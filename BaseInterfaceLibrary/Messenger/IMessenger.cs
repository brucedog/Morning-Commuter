using System;

namespace BaseInterfaceLibrary.Messenger
{
    /// <summary>
    /// Messenger Service interface that exposes the methods to link actions.
    /// </summary>
    public interface IMessenger
    {
        /// <summary>
        /// Registers a callback method, with no parameter, to be invoked when a specific message is broadcasted.
        /// </summary>
        /// <param name="message">The message to register for.</param>
        /// <param name="callback">The callback to be called when this message is broadcasted.</param>
        void RegisterAction(string message, Action callback);

        /// <summary>
        /// Registers a callback method, with a parameter, to be invoked when a specific message is broadcasted.
        /// </summary>
        /// <param name="message">The message to register for.</param>
        /// <param name="callback">The callback to be called when this message is broadcasted.</param>
        void RegisterAction<T1>(string message, Action<T1> callback);

        void RegisterAction<T1, T2>(string message, Action<T1, T2> callback);

        void RegisterAction<T1, T2, T3>(string message, Action<T1, T2, T3> callback);

        /// <summary>
        /// Notifies all registered parties that a message is being broadcasted.
        /// </summary>
        /// <param name="message">The message to broadcast.</param>
        /// <param name="parameters">The parameters to pass together with the message.</param>
        void Notify(string message, params object[] parameters);

        /// <summary>
        /// Notifies a specific registered party that a message is being broadcasted.
        /// </summary>
        /// <param name="message">The message to broadcast.</param>
        /// <param name="target">The intended target of the message.</param>
        /// <param name="parameters">The parameters to pass together with the message.</param>
        void NotifyTarget(object target, string message, params object[] parameters);
    }
}