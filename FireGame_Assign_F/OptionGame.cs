using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_Assign_F
{
   public class OptionGame
    {
        
        //when we click on start game the button will disable and the next button will be enable to work 
        public void firstOption(Button btnstart,Button btnLoad) {
            btnstart.Enabled = false;
            btnLoad.Enabled = true;
        }

        //when we click on Load bullet the button will disable and the next button will be enable to work 
        public void secndOption(Button btnLoad, Button btnSpin)
        {
            btnLoad.Enabled = false;
            btnSpin.Enabled = true;
        }

        public void ThirdOption(Button btnSpin,Button btnShoot,Button btnShootaway)
        {
            btnSpin.Enabled = false;
            btnShoot.Enabled = true;
            btnShootaway.Enabled = true;
        }
        //generate the sound of fire 
        public void Shoot() {
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(FireGame_Assign_F.Properties.Resources.fire);
            obj.Play();

        }

        //generate the sound of fire 
        public void ShootAway()
        {
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(FireGame_Assign_F.Properties.Resources.fire);
            obj.Play();

        }


    }
}
