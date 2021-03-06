// MvxReplaceableJavaContainer.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Java.Lang;

namespace MvvmCross.Platform.Droid
{
    public class MvxReplaceableJavaContainer : Object
    {
        public object Object { get; set; }

        public override string ToString()
        {
            return Object?.ToString() ?? string.Empty;
        }
    }
}