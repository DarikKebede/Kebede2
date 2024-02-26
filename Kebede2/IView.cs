/***********************************************************************
*** NAME: Darik Kebede                                              ****
*** CLASS: CSc 346                                                  ****
*** ASSIGNMENT: 2                                                   ****
*** DUE DATE: 02/26/2024                                            ****
*** INSTRUCTOR: GAMRADT                                             ****
************************************************************************ 
*** DESCRIPTION: this class describes an interface that the Viking class must implement - satisfy the contract
***/

using System;
using System.Linq;
using System.Collections.Generic;

namespace VikingNS
{
     /*** DESCRIPTION: an interface that the Viking class must implement-satisfy the contract ***/
    public interface IView
    {
        void ViewH();
        void ViewV();
    }
}