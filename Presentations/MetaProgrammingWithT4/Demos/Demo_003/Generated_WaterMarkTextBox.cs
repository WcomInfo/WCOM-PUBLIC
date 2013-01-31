
// ############################################################################
// #                                                                          #
// #        ---==>  T H I S  F I L E  I S   G E N E R A T E D  <==---         #
// #                                                                          #
// # This means that any edits to the .cs file will be lost when its          #
// # regenerated. Changes should instead be applied to the corresponding      #
// # template file (.tt)                                                      #
// ############################################################################





// ReSharper disable InconsistentNaming
// ReSharper disable InvocationIsSkipped
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantAssignment
// ReSharper disable RedundantUsingDirective

namespace Demo_003
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;

    using System.Windows;
    using System.Windows.Media;

    // ------------------------------------------------------------------------
    // WaterMarkTextBox
    // ------------------------------------------------------------------------
    partial class WaterMarkTextBox
    {
        #region Uninteresting generated code
        public static readonly DependencyProperty IsWaterMarkVisibleProperty = DependencyProperty.Register (
            "IsWaterMarkVisible",
            typeof (bool),
            typeof (WaterMarkTextBox),
            new FrameworkPropertyMetadata (
                true,
                FrameworkPropertyMetadataOptions.None,
                Changed_IsWaterMarkVisible,
                Coerce_IsWaterMarkVisible          
            ));

        static void Changed_IsWaterMarkVisible (DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
        {
            var instance = dependencyObject as WaterMarkTextBox;
            if (instance != null)
            {
                var oldValue = (bool)eventArgs.OldValue;
                var newValue = (bool)eventArgs.NewValue;

                instance.Changed_IsWaterMarkVisible (oldValue, newValue);
            }
        }


        static object Coerce_IsWaterMarkVisible (DependencyObject dependencyObject, object basevalue)
        {
            var instance = dependencyObject as WaterMarkTextBox;
            if (instance == null)
            {
                return basevalue;
            }
            var oldValue = (bool)basevalue;
            var newValue = oldValue;

            instance.Coerce_IsWaterMarkVisible (oldValue, ref newValue);


            return newValue;
        }

        public static readonly DependencyProperty WaterMarkBrushProperty = DependencyProperty.Register (
            "WaterMarkBrush",
            typeof (Brush),
            typeof (WaterMarkTextBox),
            new FrameworkPropertyMetadata (
                default (Brush),
                FrameworkPropertyMetadataOptions.None,
                Changed_WaterMarkBrush,
                Coerce_WaterMarkBrush          
            ));

        static void Changed_WaterMarkBrush (DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
        {
            var instance = dependencyObject as WaterMarkTextBox;
            if (instance != null)
            {
                var oldValue = (Brush)eventArgs.OldValue;
                var newValue = (Brush)eventArgs.NewValue;

                instance.Changed_WaterMarkBrush (oldValue, newValue);
            }
        }


        static object Coerce_WaterMarkBrush (DependencyObject dependencyObject, object basevalue)
        {
            var instance = dependencyObject as WaterMarkTextBox;
            if (instance == null)
            {
                return basevalue;
            }
            var oldValue = (Brush)basevalue;
            var newValue = oldValue;

            instance.Coerce_WaterMarkBrush (oldValue, ref newValue);


            return newValue;
        }

        public static readonly DependencyProperty WaterMarkTextProperty = DependencyProperty.Register (
            "WaterMarkText",
            typeof (string),
            typeof (WaterMarkTextBox),
            new FrameworkPropertyMetadata (
                "Type text here...",
                FrameworkPropertyMetadataOptions.None,
                Changed_WaterMarkText,
                Coerce_WaterMarkText          
            ));

        static void Changed_WaterMarkText (DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
        {
            var instance = dependencyObject as WaterMarkTextBox;
            if (instance != null)
            {
                var oldValue = (string)eventArgs.OldValue;
                var newValue = (string)eventArgs.NewValue;

                instance.Changed_WaterMarkText (oldValue, newValue);
            }
        }


        static object Coerce_WaterMarkText (DependencyObject dependencyObject, object basevalue)
        {
            var instance = dependencyObject as WaterMarkTextBox;
            if (instance == null)
            {
                return basevalue;
            }
            var oldValue = (string)basevalue;
            var newValue = oldValue;

            instance.Coerce_WaterMarkText (oldValue, ref newValue);


            return newValue;
        }

        #endregion

        // --------------------------------------------------------------------
        // Constructor
        // --------------------------------------------------------------------
        public WaterMarkTextBox ()
        {
            CoerceAllProperties ();
            Constructed__WaterMarkTextBox ();
        }
        // --------------------------------------------------------------------
        partial void Constructed__WaterMarkTextBox ();
        // --------------------------------------------------------------------
        void CoerceAllProperties ()
        {
            CoerceValue (IsWaterMarkVisibleProperty);
            CoerceValue (WaterMarkBrushProperty);
            CoerceValue (WaterMarkTextProperty);
        }


        // --------------------------------------------------------------------
        // Properties
        // --------------------------------------------------------------------

           
        // --------------------------------------------------------------------
        public bool IsWaterMarkVisible
        {
            get
            {
                return (bool)GetValue (IsWaterMarkVisibleProperty);
            }
            set
            {
                if (IsWaterMarkVisible != value)
                {
                    SetValue (IsWaterMarkVisibleProperty, value);
                }
            }
        }
        // --------------------------------------------------------------------
        partial void Coerce_IsWaterMarkVisible (bool value, ref bool coercedValue);
        partial void Changed_IsWaterMarkVisible (bool oldValue, bool newValue);
        // --------------------------------------------------------------------


           
        // --------------------------------------------------------------------
        public Brush WaterMarkBrush
        {
            get
            {
                return (Brush)GetValue (WaterMarkBrushProperty);
            }
            set
            {
                if (WaterMarkBrush != value)
                {
                    SetValue (WaterMarkBrushProperty, value);
                }
            }
        }
        // --------------------------------------------------------------------
        partial void Coerce_WaterMarkBrush (Brush value, ref Brush coercedValue);
        partial void Changed_WaterMarkBrush (Brush oldValue, Brush newValue);
        // --------------------------------------------------------------------


           
        // --------------------------------------------------------------------
        public string WaterMarkText
        {
            get
            {
                return (string)GetValue (WaterMarkTextProperty);
            }
            set
            {
                if (WaterMarkText != value)
                {
                    SetValue (WaterMarkTextProperty, value);
                }
            }
        }
        // --------------------------------------------------------------------
        partial void Coerce_WaterMarkText (string value, ref string coercedValue);
        partial void Changed_WaterMarkText (string oldValue, string newValue);
        // --------------------------------------------------------------------


    }
    // ------------------------------------------------------------------------

}

