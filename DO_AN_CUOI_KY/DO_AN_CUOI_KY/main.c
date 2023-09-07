
#define F_CPU 8000000UL
#include <phong.h>

#define LED_PORT PORTB
#define LED_DDR DDRB

volatile uint8_t LED_index = 0;
volatile bool RUN = false;
volatile int timeCount = 0;

void KhoiTao_LED()
{
	LED_DDR = 0xFF;
	LED_PORT = 0x00;
	DDRC |= (1 << PC0);
	PORTC &= ~(1<< PC0);
}

void DieuKhienLED(int Vitri_LED, char TrangThai_LED)
{
	if(TrangThai_LED == '1')
		LED_PORT |= (1<<Vitri_LED);
	else
		LED_PORT &= ~(1<<Vitri_LED);
}
ISR(INT0_vect)
{
	RUN = true;
	PORTC |= (1 << PC0); 	
}
ISR(INT1_vect)
{
	RUN = false;
	PORTC &= ~(1 << PC0);
}
ISR(TIMER0_COMP_vect)
{
	if(RUN == true)
	{
		timeCount++;
		if(timeCount == 500)//500ms
		{
			PORTC ^= (1<<PC0);
			timeCount = 0;
		}
	}
	else
		timeCount = 0;
}

ISR(USART_RXC_vect)
{
	if(RUN == true)
	{
		uint8_t DuLieuNhan = UDR;
		DieuKhienLED(LED_index,DuLieuNhan);
		LED_index++;
		
		if (LED_index == 8 || DuLieuNhan == '\0')
			LED_index = 0;
	}
}

int main(void)
{
	ADC_Init(1,1,0);
	INT0_Init(3);
	INT1_Init(3);
	TIMER0_COMP_Init(64);
	UART_init(9600);//Baud rate :9600
	KhoiTao_LED();
	
	sei();//Global Interupt
    /* Replace with your application code */
    while (1) 
    {
		if(RUN == true)
		{
			UART_TransmitNumber(read_adc(1)*100*2.56/1023);
			_delay_ms(1000);
		}
    }
}

