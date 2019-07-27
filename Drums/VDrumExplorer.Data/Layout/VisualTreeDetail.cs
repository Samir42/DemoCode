﻿using System.Collections.Generic;
using VDrumExplorer.Data.Fields;

namespace VDrumExplorer.Data.Layout
{
    /// <summary>
    /// An element of the details to display when a <see cref="VisualTreeNode"/> is selected.
    /// </summary>
    public sealed class VisualTreeDetail
    {
        /// <summary>
        /// Description of this aspect of the details.
        /// </summary>
        public string Description { get; }
        
        /// <summary>
        /// A field container. May be null, in which case <see cref="DetailDescriptions"/> will not be null.
        /// </summary>
        public Container? Container { get; }
                
        /// <summary>
        /// A list of formattable descriptions. May be null, in which case <see cref="Container"/>
        /// will not be null.
        /// </summary>
        public IReadOnlyList<FormattableDescription>? DetailDescriptions { get; }

        public VisualTreeDetail(string description, Container container) =>
            (Description, Container, DetailDescriptions) = (description, container, null);

        public VisualTreeDetail(string description, IReadOnlyList<FormattableDescription> formatElements) =>
            (Description, Container, DetailDescriptions) = (description, null, formatElements);
    }
}