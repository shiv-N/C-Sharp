// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="Colleague.cs" Company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Behavioral_Pattern.Mediator_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Colleague is a abstract class.
    /// </summary>
    public abstract class Colleague
    {
        /// <summary>
        /// _mediator is the instance of the interface .
        /// </summary>
        protected IMediator _mediator;

        /// <summary>
        /// Colleague is a constructor that initialize the _mediotor.
        /// </summary>
        /// <param name="mediator"> IMediator mediator.</param>
        public Colleague(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}