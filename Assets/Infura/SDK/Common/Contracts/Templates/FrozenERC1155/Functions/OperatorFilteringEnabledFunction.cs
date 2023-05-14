using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.Contracts;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Truffle.Data;

namespace Truffle.Functions
{
    public partial class OperatorFilteringEnabledFunction : OperatorFilteringEnabledFunctionBase { }

    [Function("operatorFilteringEnabled", "bool")]
    public class OperatorFilteringEnabledFunctionBase : FunctionMessage
    {

    }
}
