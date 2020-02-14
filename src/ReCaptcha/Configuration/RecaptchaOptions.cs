﻿namespace GSoftware.AspNetCore.ReCaptcha.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    public class RecaptchaOptions
    {
        private ValidationFailedAction _validationFailedAction = ValidationFailedAction.BlockRequest;

        /// <summary>
        /// If set to true the remote IP will be send to Google when verifying the response token. The default is false.
        /// </summary>
        public bool UseRemoteIp { get; set; } = false;

        /// <summary>
        /// Configure the service on a global level whether it should block / short circuit the request pipeline 
        /// when the reCPATCHA response token is invalid or not. The default is <see cref="ValidationFailedAction.BlockRequest"/>.
        /// </summary>
        /// <remarks>
        /// This affects only the action filter logic of this service. This can also be set individually 
        /// for each controller or action by setting a value to <see cref="ValidateRecaptchaAttribute.ValidationFailedAction"/>,
        /// like this <code>[ValidateRecaptcha(ValidationFailedAction = ValidationFailedAction.ContinueRequest)]</code>.
        /// 
        /// The value may never be set to <see cref="ValidationFailedAction.Unspecified"/>, it will always be translated to
        /// <see cref="ValidationFailedAction.BlockRequest"/>.
        /// </remarks>
        public ValidationFailedAction ValidationFailedAction 
        {
            get => _validationFailedAction;
            set => _validationFailedAction = value == ValidationFailedAction.Unspecified ? ValidationFailedAction.BlockRequest : value;
        }
    }
}