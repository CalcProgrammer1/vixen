﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vixen.Sys;
using Vixen.Module.EffectEditor;
using Vixen.Module.Effect;
using Vixen.Commands.KnownDataTypes;
using VixenModules.Effect.Chase;
using VixenModules.App.ColorGradients;
using VixenModules.App.Curves;
using VixenModules.Property.RGB;

namespace VixenModules.EffectEditor.ChaseEffectEditor
{
	public partial class ChaseEffectEditorControl : UserControl, IEffectEditorControl
	{
		public ChaseEffectEditorControl()
		{
			InitializeComponent();
		}

				IEffect _targetEffect;
		public IEffect TargetEffect
		{
			get { return _targetEffect; }
			set { _targetEffect = value; }
		}

		public object[] EffectParameterValues
		{
			get
			{
				return new object[] {
					ColorHandling,
					PulseOverlap,
					DefaultLevel,
					StaticColor,
					ColorGradient,
					PulseCurve,
					ChaseMovement
				};
			}
			set
			{
				if (value.Length != 7) {
					VixenSystem.Logging.Warning("Chase effect parameters set with " + value.Length + " parameters");
					return;
				}

				ColorHandling = (ChaseColorHandling)value[0];
				PulseOverlap = (int)value[1];
				DefaultLevel = (Level)value[2];
				StaticColor = (Color)value[3];
				ColorGradient = (ColorGradient)value[4];
				PulseCurve = (Curve)value[5];
				ChaseMovement = (Curve)value[6];
			}
		}

		public ChaseColorHandling ColorHandling
		{
			get
			{
				if (radioButtonStaticColor.Checked)
					return ChaseColorHandling.StaticColor;
				if (radioButtonGradientOverWhole.Checked)
					return ChaseColorHandling.GradientThroughWholeEffect;
				if (radioButtonGradientIndividual.Checked)
					return ChaseColorHandling.GradientForEachPulse;
				if (radioButtonGradientAcrossItems.Checked)
					return ChaseColorHandling.ColorAcrossItems;

				return ChaseColorHandling.StaticColor;
			}
			set
			{
				switch (value) {
					case ChaseColorHandling.StaticColor:
						radioButtonStaticColor.Checked = true;
						break;

					case ChaseColorHandling.GradientThroughWholeEffect:
						radioButtonGradientOverWhole.Checked = true;
						break;

					case ChaseColorHandling.GradientForEachPulse:
						radioButtonGradientIndividual.Checked = true;
						break;

					case ChaseColorHandling.ColorAcrossItems:
						radioButtonGradientAcrossItems.Checked = true;
						break;
				}
			}
		}

		public int PulseOverlap
		{
			get { return (int)numericUpDownPulseTimeOverlap.Value; }
			set
			{
				if (value < (int)numericUpDownPulseTimeOverlap.Minimum)
					value = (int)numericUpDownPulseTimeOverlap.Minimum;
				if (value > (int)numericUpDownPulseTimeOverlap.Maximum)
					value = (int)numericUpDownPulseTimeOverlap.Maximum;

				numericUpDownPulseTimeOverlap.Value = value;
			}
		}

		public Level DefaultLevel
		{
			get { return levelTypeEditorControlDefaultLevel.LevelValue; }
			set { levelTypeEditorControlDefaultLevel.LevelValue = value; }
		}

		public Color StaticColor
		{
			get { return colorTypeEditorControlStaticColor.ColorValue; }
			set { colorTypeEditorControlStaticColor.ColorValue = value; }
		}

		public ColorGradient ColorGradient
		{
			get { return colorGradientTypeEditorControlGradient.ColorGradientValue; }
			set { colorGradientTypeEditorControlGradient.ColorGradientValue = value; }
		}

		public Curve PulseCurve
		{
			get { return curveTypeEditorControlEachPulse.CurveValue; }
			set { curveTypeEditorControlEachPulse.CurveValue = value; }
		}

		public Curve ChaseMovement
		{
			get { return curveTypeEditorControlChaseMovement.CurveValue; }
			set { curveTypeEditorControlChaseMovement.CurveValue = value; }
		}
	}
}