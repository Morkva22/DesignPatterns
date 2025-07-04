using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Command
{
    public interface ICommand<TReturn, TGetArgs>
    {
        TReturn Execute(TGetArgs source);
    }
}