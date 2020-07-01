using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;

namespace G1ANT.Addon.MyAddon2
{
    [Command(Name ="mynewcommand", Tooltip = "This is a demo command.")]
    class My_G1ANT_Command : Command
    {
        public My_G1ANT_Command(AbstractScripter scripter) : base(scripter)
        {

        }
        public class Arguments : CommandArguments
        {
            [Argument(Name = "user", Required = true, Tooltip = "Type text to display")]
            public TextStructure user { get; set; } = new TextStructure();
        }
        public void Execute(Arguments argu)
        {
            RobotMessageBox.Show(argu.user.Value);
        }
    }
}
