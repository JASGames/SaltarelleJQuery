// AjaxCallback.cs
// Script#/Libraries/jQuery/Core
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace jQueryApi {

    /// <summary>
    /// A callback to be invoked for an Ajax request.
    /// </summary>
    /// <param name="data">The result of the request.</param>
    public delegate void AjaxCallback(object data);

    /// <summary>
    /// A callback to be invoked for an Ajax request.
    /// </summary>
    /// <param name="data">The result of the request.</param>
    public delegate void AjaxCallback<TData>(TData data);

    /// <summary>
    /// A callback to be invoked for an Ajax request.
    /// </summary>
    /// <param name="data">The result of the request.</param>
    /// <param name="textStatus">The status of the request.</param>
    /// <param name="request">The request that was invoked.</param>
    public delegate void AjaxRequestCallback(object data, string textStatus, jQueryXmlHttpRequest request);

    /// <summary>
    /// A callback to be invoked for an Ajax request.
    /// </summary>
    /// <param name="data">The result of the request.</param>
    /// <param name="textStatus">The status of the request.</param>
    /// <param name="request">The request that was invoked.</param>
    public delegate void AjaxRequestCallback<TData>(TData data, string textStatus, jQueryDataHttpRequest<TData> request);

    /// <summary>
    /// A callback to be invoked for a failed Ajax request.
    /// </summary>
    /// <param name="request">The request that was invoked.</param>
    /// <param name="textStatus">The status of the request.</param>
    /// <param name="error">The error or exception if any.</param>
    public delegate void AjaxErrorCallback(jQueryXmlHttpRequest request, string textStatus, Exception error);

    /// <summary>
    /// A callback to be invoked for a failed Ajax request.
    /// </summary>
    /// <param name="request">The request that was invoked.</param>
    /// <param name="textStatus">The status of the request.</param>
    /// <param name="error">The error or exception if any.</param>
    public delegate void AjaxErrorCallback<TData>(jQueryDataHttpRequest<TData> request, string textStatus, Exception error);

    /// <summary>
    /// A callback to be invoked for a completed Ajax request.
    /// </summary>
    /// <param name="request">The request that was invoked.</param>
    /// <param name="textStatus">The status of the request.</param>
    public delegate void AjaxCompletedCallback(jQueryXmlHttpRequest request, string textStatus);

    /// <summary>
    /// A callback to be invoked for a completed Ajax request.
    /// </summary>
    /// <param name="request">The request that was invoked.</param>
    /// <param name="textStatus">The status of the request.</param>
    public delegate void AjaxCompletedCallback<TData>(jQueryDataHttpRequest<TData> request, string textStatus);

    /// <summary>
    /// A callback to be invoked for an Ajax request being sent.
    /// </summary>
    /// <param name="request">The request that was invoked.</param>
    public delegate void AjaxSendingCallback(jQueryXmlHttpRequest request);

    /// <summary>
    /// A callback to be invoked for an Ajax request being sent.
    /// </summary>
    /// <param name="request">The request that was invoked.</param>
    public delegate void AjaxSendingCallback<TData>(jQueryDataHttpRequest<TData> request);

    /// <summary>
    /// A function to be used to handle the raw response data of XMLHttpRequest.
    /// </summary>
    /// <param name="data">The raw data returned from the server.</param>
    /// <param name="dataType">The data type returned from the server.</param>
    public delegate object AjaxDataFilterCallback(string data, string dataType);

    /// <summary>
    /// Creates a jQueryXmlHttpRequest object.
    /// </summary>
    /// <returns>A newly created request instance.</returns>
    public delegate jQueryXmlHttpRequest XmlHttpRequestCreator();

    /// <summary>
    /// Handles ajax events.
    /// </summary>
    /// <param name="e">The event information.</param>
    /// <param name="request">The request instance.</param>
    /// <param name="options">The Ajax options associated with the request.</param>
    public delegate void AjaxEventHandler(jQueryEvent e, jQueryXmlHttpRequest request, jQueryAjaxOptions options);

    /// <summary>
    /// Handles ajax events.
    /// </summary>
    /// <param name="e">The event information.</param>
    /// <param name="request">The request instance.</param>
    /// <param name="options">The Ajax options associated with the request.</param>
    public delegate void AjaxEventHandler<TData>(jQueryEvent e, jQueryDataHttpRequest<TData> request, jQueryAjaxOptions options);

    /// <summary>
    /// Handles ajax error events.
    /// </summary>
    /// <param name="e">The event information.</param>
    /// <param name="request">The request instance.</param>
    /// <param name="options">The Ajax options associated with the request.</param>
    /// <param name="error">The error information.</param>
    public delegate void AjaxErrorEventHandler(jQueryEvent e, jQueryXmlHttpRequest request, jQueryAjaxOptions options, Exception error);

    /// <summary>
    /// Handles ajax error events.
    /// </summary>
    /// <param name="e">The event information.</param>
    /// <param name="request">The request instance.</param>
    /// <param name="options">The Ajax options associated with the request.</param>
    /// <param name="error">The error information.</param>
    public delegate void AjaxErrorEventHandler<TData>(jQueryEvent e, jQueryDataHttpRequest<TData> request, jQueryAjaxOptions options, Exception error);

	/// <summary>
	/// Delegate used for <see cref="jQuery.AjaxPrefilter"/>
	/// </summary>
	/// <param name="options">The request options.</param>
	/// <param name="originalOptions">The options as provided to the ajax method, unmodified and, thus, without defaults from ajaxSettings.</param>
	/// <param name="jqXHR">The <see cref="jQueryXmlHttpRequest"/> object of the request.</param>
	public delegate void AjaxPrefilterCallback(jQueryAjaxOptions options, jQueryAjaxOptions originalOptions, jQueryXmlHttpRequest jqXHR);
}
