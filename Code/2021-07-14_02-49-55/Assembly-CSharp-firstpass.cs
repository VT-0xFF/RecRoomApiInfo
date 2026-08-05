using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RootMotion.FinalIK;
using SA.Foundation.PropertyDrawers.Attributes;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class SA_PD_EditorIcons
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public enum IconType
	{
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		GameObject,
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		Favorite,
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		Prefab,
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		GameManager,
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		Dragdot,
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		DragdotActive,
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		DragdotDimmed,
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		Dropdown,
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		d_winbtn_mac_close,
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		d_winbtn_mac_close_a,
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		d_winbtn_mac_close_h,
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		d_winbtn_mac_inact,
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		d_winbtn_mac_max,
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		d_winbtn_mac_max_h,
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		d_winbtn_mac_min,
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		d_winbtn_mac_min_h,
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		d_winbtn_win_close,
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		DefaultAsset,
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		DllScript,
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		DistanceJoint2D,
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		FilterByLabel,
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		FilterByType,
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		Fixedjoint,
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		FlareLayer,
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		FrictionJoint2D,
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		GUIText,
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		HingeJoint2D,
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		Image,
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		LightProbeProxyVolume,
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		LightProbeGroup,
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		LineRenderer,
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		LayoutElement,
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		LensFlare
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Dictionary<IconType, string> m_internalIcons;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x381D3D0", Offset = "0x381C5D0", VA = "0x18381D3D0")]
	public static string GetInternalStringPathOfEnumValue(IconType type)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum SA_PD_MessageType
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Info,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Error
}
namespace SA.Foundation.EditorStylesCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class SA_ESC_PropertyDrawerExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[Space]
		[Multiline]
		[SerializeField]
		[Header("Unity Default Property Drawers")]
		[Space(10f)]
		private string m_multilineString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[TextArea]
		public string m_textAreaString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[Range(0f, 100f)]
		private int m_intRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_floatRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		[Tooltip("Health value between 0 and 100.")]
		private float m_hoverMouseToSeeTooltip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[Space]
		[Header("Sliders")]
		[Space(10f)]
		public float m_simpleSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SA_PD_MinMaxSlider(0f, 3f, 255f, 0f, 0f)]
		public Vector2 m_MinMaxSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Header("Help Boxes with text message")]
		[SA_PD_HelpBox(SA_PD_MessageType.Info)]
		public string myHelpBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SA_PD_HelpBox(SA_PD_MessageType.Warning)]
		public string myString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Space]
		[Space]
		[SA_PD_ThingInsertionDecorator]
		[SA_PD_PRInsertionDecorator]
		[SA_PD_StandartInsertionDecorator]
		[Space]
		[Space]
		[Header("Help Boxes Decorators")]
		[Space(10f)]
		[SA_PD_HelpboxDecorator(SA_PD_MessageType.Info, "Pre-defined text")]
		[SA_PD_HelpboxDecorator(SA_PD_MessageType.None, "")]
		[Header("Insertions")]
		[Space(10f)]
		[Header("Headers")]
		[Space(10f)]
		[SA_PD_HeaderDecorator("Indent Header")]
		[Header("Indent level")]
		[Space(10f)]
		[SA_PD_IndentLevel(1)]
		public string indentLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SA_PD_IndentLevel(2)]
		public string indentLevel1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SA_PD_IndentLevel(0)]
		public string indentLevel2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Space]
		[Header("Conditional Hide / Show fields")]
		[Space(10f)]
		public bool showBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public bool isExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public AnimationCurve curve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Space]
		[Header("Conditional Disable / Enable fields")]
		[Space(10f)]
		public bool enableBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SA_PD_Conditional("enableBelowSettings")]
		public bool firstSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SA_PD_Conditional("enableBelowSettings")]
		public float secondSettigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Space]
		[Header("Label with Icon")]
		[Space(10f)]
		[SA_PD_LabelWithIcon("Plugins/StansAssets/Support2018/Modules/Editor/EditorStylesCollection/Resources/Icons/gameObjectIcon.png")]
		public string myLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SA_PD_LabelWithIcon(SA_PD_EditorIcons.IconType.Light)]
		public string favoriteLabel;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x381D270", Offset = "0x381C470", VA = "0x18381D270")]
		public SA_ESC_PropertyDrawerExample()
		{
		}
	}
}
namespace SA.Foundation.PropertyDrawers.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_ConditionalAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string m_conditionalSourceField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool m_hideInInspector;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string ConditionalSourceField
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3F6AE0", Offset = "0x3F5CE0", VA = "0x1803F6AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x381D300", Offset = "0x381C500", VA = "0x18381D300")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x381D360", Offset = "0x381C560", VA = "0x18381D360")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField, bool hideInInspector)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_HelpBoxAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3F1470", Offset = "0x3F0670", VA = "0x1803F1470")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x381D8E0", Offset = "0x381CAE0", VA = "0x18381D8E0")]
		public SA_PD_HelpBoxAttribute(SA_PD_MessageType type)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_IndentLevelAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int m_indentLevel;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int IndentLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3F1470", Offset = "0x3F0670", VA = "0x1803F1470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x381D8E0", Offset = "0x381CAE0", VA = "0x18381D8E0")]
		public SA_PD_IndentLevelAttribute(int indentLevel)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_LabelWithIconAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private string m_iconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private string m_internalIconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private SA_PD_EditorIcons.IconType m_iconType;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string IconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x3F1310", Offset = "0x3F0510", VA = "0x1803F1310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x381D950", Offset = "0x381CB50", VA = "0x18381D950")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x381D9C0", Offset = "0x381CBC0", VA = "0x18381D9C0")]
		public SA_PD_LabelWithIconAttribute(SA_PD_EditorIcons.IconType icon)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_MinMaxSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x921DC0", Offset = "0x920FC0", VA = "0x180921DC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x921B10", Offset = "0x920D10", VA = "0x180921B10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7BB740", Offset = "0x7BA940", VA = "0x1807BB740")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x381DB40", Offset = "0x381CD40", VA = "0x18381DB40")]
		public SA_PD_MinMaxSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_SimpleSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x921DC0", Offset = "0x920FC0", VA = "0x180921DC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x921B10", Offset = "0x920D10", VA = "0x180921B10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7BB740", Offset = "0x7BA940", VA = "0x1807BB740")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x381DB40", Offset = "0x381CD40", VA = "0x18381DB40")]
		public SA_PD_SimpleSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class SA_PD_HeaderDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string m_text;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x915330", Offset = "0x914530", VA = "0x180915330")]
		public SA_PD_HeaderDecoratorAttribute(string text)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_HelpboxDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string m_message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x42DE30", Offset = "0x42D030", VA = "0x18042DE30")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x381D910", Offset = "0x381CB10", VA = "0x18381D910")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x879010", Offset = "0x878210", VA = "0x180879010")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x879010", Offset = "0x878210", VA = "0x180879010")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x879010", Offset = "0x878210", VA = "0x180879010")]
		public SA_PD_ThingInsertionDecoratorAttribute()
		{
		}
	}
}
namespace RootMotion
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		public enum Mode
		{
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			AnimationClips,
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			AnimationStates,
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			PlayableDirector,
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			Realtime
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		[Range(1f, 90f)]
		public int frameRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		[Range(0f, 0.1f)]
		public float keyReductionError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Tooltip("Sets the baked animation clip to loop time and matches the last frame keys with the first. Note that when overwriting a previously baked clip, AnimationClipSettings will be copied from the existing clip.")]
		public bool loop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[HideInInspector]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[HideInInspector]
		public PlayableDirector director;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool isBaking
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x44A940", Offset = "0x449B40", VA = "0x18044A940")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x44A9B0", Offset = "0x449BB0", VA = "0x18044A9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float bakingProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x10FFCC0", Offset = "0x10FEEC0", VA = "0x1810FFCC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2A99AE0", Offset = "0x2A98CE0", VA = "0x182A99AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected float clipLength
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8E56E0", Offset = "0x8E48E0", VA = "0x1808E56E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x894290", Offset = "0x893490", VA = "0x180894290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2A999D0", Offset = "0x2A98BD0", VA = "0x182A999D0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A99990", Offset = "0x2A98B90", VA = "0x182A99990")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A99A10", Offset = "0x2A98C10", VA = "0x182A99A10")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A99950", Offset = "0x2A98B50", VA = "0x182A99950")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract Transform GetCharacterRoot();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void OnStartBaking();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void OnSetLoopFrame(float time);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00")]
		public void BakeClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00")]
		public void StartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00")]
		public void StopBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2A99A50", Offset = "0x2A98C50", VA = "0x182A99A50")]
		protected Baker()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class GenericBaker : Baker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private BakerTransform[] children;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private BakerTransform rootChild;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int rootChildIndex;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x29EE020", Offset = "0x29ED220", VA = "0x1829EE020")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x59BAC0", Offset = "0x59ACC0", VA = "0x18059BAC0", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x29EE6D0", Offset = "0x29ED8D0", VA = "0x1829EE6D0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x29EE630", Offset = "0x29ED830", VA = "0x1829EE630", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x29EE4F0", Offset = "0x29ED6F0", VA = "0x1829EE4F0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x29EE590", Offset = "0x29ED790", VA = "0x1829EE590", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x29EE410", Offset = "0x29ED610", VA = "0x1829EE410")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x29EE330", Offset = "0x29ED530", VA = "0x1829EE330")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x29EE830", Offset = "0x29EDA30", VA = "0x1829EE830")]
		public GenericBaker()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class TQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Vector3 t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public Quaternion q;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2A01200", Offset = "0x2A00400", VA = "0x182A01200")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AvatarUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2A95A00", Offset = "0x2A94C00", VA = "0x182A95A00")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2A95270", Offset = "0x2A94470", VA = "0x182A95270")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2A95C20", Offset = "0x2A94E20", VA = "0x182A95C20")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public AvatarUtility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class BakerUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2A99610", Offset = "0x2A98810", VA = "0x182A99610")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2A99090", Offset = "0x2A98290", VA = "0x182A99090")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2A99650", Offset = "0x2A98850", VA = "0x182A99650")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2A98E00", Offset = "0x2A98000", VA = "0x182A98E00")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class BakerHumanoidQT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private string Qx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private string Qy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private string Qz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private string Qw;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string Tx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private string Ty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private string Tz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AnimationCurve rotX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AnimationCurve rotY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AnimationCurve rotZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AnimationCurve rotW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AnimationCurve posX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AnimationCurve posY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AnimationCurve posZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private AvatarIKGoal goal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Quaternion lastQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool lastQSet;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2A97560", Offset = "0x2A96760", VA = "0x182A97560")]
		public BakerHumanoidQT(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2A97450", Offset = "0x2A96650", VA = "0x182A97450")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2A968A0", Offset = "0x2A95AA0", VA = "0x182A968A0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2A96E70", Offset = "0x2A96070", VA = "0x182A96E70")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2A97270", Offset = "0x2A96470", VA = "0x182A97270")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2A96740", Offset = "0x2A95940", VA = "0x182A96740")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2A973C0", Offset = "0x2A965C0", VA = "0x182A973C0")]
		public void SetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2A966B0", Offset = "0x2A958B0", VA = "0x182A966B0")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2A967E0", Offset = "0x2A959E0", VA = "0x182A967E0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2A969E0", Offset = "0x2A95BE0", VA = "0x182A969E0")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class BakerMuscle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AnimationCurve curve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int muscleIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2A97EE0", Offset = "0x2A970E0", VA = "0x182A97EE0")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2A97650", Offset = "0x2A96850", VA = "0x182A97650")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2A967E0", Offset = "0x2A959E0", VA = "0x182A967E0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2A97CE0", Offset = "0x2A96EE0", VA = "0x182A97CE0")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2A97C90", Offset = "0x2A96E90", VA = "0x182A97C90")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2A97E80", Offset = "0x2A97080", VA = "0x182A97E80")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2A97ED0", Offset = "0x2A970D0", VA = "0x182A97ED0")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class BakerTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AnimationCurve posX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AnimationCurve posY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AnimationCurve posZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AnimationCurve rotX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AnimationCurve rotY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AnimationCurve rotZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AnimationCurve rotW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private string relativePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool recordPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool isRootNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private Quaternion relativeRotation;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2A98CA0", Offset = "0x2A97EA0", VA = "0x182A98CA0")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2A98C80", Offset = "0x2A97E80", VA = "0x182A98C80")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2A98740", Offset = "0x2A97940", VA = "0x182A98740")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2A98250", Offset = "0x2A97450", VA = "0x182A98250")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2A98640", Offset = "0x2A97840", VA = "0x182A98640")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2A984C0", Offset = "0x2A976C0", VA = "0x182A984C0")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2A989D0", Offset = "0x2A97BD0", VA = "0x182A989D0")]
		public void SetKeyframes(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2A97F80", Offset = "0x2A97180", VA = "0x182A97F80")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class HumanoidBaker : Baker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(1f, 9f)]
		public int muscleFrameRateDiv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private BakerMuscle[] bakerMuscles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private BakerHumanoidQT rootQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private BakerHumanoidQT leftFootQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private BakerHumanoidQT rightFootQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private BakerHumanoidQT leftHandQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private BakerHumanoidQT rightHandQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float[] muscles;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private HumanPose pose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private HumanPoseHandler handler;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private Vector3 bodyPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Quaternion bodyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int mN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Quaternion lastBodyRotation;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x29EF7B0", Offset = "0x29EE9B0", VA = "0x1829EF7B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xD89690", Offset = "0xD88890", VA = "0x180D89690", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x29F04E0", Offset = "0x29EF6E0", VA = "0x1829F04E0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x29F03C0", Offset = "0x29EF5C0", VA = "0x1829F03C0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x29EFBE0", Offset = "0x29EEDE0", VA = "0x1829EFBE0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x29EFE60", Offset = "0x29EF060", VA = "0x1829EFE60", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x29F0630", Offset = "0x29EF830", VA = "0x1829F0630")]
		private void UpdateHumanPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x29F0750", Offset = "0x29EF950", VA = "0x1829F0750")]
		public HumanoidBaker()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public enum UpdateMode
		{
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x40005F8")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			FixedLateUpdate
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Transform rotationSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public UpdateMode updateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public bool lockCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Header("Position")]
		public bool smoothFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Vector3 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float followSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float yMinLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public float yMaxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool rotateAlways;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool rotateOnLeftButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public bool rotateOnRightButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool rotateOnMiddleButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Header("Distance")]
		public float distance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public float zoomSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public float zoomSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float blockingRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public float blockingSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public float blockingOriginOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private Vector3 targetDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Vector3 smoothPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private Camera cam;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool fixedFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private float fixedDeltaTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private Quaternion r;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Vector3 lastUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float blockedDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float blockedDistanceV;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float x
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9F0C30", Offset = "0x9EFE30", VA = "0x1809F0C30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9F0C40", Offset = "0x9EFE40", VA = "0x1809F0C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float y
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1339AD0", Offset = "0x1338CD0", VA = "0x181339AD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x163F710", Offset = "0x163E910", VA = "0x18163F710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float distanceTarget
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x15DBD70", Offset = "0x15DAF70", VA = "0x1815DBD70")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2215220", Offset = "0x2214420", VA = "0x182215220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float zoomAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2AA45F0", Offset = "0x2AA37F0", VA = "0x182AA45F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3970", Offset = "0x2AA2B70", VA = "0x182AA3970")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA39B0", Offset = "0x2AA2BB0", VA = "0x182AA39B0")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA36A0", Offset = "0x2AA28A0", VA = "0x182AA36A0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4490", Offset = "0x2AA3690", VA = "0x182AA4490", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2AA38A0", Offset = "0x2AA2AA0", VA = "0x182AA38A0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3900", Offset = "0x2AA2B00", VA = "0x182AA3900", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2AA39C0", Offset = "0x2AA2BC0", VA = "0x182AA39C0")]
		public void UpdateInput()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3C00", Offset = "0x2AA2E00", VA = "0x182AA3C00")]
		public void UpdateTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3C30", Offset = "0x2AA2E30", VA = "0x182AA3C30")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3800", Offset = "0x2AA2A00", VA = "0x182AA3800")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2AA44C0", Offset = "0x2AA36C0", VA = "0x182AA44C0")]
		public CameraController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public float rotationSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public float yMinLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float yMaxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private float x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private float y;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3360", Offset = "0x2AA2560", VA = "0x182AA3360")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3450", Offset = "0x2AA2650", VA = "0x182AA3450")]
		public void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA33B0", Offset = "0x2AA25B0", VA = "0x182AA33B0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3680", Offset = "0x2AA2880", VA = "0x182AA3680")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum Axis
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		X,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Z
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AxisTools
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2A965E0", Offset = "0x2A957E0", VA = "0x182A965E0")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2A96520", Offset = "0x2A95720", VA = "0x182A96520")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2A95DC0", Offset = "0x2A94FC0", VA = "0x182A95DC0")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2A95C50", Offset = "0x2A94E50", VA = "0x182A95C50")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2A963F0", Offset = "0x2A955F0", VA = "0x182A963F0")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2A95FC0", Offset = "0x2A951C0", VA = "0x182A95FC0")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2A96040", Offset = "0x2A95240", VA = "0x182A96040")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		public class LimbOrientation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005FA")]
			public Vector3 upperBoneForwardAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			public Vector3 lowerBoneForwardAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			public Vector3 lastBoneLeftAxis;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFB70", Offset = "0x2AAED70", VA = "0x182AAFB70")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public LimbOrientation leftArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public LimbOrientation rightArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public LimbOrientation leftLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LimbOrientation rightLeg;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static BipedLimbOrientations UMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x2A9A6D0", Offset = "0x2A998D0", VA = "0x182A9A6D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static BipedLimbOrientations MaxBiped
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x2A9A3D0", Offset = "0x2A995D0", VA = "0x182A9A3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x429C70", Offset = "0x428E70", VA = "0x180429C70")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class BipedNaming
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		public enum BoneType
		{
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			Unassigned,
			[Cpp2IlInjected.Token(Token = "0x40005FF")]
			Spine,
			[Cpp2IlInjected.Token(Token = "0x4000600")]
			Head,
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			Arm,
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			Leg,
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			Tail,
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			Eye
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public enum BoneSide
		{
			[Cpp2IlInjected.Token(Token = "0x4000606")]
			Center,
			[Cpp2IlInjected.Token(Token = "0x4000607")]
			Left,
			[Cpp2IlInjected.Token(Token = "0x4000608")]
			Right
		}

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static string[] typeLeft;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static string[] typeRight;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public static string[] typeSpine;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static string[] typeHead;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public static string[] typeArm;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public static string[] typeLeg;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static string[] typeTail;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static string[] typeEye;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static string[] typeExclude;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static string[] typeExcludeSpine;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static string[] typeExcludeHead;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static string[] typeExcludeArm;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static string[] typeExcludeLeg;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static string[] typeExcludeTail;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static string[] typeExcludeEye;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static string[] pelvis;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static string[] hand;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static string[] foot;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B5F0", Offset = "0x2A9A7F0", VA = "0x182A9B5F0")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B2B0", Offset = "0x2A9A4B0", VA = "0x182A9B2B0")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B430", Offset = "0x2A9A630", VA = "0x182A9B430")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B770", Offset = "0x2A9A970", VA = "0x182A9B770")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B820", Offset = "0x2A9AA20", VA = "0x182A9B820")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9AD00", Offset = "0x2A99F00", VA = "0x182A9AD00")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A9D0", Offset = "0x2A99BD0", VA = "0x182A9A9D0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B220", Offset = "0x2A9A420", VA = "0x182A9B220")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EAD0", Offset = "0x2A9DCD0", VA = "0x182A9EAD0")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2A9ECF0", Offset = "0x2A9DEF0", VA = "0x182A9ECF0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EE60", Offset = "0x2A9E060", VA = "0x182A9EE60")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EA10", Offset = "0x2A9DC10", VA = "0x182A9EA10")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E890", Offset = "0x2A9DA90", VA = "0x182A9E890")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EC30", Offset = "0x2A9DE30", VA = "0x182A9EC30")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EF20", Offset = "0x2A9E120", VA = "0x182A9EF20")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E950", Offset = "0x2A9DB50", VA = "0x182A9E950")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EFE0", Offset = "0x2A9E1E0", VA = "0x182A9EFE0")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F170", Offset = "0x2A9E370", VA = "0x182A9F170")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E7A0", Offset = "0x2A9D9A0", VA = "0x182A9E7A0")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F0B0", Offset = "0x2A9E2B0", VA = "0x182A9F0B0")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B950", Offset = "0x2A9AB50", VA = "0x182A9B950")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E830", Offset = "0x2A9DA30", VA = "0x182A9E830")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F050", Offset = "0x2A9E250", VA = "0x182A9F050")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BipedReferences
	{
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public struct AutoDetectParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000609")]
			public bool legsParentInSpine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x400060A")]
			public bool includeEyes;

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public static AutoDetectParams Default
			{
				[Cpp2IlInjected.Token(Token = "0x600063F")]
				[Cpp2IlInjected.Address(RVA = "0x2A95260", Offset = "0x2A94460", VA = "0x182A95260")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x2A95250", Offset = "0x2A94450", VA = "0x182A95250")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Transform root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Transform pelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Transform leftThigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Transform leftCalf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Transform leftFoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Transform rightThigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Transform rightCalf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Transform rightFoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Transform leftUpperArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Transform leftForearm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Transform leftHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Transform rightUpperArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Transform rightForearm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Transform rightHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Transform head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Transform[] spine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Transform[] eyes;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public virtual bool isFilled
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2AA2F20", Offset = "0x2AA2120", VA = "0x182AA2F20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool isEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1026770", Offset = "0x1025970", VA = "0x181026770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1530", Offset = "0x2AA0730", VA = "0x182AA1530", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FE80", Offset = "0x2A9F080", VA = "0x182A9FE80", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FAD0", Offset = "0x2A9ECD0", VA = "0x182A9FAD0")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0450", Offset = "0x2A9F650", VA = "0x182AA0450")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F5D0", Offset = "0x2A9E7D0", VA = "0x182A9F5D0")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2810", Offset = "0x2AA1A10", VA = "0x182AA2810")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2950", Offset = "0x2AA1B50", VA = "0x182AA2950")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA19B0", Offset = "0x2AA0BB0", VA = "0x182AA19B0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F260", Offset = "0x2A9E460", VA = "0x182A9F260")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F440", Offset = "0x2A9E640", VA = "0x182A9F440")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0310", Offset = "0x2A9F510", VA = "0x182AA0310")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F360", Offset = "0x2A9E560", VA = "0x182A9F360")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1AA0", Offset = "0x2AA0CA0", VA = "0x182AA1AA0")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA20D0", Offset = "0x2AA12D0", VA = "0x182AA20D0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2A40", Offset = "0x2AA1C40", VA = "0x182AA2A40")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D40", Offset = "0x3F4F40", VA = "0x1803F5D40")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0FA0", Offset = "0x2AA01A0", VA = "0x182AA0FA0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D40", Offset = "0x3F4F40", VA = "0x1803F5D40")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA24B0", Offset = "0x2AA16B0", VA = "0x182AA24B0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1190", Offset = "0x2AA0390", VA = "0x182AA1190")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1410", Offset = "0x2AA0610", VA = "0x182AA1410")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2EC0", Offset = "0x2AA20C0", VA = "0x182AA2EC0")]
		public BipedReferences()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class Comments : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[Multiline]
		public string text;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public Comments()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA5A0", Offset = "0x2AA97A0", VA = "0x182AAA5A0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA650", Offset = "0x2AA9850", VA = "0x182AAA650")]
		public DemoGUIMessage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class Hierarchy
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x29EF390", Offset = "0x29EE590", VA = "0x1829EF390")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x29EEC60", Offset = "0x29EDE60", VA = "0x1829EEC60")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x29EF430", Offset = "0x29EE630", VA = "0x1829EF430")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x29EEB50", Offset = "0x29EDD50", VA = "0x1829EEB50")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x29EE890", Offset = "0x29EDA90", VA = "0x1829EE890")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x29EED90", Offset = "0x29EDF90", VA = "0x1829EED90")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x29EF200", Offset = "0x29EE400", VA = "0x1829EF200")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x29EF050", Offset = "0x29EE250", VA = "0x1829EF050")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x29EEEB0", Offset = "0x29EE0B0", VA = "0x1829EEEB0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x29EF5A0", Offset = "0x29EE7A0", VA = "0x1829EF5A0")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public Hierarchy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class InspectorComment : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public string color;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x29F07F0", Offset = "0x29EF9F0", VA = "0x1829F07F0")]
		public InspectorComment(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x29F0850", Offset = "0x29EFA50", VA = "0x1829F0850")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum InterpolationMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		InOutCubic,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		InOutQuintic,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		InOutSine,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		InQuintic,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		InQuartic,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		InCubic,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		InQuadratic,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		InElastic,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		InElasticSmall,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		InElasticBig,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		InSine,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		InBack,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		OutQuintic,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		OutQuartic,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		OutCubic,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		OutInCubic,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		OutInQuartic,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		OutElastic,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		OutElasticSmall,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		OutElasticBig,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		OutSine,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		OutBack,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		OutBackCubic,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		OutBackQuartic,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		BackInCubic,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		BackInQuartic
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class Interp
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x29F0D20", Offset = "0x29EFF20", VA = "0x1829F0D20")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x29F1E30", Offset = "0x29F1030", VA = "0x1829F1E30")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x29F1850", Offset = "0x29F0A50", VA = "0x1829F1850")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x29F1950", Offset = "0x29F0B50", VA = "0x1829F1950")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x29F1630", Offset = "0x29F0830", VA = "0x1829F1630")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x29F1660", Offset = "0x29F0860", VA = "0x1829F1660")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x29F1790", Offset = "0x29F0990", VA = "0x1829F1790")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x29F1770", Offset = "0x29F0970", VA = "0x1829F1770")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x29F1450", Offset = "0x29F0650", VA = "0x1829F1450")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x29F1760", Offset = "0x29F0960", VA = "0x1829F1760")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x29F1D30", Offset = "0x29F0F30", VA = "0x1829F1D30")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x29F1CD0", Offset = "0x29F0ED0", VA = "0x1829F1CD0")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x29F1A30", Offset = "0x29F0C30", VA = "0x1829F1A30")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x29F1C50", Offset = "0x29F0E50", VA = "0x1829F1C50")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x29F1C90", Offset = "0x29F0E90", VA = "0x1829F1C90")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x29F0CB0", Offset = "0x29EFEB0", VA = "0x1829F0CB0")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x29F0CE0", Offset = "0x29EFEE0", VA = "0x1829F0CE0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x29F1960", Offset = "0x29F0B60", VA = "0x1829F1960")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x29F19A0", Offset = "0x29F0BA0", VA = "0x1829F19A0")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x29F1AE0", Offset = "0x29F0CE0", VA = "0x1829F1AE0")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x29F1A70", Offset = "0x29F0C70", VA = "0x1829F1A70")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x29F14D0", Offset = "0x29F06D0", VA = "0x1829F14D0")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x29F1470", Offset = "0x29F0670", VA = "0x1829F1470")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x29F17B0", Offset = "0x29F09B0", VA = "0x1829F17B0")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x29F1DA0", Offset = "0x29F0FA0", VA = "0x1829F1DA0")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x29F16B0", Offset = "0x29F08B0", VA = "0x1829F16B0")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x29F1530", Offset = "0x29F0730", VA = "0x1829F1530")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x29F1B50", Offset = "0x29F0D50", VA = "0x1829F1B50")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x29F1420", Offset = "0x29F0620", VA = "0x1829F1420")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x29F19F0", Offset = "0x29F0BF0", VA = "0x1829F19F0")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public Interp()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class LargeHeader : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public string color;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x29F1FC0", Offset = "0x29F11C0", VA = "0x1829F1FC0")]
		public LargeHeader(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x29F1F60", Offset = "0x29F1160", VA = "0x1829F1F60")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class LayerMaskExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x29F2060", Offset = "0x29F1260", VA = "0x1829F2060")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x29F20A0", Offset = "0x29F12A0", VA = "0x1829F20A0")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x29F20B0", Offset = "0x29F12B0", VA = "0x1829F20B0")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x29F2510", Offset = "0x29F1710", VA = "0x1829F2510")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x29F20B0", Offset = "0x29F12B0", VA = "0x1829F20B0")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x29F2130", Offset = "0x29F1330", VA = "0x1829F2130")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x29F2020", Offset = "0x29F1220", VA = "0x1829F2020")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x29F25B0", Offset = "0x29F17B0", VA = "0x1829F25B0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x29F2150", Offset = "0x29F1350", VA = "0x1829F2150")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x29F2230", Offset = "0x29F1430", VA = "0x1829F2230")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x29F22F0", Offset = "0x29F14F0", VA = "0x1829F22F0")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x29F2410", Offset = "0x29F1610", VA = "0x1829F2410")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class QuaTools
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x29F5F80", Offset = "0x29F5180", VA = "0x1829F5F80")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x29F5D30", Offset = "0x29F4F30", VA = "0x1829F5D30")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x29F5740", Offset = "0x29F4940", VA = "0x1829F5740")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x29F5E30", Offset = "0x29F5030", VA = "0x1829F5E30")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x29F5BE0", Offset = "0x29F4DE0", VA = "0x1829F5BE0")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x29F5960", Offset = "0x29F4B60", VA = "0x1829F5960")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x29F6070", Offset = "0x29F5270", VA = "0x1829F6070")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x29F6470", Offset = "0x29F5670", VA = "0x1829F6470")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x29F6140", Offset = "0x29F5340", VA = "0x1829F6140")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x29F6540", Offset = "0x29F5740", VA = "0x1829F6540")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x29F5150", Offset = "0x29F4350", VA = "0x1829F5150")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x29F63A0", Offset = "0x29F55A0", VA = "0x1829F63A0")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x29F5300", Offset = "0x29F4500", VA = "0x1829F5300")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x29F5420", Offset = "0x29F4620", VA = "0x1829F5420")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x29F4EC0", Offset = "0x29F40C0", VA = "0x1829F4EC0")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x29F4CE0", Offset = "0x29F3EE0", VA = "0x1829F4CE0")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x29F6230", Offset = "0x29F5430", VA = "0x1829F6230")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x29F6680", Offset = "0x29F5880", VA = "0x1829F6680")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x29F6630", Offset = "0x29F5830", VA = "0x1829F6630")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private static T sInstance;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static T instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8CA180", Offset = "0x8C9380", VA = "0x1808CA180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x226FE30", Offset = "0x226F030", VA = "0x18226FE30", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2214540", Offset = "0x2213740", VA = "0x182214540")]
		protected Singleton()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class SolverManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private Animation legacy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool updateFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool componentInitiated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool skipSolverUpdate;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool animatePhysics
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2A01070", Offset = "0x2A00270", VA = "0x182A01070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool isAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2A01150", Offset = "0x2A00350", VA = "0x182A01150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2A00CD0", Offset = "0x29FFED0", VA = "0x182A00CD0")]
		public void Disable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2A00F90", Offset = "0x2A00190", VA = "0x182A00F90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2A00EF0", Offset = "0x2A000F0", VA = "0x182A00EF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2A00EF0", Offset = "0x2A000F0", VA = "0x182A00EF0")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2A01030", Offset = "0x2A00230", VA = "0x182A01030")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2A00D50", Offset = "0x29FFF50", VA = "0x182A00D50")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2A00F40", Offset = "0x2A00140", VA = "0x182A00F40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2A00FF0", Offset = "0x2A001F0", VA = "0x182A00FF0")]
		public void UpdateSolverExternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9852E0", Offset = "0x9844E0", VA = "0x1809852E0")]
		public SolverManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GameObject target;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2A01380", Offset = "0x2A00580", VA = "0x182A01380")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2A014C0", Offset = "0x2A006C0", VA = "0x182A014C0")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2A01420", Offset = "0x2A00620", VA = "0x182A01420")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class V2Tools
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2507A80", Offset = "0x2506C80", VA = "0x182507A80")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2A02F50", Offset = "0x2A02150", VA = "0x182A02F50")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2A02E90", Offset = "0x2A02090", VA = "0x182A02E90")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2A02FF0", Offset = "0x2A021F0", VA = "0x182A02FF0")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2A03190", Offset = "0x2A02390", VA = "0x182A03190")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class V3Tools
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x381EC00", Offset = "0x381DE00", VA = "0x18381EC00")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x381EA40", Offset = "0x381DC40", VA = "0x18381EA40")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x381E8E0", Offset = "0x381DAE0", VA = "0x18381E8E0")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x381EC80", Offset = "0x381DE80", VA = "0x18381EC80")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x381EAD0", Offset = "0x381DCD0", VA = "0x18381EAD0")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x381E6E0", Offset = "0x381D8E0", VA = "0x18381E6E0")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x381F090", Offset = "0x381E290", VA = "0x18381F090")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x381F5D0", Offset = "0x381E7D0", VA = "0x18381F5D0")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x381E5C0", Offset = "0x381D7C0", VA = "0x18381E5C0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x381E470", Offset = "0x381D670", VA = "0x18381E470")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x381DEE0", Offset = "0x381D0E0", VA = "0x18381DEE0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x381E1A0", Offset = "0x381D3A0", VA = "0x18381E1A0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x381DBD0", Offset = "0x381CDD0", VA = "0x18381DBD0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x381F180", Offset = "0x381E380", VA = "0x18381F180")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x381F390", Offset = "0x381E590", VA = "0x18381F390")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x381F6C0", Offset = "0x381E8C0", VA = "0x18381F6C0")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x381EDB0", Offset = "0x381DFB0", VA = "0x18381EDB0")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x381EF10", Offset = "0x381E110", VA = "0x18381EF10")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x381F810", Offset = "0x381EA10", VA = "0x18381F810")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3795CA0", Offset = "0x3794EA0", VA = "0x183795CA0")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class Warning
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public delegate void Logger(string message);

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static bool logged;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x381F970", Offset = "0x381EB70", VA = "0x18381F970")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x381FA00", Offset = "0x381EC00", VA = "0x18381FA00")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public BipedReferences references;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public BipedIKSolvers solvers;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x26570D0", Offset = "0x26562D0", VA = "0x1826570D0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2657090", Offset = "0x2656290", VA = "0x182657090")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x26575E0", Offset = "0x26567E0", VA = "0x1826575E0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2656920", Offset = "0x2655B20", VA = "0x182656920")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2656AA0", Offset = "0x2655CA0", VA = "0x182656AA0")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2656BB0", Offset = "0x2655DB0", VA = "0x182656BB0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2657110", Offset = "0x2656310", VA = "0x182657110")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2657200", Offset = "0x2656400", VA = "0x182657200")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2657180", Offset = "0x2656380", VA = "0x182657180")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2657270", Offset = "0x2656470", VA = "0x182657270")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2656B10", Offset = "0x2655D10", VA = "0x182656B10")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2656C20", Offset = "0x2655E20", VA = "0x182656C20")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2657310", Offset = "0x2656510", VA = "0x182657310")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x26572E0", Offset = "0x26564E0", VA = "0x1826572E0")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2657350", Offset = "0x2656550", VA = "0x182657350")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2657380", Offset = "0x2656580", VA = "0x182657380")]
		public void SetSpineWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2656A30", Offset = "0x2655C30", VA = "0x182656A30")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x611CC0", Offset = "0x610EC0", VA = "0x180611CC0")]
		public void InitiateBipedIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4988D0", Offset = "0x497AD0", VA = "0x1804988D0")]
		public void UpdateBipedIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x26573B0", Offset = "0x26565B0", VA = "0x1826573B0")]
		public void SetToDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2656960", Offset = "0x2655B60", VA = "0x182656960", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2656C90", Offset = "0x2655E90", VA = "0x182656C90", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2657620", Offset = "0x2656820", VA = "0x182657620", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2657060", Offset = "0x2656260", VA = "0x182657060")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2657850", Offset = "0x2656A50", VA = "0x182657850")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class BipedIKSolvers
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public IKSolverLimb leftFoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public IKSolverLimb rightFoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public IKSolverLimb leftHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public IKSolverLimb rightHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public IKSolverFABRIK spine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public IKSolverLookAt lookAt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public IKSolverAim aim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Constraints pelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private IKSolverLimb[] _limbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private IKSolver[] _ikSolvers;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IKSolverLimb[] limbs
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2656760", Offset = "0x2655960", VA = "0x182656760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IKSolver[] ikSolvers
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x26564B0", Offset = "0x26556B0", VA = "0x1826564B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x26561D0", Offset = "0x26553D0", VA = "0x1826561D0")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2656370", Offset = "0x2655570", VA = "0x182656370")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public abstract class Constraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float weight;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool isValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x2659460", Offset = "0x2658660", VA = "0x182659460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void UpdateConstraint();

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class ConstraintPosition : Constraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Vector3 position;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2658E30", Offset = "0x2658030", VA = "0x182658E30", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public ConstraintPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3F1200", Offset = "0x3F0400", VA = "0x1803F1200")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class ConstraintPositionOffset : Constraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Vector3 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private Vector3 defaultLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private Vector3 lastLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool initiated;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private bool positionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x2658D70", Offset = "0x2657F70", VA = "0x182658D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2658A70", Offset = "0x2657C70", VA = "0x182658A70", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public ConstraintPositionOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3F1200", Offset = "0x3F0400", VA = "0x1803F1200")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class ConstraintRotation : Constraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Quaternion rotation;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2659300", Offset = "0x2658500", VA = "0x182659300", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public ConstraintRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3F1200", Offset = "0x3F0400", VA = "0x1803F1200")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ConstraintRotationOffset : Constraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Quaternion offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private Quaternion defaultRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private Quaternion defaultLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private Quaternion lastLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Quaternion defaultTargetLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private bool initiated;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private bool rotationChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2659260", Offset = "0x2658460", VA = "0x182659260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2658FD0", Offset = "0x26581D0", VA = "0x182658FD0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public ConstraintRotationOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3F1200", Offset = "0x3F0400", VA = "0x1803F1200")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class Constraints
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Vector3 positionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public Vector3 rotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Vector3 rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2659530", Offset = "0x2658730", VA = "0x182659530")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x26594C0", Offset = "0x26586C0", VA = "0x1826594C0")]
		public void Initiate(Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2659590", Offset = "0x2658790", VA = "0x182659590")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class Finger
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		public enum DOF
		{
			[Cpp2IlInjected.Token(Token = "0x400060C")]
			One,
			[Cpp2IlInjected.Token(Token = "0x400060D")]
			Three
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private IKSolverLimb solver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Quaternion bone3RelativeToTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Vector3 bone3DefaultLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Quaternion bone3DefaultLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private Vector3 bone1Axis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Vector3 tipAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Vector3 bone1TwistAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Vector3 defaultBendNormal;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4E20D0", Offset = "0x4E12D0", VA = "0x1804E20D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB820", Offset = "0x7BAA20", VA = "0x1807BB820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 IKPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2C71D60", Offset = "0x2C70F60", VA = "0x182C71D60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x2C71DC0", Offset = "0x2C70FC0", VA = "0x182C71DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion IKRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x2C71D90", Offset = "0x2C70F90", VA = "0x182C71D90")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x2C71DF0", Offset = "0x2C70FF0", VA = "0x182C71DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2C71460", Offset = "0x2C70660", VA = "0x182C71460")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2C70BD0", Offset = "0x2C6FDD0", VA = "0x182C70BD0")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2C70AE0", Offset = "0x2C6FCE0", VA = "0x182C70AE0")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2C71560", Offset = "0x2C70760", VA = "0x182C71560")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2C71640", Offset = "0x2C70840", VA = "0x182C71640")]
		public void Update(float masterWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x109B580", Offset = "0x109A780", VA = "0x18109B580")]
		public Finger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class FingerRig : SolverManager
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public Finger[] fingers;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x4E20D0", Offset = "0x4E12D0", VA = "0x1804E20D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x7BB820", Offset = "0x7BAA20", VA = "0x1807BB820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2C706C0", Offset = "0x2C6F8C0", VA = "0x182C706C0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2C70210", Offset = "0x2C6F410", VA = "0x182C70210")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2C70080", Offset = "0x2C6F280", VA = "0x182C70080")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2C70750", Offset = "0x2C6F950", VA = "0x182C70750")]
		public void RemoveFinger(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2C6FF90", Offset = "0x2C6F190", VA = "0x182C6FF90")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2C705E0", Offset = "0x2C6F7E0", VA = "0x182C705E0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2C70A10", Offset = "0x2C6FC10", VA = "0x182C70A10")]
		public void UpdateFingerSolvers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2C70470", Offset = "0x2C6F670", VA = "0x182C70470")]
		public void FixFingerTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2C708D0", Offset = "0x2C6FAD0", VA = "0x182C708D0")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2C70A10", Offset = "0x2C6FC10", VA = "0x182C70A10", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2C70470", Offset = "0x2C6F670", VA = "0x182C70470", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2C70A90", Offset = "0x2C6FC90", VA = "0x182C70A90")]
		public FingerRig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public abstract class Grounder : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		public delegate void GrounderDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public GrounderDelegate OnPreGrounder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public GrounderDelegate OnPostGrounder;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x475270", Offset = "0x474470", VA = "0x180475270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x4754B0", Offset = "0x4746B0", VA = "0x1804754B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ResetPosition();

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2C7AFF0", Offset = "0x2C7A1F0", VA = "0x182C7AFF0")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2657060", Offset = "0x2656260", VA = "0x182657060")]
		protected void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2C7AB50", Offset = "0x2C79D50", VA = "0x182C7AB50")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2C7AD60", Offset = "0x2C79F60", VA = "0x182C7AD60")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void OpenUserManual();

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void OpenScriptReference();

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B3B0", Offset = "0x2C7A5B0", VA = "0x182C7B3B0")]
		protected Grounder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Transform[] feet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Quaternion[] footRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Vector3 animatedPelvisLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Vector3 solvedPelvisLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Vector3 spineOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private float lastWeight;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2C74080", Offset = "0x2C73280", VA = "0x182C74080", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2C74040", Offset = "0x2C73240", VA = "0x182C74040", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2C740C0", Offset = "0x2C732C0", VA = "0x182C740C0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2C733D0", Offset = "0x2C725D0", VA = "0x182C733D0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2C74250", Offset = "0x2C73450", VA = "0x182C74250")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2C73050", Offset = "0x2C72250", VA = "0x182C73050")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2C73630", Offset = "0x2C72830", VA = "0x182C73630")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2C738D0", Offset = "0x2C72AD0", VA = "0x182C738D0")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2C74140", Offset = "0x2C73340", VA = "0x182C74140")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2C73690", Offset = "0x2C72890", VA = "0x182C73690")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2C73490", Offset = "0x2C72690", VA = "0x182C73490")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2C74390", Offset = "0x2C73590", VA = "0x182C74390")]
		public GrounderBipedIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		public class SpineEffector
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400060E")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400060F")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000610")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x23C0E60", Offset = "0x23C0060", VA = "0x1823C0E60")]
			public SpineEffector()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x2C8C0B0", Offset = "0x2C8B2B0", VA = "0x182C8C0B0")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public SpineEffector[] spine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private Transform[] feet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private Vector3 spineOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private bool firstSolve;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2C75020", Offset = "0x2C74220", VA = "0x182C75020")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2C75060", Offset = "0x2C74260", VA = "0x182C75060", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2C74FE0", Offset = "0x2C741E0", VA = "0x182C74FE0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2C750A0", Offset = "0x2C742A0", VA = "0x182C750A0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2C74690", Offset = "0x2C73890", VA = "0x182C74690")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2C75370", Offset = "0x2C74570", VA = "0x182C75370")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2C74400", Offset = "0x2C73600", VA = "0x182C74400")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2C74400", Offset = "0x2C73600", VA = "0x182C74400")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2C74410", Offset = "0x2C73610", VA = "0x182C74410")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2C74940", Offset = "0x2C73B40", VA = "0x182C74940")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x2C75120", Offset = "0x2C74320", VA = "0x182C75120")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2C74830", Offset = "0x2C73A30", VA = "0x182C74830")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2C74730", Offset = "0x2C73930", VA = "0x182C74730")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2C75490", Offset = "0x2C74690", VA = "0x182C75490")]
		public GrounderFBBIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	public class GrounderIK : Grounder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public IK[] legs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private Transform[] feet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private Quaternion[] footRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private Vector3 animatedPelvisLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private Vector3 solvedPelvisLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private int solvedFeet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private bool solved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private float lastWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Rigidbody characterRootRigidbody;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2C765B0", Offset = "0x2C757B0", VA = "0x182C765B0", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C76570", Offset = "0x2C75770", VA = "0x182C76570", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2C765F0", Offset = "0x2C757F0", VA = "0x182C765F0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2C75A30", Offset = "0x2C74C30", VA = "0x182C75A30")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C75DD0", Offset = "0x2C74FD0", VA = "0x182C75DD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C76AA0", Offset = "0x2C75CA0", VA = "0x182C76AA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C75500", Offset = "0x2C74700", VA = "0x182C75500")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2C76170", Offset = "0x2C75370", VA = "0x182C76170")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C76610", Offset = "0x2C75810", VA = "0x182C76610")]
		private void SetLegIK(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C75F10", Offset = "0x2C75110", VA = "0x182C75F10")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C75BC0", Offset = "0x2C74DC0", VA = "0x182C75BC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C77010", Offset = "0x2C76210", VA = "0x182C77010")]
		public GrounderIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	public class GrounderQuadruped : Grounder
	{
		[Cpp2IlInjected.Token(Token = "0x20000D9")]
		public struct Foot
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000611")]
			public IKSolver solver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000612")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000613")]
			public Quaternion rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000614")]
			public Grounding.Leg leg;

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x2C71E10", Offset = "0x2C71010", VA = "0x182C71E10")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public IK[] legs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public IK[] forelegs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[HideInInspector]
		public Vector3 gravity;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private Foot[] feet;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private Vector3 animatedPelvisLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private Quaternion animatedPelvisLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private Quaternion animatedHeadLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private Vector3 solvedPelvisLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private Quaternion solvedPelvisLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private Quaternion solvedHeadLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int solvedFeet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private bool solved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Transform forefeetRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private Quaternion headRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private float lastWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private Rigidbody characterRootRigidbody;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C78CC0", Offset = "0x2C77EC0", VA = "0x182C78CC0", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2C78C80", Offset = "0x2C77E80", VA = "0x182C78C80", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2C78D00", Offset = "0x2C77F00", VA = "0x182C78D00", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C77B70", Offset = "0x2C76D70", VA = "0x182C77B70")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C77A30", Offset = "0x2C76C30", VA = "0x182C77A30")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C77E40", Offset = "0x2C77040", VA = "0x182C77E40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2C79870", Offset = "0x2C78A70", VA = "0x182C79870")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2C77690", Offset = "0x2C76890", VA = "0x182C77690")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C77280", Offset = "0x2C76480", VA = "0x182C77280")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C77CC0", Offset = "0x2C76EC0", VA = "0x182C77CC0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C78D40", Offset = "0x2C77F40", VA = "0x182C78D40")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C782B0", Offset = "0x2C774B0", VA = "0x182C782B0")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C794F0", Offset = "0x2C786F0", VA = "0x182C794F0")]
		private void UpdateForefeetRoot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C79310", Offset = "0x2C78510", VA = "0x182C79310")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2C77EC0", Offset = "0x2C770C0", VA = "0x182C77EC0")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2C77E00", Offset = "0x2C77000", VA = "0x182C77E00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2C77080", Offset = "0x2C76280", VA = "0x182C77080")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2C79A40", Offset = "0x2C78C40", VA = "0x182C79A40")]
		public GrounderQuadruped()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	public class GrounderVRIK : Grounder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private Transform[] feet;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A800", Offset = "0x2C79A00", VA = "0x182C7A800")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A840", Offset = "0x2C79A40", VA = "0x182C7A840", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A7C0", Offset = "0x2C799C0", VA = "0x182C7A7C0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C765F0", Offset = "0x2C757F0", VA = "0x182C765F0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C79E00", Offset = "0x2C79000", VA = "0x182C79E00")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A9E0", Offset = "0x2C79BE0", VA = "0x182C7A9E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2C79B70", Offset = "0x2C78D70", VA = "0x182C79B70")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A3E0", Offset = "0x2C795E0", VA = "0x182C7A3E0")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A880", Offset = "0x2C79A80", VA = "0x182C7A880")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A140", Offset = "0x2C79340", VA = "0x182C7A140")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A030", Offset = "0x2C79230", VA = "0x182C7A030")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C79EA0", Offset = "0x2C790A0", VA = "0x182C79EA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C7AB00", Offset = "0x2C79D00", VA = "0x182C7AB00")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class Grounding
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		public enum Quality
		{
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			Fastest,
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			Simple,
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			Best
		}

		[Cpp2IlInjected.Token(Token = "0x20000DB")]
		public class Leg
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			public Quaternion rotationOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			public bool invertFootCenter;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			private Grounding grounding;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000625")]
			private float lastTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x4000626")]
			private float deltaTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000627")]
			private Vector3 lastPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
			[Cpp2IlInjected.Token(Token = "0x4000628")]
			private Quaternion toHitNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
			[Cpp2IlInjected.Token(Token = "0x4000629")]
			private Quaternion r;

			[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			private Vector3 up;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			private bool doOverrideFootPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			private Vector3 overrideFootPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x400062D")]
			private Vector3 transformPosition;

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public bool isGrounded
			{
				[Cpp2IlInjected.Token(Token = "0x600064B")]
				[Cpp2IlInjected.Address(RVA = "0x467F20", Offset = "0x467120", VA = "0x180467F20")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600064C")]
				[Cpp2IlInjected.Address(RVA = "0x506BA0", Offset = "0x505DA0", VA = "0x180506BA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public Vector3 IKPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600064D")]
				[Cpp2IlInjected.Address(RVA = "0x226F810", Offset = "0x226EA10", VA = "0x18226F810")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600064E")]
				[Cpp2IlInjected.Address(RVA = "0x2C87350", Offset = "0x2C86550", VA = "0x182C87350")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public bool initiated
			{
				[Cpp2IlInjected.Token(Token = "0x600064F")]
				[Cpp2IlInjected.Address(RVA = "0x470DF0", Offset = "0x46FFF0", VA = "0x180470DF0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000650")]
				[Cpp2IlInjected.Address(RVA = "0x471090", Offset = "0x470290", VA = "0x180471090")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public float heightFromGround
			{
				[Cpp2IlInjected.Token(Token = "0x6000651")]
				[Cpp2IlInjected.Address(RVA = "0xD246A0", Offset = "0xD238A0", VA = "0x180D246A0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000652")]
				[Cpp2IlInjected.Address(RVA = "0xD24680", Offset = "0xD23880", VA = "0x180D24680")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public Vector3 velocity
			{
				[Cpp2IlInjected.Token(Token = "0x6000653")]
				[Cpp2IlInjected.Address(RVA = "0x2516D00", Offset = "0x2515F00", VA = "0x182516D00")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000654")]
				[Cpp2IlInjected.Address(RVA = "0x106AAC0", Offset = "0x1069CC0", VA = "0x18106AAC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Transform transform
			{
				[Cpp2IlInjected.Token(Token = "0x6000655")]
				[Cpp2IlInjected.Address(RVA = "0x434DB0", Offset = "0x433FB0", VA = "0x180434DB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000656")]
				[Cpp2IlInjected.Address(RVA = "0x421A60", Offset = "0x420C60", VA = "0x180421A60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public float IKOffset
			{
				[Cpp2IlInjected.Token(Token = "0x6000657")]
				[Cpp2IlInjected.Address(RVA = "0xA15610", Offset = "0xA14810", VA = "0x180A15610")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000658")]
				[Cpp2IlInjected.Address(RVA = "0x21BA430", Offset = "0x21B9630", VA = "0x1821BA430")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public RaycastHit heelHit
			{
				[Cpp2IlInjected.Token(Token = "0x6000659")]
				[Cpp2IlInjected.Address(RVA = "0x2C8A450", Offset = "0x2C89650", VA = "0x182C8A450")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Cpp2IlInjected.Token(Token = "0x600065A")]
				[Cpp2IlInjected.Address(RVA = "0x2C8A700", Offset = "0x2C89900", VA = "0x182C8A700")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public RaycastHit capsuleHit
			{
				[Cpp2IlInjected.Token(Token = "0x600065B")]
				[Cpp2IlInjected.Address(RVA = "0x2C8A420", Offset = "0x2C89620", VA = "0x182C8A420")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Cpp2IlInjected.Token(Token = "0x600065C")]
				[Cpp2IlInjected.Address(RVA = "0x2C8A6D0", Offset = "0x2C898D0", VA = "0x182C8A6D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public RaycastHit GetHitPoint
			{
				[Cpp2IlInjected.Token(Token = "0x600065D")]
				[Cpp2IlInjected.Address(RVA = "0x2C8A3A0", Offset = "0x2C895A0", VA = "0x182C8A3A0")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public float stepHeightFromGround
			{
				[Cpp2IlInjected.Token(Token = "0x6000663")]
				[Cpp2IlInjected.Address(RVA = "0x2C8A630", Offset = "0x2C89830", VA = "0x182C8A630")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			private float rootYOffset
			{
				[Cpp2IlInjected.Token(Token = "0x600066C")]
				[Cpp2IlInjected.Address(RVA = "0x2C8A480", Offset = "0x2C89680", VA = "0x182C8A480")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x2C89EE0", Offset = "0x2C890E0", VA = "0x182C89EE0")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x2C886E0", Offset = "0x2C878E0", VA = "0x182C886E0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x2C88810", Offset = "0x2C87A10", VA = "0x182C88810")]
			public void OnEnable()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x2C89AB0", Offset = "0x2C88CB0", VA = "0x182C89AB0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x2C88870", Offset = "0x2C87A70", VA = "0x182C88870")]
			public void Process()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0x2C875B0", Offset = "0x2C867B0", VA = "0x182C875B0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x2C87FF0", Offset = "0x2C871F0", VA = "0x182C87FF0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Cpp2IlInjected.Token(Token = "0x6000666")]
			[Cpp2IlInjected.Address(RVA = "0x2C89D80", Offset = "0x2C88F80", VA = "0x182C89D80")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0x2C8A1D0", Offset = "0x2C893D0", VA = "0x182C8A1D0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0x2C89F00", Offset = "0x2C89100", VA = "0x182C89F00")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x2C87E10", Offset = "0x2C87010", VA = "0x182C87E10")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x2C89B80", Offset = "0x2C88D80", VA = "0x182C89B80")]
			private void RotateFoot()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x2C885B0", Offset = "0x2C877B0", VA = "0x182C885B0")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x2C8A2F0", Offset = "0x2C894F0", VA = "0x182C8A2F0")]
			public Leg()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		public class Pelvis
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000630")]
			private Grounding grounding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000631")]
			private Vector3 lastRootPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000632")]
			private float damperF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000633")]
			private bool initiated;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000634")]
			private float lastTime;

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public Vector3 IKOffset
			{
				[Cpp2IlInjected.Token(Token = "0x600066E")]
				[Cpp2IlInjected.Address(RVA = "0x922520", Offset = "0x921720", VA = "0x180922520")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600066F")]
				[Cpp2IlInjected.Address(RVA = "0x922510", Offset = "0x921710", VA = "0x180922510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public float heightOffset
			{
				[Cpp2IlInjected.Token(Token = "0x6000670")]
				[Cpp2IlInjected.Address(RVA = "0x921B10", Offset = "0x920D10", VA = "0x180921B10")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000671")]
				[Cpp2IlInjected.Address(RVA = "0x876950", Offset = "0x875B50", VA = "0x180876950")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x2C8ACB0", Offset = "0x2C89EB0", VA = "0x182C8ACB0")]
			public void Initiate(Grounding grounding)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B0E0", Offset = "0x2C8A2E0", VA = "0x182C8B0E0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x2C8AD20", Offset = "0x2C89F20", VA = "0x182C8AD20")]
			public void OnEnable()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0x2C8AD90", Offset = "0x2C89F90", VA = "0x182C8AD90")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
			public Pelvis()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[HideInInspector]
		[Tooltip("Offset of the foot center along character forward axis.")]
		public float footCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
		public float maxFootRotationAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private bool initiated;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Leg[] legs
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x3F0890", Offset = "0x3EFA90", VA = "0x1803F0890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x3F08C0", Offset = "0x3EFAC0", VA = "0x1803F08C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Pelvis pelvis
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x3F0870", Offset = "0x3EFA70", VA = "0x1803F0870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x3F08A0", Offset = "0x3EFAA0", VA = "0x1803F08A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool isGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x4B10C0", Offset = "0x4B02C0", VA = "0x1804B10C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x4B1180", Offset = "0x4B0380", VA = "0x1804B1180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Transform root
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x46DEF0", Offset = "0x46D0F0", VA = "0x18046DEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x4D53A0", Offset = "0x4D45A0", VA = "0x1804D53A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public RaycastHit rootHit
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2C7CD00", Offset = "0x2C7BF00", VA = "0x182C7CD00")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x2C7CEA0", Offset = "0x2C7C0A0", VA = "0x182C7CEA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool rootGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2C7CCA0", Offset = "0x2C7BEA0", VA = "0x182C7CCA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2C7CD30", Offset = "0x2C7BF30", VA = "0x182C7CD30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private bool useRootRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2C7CDD0", Offset = "0x2C7BFD0", VA = "0x182C7CDD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BA60", Offset = "0x2C7AC60", VA = "0x182C7BA60")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C680", Offset = "0x2C7B880", VA = "0x182C7C680")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C1D0", Offset = "0x2C7B3D0", VA = "0x182C7C1D0")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C970", Offset = "0x2C7BB70", VA = "0x182C7C970")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B710", Offset = "0x2C7A910", VA = "0x182C7B710")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C770", Offset = "0x2C7B970", VA = "0x182C7C770")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C750", Offset = "0x2C7B950", VA = "0x182C7C750")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C060", Offset = "0x2C7B260", VA = "0x182C7C060")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B470", Offset = "0x2C7A670", VA = "0x182C7B470")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B5B0", Offset = "0x2C7A7B0", VA = "0x182C7B5B0")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CC40", Offset = "0x2C7BE40", VA = "0x182C7CC40")]
		public Grounding()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public IKSolverAim solver;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2655AC0", Offset = "0x2654CC0", VA = "0x182655AC0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2655A40", Offset = "0x2654C40", VA = "0x182655A40", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2655A80", Offset = "0x2654C80", VA = "0x182655A80")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2655B00", Offset = "0x2654D00", VA = "0x182655B00")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2655A00", Offset = "0x2654C00", VA = "0x182655A00")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x431080", Offset = "0x430280", VA = "0x180431080", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2655B40", Offset = "0x2654D40", VA = "0x182655B40")]
		public AimIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	public class ArmIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public IKSolverArm solver;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2655F70", Offset = "0x2655170", VA = "0x182655F70", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2655F30", Offset = "0x2655130", VA = "0x182655F30", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2655FB0", Offset = "0x26551B0", VA = "0x182655FB0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2655EF0", Offset = "0x26550F0", VA = "0x182655EF0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x431080", Offset = "0x430280", VA = "0x180431080", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x2655FF0", Offset = "0x26551F0", VA = "0x182655FF0")]
		public ArmIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public IKSolverCCD solver;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2658990", Offset = "0x2657B90", VA = "0x182658990", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2658950", Offset = "0x2657B50", VA = "0x182658950", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x26589D0", Offset = "0x2657BD0", VA = "0x1826589D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2658910", Offset = "0x2657B10", VA = "0x182658910")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x431080", Offset = "0x430280", VA = "0x180431080", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2658A10", Offset = "0x2657C10", VA = "0x182658A10")]
		public CCDIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public IKSolverFABRIK solver;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x265C610", Offset = "0x265B810", VA = "0x18265C610", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x265C5D0", Offset = "0x265B7D0", VA = "0x18265C5D0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x265C650", Offset = "0x265B850", VA = "0x18265C650")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x265C590", Offset = "0x265B790", VA = "0x18265C590")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x431080", Offset = "0x430280", VA = "0x180431080", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x265C690", Offset = "0x265B890", VA = "0x18265C690")]
		public FABRIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public IKSolverFABRIKRoot solver;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x265C4B0", Offset = "0x265B6B0", VA = "0x18265C4B0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x265C470", Offset = "0x265B670", VA = "0x18265C470", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x265C4F0", Offset = "0x265B6F0", VA = "0x18265C4F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x265C430", Offset = "0x265B630", VA = "0x18265C430")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x431080", Offset = "0x430280", VA = "0x180431080", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x265C530", Offset = "0x265B730", VA = "0x18265C530")]
		public FABRIKRoot()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public BipedReferences references;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public IKSolverFullBodyBiped solver;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x2C72040", Offset = "0x2C71240", VA = "0x182C72040", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2C71FC0", Offset = "0x2C711C0", VA = "0x182C71FC0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x2C72000", Offset = "0x2C71200", VA = "0x182C72000")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2C71F80", Offset = "0x2C71180", VA = "0x182C71F80")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2C72730", Offset = "0x2C71930", VA = "0x182C72730")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2C71E60", Offset = "0x2C71060", VA = "0x182C71E60")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2C72700", Offset = "0x2C71900", VA = "0x182C72700")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x401A60", Offset = "0x400C60", VA = "0x180401A60", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2C72080", Offset = "0x2C71280", VA = "0x182C72080")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2C722B0", Offset = "0x2C714B0", VA = "0x182C722B0")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2C726D0", Offset = "0x2C718D0", VA = "0x182C726D0")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2C71EA0", Offset = "0x2C710A0", VA = "0x182C71EA0")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2C72770", Offset = "0x2C71970", VA = "0x182C72770")]
		public FullBodyBipedIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class IK : SolverManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract IKSolver GetIKSolver();

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2C874D0", Offset = "0x2C866D0", VA = "0x182C874D0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2C87460", Offset = "0x2C86660", VA = "0x182C87460", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x2C873F0", Offset = "0x2C865F0", VA = "0x182C873F0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void OpenUserManual();

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void OpenScriptReference();

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA48B90", Offset = "0xA47D90", VA = "0x180A48B90")]
		protected IK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private bool fixedFrame;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x2C82900", Offset = "0x2C81B00", VA = "0x182C82900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2C82850", Offset = "0x2C81A50", VA = "0x182C82850")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2C828D0", Offset = "0x2C81AD0", VA = "0x182C828D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2C82700", Offset = "0x2C81900", VA = "0x182C82700")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2C82730", Offset = "0x2C81930", VA = "0x182C82730")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2C82650", Offset = "0x2C81850", VA = "0x182C82650")]
		private void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public IKExecutionOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public IKSolverLeg solver;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x29F2690", Offset = "0x29F1890", VA = "0x1829F2690", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x29F2650", Offset = "0x29F1850", VA = "0x1829F2650", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x29F26D0", Offset = "0x29F18D0", VA = "0x1829F26D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x29F2610", Offset = "0x29F1810", VA = "0x1829F2610")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x431080", Offset = "0x430280", VA = "0x180431080", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x29F2710", Offset = "0x29F1910", VA = "0x1829F2710")]
		public LegIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public IKSolverLimb solver;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x29F27F0", Offset = "0x29F19F0", VA = "0x1829F27F0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x29F27B0", Offset = "0x29F19B0", VA = "0x1829F27B0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x29F2830", Offset = "0x29F1A30", VA = "0x1829F2830")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x29F2770", Offset = "0x29F1970", VA = "0x1829F2770")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x431080", Offset = "0x430280", VA = "0x180431080", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x29F2870", Offset = "0x29F1A70", VA = "0x1829F2870")]
		public LimbIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public IKSolverLookAt solver;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x29F3CF0", Offset = "0x29F2EF0", VA = "0x1829F3CF0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x29F3CB0", Offset = "0x29F2EB0", VA = "0x1829F3CB0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x29F3D30", Offset = "0x29F2F30", VA = "0x1829F3D30")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x29F3C70", Offset = "0x29F2E70", VA = "0x1829F3C70")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x431080", Offset = "0x430280", VA = "0x180431080", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x29F3D70", Offset = "0x29F2F70", VA = "0x1829F3D70")]
		public LookAtIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public IKSolverTrigonometric solver;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2A015E0", Offset = "0x2A007E0", VA = "0x182A015E0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2A015A0", Offset = "0x2A007A0", VA = "0x182A015A0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2A01620", Offset = "0x2A00820", VA = "0x182A01620")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2A01560", Offset = "0x2A00760", VA = "0x182A01560")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x431080", Offset = "0x430280", VA = "0x180431080", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2A01660", Offset = "0x2A00860", VA = "0x182A01660")]
		public TrigonometricIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		public class References
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000635")]
			public Transform root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000636")]
			public Transform pelvis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			public Transform spine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			[Tooltip("Optional")]
			public Transform chest;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			[Tooltip("Optional")]
			public Transform neck;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public Transform head;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			[Tooltip("Optional")]
			public Transform leftShoulder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public Transform leftUpperArm;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public Transform leftForearm;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			public Transform leftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			[Tooltip("Optional")]
			public Transform rightShoulder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public Transform rightUpperArm;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			public Transform rightForearm;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			public Transform rightHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000643")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000644")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000646")]
			[Tooltip("Optional")]
			public Transform leftToes;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000647")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000648")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000649")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400064A")]
			[Tooltip("Optional")]
			public Transform rightToes;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public bool isFilled
			{
				[Cpp2IlInjected.Token(Token = "0x6000678")]
				[Cpp2IlInjected.Address(RVA = "0x29FB490", Offset = "0x29FA690", VA = "0x1829FB490")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool isEmpty
			{
				[Cpp2IlInjected.Token(Token = "0x6000679")]
				[Cpp2IlInjected.Address(RVA = "0x29FAF80", Offset = "0x29FA180", VA = "0x1829FAF80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0x29FA810", Offset = "0x29F9A10", VA = "0x1829FA810")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x29FA450", Offset = "0x29F9650", VA = "0x1829FA450")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
			public References()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		public References references;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2A09880", Offset = "0x2A08A80", VA = "0x182A09880", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2A09800", Offset = "0x2A08A00", VA = "0x182A09800", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2A09840", Offset = "0x2A08A40", VA = "0x182A09840")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2A09720", Offset = "0x2A08920", VA = "0x182A09720")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2A09750", Offset = "0x2A08950", VA = "0x182A09750")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x401A60", Offset = "0x400C60", VA = "0x180401A60", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2A09780", Offset = "0x2A08980", VA = "0x182A09780", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2A098C0", Offset = "0x2A08AC0", VA = "0x182A098C0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2A09A30", Offset = "0x2A08C30", VA = "0x182A09A30")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class FABRIKChain
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public FABRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[Range(0f, 1f)]
		public float pull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[Range(0f, 1f)]
		public float pin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int[] children;

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x265C030", Offset = "0x265B230", VA = "0x18265C030")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x265C000", Offset = "0x265B200", VA = "0x18265C000")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x265C0F0", Offset = "0x265B2F0", VA = "0x18265C0F0")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x265C240", Offset = "0x265B440", VA = "0x18265C240")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x265BB80", Offset = "0x265AD80", VA = "0x18265BB80")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x265C3D0", Offset = "0x265B5D0", VA = "0x18265C3D0")]
		public FABRIKChain()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public Vector3 bendDirectionOffsetLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Vector3 bendDirectionOffsetRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Vector3 characterSpaceBendOffsetRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private Quaternion leftHandTargetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private Quaternion rightHandTargetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private bool initiated;

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x265C6F0", Offset = "0x265B8F0", VA = "0x18265C6F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x265CE90", Offset = "0x265C090", VA = "0x18265CE90")]
		private void OnPostFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x265CDA0", Offset = "0x265BFA0", VA = "0x18265CDA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public FBBIKArmBending()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		public class BendBone
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400064B")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			[Tooltip("The weight of rotating this bone.")]
			[Range(0f, 1f)]
			public float weight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400064D")]
			private Quaternion defaultLocalRotation;

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x2656160", Offset = "0x2655360", VA = "0x182656160")]
			public BendBone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x26560D0", Offset = "0x26552D0", VA = "0x1826560D0")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067E")]
			[Cpp2IlInjected.Address(RVA = "0x2656090", Offset = "0x2655290", VA = "0x182656090")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0x2656050", Offset = "0x2655250", VA = "0x182656050")]
			public void FixTransforms()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[LargeHeader("Rotation")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
		public float headClampWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		public float CCDWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[LargeHeader("Stretching")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[Range(0f, 1f)]
		public float postStretchWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public Transform[] chestBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private Vector3 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private Vector3 headToBody;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Vector3 shoulderCenterToHead;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private Vector3 headToLeftThigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private Vector3 headToRightThigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Vector3 leftShoulderPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private Vector3 rightShoulderPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private float shoulderDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private float leftShoulderDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private float rightShoulderDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private Quaternion chestRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private Quaternion headRotationRelativeToRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private Vector3 headLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private Quaternion headLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private Vector3[] stretchLocalPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Quaternion[] stretchLocalRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private Vector3[] chestLocalPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private Quaternion[] chestLocalRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private int bendBonesCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private int ccdBonesCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private int stretchBonesCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private int chestBonesCount;

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2660D40", Offset = "0x265FF40", VA = "0x182660D40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x265FBD0", Offset = "0x265EDD0", VA = "0x18265FBD0")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x265EAE0", Offset = "0x265DCE0", VA = "0x18265EAE0")]
		private void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x265F2C0", Offset = "0x265E4C0", VA = "0x18265F2C0")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2660930", Offset = "0x265FB30", VA = "0x182660930")]
		private void SpineBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x265D0A0", Offset = "0x265C2A0", VA = "0x18265D0A0")]
		private void CCDPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x265D8E0", Offset = "0x265CAE0", VA = "0x18265D8E0")]
		private void Iterate(int iteration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x265F080", Offset = "0x265E280", VA = "0x18265F080")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x265D570", Offset = "0x265C770", VA = "0x18265D570")]
		private void ChestDirection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2660250", Offset = "0x265F450", VA = "0x182660250")]
		private void PostStretching()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x265E650", Offset = "0x265D850", VA = "0x18265E650")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2660730", Offset = "0x265F930", VA = "0x182660730")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x265E7D0", Offset = "0x265D9D0", VA = "0x18265E7D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2661110", Offset = "0x2660310", VA = "0x182661110")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class FBIKChain
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		public class ChildConstraint
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			public float pushElasticity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			public float pullElasticity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			[SerializeField]
			private Transform bone1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			[SerializeField]
			private Transform bone2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			private float crossFade;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			private float inverseCrossFade;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			private int chain1Index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			private int chain2Index;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public float nominalDistance
			{
				[Cpp2IlInjected.Token(Token = "0x6000680")]
				[Cpp2IlInjected.Address(RVA = "0x921DD0", Offset = "0x920FD0", VA = "0x180921DD0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000681")]
				[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920D20", VA = "0x180921B20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool isRigid
			{
				[Cpp2IlInjected.Token(Token = "0x6000682")]
				[Cpp2IlInjected.Address(RVA = "0x46C4D0", Offset = "0x46B6D0", VA = "0x18046C4D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000683")]
				[Cpp2IlInjected.Address(RVA = "0x46C670", Offset = "0x46B870", VA = "0x18046C670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x2C6FD90", Offset = "0x2C6EF90", VA = "0x182C6FD90")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x2C6F640", Offset = "0x2C6E840", VA = "0x182C6F640")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x2C6F6A0", Offset = "0x2C6E8A0", VA = "0x182C6F6A0")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0x2C6F940", Offset = "0x2C6EB40", VA = "0x182C6F940")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		public enum Smoothing
		{
			[Cpp2IlInjected.Token(Token = "0x4000659")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400065A")]
			Exponential,
			[Cpp2IlInjected.Token(Token = "0x400065B")]
			Cubic
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[Range(0f, 1f)]
		public float pin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[Range(0f, 1f)]
		public float pull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[Range(0f, 1f)]
		public float push;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[Range(0f, 1f)]
		public float reach;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public Smoothing reachSmoothing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public Smoothing pushSmoothing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public IKSolver.Node[] nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public int[] children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public ChildConstraint[] childConstraints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public IKConstraintBend bendConstraint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private float rootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private bool initiated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private float length;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private float distance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private IKSolver.Point p;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private float reachForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private float pullParentSum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private float[] crossFades;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private float sqrMag1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private float sqrMag2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private float sqrMagDif;

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private const float maxLimbLength = 0.99999f;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2665070", Offset = "0x2664270", VA = "0x182665070")]
		public FBIKChain()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2664E80", Offset = "0x2664080", VA = "0x182664E80")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2663800", Offset = "0x2662A00", VA = "0x182663800")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2662210", Offset = "0x2661410", VA = "0x182662210")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x26624E0", Offset = "0x26616E0", VA = "0x1826624E0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2662300", Offset = "0x2661500", VA = "0x182662300")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2663080", Offset = "0x2662280", VA = "0x182663080")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2661620", Offset = "0x2660820", VA = "0x182661620")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2662B60", Offset = "0x2661D60", VA = "0x182662B60")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x26625E0", Offset = "0x26617E0", VA = "0x1826625E0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2664170", Offset = "0x2663370", VA = "0x182664170")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2664610", Offset = "0x2663810", VA = "0x182664610")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2664CB0", Offset = "0x2663EB0", VA = "0x182664CB0")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x26639C0", Offset = "0x2662BC0", VA = "0x1826639C0")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2663DB0", Offset = "0x2662FB0", VA = "0x182663DB0")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2661FB0", Offset = "0x26611B0", VA = "0x182661FB0")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x2663930", Offset = "0x2662B30", VA = "0x182663930")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2663EF0", Offset = "0x26630F0", VA = "0x182663EF0")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2661D50", Offset = "0x2660F50", VA = "0x182661D50")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2661290", Offset = "0x2660490", VA = "0x182661290")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class IKConstraintBend
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public Transform bone1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public Transform bone2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public Transform bone3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public Transform bendGoal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public Vector3 direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public Quaternion rotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Vector3 defaultLocalDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public float clampF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private int chainIndex1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private int nodeIndex1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private int chainIndex2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private int nodeIndex2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private int chainIndex3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private int nodeIndex3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x85")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private bool limbOrientationsSet;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x843870", Offset = "0x842A70", VA = "0x180843870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x843F50", Offset = "0x843150", VA = "0x180843F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2C7F8B0", Offset = "0x2C7EAB0", VA = "0x182C7F8B0")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2C805B0", Offset = "0x2C7F7B0", VA = "0x182C805B0")]
		public IKConstraintBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2C80630", Offset = "0x2C7F830", VA = "0x182C80630")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1929D00", Offset = "0x1928F00", VA = "0x181929D00")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2C7F350", Offset = "0x2C7E550", VA = "0x182C7F350")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2C80350", Offset = "0x2C7F550", VA = "0x182C80350")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2C7FAD0", Offset = "0x2C7ECD0", VA = "0x182C7FAD0")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2C7EBF0", Offset = "0x2C7DDF0", VA = "0x182C7EBF0")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2C801F0", Offset = "0x2C7F3F0", VA = "0x182C801F0")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2C80090", Offset = "0x2C7F290", VA = "0x182C80090")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class IKEffector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public Vector3 positionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public bool effectChildNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public Transform[] childBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public Transform planeBone1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public Transform planeBone2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public Transform planeBone3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public Quaternion planeRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private float posW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private float rotW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private Vector3[] localPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private bool usePlaneNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private Quaternion animatedPlaneRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private Vector3 animatedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private bool firstUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private int chainIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private int nodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private int plane1ChainIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private int plane1NodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private int plane2ChainIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private int plane2NodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private int plane3ChainIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private int plane3NodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private int[] childChainIndexes;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private int[] childNodeIndexes;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool isEndEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x4E34D0", Offset = "0x4E26D0", VA = "0x1804E34D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x724670", Offset = "0x723870", VA = "0x180724670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2C806E0", Offset = "0x2C7F8E0", VA = "0x182C806E0")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2C81C00", Offset = "0x2C80E00", VA = "0x182C81C00")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2C82500", Offset = "0x2C81700", VA = "0x182C82500")]
		public IKEffector()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2C82390", Offset = "0x2C81590", VA = "0x182C82390")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2C810A0", Offset = "0x2C802A0", VA = "0x182C810A0")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2C80D60", Offset = "0x2C7FF60", VA = "0x182C80D60")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2C81CF0", Offset = "0x2C80EF0", VA = "0x182C81CF0")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2C81E90", Offset = "0x2C81090", VA = "0x182C81E90")]
		public void SetToTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2C81420", Offset = "0x2C80620", VA = "0x182C81420")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2C813B0", Offset = "0x2C805B0", VA = "0x182C813B0")]
		public void OnPostWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2C80750", Offset = "0x2C7F950", VA = "0x182C80750")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2C81F40", Offset = "0x2C81140", VA = "0x182C81F40")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2C809B0", Offset = "0x2C7FBB0", VA = "0x182C809B0")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class IKMapping
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		public class BoneMap
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400065C")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400065D")]
			public int chainIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400065E")]
			public int nodeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400065F")]
			public Vector3 defaultLocalPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000660")]
			public Quaternion defaultLocalRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000661")]
			public Vector3 localSwingAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000662")]
			public Vector3 localTwistAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000663")]
			public Vector3 planePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000664")]
			public Vector3 ikPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000665")]
			public Quaternion defaultLocalTargetRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
			[Cpp2IlInjected.Token(Token = "0x4000666")]
			private Quaternion maintainRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x4000667")]
			public float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000668")]
			public Quaternion animatedRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000669")]
			private Transform planeBone1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			private Transform planeBone2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400066B")]
			private Transform planeBone3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400066C")]
			private int plane1ChainIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x400066D")]
			private int plane1NodeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400066E")]
			private int plane2ChainIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x400066F")]
			private int plane2NodeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000670")]
			private int plane3ChainIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
			[Cpp2IlInjected.Token(Token = "0x4000671")]
			private int plane3NodeIndex;

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Vector3 swingDirection
			{
				[Cpp2IlInjected.Token(Token = "0x6000689")]
				[Cpp2IlInjected.Address(RVA = "0x2C6F570", Offset = "0x2C6E770", VA = "0x182C6F570")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public bool isNodeBone
			{
				[Cpp2IlInjected.Token(Token = "0x600068C")]
				[Cpp2IlInjected.Address(RVA = "0x2C6F2B0", Offset = "0x2C6E4B0", VA = "0x182C6F2B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60006A0")]
				[Cpp2IlInjected.Address(RVA = "0x2C6F2C0", Offset = "0x2C6E4C0", VA = "0x182C6F2C0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0x2C6E110", Offset = "0x2C6D310", VA = "0x182C6E110")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x2C6EB30", Offset = "0x2C6DD30", VA = "0x182C6EB30")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x2C6DCD0", Offset = "0x2C6CED0", VA = "0x182C6DCD0")]
			public void FixTransform(bool position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0x2C6E640", Offset = "0x2C6D840", VA = "0x182C6E640")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x2C6E730", Offset = "0x2C6D930", VA = "0x182C6E730")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x2C6E740", Offset = "0x2C6D940", VA = "0x182C6E740")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2C6E8F0", Offset = "0x2C6DAF0", VA = "0x182C6E8F0")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2C6EA10", Offset = "0x2C6DC10", VA = "0x182C6EA10")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x2C6F0A0", Offset = "0x2C6E2A0", VA = "0x182C6F0A0")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x2C6E600", Offset = "0x2C6D800", VA = "0x182C6E600")]
			public void SetIKPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x2C6E150", Offset = "0x2C6D350", VA = "0x182C6E150")]
			public void MaintainRotation()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0x2C6EAF0", Offset = "0x2C6DCF0", VA = "0x182C6EAF0")]
			public void SetToIKPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x2C6DB50", Offset = "0x2C6CD50", VA = "0x182C6DB50")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000697")]
			[Cpp2IlInjected.Address(RVA = "0x2C6DD30", Offset = "0x2C6CF30", VA = "0x182C6DD30")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0x2C6E190", Offset = "0x2C6D390", VA = "0x182C6E190")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0x2C6E490", Offset = "0x2C6D690", VA = "0x182C6E490")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0x2C6EB90", Offset = "0x2C6DD90", VA = "0x182C6EB90")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x2C6EC20", Offset = "0x2C6DE20", VA = "0x182C6EC20")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0x2C6EE80", Offset = "0x2C6E080", VA = "0x182C6EE80")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x2C6E380", Offset = "0x2C6D580", VA = "0x182C6E380")]
			public void RotateToMaintain(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0x2C6E1E0", Offset = "0x2C6D3E0", VA = "0x182C6E1E0")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069F")]
			[Cpp2IlInjected.Address(RVA = "0x2C6DEB0", Offset = "0x2C6D0B0", VA = "0x182C6DEB0")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0x2C6F280", Offset = "0x2C6E480", VA = "0x182C6F280")]
			public BoneMap()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CA0", Offset = "0x3F1EA0", VA = "0x1803F2CA0", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2C86770", Offset = "0x2C85970", VA = "0x182C86770")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2C86880", Offset = "0x2C85A80", VA = "0x182C86880")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class IKMappingBone : IKMapping
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private BoneMap boneMap;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2C82A90", Offset = "0x2C81C90", VA = "0x182C82A90", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2C82C90", Offset = "0x2C81E90", VA = "0x182C82C90")]
		public IKMappingBone()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2C82BF0", Offset = "0x2C81DF0", VA = "0x182C82BF0")]
		public IKMappingBone(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2C82B60", Offset = "0x2C81D60", VA = "0x182C82B60")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2C82990", Offset = "0x2C81B90", VA = "0x182C82990")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2C829D0", Offset = "0x2C81BD0", VA = "0x182C829D0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2C82B20", Offset = "0x2C81D20", VA = "0x182C82B20")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2C82BC0", Offset = "0x2C81DC0", VA = "0x182C82BC0")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		public enum BoneMapType
		{
			[Cpp2IlInjected.Token(Token = "0x4000673")]
			Parent,
			[Cpp2IlInjected.Token(Token = "0x4000674")]
			Bone1,
			[Cpp2IlInjected.Token(Token = "0x4000675")]
			Bone2,
			[Cpp2IlInjected.Token(Token = "0x4000676")]
			Bone3
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public Transform parentBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Transform bone1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Transform bone2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public Transform bone3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[Range(0f, 1f)]
		public float weight;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public bool updatePlaneRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private BoneMap boneMapParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private BoneMap boneMap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private BoneMap boneMap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private BoneMap boneMap3;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2C83280", Offset = "0x2C82480", VA = "0x182C83280", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2C82E70", Offset = "0x2C82070", VA = "0x182C82E70")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2C834A0", Offset = "0x2C826A0", VA = "0x182C834A0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2C84020", Offset = "0x2C83220", VA = "0x182C84020")]
		public IKMappingLimb()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2C83E80", Offset = "0x2C83080", VA = "0x182C83E80")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2C83480", Offset = "0x2C82680", VA = "0x182C83480")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2C83870", Offset = "0x2C82A70", VA = "0x182C83870")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2C82D20", Offset = "0x2C81F20", VA = "0x182C82D20")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2C82F30", Offset = "0x2C82130", VA = "0x182C82F30", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2C83320", Offset = "0x2C82520", VA = "0x182C83320")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2C83A30", Offset = "0x2C82C30", VA = "0x182C83A30")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class IKMappingSpine : IKMapping
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public Transform[] spineBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public Transform leftUpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public Transform rightUpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public Transform leftThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Transform rightThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		[Range(1f, 3f)]
		public int iterations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private int rootNodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private BoneMap[] spine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private BoneMap leftUpperArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private BoneMap rightUpperArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private BoneMap leftThigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private BoneMap rightThigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private bool useFABRIK;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2C85090", Offset = "0x2C84290", VA = "0x182C85090", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2C865F0", Offset = "0x2C857F0", VA = "0x182C865F0")]
		public IKMappingSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x2C86430", Offset = "0x2C85630", VA = "0x182C86430")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2C85DC0", Offset = "0x2C84FC0", VA = "0x182C85DC0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C85DE0", Offset = "0x2C84FE0", VA = "0x182C85DE0")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2C843D0", Offset = "0x2C835D0", VA = "0x182C843D0")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2C846E0", Offset = "0x2C838E0", VA = "0x182C846E0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C85EA0", Offset = "0x2C850A0", VA = "0x182C85EA0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C85940", Offset = "0x2C84B40", VA = "0x182C85940")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C85ED0", Offset = "0x2C850D0", VA = "0x182C85ED0")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x2C84470", Offset = "0x2C83670", VA = "0x182C84470")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C84180", Offset = "0x2C83380", VA = "0x182C84180")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C853C0", Offset = "0x2C845C0", VA = "0x182C853C0")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class IKSolver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		public class Point
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000677")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000678")]
			[Range(0f, 1f)]
			public float weight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			public Vector3 solverPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			public Quaternion solverRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400067B")]
			public Vector3 defaultLocalPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400067C")]
			public Quaternion defaultLocalRotation;

			[Cpp2IlInjected.Token(Token = "0x60006A2")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D430", Offset = "0x2C6C630", VA = "0x182C6D430")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D2B0", Offset = "0x2C6C4B0", VA = "0x182C6D2B0")]
			public void FixTransform()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D530", Offset = "0x2C6C730", VA = "0x182C6D530")]
			public void UpdateSolverPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D490", Offset = "0x2C6C690", VA = "0x182C6D490")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D570", Offset = "0x2C6C770", VA = "0x182C6D570")]
			public void UpdateSolverState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D4D0", Offset = "0x2C6C6D0", VA = "0x182C6D4D0")]
			public void UpdateSolverLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D1B0", Offset = "0x2C6C3B0", VA = "0x182C6D1B0")]
			public Point()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		public class Bone : Point
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			public float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			public float sqrMag;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			public Vector3 axis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			private RotationLimit _rotationLimit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			private bool isLimited;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public RotationLimit rotationLimit
			{
				[Cpp2IlInjected.Token(Token = "0x60006A9")]
				[Cpp2IlInjected.Address(RVA = "0x2C4C300", Offset = "0x2C4B500", VA = "0x182C4C300")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60006AA")]
				[Cpp2IlInjected.Address(RVA = "0x2C4C3D0", Offset = "0x2C4B5D0", VA = "0x182C4C3D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x2C4BD50", Offset = "0x2C4AF50", VA = "0x182C4BD50")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0x2C4B780", Offset = "0x2C4A980", VA = "0x182C4B780")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0x2C4BAE0", Offset = "0x2C4ACE0", VA = "0x182C4BAE0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x2C4B740", Offset = "0x2C4A940", VA = "0x182C4B740")]
			public void SetToSolverPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x2C4C210", Offset = "0x2C4B410", VA = "0x182C4C210")]
			public Bone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0x2C4C110", Offset = "0x2C4B310", VA = "0x182C4C110")]
			public Bone(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0x2C4C000", Offset = "0x2C4B200", VA = "0x182C4C000")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		public class Node : Point
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			public float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			public float effectorPositionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000684")]
			public float effectorRotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000685")]
			public Vector3 offset;

			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D1B0", Offset = "0x2C6C3B0", VA = "0x182C6D1B0")]
			public Node()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D130", Offset = "0x2C6C330", VA = "0x182C6D130")]
			public Node(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D220", Offset = "0x2C6C420", VA = "0x182C6D220")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		public delegate void UpdateDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		public delegate void IterationDelegate(int i);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		[HideInInspector]
		public bool executedInEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public UpdateDelegate OnPreInitiate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public UpdateDelegate OnPostInitiate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public UpdateDelegate OnPreUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public UpdateDelegate OnPostUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		protected bool firstInitiation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x46C4E0", Offset = "0x46B6E0", VA = "0x18046C4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x46C680", Offset = "0x46B880", VA = "0x18046C680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C86D10", Offset = "0x2C85F10", VA = "0x182C86D10")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool IsValid(ref string message);

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C86BC0", Offset = "0x2C85DC0", VA = "0x182C86BC0")]
		public void Initiate(Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2C87360", Offset = "0x2C86560", VA = "0x182C87360")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x226F810", Offset = "0x226EA10", VA = "0x18226F810", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C87350", Offset = "0x2C86550", VA = "0x182C87350")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xAB31B0", Offset = "0xAB23B0", VA = "0x180AB31B0")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C872E0", Offset = "0x2C864E0", VA = "0x182C872E0")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3F0880", Offset = "0x3EFA80", VA = "0x1803F0880")]
		public Transform GetRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract Point[] GetPoints();

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract Point GetPoint(Transform transform);

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void FixTransforms();

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void StoreDefaultLocalState();

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void OnInitiate();

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void OnUpdate();

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x2C86D80", Offset = "0x2C85F80", VA = "0x182C86D80")]
		protected void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x2C869C0", Offset = "0x2C85BC0", VA = "0x182C869C0")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2C86B10", Offset = "0x2C85D10", VA = "0x182C86B10")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C86DA0", Offset = "0x2C85FA0", VA = "0x182C86DA0")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C873D0", Offset = "0x2C865D0", VA = "0x182C873D0")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public Vector3 axis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Vector3 poleAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public Vector3 polePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public Transform poleTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public IterationDelegate OnPreIteration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private float step;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private Vector3 clampedIKPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private RotationLimit transformLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private Transform lastTransform;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector3 transformAxis
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x2C4DE40", Offset = "0x2C4D040", VA = "0x182C4DE40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 transformPoleAxis
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x2C4DF20", Offset = "0x2C4D120", VA = "0x182C4DF20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override int minBones
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x3F37C0", Offset = "0x3F29C0", VA = "0x1803F37C0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override Vector3 localDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x2C4DD70", Offset = "0x2C4CF70", VA = "0x182C4DD70", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C440", Offset = "0x2C4B640", VA = "0x182C4C440")]
		public float GetAngle()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C4CA80", Offset = "0x2C4BC80", VA = "0x182C4CA80", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x2C4CDF0", Offset = "0x2C4BFF0", VA = "0x182C4CDF0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DB50", Offset = "0x2C4CD50", VA = "0x182C4DB50")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C570", Offset = "0x2C4B770", VA = "0x182C4C570")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C4D500", Offset = "0x2C4C700", VA = "0x182C4D500")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DC90", Offset = "0x2C4CE90", VA = "0x182C4DC90")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class IKSolverArm : IKSolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public Quaternion IKRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public Point chest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public Point shoulder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public Point upperArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public Point forearm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public Point hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public bool isLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public IKSolverVR.Arm arm;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private Vector3[] positions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private Quaternion[] rotations;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E480", Offset = "0x2C4D680", VA = "0x182C4E480", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C4EE50", Offset = "0x2C4E050", VA = "0x182C4EE50")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E280", Offset = "0x2C4D480", VA = "0x182C4E280", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E070", Offset = "0x2C4D270", VA = "0x182C4E070", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x2C4EF60", Offset = "0x2C4E160", VA = "0x182C4EF60", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E000", Offset = "0x2C4D200", VA = "0x182C4E000", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E800", Offset = "0x2C4DA00", VA = "0x182C4E800", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E880", Offset = "0x2C4DA80", VA = "0x182C4E880", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x2C4EED0", Offset = "0x2C4E0D0", VA = "0x182C4EED0")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E920", Offset = "0x2C4DB20", VA = "0x182C4E920")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F0E0", Offset = "0x2C4E2E0", VA = "0x182C4F0E0")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F370", Offset = "0x2C4E570", VA = "0x182C4F370")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public IterationDelegate OnPreIteration;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F670", Offset = "0x2C4E870", VA = "0x182C4F670")]
		public void FadeOutBoneWeights()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F750", Offset = "0x2C4E950", VA = "0x182C4F750", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F7E0", Offset = "0x2C4E9E0", VA = "0x182C4F7E0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2C4FBC0", Offset = "0x2C4EDC0", VA = "0x182C4FBC0")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2C505A0", Offset = "0x2C4F7A0", VA = "0x182C505A0")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public IterationDelegate OnPreIteration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private bool[] limitedBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private Vector3[] solverLocalPositions;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected override bool boneLengthCanBeZero
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x3F5D40", Offset = "0x3F4F40", VA = "0x1803F5D40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x2C55220", Offset = "0x2C54420", VA = "0x182C55220")]
		public void SolveForward(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C55160", Offset = "0x2C54360", VA = "0x182C55160")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C53050", Offset = "0x2C52250", VA = "0x182C53050", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C54170", Offset = "0x2C53370", VA = "0x182C54170", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C54DA0", Offset = "0x2C53FA0", VA = "0x182C54DA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2C552C0", Offset = "0x2C544C0", VA = "0x182C552C0")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C54710", Offset = "0x2C53910", VA = "0x182C54710")]
		private void OnPreSolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C545B0", Offset = "0x2C537B0", VA = "0x182C545B0")]
		private void OnPostSolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C55420", Offset = "0x2C54620", VA = "0x182C55420")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C52C70", Offset = "0x2C51E70", VA = "0x182C52C70")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C55790", Offset = "0x2C54990", VA = "0x182C55790")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2C559F0", Offset = "0x2C54BF0", VA = "0x182C559F0")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C558D0", Offset = "0x2C54AD0", VA = "0x182C558D0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C554D0", Offset = "0x2C546D0", VA = "0x182C554D0")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C53460", Offset = "0x2C52660", VA = "0x182C53460")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C532C0", Offset = "0x2C524C0", VA = "0x182C532C0")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2C53100", Offset = "0x2C52300", VA = "0x182C53100")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x2C535F0", Offset = "0x2C527F0", VA = "0x182C535F0")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x2C52C30", Offset = "0x2C51E30", VA = "0x182C52C30")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2C529A0", Offset = "0x2C51BA0", VA = "0x182C529A0")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2C521A0", Offset = "0x2C513A0", VA = "0x182C521A0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2C53FA0", Offset = "0x2C531A0", VA = "0x182C53FA0")]
		private void MapToSolverPositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C53E90", Offset = "0x2C53090", VA = "0x182C53E90")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C55B30", Offset = "0x2C54D30", VA = "0x182C55B30")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int iterations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		[Range(0f, 1f)]
		public float rootPin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public FABRIKChain[] chains;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private bool zeroWeightApplied;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private bool[] isRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private Vector3 rootDefaultPosition;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2C51050", Offset = "0x2C50250", VA = "0x182C51050", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2C52080", Offset = "0x2C51280", VA = "0x182C52080", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2C50750", Offset = "0x2C4F950", VA = "0x182C50750", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x2C51BC0", Offset = "0x2C50DC0", VA = "0x182C51BC0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2C50F70", Offset = "0x2C50170", VA = "0x182C50F70")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2C51DB0", Offset = "0x2C50FB0", VA = "0x182C51DB0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x2C50D70", Offset = "0x2C4FF70", VA = "0x182C50D70", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2C50CC0", Offset = "0x2C4FEC0", VA = "0x182C50CC0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x2C505F0", Offset = "0x2C4F7F0", VA = "0x182C505F0")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2C50820", Offset = "0x2C4FA20", VA = "0x182C50820")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x2C52150", Offset = "0x2C51350", VA = "0x182C52150")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class IKSolverFullBody : IKSolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		[Range(0f, 10f)]
		public int iterations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public FBIKChain[] chain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public IKEffector[] effectors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public IKMappingSpine spineMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public IKMappingBone[] boneMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public IKMappingLimb[] limbMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public bool FABRIKPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public UpdateDelegate OnPreRead;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public UpdateDelegate OnPreSolve;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public IterationDelegate OnPreIteration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public IterationDelegate OnPostIteration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public UpdateDelegate OnPreBend;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public UpdateDelegate OnPostSolve;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public UpdateDelegate OnFixTransforms;

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x2C5ABB0", Offset = "0x2C59DB0", VA = "0x182C5ABB0")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2C5AB60", Offset = "0x2C59D60", VA = "0x182C5AB60")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x2C5A9F0", Offset = "0x2C59BF0", VA = "0x182C5A9F0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x2C5ACD0", Offset = "0x2C59ED0", VA = "0x182C5ACD0")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x2C5A960", Offset = "0x2C59B60", VA = "0x182C5A960")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x2C5AF00", Offset = "0x2C5A100", VA = "0x182C5AF00", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x2C5AD40", Offset = "0x2C59F40", VA = "0x182C5AD40", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B0D0", Offset = "0x2C5A2D0", VA = "0x182C5B0D0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x2C5BF40", Offset = "0x2C5B140", VA = "0x182C5BF40", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x2C5A830", Offset = "0x2C59A30", VA = "0x182C5A830", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B340", Offset = "0x2C5A540", VA = "0x182C5B340", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B510", Offset = "0x2C5A710", VA = "0x182C5B510", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B740", Offset = "0x2C5A940", VA = "0x182C5B740", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x2C5BAA0", Offset = "0x2C5ACA0", VA = "0x182C5BAA0", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2C5A7E0", Offset = "0x2C599E0", VA = "0x182C5A7E0", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2C5C050", Offset = "0x2C5B250", VA = "0x182C5C050", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2C5C180", Offset = "0x2C5B380", VA = "0x182C5C180")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum FullBodyBipedEffector
	{
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		Body,
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		LeftShoulder,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		RightShoulder,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		LeftThigh,
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		RightThigh,
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		LeftHand,
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		RightHand,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		LeftFoot,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		RightFoot
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public enum FullBodyBipedChain
	{
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		LeftArm,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		RightArm,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		LeftLeg,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		RightLeg
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public Transform rootNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private Vector3 offset;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public IKEffector bodyEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A360", Offset = "0x2C59560", VA = "0x182C5A360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public IKEffector leftShoulderEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A520", Offset = "0x2C59720", VA = "0x182C5A520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public IKEffector rightShoulderEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A740", Offset = "0x2C59940", VA = "0x182C5A740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public IKEffector leftThighEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A560", Offset = "0x2C59760", VA = "0x182C5A560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public IKEffector rightThighEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A780", Offset = "0x2C59980", VA = "0x182C5A780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public IKEffector leftHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A460", Offset = "0x2C59660", VA = "0x182C5A460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public IKEffector rightHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A680", Offset = "0x2C59880", VA = "0x182C5A680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public IKEffector leftFootEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A420", Offset = "0x2C59620", VA = "0x182C5A420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public IKEffector rightFootEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A640", Offset = "0x2C59840", VA = "0x182C5A640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public FBIKChain leftArmChain
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A3A0", Offset = "0x2C595A0", VA = "0x182C5A3A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public FBIKChain rightArmChain
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A5C0", Offset = "0x2C597C0", VA = "0x182C5A5C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public FBIKChain leftLegChain
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A4A0", Offset = "0x2C596A0", VA = "0x182C5A4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public FBIKChain rightLegChain
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A6C0", Offset = "0x2C598C0", VA = "0x182C5A6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public IKMappingLimb leftArmMapping
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A3E0", Offset = "0x2C595E0", VA = "0x182C5A3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public IKMappingLimb rightArmMapping
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A600", Offset = "0x2C59800", VA = "0x182C5A600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public IKMappingLimb leftLegMapping
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A4E0", Offset = "0x2C596E0", VA = "0x182C5A4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public IKMappingLimb rightLegMapping
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A700", Offset = "0x2C59900", VA = "0x182C5A700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public IKMappingBone headMapping
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x2C57340", Offset = "0x2C56540", VA = "0x182C57340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 pullBodyOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A5A0", Offset = "0x2C597A0", VA = "0x182C5A5A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x2C5A7C0", Offset = "0x2C599C0", VA = "0x182C5A7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x2C57FF0", Offset = "0x2C571F0", VA = "0x182C57FF0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2C58060", Offset = "0x2C57260", VA = "0x182C58060")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2C56CC0", Offset = "0x2C55EC0", VA = "0x182C56CC0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2C56AD0", Offset = "0x2C55CD0", VA = "0x182C56AD0")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x2C56D90", Offset = "0x2C55F90", VA = "0x182C56D90")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2C56FA0", Offset = "0x2C561A0", VA = "0x182C56FA0")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2C57440", Offset = "0x2C56640", VA = "0x182C57440")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2C57510", Offset = "0x2C56710", VA = "0x182C57510")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x46DEF0", Offset = "0x46D0F0", VA = "0x18046DEF0")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x2C57340", Offset = "0x2C56540", VA = "0x182C57340")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2C566B0", Offset = "0x2C558B0", VA = "0x182C566B0")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2C577B0", Offset = "0x2C569B0", VA = "0x182C577B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2C58490", Offset = "0x2C57690", VA = "0x182C58490")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2C561F0", Offset = "0x2C553F0", VA = "0x182C561F0")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2C58420", Offset = "0x2C57620", VA = "0x182C58420")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2C58150", Offset = "0x2C57350", VA = "0x182C58150")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2C57380", Offset = "0x2C56580", VA = "0x182C57380")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x2C576F0", Offset = "0x2C568F0", VA = "0x182C576F0")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x2C56130", Offset = "0x2C55330", VA = "0x182C56130")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x2C57BE0", Offset = "0x2C56DE0", VA = "0x182C57BE0", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x2C57980", Offset = "0x2C56B80", VA = "0x182C57980")]
		private void PullBody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x2C56780", Offset = "0x2C55980", VA = "0x182C56780")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2C57070", Offset = "0x2C56270", VA = "0x182C57070")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2C55BD0", Offset = "0x2C54DD0", VA = "0x182C55BD0", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2C5A040", Offset = "0x2C59240", VA = "0x182C5A040", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2C5A290", Offset = "0x2C59490", VA = "0x182C5A290")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class IKSolverHeuristic : IKSolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public float tolerance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int maxIterations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public bool useRotationLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public bool XY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public Bone[] bones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		protected Vector3 lastLocalDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		protected float chainLength;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected virtual int minBones
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x49B5B0", Offset = "0x49A7B0", VA = "0x18049B5B0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected virtual bool boneLengthCanBeZero
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CA0", Offset = "0x3F1EA0", VA = "0x1803F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected virtual bool allowCommonParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x3F5D40", Offset = "0x3F4F40", VA = "0x1803F5D40", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual Vector3 localDirection
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x2C5DCD0", Offset = "0x2C5CED0", VA = "0x182C5DCD0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected float positionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2C5DEA0", Offset = "0x2C5D0A0", VA = "0x182C5DEA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2C5D6E0", Offset = "0x2C5C8E0", VA = "0x182C5D6E0")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x2C5C240", Offset = "0x2C5B440", VA = "0x182C5C240")]
		public void AddBone(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2C5DC10", Offset = "0x2C5CE10", VA = "0x182C5DC10", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x2C5C520", Offset = "0x2C5B720", VA = "0x182C5C520", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2C5D2D0", Offset = "0x2C5C4D0", VA = "0x182C5D2D0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x46DEF0", Offset = "0x46D0F0", VA = "0x18046DEF0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2C5C5B0", Offset = "0x2C5B7B0", VA = "0x182C5C5B0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x2C5CB90", Offset = "0x2C5BD90", VA = "0x182C5CB90")]
		protected void InitiateBones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x2C5C6D0", Offset = "0x2C5B8D0", VA = "0x182C5C6D0")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x2C5D880", Offset = "0x2C5CA80", VA = "0x182C5D880")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x2C505A0", Offset = "0x2C4F7A0", VA = "0x182C505A0")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class IKSolverLeg : IKSolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public Quaternion IKRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public Point pelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public Point thigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public Point calf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public Point foot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public Point toe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public IKSolverVR.Leg leg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public Vector3 heelOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private Vector3[] positions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private Quaternion[] rotations;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x2C5E390", Offset = "0x2C5D590", VA = "0x182C5E390", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x2C4EE50", Offset = "0x2C4E050", VA = "0x182C4EE50")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x2C5E190", Offset = "0x2C5D390", VA = "0x182C5E190", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x2C5DF80", Offset = "0x2C5D180", VA = "0x182C5DF80", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x2C4EF60", Offset = "0x2C4E160", VA = "0x182C4EF60", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E000", Offset = "0x2C4D200", VA = "0x182C4E000", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x2C5E710", Offset = "0x2C5D910", VA = "0x182C5E710", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x2C5E790", Offset = "0x2C5D990", VA = "0x182C5E790", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EE30", Offset = "0x2C5E030", VA = "0x182C5EE30")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x2C5E910", Offset = "0x2C5DB10", VA = "0x182C5E910")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EFA0", Offset = "0x2C5E1A0", VA = "0x182C5EFA0")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2C5F230", Offset = "0x2C5E430", VA = "0x182C5F230")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		public enum BendModifier
		{
			[Cpp2IlInjected.Token(Token = "0x4000687")]
			Animation,
			[Cpp2IlInjected.Token(Token = "0x4000688")]
			Target,
			[Cpp2IlInjected.Token(Token = "0x4000689")]
			Parent,
			[Cpp2IlInjected.Token(Token = "0x400068A")]
			Arm,
			[Cpp2IlInjected.Token(Token = "0x400068B")]
			Goal
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		public struct AxisDirection
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400068C")]
			public Vector3 direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400068D")]
			public Vector3 axis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400068E")]
			public float dot;

			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x2C4B6E0", Offset = "0x2C4A8E0", VA = "0x182C4B6E0")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AvatarIKGoal goal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public BendModifier bendModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public Transform bendGoal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private bool maintainBendFor1Frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private bool maintainRotationFor1Frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private Quaternion defaultRootRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private Quaternion parentDefaultRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private Quaternion bone3RotationBeforeSolve;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private Quaternion maintainRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private Quaternion bone3DefaultRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private Vector3 _bendNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private Vector3 animationNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private AxisDirection[] axisDirectionsLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private AxisDirection[] axisDirectionsRight;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		private AxisDirection[] axisDirections
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x2C61000", Offset = "0x2C60200", VA = "0x182C61000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2C60380", Offset = "0x2C5F580", VA = "0x182C60380")]
		public void MaintainRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x2C60330", Offset = "0x2C5F530", VA = "0x182C60330")]
		public void MaintainBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2C603D0", Offset = "0x2C5F5D0", VA = "0x182C603D0", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2C60950", Offset = "0x2C5FB50", VA = "0x182C60950", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2C607E0", Offset = "0x2C5F9E0", VA = "0x182C607E0", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x2C60F90", Offset = "0x2C60190", VA = "0x182C60F90")]
		public IKSolverLimb()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x2C60F10", Offset = "0x2C60110", VA = "0x182C60F10")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2C60AA0", Offset = "0x2C5FCA0", VA = "0x182C60AA0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2C5F530", Offset = "0x2C5E730", VA = "0x182C5F530")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		public class LookAtBone : Bone
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400068F")]
			public Vector3 baseForwardOffsetEuler;

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public Vector3 forward
			{
				[Cpp2IlInjected.Token(Token = "0x60006C2")]
				[Cpp2IlInjected.Address(RVA = "0x2C6D060", Offset = "0x2C6C260", VA = "0x182C6D060")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D020", Offset = "0x2C6C220", VA = "0x182C6D020")]
			public LookAtBone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D030", Offset = "0x2C6C230", VA = "0x182C6D030")]
			public LookAtBone(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x2C6CD80", Offset = "0x2C6BF80", VA = "0x182C6CD80")]
			public void Initiate(Transform root)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x2C6CEB0", Offset = "0x2C6C0B0", VA = "0x182C6CEB0")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public LookAtBone[] spine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public LookAtBone head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public LookAtBone[] eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		[Range(0f, 1f)]
		public float headWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AnimationCurve spineWeightCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public Vector3 spineTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		protected Vector3[] spineForwards;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		protected Vector3[] headForwards;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		protected Vector3[] eyeForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private bool isDirty;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected bool spineIsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x2C63DE0", Offset = "0x2C62FE0", VA = "0x182C63DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected bool spineIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x2C63DC0", Offset = "0x2C62FC0", VA = "0x182C63DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected bool headIsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x2C63DB0", Offset = "0x2C62FB0", VA = "0x182C63DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected bool headIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x2C63D40", Offset = "0x2C62F40", VA = "0x182C63D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected bool eyesIsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2C63C50", Offset = "0x2C62E50", VA = "0x182C63C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected bool eyesIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2C63C30", Offset = "0x2C62E30", VA = "0x182C63C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2C62950", Offset = "0x2C61B50", VA = "0x182C62950")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2C626C0", Offset = "0x2C618C0", VA = "0x182C626C0")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2C62880", Offset = "0x2C61A80", VA = "0x182C62880")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x2C625D0", Offset = "0x2C617D0", VA = "0x182C625D0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x2C62760", Offset = "0x2C61960", VA = "0x182C62760")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x2C629C0", Offset = "0x2C61BC0", VA = "0x182C629C0")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x2C637C0", Offset = "0x2C629C0", VA = "0x182C637C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x2C625C0", Offset = "0x2C617C0", VA = "0x182C625C0")]
		public void SetDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2C61020", Offset = "0x2C60220", VA = "0x182C61020", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x2C61AF0", Offset = "0x2C60CF0", VA = "0x182C61AF0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x2C61810", Offset = "0x2C60A10", VA = "0x182C61810", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x2C61650", Offset = "0x2C60850", VA = "0x182C61650", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x2C62510", Offset = "0x2C61710", VA = "0x182C62510")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x2C61DC0", Offset = "0x2C60FC0", VA = "0x182C61DC0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x2C62250", Offset = "0x2C61450", VA = "0x182C62250", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2C634B0", Offset = "0x2C626B0", VA = "0x182C634B0")]
		protected void SolveSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x2C63130", Offset = "0x2C62330", VA = "0x182C63130")]
		protected void SolveHead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x2C62B10", Offset = "0x2C61D10", VA = "0x182C62B10")]
		protected void SolveEyes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2C611B0", Offset = "0x2C603B0", VA = "0x182C611B0")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2C62360", Offset = "0x2C61560", VA = "0x182C62360")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2C63A10", Offset = "0x2C62C10", VA = "0x182C63A10")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000EB")]
		public class TrigonometricBone : Bone
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000690")]
			private Quaternion targetToLocalSpace;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000691")]
			private Vector3 defaultLocalBendNormal;

			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D790", Offset = "0x2C6C990", VA = "0x182C6D790")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D6B0", Offset = "0x2C6C8B0", VA = "0x182C6D6B0")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D5D0", Offset = "0x2C6C7D0", VA = "0x182C6D5D0")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D020", Offset = "0x2C6C220", VA = "0x182C6D020")]
			public TrigonometricBone()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public Quaternion IKRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public Vector3 bendNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public TrigonometricBone bone1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public TrigonometricBone bone2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public TrigonometricBone bone3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected Vector3 weightIKPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected bool directHierarchy;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2C65D80", Offset = "0x2C64F80", VA = "0x182C65D80")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2C65FF0", Offset = "0x2C651F0", VA = "0x182C65FF0")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2C662F0", Offset = "0x2C654F0", VA = "0x182C662F0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2C66280", Offset = "0x2C65480", VA = "0x182C66280")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2C64550", Offset = "0x2C63750", VA = "0x182C64550")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xD1DAE0", Offset = "0xD1CCE0", VA = "0x180D1DAE0")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2C646C0", Offset = "0x2C638C0", VA = "0x182C646C0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2C64560", Offset = "0x2C63760", VA = "0x182C64560", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2C66960", Offset = "0x2C65B60", VA = "0x182C66960", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2C63ED0", Offset = "0x2C630D0", VA = "0x182C63ED0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2C64C40", Offset = "0x2C63E40", VA = "0x182C64C40", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2C66220", Offset = "0x2C65420", VA = "0x182C66220")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2C66300", Offset = "0x2C65500", VA = "0x182C66300")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x2C64300", Offset = "0x2C63500", VA = "0x182C64300")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2C650D0", Offset = "0x2C642D0", VA = "0x182C650D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2C64B10", Offset = "0x2C63D10", VA = "0x182C64B10")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2C64810", Offset = "0x2C63A10", VA = "0x182C64810")]
		private void InitiateBones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2C65340", Offset = "0x2C64540", VA = "0x182C65340", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2C63F30", Offset = "0x2C63130", VA = "0x182C63F30")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2C66A80", Offset = "0x2C65C80", VA = "0x182C66A80")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x200012F")]
			public enum ShoulderRotationMode
			{
				[Cpp2IlInjected.Token(Token = "0x4000878")]
				YawPitch,
				[Cpp2IlInjected.Token(Token = "0x4000879")]
				FromTo
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000692")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000693")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000694")]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000697")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000698")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[Range(0f, 1f)]
			public float shoulderTwistWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000699")]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400069A")]
			[Tooltip("Angular offset of the elbow bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400069B")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400069C")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x400069D")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			[Range(0.01f, 2f)]
			public float armLengthMlp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400069E")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400069F")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
			[Cpp2IlInjected.Token(Token = "0x40006A0")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
			[Cpp2IlInjected.Token(Token = "0x40006A1")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40006A2")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			private bool hasShoulder;

			[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
			[Cpp2IlInjected.Token(Token = "0x40006A6")]
			private Vector3 chestForwardAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			private Vector3 chestUpAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			private Quaternion chestRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
			[Cpp2IlInjected.Token(Token = "0x40006A9")]
			private Vector3 chestForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40006AA")]
			private Vector3 chestUp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
			[Cpp2IlInjected.Token(Token = "0x40006AB")]
			private Quaternion forearmRelToUpperArm;

			[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
			[Cpp2IlInjected.Token(Token = "0x40006AC")]
			private Vector3 upperArmBendAxis;

			[Cpp2IlInjected.Token(Token = "0x40006AD")]
			private const float yawOffsetAngle = 45f;

			[Cpp2IlInjected.Token(Token = "0x40006AE")]
			private const float pitchOffsetAngle = -30f;

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public Vector3 position
			{
				[Cpp2IlInjected.Token(Token = "0x60006C7")]
				[Cpp2IlInjected.Address(RVA = "0xB34030", Offset = "0xB33230", VA = "0x180B34030")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60006C8")]
				[Cpp2IlInjected.Address(RVA = "0xB33FB0", Offset = "0xB331B0", VA = "0x180B33FB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public Quaternion rotation
			{
				[Cpp2IlInjected.Token(Token = "0x60006C9")]
				[Cpp2IlInjected.Address(RVA = "0x171F800", Offset = "0x171EA00", VA = "0x18171F800")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60006CA")]
				[Cpp2IlInjected.Address(RVA = "0x171A500", Offset = "0x1719700", VA = "0x18171A500")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			private VirtualBone shoulder
			{
				[Cpp2IlInjected.Token(Token = "0x60006CB")]
				[Cpp2IlInjected.Address(RVA = "0x2E79740", Offset = "0x2E78940", VA = "0x182E79740")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			private VirtualBone upperArm
			{
				[Cpp2IlInjected.Token(Token = "0x60006CC")]
				[Cpp2IlInjected.Address(RVA = "0x2E79780", Offset = "0x2E78980", VA = "0x182E79780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			private VirtualBone forearm
			{
				[Cpp2IlInjected.Token(Token = "0x60006CD")]
				[Cpp2IlInjected.Address(RVA = "0x2E79680", Offset = "0x2E78880", VA = "0x182E79680")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			private VirtualBone hand
			{
				[Cpp2IlInjected.Token(Token = "0x60006CE")]
				[Cpp2IlInjected.Address(RVA = "0x2E796E0", Offset = "0x2E788E0", VA = "0x182E796E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x2E75260", Offset = "0x2E74460", VA = "0x182E75260", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0x2E75F30", Offset = "0x2E75130", VA = "0x182E75F30", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x2E74970", Offset = "0x2E73B70", VA = "0x182E74970", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x2E78640", Offset = "0x2E77840", VA = "0x182E78640")]
			private void Stretching()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x2E76340", Offset = "0x2E75540", VA = "0x182E76340")]
			public void Solve(bool isLeft)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0x2E762D0", Offset = "0x2E754D0", VA = "0x182E762D0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E79090", Offset = "0x2E78290", VA = "0x182E79090", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0x2E74A40", Offset = "0x2E73C40", VA = "0x182E74A40")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0x2E74B40", Offset = "0x2E73D40", VA = "0x182E74B40")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0x2E78F50", Offset = "0x2E78150", VA = "0x182E78F50")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0x2E79520", Offset = "0x2E78720", VA = "0x182E79520")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		public abstract class BodyPart
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006B1")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006B2")]
			protected bool initiated;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40006B3")]
			protected Vector3 rootPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006B4")]
			protected Quaternion rootRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006B5")]
			protected int index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40006B6")]
			protected int LOD;

			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public float sqrMag
			{
				[Cpp2IlInjected.Token(Token = "0x60006DF")]
				[Cpp2IlInjected.Address(RVA = "0x921990", Offset = "0x920B90", VA = "0x180921990")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60006E0")]
				[Cpp2IlInjected.Address(RVA = "0x9219A0", Offset = "0x920BA0", VA = "0x1809219A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public float mag
			{
				[Cpp2IlInjected.Token(Token = "0x60006E1")]
				[Cpp2IlInjected.Address(RVA = "0x921B00", Offset = "0x920D00", VA = "0x180921B00")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60006E2")]
				[Cpp2IlInjected.Address(RVA = "0x9216A0", Offset = "0x9208A0", VA = "0x1809216A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(Slot = "4")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void PreSolve();

			[Cpp2IlInjected.Token(Token = "0x60006DC")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Cpp2IlInjected.Token(Token = "0x60006DD")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void ApplyOffsets(float scale);

			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void ResetOffsets();

			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(RVA = "0x83DD10", Offset = "0x83CF10", VA = "0x18083DD10")]
			public void SetLOD(int LOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0x2E79A80", Offset = "0x2E78C80", VA = "0x182E79A80")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x2E797E0", Offset = "0x2E789E0", VA = "0x182E797E0")]
			public void MovePosition(Vector3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x2E799B0", Offset = "0x2E78BB0", VA = "0x182E799B0")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x2E79F40", Offset = "0x2E79140", VA = "0x182E79F40")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x2E79D30", Offset = "0x2E78F30", VA = "0x182E79D30")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0x2E79B90", Offset = "0x2E78D90", VA = "0x182E79B90")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x2E7A040", Offset = "0x2E79240", VA = "0x182E7A040")]
			public void Visualize(Color color)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x2E7A1B0", Offset = "0x2E793B0", VA = "0x182E7A1B0")]
			public void Visualize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0x2E7A340", Offset = "0x2E79540", VA = "0x182E7A340")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000EE")]
		public class Footstep
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006B7")]
			public float stepSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006B8")]
			public Vector3 characterSpaceOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006B9")]
			public Vector3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40006BA")]
			public Quaternion rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40006BB")]
			public Quaternion stepToRootRot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40006BC")]
			public bool isSupportLeg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
			[Cpp2IlInjected.Token(Token = "0x40006BD")]
			public bool relaxFlag;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40006BF")]
			public Vector3 stepFrom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public Vector3 stepTo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			public Quaternion stepFromRot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public Quaternion stepToRot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			private Quaternion footRelativeToRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			private float supportLegW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			private float supportLegWV;

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			public bool isStepping
			{
				[Cpp2IlInjected.Token(Token = "0x60006ED")]
				[Cpp2IlInjected.Address(RVA = "0x2E7B400", Offset = "0x2E7A600", VA = "0x182E7B400")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public float stepProgress
			{
				[Cpp2IlInjected.Token(Token = "0x60006EE")]
				[Cpp2IlInjected.Address(RVA = "0xA15610", Offset = "0xA14810", VA = "0x180A15610")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60006EF")]
				[Cpp2IlInjected.Address(RVA = "0x21BA430", Offset = "0x21B9630", VA = "0x1821BA430")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x2E7B270", Offset = "0x2E7A470", VA = "0x182E7B270")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x2E7AA50", Offset = "0x2E79C50", VA = "0x182E7AA50")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x2E7AAA0", Offset = "0x2E79CA0", VA = "0x182E7AAA0")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x2E7AE70", Offset = "0x2E7A070", VA = "0x182E7AE70")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x2E7AC70", Offset = "0x2E79E70", VA = "0x182E7AC70")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0x2E7B030", Offset = "0x2E7A230", VA = "0x182E7B030")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public class Leg : BodyPart
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			[Tooltip("Angular offset of knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
			public float bendToTargetWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40006CD")]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			[Range(0.01f, 2f)]
			public float legLengthMlp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40006CE")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40006CF")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
			[Cpp2IlInjected.Token(Token = "0x40006D0")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x40006D1")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40006D2")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
			[Cpp2IlInjected.Token(Token = "0x40006D3")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40006D4")]
			[HideInInspector]
			public float currentMag;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40006D5")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40006DA")]
			private Vector3 footPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x40006DB")]
			private Quaternion footRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
			[Cpp2IlInjected.Token(Token = "0x40006DC")]
			private Vector3 bendNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40006DD")]
			private Quaternion calfRelToThigh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40006DE")]
			private Quaternion thighRelToFoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40006DF")]
			private Vector3 bendNormalRelToPelvis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
			[Cpp2IlInjected.Token(Token = "0x40006E0")]
			private Vector3 bendNormalRelToTarget;

			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public Vector3 position
			{
				[Cpp2IlInjected.Token(Token = "0x60006F6")]
				[Cpp2IlInjected.Address(RVA = "0x105AAF0", Offset = "0x1059CF0", VA = "0x18105AAF0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60006F7")]
				[Cpp2IlInjected.Address(RVA = "0x2E89970", Offset = "0x2E88B70", VA = "0x182E89970")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public Quaternion rotation
			{
				[Cpp2IlInjected.Token(Token = "0x60006F8")]
				[Cpp2IlInjected.Address(RVA = "0x133CFB0", Offset = "0x133C1B0", VA = "0x18133CFB0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60006F9")]
				[Cpp2IlInjected.Address(RVA = "0x133C910", Offset = "0x133BB10", VA = "0x18133C910")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public bool hasToes
			{
				[Cpp2IlInjected.Token(Token = "0x60006FA")]
				[Cpp2IlInjected.Address(RVA = "0xE75F00", Offset = "0xE75100", VA = "0x180E75F00")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60006FB")]
				[Cpp2IlInjected.Address(RVA = "0xE748F0", Offset = "0xE73AF0", VA = "0x180E748F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public VirtualBone thigh
			{
				[Cpp2IlInjected.Token(Token = "0x60006FC")]
				[Cpp2IlInjected.Address(RVA = "0x2E79740", Offset = "0x2E78940", VA = "0x182E79740")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			private VirtualBone calf
			{
				[Cpp2IlInjected.Token(Token = "0x60006FD")]
				[Cpp2IlInjected.Address(RVA = "0x2E89870", Offset = "0x2E88A70", VA = "0x182E89870")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			private VirtualBone foot
			{
				[Cpp2IlInjected.Token(Token = "0x60006FE")]
				[Cpp2IlInjected.Address(RVA = "0x2E898B0", Offset = "0x2E88AB0", VA = "0x182E898B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			private VirtualBone toes
			{
				[Cpp2IlInjected.Token(Token = "0x60006FF")]
				[Cpp2IlInjected.Address(RVA = "0x2E89930", Offset = "0x2E88B30", VA = "0x182E89930")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public VirtualBone lastBone
			{
				[Cpp2IlInjected.Token(Token = "0x6000700")]
				[Cpp2IlInjected.Address(RVA = "0x2E898F0", Offset = "0x2E88AF0", VA = "0x182E898F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public Vector3 thighRelativeToPelvis
			{
				[Cpp2IlInjected.Token(Token = "0x6000701")]
				[Cpp2IlInjected.Address(RVA = "0x2C5A5A0", Offset = "0x2C597A0", VA = "0x182C5A5A0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000702")]
				[Cpp2IlInjected.Address(RVA = "0x2C5A7C0", Offset = "0x2C599C0", VA = "0x182C5A7C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x2E87390", Offset = "0x2E86590", VA = "0x182E87390", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x2E87E10", Offset = "0x2E87010", VA = "0x182E87E10", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x2E861E0", Offset = "0x2E853E0", VA = "0x182E861E0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x2E86A10", Offset = "0x2E85C10", VA = "0x182E86A10")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x2E86B60", Offset = "0x2E85D60", VA = "0x182E86B60")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x2E88740", Offset = "0x2E87940", VA = "0x182E88740")]
			public void Solve(bool stretch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x2E86E00", Offset = "0x2E86000", VA = "0x182E86E00")]
			private void FixTwistRotations()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0x2E88AD0", Offset = "0x2E87CD0", VA = "0x182E88AD0")]
			private void Stretching()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x2E893C0", Offset = "0x2E885C0", VA = "0x182E893C0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0x2E88680", Offset = "0x2E87880", VA = "0x182E88680", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x2E89770", Offset = "0x2E88970", VA = "0x182E89770")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		public class Locomotion
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006E1")]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			[Range(0f, 1f)]
			public float weight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006E2")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006E3")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40006E4")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006E5")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40006E6")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006E7")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40006E8")]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			[Range(0.9f, 1f)]
			public float maxLegStretch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			[Tooltip("Reduce this value if locomotion makes the head bob too much.")]
			public float maxBodyYOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[Range(0f, 180f)]
			public float relaxLegTwistMinAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40006F1")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			[HideInInspector]
			public bool blockingEnabled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40006F3")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40006F4")]
			[HideInInspector]
			public float raycastRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40006F5")]
			[HideInInspector]
			public float raycastHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40006F6")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40006F7")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			private Footstep[] footsteps;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			private Vector3 lastComPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			private Vector3 comVelocity;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			private int leftFootIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			private int rightFootIndex;

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public Vector3 centerOfMass
			{
				[Cpp2IlInjected.Token(Token = "0x600070E")]
				[Cpp2IlInjected.Address(RVA = "0xF3E9C0", Offset = "0xF3DBC0", VA = "0x180F3E9C0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600070F")]
				[Cpp2IlInjected.Address(RVA = "0x22193A0", Offset = "0x22185A0", VA = "0x1822193A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B3")]
			public Vector3 leftFootstepPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000716")]
				[Cpp2IlInjected.Address(RVA = "0x2E8D1B0", Offset = "0x2E8C3B0", VA = "0x182E8D1B0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B4")]
			public Vector3 rightFootstepPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000717")]
				[Cpp2IlInjected.Address(RVA = "0x2E8D260", Offset = "0x2E8C460", VA = "0x182E8D260")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B5")]
			public Quaternion leftFootstepRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0x2E8D210", Offset = "0x2E8C410", VA = "0x182E8D210")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B6")]
			public Quaternion rightFootstepRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x2E8D2C0", Offset = "0x2E8C4C0", VA = "0x182E8D2C0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2E8A360", Offset = "0x2E89560", VA = "0x182E8A360")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2E8A7A0", Offset = "0x2E899A0", VA = "0x182E8A7A0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2E8A730", Offset = "0x2E89930", VA = "0x182E8A730")]
			public void Relax()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x2E89BC0", Offset = "0x2E88DC0", VA = "0x182E89BC0")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x2E89990", Offset = "0x2E88B90", VA = "0x182E89990")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x2E8AB90", Offset = "0x2E89D90", VA = "0x182E8AB90")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x2E8CE50", Offset = "0x2E8C050", VA = "0x182E8CE50")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x2E8A0B0", Offset = "0x2E892B0", VA = "0x182E8A0B0")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x2E8A130", Offset = "0x2E89330", VA = "0x182E8A130")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x2E8D0B0", Offset = "0x2E8C2B0", VA = "0x182E8D0B0")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		public class Spine : BodyPart
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust it's position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000701")]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000702")]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000703")]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000704")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000705")]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000706")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000707")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
			[Cpp2IlInjected.Token(Token = "0x4000708")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000709")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			public float neckStiffness;

			[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
			[Cpp2IlInjected.Token(Token = "0x400070A")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400070B")]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x400070C")]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			[Range(0f, 1f)]
			public float headClampWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400070D")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x400070E")]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			[Range(0f, 1f)]
			public float maintainPelvisPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400070F")]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			public float maxRootAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
			[Cpp2IlInjected.Token(Token = "0x4000710")]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			[Range(-180f, 180f)]
			public float rootHeadingOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000711")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
			[Cpp2IlInjected.Token(Token = "0x4000712")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x4000713")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000714")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000715")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
			[Cpp2IlInjected.Token(Token = "0x4000716")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000717")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x4000718")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000719")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x400071A")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400071B")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400071C")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
			[Cpp2IlInjected.Token(Token = "0x400071D")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x400071E")]
			[HideInInspector]
			public Vector3 headPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			private Quaternion headRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x4000722")]
			private Quaternion pelvisRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x4000723")]
			private Quaternion anchorRelativeToPelvis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x4000724")]
			private Quaternion pelvisRelativeRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
			[Cpp2IlInjected.Token(Token = "0x4000725")]
			private Quaternion chestRelativeRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			private Vector3 headDeltaPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
			[Cpp2IlInjected.Token(Token = "0x4000727")]
			private Quaternion pelvisDeltaRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
			[Cpp2IlInjected.Token(Token = "0x4000728")]
			private Quaternion chestTargetRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
			[Cpp2IlInjected.Token(Token = "0x4000729")]
			private int pelvisIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
			[Cpp2IlInjected.Token(Token = "0x400072A")]
			private int spineIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
			[Cpp2IlInjected.Token(Token = "0x400072B")]
			private int chestIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
			[Cpp2IlInjected.Token(Token = "0x400072C")]
			private int neckIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
			[Cpp2IlInjected.Token(Token = "0x400072D")]
			private int headIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
			[Cpp2IlInjected.Token(Token = "0x400072E")]
			private float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
			[Cpp2IlInjected.Token(Token = "0x400072F")]
			private bool hasChest;

			[Cpp2IlInjected.FieldOffset(Offset = "0x211")]
			[Cpp2IlInjected.Token(Token = "0x4000730")]
			private bool hasNeck;

			[Cpp2IlInjected.FieldOffset(Offset = "0x212")]
			[Cpp2IlInjected.Token(Token = "0x4000731")]
			private bool hasLegs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
			[Cpp2IlInjected.Token(Token = "0x4000732")]
			private float headHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
			[Cpp2IlInjected.Token(Token = "0x4000733")]
			private float sizeMlp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
			[Cpp2IlInjected.Token(Token = "0x4000734")]
			private Vector3 chestForward;

			[Cpp2IlInjected.Token(Token = "0x170000B7")]
			public VirtualBone pelvis
			{
				[Cpp2IlInjected.Token(Token = "0x600071E")]
				[Cpp2IlInjected.Address(RVA = "0x2E92100", Offset = "0x2E91300", VA = "0x182E92100")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B8")]
			public VirtualBone firstSpineBone
			{
				[Cpp2IlInjected.Token(Token = "0x600071F")]
				[Cpp2IlInjected.Address(RVA = "0x2E92040", Offset = "0x2E91240", VA = "0x182E92040")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B9")]
			public VirtualBone chest
			{
				[Cpp2IlInjected.Token(Token = "0x6000720")]
				[Cpp2IlInjected.Address(RVA = "0x2E91FD0", Offset = "0x2E911D0", VA = "0x182E91FD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BA")]
			private VirtualBone neck
			{
				[Cpp2IlInjected.Token(Token = "0x6000721")]
				[Cpp2IlInjected.Address(RVA = "0x2E920C0", Offset = "0x2E912C0", VA = "0x182E920C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BB")]
			public VirtualBone head
			{
				[Cpp2IlInjected.Token(Token = "0x6000722")]
				[Cpp2IlInjected.Address(RVA = "0x2E92080", Offset = "0x2E91280", VA = "0x182E92080")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BC")]
			public Quaternion anchorRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000723")]
				[Cpp2IlInjected.Address(RVA = "0x28A2140", Offset = "0x28A1340", VA = "0x1828A2140")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x6000724")]
				[Cpp2IlInjected.Address(RVA = "0x2E92150", Offset = "0x2E91350", VA = "0x182E92150")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BD")]
			public Quaternion anchorRelativeToHead
			{
				[Cpp2IlInjected.Token(Token = "0x6000725")]
				[Cpp2IlInjected.Address(RVA = "0x2E91FC0", Offset = "0x2E911C0", VA = "0x182E91FC0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x6000726")]
				[Cpp2IlInjected.Address(RVA = "0x2E92140", Offset = "0x2E91340", VA = "0x182E92140")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x2E8F2F0", Offset = "0x2E8E4F0", VA = "0x182E8F2F0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2E90150", Offset = "0x2E8F350", VA = "0x182E90150", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x2E8D8F0", Offset = "0x2E8CAF0", VA = "0x182E8D8F0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x2E8E6E0", Offset = "0x2E8D8E0", VA = "0x182E8E6E0")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x2E90A00", Offset = "0x2E8FC00", VA = "0x182E90A00")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x2E8E900", Offset = "0x2E8DB00", VA = "0x182E8E900")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x2E90590", Offset = "0x2E8F790", VA = "0x182E90590")]
			private void SolvePelvis()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x2E91B00", Offset = "0x2E90D00", VA = "0x182E91B00", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x2E90480", Offset = "0x2E8F680", VA = "0x182E90480", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x2E8D430", Offset = "0x2E8C630", VA = "0x182E8D430")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x2E8EBF0", Offset = "0x2E8DDF0", VA = "0x182E8EBF0")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x2E91530", Offset = "0x2E90730", VA = "0x182E91530")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2E8EE20", Offset = "0x2E8E020", VA = "0x182E8EE20")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2E8E020", Offset = "0x2E8D220", VA = "0x182E8E020")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2E8E320", Offset = "0x2E8D520", VA = "0x182E8E320")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x2E91DD0", Offset = "0x2E90FD0", VA = "0x182E91DD0")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public enum PositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x4000736")]
			Pelvis,
			[Cpp2IlInjected.Token(Token = "0x4000737")]
			Chest,
			[Cpp2IlInjected.Token(Token = "0x4000738")]
			Head,
			[Cpp2IlInjected.Token(Token = "0x4000739")]
			LeftHand,
			[Cpp2IlInjected.Token(Token = "0x400073A")]
			RightHand,
			[Cpp2IlInjected.Token(Token = "0x400073B")]
			LeftFoot,
			[Cpp2IlInjected.Token(Token = "0x400073C")]
			RightFoot,
			[Cpp2IlInjected.Token(Token = "0x400073D")]
			LeftHeel,
			[Cpp2IlInjected.Token(Token = "0x400073E")]
			RightHeel
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		public enum RotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x4000740")]
			Pelvis,
			[Cpp2IlInjected.Token(Token = "0x4000741")]
			Chest,
			[Cpp2IlInjected.Token(Token = "0x4000742")]
			Head
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		public class VirtualBone
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000743")]
			public Vector3 readPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000744")]
			public Quaternion readRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000745")]
			public Vector3 solverPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000746")]
			public Quaternion solverRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000747")]
			public float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000748")]
			public float sqrMag;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000749")]
			public Vector3 axis;

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x2E94640", Offset = "0x2E93840", VA = "0x182E94640")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x2E927E0", Offset = "0x2E919E0", VA = "0x182E927E0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x2E94380", Offset = "0x2E93580", VA = "0x182E94380")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x2E923B0", Offset = "0x2E915B0", VA = "0x182E923B0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x2E92810", Offset = "0x2E91A10", VA = "0x182E92810")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D30", Offset = "0x2E91F30", VA = "0x182E92D30")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x2E92A50", Offset = "0x2E91C50", VA = "0x182E92A50")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x2E92FF0", Offset = "0x2E921F0", VA = "0x182E92FF0")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2E93BA0", Offset = "0x2E92DA0", VA = "0x182E93BA0")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2E92160", Offset = "0x2E91360", VA = "0x182E92160")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x2E93540", Offset = "0x2E92740", VA = "0x182E93540")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x2E93400", Offset = "0x2E92600", VA = "0x182E93400")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x2E930D0", Offset = "0x2E922D0", VA = "0x182E930D0")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private Transform[] solverTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private bool hasChest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private bool hasNeck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private bool hasShoulders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private bool hasToes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private bool hasLegs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private Vector3[] readPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private Quaternion[] readRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private Vector3[] solvedPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private Quaternion[] solvedRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private Quaternion[] defaultLocalRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private Vector3[] defaultLocalPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private Vector3 rootV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private Vector3 rootVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private Vector3 bodyOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private int supportLegIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private int lastLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		[Range(0f, 2f)]
		public int LOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
		public float scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private Leg[] legs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private Arm[] arms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private Vector3 headPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private Vector3 headDeltaPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private Vector3 raycastOriginPelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private Vector3 lastOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private Vector3 debugPos1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private Vector3 debugPos2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private Vector3 debugPos3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private Vector3 debugPos4;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x94EE90", Offset = "0x94E090", VA = "0x18094EE90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0xA0BB10", Offset = "0xA0AD10", VA = "0x180A0BB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x2C6A050", Offset = "0x2C69250", VA = "0x182C6A050")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x2C689F0", Offset = "0x2C67BF0", VA = "0x182C689F0")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x2C67640", Offset = "0x2C66840", VA = "0x182C67640")]
		public void DefaultAnimationCurves()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x2C66D70", Offset = "0x2C65F70", VA = "0x182C66D70")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x2C67270", Offset = "0x2C66470", VA = "0x182C67270")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x2C67490", Offset = "0x2C66690", VA = "0x182C67490")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x2C66BA0", Offset = "0x2C65DA0", VA = "0x182C66BA0")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x2C69E80", Offset = "0x2C69080", VA = "0x182C69E80")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BF90", Offset = "0x2C6B190", VA = "0x182C6BF90", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x2C677C0", Offset = "0x2C669C0", VA = "0x182C677C0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2C68790", Offset = "0x2C67990", VA = "0x182C68790", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C68730", Offset = "0x2C67930", VA = "0x182C68730", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C68D70", Offset = "0x2C67F70", VA = "0x182C68D70", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C67A10", Offset = "0x2C66C10", VA = "0x182C67A10")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2C68890", Offset = "0x2C67A90", VA = "0x182C68890")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C170", Offset = "0x2C6B370", VA = "0x182C6C170")]
		private void UpdateSolverTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C69020", Offset = "0x2C68220", VA = "0x182C69020", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C69080", Offset = "0x2C68280", VA = "0x182C69080", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C330", Offset = "0x2C6B530", VA = "0x182C6C330")]
		private void WriteTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C69780", Offset = "0x2C68980", VA = "0x182C69780")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2C6A4E0", Offset = "0x2C696E0", VA = "0x182C6A4E0")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2C687F0", Offset = "0x2C679F0", VA = "0x182C687F0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C68840", Offset = "0x2C67A40", VA = "0x182C68840")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C970", Offset = "0x2C6BB70", VA = "0x182C6C970")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2C67DA0", Offset = "0x2C66FA0", VA = "0x182C67DA0")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C6CB30", Offset = "0x2C6BD30", VA = "0x182C6CB30")]
		public IKSolverVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public IK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A01930", Offset = "0x2A00B30", VA = "0x182A01930")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A01880", Offset = "0x2A00A80", VA = "0x182A01880")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A016C0", Offset = "0x2A008C0", VA = "0x182A016C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A01770", Offset = "0x2A00970", VA = "0x182A01770")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A01AF0", Offset = "0x2A00CF0", VA = "0x182A01AF0")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class TwistSolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[Tooltip("The transform that this solver operates on.")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform[] children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		[Range(0f, 1f)]
		public float parentChildCrossfade;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
		public float twistAngleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private Vector3 twistAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private Vector3 axis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private Vector3 axisRelativeToParentDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private Vector3 axisRelativeToChildDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private Quaternion[] childRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private bool inititated;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A02780", Offset = "0x2A01980", VA = "0x182A02780")]
		public TwistSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A01B40", Offset = "0x2A00D40", VA = "0x182A01B40")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A021A0", Offset = "0x2A013A0", VA = "0x182A021A0")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class InteractionEffector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private Poser poser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private IKEffector effector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private float timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private float length;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private float fadeInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private float defaultPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private float defaultRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private float defaultPull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private float defaultReach;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private float defaultPush;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private float defaultPushParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private float defaultBendGoalWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private float resetTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private bool positionWeightUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private bool rotationWeightUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private bool pullUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private bool reachUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private bool pushUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private bool pushParentUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private bool bendGoalWeightUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x67")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private bool pickedUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private bool defaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private bool pickUpOnPostFBBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private Vector3 pickUpPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private Vector3 pausePositionRelative;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private Quaternion pickUpRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private Quaternion pauseRotationRelative;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private InteractionTarget interactionTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private List<bool> triggered;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private InteractionSystem interactionSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private bool started;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public FullBodyBipedEffector effectorType
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x3F3040", Offset = "0x3F2240", VA = "0x1803F3040")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x421A30", Offset = "0x420C30", VA = "0x180421A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool isPaused
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x4163D0", Offset = "0x4155D0", VA = "0x1804163D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x415F10", Offset = "0x415110", VA = "0x180415F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public InteractionObject interactionObject
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x421630", Offset = "0x420830", VA = "0x180421630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool inInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x2E7DBA0", Offset = "0x2E7CDA0", VA = "0x182E7DBA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public float progress
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E7DC00", Offset = "0x2E7CE00", VA = "0x182E7DC00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2E7DB20", Offset = "0x2E7CD20", VA = "0x182E7DB20")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2E7B5E0", Offset = "0x2E7A7E0", VA = "0x182E7B5E0")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2E7CD30", Offset = "0x2E7BF30", VA = "0x182E7CD30")]
		private void StoreDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2E7BF00", Offset = "0x2E7B100", VA = "0x182E7BF00")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x2E7BA40", Offset = "0x2E7AC40", VA = "0x182E7BA40")]
		public bool Pause()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2E7C560", Offset = "0x2E7B760", VA = "0x182E7C560")]
		public bool Resume()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2E7C610", Offset = "0x2E7B810", VA = "0x182E7C610")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2E7D230", Offset = "0x2E7C430", VA = "0x182E7D230")]
		public void Update(Transform root, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2E7CF20", Offset = "0x2E7C120", VA = "0x182E7CF20")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2E7BC00", Offset = "0x2E7AE00", VA = "0x182E7BC00")]
		private void PickUp(Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2E7CB00", Offset = "0x2E7BD00", VA = "0x182E7CB00")]
		public bool Stop()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2E7B680", Offset = "0x2E7A880", VA = "0x182E7B680")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class InteractionLookAt
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		[HideInInspector]
		public bool isPaused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private Transform lookAtTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private float stopLookTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private bool firstFBBIKSolve;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x2E7DEC0", Offset = "0x2E7D0C0", VA = "0x182E7DEC0")]
		public void Look(Transform target, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2E7E0C0", Offset = "0x2E7D2C0", VA = "0x182E7E0C0")]
		public void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x2E7E370", Offset = "0x2E7D570", VA = "0x182E7E370")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2E7E240", Offset = "0x2E7D440", VA = "0x182E7E240")]
		public void SolveSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2E7E160", Offset = "0x2E7D360", VA = "0x182E7E160")]
		public void SolveHead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2E7E640", Offset = "0x2E7D840", VA = "0x182E7E640")]
		public InteractionLookAt()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public class InteractionEvent
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400074A")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400074B")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
			[Cpp2IlInjected.Token(Token = "0x400074C")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400074D")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400074E")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400074F")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x2E7DD20", Offset = "0x2E7CF20", VA = "0x182E7DD20")]
			public void Activate(Transform t)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000F6")]
		public class Message
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000750")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000751")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Cpp2IlInjected.Token(Token = "0x4000752")]
			private const string empty = "";

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x2E8D310", Offset = "0x2E8C510", VA = "0x182E8D310")]
			public void Send(Transform t)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
			public Message()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		public class AnimatorEvent
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000753")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000754")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000755")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000756")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000757")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000758")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Cpp2IlInjected.Token(Token = "0x4000759")]
			private const string empty = "";

			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x2E74760", Offset = "0x2E73960", VA = "0x182E74760")]
			public void Activate(bool pickUp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x2E746C0", Offset = "0x2E738C0", VA = "0x182E746C0")]
			private void Activate(Animator animator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2E74600", Offset = "0x2E73800", VA = "0x182E74600")]
			private void Activate(Animation animation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x2E74960", Offset = "0x2E73B60", VA = "0x182E74960")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public class WeightCurve
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000130")]
			public enum Type
			{
				[Cpp2IlInjected.Token(Token = "0x400087B")]
				PositionWeight,
				[Cpp2IlInjected.Token(Token = "0x400087C")]
				RotationWeight,
				[Cpp2IlInjected.Token(Token = "0x400087D")]
				PositionOffsetX,
				[Cpp2IlInjected.Token(Token = "0x400087E")]
				PositionOffsetY,
				[Cpp2IlInjected.Token(Token = "0x400087F")]
				PositionOffsetZ,
				[Cpp2IlInjected.Token(Token = "0x4000880")]
				Pull,
				[Cpp2IlInjected.Token(Token = "0x4000881")]
				Reach,
				[Cpp2IlInjected.Token(Token = "0x4000882")]
				RotateBoneWeight,
				[Cpp2IlInjected.Token(Token = "0x4000883")]
				Push,
				[Cpp2IlInjected.Token(Token = "0x4000884")]
				PushParent,
				[Cpp2IlInjected.Token(Token = "0x4000885")]
				PoserWeight,
				[Cpp2IlInjected.Token(Token = "0x4000886")]
				BendGoalWeight
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400075A")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400075B")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x2E946A0", Offset = "0x2E938A0", VA = "0x182E946A0")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		public class Multiplier
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400075C")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400075D")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400075E")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x2E8D3F0", Offset = "0x2E8C5F0", VA = "0x182E8D3F0")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x23C0E60", Offset = "0x23C0060", VA = "0x1823C0E60")]
			public Multiplier()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public WeightCurve[] weightCurves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public Multiplier[] multipliers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public InteractionEvent[] events;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private InteractionTarget[] targets;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public float length
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x1195880", Offset = "0x1194A80", VA = "0x181195880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x1195890", Offset = "0x1194A90", VA = "0x181195890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x3F0880", Offset = "0x3EFA80", VA = "0x1803F0880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x3F08B0", Offset = "0x3EFAB0", VA = "0x1803F08B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Transform lookAtTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x2E800C0", Offset = "0x2E7F2C0", VA = "0x182E800C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Transform targetsRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x2E80140", Offset = "0x2E7F340", VA = "0x182E80140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2E7FFE0", Offset = "0x2E7F1E0", VA = "0x182E7FFE0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2E7FEA0", Offset = "0x2E7F0A0", VA = "0x182E7FEA0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2E7FEE0", Offset = "0x2E7F0E0", VA = "0x182E7FEE0")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2E7FF20", Offset = "0x2E7F120", VA = "0x182E7FF20")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2E7FF60", Offset = "0x2E7F160", VA = "0x182E7FF60")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2E7FFA0", Offset = "0x2E7F1A0", VA = "0x182E7FFA0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2E80030", Offset = "0x2E7F230", VA = "0x182E80030")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2E7E660", Offset = "0x2E7D860", VA = "0x182E7E660")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2E7FBD0", Offset = "0x2E7EDD0", VA = "0x182E7FBD0")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2E7F680", Offset = "0x2E7E880", VA = "0x182E7F680")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2E7F3A0", Offset = "0x2E7E5A0", VA = "0x182E7F3A0")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F0890", Offset = "0x3EFA90", VA = "0x1803F0890")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2E7F4D0", Offset = "0x2E7E6D0", VA = "0x182E7F4D0")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x3F08B0", Offset = "0x3EFAB0", VA = "0x1803F08B0")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x2E7E6A0", Offset = "0x2E7D8A0", VA = "0x182E7E6A0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x2E7F860", Offset = "0x2E7EA60", VA = "0x182E7F860")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2E80020", Offset = "0x2E7F220", VA = "0x182E80020")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x2E7EC30", Offset = "0x2E7DE30", VA = "0x182E7EC30")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2E7F7D0", Offset = "0x2E7E9D0", VA = "0x182E7F7D0")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2E7FB60", Offset = "0x2E7ED60", VA = "0x182E7FB60")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2E7F460", Offset = "0x2E7E660", VA = "0x182E7F460")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x2E80070", Offset = "0x2E7F270", VA = "0x182E80070")]
		public InteractionObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		[Header("Triggering")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[FormerlySerializedAs("collider")]
		public Collider characterCollider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private List<InteractionTrigger> inContact;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private List<int> bestRangeIndexes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public InteractionDelegate OnInteractionStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public InteractionDelegate OnInteractionPause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public InteractionDelegate OnInteractionPickUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public InteractionDelegate OnInteractionResume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public InteractionDelegate OnInteractionStop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public InteractionEventDelegate OnInteractionEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public RaycastHit raycastHit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[Space]
		[SerializeField]
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		private FullBodyBipedIK fullBody;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private InteractionEffector[] interactionEffectors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private Collider lastCollider;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private Collider c;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool inInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x2E85550", Offset = "0x2E84750", VA = "0x182E85550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public FullBodyBipedIK ik
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x989E90", Offset = "0x989090", VA = "0x180989E90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x988B10", Offset = "0x987D10", VA = "0x180988B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public List<InteractionTrigger> triggersInRange
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x434DB0", Offset = "0x433FB0", VA = "0x180434DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x421A60", Offset = "0x420C60", VA = "0x180421A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xD245B0", Offset = "0xD237B0", VA = "0x180D245B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xD245E0", Offset = "0xD237E0", VA = "0x180D245E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2E82990", Offset = "0x2E81B90", VA = "0x182E82990")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2E82850", Offset = "0x2E81A50", VA = "0x182E82850")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x2E82890", Offset = "0x2E81A90", VA = "0x182E82890")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2E828D0", Offset = "0x2E81AD0", VA = "0x182E828D0")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2E82910", Offset = "0x2E81B10", VA = "0x182E82910")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x2E82950", Offset = "0x2E81B50", VA = "0x182E82950")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x2E83870", Offset = "0x2E82A70", VA = "0x182E83870")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x2E801C0", Offset = "0x2E7F3C0", VA = "0x182E801C0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x2E812A0", Offset = "0x2E804A0", VA = "0x182E812A0")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x2E815F0", Offset = "0x2E807F0", VA = "0x182E815F0")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x2E81770", Offset = "0x2E80970", VA = "0x182E81770")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x2E81420", Offset = "0x2E80620", VA = "0x182E81420")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x2E82FC0", Offset = "0x2E821C0", VA = "0x182E82FC0")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x2E82AE0", Offset = "0x2E81CE0", VA = "0x182E82AE0")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x2E82E80", Offset = "0x2E82080", VA = "0x182E82E80")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x2E83730", Offset = "0x2E82930", VA = "0x182E83730")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x2E829D0", Offset = "0x2E81BD0", VA = "0x182E829D0")]
		public void PauseAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x2E82D70", Offset = "0x2E81F70", VA = "0x182E82D70")]
		public void ResumeAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x2E836B0", Offset = "0x2E828B0", VA = "0x182E836B0")]
		public void StopAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x2E80C40", Offset = "0x2E7FE40", VA = "0x182E80C40")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2E80F70", Offset = "0x2E80170", VA = "0x182E80F70")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x2E80D70", Offset = "0x2E7FF70", VA = "0x182E80D70")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x2E84450", Offset = "0x2E83650", VA = "0x182E84450")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x2E83DE0", Offset = "0x2E82FE0", VA = "0x182E83DE0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2E840B0", Offset = "0x2E832B0", VA = "0x182E840B0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2E805C0", Offset = "0x2E7F7C0", VA = "0x182E805C0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2E80420", Offset = "0x2E7F620", VA = "0x182E80420")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2E80730", Offset = "0x2E7F930", VA = "0x182E80730")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2E80470", Offset = "0x2E7F670", VA = "0x182E80470")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2E807D0", Offset = "0x2E7F9D0", VA = "0x182E807D0")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2E838B0", Offset = "0x2E82AB0", VA = "0x182E838B0")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2E810B0", Offset = "0x2E802B0", VA = "0x182E810B0")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2E80960", Offset = "0x2E7FB60", VA = "0x182E80960")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2E83180", Offset = "0x2E82380", VA = "0x182E83180")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2E81260", Offset = "0x2E80460", VA = "0x182E81260")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2E81280", Offset = "0x2E80480", VA = "0x182E81280")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2E81280", Offset = "0x2E80480", VA = "0x182E81280")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2E81A00", Offset = "0x2E80C00", VA = "0x182E81A00")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2E82670", Offset = "0x2E81870", VA = "0x182E82670")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2E82770", Offset = "0x2E81970", VA = "0x182E82770")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2E80200", Offset = "0x2E7F400", VA = "0x182E80200")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2E82030", Offset = "0x2E81230", VA = "0x182E82030")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2E84B10", Offset = "0x2E83D10", VA = "0x182E84B10")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2E82C20", Offset = "0x2E81E20", VA = "0x182E82C20")]
		private void Raycasting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2E84850", Offset = "0x2E83A50", VA = "0x182E84850")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2E846E0", Offset = "0x2E838E0", VA = "0x182E846E0")]
		private void UpdateEffectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2E82370", Offset = "0x2E81570", VA = "0x182E82370")]
		private void OnPreFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2E821C0", Offset = "0x2E813C0", VA = "0x182E821C0")]
		private void OnPostFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2E82110", Offset = "0x2E81310", VA = "0x182E82110")]
		private void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2E81C90", Offset = "0x2E80E90", VA = "0x182E81C90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2E81930", Offset = "0x2E80B30", VA = "0x182E81930")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2E83CE0", Offset = "0x2E82EE0", VA = "0x182E83CE0")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2E84E60", Offset = "0x2E84060", VA = "0x182E84E60")]
		public InteractionSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public enum RotationMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000760")]
			TwoDOF,
			[Cpp2IlInjected.Token(Token = "0x4000761")]
			ThreeDOF
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		public class Multiplier
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000762")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000763")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
			public Multiplier()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget's rotation to the effector bone rotation.")]
		public RotationMode rotationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
		[Range(0f, 1f)]
		public float threeDOFWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private Quaternion defaultLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private Transform lastPivot;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x2E85920", Offset = "0x2E84B20", VA = "0x182E85920")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2E857E0", Offset = "0x2E849E0", VA = "0x182E857E0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2E85820", Offset = "0x2E84A20", VA = "0x182E85820")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2E85860", Offset = "0x2E84A60", VA = "0x182E85860")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x2E858A0", Offset = "0x2E84AA0", VA = "0x182E858A0")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2E858E0", Offset = "0x2E84AE0", VA = "0x182E858E0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x2E86110", Offset = "0x2E85310", VA = "0x182E86110")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2E85710", Offset = "0x2E84910", VA = "0x182E85710")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2E85750", Offset = "0x2E84950", VA = "0x182E85750")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2E85960", Offset = "0x2E84B60", VA = "0x182E85960")]
		public void ResetRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2E859F0", Offset = "0x2E84BF0", VA = "0x182E859F0")]
		public void RotateTo(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2E86150", Offset = "0x2E85350", VA = "0x182E86150")]
		public InteractionTarget()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public class CharacterPosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000764")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000765")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000766")]
			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000767")]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000768")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000769")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x400076A")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Cpp2IlInjected.Token(Token = "0x170000BE")]
			public Vector3 offset3D
			{
				[Cpp2IlInjected.Token(Token = "0x6000759")]
				[Cpp2IlInjected.Address(RVA = "0x29ED920", Offset = "0x29ECB20", VA = "0x1829ED920")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BF")]
			public Vector3 direction3D
			{
				[Cpp2IlInjected.Token(Token = "0x600075A")]
				[Cpp2IlInjected.Address(RVA = "0x29ED810", Offset = "0x29ECA10", VA = "0x1829ED810")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x29ECEC0", Offset = "0x29EC0C0", VA = "0x1829ECEC0")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x29ED7F0", Offset = "0x29EC9F0", VA = "0x1829ED7F0")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public class CameraPosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400076B")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400076C")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400076D")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400076E")]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400076F")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x29EC900", Offset = "0x29EBB00", VA = "0x1829EC900")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0x29ECB10", Offset = "0x29EBD10", VA = "0x1829ECB10")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x29ECE20", Offset = "0x29EC020", VA = "0x1829ECE20")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		public class Range
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000131")]
			public class Interaction
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000887")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000888")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Cpp2IlInjected.Token(Token = "0x6000809")]
				[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
				public Interaction()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000770")]
			[HideInInspector]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000771")]
			[HideInInspector]
			public bool show;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000772")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000773")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000774")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0x29F7F80", Offset = "0x29F7180", VA = "0x1829F7F80")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x29F80D0", Offset = "0x29F72D0", VA = "0x1829F80D0")]
			public Range()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x29F0BE0", Offset = "0x29EFDE0", VA = "0x1829F0BE0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x29F0B60", Offset = "0x29EFD60", VA = "0x1829F0B60")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x29F0BA0", Offset = "0x29EFDA0", VA = "0x1829F0BA0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x29F0C20", Offset = "0x29EFE20", VA = "0x1829F0C20")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x29F08B0", Offset = "0x29EFAB0", VA = "0x1829F08B0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x29F08F0", Offset = "0x29EFAF0", VA = "0x1829F08F0")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x29F0C60", Offset = "0x29EFE60", VA = "0x1829F0C60")]
		public InteractionTrigger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		public class Map
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000775")]
			public Transform bone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000776")]
			public Transform target;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000777")]
			private Vector3 defaultLocalPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000778")]
			private Quaternion defaultLocalRotation;

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0x2C8A990", Offset = "0x2C89B90", VA = "0x182C8A990")]
			public Map(Transform bone, Transform target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x2C6EB30", Offset = "0x2C6DD30", VA = "0x182C6EB30")]
			public void StoreDefaultState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(RVA = "0x2C8A730", Offset = "0x2C89930", VA = "0x182C8A730")]
			public void FixTransform()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x2C8A790", Offset = "0x2C89990", VA = "0x182C8A790")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public Map[] maps;

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2C727F0", Offset = "0x2C719F0", VA = "0x182C727F0", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x2C72C40", Offset = "0x2C71E40", VA = "0x182C72C40", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x2C72D10", Offset = "0x2C71F10", VA = "0x182C72D10", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x2C72AC0", Offset = "0x2C71CC0", VA = "0x182C72AC0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2C72C50", Offset = "0x2C71E50", VA = "0x182C72C50")]
		private void StoreDefaultState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2C72B90", Offset = "0x2C71D90", VA = "0x182C72B90")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2C73040", Offset = "0x2C72240", VA = "0x182C73040")]
		public GenericPoser()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class HandPoser : Poser
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		protected Transform[] children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private Transform _poseRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private Transform[] poseChildren;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private Vector3[] defaultLocalPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private Quaternion[] defaultLocalRotations;

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CED0", Offset = "0x2C7C0D0", VA = "0x182C7CED0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D0C0", Offset = "0x2C7C2C0", VA = "0x182C7D0C0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CF70", Offset = "0x2C7C170", VA = "0x182C7CF70", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D2B0", Offset = "0x2C7C4B0", VA = "0x182C7D2B0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D110", Offset = "0x2C7C310", VA = "0x182C7D110")]
		protected void StoreDefaultState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x2C73040", Offset = "0x2C72240", VA = "0x182C73040")]
		public HandPoser()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public abstract class Poser : SolverManager
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Transform poseRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private bool initiated;

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void AutoMapping();

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x58ABD0", Offset = "0x589DD0", VA = "0x18058ABD0")]
		public void UpdateManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void InitiatePoser();

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void UpdatePoser();

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void FixPoserTransforms();

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x29F4C70", Offset = "0x29F3E70", VA = "0x1829F4C70", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x29F4C40", Offset = "0x29F3E40", VA = "0x1829F4C40", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x29F4C20", Offset = "0x29F3E20", VA = "0x1829F4C20", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x29F4CC0", Offset = "0x29F3EC0", VA = "0x1829F4CC0")]
		protected Poser()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class RagdollUtility : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		public class Rigidbone
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000779")]
			public Rigidbody r;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400077A")]
			public Transform t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400077B")]
			public Collider collider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400077C")]
			public Joint joint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400077D")]
			public Rigidbody c;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400077E")]
			public bool updateAnchor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400077F")]
			public Vector3 deltaPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000780")]
			public Quaternion deltaRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000781")]
			public float deltaTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000782")]
			public Vector3 lastPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000783")]
			public Quaternion lastRotation;

			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(RVA = "0x29FBEF0", Offset = "0x29FB0F0", VA = "0x1829FBEF0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(RVA = "0x29FB9B0", Offset = "0x29FABB0", VA = "0x1829FB9B0")]
			public void RecordVelocity()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(RVA = "0x29FBBF0", Offset = "0x29FADF0", VA = "0x1829FBBF0")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		public class Child
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000784")]
			public Transform t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000785")]
			public Vector3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000786")]
			public Quaternion localRotation;

			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(RVA = "0x29EDBE0", Offset = "0x29ECDE0", VA = "0x1829EDBE0")]
			public Child(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x29ED960", Offset = "0x29ECB60", VA = "0x1829ED960")]
			public void FixTransform(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x29EDB80", Offset = "0x29ECD80", VA = "0x1829EDB80")]
			public void StoreLocalState()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000104")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000787")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000788")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000789")]
			public RagdollUtility <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000C0")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600076F")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C1")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000771")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x2A02840", Offset = "0x2A01A40", VA = "0x182A02840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2A02B20", Offset = "0x2A01D20", VA = "0x182A02B20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private Rigidbone[] rigidbones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private Child[] children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private bool enableRagdollFlag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private IK[] allIKComponents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private bool[] fixTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private float ragdollWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private float ragdollWeightV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private bool fixedFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private bool[] disabledIKComponents;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		private bool isRagdoll
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x29F7F10", Offset = "0x29F7110", VA = "0x1829F7F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private bool ikUsed
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x29F7DD0", Offset = "0x29F6FD0", VA = "0x1829F7DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x29F69A0", Offset = "0x29F5BA0", VA = "0x1829F69A0")]
		public void EnableRagdoll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x29F68C0", Offset = "0x29F5AC0", VA = "0x1829F68C0")]
		public void DisableRagdoll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x29F7360", Offset = "0x29F6560", VA = "0x1829F7360")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x29F6860", Offset = "0x29F5A60", VA = "0x1829F6860")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x29F7990", Offset = "0x29F6B90", VA = "0x1829F7990")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x29F6CA0", Offset = "0x29F5EA0", VA = "0x1829F6CA0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x29F6D30", Offset = "0x29F5F30", VA = "0x1829F6D30")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x29F6830", Offset = "0x29F5A30", VA = "0x1829F6830")]
		private void AfterLastIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x29F67A0", Offset = "0x29F59A0", VA = "0x1829F67A0")]
		private void AfterAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x29F6F20", Offset = "0x29F6120", VA = "0x1829F6F20")]
		private void OnFinalPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x29F7000", Offset = "0x29F6200", VA = "0x1829F7000")]
		private void RagdollEnabler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x29F7300", Offset = "0x29F6500", VA = "0x1829F7300")]
		private void RecordVelocities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x29F78E0", Offset = "0x29F6AE0", VA = "0x1829F78E0")]
		private void StoreLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x29F6A20", Offset = "0x29F5C20", VA = "0x1829F6A20")]
		private void FixTransforms(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x29F6E10", Offset = "0x29F6010", VA = "0x1829F6E10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x29F7D20", Offset = "0x29F6F20", VA = "0x1829F7D20")]
		public RagdollUtility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public Vector3 axis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private bool initiated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private bool applicationQuit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private bool defaultLocalRotationSet;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Vector3 secondaryAxis
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x2A002B0", Offset = "0x29FF4B0", VA = "0x182A002B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Vector3 crossAxis
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x2A001C0", Offset = "0x29FF3C0", VA = "0x182A001C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool defaultLocalRotationOverride
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x82E2C0", Offset = "0x82D4C0", VA = "0x18082E2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0x82E330", Offset = "0x82D530", VA = "0x18082E330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2A00100", Offset = "0x29FF300", VA = "0x182A00100")]
		public void SetDefaultLocalRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2A00140", Offset = "0x29FF340", VA = "0x182A00140")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x29FFB20", Offset = "0x29FED20", VA = "0x1829FFB20")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x29FF7F0", Offset = "0x29FE9F0", VA = "0x1829FF7F0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x29FFAF0", Offset = "0x29FECF0", VA = "0x1829FFAF0")]
		public void Disable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x29FF9D0", Offset = "0x29FEBD0", VA = "0x1829FF9D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x29FFD80", Offset = "0x29FEF80", VA = "0x1829FFD80")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2657060", Offset = "0x2656260", VA = "0x182657060")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x29FFD90", Offset = "0x29FEF90", VA = "0x1829FFD90")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x29FFE90", Offset = "0x29FF090", VA = "0x1829FFE90")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x29FFCC0", Offset = "0x29FEEC0", VA = "0x1829FFCC0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2A00150", Offset = "0x29FF350", VA = "0x182A00150")]
		protected RotationLimit()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		[Range(0f, 180f)]
		public float limit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x29FC440", Offset = "0x29FB640", VA = "0x1829FC440")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x29FC400", Offset = "0x29FB600", VA = "0x1829FC400")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x29FC480", Offset = "0x29FB680", VA = "0x1829FC480")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x29FC050", Offset = "0x29FB250", VA = "0x1829FC050")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x29FC090", Offset = "0x29FB290", VA = "0x1829FC090", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x29FC180", Offset = "0x29FB380", VA = "0x1829FC180")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x29FC4C0", Offset = "0x29FB6C0", VA = "0x1829FC4C0")]
		public RotationLimitAngle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public bool useLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public float max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private float lastAngle;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x29FC9B0", Offset = "0x29FBBB0", VA = "0x1829FC9B0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x29FC970", Offset = "0x29FBB70", VA = "0x1829FC970")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x29FC9F0", Offset = "0x29FBBF0", VA = "0x1829FC9F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x29FC540", Offset = "0x29FB740", VA = "0x1829FC540")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x29FC930", Offset = "0x29FBB30", VA = "0x1829FC930", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x29FC580", Offset = "0x29FB780", VA = "0x1829FC580")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x29FCA30", Offset = "0x29FBC30", VA = "0x1829FCA30")]
		public RotationLimitHinge()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000105")]
		public class ReachCone
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400078A")]
			public Vector3[] tetrahedron;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400078B")]
			public float volume;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400078C")]
			public Vector3 S;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400078D")]
			public Vector3 B;

			[Cpp2IlInjected.Token(Token = "0x170000C2")]
			public Vector3 o
			{
				[Cpp2IlInjected.Token(Token = "0x6000772")]
				[Cpp2IlInjected.Address(RVA = "0x29F8640", Offset = "0x29F7840", VA = "0x1829F8640")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C3")]
			public Vector3 a
			{
				[Cpp2IlInjected.Token(Token = "0x6000773")]
				[Cpp2IlInjected.Address(RVA = "0x29F8570", Offset = "0x29F7770", VA = "0x1829F8570")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C4")]
			public Vector3 b
			{
				[Cpp2IlInjected.Token(Token = "0x6000774")]
				[Cpp2IlInjected.Address(RVA = "0x29F85B0", Offset = "0x29F77B0", VA = "0x1829F85B0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C5")]
			public Vector3 c
			{
				[Cpp2IlInjected.Token(Token = "0x6000775")]
				[Cpp2IlInjected.Address(RVA = "0x29F85F0", Offset = "0x29F77F0", VA = "0x1829F85F0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C6")]
			public bool isValid
			{
				[Cpp2IlInjected.Token(Token = "0x6000777")]
				[Cpp2IlInjected.Address(RVA = "0x29F8630", Offset = "0x29F7830", VA = "0x1829F8630")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x29F83C0", Offset = "0x29F75C0", VA = "0x1829F83C0")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x29F80E0", Offset = "0x29F72E0", VA = "0x1829F80E0")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000106")]
		public class LimitPoint
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400078E")]
			public Vector3 point;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400078F")]
			public float tangentWeight;

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x29F28D0", Offset = "0x29F1AD0", VA = "0x1829F28D0")]
			public LimitPoint()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		[HideInInspector]
		public LimitPoint[] points;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		[HideInInspector]
		public Vector3[] P;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x29FD980", Offset = "0x29FCB80", VA = "0x1829FD980")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x29FD940", Offset = "0x29FCB40", VA = "0x1829FD940")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x29FEDC0", Offset = "0x29FDFC0", VA = "0x1829FEDC0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x29FCAB0", Offset = "0x29FBCB0", VA = "0x1829FCAB0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x29FE040", Offset = "0x29FD240", VA = "0x1829FE040")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x29FD480", Offset = "0x29FC680", VA = "0x1829FD480", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x29FEB10", Offset = "0x29FDD10", VA = "0x1829FEB10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x29FDB50", Offset = "0x29FCD50", VA = "0x1829FDB50")]
		public void ResetToDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x29FCAF0", Offset = "0x29FBCF0", VA = "0x1829FCAF0")]
		public void BuildReachCones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x29FE0C0", Offset = "0x29FD2C0", VA = "0x1829FE0C0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x29FD430", Offset = "0x29FC630", VA = "0x1829FD430")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x29FD9C0", Offset = "0x29FCBC0", VA = "0x1829FD9C0")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x29FEE00", Offset = "0x29FE000", VA = "0x1829FEE00")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x29FD5A0", Offset = "0x29FC7A0", VA = "0x1829FD5A0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x29FD1C0", Offset = "0x29FC3C0", VA = "0x1829FD1C0")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x29FF000", Offset = "0x29FE200", VA = "0x1829FF000")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		[HideInInspector]
		public AnimationCurve spline;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x29FF6D0", Offset = "0x29FE8D0", VA = "0x1829FF6D0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x29FF690", Offset = "0x29FE890", VA = "0x1829FF690")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x29FF730", Offset = "0x29FE930", VA = "0x1829FF730")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x29FF0A0", Offset = "0x29FE2A0", VA = "0x1829FF0A0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x29FF710", Offset = "0x29FE910", VA = "0x1829FF710")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x29FF0E0", Offset = "0x29FE2E0", VA = "0x1829FF0E0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x29FF1D0", Offset = "0x29FE3D0", VA = "0x1829FF1D0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x29FF770", Offset = "0x29FE970", VA = "0x1829FF770")]
		public RotationLimitSpline()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class AimController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000790")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000791")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000792")]
			public AimController <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000C7")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600077D")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C8")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600077F")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x2670780", Offset = "0x266F980", VA = "0x182670780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x26708D0", Offset = "0x266FAD0", VA = "0x1826708D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
		public float smoothDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private Transform lastTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private float switchWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private float switchWeightV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private float weightV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private Vector3 dir;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private bool lastSmoothTowardsTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB5")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private bool turningToTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private float turnToTargetMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private float turnToTargetMlpV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private float yawV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private float pitchV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private float dirMagV;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private Vector3 pivot
		{
			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x2655870", Offset = "0x2654A70", VA = "0x182655870")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x26555F0", Offset = "0x26547F0", VA = "0x1826555F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x2654430", Offset = "0x2653630", VA = "0x182654430")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x2654220", Offset = "0x2653420", VA = "0x182654220")]
		private void ApplyMinDistance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x2655230", Offset = "0x2654430", VA = "0x182655230")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x2655730", Offset = "0x2654930", VA = "0x182655730")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x2655790", Offset = "0x2654990", VA = "0x182655790")]
		public AimController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		public class Pose
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000793")]
			public bool visualize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000794")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000795")]
			public Vector3 direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000796")]
			public float yaw;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000797")]
			public float pitch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000798")]
			private float angleBuffer;

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x266C6C0", Offset = "0x266B8C0", VA = "0x18266C6C0")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0xD24680", Offset = "0xD23880", VA = "0x180D24680")]
			public void SetAngleBuffer(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x266CA10", Offset = "0x266BC10", VA = "0x18266CA10")]
			public Pose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public float angleBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public Pose[] poses;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2655BA0", Offset = "0x2654DA0", VA = "0x182655BA0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x2655CC0", Offset = "0x2654EC0", VA = "0x182655CC0")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x2655D50", Offset = "0x2654F50", VA = "0x182655D50")]
		public AimPoser()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		public class Body
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000132")]
			public class EffectorLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000889")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400088A")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Cpp2IlInjected.Token(Token = "0x600080A")]
				[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
				public EffectorLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			private Vector3 lastRelativePos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			private Vector3 smoothDelta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			private bool firstUpdate;

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x2657D40", Offset = "0x2656F40", VA = "0x182657D40")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x2657CE0", Offset = "0x2656EE0", VA = "0x182657CE0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x2658330", Offset = "0x2657530", VA = "0x182658330")]
			public Body()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x2655DA0", Offset = "0x2654FA0", VA = "0x182655DA0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x2655EE0", Offset = "0x26550E0", VA = "0x182655EE0")]
		public Amplifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class BodyTilt : OffsetModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private float tiltAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private Vector3 lastForward;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x2657C70", Offset = "0x2656E70", VA = "0x182657C70", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x26579F0", Offset = "0x2656BF0", VA = "0x1826579F0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x2657CC0", Offset = "0x2656EC0", VA = "0x182657CC0")]
		public BodyTilt()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public CCDIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x2658830", Offset = "0x2657A30", VA = "0x182658830")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x2658350", Offset = "0x2657550", VA = "0x182658350")]
		private void BeforeIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x2658740", Offset = "0x2657940", VA = "0x182658740")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xAB98C0", Offset = "0xAB8AC0", VA = "0x180AB98C0")]
		public CCDBendGoal()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		[HideInInspector]
		public Transform[] bones;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public IK ik
		{
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x42EA00", Offset = "0x42DC00", VA = "0x18042EA00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x421A50", Offset = "0x420C50", VA = "0x180421A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x265A200", Offset = "0x2659400", VA = "0x18265A200")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x265A100", Offset = "0x2659300", VA = "0x18265A100")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x2659FB0", Offset = "0x26591B0", VA = "0x182659FB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x265A350", Offset = "0x2659550", VA = "0x18265A350")]
		public void StoreDefaultPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x2659D80", Offset = "0x2658F80", VA = "0x182659D80")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x265A520", Offset = "0x2659720", VA = "0x18265A520")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x265A820", Offset = "0x2659A20", VA = "0x18265A820")]
		public EditorIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CreateAssetMenu]
	public class EditorIKPose : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public Vector3[] localPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public Quaternion[] localRotations;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool poseStored
		{
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x2659D60", Offset = "0x2658F60", VA = "0x182659D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x2659B80", Offset = "0x2658D80", VA = "0x182659B80")]
		public void Store(Transform[] T)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x26599E0", Offset = "0x2658BE0", VA = "0x1826599E0")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x2659D00", Offset = "0x2658F00", VA = "0x182659D00")]
		public EditorIKPose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200010A")]
		public abstract class HitPoint
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007A4")]
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40007A9")]
			private float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007AA")]
			private float crossFadeSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40007AB")]
			private float lastTime;

			[Cpp2IlInjected.Token(Token = "0x170000C9")]
			public bool inProgress
			{
				[Cpp2IlInjected.Token(Token = "0x6000786")]
				[Cpp2IlInjected.Address(RVA = "0x2C7E430", Offset = "0x2C7D630", VA = "0x182C7E430")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CA")]
			protected float crossFader
			{
				[Cpp2IlInjected.Token(Token = "0x6000787")]
				[Cpp2IlInjected.Address(RVA = "0x921BF0", Offset = "0x920DF0", VA = "0x180921BF0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000788")]
				[Cpp2IlInjected.Address(RVA = "0x921DB0", Offset = "0x920FB0", VA = "0x180921DB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CB")]
			protected float timer
			{
				[Cpp2IlInjected.Token(Token = "0x6000789")]
				[Cpp2IlInjected.Address(RVA = "0x921DD0", Offset = "0x920FD0", VA = "0x180921DD0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600078A")]
				[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920D20", VA = "0x180921B20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CC")]
			protected Vector3 force
			{
				[Cpp2IlInjected.Token(Token = "0x600078B")]
				[Cpp2IlInjected.Address(RVA = "0xE86EF0", Offset = "0xE860F0", VA = "0x180E86EF0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0xE87000", Offset = "0xE86200", VA = "0x180E87000")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CD")]
			protected Vector3 point
			{
				[Cpp2IlInjected.Token(Token = "0x600078D")]
				[Cpp2IlInjected.Address(RVA = "0x2516D00", Offset = "0x2515F00", VA = "0x182516D00")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600078E")]
				[Cpp2IlInjected.Address(RVA = "0x106AAC0", Offset = "0x1069CC0", VA = "0x18106AAC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x2C7E320", Offset = "0x2C7D520", VA = "0x182C7E320")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2C7E1C0", Offset = "0x2C7D3C0", VA = "0x182C7E1C0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(Slot = "4")]
			protected abstract float GetLength();

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(Slot = "5")]
			protected abstract void CrossFadeStart();

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(Slot = "6")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x2C7DBE0", Offset = "0x2C7CDE0", VA = "0x182C7DBE0")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000133")]
			public class EffectorLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400088B")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400088C")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400088D")]
				private Vector3 lastValue;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400088E")]
				private Vector3 current;

				[Cpp2IlInjected.Token(Token = "0x600080B")]
				[Cpp2IlInjected.Address(RVA = "0x2C6FDF0", Offset = "0x2C6EFF0", VA = "0x182C6FDF0")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600080C")]
				[Cpp2IlInjected.Address(RVA = "0x2C6FF70", Offset = "0x2C6F170", VA = "0x182C6FF70")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600080D")]
				[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
				public EffectorLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x2C7DC50", Offset = "0x2C7CE50", VA = "0x182C7DC50", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x2C7DBF0", Offset = "0x2C7CDF0", VA = "0x182C7DBF0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x2C7DDE0", Offset = "0x2C7CFE0", VA = "0x182C7DDE0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x2C7DBE0", Offset = "0x2C7CDE0", VA = "0x182C7DBE0")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000134")]
			public class BoneLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400088F")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000890")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000891")]
				private Quaternion lastValue;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000892")]
				private Quaternion current;

				[Cpp2IlInjected.Token(Token = "0x600080E")]
				[Cpp2IlInjected.Address(RVA = "0x2C6D970", Offset = "0x2C6CB70", VA = "0x182C6D970")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600080F")]
				[Cpp2IlInjected.Address(RVA = "0x2C6DAC0", Offset = "0x2C6CCC0", VA = "0x182C6DAC0")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000810")]
				[Cpp2IlInjected.Address(RVA = "0x2C6DAD0", Offset = "0x2C6CCD0", VA = "0x182C6DAD0")]
				public BoneLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			private Rigidbody rigidbody;

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0x2C7D7A0", Offset = "0x2C7C9A0", VA = "0x182C7D7A0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x2C7D740", Offset = "0x2C7C940", VA = "0x182C7D740", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x2C7D840", Offset = "0x2C7CA40", VA = "0x182C7D840", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x2C7DBE0", Offset = "0x2C7CDE0", VA = "0x182C7DBE0")]
			public HitPointBone()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool inProgress
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0x2C7EB30", Offset = "0x2C7DD30", VA = "0x182C7EB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C7EA30", Offset = "0x2C7DC30", VA = "0x182C7EA30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C7E7B0", Offset = "0x2C7D9B0", VA = "0x182C7E7B0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x2655EE0", Offset = "0x26550E0", VA = "0x182655EE0")]
		public HitReaction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200010D")]
		public abstract class Offset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40007B9")]
			private float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007BA")]
			private float crossFadeSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40007BB")]
			private float lastTime;

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			protected float crossFader
			{
				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x921BF0", Offset = "0x920DF0", VA = "0x180921BF0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x921DB0", Offset = "0x920FB0", VA = "0x180921DB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			protected float timer
			{
				[Cpp2IlInjected.Token(Token = "0x600079F")]
				[Cpp2IlInjected.Address(RVA = "0x921DD0", Offset = "0x920FD0", VA = "0x180921DD0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60007A0")]
				[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920D20", VA = "0x180921B20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			protected Vector3 force
			{
				[Cpp2IlInjected.Token(Token = "0x60007A1")]
				[Cpp2IlInjected.Address(RVA = "0xE86EF0", Offset = "0xE860F0", VA = "0x180E86EF0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60007A2")]
				[Cpp2IlInjected.Address(RVA = "0xE87000", Offset = "0xE86200", VA = "0x180E87000")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			protected Vector3 point
			{
				[Cpp2IlInjected.Token(Token = "0x60007A3")]
				[Cpp2IlInjected.Address(RVA = "0x2516D00", Offset = "0x2515F00", VA = "0x182516D00")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60007A4")]
				[Cpp2IlInjected.Address(RVA = "0x106AAC0", Offset = "0x1069CC0", VA = "0x18106AAC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2C8AB90", Offset = "0x2C89D90", VA = "0x182C8AB90")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2C8AA10", Offset = "0x2C89C10", VA = "0x182C8AA10")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			protected abstract void CrossFadeStart();

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x2C7DBE0", Offset = "0x2C7CDE0", VA = "0x182C7DBE0")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000135")]
			public class PositionOffsetLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000893")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000894")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000895")]
				private Vector3 lastValue;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000896")]
				private Vector3 current;

				[Cpp2IlInjected.Token(Token = "0x6000811")]
				[Cpp2IlInjected.Address(RVA = "0x2C8B1A0", Offset = "0x2C8A3A0", VA = "0x182C8B1A0")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000812")]
				[Cpp2IlInjected.Address(RVA = "0x2C6FF70", Offset = "0x2C6F170", VA = "0x182C6FF70")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000813")]
				[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
				public PositionOffsetLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007BC")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40007BD")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007BE")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B350", Offset = "0x2C8A550", VA = "0x182C8B350", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B2F0", Offset = "0x2C8A4F0", VA = "0x182C8B2F0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B5B0", Offset = "0x2C8A7B0", VA = "0x182C8B5B0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B960", Offset = "0x2C8AB60", VA = "0x182C8B960")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000136")]
			public class RotationOffsetLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000897")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000898")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000899")]
				private Quaternion lastValue;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400089A")]
				private Quaternion current;

				[Cpp2IlInjected.Token(Token = "0x6000814")]
				[Cpp2IlInjected.Address(RVA = "0x2C8B980", Offset = "0x2C8AB80", VA = "0x182C8B980")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000815")]
				[Cpp2IlInjected.Address(RVA = "0x2C8BAA0", Offset = "0x2C8ACA0", VA = "0x182C8BAA0")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000816")]
				[Cpp2IlInjected.Address(RVA = "0x2C8BAB0", Offset = "0x2C8ACB0", VA = "0x182C8BAB0")]
				public RotationOffsetLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007BF")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007C0")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007C1")]
			private Rigidbody rigidbody;

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x2C8BB90", Offset = "0x2C8AD90", VA = "0x182C8BB90", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x2C8BB30", Offset = "0x2C8AD30", VA = "0x182C8BB30", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0x2C8BCB0", Offset = "0x2C8AEB0", VA = "0x182C8BCB0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x2C7DBE0", Offset = "0x2C7CDE0", VA = "0x182C7DBE0")]
			public RotationOffset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public AnimationCurve[] offsetCurves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x2C7E6C0", Offset = "0x2C7D8C0", VA = "0x182C7E6C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x2C7E440", Offset = "0x2C7D640", VA = "0x182C7E440")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x2655EE0", Offset = "0x26550E0", VA = "0x182655EE0")]
		public HitReactionVRIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		public class Body
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000137")]
			public class EffectorLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400089B")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400089C")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Cpp2IlInjected.Token(Token = "0x6000817")]
				[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
				public EffectorLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007C2")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40007C5")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007C6")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40007C7")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007C8")]
			private Vector3 delta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40007C9")]
			private Vector3 lazyPoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007CA")]
			private Vector3 direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40007CB")]
			private Vector3 lastPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007CC")]
			private bool firstUpdate;

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0x2E7A3C0", Offset = "0x2E795C0", VA = "0x182E7A3C0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x2E7A4C0", Offset = "0x2E796C0", VA = "0x182E7A4C0")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x2E7AA30", Offset = "0x2E79C30", VA = "0x182E7AA30")]
			public Body()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x2E7B4E0", Offset = "0x2E7A6E0", VA = "0x182E7B4E0")]
		public void ResetBodies()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x2E7B410", Offset = "0x2E7A610", VA = "0x182E7B410", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x2655EE0", Offset = "0x26550E0", VA = "0x182655EE0")]
		public Inertia()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class LookAtController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public LookAtIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		[Header("Target Smoothing")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public Vector3 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private Transform lastTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private float switchWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private float switchWeightV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private float weightV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private Vector3 dir;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private bool lastSmoothTowardsTarget;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private Vector3 pivot
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x29F3AE0", Offset = "0x29F2CE0", VA = "0x1829F3AE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x29F3910", Offset = "0x29F2B10", VA = "0x1829F3910")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x29F2B60", Offset = "0x29F1D60", VA = "0x1829F2B60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x29F2950", Offset = "0x29F1B50", VA = "0x1829F2950")]
		private void ApplyMinDistance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x29F35B0", Offset = "0x29F27B0", VA = "0x1829F35B0")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x29F3A30", Offset = "0x29F2C30", VA = "0x1829F3A30")]
		public LookAtController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		public class OffsetLimits
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007CD")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007CE")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007CF")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x40007D0")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x40007D1")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40007D2")]
			[Tooltip("The limits")]
			public float minX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			[Tooltip("The limits")]
			public float maxX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			[Tooltip("The limits")]
			public float minY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007D5")]
			[Tooltip("The limits")]
			public float maxY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40007D6")]
			[Tooltip("The limits")]
			public float minZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007D7")]
			[Tooltip("The limits")]
			public float maxZ;

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x29F3DD0", Offset = "0x29F2FD0", VA = "0x1829F3DD0")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x29F40D0", Offset = "0x29F32D0", VA = "0x1829F40D0")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x29F4210", Offset = "0x29F3410", VA = "0x1829F4210")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
			public OffsetLimits()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public OffsetModifier <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007BD")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D3")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007BF")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x2A02D00", Offset = "0x2A01F00", VA = "0x182A02D00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2A02E40", Offset = "0x2A02040", VA = "0x182A02E40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		[Tooltip("The master weight")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		protected float lastTime;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		protected float deltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xBFFBD0", Offset = "0xBFEDD0", VA = "0x180BFFBD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void OnModifyOffset();

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x29F4920", Offset = "0x29F3B20", VA = "0x1829F4920", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x29F46C0", Offset = "0x29F38C0", VA = "0x1829F46C0")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x29F4720", Offset = "0x29F3920", VA = "0x1829F4720")]
		private void ModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x29F45D0", Offset = "0x29F37D0", VA = "0x1829F45D0")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x29F4830", Offset = "0x29F3A30", VA = "0x1829F4830", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x99DD00", Offset = "0x99CF00", VA = "0x18099DD00")]
		protected OffsetModifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			public OffsetModifierVRIK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000D4")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007C3")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007C5")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C1")]
			[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C2")]
			[Cpp2IlInjected.Address(RVA = "0x2A02B70", Offset = "0x2A01D70", VA = "0x182A02B70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007C4")]
			[Cpp2IlInjected.Address(RVA = "0x2A02CB0", Offset = "0x2A01EB0", VA = "0x182A02CB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		[Tooltip("The master weight")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private float lastTime;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		protected float deltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xBFFBD0", Offset = "0xBFEDD0", VA = "0x180BFFBD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void OnModifyOffset();

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x29F4560", Offset = "0x29F3760", VA = "0x1829F4560", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x29F4300", Offset = "0x29F3500", VA = "0x1829F4300")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x29F4360", Offset = "0x29F3560", VA = "0x1829F4360")]
		private void ModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x29F4470", Offset = "0x29F3670", VA = "0x1829F4470", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x99DD00", Offset = "0x99CF00", VA = "0x18099DD00")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000114")]
		public class EffectorLink
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			public FullBodyBipedEffector effector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007DF")]
			public Vector3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007E0")]
			public Vector3 pin;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40007E1")]
			public Vector3 pinWeight;

			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0x29EDC50", Offset = "0x29ECE50", VA = "0x1829EDC50")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
			public EffectorLink()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public EffectorLink[] effectorLinks;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x29F4A60", Offset = "0x29F3C60", VA = "0x1829F4A60")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x29F4990", Offset = "0x29F3B90", VA = "0x1829F4990")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x29F4B50", Offset = "0x29F3D50", VA = "0x1829F4B50")]
		public OffsetPose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public class Avoider
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000138")]
			public class EffectorLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400089D")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400089E")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Cpp2IlInjected.Token(Token = "0x6000818")]
				[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
				public EffectorLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007E2")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007E3")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007E4")]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007E5")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007E6")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40007E7")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007E8")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40007E9")]
			private Vector3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007EA")]
			private Vector3 offsetTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40007EB")]
			private Vector3 offsetV;

			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x29EC4A0", Offset = "0x29EB6A0", VA = "0x1829EC4A0")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0x29EBF90", Offset = "0x29EB190", VA = "0x1829EBF90")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60007CA")]
			[Cpp2IlInjected.Address(RVA = "0x29EC1A0", Offset = "0x29EB3A0", VA = "0x1829EC1A0")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0x29EC8E0", Offset = "0x29EBAE0", VA = "0x1829EC8E0")]
			public Avoider()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x29F4BA0", Offset = "0x29F3DA0", VA = "0x1829F4BA0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x99DD00", Offset = "0x99CF00", VA = "0x18099DD00")]
		public PenetrationAvoidance()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		public class RecoilOffset
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000139")]
			public class EffectorLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400089F")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40008A0")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Cpp2IlInjected.Token(Token = "0x6000819")]
				[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
				public EffectorLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007EC")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40007ED")]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007EE")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007EF")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007F0")]
			private Vector3 additiveOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40007F1")]
			private Vector3 lastOffset;

			[Cpp2IlInjected.Token(Token = "0x60007CC")]
			[Cpp2IlInjected.Address(RVA = "0x29F8990", Offset = "0x29F7B90", VA = "0x1829F8990")]
			public void Start()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0x29F8680", Offset = "0x29F7880", VA = "0x1829F8680")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0x29F8A70", Offset = "0x29F7C70", VA = "0x1829F8A70")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000117")]
		public enum Handedness
		{
			[Cpp2IlInjected.Token(Token = "0x40007F3")]
			Right,
			[Cpp2IlInjected.Token(Token = "0x40007F4")]
			Left
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		[Space]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private float magnitudeMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private float endTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private Quaternion handRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private Quaternion secondaryHandRelativeRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private Quaternion randomRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private float length;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private bool initiated;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private float blendWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private float w;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private Quaternion primaryHandRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private bool handRotationsSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private Vector3 aimIKAxis;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool isFinished
		{
			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0x29FA2F0", Offset = "0x29F94F0", VA = "0x1829FA2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private IKEffector primaryHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x29FA310", Offset = "0x29F9510", VA = "0x1829FA310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		private IKEffector secondaryHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x29FA3B0", Offset = "0x29F95B0", VA = "0x1829FA3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		private Transform primaryHand
		{
			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x29FA360", Offset = "0x29F9560", VA = "0x1829FA360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		private Transform secondaryHand
		{
			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x29FA400", Offset = "0x29F9600", VA = "0x1829FA400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x29FA210", Offset = "0x29F9410", VA = "0x1829FA210")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x29F8CF0", Offset = "0x29F7EF0", VA = "0x1829F8CF0")]
		public void Fire(float magnitude)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x29F9240", Offset = "0x29F8440", VA = "0x1829F9240", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x29F8AE0", Offset = "0x29F7CE0", VA = "0x1829F8AE0")]
		private void AfterFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x29F8A90", Offset = "0x29F7C90", VA = "0x1829F8A90")]
		private void AfterAimIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x29F8FC0", Offset = "0x29F81C0", VA = "0x1829F8FC0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x29FA240", Offset = "0x29F9440", VA = "0x1829FA240")]
		public Recoil()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private bool skip;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A00BC0", Offset = "0x29FFDC0", VA = "0x182A00BC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A00AC0", Offset = "0x29FFCC0", VA = "0x182A00AC0")]
		private void RotateShoulders()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A00530", Offset = "0x29FF730", VA = "0x182A00530")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A00400", Offset = "0x29FF600", VA = "0x182A00400")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A00440", Offset = "0x29FF640", VA = "0x182A00440")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A00CB0", Offset = "0x29FFEB0", VA = "0x182A00CB0")]
		public ShoulderRotator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000118")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007F5")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007F6")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007F7")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40007F8")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007F9")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40007FA")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007FB")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40007FC")]
			[Space]
			[Space(10f)]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			public Vector3 headOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007FD")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40007FE")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007FF")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			[Range(-180f, 180f)]
			public float footHeadingOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x2A002F0", Offset = "0x29FF4F0", VA = "0x182A002F0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		public class CalibrationData
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x200013A")]
			public class Target
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40008A1")]
				public bool used;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40008A2")]
				public Vector3 localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40008A3")]
				public Quaternion localRotation;

				[Cpp2IlInjected.Token(Token = "0x600081A")]
				[Cpp2IlInjected.Address(RVA = "0x2A012C0", Offset = "0x2A004C0", VA = "0x182A012C0")]
				public Target(Transform t)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600081B")]
				[Cpp2IlInjected.Address(RVA = "0x2A01250", Offset = "0x2A00450", VA = "0x182A01250")]
				public void SetTo(Transform t)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000804")]
			public Target head;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000805")]
			public Target leftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000806")]
			public Target rightHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			public Target pelvis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			public Target leftFoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000809")]
			public Target rightFoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400080A")]
			public Target leftLegGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400080B")]
			public Target rightLegGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400080C")]
			public Vector3 pelvisTargetRight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400080D")]
			public float pelvisPositionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400080E")]
			public float pelvisRotationWeight;

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
			public CalibrationData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x2A08620", Offset = "0x2A07820", VA = "0x182A08620")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x2A086A0", Offset = "0x2A078A0", VA = "0x182A086A0")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x2A05050", Offset = "0x2A04250", VA = "0x182A05050")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x2A05070", Offset = "0x2A04270", VA = "0x182A05070")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x2A06300", Offset = "0x2A05500", VA = "0x182A06300")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x2A046F0", Offset = "0x2A038F0", VA = "0x182A046F0")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x2A054C0", Offset = "0x2A046C0", VA = "0x182A054C0")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x2A044C0", Offset = "0x2A036C0", VA = "0x182A044C0")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x2A05280", Offset = "0x2A04480", VA = "0x182A05280")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x2A03EF0", Offset = "0x2A030F0", VA = "0x182A03EF0")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x2A03350", Offset = "0x2A02550", VA = "0x182A03350")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x2A03C20", Offset = "0x2A02E20", VA = "0x182A03C20")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x2A03690", Offset = "0x2A02890", VA = "0x182A03690")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x2A08410", Offset = "0x2A07610", VA = "0x182A08410")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x2A07F30", Offset = "0x2A07130", VA = "0x182A07F30")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class VRIKLODController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public Renderer LODRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public float LODDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public bool allowCulled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private VRIK ik;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x2A088D0", Offset = "0x2A07AD0", VA = "0x182A088D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x2A08910", Offset = "0x2A07B10", VA = "0x182A08910")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x2A08710", Offset = "0x2A07910", VA = "0x182A08710")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x2A08AF0", Offset = "0x2A07CF0", VA = "0x182A08AF0")]
		public VRIKLODController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class VRIKRootController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private Transform pelvisTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private Transform leftFootTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private Transform rightFootTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private VRIK ik;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector3 pelvisTargetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x93F190", Offset = "0x93E390", VA = "0x18093F190")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x93F1E0", Offset = "0x93E3E0", VA = "0x18093F1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x2A08B10", Offset = "0x2A07D10", VA = "0x182A08B10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x2A08BF0", Offset = "0x2A07DF0", VA = "0x182A08BF0")]
		public void Calibrate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x2A08E40", Offset = "0x2A08040", VA = "0x182A08E40")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2A090D0", Offset = "0x2A082D0", VA = "0x182A090D0")]
		private void OnPreUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2A08FE0", Offset = "0x2A081E0", VA = "0x182A08FE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200011A")]
		public class Offset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400080F")]
			[HideInInspector]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000810")]
			public HumanBodyBones bone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000811")]
			public Vector3 rotationOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000812")]
			private Transform t;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFC60", Offset = "0x2AAEE60", VA = "0x182AAFC60")]
			public void Apply(Animator animator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
			public Offset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public Offset[] offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private Animator animator;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x2AACA20", Offset = "0x2AABC20", VA = "0x182AACA20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC750", Offset = "0x2AAB950", VA = "0x182AAC750")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC940", Offset = "0x2AABB40", VA = "0x182AAC940")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public FKOffset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class AimBoxing : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public AimIK aimIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public Transform pin;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x2A92D90", Offset = "0x2A91F90", VA = "0x182A92D90")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public AimBoxing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class AimSwing : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public AimIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x2A92E50", Offset = "0x2A92050", VA = "0x182A92E50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x2A92F90", Offset = "0x2A92190", VA = "0x182A92F90")]
		public AimSwing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public AimIK aim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public LimbIK leftArmIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public Transform leftHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public Transform rightHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public Vector3 leftHandPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public Vector3 leftHandRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private Vector3 leftHandPosRelToRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private Quaternion leftHandRotRelToRight;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x266D240", Offset = "0x266C440", VA = "0x18266D240")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x266CF50", Offset = "0x266C150", VA = "0x18266CF50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public SecondHandOnGun()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private AimPoser.Pose aimPose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private AimPoser.Pose lastPose;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x266DB30", Offset = "0x266CD30", VA = "0x18266DB30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x266D370", Offset = "0x266C570", VA = "0x18266D370")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x266D740", Offset = "0x266C940", VA = "0x18266D740")]
		private void Pose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x266D4B0", Offset = "0x266C6B0", VA = "0x18266D4B0")]
		private void LimitAimTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x266D280", Offset = "0x266C480", VA = "0x18266D280")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x266DB70", Offset = "0x266CD70", VA = "0x18266DB70")]
		public SimpleAimingSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class TerrainOffset : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public AimIK aimIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public Vector3 raycastOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public LayerMask raycastLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public float max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public float lerpSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private RaycastHit hit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private Vector3 offset;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x266EC10", Offset = "0x266DE10", VA = "0x18266EC10")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x266E950", Offset = "0x266DB50", VA = "0x18266E950")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x266EF00", Offset = "0x266E100", VA = "0x18266EF00")]
		public TerrainOffset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		[LargeHeader("References")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public BipedIK bipedIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public Transform lookAtTargetAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public Transform footTargetAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public Transform handTargetAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x2A99C10", Offset = "0x2A98E10", VA = "0x182A99C10")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A390", Offset = "0x2A99590", VA = "0x182A9A390")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class MechSpider : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public LayerMask raycastLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public float scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public Transform body;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public MechSpiderLeg[] legs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public float legRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public float rootPositionSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public float rootRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public float breatheSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public float breatheMagnitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public float height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public float minHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public float raycastHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public float raycastDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private Vector3 defaultBodyLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private float sine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private RaycastHit rootHit;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 velocity
		{
			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0xBE7570", Offset = "0xBE6770", VA = "0x180BE7570")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0xBE7060", Offset = "0xBE6260", VA = "0x180BE7060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2667760", Offset = "0x2666960", VA = "0x182667760")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x26677A0", Offset = "0x26669A0", VA = "0x1826677A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x26670B0", Offset = "0x26662B0", VA = "0x1826670B0")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x26672D0", Offset = "0x26664D0", VA = "0x1826672D0")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2668140", Offset = "0x2667340", VA = "0x182668140")]
		public MechSpider()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class MechSpiderController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public MechSpider mechSpider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public Transform cameraTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public float speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public float turnSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Vector3 inputVector
		{
			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x26654C0", Offset = "0x26646C0", VA = "0x1826654C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x2665120", Offset = "0x2664320", VA = "0x182665120")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x26654A0", Offset = "0x26646A0", VA = "0x1826654A0")]
		public MechSpiderController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000813")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000814")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000815")]
			public MechSpiderLeg <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000816")]
			public Vector3 stepStartPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000817")]
			public Vector3 targetPosition;

			[Cpp2IlInjected.Token(Token = "0x170000D6")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007D6")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007D8")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0x266FFD0", Offset = "0x266F1D0", VA = "0x18266FFD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x2670550", Offset = "0x266F750", VA = "0x182670550", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public MechSpider mechSpider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public MechSpiderLeg unSync;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public Vector3 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public float minDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public float maxOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public float stepSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public float footHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public float velocityPrediction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public float raycastFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public AnimationCurve yOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public Transform foot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public Vector3 footUpAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public float footRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public ParticleSystem sand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private IK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private float stepProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private float lastStepTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private Vector3 defaultPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private RaycastHit hit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private Quaternion lastFootLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private Vector3 smoothHitNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private Vector3 lastStepPosition;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool isStepping
		{
			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0x2666B70", Offset = "0x2665D70", VA = "0x182666B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x2666B90", Offset = "0x2665D90", VA = "0x182666B90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x2666BF0", Offset = "0x2665DF0", VA = "0x182666BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x26657C0", Offset = "0x26649C0", VA = "0x1826657C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2665540", Offset = "0x2664740", VA = "0x182665540")]
		private void AfterIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2665F30", Offset = "0x2665130", VA = "0x182665F30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2665A30", Offset = "0x2664C30", VA = "0x182665A30")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2666400", Offset = "0x2665600", VA = "0x182666400")]
		private void UpdatePosition(float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2666740", Offset = "0x2665940", VA = "0x182666740")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2666360", Offset = "0x2665560", VA = "0x182666360")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x2666AC0", Offset = "0x2665CC0", VA = "0x182666AC0")]
		public MechSpiderLeg()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public MechSpiderController mechSpiderController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x2666C40", Offset = "0x2665E40", VA = "0x182666C40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x2666CF0", Offset = "0x2665EF0", VA = "0x182666CF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public MechSpiderParticles()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200011C")]
		public struct Warp
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000818")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000819")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400081A")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400081B")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400081C")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400081D")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200011D")]
		public enum EffectorMode
		{
			[Cpp2IlInjected.Token(Token = "0x400081F")]
			PositionOffset,
			[Cpp2IlInjected.Token(Token = "0x4000820")]
			Position
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[Space]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private EffectorMode lastMode;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x2A93850", Offset = "0x2A92A50", VA = "0x182A93850", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x2A93000", Offset = "0x2A92200", VA = "0x182A93000")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x2A93330", Offset = "0x2A92530", VA = "0x182A93330", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x2A93280", Offset = "0x2A92480", VA = "0x182A93280")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x2655EE0", Offset = "0x26550E0", VA = "0x182655EE0")]
		public AnimationWarping()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public float rotateSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public float blendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public float maxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public float rootMotionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected Vector3 moveBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		protected Vector3 moveInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		protected Vector3 velocity;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x2A951B0", Offset = "0x2A943B0", VA = "0x182A951B0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x2A94EF0", Offset = "0x2A940F0", VA = "0x182A94EF0")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x2A94C10", Offset = "0x2A93E10", VA = "0x182A94C10", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x2A951F0", Offset = "0x2A943F0", VA = "0x182A951F0")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public Vector3 gunHoldOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public Vector3 leftHandOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public Recoil recoil;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private AimIK aim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private Vector3 headLookAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private Vector3 leftHandPosRelToRightHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private Quaternion leftHandRotRelToRightHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private Vector3 aimTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private Quaternion rightHandRotation;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x2A949D0", Offset = "0x2A93BD0", VA = "0x182A949D0", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x2A94020", Offset = "0x2A93220", VA = "0x182A94020", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2A94820", Offset = "0x2A93A20", VA = "0x182A94820")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x2A93870", Offset = "0x2A92A70", VA = "0x182A93870")]
		private void AimIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2A938D0", Offset = "0x2A92AD0", VA = "0x182A938D0")]
		private void FBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x2A94420", Offset = "0x2A93620", VA = "0x182A94420")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x2A93D80", Offset = "0x2A92F80", VA = "0x182A93D80")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x2A94310", Offset = "0x2A93510", VA = "0x182A94310")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x2A94BE0", Offset = "0x2A93DE0", VA = "0x182A94BE0")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private FullBodyBipedIK ik;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA54B0", Offset = "0x2AA46B0", VA = "0x182AA54B0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4FB0", Offset = "0x2AA41B0", VA = "0x182AA4FB0", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA52B0", Offset = "0x2AA44B0", VA = "0x182AA52B0")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5570", Offset = "0x2AA4770", VA = "0x182AA5570")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public CameraController cam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private AnimatorController3rdPerson animatorController;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		private static Vector3 inputVector
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7080", Offset = "0x2AA6280", VA = "0x182AA7080")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private static Vector3 inputVectorRaw
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7000", Offset = "0x2AA6200", VA = "0x182AA7000")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6FA0", Offset = "0x2AA61A0", VA = "0x182AA6FA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6BE0", Offset = "0x2AA5DE0", VA = "0x182AA6BE0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class EffectorOffset : OffsetModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public Vector3 bodyOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public Vector3 leftShoulderOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public Vector3 rightShoulderOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public Vector3 leftThighOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public Vector3 rightThighOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public Vector3 leftHandOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public Vector3 rightHandOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public Vector3 leftFootOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public Vector3 rightFootOffset;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA680", Offset = "0x2AA9880", VA = "0x182AAA680", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2655EE0", Offset = "0x26550E0", VA = "0x182655EE0")]
		public EffectorOffset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public SimpleLocomotion character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public float forceMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public float upForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public float weightFalloffSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AnimationCurve weightFalloff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AnimationCurve explosionForceByDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AnimationCurve scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private Vector3 defaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private Rigidbody r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private FullBodyBipedIK ik;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB070", Offset = "0x2AAA270", VA = "0x182AAB070")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB100", Offset = "0x2AAA300", VA = "0x182AAB100")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAFB0", Offset = "0x2AAA1B0", VA = "0x182AAAFB0")]
		private void SetEffectorWeights(float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB7D0", Offset = "0x2AAA9D0", VA = "0x182AAB7D0")]
		public ExplosionDemo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		public class Limb
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000821")]
			public FBIKChain.Smoothing reachSmoothing;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000822")]
			public float maintainRelativePositionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000823")]
			public float mappingWeight;

			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFBE0", Offset = "0x2AAEDE0", VA = "0x182AAFBE0")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0x9BB170", Offset = "0x9BA370", VA = "0x1809BB170")]
			public Limb()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public bool disableAfterStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public Limb leftArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public Limb rightArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public Limb leftLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public Limb rightLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public float rootPin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public bool bodyEffectChildNodes;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB8E0", Offset = "0x2AAAAE0", VA = "0x182AAB8E0")]
		public void UpdateSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB860", Offset = "0x2AAAA60", VA = "0x182AAB860")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x2AABA60", Offset = "0x2AAAC60", VA = "0x182AABA60")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x2AABA70", Offset = "0x2AAAC70", VA = "0x182AABA70")]
		public FBBIKSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public FullBodyBipedChain chain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public float weight;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x2AABA80", Offset = "0x2AAAC80", VA = "0x182AABA80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x2AABAD0", Offset = "0x2AAACD0", VA = "0x182AABAD0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public FBIKBendGoal()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		[Tooltip("The master weight")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private Animator animator;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x2AABDA0", Offset = "0x2AAAFA0", VA = "0x182AABDA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2AABBA0", Offset = "0x2AAADA0", VA = "0x182AABBA0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public FBIKBoxing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public bool leftHanded;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x2AABDE0", Offset = "0x2AAAFE0", VA = "0x182AABDE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC6B0", Offset = "0x2AAB8B0", VA = "0x182AAC6B0")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x2AABEC0", Offset = "0x2AAB0C0", VA = "0x182AABEC0")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC5B0", Offset = "0x2AAB7B0", VA = "0x182AAC5B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class FPSAiming : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public Vector3 aimOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public bool animatePhysics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public Transform gun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public Transform gunTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public AimIK gunAim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public AimIK headAim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public CameraControllerFPS cam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public Recoil recoil;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private Vector3 camDefaultLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private Vector3 camRelativeToGunTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private bool updateFrame;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE0C0", Offset = "0x2AAD2C0", VA = "0x182AAE0C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2AACEB0", Offset = "0x2AAC0B0", VA = "0x182AACEB0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2AACEC0", Offset = "0x2AAC0C0", VA = "0x182AACEC0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2AACA60", Offset = "0x2AABC60", VA = "0x182AACA60")]
		private void Aiming()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2AACFE0", Offset = "0x2AAC1E0", VA = "0x182AACFE0")]
		private void LookDownTheSight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x2AADD60", Offset = "0x2AACF60", VA = "0x182AADD60")]
		private void RotateCharacter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE2A0", Offset = "0x2AAD4A0", VA = "0x182AAE2A0")]
		public FPSAiming()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public class FPSCharacter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private float sVel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private FPSAiming FPSAiming;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE380", Offset = "0x2AAD580", VA = "0x182AAE380")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE3D0", Offset = "0x2AAD5D0", VA = "0x182AAE3D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE2D0", Offset = "0x2AAD4D0", VA = "0x182AAE2D0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xAABF90", Offset = "0xAAB190", VA = "0x180AABF90")]
		public FPSCharacter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public HitReaction hitReaction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public float hitForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private string colliderName;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE730", Offset = "0x2AAD930", VA = "0x182AAE730")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE690", Offset = "0x2AAD890", VA = "0x182AAE690")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xAB98C0", Offset = "0xAB8AC0", VA = "0x180AB98C0")]
		public HitReactionTrigger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class HoldingHands : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public FullBodyBipedIK rightHandChar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public FullBodyBipedIK leftHandChar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Transform rightHandTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public Transform leftHandTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public float crossFade;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public float speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private Quaternion rightHandRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private Quaternion leftHandRotation;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF0F0", Offset = "0x2AAE2F0", VA = "0x182AAF0F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEC50", Offset = "0x2AADE50", VA = "0x182AAEC50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF2B0", Offset = "0x2AAE4B0", VA = "0x182AAF2B0")]
		public HoldingHands()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public InteractionSystem character1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public InteractionSystem character2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public InteractionObject handShake;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF470", Offset = "0x2AAE670", VA = "0x182AAF470")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF2C0", Offset = "0x2AAE4C0", VA = "0x182AAF2C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public InteractionC2CDemo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public class InteractionDemo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public InteractionSystem interactionSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public bool interrupt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public InteractionObject ball;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public InteractionObject benchMain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public InteractionObject benchHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public InteractionObject button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public InteractionObject cigarette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public InteractionObject door;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private bool isSitting;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF510", Offset = "0x2AAE710", VA = "0x182AAF510")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public InteractionDemo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private InteractionSystem interactionSystem;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF850", Offset = "0x2AAEA50", VA = "0x182AAF850")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF890", Offset = "0x2AAEA90", VA = "0x182AAF890")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200011F")]
		public class Partner
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000824")]
			public FullBodyBipedIK ik;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000825")]
			public Transform mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000826")]
			public Transform mouthTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000827")]
			public Transform touchTargetLeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000828")]
			public Transform touchTargetRightHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000829")]
			public float bodyWeightHorizontal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400082A")]
			public float bodyWeightVertical;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400082B")]
			public float neckRotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400082C")]
			public float headTiltAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400082D")]
			public Vector3 headTiltAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400082E")]
			private Quaternion neckRotation;

			[Cpp2IlInjected.Token(Token = "0x170000D8")]
			private Transform neck
			{
				[Cpp2IlInjected.Token(Token = "0x60007DD")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0A40", Offset = "0x2AAFC40", VA = "0x182AB0A40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007DB")]
			[Cpp2IlInjected.Address(RVA = "0x265C000", Offset = "0x265B200", VA = "0x18265C000")]
			public void Initiate()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DC")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0020", Offset = "0x2AAF220", VA = "0x182AB0020")]
			public void Update(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DE")]
			[Cpp2IlInjected.Address(RVA = "0x2AAFDF0", Offset = "0x2AAEFF0", VA = "0x182AAFDF0")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0A10", Offset = "0x2AAFC10", VA = "0x182AB0A10")]
			public Partner()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public Partner partner1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public Partner partner2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public int iterations;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFB10", Offset = "0x2AAED10", VA = "0x182AAFB10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFAB0", Offset = "0x2AAECB0", VA = "0x182AAFAB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFB60", Offset = "0x2AAED60", VA = "0x182AAFB60")]
		public KissingRig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000120")]
		public enum Mode
		{
			[Cpp2IlInjected.Token(Token = "0x4000830")]
			Position,
			[Cpp2IlInjected.Token(Token = "0x4000831")]
			PositionOffset
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		public class Absorber
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000832")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000833")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000834")]
			private Vector3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000835")]
			private Quaternion rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000836")]
			private IKEffector e;

			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0x2654040", Offset = "0x2653240", VA = "0x182654040")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x2654170", Offset = "0x2653370", VA = "0x182654170")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x2653D40", Offset = "0x2652F40", VA = "0x182653D40")]
			public void SetPosition(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x2653F10", Offset = "0x2653110", VA = "0x182653F10")]
			public void SetRotation(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x26541B0", Offset = "0x26533B0", VA = "0x1826541B0")]
			public Absorber()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private float timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private float w;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private Mode initialMode;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x2668C90", Offset = "0x2667E90", VA = "0x182668C90", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x2668670", Offset = "0x2667870", VA = "0x182668670")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x2668940", Offset = "0x2667B40", VA = "0x182668940", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x26684A0", Offset = "0x26676A0", VA = "0x1826684A0")]
		private void AfterIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x2668840", Offset = "0x2667A40", VA = "0x182668840", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x2668D60", Offset = "0x2667F60", VA = "0x182668D60")]
		public MotionAbsorb()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public MotionAbsorb motionAbsorb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public Transform cube;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public float cubeRandomPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AnimationCurve motionAbsorbWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private Vector3 cubeDefaultPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private AnimatorStateInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private Rigidbody cubeRigidbody;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x2668190", Offset = "0x2667390", VA = "0x182668190")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x26683E0", Offset = "0x26675E0", VA = "0x1826683E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x2668200", Offset = "0x2667400", VA = "0x182668200")]
		private void SwingStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x1467E60", Offset = "0x1467060", VA = "0x181467E60")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		public class EffectorLink
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000837")]
			public FullBodyBipedEffector effectorType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000838")]
			public float weightMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000839")]
			[HideInInspector]
			public Vector3 localPosition;

			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0x23C0E60", Offset = "0x23C0060", VA = "0x1823C0E60")]
			public EffectorLink()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public EffectorLink[] effectorLinks;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x2669DC0", Offset = "0x2668FC0", VA = "0x182669DC0", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x2669A70", Offset = "0x2668C70", VA = "0x182669A70", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x2655EE0", Offset = "0x26550E0", VA = "0x182655EE0")]
		public OffsetEffector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class PendulumExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		[Tooltip("The master weight of this script.")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		[HideInInspector]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		public Vector3 rootTargetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		[HideInInspector]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		public Quaternion rootTargetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public Transform leftHandTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public Transform rightHandTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public Transform leftFootTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public Transform rightFootTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public Transform pelvisTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public Transform bodyTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public Transform headTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public Vector3 pelvisDownAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private Quaternion rootRelativeToPelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private Vector3 pelvisToRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private float lastWeight;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x266A9A0", Offset = "0x2669BA0", VA = "0x18266A9A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x266A050", Offset = "0x2669250", VA = "0x18266A050")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x266AD60", Offset = "0x2669F60", VA = "0x18266AD60")]
		public PendulumExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public int GUIspace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public InteractionSystem interactionSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public InteractionObject obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public Transform pivot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public Transform holdPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public float pickUpTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private float holdWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private float holdWeightVel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private Vector3 pickUpPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private Quaternion pickUpRotation;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private bool holding
		{
			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x266BB10", Offset = "0x266AD10", VA = "0x18266BB10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private bool holdingLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x266B9D0", Offset = "0x266ABD0", VA = "0x18266B9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private bool holdingRight
		{
			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x266BA70", Offset = "0x266AC70", VA = "0x18266BA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x266B370", Offset = "0x266A570", VA = "0x18266B370")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void RotatePivot();

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x266B820", Offset = "0x266AA20", VA = "0x18266B820")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x266B5A0", Offset = "0x266A7A0", VA = "0x18266B5A0")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x266B740", Offset = "0x266A940", VA = "0x18266B740")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x266B230", Offset = "0x266A430", VA = "0x18266B230")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x266ADE0", Offset = "0x2669FE0", VA = "0x18266ADE0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x266B050", Offset = "0x266A250", VA = "0x18266B050")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x266B9C0", Offset = "0x266ABC0", VA = "0x18266B9C0")]
		protected PickUp2Handed()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class PickUpBox : PickUp2Handed
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x266BB40", Offset = "0x266AD40", VA = "0x18266BB40", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x266B9C0", Offset = "0x266ABC0", VA = "0x18266B9C0")]
		public PickUpBox()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public class PickUpSphere : PickUp2Handed
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x266BE00", Offset = "0x266B000", VA = "0x18266BE00", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x266B9C0", Offset = "0x266ABC0", VA = "0x18266B9C0")]
		public PickUpSphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public RagdollUtility ragdollUtility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public Transform root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public Rigidbody pelvis;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x266CA30", Offset = "0x266BC30", VA = "0x18266CA30")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x266CA80", Offset = "0x266BC80", VA = "0x18266CA80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public class RecoilTest : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public float magnitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private Recoil recoil;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x266CCF0", Offset = "0x266BEF0", VA = "0x18266CCF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x266CD30", Offset = "0x266BF30", VA = "0x18266CD30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x266CCA0", Offset = "0x266BEA0", VA = "0x18266CCA0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x99DD00", Offset = "0x99CF00", VA = "0x18099DD00")]
		public RecoilTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400083A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400083B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400083C")]
			public float resetTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400083D")]
			public ResetInteractionObject <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000D9")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007E9")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000DA")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007EB")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x266FDB0", Offset = "0x266EFB0", VA = "0x18266FDB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0x266FF80", Offset = "0x266F180", VA = "0x18266FF80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public float resetDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private Vector3 defaultPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private Quaternion defaultRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private Transform defaultParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private Rigidbody r;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x266CE90", Offset = "0x266C090", VA = "0x18266CE90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x266CD80", Offset = "0x266BF80", VA = "0x18266CD80")]
		private void OnPickUp(Transform t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x266CE20", Offset = "0x266C020", VA = "0x18266CE20")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x99DD00", Offset = "0x99CF00", VA = "0x18099DD00")]
		public ResetInteractionObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public class SoccerDemo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400083E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400083F")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000840")]
			public SoccerDemo <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000DB")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007EF")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000DC")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007F1")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0x266FC10", Offset = "0x266EE10", VA = "0x18266FC10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x266FD60", Offset = "0x266EF60", VA = "0x18266FD60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private Vector3 defaultPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private Quaternion defaultRotation;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x266E850", Offset = "0x266DA50", VA = "0x18266E850")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x266E7F0", Offset = "0x266D9F0", VA = "0x18266E7F0")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public SoccerDemo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000125")]
		public class EffectorLink
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000841")]
			public bool enabled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000842")]
			public FullBodyBipedEffector effectorType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000843")]
			public InteractionObject interactionObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000844")]
			public Transform spherecastFrom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000845")]
			public float spherecastRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000846")]
			public float minDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000847")]
			public float distanceMlp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000848")]
			public LayerMask touchLayers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000849")]
			public float lerpSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400084A")]
			public float minSwitchTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400084B")]
			public float releaseDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400084C")]
			public bool sliding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400084D")]
			private Vector3 raycastDirectionLocal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400084E")]
			private float raycastDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400084F")]
			private bool inTouch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000850")]
			private RaycastHit hit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000851")]
			private Vector3 targetPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x4000852")]
			private Quaternion targetRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
			[Cpp2IlInjected.Token(Token = "0x4000853")]
			private bool initiated;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000854")]
			private float nextSwitchTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
			[Cpp2IlInjected.Token(Token = "0x4000855")]
			private float speedF;

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x265AB40", Offset = "0x2659D40", VA = "0x18265AB40")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x265AA10", Offset = "0x2659C10", VA = "0x18265AA10")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x265B220", Offset = "0x265A420", VA = "0x18265B220")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x265B070", Offset = "0x265A270", VA = "0x18265B070")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x265AF70", Offset = "0x265A170", VA = "0x18265AF70")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x265AEF0", Offset = "0x265A0F0", VA = "0x18265AEF0")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x265AFF0", Offset = "0x265A1F0", VA = "0x18265AFF0")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x265A870", Offset = "0x2659A70", VA = "0x18265A870")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x265BB40", Offset = "0x265AD40", VA = "0x18265BB40")]
			public EffectorLink()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public InteractionSystem interactionSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public EffectorLink[] effectorLinks;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x266F0C0", Offset = "0x266E2C0", VA = "0x18266F0C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x266EF70", Offset = "0x266E170", VA = "0x18266EF70")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x266EFF0", Offset = "0x266E1F0", VA = "0x18266EFF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public TouchWalls()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public class TransferMotion : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x266F130", Offset = "0x266E330", VA = "0x18266F130")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x266F170", Offset = "0x266E370", VA = "0x18266F170")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x266F330", Offset = "0x266E530", VA = "0x18266F330")]
		public TransferMotion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private Vector3 targetPosRelativeToRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private Quaternion targetRotRelativeToRight;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x266FA50", Offset = "0x266EC50", VA = "0x18266FA50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x266F5F0", Offset = "0x266E7F0", VA = "0x18266F5F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x266F4F0", Offset = "0x266E6F0", VA = "0x18266F4F0")]
		private void AfterFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x266F960", Offset = "0x266EB60", VA = "0x18266F960")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public TwoHandedProp()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public CharacterThirdPerson character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public InteractionSystem interactionSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public bool disableInputInInteraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public float enableInputAtProgress;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x2670EE0", Offset = "0x26700E0", VA = "0x182670EE0", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x2670DA0", Offset = "0x266FFA0", VA = "0x182670DA0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x2671000", Offset = "0x2670200", VA = "0x182671000")]
		public UserControlInteractions()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class GrounderDemo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public GameObject[] characters;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE590", Offset = "0x2AAD790", VA = "0x182AAE590")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE500", Offset = "0x2AAD700", VA = "0x182AAE500")]
		public void Activate(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public GrounderDemo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public class PlatformRotator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000856")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000857")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000858")]
			public PlatformRotator <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000DD")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007FE")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000DE")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000800")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FD")]
			[Cpp2IlInjected.Address(RVA = "0x26705A0", Offset = "0x266F7A0", VA = "0x1826705A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0x2670730", Offset = "0x266F930", VA = "0x182670730", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public float maxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public float switchRotationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public float random;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public float rotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public Vector3 movePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public int characterLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private Quaternion defaultRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private Quaternion targetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private Vector3 targetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private Vector3 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private Rigidbody r;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x266C4C0", Offset = "0x266B6C0", VA = "0x18266C4C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x266C040", Offset = "0x266B240", VA = "0x18266C040")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x266C630", Offset = "0x266B830", VA = "0x18266C630")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x266C330", Offset = "0x266B530", VA = "0x18266C330")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x266C400", Offset = "0x266B600", VA = "0x18266C400")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x266C690", Offset = "0x266B890", VA = "0x18266C690")]
		public PlatformRotator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class BendGoal : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public LimbIK limbIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A99BC0", Offset = "0x2A98DC0", VA = "0x182A99BC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2A99AF0", Offset = "0x2A98CF0", VA = "0x182A99AF0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xAB98C0", Offset = "0xAB8AC0", VA = "0x180AB98C0")]
		public BendGoal()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		public class Part
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000859")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400085A")]
			private RotationLimit rotationLimit;

			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0x2669F10", Offset = "0x2669110", VA = "0x182669F10")]
			public void AimAt(Transform target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
			public Part()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public Part[] parts;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x266F340", Offset = "0x266E540", VA = "0x18266F340")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public Turret()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public HitReactionVRIK hitReaction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public float hitForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private string colliderName;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEA10", Offset = "0x2AADC10", VA = "0x182AAEA10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE970", Offset = "0x2AADB70", VA = "0x182AAE970")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xAB98C0", Offset = "0xAB8AC0", VA = "0x180AB98C0")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		[Tooltip("The VRIK component.")]
		public VRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		[Header("Head")]
		[Tooltip("HMD.")]
		public Transform centerEyeAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		[Tooltip("Position offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		[Tooltip("Rotation offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		[Header("Hands")]
		[Tooltip("Left Hand Controller")]
		public Transform leftHandAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		[Tooltip("Right Hand Controller")]
		public Transform rightHandAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		[Tooltip("Position offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		[Tooltip("Rotation offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		[Header("Scale")]
		[Tooltip("Multiplies the scale of the root.")]
		public float scaleMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2671430", Offset = "0x2670630", VA = "0x182671430")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2671630", Offset = "0x2670830", VA = "0x182671630")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x2671690", Offset = "0x2670890", VA = "0x182671690")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2671830", Offset = "0x2670A30", VA = "0x182671830")]
		public VRIKCalibrationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public VRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private Quaternion lastRotation;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x26721D0", Offset = "0x26713D0", VA = "0x1826721D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x2671F60", Offset = "0x2671160", VA = "0x182671F60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x2672240", Offset = "0x2671440", VA = "0x182672240")]
		public VRIKPlatform()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public VRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public Transform platform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public bool moveToPlatform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private Transform lastPlatform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private Quaternion lastRotation;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x2671890", Offset = "0x2670A90", VA = "0x182671890")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x2671EF0", Offset = "0x26710F0", VA = "0x182671EF0")]
		public VRIKPlatformController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public bool smoothFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public float smoothFollowSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		protected bool animatePhysics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private Quaternion lastRotation;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public virtual bool animationGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CA0", Offset = "0x3F1EA0", VA = "0x1803F2CA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x8E7120", Offset = "0x8E6320", VA = "0x1808E7120", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4660", Offset = "0x2AA3860", VA = "0x182AA4660")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4A50", Offset = "0x2AA3C50", VA = "0x182AA4A50", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4720", Offset = "0x2AA3920", VA = "0x182AA4720", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4650", Offset = "0x2AA3850", VA = "0x182AA4650", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4730", Offset = "0x2AA3930", VA = "0x182AA4730")]
		private void SmoothFollow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4BE0", Offset = "0x2AA3DE0", VA = "0x182AA4BE0")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public CharacterThirdPerson characterController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public float pivotOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public AnimationCurve moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private Animator animator;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4DA0", Offset = "0x2AA3FA0", VA = "0x182AA4DA0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4C00", Offset = "0x2AA3E00", VA = "0x182AA4C00", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4DF0", Offset = "0x2AA3FF0", VA = "0x182AA4DF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4BE0", Offset = "0x2AA3DE0", VA = "0x182AA4BE0")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CharacterThirdPerson characterController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		[SerializeField]
		private float turnSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		[SerializeField]
		private float turnSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[SerializeField]
		private float runCycleLegOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		protected Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private Vector3 lastForward;

		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private const string groundedDirectional = "Grounded Directional";

		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private const string groundedStrafe = "Grounded Strafe";

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private float deltaAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private float jumpLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private bool lastJump;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override bool animationGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5DA0", Offset = "0x2AA4FA0", VA = "0x182AA5DA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA57A0", Offset = "0x2AA49A0", VA = "0x182AA57A0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA55A0", Offset = "0x2AA47A0", VA = "0x182AA55A0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5830", Offset = "0x2AA4A30", VA = "0x182AA5830", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA55E0", Offset = "0x2AA47E0", VA = "0x182AA55E0")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5570", Offset = "0x2AA4770", VA = "0x182AA5570")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public float airborneThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public float slopeStartAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public float slopeEndAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public float spherecastRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public LayerMask groundLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private PhysicMaterial zeroFrictionMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private PhysicMaterial highFrictionMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		protected Rigidbody r;

		[Cpp2IlInjected.Token(Token = "0x4000567")]
		protected const float half = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		protected float originalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		protected Vector3 originalCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		protected CapsuleCollider capsule;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5F50", Offset = "0x2AA5150", VA = "0x182AA5F50")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x2AA69E0", Offset = "0x2AA5BE0", VA = "0x182AA69E0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6230", Offset = "0x2AA5430", VA = "0x182AA6230", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5E90", Offset = "0x2AA5090", VA = "0x182AA5E90")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x2AA65B0", Offset = "0x2AA57B0", VA = "0x182AA65B0")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x2AA67C0", Offset = "0x2AA59C0", VA = "0x182AA67C0")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6580", Offset = "0x2AA5780", VA = "0x182AA6580")]
		protected void HighFriction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6B80", Offset = "0x2AA5D80", VA = "0x182AA6B80")]
		protected void ZeroFriction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6120", Offset = "0x2AA5320", VA = "0x182AA6120")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6BB0", Offset = "0x2AA5DB0", VA = "0x182AA6BB0")]
		protected CharacterBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		public enum MoveMode
		{
			[Cpp2IlInjected.Token(Token = "0x400085C")]
			Directional,
			[Cpp2IlInjected.Token(Token = "0x400085D")]
			Strafe
		}

		[Cpp2IlInjected.Token(Token = "0x2000129")]
		public struct AnimState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400085E")]
			public Vector3 moveDirection;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400085F")]
			public bool jump;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
			[Cpp2IlInjected.Token(Token = "0x4000860")]
			public bool crouch;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
			[Cpp2IlInjected.Token(Token = "0x4000861")]
			public bool onGround;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
			[Cpp2IlInjected.Token(Token = "0x4000862")]
			public bool isStrafing;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000863")]
			public float yVelocity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000864")]
			public bool doubleJump;
		}

		[Cpp2IlInjected.Token(Token = "0x200012A")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000865")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000866")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000867")]
			public CharacterThirdPerson <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000868")]
			public Vector3 jumpVelocity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000869")]
			private int <steps>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400086A")]
			private int <stepsToTake>5__3;

			[Cpp2IlInjected.Token(Token = "0x170000DF")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000806")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E0")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000808")]
				[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0AB0", Offset = "0x2AAFCB0", VA = "0x182AB0AB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000807")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0C00", Offset = "0x2AAFE00", VA = "0x182AB0C00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public UserControlThirdPerson userControl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public CameraController cam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public bool smoothPhysics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public float smoothAccelerationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public float linearAccelerationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public float platformFriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public float groundStickyEffect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public float maxVerticalVelocityOnGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public float velocityToGroundTangentWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public float turnSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public float stationaryTurnSpeedMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public float airSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public float airControl;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public float jumpPower;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public float jumpRepeatDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public bool doubleJumpEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public float doubleJumpPowerMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public float wallRunMaxLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public float wallRunMinMoveMag;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public float wallRunMinVelocityY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public float wallRunRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public float wallRunMaxRotationAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public float wallRunWeightSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AnimState animState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		protected Vector3 moveDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private Vector3 normal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private Vector3 platformVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private Vector3 platformAngularVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private RaycastHit hit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private float jumpLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private float jumpEndTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private float forwardMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private float groundDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private float lastAirTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private float stickyForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private Vector3 wallNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private Vector3 moveDirectionVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private float wallRunWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private float lastWallRunWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private float fixedDeltaTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private Vector3 fixedDeltaPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private Quaternion fixedDeltaRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private bool fixedFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private float wallRunEndTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private Vector3 gravity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private Vector3 verticalVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private float velocityY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private bool doubleJumped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E5")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private bool jumpReleased;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool onGround
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0xE748C0", Offset = "0xE73AC0", VA = "0x180E748C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xE73040", Offset = "0xE72240", VA = "0x180E73040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9880", Offset = "0x2AA8A80", VA = "0x182AA9880", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9250", Offset = "0x2AA8450", VA = "0x182AA9250")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9110", Offset = "0x2AA8310", VA = "0x182AA9110", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA71A0", Offset = "0x2AA63A0", VA = "0x182AA71A0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9A00", Offset = "0x2AA8C00", VA = "0x182AA9A00", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8960", Offset = "0x2AA7B60", VA = "0x182AA8960", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8A40", Offset = "0x2AA7C40", VA = "0x182AA8A40")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9B00", Offset = "0x2AA8D00", VA = "0x182AA9B00")]
		private void WallRun()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7100", Offset = "0x2AA6300", VA = "0x182AA7100")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7D10", Offset = "0x2AA6F10", VA = "0x182AA7D10")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x2AA92F0", Offset = "0x2AA84F0", VA = "0x182AA92F0", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7AF0", Offset = "0x2AA6CF0", VA = "0x182AA7AF0")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8680", Offset = "0x2AA7880", VA = "0x182AA8680", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8600", Offset = "0x2AA7800", VA = "0x182AA8600")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__75))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2AA80D0", Offset = "0x2AA72D0", VA = "0x182AA80D0")]
		private void GroundCheck()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA410", Offset = "0x2AA9610", VA = "0x182AAA410")]
		public CharacterThirdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		public enum RotationMode
		{
			[Cpp2IlInjected.Token(Token = "0x400086C")]
			Smooth,
			[Cpp2IlInjected.Token(Token = "0x400086D")]
			Linear
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private float speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private float angleVel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private float speedVel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private Vector3 linearTargetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private CharacterController characterController;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool isGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x82E2C0", Offset = "0x82D4C0", VA = "0x18082E2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x82E330", Offset = "0x82D530", VA = "0x18082E330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x266E580", Offset = "0x266D780", VA = "0x18266E580")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x266E5F0", Offset = "0x266D7F0", VA = "0x18266E5F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x266DD20", Offset = "0x266CF20", VA = "0x18266DD20")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x266E080", Offset = "0x266D280", VA = "0x18266E080")]
		private void Rotate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x266DD60", Offset = "0x266CF60", VA = "0x18266DD60")]
		private void Move()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x266DC10", Offset = "0x266CE10", VA = "0x18266DC10")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x266DB90", Offset = "0x266CD90", VA = "0x18266DB90")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x266E650", Offset = "0x266D850", VA = "0x18266E650")]
		public SimpleLocomotion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public Transform moveTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public float stoppingDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public float stoppingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public Navigator navigator;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2670950", Offset = "0x266FB50", VA = "0x182670950", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2670A40", Offset = "0x266FC40", VA = "0x182670A40", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x2670920", Offset = "0x266FB20", VA = "0x182670920")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2670D80", Offset = "0x266FF80", VA = "0x182670D80")]
		public UserControlAI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200012C")]
		public struct State
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400086E")]
			public Vector3 move;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400086F")]
			public Vector3 lookPos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000870")]
			public bool crouch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000871")]
			public bool jump;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000872")]
			public int actionIndex;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public bool walkByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public bool canCrouch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public bool canJump;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public State state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		protected Transform cam;

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x2671020", Offset = "0x2670220", VA = "0x182671020", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2671050", Offset = "0x2670250", VA = "0x182671050", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2671420", Offset = "0x2670620", VA = "0x182671420")]
		public UserControlThirdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2A95220", Offset = "0x2A94420", VA = "0x182A95220")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D0", Offset = "0x8AFAD0", VA = "0x1808B08D0")]
		public ApplicationQuit()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class SlowMo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public KeyCode[] keyCodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public bool mouse0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public bool mouse1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public float slowMoTimeScale;

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x266E720", Offset = "0x266D920", VA = "0x18266E720")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x266E670", Offset = "0x266D870", VA = "0x18266E670")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x266E7E0", Offset = "0x266D9E0", VA = "0x18266E7E0")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public class Navigator
	{
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		public enum State
		{
			[Cpp2IlInjected.Token(Token = "0x4000874")]
			Idle,
			[Cpp2IlInjected.Token(Token = "0x4000875")]
			Seeking,
			[Cpp2IlInjected.Token(Token = "0x4000876")]
			OnPath
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private int cornerIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private Vector3[] corners;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private NavMeshPath path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private Vector3 lastTargetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private bool initiated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private float nextPathTime;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector3 normalizedDeltaPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x93E9F0", Offset = "0x93DBF0", VA = "0x18093E9F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x93F1B0", Offset = "0x93E3B0", VA = "0x18093F1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public State state
		{
			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x4AD860", Offset = "0x4ACA60", VA = "0x1804AD860")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x71ECB0", Offset = "0x71DEB0", VA = "0x18071ECB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x26690C0", Offset = "0x26682C0", VA = "0x1826690C0")]
		public void Initiate(Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x26691E0", Offset = "0x26683E0", VA = "0x1826691E0")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x2668D70", Offset = "0x2667F70", VA = "0x182668D70")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x2668DE0", Offset = "0x2667FE0", VA = "0x182668DE0")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x2669170", Offset = "0x2668370", VA = "0x182669170")]
		private void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x2669000", Offset = "0x2668200", VA = "0x182669000")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x2669760", Offset = "0x2668960", VA = "0x182669760")]
		public void Visualize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x2669A00", Offset = "0x2668C00", VA = "0x182669A00")]
		public Navigator()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
