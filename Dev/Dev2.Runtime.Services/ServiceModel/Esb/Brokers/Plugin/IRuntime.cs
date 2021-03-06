/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2019 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using Dev2.Common.Interfaces;
using Dev2.Common.Interfaces.Core.Graph;

namespace Dev2.Runtime.ServiceModel.Esb.Brokers.Plugin
{
    /// <summary>
    /// Interface for Plugin Invoke
    /// </summary>
    public interface IRuntime
    {
        PluginExecutionDto CreateInstance(PluginInvokeArgs constructor);
        object Run(PluginInvokeArgs setupInfo);
        IOutputDescription Test(PluginInvokeArgs setupInfo, out string serializedResult);
        IDev2MethodInfo Run(IDev2MethodInfo dev2MethodInfo, PluginExecutionDto dto, out string objectString);
    }
}
