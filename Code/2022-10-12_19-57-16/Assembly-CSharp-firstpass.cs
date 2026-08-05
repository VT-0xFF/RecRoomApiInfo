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
	[Cpp2IlInjected.Address(RVA = "0x4BAB340", Offset = "0x4BAA340", VA = "0x184BAB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAB160", Offset = "0x4BAA160", VA = "0x184BAB160")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6653D0", Offset = "0x6643D0", VA = "0x1806653D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4BAB2C0", Offset = "0x4BAA2C0", VA = "0x184BAB2C0")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4BAB230", Offset = "0x4BAA230", VA = "0x184BAB230")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BBD0", Offset = "0x64ABD0", VA = "0x18064BBD0")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x33F3880", Offset = "0x33F2880", VA = "0x1833F3880")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BBD0", Offset = "0x64ABD0", VA = "0x18064BBD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x33F3880", Offset = "0x33F2880", VA = "0x1833F3880")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4BABC30", Offset = "0x4BAAC30", VA = "0x184BABC30")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4BABA60", Offset = "0x4BAAA60", VA = "0x184BABA60")]
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
			[Cpp2IlInjected.Address(RVA = "0x10C9020", Offset = "0x10C8020", VA = "0x1810C9020")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1285BE0", Offset = "0x1284BE0", VA = "0x181285BE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCBE830", Offset = "0xCBD830", VA = "0x180CBE830")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4BABCD0", Offset = "0x4BAACD0", VA = "0x184BABCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x10C9020", Offset = "0x10C8020", VA = "0x1810C9020")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1285BE0", Offset = "0x1284BE0", VA = "0x181285BE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCBE830", Offset = "0xCBD830", VA = "0x180CBE830")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4BABCD0", Offset = "0x4BAACD0", VA = "0x184BABCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x498CF20", Offset = "0x498BF20", VA = "0x18498CF20")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x64A010", Offset = "0x649010", VA = "0x18064A010")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4BABA20", Offset = "0x4BAAA20", VA = "0x184BABA20")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x931EF0", Offset = "0x930EF0", VA = "0x180931EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x92F0F0", Offset = "0x92E0F0", VA = "0x18092F0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float bakingProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x12EDDF0", Offset = "0x12ECDF0", VA = "0x1812EDDF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3CDB9A0", Offset = "0x3CDA9A0", VA = "0x183CDB9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected float clipLength
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x14268D0", Offset = "0x14258D0", VA = "0x1814268D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xF300F0", Offset = "0xF2F0F0", VA = "0x180F300F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5307DA0", Offset = "0x5306DA0", VA = "0x185307DA0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5307D60", Offset = "0x5306D60", VA = "0x185307D60")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5307DE0", Offset = "0x5306DE0", VA = "0x185307DE0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5307D20", Offset = "0x5306D20", VA = "0x185307D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public void BakeClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public void StartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public void StopBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5307E20", Offset = "0x5306E20", VA = "0x185307E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x53AF3E0", Offset = "0x53AE3E0", VA = "0x1853AF3E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6866D0", Offset = "0x6856D0", VA = "0x1806866D0", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x53AFAB0", Offset = "0x53AEAB0", VA = "0x1853AFAB0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x53AFA10", Offset = "0x53AEA10", VA = "0x1853AFA10", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x53AF8D0", Offset = "0x53AE8D0", VA = "0x1853AF8D0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x53AF970", Offset = "0x53AE970", VA = "0x1853AF970", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x53AF7F0", Offset = "0x53AE7F0", VA = "0x1853AF7F0")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x53AF710", Offset = "0x53AE710", VA = "0x1853AF710")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x53AFC10", Offset = "0x53AEC10", VA = "0x1853AFC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAE1C0", Offset = "0x4BAD1C0", VA = "0x184BAE1C0")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AvatarUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x53037F0", Offset = "0x53027F0", VA = "0x1853037F0")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5303020", Offset = "0x5302020", VA = "0x185303020")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5303A90", Offset = "0x5302A90", VA = "0x185303A90")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public AvatarUtility()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class BakerUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5307A30", Offset = "0x5306A30", VA = "0x185307A30")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x53074E0", Offset = "0x53064E0", VA = "0x1853074E0")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5307A70", Offset = "0x5306A70", VA = "0x185307A70")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5307230", Offset = "0x5306230", VA = "0x185307230")]
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
		[Cpp2IlInjected.Address(RVA = "0x5305280", Offset = "0x5304280", VA = "0x185305280")]
		public BakerHumanoidQT(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5305400", Offset = "0x5304400", VA = "0x185305400")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x53046B0", Offset = "0x53036B0", VA = "0x1853046B0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5304CD0", Offset = "0x5303CD0", VA = "0x185304CD0")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x53050C0", Offset = "0x53040C0", VA = "0x1853050C0")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x53042F0", Offset = "0x53032F0", VA = "0x1853042F0")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x53051F0", Offset = "0x53041F0", VA = "0x1853051F0")]
		public void SetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5304260", Offset = "0x5303260", VA = "0x185304260")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x53045F0", Offset = "0x53035F0", VA = "0x1853045F0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5304820", Offset = "0x5303820", VA = "0x185304820")]
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
		[Cpp2IlInjected.Address(RVA = "0x5306220", Offset = "0x5305220", VA = "0x185306220")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x53055B0", Offset = "0x53045B0", VA = "0x1853055B0")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x53045F0", Offset = "0x53035F0", VA = "0x1853045F0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5306000", Offset = "0x5305000", VA = "0x185306000")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5305FA0", Offset = "0x5304FA0", VA = "0x185305FA0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x53061C0", Offset = "0x53051C0", VA = "0x1853061C0")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5306210", Offset = "0x5305210", VA = "0x185306210")]
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
		[Cpp2IlInjected.Address(RVA = "0x5307070", Offset = "0x5306070", VA = "0x185307070")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5307050", Offset = "0x5306050", VA = "0x185307050")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5306B20", Offset = "0x5305B20", VA = "0x185306B20")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5306570", Offset = "0x5305570", VA = "0x185306570")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x53069D0", Offset = "0x53059D0", VA = "0x1853069D0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5306850", Offset = "0x5305850", VA = "0x185306850")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5306E10", Offset = "0x5305E10", VA = "0x185306E10")]
		public void SetKeyframes(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x53062E0", Offset = "0x53052E0", VA = "0x1853062E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x54546B0", Offset = "0x54536B0", VA = "0x1854546B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5454C30", Offset = "0x5453C30", VA = "0x185454C30", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5455530", Offset = "0x5454530", VA = "0x185455530", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5455410", Offset = "0x5454410", VA = "0x185455410", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5454C50", Offset = "0x5453C50", VA = "0x185454C50", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5454ED0", Offset = "0x5453ED0", VA = "0x185454ED0", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5455640", Offset = "0x5454640", VA = "0x185455640")]
		private void UpdateHumanPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5455770", Offset = "0x5454770", VA = "0x185455770")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FD70B0", Offset = "0x1FD60B0", VA = "0x181FD70B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2179780", Offset = "0x2178780", VA = "0x182179780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float y
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x15477E0", Offset = "0x15467E0", VA = "0x1815477E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1E4E6E0", Offset = "0x1E4D6E0", VA = "0x181E4E6E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float distanceTarget
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x155D970", Offset = "0x155C970", VA = "0x18155D970")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x155BF80", Offset = "0x155AF80", VA = "0x18155BF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float zoomAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5315C20", Offset = "0x5314C20", VA = "0x185315C20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5315160", Offset = "0x5314160", VA = "0x185315160")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5315150", Offset = "0x5314150", VA = "0x185315150")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5314F30", Offset = "0x5313F30", VA = "0x185314F30", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5315B10", Offset = "0x5314B10", VA = "0x185315B10", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5315080", Offset = "0x5314080", VA = "0x185315080", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x53150E0", Offset = "0x53140E0", VA = "0x1853150E0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x53151A0", Offset = "0x53141A0", VA = "0x1853151A0")]
		public void UpdateInput()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5315360", Offset = "0x5314360", VA = "0x185315360")]
		public void UpdateTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5315390", Offset = "0x5314390", VA = "0x185315390")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5314D30", Offset = "0x5313D30", VA = "0x185314D30")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5315B40", Offset = "0x5314B40", VA = "0x185315B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5314CE0", Offset = "0x5313CE0", VA = "0x185314CE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5314D70", Offset = "0x5313D70", VA = "0x185314D70")]
		public void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5314D30", Offset = "0x5313D30", VA = "0x185314D30")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5314F10", Offset = "0x5313F10", VA = "0x185314F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5304210", Offset = "0x5303210", VA = "0x185304210")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x53041B0", Offset = "0x53031B0", VA = "0x1853041B0")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5303BD0", Offset = "0x5302BD0", VA = "0x185303BD0")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5303AC0", Offset = "0x5302AC0", VA = "0x185303AC0")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x53040A0", Offset = "0x53030A0", VA = "0x1853040A0")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5304030", Offset = "0x5303030", VA = "0x185304030")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5303D50", Offset = "0x5302D50", VA = "0x185303D50")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BA9520", Offset = "0x4BA8520", VA = "0x184BA9520")]
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
			[Cpp2IlInjected.Address(RVA = "0x530A350", Offset = "0x5309350", VA = "0x18530A350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static BipedLimbOrientations MaxBiped
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x530A040", Offset = "0x5309040", VA = "0x18530A040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xFDF7C0", Offset = "0xFDE7C0", VA = "0x180FDF7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x530AB40", Offset = "0x5309B40", VA = "0x18530AB40")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x530A910", Offset = "0x5309910", VA = "0x18530A910")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x530AAC0", Offset = "0x5309AC0", VA = "0x18530AAC0")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x530ACF0", Offset = "0x5309CF0", VA = "0x18530ACF0")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x530ADA0", Offset = "0x5309DA0", VA = "0x18530ADA0")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x530A700", Offset = "0x5309700", VA = "0x18530A700")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x530A660", Offset = "0x5309660", VA = "0x18530A660")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x530A880", Offset = "0x5309880", VA = "0x18530A880")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x530F020", Offset = "0x530E020", VA = "0x18530F020")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x530F4B0", Offset = "0x530E4B0", VA = "0x18530F4B0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x530F730", Offset = "0x530E730", VA = "0x18530F730")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x530EE10", Offset = "0x530DE10", VA = "0x18530EE10")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x530E9F0", Offset = "0x530D9F0", VA = "0x18530E9F0")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x530F2A0", Offset = "0x530E2A0", VA = "0x18530F2A0")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x530F940", Offset = "0x530E940", VA = "0x18530F940")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x530EC00", Offset = "0x530DC00", VA = "0x18530EC00")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x530FB50", Offset = "0x530EB50", VA = "0x18530FB50")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x530FE10", Offset = "0x530EE10", VA = "0x18530FE10")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x530E900", Offset = "0x530D900", VA = "0x18530E900")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x530FD30", Offset = "0x530ED30", VA = "0x18530FD30")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x530AFD0", Offset = "0x5309FD0", VA = "0x18530AFD0")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x530E990", Offset = "0x530D990", VA = "0x18530E990")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x530FCD0", Offset = "0x530ECD0", VA = "0x18530FCD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4BA3770", Offset = "0x4BA2770", VA = "0x184BA3770")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x46DC260", Offset = "0x46DB260", VA = "0x1846DC260")]
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
			[Cpp2IlInjected.Address(RVA = "0x5313F90", Offset = "0x5312F90", VA = "0x185313F90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool isEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x801150", Offset = "0x800150", VA = "0x180801150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5312370", Offset = "0x5311370", VA = "0x185312370", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5310B50", Offset = "0x530FB50", VA = "0x185310B50", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5310870", Offset = "0x530F870", VA = "0x185310870")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5311170", Offset = "0x5310170", VA = "0x185311170")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x53102E0", Offset = "0x530F2E0", VA = "0x1853102E0")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5313850", Offset = "0x5312850", VA = "0x185313850")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x53139A0", Offset = "0x53129A0", VA = "0x1853139A0")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x53127F0", Offset = "0x53117F0", VA = "0x1853127F0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x530FF40", Offset = "0x530EF40", VA = "0x18530FF40")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5310150", Offset = "0x530F150", VA = "0x185310150")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5310FE0", Offset = "0x530FFE0", VA = "0x185310FE0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5310050", Offset = "0x530F050", VA = "0x185310050")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x53128E0", Offset = "0x53118E0", VA = "0x1853128E0")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5313170", Offset = "0x5312170", VA = "0x185313170")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5313A90", Offset = "0x5312A90", VA = "0x185313A90")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5311DE0", Offset = "0x5310DE0", VA = "0x185311DE0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x53135B0", Offset = "0x53125B0", VA = "0x1853135B0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5311FF0", Offset = "0x5310FF0", VA = "0x185311FF0")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5312290", Offset = "0x5311290", VA = "0x185312290")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5313F10", Offset = "0x5312F10", VA = "0x185313F10")]
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
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x539EBD0", Offset = "0x539DBD0", VA = "0x18539EBD0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x539EC90", Offset = "0x539DC90", VA = "0x18539EC90")]
		public DemoGUIMessage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class Hierarchy
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5452EE0", Offset = "0x5451EE0", VA = "0x185452EE0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5452760", Offset = "0x5451760", VA = "0x185452760")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5452F80", Offset = "0x5451F80", VA = "0x185452F80")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5452650", Offset = "0x5451650", VA = "0x185452650")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x54523C0", Offset = "0x54513C0", VA = "0x1854523C0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5452890", Offset = "0x5451890", VA = "0x185452890")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5452B70", Offset = "0x5451B70", VA = "0x185452B70")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5452D10", Offset = "0x5451D10", VA = "0x185452D10")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x54529A0", Offset = "0x54519A0", VA = "0x1854529A0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x54530F0", Offset = "0x54520F0", VA = "0x1854530F0")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x547CC90", Offset = "0x547BC90", VA = "0x18547CC90")]
		public InspectorComment(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x547CD20", Offset = "0x547BD20", VA = "0x18547CD20")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F6C200", Offset = "0x4F6B200", VA = "0x184F6C200")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D050", Offset = "0x4F6C050", VA = "0x184F6D050")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CB70", Offset = "0x4F6BB70", VA = "0x184F6CB70")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CC00", Offset = "0x4F6BC00", VA = "0x184F6CC00")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C9F0", Offset = "0x4F6B9F0", VA = "0x184F6C9F0")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CA20", Offset = "0x4F6BA20", VA = "0x184F6CA20")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CB00", Offset = "0x4F6BB00", VA = "0x184F6CB00")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CAE0", Offset = "0x4F6BAE0", VA = "0x184F6CAE0")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C840", Offset = "0x4F6B840", VA = "0x184F6C840")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CAD0", Offset = "0x4F6BAD0", VA = "0x184F6CAD0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CFA0", Offset = "0x4F6BFA0", VA = "0x184F6CFA0")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CF40", Offset = "0x4F6BF40", VA = "0x184F6CF40")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CCE0", Offset = "0x4F6BCE0", VA = "0x184F6CCE0")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CEC0", Offset = "0x4F6BEC0", VA = "0x184F6CEC0")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CF00", Offset = "0x4F6BF00", VA = "0x184F6CF00")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C190", Offset = "0x4F6B190", VA = "0x184F6C190")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C1C0", Offset = "0x4F6B1C0", VA = "0x184F6C1C0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CC10", Offset = "0x4F6BC10", VA = "0x184F6CC10")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CC50", Offset = "0x4F6BC50", VA = "0x184F6CC50")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CD90", Offset = "0x4F6BD90", VA = "0x184F6CD90")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CD20", Offset = "0x4F6BD20", VA = "0x184F6CD20")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C8C0", Offset = "0x4F6B8C0", VA = "0x184F6C8C0")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C860", Offset = "0x4F6B860", VA = "0x184F6C860")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CB20", Offset = "0x4F6BB20", VA = "0x184F6CB20")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D010", Offset = "0x4F6C010", VA = "0x184F6D010")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CA70", Offset = "0x4F6BA70", VA = "0x184F6CA70")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C920", Offset = "0x4F6B920", VA = "0x184F6C920")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CE00", Offset = "0x4F6BE00", VA = "0x184F6CE00")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C810", Offset = "0x4F6B810", VA = "0x184F6C810")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CCA0", Offset = "0x4F6BCA0", VA = "0x184F6CCA0")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F6D1E0", Offset = "0x4F6C1E0", VA = "0x184F6D1E0")]
		public LargeHeader(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D270", Offset = "0x4F6C270", VA = "0x184F6D270")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class LayerMaskExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D3D0", Offset = "0x4F6C3D0", VA = "0x184F6D3D0")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D410", Offset = "0x4F6C410", VA = "0x184F6D410")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D4B0", Offset = "0x4F6C4B0", VA = "0x184F6D4B0")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D410", Offset = "0x4F6C410", VA = "0x184F6D410")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D4B0", Offset = "0x4F6C4B0", VA = "0x184F6D4B0")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D530", Offset = "0x4F6C530", VA = "0x184F6D530")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D300", Offset = "0x4F6C300", VA = "0x184F6D300")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D9B0", Offset = "0x4F6C9B0", VA = "0x184F6D9B0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D550", Offset = "0x4F6C550", VA = "0x184F6D550")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D660", Offset = "0x4F6C660", VA = "0x184F6D660")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D870", Offset = "0x4F6C870", VA = "0x184F6D870")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D750", Offset = "0x4F6C750", VA = "0x184F6D750")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class QuaTools
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4F77140", Offset = "0x4F76140", VA = "0x184F77140")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4F76FD0", Offset = "0x4F75FD0", VA = "0x184F76FD0")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4F76B60", Offset = "0x4F75B60", VA = "0x184F76B60")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4F77070", Offset = "0x4F76070", VA = "0x184F77070")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4F76F10", Offset = "0x4F75F10", VA = "0x184F76F10")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4F76D10", Offset = "0x4F75D10", VA = "0x184F76D10")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4F771C0", Offset = "0x4F761C0", VA = "0x184F771C0")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4F77480", Offset = "0x4F76480", VA = "0x184F77480")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4F77230", Offset = "0x4F76230", VA = "0x184F77230")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4F774F0", Offset = "0x4F764F0", VA = "0x184F774F0")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4F76720", Offset = "0x4F75720", VA = "0x184F76720")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4F77400", Offset = "0x4F76400", VA = "0x184F77400")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4F76860", Offset = "0x4F75860", VA = "0x184F76860")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4F76910", Offset = "0x4F75910", VA = "0x184F76910")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4F76530", Offset = "0x4F75530", VA = "0x184F76530")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4F76400", Offset = "0x4F75400", VA = "0x184F76400")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4F772D0", Offset = "0x4F762D0", VA = "0x184F772D0")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4F77590", Offset = "0x4F76590", VA = "0x184F77590")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4F77690", Offset = "0x4F76690", VA = "0x184F77690")]
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
			[Cpp2IlInjected.Address(RVA = "0xF98690", Offset = "0xF97690", VA = "0x180F98690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8130", Offset = "0x3EB7130", VA = "0x183EB8130", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2C66600", Offset = "0x2C65600", VA = "0x182C66600")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BADFE0", Offset = "0x4BACFE0", VA = "0x184BADFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool isAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x4BAE0C0", Offset = "0x4BAD0C0", VA = "0x184BAE0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4BADBD0", Offset = "0x4BACBD0", VA = "0x184BADBD0")]
		public void Disable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4BADF00", Offset = "0x4BACF00", VA = "0x184BADF00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4BADE60", Offset = "0x4BACE60", VA = "0x184BADE60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4BADE60", Offset = "0x4BACE60", VA = "0x184BADE60")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4BADFA0", Offset = "0x4BACFA0", VA = "0x184BADFA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4BADC60", Offset = "0x4BACC60", VA = "0x184BADC60")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4BADEB0", Offset = "0x4BACEB0", VA = "0x184BADEB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4BADF60", Offset = "0x4BACF60", VA = "0x184BADF60")]
		public void UpdateSolverExternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x150B710", Offset = "0x150A710", VA = "0x18150B710")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAEAC0", Offset = "0x4BADAC0", VA = "0x184BAEAC0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4BAEC20", Offset = "0x4BADC20", VA = "0x184BAEC20")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4BAEB70", Offset = "0x4BADB70", VA = "0x184BAEB70")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class V2Tools
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x42C7EB0", Offset = "0x42C6EB0", VA = "0x1842C7EB0")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4BB1440", Offset = "0x4BB0440", VA = "0x184BB1440")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4BB13D0", Offset = "0x4BB03D0", VA = "0x184BB13D0")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4BB14A0", Offset = "0x4BB04A0", VA = "0x184BB14A0")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4BB15C0", Offset = "0x4BB05C0", VA = "0x184BB15C0")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class V3Tools
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2250", Offset = "0x4BB1250", VA = "0x184BB2250")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2160", Offset = "0x4BB1160", VA = "0x184BB2160")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2090", Offset = "0x4BB1090", VA = "0x184BB2090")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2280", Offset = "0x4BB1280", VA = "0x184BB2280")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4BB21A0", Offset = "0x4BB11A0", VA = "0x184BB21A0")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4BB1EF0", Offset = "0x4BB0EF0", VA = "0x184BB1EF0")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4BB25B0", Offset = "0x4BB15B0", VA = "0x184BB25B0")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2AF0", Offset = "0x4BB1AF0", VA = "0x184BB2AF0")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4BB1E30", Offset = "0x4BB0E30", VA = "0x184BB1E30")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4BB1D40", Offset = "0x4BB0D40", VA = "0x184BB1D40")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4BB1700", Offset = "0x4BB0700", VA = "0x184BB1700")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x4BB1900", Offset = "0x4BB0900", VA = "0x184BB1900")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4BB1B00", Offset = "0x4BB0B00", VA = "0x184BB1B00")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4BB26F0", Offset = "0x4BB16F0", VA = "0x184BB26F0")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4BB28D0", Offset = "0x4BB18D0", VA = "0x184BB28D0")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2B80", Offset = "0x4BB1B80", VA = "0x184BB2B80")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2340", Offset = "0x4BB1340", VA = "0x184BB2340")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2460", Offset = "0x4BB1460", VA = "0x184BB2460")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2C70", Offset = "0x4BB1C70", VA = "0x184BB2C70")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x496DDA0", Offset = "0x496CDA0", VA = "0x18496DDA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BBA280", Offset = "0x4BB9280", VA = "0x184BBA280")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4BBA1D0", Offset = "0x4BB91D0", VA = "0x184BBA1D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5308FD0", Offset = "0x5307FD0", VA = "0x185308FD0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5308F90", Offset = "0x5307F90", VA = "0x185308F90")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x53094F0", Offset = "0x53084F0", VA = "0x1853094F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x53088B0", Offset = "0x53078B0", VA = "0x1853088B0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5308A30", Offset = "0x5307A30", VA = "0x185308A30")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5308B40", Offset = "0x5307B40", VA = "0x185308B40")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5309010", Offset = "0x5308010", VA = "0x185309010")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5309100", Offset = "0x5308100", VA = "0x185309100")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5309080", Offset = "0x5308080", VA = "0x185309080")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5309170", Offset = "0x5308170", VA = "0x185309170")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5308AA0", Offset = "0x5307AA0", VA = "0x185308AA0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5308BB0", Offset = "0x5307BB0", VA = "0x185308BB0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5309210", Offset = "0x5308210", VA = "0x185309210")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x53091E0", Offset = "0x53081E0", VA = "0x1853091E0")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5309250", Offset = "0x5308250", VA = "0x185309250")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5309280", Offset = "0x5308280", VA = "0x185309280")]
		public void SetSpineWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x53089C0", Offset = "0x53079C0", VA = "0x1853089C0")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA5EC80", Offset = "0xA5DC80", VA = "0x180A5EC80")]
		public void InitiateBipedIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x651670", Offset = "0x650670", VA = "0x180651670")]
		public void UpdateBipedIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x53092B0", Offset = "0x53082B0", VA = "0x1853092B0")]
		public void SetToDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x53088F0", Offset = "0x53078F0", VA = "0x1853088F0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5308C20", Offset = "0x5307C20", VA = "0x185308C20", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5309530", Offset = "0x5308530", VA = "0x185309530", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DF50", Offset = "0x4F7CF50", VA = "0x184F7DF50")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5309750", Offset = "0x5308750", VA = "0x185309750")]
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
			[Cpp2IlInjected.Address(RVA = "0x53086B0", Offset = "0x53076B0", VA = "0x1853086B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IKSolver[] ikSolvers
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x53083A0", Offset = "0x53073A0", VA = "0x1853083A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5308040", Offset = "0x5307040", VA = "0x185308040")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x53081E0", Offset = "0x53071E0", VA = "0x1853081E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x539E6A0", Offset = "0x539D6A0", VA = "0x18539E6A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void UpdateConstraint();

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x539E200", Offset = "0x539D200", VA = "0x18539E200", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ConstraintPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
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
			[Cpp2IlInjected.Address(RVA = "0x539E1A0", Offset = "0x539D1A0", VA = "0x18539E1A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x539DF40", Offset = "0x539CF40", VA = "0x18539DF40", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ConstraintPositionOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
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
		[Cpp2IlInjected.Address(RVA = "0x539E5A0", Offset = "0x539D5A0", VA = "0x18539E5A0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ConstraintRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
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
			[Cpp2IlInjected.Address(RVA = "0x539E550", Offset = "0x539D550", VA = "0x18539E550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x539E360", Offset = "0x539D360", VA = "0x18539E360", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ConstraintRotationOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
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
		[Cpp2IlInjected.Address(RVA = "0x539E780", Offset = "0x539D780", VA = "0x18539E780")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x539E700", Offset = "0x539D700", VA = "0x18539E700")]
		public void Initiate(Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x539E7E0", Offset = "0x539D7E0", VA = "0x18539E7E0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x8147B0", Offset = "0x8137B0", VA = "0x1808147B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x129E760", Offset = "0x129D760", VA = "0x18129E760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 IKPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x53AE8E0", Offset = "0x53AD8E0", VA = "0x1853AE8E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x53AE910", Offset = "0x53AD910", VA = "0x1853AE910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion IKRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x15ACA90", Offset = "0x15ABA90", VA = "0x1815ACA90")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x53AE940", Offset = "0x53AD940", VA = "0x1853AE940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x53AE050", Offset = "0x53AD050", VA = "0x1853AE050")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x53AD6B0", Offset = "0x53AC6B0", VA = "0x1853AD6B0")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x53AD5C0", Offset = "0x53AC5C0", VA = "0x1853AD5C0")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x53AE170", Offset = "0x53AD170", VA = "0x1853AE170")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x53AE250", Offset = "0x53AD250", VA = "0x1853AE250")]
		public void Update(float masterWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x1AA1160", Offset = "0x1AA0160", VA = "0x181AA1160")]
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
			[Cpp2IlInjected.Address(RVA = "0x8147B0", Offset = "0x8137B0", VA = "0x1808147B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x129E760", Offset = "0x129D760", VA = "0x18129E760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x53AD160", Offset = "0x53AC160", VA = "0x1853AD160")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x53ACB90", Offset = "0x53ABB90", VA = "0x1853ACB90")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x53AC9B0", Offset = "0x53AB9B0", VA = "0x1853AC9B0")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x53AD1F0", Offset = "0x53AC1F0", VA = "0x1853AD1F0")]
		public void RemoveFinger(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x53AC8B0", Offset = "0x53AB8B0", VA = "0x1853AC8B0")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x53AD090", Offset = "0x53AC090", VA = "0x1853AD090", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x53AD4E0", Offset = "0x53AC4E0", VA = "0x1853AD4E0")]
		public void UpdateFingerSolvers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x53ACF20", Offset = "0x53ABF20", VA = "0x1853ACF20")]
		public void FixFingerTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x53AD3A0", Offset = "0x53AC3A0", VA = "0x1853AD3A0")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x53AD4E0", Offset = "0x53AC4E0", VA = "0x1853AD4E0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x53ACF20", Offset = "0x53ABF20", VA = "0x1853ACF20", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x53AD560", Offset = "0x53AC560", VA = "0x1853AD560")]
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
			[Cpp2IlInjected.Address(RVA = "0x715540", Offset = "0x714540", VA = "0x180715540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9586A0", Offset = "0x9576A0", VA = "0x1809586A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ResetPosition();

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x53B7110", Offset = "0x53B6110", VA = "0x1853B7110")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DF50", Offset = "0x4F7CF50", VA = "0x184F7DF50")]
		protected void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x53B6BE0", Offset = "0x53B5BE0", VA = "0x1853B6BE0")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x53B6F30", Offset = "0x53B5F30", VA = "0x1853B6F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x53B7250", Offset = "0x53B6250", VA = "0x1853B7250")]
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
		[Cpp2IlInjected.Address(RVA = "0x53B1270", Offset = "0x53B0270", VA = "0x1853B1270", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x53B1230", Offset = "0x53B0230", VA = "0x1853B1230", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x53B12B0", Offset = "0x53B02B0", VA = "0x1853B12B0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x53B0640", Offset = "0x53AF640", VA = "0x1853B0640")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x53B1410", Offset = "0x53B0410", VA = "0x1853B1410")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x53B0270", Offset = "0x53AF270", VA = "0x1853B0270")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x53B08D0", Offset = "0x53AF8D0", VA = "0x1853B08D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x53B0B40", Offset = "0x53AFB40", VA = "0x1853B0B40")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x53B1300", Offset = "0x53B0300", VA = "0x1853B1300")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x53B0930", Offset = "0x53AF930", VA = "0x1853B0930")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x53B06F0", Offset = "0x53AF6F0", VA = "0x1853B06F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x53B1500", Offset = "0x53B0500", VA = "0x1853B1500")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F9AAB0", Offset = "0x3F99AB0", VA = "0x183F9AAB0")]
			public SpineEffector()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x4BAE170", Offset = "0x4BAD170", VA = "0x184BAE170")]
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
		[Cpp2IlInjected.Address(RVA = "0x53B2360", Offset = "0x53B1360", VA = "0x1853B2360")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x53B23A0", Offset = "0x53B13A0", VA = "0x1853B23A0", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x53B2320", Offset = "0x53B1320", VA = "0x1853B2320", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x53B23E0", Offset = "0x53B13E0", VA = "0x1853B23E0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x53B1A90", Offset = "0x53B0A90", VA = "0x1853B1A90")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x53B25D0", Offset = "0x53B15D0", VA = "0x1853B25D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x53B17B0", Offset = "0x53B07B0", VA = "0x1853B17B0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x53B17B0", Offset = "0x53B07B0", VA = "0x1853B17B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x53B17C0", Offset = "0x53B07C0", VA = "0x1853B17C0")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x53B1DC0", Offset = "0x53B0DC0", VA = "0x1853B1DC0")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x53B2420", Offset = "0x53B1420", VA = "0x1853B2420")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x53B1C60", Offset = "0x53B0C60", VA = "0x1853B1C60")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x53B1B30", Offset = "0x53B0B30", VA = "0x1853B1B30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x53B26B0", Offset = "0x53B16B0", VA = "0x1853B26B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53B3890", Offset = "0x53B2890", VA = "0x1853B3890", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x53B3850", Offset = "0x53B2850", VA = "0x1853B3850", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x53B38D0", Offset = "0x53B28D0", VA = "0x1853B38D0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x53B2D30", Offset = "0x53B1D30", VA = "0x1853B2D30")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x53B3170", Offset = "0x53B2170", VA = "0x1853B3170")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x53B3CF0", Offset = "0x53B2CF0", VA = "0x1853B3CF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x53B2790", Offset = "0x53B1790", VA = "0x1853B2790")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x53B34D0", Offset = "0x53B24D0", VA = "0x1853B34D0")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x53B38F0", Offset = "0x53B28F0", VA = "0x1853B38F0")]
		private void SetLegIK(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x53B32B0", Offset = "0x53B22B0", VA = "0x1853B32B0")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x53B2F40", Offset = "0x53B1F40", VA = "0x1853B2F40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x53B4150", Offset = "0x53B3150", VA = "0x1853B4150")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BA60F0", Offset = "0x4BA50F0", VA = "0x184BA60F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53B5E50", Offset = "0x53B4E50", VA = "0x1853B5E50", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x53B5E10", Offset = "0x53B4E10", VA = "0x1853B5E10", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x53B5E90", Offset = "0x53B4E90", VA = "0x1853B5E90", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x53B4E70", Offset = "0x53B3E70", VA = "0x1853B4E70")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x53B4CA0", Offset = "0x53B3CA0", VA = "0x1853B4CA0")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x53B50F0", Offset = "0x53B40F0", VA = "0x1853B50F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x53B6930", Offset = "0x53B5930", VA = "0x1853B6930")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x53B4890", Offset = "0x53B3890", VA = "0x1853B4890")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x53B4450", Offset = "0x53B3450", VA = "0x1853B4450")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x53B4FC0", Offset = "0x53B3FC0", VA = "0x1853B4FC0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x53B5ED0", Offset = "0x53B4ED0", VA = "0x1853B5ED0")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x53B54E0", Offset = "0x53B44E0", VA = "0x1853B54E0")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x53B6610", Offset = "0x53B5610", VA = "0x1853B6610")]
		private void UpdateForefeetRoot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x53B6460", Offset = "0x53B5460", VA = "0x1853B6460")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x53B5170", Offset = "0x53B4170", VA = "0x1853B5170")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x53B50B0", Offset = "0x53B40B0", VA = "0x1853B50B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x53B4230", Offset = "0x53B3230", VA = "0x1853B4230")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x53B6AB0", Offset = "0x53B5AB0", VA = "0x1853B6AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5450270", Offset = "0x544F270", VA = "0x185450270")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x54502B0", Offset = "0x544F2B0", VA = "0x1854502B0", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5450230", Offset = "0x544F230", VA = "0x185450230", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x54502F0", Offset = "0x544F2F0", VA = "0x1854502F0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x544F860", Offset = "0x544E860", VA = "0x18544F860")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5450490", Offset = "0x544F490", VA = "0x185450490")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x544F570", Offset = "0x544E570", VA = "0x18544F570")]
		private void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x544FE90", Offset = "0x544EE90", VA = "0x18544FE90")]
		private void OnSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5450380", Offset = "0x544F380", VA = "0x185450380")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x544FC30", Offset = "0x544EC30", VA = "0x18544FC30")]
		private void OnPostSolverUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x544FAD0", Offset = "0x544EAD0", VA = "0x18544FAD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x544F900", Offset = "0x544E900", VA = "0x18544F900")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5450570", Offset = "0x544F570", VA = "0x185450570")]
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
				[Cpp2IlInjected.Address(RVA = "0x64E250", Offset = "0x64D250", VA = "0x18064E250")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(RVA = "0x64E270", Offset = "0x64D270", VA = "0x18064E270")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Vector3 IKPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(RVA = "0x2EA8F80", Offset = "0x2EA7F80", VA = "0x182EA8F80")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FD")]
				[Cpp2IlInjected.Address(RVA = "0x4BA94B0", Offset = "0x4BA84B0", VA = "0x184BA94B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool initiated
			{
				[Cpp2IlInjected.Token(Token = "0x60001FE")]
				[Cpp2IlInjected.Address(RVA = "0x64A030", Offset = "0x649030", VA = "0x18064A030")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FF")]
				[Cpp2IlInjected.Address(RVA = "0x800230", Offset = "0x7FF230", VA = "0x180800230")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public float heightFromGround
			{
				[Cpp2IlInjected.Token(Token = "0x6000200")]
				[Cpp2IlInjected.Address(RVA = "0x140D470", Offset = "0x140C470", VA = "0x18140D470")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0x1482C10", Offset = "0x1481C10", VA = "0x181482C10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Vector3 velocity
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x12E1390", Offset = "0x12E0390", VA = "0x1812E1390")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000203")]
				[Cpp2IlInjected.Address(RVA = "0x1212130", Offset = "0x1211130", VA = "0x181212130")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public Transform transform
			{
				[Cpp2IlInjected.Token(Token = "0x6000204")]
				[Cpp2IlInjected.Address(RVA = "0x64A0D0", Offset = "0x6490D0", VA = "0x18064A0D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000205")]
				[Cpp2IlInjected.Address(RVA = "0x72D4A0", Offset = "0x72C4A0", VA = "0x18072D4A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public float IKOffset
			{
				[Cpp2IlInjected.Token(Token = "0x6000206")]
				[Cpp2IlInjected.Address(RVA = "0x12C4340", Offset = "0x12C3340", VA = "0x1812C4340")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000207")]
				[Cpp2IlInjected.Address(RVA = "0x1A2BE50", Offset = "0x1A2AE50", VA = "0x181A2BE50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public RaycastHit heelHit
			{
				[Cpp2IlInjected.Token(Token = "0x6000208")]
				[Cpp2IlInjected.Address(RVA = "0x4BA9310", Offset = "0x4BA8310", VA = "0x184BA9310")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Cpp2IlInjected.Token(Token = "0x6000209")]
				[Cpp2IlInjected.Address(RVA = "0x4BA94F0", Offset = "0x4BA84F0", VA = "0x184BA94F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RaycastHit capsuleHit
			{
				[Cpp2IlInjected.Token(Token = "0x600020A")]
				[Cpp2IlInjected.Address(RVA = "0x4BA92E0", Offset = "0x4BA82E0", VA = "0x184BA92E0")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Cpp2IlInjected.Token(Token = "0x600020B")]
				[Cpp2IlInjected.Address(RVA = "0x4BA94C0", Offset = "0x4BA84C0", VA = "0x184BA94C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public RaycastHit GetHitPoint
			{
				[Cpp2IlInjected.Token(Token = "0x600020C")]
				[Cpp2IlInjected.Address(RVA = "0x4BA9260", Offset = "0x4BA8260", VA = "0x184BA9260")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public float stepHeightFromGround
			{
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0x4BA9470", Offset = "0x4BA8470", VA = "0x184BA9470")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			private float rootYOffset
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x4BA9340", Offset = "0x4BA8340", VA = "0x184BA9340")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4BA8D80", Offset = "0x4BA7D80", VA = "0x184BA8D80")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x4BA7860", Offset = "0x4BA6860", VA = "0x184BA7860")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x4BA7950", Offset = "0x4BA6950", VA = "0x184BA7950")]
			public void OnEnable()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x4BA8B20", Offset = "0x4BA7B20", VA = "0x184BA8B20")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x4BA79B0", Offset = "0x4BA69B0", VA = "0x184BA79B0")]
			public void Process()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x4BA6AA0", Offset = "0x4BA5AA0", VA = "0x184BA6AA0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x4BA7310", Offset = "0x4BA6310", VA = "0x184BA7310")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x4BA8CC0", Offset = "0x4BA7CC0", VA = "0x184BA8CC0")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x4BA90F0", Offset = "0x4BA80F0", VA = "0x184BA90F0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x4BA8DA0", Offset = "0x4BA7DA0", VA = "0x184BA8DA0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x4BA7180", Offset = "0x4BA6180", VA = "0x184BA7180")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x4BA8BB0", Offset = "0x4BA7BB0", VA = "0x184BA8BB0")]
			private void RotateFoot()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x4BA7790", Offset = "0x4BA6790", VA = "0x184BA7790")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x4BA9210", Offset = "0x4BA8210", VA = "0x184BA9210")]
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
				[Cpp2IlInjected.Address(RVA = "0x194A540", Offset = "0x1949540", VA = "0x18194A540")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x14CD810", Offset = "0x14CC810", VA = "0x1814CD810")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public float heightOffset
			{
				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x1285BE0", Offset = "0x1284BE0", VA = "0x181285BE0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0xF2F340", Offset = "0xF2E340", VA = "0x180F2F340")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x4BA9C40", Offset = "0x4BA8C40", VA = "0x184BA9C40")]
			public void Initiate(Grounding grounding)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x4BA9FC0", Offset = "0x4BA8FC0", VA = "0x184BA9FC0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x4BA9CC0", Offset = "0x4BA8CC0", VA = "0x184BA9CC0")]
			public void OnEnable()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x4BA9D30", Offset = "0x4BA8D30", VA = "0x184BA9D30")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A0B0", Offset = "0x6490B0", VA = "0x18064A0B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x72D490", Offset = "0x72C490", VA = "0x18072D490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Pelvis pelvis
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x660770", Offset = "0x65F770", VA = "0x180660770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x6EBAB0", Offset = "0x6EAAB0", VA = "0x1806EBAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool isGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x866160", Offset = "0x865160", VA = "0x180866160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6F6630", Offset = "0x6F5630", VA = "0x1806F6630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Transform root
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x660700", Offset = "0x65F700", VA = "0x180660700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x672860", Offset = "0x671860", VA = "0x180672860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public RaycastHit rootHit
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x54519C0", Offset = "0x54509C0", VA = "0x1854519C0")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x5451AF0", Offset = "0x5450AF0", VA = "0x185451AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool rootGrounded
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x5451960", Offset = "0x5450960", VA = "0x185451960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x54519F0", Offset = "0x54509F0", VA = "0x1854519F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private bool useRootRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x5451A60", Offset = "0x5450A60", VA = "0x185451A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5450AB0", Offset = "0x544FAB0", VA = "0x185450AB0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x54514A0", Offset = "0x54504A0", VA = "0x1854514A0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5451100", Offset = "0x5450100", VA = "0x185451100")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5451670", Offset = "0x5450670", VA = "0x185451670")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x54507E0", Offset = "0x544F7E0", VA = "0x1854507E0")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x54515F0", Offset = "0x54505F0", VA = "0x1854515F0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x54515D0", Offset = "0x54505D0", VA = "0x1854515D0")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5450FE0", Offset = "0x544FFE0", VA = "0x185450FE0")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x54505D0", Offset = "0x544F5D0", VA = "0x1854505D0")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x54506C0", Offset = "0x544F6C0", VA = "0x1854506C0")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5451900", Offset = "0x5450900", VA = "0x185451900")]
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
		[Cpp2IlInjected.Address(RVA = "0x5300970", Offset = "0x52FF970", VA = "0x185300970", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x53008F0", Offset = "0x52FF8F0", VA = "0x1853008F0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5300930", Offset = "0x52FF930", VA = "0x185300930")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x53009B0", Offset = "0x52FF9B0", VA = "0x1853009B0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x53008B0", Offset = "0x52FF8B0", VA = "0x1853008B0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x53009F0", Offset = "0x52FF9F0", VA = "0x1853009F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5302F30", Offset = "0x5301F30", VA = "0x185302F30", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5302EF0", Offset = "0x5301EF0", VA = "0x185302EF0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5302F70", Offset = "0x5301F70", VA = "0x185302F70")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5302EB0", Offset = "0x5301EB0", VA = "0x185302EB0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5302FB0", Offset = "0x5301FB0", VA = "0x185302FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5314BF0", Offset = "0x5313BF0", VA = "0x185314BF0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5314BB0", Offset = "0x5313BB0", VA = "0x185314BB0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x5314C30", Offset = "0x5313C30", VA = "0x185314C30")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5314B70", Offset = "0x5313B70", VA = "0x185314B70")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5314C70", Offset = "0x5313C70", VA = "0x185314C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x53A1700", Offset = "0x53A0700", VA = "0x1853A1700", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x53A16C0", Offset = "0x53A06C0", VA = "0x1853A16C0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x53A1740", Offset = "0x53A0740", VA = "0x1853A1740")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x53A1680", Offset = "0x53A0680", VA = "0x1853A1680")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x53A1780", Offset = "0x53A0780", VA = "0x1853A1780")]
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
		[Cpp2IlInjected.Address(RVA = "0x53A1590", Offset = "0x53A0590", VA = "0x1853A1590", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x53A1550", Offset = "0x53A0550", VA = "0x1853A1550", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x53A15D0", Offset = "0x53A05D0", VA = "0x1853A15D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x53A1510", Offset = "0x53A0510", VA = "0x1853A1510")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x53A1610", Offset = "0x53A0610", VA = "0x1853A1610")]
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
		[Cpp2IlInjected.Address(RVA = "0x53AEB50", Offset = "0x53ADB50", VA = "0x1853AEB50", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x53AEAD0", Offset = "0x53ADAD0", VA = "0x1853AEAD0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x53AEB10", Offset = "0x53ADB10", VA = "0x1853AEB10")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x53AEA90", Offset = "0x53ADA90", VA = "0x1853AEA90")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x53AF300", Offset = "0x53AE300", VA = "0x1853AF300")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x53AE960", Offset = "0x53AD960", VA = "0x1853AE960")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x53AF2B0", Offset = "0x53AE2B0", VA = "0x1853AF2B0")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x651580", Offset = "0x650580", VA = "0x180651580", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x53AEB90", Offset = "0x53ADB90", VA = "0x1853AEB90")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x53AEE20", Offset = "0x53ADE20", VA = "0x1853AEE20")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x53AF250", Offset = "0x53AE250", VA = "0x1853AF250")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x53AE9A0", Offset = "0x53AD9A0", VA = "0x1853AE9A0")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x53AF340", Offset = "0x53AE340", VA = "0x1853AF340")]
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
		[Cpp2IlInjected.Address(RVA = "0x5468700", Offset = "0x5467700", VA = "0x185468700", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5468690", Offset = "0x5467690", VA = "0x185468690", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5468620", Offset = "0x5467620", VA = "0x185468620", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x17A4970", Offset = "0x17A3970", VA = "0x1817A4970")]
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
			[Cpp2IlInjected.Address(RVA = "0x5459D20", Offset = "0x5458D20", VA = "0x185459D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x5459C70", Offset = "0x5458C70", VA = "0x185459C70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5459CF0", Offset = "0x5458CF0", VA = "0x185459CF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x5459B20", Offset = "0x5458B20", VA = "0x185459B20")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5459B50", Offset = "0x5458B50", VA = "0x185459B50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x5459A70", Offset = "0x5458A70", VA = "0x185459A70")]
		private void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F6DB10", Offset = "0x4F6CB10", VA = "0x184F6DB10", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DAD0", Offset = "0x4F6CAD0", VA = "0x184F6DAD0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DB50", Offset = "0x4F6CB50", VA = "0x184F6DB50")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DA90", Offset = "0x4F6CA90", VA = "0x184F6DA90")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DB90", Offset = "0x4F6CB90", VA = "0x184F6DB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F6DC80", Offset = "0x4F6CC80", VA = "0x184F6DC80", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DC40", Offset = "0x4F6CC40", VA = "0x184F6DC40", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DCC0", Offset = "0x4F6CCC0", VA = "0x184F6DCC0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DC00", Offset = "0x4F6CC00", VA = "0x184F6DC00")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DD00", Offset = "0x4F6CD00", VA = "0x184F6DD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F6EE20", Offset = "0x4F6DE20", VA = "0x184F6EE20", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4F6EDE0", Offset = "0x4F6DDE0", VA = "0x184F6EDE0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x4F6EE60", Offset = "0x4F6DE60", VA = "0x184F6EE60")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x4F6EDA0", Offset = "0x4F6DDA0", VA = "0x184F6EDA0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4F6EEA0", Offset = "0x4F6DEA0", VA = "0x184F6EEA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAED50", Offset = "0x4BADD50", VA = "0x184BAED50", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4BAED10", Offset = "0x4BADD10", VA = "0x184BAED10", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x4BAED90", Offset = "0x4BADD90", VA = "0x184BAED90")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x4BAECD0", Offset = "0x4BADCD0", VA = "0x184BAECD0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x4BAEDD0", Offset = "0x4BADDD0", VA = "0x184BAEDD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5DDED20", Offset = "0x5DDDD20", VA = "0x185DDED20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public bool isEmpty
			{
				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x5DDE810", Offset = "0x5DDD810", VA = "0x185DDE810")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDFB0", Offset = "0x5DDCFB0", VA = "0x185DDDFB0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDAC0", Offset = "0x5DDCAC0", VA = "0x185DDDAC0")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BB9F80", Offset = "0x4BB8F80", VA = "0x184BB9F80", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x4BB9F00", Offset = "0x4BB8F00", VA = "0x184BB9F00", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x4BB9F40", Offset = "0x4BB8F40", VA = "0x184BB9F40")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x4BB9E20", Offset = "0x4BB8E20", VA = "0x184BB9E20")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x4BB9E50", Offset = "0x4BB8E50", VA = "0x184BB9E50")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x651580", Offset = "0x650580", VA = "0x180651580", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x4BB9E80", Offset = "0x4BB8E80", VA = "0x184BB9E80", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x4BB9FC0", Offset = "0x4BB8FC0", VA = "0x184BB9FC0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x4BBA130", Offset = "0x4BB9130", VA = "0x184BBA130")]
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
		[Cpp2IlInjected.Address(RVA = "0x53A1110", Offset = "0x53A0110", VA = "0x1853A1110")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x53A10E0", Offset = "0x53A00E0", VA = "0x1853A10E0")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x53A11F0", Offset = "0x53A01F0", VA = "0x1853A11F0")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x53A1330", Offset = "0x53A0330", VA = "0x1853A1330")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x53A0DC0", Offset = "0x539FDC0", VA = "0x1853A0DC0")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x53A14B0", Offset = "0x53A04B0", VA = "0x1853A14B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53A17F0", Offset = "0x53A07F0", VA = "0x1853A17F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x53A1FE0", Offset = "0x53A0FE0", VA = "0x1853A1FE0")]
		private void OnPostFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x53A1EC0", Offset = "0x53A0EC0", VA = "0x1853A1EC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BA3800", Offset = "0x4BA2800", VA = "0x184BA3800")]
			public BendBone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x4BA3840", Offset = "0x4BA2840", VA = "0x184BA3840")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x4BA37C0", Offset = "0x4BA27C0", VA = "0x184BA37C0")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x4BA3780", Offset = "0x4BA2780", VA = "0x184BA3780")]
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
		[Cpp2IlInjected.Address(RVA = "0x53A5E70", Offset = "0x53A4E70", VA = "0x1853A5E70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x53A4E20", Offset = "0x53A3E20", VA = "0x1853A4E20")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x53A3CE0", Offset = "0x53A2CE0", VA = "0x1853A3CE0")]
		private void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x53A4460", Offset = "0x53A3460", VA = "0x1853A4460")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x53A5AA0", Offset = "0x53A4AA0", VA = "0x1853A5AA0")]
		private void SpineBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x53A21E0", Offset = "0x53A11E0", VA = "0x1853A21E0")]
		private void CCDPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x53A2920", Offset = "0x53A1920", VA = "0x1853A2920")]
		private void Iterate(int iteration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x53A4260", Offset = "0x53A3260", VA = "0x1853A4260")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x53A2680", Offset = "0x53A1680", VA = "0x1853A2680")]
		private void ChestDirection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x53A54E0", Offset = "0x53A44E0", VA = "0x1853A54E0")]
		private void PostStretching()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x53A3770", Offset = "0x53A2770", VA = "0x1853A3770")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x53A5910", Offset = "0x53A4910", VA = "0x1853A5910")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x53A3940", Offset = "0x53A2940", VA = "0x1853A3940")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x53A62A0", Offset = "0x53A52A0", VA = "0x1853A62A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x1118820", Offset = "0x1117820", VA = "0x181118820")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x1118810", Offset = "0x1117810", VA = "0x181118810")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public bool isRigid
			{
				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x72D470", Offset = "0x72C470", VA = "0x18072D470")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x72D4B0", Offset = "0x72C4B0", VA = "0x18072D4B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x4BA6080", Offset = "0x4BA5080", VA = "0x184BA6080")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5A20", Offset = "0x4BA4A20", VA = "0x184BA5A20")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5A80", Offset = "0x4BA4A80", VA = "0x184BA5A80")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5CC0", Offset = "0x4BA4CC0", VA = "0x184BA5CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53AA290", Offset = "0x53A9290", VA = "0x1853AA290")]
		public FBIKChain()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x53AA010", Offset = "0x53A9010", VA = "0x1853AA010")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x53A8B50", Offset = "0x53A7B50", VA = "0x1853A8B50")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x53A78B0", Offset = "0x53A68B0", VA = "0x1853A78B0")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x53A7B70", Offset = "0x53A6B70", VA = "0x1853A7B70")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x53A79A0", Offset = "0x53A69A0", VA = "0x1853A79A0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x53A8520", Offset = "0x53A7520", VA = "0x1853A8520")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x53A6D60", Offset = "0x53A5D60", VA = "0x1853A6D60")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x53A8100", Offset = "0x53A7100", VA = "0x1853A8100")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x53A7CA0", Offset = "0x53A6CA0", VA = "0x1853A7CA0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x53A9380", Offset = "0x53A8380", VA = "0x1853A9380")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x53A98B0", Offset = "0x53A88B0", VA = "0x1853A98B0")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x53A9E80", Offset = "0x53A8E80", VA = "0x1853A9E80")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x53A8D40", Offset = "0x53A7D40", VA = "0x1853A8D40")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x53A9070", Offset = "0x53A8070", VA = "0x1853A9070")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x53A76E0", Offset = "0x53A66E0", VA = "0x1853A76E0")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x53A8CB0", Offset = "0x53A7CB0", VA = "0x1853A8CB0")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x53A9190", Offset = "0x53A8190", VA = "0x1853A9190")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x53A7500", Offset = "0x53A6500", VA = "0x1853A7500")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x53A6A60", Offset = "0x53A5A60", VA = "0x1853A6A60")]
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
			[Cpp2IlInjected.Address(RVA = "0x88CB20", Offset = "0x88BB20", VA = "0x18088CB20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xED5880", Offset = "0xED4880", VA = "0x180ED5880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x5456790", Offset = "0x5455790", VA = "0x185456790")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5457490", Offset = "0x5456490", VA = "0x185457490")]
		public IKConstraintBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x54574D0", Offset = "0x54564D0", VA = "0x1854574D0")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x31EE360", Offset = "0x31ED360", VA = "0x1831EE360")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5456160", Offset = "0x5455160", VA = "0x185456160")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5457280", Offset = "0x5456280", VA = "0x185457280")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x54569E0", Offset = "0x54559E0", VA = "0x1854569E0")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5455800", Offset = "0x5454800", VA = "0x185455800")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x54570E0", Offset = "0x54560E0", VA = "0x1854570E0")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5456F40", Offset = "0x5455F40", VA = "0x185456F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x9E5540", Offset = "0x9E4540", VA = "0x1809E5540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x9E56E0", Offset = "0x9E46E0", VA = "0x1809E56E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5457560", Offset = "0x5456560", VA = "0x185457560")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5458F40", Offset = "0x5457F40", VA = "0x185458F40")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5459780", Offset = "0x5458780", VA = "0x185459780")]
		public IKEffector()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x54598D0", Offset = "0x54588D0", VA = "0x1854598D0")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x5458290", Offset = "0x5457290", VA = "0x185458290")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5457DE0", Offset = "0x5456DE0", VA = "0x185457DE0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x5458FF0", Offset = "0x5457FF0", VA = "0x185458FF0")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x54591D0", Offset = "0x54581D0", VA = "0x1854591D0")]
		public void SetToTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5458620", Offset = "0x5457620", VA = "0x185458620")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x54585F0", Offset = "0x54575F0", VA = "0x1854585F0")]
		public void OnPostWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x54575D0", Offset = "0x54565D0", VA = "0x1854575D0")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x5459280", Offset = "0x5458280", VA = "0x185459280")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5457970", Offset = "0x5456970", VA = "0x185457970")]
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
				[Cpp2IlInjected.Address(RVA = "0x4BA59B0", Offset = "0x4BA49B0", VA = "0x184BA59B0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public bool isNodeBone
			{
				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x4BA5780", Offset = "0x4BA4780", VA = "0x184BA5780")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0x4BA5790", Offset = "0x4BA4790", VA = "0x184BA5790")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4440", Offset = "0x4BA3440", VA = "0x184BA4440")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4E30", Offset = "0x4BA3E30", VA = "0x184BA4E30")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4120", Offset = "0x4BA3120", VA = "0x184BA4120")]
			public void FixTransform(bool position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4900", Offset = "0x4BA3900", VA = "0x184BA4900")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x4BA49B0", Offset = "0x4BA39B0", VA = "0x184BA49B0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4AF0", Offset = "0x4BA3AF0", VA = "0x184BA4AF0")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4C40", Offset = "0x4BA3C40", VA = "0x184BA4C40")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4CE0", Offset = "0x4BA3CE0", VA = "0x184BA4CE0")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x4BA53E0", Offset = "0x4BA43E0", VA = "0x184BA53E0")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x4BA48C0", Offset = "0x4BA38C0", VA = "0x184BA48C0")]
			public void SetIKPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x4BA44A0", Offset = "0x4BA34A0", VA = "0x184BA44A0")]
			public void MaintainRotation()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4DF0", Offset = "0x4BA3DF0", VA = "0x184BA4DF0")]
			public void SetToIKPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x4BA3FB0", Offset = "0x4BA2FB0", VA = "0x184BA3FB0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4180", Offset = "0x4BA3180", VA = "0x184BA4180")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x4BA44E0", Offset = "0x4BA34E0", VA = "0x184BA44E0")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x4BA47F0", Offset = "0x4BA37F0", VA = "0x184BA47F0")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5080", Offset = "0x4BA4080", VA = "0x184BA5080")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4E90", Offset = "0x4BA3E90", VA = "0x184BA4E90")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5260", Offset = "0x4BA4260", VA = "0x184BA5260")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4760", Offset = "0x4BA3760", VA = "0x184BA4760")]
			public void RotateToMaintain(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4620", Offset = "0x4BA3620", VA = "0x184BA4620")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4290", Offset = "0x4BA3290", VA = "0x184BA4290")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5750", Offset = "0x4BA4750", VA = "0x184BA5750")]
			public BoneMap()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x545D2E0", Offset = "0x545C2E0", VA = "0x18545D2E0")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x53A9070", Offset = "0x53A8070", VA = "0x1853A9070")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5459E80", Offset = "0x5458E80", VA = "0x185459E80", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x5459F90", Offset = "0x5458F90", VA = "0x185459F90")]
		public IKMappingBone()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x545A000", Offset = "0x5459000", VA = "0x18545A000")]
		public IKMappingBone(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5459F40", Offset = "0x5458F40", VA = "0x185459F40")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x5459DB0", Offset = "0x5458DB0", VA = "0x185459DB0")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x5459DE0", Offset = "0x5458DE0", VA = "0x185459DE0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x5459F20", Offset = "0x5458F20", VA = "0x185459F20")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x5459F60", Offset = "0x5458F60", VA = "0x185459F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x545A4D0", Offset = "0x54594D0", VA = "0x18545A4D0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x545A150", Offset = "0x5459150", VA = "0x18545A150")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x545A820", Offset = "0x5459820", VA = "0x18545A820")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x545AFB0", Offset = "0x5459FB0", VA = "0x18545AFB0")]
		public IKMappingLimb()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x545AE60", Offset = "0x5459E60", VA = "0x18545AE60")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x545A7B0", Offset = "0x54597B0", VA = "0x18545A7B0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x545AC20", Offset = "0x5459C20", VA = "0x18545AC20")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x545A090", Offset = "0x5459090", VA = "0x18545A090")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x545A220", Offset = "0x5459220", VA = "0x18545A220", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x545A730", Offset = "0x5459730", VA = "0x18545A730")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x545ACD0", Offset = "0x5459CD0", VA = "0x18545ACD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x545BDA0", Offset = "0x545ADA0", VA = "0x18545BDA0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x545D030", Offset = "0x545C030", VA = "0x18545D030")]
		public IKMappingSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x545D150", Offset = "0x545C150", VA = "0x18545D150")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x545C9D0", Offset = "0x545B9D0", VA = "0x18545C9D0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x545CA50", Offset = "0x545BA50", VA = "0x18545CA50")]
		public void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x545B280", Offset = "0x545A280", VA = "0x18545B280")]
		public void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x545B510", Offset = "0x545A510", VA = "0x18545B510", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x545CAD0", Offset = "0x545BAD0", VA = "0x18545CAD0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x545C5F0", Offset = "0x545B5F0", VA = "0x18545C5F0")]
		public void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x545CB00", Offset = "0x545BB00", VA = "0x18545CB00")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x545B320", Offset = "0x545A320", VA = "0x18545B320")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x545B0A0", Offset = "0x545A0A0", VA = "0x18545B0A0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x545C1C0", Offset = "0x545B1C0", VA = "0x18545C1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x56BC270", Offset = "0x56BB270", VA = "0x1856BC270")]
			public void StoreDefaultLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x56BC180", Offset = "0x56BB180", VA = "0x1856BC180")]
			public void FixTransform()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x56BC370", Offset = "0x56BB370", VA = "0x1856BC370")]
			public void UpdateSolverPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x56BC2D0", Offset = "0x56BB2D0", VA = "0x1856BC2D0")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x56BC3B0", Offset = "0x56BB3B0", VA = "0x1856BC3B0")]
			public void UpdateSolverState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x56BC310", Offset = "0x56BB310", VA = "0x1856BC310")]
			public void UpdateSolverLocalState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x56BB230", Offset = "0x56BA230", VA = "0x1856BB230")]
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
				[Cpp2IlInjected.Address(RVA = "0x56B1E00", Offset = "0x56B0E00", VA = "0x1856B1E00")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x56B1F00", Offset = "0x56B0F00", VA = "0x1856B1F00")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x56B19C0", Offset = "0x56B09C0", VA = "0x1856B19C0")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x56B1500", Offset = "0x56B0500", VA = "0x1856B1500")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x56B17E0", Offset = "0x56B07E0", VA = "0x1856B17E0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x56B14C0", Offset = "0x56B04C0", VA = "0x1856B14C0")]
			public void SetToSolverPosition()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x56B1D70", Offset = "0x56B0D70", VA = "0x1856B1D70")]
			public Bone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x56B1C00", Offset = "0x56B0C00", VA = "0x1856B1C00")]
			public Bone(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x56B1CB0", Offset = "0x56B0CB0", VA = "0x1856B1CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x56BB230", Offset = "0x56BA230", VA = "0x1856BB230")]
			public Node()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x56BB270", Offset = "0x56BA270", VA = "0x1856BB270")]
			public Node(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x56BB1D0", Offset = "0x56BA1D0", VA = "0x1856BB1D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x755BB0", Offset = "0x754BB0", VA = "0x180755BB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x832490", Offset = "0x831490", VA = "0x180832490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x5468060", Offset = "0x5467060", VA = "0x185468060")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool IsValid(ref string message);

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5467EE0", Offset = "0x5466EE0", VA = "0x185467EE0")]
		public void Initiate(Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x5468590", Offset = "0x5467590", VA = "0x185468590")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2EA8F80", Offset = "0x2EA7F80", VA = "0x182EA8F80", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x4BA94B0", Offset = "0x4BA84B0", VA = "0x184BA94B0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1069700", Offset = "0x1068700", VA = "0x181069700")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5468560", Offset = "0x5467560", VA = "0x185468560")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x660760", Offset = "0x65F760", VA = "0x180660760")]
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
		[Cpp2IlInjected.Address(RVA = "0x54680C0", Offset = "0x54670C0", VA = "0x1854680C0")]
		protected void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x5467CE0", Offset = "0x5466CE0", VA = "0x185467CE0")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x5467E30", Offset = "0x5466E30", VA = "0x185467E30")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x54680E0", Offset = "0x54670E0", VA = "0x1854680E0")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x5468600", Offset = "0x5467600", VA = "0x185468600")]
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
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x1FF400", Offset = "0x1FE800")]
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
			[Cpp2IlInjected.Address(RVA = "0x545EEB0", Offset = "0x545DEB0", VA = "0x18545EEB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector3 transformPoleAxis
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x545EF30", Offset = "0x545DF30", VA = "0x18545EF30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected override int minBones
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x670AA0", Offset = "0x66FAA0", VA = "0x180670AA0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected override Vector3 localDirection
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x545EDE0", Offset = "0x545DDE0", VA = "0x18545EDE0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x545D420", Offset = "0x545C420", VA = "0x18545D420")]
		public float GetAngle()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x545DA80", Offset = "0x545CA80", VA = "0x18545DA80", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x545DE40", Offset = "0x545CE40", VA = "0x18545DE40", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x545EC30", Offset = "0x545DC30", VA = "0x18545EC30")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x545D540", Offset = "0x545C540", VA = "0x18545D540")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x545E5A0", Offset = "0x545D5A0", VA = "0x18545E5A0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x545ED70", Offset = "0x545DD70", VA = "0x18545ED70")]
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
		[Cpp2IlInjected.Address(RVA = "0x545F460", Offset = "0x545E460", VA = "0x18545F460", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x5460070", Offset = "0x545F070", VA = "0x185460070")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x545F230", Offset = "0x545E230", VA = "0x18545F230", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x545F020", Offset = "0x545E020", VA = "0x18545F020", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x54601D0", Offset = "0x545F1D0", VA = "0x1854601D0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x545EFB0", Offset = "0x545DFB0", VA = "0x18545EFB0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x545FA20", Offset = "0x545EA20", VA = "0x18545FA20", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x545FAA0", Offset = "0x545EAA0", VA = "0x18545FAA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x5460140", Offset = "0x545F140", VA = "0x185460140")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x545FB40", Offset = "0x545EB40", VA = "0x18545FB40")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x5460230", Offset = "0x545F230", VA = "0x185460230")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x54604C0", Offset = "0x545F4C0", VA = "0x1854604C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5460690", Offset = "0x545F690", VA = "0x185460690")]
		public void FadeOutBoneWeights()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5460770", Offset = "0x545F770", VA = "0x185460770", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x5460800", Offset = "0x545F800", VA = "0x185460800", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x5460B20", Offset = "0x545FB20", VA = "0x185460B20")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x5461490", Offset = "0x5460490", VA = "0x185461490")]
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
			[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x5465840", Offset = "0x5464840", VA = "0x185465840")]
		public void SolveForward(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x5465770", Offset = "0x5464770", VA = "0x185465770")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x5463920", Offset = "0x5462920", VA = "0x185463920", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x5464960", Offset = "0x5463960", VA = "0x185464960", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x5465460", Offset = "0x5464460", VA = "0x185465460", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x54658F0", Offset = "0x54648F0", VA = "0x1854658F0")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x5464E90", Offset = "0x5463E90", VA = "0x185464E90")]
		private void OnPreSolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x5464D40", Offset = "0x5463D40", VA = "0x185464D40")]
		private void OnPostSolve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x5465A30", Offset = "0x5464A30", VA = "0x185465A30")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x5463630", Offset = "0x5462630", VA = "0x185463630")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x5465CB0", Offset = "0x5464CB0", VA = "0x185465CB0")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x5465E30", Offset = "0x5464E30", VA = "0x185465E30")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x5465D70", Offset = "0x5464D70", VA = "0x185465D70")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x5465AE0", Offset = "0x5464AE0", VA = "0x185465AE0")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x5463CB0", Offset = "0x5462CB0", VA = "0x185463CB0")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x5463B30", Offset = "0x5462B30", VA = "0x185463B30")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x54639D0", Offset = "0x54629D0", VA = "0x1854639D0")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x5463E20", Offset = "0x5462E20", VA = "0x185463E20")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x54635F0", Offset = "0x54625F0", VA = "0x1854635F0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x5463400", Offset = "0x5462400", VA = "0x185463400")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x5462CC0", Offset = "0x5461CC0", VA = "0x185462CC0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x54647A0", Offset = "0x54637A0", VA = "0x1854647A0")]
		private void MapToSolverPositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x54646A0", Offset = "0x54636A0", VA = "0x1854646A0")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x5465F10", Offset = "0x5464F10", VA = "0x185465F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5461E20", Offset = "0x5460E20", VA = "0x185461E20", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5462B80", Offset = "0x5461B80", VA = "0x185462B80", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x5461610", Offset = "0x5460610", VA = "0x185461610", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5462760", Offset = "0x5461760", VA = "0x185462760", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x5461D80", Offset = "0x5460D80", VA = "0x185461D80")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5462920", Offset = "0x5461920", VA = "0x185462920", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5461B70", Offset = "0x5460B70", VA = "0x185461B70", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5461AC0", Offset = "0x5460AC0", VA = "0x185461AC0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x54614A0", Offset = "0x54604A0", VA = "0x1854614A0")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x54616E0", Offset = "0x54606E0", VA = "0x1854616E0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x5462C50", Offset = "0x5461C50", VA = "0x185462C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x5466470", Offset = "0x5465470", VA = "0x185466470")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x5466420", Offset = "0x5465420", VA = "0x185466420")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x54662F0", Offset = "0x54652F0", VA = "0x1854662F0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x5466590", Offset = "0x5465590", VA = "0x185466590")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x5466260", Offset = "0x5465260", VA = "0x185466260")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x5466790", Offset = "0x5465790", VA = "0x185466790", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x5466600", Offset = "0x5465600", VA = "0x185466600", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x5466940", Offset = "0x5465940", VA = "0x185466940", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5467730", Offset = "0x5466730", VA = "0x185467730", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x5465FE0", Offset = "0x5464FE0", VA = "0x185465FE0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x5466BE0", Offset = "0x5465BE0", VA = "0x185466BE0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x5466DB0", Offset = "0x5465DB0", VA = "0x185466DB0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x5466F70", Offset = "0x5465F70", VA = "0x185466F70", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x5467350", Offset = "0x5466350", VA = "0x185467350", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x5465F90", Offset = "0x5464F90", VA = "0x185465F90", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5467970", Offset = "0x5466970", VA = "0x185467970", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5467AB0", Offset = "0x5466AB0", VA = "0x185467AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x546CF10", Offset = "0x546BF10", VA = "0x18546CF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public IKEffector leftShoulderEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x546D0D0", Offset = "0x546C0D0", VA = "0x18546D0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public IKEffector rightShoulderEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x546D2F0", Offset = "0x546C2F0", VA = "0x18546D2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public IKEffector leftThighEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x546D110", Offset = "0x546C110", VA = "0x18546D110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public IKEffector rightThighEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x546D330", Offset = "0x546C330", VA = "0x18546D330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IKEffector leftHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x546D010", Offset = "0x546C010", VA = "0x18546D010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public IKEffector rightHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x546D230", Offset = "0x546C230", VA = "0x18546D230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public IKEffector leftFootEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x546CFD0", Offset = "0x546BFD0", VA = "0x18546CFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public IKEffector rightFootEffector
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x546D1F0", Offset = "0x546C1F0", VA = "0x18546D1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public FBIKChain leftArmChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x546CF50", Offset = "0x546BF50", VA = "0x18546CF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public FBIKChain rightArmChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x546D170", Offset = "0x546C170", VA = "0x18546D170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public FBIKChain leftLegChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x546D050", Offset = "0x546C050", VA = "0x18546D050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public FBIKChain rightLegChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x546D270", Offset = "0x546C270", VA = "0x18546D270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public IKMappingLimb leftArmMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x546CF90", Offset = "0x546BF90", VA = "0x18546CF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public IKMappingLimb rightArmMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x546D1B0", Offset = "0x546C1B0", VA = "0x18546D1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public IKMappingLimb leftLegMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x546D090", Offset = "0x546C090", VA = "0x18546D090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public IKMappingLimb rightLegMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x546D2B0", Offset = "0x546C2B0", VA = "0x18546D2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IKMappingBone headMapping
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x5469CB0", Offset = "0x5468CB0", VA = "0x185469CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Vector3 pullBodyOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x546D150", Offset = "0x546C150", VA = "0x18546D150")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x546D370", Offset = "0x546C370", VA = "0x18546D370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x546A880", Offset = "0x5469880", VA = "0x18546A880")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x546A8F0", Offset = "0x54698F0", VA = "0x18546A8F0")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x54694E0", Offset = "0x54684E0", VA = "0x1854694E0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x54695B0", Offset = "0x54685B0", VA = "0x1854695B0")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x54697A0", Offset = "0x54687A0", VA = "0x1854697A0")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x54699B0", Offset = "0x54689B0", VA = "0x1854699B0")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5469DB0", Offset = "0x5468DB0", VA = "0x185469DB0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x5469E80", Offset = "0x5468E80", VA = "0x185469E80")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x660700", Offset = "0x65F700", VA = "0x180660700")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x5469CB0", Offset = "0x5468CB0", VA = "0x185469CB0")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x5469140", Offset = "0x5468140", VA = "0x185469140")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x546A120", Offset = "0x5469120", VA = "0x18546A120", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x546AD20", Offset = "0x5469D20", VA = "0x18546AD20")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x5468D20", Offset = "0x5467D20", VA = "0x185468D20")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x546ACB0", Offset = "0x5469CB0", VA = "0x18546ACB0")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x546A9A0", Offset = "0x54699A0", VA = "0x18546A9A0")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5469CF0", Offset = "0x5468CF0", VA = "0x185469CF0")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x546A060", Offset = "0x5469060", VA = "0x18546A060")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5468C60", Offset = "0x5467C60", VA = "0x185468C60")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x546A510", Offset = "0x5469510", VA = "0x18546A510", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x546A2F0", Offset = "0x54692F0", VA = "0x18546A2F0")]
		private void PullBody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5469210", Offset = "0x5468210", VA = "0x185469210")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5469A80", Offset = "0x5468A80", VA = "0x185469A80")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x54687E0", Offset = "0x54677E0", VA = "0x1854687E0", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x546CDE0", Offset = "0x546BDE0", VA = "0x18546CDE0", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x546CEF0", Offset = "0x546BEF0", VA = "0x18546CEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6652A0", Offset = "0x6642A0", VA = "0x1806652A0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual bool boneLengthCanBeZero
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual bool allowCommonParent
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual Vector3 localDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x546EC50", Offset = "0x546DC50", VA = "0x18546EC50", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected float positionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x546EDF0", Offset = "0x546DDF0", VA = "0x18546EDF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x546E6B0", Offset = "0x546D6B0", VA = "0x18546E6B0")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x546D390", Offset = "0x546C390", VA = "0x18546D390")]
		public void AddBone(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x546EB70", Offset = "0x546DB70", VA = "0x18546EB70", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x546D560", Offset = "0x546C560", VA = "0x18546D560", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x546E260", Offset = "0x546D260", VA = "0x18546E260", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x660700", Offset = "0x65F700", VA = "0x180660700", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x546D5F0", Offset = "0x546C5F0", VA = "0x18546D5F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x546DB70", Offset = "0x546CB70", VA = "0x18546DB70")]
		protected void InitiateBones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x546D710", Offset = "0x546C710", VA = "0x18546D710")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x546E890", Offset = "0x546D890", VA = "0x18546E890")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x546EBF0", Offset = "0x546DBF0", VA = "0x18546EBF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x546F2B0", Offset = "0x546E2B0", VA = "0x18546F2B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x5460070", Offset = "0x545F070", VA = "0x185460070")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x546F080", Offset = "0x546E080", VA = "0x18546F080", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x546EE70", Offset = "0x546DE70", VA = "0x18546EE70", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x54601D0", Offset = "0x545F1D0", VA = "0x1854601D0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x545EFB0", Offset = "0x545DFB0", VA = "0x18545EFB0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x546F790", Offset = "0x546E790", VA = "0x18546F790", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x546F810", Offset = "0x546E810", VA = "0x18546F810", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x546FE60", Offset = "0x546EE60", VA = "0x18546FE60")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x546F940", Offset = "0x546E940", VA = "0x18546F940")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x546FF80", Offset = "0x546EF80", VA = "0x18546FF80")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x5470210", Offset = "0x546F210", VA = "0x185470210")]
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
			[Cpp2IlInjected.Address(RVA = "0x56B03C0", Offset = "0x56AF3C0", VA = "0x1856B03C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5471B20", Offset = "0x5470B20", VA = "0x185471B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x5471130", Offset = "0x5470130", VA = "0x185471130")]
		public void MaintainRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x54710E0", Offset = "0x54700E0", VA = "0x1854710E0")]
		public void MaintainBend()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x5471180", Offset = "0x5470180", VA = "0x185471180", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x5471680", Offset = "0x5470680", VA = "0x185471680", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x5471590", Offset = "0x5470590", VA = "0x185471590", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x54719F0", Offset = "0x54709F0", VA = "0x1854719F0")]
		public IKSolverLimb()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x5471A80", Offset = "0x5470A80", VA = "0x185471A80")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x5471790", Offset = "0x5470790", VA = "0x185471790")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x54703D0", Offset = "0x546F3D0", VA = "0x1854703D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x56BB030", Offset = "0x56BA030", VA = "0x1856BB030")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x56BAFF0", Offset = "0x56B9FF0", VA = "0x1856BAFF0")]
			public LookAtBone()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x56BB000", Offset = "0x56BA000", VA = "0x1856BB000")]
			public LookAtBone(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x56BAD70", Offset = "0x56B9D70", VA = "0x1856BAD70")]
			public void Initiate(Transform root)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x56BAE90", Offset = "0x56B9E90", VA = "0x1856BAE90")]
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
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x1FF400", Offset = "0x1FE800")]
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
			[Cpp2IlInjected.Address(RVA = "0x54744C0", Offset = "0x54734C0", VA = "0x1854744C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected bool spineIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x54744A0", Offset = "0x54734A0", VA = "0x1854744A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected bool headIsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x5474490", Offset = "0x5473490", VA = "0x185474490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected bool headIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x5474420", Offset = "0x5473420", VA = "0x185474420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected bool eyesIsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x5474330", Offset = "0x5473330", VA = "0x185474330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected bool eyesIsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x5474310", Offset = "0x5473310", VA = "0x185474310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x5468560", Offset = "0x5467560", VA = "0x185468560")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5473050", Offset = "0x5472050", VA = "0x185473050")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x54730B0", Offset = "0x54720B0", VA = "0x1854730B0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x5472FB0", Offset = "0x5471FB0", VA = "0x185472FB0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x5473130", Offset = "0x5472130", VA = "0x185473130")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x5473210", Offset = "0x5472210", VA = "0x185473210")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x5473F10", Offset = "0x5472F10", VA = "0x185473F10", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x5472FA0", Offset = "0x5471FA0", VA = "0x185472FA0")]
		public void SetDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x5471B40", Offset = "0x5470B40", VA = "0x185471B40", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x5472510", Offset = "0x5471510", VA = "0x185472510", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5472200", Offset = "0x5471200", VA = "0x185472200", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x5472040", Offset = "0x5471040", VA = "0x185472040", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x5472EE0", Offset = "0x5471EE0", VA = "0x185472EE0")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5472840", Offset = "0x5471840", VA = "0x185472840", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5472C30", Offset = "0x5471C30", VA = "0x185472C30", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x5473C00", Offset = "0x5472C00", VA = "0x185473C00")]
		protected void SolveSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x54738B0", Offset = "0x54728B0", VA = "0x1854738B0")]
		protected void SolveHead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x5473320", Offset = "0x5472320", VA = "0x185473320")]
		protected void SolveEyes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5471CD0", Offset = "0x5470CD0", VA = "0x185471CD0")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5472D10", Offset = "0x5471D10", VA = "0x185472D10")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5474070", Offset = "0x5473070", VA = "0x185474070")]
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
			[Cpp2IlInjected.Address(RVA = "0x56C1470", Offset = "0x56C0470", VA = "0x1856C1470")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x56C13F0", Offset = "0x56C03F0", VA = "0x1856C13F0")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x56C1370", Offset = "0x56C0370", VA = "0x1856C1370")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x56BAFF0", Offset = "0x56B9FF0", VA = "0x1856BAFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5476330", Offset = "0x5475330", VA = "0x185476330")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x54765A0", Offset = "0x54755A0", VA = "0x1854765A0")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x3E83B00", Offset = "0x3E82B00", VA = "0x183E83B00")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x5476840", Offset = "0x5475840", VA = "0x185476840")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x15AA400", Offset = "0x15A9400", VA = "0x1815AA400")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x12EDDC0", Offset = "0x12ECDC0", VA = "0x1812EDDC0")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5474C60", Offset = "0x5473C60", VA = "0x185474C60", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5474B00", Offset = "0x5473B00", VA = "0x185474B00", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5477080", Offset = "0x5476080", VA = "0x185477080", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x54745B0", Offset = "0x54735B0", VA = "0x1854745B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x54751F0", Offset = "0x54741F0", VA = "0x1854751F0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x54767B0", Offset = "0x54757B0", VA = "0x1854767B0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x5476870", Offset = "0x5475870", VA = "0x185476870")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x5474930", Offset = "0x5473930", VA = "0x185474930")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x54756E0", Offset = "0x54746E0", VA = "0x1854756E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x54750C0", Offset = "0x54740C0", VA = "0x1854750C0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x5474DE0", Offset = "0x5473DE0", VA = "0x185474DE0")]
		private void InitiateBones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x54758F0", Offset = "0x54748F0", VA = "0x1854758F0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x5474610", Offset = "0x5473610", VA = "0x185474610")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x54770D0", Offset = "0x54760D0", VA = "0x1854770D0")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x5C4AB0", Offset = "0x5C3EB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x16F1AB0", Offset = "0x16F0AB0", VA = "0x1816F1AB0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0x16F0EC0", Offset = "0x16EFEC0", VA = "0x1816F0EC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public Quaternion rotation
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0x157FFE0", Offset = "0x157EFE0", VA = "0x18157FFE0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x157FD00", Offset = "0x157ED00", VA = "0x18157FD00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			private VirtualBone shoulder
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0x56AFAA0", Offset = "0x56AEAA0", VA = "0x1856AFAA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			private VirtualBone upperArm
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x56AFAE0", Offset = "0x56AEAE0", VA = "0x1856AFAE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			private VirtualBone forearm
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x56AF9E0", Offset = "0x56AE9E0", VA = "0x1856AF9E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			private VirtualBone hand
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x56AFA40", Offset = "0x56AEA40", VA = "0x1856AFA40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x56AB9E0", Offset = "0x56AA9E0", VA = "0x1856AB9E0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x56AC6F0", Offset = "0x56AB6F0", VA = "0x1856AC6F0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x56AB1E0", Offset = "0x56AA1E0", VA = "0x1856AB1E0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x56AEBB0", Offset = "0x56ADBB0", VA = "0x1856AEBB0")]
			private void Stretching()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x56ACA80", Offset = "0x56ABA80", VA = "0x1856ACA80")]
			public void Solve(bool isLeft)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x56ACA50", Offset = "0x56ABA50", VA = "0x1856ACA50", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x56AF3D0", Offset = "0x56AE3D0", VA = "0x1856AF3D0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x56AB270", Offset = "0x56AA270", VA = "0x1856AB270")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x56AB300", Offset = "0x56AA300", VA = "0x1856AB300")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x56AF290", Offset = "0x56AE290", VA = "0x1856AF290")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x56AF860", Offset = "0x56AE860", VA = "0x1856AF860")]
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
				[Cpp2IlInjected.Address(RVA = "0xE9F390", Offset = "0xE9E390", VA = "0x180E9F390")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0xE9F3A0", Offset = "0xE9E3A0", VA = "0x180E9F3A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public float mag
			{
				[Cpp2IlInjected.Token(Token = "0x6000462")]
				[Cpp2IlInjected.Address(RVA = "0xFCEC20", Offset = "0xFCDC20", VA = "0x180FCEC20")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0x117E430", Offset = "0x117D430", VA = "0x18117E430")]
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
			[Cpp2IlInjected.Address(RVA = "0xA8BF20", Offset = "0xA8AF20", VA = "0x180A8BF20")]
			public void SetLOD(int LOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x56B05F0", Offset = "0x56AF5F0", VA = "0x1856B05F0")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x56B0420", Offset = "0x56AF420", VA = "0x1856B0420")]
			public void MovePosition(Vector3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x56B0520", Offset = "0x56AF520", VA = "0x1856B0520")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x56B09F0", Offset = "0x56AF9F0", VA = "0x1856B09F0")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x56B0830", Offset = "0x56AF830", VA = "0x1856B0830")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x56B0700", Offset = "0x56AF700", VA = "0x1856B0700")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x56B0AF0", Offset = "0x56AFAF0", VA = "0x1856B0AF0")]
			public void Visualize(Color color)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x56B0C60", Offset = "0x56AFC60", VA = "0x1856B0C60")]
			public void Visualize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x56B0DF0", Offset = "0x56AFDF0", VA = "0x1856B0DF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x56B3C00", Offset = "0x56B2C00", VA = "0x1856B3C00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public float stepProgress
			{
				[Cpp2IlInjected.Token(Token = "0x600046F")]
				[Cpp2IlInjected.Address(RVA = "0x12C4340", Offset = "0x12C3340", VA = "0x1812C4340")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000470")]
				[Cpp2IlInjected.Address(RVA = "0x1A2BE50", Offset = "0x1A2AE50", VA = "0x181A2BE50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x56B3AB0", Offset = "0x56B2AB0", VA = "0x1856B3AB0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x56B3370", Offset = "0x56B2370", VA = "0x1856B3370")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x56B33C0", Offset = "0x56B23C0", VA = "0x1856B33C0")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x56B3760", Offset = "0x56B2760", VA = "0x1856B3760")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x56B35F0", Offset = "0x56B25F0", VA = "0x1856B35F0")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x56B3900", Offset = "0x56B2900", VA = "0x1856B3900")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x5C4D40", Offset = "0x5C4140")]
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
				[Cpp2IlInjected.Address(RVA = "0x42C26C0", Offset = "0x42C16C0", VA = "0x1842C26C0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000478")]
				[Cpp2IlInjected.Address(RVA = "0x56B7430", Offset = "0x56B6430", VA = "0x1856B7430")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public Quaternion rotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x2B19340", Offset = "0x2B18340", VA = "0x182B19340")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x2B195A0", Offset = "0x2B185A0", VA = "0x182B195A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public bool hasToes
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0x937270", Offset = "0x936270", VA = "0x180937270")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0x1E15BC0", Offset = "0x1E14BC0", VA = "0x181E15BC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public VirtualBone thigh
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0x56AFAA0", Offset = "0x56AEAA0", VA = "0x1856AFAA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			private VirtualBone calf
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0x56B7330", Offset = "0x56B6330", VA = "0x1856B7330")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			private VirtualBone foot
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0x56B7370", Offset = "0x56B6370", VA = "0x1856B7370")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			private VirtualBone toes
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0x56B73F0", Offset = "0x56B63F0", VA = "0x1856B73F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public VirtualBone lastBone
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0x56B73B0", Offset = "0x56B63B0", VA = "0x1856B73B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public Vector3 thighRelativeToPelvis
			{
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x546D150", Offset = "0x546C150", VA = "0x18546D150")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0x546D370", Offset = "0x546C370", VA = "0x18546D370")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x56B5080", Offset = "0x56B4080", VA = "0x1856B5080", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x56B5B50", Offset = "0x56B4B50", VA = "0x1856B5B50", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x56B3F70", Offset = "0x56B2F70", VA = "0x1856B3F70", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x56B4860", Offset = "0x56B3860", VA = "0x1856B4860")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x56B4950", Offset = "0x56B3950", VA = "0x1856B4950")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x56B6410", Offset = "0x56B5410", VA = "0x1856B6410")]
			public void Solve(bool stretch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x56B4B90", Offset = "0x56B3B90", VA = "0x1856B4B90")]
			private void FixTwistRotations()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x56B6780", Offset = "0x56B5780", VA = "0x1856B6780")]
			private void Stretching()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x56B6E40", Offset = "0x56B5E40", VA = "0x1856B6E40", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x56B63A0", Offset = "0x56B53A0", VA = "0x1856B63A0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x56B71F0", Offset = "0x56B61F0", VA = "0x1856B71F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x155BE70", Offset = "0x155AE70", VA = "0x18155BE70")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0x155BF50", Offset = "0x155AF50", VA = "0x18155BF50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public Vector3 leftFootstepPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x56BAC10", Offset = "0x56B9C10", VA = "0x1856BAC10")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public Vector3 rightFootstepPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0x56BACC0", Offset = "0x56B9CC0", VA = "0x1856BACC0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public Quaternion leftFootstepRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x56BAC70", Offset = "0x56B9C70", VA = "0x1856BAC70")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public Quaternion rightFootstepRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600049A")]
				[Cpp2IlInjected.Address(RVA = "0x56BAD20", Offset = "0x56B9D20", VA = "0x1856BAD20")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x56B7E40", Offset = "0x56B6E40", VA = "0x1856B7E40")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x56B8450", Offset = "0x56B7450", VA = "0x1856B8450")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x56B83E0", Offset = "0x56B73E0", VA = "0x1856B83E0")]
			public void Relax()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x56B7610", Offset = "0x56B6610", VA = "0x1856B7610")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x56B7450", Offset = "0x56B6450", VA = "0x1856B7450")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x56B87D0", Offset = "0x56B77D0", VA = "0x1856B87D0")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x56BA900", Offset = "0x56B9900", VA = "0x1856BA900")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x56B7BD0", Offset = "0x56B6BD0", VA = "0x1856B7BD0")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x56B7C50", Offset = "0x56B6C50", VA = "0x1856B7C50")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x56BAAE0", Offset = "0x56B9AE0", VA = "0x1856BAAE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x56C1310", Offset = "0x56C0310", VA = "0x1856C1310")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public VirtualBone firstSpineBone
			{
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0x56C1250", Offset = "0x56C0250", VA = "0x1856C1250")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public VirtualBone chest
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0x56C11E0", Offset = "0x56C01E0", VA = "0x1856C11E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			private VirtualBone neck
			{
				[Cpp2IlInjected.Token(Token = "0x60004A2")]
				[Cpp2IlInjected.Address(RVA = "0x56C12D0", Offset = "0x56C02D0", VA = "0x1856C12D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public VirtualBone head
			{
				[Cpp2IlInjected.Token(Token = "0x60004A3")]
				[Cpp2IlInjected.Address(RVA = "0x56C1290", Offset = "0x56C0290", VA = "0x1856C1290")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Quaternion anchorRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60004A4")]
				[Cpp2IlInjected.Address(RVA = "0x56C11D0", Offset = "0x56C01D0", VA = "0x1856C11D0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60004A5")]
				[Cpp2IlInjected.Address(RVA = "0x56C1360", Offset = "0x56C0360", VA = "0x1856C1360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public Quaternion anchorRelativeToHead
			{
				[Cpp2IlInjected.Token(Token = "0x60004A6")]
				[Cpp2IlInjected.Address(RVA = "0x54CEE70", Offset = "0x54CDE70", VA = "0x1854CEE70")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60004A7")]
				[Cpp2IlInjected.Address(RVA = "0x56C1350", Offset = "0x56C0350", VA = "0x1856C1350")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x56BE7B0", Offset = "0x56BD7B0", VA = "0x1856BE7B0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x56BF5F0", Offset = "0x56BE5F0", VA = "0x1856BF5F0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x56BCFF0", Offset = "0x56BBFF0", VA = "0x1856BCFF0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x56BDD30", Offset = "0x56BCD30", VA = "0x1856BDD30")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x56BFD80", Offset = "0x56BED80", VA = "0x1856BFD80")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x56BDF10", Offset = "0x56BCF10", VA = "0x1856BDF10")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x56BF9D0", Offset = "0x56BE9D0", VA = "0x1856BF9D0")]
			private void SolvePelvis()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x56C0D00", Offset = "0x56BFD00", VA = "0x1856C0D00", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x56BF920", Offset = "0x56BE920", VA = "0x1856BF920", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x56BCAC0", Offset = "0x56BBAC0", VA = "0x1856BCAC0")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x56BE210", Offset = "0x56BD210", VA = "0x1856BE210")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x56C05A0", Offset = "0x56BF5A0", VA = "0x1856C05A0")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x56BE420", Offset = "0x56BD420", VA = "0x1856BE420")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x56BDAA0", Offset = "0x56BCAA0", VA = "0x1856BDAA0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x56BD740", Offset = "0x56BC740", VA = "0x1856BD740")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x56C0FD0", Offset = "0x56BFFD0", VA = "0x1856C0FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x56C45A0", Offset = "0x56C35A0", VA = "0x1856C45A0")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x56C27E0", Offset = "0x56C17E0", VA = "0x1856C27E0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x56C4350", Offset = "0x56C3350", VA = "0x1856C4350")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x56C2450", Offset = "0x56C1450", VA = "0x1856C2450")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x56C2810", Offset = "0x56C1810", VA = "0x1856C2810")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x56C2C40", Offset = "0x56C1C40", VA = "0x1856C2C40")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x56C2A20", Offset = "0x56C1A20", VA = "0x1856C2A20")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x56C2E60", Offset = "0x56C1E60", VA = "0x1856C2E60")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x56C3990", Offset = "0x56C2990", VA = "0x1856C3990")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x56C2280", Offset = "0x56C1280", VA = "0x1856C2280")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x56C3310", Offset = "0x56C2310", VA = "0x1856C3310")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x56C31F0", Offset = "0x56C21F0", VA = "0x1856C31F0")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x56C2F40", Offset = "0x56C1F40", VA = "0x1856C2F40")]
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
		[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x5C45D0", Offset = "0x5C39D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x739120", Offset = "0x738120", VA = "0x180739120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x739210", Offset = "0x738210", VA = "0x180739210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x5479EB0", Offset = "0x5478EB0", VA = "0x185479EB0")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x5478A90", Offset = "0x5477A90", VA = "0x185478A90")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x5477940", Offset = "0x5476940", VA = "0x185477940")]
		public void DefaultAnimationCurves()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x5477360", Offset = "0x5476360", VA = "0x185477360")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x5477700", Offset = "0x5476700", VA = "0x185477700")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x5477840", Offset = "0x5476840", VA = "0x185477840")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x54771D0", Offset = "0x54761D0", VA = "0x1854771D0")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x5479D60", Offset = "0x5478D60", VA = "0x185479D60")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x547BD50", Offset = "0x547AD50", VA = "0x18547BD50", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x5477AE0", Offset = "0x5476AE0", VA = "0x185477AE0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x5478820", Offset = "0x5477820", VA = "0x185478820", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x54787C0", Offset = "0x54777C0", VA = "0x1854787C0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x5478DA0", Offset = "0x5477DA0", VA = "0x185478DA0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x5477D30", Offset = "0x5476D30", VA = "0x185477D30")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x5478920", Offset = "0x5477920", VA = "0x185478920")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x547BF30", Offset = "0x547AF30", VA = "0x18547BF30")]
		private void UpdateSolverTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x5479040", Offset = "0x5478040", VA = "0x185479040", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x54790A0", Offset = "0x54780A0", VA = "0x1854790A0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x547C0F0", Offset = "0x547B0F0", VA = "0x18547C0F0")]
		private void WriteTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x5479640", Offset = "0x5478640", VA = "0x185479640")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x547A240", Offset = "0x5479240", VA = "0x18547A240")]
		private void Solve()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x5478880", Offset = "0x5477880", VA = "0x185478880")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x54788D0", Offset = "0x54778D0", VA = "0x1854788D0")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x547C6B0", Offset = "0x547B6B0", VA = "0x18547C6B0")]
		private void Write()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x5478030", Offset = "0x5477030", VA = "0x185478030")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x547C870", Offset = "0x547B870", VA = "0x18547C870")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAF160", Offset = "0x4BAE160", VA = "0x184BAF160")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x4BAF0A0", Offset = "0x4BAE0A0", VA = "0x184BAF0A0")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x4BAEEB0", Offset = "0x4BADEB0", VA = "0x184BAEEB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x4BAEF70", Offset = "0x4BADF70", VA = "0x184BAEF70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x4BAF350", Offset = "0x4BAE350", VA = "0x184BAF350")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAFFB0", Offset = "0x4BAEFB0", VA = "0x184BAFFB0")]
		public TwistSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x4BAF3B0", Offset = "0x4BAE3B0", VA = "0x184BAF3B0")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x4BAFA80", Offset = "0x4BAEA80", VA = "0x184BAFA80")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A040", Offset = "0x649040", VA = "0x18064A040")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x66AF30", Offset = "0x669F30", VA = "0x18066AF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public bool isPaused
		{
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x73AEB0", Offset = "0x739EB0", VA = "0x18073AEB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x8738C0", Offset = "0x8728C0", VA = "0x1808738C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public InteractionObject interactionObject
		{
			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x66A140", Offset = "0x669140", VA = "0x18066A140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public bool inInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x547F860", Offset = "0x547E860", VA = "0x18547F860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public float progress
		{
			[Cpp2IlInjected.Token(Token = "0x60004DC")]
			[Cpp2IlInjected.Address(RVA = "0x547F8C0", Offset = "0x547E8C0", VA = "0x18547F8C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x547F7D0", Offset = "0x547E7D0", VA = "0x18547F7D0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x547D3E0", Offset = "0x547C3E0", VA = "0x18547D3E0")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x547E8A0", Offset = "0x547D8A0", VA = "0x18547E8A0")]
		private void StoreDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x547DC30", Offset = "0x547CC30", VA = "0x18547DC30")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x547D7D0", Offset = "0x547C7D0", VA = "0x18547D7D0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x547E110", Offset = "0x547D110", VA = "0x18547E110")]
		public bool Resume()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x547E1C0", Offset = "0x547D1C0", VA = "0x18547E1C0")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x547ED70", Offset = "0x547DD70", VA = "0x18547ED70")]
		public void Update(Transform root, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x547EA90", Offset = "0x547DA90", VA = "0x18547EA90")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x547D940", Offset = "0x547C940", VA = "0x18547D940")]
		private void PickUp(Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x547E6E0", Offset = "0x547D6E0", VA = "0x18547E6E0")]
		public bool Stop()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x547D4A0", Offset = "0x547C4A0", VA = "0x18547D4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x547F940", Offset = "0x547E940", VA = "0x18547F940")]
		public void Look(Transform target, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x547FAD0", Offset = "0x547EAD0", VA = "0x18547FAD0")]
		public void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x547FD60", Offset = "0x547ED60", VA = "0x18547FD60")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x547FC40", Offset = "0x547EC40", VA = "0x18547FC40")]
		public void SolveSpine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x547FB70", Offset = "0x547EB70", VA = "0x18547FB70")]
		public void SolveHead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x547FFE0", Offset = "0x547EFE0", VA = "0x18547FFE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x56B3D30", Offset = "0x56B2D30", VA = "0x1856B3D30")]
			public void Activate(Transform t)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x56BB0A0", Offset = "0x56BA0A0", VA = "0x1856BB0A0")]
			public void Send(Transform t)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x56AAFE0", Offset = "0x56A9FE0", VA = "0x1856AAFE0")]
			public void Activate(bool pickUp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0x56AAE80", Offset = "0x56A9E80", VA = "0x1856AAE80")]
			private void Activate(Animator animator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x56AAF20", Offset = "0x56A9F20", VA = "0x1856AAF20")]
			private void Activate(Animation animation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0x56AB1D0", Offset = "0x56AA1D0", VA = "0x1856AB1D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x56C4600", Offset = "0x56C3600", VA = "0x1856C4600")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x56BB190", Offset = "0x56BA190", VA = "0x1856BB190")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0x3F9AAB0", Offset = "0x3F99AB0", VA = "0x183F9AAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x12EDDE0", Offset = "0x12ECDE0", VA = "0x1812EDDE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x21770E0", Offset = "0x21760E0", VA = "0x1821770E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x660760", Offset = "0x65F760", VA = "0x180660760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x6D4000", Offset = "0x6D3000", VA = "0x1806D4000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Transform lookAtTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x4F66870", Offset = "0x4F65870", VA = "0x184F66870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public Transform targetsRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x4F668F0", Offset = "0x4F658F0", VA = "0x184F668F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x4F66780", Offset = "0x4F65780", VA = "0x184F66780")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x4F66640", Offset = "0x4F65640", VA = "0x184F66640")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x4F66680", Offset = "0x4F65680", VA = "0x184F66680")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x4F666C0", Offset = "0x4F656C0", VA = "0x184F666C0")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x4F66700", Offset = "0x4F65700", VA = "0x184F66700")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x4F66740", Offset = "0x4F65740", VA = "0x184F66740")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x4F667D0", Offset = "0x4F657D0", VA = "0x184F667D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x4F64F70", Offset = "0x4F63F70", VA = "0x184F64F70")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x4F66380", Offset = "0x4F65380", VA = "0x184F66380")]
		public void Initiate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x4F65CC0", Offset = "0x4F64CC0", VA = "0x184F65CC0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x4F65B90", Offset = "0x4F64B90", VA = "0x184F65B90")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x64A0B0", Offset = "0x6490B0", VA = "0x18064A0B0")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x4F65EA0", Offset = "0x4F64EA0", VA = "0x184F65EA0")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x6D4000", Offset = "0x6D3000", VA = "0x1806D4000")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x4F65600", Offset = "0x4F64600", VA = "0x184F65600")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x4F66040", Offset = "0x4F65040", VA = "0x184F66040")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x4F667C0", Offset = "0x4F657C0", VA = "0x184F667C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x4F64FB0", Offset = "0x4F63FB0", VA = "0x184F64FB0")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x4F65E20", Offset = "0x4F64E20", VA = "0x184F65E20")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x4F66310", Offset = "0x4F65310", VA = "0x184F66310")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x4F65C50", Offset = "0x4F64C50", VA = "0x184F65C50")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x4F66810", Offset = "0x4F65810", VA = "0x184F66810")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F6B1B0", Offset = "0x4F6A1B0", VA = "0x184F6B1B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public FullBodyBipedIK ik
		{
			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x739200", Offset = "0x738200", VA = "0x180739200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x739250", Offset = "0x738250", VA = "0x180739250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public List<InteractionTrigger> triggersInRange
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x64A0D0", Offset = "0x6490D0", VA = "0x18064A0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x72D4A0", Offset = "0x72C4A0", VA = "0x18072D4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public bool initiated
		{
			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0xA8BE00", Offset = "0xA8AE00", VA = "0x180A8BE00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0xA8BF30", Offset = "0xA8AF30", VA = "0x180A8BF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x4F68C30", Offset = "0x4F67C30", VA = "0x184F68C30")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x4F68AF0", Offset = "0x4F67AF0", VA = "0x184F68AF0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x4F68B30", Offset = "0x4F67B30", VA = "0x184F68B30")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x4F68B70", Offset = "0x4F67B70", VA = "0x184F68B70")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x4F68BB0", Offset = "0x4F67BB0", VA = "0x184F68BB0")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x4F68BF0", Offset = "0x4F67BF0", VA = "0x184F68BF0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x4F697F0", Offset = "0x4F687F0", VA = "0x184F697F0")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x4F66C10", Offset = "0x4F65C10", VA = "0x184F66C10")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x4F67AC0", Offset = "0x4F66AC0", VA = "0x184F67AC0")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x4F67DC0", Offset = "0x4F66DC0", VA = "0x184F67DC0")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x4F67CD0", Offset = "0x4F66CD0", VA = "0x184F67CD0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x4F67B90", Offset = "0x4F66B90", VA = "0x184F67B90")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x4F69000", Offset = "0x4F68000", VA = "0x184F69000")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x4F68D00", Offset = "0x4F67D00", VA = "0x184F68D00")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x4F68F70", Offset = "0x4F67F70", VA = "0x184F68F70")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x4F69760", Offset = "0x4F68760", VA = "0x184F69760")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x4F68C70", Offset = "0x4F67C70", VA = "0x184F68C70")]
		public void PauseAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x4F68EE0", Offset = "0x4F67EE0", VA = "0x184F68EE0")]
		public void ResumeAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x4F696E0", Offset = "0x4F686E0", VA = "0x184F696E0")]
		public void StopAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x4F67710", Offset = "0x4F66710", VA = "0x184F67710")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x4F678B0", Offset = "0x4F668B0", VA = "0x184F678B0")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x4F677A0", Offset = "0x4F667A0", VA = "0x184F677A0")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A220", Offset = "0x4F69220", VA = "0x184F6A220")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x4F69FC0", Offset = "0x4F68FC0", VA = "0x184F69FC0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x4F69C80", Offset = "0x4F68C80", VA = "0x184F69C80")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x4F67190", Offset = "0x4F66190", VA = "0x184F67190")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x4F66FF0", Offset = "0x4F65FF0", VA = "0x184F66FF0")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x4F67290", Offset = "0x4F66290", VA = "0x184F67290")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x4F67040", Offset = "0x4F66040", VA = "0x184F67040")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x4F67320", Offset = "0x4F66320", VA = "0x184F67320")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x4F69830", Offset = "0x4F68830", VA = "0x184F69830")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x4F67940", Offset = "0x4F66940", VA = "0x184F67940")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x4F674D0", Offset = "0x4F664D0", VA = "0x184F674D0")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x4F69110", Offset = "0x4F68110", VA = "0x184F69110")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x4F67A80", Offset = "0x4F66A80", VA = "0x184F67A80")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x4F67AA0", Offset = "0x4F66AA0", VA = "0x184F67AA0")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x4F67AA0", Offset = "0x4F66AA0", VA = "0x184F67AA0")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x4F67F80", Offset = "0x4F66F80", VA = "0x184F67F80")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x4F688D0", Offset = "0x4F678D0", VA = "0x184F688D0")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x4F689F0", Offset = "0x4F679F0", VA = "0x184F689F0")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x4F66C50", Offset = "0x4F65C50", VA = "0x184F66C50")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x4F684C0", Offset = "0x4F674C0", VA = "0x184F684C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A870", Offset = "0x4F69870", VA = "0x184F6A870")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x4F68D90", Offset = "0x4F67D90", VA = "0x184F68D90")]
		private void Raycasting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A570", Offset = "0x4F69570", VA = "0x184F6A570")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A400", Offset = "0x4F69400", VA = "0x184F6A400")]
		private void UpdateEffectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x4F686F0", Offset = "0x4F676F0", VA = "0x184F686F0")]
		private void OnPreFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x4F68610", Offset = "0x4F67610", VA = "0x184F68610")]
		private void OnPostFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x4F685E0", Offset = "0x4F675E0", VA = "0x184F685E0")]
		private void OnFixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x4F68050", Offset = "0x4F67050", VA = "0x184F68050")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x4F67E90", Offset = "0x4F66E90", VA = "0x184F67E90")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x4F69B60", Offset = "0x4F68B60", VA = "0x184F69B60")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x4F6AC10", Offset = "0x4F69C10", VA = "0x184F6AC10")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F6B490", Offset = "0x4F6A490", VA = "0x184F6B490")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B350", Offset = "0x4F6A350", VA = "0x184F6B350")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B390", Offset = "0x4F6A390", VA = "0x184F6B390")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B3D0", Offset = "0x4F6A3D0", VA = "0x184F6B3D0")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B410", Offset = "0x4F6A410", VA = "0x184F6B410")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B450", Offset = "0x4F6A450", VA = "0x184F6B450")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x4F6BD60", Offset = "0x4F6AD60", VA = "0x184F6BD60")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B2A0", Offset = "0x4F6A2A0", VA = "0x184F6B2A0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B2E0", Offset = "0x4F6A2E0", VA = "0x184F6B2E0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B4D0", Offset = "0x4F6A4D0", VA = "0x184F6B4D0")]
		public void ResetRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B560", Offset = "0x4F6A560", VA = "0x184F6B560")]
		public void RotateTo(Transform bone)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x4F6BDA0", Offset = "0x4F6ADA0", VA = "0x184F6BDA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x56B2D80", Offset = "0x56B1D80", VA = "0x1856B2D80")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public Vector3 direction3D
			{
				[Cpp2IlInjected.Token(Token = "0x6000568")]
				[Cpp2IlInjected.Address(RVA = "0x56B2CE0", Offset = "0x56B1CE0", VA = "0x1856B2CE0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x56B2520", Offset = "0x56B1520", VA = "0x1856B2520")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(RVA = "0x56B2CC0", Offset = "0x56B1CC0", VA = "0x1856B2CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x56B1F80", Offset = "0x56B0F80", VA = "0x1856B1F80")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(RVA = "0x56B20E0", Offset = "0x56B10E0", VA = "0x1856B20E0")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x56B24A0", Offset = "0x56B14A0", VA = "0x1856B24A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x56BC410", Offset = "0x56BB410", VA = "0x1856BC410")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x1BF2D00", Offset = "0x1BF1D00", VA = "0x181BF2D00")]
			public Range()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C0B0", Offset = "0x4F6B0B0", VA = "0x184F6C0B0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C030", Offset = "0x4F6B030", VA = "0x184F6C030")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C070", Offset = "0x4F6B070", VA = "0x184F6C070")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C0F0", Offset = "0x4F6B0F0", VA = "0x184F6C0F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x4F6BDF0", Offset = "0x4F6ADF0", VA = "0x184F6BDF0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x4F6BE30", Offset = "0x4F6AE30", VA = "0x184F6BE30")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C130", Offset = "0x4F6B130", VA = "0x184F6C130")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BA9800", Offset = "0x4BA8800", VA = "0x184BA9800")]
			public Map(Transform bone, Transform target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4E30", Offset = "0x4BA3E30", VA = "0x184BA4E30")]
			public void StoreDefaultState()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x4BA9610", Offset = "0x4BA8610", VA = "0x184BA9610")]
			public void FixTransform()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x4BA9670", Offset = "0x4BA8670", VA = "0x184BA9670")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public Map[] maps;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x53AFC70", Offset = "0x53AEC70", VA = "0x1853AFC70", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x53B00C0", Offset = "0x53AF0C0", VA = "0x1853B00C0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x53B0150", Offset = "0x53AF150", VA = "0x1853B0150", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x53AFF90", Offset = "0x53AEF90", VA = "0x1853AFF90", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x53B00D0", Offset = "0x53AF0D0", VA = "0x1853B00D0")]
		private void StoreDefaultState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x53B0010", Offset = "0x53AF010", VA = "0x1853B0010")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x53B0260", Offset = "0x53AF260", VA = "0x1853B0260")]
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
		[Cpp2IlInjected.Address(RVA = "0x5451B20", Offset = "0x5450B20", VA = "0x185451B20", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x5451D40", Offset = "0x5450D40", VA = "0x185451D40", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x5451BF0", Offset = "0x5450BF0", VA = "0x185451BF0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x5451F80", Offset = "0x5450F80", VA = "0x185451F80", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x5451DA0", Offset = "0x5450DA0", VA = "0x185451DA0")]
		protected void StoreDefaultState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x53B0260", Offset = "0x53AF260", VA = "0x1853B0260")]
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
		[Cpp2IlInjected.Address(RVA = "0x76E0F0", Offset = "0x76D0F0", VA = "0x18076E0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F76390", Offset = "0x4F75390", VA = "0x184F76390", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x4F76360", Offset = "0x4F75360", VA = "0x184F76360", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x4F76340", Offset = "0x4F75340", VA = "0x184F76340", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x4F763E0", Offset = "0x4F753E0", VA = "0x184F763E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x56BC8F0", Offset = "0x56BB8F0", VA = "0x1856BC8F0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x56BC520", Offset = "0x56BB520", VA = "0x1856BC520")]
			public void RecordVelocity()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x56BC660", Offset = "0x56BB660", VA = "0x1856BC660")]
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
			[Cpp2IlInjected.Address(RVA = "0x56B2FC0", Offset = "0x56B1FC0", VA = "0x1856B2FC0")]
			public Child(Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x56B2DA0", Offset = "0x56B1DA0", VA = "0x1856B2DA0")]
			public void FixTransform(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x56B2F60", Offset = "0x56B1F60", VA = "0x1856B2F60")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x56C1620", Offset = "0x56C0620", VA = "0x1856C1620", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x56C1890", Offset = "0x56C0890", VA = "0x1856C1890", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F79150", Offset = "0x4F78150", VA = "0x184F79150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private bool ikUsed
		{
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x4F79000", Offset = "0x4F78000", VA = "0x184F79000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x4F77D90", Offset = "0x4F76D90", VA = "0x184F77D90")]
		public void EnableRagdoll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x4F77C40", Offset = "0x4F76C40", VA = "0x184F77C40")]
		public void DisableRagdoll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x4F78600", Offset = "0x4F77600", VA = "0x184F78600")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x4F77BD0", Offset = "0x4F76BD0", VA = "0x184F77BD0")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x4F78B70", Offset = "0x4F77B70", VA = "0x184F78B70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x4F77E80", Offset = "0x4F76E80", VA = "0x184F77E80")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x4F77F10", Offset = "0x4F76F10", VA = "0x184F77F10")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x4F77BA0", Offset = "0x4F76BA0", VA = "0x184F77BA0")]
		private void AfterLastIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x4F77AD0", Offset = "0x4F76AD0", VA = "0x184F77AD0")]
		private void AfterAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x4F78180", Offset = "0x4F77180", VA = "0x184F78180")]
		private void OnFinalPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x4F78260", Offset = "0x4F77260", VA = "0x184F78260")]
		private void RagdollEnabler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x4F785A0", Offset = "0x4F775A0", VA = "0x184F785A0")]
		private void RecordVelocities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x4F78B10", Offset = "0x4F77B10", VA = "0x184F78B10")]
		private void StoreLocalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x4F77E10", Offset = "0x4F76E10", VA = "0x184F77E10")]
		private void FixTransforms(float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x4F78050", Offset = "0x4F77050", VA = "0x184F78050")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x4F78F00", Offset = "0x4F77F00", VA = "0x184F78F00")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F7E080", Offset = "0x4F7D080", VA = "0x184F7E080")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Vector3 crossAxis
		{
			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x4F7E010", Offset = "0x4F7D010", VA = "0x184F7E010")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool defaultLocalRotationOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x6A7880", Offset = "0x6A6880", VA = "0x1806A7880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0xDE1A50", Offset = "0xDE0A50", VA = "0x180DE1A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DF80", Offset = "0x4F7CF80", VA = "0x184F7DF80")]
		public void SetDefaultLocalRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DFC0", Offset = "0x4F7CFC0", VA = "0x184F7DFC0")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x4F7D990", Offset = "0x4F7C990", VA = "0x184F7D990")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x4F7D6E0", Offset = "0x4F7C6E0", VA = "0x184F7D6E0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x4F7D960", Offset = "0x4F7C960", VA = "0x184F7D960")]
		public void Disable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x4F7D860", Offset = "0x4F7C860", VA = "0x184F7D860")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DB50", Offset = "0x4F7CB50", VA = "0x184F7DB50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DF50", Offset = "0x4F7CF50", VA = "0x184F7DF50")]
		public void LogWarning(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DCD0", Offset = "0x4F7CCD0", VA = "0x184F7DCD0")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DD90", Offset = "0x4F7CD90", VA = "0x184F7DD90")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DAD0", Offset = "0x4F7CAD0", VA = "0x184F7DAD0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DFD0", Offset = "0x4F7CFD0", VA = "0x184F7DFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F7B080", Offset = "0x4F7A080", VA = "0x184F7B080")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B040", Offset = "0x4F7A040", VA = "0x184F7B040")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B0C0", Offset = "0x4F7A0C0", VA = "0x184F7B0C0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x4F7AB90", Offset = "0x4F79B90", VA = "0x184F7AB90")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x4F7ABD0", Offset = "0x4F79BD0", VA = "0x184F7ABD0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x4F7AE40", Offset = "0x4F79E40", VA = "0x184F7AE40")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B100", Offset = "0x4F7A100", VA = "0x184F7B100")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F7B4B0", Offset = "0x4F7A4B0", VA = "0x184F7B4B0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B470", Offset = "0x4F7A470", VA = "0x184F7B470")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B4F0", Offset = "0x4F7A4F0", VA = "0x184F7B4F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B150", Offset = "0x4F7A150", VA = "0x184F7B150")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B430", Offset = "0x4F7A430", VA = "0x184F7B430", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B190", Offset = "0x4F7A190", VA = "0x184F7B190")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B530", Offset = "0x4F7A530", VA = "0x184F7B530")]
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
				[Cpp2IlInjected.Address(RVA = "0x5DDD700", Offset = "0x5DDC700", VA = "0x185DDD700")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			public Vector3 a
			{
				[Cpp2IlInjected.Token(Token = "0x60005D9")]
				[Cpp2IlInjected.Address(RVA = "0x5DDD630", Offset = "0x5DDC630", VA = "0x185DDD630")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public Vector3 b
			{
				[Cpp2IlInjected.Token(Token = "0x60005DA")]
				[Cpp2IlInjected.Address(RVA = "0x5DDD670", Offset = "0x5DDC670", VA = "0x185DDD670")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public Vector3 c
			{
				[Cpp2IlInjected.Token(Token = "0x60005DB")]
				[Cpp2IlInjected.Address(RVA = "0x5DDD6B0", Offset = "0x5DDC6B0", VA = "0x185DDD6B0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public bool isValid
			{
				[Cpp2IlInjected.Token(Token = "0x60005DD")]
				[Cpp2IlInjected.Address(RVA = "0x5DDD6F0", Offset = "0x5DDC6F0", VA = "0x185DDD6F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD480", Offset = "0x5DDC480", VA = "0x185DDD480")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD230", Offset = "0x5DDC230", VA = "0x185DDD230")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DDCF80", Offset = "0x5DDBF80", VA = "0x185DDCF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F7C1E0", Offset = "0x4F7B1E0", VA = "0x184F7C1E0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x4F7C1A0", Offset = "0x4F7B1A0", VA = "0x184F7C1A0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x4F7D470", Offset = "0x4F7C470", VA = "0x184F7D470")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B580", Offset = "0x4F7A580", VA = "0x184F7B580")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x4F7C7D0", Offset = "0x4F7B7D0", VA = "0x184F7C7D0")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x4F7BD60", Offset = "0x4F7AD60", VA = "0x184F7BD60", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x4F7D0B0", Offset = "0x4F7C0B0", VA = "0x184F7D0B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x4F7C350", Offset = "0x4F7B350", VA = "0x184F7C350")]
		public void ResetToDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B5C0", Offset = "0x4F7A5C0", VA = "0x184F7B5C0")]
		public void BuildReachCones()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x4F7C860", Offset = "0x4F7B860", VA = "0x184F7C860")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x4F7BD10", Offset = "0x4F7AD10", VA = "0x184F7BD10")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x4F7C220", Offset = "0x4F7B220", VA = "0x184F7C220")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x4F7D4B0", Offset = "0x4F7C4B0", VA = "0x184F7D4B0")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x4F7BE60", Offset = "0x4F7AE60", VA = "0x184F7BE60")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x4F7BB70", Offset = "0x4F7AB70", VA = "0x184F7BB70")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x4F7D660", Offset = "0x4F7C660", VA = "0x184F7D660")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAAC10", Offset = "0x4BA9C10", VA = "0x184BAAC10")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x4BAABD0", Offset = "0x4BA9BD0", VA = "0x184BAABD0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x4BAAC70", Offset = "0x4BA9C70", VA = "0x184BAAC70")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA7D0", Offset = "0x4BA97D0", VA = "0x184BAA7D0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x4BAAC50", Offset = "0x4BA9C50", VA = "0x184BAAC50")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA810", Offset = "0x4BA9810", VA = "0x184BAA810", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA8F0", Offset = "0x4BA98F0", VA = "0x184BAA8F0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x4BAACB0", Offset = "0x4BA9CB0", VA = "0x184BAACB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x4BB0940", Offset = "0x4BAF940", VA = "0x184BB0940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x4BB0A20", Offset = "0x4BAFA20", VA = "0x184BB0A20", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5300790", Offset = "0x52FF790", VA = "0x185300790")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x5300580", Offset = "0x52FF580", VA = "0x185300580")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x52FF580", Offset = "0x52FE580", VA = "0x1852FF580")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x52FF410", Offset = "0x52FE410", VA = "0x1852FF410")]
		private void ApplyMinDistance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x5300280", Offset = "0x52FF280", VA = "0x185300280")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x5300680", Offset = "0x52FF680", VA = "0x185300680")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x53006F0", Offset = "0x52FF6F0", VA = "0x1853006F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BAA040", Offset = "0x4BA9040", VA = "0x184BAA040")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x1482C10", Offset = "0x1481C10", VA = "0x181482C10")]
			public void SetAngleBuffer(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x4BAA290", Offset = "0x4BA9290", VA = "0x184BAA290")]
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
		[Cpp2IlInjected.Address(RVA = "0x5300A60", Offset = "0x52FFA60", VA = "0x185300A60")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x5300B70", Offset = "0x52FFB70", VA = "0x185300B70")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x5300C00", Offset = "0x52FFC00", VA = "0x185300C00")]
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
				[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BA3900", Offset = "0x4BA2900", VA = "0x184BA3900")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x4BA38A0", Offset = "0x4BA28A0", VA = "0x184BA38A0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x4BA3F90", Offset = "0x4BA2F90", VA = "0x184BA3F90")]
			public Body()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x5300D80", Offset = "0x52FFD80", VA = "0x185300D80", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x5300ED0", Offset = "0x52FFED0", VA = "0x185300ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53145D0", Offset = "0x53135D0", VA = "0x1853145D0", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x53143D0", Offset = "0x53133D0", VA = "0x1853143D0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x5314620", Offset = "0x5313620", VA = "0x185314620")]
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
		[Cpp2IlInjected.Address(RVA = "0x5314A90", Offset = "0x5313A90", VA = "0x185314A90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x5314640", Offset = "0x5313640", VA = "0x185314640")]
		private void BeforeIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x5314970", Offset = "0x5313970", VA = "0x185314970")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x1670140", Offset = "0x166F140", VA = "0x181670140")]
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
			[Cpp2IlInjected.Address(RVA = "0x6606F0", Offset = "0x65F6F0", VA = "0x1806606F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x6E2AE0", Offset = "0x6E1AE0", VA = "0x1806E2AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x539F580", Offset = "0x539E580", VA = "0x18539F580")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x539F480", Offset = "0x539E480", VA = "0x18539F480")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x539F310", Offset = "0x539E310", VA = "0x18539F310")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x539F720", Offset = "0x539E720", VA = "0x18539F720")]
		public void StoreDefaultPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x539F0B0", Offset = "0x539E0B0", VA = "0x18539F0B0")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x539F940", Offset = "0x539E940", VA = "0x18539F940")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x539FC60", Offset = "0x539EC60", VA = "0x18539FC60")]
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
			[Cpp2IlInjected.Address(RVA = "0x539F090", Offset = "0x539E090", VA = "0x18539F090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x539EE70", Offset = "0x539DE70", VA = "0x18539EE70")]
		public void Store(Transform[] T)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x539ECC0", Offset = "0x539DCC0", VA = "0x18539ECC0")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x539F010", Offset = "0x539E010", VA = "0x18539F010")]
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
				[Cpp2IlInjected.Address(RVA = "0x4BA6A90", Offset = "0x4BA5A90", VA = "0x184BA6A90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			protected float crossFader
			{
				[Cpp2IlInjected.Token(Token = "0x600061A")]
				[Cpp2IlInjected.Address(RVA = "0x12E7610", Offset = "0x12E6610", VA = "0x1812E7610")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600061B")]
				[Cpp2IlInjected.Address(RVA = "0x1555AC0", Offset = "0x1554AC0", VA = "0x181555AC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B3")]
			protected float timer
			{
				[Cpp2IlInjected.Token(Token = "0x600061C")]
				[Cpp2IlInjected.Address(RVA = "0x1118820", Offset = "0x1117820", VA = "0x181118820")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600061D")]
				[Cpp2IlInjected.Address(RVA = "0x1118810", Offset = "0x1117810", VA = "0x181118810")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B4")]
			protected Vector3 force
			{
				[Cpp2IlInjected.Token(Token = "0x600061E")]
				[Cpp2IlInjected.Address(RVA = "0x1A2C4C0", Offset = "0x1A2B4C0", VA = "0x181A2C4C0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600061F")]
				[Cpp2IlInjected.Address(RVA = "0x1A2DEA0", Offset = "0x1A2CEA0", VA = "0x181A2DEA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B5")]
			protected Vector3 point
			{
				[Cpp2IlInjected.Token(Token = "0x6000620")]
				[Cpp2IlInjected.Address(RVA = "0x12E1390", Offset = "0x12E0390", VA = "0x1812E1390")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000621")]
				[Cpp2IlInjected.Address(RVA = "0x1212130", Offset = "0x1211130", VA = "0x181212130")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x4BA6970", Offset = "0x4BA5970", VA = "0x184BA6970")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x4BA68A0", Offset = "0x4BA58A0", VA = "0x184BA68A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BA64C0", Offset = "0x4BA54C0", VA = "0x184BA64C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5DDBB60", Offset = "0x5DDAB60", VA = "0x185DDBB60")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600062D")]
				[Cpp2IlInjected.Address(RVA = "0x5DDBCD0", Offset = "0x5DDACD0", VA = "0x185DDBCD0")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600062E")]
				[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BA6530", Offset = "0x4BA5530", VA = "0x184BA6530", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x4BA64D0", Offset = "0x4BA54D0", VA = "0x184BA64D0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x4BA6680", Offset = "0x4BA5680", VA = "0x184BA6680", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x4BA64C0", Offset = "0x4BA54C0", VA = "0x184BA64C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5DDB9F0", Offset = "0x5DDA9F0", VA = "0x185DDB9F0")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000634")]
				[Cpp2IlInjected.Address(RVA = "0x5DDBB10", Offset = "0x5DDAB10", VA = "0x185DDBB10")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000635")]
				[Cpp2IlInjected.Address(RVA = "0x5DDBB20", Offset = "0x5DDAB20", VA = "0x185DDBB20")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BA61C0", Offset = "0x4BA51C0", VA = "0x184BA61C0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x4BA6160", Offset = "0x4BA5160", VA = "0x184BA6160", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x4BA6260", Offset = "0x4BA5260", VA = "0x184BA6260", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x4BA64C0", Offset = "0x4BA54C0", VA = "0x184BA64C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5453FE0", Offset = "0x5452FE0", VA = "0x185453FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x5453EE0", Offset = "0x5452EE0", VA = "0x185453EE0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x5453C50", Offset = "0x5452C50", VA = "0x185453C50")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x5300ED0", Offset = "0x52FFED0", VA = "0x185300ED0")]
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
				[Cpp2IlInjected.Address(RVA = "0x12E7610", Offset = "0x12E6610", VA = "0x1812E7610")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600063A")]
				[Cpp2IlInjected.Address(RVA = "0x1555AC0", Offset = "0x1554AC0", VA = "0x181555AC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B7")]
			protected float timer
			{
				[Cpp2IlInjected.Token(Token = "0x600063B")]
				[Cpp2IlInjected.Address(RVA = "0x1118820", Offset = "0x1117820", VA = "0x181118820")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600063C")]
				[Cpp2IlInjected.Address(RVA = "0x1118810", Offset = "0x1117810", VA = "0x181118810")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B8")]
			protected Vector3 force
			{
				[Cpp2IlInjected.Token(Token = "0x600063D")]
				[Cpp2IlInjected.Address(RVA = "0x1A2C4C0", Offset = "0x1A2B4C0", VA = "0x181A2C4C0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x600063E")]
				[Cpp2IlInjected.Address(RVA = "0x1A2DEA0", Offset = "0x1A2CEA0", VA = "0x181A2DEA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B9")]
			protected Vector3 point
			{
				[Cpp2IlInjected.Token(Token = "0x600063F")]
				[Cpp2IlInjected.Address(RVA = "0x12E1390", Offset = "0x12E0390", VA = "0x1812E1390")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x6000640")]
				[Cpp2IlInjected.Address(RVA = "0x1212130", Offset = "0x1211130", VA = "0x181212130")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x4BA9B10", Offset = "0x4BA8B10", VA = "0x184BA9B10")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x4BA9A20", Offset = "0x4BA8A20", VA = "0x184BA9A20")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BA64C0", Offset = "0x4BA54C0", VA = "0x184BA64C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5DDD110", Offset = "0x5DDC110", VA = "0x185DDD110")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600064C")]
				[Cpp2IlInjected.Address(RVA = "0x5DDBCD0", Offset = "0x5DDACD0", VA = "0x185DDBCD0")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600064D")]
				[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BAA310", Offset = "0x4BA9310", VA = "0x184BAA310", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x4BAA2B0", Offset = "0x4BA92B0", VA = "0x184BAA2B0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x4BAA530", Offset = "0x4BA9530", VA = "0x184BAA530", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x4BAA7B0", Offset = "0x4BA97B0", VA = "0x184BAA7B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5DDF240", Offset = "0x5DDE240", VA = "0x185DDF240")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000653")]
				[Cpp2IlInjected.Address(RVA = "0x5DDF330", Offset = "0x5DDE330", VA = "0x185DDF330")]
				public void CrossFadeStart()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000654")]
				[Cpp2IlInjected.Address(RVA = "0x5DDF340", Offset = "0x5DDE340", VA = "0x185DDF340")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BAAD20", Offset = "0x4BA9D20", VA = "0x184BAAD20", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x4BAACC0", Offset = "0x4BA9CC0", VA = "0x184BAACC0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x4BAAE40", Offset = "0x4BA9E40", VA = "0x184BAAE40", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x4BA64C0", Offset = "0x4BA54C0", VA = "0x184BA64C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5453B60", Offset = "0x5452B60", VA = "0x185453B60", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x54538C0", Offset = "0x54528C0", VA = "0x1854538C0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x5300ED0", Offset = "0x52FFED0", VA = "0x185300ED0")]
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
				[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x56B0E60", Offset = "0x56AFE60", VA = "0x1856B0E60")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x56B0F40", Offset = "0x56AFF40", VA = "0x1856B0F40")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0x56B14A0", Offset = "0x56B04A0", VA = "0x1856B14A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x547CC20", Offset = "0x547BC20", VA = "0x18547CC20")]
		public void ResetBodies()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x547CB50", Offset = "0x547BB50", VA = "0x18547CB50", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x5300ED0", Offset = "0x52FFED0", VA = "0x185300ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F6EC80", Offset = "0x4F6DC80", VA = "0x184F6EC80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x4F6EB40", Offset = "0x4F6DB40", VA = "0x184F6EB40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DEE0", Offset = "0x4F6CEE0", VA = "0x184F6DEE0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DD70", Offset = "0x4F6CD70", VA = "0x184F6DD70")]
		private void ApplyMinDistance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x4F6E8A0", Offset = "0x4F6D8A0", VA = "0x184F6E8A0")]
		private void RootRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x4F6EC10", Offset = "0x4F6DC10", VA = "0x184F6EC10")]
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
			[Cpp2IlInjected.Address(RVA = "0x56BB2C0", Offset = "0x56BA2C0", VA = "0x1856BB2C0")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x56BB490", Offset = "0x56BA490", VA = "0x1856BB490")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x56BB510", Offset = "0x56BA510", VA = "0x1856BB510")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x56C1AA0", Offset = "0x56C0AA0", VA = "0x1856C1AA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x56C1C30", Offset = "0x56C0C30", VA = "0x1856C1C30", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F736E0", Offset = "0x4F726E0", VA = "0x184F736E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void OnModifyOffset();

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x4F73A60", Offset = "0x4F72A60", VA = "0x184F73A60", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x4F737F0", Offset = "0x4F727F0", VA = "0x184F737F0")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x4F73860", Offset = "0x4F72860", VA = "0x184F73860")]
		private void ModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x4F73700", Offset = "0x4F72700", VA = "0x184F73700")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x4F73940", Offset = "0x4F72940", VA = "0x184F73940", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x1605770", Offset = "0x1604770", VA = "0x181605770")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x56C18D0", Offset = "0x56C08D0", VA = "0x1856C18D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0x56C1A60", Offset = "0x56C0A60", VA = "0x1856C1A60", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F736E0", Offset = "0x4F726E0", VA = "0x184F736E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void OnModifyOffset();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x4F73660", Offset = "0x4F72660", VA = "0x184F73660", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x4F733F0", Offset = "0x4F723F0", VA = "0x184F733F0")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x4F73460", Offset = "0x4F72460", VA = "0x184F73460")]
		private void ModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x4F73540", Offset = "0x4F72540", VA = "0x184F73540", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x1605770", Offset = "0x1604770", VA = "0x181605770")]
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
			[Cpp2IlInjected.Address(RVA = "0x56B3050", Offset = "0x56B2050", VA = "0x1856B3050")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public EffectorLink()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public EffectorLink[] effectorLinks;

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x4F73AE0", Offset = "0x4F72AE0", VA = "0x184F73AE0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x4F73BD0", Offset = "0x4F72BD0", VA = "0x184F73BD0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x4F73CA0", Offset = "0x4F72CA0", VA = "0x184F73CA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x56B0010", Offset = "0x56AF010", VA = "0x1856B0010")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0x56AFB40", Offset = "0x56AEB40", VA = "0x1856AFB40")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x56AFD10", Offset = "0x56AED10", VA = "0x1856AFD10")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x56B03A0", Offset = "0x56AF3A0", VA = "0x1856B03A0")]
			public Avoider()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x4F74A50", Offset = "0x4F73A50", VA = "0x184F74A50", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x1605770", Offset = "0x1604770", VA = "0x181605770")]
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
				[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DDD9F0", Offset = "0x5DDC9F0", VA = "0x185DDD9F0")]
			public void Start()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD740", Offset = "0x5DDC740", VA = "0x185DDD740")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDAA0", Offset = "0x5DDCAA0", VA = "0x185DDDAA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F7A830", Offset = "0x4F79830", VA = "0x184F7A830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private IKEffector primaryHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x4F7A850", Offset = "0x4F79850", VA = "0x184F7A850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private IKEffector secondaryHandEffector
		{
			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x4F7A8F0", Offset = "0x4F798F0", VA = "0x184F7A8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		private Transform primaryHand
		{
			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0x4F7A8A0", Offset = "0x4F798A0", VA = "0x184F7A8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		private Transform secondaryHand
		{
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x4F7A940", Offset = "0x4F79940", VA = "0x184F7A940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x4F7A780", Offset = "0x4F79780", VA = "0x184F7A780")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x4F794B0", Offset = "0x4F784B0", VA = "0x184F794B0")]
		public void Fire(float magnitude)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x4F79860", Offset = "0x4F78860", VA = "0x184F79860", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x4F79300", Offset = "0x4F78300", VA = "0x184F79300")]
		private void AfterFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x4F792B0", Offset = "0x4F782B0", VA = "0x184F792B0")]
		private void AfterAimIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x4F79650", Offset = "0x4F78650", VA = "0x184F79650", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x4F7A7B0", Offset = "0x4F797B0", VA = "0x184F7A7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAC7E0", Offset = "0x4BAB7E0", VA = "0x184BAC7E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x4BAC6E0", Offset = "0x4BAB6E0", VA = "0x184BAC6E0")]
		private void RotateShoulders()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x4BAC1B0", Offset = "0x4BAB1B0", VA = "0x184BAC1B0")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x4BAC050", Offset = "0x4BAB050", VA = "0x184BAC050")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x4BAC090", Offset = "0x4BAB090", VA = "0x184BAC090")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x4BAC8E0", Offset = "0x4BAB8E0", VA = "0x184BAC8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DDF380", Offset = "0x5DDE380", VA = "0x185DDF380")]
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
				[Cpp2IlInjected.Address(RVA = "0x5DDF4D0", Offset = "0x5DDE4D0", VA = "0x185DDF4D0")]
				public Target(Transform t)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006B5")]
				[Cpp2IlInjected.Address(RVA = "0x5DDF460", Offset = "0x5DDE460", VA = "0x185DDF460")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public CalibrationData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x4BB8440", Offset = "0x4BB7440", VA = "0x184BB8440")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x4BB84C0", Offset = "0x4BB74C0", VA = "0x184BB84C0")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x4BB51C0", Offset = "0x4BB41C0", VA = "0x184BB51C0")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x4BB5000", Offset = "0x4BB4000", VA = "0x184BB5000")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x4BB6220", Offset = "0x4BB5220", VA = "0x184BB6220")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x4BB4490", Offset = "0x4BB3490", VA = "0x184BB4490")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x4BB51E0", Offset = "0x4BB41E0", VA = "0x184BB51E0")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x4BB4D70", Offset = "0x4BB3D70", VA = "0x184BB4D70")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x4BB5FB0", Offset = "0x4BB4FB0", VA = "0x184BB5FB0")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x4BB3E80", Offset = "0x4BB2E80", VA = "0x184BB3E80")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x4BB32E0", Offset = "0x4BB22E0", VA = "0x184BB32E0")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x4BB3B80", Offset = "0x4BB2B80", VA = "0x184BB3B80")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x4BB3630", Offset = "0x4BB2630", VA = "0x184BB3630")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x4BB8260", Offset = "0x4BB7260", VA = "0x184BB8260")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x4BB7D50", Offset = "0x4BB6D50", VA = "0x184BB7D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BB86C0", Offset = "0x4BB76C0", VA = "0x184BB86C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x4BB8710", Offset = "0x4BB7710", VA = "0x184BB8710")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x4BB8530", Offset = "0x4BB7530", VA = "0x184BB8530")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x4BB88D0", Offset = "0x4BB78D0", VA = "0x184BB88D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x10DFCD0", Offset = "0x10DECD0", VA = "0x1810DFCD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0x10DFCA0", Offset = "0x10DECA0", VA = "0x1810DFCA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x4BB91D0", Offset = "0x4BB81D0", VA = "0x184BB91D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x4BB94D0", Offset = "0x4BB84D0", VA = "0x184BB94D0")]
		public void Calibrate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x4BB92F0", Offset = "0x4BB82F0", VA = "0x184BB92F0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x4BB9870", Offset = "0x4BB8870", VA = "0x184BB9870")]
		private void OnPreUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x4BB9750", Offset = "0x4BB8750", VA = "0x184BB9750")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BA98B0", Offset = "0x4BA88B0", VA = "0x184BA98B0")]
			public void Apply(Animator animator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x53AAF60", Offset = "0x53A9F60", VA = "0x1853AAF60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x53AAE00", Offset = "0x53A9E00", VA = "0x1853AAE00")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x53AAE70", Offset = "0x53A9E70", VA = "0x1853AAE70")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x52FF350", Offset = "0x52FE350", VA = "0x1852FF350")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x5300C60", Offset = "0x52FFC60", VA = "0x185300C60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x5300D40", Offset = "0x52FFD40", VA = "0x185300D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAC010", Offset = "0x4BAB010", VA = "0x184BAC010")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x4BABD60", Offset = "0x4BAAD60", VA = "0x184BABD60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BACF50", Offset = "0x4BABF50", VA = "0x184BACF50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x4BAC990", Offset = "0x4BAB990", VA = "0x184BAC990")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x4BACCE0", Offset = "0x4BABCE0", VA = "0x184BACCE0")]
		private void Pose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x4BACAE0", Offset = "0x4BABAE0", VA = "0x184BACAE0")]
		private void LimitAimTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x4BAC900", Offset = "0x4BAB900", VA = "0x184BAC900")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x4BACF90", Offset = "0x4BABF90", VA = "0x184BACF90")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAE450", Offset = "0x4BAD450", VA = "0x184BAE450")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE210", Offset = "0x4BAD210", VA = "0x184BAE210")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE700", Offset = "0x4BAD700", VA = "0x184BAE700")]
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
		[Cpp2IlInjected.Address(RVA = "0x53097F0", Offset = "0x53087F0", VA = "0x1853097F0")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x530A000", Offset = "0x5309000", VA = "0x18530A000")]
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
			[Cpp2IlInjected.Address(RVA = "0x1CFB6B0", Offset = "0x1CFA6B0", VA = "0x181CFB6B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0x4F71B80", Offset = "0x4F70B80", VA = "0x184F71B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x4F710E0", Offset = "0x4F700E0", VA = "0x184F710E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x4F71120", Offset = "0x4F70120", VA = "0x184F71120")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x4F70BC0", Offset = "0x4F6FBC0", VA = "0x184F70BC0")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x4F70D40", Offset = "0x4F6FD40", VA = "0x184F70D40")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x4F71B30", Offset = "0x4F70B30", VA = "0x184F71B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F6F210", Offset = "0x4F6E210", VA = "0x184F6F210")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x4F6EF10", Offset = "0x4F6DF10", VA = "0x184F6EF10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x4F6F1F0", Offset = "0x4F6E1F0", VA = "0x184F6F1F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x56C1C70", Offset = "0x56C0C70", VA = "0x1856C1C70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x56C2090", Offset = "0x56C1090", VA = "0x1856C2090", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F70700", Offset = "0x4F6F700", VA = "0x184F70700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x4F70720", Offset = "0x4F6F720", VA = "0x184F70720")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x4F70780", Offset = "0x4F6F780", VA = "0x184F70780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x4F6F4B0", Offset = "0x4F6E4B0", VA = "0x184F6F4B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x4F6F290", Offset = "0x4F6E290", VA = "0x184F6F290")]
		private void AfterIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x4F6FB90", Offset = "0x4F6EB90", VA = "0x184F6FB90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x4F6F710", Offset = "0x4F6E710", VA = "0x184F6F710")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x4F70040", Offset = "0x4F6F040", VA = "0x184F70040")]
		private void UpdatePosition(float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x4F70310", Offset = "0x4F6F310", VA = "0x184F70310")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x4F6FF90", Offset = "0x4F6EF90", VA = "0x184F6FF90")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x4F70680", Offset = "0x4F6F680", VA = "0x184F70680")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F707D0", Offset = "0x4F6F7D0", VA = "0x184F707D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x4F70890", Offset = "0x4F6F890", VA = "0x184F70890")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x5301670", Offset = "0x5300670", VA = "0x185301670", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x5300EE0", Offset = "0x52FFEE0", VA = "0x185300EE0")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x5301220", Offset = "0x5300220", VA = "0x185301220", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x5301170", Offset = "0x5300170", VA = "0x185301170")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x5300ED0", Offset = "0x52FFED0", VA = "0x185300ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5302E00", Offset = "0x5301E00", VA = "0x185302E00", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x5302B70", Offset = "0x5301B70", VA = "0x185302B70")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x53028F0", Offset = "0x53018F0", VA = "0x1853028F0", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x5302E50", Offset = "0x5301E50", VA = "0x185302E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x5302650", Offset = "0x5301650", VA = "0x185302650", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x5301D50", Offset = "0x5300D50", VA = "0x185301D50", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x53024F0", Offset = "0x53014F0", VA = "0x1853024F0")]
		private void Read()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x5301690", Offset = "0x5300690", VA = "0x185301690")]
		private void AimIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x53016F0", Offset = "0x53006F0", VA = "0x1853016F0")]
		private void FBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x5302120", Offset = "0x5301120", VA = "0x185302120")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x5301AF0", Offset = "0x5300AF0", VA = "0x185301AF0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x5301FF0", Offset = "0x5300FF0", VA = "0x185301FF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x53028C0", Offset = "0x53018C0", VA = "0x1853028C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53168E0", Offset = "0x53158E0", VA = "0x1853168E0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x53164B0", Offset = "0x53154B0", VA = "0x1853164B0", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x5316720", Offset = "0x5315720", VA = "0x185316720")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x53169B0", Offset = "0x53159B0", VA = "0x1853169B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x53181E0", Offset = "0x53171E0", VA = "0x1853181E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		private static Vector3 inputVectorRaw
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x5318160", Offset = "0x5317160", VA = "0x185318160")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x53180F0", Offset = "0x53170F0", VA = "0x1853180F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x5317DC0", Offset = "0x5316DC0", VA = "0x185317DC0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x539FCC0", Offset = "0x539ECC0", VA = "0x18539FCC0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x5300ED0", Offset = "0x52FFED0", VA = "0x185300ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53A0670", Offset = "0x539F670", VA = "0x1853A0670")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x53A0730", Offset = "0x539F730", VA = "0x1853A0730")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x53A05B0", Offset = "0x539F5B0", VA = "0x1853A05B0")]
		private void SetEffectorWeights(float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x53A0D70", Offset = "0x539FD70", VA = "0x1853A0D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BA9590", Offset = "0x4BA8590", VA = "0x184BA9590")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x10C9030", Offset = "0x10C8030", VA = "0x1810C9030")]
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
		[Cpp2IlInjected.Address(RVA = "0x53A6520", Offset = "0x53A5520", VA = "0x1853A6520")]
		public void UpdateSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x53A6490", Offset = "0x53A5490", VA = "0x1853A6490")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x53A66A0", Offset = "0x53A56A0", VA = "0x1853A66A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x53A66B0", Offset = "0x53A56B0", VA = "0x1853A66B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53A66C0", Offset = "0x53A56C0", VA = "0x1853A66C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x53A6720", Offset = "0x53A5720", VA = "0x1853A6720")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x53A6A10", Offset = "0x53A5A10", VA = "0x1853A6A10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x53A6800", Offset = "0x53A5800", VA = "0x1853A6800")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x53AA390", Offset = "0x53A9390", VA = "0x1853AA390")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x53AAD60", Offset = "0x53A9D60", VA = "0x1853AAD60")]
		private void OnPreRead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x53AA480", Offset = "0x53A9480", VA = "0x1853AA480")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x53AAC30", Offset = "0x53A9C30", VA = "0x1853AAC30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x53AC450", Offset = "0x53AB450", VA = "0x1853AC450")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x53AB3D0", Offset = "0x53AA3D0", VA = "0x1853AB3D0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x53AB3E0", Offset = "0x53AA3E0", VA = "0x1853AB3E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x53AAFB0", Offset = "0x53A9FB0", VA = "0x1853AAFB0")]
		private void Aiming()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x53AB500", Offset = "0x53AA500", VA = "0x1853AB500")]
		private void LookDownTheSight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x53AC1D0", Offset = "0x53AB1D0", VA = "0x1853AC1D0")]
		private void RotateCharacter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x53AC650", Offset = "0x53AB650", VA = "0x1853AC650")]
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
		[Cpp2IlInjected.Address(RVA = "0x53AC740", Offset = "0x53AB740", VA = "0x1853AC740")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x53AC7C0", Offset = "0x53AB7C0", VA = "0x1853AC7C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x53AC680", Offset = "0x53AB680", VA = "0x1853AC680")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x12015A0", Offset = "0x12005A0", VA = "0x1812015A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5453410", Offset = "0x5452410", VA = "0x185453410")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x5453340", Offset = "0x5452340", VA = "0x185453340")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x1670140", Offset = "0x166F140", VA = "0x181670140")]
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
		[Cpp2IlInjected.Address(RVA = "0x5454520", Offset = "0x5453520", VA = "0x185454520")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x54540B0", Offset = "0x54530B0", VA = "0x1854540B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x54546A0", Offset = "0x54536A0", VA = "0x1854546A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x547CF80", Offset = "0x547BF80", VA = "0x18547CF80")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x547CDB0", Offset = "0x547BDB0", VA = "0x18547CDB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x547D030", Offset = "0x547C030", VA = "0x18547D030")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F66970", Offset = "0x4F65970", VA = "0x184F66970")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x4F669C0", Offset = "0x4F659C0", VA = "0x184F669C0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
				[Cpp2IlInjected.Address(RVA = "0x56BC120", Offset = "0x56BB120", VA = "0x1856BC120")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x53A10E0", Offset = "0x53A00E0", VA = "0x1853A10E0")]
			public void Initiate()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x56BB7E0", Offset = "0x56BA7E0", VA = "0x1856BB7E0")]
			public void Update(float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x56BB580", Offset = "0x56BA580", VA = "0x1856BB580")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x56BC0F0", Offset = "0x56BB0F0", VA = "0x1856BC0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F6D190", Offset = "0x4F6C190", VA = "0x184F6D190")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D130", Offset = "0x4F6C130", VA = "0x184F6D130")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D1D0", Offset = "0x4F6C1D0", VA = "0x184F6D1D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x56AACD0", Offset = "0x56A9CD0", VA = "0x1856AACD0")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x56AAE00", Offset = "0x56A9E00", VA = "0x1856AAE00")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x56AAB20", Offset = "0x56A9B20", VA = "0x1856AAB20")]
			public void SetPosition(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x56AAC20", Offset = "0x56A9C20", VA = "0x1856AAC20")]
			public void SetRotation(float w)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000755")]
			[Cpp2IlInjected.Address(RVA = "0x56AAE40", Offset = "0x56A9E40", VA = "0x1856AAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F72210", Offset = "0x4F71210", VA = "0x184F72210", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x4F71EF0", Offset = "0x4F70EF0", VA = "0x184F71EF0")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x4F720C0", Offset = "0x4F710C0", VA = "0x184F720C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x4F71E50", Offset = "0x4F70E50", VA = "0x184F71E50")]
		private void AfterIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x4F71F90", Offset = "0x4F70F90", VA = "0x184F71F90", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x4F72300", Offset = "0x4F71300", VA = "0x184F72300")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F71B90", Offset = "0x4F70B90", VA = "0x184F71B90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x4F71D90", Offset = "0x4F70D90", VA = "0x184F71D90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x4F71C10", Offset = "0x4F70C10", VA = "0x184F71C10")]
		private void SwingStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x16DF150", Offset = "0x16DE150", VA = "0x1816DF150")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F9AAB0", Offset = "0x3F99AB0", VA = "0x183F9AAB0")]
			public EffectorLink()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public EffectorLink[] effectorLinks;

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x4F732A0", Offset = "0x4F722A0", VA = "0x184F732A0", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x4F73050", Offset = "0x4F72050", VA = "0x184F73050", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x1605770", Offset = "0x1604770", VA = "0x181605770")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F74650", Offset = "0x4F73650", VA = "0x184F74650")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x4F73D00", Offset = "0x4F72D00", VA = "0x184F73D00")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x4F74A00", Offset = "0x4F73A00", VA = "0x184F74A00")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F75870", Offset = "0x4F74870", VA = "0x184F75870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private bool holdingLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(RVA = "0x4F75710", Offset = "0x4F74710", VA = "0x184F75710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private bool holdingRight
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x4F757C0", Offset = "0x4F747C0", VA = "0x184F757C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x4F75030", Offset = "0x4F74030", VA = "0x184F75030")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void RotatePivot();

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x4F75510", Offset = "0x4F74510", VA = "0x184F75510")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x4F75290", Offset = "0x4F74290", VA = "0x184F75290")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x4F75430", Offset = "0x4F74430", VA = "0x184F75430")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x4F74EE0", Offset = "0x4F73EE0", VA = "0x184F74EE0")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x4F74AD0", Offset = "0x4F73AD0", VA = "0x184F74AD0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x4F74CB0", Offset = "0x4F73CB0", VA = "0x184F74CB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x4F75700", Offset = "0x4F74700", VA = "0x184F75700")]
		protected PickUp2Handed()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	public class PickUpBox : PickUp2Handed
	{
		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x4F758A0", Offset = "0x4F748A0", VA = "0x184F758A0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x4F75700", Offset = "0x4F74700", VA = "0x184F75700")]
		public PickUpBox()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	public class PickUpSphere : PickUp2Handed
	{
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x4F75AF0", Offset = "0x4F74AF0", VA = "0x184F75AF0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x4F75700", Offset = "0x4F74700", VA = "0x184F75700")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F776E0", Offset = "0x4F766E0", VA = "0x184F776E0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x4F77730", Offset = "0x4F76730", VA = "0x184F77730")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F79210", Offset = "0x4F78210", VA = "0x184F79210")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x4F79260", Offset = "0x4F78260", VA = "0x184F79260")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x4F791C0", Offset = "0x4F781C0", VA = "0x184F791C0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x1605770", Offset = "0x1604770", VA = "0x181605770")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x5DDF740", Offset = "0x5DDE740", VA = "0x185DDF740", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x5DDF930", Offset = "0x5DDE930", VA = "0x185DDF930", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F7AAC0", Offset = "0x4F79AC0", VA = "0x184F7AAC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x4F7A990", Offset = "0x4F79990", VA = "0x184F7A990")]
		private void OnPickUp(Transform t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x4F7AA40", Offset = "0x4F79A40", VA = "0x184F7AA40")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x1605770", Offset = "0x1604770", VA = "0x181605770")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x5DDF590", Offset = "0x5DDE590", VA = "0x185DDF590", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x5DDF700", Offset = "0x5DDE700", VA = "0x185DDF700", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BADAC0", Offset = "0x4BACAC0", VA = "0x184BADAC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x4BADA50", Offset = "0x4BACA50", VA = "0x184BADA50")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DDC010", Offset = "0x5DDB010", VA = "0x185DDC010")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x5DDBEE0", Offset = "0x5DDAEE0", VA = "0x185DDBEE0")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x5DDC700", Offset = "0x5DDB700", VA = "0x185DDC700")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x5DDC590", Offset = "0x5DDB590", VA = "0x185DDC590")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x5DDC490", Offset = "0x5DDB490", VA = "0x185DDC490")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x5DDC410", Offset = "0x5DDB410", VA = "0x185DDC410")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x5DDC510", Offset = "0x5DDB510", VA = "0x185DDC510")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x5DDBCF0", Offset = "0x5DDACF0", VA = "0x185DDBCF0")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x5DDCF40", Offset = "0x5DDBF40", VA = "0x185DDCF40")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAE8A0", Offset = "0x4BAD8A0", VA = "0x184BAE8A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE750", Offset = "0x4BAD750", VA = "0x184BAE750")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE7D0", Offset = "0x4BAD7D0", VA = "0x184BAE7D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAE910", Offset = "0x4BAD910", VA = "0x184BAE910")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE950", Offset = "0x4BAD950", VA = "0x184BAE950")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x4BAEAB0", Offset = "0x4BADAB0", VA = "0x184BAEAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BB0590", Offset = "0x4BAF590", VA = "0x184BB0590")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0160", Offset = "0x4BAF160", VA = "0x184BB0160")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0060", Offset = "0x4BAF060", VA = "0x184BB0060")]
		private void AfterFBBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0470", Offset = "0x4BAF470", VA = "0x184BB0470")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BB0F40", Offset = "0x4BAFF40", VA = "0x184BB0F40", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0DE0", Offset = "0x4BAFDE0", VA = "0x184BB0DE0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x4BB1030", Offset = "0x4BB0030", VA = "0x184BB1030")]
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
		[Cpp2IlInjected.Address(RVA = "0x53B1680", Offset = "0x53B0680", VA = "0x1853B1680")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x53B15F0", Offset = "0x53B05F0", VA = "0x1853B15F0")]
		public void Activate(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x56C20D0", Offset = "0x56C10D0", VA = "0x1856C20D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x56C2240", Offset = "0x56C1240", VA = "0x1856C2240", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F76130", Offset = "0x4F75130", VA = "0x184F76130")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x4F75CF0", Offset = "0x4F74CF0", VA = "0x184F75CF0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x4F762A0", Offset = "0x4F752A0", VA = "0x184F762A0")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x4F75F80", Offset = "0x4F74F80", VA = "0x184F75F80")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x4F76060", Offset = "0x4F75060", VA = "0x184F76060")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x4F76310", Offset = "0x4F75310", VA = "0x184F76310")]
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
		[Cpp2IlInjected.Address(RVA = "0x5307FE0", Offset = "0x5306FE0", VA = "0x185307FE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x5307F10", Offset = "0x5306F10", VA = "0x185307F10")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x1670140", Offset = "0x166F140", VA = "0x181670140")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DDCFC0", Offset = "0x5DDBFC0", VA = "0x185DDCFC0")]
			public void AimAt(Transform target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAEE40", Offset = "0x4BADE40", VA = "0x184BAEE40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x54536D0", Offset = "0x54526D0", VA = "0x1854536D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x5453600", Offset = "0x5452600", VA = "0x185453600")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x1670140", Offset = "0x166F140", VA = "0x181670140")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BB2D60", Offset = "0x4BB1D60", VA = "0x184BB2D60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2FE0", Offset = "0x4BB1FE0", VA = "0x184BB2FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BB3050", Offset = "0x4BB2050", VA = "0x184BB3050")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x4BB3270", Offset = "0x4BB2270", VA = "0x184BB3270")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BB9130", Offset = "0x4BB8130", VA = "0x184BB9130")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x4BB8F40", Offset = "0x4BB7F40", VA = "0x184BB8F40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x4BB91A0", Offset = "0x4BB81A0", VA = "0x184BB91A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BB88F0", Offset = "0x4BB78F0", VA = "0x184BB88F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x4BB8F10", Offset = "0x4BB7F10", VA = "0x184BB8F10")]
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
			[Cpp2IlInjected.Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x11E6200", Offset = "0x11E5200", VA = "0x1811E6200", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x5315C90", Offset = "0x5314C90", VA = "0x185315C90")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x5315FC0", Offset = "0x5314FC0", VA = "0x185315FC0", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x5315D00", Offset = "0x5314D00", VA = "0x185315D00", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x5315C80", Offset = "0x5314C80", VA = "0x185315C80", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x5315D10", Offset = "0x5314D10", VA = "0x185315D10")]
		private void SmoothFollow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x5316170", Offset = "0x5315170", VA = "0x185316170")]
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
		[Cpp2IlInjected.Address(RVA = "0x53162D0", Offset = "0x53152D0", VA = "0x1853162D0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x5316190", Offset = "0x5315190", VA = "0x185316190", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x5316330", Offset = "0x5315330", VA = "0x185316330")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x5316170", Offset = "0x5315170", VA = "0x185316170")]
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
			[Cpp2IlInjected.Address(RVA = "0x5317120", Offset = "0x5316120", VA = "0x185317120", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x5316B60", Offset = "0x5315B60", VA = "0x185316B60", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x53169E0", Offset = "0x53159E0", VA = "0x1853169E0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x5316BF0", Offset = "0x5315BF0", VA = "0x185316BF0", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x5316A20", Offset = "0x5315A20", VA = "0x185316A20")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x53169B0", Offset = "0x53159B0", VA = "0x1853169B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5317200", Offset = "0x5316200", VA = "0x185317200")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x5317B50", Offset = "0x5316B50", VA = "0x185317B50", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x5317450", Offset = "0x5316450", VA = "0x185317450", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x5315C90", Offset = "0x5314C90", VA = "0x185315C90")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x5317760", Offset = "0x5316760", VA = "0x185317760")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x5317990", Offset = "0x5316990", VA = "0x185317990")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x5317730", Offset = "0x5316730", VA = "0x185317730")]
		protected void HighFriction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x5317D60", Offset = "0x5316D60", VA = "0x185317D60")]
		protected void ZeroFriction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x53173C0", Offset = "0x53163C0", VA = "0x1853173C0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x5317D90", Offset = "0x5316D90", VA = "0x185317D90")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x4BB07C0", Offset = "0x4BAF7C0", VA = "0x184BB07C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x4BB0900", Offset = "0x4BAF900", VA = "0x184BB0900", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9BF180", Offset = "0x9BE180", VA = "0x1809BF180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x16EBC90", Offset = "0x16EAC90", VA = "0x1816EBC90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x531A810", Offset = "0x5319810", VA = "0x18531A810", Slot = "5")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x531A2E0", Offset = "0x53192E0", VA = "0x18531A2E0")]
		private void OnAnimatorMove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x531A1B0", Offset = "0x53191B0", VA = "0x18531A1B0", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x5318300", Offset = "0x5317300", VA = "0x185318300")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x531A9B0", Offset = "0x53199B0", VA = "0x18531A9B0", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x5319A60", Offset = "0x5318A60", VA = "0x185319A60", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x5319B40", Offset = "0x5318B40", VA = "0x185319B40")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x531AA70", Offset = "0x5319A70", VA = "0x18531AA70")]
		private void WallRun()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x5318260", Offset = "0x5317260", VA = "0x185318260")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x5318F10", Offset = "0x5317F10", VA = "0x185318F10")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x531A380", Offset = "0x5319380", VA = "0x18531A380", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x5318D00", Offset = "0x5317D00", VA = "0x185318D00")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x5319790", Offset = "0x5318790", VA = "0x185319790", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x5319700", Offset = "0x5318700", VA = "0x185319700")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__75))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x5319210", Offset = "0x5318210", VA = "0x185319210")]
		private void GroundCheck()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x531B310", Offset = "0x531A310", VA = "0x18531B310")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A7880", Offset = "0x6A6880", VA = "0x1806A7880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0xDE1A50", Offset = "0xDE0A50", VA = "0x180DE1A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD7C0", Offset = "0x4BAC7C0", VA = "0x184BAD7C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD850", Offset = "0x4BAC850", VA = "0x184BAD850")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD0F0", Offset = "0x4BAC0F0", VA = "0x184BAD0F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD410", Offset = "0x4BAC410", VA = "0x184BAD410")]
		private void Rotate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD130", Offset = "0x4BAC130", VA = "0x184BAD130")]
		private void Move()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD030", Offset = "0x4BAC030", VA = "0x184BAD030")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x4BACFB0", Offset = "0x4BABFB0", VA = "0x184BACFB0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD8B0", Offset = "0x4BAC8B0", VA = "0x184BAD8B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BB0A90", Offset = "0x4BAFA90", VA = "0x184BB0A90", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0B00", Offset = "0x4BAFB00", VA = "0x184BB0B00", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0A60", Offset = "0x4BAFA60", VA = "0x184BB0A60")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0DC0", Offset = "0x4BAFDC0", VA = "0x184BB0DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BB1050", Offset = "0x4BB0050", VA = "0x184BB1050", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x4BB1090", Offset = "0x4BB0090", VA = "0x184BB1090", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x4BB13C0", Offset = "0x4BB03C0", VA = "0x184BB13C0")]
		public UserControlThirdPerson()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x5302E80", Offset = "0x5301E80", VA = "0x185302E80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BAD980", Offset = "0x4BAC980", VA = "0x184BAD980")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD8D0", Offset = "0x4BAC8D0", VA = "0x184BAD8D0")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x4BADA40", Offset = "0x4BACA40", VA = "0x184BADA40")]
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
			[Cpp2IlInjected.Address(RVA = "0x2809230", Offset = "0x2808230", VA = "0x182809230")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000811")]
			[Cpp2IlInjected.Address(RVA = "0x2808BC0", Offset = "0x2807BC0", VA = "0x182808BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public State state
		{
			[Cpp2IlInjected.Token(Token = "0x6000812")]
			[Cpp2IlInjected.Address(RVA = "0x64A0E0", Offset = "0x6490E0", VA = "0x18064A0E0")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x6B1640", Offset = "0x6B0640", VA = "0x1806B1640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x4F72790", Offset = "0x4F71790", VA = "0x184F72790")]
		public void Initiate(Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x4F728A0", Offset = "0x4F718A0", VA = "0x184F728A0")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x4F72320", Offset = "0x4F71320", VA = "0x184F72320")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x4F72550", Offset = "0x4F71550", VA = "0x184F72550")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x4F72860", Offset = "0x4F71860", VA = "0x184F72860")]
		private void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x4F72740", Offset = "0x4F71740", VA = "0x184F72740")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x4F72D40", Offset = "0x4F71D40", VA = "0x184F72D40")]
		public void Visualize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x4F72FE0", Offset = "0x4F71FE0", VA = "0x184F72FE0")]
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
