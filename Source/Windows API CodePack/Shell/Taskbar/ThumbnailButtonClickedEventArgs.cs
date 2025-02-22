﻿// Copyright (c) Microsoft Corporation.  All rights reserved.

namespace Microsoft.WindowsAPICodePack.Taskbar
{
    /// <summary>
    /// Event args for TabbedThumbnailButton.Click event
    /// </summary>
    public class ThumbnailButtonClickedEventArgs : EventArgs
    {
        /// <summary>
        /// Creates a Event Args for the TabbedThumbnailButton.Click event
        /// </summary>
        /// <param name="windowHandle">Window handle for the control/window related to the event</param>
        /// <param name="button">Thumbnail toolbar button that was clicked</param>
        public ThumbnailButtonClickedEventArgs(IntPtr windowHandle, ThumbnailToolBarButton button)
        {
            ThumbnailButton = button;
            WindowHandle = windowHandle;
            WindowsControl = null;
        }

        /// <summary>
        /// Creates a Event Args for the TabbedThumbnailButton.Click event
        /// </summary>
        /// <param name="windowsControl">WPF Control (UIElement) related to the event</param>
        /// <param name="button">Thumbnail toolbar button that was clicked</param>
        public ThumbnailButtonClickedEventArgs(UIElement windowsControl, ThumbnailToolBarButton button)
        {
            ThumbnailButton = button;
            WindowHandle = IntPtr.Zero;
            WindowsControl = windowsControl;
        }

        /// <summary>
        /// Gets the Window handle for the specific control/window that is related to this event.
        /// </summary>
        /// <remarks>For WPF Controls (UIElement) the WindowHandle will be IntPtr.Zero. 
        /// Check the WindowsControl property to get the specific control associated with this event.</remarks>
        public IntPtr WindowHandle { get; private set; }

        /// <summary>
        /// Gets the WPF Control (UIElement) that is related to this event. This property may be null
        /// for non-WPF applications.
        /// </summary>
        public UIElement WindowsControl { get; private set; }

        /// <summary>
        /// Gets the ThumbnailToolBarButton that was clicked
        /// </summary>
        public ThumbnailToolBarButton ThumbnailButton { get; private set; }
    }
}
