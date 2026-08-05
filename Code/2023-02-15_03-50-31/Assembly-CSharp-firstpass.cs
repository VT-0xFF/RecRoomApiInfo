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
	[Cpp2IlInjected.Address(RVA = "0x136F880", Offset = "0x136EC80", VA = "0x18136F880")]
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
		[Cpp2IlInjected.Address(RVA = "0x136F6A0", Offset = "0x136EAA0", VA = "0x18136F6A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7D3DD0", Offset = "0x7D31D0", VA = "0x1807D3DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x136F800", Offset = "0x136EC00", VA = "0x18136F800")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x136F770", Offset = "0x136EB70", VA = "0x18136F770")]
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
			[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x838E50", Offset = "0x838250", VA = "0x180838E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x838E50", Offset = "0x838250", VA = "0x180838E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1370170", Offset = "0x136F570", VA = "0x181370170")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x136FFA0", Offset = "0x136F3A0", VA = "0x18136FFA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A55E0", Offset = "0x8A49E0", VA = "0x1808A55E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8D17E0", Offset = "0x8D0BE0", VA = "0x1808D17E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x752ED0", Offset = "0x7522D0", VA = "0x180752ED0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1370210", Offset = "0x136F610", VA = "0x181370210")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A55E0", Offset = "0x8A49E0", VA = "0x1808A55E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8D17E0", Offset = "0x8D0BE0", VA = "0x1808D17E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x752ED0", Offset = "0x7522D0", VA = "0x180752ED0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1370210", Offset = "0x136F610", VA = "0x181370210")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1061420", Offset = "0x1060820", VA = "0x181061420")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6E08E0", Offset = "0x6DFCE0", VA = "0x1806E08E0")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x136FF60", Offset = "0x136F360", VA = "0x18136FF60")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F04F0", Offset = "0x9EF8F0", VA = "0x1809F04F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD7AB80", Offset = "0xD79F80", VA = "0x180D7AB80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float bakingProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x15ACF30", Offset = "0x15AC330", VA = "0x1815ACF30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x14CEAD0", Offset = "0x14CDED0", VA = "0x1814CEAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected float clipLength
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x12D5FE0", Offset = "0x12D53E0", VA = "0x1812D5FE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x14CEB10", Offset = "0x14CDF10", VA = "0x1814CEB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x15ACDC0", Offset = "0x15AC1C0", VA = "0x1815ACDC0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x15ACD80", Offset = "0x15AC180", VA = "0x1815ACD80")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x15ACE00", Offset = "0x15AC200", VA = "0x1815ACE00")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x15ACD40", Offset = "0x15AC140", VA = "0x1815ACD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public void BakeClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public void StartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public void StopBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x15ACE40", Offset = "0x15AC240", VA = "0x1815ACE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x161F190", Offset = "0x161E590", VA = "0x18161F190")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7A4AB0", Offset = "0x7A3EB0", VA = "0x1807A4AB0", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x161F860", Offset = "0x161EC60", VA = "0x18161F860", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x161F7C0", Offset = "0x161EBC0", VA = "0x18161F7C0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x161F680", Offset = "0x161EA80", VA = "0x18161F680", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x161F720", Offset = "0x161EB20", VA = "0x18161F720", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x161F5A0", Offset = "0x161E9A0", VA = "0x18161F5A0")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x161F4C0", Offset = "0x161E8C0", VA = "0x18161F4C0")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x161F9C0", Offset = "0x161EDC0", VA = "0x18161F9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1372710", Offset = "0x1371B10", VA = "0x181372710")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AvatarUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x15A8810", Offset = "0x15A7C10", VA = "0x1815A8810")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x15A8040", Offset = "0x15A7440", VA = "0x1815A8040")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x15A8AB0", Offset = "0x15A7EB0", VA = "0x1815A8AB0")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public AvatarUtility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class BakerUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x15ACA50", Offset = "0x15ABE50", VA = "0x1815ACA50")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x15AC500", Offset = "0x15AB900", VA = "0x1815AC500")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x15ACA90", Offset = "0x15ABE90", VA = "0x1815ACA90")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x15AC250", Offset = "0x15AB650", VA = "0x1815AC250")]
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
		[Cpp2IlInjected.Address(RVA = "0x15AA2A0", Offset = "0x15A96A0", VA = "0x1815AA2A0")]
		public BakerHumanoidQT(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x15AA420", Offset = "0x15A9820", VA = "0x1815AA420")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x15A96D0", Offset = "0x15A8AD0", VA = "0x1815A96D0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x15A9CF0", Offset = "0x15A90F0", VA = "0x1815A9CF0")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x15AA0E0", Offset = "0x15A94E0", VA = "0x1815AA0E0")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x15A9310", Offset = "0x15A8710", VA = "0x1815A9310")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x15AA210", Offset = "0x15A9610", VA = "0x1815AA210")]
		public void SetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x15A9280", Offset = "0x15A8680", VA = "0x1815A9280")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x15A9610", Offset = "0x15A8A10", VA = "0x1815A9610")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x15A9840", Offset = "0x15A8C40", VA = "0x1815A9840")]
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
		[Cpp2IlInjected.Address(RVA = "0x15AB240", Offset = "0x15AA640", VA = "0x1815AB240")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x15AA5D0", Offset = "0x15A99D0", VA = "0x1815AA5D0")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x15A9610", Offset = "0x15A8A10", VA = "0x1815A9610")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x15AB020", Offset = "0x15AA420", VA = "0x1815AB020")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x15AAFC0", Offset = "0x15AA3C0", VA = "0x1815AAFC0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x15AB1E0", Offset = "0x15AA5E0", VA = "0x1815AB1E0")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x15AB230", Offset = "0x15AA630", VA = "0x1815AB230")]
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
		[Cpp2IlInjected.Address(RVA = "0x15AC090", Offset = "0x15AB490", VA = "0x1815AC090")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x15AC070", Offset = "0x15AB470", VA = "0x1815AC070")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x15ABB40", Offset = "0x15AAF40", VA = "0x1815ABB40")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x15AB590", Offset = "0x15AA990", VA = "0x1815AB590")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x15AB9F0", Offset = "0x15AADF0", VA = "0x1815AB9F0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x15AB870", Offset = "0x15AAC70", VA = "0x1815AB870")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x15ABE30", Offset = "0x15AB230", VA = "0x1815ABE30")]
		public void SetKeyframes(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x15AB300", Offset = "0x15AA700", VA = "0x1815AB300")]
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
		[Cpp2IlInjected.Address(RVA = "0x165E530", Offset = "0x165D930", VA = "0x18165E530")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x165EAB0", Offset = "0x165DEB0", VA = "0x18165EAB0", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x165F3B0", Offset = "0x165E7B0", VA = "0x18165F3B0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x165F290", Offset = "0x165E690", VA = "0x18165F290", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x165EAD0", Offset = "0x165DED0", VA = "0x18165EAD0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x165ED50", Offset = "0x165E150", VA = "0x18165ED50", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x165F4C0", Offset = "0x165E8C0", VA = "0x18165F4C0")]
		private void UpdateHumanPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x165F5F0", Offset = "0x165E9F0", VA = "0x18165F5F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF69130", Offset = "0xF68530", VA = "0x180F69130")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xF69160", Offset = "0xF68560", VA = "0x180F69160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float y
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x15BAC60", Offset = "0x15BA060", VA = "0x1815BAC60")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x14CEB20", Offset = "0x14CDF20", VA = "0x1814CEB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float distanceTarget
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xF5B9A0", Offset = "0xF5ADA0", VA = "0x180F5B9A0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xF5BA80", Offset = "0xF5AE80", VA = "0x180F5BA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float zoomAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x15BAC70", Offset = "0x15BA070", VA = "0x1815BAC70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x15BA1A0", Offset = "0x15B95A0", VA = "0x1815BA1A0")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x15BA190", Offset = "0x15B9590", VA = "0x1815BA190")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F70", Offset = "0x15B9370", VA = "0x1815B9F70", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x15BAB50", Offset = "0x15B9F50", VA = "0x1815BAB50", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x15BA0C0", Offset = "0x15B94C0", VA = "0x1815BA0C0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x15BA120", Offset = "0x15B9520", VA = "0x1815BA120", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x15BA1E0", Offset = "0x15B95E0", VA = "0x1815BA1E0")]
		public void UpdateInput()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x15BA3A0", Offset = "0x15B97A0", VA = "0x1815BA3A0")]
		public void UpdateTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x15BA3D0", Offset = "0x15B97D0", VA = "0x1815BA3D0")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x15B9D70", Offset = "0x15B9170", VA = "0x1815B9D70")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x15BAB80", Offset = "0x15B9F80", VA = "0x1815BAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x15B9D20", Offset = "0x15B9120", VA = "0x1815B9D20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x15B9DB0", Offset = "0x15B91B0", VA = "0x1815B9DB0")]
		public void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x15B9D70", Offset = "0x15B9170", VA = "0x1815B9D70")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F50", Offset = "0x15B9350", VA = "0x1815B9F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x15A9230", Offset = "0x15A8630", VA = "0x1815A9230")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x15A91D0", Offset = "0x15A85D0", VA = "0x1815A91D0")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x15A8BF0", Offset = "0x15A7FF0", VA = "0x1815A8BF0")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x15A8AE0", Offset = "0x15A7EE0", VA = "0x1815A8AE0")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x15A90C0", Offset = "0x15A84C0", VA = "0x1815A90C0")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x15A9050", Offset = "0x15A8450", VA = "0x1815A9050")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x15A8D70", Offset = "0x15A8170", VA = "0x1815A8D70")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x136DA40", Offset = "0x136CE40", VA = "0x18136DA40")]
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
			[Cpp2IlInjected.Address(RVA = "0x15AF390", Offset = "0x15AE790", VA = "0x1815AF390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static BipedLimbOrientations MaxBiped
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x15AF080", Offset = "0x15AE480", VA = "0x1815AF080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x14950C0", Offset = "0x14944C0", VA = "0x1814950C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15AFB80", Offset = "0x15AEF80", VA = "0x1815AFB80")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x15AF950", Offset = "0x15AED50", VA = "0x1815AF950")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x15AFB00", Offset = "0x15AEF00", VA = "0x1815AFB00")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x15AFD30", Offset = "0x15AF130", VA = "0x1815AFD30")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x15AFDE0", Offset = "0x15AF1E0", VA = "0x1815AFDE0")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x15AF740", Offset = "0x15AEB40", VA = "0x1815AF740")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x15AF6A0", Offset = "0x15AEAA0", VA = "0x1815AF6A0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x15AF8C0", Offset = "0x15AECC0", VA = "0x1815AF8C0")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x15B4060", Offset = "0x15B3460", VA = "0x1815B4060")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x15B44F0", Offset = "0x15B38F0", VA = "0x1815B44F0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x15B4770", Offset = "0x15B3B70", VA = "0x1815B4770")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x15B3E50", Offset = "0x15B3250", VA = "0x1815B3E50")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x15B3A30", Offset = "0x15B2E30", VA = "0x1815B3A30")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x15B42E0", Offset = "0x15B36E0", VA = "0x1815B42E0")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x15B4980", Offset = "0x15B3D80", VA = "0x1815B4980")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x15B3C40", Offset = "0x15B3040", VA = "0x1815B3C40")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x15B4B90", Offset = "0x15B3F90", VA = "0x1815B4B90")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x15B4E50", Offset = "0x15B4250", VA = "0x1815B4E50")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x15B3940", Offset = "0x15B2D40", VA = "0x1815B3940")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x15B4D70", Offset = "0x15B4170", VA = "0x1815B4D70")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x15B0010", Offset = "0x15AF410", VA = "0x1815B0010")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x15B39D0", Offset = "0x15B2DD0", VA = "0x1815B39D0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x15B4D10", Offset = "0x15B4110", VA = "0x1815B4D10")]
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
				[Cpp2IlInjected.Address(RVA = "0x13679B0", Offset = "0x1366DB0", VA = "0x1813679B0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x13679A0", Offset = "0x1366DA0", VA = "0x1813679A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15B8FD0", Offset = "0x15B83D0", VA = "0x1815B8FD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool isEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x87B0F0", Offset = "0x87A4F0", VA = "0x18087B0F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x15B73B0", Offset = "0x15B67B0", VA = "0x1815B73B0", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x15B5B90", Offset = "0x15B4F90", VA = "0x1815B5B90", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x15B58B0", Offset = "0x15B4CB0", VA = "0x1815B58B0")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x15B61B0", Offset = "0x15B55B0", VA = "0x1815B61B0")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x15B5320", Offset = "0x15B4720", VA = "0x1815B5320")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x15B8890", Offset = "0x15B7C90", VA = "0x1815B8890")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x15B89E0", Offset = "0x15B7DE0", VA = "0x1815B89E0")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x15B7830", Offset = "0x15B6C30", VA = "0x1815B7830")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x15B4F80", Offset = "0x15B4380", VA = "0x1815B4F80")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x15B5190", Offset = "0x15B4590", VA = "0x1815B5190")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x15B6020", Offset = "0x15B5420", VA = "0x1815B6020")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x15B5090", Offset = "0x15B4490", VA = "0x1815B5090")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x15B7920", Offset = "0x15B6D20", VA = "0x1815B7920")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x15B81B0", Offset = "0x15B75B0", VA = "0x1815B81B0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x15B8AD0", Offset = "0x15B7ED0", VA = "0x1815B8AD0")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x15B6E20", Offset = "0x15B6220", VA = "0x1815B6E20")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x15B85F0", Offset = "0x15B79F0", VA = "0x1815B85F0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x15B7030", Offset = "0x15B6430", VA = "0x1815B7030")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x15B72D0", Offset = "0x15B66D0", VA = "0x1815B72D0")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x15B8F50", Offset = "0x15B8350", VA = "0x1815B8F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x160E920", Offset = "0x160DD20", VA = "0x18160E920")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x160E9E0", Offset = "0x160DDE0", VA = "0x18160E9E0")]
		public DemoGUIMessage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class Hierarchy
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x165CD60", Offset = "0x165C160", VA = "0x18165CD60")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x165C5E0", Offset = "0x165B9E0", VA = "0x18165C5E0")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x165CE00", Offset = "0x165C200", VA = "0x18165CE00")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x165C4D0", Offset = "0x165B8D0", VA = "0x18165C4D0")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x165C240", Offset = "0x165B640", VA = "0x18165C240")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x165C710", Offset = "0x165BB10", VA = "0x18165C710")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x165C9F0", Offset = "0x165BDF0", VA = "0x18165C9F0")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x165CB90", Offset = "0x165BF90", VA = "0x18165CB90")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x165C820", Offset = "0x165BC20", VA = "0x18165C820")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x165CF70", Offset = "0x165C370", VA = "0x18165CF70")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16AEE00", Offset = "0x16AE200", VA = "0x1816AEE00")]
		public InspectorComment(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x16AEE90", Offset = "0x16AE290", VA = "0x1816AEE90")]
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
		[Cpp2IlInjected.Address(RVA = "0x14B8BA0", Offset = "0x14B7FA0", VA = "0x1814B8BA0")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x14B99F0", Offset = "0x14B8DF0", VA = "0x1814B99F0")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x14B9510", Offset = "0x14B8910", VA = "0x1814B9510")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x14B95A0", Offset = "0x14B89A0", VA = "0x1814B95A0")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x14B9390", Offset = "0x14B8790", VA = "0x1814B9390")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x14B93C0", Offset = "0x14B87C0", VA = "0x1814B93C0")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x14B94A0", Offset = "0x14B88A0", VA = "0x1814B94A0")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x14B9480", Offset = "0x14B8880", VA = "0x1814B9480")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x14B91E0", Offset = "0x14B85E0", VA = "0x1814B91E0")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x14B9470", Offset = "0x14B8870", VA = "0x1814B9470")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x14B9940", Offset = "0x14B8D40", VA = "0x1814B9940")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x14B98E0", Offset = "0x14B8CE0", VA = "0x1814B98E0")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x14B9680", Offset = "0x14B8A80", VA = "0x1814B9680")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x14B9860", Offset = "0x14B8C60", VA = "0x1814B9860")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x14B98A0", Offset = "0x14B8CA0", VA = "0x1814B98A0")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x14B8B30", Offset = "0x14B7F30", VA = "0x1814B8B30")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x14B8B60", Offset = "0x14B7F60", VA = "0x1814B8B60")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x14B95B0", Offset = "0x14B89B0", VA = "0x1814B95B0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x14B95F0", Offset = "0x14B89F0", VA = "0x1814B95F0")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x14B9730", Offset = "0x14B8B30", VA = "0x1814B9730")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x14B96C0", Offset = "0x14B8AC0", VA = "0x1814B96C0")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x14B9260", Offset = "0x14B8660", VA = "0x1814B9260")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x14B9200", Offset = "0x14B8600", VA = "0x1814B9200")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x14B94C0", Offset = "0x14B88C0", VA = "0x1814B94C0")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x14B99B0", Offset = "0x14B8DB0", VA = "0x1814B99B0")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x14B9410", Offset = "0x14B8810", VA = "0x1814B9410")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x14B92C0", Offset = "0x14B86C0", VA = "0x1814B92C0")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x14B97A0", Offset = "0x14B8BA0", VA = "0x1814B97A0")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x14B91B0", Offset = "0x14B85B0", VA = "0x1814B91B0")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x14B9640", Offset = "0x14B8A40", VA = "0x1814B9640")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14B9B80", Offset = "0x14B8F80", VA = "0x1814B9B80")]
		public LargeHeader(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x14B9C10", Offset = "0x14B9010", VA = "0x1814B9C10")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class LayerMaskExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x14B9D70", Offset = "0x14B9170", VA = "0x1814B9D70")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x14B9DB0", Offset = "0x14B91B0", VA = "0x1814B9DB0")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x14B9E50", Offset = "0x14B9250", VA = "0x1814B9E50")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x14B9DB0", Offset = "0x14B91B0", VA = "0x1814B9DB0")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x14B9E50", Offset = "0x14B9250", VA = "0x1814B9E50")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x14B9ED0", Offset = "0x14B92D0", VA = "0x1814B9ED0")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x14B9CA0", Offset = "0x14B90A0", VA = "0x1814B9CA0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x14BA350", Offset = "0x14B9750", VA = "0x1814BA350")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x14B9EF0", Offset = "0x14B92F0", VA = "0x1814B9EF0")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x14BA000", Offset = "0x14B9400", VA = "0x1814BA000")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x14BA210", Offset = "0x14B9610", VA = "0x1814BA210")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x14BA0F0", Offset = "0x14B94F0", VA = "0x1814BA0F0")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class QuaTools
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x14C3B50", Offset = "0x14C2F50", VA = "0x1814C3B50")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x14C39E0", Offset = "0x14C2DE0", VA = "0x1814C39E0")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x14C3570", Offset = "0x14C2970", VA = "0x1814C3570")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A80", Offset = "0x14C2E80", VA = "0x1814C3A80")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x14C3920", Offset = "0x14C2D20", VA = "0x1814C3920")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x14C3720", Offset = "0x14C2B20", VA = "0x1814C3720")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x14C3BD0", Offset = "0x14C2FD0", VA = "0x1814C3BD0")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x14C3E90", Offset = "0x14C3290", VA = "0x1814C3E90")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x14C3C40", Offset = "0x14C3040", VA = "0x1814C3C40")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x14C3F00", Offset = "0x14C3300", VA = "0x1814C3F00")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x14C3130", Offset = "0x14C2530", VA = "0x1814C3130")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x14C3E10", Offset = "0x14C3210", VA = "0x1814C3E10")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x14C3270", Offset = "0x14C2670", VA = "0x1814C3270")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x14C3320", Offset = "0x14C2720", VA = "0x1814C3320")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x14C2F40", Offset = "0x14C2340", VA = "0x1814C2F40")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x14C2E10", Offset = "0x14C2210", VA = "0x1814C2E10")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x14C3CE0", Offset = "0x14C30E0", VA = "0x1814C3CE0")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x14C3FA0", Offset = "0x14C33A0", VA = "0x1814C3FA0")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x14C40A0", Offset = "0x14C34A0", VA = "0x1814C40A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1968E90", Offset = "0x1968290", VA = "0x181968E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x375B830", Offset = "0x375AC30", VA = "0x18375B830", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1E299B0", Offset = "0x1E28DB0", VA = "0x181E299B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1372530", Offset = "0x1371930", VA = "0x181372530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool isAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1372610", Offset = "0x1371A10", VA = "0x181372610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x1372110", Offset = "0x1371510", VA = "0x181372110")]
		public void Disable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1372440", Offset = "0x1371840", VA = "0x181372440")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x13723A0", Offset = "0x13717A0", VA = "0x1813723A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x13723A0", Offset = "0x13717A0", VA = "0x1813723A0")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x13724E0", Offset = "0x13718E0", VA = "0x1813724E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x13721A0", Offset = "0x13715A0", VA = "0x1813721A0")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x13723F0", Offset = "0x13717F0", VA = "0x1813723F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x13724A0", Offset = "0x13718A0", VA = "0x1813724A0")]
		public void UpdateSolverExternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1372520", Offset = "0x1371920", VA = "0x181372520")]
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
		[Cpp2IlInjected.Address(RVA = "0x1373010", Offset = "0x1372410", VA = "0x181373010")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1373170", Offset = "0x1372570", VA = "0x181373170")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x13730C0", Offset = "0x13724C0", VA = "0x1813730C0")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class V2Tools
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xF5B320", Offset = "0xF5A720", VA = "0x180F5B320")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1375990", Offset = "0x1374D90", VA = "0x181375990")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1375920", Offset = "0x1374D20", VA = "0x181375920")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x13759F0", Offset = "0x1374DF0", VA = "0x1813759F0")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1375B10", Offset = "0x1374F10", VA = "0x181375B10")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class V3Tools
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x13767F0", Offset = "0x1375BF0", VA = "0x1813767F0")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1376700", Offset = "0x1375B00", VA = "0x181376700")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x1376630", Offset = "0x1375A30", VA = "0x181376630")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1376820", Offset = "0x1375C20", VA = "0x181376820")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1376740", Offset = "0x1375B40", VA = "0x181376740")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1376490", Offset = "0x1375890", VA = "0x181376490")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1376B50", Offset = "0x1375F50", VA = "0x181376B50")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1377090", Offset = "0x1376490", VA = "0x181377090")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x13763D0", Offset = "0x13757D0", VA = "0x1813763D0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x13762E0", Offset = "0x13756E0", VA = "0x1813762E0")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1375C50", Offset = "0x1375050", VA = "0x181375C50")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1375E50", Offset = "0x1375250", VA = "0x181375E50")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1376050", Offset = "0x1375450", VA = "0x181376050")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1376C90", Offset = "0x1376090", VA = "0x181376C90")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1376E70", Offset = "0x1376270", VA = "0x181376E70")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1377120", Offset = "0x1376520", VA = "0x181377120")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x13768E0", Offset = "0x1375CE0", VA = "0x1813768E0")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1376A00", Offset = "0x1375E00", VA = "0x181376A00")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1377210", Offset = "0x1376610", VA = "0x181377210")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1376290", Offset = "0x1375690", VA = "0x181376290")]
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
		[Cpp2IlInjected.Address(RVA = "0x137E850", Offset = "0x137DC50", VA = "0x18137E850")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x137E7A0", Offset = "0x137DBA0", VA = "0x18137E7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15AE010", Offset = "0x15AD410", VA = "0x1815AE010")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x15ADFD0", Offset = "0x15AD3D0", VA = "0x1815ADFD0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x15AE530", Offset = "0x15AD930", VA = "0x1815AE530")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x15AD8F0", Offset = "0x15ACCF0", VA = "0x1815AD8F0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x15ADA70", Offset = "0x15ACE70", VA = "0x1815ADA70")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x15ADB80", Offset = "0x15ACF80", VA = "0x1815ADB80")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15AE050", Offset = "0x15AD450", VA = "0x1815AE050")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x15AE140", Offset = "0x15AD540", VA = "0x1815AE140")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x15AE0C0", Offset = "0x15AD4C0", VA = "0x1815AE0C0")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x15AE1B0", Offset = "0x15AD5B0", VA = "0x1815AE1B0")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x15ADAE0", Offset = "0x15ACEE0", VA = "0x1815ADAE0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x15ADBF0", Offset = "0x15ACFF0", VA = "0x1815ADBF0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x15AE250", Offset = "0x15AD650", VA = "0x1815AE250")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x15AE220", Offset = "0x15AD620", VA = "0x1815AE220")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x15AE290", Offset = "0x15AD690", VA = "0x1815AE290")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x15AE2C0", Offset = "0x15AD6C0", VA = "0x1815AE2C0")]
		public void SetSpineWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x15ADA00", Offset = "0x15ACE00", VA = "0x1815ADA00")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x969DA0", Offset = "0x9691A0", VA = "0x180969DA0")]
		public void InitiateBipedIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x786A30", Offset = "0x785E30", VA = "0x180786A30")]
		public void UpdateBipedIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x15AE2F0", Offset = "0x15AD6F0", VA = "0x1815AE2F0")]
		public void SetToDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x15AD930", Offset = "0x15ACD30", VA = "0x1815AD930", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x15ADC60", Offset = "0x15AD060", VA = "0x1815ADC60", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x15AE570", Offset = "0x15AD970", VA = "0x1815AE570", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x14CA960", Offset = "0x14C9D60", VA = "0x1814CA960")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x15AE790", Offset = "0x15ADB90", VA = "0x1815AE790")]
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
			[Cpp2IlInjected.Address(RVA = "0x15AD6F0", Offset = "0x15ACAF0", VA = "0x1815AD6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IKSolver[] ikSolvers
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x15AD3E0", Offset = "0x15AC7E0", VA = "0x1815AD3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x15AD080", Offset = "0x15AC480", VA = "0x1815AD080")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x15AD220", Offset = "0x15AC620", VA = "0x1815AD220")]
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
			[Cpp2IlInjected.Address(RVA = "0x160E3F0", Offset = "0x160D7F0", VA = "0x18160E3F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void UpdateConstraint();

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x160DF50", Offset = "0x160D350", VA = "0x18160DF50", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ConstraintPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x160DEF0", Offset = "0x160D2F0", VA = "0x18160DEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x160DC90", Offset = "0x160D090", VA = "0x18160DC90", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ConstraintPositionOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x160E2F0", Offset = "0x160D6F0", VA = "0x18160E2F0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ConstraintRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x160E2A0", Offset = "0x160D6A0", VA = "0x18160E2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x160E0B0", Offset = "0x160D4B0", VA = "0x18160E0B0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ConstraintRotationOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x160E4D0", Offset = "0x160D8D0", VA = "0x18160E4D0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x160E450", Offset = "0x160D850", VA = "0x18160E450")]
		public void Initiate(Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x160E530", Offset = "0x160D930", VA = "0x18160E530")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x705CF0", Offset = "0x7050F0", VA = "0x180705CF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x7061E0", Offset = "0x7055E0", VA = "0x1807061E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 IKPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x161E660", Offset = "0x161DA60", VA = "0x18161E660")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x161E6C0", Offset = "0x161DAC0", VA = "0x18161E6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion IKRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x161E690", Offset = "0x161DA90", VA = "0x18161E690")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x161E6F0", Offset = "0x161DAF0", VA = "0x18161E6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x161DDB0", Offset = "0x161D1B0", VA = "0x18161DDB0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x161D410", Offset = "0x161C810", VA = "0x18161D410")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x161D320", Offset = "0x161C720", VA = "0x18161D320")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x161DED0", Offset = "0x161D2D0", VA = "0x18161DED0")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x161DFB0", Offset = "0x161D3B0", VA = "0x18161DFB0")]
		public void Update(float masterWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x161E640", Offset = "0x161DA40", VA = "0x18161E640")]
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
			[Cpp2IlInjected.Address(RVA = "0x705CF0", Offset = "0x7050F0", VA = "0x180705CF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7061E0", Offset = "0x7055E0", VA = "0x1807061E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x161CEC0", Offset = "0x161C2C0", VA = "0x18161CEC0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x161C8F0", Offset = "0x161BCF0", VA = "0x18161C8F0")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x161C710", Offset = "0x161BB10", VA = "0x18161C710")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x161CF50", Offset = "0x161C350", VA = "0x18161CF50")]
		public void RemoveFinger(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x161C610", Offset = "0x161BA10", VA = "0x18161C610")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x161CDF0", Offset = "0x161C1F0", VA = "0x18161CDF0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x161D240", Offset = "0x161C640", VA = "0x18161D240")]
		public void UpdateFingerSolvers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x161CC80", Offset = "0x161C080", VA = "0x18161CC80")]
		public void FixFingerTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x161D100", Offset = "0x161C500", VA = "0x18161D100")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x161D240", Offset = "0x161C640", VA = "0x18161D240", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x161CC80", Offset = "0x161C080", VA = "0x18161CC80", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x161D2C0", Offset = "0x161C6C0", VA = "0x18161D2C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4370", Offset = "0x6E3770", VA = "0x1806E4370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x6E43F0", Offset = "0x6E37F0", VA = "0x1806E43F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ResetPosition();

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1626EC0", Offset = "0x16262C0", VA = "0x181626EC0")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x14CA960", Offset = "0x14C9D60", VA = "0x1814CA960")]
		protected void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1626990", Offset = "0x1625D90", VA = "0x181626990")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1626CE0", Offset = "0x16260E0", VA = "0x181626CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1627000", Offset = "0x1626400", VA = "0x181627000")]
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
		[Cpp2IlInjected.Address(RVA = "0x1621020", Offset = "0x1620420", VA = "0x181621020", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1620FE0", Offset = "0x16203E0", VA = "0x181620FE0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x1621060", Offset = "0x1620460", VA = "0x181621060", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x16203F0", Offset = "0x161F7F0", VA = "0x1816203F0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x16211C0", Offset = "0x16205C0", VA = "0x1816211C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1620020", Offset = "0x161F420", VA = "0x181620020")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x1620680", Offset = "0x161FA80", VA = "0x181620680")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x16208F0", Offset = "0x161FCF0", VA = "0x1816208F0")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x16210B0", Offset = "0x16204B0", VA = "0x1816210B0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x16206E0", Offset = "0x161FAE0", VA = "0x1816206E0")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x16204A0", Offset = "0x161F8A0", VA = "0x1816204A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x16212B0", Offset = "0x16206B0", VA = "0x1816212B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD83730", Offset = "0xD82B30", VA = "0x180D83730")]
			public SpineEffector()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x13726C0", Offset = "0x1371AC0", VA = "0x1813726C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1622110", Offset = "0x1621510", VA = "0x181622110")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1622150", Offset = "0x1621550", VA = "0x181622150", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x16220D0", Offset = "0x16214D0", VA = "0x1816220D0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1622190", Offset = "0x1621590", VA = "0x181622190", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1621840", Offset = "0x1620C40", VA = "0x181621840")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1622380", Offset = "0x1621780", VA = "0x181622380")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x1621560", Offset = "0x1620960", VA = "0x181621560")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x1621560", Offset = "0x1620960", VA = "0x181621560")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1621570", Offset = "0x1620970", VA = "0x181621570")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x1621B70", Offset = "0x1620F70", VA = "0x181621B70")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x16221D0", Offset = "0x16215D0", VA = "0x1816221D0")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1621A10", Offset = "0x1620E10", VA = "0x181621A10")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x16218E0", Offset = "0x1620CE0", VA = "0x1816218E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1622460", Offset = "0x1621860", VA = "0x181622460")]
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
		[Cpp2IlInjected.Address(RVA = "0x1623640", Offset = "0x1622A40", VA = "0x181623640", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x1623600", Offset = "0x1622A00", VA = "0x181623600", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1623680", Offset = "0x1622A80", VA = "0x181623680", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1622AE0", Offset = "0x1621EE0", VA = "0x181622AE0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1622F20", Offset = "0x1622320", VA = "0x181622F20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1623AA0", Offset = "0x1622EA0", VA = "0x181623AA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1622540", Offset = "0x1621940", VA = "0x181622540")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1623280", Offset = "0x1622680", VA = "0x181623280")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x16236A0", Offset = "0x1622AA0", VA = "0x1816236A0")]
		private void SetLegIK(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1623060", Offset = "0x1622460", VA = "0x181623060")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1622CF0", Offset = "0x16220F0", VA = "0x181622CF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1623F00", Offset = "0x1623300", VA = "0x181623F00")]
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
			[Cpp2IlInjected.Address(RVA = "0x136A330", Offset = "0x1369730", VA = "0x18136A330")]
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
		[Cpp2IlInjected.Address(RVA = "0x1625C00", Offset = "0x1625000", VA = "0x181625C00", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1625BC0", Offset = "0x1624FC0", VA = "0x181625BC0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1625C40", Offset = "0x1625040", VA = "0x181625C40", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1624C20", Offset = "0x1624020", VA = "0x181624C20")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1624A50", Offset = "0x1623E50", VA = "0x181624A50")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1624EA0", Offset = "0x16242A0", VA = "0x181624EA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x16266E0", Offset = "0x1625AE0", VA = "0x1816266E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1624640", Offset = "0x1623A40", VA = "0x181624640")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1624200", Offset = "0x1623600", VA = "0x181624200")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1624D70", Offset = "0x1624170", VA = "0x181624D70")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1625C80", Offset = "0x1625080", VA = "0x181625C80")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1625290", Offset = "0x1624690", VA = "0x181625290")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x16263C0", Offset = "0x16257C0", VA = "0x1816263C0")]
		private void UpdateForefeetRoot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1626210", Offset = "0x1625610", VA = "0x181626210")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1624F20", Offset = "0x1624320", VA = "0x181624F20")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1624E60", Offset = "0x1624260", VA = "0x181624E60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1623FE0", Offset = "0x16233E0", VA = "0x181623FE0")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1626860", Offset = "0x1625C60", VA = "0x181626860")]
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
		[Cpp2IlInjected.Address(RVA = "0x165A0F0", Offset = "0x16594F0", VA = "0x18165A0F0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x165A130", Offset = "0x1659530", VA = "0x18165A130", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x165A0B0", Offset = "0x16594B0", VA = "0x18165A0B0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x165A170", Offset = "0x1659570", VA = "0x18165A170", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x16596E0", Offset = "0x1658AE0", VA = "0x1816596E0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x165A310", Offset = "0x1659710", VA = "0x18165A310")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x16593F0", Offset = "0x16587F0", VA = "0x1816593F0")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1659D10", Offset = "0x1659110", VA = "0x181659D10")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x165A200", Offset = "0x1659600", VA = "0x18165A200")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1659AB0", Offset = "0x1658EB0", VA = "0x181659AB0")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1659950", Offset = "0x1658D50", VA = "0x181659950")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x1659780", Offset = "0x1658B80", VA = "0x181659780")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x165A3F0", Offset = "0x16597F0", VA = "0x18165A3F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x75DD10", Offset = "0x75D110", VA = "0x18075DD10")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(RVA = "0x75DD30", Offset = "0x75D130", VA = "0x18075DD30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Vector3 IKPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(RVA = "0x136D7E0", Offset = "0x136CBE0", VA = "0x18136D7E0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FD")]
				[Cpp2IlInjected.Address(RVA = "0x136D9D0", Offset = "0x136CDD0", VA = "0x18136D9D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool initiated
			{
				[Cpp2IlInjected.Token(Token = "0x60001FE")]
				[Cpp2IlInjected.Address(RVA = "0x77F530", Offset = "0x77E930", VA = "0x18077F530")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FF")]
				[Cpp2IlInjected.Address(RVA = "0x9C88F0", Offset = "0x9C7CF0", VA = "0x1809C88F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public float heightFromGround
			{
				[Cpp2IlInjected.Token(Token = "0x6000200")]
				[Cpp2IlInjected.Address(RVA = "0x92C3E0", Offset = "0x92B7E0", VA = "0x18092C3E0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0x92CB60", Offset = "0x92BF60", VA = "0x18092CB60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Vector3 velocity
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x7300E0", Offset = "0x72F4E0", VA = "0x1807300E0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000203")]
				[Cpp2IlInjected.Address(RVA = "0x730160", Offset = "0x72F560", VA = "0x180730160")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public Transform transform
			{
				[Cpp2IlInjected.Token(Token = "0x6000204")]
				[Cpp2IlInjected.Address(RVA = "0x6E79C0", Offset = "0x6E6DC0", VA = "0x1806E79C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000205")]
				[Cpp2IlInjected.Address(RVA = "0x6E8F10", Offset = "0x6E8310", VA = "0x1806E8F10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public float IKOffset
			{
				[Cpp2IlInjected.Token(Token = "0x6000206")]
				[Cpp2IlInjected.Address(RVA = "0x797680", Offset = "0x796A80", VA = "0x180797680")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000207")]
				[Cpp2IlInjected.Address(RVA = "0x7A4EC0", Offset = "0x7A42C0", VA = "0x1807A4EC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public RaycastHit heelHit
			{
				[Cpp2IlInjected.Token(Token = "0x6000208")]
				[Cpp2IlInjected.Address(RVA = "0x136D830", Offset = "0x136CC30", VA = "0x18136D830")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Cpp2IlInjected.Token(Token = "0x6000209")]
				[Cpp2IlInjected.Address(RVA = "0x136DA10", Offset = "0x136CE10", VA = "0x18136DA10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RaycastHit capsuleHit
			{
				[Cpp2IlInjected.Token(Token = "0x600020A")]
				[Cpp2IlInjected.Address(RVA = "0x136D800", Offset = "0x136CC00", VA = "0x18136D800")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Cpp2IlInjected.Token(Token = "0x600020B")]
				[Cpp2IlInjected.Address(RVA = "0x136D9E0", Offset = "0x136CDE0", VA = "0x18136D9E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public RaycastHit GetHitPoint
			{
				[Cpp2IlInjected.Token(Token = "0x600020C")]
				[Cpp2IlInjected.Address(RVA = "0x136D760", Offset = "0x136CB60", VA = "0x18136D760")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public float stepHeightFromGround
			{
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0x136D990", Offset = "0x136CD90", VA = "0x18136D990")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			private float rootYOffset
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x136D860", Offset = "0x136CC60", VA = "0x18136D860")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x136D280", Offset = "0x136C680", VA = "0x18136D280")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x136BD60", Offset = "0x136B160", VA = "0x18136BD60")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x136BE50", Offset = "0x136B250", VA = "0x18136BE50")]
			public void OnEnable()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x136D020", Offset = "0x136C420", VA = "0x18136D020")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x136BEB0", Offset = "0x136B2B0", VA = "0x18136BEB0")]
			public void Process()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x136AFA0", Offset = "0x136A3A0", VA = "0x18136AFA0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x136B810", Offset = "0x136AC10", VA = "0x18136B810")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x136D1C0", Offset = "0x136C5C0", VA = "0x18136D1C0")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x136D5F0", Offset = "0x136C9F0", VA = "0x18136D5F0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x136D2A0", Offset = "0x136C6A0", VA = "0x18136D2A0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x136B680", Offset = "0x136AA80", VA = "0x18136B680")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x136D0B0", Offset = "0x136C4B0", VA = "0x18136D0B0")]
			private void RotateFoot()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x136BC90", Offset = "0x136B090", VA = "0x18136BC90")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x136D710", Offset = "0x136CB10", VA = "0x18136D710")]
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
				[Cpp2IlInjected.Address(RVA = "0xF268B0", Offset = "0xF25CB0", VA = "0x180F268B0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x136E570", Offset = "0x136D970", VA = "0x18136E570")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public float heightOffset
			{
				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x8D17E0", Offset = "0x8D0BE0", VA = "0x1808D17E0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0xA335E0", Offset = "0xA329E0", VA = "0x180A335E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x136E170", Offset = "0x136D570", VA = "0x18136E170")]
			public void Initiate(Grounding grounding)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x136E4F0", Offset = "0x136D8F0", VA = "0x18136E4F0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x136E1F0", Offset = "0x136D5F0", VA = "0x18136E1F0")]
			public void OnEnable()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x136E260", Offset = "0x136D660", VA = "0x18136E260")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x77F5A0", Offset = "0x77E9A0", VA = "0x18077F5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x83DD10", Offset = "0x83D110", VA = "0x18083DD10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Pelvis pelvis
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x77D5F0", Offset = "0x77C9F0", VA = "0x18077D5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x706290", Offset = "0x705690", VA = "0x180706290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool isGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xCE0A00", Offset = "0xCDFE00", VA = "0x180CE0A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA49790", Offset = "0xA48B90", VA = "0x180A49790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Transform root
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6F0B50", Offset = "0x6EFF50", VA = "0x1806F0B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x7E1190", Offset = "0x7E0590", VA = "0x1807E1190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public RaycastHit rootHit
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x165B840", Offset = "0x165AC40", VA = "0x18165B840")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x165B970", Offset = "0x165AD70", VA = "0x18165B970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool rootGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x165B7E0", Offset = "0x165ABE0", VA = "0x18165B7E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x165B870", Offset = "0x165AC70", VA = "0x18165B870")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private bool useRootRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x165B8E0", Offset = "0x165ACE0", VA = "0x18165B8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x165A930", Offset = "0x1659D30", VA = "0x18165A930")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x165B320", Offset = "0x165A720", VA = "0x18165B320")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x165AF80", Offset = "0x165A380", VA = "0x18165AF80")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x165B4F0", Offset = "0x165A8F0", VA = "0x18165B4F0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x165A660", Offset = "0x1659A60", VA = "0x18165A660")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x165B470", Offset = "0x165A870", VA = "0x18165B470")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x165B450", Offset = "0x165A850", VA = "0x18165B450")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x165AE60", Offset = "0x165A260", VA = "0x18165AE60")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x165A450", Offset = "0x1659850", VA = "0x18165A450")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x165A540", Offset = "0x1659940", VA = "0x18165A540")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x165B780", Offset = "0x165AB80", VA = "0x18165B780")]
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
		[Cpp2IlInjected.Address(RVA = "0x15A5990", Offset = "0x15A4D90", VA = "0x1815A5990", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x15A5910", Offset = "0x15A4D10", VA = "0x1815A5910", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x15A5950", Offset = "0x15A4D50", VA = "0x1815A5950")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x15A59D0", Offset = "0x15A4DD0", VA = "0x1815A59D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x15A58D0", Offset = "0x15A4CD0", VA = "0x1815A58D0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x15A5A10", Offset = "0x15A4E10", VA = "0x1815A5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x15A7F50", Offset = "0x15A7350", VA = "0x1815A7F50", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x15A7F10", Offset = "0x15A7310", VA = "0x1815A7F10", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x15A7F90", Offset = "0x15A7390", VA = "0x1815A7F90")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x15A7ED0", Offset = "0x15A72D0", VA = "0x1815A7ED0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x15A7FD0", Offset = "0x15A73D0", VA = "0x1815A7FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15B9C30", Offset = "0x15B9030", VA = "0x1815B9C30", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x15B9BF0", Offset = "0x15B8FF0", VA = "0x1815B9BF0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x15B9C70", Offset = "0x15B9070", VA = "0x1815B9C70")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x15B9BB0", Offset = "0x15B8FB0", VA = "0x1815B9BB0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x15B9CB0", Offset = "0x15B90B0", VA = "0x1815B9CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1611450", Offset = "0x1610850", VA = "0x181611450", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1611410", Offset = "0x1610810", VA = "0x181611410", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1611490", Offset = "0x1610890", VA = "0x181611490")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x16113D0", Offset = "0x16107D0", VA = "0x1816113D0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x16114D0", Offset = "0x16108D0", VA = "0x1816114D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16112E0", Offset = "0x16106E0", VA = "0x1816112E0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x16112A0", Offset = "0x16106A0", VA = "0x1816112A0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1611320", Offset = "0x1610720", VA = "0x181611320")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1611260", Offset = "0x1610660", VA = "0x181611260")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1611360", Offset = "0x1610760", VA = "0x181611360")]
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
		[Cpp2IlInjected.Address(RVA = "0x161E900", Offset = "0x161DD00", VA = "0x18161E900", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x161E880", Offset = "0x161DC80", VA = "0x18161E880", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x161E8C0", Offset = "0x161DCC0", VA = "0x18161E8C0")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x161E840", Offset = "0x161DC40", VA = "0x18161E840")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x161F0B0", Offset = "0x161E4B0", VA = "0x18161F0B0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x161E710", Offset = "0x161DB10", VA = "0x18161E710")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x161F060", Offset = "0x161E460", VA = "0x18161F060")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E3550", VA = "0x1806E4150", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x161E940", Offset = "0x161DD40", VA = "0x18161E940")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x161EBD0", Offset = "0x161DFD0", VA = "0x18161EBD0")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x161F000", Offset = "0x161E400", VA = "0x18161F000")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x161E750", Offset = "0x161DB50", VA = "0x18161E750")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x161F0F0", Offset = "0x161E4F0", VA = "0x18161F0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16725F0", Offset = "0x16719F0", VA = "0x1816725F0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1672580", Offset = "0x1671980", VA = "0x181672580", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1672510", Offset = "0x1671910", VA = "0x181672510", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x16726D0", Offset = "0x1671AD0", VA = "0x1816726D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1663C10", Offset = "0x1663010", VA = "0x181663C10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1663B60", Offset = "0x1662F60", VA = "0x181663B60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1663BE0", Offset = "0x1662FE0", VA = "0x181663BE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1663A10", Offset = "0x1662E10", VA = "0x181663A10")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1663A40", Offset = "0x1662E40", VA = "0x181663A40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1663960", Offset = "0x1662D60", VA = "0x181663960")]
		private void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BA4B0", Offset = "0x14B98B0", VA = "0x1814BA4B0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x14BA470", Offset = "0x14B9870", VA = "0x1814BA470", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x14BA4F0", Offset = "0x14B98F0", VA = "0x1814BA4F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x14BA430", Offset = "0x14B9830", VA = "0x1814BA430")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x14BA530", Offset = "0x14B9930", VA = "0x1814BA530")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BA620", Offset = "0x14B9A20", VA = "0x1814BA620", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x14BA5E0", Offset = "0x14B99E0", VA = "0x1814BA5E0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x14BA660", Offset = "0x14B9A60", VA = "0x1814BA660")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x14BA5A0", Offset = "0x14B99A0", VA = "0x1814BA5A0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x14BA6A0", Offset = "0x14B9AA0", VA = "0x1814BA6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BB7C0", Offset = "0x14BABC0", VA = "0x1814BB7C0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x14BB780", Offset = "0x14BAB80", VA = "0x1814BB780", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x14BB800", Offset = "0x14BAC00", VA = "0x1814BB800")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x14BB740", Offset = "0x14BAB40", VA = "0x1814BB740")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x14BB840", Offset = "0x14BAC40", VA = "0x1814BB840")]
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
		[Cpp2IlInjected.Address(RVA = "0x13732A0", Offset = "0x13726A0", VA = "0x1813732A0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x1373260", Offset = "0x1372660", VA = "0x181373260", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x13732E0", Offset = "0x13726E0", VA = "0x1813732E0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x1373220", Offset = "0x1372620", VA = "0x181373220")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1373320", Offset = "0x1372720", VA = "0x181373320")]
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
				[Cpp2IlInjected.Address(RVA = "0x18AE350", Offset = "0x18AD750", VA = "0x1818AE350")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public bool isEmpty
			{
				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x18ADE40", Offset = "0x18AD240", VA = "0x1818ADE40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x18AD5E0", Offset = "0x18AC9E0", VA = "0x1818AD5E0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x18AD0F0", Offset = "0x18AC4F0", VA = "0x1818AD0F0")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x137E550", Offset = "0x137D950", VA = "0x18137E550", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x137E4D0", Offset = "0x137D8D0", VA = "0x18137E4D0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x137E510", Offset = "0x137D910", VA = "0x18137E510")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x137E3F0", Offset = "0x137D7F0", VA = "0x18137E3F0")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x137E420", Offset = "0x137D820", VA = "0x18137E420")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E3550", VA = "0x1806E4150", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x137E450", Offset = "0x137D850", VA = "0x18137E450", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x137E590", Offset = "0x137D990", VA = "0x18137E590", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x137E700", Offset = "0x137DB00", VA = "0x18137E700")]
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
		[Cpp2IlInjected.Address(RVA = "0x1610E60", Offset = "0x1610260", VA = "0x181610E60")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1610E30", Offset = "0x1610230", VA = "0x181610E30")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1610F40", Offset = "0x1610340", VA = "0x181610F40")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1611080", Offset = "0x1610480", VA = "0x181611080")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1610B10", Offset = "0x160FF10", VA = "0x181610B10")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1611200", Offset = "0x1610600", VA = "0x181611200")]
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
		[Cpp2IlInjected.Address(RVA = "0x1611540", Offset = "0x1610940", VA = "0x181611540")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1611D30", Offset = "0x1611130", VA = "0x181611D30")]
		private void OnPostFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1611C10", Offset = "0x1611010", VA = "0x181611C10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
			[Cpp2IlInjected.Address(RVA = "0x1367A40", Offset = "0x1366E40", VA = "0x181367A40")]
			public BendBone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x1367A80", Offset = "0x1366E80", VA = "0x181367A80")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x1367A00", Offset = "0x1366E00", VA = "0x181367A00")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x13679C0", Offset = "0x1366DC0", VA = "0x1813679C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1615BC0", Offset = "0x1614FC0", VA = "0x181615BC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1614B70", Offset = "0x1613F70", VA = "0x181614B70")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1613A30", Offset = "0x1612E30", VA = "0x181613A30")]
		private void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x16141B0", Offset = "0x16135B0", VA = "0x1816141B0")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x16157F0", Offset = "0x1614BF0", VA = "0x1816157F0")]
		private void SpineBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1611F30", Offset = "0x1611330", VA = "0x181611F30")]
		private void CCDPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1612670", Offset = "0x1611A70", VA = "0x181612670")]
		private void Iterate(int iteration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1613FB0", Offset = "0x16133B0", VA = "0x181613FB0")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x16123D0", Offset = "0x16117D0", VA = "0x1816123D0")]
		private void ChestDirection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1615230", Offset = "0x1614630", VA = "0x181615230")]
		private void PostStretching()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x16134C0", Offset = "0x16128C0", VA = "0x1816134C0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1615660", Offset = "0x1614A60", VA = "0x181615660")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1613690", Offset = "0x1612A90", VA = "0x181613690")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1615FF0", Offset = "0x16153F0", VA = "0x181615FF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x92C730", Offset = "0x92BB30", VA = "0x18092C730")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x92CC30", Offset = "0x92C030", VA = "0x18092CC30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public bool isRigid
			{
				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x797640", Offset = "0x796A40", VA = "0x180797640")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x9DFA90", Offset = "0x9DEE90", VA = "0x1809DFA90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x136A2C0", Offset = "0x13696C0", VA = "0x18136A2C0")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x1369C60", Offset = "0x1369060", VA = "0x181369C60")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x1369CC0", Offset = "0x13690C0", VA = "0x181369CC0")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x1369F00", Offset = "0x1369300", VA = "0x181369F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1619FE0", Offset = "0x16193E0", VA = "0x181619FE0")]
		public FBIKChain()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1619D60", Offset = "0x1619160", VA = "0x181619D60")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x16188A0", Offset = "0x1617CA0", VA = "0x1816188A0")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1617600", Offset = "0x1616A00", VA = "0x181617600")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x16178C0", Offset = "0x1616CC0", VA = "0x1816178C0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x16176F0", Offset = "0x1616AF0", VA = "0x1816176F0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1618270", Offset = "0x1617670", VA = "0x181618270")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1616AB0", Offset = "0x1615EB0", VA = "0x181616AB0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1617E50", Offset = "0x1617250", VA = "0x181617E50")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x16179F0", Offset = "0x1616DF0", VA = "0x1816179F0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x16190D0", Offset = "0x16184D0", VA = "0x1816190D0")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1619600", Offset = "0x1618A00", VA = "0x181619600")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1619BD0", Offset = "0x1618FD0", VA = "0x181619BD0")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1618A90", Offset = "0x1617E90", VA = "0x181618A90")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1618DC0", Offset = "0x16181C0", VA = "0x181618DC0")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1617430", Offset = "0x1616830", VA = "0x181617430")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x1618A00", Offset = "0x1617E00", VA = "0x181618A00")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1618EE0", Offset = "0x16182E0", VA = "0x181618EE0")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x1617250", Offset = "0x1616650", VA = "0x181617250")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x16167B0", Offset = "0x1615BB0", VA = "0x1816167B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD91B00", Offset = "0xD90F00", VA = "0x180D91B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x1661440", Offset = "0x1660840", VA = "0x181661440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1660610", Offset = "0x165FA10", VA = "0x181660610")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x1661370", Offset = "0x1660770", VA = "0x181661370")]
		public IKConstraintBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x16613B0", Offset = "0x16607B0", VA = "0x1816613B0")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1661100", Offset = "0x1660500", VA = "0x181661100")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x165FFE0", Offset = "0x165F3E0", VA = "0x18165FFE0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1661160", Offset = "0x1660560", VA = "0x181661160")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1660860", Offset = "0x165FC60", VA = "0x181660860")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x165F680", Offset = "0x165EA80", VA = "0x18165F680")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1660F60", Offset = "0x1660360", VA = "0x181660F60")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1660DC0", Offset = "0x16601C0", VA = "0x181660DC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BE830", Offset = "0x7BDC30", VA = "0x1807BE830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x7BE840", Offset = "0x7BDC40", VA = "0x1807BE840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1661450", Offset = "0x1660850", VA = "0x181661450")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1662E30", Offset = "0x1662230", VA = "0x181662E30")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1663670", Offset = "0x1662A70", VA = "0x181663670")]
		public IKEffector()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x16637C0", Offset = "0x1662BC0", VA = "0x1816637C0")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1662180", Offset = "0x1661580", VA = "0x181662180")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1661CD0", Offset = "0x16610D0", VA = "0x181661CD0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1662EE0", Offset = "0x16622E0", VA = "0x181662EE0")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x16630C0", Offset = "0x16624C0", VA = "0x1816630C0")]
		public void SetToTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1662510", Offset = "0x1661910", VA = "0x181662510")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x16624E0", Offset = "0x16618E0", VA = "0x1816624E0")]
		public void OnPostWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x16614C0", Offset = "0x16608C0", VA = "0x1816614C0")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1663170", Offset = "0x1662570", VA = "0x181663170")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1661860", Offset = "0x1660C60", VA = "0x181661860")]
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
				[Cpp2IlInjected.Address(RVA = "0x1369BF0", Offset = "0x1368FF0", VA = "0x181369BF0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public bool isNodeBone
			{
				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x13699C0", Offset = "0x1368DC0", VA = "0x1813699C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0x13699D0", Offset = "0x1368DD0", VA = "0x1813699D0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x1368680", Offset = "0x1367A80", VA = "0x181368680")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x1369070", Offset = "0x1368470", VA = "0x181369070")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1367760", VA = "0x181368360")]
			public void FixTransform(bool position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x1368B40", Offset = "0x1367F40", VA = "0x181368B40")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x1368BF0", Offset = "0x1367FF0", VA = "0x181368BF0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x1368D30", Offset = "0x1368130", VA = "0x181368D30")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x1368E80", Offset = "0x1368280", VA = "0x181368E80")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x1368F20", Offset = "0x1368320", VA = "0x181368F20")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x1369620", Offset = "0x1368A20", VA = "0x181369620")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x1368B00", Offset = "0x1367F00", VA = "0x181368B00")]
			public void SetIKPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x13686E0", Offset = "0x1367AE0", VA = "0x1813686E0")]
			public void MaintainRotation()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x1369030", Offset = "0x1368430", VA = "0x181369030")]
			public void SetToIKPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x13681F0", Offset = "0x13675F0", VA = "0x1813681F0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x13683C0", Offset = "0x13677C0", VA = "0x1813683C0")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1368720", Offset = "0x1367B20", VA = "0x181368720")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x1368A30", Offset = "0x1367E30", VA = "0x181368A30")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x13692C0", Offset = "0x13686C0", VA = "0x1813692C0")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x13690D0", Offset = "0x13684D0", VA = "0x1813690D0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x13694A0", Offset = "0x13688A0", VA = "0x1813694A0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x13689A0", Offset = "0x1367DA0", VA = "0x1813689A0")]
			public void RotateToMaintain(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x1368860", Offset = "0x1367C60", VA = "0x181368860")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x13684D0", Offset = "0x13678D0", VA = "0x1813684D0")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x1369990", Offset = "0x1368D90", VA = "0x181369990")]
			public BoneMap()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x16671D0", Offset = "0x16665D0", VA = "0x1816671D0")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1618DC0", Offset = "0x16181C0", VA = "0x181618DC0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1663D70", Offset = "0x1663170", VA = "0x181663D70", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1663E80", Offset = "0x1663280", VA = "0x181663E80")]
		public IKMappingBone()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x1663EF0", Offset = "0x16632F0", VA = "0x181663EF0")]
		public IKMappingBone(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x1663E30", Offset = "0x1663230", VA = "0x181663E30")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x1663CA0", Offset = "0x16630A0", VA = "0x181663CA0")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1663CD0", Offset = "0x16630D0", VA = "0x181663CD0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x1663E10", Offset = "0x1663210", VA = "0x181663E10")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x1663E50", Offset = "0x1663250", VA = "0x181663E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x16643C0", Offset = "0x16637C0", VA = "0x1816643C0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x1664040", Offset = "0x1663440", VA = "0x181664040")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1664710", Offset = "0x1663B10", VA = "0x181664710")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1664EA0", Offset = "0x16642A0", VA = "0x181664EA0")]
		public IKMappingLimb()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x1664D50", Offset = "0x1664150", VA = "0x181664D50")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x16646A0", Offset = "0x1663AA0", VA = "0x1816646A0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1664B10", Offset = "0x1663F10", VA = "0x181664B10")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1663F80", Offset = "0x1663380", VA = "0x181663F80")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1664110", Offset = "0x1663510", VA = "0x181664110", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x1664620", Offset = "0x1663A20", VA = "0x181664620")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x1664BC0", Offset = "0x1663FC0", VA = "0x181664BC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1665C90", Offset = "0x1665090", VA = "0x181665C90", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1666F20", Offset = "0x1666320", VA = "0x181666F20")]
		public IKMappingSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1667040", Offset = "0x1666440", VA = "0x181667040")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x16668C0", Offset = "0x1665CC0", VA = "0x1816668C0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x1666940", Offset = "0x1665D40", VA = "0x181666940")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1665170", Offset = "0x1664570", VA = "0x181665170")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1665400", Offset = "0x1664800", VA = "0x181665400", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x16669C0", Offset = "0x1665DC0", VA = "0x1816669C0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x16664E0", Offset = "0x16658E0", VA = "0x1816664E0")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x16669F0", Offset = "0x1665DF0", VA = "0x1816669F0")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x1665210", Offset = "0x1664610", VA = "0x181665210")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1664F90", Offset = "0x1664390", VA = "0x181664F90")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x16660B0", Offset = "0x16654B0", VA = "0x1816660B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16EB0F0", Offset = "0x16EA4F0", VA = "0x1816EB0F0")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x16EB000", Offset = "0x16EA400", VA = "0x1816EB000")]
			public void FixTransform()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x16EB1F0", Offset = "0x16EA5F0", VA = "0x1816EB1F0")]
			public void UpdateSolverPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x16EB150", Offset = "0x16EA550", VA = "0x1816EB150")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x16EB230", Offset = "0x16EA630", VA = "0x1816EB230")]
			public void UpdateSolverState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x16EB190", Offset = "0x16EA590", VA = "0x1816EB190")]
			public void UpdateSolverLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x16EA0B0", Offset = "0x16E94B0", VA = "0x1816EA0B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x16E0910", Offset = "0x16DFD10", VA = "0x1816E0910")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x16E0A10", Offset = "0x16DFE10", VA = "0x1816E0A10")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x16E04D0", Offset = "0x16DF8D0", VA = "0x1816E04D0")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x16E0010", Offset = "0x16DF410", VA = "0x1816E0010")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x16E02F0", Offset = "0x16DF6F0", VA = "0x1816E02F0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x16DFFD0", Offset = "0x16DF3D0", VA = "0x1816DFFD0")]
			public void SetToSolverPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x16E0880", Offset = "0x16DFC80", VA = "0x1816E0880")]
			public Bone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x16E0710", Offset = "0x16DFB10", VA = "0x1816E0710")]
			public Bone(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x16E07C0", Offset = "0x16DFBC0", VA = "0x1816E07C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16EA0B0", Offset = "0x16E94B0", VA = "0x1816EA0B0")]
			public Node()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x16EA0F0", Offset = "0x16E94F0", VA = "0x1816EA0F0")]
			public Node(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x16EA050", Offset = "0x16E9450", VA = "0x1816EA050")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F0B40", Offset = "0x6EFF40", VA = "0x1806F0B40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x6F0D20", Offset = "0x6F0120", VA = "0x1806F0D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1671F50", Offset = "0x1671350", VA = "0x181671F50")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool IsValid(ref string message);

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1671DD0", Offset = "0x16711D0", VA = "0x181671DD0")]
		public void Initiate(Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1672480", Offset = "0x1671880", VA = "0x181672480")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x136D7E0", Offset = "0x136CBE0", VA = "0x18136D7E0", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x136D9D0", Offset = "0x136CDD0", VA = "0x18136D9D0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6F0AE0", Offset = "0x6EFEE0", VA = "0x1806F0AE0")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1672450", Offset = "0x1671850", VA = "0x181672450")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB40", Offset = "0x7CAF40", VA = "0x1807CBB40")]
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
		[Cpp2IlInjected.Address(RVA = "0x1671FB0", Offset = "0x16713B0", VA = "0x181671FB0")]
		protected void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1671BD0", Offset = "0x1670FD0", VA = "0x181671BD0")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x1671D20", Offset = "0x1671120", VA = "0x181671D20")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1671FD0", Offset = "0x16713D0", VA = "0x181671FD0")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x16724F0", Offset = "0x16718F0", VA = "0x1816724F0")]
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
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xB82B0", Offset = "0xB76B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1668DA0", Offset = "0x16681A0", VA = "0x181668DA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector3 transformPoleAxis
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x1668E20", Offset = "0x1668220", VA = "0x181668E20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected override int minBones
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7DF3D0", Offset = "0x7DE7D0", VA = "0x1807DF3D0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected override Vector3 localDirection
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x1668CD0", Offset = "0x16680D0", VA = "0x181668CD0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x1667310", Offset = "0x1666710", VA = "0x181667310")]
		public float GetAngle()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x1667970", Offset = "0x1666D70", VA = "0x181667970", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x1667D30", Offset = "0x1667130", VA = "0x181667D30", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x1668B20", Offset = "0x1667F20", VA = "0x181668B20")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1667430", Offset = "0x1666830", VA = "0x181667430")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x1668490", Offset = "0x1667890", VA = "0x181668490")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1668C60", Offset = "0x1668060", VA = "0x181668C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x1669350", Offset = "0x1668750", VA = "0x181669350", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1669F60", Offset = "0x1669360", VA = "0x181669F60")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1669120", Offset = "0x1668520", VA = "0x181669120", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1668F10", Offset = "0x1668310", VA = "0x181668F10", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x166A0C0", Offset = "0x16694C0", VA = "0x18166A0C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x1668EA0", Offset = "0x16682A0", VA = "0x181668EA0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x1669910", Offset = "0x1668D10", VA = "0x181669910", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x1669990", Offset = "0x1668D90", VA = "0x181669990", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x166A030", Offset = "0x1669430", VA = "0x18166A030")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1669A30", Offset = "0x1668E30", VA = "0x181669A30")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x166A120", Offset = "0x1669520", VA = "0x18166A120")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x166A3B0", Offset = "0x16697B0", VA = "0x18166A3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x166A580", Offset = "0x1669980", VA = "0x18166A580")]
		public void FadeOutBoneWeights()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x166A660", Offset = "0x1669A60", VA = "0x18166A660", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x166A6F0", Offset = "0x1669AF0", VA = "0x18166A6F0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x166AA10", Offset = "0x1669E10", VA = "0x18166AA10")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x166B380", Offset = "0x166A780", VA = "0x18166B380")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x166F730", Offset = "0x166EB30", VA = "0x18166F730")]
		public void SolveForward(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x166F660", Offset = "0x166EA60", VA = "0x18166F660")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x166D810", Offset = "0x166CC10", VA = "0x18166D810", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x166E850", Offset = "0x166DC50", VA = "0x18166E850", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x166F350", Offset = "0x166E750", VA = "0x18166F350", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x166F7E0", Offset = "0x166EBE0", VA = "0x18166F7E0")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x166ED80", Offset = "0x166E180", VA = "0x18166ED80")]
		private void OnPreSolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x166EC30", Offset = "0x166E030", VA = "0x18166EC30")]
		private void OnPostSolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x166F920", Offset = "0x166ED20", VA = "0x18166F920")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x166D520", Offset = "0x166C920", VA = "0x18166D520")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x166FBA0", Offset = "0x166EFA0", VA = "0x18166FBA0")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x166FD20", Offset = "0x166F120", VA = "0x18166FD20")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x166FC60", Offset = "0x166F060", VA = "0x18166FC60")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x166F9D0", Offset = "0x166EDD0", VA = "0x18166F9D0")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x166DBA0", Offset = "0x166CFA0", VA = "0x18166DBA0")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x166DA20", Offset = "0x166CE20", VA = "0x18166DA20")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x166D8C0", Offset = "0x166CCC0", VA = "0x18166D8C0")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x166DD10", Offset = "0x166D110", VA = "0x18166DD10")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x166D4E0", Offset = "0x166C8E0", VA = "0x18166D4E0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x166D2F0", Offset = "0x166C6F0", VA = "0x18166D2F0")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x166CBB0", Offset = "0x166BFB0", VA = "0x18166CBB0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x166E690", Offset = "0x166DA90", VA = "0x18166E690")]
		private void MapToSolverPositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x166E590", Offset = "0x166D990", VA = "0x18166E590")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x166FE00", Offset = "0x166F200", VA = "0x18166FE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x166BD10", Offset = "0x166B110", VA = "0x18166BD10", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x166CA70", Offset = "0x166BE70", VA = "0x18166CA70", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x166B500", Offset = "0x166A900", VA = "0x18166B500", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x166C650", Offset = "0x166BA50", VA = "0x18166C650", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x166BC70", Offset = "0x166B070", VA = "0x18166BC70")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x166C810", Offset = "0x166BC10", VA = "0x18166C810", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x166BA60", Offset = "0x166AE60", VA = "0x18166BA60", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x166B9B0", Offset = "0x166ADB0", VA = "0x18166B9B0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x166B390", Offset = "0x166A790", VA = "0x18166B390")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x166B5D0", Offset = "0x166A9D0", VA = "0x18166B5D0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x166CB40", Offset = "0x166BF40", VA = "0x18166CB40")]
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
		[Cpp2IlInjected.Address(RVA = "0x1670360", Offset = "0x166F760", VA = "0x181670360")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x1670310", Offset = "0x166F710", VA = "0x181670310")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x16701E0", Offset = "0x166F5E0", VA = "0x1816701E0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x1670480", Offset = "0x166F880", VA = "0x181670480")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1670150", Offset = "0x166F550", VA = "0x181670150")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x1670680", Offset = "0x166FA80", VA = "0x181670680", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x16704F0", Offset = "0x166F8F0", VA = "0x1816704F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x1670830", Offset = "0x166FC30", VA = "0x181670830", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x1671620", Offset = "0x1670A20", VA = "0x181671620", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x166FED0", Offset = "0x166F2D0", VA = "0x18166FED0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x1670AD0", Offset = "0x166FED0", VA = "0x181670AD0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1670CA0", Offset = "0x16700A0", VA = "0x181670CA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1670E60", Offset = "0x1670260", VA = "0x181670E60", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1671240", Offset = "0x1670640", VA = "0x181671240", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x166FE80", Offset = "0x166F280", VA = "0x18166FE80", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1671860", Offset = "0x1670C60", VA = "0x181671860", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x16719A0", Offset = "0x1670DA0", VA = "0x1816719A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x169F060", Offset = "0x169E460", VA = "0x18169F060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public IKEffector leftShoulderEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x169F220", Offset = "0x169E620", VA = "0x18169F220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public IKEffector rightShoulderEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x169F440", Offset = "0x169E840", VA = "0x18169F440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public IKEffector leftThighEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x169F260", Offset = "0x169E660", VA = "0x18169F260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public IKEffector rightThighEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x169F480", Offset = "0x169E880", VA = "0x18169F480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IKEffector leftHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x169F160", Offset = "0x169E560", VA = "0x18169F160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public IKEffector rightHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x169F380", Offset = "0x169E780", VA = "0x18169F380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public IKEffector leftFootEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x169F120", Offset = "0x169E520", VA = "0x18169F120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public IKEffector rightFootEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x169F340", Offset = "0x169E740", VA = "0x18169F340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public FBIKChain leftArmChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x169F0A0", Offset = "0x169E4A0", VA = "0x18169F0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public FBIKChain rightArmChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x169F2C0", Offset = "0x169E6C0", VA = "0x18169F2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public FBIKChain leftLegChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x169F1A0", Offset = "0x169E5A0", VA = "0x18169F1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public FBIKChain rightLegChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x169F3C0", Offset = "0x169E7C0", VA = "0x18169F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public IKMappingLimb leftArmMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x169F0E0", Offset = "0x169E4E0", VA = "0x18169F0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public IKMappingLimb rightArmMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x169F300", Offset = "0x169E700", VA = "0x18169F300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public IKMappingLimb leftLegMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x169F1E0", Offset = "0x169E5E0", VA = "0x18169F1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public IKMappingLimb rightLegMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x169F400", Offset = "0x169E800", VA = "0x18169F400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IKMappingBone headMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x169BE00", Offset = "0x169B200", VA = "0x18169BE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Vector3 pullBodyOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x169F2A0", Offset = "0x169E6A0", VA = "0x18169F2A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x169F4C0", Offset = "0x169E8C0", VA = "0x18169F4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x169C9D0", Offset = "0x169BDD0", VA = "0x18169C9D0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x169CA40", Offset = "0x169BE40", VA = "0x18169CA40")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x169B630", Offset = "0x169AA30", VA = "0x18169B630")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x169B700", Offset = "0x169AB00", VA = "0x18169B700")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x169B8F0", Offset = "0x169ACF0", VA = "0x18169B8F0")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x169BB00", Offset = "0x169AF00", VA = "0x18169BB00")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x169BF00", Offset = "0x169B300", VA = "0x18169BF00")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x169BFD0", Offset = "0x169B3D0", VA = "0x18169BFD0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B50", Offset = "0x6EFF50", VA = "0x1806F0B50")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x169BE00", Offset = "0x169B200", VA = "0x18169BE00")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x169B290", Offset = "0x169A690", VA = "0x18169B290")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x169C270", Offset = "0x169B670", VA = "0x18169C270", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x169CE70", Offset = "0x169C270", VA = "0x18169CE70")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x169AE70", Offset = "0x169A270", VA = "0x18169AE70")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x169CE00", Offset = "0x169C200", VA = "0x18169CE00")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x169CAF0", Offset = "0x169BEF0", VA = "0x18169CAF0")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x169BE40", Offset = "0x169B240", VA = "0x18169BE40")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x169C1B0", Offset = "0x169B5B0", VA = "0x18169C1B0")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x169ADB0", Offset = "0x169A1B0", VA = "0x18169ADB0")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x169C660", Offset = "0x169BA60", VA = "0x18169C660", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x169C440", Offset = "0x169B840", VA = "0x18169C440")]
		private void PullBody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x169B360", Offset = "0x169A760", VA = "0x18169B360")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x169BBD0", Offset = "0x169AFD0", VA = "0x18169BBD0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x169A930", Offset = "0x1699D30", VA = "0x18169A930", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x169EF30", Offset = "0x169E330", VA = "0x18169EF30", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x169F040", Offset = "0x169E440", VA = "0x18169F040")]
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
			[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D30A0", VA = "0x1807D3CA0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual bool boneLengthCanBeZero
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual bool allowCommonParent
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual Vector3 localDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x16A0DA0", Offset = "0x16A01A0", VA = "0x1816A0DA0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected float positionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x16A0F40", Offset = "0x16A0340", VA = "0x1816A0F40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x16A0800", Offset = "0x169FC00", VA = "0x1816A0800")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x169F4E0", Offset = "0x169E8E0", VA = "0x18169F4E0")]
		public void AddBone(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x16A0CC0", Offset = "0x16A00C0", VA = "0x1816A0CC0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x169F6B0", Offset = "0x169EAB0", VA = "0x18169F6B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x16A03B0", Offset = "0x169F7B0", VA = "0x1816A03B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B50", Offset = "0x6EFF50", VA = "0x1806F0B50", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x169F740", Offset = "0x169EB40", VA = "0x18169F740", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x169FCC0", Offset = "0x169F0C0", VA = "0x18169FCC0")]
		protected void InitiateBones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x169F860", Offset = "0x169EC60", VA = "0x18169F860")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x16A09E0", Offset = "0x169FDE0", VA = "0x1816A09E0")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x16A0D40", Offset = "0x16A0140", VA = "0x1816A0D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A1400", Offset = "0x16A0800", VA = "0x1816A1400", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1669F60", Offset = "0x1669360", VA = "0x181669F60")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x16A11D0", Offset = "0x16A05D0", VA = "0x1816A11D0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x16A0FC0", Offset = "0x16A03C0", VA = "0x1816A0FC0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x166A0C0", Offset = "0x16694C0", VA = "0x18166A0C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x1668EA0", Offset = "0x16682A0", VA = "0x181668EA0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x16A18E0", Offset = "0x16A0CE0", VA = "0x1816A18E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x16A1960", Offset = "0x16A0D60", VA = "0x1816A1960", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x16A1FB0", Offset = "0x16A13B0", VA = "0x1816A1FB0")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x16A1A90", Offset = "0x16A0E90", VA = "0x1816A1A90")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x16A20D0", Offset = "0x16A14D0", VA = "0x1816A20D0")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x16A2360", Offset = "0x16A1760", VA = "0x1816A2360")]
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
			[Cpp2IlInjected.Address(RVA = "0x16DEED0", Offset = "0x16DE2D0", VA = "0x1816DEED0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16A3C70", Offset = "0x16A3070", VA = "0x1816A3C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x16A3280", Offset = "0x16A2680", VA = "0x1816A3280")]
		public void MaintainRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x16A3230", Offset = "0x16A2630", VA = "0x1816A3230")]
		public void MaintainBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x16A32D0", Offset = "0x16A26D0", VA = "0x1816A32D0", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x16A37D0", Offset = "0x16A2BD0", VA = "0x1816A37D0", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x16A36E0", Offset = "0x16A2AE0", VA = "0x1816A36E0", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x16A3B40", Offset = "0x16A2F40", VA = "0x1816A3B40")]
		public IKSolverLimb()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x16A3BD0", Offset = "0x16A2FD0", VA = "0x1816A3BD0")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x16A38E0", Offset = "0x16A2CE0", VA = "0x1816A38E0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x16A2520", Offset = "0x16A1920", VA = "0x1816A2520")]
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
				[Cpp2IlInjected.Address(RVA = "0x16E9EB0", Offset = "0x16E92B0", VA = "0x1816E9EB0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x16E9E70", Offset = "0x16E9270", VA = "0x1816E9E70")]
			public LookAtBone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x16E9E80", Offset = "0x16E9280", VA = "0x1816E9E80")]
			public LookAtBone(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x16E9BF0", Offset = "0x16E8FF0", VA = "0x1816E9BF0")]
			public void Initiate(Transform root)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x16E9D10", Offset = "0x16E9110", VA = "0x1816E9D10")]
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
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xB82B0", Offset = "0xB76B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16A6610", Offset = "0x16A5A10", VA = "0x1816A6610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected bool spineIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x16A65F0", Offset = "0x16A59F0", VA = "0x1816A65F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected bool headIsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x16A65E0", Offset = "0x16A59E0", VA = "0x1816A65E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected bool headIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x16A6570", Offset = "0x16A5970", VA = "0x1816A6570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected bool eyesIsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x16A6480", Offset = "0x16A5880", VA = "0x1816A6480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected bool eyesIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x16A6460", Offset = "0x16A5860", VA = "0x1816A6460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x1672450", Offset = "0x1671850", VA = "0x181672450")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x16A51A0", Offset = "0x16A45A0", VA = "0x1816A51A0")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x16A5200", Offset = "0x16A4600", VA = "0x1816A5200")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x16A5100", Offset = "0x16A4500", VA = "0x1816A5100")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x16A5280", Offset = "0x16A4680", VA = "0x1816A5280")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x16A5360", Offset = "0x16A4760", VA = "0x1816A5360")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x16A6060", Offset = "0x16A5460", VA = "0x1816A6060", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x16A50F0", Offset = "0x16A44F0", VA = "0x1816A50F0")]
		public void SetDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x16A3C90", Offset = "0x16A3090", VA = "0x1816A3C90", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x16A4660", Offset = "0x16A3A60", VA = "0x1816A4660", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x16A4350", Offset = "0x16A3750", VA = "0x1816A4350", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x16A4190", Offset = "0x16A3590", VA = "0x1816A4190", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x16A5030", Offset = "0x16A4430", VA = "0x1816A5030")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x16A4990", Offset = "0x16A3D90", VA = "0x1816A4990", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x16A4D80", Offset = "0x16A4180", VA = "0x1816A4D80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x16A5D50", Offset = "0x16A5150", VA = "0x1816A5D50")]
		protected void SolveSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x16A5A00", Offset = "0x16A4E00", VA = "0x1816A5A00")]
		protected void SolveHead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x16A5470", Offset = "0x16A4870", VA = "0x1816A5470")]
		protected void SolveEyes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x16A3E20", Offset = "0x16A3220", VA = "0x1816A3E20")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x16A4E60", Offset = "0x16A4260", VA = "0x1816A4E60")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x16A61C0", Offset = "0x16A55C0", VA = "0x1816A61C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16F0300", Offset = "0x16EF700", VA = "0x1816F0300")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x16F0280", Offset = "0x16EF680", VA = "0x1816F0280")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x16F0200", Offset = "0x16EF600", VA = "0x1816F0200")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x16E9E70", Offset = "0x16E9270", VA = "0x1816E9E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A8490", Offset = "0x16A7890", VA = "0x1816A8490")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x16A8700", Offset = "0x16A7B00", VA = "0x1816A8700")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x16A89D0", Offset = "0x16A7DD0", VA = "0x1816A89D0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x16A89A0", Offset = "0x16A7DA0", VA = "0x1816A89A0")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x12CFCC0", Offset = "0x12CF0C0", VA = "0x1812CFCC0")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x16A6C50", Offset = "0x16A6050", VA = "0x1816A6C50")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x16A6DC0", Offset = "0x16A61C0", VA = "0x1816A6DC0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x16A6C60", Offset = "0x16A6060", VA = "0x1816A6C60", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x16A91F0", Offset = "0x16A85F0", VA = "0x1816A91F0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x16A6700", Offset = "0x16A5B00", VA = "0x1816A6700", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x16A7350", Offset = "0x16A6750", VA = "0x1816A7350", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x16A8910", Offset = "0x16A7D10", VA = "0x1816A8910")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x16A89E0", Offset = "0x16A7DE0", VA = "0x1816A89E0")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x16A6A80", Offset = "0x16A5E80", VA = "0x1816A6A80")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x16A7840", Offset = "0x16A6C40", VA = "0x1816A7840", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x16A7220", Offset = "0x16A6620", VA = "0x1816A7220")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x16A6F40", Offset = "0x16A6340", VA = "0x1816A6F40")]
		private void InitiateBones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x16A7A50", Offset = "0x16A6E50", VA = "0x1816A7A50", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x16A6760", Offset = "0x16A5B60", VA = "0x1816A6760")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x16A9240", Offset = "0x16A8640", VA = "0x1816A9240")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xB87D0", Offset = "0xB7BD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x16DE560", Offset = "0x16DD960", VA = "0x1816DE560")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x16DE620", Offset = "0x16DDA20", VA = "0x1816DE620")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public Quaternion rotation
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0x12CD680", Offset = "0x12CCA80", VA = "0x1812CD680")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x16DE640", Offset = "0x16DDA40", VA = "0x1816DE640")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			private VirtualBone shoulder
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0x16DE580", Offset = "0x16DD980", VA = "0x1816DE580")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			private VirtualBone upperArm
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x16DE5C0", Offset = "0x16DD9C0", VA = "0x1816DE5C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			private VirtualBone forearm
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x16DE4A0", Offset = "0x16DD8A0", VA = "0x1816DE4A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			private VirtualBone hand
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x16DE500", Offset = "0x16DD900", VA = "0x1816DE500")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x16DA4A0", Offset = "0x16D98A0", VA = "0x1816DA4A0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x16DB1B0", Offset = "0x16DA5B0", VA = "0x1816DB1B0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x16D9CA0", Offset = "0x16D90A0", VA = "0x1816D9CA0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x16DD670", Offset = "0x16DCA70", VA = "0x1816DD670")]
			private void Stretching()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x16DB540", Offset = "0x16DA940", VA = "0x1816DB540")]
			public void Solve(bool isLeft)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x16DB510", Offset = "0x16DA910", VA = "0x1816DB510", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x16DDE90", Offset = "0x16DD290", VA = "0x1816DDE90", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x16D9D30", Offset = "0x16D9130", VA = "0x1816D9D30")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x16D9DC0", Offset = "0x16D91C0", VA = "0x1816D9DC0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x16DDD50", Offset = "0x16DD150", VA = "0x1816DDD50")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x16DE320", Offset = "0x16DD720", VA = "0x1816DE320")]
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
				[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x9C9260", Offset = "0x9C8660", VA = "0x1809C9260")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public float mag
			{
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0xA335C0", Offset = "0xA329C0", VA = "0x180A335C0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0xA335D0", Offset = "0xA329D0", VA = "0x180A335D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xC27BB0", Offset = "0xC26FB0", VA = "0x180C27BB0")]
			public void SetLOD(int LOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x16DF100", Offset = "0x16DE500", VA = "0x1816DF100")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x16DEF30", Offset = "0x16DE330", VA = "0x1816DEF30")]
			public void MovePosition(Vector3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x16DF030", Offset = "0x16DE430", VA = "0x1816DF030")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x16DF500", Offset = "0x16DE900", VA = "0x1816DF500")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x16DF340", Offset = "0x16DE740", VA = "0x1816DF340")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x16DF210", Offset = "0x16DE610", VA = "0x1816DF210")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x16DF600", Offset = "0x16DEA00", VA = "0x1816DF600")]
			public void Visualize(Color color)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x16DF770", Offset = "0x16DEB70", VA = "0x1816DF770")]
			public void Visualize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x16DF900", Offset = "0x16DED00", VA = "0x1816DF900")]
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
				[Cpp2IlInjected.Address(RVA = "0x16E2710", Offset = "0x16E1B10", VA = "0x1816E2710")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public float stepProgress
			{
				[Cpp2IlInjected.Token(Token = "0x600046F")]
				[Cpp2IlInjected.Address(RVA = "0x797680", Offset = "0x796A80", VA = "0x180797680")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000470")]
				[Cpp2IlInjected.Address(RVA = "0x7A4EC0", Offset = "0x7A42C0", VA = "0x1807A4EC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x16E25C0", Offset = "0x16E19C0", VA = "0x1816E25C0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x16E1E80", Offset = "0x16E1280", VA = "0x1816E1E80")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x16E1ED0", Offset = "0x16E12D0", VA = "0x1816E1ED0")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x16E2270", Offset = "0x16E1670", VA = "0x1816E2270")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x16E2100", Offset = "0x16E1500", VA = "0x1816E2100")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x16E2410", Offset = "0x16E1810", VA = "0x1816E2410")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xB8A60", Offset = "0xB7E60")]
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
				[Cpp2IlInjected.Address(RVA = "0xF55AC0", Offset = "0xF54EC0", VA = "0x180F55AC0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000478")]
				[Cpp2IlInjected.Address(RVA = "0x16E6270", Offset = "0x16E5670", VA = "0x1816E6270")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public Quaternion rotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x6E52E0", Offset = "0x6E46E0", VA = "0x1806E52E0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x6E55A0", Offset = "0x6E49A0", VA = "0x1806E55A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public bool hasToes
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0xEB2950", Offset = "0xEB1D50", VA = "0x180EB2950")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0x16E6260", Offset = "0x16E5660", VA = "0x1816E6260")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public VirtualBone thigh
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0x16DE580", Offset = "0x16DD980", VA = "0x1816DE580")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			private VirtualBone calf
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0x16E6160", Offset = "0x16E5560", VA = "0x1816E6160")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			private VirtualBone foot
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0x16E61A0", Offset = "0x16E55A0", VA = "0x1816E61A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			private VirtualBone toes
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0x16E6220", Offset = "0x16E5620", VA = "0x1816E6220")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public VirtualBone lastBone
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0x16E61E0", Offset = "0x16E55E0", VA = "0x1816E61E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public Vector3 thighRelativeToPelvis
			{
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x169F2A0", Offset = "0x169E6A0", VA = "0x18169F2A0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0x169F4C0", Offset = "0x169E8C0", VA = "0x18169F4C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x16E3EB0", Offset = "0x16E32B0", VA = "0x1816E3EB0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x16E4980", Offset = "0x16E3D80", VA = "0x1816E4980", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x16E2DA0", Offset = "0x16E21A0", VA = "0x1816E2DA0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x16E3690", Offset = "0x16E2A90", VA = "0x1816E3690")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x16E3780", Offset = "0x16E2B80", VA = "0x1816E3780")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x16E5240", Offset = "0x16E4640", VA = "0x1816E5240")]
			public void Solve(bool stretch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x16E39C0", Offset = "0x16E2DC0", VA = "0x1816E39C0")]
			private void FixTwistRotations()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x16E55B0", Offset = "0x16E49B0", VA = "0x1816E55B0")]
			private void Stretching()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x16E5C70", Offset = "0x16E5070", VA = "0x1816E5C70", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x16E51D0", Offset = "0x16E45D0", VA = "0x1816E51D0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x16E6020", Offset = "0x16E5420", VA = "0x1816E6020")]
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
				[Cpp2IlInjected.Address(RVA = "0x16E9A50", Offset = "0x16E8E50", VA = "0x1816E9A50")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x16E9BD0", Offset = "0x16E8FD0", VA = "0x1816E9BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public Vector3 leftFootstepPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x16E9A70", Offset = "0x16E8E70", VA = "0x1816E9A70")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public Vector3 rightFootstepPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0x16E9B20", Offset = "0x16E8F20", VA = "0x1816E9B20")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public Quaternion leftFootstepRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x16E9AD0", Offset = "0x16E8ED0", VA = "0x1816E9AD0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public Quaternion rightFootstepRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600049A")]
				[Cpp2IlInjected.Address(RVA = "0x16E9B80", Offset = "0x16E8F80", VA = "0x1816E9B80")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x16E6C80", Offset = "0x16E6080", VA = "0x1816E6C80")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x16E7290", Offset = "0x16E6690", VA = "0x1816E7290")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x16E7220", Offset = "0x16E6620", VA = "0x1816E7220")]
			public void Relax()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x16E6450", Offset = "0x16E5850", VA = "0x1816E6450")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x16E6290", Offset = "0x16E5690", VA = "0x1816E6290")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x16E7610", Offset = "0x16E6A10", VA = "0x1816E7610")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x16E9740", Offset = "0x16E8B40", VA = "0x1816E9740")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x16E6A10", Offset = "0x16E5E10", VA = "0x1816E6A10")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x16E6A90", Offset = "0x16E5E90", VA = "0x1816E6A90")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x16E9920", Offset = "0x16E8D20", VA = "0x1816E9920")]
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
				[Cpp2IlInjected.Address(RVA = "0x16F01A0", Offset = "0x16EF5A0", VA = "0x1816F01A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public VirtualBone firstSpineBone
			{
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0x16F00E0", Offset = "0x16EF4E0", VA = "0x1816F00E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public VirtualBone chest
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0x16F0070", Offset = "0x16EF470", VA = "0x1816F0070")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			private VirtualBone neck
			{
				[Cpp2IlInjected.Token(Token = "0x60004A2")]
				[Cpp2IlInjected.Address(RVA = "0x16F0160", Offset = "0x16EF560", VA = "0x1816F0160")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public VirtualBone head
			{
				[Cpp2IlInjected.Token(Token = "0x60004A3")]
				[Cpp2IlInjected.Address(RVA = "0x16F0120", Offset = "0x16EF520", VA = "0x1816F0120")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Quaternion anchorRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60004A4")]
				[Cpp2IlInjected.Address(RVA = "0x16F0060", Offset = "0x16EF460", VA = "0x1816F0060")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60004A5")]
				[Cpp2IlInjected.Address(RVA = "0x16F01F0", Offset = "0x16EF5F0", VA = "0x1816F01F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public Quaternion anchorRelativeToHead
			{
				[Cpp2IlInjected.Token(Token = "0x60004A6")]
				[Cpp2IlInjected.Address(RVA = "0x16C4730", Offset = "0x16C3B30", VA = "0x1816C4730")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60004A7")]
				[Cpp2IlInjected.Address(RVA = "0x16F01E0", Offset = "0x16EF5E0", VA = "0x1816F01E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x16ED640", Offset = "0x16ECA40", VA = "0x1816ED640", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x16EE480", Offset = "0x16ED880", VA = "0x1816EE480", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x16EBE80", Offset = "0x16EB280", VA = "0x1816EBE80", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x16ECBC0", Offset = "0x16EBFC0", VA = "0x1816ECBC0")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x16EEC10", Offset = "0x16EE010", VA = "0x1816EEC10")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x16ECDA0", Offset = "0x16EC1A0", VA = "0x1816ECDA0")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x16EE860", Offset = "0x16EDC60", VA = "0x1816EE860")]
			private void SolvePelvis()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x16EFB90", Offset = "0x16EEF90", VA = "0x1816EFB90", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x16EE7B0", Offset = "0x16EDBB0", VA = "0x1816EE7B0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x16EB950", Offset = "0x16EAD50", VA = "0x1816EB950")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x16ED0A0", Offset = "0x16EC4A0", VA = "0x1816ED0A0")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x16EF430", Offset = "0x16EE830", VA = "0x1816EF430")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x16ED2B0", Offset = "0x16EC6B0", VA = "0x1816ED2B0")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x16EC930", Offset = "0x16EBD30", VA = "0x1816EC930")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x16EC5D0", Offset = "0x16EB9D0", VA = "0x1816EC5D0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x16EFE60", Offset = "0x16EF260", VA = "0x1816EFE60")]
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
			[Cpp2IlInjected.Address(RVA = "0x16F3430", Offset = "0x16F2830", VA = "0x1816F3430")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x16F1670", Offset = "0x16F0A70", VA = "0x1816F1670")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x16F31E0", Offset = "0x16F25E0", VA = "0x1816F31E0")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x16F12E0", Offset = "0x16F06E0", VA = "0x1816F12E0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x16F16A0", Offset = "0x16F0AA0", VA = "0x1816F16A0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x16F1AD0", Offset = "0x16F0ED0", VA = "0x1816F1AD0")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x16F18B0", Offset = "0x16F0CB0", VA = "0x1816F18B0")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x16F1CF0", Offset = "0x16F10F0", VA = "0x1816F1CF0")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x16F2820", Offset = "0x16F1C20", VA = "0x1816F2820")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x16F1110", Offset = "0x16F0510", VA = "0x1816F1110")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x16F21A0", Offset = "0x16F15A0", VA = "0x1816F21A0")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x16F2080", Offset = "0x16F1480", VA = "0x1816F2080")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x16F1DD0", Offset = "0x16F11D0", VA = "0x1816F1DD0")]
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
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xB82F0", Offset = "0xB76F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7044D0", Offset = "0x7038D0", VA = "0x1807044D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x7049A0", Offset = "0x703DA0", VA = "0x1807049A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x16AC020", Offset = "0x16AB420", VA = "0x1816AC020")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x16AAC00", Offset = "0x16AA000", VA = "0x1816AAC00")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x16A9AB0", Offset = "0x16A8EB0", VA = "0x1816A9AB0")]
		public void DefaultAnimationCurves()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x16A94D0", Offset = "0x16A88D0", VA = "0x1816A94D0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x16A9870", Offset = "0x16A8C70", VA = "0x1816A9870")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x16A99B0", Offset = "0x16A8DB0", VA = "0x1816A99B0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x16A9340", Offset = "0x16A8740", VA = "0x1816A9340")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x16ABED0", Offset = "0x16AB2D0", VA = "0x1816ABED0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x16ADEC0", Offset = "0x16AD2C0", VA = "0x1816ADEC0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x16A9C50", Offset = "0x16A9050", VA = "0x1816A9C50", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x16AA990", Offset = "0x16A9D90", VA = "0x1816AA990", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x16AA930", Offset = "0x16A9D30", VA = "0x1816AA930", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x16AAF10", Offset = "0x16AA310", VA = "0x1816AAF10", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x16A9EA0", Offset = "0x16A92A0", VA = "0x1816A9EA0")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x16AAA90", Offset = "0x16A9E90", VA = "0x1816AAA90")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x16AE0A0", Offset = "0x16AD4A0", VA = "0x1816AE0A0")]
		private void UpdateSolverTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x16AB1B0", Offset = "0x16AA5B0", VA = "0x1816AB1B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x16AB210", Offset = "0x16AA610", VA = "0x1816AB210", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x16AE260", Offset = "0x16AD660", VA = "0x1816AE260")]
		private void WriteTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x16AB7B0", Offset = "0x16AABB0", VA = "0x1816AB7B0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x16AC3B0", Offset = "0x16AB7B0", VA = "0x1816AC3B0")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x16AA9F0", Offset = "0x16A9DF0", VA = "0x1816AA9F0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x16AAA40", Offset = "0x16A9E40", VA = "0x1816AAA40")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x16AE820", Offset = "0x16ADC20", VA = "0x1816AE820")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x16AA1A0", Offset = "0x16A95A0", VA = "0x1816AA1A0")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x16AE9E0", Offset = "0x16ADDE0", VA = "0x1816AE9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x13736B0", Offset = "0x1372AB0", VA = "0x1813736B0")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x13735F0", Offset = "0x13729F0", VA = "0x1813735F0")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x1373400", Offset = "0x1372800", VA = "0x181373400")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x13734C0", Offset = "0x13728C0", VA = "0x1813734C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x13738A0", Offset = "0x1372CA0", VA = "0x1813738A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1374500", Offset = "0x1373900", VA = "0x181374500")]
		public TwistSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x1373900", Offset = "0x1372D00", VA = "0x181373900")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x1373FD0", Offset = "0x13733D0", VA = "0x181373FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x7532B0", Offset = "0x7526B0", VA = "0x1807532B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public bool isPaused
		{
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x9C9270", Offset = "0x9C8670", VA = "0x1809C9270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public InteractionObject interactionObject
		{
			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x6EBA00", Offset = "0x6EAE00", VA = "0x1806EBA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public bool inInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x16B19D0", Offset = "0x16B0DD0", VA = "0x1816B19D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public float progress
		{
			[Cpp2IlInjected.Token(Token = "0x60004DC")]
			[Cpp2IlInjected.Address(RVA = "0x16B1A30", Offset = "0x16B0E30", VA = "0x1816B1A30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x16B1940", Offset = "0x16B0D40", VA = "0x1816B1940")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x16AF550", Offset = "0x16AE950", VA = "0x1816AF550")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x16B0A10", Offset = "0x16AFE10", VA = "0x1816B0A10")]
		private void StoreDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x16AFDA0", Offset = "0x16AF1A0", VA = "0x1816AFDA0")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x16AF940", Offset = "0x16AED40", VA = "0x1816AF940")]
		public bool Pause()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x16B0280", Offset = "0x16AF680", VA = "0x1816B0280")]
		public bool Resume()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x16B0330", Offset = "0x16AF730", VA = "0x1816B0330")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x16B0EE0", Offset = "0x16B02E0", VA = "0x1816B0EE0")]
		public void Update(Transform root, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x16B0C00", Offset = "0x16B0000", VA = "0x1816B0C00")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x16AFAB0", Offset = "0x16AEEB0", VA = "0x1816AFAB0")]
		private void PickUp(Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x16B0850", Offset = "0x16AFC50", VA = "0x1816B0850")]
		public bool Stop()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x16AF610", Offset = "0x16AEA10", VA = "0x1816AF610")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B1AB0", Offset = "0x16B0EB0", VA = "0x1816B1AB0")]
		public void Look(Transform target, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x16B1C40", Offset = "0x16B1040", VA = "0x1816B1C40")]
		public void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x16B1ED0", Offset = "0x16B12D0", VA = "0x1816B1ED0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x16B1DB0", Offset = "0x16B11B0", VA = "0x1816B1DB0")]
		public void SolveSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x16B1CE0", Offset = "0x16B10E0", VA = "0x1816B1CE0")]
		public void SolveHead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x16B2150", Offset = "0x16B1550", VA = "0x1816B2150")]
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
			[Cpp2IlInjected.Address(RVA = "0x16E2B60", Offset = "0x16E1F60", VA = "0x1816E2B60")]
			public void Activate(Transform t)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16E9F20", Offset = "0x16E9320", VA = "0x1816E9F20")]
			public void Send(Transform t)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16D9AA0", Offset = "0x16D8EA0", VA = "0x1816D9AA0")]
			public void Activate(bool pickUp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0x16D9940", Offset = "0x16D8D40", VA = "0x1816D9940")]
			private void Activate(Animator animator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x16D99E0", Offset = "0x16D8DE0", VA = "0x1816D99E0")]
			private void Activate(Animation animation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0x16D9C90", Offset = "0x16D9090", VA = "0x1816D9C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x16F3490", Offset = "0x16F2890", VA = "0x1816F3490")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16EA010", Offset = "0x16E9410", VA = "0x1816EA010")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0xD83730", Offset = "0xD82B30", VA = "0x180D83730")]
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
			[Cpp2IlInjected.Address(RVA = "0x730120", Offset = "0x72F520", VA = "0x180730120")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x730190", Offset = "0x72F590", VA = "0x180730190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB40", Offset = "0x7CAF40", VA = "0x1807CBB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A7C70", Offset = "0x8A7070", VA = "0x1808A7C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Transform lookAtTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x14B3210", Offset = "0x14B2610", VA = "0x1814B3210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public Transform targetsRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x14B3290", Offset = "0x14B2690", VA = "0x1814B3290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x14B3120", Offset = "0x14B2520", VA = "0x1814B3120")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x14B2FE0", Offset = "0x14B23E0", VA = "0x1814B2FE0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x14B3020", Offset = "0x14B2420", VA = "0x1814B3020")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x14B3060", Offset = "0x14B2460", VA = "0x1814B3060")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x14B30A0", Offset = "0x14B24A0", VA = "0x1814B30A0")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x14B30E0", Offset = "0x14B24E0", VA = "0x1814B30E0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x14B3170", Offset = "0x14B2570", VA = "0x1814B3170")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x14B1910", Offset = "0x14B0D10", VA = "0x1814B1910")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x14B2D20", Offset = "0x14B2120", VA = "0x1814B2D20")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x14B2660", Offset = "0x14B1A60", VA = "0x1814B2660")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x14B2530", Offset = "0x14B1930", VA = "0x1814B2530")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x77F5A0", Offset = "0x77E9A0", VA = "0x18077F5A0")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x14B2840", Offset = "0x14B1C40", VA = "0x1814B2840")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A7C70", Offset = "0x8A7070", VA = "0x1808A7C70")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x14B1FA0", Offset = "0x14B13A0", VA = "0x1814B1FA0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x14B29E0", Offset = "0x14B1DE0", VA = "0x1814B29E0")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x14B3160", Offset = "0x14B2560", VA = "0x1814B3160")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x14B1950", Offset = "0x14B0D50", VA = "0x1814B1950")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x14B27C0", Offset = "0x14B1BC0", VA = "0x1814B27C0")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x14B2CB0", Offset = "0x14B20B0", VA = "0x1814B2CB0")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x14B25F0", Offset = "0x14B19F0", VA = "0x1814B25F0")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x14B31B0", Offset = "0x14B25B0", VA = "0x1814B31B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x14B7B50", Offset = "0x14B6F50", VA = "0x1814B7B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public FullBodyBipedIK ik
		{
			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x702380", Offset = "0x701780", VA = "0x180702380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x7023D0", Offset = "0x7017D0", VA = "0x1807023D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public List<InteractionTrigger> triggersInRange
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x6E79C0", Offset = "0x6E6DC0", VA = "0x1806E79C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x6E8F10", Offset = "0x6E8310", VA = "0x1806E8F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x1135FF0", Offset = "0x11353F0", VA = "0x181135FF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x1136100", Offset = "0x1135500", VA = "0x181136100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x14B55D0", Offset = "0x14B49D0", VA = "0x1814B55D0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x14B5490", Offset = "0x14B4890", VA = "0x1814B5490")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x14B54D0", Offset = "0x14B48D0", VA = "0x1814B54D0")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x14B5510", Offset = "0x14B4910", VA = "0x1814B5510")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x14B5550", Offset = "0x14B4950", VA = "0x1814B5550")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x14B5590", Offset = "0x14B4990", VA = "0x1814B5590")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x14B6190", Offset = "0x14B5590", VA = "0x1814B6190")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x14B35B0", Offset = "0x14B29B0", VA = "0x1814B35B0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x14B4460", Offset = "0x14B3860", VA = "0x1814B4460")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x14B4760", Offset = "0x14B3B60", VA = "0x1814B4760")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x14B4670", Offset = "0x14B3A70", VA = "0x1814B4670")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x14B4530", Offset = "0x14B3930", VA = "0x1814B4530")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x14B59A0", Offset = "0x14B4DA0", VA = "0x1814B59A0")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x14B56A0", Offset = "0x14B4AA0", VA = "0x1814B56A0")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x14B5910", Offset = "0x14B4D10", VA = "0x1814B5910")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x14B6100", Offset = "0x14B5500", VA = "0x1814B6100")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x14B5610", Offset = "0x14B4A10", VA = "0x1814B5610")]
		public void PauseAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x14B5880", Offset = "0x14B4C80", VA = "0x1814B5880")]
		public void ResumeAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x14B6080", Offset = "0x14B5480", VA = "0x1814B6080")]
		public void StopAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x14B40B0", Offset = "0x14B34B0", VA = "0x1814B40B0")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x14B4250", Offset = "0x14B3650", VA = "0x1814B4250")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x14B4140", Offset = "0x14B3540", VA = "0x1814B4140")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x14B6BC0", Offset = "0x14B5FC0", VA = "0x1814B6BC0")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x14B6960", Offset = "0x14B5D60", VA = "0x1814B6960")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x14B6620", Offset = "0x14B5A20", VA = "0x1814B6620")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x14B3B30", Offset = "0x14B2F30", VA = "0x1814B3B30")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x14B3990", Offset = "0x14B2D90", VA = "0x1814B3990")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x14B3C30", Offset = "0x14B3030", VA = "0x1814B3C30")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x14B39E0", Offset = "0x14B2DE0", VA = "0x1814B39E0")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x14B3CC0", Offset = "0x14B30C0", VA = "0x1814B3CC0")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x14B61D0", Offset = "0x14B55D0", VA = "0x1814B61D0")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x14B42E0", Offset = "0x14B36E0", VA = "0x1814B42E0")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x14B3E70", Offset = "0x14B3270", VA = "0x1814B3E70")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x14B5AB0", Offset = "0x14B4EB0", VA = "0x1814B5AB0")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x14B4420", Offset = "0x14B3820", VA = "0x1814B4420")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x14B4440", Offset = "0x14B3840", VA = "0x1814B4440")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x14B4440", Offset = "0x14B3840", VA = "0x1814B4440")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x14B4920", Offset = "0x14B3D20", VA = "0x1814B4920")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x14B5270", Offset = "0x14B4670", VA = "0x1814B5270")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x14B5390", Offset = "0x14B4790", VA = "0x1814B5390")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x14B35F0", Offset = "0x14B29F0", VA = "0x1814B35F0")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x14B4E60", Offset = "0x14B4260", VA = "0x1814B4E60")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x14B7210", Offset = "0x14B6610", VA = "0x1814B7210")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x14B5730", Offset = "0x14B4B30", VA = "0x1814B5730")]
		private void Raycasting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x14B6F10", Offset = "0x14B6310", VA = "0x1814B6F10")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x14B6DA0", Offset = "0x14B61A0", VA = "0x1814B6DA0")]
		private void UpdateEffectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x14B5090", Offset = "0x14B4490", VA = "0x1814B5090")]
		private void OnPreFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x14B4FB0", Offset = "0x14B43B0", VA = "0x1814B4FB0")]
		private void OnPostFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x14B4F80", Offset = "0x14B4380", VA = "0x1814B4F80")]
		private void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x14B49F0", Offset = "0x14B3DF0", VA = "0x1814B49F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x14B4830", Offset = "0x14B3C30", VA = "0x1814B4830")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x14B6500", Offset = "0x14B5900", VA = "0x1814B6500")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x14B75B0", Offset = "0x14B69B0", VA = "0x1814B75B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14B7E30", Offset = "0x14B7230", VA = "0x1814B7E30")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x14B7CF0", Offset = "0x14B70F0", VA = "0x1814B7CF0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x14B7D30", Offset = "0x14B7130", VA = "0x1814B7D30")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x14B7D70", Offset = "0x14B7170", VA = "0x1814B7D70")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x14B7DB0", Offset = "0x14B71B0", VA = "0x1814B7DB0")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x14B7DF0", Offset = "0x14B71F0", VA = "0x1814B7DF0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x14B8700", Offset = "0x14B7B00", VA = "0x1814B8700")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x14B7C40", Offset = "0x14B7040", VA = "0x1814B7C40")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x14B7C80", Offset = "0x14B7080", VA = "0x1814B7C80")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x14B7E70", Offset = "0x14B7270", VA = "0x1814B7E70")]
		public void ResetRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x14B7F00", Offset = "0x14B7300", VA = "0x1814B7F00")]
		public void RotateTo(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x14B8740", Offset = "0x14B7B40", VA = "0x1814B8740")]
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
				[Cpp2IlInjected.Address(RVA = "0x16E1890", Offset = "0x16E0C90", VA = "0x1816E1890")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public Vector3 direction3D
			{
				[Cpp2IlInjected.Token(Token = "0x6000568")]
				[Cpp2IlInjected.Address(RVA = "0x16E17F0", Offset = "0x16E0BF0", VA = "0x1816E17F0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x16E1030", Offset = "0x16E0430", VA = "0x1816E1030")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(RVA = "0x16E17D0", Offset = "0x16E0BD0", VA = "0x1816E17D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16E0A90", Offset = "0x16DFE90", VA = "0x1816E0A90")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(RVA = "0x16E0BF0", Offset = "0x16DFFF0", VA = "0x1816E0BF0")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x16E0FB0", Offset = "0x16E03B0", VA = "0x1816E0FB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16EB290", Offset = "0x16EA690", VA = "0x1816EB290")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x16EB3A0", Offset = "0x16EA7A0", VA = "0x1816EB3A0")]
			public Range()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x14B8A50", Offset = "0x14B7E50", VA = "0x1814B8A50")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x14B89D0", Offset = "0x14B7DD0", VA = "0x1814B89D0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x14B8A10", Offset = "0x14B7E10", VA = "0x1814B8A10")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x14B8A90", Offset = "0x14B7E90", VA = "0x1814B8A90")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x14B8790", Offset = "0x14B7B90", VA = "0x1814B8790")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x14B87D0", Offset = "0x14B7BD0", VA = "0x1814B87D0")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x14B8AD0", Offset = "0x14B7ED0", VA = "0x1814B8AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x136DD30", Offset = "0x136D130", VA = "0x18136DD30")]
			public Map(Transform bone, Transform target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x1369070", Offset = "0x1368470", VA = "0x181369070")]
			public void StoreDefaultState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x136DB40", Offset = "0x136CF40", VA = "0x18136DB40")]
			public void FixTransform()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x136DBA0", Offset = "0x136CFA0", VA = "0x18136DBA0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public Map[] maps;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x161FA20", Offset = "0x161EE20", VA = "0x18161FA20", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x161FE70", Offset = "0x161F270", VA = "0x18161FE70", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x161FF00", Offset = "0x161F300", VA = "0x18161FF00", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x161FD40", Offset = "0x161F140", VA = "0x18161FD40", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x161FE80", Offset = "0x161F280", VA = "0x18161FE80")]
		private void StoreDefaultState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x161FDC0", Offset = "0x161F1C0", VA = "0x18161FDC0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x1620010", Offset = "0x161F410", VA = "0x181620010")]
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
		[Cpp2IlInjected.Address(RVA = "0x165B9A0", Offset = "0x165ADA0", VA = "0x18165B9A0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x165BBC0", Offset = "0x165AFC0", VA = "0x18165BBC0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x165BA70", Offset = "0x165AE70", VA = "0x18165BA70", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x165BE00", Offset = "0x165B200", VA = "0x18165BE00", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x165BC20", Offset = "0x165B020", VA = "0x18165BC20")]
		protected void StoreDefaultState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x1620010", Offset = "0x161F410", VA = "0x181620010")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3D060", Offset = "0xB3C460", VA = "0x180B3D060")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C2DA0", Offset = "0x14C21A0", VA = "0x1814C2DA0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x14C2D70", Offset = "0x14C2170", VA = "0x1814C2D70", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x14C2D50", Offset = "0x14C2150", VA = "0x1814C2D50", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x14C2DF0", Offset = "0x14C21F0", VA = "0x1814C2DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16EB780", Offset = "0x16EAB80", VA = "0x1816EB780")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x16EB3B0", Offset = "0x16EA7B0", VA = "0x1816EB3B0")]
			public void RecordVelocity()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x16EB4F0", Offset = "0x16EA8F0", VA = "0x1816EB4F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16E1AD0", Offset = "0x16E0ED0", VA = "0x1816E1AD0")]
			public Child(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x16E18B0", Offset = "0x16E0CB0", VA = "0x1816E18B0")]
			public void FixTransform(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x16E1A70", Offset = "0x16E0E70", VA = "0x1816E1A70")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x16F04B0", Offset = "0x16EF8B0", VA = "0x1816F04B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x16F0720", Offset = "0x16EFB20", VA = "0x1816F0720", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x14C5B60", Offset = "0x14C4F60", VA = "0x1814C5B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private bool ikUsed
		{
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x14C5A10", Offset = "0x14C4E10", VA = "0x1814C5A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x14C47A0", Offset = "0x14C3BA0", VA = "0x1814C47A0")]
		public void EnableRagdoll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x14C4650", Offset = "0x14C3A50", VA = "0x1814C4650")]
		public void DisableRagdoll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x14C5010", Offset = "0x14C4410", VA = "0x1814C5010")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x14C45E0", Offset = "0x14C39E0", VA = "0x1814C45E0")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x14C5580", Offset = "0x14C4980", VA = "0x1814C5580")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x14C4890", Offset = "0x14C3C90", VA = "0x1814C4890")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x14C4920", Offset = "0x14C3D20", VA = "0x1814C4920")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x14C45B0", Offset = "0x14C39B0", VA = "0x1814C45B0")]
		private void AfterLastIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x14C44E0", Offset = "0x14C38E0", VA = "0x1814C44E0")]
		private void AfterAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x14C4B90", Offset = "0x14C3F90", VA = "0x1814C4B90")]
		private void OnFinalPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x14C4C70", Offset = "0x14C4070", VA = "0x1814C4C70")]
		private void RagdollEnabler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x14C4FB0", Offset = "0x14C43B0", VA = "0x1814C4FB0")]
		private void RecordVelocities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x14C5520", Offset = "0x14C4920", VA = "0x1814C5520")]
		private void StoreLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x14C4820", Offset = "0x14C3C20", VA = "0x1814C4820")]
		private void FixTransforms(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x14C4A60", Offset = "0x14C3E60", VA = "0x1814C4A60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x14C5910", Offset = "0x14C4D10", VA = "0x1814C5910")]
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
			[Cpp2IlInjected.Address(RVA = "0x14CAA90", Offset = "0x14C9E90", VA = "0x1814CAA90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Vector3 crossAxis
		{
			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x14CAA20", Offset = "0x14C9E20", VA = "0x1814CAA20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool defaultLocalRotationOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x856040", Offset = "0x855440", VA = "0x180856040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0xB14820", Offset = "0xB13C20", VA = "0x180B14820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x14CA990", Offset = "0x14C9D90", VA = "0x1814CA990")]
		public void SetDefaultLocalRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x14CA9D0", Offset = "0x14C9DD0", VA = "0x1814CA9D0")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x14CA3A0", Offset = "0x14C97A0", VA = "0x1814CA3A0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x14CA0F0", Offset = "0x14C94F0", VA = "0x1814CA0F0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x14CA370", Offset = "0x14C9770", VA = "0x1814CA370")]
		public void Disable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x14CA270", Offset = "0x14C9670", VA = "0x1814CA270")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x14CA960", Offset = "0x14C9D60", VA = "0x1814CA960")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x14CA6E0", Offset = "0x14C9AE0", VA = "0x1814CA6E0")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x14CA7A0", Offset = "0x14C9BA0", VA = "0x1814CA7A0")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x14CA4E0", Offset = "0x14C98E0", VA = "0x1814CA4E0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x14CA9E0", Offset = "0x14C9DE0", VA = "0x1814CA9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C7A90", Offset = "0x14C6E90", VA = "0x1814C7A90")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x14C7A50", Offset = "0x14C6E50", VA = "0x1814C7A50")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x14C7AD0", Offset = "0x14C6ED0", VA = "0x1814C7AD0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x14C75A0", Offset = "0x14C69A0", VA = "0x1814C75A0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x14C75E0", Offset = "0x14C69E0", VA = "0x1814C75E0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x14C7850", Offset = "0x14C6C50", VA = "0x1814C7850")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x14C7B10", Offset = "0x14C6F10", VA = "0x1814C7B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C7EC0", Offset = "0x14C72C0", VA = "0x1814C7EC0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x14C7E80", Offset = "0x14C7280", VA = "0x1814C7E80")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x14C7F00", Offset = "0x14C7300", VA = "0x1814C7F00")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x14C7B60", Offset = "0x14C6F60", VA = "0x1814C7B60")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x14C7E40", Offset = "0x14C7240", VA = "0x1814C7E40", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x14C7BA0", Offset = "0x14C6FA0", VA = "0x1814C7BA0")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x14C7F40", Offset = "0x14C7340", VA = "0x1814C7F40")]
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
				[Cpp2IlInjected.Address(RVA = "0x18ACD30", Offset = "0x18AC130", VA = "0x1818ACD30")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			public Vector3 a
			{
				[Cpp2IlInjected.Token(Token = "0x60005D9")]
				[Cpp2IlInjected.Address(RVA = "0x18ACC60", Offset = "0x18AC060", VA = "0x1818ACC60")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public Vector3 b
			{
				[Cpp2IlInjected.Token(Token = "0x60005DA")]
				[Cpp2IlInjected.Address(RVA = "0x18ACCA0", Offset = "0x18AC0A0", VA = "0x1818ACCA0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public Vector3 c
			{
				[Cpp2IlInjected.Token(Token = "0x60005DB")]
				[Cpp2IlInjected.Address(RVA = "0x18ACCE0", Offset = "0x18AC0E0", VA = "0x1818ACCE0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public bool isValid
			{
				[Cpp2IlInjected.Token(Token = "0x60005DD")]
				[Cpp2IlInjected.Address(RVA = "0x18ACD20", Offset = "0x18AC120", VA = "0x1818ACD20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x18ACAB0", Offset = "0x18ABEB0", VA = "0x1818ACAB0")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0x18AC860", Offset = "0x18ABC60", VA = "0x1818AC860")]
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
			[Cpp2IlInjected.Address(RVA = "0x18AC5B0", Offset = "0x18AB9B0", VA = "0x1818AC5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C8BF0", Offset = "0x14C7FF0", VA = "0x1814C8BF0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x14C8BB0", Offset = "0x14C7FB0", VA = "0x1814C8BB0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x14C9E80", Offset = "0x14C9280", VA = "0x1814C9E80")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x14C7F90", Offset = "0x14C7390", VA = "0x1814C7F90")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x14C91E0", Offset = "0x14C85E0", VA = "0x1814C91E0")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x14C8770", Offset = "0x14C7B70", VA = "0x1814C8770", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x14C9AC0", Offset = "0x14C8EC0", VA = "0x1814C9AC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x14C8D60", Offset = "0x14C8160", VA = "0x1814C8D60")]
		public void ResetToDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x14C7FD0", Offset = "0x14C73D0", VA = "0x1814C7FD0")]
		public void BuildReachCones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x14C9270", Offset = "0x14C8670", VA = "0x1814C9270")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x14C8720", Offset = "0x14C7B20", VA = "0x1814C8720")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x14C8C30", Offset = "0x14C8030", VA = "0x1814C8C30")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x14C9EC0", Offset = "0x14C92C0", VA = "0x1814C9EC0")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x14C8870", Offset = "0x14C7C70", VA = "0x1814C8870")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x14C8580", Offset = "0x14C7980", VA = "0x1814C8580")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x14CA070", Offset = "0x14C9470", VA = "0x1814CA070")]
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
		[Cpp2IlInjected.Address(RVA = "0x136F150", Offset = "0x136E550", VA = "0x18136F150")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x136F110", Offset = "0x136E510", VA = "0x18136F110")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x136F1B0", Offset = "0x136E5B0", VA = "0x18136F1B0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x136ED10", Offset = "0x136E110", VA = "0x18136ED10")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x136F190", Offset = "0x136E590", VA = "0x18136F190")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x136ED50", Offset = "0x136E150", VA = "0x18136ED50", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x136EE30", Offset = "0x136E230", VA = "0x18136EE30")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x136F1F0", Offset = "0x136E5F0", VA = "0x18136F1F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x1374E90", Offset = "0x1374290", VA = "0x181374E90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x1374F70", Offset = "0x1374370", VA = "0x181374F70", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x15A57B0", Offset = "0x15A4BB0", VA = "0x1815A57B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x15A55A0", Offset = "0x15A49A0", VA = "0x1815A55A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x15A45A0", Offset = "0x15A39A0", VA = "0x1815A45A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x15A4430", Offset = "0x15A3830", VA = "0x1815A4430")]
		private void ApplyMinDistance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x15A52A0", Offset = "0x15A46A0", VA = "0x1815A52A0")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x15A56A0", Offset = "0x15A4AA0", VA = "0x1815A56A0")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x15A5710", Offset = "0x15A4B10", VA = "0x1815A5710")]
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
			[Cpp2IlInjected.Address(RVA = "0x136E580", Offset = "0x136D980", VA = "0x18136E580")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x92CB60", Offset = "0x92BF60", VA = "0x18092CB60")]
			public void SetAngleBuffer(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x136E7D0", Offset = "0x136DBD0", VA = "0x18136E7D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15A5A80", Offset = "0x15A4E80", VA = "0x1815A5A80")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x15A5B90", Offset = "0x15A4F90", VA = "0x1815A5B90")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x15A5C20", Offset = "0x15A5020", VA = "0x1815A5C20")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1367B40", Offset = "0x1366F40", VA = "0x181367B40")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x1367AE0", Offset = "0x1366EE0", VA = "0x181367AE0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x13681D0", Offset = "0x13675D0", VA = "0x1813681D0")]
			public Body()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x15A5DA0", Offset = "0x15A51A0", VA = "0x1815A5DA0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x15A5EF0", Offset = "0x15A52F0", VA = "0x1815A5EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15B9610", Offset = "0x15B8A10", VA = "0x1815B9610", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x15B9410", Offset = "0x15B8810", VA = "0x1815B9410", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x15B9660", Offset = "0x15B8A60", VA = "0x1815B9660")]
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
		[Cpp2IlInjected.Address(RVA = "0x15B9AD0", Offset = "0x15B8ED0", VA = "0x1815B9AD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x15B9680", Offset = "0x15B8A80", VA = "0x1815B9680")]
		private void BeforeIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x15B99B0", Offset = "0x15B8DB0", VA = "0x1815B99B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x15AD070", Offset = "0x15AC470", VA = "0x1815AD070")]
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
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x7530C0", Offset = "0x7524C0", VA = "0x1807530C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x160F2D0", Offset = "0x160E6D0", VA = "0x18160F2D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x160F1D0", Offset = "0x160E5D0", VA = "0x18160F1D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x160F060", Offset = "0x160E460", VA = "0x18160F060")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x160F470", Offset = "0x160E870", VA = "0x18160F470")]
		public void StoreDefaultPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x160EE00", Offset = "0x160E200", VA = "0x18160EE00")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x160F690", Offset = "0x160EA90", VA = "0x18160F690")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x160F9B0", Offset = "0x160EDB0", VA = "0x18160F9B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x160EDE0", Offset = "0x160E1E0", VA = "0x18160EDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x160EBC0", Offset = "0x160DFC0", VA = "0x18160EBC0")]
		public void Store(Transform[] T)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x160EA10", Offset = "0x160DE10", VA = "0x18160EA10")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x160ED60", Offset = "0x160E160", VA = "0x18160ED60")]
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
				[Cpp2IlInjected.Address(RVA = "0x136AF80", Offset = "0x136A380", VA = "0x18136AF80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			protected float crossFader
			{
				[Cpp2IlInjected.Token(Token = "0x600061A")]
				[Cpp2IlInjected.Address(RVA = "0x8CC370", Offset = "0x8CB770", VA = "0x1808CC370")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600061B")]
				[Cpp2IlInjected.Address(RVA = "0x8CC3E0", Offset = "0x8CB7E0", VA = "0x1808CC3E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B3")]
			protected float timer
			{
				[Cpp2IlInjected.Token(Token = "0x600061C")]
				[Cpp2IlInjected.Address(RVA = "0x92C730", Offset = "0x92BB30", VA = "0x18092C730")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600061D")]
				[Cpp2IlInjected.Address(RVA = "0x92CC30", Offset = "0x92C030", VA = "0x18092CC30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B4")]
			protected Vector3 force
			{
				[Cpp2IlInjected.Token(Token = "0x600061E")]
				[Cpp2IlInjected.Address(RVA = "0x136AF60", Offset = "0x136A360", VA = "0x18136AF60")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600061F")]
				[Cpp2IlInjected.Address(RVA = "0x136AF90", Offset = "0x136A390", VA = "0x18136AF90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B5")]
			protected Vector3 point
			{
				[Cpp2IlInjected.Token(Token = "0x6000620")]
				[Cpp2IlInjected.Address(RVA = "0x7300E0", Offset = "0x72F4E0", VA = "0x1807300E0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000621")]
				[Cpp2IlInjected.Address(RVA = "0x730160", Offset = "0x72F560", VA = "0x180730160")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x136AE40", Offset = "0x136A240", VA = "0x18136AE40")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x136AD70", Offset = "0x136A170", VA = "0x18136AD70")]
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
			[Cpp2IlInjected.Address(RVA = "0x136A990", Offset = "0x1369D90", VA = "0x18136A990")]
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
				[Cpp2IlInjected.Address(RVA = "0x18AB190", Offset = "0x18AA590", VA = "0x1818AB190")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600062D")]
				[Cpp2IlInjected.Address(RVA = "0x18AB300", Offset = "0x18AA700", VA = "0x1818AB300")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600062E")]
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x136AA00", Offset = "0x1369E00", VA = "0x18136AA00", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x136A9A0", Offset = "0x1369DA0", VA = "0x18136A9A0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x136AB50", Offset = "0x1369F50", VA = "0x18136AB50", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x136A990", Offset = "0x1369D90", VA = "0x18136A990")]
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
				[Cpp2IlInjected.Address(RVA = "0x18AB020", Offset = "0x18AA420", VA = "0x1818AB020")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000634")]
				[Cpp2IlInjected.Address(RVA = "0x18AB140", Offset = "0x18AA540", VA = "0x1818AB140")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000635")]
				[Cpp2IlInjected.Address(RVA = "0x18AB150", Offset = "0x18AA550", VA = "0x1818AB150")]
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
			[Cpp2IlInjected.Address(RVA = "0x136A690", Offset = "0x1369A90", VA = "0x18136A690", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x136A630", Offset = "0x1369A30", VA = "0x18136A630", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x136A730", Offset = "0x1369B30", VA = "0x18136A730", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x136A990", Offset = "0x1369D90", VA = "0x18136A990")]
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
			[Cpp2IlInjected.Address(RVA = "0x165DE60", Offset = "0x165D260", VA = "0x18165DE60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x165DD60", Offset = "0x165D160", VA = "0x18165DD60", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x165DAD0", Offset = "0x165CED0", VA = "0x18165DAD0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x15A5EF0", Offset = "0x15A52F0", VA = "0x1815A5EF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x8CC370", Offset = "0x8CB770", VA = "0x1808CC370")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600063A")]
				[Cpp2IlInjected.Address(RVA = "0x8CC3E0", Offset = "0x8CB7E0", VA = "0x1808CC3E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B7")]
			protected float timer
			{
				[Cpp2IlInjected.Token(Token = "0x600063B")]
				[Cpp2IlInjected.Address(RVA = "0x92C730", Offset = "0x92BB30", VA = "0x18092C730")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600063C")]
				[Cpp2IlInjected.Address(RVA = "0x92CC30", Offset = "0x92C030", VA = "0x18092CC30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B8")]
			protected Vector3 force
			{
				[Cpp2IlInjected.Token(Token = "0x600063D")]
				[Cpp2IlInjected.Address(RVA = "0x136AF60", Offset = "0x136A360", VA = "0x18136AF60")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600063E")]
				[Cpp2IlInjected.Address(RVA = "0x136AF90", Offset = "0x136A390", VA = "0x18136AF90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B9")]
			protected Vector3 point
			{
				[Cpp2IlInjected.Token(Token = "0x600063F")]
				[Cpp2IlInjected.Address(RVA = "0x7300E0", Offset = "0x72F4E0", VA = "0x1807300E0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000640")]
				[Cpp2IlInjected.Address(RVA = "0x730160", Offset = "0x72F560", VA = "0x180730160")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x136E040", Offset = "0x136D440", VA = "0x18136E040")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x136DF50", Offset = "0x136D350", VA = "0x18136DF50")]
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
			[Cpp2IlInjected.Address(RVA = "0x136A990", Offset = "0x1369D90", VA = "0x18136A990")]
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
				[Cpp2IlInjected.Address(RVA = "0x18AC740", Offset = "0x18ABB40", VA = "0x1818AC740")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600064C")]
				[Cpp2IlInjected.Address(RVA = "0x18AB300", Offset = "0x18AA700", VA = "0x1818AB300")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600064D")]
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x136E850", Offset = "0x136DC50", VA = "0x18136E850", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x136E7F0", Offset = "0x136DBF0", VA = "0x18136E7F0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x136EA70", Offset = "0x136DE70", VA = "0x18136EA70", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x136ECF0", Offset = "0x136E0F0", VA = "0x18136ECF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x18AE870", Offset = "0x18ADC70", VA = "0x1818AE870")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000653")]
				[Cpp2IlInjected.Address(RVA = "0x18AE960", Offset = "0x18ADD60", VA = "0x1818AE960")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000654")]
				[Cpp2IlInjected.Address(RVA = "0x18AE970", Offset = "0x18ADD70", VA = "0x1818AE970")]
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
			[Cpp2IlInjected.Address(RVA = "0x136F260", Offset = "0x136E660", VA = "0x18136F260", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x136F200", Offset = "0x136E600", VA = "0x18136F200", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x136F380", Offset = "0x136E780", VA = "0x18136F380", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x136A990", Offset = "0x1369D90", VA = "0x18136A990")]
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
		[Cpp2IlInjected.Address(RVA = "0x165D9E0", Offset = "0x165CDE0", VA = "0x18165D9E0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x165D740", Offset = "0x165CB40", VA = "0x18165D740")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x15A5EF0", Offset = "0x15A52F0", VA = "0x1815A5EF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16DF970", Offset = "0x16DED70", VA = "0x1816DF970")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x16DFA50", Offset = "0x16DEE50", VA = "0x1816DFA50")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0x16DFFB0", Offset = "0x16DF3B0", VA = "0x1816DFFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16AED90", Offset = "0x16AE190", VA = "0x1816AED90")]
		public void ResetBodies()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x16AECC0", Offset = "0x16AE0C0", VA = "0x1816AECC0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x15A5EF0", Offset = "0x15A52F0", VA = "0x1815A5EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x14BB620", Offset = "0x14BAA20", VA = "0x1814BB620")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x14BB4E0", Offset = "0x14BA8E0", VA = "0x1814BB4E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x14BA880", Offset = "0x14B9C80", VA = "0x1814BA880")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x14BA710", Offset = "0x14B9B10", VA = "0x1814BA710")]
		private void ApplyMinDistance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x14BB240", Offset = "0x14BA640", VA = "0x1814BB240")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x14BB5B0", Offset = "0x14BA9B0", VA = "0x1814BB5B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16EA140", Offset = "0x16E9540", VA = "0x1816EA140")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x16EA310", Offset = "0x16E9710", VA = "0x1816EA310")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x16EA390", Offset = "0x16E9790", VA = "0x1816EA390")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x16F0930", Offset = "0x16EFD30", VA = "0x1816F0930", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x16F0AC0", Offset = "0x16EFEC0", VA = "0x1816F0AC0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x14C00F0", Offset = "0x14BF4F0", VA = "0x1814C00F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void OnModifyOffset();

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x14C0470", Offset = "0x14BF870", VA = "0x1814C0470", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x14C0200", Offset = "0x14BF600", VA = "0x1814C0200")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x14C0270", Offset = "0x14BF670", VA = "0x1814C0270")]
		private void ModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x14C0110", Offset = "0x14BF510", VA = "0x1814C0110")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x14C0350", Offset = "0x14BF750", VA = "0x1814C0350", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x14BFDF0", Offset = "0x14BF1F0", VA = "0x1814BFDF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x16F0760", Offset = "0x16EFB60", VA = "0x1816F0760", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0x16F08F0", Offset = "0x16EFCF0", VA = "0x1816F08F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x14C00F0", Offset = "0x14BF4F0", VA = "0x1814C00F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void OnModifyOffset();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x14C0070", Offset = "0x14BF470", VA = "0x1814C0070", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x14BFE00", Offset = "0x14BF200", VA = "0x1814BFE00")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x14BFE70", Offset = "0x14BF270", VA = "0x1814BFE70")]
		private void ModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x14BFF50", Offset = "0x14BF350", VA = "0x1814BFF50", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x14BFDF0", Offset = "0x14BF1F0", VA = "0x1814BFDF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16E1B60", Offset = "0x16E0F60", VA = "0x1816E1B60")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public EffectorLink()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public EffectorLink[] effectorLinks;

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x14C04F0", Offset = "0x14BF8F0", VA = "0x1814C04F0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x14C05E0", Offset = "0x14BF9E0", VA = "0x1814C05E0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x14C06B0", Offset = "0x14BFAB0", VA = "0x1814C06B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16DEB20", Offset = "0x16DDF20", VA = "0x1816DEB20")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0x16DE650", Offset = "0x16DDA50", VA = "0x1816DE650")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x16DE820", Offset = "0x16DDC20", VA = "0x1816DE820")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x16DEEB0", Offset = "0x16DE2B0", VA = "0x1816DEEB0")]
			public Avoider()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x14C1460", Offset = "0x14C0860", VA = "0x1814C1460", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x14BFDF0", Offset = "0x14BF1F0", VA = "0x1814BFDF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18AD020", Offset = "0x18AC420", VA = "0x1818AD020")]
			public void Start()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0x18ACD70", Offset = "0x18AC170", VA = "0x1818ACD70")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x18AD0D0", Offset = "0x18AC4D0", VA = "0x1818AD0D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x14C7240", Offset = "0x14C6640", VA = "0x1814C7240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private IKEffector primaryHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x14C7260", Offset = "0x14C6660", VA = "0x1814C7260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private IKEffector secondaryHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x14C7300", Offset = "0x14C6700", VA = "0x1814C7300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		private Transform primaryHand
		{
			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0x14C72B0", Offset = "0x14C66B0", VA = "0x1814C72B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		private Transform secondaryHand
		{
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x14C7350", Offset = "0x14C6750", VA = "0x1814C7350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x14C7190", Offset = "0x14C6590", VA = "0x1814C7190")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x14C5EC0", Offset = "0x14C52C0", VA = "0x1814C5EC0")]
		public void Fire(float magnitude)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x14C6270", Offset = "0x14C5670", VA = "0x1814C6270", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x14C5D10", Offset = "0x14C5110", VA = "0x1814C5D10")]
		private void AfterFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x14C5CC0", Offset = "0x14C50C0", VA = "0x1814C5CC0")]
		private void AfterAimIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x14C6060", Offset = "0x14C5460", VA = "0x1814C6060", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x14C71C0", Offset = "0x14C65C0", VA = "0x1814C71C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1370D20", Offset = "0x1370120", VA = "0x181370D20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x1370C20", Offset = "0x1370020", VA = "0x181370C20")]
		private void RotateShoulders()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x13706F0", Offset = "0x136FAF0", VA = "0x1813706F0")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x1370590", Offset = "0x136F990", VA = "0x181370590")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x13705D0", Offset = "0x136F9D0", VA = "0x1813705D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x1370E20", Offset = "0x1370220", VA = "0x181370E20")]
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
			[Cpp2IlInjected.Address(RVA = "0x18AE9B0", Offset = "0x18ADDB0", VA = "0x1818AE9B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x18AEB00", Offset = "0x18ADF00", VA = "0x1818AEB00")]
				public Target(Transform t)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006B5")]
				[Cpp2IlInjected.Address(RVA = "0x18AEA90", Offset = "0x18ADE90", VA = "0x1818AEA90")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public CalibrationData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x137C9E0", Offset = "0x137BDE0", VA = "0x18137C9E0")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x137CA60", Offset = "0x137BE60", VA = "0x18137CA60")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x1379760", Offset = "0x1378B60", VA = "0x181379760")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x13795A0", Offset = "0x13789A0", VA = "0x1813795A0")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x137A7C0", Offset = "0x1379BC0", VA = "0x18137A7C0")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x1378A30", Offset = "0x1377E30", VA = "0x181378A30")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x1379780", Offset = "0x1378B80", VA = "0x181379780")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x1379310", Offset = "0x1378710", VA = "0x181379310")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x137A550", Offset = "0x1379950", VA = "0x18137A550")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x1378420", Offset = "0x1377820", VA = "0x181378420")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x1377880", Offset = "0x1376C80", VA = "0x181377880")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x1378120", Offset = "0x1377520", VA = "0x181378120")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x1377BD0", Offset = "0x1376FD0", VA = "0x181377BD0")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x137C800", Offset = "0x137BC00", VA = "0x18137C800")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x137C2F0", Offset = "0x137B6F0", VA = "0x18137C2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x137CC60", Offset = "0x137C060", VA = "0x18137CC60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x137CCB0", Offset = "0x137C0B0", VA = "0x18137CCB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x137CAD0", Offset = "0x137BED0", VA = "0x18137CAD0")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x137CE70", Offset = "0x137C270", VA = "0x18137CE70")]
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
			[Cpp2IlInjected.Address(RVA = "0x137E3C0", Offset = "0x137D7C0", VA = "0x18137E3C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0x137E3E0", Offset = "0x137D7E0", VA = "0x18137E3E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x137D770", Offset = "0x137CB70", VA = "0x18137D770")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x137DA70", Offset = "0x137CE70", VA = "0x18137DA70")]
		public void Calibrate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x137D890", Offset = "0x137CC90", VA = "0x18137D890")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x137DE10", Offset = "0x137D210", VA = "0x18137DE10")]
		private void OnPreUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x137DCF0", Offset = "0x137D0F0", VA = "0x18137DCF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
			[Cpp2IlInjected.Address(RVA = "0x136DDE0", Offset = "0x136D1E0", VA = "0x18136DDE0")]
			public void Apply(Animator animator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x161ACB0", Offset = "0x161A0B0", VA = "0x18161ACB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x161AB50", Offset = "0x1619F50", VA = "0x18161AB50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x161ABC0", Offset = "0x1619FC0", VA = "0x18161ABC0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x15A4370", Offset = "0x15A3770", VA = "0x1815A4370")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x15A5C80", Offset = "0x15A5080", VA = "0x1815A5C80")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x15A5D60", Offset = "0x15A5160", VA = "0x1815A5D60")]
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
		[Cpp2IlInjected.Address(RVA = "0x1370550", Offset = "0x136F950", VA = "0x181370550")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x13702A0", Offset = "0x136F6A0", VA = "0x1813702A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x1371490", Offset = "0x1370890", VA = "0x181371490")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x1370ED0", Offset = "0x13702D0", VA = "0x181370ED0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x1371220", Offset = "0x1370620", VA = "0x181371220")]
		private void Pose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x1371020", Offset = "0x1370420", VA = "0x181371020")]
		private void LimitAimTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x1370E40", Offset = "0x1370240", VA = "0x181370E40")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x13714D0", Offset = "0x13708D0", VA = "0x1813714D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x13729A0", Offset = "0x1371DA0", VA = "0x1813729A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x1372760", Offset = "0x1371B60", VA = "0x181372760")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x1372C50", Offset = "0x1372050", VA = "0x181372C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x15AE830", Offset = "0x15ADC30", VA = "0x1815AE830")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x15AF040", Offset = "0x15AE440", VA = "0x1815AF040")]
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
			[Cpp2IlInjected.Address(RVA = "0x14BE520", Offset = "0x14BD920", VA = "0x1814BE520")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0x14BE540", Offset = "0x14BD940", VA = "0x1814BE540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x14BDA80", Offset = "0x14BCE80", VA = "0x1814BDA80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x14BDAC0", Offset = "0x14BCEC0", VA = "0x1814BDAC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x14BD560", Offset = "0x14BC960", VA = "0x1814BD560")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x14BD6E0", Offset = "0x14BCAE0", VA = "0x1814BD6E0")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x14BE4D0", Offset = "0x14BD8D0", VA = "0x1814BE4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x14BBBB0", Offset = "0x14BAFB0", VA = "0x1814BBBB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x14BB8B0", Offset = "0x14BACB0", VA = "0x1814BB8B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x14BBB90", Offset = "0x14BAF90", VA = "0x1814BBB90")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x16F0B00", Offset = "0x16EFF00", VA = "0x1816F0B00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x16F0F20", Offset = "0x16F0320", VA = "0x1816F0F20", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x14BD0A0", Offset = "0x14BC4A0", VA = "0x1814BD0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x14BD0C0", Offset = "0x14BC4C0", VA = "0x1814BD0C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x14BD120", Offset = "0x14BC520", VA = "0x1814BD120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x14BBE50", Offset = "0x14BB250", VA = "0x1814BBE50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x14BBC30", Offset = "0x14BB030", VA = "0x1814BBC30")]
		private void AfterIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x14BC530", Offset = "0x14BB930", VA = "0x1814BC530")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x14BC0B0", Offset = "0x14BB4B0", VA = "0x1814BC0B0")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x14BC9E0", Offset = "0x14BBDE0", VA = "0x1814BC9E0")]
		private void UpdatePosition(float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x14BCCB0", Offset = "0x14BC0B0", VA = "0x1814BCCB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x14BC930", Offset = "0x14BBD30", VA = "0x1814BC930")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x14BD020", Offset = "0x14BC420", VA = "0x1814BD020")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BD170", Offset = "0x14BC570", VA = "0x1814BD170")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x14BD230", Offset = "0x14BC630", VA = "0x1814BD230")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x15A6690", Offset = "0x15A5A90", VA = "0x1815A6690", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x15A5F00", Offset = "0x15A5300", VA = "0x1815A5F00")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x15A6240", Offset = "0x15A5640", VA = "0x1815A6240", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x15A6190", Offset = "0x15A5590", VA = "0x1815A6190")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x15A5EF0", Offset = "0x15A52F0", VA = "0x1815A5EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15A7E20", Offset = "0x15A7220", VA = "0x1815A7E20", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x15A7B90", Offset = "0x15A6F90", VA = "0x1815A7B90")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x15A7910", Offset = "0x15A6D10", VA = "0x1815A7910", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x15A7E70", Offset = "0x15A7270", VA = "0x1815A7E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x15A7670", Offset = "0x15A6A70", VA = "0x1815A7670", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x15A6D70", Offset = "0x15A6170", VA = "0x1815A6D70", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x15A7510", Offset = "0x15A6910", VA = "0x1815A7510")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x15A66B0", Offset = "0x15A5AB0", VA = "0x1815A66B0")]
		private void AimIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x15A6710", Offset = "0x15A5B10", VA = "0x1815A6710")]
		private void FBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x15A7140", Offset = "0x15A6540", VA = "0x1815A7140")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x15A6B10", Offset = "0x15A5F10", VA = "0x1815A6B10")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x15A7010", Offset = "0x15A6410", VA = "0x1815A7010")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x15A78E0", Offset = "0x15A6CE0", VA = "0x1815A78E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15BB980", Offset = "0x15BAD80", VA = "0x1815BB980", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x15BB550", Offset = "0x15BA950", VA = "0x1815BB550", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x15BB7C0", Offset = "0x15BABC0", VA = "0x1815BB7C0")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x15BBA50", Offset = "0x15BAE50", VA = "0x1815BBA50")]
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
			[Cpp2IlInjected.Address(RVA = "0x15BD280", Offset = "0x15BC680", VA = "0x1815BD280")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		private static Vector3 inputVectorRaw
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x15BD200", Offset = "0x15BC600", VA = "0x1815BD200")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x15BD190", Offset = "0x15BC590", VA = "0x1815BD190")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x15BCE60", Offset = "0x15BC260", VA = "0x1815BCE60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x160FA10", Offset = "0x160EE10", VA = "0x18160FA10", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x15A5EF0", Offset = "0x15A52F0", VA = "0x1815A5EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16103C0", Offset = "0x160F7C0", VA = "0x1816103C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x1610480", Offset = "0x160F880", VA = "0x181610480")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x1610300", Offset = "0x160F700", VA = "0x181610300")]
		private void SetEffectorWeights(float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x1610AC0", Offset = "0x160FEC0", VA = "0x181610AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x136DAB0", Offset = "0x136CEB0", VA = "0x18136DAB0")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x136DB30", Offset = "0x136CF30", VA = "0x18136DB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x1616270", Offset = "0x1615670", VA = "0x181616270")]
		public void UpdateSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x16161E0", Offset = "0x16155E0", VA = "0x1816161E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x16163F0", Offset = "0x16157F0", VA = "0x1816163F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x1616400", Offset = "0x1615800", VA = "0x181616400")]
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
		[Cpp2IlInjected.Address(RVA = "0x1616410", Offset = "0x1615810", VA = "0x181616410")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x1616470", Offset = "0x1615870", VA = "0x181616470")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x1616760", Offset = "0x1615B60", VA = "0x181616760")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x1616550", Offset = "0x1615950", VA = "0x181616550")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x161A0E0", Offset = "0x16194E0", VA = "0x18161A0E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x161AAB0", Offset = "0x1619EB0", VA = "0x18161AAB0")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x161A1D0", Offset = "0x16195D0", VA = "0x18161A1D0")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x161A980", Offset = "0x1619D80", VA = "0x18161A980")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x161C1A0", Offset = "0x161B5A0", VA = "0x18161C1A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x161B120", Offset = "0x161A520", VA = "0x18161B120")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x161B130", Offset = "0x161A530", VA = "0x18161B130")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x161AD00", Offset = "0x161A100", VA = "0x18161AD00")]
		private void Aiming()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x161B250", Offset = "0x161A650", VA = "0x18161B250")]
		private void LookDownTheSight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x161BF20", Offset = "0x161B320", VA = "0x18161BF20")]
		private void RotateCharacter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x161C3A0", Offset = "0x161B7A0", VA = "0x18161C3A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x161C490", Offset = "0x161B890", VA = "0x18161C490")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x161C510", Offset = "0x161B910", VA = "0x18161C510")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x161C3D0", Offset = "0x161B7D0", VA = "0x18161C3D0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x161C600", Offset = "0x161BA00", VA = "0x18161C600")]
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
		[Cpp2IlInjected.Address(RVA = "0x165D290", Offset = "0x165C690", VA = "0x18165D290")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x165D1C0", Offset = "0x165C5C0", VA = "0x18165D1C0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x15AD070", Offset = "0x15AC470", VA = "0x1815AD070")]
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
		[Cpp2IlInjected.Address(RVA = "0x165E3A0", Offset = "0x165D7A0", VA = "0x18165E3A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x165DF30", Offset = "0x165D330", VA = "0x18165DF30")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x165E520", Offset = "0x165D920", VA = "0x18165E520")]
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
		[Cpp2IlInjected.Address(RVA = "0x16AF0F0", Offset = "0x16AE4F0", VA = "0x1816AF0F0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x16AEF20", Offset = "0x16AE320", VA = "0x1816AEF20")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x16AF1A0", Offset = "0x16AE5A0", VA = "0x1816AF1A0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x14B3310", Offset = "0x14B2710", VA = "0x1814B3310")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x14B3360", Offset = "0x14B2760", VA = "0x1814B3360")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
				[Cpp2IlInjected.Address(RVA = "0x16EAFA0", Offset = "0x16EA3A0", VA = "0x1816EAFA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x1610E30", Offset = "0x1610230", VA = "0x181610E30")]
			public void Initiate()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x16EA660", Offset = "0x16E9A60", VA = "0x1816EA660")]
			public void Update(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x16EA400", Offset = "0x16E9800", VA = "0x1816EA400")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x16EAF70", Offset = "0x16EA370", VA = "0x1816EAF70")]
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
		[Cpp2IlInjected.Address(RVA = "0x14B9B30", Offset = "0x14B8F30", VA = "0x1814B9B30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x14B9AD0", Offset = "0x14B8ED0", VA = "0x1814B9AD0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x14B9B70", Offset = "0x14B8F70", VA = "0x1814B9B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x16D9790", Offset = "0x16D8B90", VA = "0x1816D9790")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x16D98C0", Offset = "0x16D8CC0", VA = "0x1816D98C0")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x16D95E0", Offset = "0x16D89E0", VA = "0x1816D95E0")]
			public void SetPosition(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x16D96E0", Offset = "0x16D8AE0", VA = "0x1816D96E0")]
			public void SetRotation(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000755")]
			[Cpp2IlInjected.Address(RVA = "0x16D9900", Offset = "0x16D8D00", VA = "0x1816D9900")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BEBE0", Offset = "0x14BDFE0", VA = "0x1814BEBE0", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x14BE8C0", Offset = "0x14BDCC0", VA = "0x1814BE8C0")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x14BEA90", Offset = "0x14BDE90", VA = "0x1814BEA90", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x14BE820", Offset = "0x14BDC20", VA = "0x1814BE820")]
		private void AfterIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x14BE960", Offset = "0x14BDD60", VA = "0x1814BE960", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x14BECD0", Offset = "0x14BE0D0", VA = "0x1814BECD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BE550", Offset = "0x14BD950", VA = "0x1814BE550")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x14BE750", Offset = "0x14BDB50", VA = "0x1814BE750")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x14BE5D0", Offset = "0x14BD9D0", VA = "0x1814BE5D0")]
		private void SwingStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x14BE810", Offset = "0x14BDC10", VA = "0x1814BE810")]
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
			[Cpp2IlInjected.Address(RVA = "0xD83730", Offset = "0xD82B30", VA = "0x180D83730")]
			public EffectorLink()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public EffectorLink[] effectorLinks;

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x14BFCA0", Offset = "0x14BF0A0", VA = "0x1814BFCA0", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x14BFA50", Offset = "0x14BEE50", VA = "0x1814BFA50", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x14BFDF0", Offset = "0x14BF1F0", VA = "0x1814BFDF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C1060", Offset = "0x14C0460", VA = "0x1814C1060")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x14C0710", Offset = "0x14BFB10", VA = "0x1814C0710")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x14C1410", Offset = "0x14C0810", VA = "0x1814C1410")]
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
			[Cpp2IlInjected.Address(RVA = "0x14C2280", Offset = "0x14C1680", VA = "0x1814C2280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private bool holdingLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(RVA = "0x14C2120", Offset = "0x14C1520", VA = "0x1814C2120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private bool holdingRight
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x14C21D0", Offset = "0x14C15D0", VA = "0x1814C21D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x14C1A40", Offset = "0x14C0E40", VA = "0x1814C1A40")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void RotatePivot();

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x14C1F20", Offset = "0x14C1320", VA = "0x1814C1F20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x14C1CA0", Offset = "0x14C10A0", VA = "0x1814C1CA0")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x14C1E40", Offset = "0x14C1240", VA = "0x1814C1E40")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x14C18F0", Offset = "0x14C0CF0", VA = "0x1814C18F0")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x14C14E0", Offset = "0x14C08E0", VA = "0x1814C14E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x14C16C0", Offset = "0x14C0AC0", VA = "0x1814C16C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x14C2110", Offset = "0x14C1510", VA = "0x1814C2110")]
		protected PickUp2Handed()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	public class PickUpBox : PickUp2Handed
	{
		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x14C22B0", Offset = "0x14C16B0", VA = "0x1814C22B0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x14C2110", Offset = "0x14C1510", VA = "0x1814C2110")]
		public PickUpBox()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	public class PickUpSphere : PickUp2Handed
	{
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x14C2500", Offset = "0x14C1900", VA = "0x1814C2500", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x14C2110", Offset = "0x14C1510", VA = "0x1814C2110")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C40F0", Offset = "0x14C34F0", VA = "0x1814C40F0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x14C4140", Offset = "0x14C3540", VA = "0x1814C4140")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C5C20", Offset = "0x14C5020", VA = "0x1814C5C20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x14C5C70", Offset = "0x14C5070", VA = "0x1814C5C70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x14C5BD0", Offset = "0x14C4FD0", VA = "0x1814C5BD0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x14BFDF0", Offset = "0x14BF1F0", VA = "0x1814BFDF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x18AED70", Offset = "0x18AE170", VA = "0x1818AED70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x18AEF60", Offset = "0x18AE360", VA = "0x1818AEF60", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C74D0", Offset = "0x14C68D0", VA = "0x1814C74D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x14C73A0", Offset = "0x14C67A0", VA = "0x1814C73A0")]
		private void OnPickUp(Transform t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x14C7450", Offset = "0x14C6850", VA = "0x1814C7450")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x14BFDF0", Offset = "0x14BF1F0", VA = "0x1814BFDF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x18AEBC0", Offset = "0x18ADFC0", VA = "0x1818AEBC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x18AED30", Offset = "0x18AE130", VA = "0x1818AED30", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x1372000", Offset = "0x1371400", VA = "0x181372000")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x1371F90", Offset = "0x1371390", VA = "0x181371F90")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
			[Cpp2IlInjected.Address(RVA = "0x18AB640", Offset = "0x18AAA40", VA = "0x1818AB640")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x18AB510", Offset = "0x18AA910", VA = "0x1818AB510")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x18ABD30", Offset = "0x18AB130", VA = "0x1818ABD30")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x18ABBC0", Offset = "0x18AAFC0", VA = "0x1818ABBC0")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x18ABAC0", Offset = "0x18AAEC0", VA = "0x1818ABAC0")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x18ABA40", Offset = "0x18AAE40", VA = "0x1818ABA40")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x18ABB40", Offset = "0x18AAF40", VA = "0x1818ABB40")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x18AB320", Offset = "0x18AA720", VA = "0x1818AB320")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x18AC570", Offset = "0x18AB970", VA = "0x1818AC570")]
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
		[Cpp2IlInjected.Address(RVA = "0x1372DF0", Offset = "0x13721F0", VA = "0x181372DF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x1372CA0", Offset = "0x13720A0", VA = "0x181372CA0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x1372D20", Offset = "0x1372120", VA = "0x181372D20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x1372E60", Offset = "0x1372260", VA = "0x181372E60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x1372EA0", Offset = "0x13722A0", VA = "0x181372EA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x1373000", Offset = "0x1372400", VA = "0x181373000")]
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
		[Cpp2IlInjected.Address(RVA = "0x1374AE0", Offset = "0x1373EE0", VA = "0x181374AE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x13746B0", Offset = "0x1373AB0", VA = "0x1813746B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x13745B0", Offset = "0x13739B0", VA = "0x1813745B0")]
		private void AfterFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x13749C0", Offset = "0x1373DC0", VA = "0x1813749C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x1375490", Offset = "0x1374890", VA = "0x181375490", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x1375330", Offset = "0x1374730", VA = "0x181375330")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x1375580", Offset = "0x1374980", VA = "0x181375580")]
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
		[Cpp2IlInjected.Address(RVA = "0x1621430", Offset = "0x1620830", VA = "0x181621430")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x16213A0", Offset = "0x16207A0", VA = "0x1816213A0")]
		public void Activate(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x16F0F60", Offset = "0x16F0360", VA = "0x1816F0F60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x16F10D0", Offset = "0x16F04D0", VA = "0x1816F10D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C2B40", Offset = "0x14C1F40", VA = "0x1814C2B40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x14C2700", Offset = "0x14C1B00", VA = "0x1814C2700")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x14C2CB0", Offset = "0x14C20B0", VA = "0x1814C2CB0")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x14C2990", Offset = "0x14C1D90", VA = "0x1814C2990")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x14C2A70", Offset = "0x14C1E70", VA = "0x1814C2A70")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x14C2D20", Offset = "0x14C2120", VA = "0x1814C2D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x15AD010", Offset = "0x15AC410", VA = "0x1815AD010")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x15ACF40", Offset = "0x15AC340", VA = "0x1815ACF40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x15AD070", Offset = "0x15AC470", VA = "0x1815AD070")]
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
			[Cpp2IlInjected.Address(RVA = "0x18AC5F0", Offset = "0x18AB9F0", VA = "0x1818AC5F0")]
			public void AimAt(Transform target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1373390", Offset = "0x1372790", VA = "0x181373390")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x165D550", Offset = "0x165C950", VA = "0x18165D550")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x165D480", Offset = "0x165C880", VA = "0x18165D480")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x15AD070", Offset = "0x15AC470", VA = "0x1815AD070")]
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
		[Cpp2IlInjected.Address(RVA = "0x1377300", Offset = "0x1376700", VA = "0x181377300")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x1377580", Offset = "0x1376980", VA = "0x181377580")]
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
		[Cpp2IlInjected.Address(RVA = "0x13775F0", Offset = "0x13769F0", VA = "0x1813775F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x1377810", Offset = "0x1376C10", VA = "0x181377810")]
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
		[Cpp2IlInjected.Address(RVA = "0x137D6D0", Offset = "0x137CAD0", VA = "0x18137D6D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x137D4E0", Offset = "0x137C8E0", VA = "0x18137D4E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x137D740", Offset = "0x137CB40", VA = "0x18137D740")]
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
		[Cpp2IlInjected.Address(RVA = "0x137CE90", Offset = "0x137C290", VA = "0x18137CE90")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x137D4B0", Offset = "0x137C8B0", VA = "0x18137D4B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x15BAD50", Offset = "0x15BA150", VA = "0x1815BAD50", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x15BACE0", Offset = "0x15BA0E0", VA = "0x1815BACE0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x15BB060", Offset = "0x15BA460", VA = "0x1815BB060", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x15BADA0", Offset = "0x15BA1A0", VA = "0x1815BADA0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x15BACD0", Offset = "0x15BA0D0", VA = "0x1815BACD0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x15BADB0", Offset = "0x15BA1B0", VA = "0x1815BADB0")]
		private void SmoothFollow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x15BB210", Offset = "0x15BA610", VA = "0x1815BB210")]
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
		[Cpp2IlInjected.Address(RVA = "0x15BB370", Offset = "0x15BA770", VA = "0x1815BB370", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x15BB230", Offset = "0x15BA630", VA = "0x1815BB230", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x15BB3D0", Offset = "0x15BA7D0", VA = "0x1815BB3D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x15BB210", Offset = "0x15BA610", VA = "0x1815BB210")]
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
			[Cpp2IlInjected.Address(RVA = "0x15BC1C0", Offset = "0x15BB5C0", VA = "0x1815BC1C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x15BBC00", Offset = "0x15BB000", VA = "0x1815BBC00", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x15BBA80", Offset = "0x15BAE80", VA = "0x1815BBA80", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x15BBC90", Offset = "0x15BB090", VA = "0x1815BBC90", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x15BBAC0", Offset = "0x15BAEC0", VA = "0x1815BBAC0")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x15BBA50", Offset = "0x15BAE50", VA = "0x1815BBA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x15BC2A0", Offset = "0x15BB6A0", VA = "0x1815BC2A0")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x15BCBF0", Offset = "0x15BBFF0", VA = "0x1815BCBF0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x15BC4F0", Offset = "0x15BB8F0", VA = "0x1815BC4F0", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x15BACE0", Offset = "0x15BA0E0", VA = "0x1815BACE0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x15BC800", Offset = "0x15BBC00", VA = "0x1815BC800")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x15BCA30", Offset = "0x15BBE30", VA = "0x1815BCA30")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x15BC7D0", Offset = "0x15BBBD0", VA = "0x1815BC7D0")]
		protected void HighFriction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x15BCE00", Offset = "0x15BC200", VA = "0x1815BCE00")]
		protected void ZeroFriction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x15BC460", Offset = "0x15BB860", VA = "0x1815BC460")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x15BCE30", Offset = "0x15BC230", VA = "0x1815BCE30")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x1374D10", Offset = "0x1374110", VA = "0x181374D10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x1374E50", Offset = "0x1374250", VA = "0x181374E50", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x723700", Offset = "0x722B00", VA = "0x180723700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x12C9330", Offset = "0x12C8730", VA = "0x1812C9330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x15BF8B0", Offset = "0x15BECB0", VA = "0x1815BF8B0", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x15BF380", Offset = "0x15BE780", VA = "0x1815BF380")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x15BF250", Offset = "0x15BE650", VA = "0x1815BF250", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x15BD3A0", Offset = "0x15BC7A0", VA = "0x1815BD3A0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x15BFA50", Offset = "0x15BEE50", VA = "0x1815BFA50", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x15BEB00", Offset = "0x15BDF00", VA = "0x1815BEB00", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x15BEBE0", Offset = "0x15BDFE0", VA = "0x1815BEBE0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x15BFB10", Offset = "0x15BEF10", VA = "0x1815BFB10")]
		private void WallRun()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x15BD300", Offset = "0x15BC700", VA = "0x1815BD300")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x15BDFB0", Offset = "0x15BD3B0", VA = "0x1815BDFB0")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x15BF420", Offset = "0x15BE820", VA = "0x1815BF420", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x15BDDA0", Offset = "0x15BD1A0", VA = "0x1815BDDA0")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x15BE830", Offset = "0x15BDC30", VA = "0x1815BE830", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x15BE7A0", Offset = "0x15BDBA0", VA = "0x1815BE7A0")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__75))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x15BE2B0", Offset = "0x15BD6B0", VA = "0x1815BE2B0")]
		private void GroundCheck()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x15C03B0", Offset = "0x15BF7B0", VA = "0x1815C03B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x856040", Offset = "0x855440", VA = "0x180856040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0xB14820", Offset = "0xB13C20", VA = "0x180B14820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x1371D00", Offset = "0x1371100", VA = "0x181371D00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x1371D90", Offset = "0x1371190", VA = "0x181371D90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x1371630", Offset = "0x1370A30", VA = "0x181371630")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x1371950", Offset = "0x1370D50", VA = "0x181371950")]
		private void Rotate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x1371670", Offset = "0x1370A70", VA = "0x181371670")]
		private void Move()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x1371570", Offset = "0x1370970", VA = "0x181371570")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x13714F0", Offset = "0x13708F0", VA = "0x1813714F0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x1371DF0", Offset = "0x13711F0", VA = "0x181371DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1374FE0", Offset = "0x13743E0", VA = "0x181374FE0", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x1375050", Offset = "0x1374450", VA = "0x181375050", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x1374FB0", Offset = "0x13743B0", VA = "0x181374FB0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x1375310", Offset = "0x1374710", VA = "0x181375310")]
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
		[Cpp2IlInjected.Address(RVA = "0x13755A0", Offset = "0x13749A0", VA = "0x1813755A0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x13755E0", Offset = "0x13749E0", VA = "0x1813755E0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x1375910", Offset = "0x1374D10", VA = "0x181375910")]
		public UserControlThirdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x15A7EA0", Offset = "0x15A72A0", VA = "0x1815A7EA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x1371EC0", Offset = "0x13712C0", VA = "0x181371EC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x1371E10", Offset = "0x1371210", VA = "0x181371E10")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x1371F80", Offset = "0x1371380", VA = "0x181371F80")]
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
			[Cpp2IlInjected.Address(RVA = "0x14BFA20", Offset = "0x14BEE20", VA = "0x1814BFA20")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000811")]
			[Cpp2IlInjected.Address(RVA = "0x14BFA40", Offset = "0x14BEE40", VA = "0x1814BFA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public State state
		{
			[Cpp2IlInjected.Token(Token = "0x6000812")]
			[Cpp2IlInjected.Address(RVA = "0x77F5B0", Offset = "0x77E9B0", VA = "0x18077F5B0")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x85FD40", Offset = "0x85F140", VA = "0x18085FD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x14BF160", Offset = "0x14BE560", VA = "0x1814BF160")]
		public void Initiate(Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x14BF270", Offset = "0x14BE670", VA = "0x1814BF270")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x14BECF0", Offset = "0x14BE0F0", VA = "0x1814BECF0")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x14BEF20", Offset = "0x14BE320", VA = "0x1814BEF20")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x14BF230", Offset = "0x14BE630", VA = "0x1814BF230")]
		private void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x14BF110", Offset = "0x14BE510", VA = "0x1814BF110")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x14BF710", Offset = "0x14BEB10", VA = "0x1814BF710")]
		public void Visualize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x14BF9B0", Offset = "0x14BEDB0", VA = "0x1814BF9B0")]
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
