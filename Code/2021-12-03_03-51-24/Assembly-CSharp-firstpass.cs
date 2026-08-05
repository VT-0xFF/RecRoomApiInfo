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
	[Cpp2IlInjected.Address(RVA = "0x3F8B130", Offset = "0x3F8A330", VA = "0x183F8B130")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F8AFD0", Offset = "0x3F8A1D0", VA = "0x183F8AFD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x46F160", Offset = "0x46E360", VA = "0x18046F160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B060", Offset = "0x3F8A260", VA = "0x183F8B060")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B0C0", Offset = "0x3F8A2C0", VA = "0x183F8B0C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F30A0", Offset = "0x4F22A0", VA = "0x1804F30A0")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B640", Offset = "0x3F8A840", VA = "0x183F8B640")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F30A0", Offset = "0x4F22A0", VA = "0x1804F30A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B640", Offset = "0x3F8A840", VA = "0x183F8B640")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x471CF0", Offset = "0x470EF0", VA = "0x180471CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B6B0", Offset = "0x3F8A8B0", VA = "0x183F8B6B0")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B720", Offset = "0x3F8A920", VA = "0x183F8B720")]
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
			[Cpp2IlInjected.Address(RVA = "0xB12C40", Offset = "0xB11E40", VA = "0x180B12C40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB12C50", Offset = "0xB11E50", VA = "0x180B12C50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x96CEC0", Offset = "0x96C0C0", VA = "0x18096CEC0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B8A0", Offset = "0x3F8AAA0", VA = "0x183F8B8A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB12C40", Offset = "0xB11E40", VA = "0x180B12C40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB12C50", Offset = "0xB11E50", VA = "0x180B12C50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x96CEC0", Offset = "0x96C0C0", VA = "0x18096CEC0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B8A0", Offset = "0x3F8AAA0", VA = "0x183F8B8A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA74E40", Offset = "0xA74040", VA = "0x180A74E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x46FC60", Offset = "0x46EE60", VA = "0x18046FC60")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B670", Offset = "0x3F8A870", VA = "0x183F8B670")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x559DB0", Offset = "0x558FB0", VA = "0x180559DB0")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x559DB0", Offset = "0x558FB0", VA = "0x180559DB0")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x559DB0", Offset = "0x558FB0", VA = "0x180559DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x515360", Offset = "0x514560", VA = "0x180515360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5127E0", Offset = "0x5119E0", VA = "0x1805127E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float bakingProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xE04170", Offset = "0xE03370", VA = "0x180E04170")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2F721D0", Offset = "0x2F713D0", VA = "0x182F721D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected float clipLength
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xBCF350", Offset = "0xBCE550", VA = "0x180BCF350")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xA54BD0", Offset = "0xA53DD0", VA = "0x180A54BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2F720C0", Offset = "0x2F712C0", VA = "0x182F720C0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2F72080", Offset = "0x2F71280", VA = "0x182F72080")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2F72100", Offset = "0x2F71300", VA = "0x182F72100")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2F72040", Offset = "0x2F71240", VA = "0x182F72040")]
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
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00")]
		public void BakeClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00")]
		public void StartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00")]
		public void StopBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2F72140", Offset = "0x2F71340", VA = "0x182F72140")]
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
		[Cpp2IlInjected.Address(RVA = "0x2EFC8C0", Offset = "0x2EFBAC0", VA = "0x182EFC8C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4825A0", Offset = "0x4817A0", VA = "0x1804825A0", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2EFCF70", Offset = "0x2EFC170", VA = "0x182EFCF70", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2EFCED0", Offset = "0x2EFC0D0", VA = "0x182EFCED0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2EFCD90", Offset = "0x2EFBF90", VA = "0x182EFCD90", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2EFCE30", Offset = "0x2EFC030", VA = "0x182EFCE30", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2EFCCB0", Offset = "0x2EFBEB0", VA = "0x182EFCCB0")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2EFCBD0", Offset = "0x2EFBDD0", VA = "0x182EFCBD0")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2EFD0D0", Offset = "0x2EFC2D0", VA = "0x182EFD0D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0FAB0", Offset = "0x2F0ECB0", VA = "0x182F0FAB0")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AvatarUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2F6E0F0", Offset = "0x2F6D2F0", VA = "0x182F6E0F0")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D960", Offset = "0x2F6CB60", VA = "0x182F6D960")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2F6E310", Offset = "0x2F6D510", VA = "0x182F6E310")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		public AvatarUtility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class BakerUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2F71D00", Offset = "0x2F70F00", VA = "0x182F71D00")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2F71780", Offset = "0x2F70980", VA = "0x182F71780")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2F71D40", Offset = "0x2F70F40", VA = "0x182F71D40")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2F714F0", Offset = "0x2F706F0", VA = "0x182F714F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6FC50", Offset = "0x2F6EE50", VA = "0x182F6FC50")]
		public BakerHumanoidQT(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2F6FB40", Offset = "0x2F6ED40", VA = "0x182F6FB40")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2F6EF90", Offset = "0x2F6E190", VA = "0x182F6EF90")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2F6F560", Offset = "0x2F6E760", VA = "0x182F6F560")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2F6F960", Offset = "0x2F6EB60", VA = "0x182F6F960")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2F6EE30", Offset = "0x2F6E030", VA = "0x182F6EE30")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2F6FAB0", Offset = "0x2F6ECB0", VA = "0x182F6FAB0")]
		public void SetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2F6EDA0", Offset = "0x2F6DFA0", VA = "0x182F6EDA0")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2F6EED0", Offset = "0x2F6E0D0", VA = "0x182F6EED0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2F6F0D0", Offset = "0x2F6E2D0", VA = "0x182F6F0D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F705D0", Offset = "0x2F6F7D0", VA = "0x182F705D0")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2F6FD40", Offset = "0x2F6EF40", VA = "0x182F6FD40")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2F6EED0", Offset = "0x2F6E0D0", VA = "0x182F6EED0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2F703D0", Offset = "0x2F6F5D0", VA = "0x182F703D0")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2F70380", Offset = "0x2F6F580", VA = "0x182F70380")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2F70570", Offset = "0x2F6F770", VA = "0x182F70570")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2F705C0", Offset = "0x2F6F7C0", VA = "0x182F705C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F71390", Offset = "0x2F70590", VA = "0x182F71390")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2F71370", Offset = "0x2F70570", VA = "0x182F71370")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2F70E30", Offset = "0x2F70030", VA = "0x182F70E30")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2F70940", Offset = "0x2F6FB40", VA = "0x182F70940")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2F70D30", Offset = "0x2F6FF30", VA = "0x182F70D30")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2F70BB0", Offset = "0x2F6FDB0", VA = "0x182F70BB0")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2F710C0", Offset = "0x2F702C0", VA = "0x182F710C0")]
		public void SetKeyframes(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2F70670", Offset = "0x2F6F870", VA = "0x182F70670")]
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
		[Cpp2IlInjected.Address(RVA = "0x2EFE050", Offset = "0x2EFD250", VA = "0x182EFE050")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2EFE480", Offset = "0x2EFD680", VA = "0x182EFE480", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2EFEDA0", Offset = "0x2EFDFA0", VA = "0x182EFEDA0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2EFEC80", Offset = "0x2EFDE80", VA = "0x182EFEC80", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2EFE4A0", Offset = "0x2EFD6A0", VA = "0x182EFE4A0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2EFE720", Offset = "0x2EFD920", VA = "0x182EFE720", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2EFEEF0", Offset = "0x2EFE0F0", VA = "0x182EFEEF0")]
		private void UpdateHumanPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF010", Offset = "0x2EFE210", VA = "0x182EFF010")]
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
			[Cpp2IlInjected.Address(RVA = "0xC563E0", Offset = "0xC555E0", VA = "0x180C563E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xC563F0", Offset = "0xC555F0", VA = "0x180C563F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float y
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x12F3420", Offset = "0x12F2620", VA = "0x1812F3420")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x12F3430", Offset = "0x12F2630", VA = "0x1812F3430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float distanceTarget
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB03FD0", Offset = "0xB031D0", VA = "0x180B03FD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x12F3770", Offset = "0x12F2970", VA = "0x1812F3770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float zoomAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2F7CCE0", Offset = "0x2F7BEE0", VA = "0x182F7CCE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2F7C060", Offset = "0x2F7B260", VA = "0x182F7C060")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2F7C0A0", Offset = "0x2F7B2A0", VA = "0x182F7C0A0")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2F7BD90", Offset = "0x2F7AF90", VA = "0x182F7BD90", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2F7CB80", Offset = "0x2F7BD80", VA = "0x182F7CB80", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2F7BF90", Offset = "0x2F7B190", VA = "0x182F7BF90", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2F7BFF0", Offset = "0x2F7B1F0", VA = "0x182F7BFF0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2F7C0B0", Offset = "0x2F7B2B0", VA = "0x182F7C0B0")]
		public void UpdateInput()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2F7C2F0", Offset = "0x2F7B4F0", VA = "0x182F7C2F0")]
		public void UpdateTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2F7C320", Offset = "0x2F7B520", VA = "0x182F7C320")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2F7BEF0", Offset = "0x2F7B0F0", VA = "0x182F7BEF0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2F7CBB0", Offset = "0x2F7BDB0", VA = "0x182F7CBB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7BA50", Offset = "0x2F7AC50", VA = "0x182F7BA50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2F7BB40", Offset = "0x2F7AD40", VA = "0x182F7BB40")]
		public void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2F7BAA0", Offset = "0x2F7ACA0", VA = "0x182F7BAA0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2F7BD70", Offset = "0x2F7AF70", VA = "0x182F7BD70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6ECD0", Offset = "0x2F6DED0", VA = "0x182F6ECD0")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2F6EC10", Offset = "0x2F6DE10", VA = "0x182F6EC10")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2F6E4B0", Offset = "0x2F6D6B0", VA = "0x182F6E4B0")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2F6E340", Offset = "0x2F6D540", VA = "0x182F6E340")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2F6EAE0", Offset = "0x2F6DCE0", VA = "0x182F6EAE0")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2F6E6B0", Offset = "0x2F6D8B0", VA = "0x182F6E6B0")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2F6E730", Offset = "0x2F6D930", VA = "0x182F6E730")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F88260", Offset = "0x2F87460", VA = "0x182F88260")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F72DC0", Offset = "0x2F71FC0", VA = "0x182F72DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static BipedLimbOrientations MaxBiped
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x2F72AC0", Offset = "0x2F71CC0", VA = "0x182F72AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5978D0", Offset = "0x596AD0", VA = "0x1805978D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F73CE0", Offset = "0x2F72EE0", VA = "0x182F73CE0")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2F739A0", Offset = "0x2F72BA0", VA = "0x182F739A0")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2F73B20", Offset = "0x2F72D20", VA = "0x182F73B20")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2F73E60", Offset = "0x2F73060", VA = "0x182F73E60")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2F73F10", Offset = "0x2F73110", VA = "0x182F73F10")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2F733F0", Offset = "0x2F725F0", VA = "0x182F733F0")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2F730C0", Offset = "0x2F722C0", VA = "0x182F730C0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2F73910", Offset = "0x2F72B10", VA = "0x182F73910")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2F771C0", Offset = "0x2F763C0", VA = "0x182F771C0")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2F773E0", Offset = "0x2F765E0", VA = "0x182F773E0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2F77550", Offset = "0x2F76750", VA = "0x182F77550")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2F77100", Offset = "0x2F76300", VA = "0x182F77100")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2F76F80", Offset = "0x2F76180", VA = "0x182F76F80")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2F77320", Offset = "0x2F76520", VA = "0x182F77320")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2F77610", Offset = "0x2F76810", VA = "0x182F77610")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2F77040", Offset = "0x2F76240", VA = "0x182F77040")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2F776D0", Offset = "0x2F768D0", VA = "0x182F776D0")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2F77860", Offset = "0x2F76A60", VA = "0x182F77860")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2F76E90", Offset = "0x2F76090", VA = "0x182F76E90")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2F777A0", Offset = "0x2F769A0", VA = "0x182F777A0")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2F74040", Offset = "0x2F73240", VA = "0x182F74040")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2F76F20", Offset = "0x2F76120", VA = "0x182F76F20")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2F77740", Offset = "0x2F76940", VA = "0x182F77740")]
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
				[Cpp2IlInjected.Address(RVA = "0x2F6D950", Offset = "0x2F6CB50", VA = "0x182F6D950")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x2F6D940", Offset = "0x2F6CB40", VA = "0x182F6D940")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F7B610", Offset = "0x2F7A810", VA = "0x182F7B610", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool isEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x601520", Offset = "0x600720", VA = "0x180601520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2F79C20", Offset = "0x2F78E20", VA = "0x182F79C20", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2F78570", Offset = "0x2F77770", VA = "0x182F78570", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2F781C0", Offset = "0x2F773C0", VA = "0x182F781C0")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2F78B40", Offset = "0x2F77D40", VA = "0x182F78B40")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2F77CC0", Offset = "0x2F76EC0", VA = "0x182F77CC0")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2F7AF00", Offset = "0x2F7A100", VA = "0x182F7AF00")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2F7B040", Offset = "0x2F7A240", VA = "0x182F7B040")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2F7A0A0", Offset = "0x2F792A0", VA = "0x182F7A0A0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2F77950", Offset = "0x2F76B50", VA = "0x182F77950")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2F77B30", Offset = "0x2F76D30", VA = "0x182F77B30")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2F78A00", Offset = "0x2F77C00", VA = "0x182F78A00")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2F77A50", Offset = "0x2F76C50", VA = "0x182F77A50")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2F7A190", Offset = "0x2F79390", VA = "0x182F7A190")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2F7A7C0", Offset = "0x2F799C0", VA = "0x182F7A7C0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2F7B130", Offset = "0x2F7A330", VA = "0x182F7B130")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x46FE40", Offset = "0x46F040", VA = "0x18046FE40")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2F79690", Offset = "0x2F78890", VA = "0x182F79690")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x46FE40", Offset = "0x46F040", VA = "0x18046FE40")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2F7ABA0", Offset = "0x2F79DA0", VA = "0x182F7ABA0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2F79880", Offset = "0x2F78A80", VA = "0x182F79880")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2F79B00", Offset = "0x2F78D00", VA = "0x182F79B00")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2F7B5B0", Offset = "0x2F7A7B0", VA = "0x182F7B5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F82C90", Offset = "0x2F81E90", VA = "0x182F82C90")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2F82D40", Offset = "0x2F81F40", VA = "0x182F82D40")]
		public DemoGUIMessage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class Hierarchy
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2EFDC30", Offset = "0x2EFCE30", VA = "0x182EFDC30")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2EFD500", Offset = "0x2EFC700", VA = "0x182EFD500")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2EFDCD0", Offset = "0x2EFCED0", VA = "0x182EFDCD0")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2EFD3F0", Offset = "0x2EFC5F0", VA = "0x182EFD3F0")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2EFD130", Offset = "0x2EFC330", VA = "0x182EFD130")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2EFD630", Offset = "0x2EFC830", VA = "0x182EFD630")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2EFDAA0", Offset = "0x2EFCCA0", VA = "0x182EFDAA0")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2EFD8F0", Offset = "0x2EFCAF0", VA = "0x182EFD8F0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2EFD750", Offset = "0x2EFC950", VA = "0x182EFD750")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2EFDE40", Offset = "0x2EFD040", VA = "0x182EFDE40")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2EFF0B0", Offset = "0x2EFE2B0", VA = "0x182EFF0B0")]
		public InspectorComment(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF110", Offset = "0x2EFE310", VA = "0x182EFF110")]
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
		[Cpp2IlInjected.Address(RVA = "0x2EFF5E0", Offset = "0x2EFE7E0", VA = "0x182EFF5E0")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2F006F0", Offset = "0x2EFF8F0", VA = "0x182F006F0")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2F00110", Offset = "0x2EFF310", VA = "0x182F00110")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2F00210", Offset = "0x2EFF410", VA = "0x182F00210")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2EFFEF0", Offset = "0x2EFF0F0", VA = "0x182EFFEF0")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2EFFF20", Offset = "0x2EFF120", VA = "0x182EFFF20")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2F00050", Offset = "0x2EFF250", VA = "0x182F00050")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2F00030", Offset = "0x2EFF230", VA = "0x182F00030")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2EFFD10", Offset = "0x2EFEF10", VA = "0x182EFFD10")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2F00020", Offset = "0x2EFF220", VA = "0x182F00020")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2F005F0", Offset = "0x2EFF7F0", VA = "0x182F005F0")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2F00590", Offset = "0x2EFF790", VA = "0x182F00590")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2F002F0", Offset = "0x2EFF4F0", VA = "0x182F002F0")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2F00510", Offset = "0x2EFF710", VA = "0x182F00510")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2F00550", Offset = "0x2EFF750", VA = "0x182F00550")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF570", Offset = "0x2EFE770", VA = "0x182EFF570")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF5A0", Offset = "0x2EFE7A0", VA = "0x182EFF5A0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2F00220", Offset = "0x2EFF420", VA = "0x182F00220")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2F00260", Offset = "0x2EFF460", VA = "0x182F00260")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2F003A0", Offset = "0x2EFF5A0", VA = "0x182F003A0")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2F00330", Offset = "0x2EFF530", VA = "0x182F00330")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2EFFD90", Offset = "0x2EFEF90", VA = "0x182EFFD90")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2EFFD30", Offset = "0x2EFEF30", VA = "0x182EFFD30")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2F00070", Offset = "0x2EFF270", VA = "0x182F00070")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2F00660", Offset = "0x2EFF860", VA = "0x182F00660")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2EFFF70", Offset = "0x2EFF170", VA = "0x182EFFF70")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2EFFDF0", Offset = "0x2EFEFF0", VA = "0x182EFFDF0")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2F00410", Offset = "0x2EFF610", VA = "0x182F00410")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2EFFCE0", Offset = "0x2EFEEE0", VA = "0x182EFFCE0")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2F002B0", Offset = "0x2EFF4B0", VA = "0x182F002B0")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F00880", Offset = "0x2EFFA80", VA = "0x182F00880")]
		public LargeHeader(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2F00820", Offset = "0x2EFFA20", VA = "0x182F00820")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class LayerMaskExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2F00920", Offset = "0x2EFFB20", VA = "0x182F00920")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2F00960", Offset = "0x2EFFB60", VA = "0x182F00960")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2F00970", Offset = "0x2EFFB70", VA = "0x182F00970")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2F00DD0", Offset = "0x2EFFFD0", VA = "0x182F00DD0")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2F00970", Offset = "0x2EFFB70", VA = "0x182F00970")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2F009F0", Offset = "0x2EFFBF0", VA = "0x182F009F0")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2F008E0", Offset = "0x2EFFAE0", VA = "0x182F008E0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2F00E70", Offset = "0x2F00070", VA = "0x182F00E70")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2F00A10", Offset = "0x2EFFC10", VA = "0x182F00A10")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2F00AF0", Offset = "0x2EFFCF0", VA = "0x182F00AF0")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2F00BB0", Offset = "0x2EFFDB0", VA = "0x182F00BB0")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2F00CD0", Offset = "0x2EFFED0", VA = "0x182F00CD0")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class QuaTools
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2F04840", Offset = "0x2F03A40", VA = "0x182F04840")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2F045F0", Offset = "0x2F037F0", VA = "0x182F045F0")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2F04000", Offset = "0x2F03200", VA = "0x182F04000")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2F046F0", Offset = "0x2F038F0", VA = "0x182F046F0")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2F044A0", Offset = "0x2F036A0", VA = "0x182F044A0")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2F04220", Offset = "0x2F03420", VA = "0x182F04220")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2F04930", Offset = "0x2F03B30", VA = "0x182F04930")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2F04D30", Offset = "0x2F03F30", VA = "0x182F04D30")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2F04A00", Offset = "0x2F03C00", VA = "0x182F04A00")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2F04E00", Offset = "0x2F04000", VA = "0x182F04E00")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2F03A10", Offset = "0x2F02C10", VA = "0x182F03A10")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2F04C60", Offset = "0x2F03E60", VA = "0x182F04C60")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2F03BC0", Offset = "0x2F02DC0", VA = "0x182F03BC0")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2F03CE0", Offset = "0x2F02EE0", VA = "0x182F03CE0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2F03780", Offset = "0x2F02980", VA = "0x182F03780")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2F035A0", Offset = "0x2F027A0", VA = "0x182F035A0")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2F04AF0", Offset = "0x2F03CF0", VA = "0x182F04AF0")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2F04F40", Offset = "0x2F04140", VA = "0x182F04F40")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2F04EF0", Offset = "0x2F040F0", VA = "0x182F04EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA8D390", Offset = "0xA8C590", VA = "0x180A8D390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x21E64C0", Offset = "0x21E56C0", VA = "0x1821E64C0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x20C3410", Offset = "0x20C2610", VA = "0x1820C3410")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F0F920", Offset = "0x2F0EB20", VA = "0x182F0F920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool isAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2F0FA00", Offset = "0x2F0EC00", VA = "0x182F0FA00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F580", Offset = "0x2F0E780", VA = "0x182F0F580")]
		public void Disable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F840", Offset = "0x2F0EA40", VA = "0x182F0F840")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F7A0", Offset = "0x2F0E9A0", VA = "0x182F0F7A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F7A0", Offset = "0x2F0E9A0", VA = "0x182F0F7A0")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F8E0", Offset = "0x2F0EAE0", VA = "0x182F0F8E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F600", Offset = "0x2F0E800", VA = "0x182F0F600")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F7F0", Offset = "0x2F0E9F0", VA = "0x182F0F7F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F8A0", Offset = "0x2F0EAA0", VA = "0x182F0F8A0")]
		public void UpdateSolverExternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xB3C300", Offset = "0xB3B500", VA = "0x180B3C300")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0FC30", Offset = "0x2F0EE30", VA = "0x182F0FC30")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2F0FD70", Offset = "0x2F0EF70", VA = "0x182F0FD70")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0FCD0", Offset = "0x2F0EED0", VA = "0x182F0FCD0")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class V2Tools
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x29076E0", Offset = "0x29068E0", VA = "0x1829076E0")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2F11800", Offset = "0x2F10A00", VA = "0x182F11800")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2F11740", Offset = "0x2F10940", VA = "0x182F11740")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2F118A0", Offset = "0x2F10AA0", VA = "0x182F118A0")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2F11A40", Offset = "0x2F10C40", VA = "0x182F11A40")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class V3Tools
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C960", Offset = "0x3F8BB60", VA = "0x183F8C960")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C7A0", Offset = "0x3F8B9A0", VA = "0x183F8C7A0")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C640", Offset = "0x3F8B840", VA = "0x183F8C640")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C9E0", Offset = "0x3F8BBE0", VA = "0x183F8C9E0")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C830", Offset = "0x3F8BA30", VA = "0x183F8C830")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C440", Offset = "0x3F8B640", VA = "0x183F8C440")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CDF0", Offset = "0x3F8BFF0", VA = "0x183F8CDF0")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D330", Offset = "0x3F8C530", VA = "0x183F8D330")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C320", Offset = "0x3F8B520", VA = "0x183F8C320")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C1D0", Offset = "0x3F8B3D0", VA = "0x183F8C1D0")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3F8BC40", Offset = "0x3F8AE40", VA = "0x183F8BC40")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3F8BF00", Offset = "0x3F8B100", VA = "0x183F8BF00")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B930", Offset = "0x3F8AB30", VA = "0x183F8B930")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CEE0", Offset = "0x3F8C0E0", VA = "0x183F8CEE0")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D0F0", Offset = "0x3F8C2F0", VA = "0x183F8D0F0")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D420", Offset = "0x3F8C620", VA = "0x183F8D420")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CB10", Offset = "0x3F8BD10", VA = "0x183F8CB10")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CC70", Offset = "0x3F8BE70", VA = "0x183F8CC70")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D570", Offset = "0x3F8C770", VA = "0x183F8D570")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8770", Offset = "0x3EB7970", VA = "0x183EB8770")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F8D6D0", Offset = "0x3F8C8D0", VA = "0x183F8D6D0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D760", Offset = "0x3F8C960", VA = "0x183F8D760")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4D110", Offset = "0x2A4C310", VA = "0x182A4D110")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D0D0", Offset = "0x2A4C2D0", VA = "0x182A4D0D0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D620", Offset = "0x2A4C820", VA = "0x182A4D620")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C960", Offset = "0x2A4BB60", VA = "0x182A4C960")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CAE0", Offset = "0x2A4BCE0", VA = "0x182A4CAE0")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CBF0", Offset = "0x2A4BDF0", VA = "0x182A4CBF0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D150", Offset = "0x2A4C350", VA = "0x182A4D150")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D240", Offset = "0x2A4C440", VA = "0x182A4D240")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D1C0", Offset = "0x2A4C3C0", VA = "0x182A4D1C0")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D2B0", Offset = "0x2A4C4B0", VA = "0x182A4D2B0")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CB50", Offset = "0x2A4BD50", VA = "0x182A4CB50")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CC60", Offset = "0x2A4BE60", VA = "0x182A4CC60")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D350", Offset = "0x2A4C550", VA = "0x182A4D350")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D320", Offset = "0x2A4C520", VA = "0x182A4D320")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D390", Offset = "0x2A4C590", VA = "0x182A4D390")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D3C0", Offset = "0x2A4C5C0", VA = "0x182A4D3C0")]
		public void SetSpineWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CA70", Offset = "0x2A4BC70", VA = "0x182A4CA70")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8238B0", Offset = "0x822AB0", VA = "0x1808238B0")]
		public void InitiateBipedIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5309C0", Offset = "0x52FBC0", VA = "0x1805309C0")]
		public void UpdateBipedIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D3F0", Offset = "0x2A4C5F0", VA = "0x182A4D3F0")]
		public void SetToDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C9A0", Offset = "0x2A4BBA0", VA = "0x182A4C9A0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CCD0", Offset = "0x2A4BED0", VA = "0x182A4CCD0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D660", Offset = "0x2A4C860", VA = "0x182A4D660", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D0A0", Offset = "0x2A4C2A0", VA = "0x182A4D0A0")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D890", Offset = "0x2A4CA90", VA = "0x182A4D890")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A4C7A0", Offset = "0x2A4B9A0", VA = "0x182A4C7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IKSolver[] ikSolvers
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x2A4C4F0", Offset = "0x2A4B6F0", VA = "0x182A4C4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C210", Offset = "0x2A4B410", VA = "0x182A4C210")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C3B0", Offset = "0x2A4B5B0", VA = "0x182A4C3B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A4F4A0", Offset = "0x2A4E6A0", VA = "0x182A4F4A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void UpdateConstraint();

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4EE70", Offset = "0x2A4E070", VA = "0x182A4EE70", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		public ConstraintPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x52C590", Offset = "0x52B790", VA = "0x18052C590")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A4EDB0", Offset = "0x2A4DFB0", VA = "0x182A4EDB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EAB0", Offset = "0x2A4DCB0", VA = "0x182A4EAB0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		public ConstraintPositionOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x52C590", Offset = "0x52B790", VA = "0x18052C590")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4F340", Offset = "0x2A4E540", VA = "0x182A4F340", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		public ConstraintRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x52C590", Offset = "0x52B790", VA = "0x18052C590")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A4F2A0", Offset = "0x2A4E4A0", VA = "0x182A4F2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F010", Offset = "0x2A4E210", VA = "0x182A4F010", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		public ConstraintRotationOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x52C590", Offset = "0x52B790", VA = "0x18052C590")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4F570", Offset = "0x2A4E770", VA = "0x182A4F570")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F500", Offset = "0x2A4E700", VA = "0x182A4F500")]
		public void Initiate(Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F5D0", Offset = "0x2A4E7D0", VA = "0x182A4F5D0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4991F0", Offset = "0x4983F0", VA = "0x1804991F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x6F15E0", Offset = "0x6F07E0", VA = "0x1806F15E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 IKPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3253300", Offset = "0x3252500", VA = "0x183253300")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x3253360", Offset = "0x3252560", VA = "0x183253360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion IKRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x3253330", Offset = "0x3252530", VA = "0x183253330")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x3253390", Offset = "0x3252590", VA = "0x183253390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3252A00", Offset = "0x3251C00", VA = "0x183252A00")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3252170", Offset = "0x3251370", VA = "0x183252170")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3252080", Offset = "0x3251280", VA = "0x183252080")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3252B00", Offset = "0x3251D00", VA = "0x183252B00")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3252BE0", Offset = "0x3251DE0", VA = "0x183252BE0")]
		public void Update(float masterWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x128D380", Offset = "0x128C580", VA = "0x18128D380")]
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
			[Cpp2IlInjected.Address(RVA = "0x4991F0", Offset = "0x4983F0", VA = "0x1804991F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x6F15E0", Offset = "0x6F07E0", VA = "0x1806F15E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3251C60", Offset = "0x3250E60", VA = "0x183251C60")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x32517B0", Offset = "0x32509B0", VA = "0x1832517B0")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3251620", Offset = "0x3250820", VA = "0x183251620")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3251CF0", Offset = "0x3250EF0", VA = "0x183251CF0")]
		public void RemoveFinger(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3251530", Offset = "0x3250730", VA = "0x183251530")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3251B80", Offset = "0x3250D80", VA = "0x183251B80", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3251FB0", Offset = "0x32511B0", VA = "0x183251FB0")]
		public void UpdateFingerSolvers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3251A10", Offset = "0x3250C10", VA = "0x183251A10")]
		public void FixFingerTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3251E70", Offset = "0x3251070", VA = "0x183251E70")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3251FB0", Offset = "0x32511B0", VA = "0x183251FB0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3251A10", Offset = "0x3250C10", VA = "0x183251A10", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3252030", Offset = "0x3251230", VA = "0x183252030")]
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
			[Cpp2IlInjected.Address(RVA = "0x546F80", Offset = "0x546180", VA = "0x180546F80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x547060", Offset = "0x546260", VA = "0x180547060")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ResetPosition();

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x325C590", Offset = "0x325B790", VA = "0x18325C590")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D0A0", Offset = "0x2A4C2A0", VA = "0x182A4D0A0")]
		protected void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x325C0F0", Offset = "0x325B2F0", VA = "0x18325C0F0")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x325C300", Offset = "0x325B500", VA = "0x18325C300")]
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
		[Cpp2IlInjected.Address(RVA = "0x325C950", Offset = "0x325BB50", VA = "0x18325C950")]
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
		[Cpp2IlInjected.Address(RVA = "0x3255620", Offset = "0x3254820", VA = "0x183255620", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x32555E0", Offset = "0x32547E0", VA = "0x1832555E0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3255660", Offset = "0x3254860", VA = "0x183255660", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3254970", Offset = "0x3253B70", VA = "0x183254970")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x32557F0", Offset = "0x32549F0", VA = "0x1832557F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x32545F0", Offset = "0x32537F0", VA = "0x1832545F0")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3254BD0", Offset = "0x3253DD0", VA = "0x183254BD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3254E70", Offset = "0x3254070", VA = "0x183254E70")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x32556E0", Offset = "0x32548E0", VA = "0x1832556E0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3254C30", Offset = "0x3253E30", VA = "0x183254C30")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3254A30", Offset = "0x3253C30", VA = "0x183254A30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3255930", Offset = "0x3254B30", VA = "0x183255930")]
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
			[Cpp2IlInjected.Address(RVA = "0x2677300", Offset = "0x2676500", VA = "0x182677300")]
			public SpineEffector()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x326D650", Offset = "0x326C850", VA = "0x18326D650")]
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
		[Cpp2IlInjected.Address(RVA = "0x32565C0", Offset = "0x32557C0", VA = "0x1832565C0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3256600", Offset = "0x3255800", VA = "0x183256600", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3256580", Offset = "0x3255780", VA = "0x183256580", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3256640", Offset = "0x3255840", VA = "0x183256640", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3255C30", Offset = "0x3254E30", VA = "0x183255C30")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3256910", Offset = "0x3255B10", VA = "0x183256910")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x32559A0", Offset = "0x3254BA0", VA = "0x1832559A0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x32559A0", Offset = "0x3254BA0", VA = "0x1832559A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x32559B0", Offset = "0x3254BB0", VA = "0x1832559B0")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3255EE0", Offset = "0x32550E0", VA = "0x183255EE0")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x32566C0", Offset = "0x32558C0", VA = "0x1832566C0")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3255DD0", Offset = "0x3254FD0", VA = "0x183255DD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3255CD0", Offset = "0x3254ED0", VA = "0x183255CD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3256A30", Offset = "0x3255C30", VA = "0x183256A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3257B50", Offset = "0x3256D50", VA = "0x183257B50", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3257B10", Offset = "0x3256D10", VA = "0x183257B10", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3257B90", Offset = "0x3256D90", VA = "0x183257B90", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3256FD0", Offset = "0x32561D0", VA = "0x183256FD0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3257370", Offset = "0x3256570", VA = "0x183257370")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3258040", Offset = "0x3257240", VA = "0x183258040")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3256AA0", Offset = "0x3255CA0", VA = "0x183256AA0")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3257710", Offset = "0x3256910", VA = "0x183257710")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3257BB0", Offset = "0x3256DB0", VA = "0x183257BB0")]
		private void SetLegIK(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x32574B0", Offset = "0x32566B0", VA = "0x1832574B0")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3257160", Offset = "0x3256360", VA = "0x183257160")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x32585B0", Offset = "0x32577B0", VA = "0x1832585B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x32533B0", Offset = "0x32525B0", VA = "0x1832533B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x325A260", Offset = "0x3259460", VA = "0x18325A260", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x325A220", Offset = "0x3259420", VA = "0x18325A220", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x325A2A0", Offset = "0x32594A0", VA = "0x18325A2A0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3259110", Offset = "0x3258310", VA = "0x183259110")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3258FD0", Offset = "0x32581D0", VA = "0x183258FD0")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x32593E0", Offset = "0x32585E0", VA = "0x1832593E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x325AE10", Offset = "0x325A010", VA = "0x18325AE10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3258C30", Offset = "0x3257E30", VA = "0x183258C30")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3258820", Offset = "0x3257A20", VA = "0x183258820")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3259260", Offset = "0x3258460", VA = "0x183259260")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x325A2E0", Offset = "0x32594E0", VA = "0x18325A2E0")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3259850", Offset = "0x3258A50", VA = "0x183259850")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x325AA90", Offset = "0x3259C90", VA = "0x18325AA90")]
		private void UpdateForefeetRoot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x325A8B0", Offset = "0x3259AB0", VA = "0x18325A8B0")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3259460", Offset = "0x3258660", VA = "0x183259460")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x32593A0", Offset = "0x32585A0", VA = "0x1832593A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3258620", Offset = "0x3257820", VA = "0x183258620")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x325AFE0", Offset = "0x325A1E0", VA = "0x18325AFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x325BDA0", Offset = "0x325AFA0", VA = "0x18325BDA0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x325BDE0", Offset = "0x325AFE0", VA = "0x18325BDE0", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x325BD60", Offset = "0x325AF60", VA = "0x18325BD60", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3257B90", Offset = "0x3256D90", VA = "0x183257B90", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x325B3A0", Offset = "0x325A5A0", VA = "0x18325B3A0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x325BF80", Offset = "0x325B180", VA = "0x18325BF80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x325B110", Offset = "0x325A310", VA = "0x18325B110")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x325B980", Offset = "0x325AB80", VA = "0x18325B980")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x325BE20", Offset = "0x325B020", VA = "0x18325BE20")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x325B6E0", Offset = "0x325A8E0", VA = "0x18325B6E0")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x325B5D0", Offset = "0x325A7D0", VA = "0x18325B5D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x325B440", Offset = "0x325A640", VA = "0x18325B440")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x325C0A0", Offset = "0x325B2A0", VA = "0x18325C0A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x499180", Offset = "0x498380", VA = "0x180499180")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600064C")]
				[Cpp2IlInjected.Address(RVA = "0x549960", Offset = "0x548B60", VA = "0x180549960")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public Vector3 IKPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600064D")]
				[Cpp2IlInjected.Address(RVA = "0x20C4400", Offset = "0x20C3600", VA = "0x1820C4400")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600064E")]
				[Cpp2IlInjected.Address(RVA = "0x32688F0", Offset = "0x3267AF0", VA = "0x1832688F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public bool initiated
			{
				[Cpp2IlInjected.Token(Token = "0x600064F")]
				[Cpp2IlInjected.Address(RVA = "0x5F2280", Offset = "0x5F1480", VA = "0x1805F2280")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000650")]
				[Cpp2IlInjected.Address(RVA = "0x5F22F0", Offset = "0x5F14F0", VA = "0x1805F22F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public float heightFromGround
			{
				[Cpp2IlInjected.Token(Token = "0x6000651")]
				[Cpp2IlInjected.Address(RVA = "0xAFA600", Offset = "0xAF9800", VA = "0x180AFA600")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000652")]
				[Cpp2IlInjected.Address(RVA = "0xAFA420", Offset = "0xAF9620", VA = "0x180AFA420")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public Vector3 velocity
			{
				[Cpp2IlInjected.Token(Token = "0x6000653")]
				[Cpp2IlInjected.Address(RVA = "0xBEE8D0", Offset = "0xBEDAD0", VA = "0x180BEE8D0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000654")]
				[Cpp2IlInjected.Address(RVA = "0xD04BD0", Offset = "0xD03DD0", VA = "0x180D04BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public Transform transform
			{
				[Cpp2IlInjected.Token(Token = "0x6000655")]
				[Cpp2IlInjected.Address(RVA = "0x4BFA20", Offset = "0x4BEC20", VA = "0x1804BFA20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000656")]
				[Cpp2IlInjected.Address(RVA = "0x52F620", Offset = "0x52E820", VA = "0x18052F620")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public float IKOffset
			{
				[Cpp2IlInjected.Token(Token = "0x6000657")]
				[Cpp2IlInjected.Address(RVA = "0xAFC200", Offset = "0xAFB400", VA = "0x180AFC200")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000658")]
				[Cpp2IlInjected.Address(RVA = "0x1B691C0", Offset = "0x1B683C0", VA = "0x181B691C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public RaycastHit heelHit
			{
				[Cpp2IlInjected.Token(Token = "0x6000659")]
				[Cpp2IlInjected.Address(RVA = "0x326B9F0", Offset = "0x326ABF0", VA = "0x18326B9F0")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Cpp2IlInjected.Token(Token = "0x600065A")]
				[Cpp2IlInjected.Address(RVA = "0x326BCA0", Offset = "0x326AEA0", VA = "0x18326BCA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public RaycastHit capsuleHit
			{
				[Cpp2IlInjected.Token(Token = "0x600065B")]
				[Cpp2IlInjected.Address(RVA = "0x326B9C0", Offset = "0x326ABC0", VA = "0x18326B9C0")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Cpp2IlInjected.Token(Token = "0x600065C")]
				[Cpp2IlInjected.Address(RVA = "0x326BC70", Offset = "0x326AE70", VA = "0x18326BC70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public RaycastHit GetHitPoint
			{
				[Cpp2IlInjected.Token(Token = "0x600065D")]
				[Cpp2IlInjected.Address(RVA = "0x326B940", Offset = "0x326AB40", VA = "0x18326B940")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public float stepHeightFromGround
			{
				[Cpp2IlInjected.Token(Token = "0x6000663")]
				[Cpp2IlInjected.Address(RVA = "0x326BBD0", Offset = "0x326ADD0", VA = "0x18326BBD0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			private float rootYOffset
			{
				[Cpp2IlInjected.Token(Token = "0x600066C")]
				[Cpp2IlInjected.Address(RVA = "0x326BA20", Offset = "0x326AC20", VA = "0x18326BA20")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x326B480", Offset = "0x326A680", VA = "0x18326B480")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x3269C80", Offset = "0x3268E80", VA = "0x183269C80")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x3269DB0", Offset = "0x3268FB0", VA = "0x183269DB0")]
			public void OnEnable()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x326B050", Offset = "0x326A250", VA = "0x18326B050")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x3269E10", Offset = "0x3269010", VA = "0x183269E10")]
			public void Process()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0x3268B50", Offset = "0x3267D50", VA = "0x183268B50")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x3269590", Offset = "0x3268790", VA = "0x183269590")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Cpp2IlInjected.Token(Token = "0x6000666")]
			[Cpp2IlInjected.Address(RVA = "0x326B320", Offset = "0x326A520", VA = "0x18326B320")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0x326B770", Offset = "0x326A970", VA = "0x18326B770")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0x326B4A0", Offset = "0x326A6A0", VA = "0x18326B4A0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x32693B0", Offset = "0x32685B0", VA = "0x1832693B0")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x326B120", Offset = "0x326A320", VA = "0x18326B120")]
			private void RotateFoot()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x3269B50", Offset = "0x3268D50", VA = "0x183269B50")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x326B890", Offset = "0x326AA90", VA = "0x18326B890")]
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
				[Cpp2IlInjected.Address(RVA = "0x1065840", Offset = "0x1064A40", VA = "0x181065840")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600066F")]
				[Cpp2IlInjected.Address(RVA = "0x1065820", Offset = "0x1064A20", VA = "0x181065820")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public float heightOffset
			{
				[Cpp2IlInjected.Token(Token = "0x6000670")]
				[Cpp2IlInjected.Address(RVA = "0xB12C50", Offset = "0xB11E50", VA = "0x180B12C50")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000671")]
				[Cpp2IlInjected.Address(RVA = "0xA3FB20", Offset = "0xA3ED20", VA = "0x180A3FB20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x326C250", Offset = "0x326B450", VA = "0x18326C250")]
			public void Initiate(Grounding grounding)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(RVA = "0x326C680", Offset = "0x326B880", VA = "0x18326C680")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x326C2C0", Offset = "0x326B4C0", VA = "0x18326C2C0")]
			public void OnEnable()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0x326C330", Offset = "0x326B530", VA = "0x18326C330")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x480A00", Offset = "0x47FC00", VA = "0x180480A00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4E5C40", Offset = "0x4E4E40", VA = "0x1804E5C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Pelvis pelvis
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x475320", Offset = "0x474520", VA = "0x180475320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4825E0", Offset = "0x4817E0", VA = "0x1804825E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool isGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x4991A0", Offset = "0x4983A0", VA = "0x1804991A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x547C40", Offset = "0x546E40", VA = "0x180547C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Transform root
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x4928B0", Offset = "0x491AB0", VA = "0x1804928B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x475330", Offset = "0x474530", VA = "0x180475330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public RaycastHit rootHit
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x325E2A0", Offset = "0x325D4A0", VA = "0x18325E2A0")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x325E440", Offset = "0x325D640", VA = "0x18325E440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool rootGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x325E240", Offset = "0x325D440", VA = "0x18325E240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x325E2D0", Offset = "0x325D4D0", VA = "0x18325E2D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private bool useRootRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x325E370", Offset = "0x325D570", VA = "0x18325E370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x325D000", Offset = "0x325C200", VA = "0x18325D000")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x325DC20", Offset = "0x325CE20", VA = "0x18325DC20")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x325D770", Offset = "0x325C970", VA = "0x18325D770")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x325DF10", Offset = "0x325D110", VA = "0x18325DF10")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x325CCB0", Offset = "0x325BEB0", VA = "0x18325CCB0")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x325DD10", Offset = "0x325CF10", VA = "0x18325DD10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x325DCF0", Offset = "0x325CEF0", VA = "0x18325DCF0")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x325D600", Offset = "0x325C800", VA = "0x18325D600")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x325CA10", Offset = "0x325BC10", VA = "0x18325CA10")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x325CB50", Offset = "0x325BD50", VA = "0x18325CB50")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x325E1E0", Offset = "0x325D3E0", VA = "0x18325E1E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4BB00", Offset = "0x2A4AD00", VA = "0x182A4BB00", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BA80", Offset = "0x2A4AC80", VA = "0x182A4BA80", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BAC0", Offset = "0x2A4ACC0", VA = "0x182A4BAC0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BB40", Offset = "0x2A4AD40", VA = "0x182A4BB40")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BA40", Offset = "0x2A4AC40", VA = "0x182A4BA40")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x46FF90", Offset = "0x46F190", VA = "0x18046FF90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BB80", Offset = "0x2A4AD80", VA = "0x182A4BB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4BFB0", Offset = "0x2A4B1B0", VA = "0x182A4BFB0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BF70", Offset = "0x2A4B170", VA = "0x182A4BF70", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BFF0", Offset = "0x2A4B1F0", VA = "0x182A4BFF0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BF30", Offset = "0x2A4B130", VA = "0x182A4BF30")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x46FF90", Offset = "0x46F190", VA = "0x18046FF90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C030", Offset = "0x2A4B230", VA = "0x182A4C030")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4E9D0", Offset = "0x2A4DBD0", VA = "0x182A4E9D0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E990", Offset = "0x2A4DB90", VA = "0x182A4E990", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EA10", Offset = "0x2A4DC10", VA = "0x182A4EA10")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E950", Offset = "0x2A4DB50", VA = "0x182A4E950")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x46FF90", Offset = "0x46F190", VA = "0x18046FF90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EA50", Offset = "0x2A4DC50", VA = "0x182A4EA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A52650", Offset = "0x2A51850", VA = "0x182A52650", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x2A52610", Offset = "0x2A51810", VA = "0x182A52610", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2A52690", Offset = "0x2A51890", VA = "0x182A52690")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2A525D0", Offset = "0x2A517D0", VA = "0x182A525D0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x46FF90", Offset = "0x46F190", VA = "0x18046FF90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2A526D0", Offset = "0x2A518D0", VA = "0x182A526D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A524F0", Offset = "0x2A516F0", VA = "0x182A524F0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2A524B0", Offset = "0x2A516B0", VA = "0x182A524B0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2A52530", Offset = "0x2A51730", VA = "0x182A52530")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2A52470", Offset = "0x2A51670", VA = "0x182A52470")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x46FF90", Offset = "0x46F190", VA = "0x18046FF90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2A52570", Offset = "0x2A51770", VA = "0x182A52570")]
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
		[Cpp2IlInjected.Address(RVA = "0x32535E0", Offset = "0x32527E0", VA = "0x1832535E0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3253560", Offset = "0x3252760", VA = "0x183253560", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x32535A0", Offset = "0x32527A0", VA = "0x1832535A0")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3253520", Offset = "0x3252720", VA = "0x183253520")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3253CD0", Offset = "0x3252ED0", VA = "0x183253CD0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3253400", Offset = "0x3252600", VA = "0x183253400")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3253CA0", Offset = "0x3252EA0", VA = "0x183253CA0")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x482470", Offset = "0x481670", VA = "0x180482470", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3253620", Offset = "0x3252820", VA = "0x183253620")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3253850", Offset = "0x3252A50", VA = "0x183253850")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3253C70", Offset = "0x3252E70", VA = "0x183253C70")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3253440", Offset = "0x3252640", VA = "0x183253440")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3253D10", Offset = "0x3252F10", VA = "0x183253D10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3268A70", Offset = "0x3267C70", VA = "0x183268A70", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3268A00", Offset = "0x3267C00", VA = "0x183268A00", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3268990", Offset = "0x3267B90", VA = "0x183268990", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0xC1CD80", Offset = "0xC1BF80", VA = "0x180C1CD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x3263EA0", Offset = "0x32630A0", VA = "0x183263EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3263DF0", Offset = "0x3262FF0", VA = "0x183263DF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3263E70", Offset = "0x3263070", VA = "0x183263E70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3263CA0", Offset = "0x3262EA0", VA = "0x183263CA0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3263CD0", Offset = "0x3262ED0", VA = "0x183263CD0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3263BF0", Offset = "0x3262DF0", VA = "0x183263BF0")]
		private void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F00F50", Offset = "0x2F00150", VA = "0x182F00F50", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2F00F10", Offset = "0x2F00110", VA = "0x182F00F10", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2F00F90", Offset = "0x2F00190", VA = "0x182F00F90")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2F00ED0", Offset = "0x2F000D0", VA = "0x182F00ED0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x46FF90", Offset = "0x46F190", VA = "0x18046FF90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2F00FD0", Offset = "0x2F001D0", VA = "0x182F00FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F010B0", Offset = "0x2F002B0", VA = "0x182F010B0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2F01070", Offset = "0x2F00270", VA = "0x182F01070", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2F010F0", Offset = "0x2F002F0", VA = "0x182F010F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2F01030", Offset = "0x2F00230", VA = "0x182F01030")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x46FF90", Offset = "0x46F190", VA = "0x18046FF90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2F01130", Offset = "0x2F00330", VA = "0x182F01130")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F025B0", Offset = "0x2F017B0", VA = "0x182F025B0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2F02570", Offset = "0x2F01770", VA = "0x182F02570", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2F025F0", Offset = "0x2F017F0", VA = "0x182F025F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2F02530", Offset = "0x2F01730", VA = "0x182F02530")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x46FF90", Offset = "0x46F190", VA = "0x18046FF90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2F02630", Offset = "0x2F01830", VA = "0x182F02630")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0FE90", Offset = "0x2F0F090", VA = "0x182F0FE90", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2F0FE50", Offset = "0x2F0F050", VA = "0x182F0FE50", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2F0FED0", Offset = "0x2F0F0D0", VA = "0x182F0FED0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2F0FE10", Offset = "0x2F0F010", VA = "0x182F0FE10")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x46FF90", Offset = "0x46F190", VA = "0x18046FF90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2F0FF10", Offset = "0x2F0F110", VA = "0x182F0FF10")]
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
				[Cpp2IlInjected.Address(RVA = "0x2F09D40", Offset = "0x2F08F40", VA = "0x182F09D40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool isEmpty
			{
				[Cpp2IlInjected.Token(Token = "0x6000679")]
				[Cpp2IlInjected.Address(RVA = "0x2F09830", Offset = "0x2F08A30", VA = "0x182F09830")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0x2F090C0", Offset = "0x2F082C0", VA = "0x182F090C0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x2F08D00", Offset = "0x2F07F00", VA = "0x182F08D00")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F18130", Offset = "0x2F17330", VA = "0x182F18130", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2F180B0", Offset = "0x2F172B0", VA = "0x182F180B0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2F180F0", Offset = "0x2F172F0", VA = "0x182F180F0")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2F17FD0", Offset = "0x2F171D0", VA = "0x182F17FD0")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2F18000", Offset = "0x2F17200", VA = "0x182F18000")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x482470", Offset = "0x481670", VA = "0x180482470", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2F18030", Offset = "0x2F17230", VA = "0x182F18030", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2F18170", Offset = "0x2F17370", VA = "0x182F18170", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2F182E0", Offset = "0x2F174E0", VA = "0x182F182E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A52070", Offset = "0x2A51270", VA = "0x182A52070")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2A52040", Offset = "0x2A51240", VA = "0x182A52040")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2A52130", Offset = "0x2A51330", VA = "0x182A52130")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2A52280", Offset = "0x2A51480", VA = "0x182A52280")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2A51BC0", Offset = "0x2A50DC0", VA = "0x182A51BC0")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2A52410", Offset = "0x2A51610", VA = "0x182A52410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A52730", Offset = "0x2A51930", VA = "0x182A52730")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2A52ED0", Offset = "0x2A520D0", VA = "0x182A52ED0")]
		private void OnPostFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2A52DE0", Offset = "0x2A51FE0", VA = "0x182A52DE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A4C1A0", Offset = "0x2A4B3A0", VA = "0x182A4C1A0")]
			public BendBone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x2A4C110", Offset = "0x2A4B310", VA = "0x182A4C110")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067E")]
			[Cpp2IlInjected.Address(RVA = "0x2A4C0D0", Offset = "0x2A4B2D0", VA = "0x182A4C0D0")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0x2A4C090", Offset = "0x2A4B290", VA = "0x182A4C090")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A56D80", Offset = "0x2A55F80", VA = "0x182A56D80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2A55C10", Offset = "0x2A54E10", VA = "0x182A55C10")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2A54B20", Offset = "0x2A53D20", VA = "0x182A54B20")]
		private void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2A55300", Offset = "0x2A54500", VA = "0x182A55300")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2A56970", Offset = "0x2A55B70", VA = "0x182A56970")]
		private void SpineBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2A530E0", Offset = "0x2A522E0", VA = "0x182A530E0")]
		private void CCDPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2A53920", Offset = "0x2A52B20", VA = "0x182A53920")]
		private void Iterate(int iteration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2A550C0", Offset = "0x2A542C0", VA = "0x182A550C0")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2A535B0", Offset = "0x2A527B0", VA = "0x182A535B0")]
		private void ChestDirection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2A56290", Offset = "0x2A55490", VA = "0x182A56290")]
		private void PostStretching()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2A54690", Offset = "0x2A53890", VA = "0x182A54690")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2A56770", Offset = "0x2A55970", VA = "0x182A56770")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2A54810", Offset = "0x2A53A10", VA = "0x182A54810")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2A57150", Offset = "0x2A56350", VA = "0x182A57150")]
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
				[Cpp2IlInjected.Address(RVA = "0xB7BD80", Offset = "0xB7AF80", VA = "0x180B7BD80")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000681")]
				[Cpp2IlInjected.Address(RVA = "0xD2DBE0", Offset = "0xD2CDE0", VA = "0x180D2DBE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool isRigid
			{
				[Cpp2IlInjected.Token(Token = "0x6000682")]
				[Cpp2IlInjected.Address(RVA = "0xA8F1D0", Offset = "0xA8E3D0", VA = "0x180A8F1D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000683")]
				[Cpp2IlInjected.Address(RVA = "0x10B56C0", Offset = "0x10B48C0", VA = "0x1810B56C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x3251330", Offset = "0x3250530", VA = "0x183251330")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x3250BE0", Offset = "0x324FDE0", VA = "0x183250BE0")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x3250C40", Offset = "0x324FE40", VA = "0x183250C40")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0x3250EE0", Offset = "0x32500E0", VA = "0x183250EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A5B0B0", Offset = "0x2A5A2B0", VA = "0x182A5B0B0")]
		public FBIKChain()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2A5AEC0", Offset = "0x2A5A0C0", VA = "0x182A5AEC0")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2A59840", Offset = "0x2A58A40", VA = "0x182A59840")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2A58250", Offset = "0x2A57450", VA = "0x182A58250")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2A58520", Offset = "0x2A57720", VA = "0x182A58520")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2A58340", Offset = "0x2A57540", VA = "0x182A58340")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2A590C0", Offset = "0x2A582C0", VA = "0x182A590C0")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2A57660", Offset = "0x2A56860", VA = "0x182A57660")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2A58BA0", Offset = "0x2A57DA0", VA = "0x182A58BA0")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2A58620", Offset = "0x2A57820", VA = "0x182A58620")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2A5A1B0", Offset = "0x2A593B0", VA = "0x182A5A1B0")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2A5A650", Offset = "0x2A59850", VA = "0x182A5A650")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2A5ACF0", Offset = "0x2A59EF0", VA = "0x182A5ACF0")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2A59A00", Offset = "0x2A58C00", VA = "0x182A59A00")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2A59DF0", Offset = "0x2A58FF0", VA = "0x182A59DF0")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2A57FF0", Offset = "0x2A571F0", VA = "0x182A57FF0")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x2A59970", Offset = "0x2A58B70", VA = "0x182A59970")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2A59F30", Offset = "0x2A59130", VA = "0x182A59F30")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2A57D90", Offset = "0x2A56F90", VA = "0x182A57D90")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2A572D0", Offset = "0x2A564D0", VA = "0x182A572D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7167D0", Offset = "0x7159D0", VA = "0x1807167D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x9EA8E0", Offset = "0x9E9AE0", VA = "0x1809EA8E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3260E50", Offset = "0x3260050", VA = "0x183260E50")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3261B50", Offset = "0x3260D50", VA = "0x183261B50")]
		public IKConstraintBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3261BD0", Offset = "0x3260DD0", VA = "0x183261BD0")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2FF0530", Offset = "0x2FEF730", VA = "0x182FF0530")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x32608F0", Offset = "0x325FAF0", VA = "0x1832608F0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x32618F0", Offset = "0x3260AF0", VA = "0x1832618F0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3261070", Offset = "0x3260270", VA = "0x183261070")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3260190", Offset = "0x325F390", VA = "0x183260190")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3261790", Offset = "0x3260990", VA = "0x183261790")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3261630", Offset = "0x3260830", VA = "0x183261630")]
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
			[Cpp2IlInjected.Address(RVA = "0x547030", Offset = "0x546230", VA = "0x180547030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x5471B0", Offset = "0x5463B0", VA = "0x1805471B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3261C80", Offset = "0x3260E80", VA = "0x183261C80")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x32631A0", Offset = "0x32623A0", VA = "0x1832631A0")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3263AA0", Offset = "0x3262CA0", VA = "0x183263AA0")]
		public IKEffector()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3263930", Offset = "0x3262B30", VA = "0x183263930")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3262640", Offset = "0x3261840", VA = "0x183262640")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3262300", Offset = "0x3261500", VA = "0x183262300")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3263290", Offset = "0x3262490", VA = "0x183263290")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3263430", Offset = "0x3262630", VA = "0x183263430")]
		public void SetToTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x32629C0", Offset = "0x3261BC0", VA = "0x1832629C0")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3262950", Offset = "0x3261B50", VA = "0x183262950")]
		public void OnPostWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3261CF0", Offset = "0x3260EF0", VA = "0x183261CF0")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x32634E0", Offset = "0x32626E0", VA = "0x1832634E0")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3261F50", Offset = "0x3261150", VA = "0x183261F50")]
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
				[Cpp2IlInjected.Address(RVA = "0x3250B10", Offset = "0x324FD10", VA = "0x183250B10")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public bool isNodeBone
			{
				[Cpp2IlInjected.Token(Token = "0x600068C")]
				[Cpp2IlInjected.Address(RVA = "0x3250850", Offset = "0x324FA50", VA = "0x183250850")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60006A0")]
				[Cpp2IlInjected.Address(RVA = "0x3250860", Offset = "0x324FA60", VA = "0x183250860")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0x324F6B0", Offset = "0x324E8B0", VA = "0x18324F6B0")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x32500D0", Offset = "0x324F2D0", VA = "0x1832500D0")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x324F270", Offset = "0x324E470", VA = "0x18324F270")]
			public void FixTransform(bool position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0x324FBE0", Offset = "0x324EDE0", VA = "0x18324FBE0")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x324FCD0", Offset = "0x324EED0", VA = "0x18324FCD0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x324FCE0", Offset = "0x324EEE0", VA = "0x18324FCE0")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x324FE90", Offset = "0x324F090", VA = "0x18324FE90")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x324FFB0", Offset = "0x324F1B0", VA = "0x18324FFB0")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x3250640", Offset = "0x324F840", VA = "0x183250640")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x324FBA0", Offset = "0x324EDA0", VA = "0x18324FBA0")]
			public void SetIKPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x324F6F0", Offset = "0x324E8F0", VA = "0x18324F6F0")]
			public void MaintainRotation()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0x3250090", Offset = "0x324F290", VA = "0x183250090")]
			public void SetToIKPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x324F0F0", Offset = "0x324E2F0", VA = "0x18324F0F0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000697")]
			[Cpp2IlInjected.Address(RVA = "0x324F2D0", Offset = "0x324E4D0", VA = "0x18324F2D0")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0x324F730", Offset = "0x324E930", VA = "0x18324F730")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0x324FA30", Offset = "0x324EC30", VA = "0x18324FA30")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0x3250130", Offset = "0x324F330", VA = "0x183250130")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x32501C0", Offset = "0x324F3C0", VA = "0x1832501C0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0x3250420", Offset = "0x324F620", VA = "0x183250420")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x324F920", Offset = "0x324EB20", VA = "0x18324F920")]
			public void RotateToMaintain(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0x324F780", Offset = "0x324E980", VA = "0x18324F780")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069F")]
			[Cpp2IlInjected.Address(RVA = "0x324F450", Offset = "0x324E650", VA = "0x18324F450")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0x3250820", Offset = "0x324FA20", VA = "0x183250820")]
			public BoneMap()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x46FF60", Offset = "0x46F160", VA = "0x18046FF60", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3267D10", Offset = "0x3266F10", VA = "0x183267D10")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3267E20", Offset = "0x3267020", VA = "0x183267E20")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3264030", Offset = "0x3263230", VA = "0x183264030", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3264230", Offset = "0x3263430", VA = "0x183264230")]
		public IKMappingBone()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3264190", Offset = "0x3263390", VA = "0x183264190")]
		public IKMappingBone(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3264100", Offset = "0x3263300", VA = "0x183264100")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3263F30", Offset = "0x3263130", VA = "0x183263F30")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3263F70", Offset = "0x3263170", VA = "0x183263F70", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x32640C0", Offset = "0x32632C0", VA = "0x1832640C0")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3264160", Offset = "0x3263360", VA = "0x183264160")]
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
		[Cpp2IlInjected.Address(RVA = "0x3264820", Offset = "0x3263A20", VA = "0x183264820", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3264410", Offset = "0x3263610", VA = "0x183264410")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3264A40", Offset = "0x3263C40", VA = "0x183264A40")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x32655C0", Offset = "0x32647C0", VA = "0x1832655C0")]
		public IKMappingLimb()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3265420", Offset = "0x3264620", VA = "0x183265420")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3264A20", Offset = "0x3263C20", VA = "0x183264A20")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3264E10", Offset = "0x3264010", VA = "0x183264E10")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x32642C0", Offset = "0x32634C0", VA = "0x1832642C0")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x32644D0", Offset = "0x32636D0", VA = "0x1832644D0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x32648C0", Offset = "0x3263AC0", VA = "0x1832648C0")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3264FD0", Offset = "0x32641D0", VA = "0x183264FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3266630", Offset = "0x3265830", VA = "0x183266630", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3267B90", Offset = "0x3266D90", VA = "0x183267B90")]
		public IKMappingSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x32679D0", Offset = "0x3266BD0", VA = "0x1832679D0")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3267360", Offset = "0x3266560", VA = "0x183267360")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3267380", Offset = "0x3266580", VA = "0x183267380")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3265970", Offset = "0x3264B70", VA = "0x183265970")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3265C80", Offset = "0x3264E80", VA = "0x183265C80", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3267440", Offset = "0x3266640", VA = "0x183267440")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3266EE0", Offset = "0x32660E0", VA = "0x183266EE0")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3267470", Offset = "0x3266670", VA = "0x183267470")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3265A10", Offset = "0x3264C10", VA = "0x183265A10")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x3265720", Offset = "0x3264920", VA = "0x183265720")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3266960", Offset = "0x3265B60", VA = "0x183266960")]
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
			[Cpp2IlInjected.Address(RVA = "0x324E9D0", Offset = "0x324DBD0", VA = "0x18324E9D0")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x324E850", Offset = "0x324DA50", VA = "0x18324E850")]
			public void FixTransform()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0x324EAD0", Offset = "0x324DCD0", VA = "0x18324EAD0")]
			public void UpdateSolverPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0x324EA30", Offset = "0x324DC30", VA = "0x18324EA30")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0x324EB10", Offset = "0x324DD10", VA = "0x18324EB10")]
			public void UpdateSolverState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x324EA70", Offset = "0x324DC70", VA = "0x18324EA70")]
			public void UpdateSolverLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0x324E750", Offset = "0x324D950", VA = "0x18324E750")]
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
				[Cpp2IlInjected.Address(RVA = "0x322D8B0", Offset = "0x322CAB0", VA = "0x18322D8B0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60006AA")]
				[Cpp2IlInjected.Address(RVA = "0x322D980", Offset = "0x322CB80", VA = "0x18322D980")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x322D300", Offset = "0x322C500", VA = "0x18322D300")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0x322CD30", Offset = "0x322BF30", VA = "0x18322CD30")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0x322D090", Offset = "0x322C290", VA = "0x18322D090")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x322CCF0", Offset = "0x322BEF0", VA = "0x18322CCF0")]
			public void SetToSolverPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x322D7C0", Offset = "0x322C9C0", VA = "0x18322D7C0")]
			public Bone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0x322D6C0", Offset = "0x322C8C0", VA = "0x18322D6C0")]
			public Bone(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0x322D5B0", Offset = "0x322C7B0", VA = "0x18322D5B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x324E750", Offset = "0x324D950", VA = "0x18324E750")]
			public Node()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x324E6D0", Offset = "0x324D8D0", VA = "0x18324E6D0")]
			public Node(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0x324E7C0", Offset = "0x324D9C0", VA = "0x18324E7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8F70", Offset = "0xCE8170", VA = "0x180CE8F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xCE8F80", Offset = "0xCE8180", VA = "0x180CE8F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x32682B0", Offset = "0x32674B0", VA = "0x1832682B0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool IsValid(ref string message);

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3268160", Offset = "0x3267360", VA = "0x183268160")]
		public void Initiate(Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3268900", Offset = "0x3267B00", VA = "0x183268900")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x20C4400", Offset = "0x20C3600", VA = "0x1820C4400", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x32688F0", Offset = "0x3267AF0", VA = "0x1832688F0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xB7BD90", Offset = "0xB7AF90", VA = "0x180B7BD90")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3268880", Offset = "0x3267A80", VA = "0x183268880")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x492970", Offset = "0x491B70", VA = "0x180492970")]
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
		[Cpp2IlInjected.Address(RVA = "0x3268320", Offset = "0x3267520", VA = "0x183268320")]
		protected void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x3267F60", Offset = "0x3267160", VA = "0x183267F60")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x32680B0", Offset = "0x32672B0", VA = "0x1832680B0")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x3268340", Offset = "0x3267540", VA = "0x183268340")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x3268970", Offset = "0x3267B70", VA = "0x183268970")]
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
			[Cpp2IlInjected.Address(RVA = "0x322F3F0", Offset = "0x322E5F0", VA = "0x18322F3F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 transformPoleAxis
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x322F4D0", Offset = "0x322E6D0", VA = "0x18322F4D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override int minBones
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x5153E0", Offset = "0x5145E0", VA = "0x1805153E0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override Vector3 localDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x322F320", Offset = "0x322E520", VA = "0x18322F320", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x322D9F0", Offset = "0x322CBF0", VA = "0x18322D9F0")]
		public float GetAngle()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x322E030", Offset = "0x322D230", VA = "0x18322E030", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x322E3A0", Offset = "0x322D5A0", VA = "0x18322E3A0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x322F100", Offset = "0x322E300", VA = "0x18322F100")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x322DB20", Offset = "0x322CD20", VA = "0x18322DB20")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x322EAB0", Offset = "0x322DCB0", VA = "0x18322EAB0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x322F240", Offset = "0x322E440", VA = "0x18322F240")]
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
		[Cpp2IlInjected.Address(RVA = "0x322FA30", Offset = "0x322EC30", VA = "0x18322FA30", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x3230400", Offset = "0x322F600", VA = "0x183230400")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x322F830", Offset = "0x322EA30", VA = "0x18322F830", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x322F620", Offset = "0x322E820", VA = "0x18322F620", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x3230510", Offset = "0x322F710", VA = "0x183230510", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x322F5B0", Offset = "0x322E7B0", VA = "0x18322F5B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x322FDB0", Offset = "0x322EFB0", VA = "0x18322FDB0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x322FE30", Offset = "0x322F030", VA = "0x18322FE30", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x3230480", Offset = "0x322F680", VA = "0x183230480")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x322FED0", Offset = "0x322F0D0", VA = "0x18322FED0")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x3230690", Offset = "0x322F890", VA = "0x183230690")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x3230920", Offset = "0x322FB20", VA = "0x183230920")]
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
		[Cpp2IlInjected.Address(RVA = "0x3230C20", Offset = "0x322FE20", VA = "0x183230C20")]
		public void FadeOutBoneWeights()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x3230D00", Offset = "0x322FF00", VA = "0x183230D00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x3230D90", Offset = "0x322FF90", VA = "0x183230D90", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x3231170", Offset = "0x3230370", VA = "0x183231170")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x3231B50", Offset = "0x3230D50", VA = "0x183231B50")]
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
			[Cpp2IlInjected.Address(RVA = "0x46FE40", Offset = "0x46F040", VA = "0x18046FE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x32367D0", Offset = "0x32359D0", VA = "0x1832367D0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x3236710", Offset = "0x3235910", VA = "0x183236710")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x3234600", Offset = "0x3233800", VA = "0x183234600", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x3235720", Offset = "0x3234920", VA = "0x183235720", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x3236350", Offset = "0x3235550", VA = "0x183236350", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x3236870", Offset = "0x3235A70", VA = "0x183236870")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x3235CC0", Offset = "0x3234EC0", VA = "0x183235CC0")]
		private void OnPreSolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x3235B60", Offset = "0x3234D60", VA = "0x183235B60")]
		private void OnPostSolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x32369D0", Offset = "0x3235BD0", VA = "0x1832369D0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x3234220", Offset = "0x3233420", VA = "0x183234220")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x3236D40", Offset = "0x3235F40", VA = "0x183236D40")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x3236FA0", Offset = "0x32361A0", VA = "0x183236FA0")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x3236E80", Offset = "0x3236080", VA = "0x183236E80")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x3236A80", Offset = "0x3235C80", VA = "0x183236A80")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x3234A10", Offset = "0x3233C10", VA = "0x183234A10")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x3234870", Offset = "0x3233A70", VA = "0x183234870")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x32346B0", Offset = "0x32338B0", VA = "0x1832346B0")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x3234BA0", Offset = "0x3233DA0", VA = "0x183234BA0")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x32341E0", Offset = "0x32333E0", VA = "0x1832341E0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x3233F50", Offset = "0x3233150", VA = "0x183233F50")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x3233750", Offset = "0x3232950", VA = "0x183233750")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x3235550", Offset = "0x3234750", VA = "0x183235550")]
		private void MapToSolverPositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x3235440", Offset = "0x3234640", VA = "0x183235440")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x32370E0", Offset = "0x32362E0", VA = "0x1832370E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3232600", Offset = "0x3231800", VA = "0x183232600", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x3233630", Offset = "0x3232830", VA = "0x183233630", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x3231D00", Offset = "0x3230F00", VA = "0x183231D00", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x3233170", Offset = "0x3232370", VA = "0x183233170", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x3232520", Offset = "0x3231720", VA = "0x183232520")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x3233360", Offset = "0x3232560", VA = "0x183233360", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x3232320", Offset = "0x3231520", VA = "0x183232320", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x3232270", Offset = "0x3231470", VA = "0x183232270", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x3231BA0", Offset = "0x3230DA0", VA = "0x183231BA0")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x3231DD0", Offset = "0x3230FD0", VA = "0x183231DD0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x3233700", Offset = "0x3232900", VA = "0x183233700")]
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
		[Cpp2IlInjected.Address(RVA = "0x323C160", Offset = "0x323B360", VA = "0x18323C160")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x323C110", Offset = "0x323B310", VA = "0x18323C110")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x323BFA0", Offset = "0x323B1A0", VA = "0x18323BFA0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x323C280", Offset = "0x323B480", VA = "0x18323C280")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x323BF10", Offset = "0x323B110", VA = "0x18323BF10")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x323C4B0", Offset = "0x323B6B0", VA = "0x18323C4B0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x323C2F0", Offset = "0x323B4F0", VA = "0x18323C2F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x323C680", Offset = "0x323B880", VA = "0x18323C680", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x323D4F0", Offset = "0x323C6F0", VA = "0x18323D4F0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x323BDE0", Offset = "0x323AFE0", VA = "0x18323BDE0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x323C8F0", Offset = "0x323BAF0", VA = "0x18323C8F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x323CAC0", Offset = "0x323BCC0", VA = "0x18323CAC0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x323CCF0", Offset = "0x323BEF0", VA = "0x18323CCF0", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x323D050", Offset = "0x323C250", VA = "0x18323D050", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x323BD90", Offset = "0x323AF90", VA = "0x18323BD90", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x323D600", Offset = "0x323C800", VA = "0x18323D600", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x323D730", Offset = "0x323C930", VA = "0x18323D730")]
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
			[Cpp2IlInjected.Address(RVA = "0x323B910", Offset = "0x323AB10", VA = "0x18323B910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public IKEffector leftShoulderEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x323BAD0", Offset = "0x323ACD0", VA = "0x18323BAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public IKEffector rightShoulderEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x323BCF0", Offset = "0x323AEF0", VA = "0x18323BCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public IKEffector leftThighEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x323BB10", Offset = "0x323AD10", VA = "0x18323BB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public IKEffector rightThighEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x323BD30", Offset = "0x323AF30", VA = "0x18323BD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public IKEffector leftHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x323BA10", Offset = "0x323AC10", VA = "0x18323BA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public IKEffector rightHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x323BC30", Offset = "0x323AE30", VA = "0x18323BC30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public IKEffector leftFootEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x323B9D0", Offset = "0x323ABD0", VA = "0x18323B9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public IKEffector rightFootEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x323BBF0", Offset = "0x323ADF0", VA = "0x18323BBF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public FBIKChain leftArmChain
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x323B950", Offset = "0x323AB50", VA = "0x18323B950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public FBIKChain rightArmChain
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x323BB70", Offset = "0x323AD70", VA = "0x18323BB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public FBIKChain leftLegChain
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x323BA50", Offset = "0x323AC50", VA = "0x18323BA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public FBIKChain rightLegChain
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x323BC70", Offset = "0x323AE70", VA = "0x18323BC70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public IKMappingLimb leftArmMapping
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x323B990", Offset = "0x323AB90", VA = "0x18323B990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public IKMappingLimb rightArmMapping
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x323BBB0", Offset = "0x323ADB0", VA = "0x18323BBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public IKMappingLimb leftLegMapping
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x323BA90", Offset = "0x323AC90", VA = "0x18323BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public IKMappingLimb rightLegMapping
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x323BCB0", Offset = "0x323AEB0", VA = "0x18323BCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public IKMappingBone headMapping
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x32388F0", Offset = "0x3237AF0", VA = "0x1832388F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 pullBodyOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x323BB50", Offset = "0x323AD50", VA = "0x18323BB50")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x323BD70", Offset = "0x323AF70", VA = "0x18323BD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x32395A0", Offset = "0x32387A0", VA = "0x1832395A0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x3239610", Offset = "0x3238810", VA = "0x183239610")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x3238270", Offset = "0x3237470", VA = "0x183238270")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3238080", Offset = "0x3237280", VA = "0x183238080")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x3238340", Offset = "0x3237540", VA = "0x183238340")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3238550", Offset = "0x3237750", VA = "0x183238550")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x32389F0", Offset = "0x3237BF0", VA = "0x1832389F0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3238AC0", Offset = "0x3237CC0", VA = "0x183238AC0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x4928B0", Offset = "0x491AB0", VA = "0x1804928B0")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x32388F0", Offset = "0x3237AF0", VA = "0x1832388F0")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x3237C60", Offset = "0x3236E60", VA = "0x183237C60")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3238D60", Offset = "0x3237F60", VA = "0x183238D60", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x3239A40", Offset = "0x3238C40", VA = "0x183239A40")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x32377A0", Offset = "0x32369A0", VA = "0x1832377A0")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x32399D0", Offset = "0x3238BD0", VA = "0x1832399D0")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x3239700", Offset = "0x3238900", VA = "0x183239700")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x3238930", Offset = "0x3237B30", VA = "0x183238930")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x3238CA0", Offset = "0x3237EA0", VA = "0x183238CA0")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x32376E0", Offset = "0x32368E0", VA = "0x1832376E0")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x3239190", Offset = "0x3238390", VA = "0x183239190", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x3238F30", Offset = "0x3238130", VA = "0x183238F30")]
		private void PullBody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x3237D30", Offset = "0x3236F30", VA = "0x183237D30")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x3238620", Offset = "0x3237820", VA = "0x183238620")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x3237180", Offset = "0x3236380", VA = "0x183237180", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x323B5F0", Offset = "0x323A7F0", VA = "0x18323B5F0", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x323B840", Offset = "0x323AA40", VA = "0x18323B840")]
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
			[Cpp2IlInjected.Address(RVA = "0x5361A0", Offset = "0x5353A0", VA = "0x1805361A0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected virtual bool boneLengthCanBeZero
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x46FF60", Offset = "0x46F160", VA = "0x18046FF60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected virtual bool allowCommonParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x46FE40", Offset = "0x46F040", VA = "0x18046FE40", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual Vector3 localDirection
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x323F280", Offset = "0x323E480", VA = "0x18323F280", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected float positionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x323F450", Offset = "0x323E650", VA = "0x18323F450")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x323EC90", Offset = "0x323DE90", VA = "0x18323EC90")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x323D7F0", Offset = "0x323C9F0", VA = "0x18323D7F0")]
		public void AddBone(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x323F1C0", Offset = "0x323E3C0", VA = "0x18323F1C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x323DAD0", Offset = "0x323CCD0", VA = "0x18323DAD0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x323E880", Offset = "0x323DA80", VA = "0x18323E880", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x4928B0", Offset = "0x491AB0", VA = "0x1804928B0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x323DB60", Offset = "0x323CD60", VA = "0x18323DB60", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x323E140", Offset = "0x323D340", VA = "0x18323E140")]
		protected void InitiateBones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x323DC80", Offset = "0x323CE80", VA = "0x18323DC80")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x323EE30", Offset = "0x323E030", VA = "0x18323EE30")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x3231B50", Offset = "0x3230D50", VA = "0x183231B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x323F940", Offset = "0x323EB40", VA = "0x18323F940", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x3230400", Offset = "0x322F600", VA = "0x183230400")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x323F740", Offset = "0x323E940", VA = "0x18323F740", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x323F530", Offset = "0x323E730", VA = "0x18323F530", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x3230510", Offset = "0x322F710", VA = "0x183230510", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x322F5B0", Offset = "0x322E7B0", VA = "0x18322F5B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x323FCC0", Offset = "0x323EEC0", VA = "0x18323FCC0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x323FD40", Offset = "0x323EF40", VA = "0x18323FD40", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x32403E0", Offset = "0x323F5E0", VA = "0x1832403E0")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x323FEC0", Offset = "0x323F0C0", VA = "0x18323FEC0")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x3240550", Offset = "0x323F750", VA = "0x183240550")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x32407E0", Offset = "0x323F9E0", VA = "0x1832407E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x322CC90", Offset = "0x322BE90", VA = "0x18322CC90")]
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
			[Cpp2IlInjected.Address(RVA = "0x32425B0", Offset = "0x32417B0", VA = "0x1832425B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x3241930", Offset = "0x3240B30", VA = "0x183241930")]
		public void MaintainRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x32418E0", Offset = "0x3240AE0", VA = "0x1832418E0")]
		public void MaintainBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x3241980", Offset = "0x3240B80", VA = "0x183241980", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x3241F00", Offset = "0x3241100", VA = "0x183241F00", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x3241D90", Offset = "0x3240F90", VA = "0x183241D90", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x3242540", Offset = "0x3241740", VA = "0x183242540")]
		public IKSolverLimb()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x32424C0", Offset = "0x32416C0", VA = "0x1832424C0")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x3242050", Offset = "0x3241250", VA = "0x183242050")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x3240AE0", Offset = "0x323FCE0", VA = "0x183240AE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x324E600", Offset = "0x324D800", VA = "0x18324E600")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0x324E5C0", Offset = "0x324D7C0", VA = "0x18324E5C0")]
			public LookAtBone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x324E5D0", Offset = "0x324D7D0", VA = "0x18324E5D0")]
			public LookAtBone(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x324E320", Offset = "0x324D520", VA = "0x18324E320")]
			public void Initiate(Transform root)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x324E450", Offset = "0x324D650", VA = "0x18324E450")]
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
			[Cpp2IlInjected.Address(RVA = "0x3245380", Offset = "0x3244580", VA = "0x183245380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected bool spineIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x3245360", Offset = "0x3244560", VA = "0x183245360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected bool headIsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x3245350", Offset = "0x3244550", VA = "0x183245350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected bool headIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x32452E0", Offset = "0x32444E0", VA = "0x1832452E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected bool eyesIsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x32451F0", Offset = "0x32443F0", VA = "0x1832451F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected bool eyesIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x32451D0", Offset = "0x32443D0", VA = "0x1832451D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x3243EF0", Offset = "0x32430F0", VA = "0x183243EF0")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x3243C60", Offset = "0x3242E60", VA = "0x183243C60")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x3243E20", Offset = "0x3243020", VA = "0x183243E20")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x3243B70", Offset = "0x3242D70", VA = "0x183243B70")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x3243D00", Offset = "0x3242F00", VA = "0x183243D00")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x3243F60", Offset = "0x3243160", VA = "0x183243F60")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x3244D60", Offset = "0x3243F60", VA = "0x183244D60", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x19B6700", Offset = "0x19B5900", VA = "0x1819B6700")]
		public void SetDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x32425D0", Offset = "0x32417D0", VA = "0x1832425D0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x32430A0", Offset = "0x32422A0", VA = "0x1832430A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x3242DC0", Offset = "0x3241FC0", VA = "0x183242DC0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x3242C00", Offset = "0x3241E00", VA = "0x183242C00", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x3243AC0", Offset = "0x3242CC0", VA = "0x183243AC0")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x3243370", Offset = "0x3242570", VA = "0x183243370", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3243800", Offset = "0x3242A00", VA = "0x183243800", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x3244A50", Offset = "0x3243C50", VA = "0x183244A50")]
		protected void SolveSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x32446D0", Offset = "0x32438D0", VA = "0x1832446D0")]
		protected void SolveHead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x32440B0", Offset = "0x32432B0", VA = "0x1832440B0")]
		protected void SolveEyes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x3242760", Offset = "0x3241960", VA = "0x183242760")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x3243910", Offset = "0x3242B10", VA = "0x183243910")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x3244FB0", Offset = "0x32441B0", VA = "0x183244FB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x324ED30", Offset = "0x324DF30", VA = "0x18324ED30")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x324EC50", Offset = "0x324DE50", VA = "0x18324EC50")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0x324EB70", Offset = "0x324DD70", VA = "0x18324EB70")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x324E5C0", Offset = "0x324D7C0", VA = "0x18324E5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3247320", Offset = "0x3246520", VA = "0x183247320")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x3247590", Offset = "0x3246790", VA = "0x183247590")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x3247890", Offset = "0x3246A90", VA = "0x183247890")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x3247820", Offset = "0x3246A20", VA = "0x183247820")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x3245AF0", Offset = "0x3244CF0", VA = "0x183245AF0")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xD61BA0", Offset = "0xD60DA0", VA = "0x180D61BA0")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3245C60", Offset = "0x3244E60", VA = "0x183245C60", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x3245B00", Offset = "0x3244D00", VA = "0x183245B00", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x3247F00", Offset = "0x3247100", VA = "0x183247F00", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x3245470", Offset = "0x3244670", VA = "0x183245470", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x32461E0", Offset = "0x32453E0", VA = "0x1832461E0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x32477C0", Offset = "0x32469C0", VA = "0x1832477C0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x32478A0", Offset = "0x3246AA0", VA = "0x1832478A0")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x32458A0", Offset = "0x3244AA0", VA = "0x1832458A0")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x3246670", Offset = "0x3245870", VA = "0x183246670", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x32460B0", Offset = "0x32452B0", VA = "0x1832460B0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x3245DB0", Offset = "0x3244FB0", VA = "0x183245DB0")]
		private void InitiateBones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x32468E0", Offset = "0x3245AE0", VA = "0x1832468E0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x32454D0", Offset = "0x32446D0", VA = "0x1832454D0")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x3248020", Offset = "0x3247220", VA = "0x183248020")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE5520", Offset = "0xCE4720", VA = "0x180CE5520")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60006C8")]
				[Cpp2IlInjected.Address(RVA = "0xCE5440", Offset = "0xCE4640", VA = "0x180CE5440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public Quaternion rotation
			{
				[Cpp2IlInjected.Token(Token = "0x60006C9")]
				[Cpp2IlInjected.Address(RVA = "0x18F2700", Offset = "0x18F1900", VA = "0x1818F2700")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60006CA")]
				[Cpp2IlInjected.Address(RVA = "0x18EC9A0", Offset = "0x18EBBA0", VA = "0x1818EC9A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			private VirtualBone shoulder
			{
				[Cpp2IlInjected.Token(Token = "0x60006CB")]
				[Cpp2IlInjected.Address(RVA = "0x3493130", Offset = "0x3492330", VA = "0x183493130")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			private VirtualBone upperArm
			{
				[Cpp2IlInjected.Token(Token = "0x60006CC")]
				[Cpp2IlInjected.Address(RVA = "0x3493170", Offset = "0x3492370", VA = "0x183493170")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			private VirtualBone forearm
			{
				[Cpp2IlInjected.Token(Token = "0x60006CD")]
				[Cpp2IlInjected.Address(RVA = "0x3493070", Offset = "0x3492270", VA = "0x183493070")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			private VirtualBone hand
			{
				[Cpp2IlInjected.Token(Token = "0x60006CE")]
				[Cpp2IlInjected.Address(RVA = "0x34930D0", Offset = "0x34922D0", VA = "0x1834930D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x348EC50", Offset = "0x348DE50", VA = "0x18348EC50", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0x348F920", Offset = "0x348EB20", VA = "0x18348F920", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x348E360", Offset = "0x348D560", VA = "0x18348E360", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x3492030", Offset = "0x3491230", VA = "0x183492030")]
			private void Stretching()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x348FD30", Offset = "0x348EF30", VA = "0x18348FD30")]
			public void Solve(bool isLeft)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0x348FCC0", Offset = "0x348EEC0", VA = "0x18348FCC0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0x3492A80", Offset = "0x3491C80", VA = "0x183492A80", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0x348E430", Offset = "0x348D630", VA = "0x18348E430")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0x348E530", Offset = "0x348D730", VA = "0x18348E530")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0x3492940", Offset = "0x3491B40", VA = "0x183492940")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0x3492F10", Offset = "0x3492110", VA = "0x183492F10")]
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
				[Cpp2IlInjected.Address(RVA = "0xD9DAE0", Offset = "0xD9CCE0", VA = "0x180D9DAE0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60006E0")]
				[Cpp2IlInjected.Address(RVA = "0xD9DB00", Offset = "0xD9CD00", VA = "0x180D9DB00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public float mag
			{
				[Cpp2IlInjected.Token(Token = "0x60006E1")]
				[Cpp2IlInjected.Address(RVA = "0xB96810", Offset = "0xB95A10", VA = "0x180B96810")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60006E2")]
				[Cpp2IlInjected.Address(RVA = "0xB96800", Offset = "0xB95A00", VA = "0x180B96800")]
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
			[Cpp2IlInjected.Address(RVA = "0x7377F0", Offset = "0x7369F0", VA = "0x1807377F0")]
			public void SetLOD(int LOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0x3493470", Offset = "0x3492670", VA = "0x183493470")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x34931D0", Offset = "0x34923D0", VA = "0x1834931D0")]
			public void MovePosition(Vector3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x34933A0", Offset = "0x34925A0", VA = "0x1834933A0")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x3493930", Offset = "0x3492B30", VA = "0x183493930")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x3493720", Offset = "0x3492920", VA = "0x183493720")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0x3493580", Offset = "0x3492780", VA = "0x183493580")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x3493A30", Offset = "0x3492C30", VA = "0x183493A30")]
			public void Visualize(Color color)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x3493BA0", Offset = "0x3492DA0", VA = "0x183493BA0")]
			public void Visualize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0x3493D30", Offset = "0x3492F30", VA = "0x183493D30")]
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
				[Cpp2IlInjected.Address(RVA = "0x3494DF0", Offset = "0x3493FF0", VA = "0x183494DF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public float stepProgress
			{
				[Cpp2IlInjected.Token(Token = "0x60006EE")]
				[Cpp2IlInjected.Address(RVA = "0xAFC200", Offset = "0xAFB400", VA = "0x180AFC200")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60006EF")]
				[Cpp2IlInjected.Address(RVA = "0x1B691C0", Offset = "0x1B683C0", VA = "0x181B691C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x3494C60", Offset = "0x3493E60", VA = "0x183494C60")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x3494440", Offset = "0x3493640", VA = "0x183494440")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x3494490", Offset = "0x3493690", VA = "0x183494490")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x3494860", Offset = "0x3493A60", VA = "0x183494860")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x3494660", Offset = "0x3493860", VA = "0x183494660")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0x3494A20", Offset = "0x3493C20", VA = "0x183494A20")]
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
				[Cpp2IlInjected.Address(RVA = "0x2663260", Offset = "0x2662460", VA = "0x182663260")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60006F7")]
				[Cpp2IlInjected.Address(RVA = "0x34A3360", Offset = "0x34A2560", VA = "0x1834A3360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public Quaternion rotation
			{
				[Cpp2IlInjected.Token(Token = "0x60006F8")]
				[Cpp2IlInjected.Address(RVA = "0x13D6CE0", Offset = "0x13D5EE0", VA = "0x1813D6CE0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60006F9")]
				[Cpp2IlInjected.Address(RVA = "0x13D67F0", Offset = "0x13D59F0", VA = "0x1813D67F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public bool hasToes
			{
				[Cpp2IlInjected.Token(Token = "0x60006FA")]
				[Cpp2IlInjected.Address(RVA = "0x684A00", Offset = "0x683C00", VA = "0x180684A00")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60006FB")]
				[Cpp2IlInjected.Address(RVA = "0x17F1FB0", Offset = "0x17F11B0", VA = "0x1817F1FB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public VirtualBone thigh
			{
				[Cpp2IlInjected.Token(Token = "0x60006FC")]
				[Cpp2IlInjected.Address(RVA = "0x3493130", Offset = "0x3492330", VA = "0x183493130")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			private VirtualBone calf
			{
				[Cpp2IlInjected.Token(Token = "0x60006FD")]
				[Cpp2IlInjected.Address(RVA = "0x34A3260", Offset = "0x34A2460", VA = "0x1834A3260")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			private VirtualBone foot
			{
				[Cpp2IlInjected.Token(Token = "0x60006FE")]
				[Cpp2IlInjected.Address(RVA = "0x34A32A0", Offset = "0x34A24A0", VA = "0x1834A32A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			private VirtualBone toes
			{
				[Cpp2IlInjected.Token(Token = "0x60006FF")]
				[Cpp2IlInjected.Address(RVA = "0x34A3320", Offset = "0x34A2520", VA = "0x1834A3320")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public VirtualBone lastBone
			{
				[Cpp2IlInjected.Token(Token = "0x6000700")]
				[Cpp2IlInjected.Address(RVA = "0x34A32E0", Offset = "0x34A24E0", VA = "0x1834A32E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public Vector3 thighRelativeToPelvis
			{
				[Cpp2IlInjected.Token(Token = "0x6000701")]
				[Cpp2IlInjected.Address(RVA = "0x323BB50", Offset = "0x323AD50", VA = "0x18323BB50")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000702")]
				[Cpp2IlInjected.Address(RVA = "0x323BD70", Offset = "0x323AF70", VA = "0x18323BD70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x34A0D80", Offset = "0x349FF80", VA = "0x1834A0D80", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x34A1800", Offset = "0x34A0A00", VA = "0x1834A1800", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x349FBD0", Offset = "0x349EDD0", VA = "0x18349FBD0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x34A0400", Offset = "0x349F600", VA = "0x1834A0400")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x34A0550", Offset = "0x349F750", VA = "0x1834A0550")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x34A2130", Offset = "0x34A1330", VA = "0x1834A2130")]
			public void Solve(bool stretch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x34A07F0", Offset = "0x349F9F0", VA = "0x1834A07F0")]
			private void FixTwistRotations()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0x34A24C0", Offset = "0x34A16C0", VA = "0x1834A24C0")]
			private void Stretching()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x34A2DB0", Offset = "0x34A1FB0", VA = "0x1834A2DB0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0x34A2070", Offset = "0x34A1270", VA = "0x1834A2070", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x34A3160", Offset = "0x34A2360", VA = "0x1834A3160")]
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
				[Cpp2IlInjected.Address(RVA = "0x12817B0", Offset = "0x12809B0", VA = "0x1812817B0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600070F")]
				[Cpp2IlInjected.Address(RVA = "0x1965AD0", Offset = "0x1964CD0", VA = "0x181965AD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B3")]
			public Vector3 leftFootstepPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000716")]
				[Cpp2IlInjected.Address(RVA = "0x34A6BA0", Offset = "0x34A5DA0", VA = "0x1834A6BA0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B4")]
			public Vector3 rightFootstepPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000717")]
				[Cpp2IlInjected.Address(RVA = "0x34A6C50", Offset = "0x34A5E50", VA = "0x1834A6C50")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B5")]
			public Quaternion leftFootstepRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0x34A6C00", Offset = "0x34A5E00", VA = "0x1834A6C00")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B6")]
			public Quaternion rightFootstepRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x34A6CB0", Offset = "0x34A5EB0", VA = "0x1834A6CB0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x34A3D50", Offset = "0x34A2F50", VA = "0x1834A3D50")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x34A4190", Offset = "0x34A3390", VA = "0x1834A4190")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x34A4120", Offset = "0x34A3320", VA = "0x1834A4120")]
			public void Relax()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x34A35B0", Offset = "0x34A27B0", VA = "0x1834A35B0")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x34A3380", Offset = "0x34A2580", VA = "0x1834A3380")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x34A4580", Offset = "0x34A3780", VA = "0x1834A4580")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x34A6840", Offset = "0x34A5A40", VA = "0x1834A6840")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x34A3AA0", Offset = "0x34A2CA0", VA = "0x1834A3AA0")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x34A3B20", Offset = "0x34A2D20", VA = "0x1834A3B20")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x34A6AA0", Offset = "0x34A5CA0", VA = "0x1834A6AA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x34ABAF0", Offset = "0x34AACF0", VA = "0x1834ABAF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B8")]
			public VirtualBone firstSpineBone
			{
				[Cpp2IlInjected.Token(Token = "0x600071F")]
				[Cpp2IlInjected.Address(RVA = "0x34ABA30", Offset = "0x34AAC30", VA = "0x1834ABA30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B9")]
			public VirtualBone chest
			{
				[Cpp2IlInjected.Token(Token = "0x6000720")]
				[Cpp2IlInjected.Address(RVA = "0x34AB9C0", Offset = "0x34AABC0", VA = "0x1834AB9C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BA")]
			private VirtualBone neck
			{
				[Cpp2IlInjected.Token(Token = "0x6000721")]
				[Cpp2IlInjected.Address(RVA = "0x34ABAB0", Offset = "0x34AACB0", VA = "0x1834ABAB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BB")]
			public VirtualBone head
			{
				[Cpp2IlInjected.Token(Token = "0x6000722")]
				[Cpp2IlInjected.Address(RVA = "0x34ABA70", Offset = "0x34AAC70", VA = "0x1834ABA70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BC")]
			public Quaternion anchorRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000723")]
				[Cpp2IlInjected.Address(RVA = "0x2D35DA0", Offset = "0x2D34FA0", VA = "0x182D35DA0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x6000724")]
				[Cpp2IlInjected.Address(RVA = "0x34ABB40", Offset = "0x34AAD40", VA = "0x1834ABB40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BD")]
			public Quaternion anchorRelativeToHead
			{
				[Cpp2IlInjected.Token(Token = "0x6000725")]
				[Cpp2IlInjected.Address(RVA = "0x34AB9B0", Offset = "0x34AABB0", VA = "0x1834AB9B0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x6000726")]
				[Cpp2IlInjected.Address(RVA = "0x34ABB30", Offset = "0x34AAD30", VA = "0x1834ABB30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x34A8CE0", Offset = "0x34A7EE0", VA = "0x1834A8CE0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x34A9B40", Offset = "0x34A8D40", VA = "0x1834A9B40", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x34A72E0", Offset = "0x34A64E0", VA = "0x1834A72E0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x34A80D0", Offset = "0x34A72D0", VA = "0x1834A80D0")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x34AA3F0", Offset = "0x34A95F0", VA = "0x1834AA3F0")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x34A82F0", Offset = "0x34A74F0", VA = "0x1834A82F0")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x34A9F80", Offset = "0x34A9180", VA = "0x1834A9F80")]
			private void SolvePelvis()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x34AB4F0", Offset = "0x34AA6F0", VA = "0x1834AB4F0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x34A9E70", Offset = "0x34A9070", VA = "0x1834A9E70", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x34A6E20", Offset = "0x34A6020", VA = "0x1834A6E20")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x34A85E0", Offset = "0x34A77E0", VA = "0x1834A85E0")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x34AAF20", Offset = "0x34AA120", VA = "0x1834AAF20")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x34A8810", Offset = "0x34A7A10", VA = "0x1834A8810")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x34A7A10", Offset = "0x34A6C10", VA = "0x1834A7A10")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x34A7D10", Offset = "0x34A6F10", VA = "0x1834A7D10")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x34AB7C0", Offset = "0x34AA9C0", VA = "0x1834AB7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x34AE030", Offset = "0x34AD230", VA = "0x1834AE030")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x34AC1D0", Offset = "0x34AB3D0", VA = "0x1834AC1D0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x34ADD70", Offset = "0x34ACF70", VA = "0x1834ADD70")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x34ABDA0", Offset = "0x34AAFA0", VA = "0x1834ABDA0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x34AC200", Offset = "0x34AB400", VA = "0x1834AC200")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x34AC720", Offset = "0x34AB920", VA = "0x1834AC720")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x34AC440", Offset = "0x34AB640", VA = "0x1834AC440")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x34AC9E0", Offset = "0x34ABBE0", VA = "0x1834AC9E0")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x34AD590", Offset = "0x34AC790", VA = "0x1834AD590")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x34ABB50", Offset = "0x34AAD50", VA = "0x1834ABB50")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x34ACF30", Offset = "0x34AC130", VA = "0x1834ACF30")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x34ACDF0", Offset = "0x34ABFF0", VA = "0x1834ACDF0")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x34ACAC0", Offset = "0x34ABCC0", VA = "0x1834ACAC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E5B10", Offset = "0x5E4D10", VA = "0x1805E5B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x5E5960", Offset = "0x5E4B60", VA = "0x1805E5960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x324B5F0", Offset = "0x324A7F0", VA = "0x18324B5F0")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x3249F90", Offset = "0x3249190", VA = "0x183249F90")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x3248BE0", Offset = "0x3247DE0", VA = "0x183248BE0")]
		public void DefaultAnimationCurves()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x3248310", Offset = "0x3247510", VA = "0x183248310")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x3248810", Offset = "0x3247A10", VA = "0x183248810")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x3248A30", Offset = "0x3247C30", VA = "0x183248A30")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x3248140", Offset = "0x3247340", VA = "0x183248140")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x324B420", Offset = "0x324A620", VA = "0x18324B420")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x324D530", Offset = "0x324C730", VA = "0x18324D530", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x3248D60", Offset = "0x3247F60", VA = "0x183248D60", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x3249D30", Offset = "0x3248F30", VA = "0x183249D30", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x3249CD0", Offset = "0x3248ED0", VA = "0x183249CD0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x324A310", Offset = "0x3249510", VA = "0x18324A310", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x3248FB0", Offset = "0x32481B0", VA = "0x183248FB0")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x3249E30", Offset = "0x3249030", VA = "0x183249E30")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x324D710", Offset = "0x324C910", VA = "0x18324D710")]
		private void UpdateSolverTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x324A5C0", Offset = "0x32497C0", VA = "0x18324A5C0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x324A620", Offset = "0x3249820", VA = "0x18324A620", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x324D8D0", Offset = "0x324CAD0", VA = "0x18324D8D0")]
		private void WriteTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x324AD20", Offset = "0x3249F20", VA = "0x18324AD20")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x324BA80", Offset = "0x324AC80", VA = "0x18324BA80")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x3249D90", Offset = "0x3248F90", VA = "0x183249D90")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x3249DE0", Offset = "0x3248FE0", VA = "0x183249DE0")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x324DF10", Offset = "0x324D110", VA = "0x18324DF10")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x3249340", Offset = "0x3248540", VA = "0x183249340")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x324E0D0", Offset = "0x324D2D0", VA = "0x18324E0D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F101E0", Offset = "0x2F0F3E0", VA = "0x182F101E0")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x2F10130", Offset = "0x2F0F330", VA = "0x182F10130")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2F0FF70", Offset = "0x2F0F170", VA = "0x182F0FF70")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x2F10020", Offset = "0x2F0F220", VA = "0x182F10020")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2F103A0", Offset = "0x2F0F5A0", VA = "0x182F103A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F11030", Offset = "0x2F10230", VA = "0x182F11030")]
		public TwistSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2F103F0", Offset = "0x2F0F5F0", VA = "0x182F103F0")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2F10A50", Offset = "0x2F0FC50", VA = "0x182F10A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x46FE50", Offset = "0x46F050", VA = "0x18046FE50")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x46FE60", Offset = "0x46F060", VA = "0x18046FE60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool isPaused
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x5ACD90", Offset = "0x5ABF90", VA = "0x1805ACD90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x583F30", Offset = "0x583130", VA = "0x180583F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public InteractionObject interactionObject
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x46F450", Offset = "0x46E650", VA = "0x18046F450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool inInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x3497590", Offset = "0x3496790", VA = "0x183497590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public float progress
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x34975F0", Offset = "0x34967F0", VA = "0x1834975F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x3497510", Offset = "0x3496710", VA = "0x183497510")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x3494FD0", Offset = "0x34941D0", VA = "0x183494FD0")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x3496720", Offset = "0x3495920", VA = "0x183496720")]
		private void StoreDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x34958F0", Offset = "0x3494AF0", VA = "0x1834958F0")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x3495430", Offset = "0x3494630", VA = "0x183495430")]
		public bool Pause()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x3495F50", Offset = "0x3495150", VA = "0x183495F50")]
		public bool Resume()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x3496000", Offset = "0x3495200", VA = "0x183496000")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x3496C20", Offset = "0x3495E20", VA = "0x183496C20")]
		public void Update(Transform root, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x3496910", Offset = "0x3495B10", VA = "0x183496910")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x34955F0", Offset = "0x34947F0", VA = "0x1834955F0")]
		private void PickUp(Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x34964F0", Offset = "0x34956F0", VA = "0x1834964F0")]
		public bool Stop()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x3495070", Offset = "0x3494270", VA = "0x183495070")]
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
		[Cpp2IlInjected.Address(RVA = "0x34978B0", Offset = "0x3496AB0", VA = "0x1834978B0")]
		public void Look(Transform target, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x3497AB0", Offset = "0x3496CB0", VA = "0x183497AB0")]
		public void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x3497D60", Offset = "0x3496F60", VA = "0x183497D60")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x3497C30", Offset = "0x3496E30", VA = "0x183497C30")]
		public void SolveSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x3497B50", Offset = "0x3496D50", VA = "0x183497B50")]
		public void SolveHead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x3498030", Offset = "0x3497230", VA = "0x183498030")]
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
			[Cpp2IlInjected.Address(RVA = "0x3497710", Offset = "0x3496910", VA = "0x183497710")]
			public void Activate(Transform t)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x34A6D00", Offset = "0x34A5F00", VA = "0x1834A6D00")]
			public void Send(Transform t)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x348E150", Offset = "0x348D350", VA = "0x18348E150")]
			public void Activate(bool pickUp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x348E0B0", Offset = "0x348D2B0", VA = "0x18348E0B0")]
			private void Activate(Animator animator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x348DFF0", Offset = "0x348D1F0", VA = "0x18348DFF0")]
			private void Activate(Animation animation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x348E350", Offset = "0x348D550", VA = "0x18348E350")]
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
			[Cpp2IlInjected.Address(RVA = "0x34AE090", Offset = "0x34AD290", VA = "0x1834AE090")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x34A6DE0", Offset = "0x34A5FE0", VA = "0x1834A6DE0")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x2677300", Offset = "0x2676500", VA = "0x182677300")]
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
			[Cpp2IlInjected.Address(RVA = "0xFE33E0", Offset = "0xFE25E0", VA = "0x180FE33E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x1B69070", Offset = "0x1B68270", VA = "0x181B69070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x492970", Offset = "0x491B70", VA = "0x180492970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x4E5BA0", Offset = "0x4E4DA0", VA = "0x1804E5BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Transform lookAtTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x3499AB0", Offset = "0x3498CB0", VA = "0x183499AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Transform targetsRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x3499B30", Offset = "0x3498D30", VA = "0x183499B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x34999D0", Offset = "0x3498BD0", VA = "0x1834999D0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x3499890", Offset = "0x3498A90", VA = "0x183499890")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x34998D0", Offset = "0x3498AD0", VA = "0x1834998D0")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x3499910", Offset = "0x3498B10", VA = "0x183499910")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x3499950", Offset = "0x3498B50", VA = "0x183499950")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x3499990", Offset = "0x3498B90", VA = "0x183499990")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x3499A20", Offset = "0x3498C20", VA = "0x183499A20")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x3498050", Offset = "0x3497250", VA = "0x183498050")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x34995C0", Offset = "0x34987C0", VA = "0x1834995C0")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x3499070", Offset = "0x3498270", VA = "0x183499070")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x3498D90", Offset = "0x3497F90", VA = "0x183498D90")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x480A00", Offset = "0x47FC00", VA = "0x180480A00")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x3498EC0", Offset = "0x34980C0", VA = "0x183498EC0")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x4E5BA0", Offset = "0x4E4DA0", VA = "0x1804E5BA0")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x3498090", Offset = "0x3497290", VA = "0x183498090")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x3499250", Offset = "0x3498450", VA = "0x183499250")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x3499A10", Offset = "0x3498C10", VA = "0x183499A10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x3498620", Offset = "0x3497820", VA = "0x183498620")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x34991C0", Offset = "0x34983C0", VA = "0x1834991C0")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x3499550", Offset = "0x3498750", VA = "0x183499550")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x3498E50", Offset = "0x3498050", VA = "0x183498E50")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3499A60", Offset = "0x3498C60", VA = "0x183499A60")]
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
			[Cpp2IlInjected.Address(RVA = "0x349EF40", Offset = "0x349E140", VA = "0x18349EF40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public FullBodyBipedIK ik
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x5E48D0", Offset = "0x5E3AD0", VA = "0x1805E48D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x564820", Offset = "0x563A20", VA = "0x180564820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public List<InteractionTrigger> triggersInRange
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x4BFA20", Offset = "0x4BEC20", VA = "0x1804BFA20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x52F620", Offset = "0x52E820", VA = "0x18052F620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x7376E0", Offset = "0x7368E0", VA = "0x1807376E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x737800", Offset = "0x736A00", VA = "0x180737800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x349C380", Offset = "0x349B580", VA = "0x18349C380")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x349C240", Offset = "0x349B440", VA = "0x18349C240")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x349C280", Offset = "0x349B480", VA = "0x18349C280")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x349C2C0", Offset = "0x349B4C0", VA = "0x18349C2C0")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x349C300", Offset = "0x349B500", VA = "0x18349C300")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x349C340", Offset = "0x349B540", VA = "0x18349C340")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x349D260", Offset = "0x349C460", VA = "0x18349D260")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x3499BB0", Offset = "0x3498DB0", VA = "0x183499BB0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x349AC90", Offset = "0x3499E90", VA = "0x18349AC90")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x349AFE0", Offset = "0x349A1E0", VA = "0x18349AFE0")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x349B160", Offset = "0x349A360", VA = "0x18349B160")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x349AE10", Offset = "0x349A010", VA = "0x18349AE10")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x349C9B0", Offset = "0x349BBB0", VA = "0x18349C9B0")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x349C4D0", Offset = "0x349B6D0", VA = "0x18349C4D0")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x349C870", Offset = "0x349BA70", VA = "0x18349C870")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x349D120", Offset = "0x349C320", VA = "0x18349D120")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x349C3C0", Offset = "0x349B5C0", VA = "0x18349C3C0")]
		public void PauseAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x349C760", Offset = "0x349B960", VA = "0x18349C760")]
		public void ResumeAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x349D0A0", Offset = "0x349C2A0", VA = "0x18349D0A0")]
		public void StopAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x349A630", Offset = "0x3499830", VA = "0x18349A630")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x349A960", Offset = "0x3499B60", VA = "0x18349A960")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x349A760", Offset = "0x3499960", VA = "0x18349A760")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x349DE40", Offset = "0x349D040", VA = "0x18349DE40")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x349D7D0", Offset = "0x349C9D0", VA = "0x18349D7D0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x349DAA0", Offset = "0x349CCA0", VA = "0x18349DAA0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x3499FB0", Offset = "0x34991B0", VA = "0x183499FB0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x3499E10", Offset = "0x3499010", VA = "0x183499E10")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x349A120", Offset = "0x3499320", VA = "0x18349A120")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x3499E60", Offset = "0x3499060", VA = "0x183499E60")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x349A1C0", Offset = "0x34993C0", VA = "0x18349A1C0")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x349D2A0", Offset = "0x349C4A0", VA = "0x18349D2A0")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x349AAA0", Offset = "0x3499CA0", VA = "0x18349AAA0")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x349A350", Offset = "0x3499550", VA = "0x18349A350")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x349CB70", Offset = "0x349BD70", VA = "0x18349CB70")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x349AC50", Offset = "0x3499E50", VA = "0x18349AC50")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x349AC70", Offset = "0x3499E70", VA = "0x18349AC70")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x349AC70", Offset = "0x3499E70", VA = "0x18349AC70")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x349B3F0", Offset = "0x349A5F0", VA = "0x18349B3F0")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x349C060", Offset = "0x349B260", VA = "0x18349C060")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x349C160", Offset = "0x349B360", VA = "0x18349C160")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x3499BF0", Offset = "0x3498DF0", VA = "0x183499BF0")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x349BA20", Offset = "0x349AC20", VA = "0x18349BA20")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x349E500", Offset = "0x349D700", VA = "0x18349E500")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x349C610", Offset = "0x349B810", VA = "0x18349C610")]
		private void Raycasting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x349E240", Offset = "0x349D440", VA = "0x18349E240")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x349E0D0", Offset = "0x349D2D0", VA = "0x18349E0D0")]
		private void UpdateEffectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x349BD60", Offset = "0x349AF60", VA = "0x18349BD60")]
		private void OnPreFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x349BBB0", Offset = "0x349ADB0", VA = "0x18349BBB0")]
		private void OnPostFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x349BB00", Offset = "0x349AD00", VA = "0x18349BB00")]
		private void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x349B680", Offset = "0x349A880", VA = "0x18349B680")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x349B320", Offset = "0x349A520", VA = "0x18349B320")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x349D6D0", Offset = "0x349C8D0", VA = "0x18349D6D0")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x349E850", Offset = "0x349DA50", VA = "0x18349E850")]
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
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x349F310", Offset = "0x349E510", VA = "0x18349F310")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x349F1D0", Offset = "0x349E3D0", VA = "0x18349F1D0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x349F210", Offset = "0x349E410", VA = "0x18349F210")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x349F250", Offset = "0x349E450", VA = "0x18349F250")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x349F290", Offset = "0x349E490", VA = "0x18349F290")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x349F2D0", Offset = "0x349E4D0", VA = "0x18349F2D0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x349FB00", Offset = "0x349ED00", VA = "0x18349FB00")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x349F100", Offset = "0x349E300", VA = "0x18349F100")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x349F140", Offset = "0x349E340", VA = "0x18349F140")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x349F350", Offset = "0x349E550", VA = "0x18349F350")]
		public void ResetRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x349F3E0", Offset = "0x349E5E0", VA = "0x18349F3E0")]
		public void RotateTo(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x349FB40", Offset = "0x349ED40", VA = "0x18349FB40")]
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
				[Cpp2IlInjected.Address(RVA = "0x2EFC1C0", Offset = "0x2EFB3C0", VA = "0x182EFC1C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BF")]
			public Vector3 direction3D
			{
				[Cpp2IlInjected.Token(Token = "0x600075A")]
				[Cpp2IlInjected.Address(RVA = "0x2EFC0B0", Offset = "0x2EFB2B0", VA = "0x182EFC0B0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x2EFB760", Offset = "0x2EFA960", VA = "0x182EFB760")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x2EFC090", Offset = "0x2EFB290", VA = "0x182EFC090")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EFB1A0", Offset = "0x2EFA3A0", VA = "0x182EFB1A0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0x2EFB3B0", Offset = "0x2EFA5B0", VA = "0x182EFB3B0")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2EFB6C0", Offset = "0x2EFA8C0", VA = "0x182EFB6C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F06840", Offset = "0x2F05A40", VA = "0x182F06840")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x232AA90", Offset = "0x2329C90", VA = "0x18232AA90")]
			public Range()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF4A0", Offset = "0x2EFE6A0", VA = "0x182EFF4A0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF420", Offset = "0x2EFE620", VA = "0x182EFF420")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF460", Offset = "0x2EFE660", VA = "0x182EFF460")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF4E0", Offset = "0x2EFE6E0", VA = "0x182EFF4E0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF170", Offset = "0x2EFE370", VA = "0x182EFF170")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF1B0", Offset = "0x2EFE3B0", VA = "0x182EFF1B0")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF520", Offset = "0x2EFE720", VA = "0x182EFF520")]
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
			[Cpp2IlInjected.Address(RVA = "0x326BF30", Offset = "0x326B130", VA = "0x18326BF30")]
			public Map(Transform bone, Transform target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x32500D0", Offset = "0x324F2D0", VA = "0x1832500D0")]
			public void StoreDefaultState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(RVA = "0x326BCD0", Offset = "0x326AED0", VA = "0x18326BCD0")]
			public void FixTransform()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x326BD30", Offset = "0x326AF30", VA = "0x18326BD30")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public Map[] maps;

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x3253D90", Offset = "0x3252F90", VA = "0x183253D90", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x32541E0", Offset = "0x32533E0", VA = "0x1832541E0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x32542B0", Offset = "0x32534B0", VA = "0x1832542B0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x3254060", Offset = "0x3253260", VA = "0x183254060", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x32541F0", Offset = "0x32533F0", VA = "0x1832541F0")]
		private void StoreDefaultState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x3254130", Offset = "0x3253330", VA = "0x183254130")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x32545E0", Offset = "0x32537E0", VA = "0x1832545E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x325E470", Offset = "0x325D670", VA = "0x18325E470", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x325E660", Offset = "0x325D860", VA = "0x18325E660", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x325E510", Offset = "0x325D710", VA = "0x18325E510", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x325E850", Offset = "0x325DA50", VA = "0x18325E850", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x325E6B0", Offset = "0x325D8B0", VA = "0x18325E6B0")]
		protected void StoreDefaultState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x32545E0", Offset = "0x32537E0", VA = "0x1832545E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B1AB0", Offset = "0x5B0CB0", VA = "0x1805B1AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F03530", Offset = "0x2F02730", VA = "0x182F03530", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2F03500", Offset = "0x2F02700", VA = "0x182F03500", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2F034E0", Offset = "0x2F026E0", VA = "0x182F034E0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2F03580", Offset = "0x2F02780", VA = "0x182F03580")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F0A7A0", Offset = "0x2F099A0", VA = "0x182F0A7A0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(RVA = "0x2F0A260", Offset = "0x2F09460", VA = "0x182F0A260")]
			public void RecordVelocity()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(RVA = "0x2F0A4A0", Offset = "0x2F096A0", VA = "0x182F0A4A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EFC480", Offset = "0x2EFB680", VA = "0x182EFC480")]
			public Child(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x2EFC200", Offset = "0x2EFB400", VA = "0x182EFC200")]
			public void FixTransform(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x2EFC420", Offset = "0x2EFB620", VA = "0x182EFC420")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x2F110F0", Offset = "0x2F102F0", VA = "0x182F110F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2F113D0", Offset = "0x2F105D0", VA = "0x182F113D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F067D0", Offset = "0x2F059D0", VA = "0x182F067D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private bool ikUsed
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x2F06690", Offset = "0x2F05890", VA = "0x182F06690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2F05260", Offset = "0x2F04460", VA = "0x182F05260")]
		public void EnableRagdoll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2F05180", Offset = "0x2F04380", VA = "0x182F05180")]
		public void DisableRagdoll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2F05C20", Offset = "0x2F04E20", VA = "0x182F05C20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2F05120", Offset = "0x2F04320", VA = "0x182F05120")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2F06250", Offset = "0x2F05450", VA = "0x182F06250")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2F05560", Offset = "0x2F04760", VA = "0x182F05560")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2F055F0", Offset = "0x2F047F0", VA = "0x182F055F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2F050F0", Offset = "0x2F042F0", VA = "0x182F050F0")]
		private void AfterLastIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2F05060", Offset = "0x2F04260", VA = "0x182F05060")]
		private void AfterAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2F057E0", Offset = "0x2F049E0", VA = "0x182F057E0")]
		private void OnFinalPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2F058C0", Offset = "0x2F04AC0", VA = "0x182F058C0")]
		private void RagdollEnabler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2F05BC0", Offset = "0x2F04DC0", VA = "0x182F05BC0")]
		private void RecordVelocities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2F061A0", Offset = "0x2F053A0", VA = "0x182F061A0")]
		private void StoreLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2F052E0", Offset = "0x2F044E0", VA = "0x182F052E0")]
		private void FixTransforms(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2F056D0", Offset = "0x2F048D0", VA = "0x182F056D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2F065E0", Offset = "0x2F057E0", VA = "0x182F065E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F0EB60", Offset = "0x2F0DD60", VA = "0x182F0EB60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Vector3 crossAxis
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x2F0EA70", Offset = "0x2F0DC70", VA = "0x182F0EA70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool defaultLocalRotationOverride
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x499190", Offset = "0x498390", VA = "0x180499190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0x9D4D30", Offset = "0x9D3F30", VA = "0x1809D4D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E9B0", Offset = "0x2F0DBB0", VA = "0x182F0E9B0")]
		public void SetDefaultLocalRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E9F0", Offset = "0x2F0DBF0", VA = "0x182F0E9F0")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E3D0", Offset = "0x2F0D5D0", VA = "0x182F0E3D0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E0A0", Offset = "0x2F0D2A0", VA = "0x182F0E0A0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E3A0", Offset = "0x2F0D5A0", VA = "0x182F0E3A0")]
		public void Disable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E280", Offset = "0x2F0D480", VA = "0x182F0E280")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E630", Offset = "0x2F0D830", VA = "0x182F0E630")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D0A0", Offset = "0x2A4C2A0", VA = "0x182A4D0A0")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E640", Offset = "0x2F0D840", VA = "0x182F0E640")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E740", Offset = "0x2F0D940", VA = "0x182F0E740")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E570", Offset = "0x2F0D770", VA = "0x182F0E570")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2F0EA00", Offset = "0x2F0DC00", VA = "0x182F0EA00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0ACF0", Offset = "0x2F09EF0", VA = "0x182F0ACF0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2F0ACB0", Offset = "0x2F09EB0", VA = "0x182F0ACB0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AD30", Offset = "0x2F09F30", VA = "0x182F0AD30")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A900", Offset = "0x2F09B00", VA = "0x182F0A900")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A940", Offset = "0x2F09B40", VA = "0x182F0A940", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AA30", Offset = "0x2F09C30", VA = "0x182F0AA30")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AD70", Offset = "0x2F09F70", VA = "0x182F0AD70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0B260", Offset = "0x2F0A460", VA = "0x182F0B260")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B220", Offset = "0x2F0A420", VA = "0x182F0B220")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B2A0", Offset = "0x2F0A4A0", VA = "0x182F0B2A0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0ADF0", Offset = "0x2F09FF0", VA = "0x182F0ADF0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B1E0", Offset = "0x2F0A3E0", VA = "0x182F0B1E0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AE30", Offset = "0x2F0A030", VA = "0x182F0AE30")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B2E0", Offset = "0x2F0A4E0", VA = "0x182F0B2E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2F06EF0", Offset = "0x2F060F0", VA = "0x182F06EF0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C3")]
			public Vector3 a
			{
				[Cpp2IlInjected.Token(Token = "0x6000773")]
				[Cpp2IlInjected.Address(RVA = "0x2F06E20", Offset = "0x2F06020", VA = "0x182F06E20")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C4")]
			public Vector3 b
			{
				[Cpp2IlInjected.Token(Token = "0x6000774")]
				[Cpp2IlInjected.Address(RVA = "0x2F06E60", Offset = "0x2F06060", VA = "0x182F06E60")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C5")]
			public Vector3 c
			{
				[Cpp2IlInjected.Token(Token = "0x6000775")]
				[Cpp2IlInjected.Address(RVA = "0x2F06EA0", Offset = "0x2F060A0", VA = "0x182F06EA0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C6")]
			public bool isValid
			{
				[Cpp2IlInjected.Token(Token = "0x6000777")]
				[Cpp2IlInjected.Address(RVA = "0x2F06EE0", Offset = "0x2F060E0", VA = "0x182F06EE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x2F06C70", Offset = "0x2F05E70", VA = "0x182F06C70")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x2F06990", Offset = "0x2F05B90", VA = "0x182F06990")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F01190", Offset = "0x2F00390", VA = "0x182F01190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0C230", Offset = "0x2F0B430", VA = "0x182F0C230")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C1F0", Offset = "0x2F0B3F0", VA = "0x182F0C1F0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D670", Offset = "0x2F0C870", VA = "0x182F0D670")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B360", Offset = "0x2F0A560", VA = "0x182F0B360")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C8F0", Offset = "0x2F0BAF0", VA = "0x182F0C8F0")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2F0BD30", Offset = "0x2F0AF30", VA = "0x182F0BD30", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D3C0", Offset = "0x2F0C5C0", VA = "0x182F0D3C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C400", Offset = "0x2F0B600", VA = "0x182F0C400")]
		public void ResetToDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B3A0", Offset = "0x2F0A5A0", VA = "0x182F0B3A0")]
		public void BuildReachCones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C970", Offset = "0x2F0BB70", VA = "0x182F0C970")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0BCE0", Offset = "0x2F0AEE0", VA = "0x182F0BCE0")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C270", Offset = "0x2F0B470", VA = "0x182F0C270")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D6B0", Offset = "0x2F0C8B0", VA = "0x182F0D6B0")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x2F0BE50", Offset = "0x2F0B050", VA = "0x182F0BE50")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2F0BA70", Offset = "0x2F0AC70", VA = "0x182F0BA70")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D8B0", Offset = "0x2F0CAB0", VA = "0x182F0D8B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0DF80", Offset = "0x2F0D180", VA = "0x182F0DF80")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DF40", Offset = "0x2F0D140", VA = "0x182F0DF40")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DFE0", Offset = "0x2F0D1E0", VA = "0x182F0DFE0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D950", Offset = "0x2F0CB50", VA = "0x182F0D950")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DFC0", Offset = "0x2F0D1C0", VA = "0x182F0DFC0")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D990", Offset = "0x2F0CB90", VA = "0x182F0D990", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DA80", Offset = "0x2F0CC80", VA = "0x182F0DA80")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E020", Offset = "0x2F0D220", VA = "0x182F0E020")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x2A667C0", Offset = "0x2A659C0", VA = "0x182A667C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x2A66910", Offset = "0x2A65B10", VA = "0x182A66910", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A4B8B0", Offset = "0x2A4AAB0", VA = "0x182A4B8B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B630", Offset = "0x2A4A830", VA = "0x182A4B630")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x2A4A470", Offset = "0x2A49670", VA = "0x182A4A470")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x2A4A260", Offset = "0x2A49460", VA = "0x182A4A260")]
		private void ApplyMinDistance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B270", Offset = "0x2A4A470", VA = "0x182A4B270")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B770", Offset = "0x2A4A970", VA = "0x182A4B770")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B7D0", Offset = "0x2A4A9D0", VA = "0x182A4B7D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A62700", Offset = "0x2A61900", VA = "0x182A62700")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0xAFA420", Offset = "0xAF9620", VA = "0x180AFA420")]
			public void SetAngleBuffer(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x2A62A50", Offset = "0x2A61C50", VA = "0x182A62A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4BBE0", Offset = "0x2A4ADE0", VA = "0x182A4BBE0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BD00", Offset = "0x2A4AF00", VA = "0x182A4BD00")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BD90", Offset = "0x2A4AF90", VA = "0x182A4BD90")]
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
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A4DD80", Offset = "0x2A4CF80", VA = "0x182A4DD80")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x2A4DD20", Offset = "0x2A4CF20", VA = "0x182A4DD20")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x2A4E370", Offset = "0x2A4D570", VA = "0x182A4E370")]
			public Body()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BDE0", Offset = "0x2A4AFE0", VA = "0x182A4BDE0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BF20", Offset = "0x2A4B120", VA = "0x182A4BF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4DCB0", Offset = "0x2A4CEB0", VA = "0x182A4DCB0", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DA30", Offset = "0x2A4CC30", VA = "0x182A4DA30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DD00", Offset = "0x2A4CF00", VA = "0x182A4DD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4E870", Offset = "0x2A4DA70", VA = "0x182A4E870")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E390", Offset = "0x2A4D590", VA = "0x182A4E390")]
		private void BeforeIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E780", Offset = "0x2A4D980", VA = "0x182A4E780")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xC00840", Offset = "0xBFFA40", VA = "0x180C00840")]
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
			[Cpp2IlInjected.Address(RVA = "0x496670", Offset = "0x495870", VA = "0x180496670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x52F650", Offset = "0x52E850", VA = "0x18052F650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A50240", Offset = "0x2A4F440", VA = "0x182A50240")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A50140", Offset = "0x2A4F340", VA = "0x182A50140")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FFF0", Offset = "0x2A4F1F0", VA = "0x182A4FFF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A50390", Offset = "0x2A4F590", VA = "0x182A50390")]
		public void StoreDefaultPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FDC0", Offset = "0x2A4EFC0", VA = "0x182A4FDC0")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A50560", Offset = "0x2A4F760", VA = "0x182A50560")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A50860", Offset = "0x2A4FA60", VA = "0x182A50860")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A4FDA0", Offset = "0x2A4EFA0", VA = "0x182A4FDA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FBC0", Offset = "0x2A4EDC0", VA = "0x182A4FBC0")]
		public void Store(Transform[] T)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FA20", Offset = "0x2A4EC20", VA = "0x182A4FA20")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FD40", Offset = "0x2A4EF40", VA = "0x182A4FD40")]
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
				[Cpp2IlInjected.Address(RVA = "0x325F9D0", Offset = "0x325EBD0", VA = "0x18325F9D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CA")]
			protected float crossFader
			{
				[Cpp2IlInjected.Token(Token = "0x6000787")]
				[Cpp2IlInjected.Address(RVA = "0xB2BFD0", Offset = "0xB2B1D0", VA = "0x180B2BFD0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000788")]
				[Cpp2IlInjected.Address(RVA = "0xB2CF70", Offset = "0xB2C170", VA = "0x180B2CF70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CB")]
			protected float timer
			{
				[Cpp2IlInjected.Token(Token = "0x6000789")]
				[Cpp2IlInjected.Address(RVA = "0xB7BD80", Offset = "0xB7AF80", VA = "0x180B7BD80")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600078A")]
				[Cpp2IlInjected.Address(RVA = "0xD2DBE0", Offset = "0xD2CDE0", VA = "0x180D2DBE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CC")]
			protected Vector3 force
			{
				[Cpp2IlInjected.Token(Token = "0x600078B")]
				[Cpp2IlInjected.Address(RVA = "0xFE52A0", Offset = "0xFE44A0", VA = "0x180FE52A0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0xFE3F80", Offset = "0xFE3180", VA = "0x180FE3F80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CD")]
			protected Vector3 point
			{
				[Cpp2IlInjected.Token(Token = "0x600078D")]
				[Cpp2IlInjected.Address(RVA = "0xBEE8D0", Offset = "0xBEDAD0", VA = "0x180BEE8D0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600078E")]
				[Cpp2IlInjected.Address(RVA = "0xD04BD0", Offset = "0xD03DD0", VA = "0x180D04BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x325F8C0", Offset = "0x325EAC0", VA = "0x18325F8C0")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x325F760", Offset = "0x325E960", VA = "0x18325F760")]
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
			[Cpp2IlInjected.Address(RVA = "0x325F180", Offset = "0x325E380", VA = "0x18325F180")]
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
				[Cpp2IlInjected.Address(RVA = "0x3251390", Offset = "0x3250590", VA = "0x183251390")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600080C")]
				[Cpp2IlInjected.Address(RVA = "0x3251510", Offset = "0x3250710", VA = "0x183251510")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600080D")]
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x325F1F0", Offset = "0x325E3F0", VA = "0x18325F1F0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x325F190", Offset = "0x325E390", VA = "0x18325F190", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x325F380", Offset = "0x325E580", VA = "0x18325F380", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x325F180", Offset = "0x325E380", VA = "0x18325F180")]
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
				[Cpp2IlInjected.Address(RVA = "0x324EF10", Offset = "0x324E110", VA = "0x18324EF10")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600080F")]
				[Cpp2IlInjected.Address(RVA = "0x324F060", Offset = "0x324E260", VA = "0x18324F060")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000810")]
				[Cpp2IlInjected.Address(RVA = "0x324F070", Offset = "0x324E270", VA = "0x18324F070")]
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
			[Cpp2IlInjected.Address(RVA = "0x325ED40", Offset = "0x325DF40", VA = "0x18325ED40", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x325ECE0", Offset = "0x325DEE0", VA = "0x18325ECE0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x325EDE0", Offset = "0x325DFE0", VA = "0x18325EDE0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x325F180", Offset = "0x325E380", VA = "0x18325F180")]
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
			[Cpp2IlInjected.Address(RVA = "0x32600D0", Offset = "0x325F2D0", VA = "0x1832600D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x325FFD0", Offset = "0x325F1D0", VA = "0x18325FFD0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x325FD50", Offset = "0x325EF50", VA = "0x18325FD50")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BF20", Offset = "0x2A4B120", VA = "0x182A4BF20")]
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
				[Cpp2IlInjected.Address(RVA = "0xB2BFD0", Offset = "0xB2B1D0", VA = "0x180B2BFD0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0xB2CF70", Offset = "0xB2C170", VA = "0x180B2CF70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			protected float timer
			{
				[Cpp2IlInjected.Token(Token = "0x600079F")]
				[Cpp2IlInjected.Address(RVA = "0xB7BD80", Offset = "0xB7AF80", VA = "0x180B7BD80")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60007A0")]
				[Cpp2IlInjected.Address(RVA = "0xD2DBE0", Offset = "0xD2CDE0", VA = "0x180D2DBE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			protected Vector3 force
			{
				[Cpp2IlInjected.Token(Token = "0x60007A1")]
				[Cpp2IlInjected.Address(RVA = "0xFE52A0", Offset = "0xFE44A0", VA = "0x180FE52A0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60007A2")]
				[Cpp2IlInjected.Address(RVA = "0xFE3F80", Offset = "0xFE3180", VA = "0x180FE3F80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			protected Vector3 point
			{
				[Cpp2IlInjected.Token(Token = "0x60007A3")]
				[Cpp2IlInjected.Address(RVA = "0xBEE8D0", Offset = "0xBEDAD0", VA = "0x180BEE8D0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60007A4")]
				[Cpp2IlInjected.Address(RVA = "0xD04BD0", Offset = "0xD03DD0", VA = "0x180D04BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x326C130", Offset = "0x326B330", VA = "0x18326C130")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x326BFB0", Offset = "0x326B1B0", VA = "0x18326BFB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x325F180", Offset = "0x325E380", VA = "0x18325F180")]
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
				[Cpp2IlInjected.Address(RVA = "0x326C740", Offset = "0x326B940", VA = "0x18326C740")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000812")]
				[Cpp2IlInjected.Address(RVA = "0x3251510", Offset = "0x3250710", VA = "0x183251510")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000813")]
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x326C8F0", Offset = "0x326BAF0", VA = "0x18326C8F0", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x326C890", Offset = "0x326BA90", VA = "0x18326C890", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x326CB50", Offset = "0x326BD50", VA = "0x18326CB50", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x326CF00", Offset = "0x326C100", VA = "0x18326CF00")]
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
				[Cpp2IlInjected.Address(RVA = "0x326CF20", Offset = "0x326C120", VA = "0x18326CF20")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000815")]
				[Cpp2IlInjected.Address(RVA = "0x326D040", Offset = "0x326C240", VA = "0x18326D040")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000816")]
				[Cpp2IlInjected.Address(RVA = "0x326D050", Offset = "0x326C250", VA = "0x18326D050")]
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
			[Cpp2IlInjected.Address(RVA = "0x326D130", Offset = "0x326C330", VA = "0x18326D130", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x326D0D0", Offset = "0x326C2D0", VA = "0x18326D0D0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0x326D250", Offset = "0x326C450", VA = "0x18326D250", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x325F180", Offset = "0x325E380", VA = "0x18325F180")]
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
		[Cpp2IlInjected.Address(RVA = "0x325FC60", Offset = "0x325EE60", VA = "0x18325FC60", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x325F9E0", Offset = "0x325EBE0", VA = "0x18325F9E0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BF20", Offset = "0x2A4B120", VA = "0x182A4BF20")]
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
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3493DB0", Offset = "0x3492FB0", VA = "0x183493DB0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x3493EB0", Offset = "0x34930B0", VA = "0x183493EB0")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x3494420", Offset = "0x3493620", VA = "0x183494420")]
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
		[Cpp2IlInjected.Address(RVA = "0x3494ED0", Offset = "0x34940D0", VA = "0x183494ED0")]
		public void ResetBodies()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x3494E00", Offset = "0x3494000", VA = "0x183494E00", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BF20", Offset = "0x2A4B120", VA = "0x182A4BF20")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F023A0", Offset = "0x2F015A0", VA = "0x182F023A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x2F021D0", Offset = "0x2F013D0", VA = "0x182F021D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x2F01420", Offset = "0x2F00620", VA = "0x182F01420")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x2F01210", Offset = "0x2F00410", VA = "0x182F01210")]
		private void ApplyMinDistance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x2F01E70", Offset = "0x2F01070", VA = "0x182F01E70")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x2F022F0", Offset = "0x2F014F0", VA = "0x182F022F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F02690", Offset = "0x2F01890", VA = "0x182F02690")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x2F02990", Offset = "0x2F01B90", VA = "0x182F02990")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x2F02AD0", Offset = "0x2F01CD0", VA = "0x182F02AD0")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x2F115B0", Offset = "0x2F107B0", VA = "0x182F115B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2F116F0", Offset = "0x2F108F0", VA = "0x182F116F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xBA36A0", Offset = "0xBA28A0", VA = "0x180BA36A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void OnModifyOffset();

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x2F031E0", Offset = "0x2F023E0", VA = "0x182F031E0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x2F02F80", Offset = "0x2F02180", VA = "0x182F02F80")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x2F02FE0", Offset = "0x2F021E0", VA = "0x182F02FE0")]
		private void ModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x2F02E90", Offset = "0x2F02090", VA = "0x182F02E90")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x2F030F0", Offset = "0x2F022F0", VA = "0x182F030F0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xF757A0", Offset = "0xF749A0", VA = "0x180F757A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C1")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C2")]
			[Cpp2IlInjected.Address(RVA = "0x2F11420", Offset = "0x2F10620", VA = "0x182F11420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007C4")]
			[Cpp2IlInjected.Address(RVA = "0x2F11560", Offset = "0x2F10760", VA = "0x182F11560", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xBA36A0", Offset = "0xBA28A0", VA = "0x180BA36A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void OnModifyOffset();

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x2F02E20", Offset = "0x2F02020", VA = "0x182F02E20", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x2F02BC0", Offset = "0x2F01DC0", VA = "0x182F02BC0")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x2F02C20", Offset = "0x2F01E20", VA = "0x182F02C20")]
		private void ModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x2F02D30", Offset = "0x2F01F30", VA = "0x182F02D30", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xF757A0", Offset = "0xF749A0", VA = "0x180F757A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EFC4F0", Offset = "0x2EFB6F0", VA = "0x182EFC4F0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
			public EffectorLink()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public EffectorLink[] effectorLinks;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x2F03320", Offset = "0x2F02520", VA = "0x182F03320")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x2F03250", Offset = "0x2F02450", VA = "0x182F03250")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x2F03410", Offset = "0x2F02610", VA = "0x182F03410")]
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
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EFAD40", Offset = "0x2EF9F40", VA = "0x182EFAD40")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0x2EFA830", Offset = "0x2EF9A30", VA = "0x182EFA830")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60007CA")]
			[Cpp2IlInjected.Address(RVA = "0x2EFAA40", Offset = "0x2EF9C40", VA = "0x182EFAA40")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0x2EFB180", Offset = "0x2EFA380", VA = "0x182EFB180")]
			public Avoider()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x2F03460", Offset = "0x2F02660", VA = "0x182F03460", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xF757A0", Offset = "0xF749A0", VA = "0x180F757A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F07240", Offset = "0x2F06440", VA = "0x182F07240")]
			public void Start()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0x2F06F30", Offset = "0x2F06130", VA = "0x182F06F30")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0x2F07320", Offset = "0x2F06520", VA = "0x182F07320")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F08BA0", Offset = "0x2F07DA0", VA = "0x182F08BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private IKEffector primaryHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x2F08BC0", Offset = "0x2F07DC0", VA = "0x182F08BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		private IKEffector secondaryHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x2F08C60", Offset = "0x2F07E60", VA = "0x182F08C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		private Transform primaryHand
		{
			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x2F08C10", Offset = "0x2F07E10", VA = "0x182F08C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		private Transform secondaryHand
		{
			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x2F08CB0", Offset = "0x2F07EB0", VA = "0x182F08CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x2F08AC0", Offset = "0x2F07CC0", VA = "0x182F08AC0")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x2F075A0", Offset = "0x2F067A0", VA = "0x182F075A0")]
		public void Fire(float magnitude)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x2F07AF0", Offset = "0x2F06CF0", VA = "0x182F07AF0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x2F07390", Offset = "0x2F06590", VA = "0x182F07390")]
		private void AfterFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x2F07340", Offset = "0x2F06540", VA = "0x182F07340")]
		private void AfterAimIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x2F07870", Offset = "0x2F06A70", VA = "0x182F07870", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x2F08AF0", Offset = "0x2F07CF0", VA = "0x182F08AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0F470", Offset = "0x2F0E670", VA = "0x182F0F470")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F370", Offset = "0x2F0E570", VA = "0x182F0F370")]
		private void RotateShoulders()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x2F0EDE0", Offset = "0x2F0DFE0", VA = "0x182F0EDE0")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x2F0ECB0", Offset = "0x2F0DEB0", VA = "0x182F0ECB0")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x2F0ECF0", Offset = "0x2F0DEF0", VA = "0x182F0ECF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F560", Offset = "0x2F0E760", VA = "0x182F0F560")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F0EBA0", Offset = "0x2F0DDA0", VA = "0x182F0EBA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2F0FB70", Offset = "0x2F0ED70", VA = "0x182F0FB70")]
				public Target(Transform t)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600081B")]
				[Cpp2IlInjected.Address(RVA = "0x2F0FB00", Offset = "0x2F0ED00", VA = "0x182F0FB00")]
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
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
			public CalibrationData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x2F16ED0", Offset = "0x2F160D0", VA = "0x182F16ED0")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x2F16F50", Offset = "0x2F16150", VA = "0x182F16F50")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x2F13900", Offset = "0x2F12B00", VA = "0x182F13900")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x2F13920", Offset = "0x2F12B20", VA = "0x182F13920")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x2F14BB0", Offset = "0x2F13DB0", VA = "0x182F14BB0")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x2F12FA0", Offset = "0x2F121A0", VA = "0x182F12FA0")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x2F13D70", Offset = "0x2F12F70", VA = "0x182F13D70")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x2F12D70", Offset = "0x2F11F70", VA = "0x182F12D70")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x2F13B30", Offset = "0x2F12D30", VA = "0x182F13B30")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x2F127A0", Offset = "0x2F119A0", VA = "0x182F127A0")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x2F11C00", Offset = "0x2F10E00", VA = "0x182F11C00")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x2F124D0", Offset = "0x2F116D0", VA = "0x182F124D0")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x2F11F40", Offset = "0x2F11140", VA = "0x182F11F40")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x2F16CC0", Offset = "0x2F15EC0", VA = "0x182F16CC0")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x2F167E0", Offset = "0x2F159E0", VA = "0x182F167E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F17180", Offset = "0x2F16380", VA = "0x182F17180")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x2F171C0", Offset = "0x2F163C0", VA = "0x182F171C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x2F16FC0", Offset = "0x2F161C0", VA = "0x182F16FC0")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x2F173A0", Offset = "0x2F165A0", VA = "0x182F173A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x11CBBF0", Offset = "0x11CADF0", VA = "0x1811CBBF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x11CBB30", Offset = "0x11CAD30", VA = "0x1811CBB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x2F173C0", Offset = "0x2F165C0", VA = "0x182F173C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x2F174A0", Offset = "0x2F166A0", VA = "0x182F174A0")]
		public void Calibrate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x2F176F0", Offset = "0x2F168F0", VA = "0x182F176F0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2F17980", Offset = "0x2F16B80", VA = "0x182F17980")]
		private void OnPreUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2F17890", Offset = "0x2F16A90", VA = "0x182F17890")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F88350", Offset = "0x2F87550", VA = "0x182F88350")]
			public void Apply(Animator animator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F85110", Offset = "0x2F84310", VA = "0x182F85110")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x2F84E40", Offset = "0x2F84040", VA = "0x182F84E40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x2F85030", Offset = "0x2F84230", VA = "0x182F85030")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6B480", Offset = "0x2F6A680", VA = "0x182F6B480")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6B540", Offset = "0x2F6A740", VA = "0x182F6B540")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x2F6B680", Offset = "0x2F6A880", VA = "0x182F6B680")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A63280", Offset = "0x2A62480", VA = "0x182A63280")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x2A62F90", Offset = "0x2A62190", VA = "0x182A62F90")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A63B70", Offset = "0x2A62D70", VA = "0x182A63B70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x2A633B0", Offset = "0x2A625B0", VA = "0x182A633B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x2A63780", Offset = "0x2A62980", VA = "0x182A63780")]
		private void Pose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x2A634F0", Offset = "0x2A626F0", VA = "0x182A634F0")]
		private void LimitAimTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x2A632C0", Offset = "0x2A624C0", VA = "0x182A632C0")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2A63BB0", Offset = "0x2A62DB0", VA = "0x182A63BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A64C50", Offset = "0x2A63E50", VA = "0x182A64C50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x2A64990", Offset = "0x2A63B90", VA = "0x182A64990")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x2A64F40", Offset = "0x2A64140", VA = "0x182A64F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F72300", Offset = "0x2F71500", VA = "0x182F72300")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x2F72A80", Offset = "0x2F71C80", VA = "0x182F72A80")]
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
			[Cpp2IlInjected.Address(RVA = "0x1BAB680", Offset = "0x1BAA880", VA = "0x181BAB680")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x1BAB760", Offset = "0x1BAA960", VA = "0x181BAB760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D7A0", Offset = "0x2A5C9A0", VA = "0x182A5D7A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D7E0", Offset = "0x2A5C9E0", VA = "0x182A5D7E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D0F0", Offset = "0x2A5C2F0", VA = "0x182A5D0F0")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D310", Offset = "0x2A5C510", VA = "0x182A5D310")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2A5E180", Offset = "0x2A5D380", VA = "0x182A5E180")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A5B500", Offset = "0x2A5A700", VA = "0x182A5B500")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x2A5B160", Offset = "0x2A5A360", VA = "0x182A5B160")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x2A5B4E0", Offset = "0x2A5A6E0", VA = "0x182A5B4E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0x2A66010", Offset = "0x2A65210", VA = "0x182A66010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x2A66590", Offset = "0x2A65790", VA = "0x182A66590", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A5CBB0", Offset = "0x2A5BDB0", VA = "0x182A5CBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x2A5CBD0", Offset = "0x2A5BDD0", VA = "0x182A5CBD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x2A5CC30", Offset = "0x2A5BE30", VA = "0x182A5CC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2A5B800", Offset = "0x2A5AA00", VA = "0x182A5B800")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2A5B580", Offset = "0x2A5A780", VA = "0x182A5B580")]
		private void AfterIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2A5BF70", Offset = "0x2A5B170", VA = "0x182A5BF70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2A5BA70", Offset = "0x2A5AC70", VA = "0x182A5BA70")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2A5C440", Offset = "0x2A5B640", VA = "0x182A5C440")]
		private void UpdatePosition(float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2A5C780", Offset = "0x2A5B980", VA = "0x182A5C780")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2A5C3A0", Offset = "0x2A5B5A0", VA = "0x182A5C3A0")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x2A5CB00", Offset = "0x2A5BD00", VA = "0x182A5CB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A5CC80", Offset = "0x2A5BE80", VA = "0x182A5CC80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x2A5CD30", Offset = "0x2A5BF30", VA = "0x182A5CD30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6BF40", Offset = "0x2F6B140", VA = "0x182F6BF40", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x2F6B6F0", Offset = "0x2F6A8F0", VA = "0x182F6B6F0")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x2F6BA20", Offset = "0x2F6AC20", VA = "0x182F6BA20", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x2F6B970", Offset = "0x2F6AB70", VA = "0x182F6B970")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BF20", Offset = "0x2A4B120", VA = "0x182A4BF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6D8A0", Offset = "0x2F6CAA0", VA = "0x182F6D8A0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D5E0", Offset = "0x2F6C7E0", VA = "0x182F6D5E0")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D300", Offset = "0x2F6C500", VA = "0x182F6D300", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D8E0", Offset = "0x2F6CAE0", VA = "0x182F6D8E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F6D0C0", Offset = "0x2F6C2C0", VA = "0x182F6D0C0", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x2F6C710", Offset = "0x2F6B910", VA = "0x182F6C710", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2F6CF10", Offset = "0x2F6C110", VA = "0x182F6CF10")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x2F6BF60", Offset = "0x2F6B160", VA = "0x182F6BF60")]
		private void AimIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2F6BFC0", Offset = "0x2F6B1C0", VA = "0x182F6BFC0")]
		private void FBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x2F6CB10", Offset = "0x2F6BD10", VA = "0x182F6CB10")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x2F6C470", Offset = "0x2F6B670", VA = "0x182F6C470")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x2F6CA00", Offset = "0x2F6BC00", VA = "0x182F6CA00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D2D0", Offset = "0x2F6C4D0", VA = "0x182F6D2D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7DBA0", Offset = "0x2F7CDA0", VA = "0x182F7DBA0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D6A0", Offset = "0x2F7C8A0", VA = "0x182F7D6A0", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D9A0", Offset = "0x2F7CBA0", VA = "0x182F7D9A0")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2F7DC60", Offset = "0x2F7CE60", VA = "0x182F7DC60")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F7F770", Offset = "0x2F7E970", VA = "0x182F7F770")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private static Vector3 inputVectorRaw
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x2F7F6F0", Offset = "0x2F7E8F0", VA = "0x182F7F6F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F690", Offset = "0x2F7E890", VA = "0x182F7F690")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F2D0", Offset = "0x2F7E4D0", VA = "0x182F7F2D0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F82D70", Offset = "0x2F81F70", VA = "0x182F82D70", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BF20", Offset = "0x2A4B120", VA = "0x182A4BF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F83760", Offset = "0x2F82960", VA = "0x182F83760")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2F837F0", Offset = "0x2F829F0", VA = "0x182F837F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x2F836A0", Offset = "0x2F828A0", VA = "0x182F836A0")]
		private void SetEffectorWeights(float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2F83EC0", Offset = "0x2F830C0", VA = "0x182F83EC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F882D0", Offset = "0x2F874D0", VA = "0x182F882D0")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0xEF24D0", Offset = "0xEF16D0", VA = "0x180EF24D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F83FD0", Offset = "0x2F831D0", VA = "0x182F83FD0")]
		public void UpdateSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x2F83F50", Offset = "0x2F83150", VA = "0x182F83F50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x2F84150", Offset = "0x2F83350", VA = "0x182F84150")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x2F84160", Offset = "0x2F83360", VA = "0x182F84160")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F84170", Offset = "0x2F83370", VA = "0x182F84170")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x2F841C0", Offset = "0x2F833C0", VA = "0x182F841C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F84490", Offset = "0x2F83690", VA = "0x182F84490")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2F84290", Offset = "0x2F83490", VA = "0x182F84290")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F844D0", Offset = "0x2F836D0", VA = "0x182F844D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x2F84DA0", Offset = "0x2F83FA0", VA = "0x182F84DA0")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x2F845B0", Offset = "0x2F837B0", VA = "0x182F845B0")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2F84CA0", Offset = "0x2F83EA0", VA = "0x182F84CA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F867B0", Offset = "0x2F859B0", VA = "0x182F867B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2F855A0", Offset = "0x2F847A0", VA = "0x182F855A0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2F855B0", Offset = "0x2F847B0", VA = "0x182F855B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2F85150", Offset = "0x2F84350", VA = "0x182F85150")]
		private void Aiming()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2F856D0", Offset = "0x2F848D0", VA = "0x182F856D0")]
		private void LookDownTheSight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x2F86450", Offset = "0x2F85650", VA = "0x182F86450")]
		private void RotateCharacter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x2F86990", Offset = "0x2F85B90", VA = "0x182F86990")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F86A70", Offset = "0x2F85C70", VA = "0x182F86A70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x2F86AC0", Offset = "0x2F85CC0", VA = "0x182F86AC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x2F869C0", Offset = "0x2F85BC0", VA = "0x182F869C0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xEEF1F0", Offset = "0xEEE3F0", VA = "0x180EEF1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F86E20", Offset = "0x2F86020", VA = "0x182F86E20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x2F86D80", Offset = "0x2F85F80", VA = "0x182F86D80")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xC00840", Offset = "0xBFFA40", VA = "0x180C00840")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F877E0", Offset = "0x2F869E0", VA = "0x182F877E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x2F87340", Offset = "0x2F86540", VA = "0x182F87340")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x2F879A0", Offset = "0x2F86BA0", VA = "0x182F879A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F87B60", Offset = "0x2F86D60", VA = "0x182F87B60")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x2F879B0", Offset = "0x2F86BB0", VA = "0x182F879B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F87C00", Offset = "0x2F86E00", VA = "0x182F87C00")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F87F40", Offset = "0x2F87140", VA = "0x182F87F40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x2F87F80", Offset = "0x2F87180", VA = "0x182F87F80")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
				[Cpp2IlInjected.Address(RVA = "0x2F89130", Offset = "0x2F88330", VA = "0x182F89130")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007DB")]
			[Cpp2IlInjected.Address(RVA = "0x2A52040", Offset = "0x2A51240", VA = "0x182A52040")]
			public void Initiate()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DC")]
			[Cpp2IlInjected.Address(RVA = "0x2F88710", Offset = "0x2F87910", VA = "0x182F88710")]
			public void Update(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DE")]
			[Cpp2IlInjected.Address(RVA = "0x2F884E0", Offset = "0x2F876E0", VA = "0x182F884E0")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0x2F89100", Offset = "0x2F88300", VA = "0x182F89100")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F88200", Offset = "0x2F87400", VA = "0x182F88200")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x2F881A0", Offset = "0x2F873A0", VA = "0x182F881A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x2F88250", Offset = "0x2F87450", VA = "0x182F88250")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A4A080", Offset = "0x2A49280", VA = "0x182A4A080")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x2A4A1B0", Offset = "0x2A493B0", VA = "0x182A4A1B0")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x2A49D80", Offset = "0x2A48F80", VA = "0x182A49D80")]
			public void SetPosition(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x2A49F50", Offset = "0x2A49150", VA = "0x182A49F50")]
			public void SetRotation(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x2A4A1F0", Offset = "0x2A493F0", VA = "0x182A4A1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A5ECD0", Offset = "0x2A5DED0", VA = "0x182A5ECD0", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x2A5E6B0", Offset = "0x2A5D8B0", VA = "0x182A5E6B0")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x2A5E980", Offset = "0x2A5DB80", VA = "0x182A5E980", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x2A5E4E0", Offset = "0x2A5D6E0", VA = "0x182A5E4E0")]
		private void AfterIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x2A5E880", Offset = "0x2A5DA80", VA = "0x182A5E880", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x2A5EDA0", Offset = "0x2A5DFA0", VA = "0x182A5EDA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A5E1D0", Offset = "0x2A5D3D0", VA = "0x182A5E1D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x2A5E420", Offset = "0x2A5D620", VA = "0x182A5E420")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x2A5E240", Offset = "0x2A5D440", VA = "0x182A5E240")]
		private void SwingStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x1605530", Offset = "0x1604730", VA = "0x181605530")]
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
			[Cpp2IlInjected.Address(RVA = "0x2677300", Offset = "0x2676500", VA = "0x182677300")]
			public EffectorLink()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public EffectorLink[] effectorLinks;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x2A5FE00", Offset = "0x2A5F000", VA = "0x182A5FE00", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A5FAB0", Offset = "0x2A5ECB0", VA = "0x182A5FAB0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BF20", Offset = "0x2A4B120", VA = "0x182A4BF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A609E0", Offset = "0x2A5FBE0", VA = "0x182A609E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A60090", Offset = "0x2A5F290", VA = "0x182A60090")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A60DA0", Offset = "0x2A5FFA0", VA = "0x182A60DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A61B50", Offset = "0x2A60D50", VA = "0x182A61B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private bool holdingLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A61A10", Offset = "0x2A60C10", VA = "0x182A61A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private bool holdingRight
		{
			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x2A61AB0", Offset = "0x2A60CB0", VA = "0x182A61AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x2A613B0", Offset = "0x2A605B0", VA = "0x182A613B0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void RotatePivot();

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A61860", Offset = "0x2A60A60", VA = "0x182A61860")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x2A615E0", Offset = "0x2A607E0", VA = "0x182A615E0")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x2A61780", Offset = "0x2A60980", VA = "0x182A61780")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A61270", Offset = "0x2A60470", VA = "0x182A61270")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x2A60E20", Offset = "0x2A60020", VA = "0x182A60E20")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x2A61090", Offset = "0x2A60290", VA = "0x182A61090")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A61A00", Offset = "0x2A60C00", VA = "0x182A61A00")]
		protected PickUp2Handed()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class PickUpBox : PickUp2Handed
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A61B80", Offset = "0x2A60D80", VA = "0x182A61B80", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A61A00", Offset = "0x2A60C00", VA = "0x182A61A00")]
		public PickUpBox()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public class PickUpSphere : PickUp2Handed
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A61E40", Offset = "0x2A61040", VA = "0x182A61E40", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A61A00", Offset = "0x2A60C00", VA = "0x182A61A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A62A70", Offset = "0x2A61C70", VA = "0x182A62A70")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A62AC0", Offset = "0x2A61CC0", VA = "0x182A62AC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A62D30", Offset = "0x2A61F30", VA = "0x182A62D30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x2A62D70", Offset = "0x2A61F70", VA = "0x182A62D70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A62CE0", Offset = "0x2A61EE0", VA = "0x182A62CE0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xF757A0", Offset = "0xF749A0", VA = "0x180F757A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x2A65DF0", Offset = "0x2A64FF0", VA = "0x182A65DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0x2A65FC0", Offset = "0x2A651C0", VA = "0x182A65FC0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A62ED0", Offset = "0x2A620D0", VA = "0x182A62ED0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A62DC0", Offset = "0x2A61FC0", VA = "0x182A62DC0")]
		private void OnPickUp(Transform t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A62E60", Offset = "0x2A62060", VA = "0x182A62E60")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xF757A0", Offset = "0xF749A0", VA = "0x180F757A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0x2A65C50", Offset = "0x2A64E50", VA = "0x182A65C50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x2A65DA0", Offset = "0x2A64FA0", VA = "0x182A65DA0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A64890", Offset = "0x2A63A90", VA = "0x182A64890")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A64830", Offset = "0x2A63A30", VA = "0x182A64830")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A50B80", Offset = "0x2A4FD80", VA = "0x182A50B80")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x2A50A50", Offset = "0x2A4FC50", VA = "0x182A50A50")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x2A51260", Offset = "0x2A50460", VA = "0x182A51260")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x2A510B0", Offset = "0x2A502B0", VA = "0x182A510B0")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x2A50FB0", Offset = "0x2A501B0", VA = "0x182A50FB0")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x2A50F30", Offset = "0x2A50130", VA = "0x182A50F30")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x2A51030", Offset = "0x2A50230", VA = "0x182A51030")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x2A508B0", Offset = "0x2A4FAB0", VA = "0x182A508B0")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x2A51B80", Offset = "0x2A50D80", VA = "0x182A51B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A65100", Offset = "0x2A64300", VA = "0x182A65100")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A64FB0", Offset = "0x2A641B0", VA = "0x182A64FB0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A65030", Offset = "0x2A64230", VA = "0x182A65030")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A65170", Offset = "0x2A64370", VA = "0x182A65170")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x2A651B0", Offset = "0x2A643B0", VA = "0x182A651B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A65370", Offset = "0x2A64570", VA = "0x182A65370")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A65A90", Offset = "0x2A64C90", VA = "0x182A65A90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A65630", Offset = "0x2A64830", VA = "0x182A65630")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A65530", Offset = "0x2A64730", VA = "0x182A65530")]
		private void AfterFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A659A0", Offset = "0x2A64BA0", VA = "0x182A659A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A66F20", Offset = "0x2A66120", VA = "0x182A66F20", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A66DE0", Offset = "0x2A65FE0", VA = "0x182A66DE0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A67040", Offset = "0x2A66240", VA = "0x182A67040")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F86C80", Offset = "0x2F85E80", VA = "0x182F86C80")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x2F86BF0", Offset = "0x2F85DF0", VA = "0x182F86BF0")]
		public void Activate(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FD")]
			[Cpp2IlInjected.Address(RVA = "0x2A665E0", Offset = "0x2A657E0", VA = "0x182A665E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0x2A66770", Offset = "0x2A65970", VA = "0x182A66770", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A62500", Offset = "0x2A61700", VA = "0x182A62500")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A62080", Offset = "0x2A61280", VA = "0x182A62080")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A62670", Offset = "0x2A61870", VA = "0x182A62670")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x2A62370", Offset = "0x2A61570", VA = "0x182A62370")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A62440", Offset = "0x2A61640", VA = "0x182A62440")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A626D0", Offset = "0x2A618D0", VA = "0x182A626D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F722B0", Offset = "0x2F714B0", VA = "0x182F722B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2F721E0", Offset = "0x2F713E0", VA = "0x182F721E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xC00840", Offset = "0xBFFA40", VA = "0x180C00840")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A5FF50", Offset = "0x2A5F150", VA = "0x182A5FF50")]
			public void AimAt(Transform target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A65380", Offset = "0x2A64580", VA = "0x182A65380")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F87100", Offset = "0x2F86300", VA = "0x182F87100")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2F87060", Offset = "0x2F86260", VA = "0x182F87060")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xC00840", Offset = "0xBFFA40", VA = "0x180C00840")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A67470", Offset = "0x2A66670", VA = "0x182A67470")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A67670", Offset = "0x2A66870", VA = "0x182A67670")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A676D0", Offset = "0x2A668D0", VA = "0x182A676D0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A67870", Offset = "0x2A66A70", VA = "0x182A67870")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A68210", Offset = "0x2A67410", VA = "0x182A68210")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A67FA0", Offset = "0x2A671A0", VA = "0x182A67FA0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A68280", Offset = "0x2A67480", VA = "0x182A68280")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A678D0", Offset = "0x2A66AD0", VA = "0x182A678D0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A67F30", Offset = "0x2A67130", VA = "0x182A67F30")]
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
			[Cpp2IlInjected.Address(RVA = "0x46FF60", Offset = "0x46F160", VA = "0x18046FF60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xBD0D90", Offset = "0xBCFF90", VA = "0x180BD0D90", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x2F7CD50", Offset = "0x2F7BF50", VA = "0x182F7CD50")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D140", Offset = "0x2F7C340", VA = "0x182F7D140", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2F7CE10", Offset = "0x2F7C010", VA = "0x182F7CE10", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2F7CD40", Offset = "0x2F7BF40", VA = "0x182F7CD40", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2F7CE20", Offset = "0x2F7C020", VA = "0x182F7CE20")]
		private void SmoothFollow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D2D0", Offset = "0x2F7C4D0", VA = "0x182F7D2D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7D490", Offset = "0x2F7C690", VA = "0x182F7D490", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D2F0", Offset = "0x2F7C4F0", VA = "0x182F7D2F0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D4E0", Offset = "0x2F7C6E0", VA = "0x182F7D4E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D2D0", Offset = "0x2F7C4D0", VA = "0x182F7D2D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F7E490", Offset = "0x2F7D690", VA = "0x182F7E490", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x2F7DE90", Offset = "0x2F7D090", VA = "0x182F7DE90", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x2F7DC90", Offset = "0x2F7CE90", VA = "0x182F7DC90", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2F7DF20", Offset = "0x2F7D120", VA = "0x182F7DF20", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2F7DCD0", Offset = "0x2F7CED0", VA = "0x182F7DCD0")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2F7DC60", Offset = "0x2F7CE60", VA = "0x182F7DC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F7E640", Offset = "0x2F7D840", VA = "0x182F7E640")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F0D0", Offset = "0x2F7E2D0", VA = "0x182F7F0D0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x2F7E920", Offset = "0x2F7DB20", VA = "0x182F7E920", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x2F7E580", Offset = "0x2F7D780", VA = "0x182F7E580")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x2F7ECA0", Offset = "0x2F7DEA0", VA = "0x182F7ECA0")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x2F7EEB0", Offset = "0x2F7E0B0", VA = "0x182F7EEB0")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x2F7EC70", Offset = "0x2F7DE70", VA = "0x182F7EC70")]
		protected void HighFriction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F270", Offset = "0x2F7E470", VA = "0x182F7F270")]
		protected void ZeroFriction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x2F7E810", Offset = "0x2F7DA10", VA = "0x182F7E810")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F2A0", Offset = "0x2F7E4A0", VA = "0x182F7F2A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x2F891A0", Offset = "0x2F883A0", VA = "0x182F891A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000807")]
			[Cpp2IlInjected.Address(RVA = "0x2F892F0", Offset = "0x2F884F0", VA = "0x182F892F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x52A1D0", Offset = "0x5293D0", VA = "0x18052A1D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xE79F30", Offset = "0xE79130", VA = "0x180E79F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2F81F70", Offset = "0x2F81170", VA = "0x182F81F70", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2F81940", Offset = "0x2F80B40", VA = "0x182F81940")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x2F81800", Offset = "0x2F80A00", VA = "0x182F81800", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F890", Offset = "0x2F7EA90", VA = "0x182F7F890")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2F820F0", Offset = "0x2F812F0", VA = "0x182F820F0", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2F81050", Offset = "0x2F80250", VA = "0x182F81050", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2F81130", Offset = "0x2F80330", VA = "0x182F81130")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2F821F0", Offset = "0x2F813F0", VA = "0x182F821F0")]
		private void WallRun()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2F7F7F0", Offset = "0x2F7E9F0", VA = "0x182F7F7F0")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2F80400", Offset = "0x2F7F600", VA = "0x182F80400")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x2F819E0", Offset = "0x2F80BE0", VA = "0x182F819E0", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2F801E0", Offset = "0x2F7F3E0", VA = "0x182F801E0")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2F80D70", Offset = "0x2F7FF70", VA = "0x182F80D70", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2F80CF0", Offset = "0x2F7FEF0", VA = "0x182F80CF0")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__75))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2F807C0", Offset = "0x2F7F9C0", VA = "0x182F807C0")]
		private void GroundCheck()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2F82B00", Offset = "0x2F81D00", VA = "0x182F82B00")]
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
			[Cpp2IlInjected.Address(RVA = "0x499190", Offset = "0x498390", VA = "0x180499190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x9D4D30", Offset = "0x9D3F30", VA = "0x1809D4D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2A645C0", Offset = "0x2A637C0", VA = "0x182A645C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2A64630", Offset = "0x2A63830", VA = "0x182A64630")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x2A63D60", Offset = "0x2A62F60", VA = "0x182A63D60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2A640C0", Offset = "0x2A632C0", VA = "0x182A640C0")]
		private void Rotate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x2A63DA0", Offset = "0x2A62FA0", VA = "0x182A63DA0")]
		private void Move()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2A63C50", Offset = "0x2A62E50", VA = "0x182A63C50")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2A63BD0", Offset = "0x2A62DD0", VA = "0x182A63BD0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2A64690", Offset = "0x2A63890", VA = "0x182A64690")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A66990", Offset = "0x2A65B90", VA = "0x182A66990", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2A66A80", Offset = "0x2A65C80", VA = "0x182A66A80", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x2A66960", Offset = "0x2A65B60", VA = "0x182A66960")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2A66DC0", Offset = "0x2A65FC0", VA = "0x182A66DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A67060", Offset = "0x2A66260", VA = "0x182A67060", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2A67090", Offset = "0x2A66290", VA = "0x182A67090", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2A67460", Offset = "0x2A66660", VA = "0x182A67460")]
		public UserControlThirdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D910", Offset = "0x2F6CB10", VA = "0x182F6D910")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A64760", Offset = "0x2A63960", VA = "0x182A64760")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x2A646B0", Offset = "0x2A638B0", VA = "0x182A646B0")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x2A64820", Offset = "0x2A63A20", VA = "0x182A64820")]
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
			[Cpp2IlInjected.Address(RVA = "0x11CBB40", Offset = "0x11CAD40", VA = "0x1811CBB40")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x11CBB60", Offset = "0x11CAD60", VA = "0x1811CBB60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public State state
		{
			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x4991B0", Offset = "0x4983B0", VA = "0x1804991B0")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x4BE360", Offset = "0x4BD560", VA = "0x1804BE360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x2A5F100", Offset = "0x2A5E300", VA = "0x182A5F100")]
		public void Initiate(Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x2A5F220", Offset = "0x2A5E420", VA = "0x182A5F220")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x2A5EDB0", Offset = "0x2A5DFB0", VA = "0x182A5EDB0")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x2A5EE20", Offset = "0x2A5E020", VA = "0x182A5EE20")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x2A5F1B0", Offset = "0x2A5E3B0", VA = "0x182A5F1B0")]
		private void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x2A5F040", Offset = "0x2A5E240", VA = "0x182A5F040")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x2A5F7A0", Offset = "0x2A5E9A0", VA = "0x182A5F7A0")]
		public void Visualize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x2A5FA40", Offset = "0x2A5EC40", VA = "0x182A5FA40")]
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
