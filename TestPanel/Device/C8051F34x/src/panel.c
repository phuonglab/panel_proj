//-----------------------------------------------------------------------------
// Includes
//-----------------------------------------------------------------------------

#include <c8051f340.h>                 // SFR declarations

//-----------------------------------------------------------------------------
// Global Constants
//-----------------------------------------------------------------------------

#define SYSCLK       12000000 / 8      // SYSCLK frequency in Hz

#define BLINK_RATE   10                // Timer2 Interrupts per second


/*defeine IO for nelement*/
SBIT(nElement_A0, SFR_P2, 3);//if set nele_xx = 1 means 1
SBIT(nElement_A1, SFR_P2, 3);
SBIT(nElement_A2, SFR_P2, 3);
SBIT(nElement_E0, SFR_P2, 3);
SBIT(nElement_E1, SFR_P2, 3);

/*defeine IO for nGroup*/
SBIT(nGroup_A0, SFR_P2, 3);//if set nGroup_xx = 1 means 1
SBIT(nGroup_A1, SFR_P2, 3);
SBIT(nGroup_A2, SFR_P2, 3);
SBIT(nGroup_E0, SFR_P2, 3);
SBIT(nGroup_E1, SFR_P2, 3);


//-----------------------------------------------------------------------------
// Function Prototypes
//-----------------------------------------------------------------------------

U8 sel_led_active(U8 nGruop, U8 nElement);
U8 get_led_active(U8 nsel);


//-----------------------------------------------------------------------------
// Set active led
//-----------------------------------------------------------------------------
U8 sel_led_active(U8 nGruop, U8 nElement)
{
	U8 ret, tmp;
	
	if((nGruop >8) || (nElement > 8))
	{
		ret = 0xFF;
		return ret;
	}
	
	/*---------------------*/
	/* for nGroup			*/ 
	/*---------------------*/
	
	tmp = (U8)(nGruop & 0x07);
	
	/*config address bit A0->A2*/
	nGroup_A0 = (tmp >> 0) & 0x01;
	nGroup_A1 = (tmp >> 1) & 0x01;
	nGroup_A2 = (tmp >> 2) & 0x01;
	
	/*config Enable bits A0->A2*/
	nGroup_E0 = 0;
	nGroup_E1 = 0;
	
	/*---------------------*/
	/* for nElement			*/ 
	/*---------------------*/
	
	tmp = (U8)(nElement & 0x07);
	
	/*config address bit A0->A2*/
	nElement_A0 = tmp & 0x01;
	nElement_A1 = (tmp >> 1) & 0x01;
	nElement_A2 = (tmp >> 2) & 0x01;
	
	/*config Enable bits A0->A2*/
	nElement_E0 = 0;
	nElement_E1 = 0;
	
	ret = 0;
	
	return (ret);
}

//-----------------------------------------------------------------------------
// Set active leds
//-----------------------------------------------------------------------------
U8 get_led_active(U8 nsel)
{
	U8 ret;
	
	switch(nsel)
	{
		case 0:
			ret = (Px & 0x) ? 1: 0;
			break;
		default:
			break;
	}
}

//-----------------------------------------------------------------------------
// get X_value
//-----------------------------------------------------------------------------
//
// Return Value : None
// Parameters   : None
//
// This function initializes the system clock to (12 Mhz / 8)
//
//-----------------------------------------------------------------------------

U8 x_raw_data[8];

U8 get_x(void)
{
	U8 ngroup, nelement, tmp, ret;
	
	for(ngroup = 0; n < 8; ngroup++)
	{
		for(nelement = 0; nelement < 8; nelement++)
		{
			sel_led_active(ngroup, nelement);
			tmp = get_led_active(0);
			pritnf("raw data at group:%d element:%d data: \r\n", ngroup, nelement, tmp);
			x_raw_data[ngroup] |= (tmp & 0x01) << nelement;
		}
		
		pritnf("data of group:%d : %d\r\n", ngroup, x_raw_data[ngroup]);
	}
	
	/*calculate x_value*/
}

//-----------------------------------------------------------------------------
// PORT_Init
//-----------------------------------------------------------------------------
//
// Return Value : None
// Parameters   : None
//
// This function configures the crossbar and GPIO ports.
//
// P2.2   digital   push-pull     LED1
//-----------------------------------------------------------------------------
void set_led_port (void)
{
   XBR0     = 0x00;                    // No digital peripherals selected
   XBR1     = 0x40;                    // Enable crossbar and weak pull-ups
   P2MDOUT |= 0x04;                    // Enable LED as a push-pull output
}


//-----------------------------------------------------------------------------
// End Of File
//-----------------------------------------------------------------------------
