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
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum IconType
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		GameObject,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Favorite,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Prefab,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		GameManager,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Dragdot,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		DragdotActive,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		DragdotDimmed,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Dropdown,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		d_winbtn_mac_close,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		d_winbtn_mac_close_a,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		d_winbtn_mac_close_h,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		d_winbtn_mac_inact,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		d_winbtn_mac_max,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		d_winbtn_mac_max_h,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		d_winbtn_mac_min,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		d_winbtn_mac_min_h,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		d_winbtn_win_close,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		DefaultAsset,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		DllScript,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		DistanceJoint2D,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		FilterByLabel,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		FilterByType,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Fixedjoint,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		FlareLayer,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		FrictionJoint2D,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		GUIText,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		HingeJoint2D,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Image,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		LightProbeProxyVolume,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		LightProbeGroup,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		LineRenderer,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		LayoutElement,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		LensFlare
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Dictionary<IconType, string> m_internalIcons;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x160A540", Offset = "0x1608B40", VA = "0x18160A540")]
	public static string GetInternalStringPathOfEnumValue(IconType type)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum SA_PD_MessageType
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Info,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Error
}
namespace SA.Foundation.EditorStylesCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class SA_ESC_PropertyDrawerExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		[Multiline]
		[Space]
		[Header("Unity Default Property Drawers")]
		[Space(10f)]
		private string m_multilineString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[TextArea]
		public string m_textAreaString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		[Range(0f, 100f)]
		private int m_intRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_floatRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		[Tooltip("Health value between 0 and 100.")]
		private float m_hoverMouseToSeeTooltip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Space]
		[Header("Sliders")]
		[Space(10f)]
		public float m_simpleSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SA_PD_MinMaxSlider(0f, 3f, 255f, 0f, 0f)]
		public Vector2 m_MinMaxSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Header("Help Boxes with text message")]
		[SA_PD_HelpBox(SA_PD_MessageType.Info)]
		public string myHelpBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SA_PD_HelpBox(SA_PD_MessageType.Warning)]
		public string myString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Space]
		[SA_PD_PRInsertionDecorator]
		[SA_PD_ThingInsertionDecorator]
		[Space]
		[SA_PD_StandartInsertionDecorator]
		[Space]
		[Space]
		[Space(10f)]
		[SA_PD_HelpboxDecorator(SA_PD_MessageType.Info, "Pre-defined text")]
		[Header("Help Boxes Decorators")]
		[SA_PD_HelpboxDecorator(SA_PD_MessageType.None, "")]
		[Space(10f)]
		[Header("Insertions")]
		[Header("Headers")]
		[SA_PD_HeaderDecorator("Indent Header")]
		[Header("Indent level")]
		[Space(10f)]
		[SA_PD_IndentLevel(1)]
		[Space(10f)]
		public string indentLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SA_PD_IndentLevel(2)]
		public string indentLevel1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SA_PD_IndentLevel(0)]
		public string indentLevel2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Space]
		[Header("Conditional Hide / Show fields")]
		[Space(10f)]
		public bool showBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public bool isExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public AnimationCurve curve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Space]
		[Header("Conditional Disable / Enable fields")]
		[Space(10f)]
		public bool enableBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SA_PD_Conditional("enableBelowSettings")]
		public bool firstSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SA_PD_Conditional("enableBelowSettings")]
		public float secondSettigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Space]
		[Header("Label with Icon")]
		[Space(10f)]
		[SA_PD_LabelWithIcon("Plugins/StansAssets/Support2018/Modules/Editor/EditorStylesCollection/Resources/Icons/gameObjectIcon.png")]
		public string myLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SA_PD_LabelWithIcon(SA_PD_EditorIcons.IconType.Light)]
		public string favoriteLabel;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x160A360", Offset = "0x1608960", VA = "0x18160A360")]
		public SA_ESC_PropertyDrawerExample()
		{
		}
	}
}
namespace SA.Foundation.PropertyDrawers.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_ConditionalAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string m_conditionalSourceField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool m_hideInInspector;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string ConditionalSourceField
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8C3430", Offset = "0x8C1A30", VA = "0x1808C3430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x160A4C0", Offset = "0x1608AC0", VA = "0x18160A4C0")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x160A430", Offset = "0x1608A30", VA = "0x18160A430")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField, bool hideInInspector)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_HelpBoxAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x966BE0", Offset = "0x9651E0", VA = "0x180966BE0")]
		public SA_PD_HelpBoxAttribute(SA_PD_MessageType type)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_IndentLevelAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int m_indentLevel;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int IndentLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x966BE0", Offset = "0x9651E0", VA = "0x180966BE0")]
		public SA_PD_IndentLevelAttribute(int indentLevel)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_LabelWithIconAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string m_iconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private string m_internalIconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private SA_PD_EditorIcons.IconType m_iconType;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string IconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x160AE30", Offset = "0x1609430", VA = "0x18160AE30")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x160AC60", Offset = "0x1609260", VA = "0x18160AC60")]
		public SA_PD_LabelWithIconAttribute(SA_PD_EditorIcons.IconType icon)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_MinMaxSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9F86F0", Offset = "0x9F6CF0", VA = "0x1809F86F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA24840", Offset = "0xA22E40", VA = "0x180A24840")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x783BB0", Offset = "0x7821B0", VA = "0x180783BB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x160AED0", Offset = "0x16094D0", VA = "0x18160AED0")]
		public SA_PD_MinMaxSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_SimpleSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9F86F0", Offset = "0x9F6CF0", VA = "0x1809F86F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA24840", Offset = "0xA22E40", VA = "0x180A24840")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x783BB0", Offset = "0x7821B0", VA = "0x180783BB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x160AED0", Offset = "0x16094D0", VA = "0x18160AED0")]
		public SA_PD_SimpleSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class SA_PD_HeaderDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private string m_text;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x14BCD50", Offset = "0x14BB350", VA = "0x1814BCD50")]
		public SA_PD_HeaderDecoratorAttribute(string text)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_HelpboxDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private string m_message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x70F350", Offset = "0x70D950", VA = "0x18070F350")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x160AC20", Offset = "0x1609220", VA = "0x18160AC20")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0")]
		public SA_PD_ThingInsertionDecoratorAttribute()
		{
		}
	}
}
namespace RootMotion
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public enum Mode
		{
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			AnimationClips,
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			AnimationStates,
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			PlayableDirector,
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Realtime
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		[Range(1f, 90f)]
		public int frameRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		[Range(0f, 0.1f)]
		public float keyReductionError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Sets the baked animation clip to loop time and matches the last frame keys with the first. Note that when overwriting a previously baked clip, AnimationClipSettings will be copied from the existing clip.")]
		public bool loop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HideInInspector]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HideInInspector]
		public PlayableDirector director;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool isBaking
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x728EA0", Offset = "0x7274A0", VA = "0x180728EA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x728EF0", Offset = "0x7274F0", VA = "0x180728EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float bakingProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x18FEC20", Offset = "0x18FD220", VA = "0x1818FEC20")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x17DF020", Offset = "0x17DD620", VA = "0x1817DF020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected float clipLength
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x155BBE0", Offset = "0x155A1E0", VA = "0x18155BBE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x15AEE00", Offset = "0x15AD400", VA = "0x1815AEE00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x18FEAB0", Offset = "0x18FD0B0", VA = "0x1818FEAB0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x18FEA70", Offset = "0x18FD070", VA = "0x1818FEA70")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x18FEAF0", Offset = "0x18FD0F0", VA = "0x1818FEAF0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x18FEA30", Offset = "0x18FD030", VA = "0x1818FEA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public void BakeClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public void StartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public void StopBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x18FEB30", Offset = "0x18FD130", VA = "0x1818FEB30")]
		protected Baker()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class GenericBaker : Baker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private BakerTransform[] children;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private BakerTransform rootChild;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int rootChildIndex;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1970DB0", Offset = "0x196F3B0", VA = "0x181970DB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83C540", Offset = "0x83AB40", VA = "0x18083C540", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1971480", Offset = "0x196FA80", VA = "0x181971480", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x19713E0", Offset = "0x196F9E0", VA = "0x1819713E0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x19712A0", Offset = "0x196F8A0", VA = "0x1819712A0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1971340", Offset = "0x196F940", VA = "0x181971340", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x19711C0", Offset = "0x196F7C0", VA = "0x1819711C0")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x19710E0", Offset = "0x196F6E0", VA = "0x1819710E0")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x19715E0", Offset = "0x196FBE0", VA = "0x1819715E0")]
		public GenericBaker()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class TQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Vector3 t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Quaternion q;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x160D3C0", Offset = "0x160B9C0", VA = "0x18160D3C0")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AvatarUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x18FA500", Offset = "0x18F8B00", VA = "0x1818FA500")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x18F9D30", Offset = "0x18F8330", VA = "0x1818F9D30")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x18FA7A0", Offset = "0x18F8DA0", VA = "0x1818FA7A0")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public AvatarUtility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class BakerUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x18FE740", Offset = "0x18FCD40", VA = "0x1818FE740")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x18FE1F0", Offset = "0x18FC7F0", VA = "0x1818FE1F0")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x18FE780", Offset = "0x18FCD80", VA = "0x1818FE780")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x18FDF40", Offset = "0x18FC540", VA = "0x1818FDF40")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class BakerHumanoidQT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private string Qx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private string Qy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private string Qz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private string Qw;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private string Tx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private string Ty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private string Tz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AnimationCurve rotX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AnimationCurve rotY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AnimationCurve rotZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AnimationCurve rotW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AnimationCurve posX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AnimationCurve posY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AnimationCurve posZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private AvatarIKGoal goal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Quaternion lastQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private bool lastQSet;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x18FBF90", Offset = "0x18FA590", VA = "0x1818FBF90")]
		public BakerHumanoidQT(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x18FC110", Offset = "0x18FA710", VA = "0x1818FC110")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x18FB3C0", Offset = "0x18F99C0", VA = "0x1818FB3C0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x18FB9E0", Offset = "0x18F9FE0", VA = "0x1818FB9E0")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x18FBDD0", Offset = "0x18FA3D0", VA = "0x1818FBDD0")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x18FB000", Offset = "0x18F9600", VA = "0x1818FB000")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x18FBF00", Offset = "0x18FA500", VA = "0x1818FBF00")]
		public void SetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x18FAF70", Offset = "0x18F9570", VA = "0x1818FAF70")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x18FB300", Offset = "0x18F9900", VA = "0x1818FB300")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x18FB530", Offset = "0x18F9B30", VA = "0x1818FB530")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class BakerMuscle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AnimationCurve curve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int muscleIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x18FCF30", Offset = "0x18FB530", VA = "0x1818FCF30")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x18FC2C0", Offset = "0x18FA8C0", VA = "0x1818FC2C0")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x18FB300", Offset = "0x18F9900", VA = "0x1818FB300")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x18FCD10", Offset = "0x18FB310", VA = "0x1818FCD10")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x18FCCB0", Offset = "0x18FB2B0", VA = "0x1818FCCB0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x18FCED0", Offset = "0x18FB4D0", VA = "0x1818FCED0")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x18FCF20", Offset = "0x18FB520", VA = "0x1818FCF20")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class BakerTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AnimationCurve posX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AnimationCurve posY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AnimationCurve posZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AnimationCurve rotX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AnimationCurve rotY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AnimationCurve rotZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AnimationCurve rotW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private string relativePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private bool recordPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool isRootNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Quaternion relativeRotation;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x18FDD80", Offset = "0x18FC380", VA = "0x1818FDD80")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x18FDD60", Offset = "0x18FC360", VA = "0x1818FDD60")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x18FD830", Offset = "0x18FBE30", VA = "0x1818FD830")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x18FD280", Offset = "0x18FB880", VA = "0x1818FD280")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x18FD6E0", Offset = "0x18FBCE0", VA = "0x1818FD6E0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x18FD560", Offset = "0x18FBB60", VA = "0x1818FD560")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x18FDB20", Offset = "0x18FC120", VA = "0x1818FDB20")]
		public void SetKeyframes(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x18FCFF0", Offset = "0x18FB5F0", VA = "0x1818FCFF0")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class HumanoidBaker : Baker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(1f, 9f)]
		public int muscleFrameRateDiv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private BakerMuscle[] bakerMuscles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private BakerHumanoidQT rootQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private BakerHumanoidQT leftFootQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private BakerHumanoidQT rightFootQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private BakerHumanoidQT leftHandQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private BakerHumanoidQT rightHandQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private float[] muscles;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private HumanPose pose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private HumanPoseHandler handler;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private Vector3 bodyPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Quaternion bodyRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int mN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Quaternion lastBodyRotation;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x19C1A30", Offset = "0x19C0030", VA = "0x1819C1A30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x19C1FB0", Offset = "0x19C05B0", VA = "0x1819C1FB0", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x19C28B0", Offset = "0x19C0EB0", VA = "0x1819C28B0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x19C2790", Offset = "0x19C0D90", VA = "0x1819C2790", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x19C1FD0", Offset = "0x19C05D0", VA = "0x1819C1FD0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x19C2250", Offset = "0x19C0850", VA = "0x1819C2250", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x19C29C0", Offset = "0x19C0FC0", VA = "0x1819C29C0")]
		private void UpdateHumanPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x19C2AF0", Offset = "0x19C10F0", VA = "0x1819C2AF0")]
		public HumanoidBaker()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum UpdateMode
		{
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			FixedLateUpdate
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Transform rotationSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public UpdateMode updateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public bool lockCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Header("Position")]
		public bool smoothFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Vector3 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public float followSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public float yMinLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float yMaxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool rotateAlways;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public bool rotateOnLeftButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public bool rotateOnRightButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public bool rotateOnMiddleButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Header("Distance")]
		public float distance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float zoomSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public float zoomSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public float blockingRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public float blockingSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public float blockingOriginOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private Vector3 targetDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Vector3 smoothPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private Camera cam;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool fixedFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private float fixedDeltaTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Quaternion r;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Vector3 lastUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private float blockedDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private float blockedDistanceV;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float x
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1169400", Offset = "0x1167A00", VA = "0x181169400")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1169430", Offset = "0x1167A30", VA = "0x181169430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float y
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x190C950", Offset = "0x190AF50", VA = "0x18190C950")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x17DF060", Offset = "0x17DD660", VA = "0x1817DF060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float distanceTarget
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x115BC90", Offset = "0x115A290", VA = "0x18115BC90")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x115BD50", Offset = "0x115A350", VA = "0x18115BD50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float zoomAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x190C960", Offset = "0x190AF60", VA = "0x18190C960")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x190BE90", Offset = "0x190A490", VA = "0x18190BE90")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x190BE80", Offset = "0x190A480", VA = "0x18190BE80")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x190BC60", Offset = "0x190A260", VA = "0x18190BC60", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x190C840", Offset = "0x190AE40", VA = "0x18190C840", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x190BDB0", Offset = "0x190A3B0", VA = "0x18190BDB0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x190BE10", Offset = "0x190A410", VA = "0x18190BE10", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x190BED0", Offset = "0x190A4D0", VA = "0x18190BED0")]
		public void UpdateInput()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x190C090", Offset = "0x190A690", VA = "0x18190C090")]
		public void UpdateTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x190C0C0", Offset = "0x190A6C0", VA = "0x18190C0C0")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x190BA60", Offset = "0x190A060", VA = "0x18190BA60")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x190C870", Offset = "0x190AE70", VA = "0x18190C870")]
		public CameraController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public float rotationSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float yMinLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public float yMaxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private float x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private float y;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x190BA10", Offset = "0x190A010", VA = "0x18190BA10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x190BAA0", Offset = "0x190A0A0", VA = "0x18190BAA0")]
		public void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x190BA60", Offset = "0x190A060", VA = "0x18190BA60")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x190BC40", Offset = "0x190A240", VA = "0x18190BC40")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public enum Axis
	{
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		X,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Z
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class AxisTools
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x18FAF20", Offset = "0x18F9520", VA = "0x1818FAF20")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x18FAEC0", Offset = "0x18F94C0", VA = "0x1818FAEC0")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x18FA8E0", Offset = "0x18F8EE0", VA = "0x1818FA8E0")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x18FA7D0", Offset = "0x18F8DD0", VA = "0x1818FA7D0")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x18FADB0", Offset = "0x18F93B0", VA = "0x1818FADB0")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x18FAD40", Offset = "0x18F9340", VA = "0x1818FAD40")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x18FAA60", Offset = "0x18F9060", VA = "0x1818FAA60")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public class LimbOrientation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public Vector3 upperBoneForwardAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public Vector3 lowerBoneForwardAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public Vector3 lastBoneLeftAxis;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1608700", Offset = "0x1606D00", VA = "0x181608700")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public LimbOrientation leftArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public LimbOrientation rightArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public LimbOrientation leftLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public LimbOrientation rightLeg;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static BipedLimbOrientations UMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x1901080", Offset = "0x18FF680", VA = "0x181901080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static BipedLimbOrientations MaxBiped
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1900D70", Offset = "0x18FF370", VA = "0x181900D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x177B7D0", Offset = "0x1779DD0", VA = "0x18177B7D0")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class BipedNaming
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public enum BoneType
		{
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			Unassigned,
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			Spine,
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			Head,
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			Arm,
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			Leg,
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			Tail,
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			Eye
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public enum BoneSide
		{
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			Center,
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			Left,
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			Right
		}

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static string[] typeLeft;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static string[] typeRight;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public static string[] typeSpine;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public static string[] typeHead;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public static string[] typeArm;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static string[] typeLeg;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static string[] typeTail;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static string[] typeEye;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public static string[] typeExclude;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public static string[] typeExcludeSpine;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public static string[] typeExcludeHead;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public static string[] typeExcludeArm;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public static string[] typeExcludeLeg;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static string[] typeExcludeTail;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static string[] typeExcludeEye;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static string[] pelvis;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static string[] hand;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static string[] foot;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1901870", Offset = "0x18FFE70", VA = "0x181901870")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1901640", Offset = "0x18FFC40", VA = "0x181901640")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x19017F0", Offset = "0x18FFDF0", VA = "0x1819017F0")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1901A20", Offset = "0x1900020", VA = "0x181901A20")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1901AD0", Offset = "0x19000D0", VA = "0x181901AD0")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1901430", Offset = "0x18FFA30", VA = "0x181901430")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1901390", Offset = "0x18FF990", VA = "0x181901390")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x19015B0", Offset = "0x18FFBB0", VA = "0x1819015B0")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1905D50", Offset = "0x1904350", VA = "0x181905D50")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x19061E0", Offset = "0x19047E0", VA = "0x1819061E0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1906460", Offset = "0x1904A60", VA = "0x181906460")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1905B40", Offset = "0x1904140", VA = "0x181905B40")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1905720", Offset = "0x1903D20", VA = "0x181905720")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1905FD0", Offset = "0x19045D0", VA = "0x181905FD0")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1906670", Offset = "0x1904C70", VA = "0x181906670")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1905930", Offset = "0x1903F30", VA = "0x181905930")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1906880", Offset = "0x1904E80", VA = "0x181906880")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1906B40", Offset = "0x1905140", VA = "0x181906B40")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1905630", Offset = "0x1903C30", VA = "0x181905630")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1906A60", Offset = "0x1905060", VA = "0x181906A60")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1901D00", Offset = "0x1900300", VA = "0x181901D00")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x19056C0", Offset = "0x1903CC0", VA = "0x1819056C0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1906A00", Offset = "0x1905000", VA = "0x181906A00")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class BipedReferences
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct AutoDetectParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public bool legsParentInSpine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public bool includeEyes;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static AutoDetectParams Default
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x1602670", Offset = "0x1600C70", VA = "0x181602670")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1602660", Offset = "0x1600C60", VA = "0x181602660")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public Transform root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Transform pelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Transform leftThigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Transform leftCalf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Transform leftFoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Transform rightThigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Transform rightCalf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public Transform rightFoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Transform leftUpperArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Transform leftForearm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Transform leftHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Transform rightUpperArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Transform rightForearm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Transform rightHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Transform head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Transform[] spine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Transform[] eyes;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public virtual bool isFilled
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x190ACC0", Offset = "0x19092C0", VA = "0x18190ACC0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool isEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9CE280", Offset = "0x9CC880", VA = "0x1809CE280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x19090A0", Offset = "0x19076A0", VA = "0x1819090A0", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1907880", Offset = "0x1905E80", VA = "0x181907880", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x19075A0", Offset = "0x1905BA0", VA = "0x1819075A0")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1907EA0", Offset = "0x19064A0", VA = "0x181907EA0")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1907010", Offset = "0x1905610", VA = "0x181907010")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x190A580", Offset = "0x1908B80", VA = "0x18190A580")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x190A6D0", Offset = "0x1908CD0", VA = "0x18190A6D0")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1909520", Offset = "0x1907B20", VA = "0x181909520")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1906C70", Offset = "0x1905270", VA = "0x181906C70")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1906E80", Offset = "0x1905480", VA = "0x181906E80")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1907D10", Offset = "0x1906310", VA = "0x181907D10")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1906D80", Offset = "0x1905380", VA = "0x181906D80")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x1909610", Offset = "0x1907C10", VA = "0x181909610")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1909EA0", Offset = "0x19084A0", VA = "0x181909EA0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x190A7C0", Offset = "0x1908DC0", VA = "0x18190A7C0")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1908B10", Offset = "0x1907110", VA = "0x181908B10")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x190A2E0", Offset = "0x19088E0", VA = "0x18190A2E0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1908D20", Offset = "0x1907320", VA = "0x181908D20")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1908FC0", Offset = "0x19075C0", VA = "0x181908FC0")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x190AC40", Offset = "0x1909240", VA = "0x18190AC40")]
		public BipedReferences()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class Comments : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[Multiline]
		public string text;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public Comments()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1960540", Offset = "0x195EB40", VA = "0x181960540")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1960600", Offset = "0x195EC00", VA = "0x181960600")]
		public DemoGUIMessage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class Hierarchy
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x19C0260", Offset = "0x19BE860", VA = "0x1819C0260")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x19BFAE0", Offset = "0x19BE0E0", VA = "0x1819BFAE0")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x19C0300", Offset = "0x19BE900", VA = "0x1819C0300")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x19BF9D0", Offset = "0x19BDFD0", VA = "0x1819BF9D0")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x19BF740", Offset = "0x19BDD40", VA = "0x1819BF740")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x19BFC10", Offset = "0x19BE210", VA = "0x1819BFC10")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x19BFEF0", Offset = "0x19BE4F0", VA = "0x1819BFEF0")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x19C0090", Offset = "0x19BE690", VA = "0x1819C0090")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x19BFD20", Offset = "0x19BE320", VA = "0x1819BFD20")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x19C0470", Offset = "0x19BEA70", VA = "0x1819C0470")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public Hierarchy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class InspectorComment : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public string color;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1A122A0", Offset = "0x1A108A0", VA = "0x181A122A0")]
		public InspectorComment(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1A12330", Offset = "0x1A10930", VA = "0x181A12330")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum InterpolationMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		InOutCubic,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		InOutQuintic,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		InOutSine,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		InQuintic,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		InQuartic,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		InCubic,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		InQuadratic,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		InElastic,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		InElasticSmall,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		InElasticBig,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		InSine,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		InBack,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		OutQuintic,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		OutQuartic,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		OutCubic,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		OutInCubic,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		OutInQuartic,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		OutElastic,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		OutElasticSmall,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		OutElasticBig,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		OutSine,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		OutBack,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		OutBackCubic,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		OutBackQuartic,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		BackInCubic,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		BackInQuartic
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class Interp
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x17C90F0", Offset = "0x17C76F0", VA = "0x1817C90F0")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x17C9F40", Offset = "0x17C8540", VA = "0x1817C9F40")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x17C9A60", Offset = "0x17C8060", VA = "0x1817C9A60")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x17C9AF0", Offset = "0x17C80F0", VA = "0x1817C9AF0")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x17C98E0", Offset = "0x17C7EE0", VA = "0x1817C98E0")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x17C9910", Offset = "0x17C7F10", VA = "0x1817C9910")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x17C99F0", Offset = "0x17C7FF0", VA = "0x1817C99F0")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x17C99D0", Offset = "0x17C7FD0", VA = "0x1817C99D0")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x17C9730", Offset = "0x17C7D30", VA = "0x1817C9730")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x17C99C0", Offset = "0x17C7FC0", VA = "0x1817C99C0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x17C9E90", Offset = "0x17C8490", VA = "0x1817C9E90")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x17C9E30", Offset = "0x17C8430", VA = "0x1817C9E30")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x17C9BD0", Offset = "0x17C81D0", VA = "0x1817C9BD0")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x17C9DB0", Offset = "0x17C83B0", VA = "0x1817C9DB0")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x17C9DF0", Offset = "0x17C83F0", VA = "0x1817C9DF0")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x17C9080", Offset = "0x17C7680", VA = "0x1817C9080")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x17C90B0", Offset = "0x17C76B0", VA = "0x1817C90B0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x17C9B00", Offset = "0x17C8100", VA = "0x1817C9B00")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x17C9B40", Offset = "0x17C8140", VA = "0x1817C9B40")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x17C9C80", Offset = "0x17C8280", VA = "0x1817C9C80")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x17C9C10", Offset = "0x17C8210", VA = "0x1817C9C10")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x17C97B0", Offset = "0x17C7DB0", VA = "0x1817C97B0")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x17C9750", Offset = "0x17C7D50", VA = "0x1817C9750")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x17C9A10", Offset = "0x17C8010", VA = "0x1817C9A10")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x17C9F00", Offset = "0x17C8500", VA = "0x1817C9F00")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x17C9960", Offset = "0x17C7F60", VA = "0x1817C9960")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x17C9810", Offset = "0x17C7E10", VA = "0x1817C9810")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x17C9CF0", Offset = "0x17C82F0", VA = "0x1817C9CF0")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x17C9700", Offset = "0x17C7D00", VA = "0x1817C9700")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x17C9B90", Offset = "0x17C8190", VA = "0x1817C9B90")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public Interp()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class LargeHeader : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public string color;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x17CA0D0", Offset = "0x17C86D0", VA = "0x1817CA0D0")]
		public LargeHeader(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x17CA160", Offset = "0x17C8760", VA = "0x1817CA160")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class LayerMaskExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x17CA2C0", Offset = "0x17C88C0", VA = "0x1817CA2C0")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x17CA300", Offset = "0x17C8900", VA = "0x1817CA300")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x17CA3A0", Offset = "0x17C89A0", VA = "0x1817CA3A0")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x17CA300", Offset = "0x17C8900", VA = "0x1817CA300")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x17CA3A0", Offset = "0x17C89A0", VA = "0x1817CA3A0")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x17CA420", Offset = "0x17C8A20", VA = "0x1817CA420")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x17CA1F0", Offset = "0x17C87F0", VA = "0x1817CA1F0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x17CA8A0", Offset = "0x17C8EA0", VA = "0x1817CA8A0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x17CA440", Offset = "0x17C8A40", VA = "0x1817CA440")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x17CA550", Offset = "0x17C8B50", VA = "0x1817CA550")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x17CA760", Offset = "0x17C8D60", VA = "0x1817CA760")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x17CA640", Offset = "0x17C8C40", VA = "0x1817CA640")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class QuaTools
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x17D40A0", Offset = "0x17D26A0", VA = "0x1817D40A0")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x17D3F30", Offset = "0x17D2530", VA = "0x1817D3F30")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x17D3AC0", Offset = "0x17D20C0", VA = "0x1817D3AC0")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x17D3FD0", Offset = "0x17D25D0", VA = "0x1817D3FD0")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x17D3E70", Offset = "0x17D2470", VA = "0x1817D3E70")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x17D3C70", Offset = "0x17D2270", VA = "0x1817D3C70")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x17D4120", Offset = "0x17D2720", VA = "0x1817D4120")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x17D43E0", Offset = "0x17D29E0", VA = "0x1817D43E0")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x17D4190", Offset = "0x17D2790", VA = "0x1817D4190")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x17D4450", Offset = "0x17D2A50", VA = "0x1817D4450")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x17D3680", Offset = "0x17D1C80", VA = "0x1817D3680")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x17D4360", Offset = "0x17D2960", VA = "0x1817D4360")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x17D37C0", Offset = "0x17D1DC0", VA = "0x1817D37C0")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x17D3870", Offset = "0x17D1E70", VA = "0x1817D3870")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x17D3490", Offset = "0x17D1A90", VA = "0x1817D3490")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x17D3360", Offset = "0x17D1960", VA = "0x1817D3360")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x17D4230", Offset = "0x17D2830", VA = "0x1817D4230")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x17D44F0", Offset = "0x17D2AF0", VA = "0x1817D44F0")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x17D45F0", Offset = "0x17D2BF0", VA = "0x1817D45F0")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static T sInstance;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static T instance
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1B427F0", Offset = "0x1B40DF0", VA = "0x181B427F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3E43710", Offset = "0x3E41D10", VA = "0x183E43710", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x234F5D0", Offset = "0x234DBD0", VA = "0x18234F5D0")]
		protected Singleton()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SolverManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Animation legacy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private bool updateFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private bool componentInitiated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private bool skipSolverUpdate;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool animatePhysics
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x160D1E0", Offset = "0x160B7E0", VA = "0x18160D1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool isAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x160D2C0", Offset = "0x160B8C0", VA = "0x18160D2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x160CDD0", Offset = "0x160B3D0", VA = "0x18160CDD0")]
		public void Disable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x160D100", Offset = "0x160B700", VA = "0x18160D100")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x160D060", Offset = "0x160B660", VA = "0x18160D060")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x160D060", Offset = "0x160B660", VA = "0x18160D060")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x160D1A0", Offset = "0x160B7A0", VA = "0x18160D1A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x160CE60", Offset = "0x160B460", VA = "0x18160CE60")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x160D0B0", Offset = "0x160B6B0", VA = "0x18160D0B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x160D160", Offset = "0x160B760", VA = "0x18160D160")]
		public void UpdateSolverExternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6B8BE0", Offset = "0x6B71E0", VA = "0x1806B8BE0")]
		public SolverManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public GameObject target;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x160DCC0", Offset = "0x160C2C0", VA = "0x18160DCC0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x160DE20", Offset = "0x160C420", VA = "0x18160DE20")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x160DD70", Offset = "0x160C370", VA = "0x18160DD70")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class V2Tools
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x115B630", Offset = "0x1159C30", VA = "0x18115B630")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1610640", Offset = "0x160EC40", VA = "0x181610640")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x16105D0", Offset = "0x160EBD0", VA = "0x1816105D0")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x16106A0", Offset = "0x160ECA0", VA = "0x1816106A0")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x16107C0", Offset = "0x160EDC0", VA = "0x1816107C0")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class V3Tools
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x16114A0", Offset = "0x160FAA0", VA = "0x1816114A0")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x16113B0", Offset = "0x160F9B0", VA = "0x1816113B0")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x16112E0", Offset = "0x160F8E0", VA = "0x1816112E0")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x16114D0", Offset = "0x160FAD0", VA = "0x1816114D0")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x16113F0", Offset = "0x160F9F0", VA = "0x1816113F0")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1611140", Offset = "0x160F740", VA = "0x181611140")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1611800", Offset = "0x160FE00", VA = "0x181611800")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1611D40", Offset = "0x1610340", VA = "0x181611D40")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1611080", Offset = "0x160F680", VA = "0x181611080")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1610F90", Offset = "0x160F590", VA = "0x181610F90")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1610900", Offset = "0x160EF00", VA = "0x181610900")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1610B00", Offset = "0x160F100", VA = "0x181610B00")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1610D00", Offset = "0x160F300", VA = "0x181610D00")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1611940", Offset = "0x160FF40", VA = "0x181611940")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1611B20", Offset = "0x1610120", VA = "0x181611B20")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1611DD0", Offset = "0x16103D0", VA = "0x181611DD0")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1611590", Offset = "0x160FB90", VA = "0x181611590")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x16116B0", Offset = "0x160FCB0", VA = "0x1816116B0")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1611EC0", Offset = "0x16104C0", VA = "0x181611EC0")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1610F40", Offset = "0x160F540", VA = "0x181610F40")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class Warning
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public delegate void Logger(string message);

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static bool logged;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x16194D0", Offset = "0x1617AD0", VA = "0x1816194D0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1619420", Offset = "0x1617A20", VA = "0x181619420")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	public class BipedIK : SolverManager
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public BipedReferences references;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public BipedIKSolvers solvers;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x18FFD00", Offset = "0x18FE300", VA = "0x1818FFD00")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x18FFCC0", Offset = "0x18FE2C0", VA = "0x1818FFCC0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1900220", Offset = "0x18FE820", VA = "0x181900220")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x18FF5E0", Offset = "0x18FDBE0", VA = "0x1818FF5E0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x18FF760", Offset = "0x18FDD60", VA = "0x1818FF760")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x18FF870", Offset = "0x18FDE70", VA = "0x1818FF870")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x18FFD40", Offset = "0x18FE340", VA = "0x1818FFD40")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x18FFE30", Offset = "0x18FE430", VA = "0x1818FFE30")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x18FFDB0", Offset = "0x18FE3B0", VA = "0x1818FFDB0")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x18FFEA0", Offset = "0x18FE4A0", VA = "0x1818FFEA0")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x18FF7D0", Offset = "0x18FDDD0", VA = "0x1818FF7D0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x18FF8E0", Offset = "0x18FDEE0", VA = "0x1818FF8E0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x18FFF40", Offset = "0x18FE540", VA = "0x1818FFF40")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x18FFF10", Offset = "0x18FE510", VA = "0x1818FFF10")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x18FFF80", Offset = "0x18FE580", VA = "0x1818FFF80")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x18FFFB0", Offset = "0x18FE5B0", VA = "0x1818FFFB0")]
		public void SetSpineWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x18FF6F0", Offset = "0x18FDCF0", VA = "0x1818FF6F0")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xB1CE20", Offset = "0xB1B420", VA = "0x180B1CE20")]
		public void InitiateBipedIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x859940", Offset = "0x857F40", VA = "0x180859940")]
		public void UpdateBipedIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x18FFFE0", Offset = "0x18FE5E0", VA = "0x1818FFFE0")]
		public void SetToDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x18FF620", Offset = "0x18FDC20", VA = "0x1818FF620", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x18FF950", Offset = "0x18FDF50", VA = "0x1818FF950", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x1900260", Offset = "0x18FE860", VA = "0x181900260", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x17DAEB0", Offset = "0x17D94B0", VA = "0x1817DAEB0")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x1900480", Offset = "0x18FEA80", VA = "0x181900480")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class BipedIKSolvers
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public IKSolverLimb leftFoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IKSolverLimb rightFoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public IKSolverLimb leftHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IKSolverLimb rightHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IKSolverFABRIK spine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public IKSolverLookAt lookAt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IKSolverAim aim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Constraints pelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IKSolverLimb[] _limbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private IKSolver[] _ikSolvers;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IKSolverLimb[] limbs
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x18FF3E0", Offset = "0x18FD9E0", VA = "0x1818FF3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IKSolver[] ikSolvers
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x18FF0D0", Offset = "0x18FD6D0", VA = "0x1818FF0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x18FED70", Offset = "0x18FD370", VA = "0x1818FED70")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x18FEF10", Offset = "0x18FD510", VA = "0x1818FEF10")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public abstract class Constraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public float weight;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool isValid
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x1960010", Offset = "0x195E610", VA = "0x181960010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void UpdateConstraint();

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class ConstraintPosition : Constraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public Vector3 position;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x195FB70", Offset = "0x195E170", VA = "0x18195FB70", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ConstraintPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class ConstraintPositionOffset : Constraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector3 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Vector3 defaultLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Vector3 lastLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private bool initiated;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private bool positionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x195FB10", Offset = "0x195E110", VA = "0x18195FB10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x195F8B0", Offset = "0x195DEB0", VA = "0x18195F8B0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ConstraintPositionOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class ConstraintRotation : Constraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public Quaternion rotation;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x195FF10", Offset = "0x195E510", VA = "0x18195FF10", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ConstraintRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class ConstraintRotationOffset : Constraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public Quaternion offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private Quaternion defaultRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private Quaternion defaultLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private Quaternion lastLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private Quaternion defaultTargetLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private bool initiated;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private bool rotationChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x195FEC0", Offset = "0x195E4C0", VA = "0x18195FEC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x195FCD0", Offset = "0x195E2D0", VA = "0x18195FCD0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ConstraintRotationOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class Constraints
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Vector3 positionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public Vector3 rotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public Vector3 rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x19600F0", Offset = "0x195E6F0", VA = "0x1819600F0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1960070", Offset = "0x195E670", VA = "0x181960070")]
		public void Initiate(Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x1960150", Offset = "0x195E750", VA = "0x181960150")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class Finger
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public enum DOF
		{
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			One,
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			Three
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[Range(0f, 1f)]
		[Tooltip("Master Weight for the finger.")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IKSolverLimb solver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private Quaternion bone3RelativeToTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private Vector3 bone3DefaultLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private Quaternion bone3DefaultLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private Vector3 bone1Axis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private Vector3 tipAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Vector3 bone1TwistAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Vector3 defaultBendNormal;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x753570", Offset = "0x751B70", VA = "0x180753570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x753A60", Offset = "0x752060", VA = "0x180753A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 IKPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1970280", Offset = "0x196E880", VA = "0x181970280")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x19702E0", Offset = "0x196E8E0", VA = "0x1819702E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion IKRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x19702B0", Offset = "0x196E8B0", VA = "0x1819702B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x1970310", Offset = "0x196E910", VA = "0x181970310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x196F9D0", Offset = "0x196DFD0", VA = "0x18196F9D0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x196F030", Offset = "0x196D630", VA = "0x18196F030")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x196EF40", Offset = "0x196D540", VA = "0x18196EF40")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x196FAF0", Offset = "0x196E0F0", VA = "0x18196FAF0")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x196FBD0", Offset = "0x196E1D0", VA = "0x18196FBD0")]
		public void Update(float masterWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x1970260", Offset = "0x196E860", VA = "0x181970260")]
		public Finger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class FingerRig : SolverManager
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Finger[] fingers;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x753570", Offset = "0x751B70", VA = "0x180753570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x753A60", Offset = "0x752060", VA = "0x180753A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x196EAE0", Offset = "0x196D0E0", VA = "0x18196EAE0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x196E510", Offset = "0x196CB10", VA = "0x18196E510")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x196E330", Offset = "0x196C930", VA = "0x18196E330")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x196EB70", Offset = "0x196D170", VA = "0x18196EB70")]
		public void RemoveFinger(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x196E230", Offset = "0x196C830", VA = "0x18196E230")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x196EA10", Offset = "0x196D010", VA = "0x18196EA10", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x196EE60", Offset = "0x196D460", VA = "0x18196EE60")]
		public void UpdateFingerSolvers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x196E8A0", Offset = "0x196CEA0", VA = "0x18196E8A0")]
		public void FixFingerTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x196ED20", Offset = "0x196D320", VA = "0x18196ED20")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x196EE60", Offset = "0x196D460", VA = "0x18196EE60", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x196E8A0", Offset = "0x196CEA0", VA = "0x18196E8A0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x196EEE0", Offset = "0x196D4E0", VA = "0x18196EEE0")]
		public FingerRig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public abstract class Grounder : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public delegate void GrounderDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public GrounderDelegate OnPreGrounder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public GrounderDelegate OnPostGrounder;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x731C90", Offset = "0x730290", VA = "0x180731C90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x731D10", Offset = "0x730310", VA = "0x180731D10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ResetPosition();

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1978AE0", Offset = "0x19770E0", VA = "0x181978AE0")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x17DAEB0", Offset = "0x17D94B0", VA = "0x1817DAEB0")]
		protected void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x19785B0", Offset = "0x1976BB0", VA = "0x1819785B0")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1978900", Offset = "0x1976F00", VA = "0x181978900")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void OpenUserManual();

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void OpenScriptReference();

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1978C20", Offset = "0x1977220", VA = "0x181978C20")]
		protected Grounder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private Transform[] feet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private Quaternion[] footRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Vector3 animatedPelvisLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private Vector3 solvedPelvisLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private Vector3 spineOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private float lastWeight;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1972C40", Offset = "0x1971240", VA = "0x181972C40", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1972C00", Offset = "0x1971200", VA = "0x181972C00", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x1972C80", Offset = "0x1971280", VA = "0x181972C80", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x1972010", Offset = "0x1970610", VA = "0x181972010")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1972DE0", Offset = "0x19713E0", VA = "0x181972DE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1971C40", Offset = "0x1970240", VA = "0x181971C40")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x19722A0", Offset = "0x19708A0", VA = "0x1819722A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x1972510", Offset = "0x1970B10", VA = "0x181972510")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1972CD0", Offset = "0x19712D0", VA = "0x181972CD0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1972300", Offset = "0x1970900", VA = "0x181972300")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x19720C0", Offset = "0x19706C0", VA = "0x1819720C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1972ED0", Offset = "0x19714D0", VA = "0x181972ED0")]
		public GrounderBipedIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public class SpineEffector
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xF69C00", Offset = "0xF68200", VA = "0x180F69C00")]
			public SpineEffector()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x160D370", Offset = "0x160B970", VA = "0x18160D370")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public SpineEffector[] spine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private Transform[] feet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Vector3 spineOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private bool firstSolve;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1973D30", Offset = "0x1972330", VA = "0x181973D30")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1973D70", Offset = "0x1972370", VA = "0x181973D70", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1973CF0", Offset = "0x19722F0", VA = "0x181973CF0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1973DB0", Offset = "0x19723B0", VA = "0x181973DB0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1973460", Offset = "0x1971A60", VA = "0x181973460")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1973FA0", Offset = "0x19725A0", VA = "0x181973FA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x1973180", Offset = "0x1971780", VA = "0x181973180")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x1973180", Offset = "0x1971780", VA = "0x181973180")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1973190", Offset = "0x1971790", VA = "0x181973190")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x1973790", Offset = "0x1971D90", VA = "0x181973790")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x1973DF0", Offset = "0x19723F0", VA = "0x181973DF0")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1973630", Offset = "0x1971C30", VA = "0x181973630")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1973500", Offset = "0x1971B00", VA = "0x181973500")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1974080", Offset = "0x1972680", VA = "0x181974080")]
		public GrounderFBBIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderIK : Grounder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public IK[] legs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private Transform[] feet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Quaternion[] footRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private Vector3 animatedPelvisLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private Vector3 solvedPelvisLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int solvedFeet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private bool solved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private float lastWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private Rigidbody characterRootRigidbody;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1975260", Offset = "0x1973860", VA = "0x181975260", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x1975220", Offset = "0x1973820", VA = "0x181975220", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x19752A0", Offset = "0x19738A0", VA = "0x1819752A0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1974700", Offset = "0x1972D00", VA = "0x181974700")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1974B40", Offset = "0x1973140", VA = "0x181974B40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x19756C0", Offset = "0x1973CC0", VA = "0x1819756C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1974160", Offset = "0x1972760", VA = "0x181974160")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1974EA0", Offset = "0x19734A0", VA = "0x181974EA0")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x19752C0", Offset = "0x19738C0", VA = "0x1819752C0")]
		private void SetLegIK(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1974C80", Offset = "0x1973280", VA = "0x181974C80")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1974910", Offset = "0x1972F10", VA = "0x181974910")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1975B20", Offset = "0x1974120", VA = "0x181975B20")]
		public GrounderIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	public class GrounderQuadruped : Grounder
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct Foot
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public IKSolver solver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public Quaternion rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public Grounding.Leg leg;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1604FF0", Offset = "0x16035F0", VA = "0x181604FF0")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		public float rootRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public IK[] legs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public IK[] forelegs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[HideInInspector]
		public Vector3 gravity;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private Foot[] feet;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private Vector3 animatedPelvisLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private Quaternion animatedPelvisLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private Quaternion animatedHeadLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Vector3 solvedPelvisLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private Quaternion solvedPelvisLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Quaternion solvedHeadLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private int solvedFeet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private bool solved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private Transform forefeetRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private Quaternion headRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private float lastWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private Rigidbody characterRootRigidbody;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1977820", Offset = "0x1975E20", VA = "0x181977820", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x19777E0", Offset = "0x1975DE0", VA = "0x1819777E0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1977860", Offset = "0x1975E60", VA = "0x181977860", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1976840", Offset = "0x1974E40", VA = "0x181976840")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1976670", Offset = "0x1974C70", VA = "0x181976670")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1976AC0", Offset = "0x19750C0", VA = "0x181976AC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1978300", Offset = "0x1976900", VA = "0x181978300")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1976260", Offset = "0x1974860", VA = "0x181976260")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1975E20", Offset = "0x1974420", VA = "0x181975E20")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1976990", Offset = "0x1974F90", VA = "0x181976990")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x19778A0", Offset = "0x1975EA0", VA = "0x1819778A0")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1976EB0", Offset = "0x19754B0", VA = "0x181976EB0")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1977FE0", Offset = "0x19765E0", VA = "0x181977FE0")]
		private void UpdateForefeetRoot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1977E30", Offset = "0x1976430", VA = "0x181977E30")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1976B40", Offset = "0x1975140", VA = "0x181976B40")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1976A80", Offset = "0x1975080", VA = "0x181976A80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1975C00", Offset = "0x1974200", VA = "0x181975C00")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1978480", Offset = "0x1976A80", VA = "0x181978480")]
		public GrounderQuadruped()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	public class GrounderVRIK : Grounder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private Transform[] feet;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x19BD5F0", Offset = "0x19BBBF0", VA = "0x1819BD5F0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x19BD630", Offset = "0x19BBC30", VA = "0x1819BD630", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x19BD5B0", Offset = "0x19BBBB0", VA = "0x1819BD5B0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x19BD670", Offset = "0x19BBC70", VA = "0x1819BD670", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x19BCBE0", Offset = "0x19BB1E0", VA = "0x1819BCBE0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x19BD810", Offset = "0x19BBE10", VA = "0x1819BD810")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x19BC8F0", Offset = "0x19BAEF0", VA = "0x1819BC8F0")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x19BD210", Offset = "0x19BB810", VA = "0x1819BD210")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x19BD700", Offset = "0x19BBD00", VA = "0x1819BD700")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x19BCFB0", Offset = "0x19BB5B0", VA = "0x1819BCFB0")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x19BCE50", Offset = "0x19BB450", VA = "0x1819BCE50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x19BCC80", Offset = "0x19BB280", VA = "0x1819BCC80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x19BD8F0", Offset = "0x19BBEF0", VA = "0x1819BD8F0")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class Grounding
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public enum Quality
		{
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			Fastest,
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			Simple,
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			Best
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public class Leg
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public Quaternion rotationOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public bool invertFootCenter;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			private Grounding grounding;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			private float lastTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			private float deltaTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			private Vector3 lastPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			private Quaternion toHitNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			private Quaternion r;

			[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			private Vector3 up;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			private bool doOverrideFootPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			private Vector3 overrideFootPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			private Vector3 transformPosition;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool isGrounded
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0x7F09A0", Offset = "0x7EEFA0", VA = "0x1807F09A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(RVA = "0x7F09C0", Offset = "0x7EEFC0", VA = "0x1807F09C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Vector3 IKPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(RVA = "0x16084A0", Offset = "0x1606AA0", VA = "0x1816084A0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FD")]
				[Cpp2IlInjected.Address(RVA = "0x1608690", Offset = "0x1606C90", VA = "0x181608690")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool initiated
			{
				[Cpp2IlInjected.Token(Token = "0x60001FE")]
				[Cpp2IlInjected.Address(RVA = "0x718150", Offset = "0x716750", VA = "0x180718150")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FF")]
				[Cpp2IlInjected.Address(RVA = "0x718170", Offset = "0x716770", VA = "0x180718170")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public float heightFromGround
			{
				[Cpp2IlInjected.Token(Token = "0x6000200")]
				[Cpp2IlInjected.Address(RVA = "0xA7F3C0", Offset = "0xA7D9C0", VA = "0x180A7F3C0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0xA7FB40", Offset = "0xA7E140", VA = "0x180A7FB40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Vector3 velocity
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x79D0C0", Offset = "0x79B6C0", VA = "0x18079D0C0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000203")]
				[Cpp2IlInjected.Address(RVA = "0x79D140", Offset = "0x79B740", VA = "0x18079D140")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public Transform transform
			{
				[Cpp2IlInjected.Token(Token = "0x6000204")]
				[Cpp2IlInjected.Address(RVA = "0x694B00", Offset = "0x693100", VA = "0x180694B00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000205")]
				[Cpp2IlInjected.Address(RVA = "0x728ED0", Offset = "0x7274D0", VA = "0x180728ED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public float IKOffset
			{
				[Cpp2IlInjected.Token(Token = "0x6000206")]
				[Cpp2IlInjected.Address(RVA = "0x83C4F0", Offset = "0x83AAF0", VA = "0x18083C4F0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000207")]
				[Cpp2IlInjected.Address(RVA = "0x83C580", Offset = "0x83AB80", VA = "0x18083C580")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public RaycastHit heelHit
			{
				[Cpp2IlInjected.Token(Token = "0x6000208")]
				[Cpp2IlInjected.Address(RVA = "0x16084F0", Offset = "0x1606AF0", VA = "0x1816084F0")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Cpp2IlInjected.Token(Token = "0x6000209")]
				[Cpp2IlInjected.Address(RVA = "0x16086D0", Offset = "0x1606CD0", VA = "0x1816086D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RaycastHit capsuleHit
			{
				[Cpp2IlInjected.Token(Token = "0x600020A")]
				[Cpp2IlInjected.Address(RVA = "0x16084C0", Offset = "0x1606AC0", VA = "0x1816084C0")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Cpp2IlInjected.Token(Token = "0x600020B")]
				[Cpp2IlInjected.Address(RVA = "0x16086A0", Offset = "0x1606CA0", VA = "0x1816086A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public RaycastHit GetHitPoint
			{
				[Cpp2IlInjected.Token(Token = "0x600020C")]
				[Cpp2IlInjected.Address(RVA = "0x1608420", Offset = "0x1606A20", VA = "0x181608420")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public float stepHeightFromGround
			{
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0x1608650", Offset = "0x1606C50", VA = "0x181608650")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			private float rootYOffset
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x1608520", Offset = "0x1606B20", VA = "0x181608520")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1607F40", Offset = "0x1606540", VA = "0x181607F40")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x1606A20", Offset = "0x1605020", VA = "0x181606A20")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1606B10", Offset = "0x1605110", VA = "0x181606B10")]
			public void OnEnable()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1607CE0", Offset = "0x16062E0", VA = "0x181607CE0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1606B70", Offset = "0x1605170", VA = "0x181606B70")]
			public void Process()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1605C60", Offset = "0x1604260", VA = "0x181605C60")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x16064D0", Offset = "0x1604AD0", VA = "0x1816064D0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x1607E80", Offset = "0x1606480", VA = "0x181607E80")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x16082B0", Offset = "0x16068B0", VA = "0x1816082B0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1607F60", Offset = "0x1606560", VA = "0x181607F60")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x1606340", Offset = "0x1604940", VA = "0x181606340")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1607D70", Offset = "0x1606370", VA = "0x181607D70")]
			private void RotateFoot()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x1606950", Offset = "0x1604F50", VA = "0x181606950")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x16083D0", Offset = "0x16069D0", VA = "0x1816083D0")]
			public Leg()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public class Pelvis
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			private Grounding grounding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			private Vector3 lastRootPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			private float damperF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			private bool initiated;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			private float lastTime;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public Vector3 IKOffset
			{
				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x1144630", Offset = "0x1142C30", VA = "0x181144630")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x1609230", Offset = "0x1607830", VA = "0x181609230")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public float heightOffset
			{
				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0xA24840", Offset = "0xA22E40", VA = "0x180A24840")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0xB3B580", Offset = "0xB39B80", VA = "0x180B3B580")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1608E30", Offset = "0x1607430", VA = "0x181608E30")]
			public void Initiate(Grounding grounding)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x16091B0", Offset = "0x16077B0", VA = "0x1816091B0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x1608EB0", Offset = "0x16074B0", VA = "0x181608EB0")]
			public void OnEnable()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x1608F20", Offset = "0x1607520", VA = "0x181608F20")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public Pelvis()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[HideInInspector]
		[Tooltip("Offset of the foot center along character forward axis.")]
		public float footCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
		public float maxFootRotationAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private bool initiated;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Leg[] legs
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x683BB0", Offset = "0x6821B0", VA = "0x180683BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x817260", Offset = "0x815860", VA = "0x180817260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Pelvis pelvis
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x810200", Offset = "0x80E800", VA = "0x180810200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x753B10", Offset = "0x752110", VA = "0x180753B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool isGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xF009A0", Offset = "0xEFEFA0", VA = "0x180F009A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xB8E1E0", Offset = "0xB8C7E0", VA = "0x180B8E1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Transform root
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x708FA0", Offset = "0x7075A0", VA = "0x180708FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x83C530", Offset = "0x83AB30", VA = "0x18083C530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public RaycastHit rootHit
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x19BED40", Offset = "0x19BD340", VA = "0x1819BED40")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x19BEE70", Offset = "0x19BD470", VA = "0x1819BEE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool rootGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x19BECE0", Offset = "0x19BD2E0", VA = "0x1819BECE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x19BED70", Offset = "0x19BD370", VA = "0x1819BED70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private bool useRootRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x19BEDE0", Offset = "0x19BD3E0", VA = "0x1819BEDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x19BDE30", Offset = "0x19BC430", VA = "0x1819BDE30")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x19BE820", Offset = "0x19BCE20", VA = "0x1819BE820")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x19BE480", Offset = "0x19BCA80", VA = "0x1819BE480")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x19BE9F0", Offset = "0x19BCFF0", VA = "0x1819BE9F0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x19BDB60", Offset = "0x19BC160", VA = "0x1819BDB60")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x19BE970", Offset = "0x19BCF70", VA = "0x1819BE970")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x19BE950", Offset = "0x19BCF50", VA = "0x1819BE950")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x19BE360", Offset = "0x19BC960", VA = "0x1819BE360")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x19BD950", Offset = "0x19BBF50", VA = "0x1819BD950")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x19BDA40", Offset = "0x19BC040", VA = "0x1819BDA40")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x19BEC80", Offset = "0x19BD280", VA = "0x1819BEC80")]
		public Grounding()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public IKSolverAim solver;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x18F7680", Offset = "0x18F5C80", VA = "0x1818F7680", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x18F7600", Offset = "0x18F5C00", VA = "0x1818F7600", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x18F7640", Offset = "0x18F5C40", VA = "0x1818F7640")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x18F76C0", Offset = "0x18F5CC0", VA = "0x1818F76C0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x18F75C0", Offset = "0x18F5BC0", VA = "0x1818F75C0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x18F7700", Offset = "0x18F5D00", VA = "0x1818F7700")]
		public AimIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	public class ArmIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public IKSolverArm solver;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x18F9C40", Offset = "0x18F8240", VA = "0x1818F9C40", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x18F9C00", Offset = "0x18F8200", VA = "0x1818F9C00", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x18F9C80", Offset = "0x18F8280", VA = "0x1818F9C80")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x18F9BC0", Offset = "0x18F81C0", VA = "0x1818F9BC0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x18F9CC0", Offset = "0x18F82C0", VA = "0x1818F9CC0")]
		public ArmIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public IKSolverCCD solver;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x190B920", Offset = "0x1909F20", VA = "0x18190B920", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x190B8E0", Offset = "0x1909EE0", VA = "0x18190B8E0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x190B960", Offset = "0x1909F60", VA = "0x18190B960")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x190B8A0", Offset = "0x1909EA0", VA = "0x18190B8A0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x190B9A0", Offset = "0x1909FA0", VA = "0x18190B9A0")]
		public CCDIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public IKSolverFABRIK solver;

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1963070", Offset = "0x1961670", VA = "0x181963070", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1963030", Offset = "0x1961630", VA = "0x181963030", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x19630B0", Offset = "0x19616B0", VA = "0x1819630B0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1962FF0", Offset = "0x19615F0", VA = "0x181962FF0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x19630F0", Offset = "0x19616F0", VA = "0x1819630F0")]
		public FABRIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public IKSolverFABRIKRoot solver;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1962F00", Offset = "0x1961500", VA = "0x181962F00", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1962EC0", Offset = "0x19614C0", VA = "0x181962EC0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1962F40", Offset = "0x1961540", VA = "0x181962F40")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1962E80", Offset = "0x1961480", VA = "0x181962E80")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1962F80", Offset = "0x1961580", VA = "0x181962F80")]
		public FABRIKRoot()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public BipedReferences references;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public IKSolverFullBodyBiped solver;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1970520", Offset = "0x196EB20", VA = "0x181970520", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x19704A0", Offset = "0x196EAA0", VA = "0x1819704A0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x19704E0", Offset = "0x196EAE0", VA = "0x1819704E0")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1970460", Offset = "0x196EA60", VA = "0x181970460")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1970CD0", Offset = "0x196F2D0", VA = "0x181970CD0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1970330", Offset = "0x196E930", VA = "0x181970330")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1970C80", Offset = "0x196F280", VA = "0x181970C80")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x684420", Offset = "0x682A20", VA = "0x180684420", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1970560", Offset = "0x196EB60", VA = "0x181970560")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x19707F0", Offset = "0x196EDF0", VA = "0x1819707F0")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1970C20", Offset = "0x196F220", VA = "0x181970C20")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1970370", Offset = "0x196E970", VA = "0x181970370")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1970D10", Offset = "0x196F310", VA = "0x181970D10")]
		public FullBodyBipedIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public abstract class IK : SolverManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract IKSolver GetIKSolver();

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x19D5A80", Offset = "0x19D4080", VA = "0x1819D5A80", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x19D5A10", Offset = "0x19D4010", VA = "0x1819D5A10", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x19D59A0", Offset = "0x19D3FA0", VA = "0x1819D59A0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void OpenUserManual();

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void OpenScriptReference();

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x19D5B60", Offset = "0x19D4160", VA = "0x1819D5B60")]
		protected IK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private bool fixedFrame;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool animatePhysics
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x19C70A0", Offset = "0x19C56A0", VA = "0x1819C70A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x19C6FF0", Offset = "0x19C55F0", VA = "0x1819C6FF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x19C7070", Offset = "0x19C5670", VA = "0x1819C7070")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x19C6EA0", Offset = "0x19C54A0", VA = "0x1819C6EA0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x19C6ED0", Offset = "0x19C54D0", VA = "0x1819C6ED0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x19C6DF0", Offset = "0x19C53F0", VA = "0x1819C6DF0")]
		private void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public IKExecutionOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public IKSolverLeg solver;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x17CAA00", Offset = "0x17C9000", VA = "0x1817CAA00", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x17CA9C0", Offset = "0x17C8FC0", VA = "0x1817CA9C0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x17CAA40", Offset = "0x17C9040", VA = "0x1817CAA40")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x17CA980", Offset = "0x17C8F80", VA = "0x1817CA980")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x17CAA80", Offset = "0x17C9080", VA = "0x1817CAA80")]
		public LegIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class LimbIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public IKSolverLimb solver;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x17CAB70", Offset = "0x17C9170", VA = "0x1817CAB70", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x17CAB30", Offset = "0x17C9130", VA = "0x1817CAB30", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x17CABB0", Offset = "0x17C91B0", VA = "0x1817CABB0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x17CAAF0", Offset = "0x17C90F0", VA = "0x1817CAAF0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x17CABF0", Offset = "0x17C91F0", VA = "0x1817CABF0")]
		public LimbIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public IKSolverLookAt solver;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x17CBD10", Offset = "0x17CA310", VA = "0x1817CBD10", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x17CBCD0", Offset = "0x17CA2D0", VA = "0x1817CBCD0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x17CBD50", Offset = "0x17CA350", VA = "0x1817CBD50")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x17CBC90", Offset = "0x17CA290", VA = "0x1817CBC90")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x17CBD90", Offset = "0x17CA390", VA = "0x1817CBD90")]
		public LookAtIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public IKSolverTrigonometric solver;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x160DF50", Offset = "0x160C550", VA = "0x18160DF50", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x160DF10", Offset = "0x160C510", VA = "0x18160DF10", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x160DF90", Offset = "0x160C590", VA = "0x18160DF90")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x160DED0", Offset = "0x160C4D0", VA = "0x18160DED0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x160DFD0", Offset = "0x160C5D0", VA = "0x18160DFD0")]
		public TrigonometricIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public class References
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public Transform root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public Transform pelvis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public Transform spine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			[Tooltip("Optional")]
			public Transform chest;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			[Tooltip("Optional")]
			public Transform neck;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public Transform head;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			[Tooltip("Optional")]
			public Transform leftShoulder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public Transform leftUpperArm;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public Transform leftForearm;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public Transform leftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			[Tooltip("Optional")]
			public Transform rightShoulder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public Transform rightUpperArm;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public Transform rightForearm;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public Transform rightHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			[Tooltip("Optional")]
			public Transform leftToes;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			[Tooltip("Optional")]
			public Transform rightToes;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public bool isFilled
			{
				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x1CD0B50", Offset = "0x1CCF150", VA = "0x181CD0B50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public bool isEmpty
			{
				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x1CD0640", Offset = "0x1CCEC40", VA = "0x181CD0640")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x1CCFDE0", Offset = "0x1CCE3E0", VA = "0x181CCFDE0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x1CCF8F0", Offset = "0x1CCDEF0", VA = "0x181CCF8F0")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public References()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		public References references;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x16191D0", Offset = "0x16177D0", VA = "0x1816191D0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1619150", Offset = "0x1617750", VA = "0x181619150", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1619190", Offset = "0x1617790", VA = "0x181619190")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x1619070", Offset = "0x1617670", VA = "0x181619070")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x16190A0", Offset = "0x16176A0", VA = "0x1816190A0")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x684420", Offset = "0x682A20", VA = "0x180684420", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x16190D0", Offset = "0x16176D0", VA = "0x1816190D0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1619210", Offset = "0x1617810", VA = "0x181619210", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1619380", Offset = "0x1617980", VA = "0x181619380")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class FABRIKChain
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public FABRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[Range(0f, 1f)]
		public float pull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[Range(0f, 1f)]
		public float pin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int[] children;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1962A80", Offset = "0x1961080", VA = "0x181962A80")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1962A50", Offset = "0x1961050", VA = "0x181962A50")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1962B60", Offset = "0x1961160", VA = "0x181962B60")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1962CA0", Offset = "0x19612A0", VA = "0x181962CA0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1962730", Offset = "0x1960D30", VA = "0x181962730")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1962E20", Offset = "0x1961420", VA = "0x181962E20")]
		public FABRIKChain()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Vector3 bendDirectionOffsetLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public Vector3 bendDirectionOffsetRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public Vector3 characterSpaceBendOffsetRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private Quaternion leftHandTargetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private Quaternion rightHandTargetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private bool initiated;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1963160", Offset = "0x1961760", VA = "0x181963160")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1963950", Offset = "0x1961F50", VA = "0x181963950")]
		private void OnPostFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1963830", Offset = "0x1961E30", VA = "0x181963830")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public FBBIKArmBending()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class BendBone
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			private Quaternion defaultLocalRotation;

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x1602700", Offset = "0x1600D00", VA = "0x181602700")]
			public BendBone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x1602740", Offset = "0x1600D40", VA = "0x181602740")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x16026C0", Offset = "0x1600CC0", VA = "0x1816026C0")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x1602680", Offset = "0x1600C80", VA = "0x181602680")]
			public void FixTransforms()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[Range(0f, 1f)]
		[Tooltip("Master weight for positioning the head.")]
		[LargeHeader("Position")]
		public float positionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the body along with the head")]
		public float bodyWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the thighs along with the head")]
		public float thighWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the head bone after solving")]
		[LargeHeader("Rotation")]
		public float rotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the body")]
		public float bodyClampWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		[Range(0f, 1f)]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[LargeHeader("CCD")]
		public float CCDWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
		public float damper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[LargeHeader("Stretching")]
		[Range(0f, 1f)]
		public float postStretchWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public Transform[] chestBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private Vector3 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private Vector3 headToBody;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private Vector3 shoulderCenterToHead;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private Vector3 headToLeftThigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private Vector3 headToRightThigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private Vector3 leftShoulderPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private Vector3 rightShoulderPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private float shoulderDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private float leftShoulderDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private float rightShoulderDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private Quaternion chestRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private Quaternion headRotationRelativeToRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private Vector3 headLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private Quaternion headLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private Vector3[] stretchLocalPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private Quaternion[] stretchLocalRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private Vector3[] chestLocalPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private Quaternion[] chestLocalRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private int bendBonesCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private int ccdBonesCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private int stretchBonesCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private int chestBonesCount;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x19677E0", Offset = "0x1965DE0", VA = "0x1819677E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1966790", Offset = "0x1964D90", VA = "0x181966790")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1965650", Offset = "0x1963C50", VA = "0x181965650")]
		private void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1965DD0", Offset = "0x19643D0", VA = "0x181965DD0")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1967410", Offset = "0x1965A10", VA = "0x181967410")]
		private void SpineBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1963B50", Offset = "0x1962150", VA = "0x181963B50")]
		private void CCDPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1964290", Offset = "0x1962890", VA = "0x181964290")]
		private void Iterate(int iteration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1965BD0", Offset = "0x19641D0", VA = "0x181965BD0")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1963FF0", Offset = "0x19625F0", VA = "0x181963FF0")]
		private void ChestDirection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1966E50", Offset = "0x1965450", VA = "0x181966E50")]
		private void PostStretching()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x19650E0", Offset = "0x19636E0", VA = "0x1819650E0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1967280", Offset = "0x1965880", VA = "0x181967280")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x19652B0", Offset = "0x19638B0", VA = "0x1819652B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1967C10", Offset = "0x1966210", VA = "0x181967C10")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class FBIKChain
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public class ChildConstraint
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			public float pushElasticity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400026C")]
			public float pullElasticity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400026D")]
			[SerializeField]
			private Transform bone1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			[SerializeField]
			private Transform bone2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			private float crossFade;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			private float inverseCrossFade;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			private int chain1Index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000274")]
			private int chain2Index;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public float nominalDistance
			{
				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0xA7F710", Offset = "0xA7DD10", VA = "0x180A7F710")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0xA7FC10", Offset = "0xA7E210", VA = "0x180A7FC10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public bool isRigid
			{
				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x886E00", Offset = "0x885400", VA = "0x180886E00")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0xB0FE70", Offset = "0xB0E470", VA = "0x180B0FE70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x1604F80", Offset = "0x1603580", VA = "0x181604F80")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x1604920", Offset = "0x1602F20", VA = "0x181604920")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x1604980", Offset = "0x1602F80", VA = "0x181604980")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x1604BC0", Offset = "0x16031C0", VA = "0x181604BC0")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public enum Smoothing
		{
			[Cpp2IlInjected.Token(Token = "0x4000276")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			Exponential,
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			Cubic
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		[Range(0f, 1f)]
		public float pin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		[Range(0f, 1f)]
		public float pull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		[Range(0f, 1f)]
		public float push;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		[Range(0f, 1f)]
		public float reach;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public Smoothing reachSmoothing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public Smoothing pushSmoothing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public IKSolver.Node[] nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int[] children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public ChildConstraint[] childConstraints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public IKConstraintBend bendConstraint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private float rootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private bool initiated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private float length;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private float distance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private IKSolver.Point p;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private float reachForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private float pullParentSum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private float[] crossFades;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private float sqrMag1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private float sqrMag2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private float sqrMagDif;

		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private const float maxLimbLength = 0.99999f;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x196BC00", Offset = "0x196A200", VA = "0x18196BC00")]
		public FBIKChain()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x196B980", Offset = "0x1969F80", VA = "0x18196B980")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x196A4C0", Offset = "0x1968AC0", VA = "0x18196A4C0")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1969220", Offset = "0x1967820", VA = "0x181969220")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x19694E0", Offset = "0x1967AE0", VA = "0x1819694E0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1969310", Offset = "0x1967910", VA = "0x181969310")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1969E90", Offset = "0x1968490", VA = "0x181969E90")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x19686D0", Offset = "0x1966CD0", VA = "0x1819686D0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1969A70", Offset = "0x1968070", VA = "0x181969A70")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1969610", Offset = "0x1967C10", VA = "0x181969610")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x196ACF0", Offset = "0x19692F0", VA = "0x18196ACF0")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x196B220", Offset = "0x1969820", VA = "0x18196B220")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x196B7F0", Offset = "0x1969DF0", VA = "0x18196B7F0")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x196A6B0", Offset = "0x1968CB0", VA = "0x18196A6B0")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x196A9E0", Offset = "0x1968FE0", VA = "0x18196A9E0")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1969050", Offset = "0x1967650", VA = "0x181969050")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x196A620", Offset = "0x1968C20", VA = "0x18196A620")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x196AB00", Offset = "0x1969100", VA = "0x18196AB00")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x1968E70", Offset = "0x1967470", VA = "0x181968E70")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x19683D0", Offset = "0x19669D0", VA = "0x1819683D0")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class IKConstraintBend
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public Transform bone1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public Transform bone2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public Transform bone3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public Transform bendGoal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public Vector3 direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public Quaternion rotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public Vector3 defaultLocalDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public float clampF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private int chainIndex1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private int nodeIndex1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private int chainIndex2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private int nodeIndex2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private int chainIndex3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private int nodeIndex3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x85")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private bool limbOrientationsSet;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xF77FE0", Offset = "0xF765E0", VA = "0x180F77FE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x1202EB0", Offset = "0x12014B0", VA = "0x181202EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x19C3B10", Offset = "0x19C2110", VA = "0x1819C3B10")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x19C4810", Offset = "0x19C2E10", VA = "0x1819C4810")]
		public IKConstraintBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x19C4850", Offset = "0x19C2E50", VA = "0x1819C4850")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x961710", Offset = "0x95FD10", VA = "0x180961710")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x19C34E0", Offset = "0x19C1AE0", VA = "0x1819C34E0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x19C4600", Offset = "0x19C2C00", VA = "0x1819C4600")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x19C3D60", Offset = "0x19C2360", VA = "0x1819C3D60")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x19C2B80", Offset = "0x19C1180", VA = "0x1819C2B80")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x19C4460", Offset = "0x19C2A60", VA = "0x1819C4460")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x19C42C0", Offset = "0x19C28C0", VA = "0x1819C42C0")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class IKEffector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public Vector3 positionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public bool effectChildNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public Transform[] childBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public Transform planeBone1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public Transform planeBone2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public Transform planeBone3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public Quaternion planeRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private float posW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private float rotW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private Vector3[] localPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private bool usePlaneNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private Quaternion animatedPlaneRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private Vector3 animatedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private bool firstUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private int chainIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private int nodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private int plane1ChainIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private int plane1NodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private int plane2ChainIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private int plane2NodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private int plane3ChainIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private int plane3NodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private int[] childChainIndexes;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private int[] childNodeIndexes;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool isEndEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x8ADED0", Offset = "0x8AC4D0", VA = "0x1808ADED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x8ADEE0", Offset = "0x8AC4E0", VA = "0x1808ADEE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x19C48E0", Offset = "0x19C2EE0", VA = "0x1819C48E0")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x19C62C0", Offset = "0x19C48C0", VA = "0x1819C62C0")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x19C6B00", Offset = "0x19C5100", VA = "0x1819C6B00")]
		public IKEffector()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x19C6C50", Offset = "0x19C5250", VA = "0x1819C6C50")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x19C5610", Offset = "0x19C3C10", VA = "0x1819C5610")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x19C5160", Offset = "0x19C3760", VA = "0x1819C5160")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x19C6370", Offset = "0x19C4970", VA = "0x1819C6370")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x19C6550", Offset = "0x19C4B50", VA = "0x1819C6550")]
		public void SetToTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x19C59A0", Offset = "0x19C3FA0", VA = "0x1819C59A0")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x19C5970", Offset = "0x19C3F70", VA = "0x1819C5970")]
		public void OnPostWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x19C4950", Offset = "0x19C2F50", VA = "0x1819C4950")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x19C6600", Offset = "0x19C4C00", VA = "0x1819C6600")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x19C4CF0", Offset = "0x19C32F0", VA = "0x1819C4CF0")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class IKMapping
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public class BoneMap
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public int chainIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			public int nodeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public Vector3 defaultLocalPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public Quaternion defaultLocalRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public Vector3 localSwingAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public Vector3 localTwistAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public Vector3 planePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public Vector3 ikPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public Quaternion defaultLocalTargetRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			private Quaternion maintainRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public Quaternion animatedRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			private Transform planeBone1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			private Transform planeBone2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private Transform planeBone3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			private int plane1ChainIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			private int plane1NodeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			private int plane2ChainIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			private int plane2NodeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40002BF")]
			private int plane3ChainIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
			[Cpp2IlInjected.Token(Token = "0x40002C0")]
			private int plane3NodeIndex;

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public Vector3 swingDirection
			{
				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x16048B0", Offset = "0x1602EB0", VA = "0x1816048B0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public bool isNodeBone
			{
				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x1604680", Offset = "0x1602C80", VA = "0x181604680")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0x1604690", Offset = "0x1602C90", VA = "0x181604690")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x1603340", Offset = "0x1601940", VA = "0x181603340")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x1603D30", Offset = "0x1602330", VA = "0x181603D30")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x1603020", Offset = "0x1601620", VA = "0x181603020")]
			public void FixTransform(bool position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x1603800", Offset = "0x1601E00", VA = "0x181603800")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x16038B0", Offset = "0x1601EB0", VA = "0x1816038B0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x16039F0", Offset = "0x1601FF0", VA = "0x1816039F0")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x1603B40", Offset = "0x1602140", VA = "0x181603B40")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x1603BE0", Offset = "0x16021E0", VA = "0x181603BE0")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x16042E0", Offset = "0x16028E0", VA = "0x1816042E0")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x16037C0", Offset = "0x1601DC0", VA = "0x1816037C0")]
			public void SetIKPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x16033A0", Offset = "0x16019A0", VA = "0x1816033A0")]
			public void MaintainRotation()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x1603CF0", Offset = "0x16022F0", VA = "0x181603CF0")]
			public void SetToIKPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x1602EB0", Offset = "0x16014B0", VA = "0x181602EB0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x1603080", Offset = "0x1601680", VA = "0x181603080")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x16033E0", Offset = "0x16019E0", VA = "0x1816033E0")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x16036F0", Offset = "0x1601CF0", VA = "0x1816036F0")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x1603F80", Offset = "0x1602580", VA = "0x181603F80")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1603D90", Offset = "0x1602390", VA = "0x181603D90")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1604160", Offset = "0x1602760", VA = "0x181604160")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x1603660", Offset = "0x1601C60", VA = "0x181603660")]
			public void RotateToMaintain(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x1603520", Offset = "0x1601B20", VA = "0x181603520")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x1603190", Offset = "0x1601790", VA = "0x181603190")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x1604650", Offset = "0x1602C50", VA = "0x181604650")]
			public BoneMap()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x19CA660", Offset = "0x19C8C60", VA = "0x1819CA660")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x196A9E0", Offset = "0x1968FE0", VA = "0x18196A9E0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class IKMappingBone : IKMapping
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private BoneMap boneMap;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x19C7200", Offset = "0x19C5800", VA = "0x1819C7200", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x19C7310", Offset = "0x19C5910", VA = "0x1819C7310")]
		public IKMappingBone()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x19C7380", Offset = "0x19C5980", VA = "0x1819C7380")]
		public IKMappingBone(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x19C72C0", Offset = "0x19C58C0", VA = "0x1819C72C0")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x19C7130", Offset = "0x19C5730", VA = "0x1819C7130")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x19C7160", Offset = "0x19C5760", VA = "0x1819C7160", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x19C72A0", Offset = "0x19C58A0", VA = "0x1819C72A0")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x19C72E0", Offset = "0x19C58E0", VA = "0x1819C72E0")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public enum BoneMapType
		{
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			Parent,
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			Bone1,
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			Bone2,
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			Bone3
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public Transform parentBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public Transform bone1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public Transform bone2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public Transform bone3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		[Range(0f, 1f)]
		public float weight;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public bool updatePlaneRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private BoneMap boneMapParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private BoneMap boneMap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private BoneMap boneMap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private BoneMap boneMap3;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x19C7850", Offset = "0x19C5E50", VA = "0x1819C7850", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x19C74D0", Offset = "0x19C5AD0", VA = "0x1819C74D0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x19C7BA0", Offset = "0x19C61A0", VA = "0x1819C7BA0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x19C8330", Offset = "0x19C6930", VA = "0x1819C8330")]
		public IKMappingLimb()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x19C81E0", Offset = "0x19C67E0", VA = "0x1819C81E0")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x19C7B30", Offset = "0x19C6130", VA = "0x1819C7B30")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x19C7FA0", Offset = "0x19C65A0", VA = "0x1819C7FA0")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x19C7410", Offset = "0x19C5A10", VA = "0x1819C7410")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x19C75A0", Offset = "0x19C5BA0", VA = "0x1819C75A0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x19C7AB0", Offset = "0x19C60B0", VA = "0x1819C7AB0")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x19C8050", Offset = "0x19C6650", VA = "0x1819C8050")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class IKMappingSpine : IKMapping
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public Transform[] spineBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public Transform leftUpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public Transform rightUpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public Transform leftThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Transform rightThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[Range(1f, 3f)]
		public int iterations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private int rootNodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private BoneMap[] spine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private BoneMap leftUpperArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private BoneMap rightUpperArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private BoneMap leftThigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private BoneMap rightThigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private bool useFABRIK;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x19C9120", Offset = "0x19C7720", VA = "0x1819C9120", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x19CA3B0", Offset = "0x19C89B0", VA = "0x1819CA3B0")]
		public IKMappingSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x19CA4D0", Offset = "0x19C8AD0", VA = "0x1819CA4D0")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x19C9D50", Offset = "0x19C8350", VA = "0x1819C9D50")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x19C9DD0", Offset = "0x19C83D0", VA = "0x1819C9DD0")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x19C8600", Offset = "0x19C6C00", VA = "0x1819C8600")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x19C8890", Offset = "0x19C6E90", VA = "0x1819C8890", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x19C9E50", Offset = "0x19C8450", VA = "0x1819C9E50")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x19C9970", Offset = "0x19C7F70", VA = "0x1819C9970")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x19C9E80", Offset = "0x19C8480", VA = "0x1819C9E80")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x19C86A0", Offset = "0x19C6CA0", VA = "0x1819C86A0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x19C8420", Offset = "0x19C6A20", VA = "0x1819C8420")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x19C9540", Offset = "0x19C7B40", VA = "0x1819C9540")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public abstract class IKSolver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public class Point
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			[Range(0f, 1f)]
			public float weight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public Vector3 solverPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public Quaternion solverRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			public Vector3 defaultLocalPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			public Quaternion defaultLocalRotation;

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x1A5C620", Offset = "0x1A5AC20", VA = "0x181A5C620")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x1A5C530", Offset = "0x1A5AB30", VA = "0x181A5C530")]
			public void FixTransform()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x1A5C720", Offset = "0x1A5AD20", VA = "0x181A5C720")]
			public void UpdateSolverPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x1A5C680", Offset = "0x1A5AC80", VA = "0x181A5C680")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x1A5C760", Offset = "0x1A5AD60", VA = "0x181A5C760")]
			public void UpdateSolverState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x1A5C6C0", Offset = "0x1A5ACC0", VA = "0x181A5C6C0")]
			public void UpdateSolverLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B5E0", Offset = "0x1A59BE0", VA = "0x181A5B5E0")]
			public Point()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public class Bone : Point
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			public float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			public float sqrMag;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			public Vector3 axis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			private RotationLimit _rotationLimit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			private bool isLimited;

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public RotationLimit rotationLimit
			{
				[Cpp2IlInjected.Token(Token = "0x6000335")]
				[Cpp2IlInjected.Address(RVA = "0x1A51E40", Offset = "0x1A50440", VA = "0x181A51E40")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x1A51F40", Offset = "0x1A50540", VA = "0x181A51F40")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x1A51A00", Offset = "0x1A50000", VA = "0x181A51A00")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x1A51540", Offset = "0x1A4FB40", VA = "0x181A51540")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x1A51820", Offset = "0x1A4FE20", VA = "0x181A51820")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x1A51500", Offset = "0x1A4FB00", VA = "0x181A51500")]
			public void SetToSolverPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x1A51DB0", Offset = "0x1A503B0", VA = "0x181A51DB0")]
			public Bone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x1A51C40", Offset = "0x1A50240", VA = "0x181A51C40")]
			public Bone(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x1A51CF0", Offset = "0x1A502F0", VA = "0x181A51CF0")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public class Node : Point
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			public float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			public float effectorPositionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			public float effectorRotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			public Vector3 offset;

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B5E0", Offset = "0x1A59BE0", VA = "0x181A5B5E0")]
			public Node()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B620", Offset = "0x1A59C20", VA = "0x181A5B620")]
			public Node(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B580", Offset = "0x1A59B80", VA = "0x181A5B580")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public delegate void UpdateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void IterationDelegate(int i);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[HideInInspector]
		public bool executedInEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public UpdateDelegate OnPreInitiate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public UpdateDelegate OnPostInitiate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public UpdateDelegate OnPreUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public UpdateDelegate OnPostUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		protected bool firstInitiation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x73E420", Offset = "0x73CA20", VA = "0x18073E420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x73E5F0", Offset = "0x73CBF0", VA = "0x18073E5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x19D53E0", Offset = "0x19D39E0", VA = "0x1819D53E0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool IsValid(ref string message);

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x19D5260", Offset = "0x19D3860", VA = "0x1819D5260")]
		public void Initiate(Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x19D5910", Offset = "0x19D3F10", VA = "0x1819D5910")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x16084A0", Offset = "0x1606AA0", VA = "0x1816084A0", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1608690", Offset = "0x1606C90", VA = "0x181608690")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x73E3C0", Offset = "0x73C9C0", VA = "0x18073E3C0")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x19D58E0", Offset = "0x19D3EE0", VA = "0x1819D58E0")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x687C20", Offset = "0x686220", VA = "0x180687C20")]
		public Transform GetRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract Point[] GetPoints();

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract Point GetPoint(Transform transform);

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void FixTransforms();

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void StoreDefaultLocalState();

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void OnInitiate();

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void OnUpdate();

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x19D5440", Offset = "0x19D3A40", VA = "0x1819D5440")]
		protected void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x19D5060", Offset = "0x19D3660", VA = "0x1819D5060")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x19D51B0", Offset = "0x19D37B0", VA = "0x1819D51B0")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x19D5460", Offset = "0x19D3A60", VA = "0x1819D5460")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x19D5980", Offset = "0x19D3F80", VA = "0x1819D5980")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public Vector3 axis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public Vector3 poleAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public Vector3 polePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public Transform poleTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xB15D0", Offset = "0xB09D0")]
		public int clampSmoothing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public IterationDelegate OnPreIteration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private float step;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private Vector3 clampedIKPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private RotationLimit transformLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private Transform lastTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 transformAxis
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x19CC230", Offset = "0x19CA830", VA = "0x1819CC230")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector3 transformPoleAxis
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x19CC2B0", Offset = "0x19CA8B0", VA = "0x1819CC2B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected override int minBones
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x677270", Offset = "0x675870", VA = "0x180677270", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected override Vector3 localDirection
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x19CC160", Offset = "0x19CA760", VA = "0x1819CC160", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x19CA7A0", Offset = "0x19C8DA0", VA = "0x1819CA7A0")]
		public float GetAngle()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x19CAE00", Offset = "0x19C9400", VA = "0x1819CAE00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x19CB1C0", Offset = "0x19C97C0", VA = "0x1819CB1C0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x19CBFB0", Offset = "0x19CA5B0", VA = "0x1819CBFB0")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x19CA8C0", Offset = "0x19C8EC0", VA = "0x1819CA8C0")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x19CB920", Offset = "0x19C9F20", VA = "0x1819CB920")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x19CC0F0", Offset = "0x19CA6F0", VA = "0x1819CC0F0")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class IKSolverArm : IKSolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public Quaternion IKRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public Point chest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public Point shoulder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public Point upperArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public Point forearm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public Point hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public bool isLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public IKSolverVR.Arm arm;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private Vector3[] positions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private Quaternion[] rotations;

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x19CC7E0", Offset = "0x19CADE0", VA = "0x1819CC7E0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x19CD3F0", Offset = "0x19CB9F0", VA = "0x1819CD3F0")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x19CC5B0", Offset = "0x19CABB0", VA = "0x1819CC5B0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x19CC3A0", Offset = "0x19CA9A0", VA = "0x1819CC3A0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x19CD550", Offset = "0x19CBB50", VA = "0x1819CD550", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x19CC330", Offset = "0x19CA930", VA = "0x1819CC330", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x19CCDA0", Offset = "0x19CB3A0", VA = "0x1819CCDA0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x19CCE20", Offset = "0x19CB420", VA = "0x1819CCE20", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x19CD4C0", Offset = "0x19CBAC0", VA = "0x1819CD4C0")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x19CCEC0", Offset = "0x19CB4C0", VA = "0x1819CCEC0")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x19CD5B0", Offset = "0x19CBBB0", VA = "0x1819CD5B0")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x19CD840", Offset = "0x19CBE40", VA = "0x1819CD840")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public IterationDelegate OnPreIteration;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x19CDA10", Offset = "0x19CC010", VA = "0x1819CDA10")]
		public void FadeOutBoneWeights()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x19CDAF0", Offset = "0x19CC0F0", VA = "0x1819CDAF0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x19CDB80", Offset = "0x19CC180", VA = "0x1819CDB80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x19CDEA0", Offset = "0x19CC4A0", VA = "0x1819CDEA0")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x19CE810", Offset = "0x19CCE10", VA = "0x1819CE810")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public IterationDelegate OnPreIteration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private bool[] limitedBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private Vector3[] solverLocalPositions;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected override bool boneLengthCanBeZero
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x19D2BC0", Offset = "0x19D11C0", VA = "0x1819D2BC0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x19D2AF0", Offset = "0x19D10F0", VA = "0x1819D2AF0")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x19D0CA0", Offset = "0x19CF2A0", VA = "0x1819D0CA0", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x19D1CE0", Offset = "0x19D02E0", VA = "0x1819D1CE0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x19D27E0", Offset = "0x19D0DE0", VA = "0x1819D27E0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x19D2C70", Offset = "0x19D1270", VA = "0x1819D2C70")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x19D2210", Offset = "0x19D0810", VA = "0x1819D2210")]
		private void OnPreSolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x19D20C0", Offset = "0x19D06C0", VA = "0x1819D20C0")]
		private void OnPostSolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x19D2DB0", Offset = "0x19D13B0", VA = "0x1819D2DB0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x19D09B0", Offset = "0x19CEFB0", VA = "0x1819D09B0")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x19D3030", Offset = "0x19D1630", VA = "0x1819D3030")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x19D31B0", Offset = "0x19D17B0", VA = "0x1819D31B0")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x19D30F0", Offset = "0x19D16F0", VA = "0x1819D30F0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x19D2E60", Offset = "0x19D1460", VA = "0x1819D2E60")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x19D1030", Offset = "0x19CF630", VA = "0x1819D1030")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x19D0EB0", Offset = "0x19CF4B0", VA = "0x1819D0EB0")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x19D0D50", Offset = "0x19CF350", VA = "0x1819D0D50")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x19D11A0", Offset = "0x19CF7A0", VA = "0x1819D11A0")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x19D0970", Offset = "0x19CEF70", VA = "0x1819D0970")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x19D0780", Offset = "0x19CED80", VA = "0x1819D0780")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x19D0040", Offset = "0x19CE640", VA = "0x1819D0040")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x19D1B20", Offset = "0x19D0120", VA = "0x1819D1B20")]
		private void MapToSolverPositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x19D1A20", Offset = "0x19D0020", VA = "0x1819D1A20")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x19D3290", Offset = "0x19D1890", VA = "0x1819D3290")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public int iterations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[Range(0f, 1f)]
		public float rootPin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public FABRIKChain[] chains;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private bool zeroWeightApplied;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private bool[] isRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private Vector3 rootDefaultPosition;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x19CF1A0", Offset = "0x19CD7A0", VA = "0x1819CF1A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x19CFF00", Offset = "0x19CE500", VA = "0x1819CFF00", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x19CE990", Offset = "0x19CCF90", VA = "0x1819CE990", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x19CFAE0", Offset = "0x19CE0E0", VA = "0x1819CFAE0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x19CF100", Offset = "0x19CD700", VA = "0x1819CF100")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x19CFCA0", Offset = "0x19CE2A0", VA = "0x1819CFCA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x19CEEF0", Offset = "0x19CD4F0", VA = "0x1819CEEF0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x19CEE40", Offset = "0x19CD440", VA = "0x1819CEE40", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x19CE820", Offset = "0x19CCE20", VA = "0x1819CE820")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x19CEA60", Offset = "0x19CD060", VA = "0x1819CEA60")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x19CFFD0", Offset = "0x19CE5D0", VA = "0x1819CFFD0")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class IKSolverFullBody : IKSolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		[Range(0f, 10f)]
		public int iterations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public FBIKChain[] chain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public IKEffector[] effectors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public IKMappingSpine spineMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public IKMappingBone[] boneMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public IKMappingLimb[] limbMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public bool FABRIKPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public UpdateDelegate OnPreRead;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public UpdateDelegate OnPreSolve;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public IterationDelegate OnPreIteration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public IterationDelegate OnPostIteration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public UpdateDelegate OnPreBend;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public UpdateDelegate OnPostSolve;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public UpdateDelegate OnFixTransforms;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x19D37F0", Offset = "0x19D1DF0", VA = "0x1819D37F0")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x19D37A0", Offset = "0x19D1DA0", VA = "0x1819D37A0")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x19D3670", Offset = "0x19D1C70", VA = "0x1819D3670")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x19D3910", Offset = "0x19D1F10", VA = "0x1819D3910")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x19D35E0", Offset = "0x19D1BE0", VA = "0x1819D35E0")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x19D3B10", Offset = "0x19D2110", VA = "0x1819D3B10", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x19D3980", Offset = "0x19D1F80", VA = "0x1819D3980", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x19D3CC0", Offset = "0x19D22C0", VA = "0x1819D3CC0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x19D4AB0", Offset = "0x19D30B0", VA = "0x1819D4AB0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x19D3360", Offset = "0x19D1960", VA = "0x1819D3360", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x19D3F60", Offset = "0x19D2560", VA = "0x1819D3F60", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x19D4130", Offset = "0x19D2730", VA = "0x1819D4130", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x19D42F0", Offset = "0x19D28F0", VA = "0x1819D42F0", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x19D46D0", Offset = "0x19D2CD0", VA = "0x1819D46D0", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x19D3310", Offset = "0x19D1910", VA = "0x1819D3310", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x19D4CF0", Offset = "0x19D32F0", VA = "0x1819D4CF0", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x19D4E30", Offset = "0x19D3430", VA = "0x1819D4E30")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum FullBodyBipedEffector
	{
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		Body,
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		LeftShoulder,
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		RightShoulder,
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		LeftThigh,
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		RightThigh,
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		LeftHand,
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		RightHand,
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		LeftFoot,
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		RightFoot
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum FullBodyBipedChain
	{
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		LeftArm,
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		RightArm,
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		LeftLeg,
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		RightLeg
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public Transform rootNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private Vector3 offset;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public IKEffector bodyEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x1A02510", Offset = "0x1A00B10", VA = "0x181A02510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public IKEffector leftShoulderEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x1A026D0", Offset = "0x1A00CD0", VA = "0x181A026D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public IKEffector rightShoulderEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x1A028F0", Offset = "0x1A00EF0", VA = "0x181A028F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public IKEffector leftThighEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x1A02710", Offset = "0x1A00D10", VA = "0x181A02710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public IKEffector rightThighEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x1A02930", Offset = "0x1A00F30", VA = "0x181A02930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IKEffector leftHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x1A02610", Offset = "0x1A00C10", VA = "0x181A02610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public IKEffector rightHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x1A02830", Offset = "0x1A00E30", VA = "0x181A02830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public IKEffector leftFootEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x1A025D0", Offset = "0x1A00BD0", VA = "0x181A025D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public IKEffector rightFootEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x1A027F0", Offset = "0x1A00DF0", VA = "0x181A027F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public FBIKChain leftArmChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x1A02550", Offset = "0x1A00B50", VA = "0x181A02550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public FBIKChain rightArmChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x1A02770", Offset = "0x1A00D70", VA = "0x181A02770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public FBIKChain leftLegChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x1A02650", Offset = "0x1A00C50", VA = "0x181A02650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public FBIKChain rightLegChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x1A02870", Offset = "0x1A00E70", VA = "0x181A02870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public IKMappingLimb leftArmMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x1A02590", Offset = "0x1A00B90", VA = "0x181A02590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public IKMappingLimb rightArmMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x1A027B0", Offset = "0x1A00DB0", VA = "0x181A027B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public IKMappingLimb leftLegMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x1A02690", Offset = "0x1A00C90", VA = "0x181A02690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public IKMappingLimb rightLegMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x1A028B0", Offset = "0x1A00EB0", VA = "0x181A028B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IKMappingBone headMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x19FF2B0", Offset = "0x19FD8B0", VA = "0x1819FF2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Vector3 pullBodyOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x1A02750", Offset = "0x1A00D50", VA = "0x181A02750")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x1A02970", Offset = "0x1A00F70", VA = "0x181A02970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x19FFE80", Offset = "0x19FE480", VA = "0x1819FFE80")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x19FFEF0", Offset = "0x19FE4F0", VA = "0x1819FFEF0")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x19FEAE0", Offset = "0x19FD0E0", VA = "0x1819FEAE0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x19FEBB0", Offset = "0x19FD1B0", VA = "0x1819FEBB0")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x19FEDA0", Offset = "0x19FD3A0", VA = "0x1819FEDA0")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x19FEFB0", Offset = "0x19FD5B0", VA = "0x1819FEFB0")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x19FF3B0", Offset = "0x19FD9B0", VA = "0x1819FF3B0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x19FF480", Offset = "0x19FDA80", VA = "0x1819FF480")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x708FA0", Offset = "0x7075A0", VA = "0x180708FA0")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x19FF2B0", Offset = "0x19FD8B0", VA = "0x1819FF2B0")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x19FE740", Offset = "0x19FCD40", VA = "0x1819FE740")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x19FF720", Offset = "0x19FDD20", VA = "0x1819FF720", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1A00320", Offset = "0x19FE920", VA = "0x181A00320")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x19FE320", Offset = "0x19FC920", VA = "0x1819FE320")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1A002B0", Offset = "0x19FE8B0", VA = "0x181A002B0")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x19FFFA0", Offset = "0x19FE5A0", VA = "0x1819FFFA0")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x19FF2F0", Offset = "0x19FD8F0", VA = "0x1819FF2F0")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x19FF660", Offset = "0x19FDC60", VA = "0x1819FF660")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x19FE260", Offset = "0x19FC860", VA = "0x1819FE260")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x19FFB10", Offset = "0x19FE110", VA = "0x1819FFB10", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x19FF8F0", Offset = "0x19FDEF0", VA = "0x1819FF8F0")]
		private void PullBody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x19FE810", Offset = "0x19FCE10", VA = "0x1819FE810")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x19FF080", Offset = "0x19FD680", VA = "0x1819FF080")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x19FDDE0", Offset = "0x19FC3E0", VA = "0x1819FDDE0", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1A023E0", Offset = "0x1A009E0", VA = "0x181A023E0", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1A024F0", Offset = "0x1A00AF0", VA = "0x181A024F0")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class IKSolverHeuristic : IKSolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public float tolerance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int maxIterations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public bool useRotationLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public bool XY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public Bone[] bones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		protected Vector3 lastLocalDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected float chainLength;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected virtual int minBones
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x8C3300", Offset = "0x8C1900", VA = "0x1808C3300", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual bool boneLengthCanBeZero
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual bool allowCommonParent
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual Vector3 localDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x1A04250", Offset = "0x1A02850", VA = "0x181A04250", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected float positionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x1A043F0", Offset = "0x1A029F0", VA = "0x181A043F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1A03CB0", Offset = "0x1A022B0", VA = "0x181A03CB0")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x1A02990", Offset = "0x1A00F90", VA = "0x181A02990")]
		public void AddBone(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x1A04170", Offset = "0x1A02770", VA = "0x181A04170", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1A02B60", Offset = "0x1A01160", VA = "0x181A02B60", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1A03860", Offset = "0x1A01E60", VA = "0x181A03860", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x708FA0", Offset = "0x7075A0", VA = "0x180708FA0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x1A02BF0", Offset = "0x1A011F0", VA = "0x181A02BF0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1A03170", Offset = "0x1A01770", VA = "0x181A03170")]
		protected void InitiateBones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1A02D10", Offset = "0x1A01310", VA = "0x181A02D10")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1A03E90", Offset = "0x1A02490", VA = "0x181A03E90")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1A041F0", Offset = "0x1A027F0", VA = "0x181A041F0")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class IKSolverLeg : IKSolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public Quaternion IKRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public Point pelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public Point thigh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public Point calf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public Point foot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public Point toe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public IKSolverVR.Leg leg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public Vector3 heelOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private Vector3[] positions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private Quaternion[] rotations;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1A048B0", Offset = "0x1A02EB0", VA = "0x181A048B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x19CD3F0", Offset = "0x19CB9F0", VA = "0x1819CD3F0")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x1A04680", Offset = "0x1A02C80", VA = "0x181A04680", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x1A04470", Offset = "0x1A02A70", VA = "0x181A04470", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x19CD550", Offset = "0x19CBB50", VA = "0x1819CD550", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x19CC330", Offset = "0x19CA930", VA = "0x1819CC330", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1A04D90", Offset = "0x1A03390", VA = "0x181A04D90", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x1A04E10", Offset = "0x1A03410", VA = "0x181A04E10", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x1A05460", Offset = "0x1A03A60", VA = "0x181A05460")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x1A04F40", Offset = "0x1A03540", VA = "0x181A04F40")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x1A05580", Offset = "0x1A03B80", VA = "0x181A05580")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x1A05810", Offset = "0x1A03E10", VA = "0x181A05810")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public enum BendModifier
		{
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			Animation,
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			Target,
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			Parent,
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			Arm,
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			Goal
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public struct AxisDirection
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Vector3 direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Vector3 axis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public float dot;

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x1A50400", Offset = "0x1A4EA00", VA = "0x181A50400")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public AvatarIKGoal goal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public BendModifier bendModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Transform bendGoal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private bool maintainBendFor1Frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private bool maintainRotationFor1Frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private Quaternion defaultRootRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private Quaternion parentDefaultRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private Quaternion bone3RotationBeforeSolve;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private Quaternion maintainRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private Quaternion bone3DefaultRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private Vector3 _bendNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private Vector3 animationNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private AxisDirection[] axisDirectionsLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private AxisDirection[] axisDirectionsRight;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private AxisDirection[] axisDirections
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x1A07120", Offset = "0x1A05720", VA = "0x181A07120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x1A06730", Offset = "0x1A04D30", VA = "0x181A06730")]
		public void MaintainRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x1A066E0", Offset = "0x1A04CE0", VA = "0x181A066E0")]
		public void MaintainBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x1A06780", Offset = "0x1A04D80", VA = "0x181A06780", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1A06C80", Offset = "0x1A05280", VA = "0x181A06C80", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x1A06B90", Offset = "0x1A05190", VA = "0x181A06B90", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x1A06FF0", Offset = "0x1A055F0", VA = "0x181A06FF0")]
		public IKSolverLimb()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x1A07080", Offset = "0x1A05680", VA = "0x181A07080")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x1A06D90", Offset = "0x1A05390", VA = "0x181A06D90")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x1A059D0", Offset = "0x1A03FD0", VA = "0x181A059D0")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class LookAtBone : Bone
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public Vector3 baseForwardOffsetEuler;

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public Vector3 forward
			{
				[Cpp2IlInjected.Token(Token = "0x6000410")]
				[Cpp2IlInjected.Address(RVA = "0x1A5B3E0", Offset = "0x1A599E0", VA = "0x181A5B3E0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B3A0", Offset = "0x1A599A0", VA = "0x181A5B3A0")]
			public LookAtBone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B3B0", Offset = "0x1A599B0", VA = "0x181A5B3B0")]
			public LookAtBone(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B120", Offset = "0x1A59720", VA = "0x181A5B120")]
			public void Initiate(Transform root)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B240", Offset = "0x1A59840", VA = "0x181A5B240")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public LookAtBone[] spine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public LookAtBone head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public LookAtBone[] eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		[Range(0f, 1f)]
		public float headWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xB15D0", Offset = "0xB09D0")]
		public int clampSmoothing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AnimationCurve spineWeightCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public Vector3 spineTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		protected Vector3[] spineForwards;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		protected Vector3[] headForwards;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		protected Vector3[] eyeForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private bool isDirty;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected bool spineIsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x1A09AC0", Offset = "0x1A080C0", VA = "0x181A09AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected bool spineIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x1A09AA0", Offset = "0x1A080A0", VA = "0x181A09AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected bool headIsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x1A09A90", Offset = "0x1A08090", VA = "0x181A09A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected bool headIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x1A09A20", Offset = "0x1A08020", VA = "0x181A09A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected bool eyesIsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x1A09930", Offset = "0x1A07F30", VA = "0x181A09930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected bool eyesIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x1A09910", Offset = "0x1A07F10", VA = "0x181A09910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x19D58E0", Offset = "0x19D3EE0", VA = "0x1819D58E0")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x1A08650", Offset = "0x1A06C50", VA = "0x181A08650")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x1A086B0", Offset = "0x1A06CB0", VA = "0x181A086B0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x1A085B0", Offset = "0x1A06BB0", VA = "0x181A085B0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1A08730", Offset = "0x1A06D30", VA = "0x181A08730")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1A08810", Offset = "0x1A06E10", VA = "0x181A08810")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1A09510", Offset = "0x1A07B10", VA = "0x181A09510", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1A085A0", Offset = "0x1A06BA0", VA = "0x181A085A0")]
		public void SetDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1A07140", Offset = "0x1A05740", VA = "0x181A07140", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1A07B10", Offset = "0x1A06110", VA = "0x181A07B10", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1A07800", Offset = "0x1A05E00", VA = "0x181A07800", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1A07640", Offset = "0x1A05C40", VA = "0x181A07640", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1A084E0", Offset = "0x1A06AE0", VA = "0x181A084E0")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1A07E40", Offset = "0x1A06440", VA = "0x181A07E40", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1A08230", Offset = "0x1A06830", VA = "0x181A08230", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1A09200", Offset = "0x1A07800", VA = "0x181A09200")]
		protected void SolveSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x1A08EB0", Offset = "0x1A074B0", VA = "0x181A08EB0")]
		protected void SolveHead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x1A08920", Offset = "0x1A06F20", VA = "0x181A08920")]
		protected void SolveEyes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x1A072D0", Offset = "0x1A058D0", VA = "0x181A072D0")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1A08310", Offset = "0x1A06910", VA = "0x181A08310")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1A09670", Offset = "0x1A07C70", VA = "0x181A09670")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public class TrigonometricBone : Bone
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			private Quaternion targetToLocalSpace;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			private Vector3 defaultLocalBendNormal;

			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x1A61830", Offset = "0x1A5FE30", VA = "0x181A61830")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x1A617B0", Offset = "0x1A5FDB0", VA = "0x181A617B0")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x1A61730", Offset = "0x1A5FD30", VA = "0x181A61730")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B3A0", Offset = "0x1A599A0", VA = "0x181A5B3A0")]
			public TrigonometricBone()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public Quaternion IKRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public Vector3 bendNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public TrigonometricBone bone1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public TrigonometricBone bone2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public TrigonometricBone bone3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		protected Vector3 weightIKPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		protected bool directHierarchy;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1A0B940", Offset = "0x1A09F40", VA = "0x181A0B940")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1A0BBB0", Offset = "0x1A0A1B0", VA = "0x181A0BBB0")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x82BBD0", Offset = "0x82A1D0", VA = "0x18082BBD0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1A0BE50", Offset = "0x1A0A450", VA = "0x181A0BE50")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x82CA70", Offset = "0x82B070", VA = "0x18082CA70")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A100", Offset = "0x1A08700", VA = "0x181A0A100")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A270", Offset = "0x1A08870", VA = "0x181A0A270", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A110", Offset = "0x1A08710", VA = "0x181A0A110", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x1A0C690", Offset = "0x1A0AC90", VA = "0x181A0C690", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x1A09BB0", Offset = "0x1A081B0", VA = "0x181A09BB0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A800", Offset = "0x1A08E00", VA = "0x181A0A800", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1A0BDC0", Offset = "0x1A0A3C0", VA = "0x181A0BDC0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x1A0BE80", Offset = "0x1A0A480", VA = "0x181A0BE80")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1A09F30", Offset = "0x1A08530", VA = "0x181A09F30")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1A0ACF0", Offset = "0x1A092F0", VA = "0x181A0ACF0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A6D0", Offset = "0x1A08CD0", VA = "0x181A0A6D0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A3F0", Offset = "0x1A089F0", VA = "0x181A0A3F0")]
		private void InitiateBones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1A0AF00", Offset = "0x1A09500", VA = "0x181A0AF00", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1A09C10", Offset = "0x1A08210", VA = "0x181A09C10")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1A0C6E0", Offset = "0x1A0ACE0", VA = "0x181A0C6E0")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000086")]
			public enum ShoulderRotationMode
			{
				[Cpp2IlInjected.Token(Token = "0x40003CD")]
				YawPitch,
				[Cpp2IlInjected.Token(Token = "0x40003CE")]
				FromTo
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[Range(0f, 1f)]
			public float shoulderTwistWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the elbow bending direction.")]
			public float swivelOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xB1AF0", Offset = "0xB0EF0")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			public float armLengthMlp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private bool hasShoulder;

			[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private Vector3 chestForwardAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			private Vector3 chestUpAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			private Quaternion chestRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private Vector3 chestForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			private Vector3 chestUp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			private Quaternion forearmRelToUpperArm;

			[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			private Vector3 upperArmBendAxis;

			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			private const float yawOffsetAngle = 45f;

			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			private const float pitchOffsetAngle = -30f;

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public Vector3 position
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0x1A4FA90", Offset = "0x1A4E090", VA = "0x181A4FA90")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x1A4FB50", Offset = "0x1A4E150", VA = "0x181A4FB50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public Quaternion rotation
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0x1553290", Offset = "0x1551890", VA = "0x181553290")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x1A4FB70", Offset = "0x1A4E170", VA = "0x181A4FB70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			private VirtualBone shoulder
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0x1A4FAB0", Offset = "0x1A4E0B0", VA = "0x181A4FAB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			private VirtualBone upperArm
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x1A4FAF0", Offset = "0x1A4E0F0", VA = "0x181A4FAF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			private VirtualBone forearm
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x1A4F9D0", Offset = "0x1A4DFD0", VA = "0x181A4F9D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			private VirtualBone hand
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x1A4FA30", Offset = "0x1A4E030", VA = "0x181A4FA30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x1A4B9D0", Offset = "0x1A49FD0", VA = "0x181A4B9D0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x1A4C6E0", Offset = "0x1A4ACE0", VA = "0x181A4C6E0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x1A4B1D0", Offset = "0x1A497D0", VA = "0x181A4B1D0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x1A4EBA0", Offset = "0x1A4D1A0", VA = "0x181A4EBA0")]
			private void Stretching()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x1A4CA70", Offset = "0x1A4B070", VA = "0x181A4CA70")]
			public void Solve(bool isLeft)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x1A4CA40", Offset = "0x1A4B040", VA = "0x181A4CA40", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x1A4F3C0", Offset = "0x1A4D9C0", VA = "0x181A4F3C0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x1A4B260", Offset = "0x1A49860", VA = "0x181A4B260")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x1A4B2F0", Offset = "0x1A498F0", VA = "0x181A4B2F0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x1A4F280", Offset = "0x1A4D880", VA = "0x181A4F280")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x1A4F850", Offset = "0x1A4DE50", VA = "0x181A4F850")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		public abstract class BodyPart
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			protected bool initiated;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			protected Vector3 rootPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			protected Quaternion rootRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			protected int index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			protected int LOD;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public float sqrMag
			{
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0xAF95C0", Offset = "0xAF7BC0", VA = "0x180AF95C0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0xAF9650", Offset = "0xAF7C50", VA = "0x180AF9650")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public float mag
			{
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0xD5C700", Offset = "0xD5AD00", VA = "0x180D5C700")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0xD5C710", Offset = "0xD5AD10", VA = "0x180D5C710")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void PreSolve();

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void ApplyOffsets(float scale);

			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void ResetOffsets();

			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x133AB90", Offset = "0x1339190", VA = "0x18133AB90")]
			public void SetLOD(int LOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x1A50630", Offset = "0x1A4EC30", VA = "0x181A50630")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x1A50460", Offset = "0x1A4EA60", VA = "0x181A50460")]
			public void MovePosition(Vector3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x1A50560", Offset = "0x1A4EB60", VA = "0x181A50560")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x1A50A30", Offset = "0x1A4F030", VA = "0x181A50A30")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x1A50870", Offset = "0x1A4EE70", VA = "0x181A50870")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x1A50740", Offset = "0x1A4ED40", VA = "0x181A50740")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x1A50B30", Offset = "0x1A4F130", VA = "0x181A50B30")]
			public void Visualize(Color color)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x1A50CA0", Offset = "0x1A4F2A0", VA = "0x181A50CA0")]
			public void Visualize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x1A50E30", Offset = "0x1A4F430", VA = "0x181A50E30")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public class Footstep
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public float stepSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public Vector3 characterSpaceOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public Vector3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Quaternion rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public Quaternion stepToRootRot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public bool isSupportLeg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public bool relaxFlag;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Vector3 stepFrom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public Vector3 stepTo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public Quaternion stepFromRot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public Quaternion stepToRot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			private Quaternion footRelativeToRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			private float supportLegW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private float supportLegWV;

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public bool isStepping
			{
				[Cpp2IlInjected.Token(Token = "0x600046E")]
				[Cpp2IlInjected.Address(RVA = "0x1A53C40", Offset = "0x1A52240", VA = "0x181A53C40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public float stepProgress
			{
				[Cpp2IlInjected.Token(Token = "0x600046F")]
				[Cpp2IlInjected.Address(RVA = "0x83C4F0", Offset = "0x83AAF0", VA = "0x18083C4F0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000470")]
				[Cpp2IlInjected.Address(RVA = "0x83C580", Offset = "0x83AB80", VA = "0x18083C580")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x1A53AF0", Offset = "0x1A520F0", VA = "0x181A53AF0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x1A533B0", Offset = "0x1A519B0", VA = "0x181A533B0")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x1A53400", Offset = "0x1A51A00", VA = "0x181A53400")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x1A537A0", Offset = "0x1A51DA0", VA = "0x181A537A0")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x1A53630", Offset = "0x1A51C30", VA = "0x181A53630")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x1A53940", Offset = "0x1A51F40", VA = "0x181A53940")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		public class Leg : BodyPart
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			[Tooltip("Angular offset of knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			[Range(0f, 1f)]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			public float bendToTargetWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xB1D80", Offset = "0xB1180")]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			public float legLengthMlp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			[HideInInspector]
			public float currentMag;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			private Vector3 footPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			private Quaternion footRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private Vector3 bendNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			private Quaternion calfRelToThigh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			private Quaternion thighRelToFoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			private Vector3 bendNormalRelToPelvis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private Vector3 bendNormalRelToTarget;

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public Vector3 position
			{
				[Cpp2IlInjected.Token(Token = "0x6000477")]
				[Cpp2IlInjected.Address(RVA = "0x1155DD0", Offset = "0x11543D0", VA = "0x181155DD0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000478")]
				[Cpp2IlInjected.Address(RVA = "0x1A577A0", Offset = "0x1A55DA0", VA = "0x181A577A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public Quaternion rotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x732C00", Offset = "0x731200", VA = "0x180732C00")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x732EC0", Offset = "0x7314C0", VA = "0x180732EC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public bool hasToes
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0x7C5A80", Offset = "0x7C4080", VA = "0x1807C5A80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0x1A57790", Offset = "0x1A55D90", VA = "0x181A57790")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public VirtualBone thigh
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0x1A4FAB0", Offset = "0x1A4E0B0", VA = "0x181A4FAB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			private VirtualBone calf
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0x1A57690", Offset = "0x1A55C90", VA = "0x181A57690")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			private VirtualBone foot
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0x1A576D0", Offset = "0x1A55CD0", VA = "0x181A576D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			private VirtualBone toes
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0x1A57750", Offset = "0x1A55D50", VA = "0x181A57750")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public VirtualBone lastBone
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0x1A57710", Offset = "0x1A55D10", VA = "0x181A57710")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public Vector3 thighRelativeToPelvis
			{
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x1A02750", Offset = "0x1A00D50", VA = "0x181A02750")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0x1A02970", Offset = "0x1A00F70", VA = "0x181A02970")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x1A553E0", Offset = "0x1A539E0", VA = "0x181A553E0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x1A55EB0", Offset = "0x1A544B0", VA = "0x181A55EB0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x1A542D0", Offset = "0x1A528D0", VA = "0x181A542D0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x1A54BC0", Offset = "0x1A531C0", VA = "0x181A54BC0")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x1A54CB0", Offset = "0x1A532B0", VA = "0x181A54CB0")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x1A56770", Offset = "0x1A54D70", VA = "0x181A56770")]
			public void Solve(bool stretch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x1A54EF0", Offset = "0x1A534F0", VA = "0x181A54EF0")]
			private void FixTwistRotations()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x1A56AE0", Offset = "0x1A550E0", VA = "0x181A56AE0")]
			private void Stretching()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x1A571A0", Offset = "0x1A557A0", VA = "0x181A571A0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x1A56700", Offset = "0x1A54D00", VA = "0x181A56700", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x1A57550", Offset = "0x1A55B50", VA = "0x181A57550")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public class Locomotion
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			[Range(0f, 1f)]
			public float weight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			[Range(0.9f, 1f)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			[Tooltip("Reduce this value if locomotion makes the head bob too much.")]
			public float maxBodyYOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[Range(0f, 180f)]
			public float relaxLegTwistMinAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			[HideInInspector]
			public bool blockingEnabled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000413")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			[HideInInspector]
			public float raycastRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			[HideInInspector]
			public float raycastHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			private Footstep[] footsteps;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private Vector3 lastComPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private Vector3 comVelocity;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			private int leftFootIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			private int rightFootIndex;

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public Vector3 centerOfMass
			{
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x1A5AF80", Offset = "0x1A59580", VA = "0x181A5AF80")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x1A5B100", Offset = "0x1A59700", VA = "0x181A5B100")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public Vector3 leftFootstepPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x1A5AFA0", Offset = "0x1A595A0", VA = "0x181A5AFA0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public Vector3 rightFootstepPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0x1A5B050", Offset = "0x1A59650", VA = "0x181A5B050")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public Quaternion leftFootstepRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x1A5B000", Offset = "0x1A59600", VA = "0x181A5B000")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public Quaternion rightFootstepRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600049A")]
				[Cpp2IlInjected.Address(RVA = "0x1A5B0B0", Offset = "0x1A596B0", VA = "0x181A5B0B0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x1A581B0", Offset = "0x1A567B0", VA = "0x181A581B0")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x1A587C0", Offset = "0x1A56DC0", VA = "0x181A587C0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x1A58750", Offset = "0x1A56D50", VA = "0x181A58750")]
			public void Relax()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x1A57980", Offset = "0x1A55F80", VA = "0x181A57980")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x1A577C0", Offset = "0x1A55DC0", VA = "0x181A577C0")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x1A58B40", Offset = "0x1A57140", VA = "0x181A58B40")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x1A5AC70", Offset = "0x1A59270", VA = "0x181A5AC70")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x1A57F40", Offset = "0x1A56540", VA = "0x181A57F40")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x1A57FC0", Offset = "0x1A565C0", VA = "0x181A57FC0")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x1A5AE50", Offset = "0x1A59450", VA = "0x181A5AE50")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public class Spine : BodyPart
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust it's position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			public float rotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			public float pelvisPositionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			public float pelvisRotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			[Range(0f, 1f)]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			public float chestGoalWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			public float neckStiffness;

			[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			[Range(0f, 1f)]
			public float headClampWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			public float maintainPelvisPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			public float maxRootAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[HideInInspector]
			public Vector3 headPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			private Quaternion headRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			private Quaternion pelvisRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			private Quaternion anchorRelativeToPelvis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			private Quaternion pelvisRelativeRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			private Quaternion chestRelativeRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			private Vector3 headDeltaPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			private Quaternion pelvisDeltaRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			private Quaternion chestTargetRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			private int pelvisIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private int spineIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private int chestIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private int neckIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private int headIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			private bool hasChest;

			[Cpp2IlInjected.FieldOffset(Offset = "0x211")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private bool hasNeck;

			[Cpp2IlInjected.FieldOffset(Offset = "0x212")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private bool hasLegs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private float headHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			private float sizeMlp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			private Vector3 chestForward;

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public VirtualBone pelvis
			{
				[Cpp2IlInjected.Token(Token = "0x600049F")]
				[Cpp2IlInjected.Address(RVA = "0x1A616D0", Offset = "0x1A5FCD0", VA = "0x181A616D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public VirtualBone firstSpineBone
			{
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0x1A61610", Offset = "0x1A5FC10", VA = "0x181A61610")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public VirtualBone chest
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0x1A615A0", Offset = "0x1A5FBA0", VA = "0x181A615A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			private VirtualBone neck
			{
				[Cpp2IlInjected.Token(Token = "0x60004A2")]
				[Cpp2IlInjected.Address(RVA = "0x1A61690", Offset = "0x1A5FC90", VA = "0x181A61690")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public VirtualBone head
			{
				[Cpp2IlInjected.Token(Token = "0x60004A3")]
				[Cpp2IlInjected.Address(RVA = "0x1A61650", Offset = "0x1A5FC50", VA = "0x181A61650")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Quaternion anchorRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60004A4")]
				[Cpp2IlInjected.Address(RVA = "0x1A61590", Offset = "0x1A5FB90", VA = "0x181A61590")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60004A5")]
				[Cpp2IlInjected.Address(RVA = "0x1A61720", Offset = "0x1A5FD20", VA = "0x181A61720")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public Quaternion anchorRelativeToHead
			{
				[Cpp2IlInjected.Token(Token = "0x60004A6")]
				[Cpp2IlInjected.Address(RVA = "0x1A27BD0", Offset = "0x1A261D0", VA = "0x181A27BD0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60004A7")]
				[Cpp2IlInjected.Address(RVA = "0x1A61710", Offset = "0x1A5FD10", VA = "0x181A61710")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x1A5EB70", Offset = "0x1A5D170", VA = "0x181A5EB70", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x1A5F9B0", Offset = "0x1A5DFB0", VA = "0x181A5F9B0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x1A5D3B0", Offset = "0x1A5B9B0", VA = "0x181A5D3B0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x1A5E0F0", Offset = "0x1A5C6F0", VA = "0x181A5E0F0")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x1A60140", Offset = "0x1A5E740", VA = "0x181A60140")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x1A5E2D0", Offset = "0x1A5C8D0", VA = "0x181A5E2D0")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x1A5FD90", Offset = "0x1A5E390", VA = "0x181A5FD90")]
			private void SolvePelvis()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x1A610C0", Offset = "0x1A5F6C0", VA = "0x181A610C0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x1A5FCE0", Offset = "0x1A5E2E0", VA = "0x181A5FCE0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x1A5CE80", Offset = "0x1A5B480", VA = "0x181A5CE80")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x1A5E5D0", Offset = "0x1A5CBD0", VA = "0x181A5E5D0")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x1A60960", Offset = "0x1A5EF60", VA = "0x181A60960")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x1A5E7E0", Offset = "0x1A5CDE0", VA = "0x181A5E7E0")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x1A5DE60", Offset = "0x1A5C460", VA = "0x181A5DE60")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x1A5DB00", Offset = "0x1A5C100", VA = "0x181A5DB00")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x1A61390", Offset = "0x1A5F990", VA = "0x181A61390")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		public enum PositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			Pelvis,
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			Chest,
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			Head,
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			LeftHand,
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			RightHand,
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			LeftFoot,
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			RightFoot,
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			LeftHeel,
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			RightHeel
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		public enum RotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			Pelvis,
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			Chest,
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			Head
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public class VirtualBone
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public Vector3 readPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public Quaternion readRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public Vector3 solverPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public Quaternion solverRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public float sqrMag;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public Vector3 axis;

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x1A64960", Offset = "0x1A62F60", VA = "0x181A64960")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x1A62BA0", Offset = "0x1A611A0", VA = "0x181A62BA0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x1A64710", Offset = "0x1A62D10", VA = "0x181A64710")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x1A62810", Offset = "0x1A60E10", VA = "0x181A62810")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x1A62BD0", Offset = "0x1A611D0", VA = "0x181A62BD0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x1A63000", Offset = "0x1A61600", VA = "0x181A63000")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x1A62DE0", Offset = "0x1A613E0", VA = "0x181A62DE0")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x1A63220", Offset = "0x1A61820", VA = "0x181A63220")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x1A63D50", Offset = "0x1A62350", VA = "0x181A63D50")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x1A62640", Offset = "0x1A60C40", VA = "0x181A62640")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x1A636D0", Offset = "0x1A61CD0", VA = "0x181A636D0")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x1A635B0", Offset = "0x1A61BB0", VA = "0x181A635B0")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x1A63300", Offset = "0x1A61900", VA = "0x181A63300")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private Transform[] solverTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private bool hasChest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private bool hasNeck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private bool hasShoulders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private bool hasToes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private bool hasLegs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private Vector3[] readPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private Quaternion[] readRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private Vector3[] solvedPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private Quaternion[] solvedRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private Quaternion[] defaultLocalRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private Vector3[] defaultLocalPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private Vector3 rootV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private Vector3 rootVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private Vector3 bodyOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private int supportLegIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private int lastLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xB1610", Offset = "0xB0A10")]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		public int LOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
		public float scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private Leg[] legs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private Arm[] arms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private Vector3 headPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private Vector3 headDeltaPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private Vector3 raycastOriginPelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private Vector3 lastOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private Vector3 debugPos1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private Vector3 debugPos2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private Vector3 debugPos3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Vector3 debugPos4;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x751D60", Offset = "0x750360", VA = "0x180751D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x752220", Offset = "0x750820", VA = "0x180752220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F4C0", Offset = "0x1A0DAC0", VA = "0x181A0F4C0")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E0A0", Offset = "0x1A0C6A0", VA = "0x181A0E0A0")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1A0CF50", Offset = "0x1A0B550", VA = "0x181A0CF50")]
		public void DefaultAnimationCurves()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1A0C970", Offset = "0x1A0AF70", VA = "0x181A0C970")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1A0CD10", Offset = "0x1A0B310", VA = "0x181A0CD10")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1A0CE50", Offset = "0x1A0B450", VA = "0x181A0CE50")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1A0C7E0", Offset = "0x1A0ADE0", VA = "0x181A0C7E0")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F370", Offset = "0x1A0D970", VA = "0x181A0F370")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1A11360", Offset = "0x1A0F960", VA = "0x181A11360", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D0F0", Offset = "0x1A0B6F0", VA = "0x181A0D0F0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x1A0DE30", Offset = "0x1A0C430", VA = "0x181A0DE30", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x1A0DDD0", Offset = "0x1A0C3D0", VA = "0x181A0DDD0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E3B0", Offset = "0x1A0C9B0", VA = "0x181A0E3B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D340", Offset = "0x1A0B940", VA = "0x181A0D340")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x1A0DF30", Offset = "0x1A0C530", VA = "0x181A0DF30")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x1A11540", Offset = "0x1A0FB40", VA = "0x181A11540")]
		private void UpdateSolverTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E650", Offset = "0x1A0CC50", VA = "0x181A0E650", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E6B0", Offset = "0x1A0CCB0", VA = "0x181A0E6B0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x1A11700", Offset = "0x1A0FD00", VA = "0x181A11700")]
		private void WriteTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x1A0EC50", Offset = "0x1A0D250", VA = "0x181A0EC50")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F850", Offset = "0x1A0DE50", VA = "0x181A0F850")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x1A0DE90", Offset = "0x1A0C490", VA = "0x181A0DE90")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1A0DEE0", Offset = "0x1A0C4E0", VA = "0x181A0DEE0")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1A11CC0", Offset = "0x1A102C0", VA = "0x181A11CC0")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D640", Offset = "0x1A0BC40", VA = "0x181A0D640")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1A11E80", Offset = "0x1A10480", VA = "0x181A11E80")]
		public IKSolverVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public IK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x160E360", Offset = "0x160C960", VA = "0x18160E360")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x160E2A0", Offset = "0x160C8A0", VA = "0x18160E2A0")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x160E0B0", Offset = "0x160C6B0", VA = "0x18160E0B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x160E170", Offset = "0x160C770", VA = "0x18160E170")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x160E550", Offset = "0x160CB50", VA = "0x18160E550")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class TwistSolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[Tooltip("The transform that this solver operates on.")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform[] children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		[Range(0f, 1f)]
		public float parentChildCrossfade;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
		public float twistAngleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private Vector3 twistAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private Vector3 axis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private Vector3 axisRelativeToParentDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private Vector3 axisRelativeToChildDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private Quaternion[] childRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private bool inititated;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x160F1B0", Offset = "0x160D7B0", VA = "0x18160F1B0")]
		public TwistSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x160E5B0", Offset = "0x160CBB0", VA = "0x18160E5B0")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x160EC80", Offset = "0x160D280", VA = "0x18160EC80")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class InteractionEffector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private Poser poser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private IKEffector effector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private float timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private float length;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private float fadeInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private float defaultPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private float defaultRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private float defaultPull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private float defaultReach;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private float defaultPush;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private float defaultPushParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private float defaultBendGoalWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private float resetTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private bool positionWeightUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private bool rotationWeightUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private bool pullUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private bool reachUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private bool pushUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private bool pushParentUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private bool bendGoalWeightUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x67")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private bool pickedUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private bool defaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private bool pickUpOnPostFBBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private Vector3 pickUpPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private Vector3 pausePositionRelative;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private Quaternion pickUpRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private Quaternion pauseRotationRelative;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private InteractionTarget interactionTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private List<bool> triggered;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private InteractionSystem interactionSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private bool started;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public FullBodyBipedEffector effectorType
		{
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x695660", Offset = "0x693C60", VA = "0x180695660")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x709AB0", Offset = "0x7080B0", VA = "0x180709AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public bool isPaused
		{
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0xAF95D0", Offset = "0xAF7BD0", VA = "0x180AF95D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xAF9660", Offset = "0xAF7C60", VA = "0x180AF9660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public InteractionObject interactionObject
		{
			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x728F30", Offset = "0x727530", VA = "0x180728F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public bool inInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x1A14E70", Offset = "0x1A13470", VA = "0x181A14E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public float progress
		{
			[Cpp2IlInjected.Token(Token = "0x60004DC")]
			[Cpp2IlInjected.Address(RVA = "0x1A14ED0", Offset = "0x1A134D0", VA = "0x181A14ED0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x1A14DE0", Offset = "0x1A133E0", VA = "0x181A14DE0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x1A129F0", Offset = "0x1A10FF0", VA = "0x181A129F0")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x1A13EB0", Offset = "0x1A124B0", VA = "0x181A13EB0")]
		private void StoreDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x1A13240", Offset = "0x1A11840", VA = "0x181A13240")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x1A12DE0", Offset = "0x1A113E0", VA = "0x181A12DE0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x1A13720", Offset = "0x1A11D20", VA = "0x181A13720")]
		public bool Resume()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x1A137D0", Offset = "0x1A11DD0", VA = "0x181A137D0")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x1A14380", Offset = "0x1A12980", VA = "0x181A14380")]
		public void Update(Transform root, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x1A140A0", Offset = "0x1A126A0", VA = "0x181A140A0")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x1A12F50", Offset = "0x1A11550", VA = "0x181A12F50")]
		private void PickUp(Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x1A13CF0", Offset = "0x1A122F0", VA = "0x181A13CF0")]
		public bool Stop()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x1A12AB0", Offset = "0x1A110B0", VA = "0x181A12AB0")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class InteractionLookAt
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		[HideInInspector]
		public bool isPaused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private Transform lookAtTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private float stopLookTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private bool firstFBBIKSolve;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x1A14F50", Offset = "0x1A13550", VA = "0x181A14F50")]
		public void Look(Transform target, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x1A150E0", Offset = "0x1A136E0", VA = "0x181A150E0")]
		public void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x1A15370", Offset = "0x1A13970", VA = "0x181A15370")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x1A15250", Offset = "0x1A13850", VA = "0x181A15250")]
		public void SolveSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x1A15180", Offset = "0x1A13780", VA = "0x181A15180")]
		public void SolveHead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x1A155F0", Offset = "0x1A13BF0", VA = "0x181A155F0")]
		public InteractionLookAt()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public class InteractionEvent
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
			[Cpp2IlInjected.Token(Token = "0x40004AF")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004B0")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0x1A54090", Offset = "0x1A52690", VA = "0x181A54090")]
			public void Activate(Transform t)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		public class Message
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			private const string empty = "";

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B450", Offset = "0x1A59A50", VA = "0x181A5B450")]
			public void Send(Transform t)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public Message()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		public class AnimatorEvent
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B8")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B9")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Cpp2IlInjected.Token(Token = "0x40004BC")]
			private const string empty = "";

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0x1A4AFD0", Offset = "0x1A495D0", VA = "0x181A4AFD0")]
			public void Activate(bool pickUp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0x1A4AE70", Offset = "0x1A49470", VA = "0x181A4AE70")]
			private void Activate(Animator animator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x1A4AF10", Offset = "0x1A49510", VA = "0x181A4AF10")]
			private void Activate(Animation animation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0x1A4B1C0", Offset = "0x1A497C0", VA = "0x181A4B1C0")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public class WeightCurve
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			public enum Type
			{
				[Cpp2IlInjected.Token(Token = "0x40004C0")]
				PositionWeight,
				[Cpp2IlInjected.Token(Token = "0x40004C1")]
				RotationWeight,
				[Cpp2IlInjected.Token(Token = "0x40004C2")]
				PositionOffsetX,
				[Cpp2IlInjected.Token(Token = "0x40004C3")]
				PositionOffsetY,
				[Cpp2IlInjected.Token(Token = "0x40004C4")]
				PositionOffsetZ,
				[Cpp2IlInjected.Token(Token = "0x40004C5")]
				Pull,
				[Cpp2IlInjected.Token(Token = "0x40004C6")]
				Reach,
				[Cpp2IlInjected.Token(Token = "0x40004C7")]
				RotateBoneWeight,
				[Cpp2IlInjected.Token(Token = "0x40004C8")]
				Push,
				[Cpp2IlInjected.Token(Token = "0x40004C9")]
				PushParent,
				[Cpp2IlInjected.Token(Token = "0x40004CA")]
				PoserWeight,
				[Cpp2IlInjected.Token(Token = "0x40004CB")]
				BendGoalWeight
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0x1A649C0", Offset = "0x1A62FC0", VA = "0x181A649C0")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public class Multiplier
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B540", Offset = "0x1A59B40", VA = "0x181A5B540")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0xF69C00", Offset = "0xF68200", VA = "0x180F69C00")]
			public Multiplier()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public WeightCurve[] weightCurves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public Multiplier[] multipliers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public InteractionEvent[] events;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private InteractionTarget[] targets;

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public float length
		{
			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x79D100", Offset = "0x79B700", VA = "0x18079D100")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x79D170", Offset = "0x79B770", VA = "0x18079D170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x687C20", Offset = "0x686220", VA = "0x180687C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x728F20", Offset = "0x727520", VA = "0x180728F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Transform lookAtTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x17C3760", Offset = "0x17C1D60", VA = "0x1817C3760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public Transform targetsRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x17C37E0", Offset = "0x17C1DE0", VA = "0x1817C37E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x17C3670", Offset = "0x17C1C70", VA = "0x1817C3670")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x17C3530", Offset = "0x17C1B30", VA = "0x1817C3530")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x17C3570", Offset = "0x17C1B70", VA = "0x1817C3570")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x17C35B0", Offset = "0x17C1BB0", VA = "0x1817C35B0")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x17C35F0", Offset = "0x17C1BF0", VA = "0x1817C35F0")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x17C3630", Offset = "0x17C1C30", VA = "0x1817C3630")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x17C36C0", Offset = "0x17C1CC0", VA = "0x1817C36C0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x17C1E60", Offset = "0x17C0460", VA = "0x1817C1E60")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x17C3270", Offset = "0x17C1870", VA = "0x1817C3270")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x17C2BB0", Offset = "0x17C11B0", VA = "0x1817C2BB0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x17C2A80", Offset = "0x17C1080", VA = "0x1817C2A80")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x683BB0", Offset = "0x6821B0", VA = "0x180683BB0")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x17C2D90", Offset = "0x17C1390", VA = "0x1817C2D90")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x728F20", Offset = "0x727520", VA = "0x180728F20")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x17C24F0", Offset = "0x17C0AF0", VA = "0x1817C24F0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x17C2F30", Offset = "0x17C1530", VA = "0x1817C2F30")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x17C36B0", Offset = "0x17C1CB0", VA = "0x1817C36B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x17C1EA0", Offset = "0x17C04A0", VA = "0x1817C1EA0")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x17C2D10", Offset = "0x17C1310", VA = "0x1817C2D10")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x17C3200", Offset = "0x17C1800", VA = "0x1817C3200")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x17C2B40", Offset = "0x17C1140", VA = "0x1817C2B40")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x17C3700", Offset = "0x17C1D00", VA = "0x1817C3700")]
		public InteractionObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Cpp2IlInjected.Token(Token = "0x200009C")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		[FormerlySerializedAs("collider")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		public Collider characterCollider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private List<InteractionTrigger> inContact;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private List<int> bestRangeIndexes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public InteractionDelegate OnInteractionStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public InteractionDelegate OnInteractionPause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public InteractionDelegate OnInteractionPickUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public InteractionDelegate OnInteractionResume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public InteractionDelegate OnInteractionStop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public InteractionEventDelegate OnInteractionEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public RaycastHit raycastHit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		[SerializeField]
		[Space]
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		private FullBodyBipedIK fullBody;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private InteractionEffector[] interactionEffectors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private Collider lastCollider;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private Collider c;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public bool inInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x17C80A0", Offset = "0x17C66A0", VA = "0x1817C80A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public FullBodyBipedIK ik
		{
			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x74FC30", Offset = "0x74E230", VA = "0x18074FC30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x74FC80", Offset = "0x74E280", VA = "0x18074FC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public List<InteractionTrigger> triggersInRange
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x694B00", Offset = "0x693100", VA = "0x180694B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x728ED0", Offset = "0x7274D0", VA = "0x180728ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x133AA80", Offset = "0x1339080", VA = "0x18133AA80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x133ABA0", Offset = "0x13391A0", VA = "0x18133ABA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x17C5B20", Offset = "0x17C4120", VA = "0x1817C5B20")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x17C59E0", Offset = "0x17C3FE0", VA = "0x1817C59E0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x17C5A20", Offset = "0x17C4020", VA = "0x1817C5A20")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x17C5A60", Offset = "0x17C4060", VA = "0x1817C5A60")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x17C5AA0", Offset = "0x17C40A0", VA = "0x1817C5AA0")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x17C5AE0", Offset = "0x17C40E0", VA = "0x1817C5AE0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x17C66E0", Offset = "0x17C4CE0", VA = "0x1817C66E0")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x17C3B00", Offset = "0x17C2100", VA = "0x1817C3B00")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x17C49B0", Offset = "0x17C2FB0", VA = "0x1817C49B0")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x17C4CB0", Offset = "0x17C32B0", VA = "0x1817C4CB0")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x17C4BC0", Offset = "0x17C31C0", VA = "0x1817C4BC0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x17C4A80", Offset = "0x17C3080", VA = "0x1817C4A80")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x17C5EF0", Offset = "0x17C44F0", VA = "0x1817C5EF0")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x17C5BF0", Offset = "0x17C41F0", VA = "0x1817C5BF0")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x17C5E60", Offset = "0x17C4460", VA = "0x1817C5E60")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x17C6650", Offset = "0x17C4C50", VA = "0x1817C6650")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x17C5B60", Offset = "0x17C4160", VA = "0x1817C5B60")]
		public void PauseAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x17C5DD0", Offset = "0x17C43D0", VA = "0x1817C5DD0")]
		public void ResumeAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x17C65D0", Offset = "0x17C4BD0", VA = "0x1817C65D0")]
		public void StopAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x17C4600", Offset = "0x17C2C00", VA = "0x1817C4600")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x17C47A0", Offset = "0x17C2DA0", VA = "0x1817C47A0")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x17C4690", Offset = "0x17C2C90", VA = "0x1817C4690")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x17C7110", Offset = "0x17C5710", VA = "0x1817C7110")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x17C6EB0", Offset = "0x17C54B0", VA = "0x1817C6EB0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x17C6B70", Offset = "0x17C5170", VA = "0x1817C6B70")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x17C4080", Offset = "0x17C2680", VA = "0x1817C4080")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x17C3EE0", Offset = "0x17C24E0", VA = "0x1817C3EE0")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x17C4180", Offset = "0x17C2780", VA = "0x1817C4180")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x17C3F30", Offset = "0x17C2530", VA = "0x1817C3F30")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x17C4210", Offset = "0x17C2810", VA = "0x1817C4210")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x17C6720", Offset = "0x17C4D20", VA = "0x1817C6720")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x17C4830", Offset = "0x17C2E30", VA = "0x1817C4830")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x17C43C0", Offset = "0x17C29C0", VA = "0x1817C43C0")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x17C6000", Offset = "0x17C4600", VA = "0x1817C6000")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x17C4970", Offset = "0x17C2F70", VA = "0x1817C4970")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x17C4990", Offset = "0x17C2F90", VA = "0x1817C4990")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x17C4990", Offset = "0x17C2F90", VA = "0x1817C4990")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x17C4E70", Offset = "0x17C3470", VA = "0x1817C4E70")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x17C57C0", Offset = "0x17C3DC0", VA = "0x1817C57C0")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x17C58E0", Offset = "0x17C3EE0", VA = "0x1817C58E0")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x17C3B40", Offset = "0x17C2140", VA = "0x1817C3B40")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x17C53B0", Offset = "0x17C39B0", VA = "0x1817C53B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x17C7760", Offset = "0x17C5D60", VA = "0x1817C7760")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x17C5C80", Offset = "0x17C4280", VA = "0x1817C5C80")]
		private void Raycasting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x17C7460", Offset = "0x17C5A60", VA = "0x1817C7460")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x17C72F0", Offset = "0x17C58F0", VA = "0x1817C72F0")]
		private void UpdateEffectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x17C55E0", Offset = "0x17C3BE0", VA = "0x1817C55E0")]
		private void OnPreFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x17C5500", Offset = "0x17C3B00", VA = "0x1817C5500")]
		private void OnPostFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x17C54D0", Offset = "0x17C3AD0", VA = "0x1817C54D0")]
		private void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x17C4F40", Offset = "0x17C3540", VA = "0x1817C4F40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x17C4D80", Offset = "0x17C3380", VA = "0x1817C4D80")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x17C6A50", Offset = "0x17C5050", VA = "0x1817C6A50")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x17C7B00", Offset = "0x17C6100", VA = "0x1817C7B00")]
		public InteractionSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		public enum RotationMode
		{
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			TwoDOF,
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			ThreeDOF
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public class Multiplier
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public Multiplier()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget's rotation to the effector bone rotation.")]
		public RotationMode rotationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
		[Range(0f, 1f)]
		public float threeDOFWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private Quaternion defaultLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private Transform lastPivot;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x17C8380", Offset = "0x17C6980", VA = "0x1817C8380")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x17C8240", Offset = "0x17C6840", VA = "0x1817C8240")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x17C8280", Offset = "0x17C6880", VA = "0x1817C8280")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x17C82C0", Offset = "0x17C68C0", VA = "0x1817C82C0")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x17C8300", Offset = "0x17C6900", VA = "0x1817C8300")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x17C8340", Offset = "0x17C6940", VA = "0x1817C8340")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x17C8C50", Offset = "0x17C7250", VA = "0x1817C8C50")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x17C8190", Offset = "0x17C6790", VA = "0x1817C8190")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x17C81D0", Offset = "0x17C67D0", VA = "0x1817C81D0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x17C83C0", Offset = "0x17C69C0", VA = "0x1817C83C0")]
		public void ResetRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x17C8450", Offset = "0x17C6A50", VA = "0x1817C8450")]
		public void RotateTo(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x17C8C90", Offset = "0x17C7290", VA = "0x1817C8C90")]
		public InteractionTarget()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public class CharacterPosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public Vector3 offset3D
			{
				[Cpp2IlInjected.Token(Token = "0x6000567")]
				[Cpp2IlInjected.Address(RVA = "0x1A52DC0", Offset = "0x1A513C0", VA = "0x181A52DC0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public Vector3 direction3D
			{
				[Cpp2IlInjected.Token(Token = "0x6000568")]
				[Cpp2IlInjected.Address(RVA = "0x1A52D20", Offset = "0x1A51320", VA = "0x181A52D20")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x1A52560", Offset = "0x1A50B60", VA = "0x181A52560")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(RVA = "0x1A52D00", Offset = "0x1A51300", VA = "0x181A52D00")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		public class CameraPosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			[Range(0f, 180f)]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			public float maxAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(RVA = "0x1A51FC0", Offset = "0x1A505C0", VA = "0x181A51FC0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(RVA = "0x1A52120", Offset = "0x1A50720", VA = "0x181A52120")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x1A524E0", Offset = "0x1A50AE0", VA = "0x181A524E0")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public class Range
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x20000A4")]
			public class Interaction
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400050A")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400050B")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Cpp2IlInjected.Token(Token = "0x6000570")]
				[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
				public Interaction()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000505")]
			[HideInInspector]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000506")]
			[HideInInspector]
			public bool show;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000507")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000508")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000509")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(RVA = "0x1A5C7C0", Offset = "0x1A5ADC0", VA = "0x181A5C7C0")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x1A5C8D0", Offset = "0x1A5AED0", VA = "0x181A5C8D0")]
			public Range()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x17C8FA0", Offset = "0x17C75A0", VA = "0x1817C8FA0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x17C8F20", Offset = "0x17C7520", VA = "0x1817C8F20")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x17C8F60", Offset = "0x17C7560", VA = "0x1817C8F60")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x17C8FE0", Offset = "0x17C75E0", VA = "0x1817C8FE0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x17C8CE0", Offset = "0x17C72E0", VA = "0x1817C8CE0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x17C8D20", Offset = "0x17C7320", VA = "0x1817C8D20")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x17C9020", Offset = "0x17C7620", VA = "0x1817C9020")]
		public InteractionTrigger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public class Map
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public Transform bone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public Transform target;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			private Vector3 defaultLocalPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			private Quaternion defaultLocalRotation;

			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0x16089F0", Offset = "0x1606FF0", VA = "0x1816089F0")]
			public Map(Transform bone, Transform target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x1603D30", Offset = "0x1602330", VA = "0x181603D30")]
			public void StoreDefaultState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x1608800", Offset = "0x1606E00", VA = "0x181608800")]
			public void FixTransform()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x1608860", Offset = "0x1606E60", VA = "0x181608860")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public Map[] maps;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x1971640", Offset = "0x196FC40", VA = "0x181971640", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x1971A90", Offset = "0x1970090", VA = "0x181971A90", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x1971B20", Offset = "0x1970120", VA = "0x181971B20", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x1971960", Offset = "0x196FF60", VA = "0x181971960", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x1971AA0", Offset = "0x19700A0", VA = "0x181971AA0")]
		private void StoreDefaultState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x19719E0", Offset = "0x196FFE0", VA = "0x1819719E0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x1971C30", Offset = "0x1970230", VA = "0x181971C30")]
		public GenericPoser()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public class HandPoser : Poser
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		protected Transform[] children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private Transform _poseRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private Transform[] poseChildren;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private Vector3[] defaultLocalPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private Quaternion[] defaultLocalRotations;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x19BEEA0", Offset = "0x19BD4A0", VA = "0x1819BEEA0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x19BF0C0", Offset = "0x19BD6C0", VA = "0x1819BF0C0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x19BEF70", Offset = "0x19BD570", VA = "0x1819BEF70", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x19BF300", Offset = "0x19BD900", VA = "0x1819BF300", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x19BF120", Offset = "0x19BD720", VA = "0x1819BF120")]
		protected void StoreDefaultState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x1971C30", Offset = "0x1970230", VA = "0x181971C30")]
		public HandPoser()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public abstract class Poser : SolverManager
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public Transform poseRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private bool initiated;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void AutoMapping();

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xC94CB0", Offset = "0xC932B0", VA = "0x180C94CB0")]
		public void UpdateManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void InitiatePoser();

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void UpdatePoser();

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void FixPoserTransforms();

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x17D32F0", Offset = "0x17D18F0", VA = "0x1817D32F0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x17D32C0", Offset = "0x17D18C0", VA = "0x1817D32C0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x17D32A0", Offset = "0x17D18A0", VA = "0x1817D32A0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x17D3340", Offset = "0x17D1940", VA = "0x1817D3340")]
		protected Poser()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class RagdollUtility : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public class Rigidbone
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			public Rigidbody r;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public Transform t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public Collider collider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public Joint joint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public Rigidbody c;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public bool updateAnchor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public Vector3 deltaPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			public Quaternion deltaRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			public float deltaTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			public Vector3 lastPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public Quaternion lastRotation;

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x1A5CCB0", Offset = "0x1A5B2B0", VA = "0x181A5CCB0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x1A5C8E0", Offset = "0x1A5AEE0", VA = "0x181A5C8E0")]
			public void RecordVelocity()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x1A5CA20", Offset = "0x1A5B020", VA = "0x181A5CA20")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public class Child
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			public Transform t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			public Vector3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			public Quaternion localRotation;

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x1A53000", Offset = "0x1A51600", VA = "0x181A53000")]
			public Child(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x1A52DE0", Offset = "0x1A513E0", VA = "0x181A52DE0")]
			public void FixTransform(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x1A52FA0", Offset = "0x1A515A0", VA = "0x181A52FA0")]
			public void StoreLocalState()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			public RagdollUtility <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005A6")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005A8")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x1A619E0", Offset = "0x1A5FFE0", VA = "0x181A619E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x1A61C50", Offset = "0x1A60250", VA = "0x181A61C50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private Rigidbone[] rigidbones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private Child[] children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private bool enableRagdollFlag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private IK[] allIKComponents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private bool[] fixTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private float ragdollWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private float ragdollWeightV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private bool fixedFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private bool[] disabledIKComponents;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private bool isRagdoll
		{
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x17D60B0", Offset = "0x17D46B0", VA = "0x1817D60B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private bool ikUsed
		{
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x17D5F60", Offset = "0x17D4560", VA = "0x1817D5F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x17D4CF0", Offset = "0x17D32F0", VA = "0x1817D4CF0")]
		public void EnableRagdoll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x17D4BA0", Offset = "0x17D31A0", VA = "0x1817D4BA0")]
		public void DisableRagdoll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x17D5560", Offset = "0x17D3B60", VA = "0x1817D5560")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x17D4B30", Offset = "0x17D3130", VA = "0x1817D4B30")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x17D5AD0", Offset = "0x17D40D0", VA = "0x1817D5AD0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x17D4DE0", Offset = "0x17D33E0", VA = "0x1817D4DE0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x17D4E70", Offset = "0x17D3470", VA = "0x1817D4E70")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x17D4B00", Offset = "0x17D3100", VA = "0x1817D4B00")]
		private void AfterLastIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x17D4A30", Offset = "0x17D3030", VA = "0x1817D4A30")]
		private void AfterAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x17D50E0", Offset = "0x17D36E0", VA = "0x1817D50E0")]
		private void OnFinalPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x17D51C0", Offset = "0x17D37C0", VA = "0x1817D51C0")]
		private void RagdollEnabler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x17D5500", Offset = "0x17D3B00", VA = "0x1817D5500")]
		private void RecordVelocities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x17D5A70", Offset = "0x17D4070", VA = "0x1817D5A70")]
		private void StoreLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x17D4D70", Offset = "0x17D3370", VA = "0x1817D4D70")]
		private void FixTransforms(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x17D4FB0", Offset = "0x17D35B0", VA = "0x1817D4FB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x17D5E60", Offset = "0x17D4460", VA = "0x1817D5E60")]
		public RagdollUtility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public Vector3 axis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private bool initiated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private bool applicationQuit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private bool defaultLocalRotationSet;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Vector3 secondaryAxis
		{
			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x17DAFE0", Offset = "0x17D95E0", VA = "0x1817DAFE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Vector3 crossAxis
		{
			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x17DAF70", Offset = "0x17D9570", VA = "0x1817DAF70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool defaultLocalRotationOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x983D50", Offset = "0x982350", VA = "0x180983D50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0xCDBAF0", Offset = "0xCDA0F0", VA = "0x180CDBAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x17DAEE0", Offset = "0x17D94E0", VA = "0x1817DAEE0")]
		public void SetDefaultLocalRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x17DAF20", Offset = "0x17D9520", VA = "0x1817DAF20")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x17DA8F0", Offset = "0x17D8EF0", VA = "0x1817DA8F0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x17DA640", Offset = "0x17D8C40", VA = "0x1817DA640")]
		public bool Apply()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x17DA8C0", Offset = "0x17D8EC0", VA = "0x1817DA8C0")]
		public void Disable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x17DA7C0", Offset = "0x17D8DC0", VA = "0x1817DA7C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x17DAAB0", Offset = "0x17D90B0", VA = "0x1817DAAB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x17DAEB0", Offset = "0x17D94B0", VA = "0x1817DAEB0")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x17DAC30", Offset = "0x17D9230", VA = "0x1817DAC30")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x17DACF0", Offset = "0x17D92F0", VA = "0x1817DACF0")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x17DAA30", Offset = "0x17D9030", VA = "0x1817DAA30")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x17DAF30", Offset = "0x17D9530", VA = "0x1817DAF30")]
		protected RotationLimit()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		[Range(0f, 180f)]
		public float limit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x17D7FE0", Offset = "0x17D65E0", VA = "0x1817D7FE0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x17D7FA0", Offset = "0x17D65A0", VA = "0x1817D7FA0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x17D8020", Offset = "0x17D6620", VA = "0x1817D8020")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x17D7AF0", Offset = "0x17D60F0", VA = "0x1817D7AF0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x17D7B30", Offset = "0x17D6130", VA = "0x1817D7B30", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x17D7DA0", Offset = "0x17D63A0", VA = "0x1817D7DA0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x17D8060", Offset = "0x17D6660", VA = "0x1817D8060")]
		public RotationLimitAngle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public bool useLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public float max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private float lastAngle;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x17D8410", Offset = "0x17D6A10", VA = "0x1817D8410")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x17D83D0", Offset = "0x17D69D0", VA = "0x1817D83D0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x17D8450", Offset = "0x17D6A50", VA = "0x1817D8450")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x17D80B0", Offset = "0x17D66B0", VA = "0x1817D80B0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x17D8390", Offset = "0x17D6990", VA = "0x1817D8390", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x17D80F0", Offset = "0x17D66F0", VA = "0x1817D80F0")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x17D8490", Offset = "0x17D6A90", VA = "0x1817D8490")]
		public RotationLimitHinge()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		public class ReachCone
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public Vector3[] tetrahedron;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public float volume;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public Vector3 S;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public Vector3 B;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public Vector3 o
			{
				[Cpp2IlInjected.Token(Token = "0x60005D8")]
				[Cpp2IlInjected.Address(RVA = "0x1CCF530", Offset = "0x1CCDB30", VA = "0x181CCF530")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			public Vector3 a
			{
				[Cpp2IlInjected.Token(Token = "0x60005D9")]
				[Cpp2IlInjected.Address(RVA = "0x1CCF460", Offset = "0x1CCDA60", VA = "0x181CCF460")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public Vector3 b
			{
				[Cpp2IlInjected.Token(Token = "0x60005DA")]
				[Cpp2IlInjected.Address(RVA = "0x1CCF4A0", Offset = "0x1CCDAA0", VA = "0x181CCF4A0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public Vector3 c
			{
				[Cpp2IlInjected.Token(Token = "0x60005DB")]
				[Cpp2IlInjected.Address(RVA = "0x1CCF4E0", Offset = "0x1CCDAE0", VA = "0x181CCF4E0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public bool isValid
			{
				[Cpp2IlInjected.Token(Token = "0x60005DD")]
				[Cpp2IlInjected.Address(RVA = "0x1CCF520", Offset = "0x1CCDB20", VA = "0x181CCF520")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x1CCF2B0", Offset = "0x1CCD8B0", VA = "0x181CCF2B0")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0x1CCF060", Offset = "0x1CCD660", VA = "0x181CCF060")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		public class LimitPoint
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			public Vector3 point;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public float tangentWeight;

			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x1CCEDB0", Offset = "0x1CCD3B0", VA = "0x181CCEDB0")]
			public LimitPoint()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[HideInInspector]
		public LimitPoint[] points;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		[HideInInspector]
		public Vector3[] P;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x17D9140", Offset = "0x17D7740", VA = "0x1817D9140")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x17D9100", Offset = "0x17D7700", VA = "0x1817D9100")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x17DA3D0", Offset = "0x17D89D0", VA = "0x1817DA3D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x17D84E0", Offset = "0x17D6AE0", VA = "0x1817D84E0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x17D9730", Offset = "0x17D7D30", VA = "0x1817D9730")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x17D8CC0", Offset = "0x17D72C0", VA = "0x1817D8CC0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x17DA010", Offset = "0x17D8610", VA = "0x1817DA010")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x17D92B0", Offset = "0x17D78B0", VA = "0x1817D92B0")]
		public void ResetToDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x17D8520", Offset = "0x17D6B20", VA = "0x1817D8520")]
		public void BuildReachCones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x17D97C0", Offset = "0x17D7DC0", VA = "0x1817D97C0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x17D8C70", Offset = "0x17D7270", VA = "0x1817D8C70")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x17D9180", Offset = "0x17D7780", VA = "0x1817D9180")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x17DA410", Offset = "0x17D8A10", VA = "0x1817DA410")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x17D8DC0", Offset = "0x17D73C0", VA = "0x1817D8DC0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x17D8AD0", Offset = "0x17D70D0", VA = "0x1817D8AD0")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x17DA5C0", Offset = "0x17D8BC0", VA = "0x1817DA5C0")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitSpline : RotationLimit
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[HideInInspector]
		public AnimationCurve spline;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x1609E10", Offset = "0x1608410", VA = "0x181609E10")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x1609DD0", Offset = "0x16083D0", VA = "0x181609DD0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x1609E70", Offset = "0x1608470", VA = "0x181609E70")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x16099D0", Offset = "0x1607FD0", VA = "0x1816099D0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x1609E50", Offset = "0x1608450", VA = "0x181609E50")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x1609A10", Offset = "0x1608010", VA = "0x181609A10", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x1609AF0", Offset = "0x16080F0", VA = "0x181609AF0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x1609EB0", Offset = "0x16084B0", VA = "0x181609EB0")]
		public RotationLimitSpline()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public class AimController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			public AimController <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005F2")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005F4")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x160FB40", Offset = "0x160E140", VA = "0x18160FB40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x160FC20", Offset = "0x160E220", VA = "0x18160FC20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
		public float smoothDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		[Header("Mode")]
		public bool useAnimatedAimDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private Transform lastTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private float switchWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private float switchWeightV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private float weightV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private Vector3 dir;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private bool lastSmoothTowardsTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB5")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private bool turningToTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private float turnToTargetMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private float turnToTargetMlpV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float yawV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private float pitchV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private float dirMagV;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		private Vector3 pivot
		{
			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x18F74A0", Offset = "0x18F5AA0", VA = "0x1818F74A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x18F7290", Offset = "0x18F5890", VA = "0x1818F7290")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x18F6290", Offset = "0x18F4890", VA = "0x1818F6290")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x18F6120", Offset = "0x18F4720", VA = "0x1818F6120")]
		private void ApplyMinDistance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x18F6F90", Offset = "0x18F5590", VA = "0x1818F6F90")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x18F7390", Offset = "0x18F5990", VA = "0x1818F7390")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x18F7400", Offset = "0x18F5A00", VA = "0x1818F7400")]
		public AimController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		public class Pose
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			public bool visualize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public Vector3 direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public float yaw;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public float pitch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			private float angleBuffer;

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x1609240", Offset = "0x1607840", VA = "0x181609240")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0xA7FB40", Offset = "0xA7E140", VA = "0x180A7FB40")]
			public void SetAngleBuffer(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x1609490", Offset = "0x1607A90", VA = "0x181609490")]
			public Pose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public float angleBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public Pose[] poses;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x18F7770", Offset = "0x18F5D70", VA = "0x1818F7770")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x18F7880", Offset = "0x18F5E80", VA = "0x1818F7880")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x18F7910", Offset = "0x18F5F10", VA = "0x1818F7910")]
		public AimPoser()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public class Body
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x20000BA")]
			public class EffectorLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400058A")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400058B")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Cpp2IlInjected.Token(Token = "0x6000600")]
				[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
				public EffectorLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			private Vector3 lastRelativePos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			private Vector3 smoothDelta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			private bool firstUpdate;

			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x1602800", Offset = "0x1600E00", VA = "0x181602800")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x16027A0", Offset = "0x1600DA0", VA = "0x1816027A0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x1602E90", Offset = "0x1601490", VA = "0x181602E90")]
			public Body()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x18F7A90", Offset = "0x18F6090", VA = "0x1818F7A90", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x18F7BE0", Offset = "0x18F61E0", VA = "0x1818F7BE0")]
		public Amplifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class BodyTilt : OffsetModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private float tiltAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private Vector3 lastForward;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x190B300", Offset = "0x1909900", VA = "0x18190B300", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x190B100", Offset = "0x1909700", VA = "0x18190B100", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x190B350", Offset = "0x1909950", VA = "0x18190B350")]
		public BodyTilt()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public CCDIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x190B7C0", Offset = "0x1909DC0", VA = "0x18190B7C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x190B370", Offset = "0x1909970", VA = "0x18190B370")]
		private void BeforeIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x190B6A0", Offset = "0x1909CA0", VA = "0x18190B6A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x18FED60", Offset = "0x18FD360", VA = "0x1818FED60")]
		public CCDBendGoal()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		[HideInInspector]
		public Transform[] bones;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public IK ik
		{
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x7E5D70", Offset = "0x7E4370", VA = "0x1807E5D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x1960EF0", Offset = "0x195F4F0", VA = "0x181960EF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x1960DF0", Offset = "0x195F3F0", VA = "0x181960DF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x1960C80", Offset = "0x195F280", VA = "0x181960C80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x1961090", Offset = "0x195F690", VA = "0x181961090")]
		public void StoreDefaultPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x1960A20", Offset = "0x195F020", VA = "0x181960A20")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x19612B0", Offset = "0x195F8B0", VA = "0x1819612B0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x19615D0", Offset = "0x195FBD0", VA = "0x1819615D0")]
		public EditorIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CreateAssetMenu]
	public class EditorIKPose : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public Vector3[] localPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public Quaternion[] localRotations;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool poseStored
		{
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x1960A00", Offset = "0x195F000", VA = "0x181960A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x19607E0", Offset = "0x195EDE0", VA = "0x1819607E0")]
		public void Store(Transform[] T)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x1960630", Offset = "0x195EC30", VA = "0x181960630")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x1960980", Offset = "0x195EF80", VA = "0x181960980")]
		public EditorIKPose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		public abstract class HitPoint
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40005A3")]
			private float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005A4")]
			private float crossFadeSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40005A5")]
			private float lastTime;

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public bool inProgress
			{
				[Cpp2IlInjected.Token(Token = "0x6000619")]
				[Cpp2IlInjected.Address(RVA = "0x1605C40", Offset = "0x1604240", VA = "0x181605C40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			protected float crossFader
			{
				[Cpp2IlInjected.Token(Token = "0x600061A")]
				[Cpp2IlInjected.Address(RVA = "0xA1F3D0", Offset = "0xA1D9D0", VA = "0x180A1F3D0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600061B")]
				[Cpp2IlInjected.Address(RVA = "0xA1F440", Offset = "0xA1DA40", VA = "0x180A1F440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B3")]
			protected float timer
			{
				[Cpp2IlInjected.Token(Token = "0x600061C")]
				[Cpp2IlInjected.Address(RVA = "0xA7F710", Offset = "0xA7DD10", VA = "0x180A7F710")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600061D")]
				[Cpp2IlInjected.Address(RVA = "0xA7FC10", Offset = "0xA7E210", VA = "0x180A7FC10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B4")]
			protected Vector3 force
			{
				[Cpp2IlInjected.Token(Token = "0x600061E")]
				[Cpp2IlInjected.Address(RVA = "0x1605C20", Offset = "0x1604220", VA = "0x181605C20")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600061F")]
				[Cpp2IlInjected.Address(RVA = "0x1605C50", Offset = "0x1604250", VA = "0x181605C50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B5")]
			protected Vector3 point
			{
				[Cpp2IlInjected.Token(Token = "0x6000620")]
				[Cpp2IlInjected.Address(RVA = "0x79D0C0", Offset = "0x79B6C0", VA = "0x18079D0C0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000621")]
				[Cpp2IlInjected.Address(RVA = "0x79D140", Offset = "0x79B740", VA = "0x18079D140")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x1605B00", Offset = "0x1604100", VA = "0x181605B00")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x1605A30", Offset = "0x1604030", VA = "0x181605A30")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(Slot = "4")]
			protected abstract float GetLength();

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(Slot = "5")]
			protected abstract void CrossFadeStart();

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(Slot = "6")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0x1605650", Offset = "0x1603C50", VA = "0x181605650")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			public class EffectorLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40005A9")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40005AA")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40005AB")]
				private Vector3 lastValue;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40005AC")]
				private Vector3 current;

				[Cpp2IlInjected.Token(Token = "0x600062C")]
				[Cpp2IlInjected.Address(RVA = "0x1CCD990", Offset = "0x1CCBF90", VA = "0x181CCD990")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600062D")]
				[Cpp2IlInjected.Address(RVA = "0x1CCDB00", Offset = "0x1CCC100", VA = "0x181CCDB00")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600062E")]
				[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
				public EffectorLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x16056C0", Offset = "0x1603CC0", VA = "0x1816056C0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x1605660", Offset = "0x1603C60", VA = "0x181605660", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x1605810", Offset = "0x1603E10", VA = "0x181605810", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x1605650", Offset = "0x1603C50", VA = "0x181605650")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x20000C4")]
			public class BoneLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40005B0")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40005B1")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40005B2")]
				private Quaternion lastValue;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40005B3")]
				private Quaternion current;

				[Cpp2IlInjected.Token(Token = "0x6000633")]
				[Cpp2IlInjected.Address(RVA = "0x1CCD820", Offset = "0x1CCBE20", VA = "0x181CCD820")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000634")]
				[Cpp2IlInjected.Address(RVA = "0x1CCD940", Offset = "0x1CCBF40", VA = "0x181CCD940")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000635")]
				[Cpp2IlInjected.Address(RVA = "0x1CCD950", Offset = "0x1CCBF50", VA = "0x181CCD950")]
				public BoneLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			private Rigidbody rigidbody;

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x1605350", Offset = "0x1603950", VA = "0x181605350", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x16052F0", Offset = "0x16038F0", VA = "0x1816052F0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x16053F0", Offset = "0x16039F0", VA = "0x1816053F0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x1605650", Offset = "0x1603C50", VA = "0x181605650")]
			public HitPointBone()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool inProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x19C1360", Offset = "0x19BF960", VA = "0x1819C1360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x19C1260", Offset = "0x19BF860", VA = "0x1819C1260", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x19C0FD0", Offset = "0x19BF5D0", VA = "0x1819C0FD0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x18F7BE0", Offset = "0x18F61E0", VA = "0x1818F7BE0")]
		public HitReaction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public abstract class Offset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005B9")]
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40005BE")]
			private float length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			private float crossFadeSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			private float lastTime;

			[Cpp2IlInjected.Token(Token = "0x170000B6")]
			protected float crossFader
			{
				[Cpp2IlInjected.Token(Token = "0x6000639")]
				[Cpp2IlInjected.Address(RVA = "0xA1F3D0", Offset = "0xA1D9D0", VA = "0x180A1F3D0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600063A")]
				[Cpp2IlInjected.Address(RVA = "0xA1F440", Offset = "0xA1DA40", VA = "0x180A1F440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B7")]
			protected float timer
			{
				[Cpp2IlInjected.Token(Token = "0x600063B")]
				[Cpp2IlInjected.Address(RVA = "0xA7F710", Offset = "0xA7DD10", VA = "0x180A7F710")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600063C")]
				[Cpp2IlInjected.Address(RVA = "0xA7FC10", Offset = "0xA7E210", VA = "0x180A7FC10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B8")]
			protected Vector3 force
			{
				[Cpp2IlInjected.Token(Token = "0x600063D")]
				[Cpp2IlInjected.Address(RVA = "0x1605C20", Offset = "0x1604220", VA = "0x181605C20")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600063E")]
				[Cpp2IlInjected.Address(RVA = "0x1605C50", Offset = "0x1604250", VA = "0x181605C50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B9")]
			protected Vector3 point
			{
				[Cpp2IlInjected.Token(Token = "0x600063F")]
				[Cpp2IlInjected.Address(RVA = "0x79D0C0", Offset = "0x79B6C0", VA = "0x18079D0C0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000640")]
				[Cpp2IlInjected.Address(RVA = "0x79D140", Offset = "0x79B740", VA = "0x18079D140")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x1608D00", Offset = "0x1607300", VA = "0x181608D00")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x1608C10", Offset = "0x1607210", VA = "0x181608C10")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(Slot = "4")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(Slot = "5")]
			protected abstract void CrossFadeStart();

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(Slot = "6")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x1605650", Offset = "0x1603C50", VA = "0x181605650")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x20000C8")]
			public class PositionOffsetLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40005C4")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40005C5")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40005C6")]
				private Vector3 lastValue;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40005C7")]
				private Vector3 current;

				[Cpp2IlInjected.Token(Token = "0x600064B")]
				[Cpp2IlInjected.Address(RVA = "0x1CCEF40", Offset = "0x1CCD540", VA = "0x181CCEF40")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600064C")]
				[Cpp2IlInjected.Address(RVA = "0x1CCDB00", Offset = "0x1CCC100", VA = "0x181CCDB00")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600064D")]
				[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
				public PositionOffsetLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005C1")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x1609510", Offset = "0x1607B10", VA = "0x181609510", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x16094B0", Offset = "0x1607AB0", VA = "0x1816094B0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x1609730", Offset = "0x1607D30", VA = "0x181609730", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x16099B0", Offset = "0x1607FB0", VA = "0x1816099B0")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			public class RotationOffsetLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40005CB")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40005CC")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40005CD")]
				private Quaternion lastValue;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40005CE")]
				private Quaternion current;

				[Cpp2IlInjected.Token(Token = "0x6000652")]
				[Cpp2IlInjected.Address(RVA = "0x1CD1070", Offset = "0x1CCF670", VA = "0x181CD1070")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000653")]
				[Cpp2IlInjected.Address(RVA = "0x1CD1160", Offset = "0x1CCF760", VA = "0x181CD1160")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000654")]
				[Cpp2IlInjected.Address(RVA = "0x1CD1170", Offset = "0x1CCF770", VA = "0x181CD1170")]
				public RotationOffsetLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			private Rigidbody rigidbody;

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x1609F20", Offset = "0x1608520", VA = "0x181609F20", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x1609EC0", Offset = "0x16084C0", VA = "0x181609EC0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x160A040", Offset = "0x1608640", VA = "0x18160A040", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x1605650", Offset = "0x1603C50", VA = "0x181605650")]
			public RotationOffset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public AnimationCurve[] offsetCurves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x19C0EE0", Offset = "0x19BF4E0", VA = "0x1819C0EE0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x19C0C40", Offset = "0x19BF240", VA = "0x1819C0C40")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x18F7BE0", Offset = "0x18F61E0", VA = "0x1818F7BE0")]
		public HitReactionVRIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		public class Body
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x20000CD")]
			public class EffectorLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40005DC")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40005DD")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Cpp2IlInjected.Token(Token = "0x600065B")]
				[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
				public EffectorLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005D1")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005D2")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40005D4")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			private Vector3 delta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			private Vector3 lazyPoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			private Vector3 direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			private Vector3 lastPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			private bool firstUpdate;

			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0x1A50EA0", Offset = "0x1A4F4A0", VA = "0x181A50EA0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x1A50F80", Offset = "0x1A4F580", VA = "0x181A50F80")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0x1A514E0", Offset = "0x1A4FAE0", VA = "0x181A514E0")]
			public Body()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x1A12230", Offset = "0x1A10830", VA = "0x181A12230")]
		public void ResetBodies()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x1A12160", Offset = "0x1A10760", VA = "0x181A12160", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x18F7BE0", Offset = "0x18F61E0", VA = "0x1818F7BE0")]
		public Inertia()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public class LookAtController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public LookAtIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public Vector3 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private Transform lastTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private float switchWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private float switchWeightV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private float weightV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private Vector3 dir;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private bool lastSmoothTowardsTarget;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private Vector3 pivot
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x17CBB70", Offset = "0x17CA170", VA = "0x1817CBB70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x17CBA30", Offset = "0x17CA030", VA = "0x1817CBA30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x17CADD0", Offset = "0x17C93D0", VA = "0x1817CADD0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x17CAC60", Offset = "0x17C9260", VA = "0x1817CAC60")]
		private void ApplyMinDistance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x17CB790", Offset = "0x17C9D90", VA = "0x1817CB790")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x17CBB00", Offset = "0x17CA100", VA = "0x1817CBB00")]
		public LookAtController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public class OffsetLimits
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x40005F8")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40005FA")]
			[Tooltip("The limits")]
			public float minX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			[Tooltip("The limits")]
			public float maxX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			[Tooltip("The limits")]
			public float minY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			[Tooltip("The limits")]
			public float maxY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			[Tooltip("The limits")]
			public float minZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005FF")]
			[Tooltip("The limits")]
			public float maxZ;

			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B670", Offset = "0x1A59C70", VA = "0x181A5B670")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B840", Offset = "0x1A59E40", VA = "0x181A5B840")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B8C0", Offset = "0x1A59EC0", VA = "0x181A5B8C0")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public OffsetLimits()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000600")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			public OffsetModifier <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000BC")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000671")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BD")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000673")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x1A61E60", Offset = "0x1A60460", VA = "0x181A61E60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x1A61FF0", Offset = "0x1A605F0", VA = "0x181A61FF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		[Tooltip("The master weight")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		protected float lastTime;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		protected float deltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x17D0640", Offset = "0x17CEC40", VA = "0x1817D0640")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void OnModifyOffset();

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x17D09C0", Offset = "0x17CEFC0", VA = "0x1817D09C0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x17D0750", Offset = "0x17CED50", VA = "0x1817D0750")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x17D07C0", Offset = "0x17CEDC0", VA = "0x1817D07C0")]
		private void ModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x17D0660", Offset = "0x17CEC60", VA = "0x1817D0660")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x17D08A0", Offset = "0x17CEEA0", VA = "0x1817D08A0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x17D0340", Offset = "0x17CE940", VA = "0x1817D0340")]
		protected OffsetModifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000606")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000607")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000608")]
			public OffsetModifierVRIK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000BF")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600067E")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C0")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000680")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x1A61C90", Offset = "0x1A60290", VA = "0x181A61C90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0x1A61E20", Offset = "0x1A60420", VA = "0x181A61E20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		[Tooltip("The master weight")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private float lastTime;

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		protected float deltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x17D0640", Offset = "0x17CEC40", VA = "0x1817D0640")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void OnModifyOffset();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x17D05C0", Offset = "0x17CEBC0", VA = "0x1817D05C0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x17D0350", Offset = "0x17CE950", VA = "0x1817D0350")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x17D03C0", Offset = "0x17CE9C0", VA = "0x1817D03C0")]
		private void ModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x17D04A0", Offset = "0x17CEAA0", VA = "0x1817D04A0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x17D0340", Offset = "0x17CE940", VA = "0x1817D0340")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public class EffectorLink
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400060A")]
			public FullBodyBipedEffector effector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400060B")]
			public Vector3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400060C")]
			public Vector3 pin;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400060D")]
			public Vector3 pinWeight;

			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x1A53090", Offset = "0x1A51690", VA = "0x181A53090")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public EffectorLink()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public EffectorLink[] effectorLinks;

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x17D0A40", Offset = "0x17CF040", VA = "0x1817D0A40")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x17D0B30", Offset = "0x17CF130", VA = "0x1817D0B30")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x17D0C00", Offset = "0x17CF200", VA = "0x1817D0C00")]
		public OffsetPose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		public class Avoider
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			public class EffectorLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000619")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400061A")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Cpp2IlInjected.Token(Token = "0x600068C")]
				[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
				public EffectorLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400060F")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000610")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000611")]
			[Range(0f, 1f)]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			public float raycastRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000612")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000613")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000614")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			private Vector3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			private Vector3 offsetTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			private Vector3 offsetV;

			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0x1A50050", Offset = "0x1A4E650", VA = "0x181A50050")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0x1A4FB80", Offset = "0x1A4E180", VA = "0x181A4FB80")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x1A4FD50", Offset = "0x1A4E350", VA = "0x181A4FD50")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x1A503E0", Offset = "0x1A4E9E0", VA = "0x181A503E0")]
			public Avoider()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x17D19B0", Offset = "0x17CFFB0", VA = "0x1817D19B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x17D0340", Offset = "0x17CE940", VA = "0x1817D0340")]
		public PenetrationAvoidance()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		public class RecoilOffset
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x20000DB")]
			public class EffectorLink
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000638")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000639")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Cpp2IlInjected.Token(Token = "0x600069C")]
				[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
				public EffectorLink()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000632")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000633")]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000634")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000635")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000636")]
			private Vector3 additiveOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			private Vector3 lastOffset;

			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0x1CCF820", Offset = "0x1CCDE20", VA = "0x181CCF820")]
			public void Start()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0x1CCF570", Offset = "0x1CCDB70", VA = "0x181CCF570")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x1CCF8D0", Offset = "0x1CCDED0", VA = "0x181CCF8D0")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		public enum Handedness
		{
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			Right,
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			Left
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		[Space]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private float magnitudeMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private float endTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private Quaternion handRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private Quaternion secondaryHandRelativeRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private Quaternion randomRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private float length;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private bool initiated;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private float blendWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private float w;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private Quaternion primaryHandRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private bool handRotationsSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private Vector3 aimIKAxis;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool isFinished
		{
			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0x17D7790", Offset = "0x17D5D90", VA = "0x1817D7790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private IKEffector primaryHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x17D77B0", Offset = "0x17D5DB0", VA = "0x1817D77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private IKEffector secondaryHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x17D7850", Offset = "0x17D5E50", VA = "0x1817D7850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		private Transform primaryHand
		{
			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0x17D7800", Offset = "0x17D5E00", VA = "0x1817D7800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		private Transform secondaryHand
		{
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x17D78A0", Offset = "0x17D5EA0", VA = "0x1817D78A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x17D76E0", Offset = "0x17D5CE0", VA = "0x1817D76E0")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x17D6410", Offset = "0x17D4A10", VA = "0x1817D6410")]
		public void Fire(float magnitude)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x17D67C0", Offset = "0x17D4DC0", VA = "0x1817D67C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x17D6260", Offset = "0x17D4860", VA = "0x1817D6260")]
		private void AfterFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x17D6210", Offset = "0x17D4810", VA = "0x1817D6210")]
		private void AfterAimIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x17D65B0", Offset = "0x17D4BB0", VA = "0x1817D65B0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x17D7710", Offset = "0x17D5D10", VA = "0x1817D7710")]
		public Recoil()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private bool skip;

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x160B9E0", Offset = "0x1609FE0", VA = "0x18160B9E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x160B8E0", Offset = "0x1609EE0", VA = "0x18160B8E0")]
		private void RotateShoulders()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x160B3B0", Offset = "0x16099B0", VA = "0x18160B3B0")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x160B250", Offset = "0x1609850", VA = "0x18160B250")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x160B290", Offset = "0x1609890", VA = "0x18160B290")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x160BAE0", Offset = "0x160A0E0", VA = "0x18160BAE0")]
		public ShoulderRotator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000643")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000644")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000646")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000647")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000648")]
			[Space]
			[Space(10f)]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			public Vector3 headOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000649")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400064A")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400064B")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			[Range(-180f, 180f)]
			public float footHeadingOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400064D")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x1CD11B0", Offset = "0x1CCF7B0", VA = "0x181CD11B0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		public class CalibrationData
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x20000E1")]
			public class Target
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400065B")]
				public bool used;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400065C")]
				public Vector3 localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400065D")]
				public Quaternion localRotation;

				[Cpp2IlInjected.Token(Token = "0x60006B4")]
				[Cpp2IlInjected.Address(RVA = "0x1CD1300", Offset = "0x1CCF900", VA = "0x181CD1300")]
				public Target(Transform t)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006B5")]
				[Cpp2IlInjected.Address(RVA = "0x1CD1290", Offset = "0x1CCF890", VA = "0x181CD1290")]
				public void SetTo(Transform t)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			public Target head;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			public Target leftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public Target rightHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			public Target pelvis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			public Target leftFoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			public Target rightFoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			public Target leftLegGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			public Target rightLegGoal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000658")]
			public Vector3 pelvisTargetRight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000659")]
			public float pelvisPositionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400065A")]
			public float pelvisRotationWeight;

			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public CalibrationData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x1617690", Offset = "0x1615C90", VA = "0x181617690")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x1617710", Offset = "0x1615D10", VA = "0x181617710")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x1614410", Offset = "0x1612A10", VA = "0x181614410")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x1614250", Offset = "0x1612850", VA = "0x181614250")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x1615470", Offset = "0x1613A70", VA = "0x181615470")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x16136E0", Offset = "0x1611CE0", VA = "0x1816136E0")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x1614430", Offset = "0x1612A30", VA = "0x181614430")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x1613FC0", Offset = "0x16125C0", VA = "0x181613FC0")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x1615200", Offset = "0x1613800", VA = "0x181615200")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x16130D0", Offset = "0x16116D0", VA = "0x1816130D0")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x1612530", Offset = "0x1610B30", VA = "0x181612530")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x1612DD0", Offset = "0x16113D0", VA = "0x181612DD0")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x1612880", Offset = "0x1610E80", VA = "0x181612880")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x16174B0", Offset = "0x1615AB0", VA = "0x1816174B0")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x1616FA0", Offset = "0x16155A0", VA = "0x181616FA0")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public class VRIKLODController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public Renderer LODRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public float LODDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public bool allowCulled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private VRIK ik;

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x1617910", Offset = "0x1615F10", VA = "0x181617910")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x1617960", Offset = "0x1615F60", VA = "0x181617960")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x1617780", Offset = "0x1615D80", VA = "0x181617780")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x1617B20", Offset = "0x1616120", VA = "0x181617B20")]
		public VRIKLODController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public class VRIKRootController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private Transform pelvisTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private Transform leftFootTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private Transform rightFootTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private VRIK ik;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public Vector3 pelvisTargetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60006BA")]
			[Cpp2IlInjected.Address(RVA = "0xFC4C80", Offset = "0xFC3280", VA = "0x180FC4C80")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0xFC4CA0", Offset = "0xFC32A0", VA = "0x180FC4CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x1618420", Offset = "0x1616A20", VA = "0x181618420")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x1618720", Offset = "0x1616D20", VA = "0x181618720")]
		public void Calibrate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x1618540", Offset = "0x1616B40", VA = "0x181618540")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x1618AC0", Offset = "0x16170C0", VA = "0x181618AC0")]
		private void OnPreUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x16189A0", Offset = "0x1616FA0", VA = "0x1816189A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		public class Offset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000669")]
			[HideInInspector]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			public HumanBodyBones bone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400066B")]
			public Vector3 rotationOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400066C")]
			private Transform t;

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x1608AA0", Offset = "0x16070A0", VA = "0x181608AA0")]
			public void Apply(Animator animator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public Offset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public Offset[] offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private Animator animator;

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x196C8D0", Offset = "0x196AED0", VA = "0x18196C8D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x196C770", Offset = "0x196AD70", VA = "0x18196C770")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x196C7E0", Offset = "0x196ADE0", VA = "0x18196C7E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public FKOffset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public class AimBoxing : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public AimIK aimIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public Transform pin;

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x18F6060", Offset = "0x18F4660", VA = "0x1818F6060")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public AimBoxing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public class AimSwing : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AimIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x18F7970", Offset = "0x18F5F70", VA = "0x1818F7970")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x18F7A50", Offset = "0x18F6050", VA = "0x1818F7A50")]
		public AimSwing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public AimIK aim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public LimbIK leftArmIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public Transform leftHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public Transform rightHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public Vector3 leftHandPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public Vector3 leftHandRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private Vector3 leftHandPosRelToRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private Quaternion leftHandRotRelToRight;

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x160B210", Offset = "0x1609810", VA = "0x18160B210")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x160AF60", Offset = "0x1609560", VA = "0x18160AF60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public SecondHandOnGun()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private AimPoser.Pose aimPose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private AimPoser.Pose lastPose;

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x160C150", Offset = "0x160A750", VA = "0x18160C150")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x160BB90", Offset = "0x160A190", VA = "0x18160BB90")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x160BEE0", Offset = "0x160A4E0", VA = "0x18160BEE0")]
		private void Pose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x160BCE0", Offset = "0x160A2E0", VA = "0x18160BCE0")]
		private void LimitAimTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x160BB00", Offset = "0x160A100", VA = "0x18160BB00")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x160C190", Offset = "0x160A790", VA = "0x18160C190")]
		public SimpleAimingSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public class TerrainOffset : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public AimIK aimIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public Vector3 raycastOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public LayerMask raycastLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public float max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public float lerpSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private RaycastHit hit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private Vector3 offset;

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x160D650", Offset = "0x160BC50", VA = "0x18160D650")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x160D410", Offset = "0x160BA10", VA = "0x18160D410")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x160D900", Offset = "0x160BF00", VA = "0x18160D900")]
		public TerrainOffset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		[LargeHeader("References")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public BipedIK bipedIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public Transform lookAtTargetAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public Transform footTargetAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public Transform handTargetAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x1900520", Offset = "0x18FEB20", VA = "0x181900520")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x1900D30", Offset = "0x18FF330", VA = "0x181900D30")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public class MechSpider : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public LayerMask raycastLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public float scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public Transform body;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public MechSpiderLeg[] legs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public float legRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public float rootPositionSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public float rootRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public float breatheSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public float breatheMagnitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public float height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public float minHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public float raycastHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public float raycastDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private Vector3 defaultBodyLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private float sine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private RaycastHit rootHit;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Vector3 velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(RVA = "0x17CEA70", Offset = "0x17CD070", VA = "0x1817CEA70")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0x17CEA90", Offset = "0x17CD090", VA = "0x1817CEA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x17CDFD0", Offset = "0x17CC5D0", VA = "0x1817CDFD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x17CE010", Offset = "0x17CC610", VA = "0x1817CE010")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x17CDAB0", Offset = "0x17CC0B0", VA = "0x1817CDAB0")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x17CDC30", Offset = "0x17CC230", VA = "0x1817CDC30")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x17CEA20", Offset = "0x17CD020", VA = "0x1817CEA20")]
		public MechSpider()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public class MechSpiderController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public MechSpider mechSpider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public Transform cameraTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public float speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public float turnSpeed;

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public Vector3 inputVector
		{
			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(RVA = "0x17CC100", Offset = "0x17CA700", VA = "0x1817CC100")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x17CBE00", Offset = "0x17CA400", VA = "0x1817CBE00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x17CC0E0", Offset = "0x17CA6E0", VA = "0x1817CC0E0")]
		public MechSpiderController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			public MechSpiderLeg <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			public Vector3 stepStartPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			public Vector3 targetPosition;

			[Cpp2IlInjected.Token(Token = "0x170000CB")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60006F2")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CC")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60006F4")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x1A62030", Offset = "0x1A60630", VA = "0x181A62030", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x1A62450", Offset = "0x1A60A50", VA = "0x181A62450", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public MechSpider mechSpider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public MechSpiderLeg unSync;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public Vector3 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public float minDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public float maxOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public float stepSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public float footHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public float velocityPrediction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public float raycastFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public AnimationCurve yOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public Transform foot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public Vector3 footUpAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public float footRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public ParticleSystem sand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private IK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private float stepProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private float lastStepTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private Vector3 defaultPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private RaycastHit hit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private Quaternion lastFootLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private Vector3 smoothHitNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private Vector3 lastStepPosition;

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public bool isStepping
		{
			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0x17CD5F0", Offset = "0x17CBBF0", VA = "0x1817CD5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x17CD610", Offset = "0x17CBC10", VA = "0x1817CD610")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x17CD670", Offset = "0x17CBC70", VA = "0x1817CD670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x17CC3A0", Offset = "0x17CA9A0", VA = "0x1817CC3A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x17CC180", Offset = "0x17CA780", VA = "0x1817CC180")]
		private void AfterIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x17CCA80", Offset = "0x17CB080", VA = "0x1817CCA80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x17CC600", Offset = "0x17CAC00", VA = "0x1817CC600")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x17CCF30", Offset = "0x17CB530", VA = "0x1817CCF30")]
		private void UpdatePosition(float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x17CD200", Offset = "0x17CB800", VA = "0x1817CD200")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x17CCE80", Offset = "0x17CB480", VA = "0x1817CCE80")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x17CD570", Offset = "0x17CBB70", VA = "0x1817CD570")]
		public MechSpiderLeg()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public MechSpiderController mechSpiderController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x17CD6C0", Offset = "0x17CBCC0", VA = "0x1817CD6C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x17CD780", Offset = "0x17CBD80", VA = "0x1817CD780")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public MechSpiderParticles()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public struct Warp
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006D3")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006D4")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006D5")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006D6")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006D7")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006D8")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		public enum EffectorMode
		{
			[Cpp2IlInjected.Token(Token = "0x40006DA")]
			PositionOffset,
			[Cpp2IlInjected.Token(Token = "0x40006DB")]
			Position
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		[Space]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private EffectorMode lastMode;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x18F8380", Offset = "0x18F6980", VA = "0x1818F8380", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x18F7BF0", Offset = "0x18F61F0", VA = "0x1818F7BF0")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x18F7F30", Offset = "0x18F6530", VA = "0x1818F7F30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x18F7E80", Offset = "0x18F6480", VA = "0x1818F7E80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x18F7BE0", Offset = "0x18F61E0", VA = "0x1818F7BE0")]
		public AnimationWarping()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public float rotateSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public float blendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public float maxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public float rootMotionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		protected Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		protected Vector3 moveBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		protected Vector3 moveInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		protected Vector3 velocity;

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x18F9B10", Offset = "0x18F8110", VA = "0x1818F9B10", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x18F9880", Offset = "0x18F7E80", VA = "0x1818F9880")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x18F9600", Offset = "0x18F7C00", VA = "0x1818F9600", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x18F9B60", Offset = "0x18F8160", VA = "0x1818F9B60")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public Vector3 gunHoldOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public Vector3 leftHandOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public Recoil recoil;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private AimIK aim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private Vector3 headLookAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private Vector3 leftHandPosRelToRightHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private Quaternion leftHandRotRelToRightHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		private Vector3 aimTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private Quaternion rightHandRotation;

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x18F9360", Offset = "0x18F7960", VA = "0x1818F9360", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x18F8A60", Offset = "0x18F7060", VA = "0x1818F8A60", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x18F9200", Offset = "0x18F7800", VA = "0x1818F9200")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x18F83A0", Offset = "0x18F69A0", VA = "0x1818F83A0")]
		private void AimIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x18F8400", Offset = "0x18F6A00", VA = "0x1818F8400")]
		private void FBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x18F8E30", Offset = "0x18F7430", VA = "0x1818F8E30")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x18F8800", Offset = "0x18F6E00", VA = "0x1818F8800")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x18F8D00", Offset = "0x18F7300", VA = "0x1818F8D00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x18F95D0", Offset = "0x18F7BD0", VA = "0x1818F95D0")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private FullBodyBipedIK ik;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x190D670", Offset = "0x190BC70", VA = "0x18190D670", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x190D240", Offset = "0x190B840", VA = "0x18190D240", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x190D4B0", Offset = "0x190BAB0", VA = "0x18190D4B0")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x190D740", Offset = "0x190BD40", VA = "0x18190D740")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public CameraController cam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private AnimatorController3rdPerson animatorController;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		private static Vector3 inputVector
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x190EF70", Offset = "0x190D570", VA = "0x18190EF70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		private static Vector3 inputVectorRaw
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x190EEF0", Offset = "0x190D4F0", VA = "0x18190EEF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x190EE80", Offset = "0x190D480", VA = "0x18190EE80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x190EB50", Offset = "0x190D150", VA = "0x18190EB50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public class EffectorOffset : OffsetModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public Vector3 bodyOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public Vector3 leftShoulderOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public Vector3 rightShoulderOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public Vector3 leftThighOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public Vector3 rightThighOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public Vector3 leftHandOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public Vector3 rightHandOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public Vector3 leftFootOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public Vector3 rightFootOffset;

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x1961630", Offset = "0x195FC30", VA = "0x181961630", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x18F7BE0", Offset = "0x18F61E0", VA = "0x1818F7BE0")]
		public EffectorOffset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public SimpleLocomotion character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public float forceMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public float upForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public float weightFalloffSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public AnimationCurve weightFalloff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public AnimationCurve explosionForceByDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public AnimationCurve scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private Vector3 defaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private Rigidbody r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private FullBodyBipedIK ik;

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x1961FE0", Offset = "0x19605E0", VA = "0x181961FE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x19620A0", Offset = "0x19606A0", VA = "0x1819620A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x1961F20", Offset = "0x1960520", VA = "0x181961F20")]
		private void SetEffectorWeights(float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x19626E0", Offset = "0x1960CE0", VA = "0x1819626E0")]
		public ExplosionDemo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class Limb
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000710")]
			public FBIKChain.Smoothing reachSmoothing;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000711")]
			public float maintainRelativePositionWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000712")]
			public float mappingWeight;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x1608770", Offset = "0x1606D70", VA = "0x181608770")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x16087F0", Offset = "0x1606DF0", VA = "0x1816087F0")]
			public Limb()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public bool disableAfterStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public Limb leftArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public Limb rightArm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public Limb leftLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public Limb rightLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public float rootPin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public bool bodyEffectChildNodes;

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x1967E90", Offset = "0x1966490", VA = "0x181967E90")]
		public void UpdateSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x1967E00", Offset = "0x1966400", VA = "0x181967E00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x1968010", Offset = "0x1966610", VA = "0x181968010")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x1968020", Offset = "0x1966620", VA = "0x181968020")]
		public FBBIKSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public FullBodyBipedChain chain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public float weight;

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x1968030", Offset = "0x1966630", VA = "0x181968030")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x1968090", Offset = "0x1966690", VA = "0x181968090")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public FBIKBendGoal()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		[Tooltip("The master weight")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private Animator animator;

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x1968380", Offset = "0x1966980", VA = "0x181968380")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x1968170", Offset = "0x1966770", VA = "0x181968170")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public FBIKBoxing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public bool leftHanded;

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x196BD00", Offset = "0x196A300", VA = "0x18196BD00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x196C6D0", Offset = "0x196ACD0", VA = "0x18196C6D0")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x196BDF0", Offset = "0x196A3F0", VA = "0x18196BDF0")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x196C5A0", Offset = "0x196ABA0", VA = "0x18196C5A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public class FPSAiming : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public Vector3 aimOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public bool animatePhysics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public Transform gun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public Transform gunTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public AimIK gunAim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public AimIK headAim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public CameraControllerFPS cam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public Recoil recoil;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private Vector3 camDefaultLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private Vector3 camRelativeToGunTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private bool updateFrame;

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x196DDC0", Offset = "0x196C3C0", VA = "0x18196DDC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x196CD40", Offset = "0x196B340", VA = "0x18196CD40")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x196CD50", Offset = "0x196B350", VA = "0x18196CD50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x196C920", Offset = "0x196AF20", VA = "0x18196C920")]
		private void Aiming()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x196CE70", Offset = "0x196B470", VA = "0x18196CE70")]
		private void LookDownTheSight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x196DB40", Offset = "0x196C140", VA = "0x18196DB40")]
		private void RotateCharacter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x196DFC0", Offset = "0x196C5C0", VA = "0x18196DFC0")]
		public FPSAiming()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public class FPSCharacter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private float sVel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private FPSAiming FPSAiming;

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x196E0B0", Offset = "0x196C6B0", VA = "0x18196E0B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x196E130", Offset = "0x196C730", VA = "0x18196E130")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x196DFF0", Offset = "0x196C5F0", VA = "0x18196DFF0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x196E220", Offset = "0x196C820", VA = "0x18196E220")]
		public FPSCharacter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public HitReaction hitReaction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public float hitForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private string colliderName;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x19C0790", Offset = "0x19BED90", VA = "0x1819C0790")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x19C06C0", Offset = "0x19BECC0", VA = "0x1819C06C0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x18FED60", Offset = "0x18FD360", VA = "0x1818FED60")]
		public HitReactionTrigger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public class HoldingHands : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public FullBodyBipedIK rightHandChar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public FullBodyBipedIK leftHandChar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public Transform rightHandTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public Transform leftHandTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public float crossFade;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public float speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private Quaternion rightHandRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private Quaternion leftHandRotation;

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x19C18A0", Offset = "0x19BFEA0", VA = "0x1819C18A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x19C1430", Offset = "0x19BFA30", VA = "0x1819C1430")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x19C1A20", Offset = "0x19C0020", VA = "0x1819C1A20")]
		public HoldingHands()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public InteractionSystem character1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public InteractionSystem character2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public InteractionObject handShake;

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x1A12590", Offset = "0x1A10B90", VA = "0x181A12590")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x1A123C0", Offset = "0x1A109C0", VA = "0x181A123C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public InteractionC2CDemo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public class InteractionDemo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public InteractionSystem interactionSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public bool interrupt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public InteractionObject ball;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public InteractionObject benchMain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public InteractionObject benchHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public InteractionObject button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public InteractionObject cigarette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public InteractionObject door;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private bool isSitting;

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x1A12640", Offset = "0x1A10C40", VA = "0x181A12640")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public InteractionDemo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private InteractionSystem interactionSystem;

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x17C3860", Offset = "0x17C1E60", VA = "0x1817C3860")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x17C38B0", Offset = "0x17C1EB0", VA = "0x1817C38B0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000107")]
		public class Partner
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000754")]
			public FullBodyBipedIK ik;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000755")]
			public Transform mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000756")]
			public Transform mouthTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000757")]
			public Transform touchTargetLeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000758")]
			public Transform touchTargetRightHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000759")]
			public float bodyWeightHorizontal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400075A")]
			public float bodyWeightVertical;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400075B")]
			public float neckRotationWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400075C")]
			public float headTiltAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400075D")]
			public Vector3 headTiltAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400075E")]
			private Quaternion neckRotation;

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			private Transform neck
			{
				[Cpp2IlInjected.Token(Token = "0x6000748")]
				[Cpp2IlInjected.Address(RVA = "0x1A5C4D0", Offset = "0x1A5AAD0", VA = "0x181A5C4D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x1962A50", Offset = "0x1961050", VA = "0x181962A50")]
			public void Initiate()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x1A5BB90", Offset = "0x1A5A190", VA = "0x181A5BB90")]
			public void Update(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B930", Offset = "0x1A59F30", VA = "0x181A5B930")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x1A5C4A0", Offset = "0x1A5AAA0", VA = "0x181A5C4A0")]
			public Partner()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public Partner partner1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		public Partner partner2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public int iterations;

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x17CA080", Offset = "0x17C8680", VA = "0x1817CA080")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x17CA020", Offset = "0x17C8620", VA = "0x1817CA020")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x17CA0C0", Offset = "0x17C86C0", VA = "0x1817CA0C0")]
		public KissingRig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		public enum Mode
		{
			[Cpp2IlInjected.Token(Token = "0x4000767")]
			Position,
			[Cpp2IlInjected.Token(Token = "0x4000768")]
			PositionOffset
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200010A")]
		public class Absorber
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000769")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400076A")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400076B")]
			private Vector3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400076C")]
			private Quaternion rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400076D")]
			private IKEffector e;

			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x1A4ACC0", Offset = "0x1A492C0", VA = "0x181A4ACC0")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x1A4ADF0", Offset = "0x1A493F0", VA = "0x181A4ADF0")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x1A4AB10", Offset = "0x1A49110", VA = "0x181A4AB10")]
			public void SetPosition(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x1A4AC10", Offset = "0x1A49210", VA = "0x181A4AC10")]
			public void SetRotation(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000755")]
			[Cpp2IlInjected.Address(RVA = "0x1A4AE30", Offset = "0x1A49430", VA = "0x181A4AE30")]
			public Absorber()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		private float timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		private float w;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		private Mode initialMode;

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x17CF130", Offset = "0x17CD730", VA = "0x1817CF130", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x17CEE10", Offset = "0x17CD410", VA = "0x1817CEE10")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x17CEFE0", Offset = "0x17CD5E0", VA = "0x1817CEFE0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x17CED70", Offset = "0x17CD370", VA = "0x1817CED70")]
		private void AfterIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x17CEEB0", Offset = "0x17CD4B0", VA = "0x1817CEEB0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x17CF220", Offset = "0x17CD820", VA = "0x1817CF220")]
		public MotionAbsorb()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public MotionAbsorb motionAbsorb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public Transform cube;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public float cubeRandomPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public AnimationCurve motionAbsorbWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		private Vector3 cubeDefaultPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private AnimatorStateInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		private Rigidbody cubeRigidbody;

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x17CEAA0", Offset = "0x17CD0A0", VA = "0x1817CEAA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x17CECA0", Offset = "0x17CD2A0", VA = "0x1817CECA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x17CEB20", Offset = "0x17CD120", VA = "0x1817CEB20")]
		private void SwingStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x17CED60", Offset = "0x17CD360", VA = "0x1817CED60")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200010D")]
		public class EffectorLink
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000777")]
			public FullBodyBipedEffector effectorType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000778")]
			public float weightMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000779")]
			[HideInInspector]
			public Vector3 localPosition;

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0xF69C00", Offset = "0xF68200", VA = "0x180F69C00")]
			public EffectorLink()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public EffectorLink[] effectorLinks;

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x17D01F0", Offset = "0x17CE7F0", VA = "0x1817D01F0", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x17CFFA0", Offset = "0x17CE5A0", VA = "0x1817CFFA0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x17D0340", Offset = "0x17CE940", VA = "0x1817D0340")]
		public OffsetEffector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	public class PendulumExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of this script.")]
		public float weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		[HideInInspector]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		public Vector3 rootTargetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		[HideInInspector]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		public Quaternion rootTargetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public Transform leftHandTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public Transform rightHandTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public Transform leftFootTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public Transform rightFootTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public Transform pelvisTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public Transform bodyTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public Transform headTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public Vector3 pelvisDownAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private Quaternion rootRelativeToPelvis;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private Vector3 pelvisToRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		private float lastWeight;

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x17D15B0", Offset = "0x17CFBB0", VA = "0x1817D15B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x17D0C60", Offset = "0x17CF260", VA = "0x1817D0C60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x17D1960", Offset = "0x17CFF60", VA = "0x1817D1960")]
		public PendulumExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public int GUIspace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public InteractionSystem interactionSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public InteractionObject obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public Transform pivot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public Transform holdPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public float pickUpTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		private float holdWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private float holdWeightVel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		private Vector3 pickUpPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		private Quaternion pickUpRotation;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		private bool holding
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(RVA = "0x17D27D0", Offset = "0x17D0DD0", VA = "0x1817D27D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private bool holdingLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(RVA = "0x17D2670", Offset = "0x17D0C70", VA = "0x1817D2670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private bool holdingRight
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x17D2720", Offset = "0x17D0D20", VA = "0x1817D2720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x17D1F90", Offset = "0x17D0590", VA = "0x1817D1F90")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void RotatePivot();

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x17D2470", Offset = "0x17D0A70", VA = "0x1817D2470")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x17D21F0", Offset = "0x17D07F0", VA = "0x1817D21F0")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x17D2390", Offset = "0x17D0990", VA = "0x1817D2390")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x17D1E40", Offset = "0x17D0440", VA = "0x1817D1E40")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x17D1A30", Offset = "0x17D0030", VA = "0x1817D1A30")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x17D1C10", Offset = "0x17D0210", VA = "0x1817D1C10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x17D2660", Offset = "0x17D0C60", VA = "0x1817D2660")]
		protected PickUp2Handed()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	public class PickUpBox : PickUp2Handed
	{
		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x17D2800", Offset = "0x17D0E00", VA = "0x1817D2800", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x17D2660", Offset = "0x17D0C60", VA = "0x1817D2660")]
		public PickUpBox()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	public class PickUpSphere : PickUp2Handed
	{
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x17D2A50", Offset = "0x17D1050", VA = "0x1817D2A50", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x17D2660", Offset = "0x17D0C60", VA = "0x1817D2660")]
		public PickUpSphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public RagdollUtility ragdollUtility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public Transform root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public Rigidbody pelvis;

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x17D4640", Offset = "0x17D2C40", VA = "0x1817D4640")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x17D4690", Offset = "0x17D2C90", VA = "0x1817D4690")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	public class RecoilTest : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public float magnitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		private Recoil recoil;

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x17D6170", Offset = "0x17D4770", VA = "0x1817D6170")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x17D61C0", Offset = "0x17D47C0", VA = "0x1817D61C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x17D6120", Offset = "0x17D4720", VA = "0x1817D6120")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x17D0340", Offset = "0x17CE940", VA = "0x1817D0340")]
		public RecoilTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			public float resetTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			public ResetInteractionObject <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000D3")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600077F")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D4")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000781")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x1CD1570", Offset = "0x1CCFB70", VA = "0x181CD1570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x1CD1760", Offset = "0x1CCFD60", VA = "0x181CD1760", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public float resetDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		private Vector3 defaultPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private Quaternion defaultRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private Transform defaultParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		private Rigidbody r;

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x17D7A20", Offset = "0x17D6020", VA = "0x1817D7A20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x17D78F0", Offset = "0x17D5EF0", VA = "0x1817D78F0")]
		private void OnPickUp(Transform t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x17D79A0", Offset = "0x17D5FA0", VA = "0x1817D79A0")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x17D0340", Offset = "0x17CE940", VA = "0x1817D0340")]
		public ResetInteractionObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	public class SoccerDemo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000117")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007A6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007A7")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007A8")]
			public SoccerDemo <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000D5")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000788")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D6")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600078A")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x1CD13C0", Offset = "0x1CCF9C0", VA = "0x181CD13C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x1CD1530", Offset = "0x1CCFB30", VA = "0x181CD1530", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		private Vector3 defaultPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		private Quaternion defaultRotation;

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x160CCC0", Offset = "0x160B2C0", VA = "0x18160CCC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x160CC50", Offset = "0x160B250", VA = "0x18160CC50")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public SoccerDemo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		public class EffectorLink
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007AB")]
			public bool enabled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			public FullBodyBipedEffector effectorType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			public InteractionObject interactionObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			public Transform spherecastFrom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public float spherecastRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public float minDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public float distanceMlp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public LayerMask touchLayers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public float lerpSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			public float minSwitchTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			public float releaseDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			public bool sliding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			private Vector3 raycastDirectionLocal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			private float raycastDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007B9")]
			private bool inTouch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40007BA")]
			private RaycastHit hit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007BB")]
			private Vector3 targetPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x40007BC")]
			private Quaternion targetRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
			[Cpp2IlInjected.Token(Token = "0x40007BD")]
			private bool initiated;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40007BE")]
			private float nextSwitchTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
			[Cpp2IlInjected.Token(Token = "0x40007BF")]
			private float speedF;

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x1CCDE40", Offset = "0x1CCC440", VA = "0x181CCDE40")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x1CCDD10", Offset = "0x1CCC310", VA = "0x181CCDD10")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x1CCE530", Offset = "0x1CCCB30", VA = "0x181CCE530")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x1CCE3C0", Offset = "0x1CCC9C0", VA = "0x181CCE3C0")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x1CCE2C0", Offset = "0x1CCC8C0", VA = "0x181CCE2C0")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x1CCE240", Offset = "0x1CCC840", VA = "0x181CCE240")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x1CCE340", Offset = "0x1CCC940", VA = "0x181CCE340")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x1CCDB20", Offset = "0x1CCC120", VA = "0x181CCDB20")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x1CCED70", Offset = "0x1CCD370", VA = "0x181CCED70")]
			public EffectorLink()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public InteractionSystem interactionSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public EffectorLink[] effectorLinks;

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x160DAA0", Offset = "0x160C0A0", VA = "0x18160DAA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x160D950", Offset = "0x160BF50", VA = "0x18160D950")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x160D9D0", Offset = "0x160BFD0", VA = "0x18160D9D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public TouchWalls()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	public class TransferMotion : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x160DB10", Offset = "0x160C110", VA = "0x18160DB10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x160DB50", Offset = "0x160C150", VA = "0x18160DB50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x160DCB0", Offset = "0x160C2B0", VA = "0x18160DCB0")]
		public TransferMotion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		private FullBodyBipedIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		private Vector3 targetPosRelativeToRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		private Quaternion targetRotRelativeToRight;

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x160F790", Offset = "0x160DD90", VA = "0x18160F790")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x160F360", Offset = "0x160D960", VA = "0x18160F360")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x160F260", Offset = "0x160D860", VA = "0x18160F260")]
		private void AfterFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x160F670", Offset = "0x160DC70", VA = "0x18160F670")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public TwoHandedProp()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public CharacterThirdPerson character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public InteractionSystem interactionSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		public bool disableInputInInteraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		public float enableInputAtProgress;

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x1610140", Offset = "0x160E740", VA = "0x181610140", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x160FFE0", Offset = "0x160E5E0", VA = "0x18160FFE0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x1610230", Offset = "0x160E830", VA = "0x181610230")]
		public UserControlInteractions()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public class GrounderDemo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		public GameObject[] characters;

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x1973050", Offset = "0x1971650", VA = "0x181973050")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x1972FC0", Offset = "0x19715C0", VA = "0x181972FC0")]
		public void Activate(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public GrounderDemo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public class PlatformRotator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public PlatformRotator <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000D7")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007AF")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D8")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007B1")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x1A62490", Offset = "0x1A60A90", VA = "0x181A62490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x1A62600", Offset = "0x1A60C00", VA = "0x181A62600", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public float maxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public float switchRotationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		public float random;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		public float rotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public Vector3 movePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public int characterLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		private Quaternion defaultRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private Quaternion targetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private Vector3 targetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private Vector3 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private Rigidbody r;

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x17D3090", Offset = "0x17D1690", VA = "0x1817D3090")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x17D2C50", Offset = "0x17D1250", VA = "0x1817D2C50")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x17D3200", Offset = "0x17D1800", VA = "0x1817D3200")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x17D2EE0", Offset = "0x17D14E0", VA = "0x1817D2EE0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x17D2FC0", Offset = "0x17D15C0", VA = "0x1817D2FC0")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x17D3270", Offset = "0x17D1870", VA = "0x1817D3270")]
		public PlatformRotator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public class BendGoal : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		public LimbIK limbIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		[Range(0f, 1f)]
		public float weight;

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x18FED00", Offset = "0x18FD300", VA = "0x1818FED00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x18FEC30", Offset = "0x18FD230", VA = "0x1818FEC30")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x18FED60", Offset = "0x18FD360", VA = "0x1818FED60")]
		public BendGoal()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		public class Part
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007DF")]
			public Transform transform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007E0")]
			private RotationLimit rotationLimit;

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x1CCEDF0", Offset = "0x1CCD3F0", VA = "0x181CCEDF0")]
			public void AimAt(Transform target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public Part()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		public Part[] parts;

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x160E040", Offset = "0x160C640", VA = "0x18160E040")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public Turret()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		public HitReactionVRIK hitReaction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		public float hitForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		private string colliderName;

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x19C0A50", Offset = "0x19BF050", VA = "0x1819C0A50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x19C0980", Offset = "0x19BEF80", VA = "0x1819C0980")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x18FED60", Offset = "0x18FD360", VA = "0x1818FED60")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		[Tooltip("The VRIK component.")]
		public VRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		[Tooltip("HMD.")]
		[Header("Head")]
		public Transform centerEyeAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		[Tooltip("Position offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		[Tooltip("Rotation offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		[Tooltip("Left Hand Controller")]
		[Header("Hands")]
		public Transform leftHandAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		[Tooltip("Right Hand Controller")]
		public Transform rightHandAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		[Tooltip("Position offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		[Tooltip("Rotation offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		[Header("Scale")]
		[Tooltip("Multiplies the scale of the root.")]
		public float scaleMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x1611FB0", Offset = "0x16105B0", VA = "0x181611FB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x1612230", Offset = "0x1610830", VA = "0x181612230")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x16122A0", Offset = "0x16108A0", VA = "0x1816122A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x16124C0", Offset = "0x1610AC0", VA = "0x1816124C0")]
		public VRIKCalibrationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		public VRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		private Quaternion lastRotation;

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x1618380", Offset = "0x1616980", VA = "0x181618380")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x1618190", Offset = "0x1616790", VA = "0x181618190")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x16183F0", Offset = "0x16169F0", VA = "0x1816183F0")]
		public VRIKPlatform()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		public VRIK ik;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		public Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		public Transform platform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		public bool moveToPlatform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private Transform lastPlatform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		private Quaternion lastRotation;

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x1617B40", Offset = "0x1616140", VA = "0x181617B40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x1618160", Offset = "0x1616760", VA = "0x181618160")]
		public VRIKPlatformController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		public bool smoothFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		public float smoothFollowSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		protected bool animatePhysics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		private Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		private Quaternion lastRotation;

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public virtual bool animationGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x190CA40", Offset = "0x190B040", VA = "0x18190CA40", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x190C9D0", Offset = "0x190AFD0", VA = "0x18190C9D0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x190CD50", Offset = "0x190B350", VA = "0x18190CD50", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x190CA90", Offset = "0x190B090", VA = "0x18190CA90", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x190C9C0", Offset = "0x190AFC0", VA = "0x18190C9C0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x190CAA0", Offset = "0x190B0A0", VA = "0x18190CAA0")]
		private void SmoothFollow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x190CF00", Offset = "0x190B500", VA = "0x18190CF00")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		public CharacterThirdPerson characterController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000809")]
		public float pivotOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		public AnimationCurve moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400080B")]
		private Animator animator;

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x190D060", Offset = "0x190B660", VA = "0x18190D060", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x190CF20", Offset = "0x190B520", VA = "0x18190CF20", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x190D0C0", Offset = "0x190B6C0", VA = "0x18190D0C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x190CF00", Offset = "0x190B500", VA = "0x18190CF00")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400080C")]
		public CharacterThirdPerson characterController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400080D")]
		[SerializeField]
		private float turnSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400080E")]
		[SerializeField]
		private float turnSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400080F")]
		[SerializeField]
		private float runCycleLegOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000810")]
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		protected Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private Vector3 lastForward;

		[Cpp2IlInjected.Token(Token = "0x4000813")]
		private const string groundedDirectional = "Grounded Directional";

		[Cpp2IlInjected.Token(Token = "0x4000814")]
		private const string groundedStrafe = "Grounded Strafe";

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		private float deltaAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private float jumpLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		private bool lastJump;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public override bool animationGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x190DEB0", Offset = "0x190C4B0", VA = "0x18190DEB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x190D8F0", Offset = "0x190BEF0", VA = "0x18190D8F0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x190D770", Offset = "0x190BD70", VA = "0x18190D770", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x190D980", Offset = "0x190BF80", VA = "0x18190D980", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x190D7B0", Offset = "0x190BDB0", VA = "0x18190D7B0")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x190D740", Offset = "0x190BD40", VA = "0x18190D740")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		[Header("Base Parameters")]
		public Transform gravityTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		public float airborneThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		public float slopeStartAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		public float slopeEndAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		public float spherecastRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		public LayerMask groundLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		private PhysicMaterial zeroFrictionMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private PhysicMaterial highFrictionMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		protected Rigidbody r;

		[Cpp2IlInjected.Token(Token = "0x4000822")]
		protected const float half = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		protected float originalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		protected Vector3 originalCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		protected CapsuleCollider capsule;

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x190DF90", Offset = "0x190C590", VA = "0x18190DF90")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x190E8E0", Offset = "0x190CEE0", VA = "0x18190E8E0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x190E1E0", Offset = "0x190C7E0", VA = "0x18190E1E0", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x190C9D0", Offset = "0x190AFD0", VA = "0x18190C9D0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x190E4F0", Offset = "0x190CAF0", VA = "0x18190E4F0")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x190E720", Offset = "0x190CD20", VA = "0x18190E720")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x190E4C0", Offset = "0x190CAC0", VA = "0x18190E4C0")]
		protected void HighFriction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x190EAF0", Offset = "0x190D0F0", VA = "0x18190EAF0")]
		protected void ZeroFriction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x190E150", Offset = "0x190C750", VA = "0x18190E150")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x190EB20", Offset = "0x190D120", VA = "0x18190EB20")]
		protected CharacterBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		public enum MoveMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000860")]
			Directional,
			[Cpp2IlInjected.Token(Token = "0x4000861")]
			Strafe
		}

		[Cpp2IlInjected.Token(Token = "0x200012E")]
		public struct AnimState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000862")]
			public Vector3 moveDirection;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000863")]
			public bool jump;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
			[Cpp2IlInjected.Token(Token = "0x4000864")]
			public bool crouch;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
			[Cpp2IlInjected.Token(Token = "0x4000865")]
			public bool onGround;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
			[Cpp2IlInjected.Token(Token = "0x4000866")]
			public bool isStrafing;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000867")]
			public float yVelocity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000868")]
			public bool doubleJump;
		}

		[Cpp2IlInjected.Token(Token = "0x200012F")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000869")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400086A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400086B")]
			public CharacterThirdPerson <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400086C")]
			public Vector3 jumpVelocity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400086D")]
			private int <steps>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400086E")]
			private int <stepsToTake>5__3;

			[Cpp2IlInjected.Token(Token = "0x170000DC")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007F7")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000DD")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007F9")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x160F9C0", Offset = "0x160DFC0", VA = "0x18160F9C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x160FB00", Offset = "0x160E100", VA = "0x18160FB00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		public UserControlThirdPerson userControl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		public CameraController cam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		public bool smoothPhysics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		public float smoothAccelerationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		public float linearAccelerationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400082D")]
		public float platformFriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400082E")]
		public float groundStickyEffect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400082F")]
		public float maxVerticalVelocityOnGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000830")]
		public float velocityToGroundTangentWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000831")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000832")]
		public float turnSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000833")]
		public float stationaryTurnSpeedMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000834")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000835")]
		public float airSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000836")]
		public float airControl;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000837")]
		public float jumpPower;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		public float jumpRepeatDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000839")]
		public bool doubleJumpEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400083A")]
		public float doubleJumpPowerMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400083B")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400083C")]
		public float wallRunMaxLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400083D")]
		public float wallRunMinMoveMag;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400083E")]
		public float wallRunMinVelocityY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		public float wallRunRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000840")]
		public float wallRunMaxRotationAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000841")]
		public float wallRunWeightSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000842")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000844")]
		public AnimState animState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000845")]
		protected Vector3 moveDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000846")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000847")]
		private Vector3 normal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000848")]
		private Vector3 platformVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000849")]
		private Vector3 platformAngularVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x400084A")]
		private RaycastHit hit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400084B")]
		private float jumpLeg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400084C")]
		private float jumpEndTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400084D")]
		private float forwardMlp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x400084E")]
		private float groundDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400084F")]
		private float lastAirTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x4000850")]
		private float stickyForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000851")]
		private Vector3 wallNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x4000852")]
		private Vector3 moveDirectionVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000853")]
		private float wallRunWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x4000854")]
		private float lastWallRunWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000855")]
		private float fixedDeltaTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4000856")]
		private Vector3 fixedDeltaPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000857")]
		private Quaternion fixedDeltaRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000858")]
		private bool fixedFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x4000859")]
		private float wallRunEndTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400085A")]
		private Vector3 gravity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x400085B")]
		private Vector3 verticalVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400085C")]
		private float velocityY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x400085D")]
		private bool doubleJumped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E5")]
		[Cpp2IlInjected.Token(Token = "0x400085E")]
		private bool jumpReleased;

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public bool onGround
		{
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x770F60", Offset = "0x76F560", VA = "0x180770F60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x154F030", Offset = "0x154D630", VA = "0x18154F030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x19115A0", Offset = "0x190FBA0", VA = "0x1819115A0", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x1911070", Offset = "0x190F670", VA = "0x181911070")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x1910F40", Offset = "0x190F540", VA = "0x181910F40", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x190F090", Offset = "0x190D690", VA = "0x18190F090")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x1911740", Offset = "0x190FD40", VA = "0x181911740", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x19107F0", Offset = "0x190EDF0", VA = "0x1819107F0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x19108D0", Offset = "0x190EED0", VA = "0x1819108D0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x1911800", Offset = "0x190FE00", VA = "0x181911800")]
		private void WallRun()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x190EFF0", Offset = "0x190D5F0", VA = "0x18190EFF0")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x190FCA0", Offset = "0x190E2A0", VA = "0x18190FCA0")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x1911110", Offset = "0x190F710", VA = "0x181911110", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x190FA90", Offset = "0x190E090", VA = "0x18190FA90")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x1910520", Offset = "0x190EB20", VA = "0x181910520", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x1910490", Offset = "0x190EA90", VA = "0x181910490")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__75))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x190FFA0", Offset = "0x190E5A0", VA = "0x18190FFA0")]
		private void GroundCheck()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x19120A0", Offset = "0x19106A0", VA = "0x1819120A0")]
		public CharacterThirdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		public enum RotationMode
		{
			[Cpp2IlInjected.Token(Token = "0x400087D")]
			Smooth,
			[Cpp2IlInjected.Token(Token = "0x400087E")]
			Linear
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400086F")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000870")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000871")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000872")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000873")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000874")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000876")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000877")]
		private float speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000878")]
		private float angleVel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000879")]
		private float speedVel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400087A")]
		private Vector3 linearTargetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400087B")]
		private CharacterController characterController;

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public bool isGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x983D50", Offset = "0x982350", VA = "0x180983D50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0xCDBAF0", Offset = "0xCDA0F0", VA = "0x180CDBAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x160C9C0", Offset = "0x160AFC0", VA = "0x18160C9C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x160CA50", Offset = "0x160B050", VA = "0x18160CA50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x160C2F0", Offset = "0x160A8F0", VA = "0x18160C2F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x160C610", Offset = "0x160AC10", VA = "0x18160C610")]
		private void Rotate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x160C330", Offset = "0x160A930", VA = "0x18160C330")]
		private void Move()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x160C230", Offset = "0x160A830", VA = "0x18160C230")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x160C1B0", Offset = "0x160A7B0", VA = "0x18160C1B0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x160CAB0", Offset = "0x160B0B0", VA = "0x18160CAB0")]
		public SimpleLocomotion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400087F")]
		public Transform moveTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000880")]
		public float stoppingDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000881")]
		public float stoppingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000882")]
		public Navigator navigator;

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x160FC90", Offset = "0x160E290", VA = "0x18160FC90", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x160FD00", Offset = "0x160E300", VA = "0x18160FD00", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x160FC60", Offset = "0x160E260", VA = "0x18160FC60")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x160FFC0", Offset = "0x160E5C0", VA = "0x18160FFC0")]
		public UserControlAI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		public struct State
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000888")]
			public Vector3 move;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000889")]
			public Vector3 lookPos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400088A")]
			public bool crouch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x400088B")]
			public bool jump;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400088C")]
			public int actionIndex;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000883")]
		public bool walkByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000884")]
		public bool canCrouch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4000885")]
		public bool canJump;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000886")]
		public State state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000887")]
		protected Transform cam;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x1610250", Offset = "0x160E850", VA = "0x181610250", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x1610290", Offset = "0x160E890", VA = "0x181610290", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x16105C0", Offset = "0x160EBC0", VA = "0x1816105C0")]
		public UserControlThirdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x18F9B90", Offset = "0x18F8190", VA = "0x1818F9B90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public ApplicationQuit()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	public class SlowMo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400088D")]
		public KeyCode[] keyCodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400088E")]
		public bool mouse0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400088F")]
		public bool mouse1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000890")]
		public float slowMoTimeScale;

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x160CB80", Offset = "0x160B180", VA = "0x18160CB80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x160CAD0", Offset = "0x160B0D0", VA = "0x18160CAD0")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x160CC40", Offset = "0x160B240", VA = "0x18160CC40")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	public class Navigator
	{
		[Cpp2IlInjected.Token(Token = "0x2000138")]
		public enum State
		{
			[Cpp2IlInjected.Token(Token = "0x40008A0")]
			Idle,
			[Cpp2IlInjected.Token(Token = "0x40008A1")]
			Seeking,
			[Cpp2IlInjected.Token(Token = "0x40008A2")]
			OnPath
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000891")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000892")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000893")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000894")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000895")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000898")]
		private Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000899")]
		private int cornerIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400089A")]
		private Vector3[] corners;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400089B")]
		private NavMeshPath path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400089C")]
		private Vector3 lastTargetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400089D")]
		private bool initiated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400089E")]
		private float nextPathTime;

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public Vector3 normalizedDeltaPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000810")]
			[Cpp2IlInjected.Address(RVA = "0x17CFF70", Offset = "0x17CE570", VA = "0x1817CFF70")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000811")]
			[Cpp2IlInjected.Address(RVA = "0x17CFF90", Offset = "0x17CE590", VA = "0x1817CFF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public State state
		{
			[Cpp2IlInjected.Token(Token = "0x6000812")]
			[Cpp2IlInjected.Address(RVA = "0x852590", Offset = "0x850B90", VA = "0x180852590")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x98DA50", Offset = "0x98C050", VA = "0x18098DA50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x17CF6B0", Offset = "0x17CDCB0", VA = "0x1817CF6B0")]
		public void Initiate(Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x17CF7C0", Offset = "0x17CDDC0", VA = "0x1817CF7C0")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x17CF240", Offset = "0x17CD840", VA = "0x1817CF240")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x17CF470", Offset = "0x17CDA70", VA = "0x1817CF470")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x17CF780", Offset = "0x17CDD80", VA = "0x1817CF780")]
		private void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x17CF660", Offset = "0x17CDC60", VA = "0x1817CF660")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x17CFC60", Offset = "0x17CE260", VA = "0x1817CFC60")]
		public void Visualize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x17CFF00", Offset = "0x17CE500", VA = "0x1817CFF00")]
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
