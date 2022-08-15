using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Quartz;

namespace MaterialScale2MES
{
    public class EmailJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            MessageBox.Show("Trigger");//Replace with send mail logic ?? // should check on if have data but shudown the program early ?
            return null;
        }
    }
}
