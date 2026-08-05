using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using MVVMDatabinding;
using RRUI;
using RRUI.Data;
using RRUI.Dialogs;
using RRUI.Framework;
using RRUI.Framework.Views;
using RRUI.Navigation;
using RecNet;
using RecNet.Data;
using RecNet.Discovery;
using RecNet.Rooms;
using RecRoom.Analytics;
using RecRoom.Analytics.AccessInterfaces;
using RecRoom.Analytics.Statsig;
using RecRoom.AppUI.Data;
using RecRoom.Attributes;
using RecRoom.Core;
using RecRoom.Core.Creation;
using RecRoom.Core.DataStructures;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Maker.Core;
using RecRoom.Maker.MakerPenHUD;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.Preferences;
using RecRoom.Protobuf;
using RecRoom.Systems.Imposters;
using TMPro;
using UJect;
using UJect.Injection;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DisallowMultipleComponent]
public class SpriteFill : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	[Autofill(AutofillType.Self, false, false, false)]
	private SpriteRenderer spriteRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private Sprite originalSprite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Sprite RIUPUZDOVWD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private float fillAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	private bool fillClockwise;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	private int fillOrigin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	private AnimationCurve progressCurve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[Range(0f, 1f)]
	private float CLOJXMJNTLZ;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static Vector3[] NMKTABNDNRW;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static Vector3[] DRDWDGQCJIM;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static List<Vector2> EPTNVXUXARN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static List<ushort> GJUVPZXYYMA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float YLRTPXFSHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xDC9D30", Offset = "0xDC8930", VA = "0x180DC9D30")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8794E60", Offset = "0x8793A60", VA = "0x188794E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NTCUZVJTGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xF8CB90", Offset = "0xF8B790", VA = "0x180F8CB90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8794EE0", Offset = "0x8793AE0", VA = "0x188794EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HHFHKXRPRWS
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB31CA0", Offset = "0xB308A0", VA = "0x180B31CA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8794EF0", Offset = "0x8793AF0", VA = "0x188794EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8794B80", Offset = "0x8793780", VA = "0x188794B80")]
	public void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8793E20", Offset = "0x8792A20", VA = "0x188793E20")]
	public void ForceRegenerateSprite()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8793DE0", Offset = "0x87929E0", VA = "0x188793DE0")]
	private void CSUFMYGBZML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8794AF0", Offset = "0x87936F0", VA = "0x188794AF0")]
	private void RPVLAANMAVW()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8793D70", Offset = "0x8792970", VA = "0x188793D70")]
	private Vector4 CEREDQAJFUT(Sprite a)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8794BC0", Offset = "0x87937C0", VA = "0x188794BC0")]
	private Sprite XKYMSEORTMX(Sprite a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8793F00", Offset = "0x8792B00", VA = "0x188793F00")]
	private void RFOEJTMBCNT()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
	public SpriteFill()
	{
	}
}
namespace _LogRegistration.RecRoom_AppUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x878A2B0", Offset = "0x8788EB0", VA = "0x18878A2B0", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AppUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x879ABE0", Offset = "0x87997E0", VA = "0x18879ABE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RRUI.Data
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface RUQRXZAMGGP
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IsServerSearch
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string Tag
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string DisplayText
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		string TextColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RRUIGameObjectLayoutElement : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		protected float width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		protected float height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		protected bool LXUDOMODISP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool WALQPJYHYNR
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xDD0FC0", Offset = "0xDCFBC0", VA = "0x180DD0FC0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xC901B0", Offset = "0xC8EDB0", VA = "0x180C901B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public virtual float AEKETZPFTBR
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xB77D10", Offset = "0xB76910", VA = "0x180B77D10", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public virtual float HZJMCUEOHDY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xB6A410", Offset = "0xB69010", VA = "0x180B6A410", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xDD0CF0", Offset = "0xDCF8F0", VA = "0x180DD0CF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xDD0CF0", Offset = "0xDCF8F0", VA = "0x180DD0CF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x878EEB0", Offset = "0x878DAB0", VA = "0x18878EEB0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x878EE70", Offset = "0x878DA70", VA = "0x18878EE70", Slot = "8")]
		public virtual bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public RRUIGameObjectLayoutElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ExecuteInEditMode]
	public class RRUIGameObjectLayoutGroup : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum LayoutDirection
		{
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			Vertical,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			Horizontal
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum LayoutAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			Start,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			Center,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			End
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private float padding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private LayoutDirection layoutDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private LayoutAnchor layoutAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private RRUIGameObjectLayoutElement centerElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private List<RRUIGameObjectLayoutElement> KPSJEOYFOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int AFODLRATRFC;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x878F980", Offset = "0x878E580", VA = "0x18878F980")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x878F7E0", Offset = "0x878E3E0", VA = "0x18878F7E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x878F7E0", Offset = "0x878E3E0", VA = "0x18878F7E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x878F1D0", Offset = "0x878DDD0", VA = "0x18878F1D0")]
		private void ELCLAPLDVRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8790760", Offset = "0x878F360", VA = "0x188790760")]
		private float ZTDMLZAZVNL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x878F5D0", Offset = "0x878E1D0", VA = "0x18878F5D0")]
		private bool JSFBOSJSPEZ([Out] float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x878F0A0", Offset = "0x878DCA0", VA = "0x18878F0A0")]
		private bool BEOSYRRREJA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x878F990", Offset = "0x878E590", VA = "0x18878F990")]
		private void UXJSLUJHQXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8790070", Offset = "0x878EC70", VA = "0x188790070")]
		private void XOFWJIFAXHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x878F4C0", Offset = "0x878E0C0", VA = "0x18878F4C0")]
		private void JQQMOXKQYIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x878F7F0", Offset = "0x878E3F0", VA = "0x18878F7F0")]
		public void RebuildLayout()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8790790", Offset = "0x878F390", VA = "0x188790790")]
		public RRUIGameObjectLayoutGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RRUIGameObjectSpriteLayoutElement : RRUIGameObjectLayoutElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private SpriteRenderer spriteRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Sprite LHWQEKUBXAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool ZRKGHZLPHSM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool WALQPJYHYNR
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8790960", Offset = "0x878F560", VA = "0x188790960", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override float AEKETZPFTBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8790A40", Offset = "0x878F640", VA = "0x188790A40", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override float HZJMCUEOHDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x87908A0", Offset = "0x878F4A0", VA = "0x1887908A0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8790820", Offset = "0x878F420", VA = "0x188790820", Slot = "8")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public RRUIGameObjectSpriteLayoutElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RRUIGameObjectTextLayoutElement : RRUIGameObjectLayoutElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private TextMeshPro textComponent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool ZRKGHZLPHSM;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool WALQPJYHYNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8790BE0", Offset = "0x878F7E0", VA = "0x188790BE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override float AEKETZPFTBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8790CD0", Offset = "0x878F8D0", VA = "0x188790CD0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override float HZJMCUEOHDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8790B80", Offset = "0x878F780", VA = "0x188790B80", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8790B00", Offset = "0x878F700", VA = "0x188790B00", Slot = "8")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public RRUIGameObjectTextLayoutElement()
		{
		}
	}
}
namespace RecRoom.Maker.MakerPenHUD
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface XYVHCWTGMED : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		IReadOnlyList<LJWJYBNIOTO> KKZKCTPYSMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action ASWJYCBCVYO;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface LJWJYBNIOTO : IEquatable<LJWJYBNIOTO>, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		SpawnableID TJKKDTIBXHR
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool KJMHXSAPSOY
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string XSOOOFHQWMR
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IFKNCMWHBAG(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<Texture2D> CFIMKYLWLBA();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum MakerPenHUDMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Select,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Create
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface RCUQYCQBFFV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool UUILOTMPACA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		AQWXMNIFQIV OWCKCPWELUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool ZFWALHKKXAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool ASDWBWXHWGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool SRSUWEOYTYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool WMEVVQPOVAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		HWNZTWGRXOC<bool> ZMCTHPWAYDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool RBSBUPGBUBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool ZTUFDGZVTVE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IKAMBQZHIZF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool XRYGGBWVCLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool UEFOBAYRQHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "17")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool FNDRWFVHNFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool YSPTHKDKMVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "23")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool HIYJDVRWALG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "25")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool BEZQOBGOTEF
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "27")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		HWNZTWGRXOC<bool> YFGTKDLFYEV
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool WSITVBOFWLN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "30")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		int IWCVRMZBALG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "32")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		AYTQVAVWOPD ZRQELUOLPPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool XHSRPZEUVGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "38")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "39")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool MWOVCBNJWLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "40")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		HWNZTWGRXOC<bool> AETPLHTUAIC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "42")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		bool CRGBPIMQONW
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "43")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		bool PQTWKXQAIET
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "47")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		bool QJPXIVKILMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "48")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		bool OYVLXOYZMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "54")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		HWNZTWGRXOC<bool> MBBGLOWLGEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "56")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		bool HVORXYJXNNV
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "58")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		HWNZTWGRXOC<bool> YMXBOVNUKCN
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(Slot = "59")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action OXGFZNEYEEV;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<int> UODNMSLZUVK;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action<bool> BJRRLGOPKYY;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void GoToSelectMode();

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void GoToCreateMode();

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void TCXXPCJCDMA();

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void EVAOMCLBMGA(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void BQKQGSMFBWV(List<SpawnableID> a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool TEIIJKPFRPS(SpawnableID a);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void AQTAQPOFFNM(bool a);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void PVCSSNPQPWI(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void EJSKOBRBNSU();

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "50")]
		void QOSXWMGRXCS();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void CHGOLSMVSHB();

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "52")]
		void XIAMUTLOIMV();

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void EndCursor();

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void NQMGZDBGNJE(Token a);

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void PKNGZRYDKOU(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface AYTQVAVWOPD : XYVHCWTGMED, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QEYTDGFFXDL(LJWJYBNIOTO a, [Out] SpawnableID? b);

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JUSIKJUVYXS(int a);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QUZELVXQJUA(int a);

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DPYOAAHLMTK(IReadOnlyList<LJWJYBNIOTO> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface EYBFYFADWWY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public enum FilterMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			Objects,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			Favorites,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Search,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			RoomInventions
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		FilterMode ZYVTQDANWXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		IReadOnlyList<WSNIPFNOPNH> BAZFAYQHYKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action IGGVTKECRQR;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WQPIFBTFOBP();

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XKBZISIGHEV();

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QHWPFYUPTCA(string a = "", SortOption b = SortOption.None);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void ZYJBCUAHGAU();

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AIHFXOCWIIQ();

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void AIHFXOCWIIQ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface SREFULXWYYN : IEquatable<SREFULXWYYN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool KJMHXSAPSOY
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool QLJZMBAVWBB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		bool GPSORIPYKYA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		string OZUHZDNJVXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool MTOIEKNQRAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool TZMQYZJJZEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action MCOPWKUYDKH;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<bool> HNTRJAZZXHV(bool a);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool DNSOKWXMIYK(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void ClickActionButton();

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ClickInfoButton();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class WSNIPFNOPNH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public SREFULXWYYN XJCNXWHCOFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public SpawnableID TPWWUBUVNGT
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x11B0630", Offset = "0x11AF230", VA = "0x1811B0630")]
			[CompilerGenerated]
			get
			{
				return default(SpawnableID);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x879ABC0", Offset = "0x87997C0", VA = "0x18879ABC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public abstract string XSOOOFHQWMR
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract LJWJYBNIOTO DGCDAFAPYQN();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void Dispose();

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract Task<string> WSLXOGUNDTC();

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract Task<Texture2D> CFIMKYLWLBA();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void GNDUFEVDRIP();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected WSNIPFNOPNH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct SpawnableID
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public enum SpawnableType
		{
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			Prop,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			Invention
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private SpawnableType type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Guid? SpawnableToolGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private long? InventionID;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8793B60", Offset = "0x8792760", VA = "0x188793B60")]
		public static SpawnableID IKZSGKESBXZ(Guid? a)
		{
			return default(SpawnableID);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8793980", Offset = "0x8792580", VA = "0x188793980")]
		public static SpawnableID BFVTWUCSTDM(long? a)
		{
			return default(SpawnableID);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8793CA0", Offset = "0x87928A0", VA = "0x188793CA0")]
		private SpawnableID(SpawnableType type, Guid? spawnableToolGuid, long? inventionID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8793C00", Offset = "0x8792800", VA = "0x188793C00")]
		public bool YPUTZQUEPMS([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8793B80", Offset = "0x8792780", VA = "0x188793B80")]
		public bool XXIGFLDRTQJ([Out] long a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x87939A0", Offset = "0x87925A0", VA = "0x1887939A0")]
		public static bool EOXNKNKFOQL(SpawnableID a, SpawnableID b)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RRUIBinder]
	public class AccountBadgeIconBinder : BaseBinder<AccountBadgeIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private AccountBadgeIconView accountBadgeView;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x87809A0", Offset = "0x877F5A0", VA = "0x1887809A0", Slot = "20")]
		protected override void OnDataUpdated(AccountBadgeIconType dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8780A40", Offset = "0x877F640", VA = "0x188780A40")]
		public AccountBadgeIconBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AccountRoleIconViewBinder : BaseBinder<AccountRoleIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private AccountRoleView accountRoleView;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8781FC0", Offset = "0x8780BC0", VA = "0x188781FC0", Slot = "20")]
		protected override void OnDataUpdated(AccountRoleIconType dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8782060", Offset = "0x8780C60", VA = "0x188782060")]
		public AccountRoleIconViewBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[RRUIBinder]
	public class ButtonFocusedActionBinder : BaseBinder<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum FocusedState
		{
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			Focused,
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			Unfocused,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			Both
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private FocusedState focusedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool focused;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8786850", Offset = "0x8785450", VA = "0x188786850", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8786AE0", Offset = "0x87856E0", VA = "0x188786AE0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "20")]
		protected override void OnDataUpdated(Action dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8786950", Offset = "0x8785550", VA = "0x188786950")]
		protected void OnButtonStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8786BC0", Offset = "0x87857C0", VA = "0x188786BC0")]
		public ButtonFocusedActionBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[RRUIBinder]
	public class ButtonFocusedStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum FocusedState
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Focused,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Unfocused,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Both
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private BindDirection bindDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private FocusedState focusedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private bool focused;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8786C00", Offset = "0x8785800", VA = "0x188786C00", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8787120", Offset = "0x8785D20", VA = "0x188787120", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8786E90", Offset = "0x8785A90", VA = "0x188786E90", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8786D00", Offset = "0x8785900", VA = "0x188786D00")]
		protected void OnButtonStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8786EB0", Offset = "0x8785AB0", VA = "0x188786EB0")]
		protected void SyncButtonState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8787200", Offset = "0x8785E00", VA = "0x188787200")]
		public ButtonFocusedStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RRUIBinder]
	public class CardHighlightStyleAspectRatioBinder : BaseBinder<HighlightStyle>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class HighlightStyleAspectRatio
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public HighlightStyle Style;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public float AspectRatio;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x2C96DE0", Offset = "0x2C959E0", VA = "0x182C96DE0")]
			public HighlightStyleAspectRatio()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private AspectRatioFitter aspectRatioFitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private RecNetRawImage recNetRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private List<HighlightStyleAspectRatio> aspectRatios;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8787250", Offset = "0x8785E50", VA = "0x188787250", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8787550", Offset = "0x8786150", VA = "0x188787550", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8787350", Offset = "0x8785F50", VA = "0x188787350")]
		protected void OnImageLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "20")]
		protected override void OnDataUpdated(HighlightStyle dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8787650", Offset = "0x8786250", VA = "0x188787650")]
		public CardHighlightStyleAspectRatioBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[RRUIBinder]
	public class CarouselHeightBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private List<LayoutElement> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private LayoutElementSizeBinder.LayoutElementSizeTarget targetSize;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8787690", Offset = "0x8786290", VA = "0x188787690", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x87877B0", Offset = "0x87863B0", VA = "0x1887877B0", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8787AA0", Offset = "0x87866A0", VA = "0x188787AA0")]
		public CarouselHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[RRUIBinder]
	public class CarouselItemSizeBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8787AE0", Offset = "0x87866E0", VA = "0x188787AE0", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8787B90", Offset = "0x8786790", VA = "0x188787B90")]
		public CarouselItemSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RRUIBinder]
	public class CarouselItemWidthHeightBinder : BaseBinder<Vector2>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8787BD0", Offset = "0x87867D0", VA = "0x188787BD0", Slot = "20")]
		protected override void OnDataUpdated(Vector2 dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8787C80", Offset = "0x8786880", VA = "0x188787C80")]
		public CarouselItemWidthHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[RRUIBinder]
	public class CarouselRowCountBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8787CC0", Offset = "0x87868C0", VA = "0x188787CC0", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8787D60", Offset = "0x8786960", VA = "0x188787D60")]
		public CarouselRowCountBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[RRUIBinder]
	public class ConditionalPrefabSpawnBinder : BaseBinder<bool>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <LoadPrefab>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ConditionalPrefabSpawnBinder <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x87990B0", Offset = "0x8797CB0", VA = "0x1887990B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private MultiPrefabSpawner prefabSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private AssetReference prefabReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private bool prependSpawnedObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private FPZMXFTLOMZ<GameObject> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8787DA0", Offset = "0x87869A0", VA = "0x188787DA0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8787FC0", Offset = "0x8786BC0", VA = "0x188787FC0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8788160", Offset = "0x8786D60", VA = "0x188788160", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8787F10", Offset = "0x8786B10", VA = "0x188787F10")]
		[AsyncStateMachine(typeof(<LoadPrefab>d__8))]
		private void LoadPrefab()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		private void OnPopulateInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		private void OnCleanupInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8788310", Offset = "0x8786F10", VA = "0x188788310")]
		public ConditionalPrefabSpawnBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[RRUIBinder]
	public class DynamicUIElementsBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private DynamicUIModel dynamicUIModel;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8788350", Offset = "0x8786F50", VA = "0x188788350", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8788400", Offset = "0x8787000", VA = "0x188788400")]
		public DynamicUIElementsBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[RRUIBinder]
	public class HideableBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8788440", Offset = "0x8787040", VA = "0x188788440", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x87884E0", Offset = "0x87870E0", VA = "0x1887884E0")]
		public HideableBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[RRUIBinder]
	public class HtmlColorStringToColorBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private List<Image> targetList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Color htmlColor;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8788520", Offset = "0x8787120", VA = "0x188788520", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x87886E0", Offset = "0x87872E0", VA = "0x1887886E0")]
		public HtmlColorStringToColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RRUIBinder]
	public class HydrationStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private List<HydrateBase> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8788720", Offset = "0x8787320", VA = "0x188788720", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8788850", Offset = "0x8787450", VA = "0x188788850")]
		public HydrationStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[RRUIBinder]
	public class ImageKeyBinder : BaseBinder<string>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct <LoadImage>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public ImageKeyBinder <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AssetReference assetReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private AsyncOperationHandle<Sprite> <handle>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private TaskAwaiter<Sprite> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8798DF0", Offset = "0x87979F0", VA = "0x188798DF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private Image targetImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private AssetReferenceLookup imageKeyLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private AssetReference currentAsset;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8788970", Offset = "0x8787570", VA = "0x188788970", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8788B20", Offset = "0x8787720", VA = "0x188788B20", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8788AD0", Offset = "0x87876D0", VA = "0x188788AD0")]
		private void ReleaseAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8788890", Offset = "0x8787490", VA = "0x188788890")]
		[AsyncStateMachine(typeof(<LoadImage>d__6))]
		private void LoadImage(AssetReference assetReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8788B80", Offset = "0x8787780", VA = "0x188788B80")]
		public ImageKeyBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[RRUIBinder]
	public class ImposterImageBinder : BaseBinder<IZQMLBCLOSL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private ImposterRawImage imposterImage;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8788BC0", Offset = "0x87877C0", VA = "0x188788BC0", Slot = "20")]
		protected override void OnDataUpdated(IZQMLBCLOSL dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8788C50", Offset = "0x8787850", VA = "0x188788C50")]
		public ImposterImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[RRUIBinder]
	public class InfiniteListBinder : BaseBinder<DataList>, VEUFYVWHDYY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		protected InfiniteListViewControllerBase infiniteList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		protected GameObject defaultPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private int listId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private HashSet<int> loadedItems;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xFEF5C0", Offset = "0xFEE1C0", VA = "0x180FEF5C0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x114DF50", Offset = "0x114CB50", VA = "0x18114DF50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public HWNZTWGRXOC<int> OnItemAtIndexLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public IReadOnlyCollection<SXKRMZOMBHZ> VisibleItems
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x87898B0", Offset = "0x87884B0", VA = "0x1887898B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8788CF0", Offset = "0x87878F0", VA = "0x188788CF0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8788D80", Offset = "0x8787980", VA = "0x188788D80", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8789260", Offset = "0x8787E60", VA = "0x188789260")]
		protected void RefreshActiveItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8789160", Offset = "0x8787D60", VA = "0x188789160", Slot = "27")]
		public virtual void OnItemVisible(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x87890D0", Offset = "0x8787CD0", VA = "0x1887890D0", Slot = "28")]
		public virtual void OnItemRefresh(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8788ED0", Offset = "0x8787AD0", VA = "0x188788ED0", Slot = "29")]
		public virtual void OnItemHidden(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0", Slot = "30")]
		public virtual GameObject GetPrefabForIndex(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8788C90", Offset = "0x8787890", VA = "0x188788C90", Slot = "31")]
		public virtual bool IsItemLoaded(InfiniteListDataItem item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8788FE0", Offset = "0x8787BE0", VA = "0x188788FE0")]
		protected void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x87897C0", Offset = "0x87883C0", VA = "0x1887897C0")]
		public InfiniteListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[RRUIBinder]
	public class LimitedCapacityListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		protected List<BaseLocalViewModel> limitedListObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		private GameObject overflowIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private TMP_Text overflowText;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8789E20", Offset = "0x8788A20", VA = "0x188789E20", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x878A270", Offset = "0x8788E70", VA = "0x18878A270")]
		public LimitedCapacityListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[RRUIBinder]
	public class MultiPrefabSpawnerListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private MultiPrefabSpawner multiPrefabSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private GameObject defaultPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int listId;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x878A750", Offset = "0x8789350", VA = "0x18878A750", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x878A600", Offset = "0x8789200", VA = "0x18878A600", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x878A9A0", Offset = "0x87895A0", VA = "0x18878A9A0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x878A7E0", Offset = "0x87893E0", VA = "0x18878A7E0", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x878A890", Offset = "0x8789490", VA = "0x18878A890", Slot = "21")]
		protected virtual void OnInstanceCleanupEvent(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x878A900", Offset = "0x8789500", VA = "0x18878A900", Slot = "22")]
		protected virtual void OnInstanceSpawnedEvent(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x878AAD0", Offset = "0x87896D0", VA = "0x18878AAD0")]
		public MultiPrefabSpawnerListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class PageNavigationHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private Uri destinationUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private string analyticsButtonName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x878B1C0", Offset = "0x8789DC0", VA = "0x18878B1C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x878B420", Offset = "0x878A020", VA = "0x18878B420")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x878B360", Offset = "0x8789F60", VA = "0x18878B360")]
		public void NavigateToPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x878B680", Offset = "0x878A280", VA = "0x18878B680")]
		public void SetUriData(string uriDataKey, int data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x878B580", Offset = "0x878A180", VA = "0x18878B580")]
		public void SetUriData(string uriDataKey, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x878B600", Offset = "0x878A200", VA = "0x18878B600")]
		public void SetUriData(string uriDataKey, float data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x878B4F0", Offset = "0x878A0F0", VA = "0x18878B4F0")]
		public void SetUriData(string uriDataKey, Guid data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x878B700", Offset = "0x878A300", VA = "0x18878B700")]
		public PageNavigationHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PageNavigationHelperUriDataBinder : BaseBinder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private PageNavigationHelper target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private string uriDataKey;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x878ACB0", Offset = "0x87898B0", VA = "0x18878ACB0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x878B180", Offset = "0x8789D80", VA = "0x18878B180")]
		public PageNavigationHelperUriDataBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[RRUIBinder]
	public class PlayerColorSpriteBinder : BaseBinder<IPlayerColor>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private SpriteRenderer target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private IPlayerUIBridge.PlayerColorType _colorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private Color defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[ConditionalField("_colorType", new object[] { 3, 5 })]
		private Color customColor;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x878B740", Offset = "0x878A340", VA = "0x18878B740", Slot = "20")]
		protected override void OnDataUpdated(IPlayerColor dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x878B8E0", Offset = "0x878A4E0", VA = "0x18878B8E0")]
		public PlayerColorSpriteBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RRUIBinder]
	public class PlayerColorTextBinder : BaseBinder<IPlayerColor>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private TMP_Text target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private IPlayerUIBridge.PlayerColorType _colorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private Color defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		[ConditionalField("_colorType", new object[] { 3, 5 })]
		private Color customTextColor;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x878B930", Offset = "0x878A530", VA = "0x18878B930", Slot = "20")]
		protected override void OnDataUpdated(IPlayerColor dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x878BB00", Offset = "0x878A700", VA = "0x18878BB00")]
		public PlayerColorTextBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[RRUIBinder]
	public class RecNetRawImageBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private RecNetRawImage target;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8790D30", Offset = "0x878F930", VA = "0x188790D30", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8790DC0", Offset = "0x878F9C0", VA = "0x188790DC0")]
		public RecNetRawImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RRUIBinder]
	public class RectTransformHeightSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private List<RectTransform> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private float activeHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private float inactiveHeight;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x87932D0", Offset = "0x8791ED0", VA = "0x1887932D0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8793440", Offset = "0x8792040", VA = "0x188793440")]
		public RectTransformHeightSwapBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RRUIBinder]
	public class RoomSourceUriLinkButtonBinder : BaseBinder<RoomListQueryData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private Uri targetUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private bool useQueryDataInUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[ConditionalField("useQueryDataInUri")]
		[SerializeField]
		private bool overrideQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private RoomListQueryData queryDataOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[ConditionalField("overrideLoadSceneSource")]
		[SerializeField]
		private LoadSceneSources loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8793480", Offset = "0x8792080", VA = "0x188793480", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8793860", Offset = "0x8792460", VA = "0x188793860", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "20")]
		protected override void OnDataUpdated(RoomListQueryData dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8793610", Offset = "0x8792210", VA = "0x188793610")]
		private void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8793940", Offset = "0x8792540", VA = "0x188793940")]
		public RoomSourceUriLinkButtonBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RRUIBinder]
	public class StringToWidgetWrapperBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private WidgetWrapperViewModel widgetWrapper;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8794F20", Offset = "0x8793B20", VA = "0x188794F20", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8794FE0", Offset = "0x8793BE0", VA = "0x188794FE0")]
		public StringToWidgetWrapperBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RRUIBinder]
	public class VirtualizedScrollRectListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int listId;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x879A2C0", Offset = "0x8798EC0", VA = "0x18879A2C0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x879A520", Offset = "0x8799120", VA = "0x18879A520", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x879A5B0", Offset = "0x87991B0", VA = "0x18879A5B0", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x879A920", Offset = "0x8799520", VA = "0x18879A920", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x879A820", Offset = "0x8799420", VA = "0x18879A820", Slot = "21")]
		protected virtual void OnItemVisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x879A780", Offset = "0x8799380", VA = "0x18879A780", Slot = "22")]
		protected virtual void OnItemRefresh(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x879A660", Offset = "0x8799260", VA = "0x18879A660", Slot = "23")]
		protected virtual void OnItemInvisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x879A6D0", Offset = "0x87992D0", VA = "0x18879A6D0")]
		private void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x879AB70", Offset = "0x8799770", VA = "0x18879AB70")]
		public VirtualizedScrollRectListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface IIconConfig
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface IIconData<T> where T : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetConfig(T enumValue, [Out] IIconConfig config);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public abstract class EnumIconDataViewBase<T, U> : MonoBehaviour where T : Enum where U : IIconData<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private T defaultIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private U iconData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Header("Image Targets")]
		[SerializeField]
		protected List<Image> backgroundOutlineImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		protected List<Image> backgroundFillImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		protected List<Image> iconOutlineImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		protected List<Image> iconFillImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Header("Sprite Renderer Targets")]
		[SerializeField]
		protected List<SpriteRenderer> backgroundOutlineSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		protected List<SpriteRenderer> backgroundFillSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		protected List<SpriteRenderer> iconOutlineSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		protected List<SpriteRenderer> iconFillSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private T iconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private bool iconTypeSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private List<FPZMXFTLOMZ<Sprite>> resourceHandles;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4D093B0", Offset = "0x4D07FB0", VA = "0x184D093B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4D087E0", Offset = "0x4D073E0", VA = "0x184D087E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4D089B0", Offset = "0x4D075B0", VA = "0x184D089B0")]
		private void ReleaseSpriteHandles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4D08B10", Offset = "0x4D07710", VA = "0x184D08B10")]
		public void SetIconType(T newIconType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4D09520", Offset = "0x4D08120", VA = "0x184D09520")]
		private void UpdateIcons()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4D08590", Offset = "0x4D07190", VA = "0x184D08590")]
		private void LoadAndSetupSprite(AssetReference spriteReference, List<Image> imageTargets, List<SpriteRenderer> spriteRendererTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4D08C30", Offset = "0x4D07830", VA = "0x184D08C30")]
		private void SetImageTargetsToIcon(List<Image> targets, Sprite icon)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4D08FF0", Offset = "0x4D07BF0", VA = "0x184D08FF0")]
		private void SetSpriteRendererTargetsToIcon(List<SpriteRenderer> targets, Sprite icon)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4D09C00", Offset = "0x4D08800", VA = "0x184D09C00")]
		protected EnumIconDataViewBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class MakerPenHUDNavigationInputState
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public class NavInputState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public float MinHoldDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public float HoldDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public float LastHoldDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public bool WasHeldLastFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public HWNZTWGRXOC<NavInputState> NavInputStateChanged;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public bool IsPressed
			{
				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0x14830C0", Offset = "0x1481CC0", VA = "0x1814830C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public bool IsHeld
			{
				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x878AC90", Offset = "0x8789890", VA = "0x18878AC90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public bool WasHeldLastPress
			{
				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x878ACA0", Offset = "0x87898A0", VA = "0x18878ACA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x878AB90", Offset = "0x8789790", VA = "0x18878AB90")]
			public void UpdateHold(float holdDuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x878AB20", Offset = "0x8789720", VA = "0x18878AB20")]
			public void StopHold()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x878AC00", Offset = "0x8789800", VA = "0x18878AC00")]
			public NavInputState()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Dictionary<MakerPenHUDNavInputType, NavInputState> navInputStates;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x878A490", Offset = "0x8789090", VA = "0x18878A490")]
		public MakerPenHUDNavigationInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x878A330", Offset = "0x8788F30", VA = "0x18878A330")]
		public void Initialize(float minHoldDuration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x878A420", Offset = "0x8789020", VA = "0x18878A420")]
		public bool TryGetNavInputState(MakerPenHUDNavInputType inputType, [Out] NavInputState navInputState)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x878A3B0", Offset = "0x8788FB0", VA = "0x18878A3B0")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public abstract class BaseBindableObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<string> OnObjectChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x87866F0", Offset = "0x87852F0", VA = "0x1887866F0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x87867A0", Offset = "0x87853A0", VA = "0x1887867A0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x87866D0", Offset = "0x87852D0", VA = "0x1887866D0")]
		protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected BaseBindableObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface IInterfacesTeamHelper
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool RRUIPerfEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		double RRUIPerfSlowFramesSec
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum MakerPenHUDNavInputType
	{
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		LeftModifier,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		RightModifier,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		MAX
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface IMakerPenHUDBridge
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		MakerPenHUDNavigationInputState NavigationInputState
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool UseCuratedControls
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		AQWXMNIFQIV UseCuratedControlsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool IsUndoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool IsRedoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		AQWXMNIFQIV UndoStackEntriesChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool OnCreateMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		bool OnSelectMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		string ToolDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		bool IsRRUIPageContainerEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "23")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		HWNZTWGRXOC<bool> RRUIPageContainerEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool OnCloneMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool OnConfigMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		bool InTransformModeAndMoveOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		bool InTransformModeAndRotateOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		bool InTransformModeAndScaleOn
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool IsDeleteAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		bool IsRecolorMode
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		bool ShowColorPicker
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		HWNZTWGRXOC<bool> ColorPickerToggled
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool IsAdjustModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "36")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool IsPrecisionModifierModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		HWNZTWGRXOC<bool> StampModeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(Slot = "54")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		bool PaletteIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(Slot = "55")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		EYBFYFADWWY PaletteDataStore
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(Slot = "56")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		bool IsPaletteSearchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "73")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		string CurrentPaletteSearchString
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(Slot = "77")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		CategoriesNestedListConfig Config
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(Slot = "82")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		TMJIXIOYVGV Configurable
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(Slot = "83")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		AQWXMNIFQIV MakerPenConfigMenuDataChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(Slot = "84")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		bool IsCursorActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(Slot = "87")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		HWNZTWGRXOC<bool> CursorActiveChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		bool IsInSubMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(Slot = "90")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		HWNZTWGRXOC<bool> IsInSubMenuChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "91")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		bool ShouldUseButtonNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "92")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		bool ButtonShortcutsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "93")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		AQWXMNIFQIV ButtonShortcutsEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "94")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action CurrentModeChanged;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action CurrentSelectionChanged;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action PrecisionModifierModeActiveChanged;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<int> ColorPickerCardSelected;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action OnConfigure;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action HotbarSelectionCleared;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action ObjectCreated;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<bool> PaletteToggled;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action PaletteNeedsVisualRefresh;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action<string, SortOption> PaletteSwitchToObjectsCategoryRequested;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action PaletteSwitchToFavoritesCategoryRequested;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action PaletteSwitchToRoomInventionsCategoryRequested;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event Action<bool> PaletteToggledToOpen;

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<string> SearchStringChanged;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TriggerUndo();

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void TriggerRedo();

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void GoToCreateMode();

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void GoToSelectMode();

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void RequestAdjustMode();

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void ToggleCloneMode();

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void ToggleMoveMode();

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void ToggleRotateMode();

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void ToggleScaleMode();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void ToggleConfigMode();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void DeleteCurrentSelection();

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void PressRecolorButton();

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void ExitRecolorMode();

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void ChangeColor(Enum shapeColor, int index);

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void OnConfigButtonPressed();

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "52")]
		void SelectHotbarSlot(int index);

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void RemoveHotbarItem(int index);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void TogglePalette();

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void ShowOrHideGlobalToolbarAccordingToPaletteState();

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "63")]
		void PaletteObjectToggleSelected(WSNIPFNOPNH placable);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void PaletteObjectToggleFavorited(WSNIPFNOPNH placable);

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "65")]
		bool DoesHotbarContainPaletteObject(WSNIPFNOPNH placable);

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "66")]
		void RequestMakerPenHUDMenuToggleIfNeeded(bool open);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "76")]
		void TogglePaletteSearch();

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "80")]
		void SetSearchString(string newSearchString);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "81")]
		void CategoryFilterChanged(CategoriesFilter filter);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "85")]
		void PresentTypedDialog(DialogListModel dialogListModel, DialogType dialogType, PVIOTSLZPKY dialogData);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "86")]
		IReadOnlyList<ZAPQAZWXYYV> GetObjectPropertyDynamicUIData(TMJIXIOYVGV configurable, bool isQuickConfig);

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "89")]
		void EndCursor();
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public enum MenuType
	{
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		AppNav,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		Watch
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface IMenuManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		Guid WatchMenuUnifiedSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		HWNZTWGRXOC<Guid> WatchMenuUnifiedSessionIdChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		MenuType LastClosedMenuType
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		float LastClosedMenuTime
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class InterfacesTeamHelper : IInterfacesTeamHelper
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static string RRUI_PERF_EXPERIMENT_NAME;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static string RRUI_PERF_ENABLED_PARAMETER_NAME;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static string RRUI_PERF_SLOW_FRAMES_PARAMETER_NAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private NADKVDSFRLV statSigProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private bool? rruiPerfEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private double? slowFramesSec;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool RRUIPerfEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x8789AE0", Offset = "0x87886E0", VA = "0x188789AE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public double RRUIPerfSlowFramesSec
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x8789C80", Offset = "0x8788880", VA = "0x188789C80", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8789900", Offset = "0x8788500", VA = "0x188789900")]
		[IFIZWETSKCB.Root.GameOnly]
		internal static void InitializeOnLoad(DiContainer container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		[UnityEngine.Scripting.Preserve]
		internal InterfacesTeamHelper([Inject(null)][NotNull] NADKVDSFRLV statSigProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public interface IOrderedRenderable
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		bool RenderInCarouselOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		bool AllowRender
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		bool HasRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		bool RequiresRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public interface IRRUIvNextBridge
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		PlatformType CurrentPlatformType
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		bool InVRDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		bool InScreensDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		Guid ScreensMenuUnifiedSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		bool IsDebugBuild
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		long LocalRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		RoomDetailsDTO LocalRoomDetails
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		bool CurrentRoomInstanceIsPrivate
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		bool Discovery_ShouldDefaultPublicInstance
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		bool Discovery_ShouldDefaultPrivateInstance
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		int Discovery_NewDataTokenThresholdDays
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		bool Discovery_ShowPublishStateDataToken
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		string Discovery_StoreItemCardVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		int Discovery_LimitedBadgeThresholdDays
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		bool Discovery_LimitedBadgeQolDetails
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		bool Discovery_LimitedBadgeEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		bool WatchMenuProjector_IsWatchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		bool WatchMenuProject_IsUIOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		bool WatchMenuProjector_IsMenuAnimationVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		bool ToolMenuProjector_IsMenuOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		bool ToolMenuProjector_IsMenuAnimationVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		int UnreadWatchNotificationCount
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		bool HideWatchNavBar
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(Slot = "24")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		Camera UICamera
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		Camera ScreenModeCamera
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		bool IsUsingTouchInput
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		Action InputMethodChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "29")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		AQWXMNIFQIV BrowserModel_RequestAppNavMenu
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(Slot = "52")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Vector2? Discovery_GetHighlightStyleCardOverride(HighlightStyle style);

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		string TimeSpanExtensions_GetFormatedTimeString(TimeSpan timeSpan, bool useShortUnits);

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "30")]
		T GetConfigValue<T>(string key);

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void OpenWatchMenu();

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void CloseWatchMenu();

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void CloseActiveToolMenu();

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void NavigateToLink(LinkInfo linkInfo, bool isPortalButton = false);

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void GuaranteeWatchStateAndGoTo(BrowserModel browserModel, Route route);

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void GuaranteeWatchStateAndGoTo(BrowserModel browserModel, Uri uri);

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void OpenLegacyUI(LegacyUIType legacyUIType);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void NavigateToUriWithRoomSourceData(BrowserModel browserModel, Uri destination, RoomListQueryData queryData, bool useLoadSceneSourceOverride = false, LoadSceneSources sourceOverride = LoadSceneSources.NOT_SET);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "39")]
		string GetFriendlyListNameFromRoomsConfig(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "40")]
		string GetSourceStringForQueryData(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "41")]
		bool PopulateRoomListQueryDataFromSourceInfo(string source, string sourceMetadata, RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "42")]
		HighlightStyle GetHighlightStyleFromDiscoveryTeamHelper(string sourceLabelText, [Optional] string sizePerPlatformFromMetadata);

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task LogImpressionEvent(NKNMZIGJWYR.SJCYWDVYQIW impressionEvent);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "44")]
		bool IsBrowserModelOnRootScreen(BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "45")]
		bool TryGetMenuOpenAction([Out] HWNZTWGRXOC<bool> menuOpenAction);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void TryTrackLatencyForBrowserRoute(string routeString);

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "47")]
		Task<bool> ShowRoomPlayActionDialog(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task<SubRoomDTO> ShowChooseSubRoomDialog(RoomDetailsDTO roomDetails, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void ForceAcceptRoomWarnings(RoomDTO room);

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "50")]
		Task ShowTwoButtonMessageDialog(DialogListModel dialogListModel, XSTLRQHMAVC dialogData, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void Discovery_HackyTryShowUpdateTheAppDialog(BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "53")]
		Task EvictAllFromDorm();

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void ShowRoomReportDialog(long roomId, string sanitizedFriendlyName);

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void ApplyBrowserModelImpressionData(ImpressionTracker impressionTracker, BrowserModel browserModel, string nullBrowserRouteProperty = "appnav/quickaccess");

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<RenderTexture> GenerateTextureForLocalAvatarAsync(CancellationToken token, int width = -1, int height = -1);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void AddNotificationRestriction(object token);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void RemoveNotificationRestriction(object token);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void OpenManageRRPlusMembershipPage();

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "60")]
		bool CanLocalPlayerChatWith(YITTHDGJKSX account);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "61")]
		void GoToChatPage(int accountId, ChatTelemetrySource chatTelemetrySource);
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface IRRUIvNextConsumableBridge
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public enum ConsumableCategory
		{
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			All,
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			Food,
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			Other
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<Consumable> OnActiveConsumableChanged;

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		event Action<Consumable> OnPurchasedConsumableChanged;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		List<Consumable> GetLatestPurchasedNonTransferableConsumables(ConsumableCategory category, bool excludeRoomieActivated);

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UseConsumable(Consumable consumable);

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IZQMLBCLOSL GetConsumableImposterRequest(Consumable consumable);

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IsConsumableSpawned(Consumable consumable);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		int GetTotalConsumableCount(Consumable consumable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public interface IRRUIvNextRoomCategoryBridge
	{
		[Cpp2IlInjected.Token(Token = "0x17000098")]
		string DefaultGameConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		bool ShouldHideShowMeAllRooms
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		bool ShouldHideChipBar
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SelectRoomCategory(RUQRXZAMGGP category, Route route, LoadSceneSources loadSceneSource, BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<IReadOnlyList<RUQRXZAMGGP>> GetRoomCategoriesForPageSource(CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<(IReadOnlyList<RUQRXZAMGGP>, string)> GetRoomCategoriesForCuratedList(string sourceMetadata, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<RUQRXZAMGGP> GetRoomCategoriesForConfig(string gameConfigKey);
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[ViewModel]
	public class PlayerNametagViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct <GetPlayerInfo>d__80 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public IPlayerUIBridge player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private RoomDetailsDTO <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private Progression <progression>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private TaskAwaiter<Account> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private TaskAwaiter<Progression> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private TaskAwaiter<bool> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x8797710", Offset = "0x8796310", VA = "0x188797710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <OnAccountUpdated>d__77 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private TaskAwaiter<Account> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x8799360", Offset = "0x8797F60", VA = "0x188799360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct <OnReputationUpdated>d__76 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private TaskAwaiter<Reputation> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x8799600", Offset = "0x8798200", VA = "0x188799600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private bool canShowNametag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private string playerDisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private string playerCustomEmoji;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private AccountRoleIconType playerRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private AccountBadgeIconType roleBadgeIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private AccountBadgeIconType cheerBadgeIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private string playerLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private bool isBroadcasting;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private string developerLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private bool inCallWithLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private bool muted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAA")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private bool blocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAB")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private bool inAPartyWithLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private IPlayerColor playerColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private IPlayerUIBridge playerUIBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private CancellationTokenSource tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private string accountLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private bool isInfluencer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private IRoomQueryManager roomQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private Account account;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private DataItem<bool> CanShowNametagDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private DataItem<string> PlayerDisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private DataItem<string> PlayerCustomEmojiDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private DataItem<bool> HasCustomEmojiDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private DataItem<AccountRoleIconType> PlayerRoleTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private DataItem<AccountBadgeIconType> RoleBadgeIconTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private DataItem<AccountBadgeIconType> CheerBadgeIconTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private DataItem<string> PlayerLevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private DataItem<bool> IsBroadcastingDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private DataItem<bool> ShowDeveloperLabelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private DataItem<string> DeveloperLabelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private DataItem<bool> InCallWithLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private DataItem<bool> MutedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private DataItem<bool> BlockedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private DataItem<bool> InAPartyWithLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private DataItem<IPlayerColor> PlayerColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private DataItemAction OpenPlayerProfileDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public bool CanShowNametag
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xB25ED0", Offset = "0xB24AD0", VA = "0x180B25ED0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x878E900", Offset = "0x878D500", VA = "0x18878E900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		[BindableData(1, "Display name of the associated player", DataPermissions.ReadOnly)]
		public string PlayerDisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x878ECC0", Offset = "0x878D8C0", VA = "0x18878ECC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		[BindableData(2, "Player-set custom emoji", DataPermissions.ReadOnly)]
		public string PlayerCustomEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x878EC50", Offset = "0x878D850", VA = "0x18878EC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		[BindableData(3, "Whether a custom emoji is set", DataPermissions.ReadOnly)]
		public bool HasCustomEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x878E1F0", Offset = "0x878CDF0", VA = "0x18878E1F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		[BindableData(5, "The role of this player in the current room", DataPermissions.ReadOnly)]
		public AccountRoleIconType PlayerRoleType
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xFEF5C0", Offset = "0xFEE1C0", VA = "0x180FEF5C0")]
			get
			{
				return default(AccountRoleIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x878EDB0", Offset = "0x878D9B0", VA = "0x18878EDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		[BindableData(6, "The badge the player has selected", DataPermissions.ReadOnly)]
		public AccountBadgeIconType RoleBadgeIconType
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1061E50", Offset = "0x1060A50", VA = "0x181061E50")]
			get
			{
				return default(AccountBadgeIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x878EE10", Offset = "0x878DA10", VA = "0x18878EE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		[BindableData(15, "The active cheer this player has", DataPermissions.ReadOnly)]
		public AccountBadgeIconType CheerBadgeIconType
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xDDA760", Offset = "0xDD9360", VA = "0x180DDA760")]
			get
			{
				return default(AccountBadgeIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x878E960", Offset = "0x878D560", VA = "0x18878E960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		[BindableData(7, "Player level (room level if room has progression)", DataPermissions.ReadOnly)]
		public string PlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x878ED30", Offset = "0x878D930", VA = "0x18878ED30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		[BindableData(8, "Whether the player is broadcasting", DataPermissions.ReadOnly)]
		public bool IsBroadcasting
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xB44430", Offset = "0xB43030", VA = "0x180B44430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x878EB20", Offset = "0x878D720", VA = "0x18878EB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		[BindableData(9, "Whether the player is a developer", DataPermissions.ReadOnly)]
		public bool ShowDeveloperLabel
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x878E210", Offset = "0x878CE10", VA = "0x18878E210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		[BindableData(10, "Player level (room level if room has progression)", DataPermissions.ReadOnly)]
		public string DeveloperLabel
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x878E9C0", Offset = "0x878D5C0", VA = "0x18878E9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		[BindableData(11, "Whether this player is in a call with the local player", DataPermissions.ReadOnly)]
		public bool InCallWithLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xBD43A0", Offset = "0xBD2FA0", VA = "0x180BD43A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x878EAC0", Offset = "0x878D6C0", VA = "0x18878EAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		[BindableData(12, "Whether this player is muted by the local player", DataPermissions.ReadOnly)]
		public bool Muted
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xBD4110", Offset = "0xBD2D10", VA = "0x180BD4110")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x878EB80", Offset = "0x878D780", VA = "0x18878EB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		[BindableData(13, "Whether this player has been blocked by local player", DataPermissions.ReadOnly)]
		public bool Blocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x2D53CD0", Offset = "0x2D528D0", VA = "0x182D53CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x878E8A0", Offset = "0x878D4A0", VA = "0x18878E8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		[BindableData(14, "Whether this player is in a party", DataPermissions.ReadOnly)]
		public bool InAPartyWithLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x2D53C80", Offset = "0x2D52880", VA = "0x182D53C80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x878EA60", Offset = "0x878D660", VA = "0x18878EA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		[BindableData(16, "Player color defined by legacy scripts", DataPermissions.ReadOnly)]
		public IPlayerColor PlayerColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xB74D40", Offset = "0xB73940", VA = "0x180B74D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x878EBE0", Offset = "0x878D7E0", VA = "0x18878EBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x878E860", Offset = "0x878D460", VA = "0x18878E860", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x878E010", Offset = "0x878CC10", VA = "0x18878E010")]
		public void Set(IPlayerUIBridge player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x878BB50", Offset = "0x878A750", VA = "0x18878BB50")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x878D690", Offset = "0x878C290", VA = "0x18878D690")]
		private void OnBroadcastingStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x878D7D0", Offset = "0x878C3D0", VA = "0x18878D7D0")]
		private void OnDeveloperDisplayChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x878D730", Offset = "0x878C330", VA = "0x18878D730")]
		private void OnCallStatusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x878D9E0", Offset = "0x878C5E0", VA = "0x18878D9E0")]
		private void OnPartyStatusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x878D940", Offset = "0x878C540", VA = "0x18878D940")]
		private void OnNametagVisibilityChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x878DDA0", Offset = "0x878C9A0", VA = "0x18878DDA0")]
		private void OnRelationshipChanged(int? playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x878DCA0", Offset = "0x878C8A0", VA = "0x18878DCA0")]
		private void OnProgressionUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x878DF50", Offset = "0x878CB50", VA = "0x18878DF50")]
		[AsyncStateMachine(typeof(<OnReputationUpdated>d__76))]
		private void OnReputationUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x878D5D0", Offset = "0x878C1D0", VA = "0x18878D5D0")]
		[AsyncStateMachine(typeof(<OnAccountUpdated>d__77))]
		private void OnAccountUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x878E230", Offset = "0x878CE30", VA = "0x18878E230")]
		private void UpdateRoleBadge()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x878DBC0", Offset = "0x878C7C0", VA = "0x18878DBC0")]
		private void OnPlayerColorUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x878C880", Offset = "0x878B480", VA = "0x18878C880")]
		[AsyncStateMachine(typeof(<GetPlayerInfo>d__80))]
		private void GetPlayerInfo(IPlayerUIBridge player, long roomId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[BindableAction(100, "Opens the player profile page")]
		private void OpenPlayerProfile()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x878C970", Offset = "0x878B570", VA = "0x18878C970")]
		private static AccountRoleIconType GetRoleIconType(IPlayerUIBridge player, AccountRoleType role)
		{
			return default(AccountRoleIconType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x878CA50", Offset = "0x878B650", VA = "0x18878CA50", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x878C0A0", Offset = "0x878ACA0", VA = "0x18878C0A0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x878E390", Offset = "0x878CF90", VA = "0x18878E390")]
		public PlayerNametagViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public enum RecRoomPlusOfferType
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		SimpleBenefitList,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		LimitedTimeSignOnItemBonus
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[ViewModel]
	public class RecRoomPlusOfferViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <FetchBenefitData>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public RecRoomPlusOfferViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private TaskAwaiter<List<RecRoomPlusBenefitData>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8795850", Offset = "0x8794450", VA = "0x188795850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <FetchStoreItemOffers>d__50 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public RecRoomPlusOfferViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public WidgetSourceData sourceData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private TaskAwaiter<Commerce.RRPlusSignUpBonusDTO> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private TaskAwaiter<IReadOnlyList<HSUCUPBTDYC>> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private IEnumerator<HSUCUPBTDYC> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private HSUCUPBTDYC <item>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private PurchasableGiftDrop <giftDrop>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private TaskAwaiter<bool> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8795A90", Offset = "0x8794690", VA = "0x188795A90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[SerializeField]
		private RecRoomPlusOfferType offerType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[SerializeField]
		private int maxLimitedTimeOfferItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[SerializeField]
		private Uri offerItemDetailsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		private ImpressionTracker bannerContentsImpressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool subscriptionActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private string offerDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private string offerIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private string offerImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private bool useImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private int offerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int activeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private IRecRoomPlusDataManager rrplusManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private IStoreItemQueryManager storeItemListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private IRRUIvNextStoreItemBridge vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private IRecRoomPlusDataManager rrPlusDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private List<RecRoomPlusBenefitData> benefitData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private StoreItemListQueryData wishlistQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private StoreItemListQueryData configuredQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private List<int> wishlistItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private string nonWishlistSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private Dictionary<int, HSUCUPBTDYC> storeItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private DataItem<bool> SubscriptionActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private DataItem<string> OfferDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private DataItem<string> OfferIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private DataItem<string> OfferImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private DataItem<bool> UseImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private DataItem<int> OfferIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private DataItemAction RefreshOfferDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private DataItemAction ViewOfferItemDetailsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool SubscriptionActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0D0", Offset = "0xB9CCD0", VA = "0x180B9E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x87926B0", Offset = "0x87912B0", VA = "0x1887926B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string OfferDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x8793150", Offset = "0x8791D50", VA = "0x188793150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string OfferIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x87931D0", Offset = "0x8791DD0", VA = "0x1887931D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string OfferImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8793250", Offset = "0x8791E50", VA = "0x188793250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool UseImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xBD43A0", Offset = "0xBD2FA0", VA = "0x180BD43A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8792740", Offset = "0x8791340", VA = "0x188792740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public int OfferId
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x174DF90", Offset = "0x174CB90", VA = "0x18174DF90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8792650", Offset = "0x8791250", VA = "0x188792650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x8793110", Offset = "0x8791D10", VA = "0x188793110", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8791B10", Offset = "0x8790710", VA = "0x188791B10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8792280", Offset = "0x8790E80", VA = "0x188792280")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8791A50", Offset = "0x8790650", VA = "0x188791A50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x87927A0", Offset = "0x87913A0", VA = "0x1887927A0")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8790E00", Offset = "0x878FA00", VA = "0x188790E00")]
		[AsyncStateMachine(typeof(<FetchBenefitData>d__49))]
		private void FetchBenefitData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8790EB0", Offset = "0x878FAB0", VA = "0x188790EB0")]
		[AsyncStateMachine(typeof(<FetchStoreItemOffers>d__50))]
		private void FetchStoreItemOffers(WidgetSourceData sourceData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8791BF0", Offset = "0x87907F0", VA = "0x188791BF0")]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8791C90", Offset = "0x8790890", VA = "0x188791C90")]
		[BindableAction(100, null)]
		private void RefreshOffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8791F00", Offset = "0x8790B00", VA = "0x188791F00")]
		private void RefreshUIContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x87920D0", Offset = "0x8790CD0", VA = "0x1887920D0")]
		private void SetUpImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8792B60", Offset = "0x8791760", VA = "0x188792B60")]
		[BindableAction(101, null)]
		private void ViewOfferItemDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x87913A0", Offset = "0x878FFA0", VA = "0x1887913A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8790FA0", Offset = "0x878FBA0", VA = "0x188790FA0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8792DC0", Offset = "0x87919C0", VA = "0x188792DC0")]
		public RecRoomPlusOfferViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public enum AccountBadgeIconType
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Party,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		RRPlus,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Influencer,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Developer,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Cheer_Helpful,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Cheer_General,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Cheer_Sportsmanship,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Cheer_GreatHost,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Cheer_Creative,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		League
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class AccountBadgeIconConfig : IIconConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public AccountBadgeIconType IconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundFillIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundOutlineIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[FormerlySerializedAs("BadgeIcon")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeOutlineIcon;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public AccountBadgeIconConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CreateAssetMenu(fileName = "AccountBadgeIconData", menuName = "Rec Room/App UI/Account/Account Badge Icon Data")]
	public class AccountBadgeIconData : ScriptableObject, IIconData<AccountBadgeIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public List<AccountBadgeIconConfig> Config;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8780A80", Offset = "0x877F680", VA = "0x188780A80", Slot = "4")]
		public bool TryGetConfig(AccountBadgeIconType iconType, [Out] IIconConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xDB83A0", Offset = "0xDB6FA0", VA = "0x180DB83A0")]
		public AccountBadgeIconData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class AccountBadgeIconView : EnumIconDataViewBase<AccountBadgeIconType, AccountBadgeIconData>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8780BE0", Offset = "0x877F7E0", VA = "0x188780BE0")]
		public AccountBadgeIconView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum AccountRoleIconType
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Banned,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		Host,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Moderator,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		Contributor,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		CoOwner,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		TemporaryCoOwner,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Creator,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		RoomLevel
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class AccountRoleIconConfig : IIconConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public AccountRoleIconType IconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundFillIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundOutlineIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeOutlineIcon;

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public AccountRoleIconConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CreateAssetMenu(fileName = "AccountRoleIconData", menuName = "RecRoom/App UI/Account Role Icon Data")]
	public class AccountRoleIconData : ScriptableObject, IIconData<AccountRoleIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private List<AccountRoleIconConfig> iconConfigList;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8781E60", Offset = "0x8780A60", VA = "0x188781E60", Slot = "4")]
		public bool TryGetConfig(AccountRoleIconType iconType, [Out] IIconConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xDB83A0", Offset = "0xDB6FA0", VA = "0x180DB83A0")]
		public AccountRoleIconData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class AccountRoleView : EnumIconDataViewBase<AccountRoleIconType, AccountRoleIconData>
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x87820A0", Offset = "0x8780CA0", VA = "0x1887820A0")]
		public AccountRoleView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[ViewModel]
	public class AccountListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private struct <UpdateList>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public AccountListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x8799AC0", Offset = "0x87986C0", VA = "0x188799AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private AccountListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private Uri viewAllFriendsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		private Uri viewHereNowUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private DataList<int> _accountList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool _isEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private string _displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private string _emptyText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private IAccountQueryManager _accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool _isSubscribed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private DataItem<bool> IsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private DataItem<string> EmptyTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private DataItemList AccountListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private DataItemAction GoToViewAllPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public AccountListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8781D60", Offset = "0x8780960", VA = "0x188781D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> AccountList
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8781BF0", Offset = "0x87807F0", VA = "0x188781BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0D0", Offset = "0xB9CCD0", VA = "0x180B9E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x87817B0", Offset = "0x87803B0", VA = "0x1887817B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		[BindableData(2, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8781C60", Offset = "0x8780860", VA = "0x188781C60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		[BindableData(3, "The text to show if the list is empty", DataPermissions.ReadOnly)]
		public string EmptyText
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8781CE0", Offset = "0x87808E0", VA = "0x188781CE0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x8781BB0", Offset = "0x87807B0", VA = "0x188781BB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x87814E0", Offset = "0x87800E0", VA = "0x1887814E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x87814C0", Offset = "0x87800C0", VA = "0x1887814C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x87818E0", Offset = "0x87804E0", VA = "0x1887818E0")]
		[AsyncStateMachine(typeof(<UpdateList>d__28))]
		private void UpdateList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8780EE0", Offset = "0x877FAE0", VA = "0x188780EE0")]
		[BindableAction(100, null)]
		private void GoToViewAllPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x87815F0", Offset = "0x87801F0", VA = "0x1887815F0")]
		private bool TrySubscribe()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x87816D0", Offset = "0x87802D0", VA = "0x1887816D0")]
		private bool TryUnsubscribe()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8781080", Offset = "0x877FC80", VA = "0x188781080", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8780C20", Offset = "0x877F820", VA = "0x188780C20")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8781990", Offset = "0x8780590", VA = "0x188781990")]
		public AccountListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[ViewModel]
	public class AccountViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private struct <FetchAccountData>d__96 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private CancellationTokenSource <cts>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private TaskAwaiter<Account> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8795020", Offset = "0x8793C20", VA = "0x188795020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private struct <UpdateAccountProgression>d__97 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private TaskAwaiter<Progression> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x87B15C0", Offset = "0x87B01C0", VA = "0x1887B15C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private struct <UpdatePresence>d__99 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x87B1FF0", Offset = "0x87B0BF0", VA = "0x1887B1FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x87B24C0", Offset = "0x87B10C0", VA = "0x1887B24C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private Uri profilePageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private ChatTelemetrySource chatTelemetrySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private PartyJoinedSource partyJoinedSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private string profileImageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int level;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private float progressInLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private string presence;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private bool _canLocalPlayerGoTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private bool isFriendOfLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAA")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private bool canSendOrAcceptFriendRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAB")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private bool canLocalPlayerInviteToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private bool isLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private bool canLocalPlayerChatWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAE")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private bool canInviteToJoinLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAF")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private bool isInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private bool isFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private bool isFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB2")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private bool isBlocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private ASVHLEOBLHF sessionManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private IRRUIvNextAccountBridge vNextAccountBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private IRRUIvNextSocialBridge vNextSocialBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private Account account;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private DataItem<int> AccountIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private DataItem<string> ProfileImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private DataItem<string> UsernameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private DataItem<int> LevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private DataItem<float> ProgressInLevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private DataItem<string> PresenceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private DataItem<bool> CanLocalPlayerGoToDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private DataItem<bool> IsFriendOfLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private DataItem<bool> CanSendOrAcceptFriendRequestDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private DataItem<bool> CanInviteToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private DataItem<bool> IsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private DataItem<bool> CanLocalPlayerChatWithDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private DataItem<bool> CanInviteToJoinLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private DataItem<bool> IsInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private DataItem<bool> IsFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private DataItem<bool> IsFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private DataItem<bool> IsBlockedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private DataItemAction GoToProfilePageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private DataItemAction GoToChatPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private DataItemAction InviteToMyLocationDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private DataItemAction GoToLocationDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private DataItemAction InviteToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private DataItemAction SendFriendRequestDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xB3B690", Offset = "0xB3A290", VA = "0x180B3B690")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x87853D0", Offset = "0x8783FD0", VA = "0x1887853D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x87864D0", Offset = "0x87850D0", VA = "0x1887864D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string ProfileImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x87865D0", Offset = "0x87851D0", VA = "0x1887865D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string Username
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x8786650", Offset = "0x8785250", VA = "0x188786650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x105A8E0", Offset = "0x10594E0", VA = "0x18105A8E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8785790", Offset = "0x8784390", VA = "0x188785790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public float ProgressInLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x1733EA0", Offset = "0x1732AA0", VA = "0x181733EA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x8785220", Offset = "0x8783E20", VA = "0x188785220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		[BindableData(6, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Presence
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x8786550", Offset = "0x8785150", VA = "0x188786550")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		[BindableData(7, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanLocalPlayerGoTo
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xBD43A0", Offset = "0xBD2FA0", VA = "0x180BD43A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x87852A0", Offset = "0x8783EA0", VA = "0x1887852A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		[BindableData(8, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xBD4110", Offset = "0xBD2D10", VA = "0x180BD4110")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8785300", Offset = "0x8783F00", VA = "0x188785300")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		[BindableData(9, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanSendOrAcceptFriendRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x2D53CD0", Offset = "0x2D528D0", VA = "0x182D53CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x8785370", Offset = "0x8783F70", VA = "0x188785370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		[BindableData(10, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanInviteToParty
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x2D53C80", Offset = "0x2D52880", VA = "0x182D53C80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x8785440", Offset = "0x8784040", VA = "0x188785440")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		[BindableData(11, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xB1F5E0", Offset = "0xB1E1E0", VA = "0x180B1F5E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x87854A0", Offset = "0x87840A0", VA = "0x1887854A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		[BindableData(12, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanLocalPlayerChatWith
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x318B660", Offset = "0x318A260", VA = "0x18318B660")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x8785500", Offset = "0x8784100", VA = "0x188785500")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		[BindableData(13, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanInviteToJoinLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1034610", Offset = "0x1033210", VA = "0x181034610")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x8785560", Offset = "0x8784160", VA = "0x188785560")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		[BindableData(14, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x87855C0", Offset = "0x87841C0", VA = "0x1887855C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x87855D0", Offset = "0x87841D0", VA = "0x1887855D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		[BindableData(15, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x15A3900", Offset = "0x15A2500", VA = "0x1815A3900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x8785640", Offset = "0x8784240", VA = "0x188785640")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		[BindableData(16, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x1DCCFD0", Offset = "0x1DCBBD0", VA = "0x181DCCFD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x87856A0", Offset = "0x87842A0", VA = "0x1887856A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		[BindableData(17, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsBlocked
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x228AD10", Offset = "0x2289910", VA = "0x18228AD10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x8785700", Offset = "0x8784300", VA = "0x188785700")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x87863A0", Offset = "0x8784FA0", VA = "0x1887863A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xC8A140", Offset = "0xC88D40", VA = "0x180C8A140", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xC88EE0", Offset = "0xC87AE0", VA = "0x180C88EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x8786360", Offset = "0x8784F60", VA = "0x188786360", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<ILoadable> Loaded
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x87862A0", Offset = "0x8784EA0", VA = "0x1887862A0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x8786410", Offset = "0x8785010", VA = "0x188786410", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x87820E0", Offset = "0x8780CE0", VA = "0x1887820E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8784B00", Offset = "0x8783700", VA = "0x188784B00", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8784D20", Offset = "0x8783920", VA = "0x188784D20")]
		private void OnRelationshipUpdated(int? accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8784D10", Offset = "0x8783910", VA = "0x188784D10")]
		private void OnPlayerPresenceUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8784D00", Offset = "0x8783900", VA = "0x188784D00")]
		private void OnPartyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8784930", Offset = "0x8783530", VA = "0x188784930")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8782470", Offset = "0x8781070", VA = "0x188782470")]
		[AsyncStateMachine(typeof(<FetchAccountData>d__96))]
		private void FetchAccountData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x87857F0", Offset = "0x87843F0", VA = "0x1887857F0")]
		[AsyncStateMachine(typeof(<UpdateAccountProgression>d__97))]
		private void UpdateAccountProgression()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8785AE0", Offset = "0x87846E0", VA = "0x188785AE0")]
		private void UpdateRelationship()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8785A10", Offset = "0x8784610", VA = "0x188785A10")]
		[AsyncStateMachine(typeof(<UpdatePresence>d__99))]
		private Task UpdatePresence()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x87858A0", Offset = "0x87844A0", VA = "0x1887858A0")]
		private void UpdateCanInviteToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8785940", Offset = "0x8784540", VA = "0x188785940")]
		private void UpdateIsFriendAndInSameRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8784D90", Offset = "0x8783990", VA = "0x188784D90")]
		private void ResetAccountData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8783300", Offset = "0x8781F00", VA = "0x188783300")]
		[BindableAction(100, null)]
		private void GoToProfilePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8783000", Offset = "0x8781C00", VA = "0x188783000")]
		[BindableAction(101, null)]
		private void GoToChatPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8784760", Offset = "0x8783360", VA = "0x188784760")]
		[BindableAction(102, null)]
		private void InviteToMyLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x87831B0", Offset = "0x8781DB0", VA = "0x1887831B0")]
		[BindableAction(103, null)]
		private void GoToLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8784850", Offset = "0x8783450", VA = "0x188784850")]
		[BindableAction(104, null)]
		private void InviteToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x87851C0", Offset = "0x8783DC0", VA = "0x1887851C0")]
		[BindableAction(105, null)]
		private void SendFriendRequest()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x87834E0", Offset = "0x87820E0", VA = "0x1887834E0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8782520", Offset = "0x8781120", VA = "0x188782520")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8785C90", Offset = "0x8784890", VA = "0x188785C90")]
		public AccountViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[ViewModel]
	public class AppNavButtonViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private struct <FetchLocalAccountInfo>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public AppNavButtonViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private TaskAwaiter<Account> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x87AE190", Offset = "0x87ACD90", VA = "0x1887AE190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private string buttonIdentifierOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private DataResolver activeIdentifierResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private DataResolver targetIdentifierResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private bool buttonPanelActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private string buttonIconId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private bool useProfilePictureAsIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private string profilePictureName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private string buttonIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private IAccountQueryManager accountManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private DataItem<bool> ButtonPanelActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private DataItem<string> ButtonIconIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private DataItem<bool> UseProfilePictureAsIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private DataItem<string> ProfilePictureNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private DataItemAction RequestChangePanelDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public bool ButtonPanelActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xDC0BA0", Offset = "0xDBF7A0", VA = "0x180DC0BA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x879C810", Offset = "0x879B410", VA = "0x18879C810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public string ButtonIconId
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x879C790", Offset = "0x879B390", VA = "0x18879C790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public bool UseProfilePictureAsIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xEF9A80", Offset = "0xEF8680", VA = "0x180EF9A80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x879C8F0", Offset = "0x879B4F0", VA = "0x18879C8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		[BindableData(3, null, DataPermissions.ReadOnly)]
		public string ProfilePictureName
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x879C870", Offset = "0x879B470", VA = "0x18879C870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x879C720", Offset = "0x879B320", VA = "0x18879C720", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x879C6E0", Offset = "0x879B2E0", VA = "0x18879C6E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x879B450", Offset = "0x879A050", VA = "0x18879B450", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x879C390", Offset = "0x879AF90", VA = "0x18879C390")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x879C150", Offset = "0x879AD50", VA = "0x18879C150", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x879BDC0", Offset = "0x879A9C0", VA = "0x18879BDC0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x879B610", Offset = "0x879A210", VA = "0x18879B610")]
		[AsyncStateMachine(typeof(<FetchLocalAccountInfo>d__28))]
		private void FetchLocalAccountInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x879BD00", Offset = "0x879A900", VA = "0x18879BD00")]
		private void OnActiveIdentifierUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x879C250", Offset = "0x879AE50", VA = "0x18879C250")]
		private void OnTargetIdentifierUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x879C310", Offset = "0x879AF10", VA = "0x18879C310")]
		[BindableAction(100, null)]
		private void RequestChangePanel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x879B560", Offset = "0x879A160", VA = "0x18879B560")]
		private void ConfigureImpressions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x879B980", Offset = "0x879A580", VA = "0x18879B980", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x879B6C0", Offset = "0x879A2C0", VA = "0x18879B6C0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x879C4E0", Offset = "0x879B0E0", VA = "0x18879C4E0")]
		public AppNavButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class AppNavMenu : MonoBehaviour, IAppNavMenu
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class <WaitForCloseMenu>d__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000F0")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034B")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F1")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034D")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <WaitForCloseMenu>d__81(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x87B2E20", Offset = "0x87B1A20", VA = "0x1887B2E20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x87B2F70", Offset = "0x87B1B70", VA = "0x1887B2F70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class <WaitForOpenMenu>d__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			private float <watchOpenStart>5__2;

			[Cpp2IlInjected.Token(Token = "0x170000F2")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F3")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000353")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <WaitForOpenMenu>d__80(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x87B2FB0", Offset = "0x87B1BB0", VA = "0x1887B2FB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x87B33C0", Offset = "0x87B1FC0", VA = "0x1887B33C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class <WaitToOpenWatch>d__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000F4")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000357")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000359")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <WaitToOpenWatch>d__82(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x87B3840", Offset = "0x87B2440", VA = "0x1887B3840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x87B38D0", Offset = "0x87B24D0", VA = "0x1887B38D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public const string AppNavLayerName = "interfaces_2025q1_appnav";

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public const string UseAppNavParameterName = "use_app_nav_forship";

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public const string UXFlowLayerName = "interfaces_widgetwatch_ux_flow";

		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public const string RetainUIStateParameterName = "enable_retain_ui_state";

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public const string ShowWatchButtonParameterName = "show_watch_button_in_menus";

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public const string PortalButtonsAsTabsParameterName = "portal_buttons_act_like_tabs";

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public const string RetainUIStateDurationParameterName = "retain_ui_state_duration";

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public const string AlwaysPresentPortalParameterName = "portal_always_present";

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public static readonly AQWXMNIFQIV InitializedEvent;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static AppNavMenu instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		private Canvas menuCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		private HydrateBase appNavHydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		private AppNavViewModel appNavViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[SerializeField]
		private AppNavPanelSwitcher panelSwitcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[SerializeField]
		private PlatformDependentCanvasSizeConfig canvasSizeConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[SerializeField]
		private LongPressInteractable backgroundInteractable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[SerializeField]
		private float forceWatchCloseDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private Coroutine transitionCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private NADKVDSFRLV statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private Transform originalParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool isGoingBack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private BGRHNWBEZAP<object> disableAppNavTokens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public AQWXMNIFQIV BeforeAppNavOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public AQWXMNIFQIV AfterAppNavOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public AQWXMNIFQIV AfterAppNavClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AQWXMNIFQIV OnShouldUseAppNavChanged;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public static bool ShouldRetainUIState
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x879E2E0", Offset = "0x879CEE0", VA = "0x18879E2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public static bool PortalButtonsActAsTabs
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x879DDD0", Offset = "0x879C9D0", VA = "0x18879DDD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public static float RetainUIStateDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x879DF60", Offset = "0x879CB60", VA = "0x18879DF60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public static bool ShouldShowWatchButtonInMenus
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x879E520", Offset = "0x879D120", VA = "0x18879E520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		private static bool showWatchButtonInMenus
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x879E8F0", Offset = "0x879D4F0", VA = "0x18879E8F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public static bool ShouldRetainUIStateAndResetAfterDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x879E270", Offset = "0x879CE70", VA = "0x18879E270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public static bool UseAlwaysPresentPortalPanel
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x879E760", Offset = "0x879D360", VA = "0x18879E760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public static AppNavMenu Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x879DD70", Offset = "0x879C970", VA = "0x18879DD70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool ShouldUseAppNav
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x879E710", Offset = "0x879D310", VA = "0x18879E710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool CanOpenAppNavWhenWatchIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xEF9A80", Offset = "0xEF8680", VA = "0x180EF9A80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x134A8B0", Offset = "0x13494B0", VA = "0x18134A8B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xEF9A90", Offset = "0xEF8690", VA = "0x180EF9A90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xEF94D0", Offset = "0xEF80D0", VA = "0x180EF94D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public bool IsTransitionActive
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x879DDC0", Offset = "0x879C9C0", VA = "0x18879DDC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x18CB820", Offset = "0x18CA420", VA = "0x1818CB820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public bool ShouldOpenLastActivePanel
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x18CFF30", Offset = "0x18CEB30", VA = "0x1818CFF30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x18CFBB0", Offset = "0x18CE7B0", VA = "0x1818CFBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public bool IsToolMenuOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x18CFF40", Offset = "0x18CEB40", VA = "0x1818CFF40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x18CF7F0", Offset = "0x18CE3F0", VA = "0x1818CF7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public bool WasOpenOnNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xB74A20", Offset = "0xB73620", VA = "0x180B74A20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0xB73710", Offset = "0xB72310", VA = "0x180B73710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x879CAB0", Offset = "0x879B6B0", VA = "0x18879CAB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x879D520", Offset = "0x879C120", VA = "0x18879D520")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x879D2D0", Offset = "0x879BED0", VA = "0x18879D2D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x879C950", Offset = "0x879B550", VA = "0x18879C950")]
		public void AddAppNavRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x879D6B0", Offset = "0x879C2B0", VA = "0x18879D6B0")]
		public void RemoveAppNavRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x879D560", Offset = "0x879C160", VA = "0x18879D560")]
		public void OpenMenuWithPreviousPanel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x879D570", Offset = "0x879C170", VA = "0x18879D570", Slot = "5")]
		public void OpenMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x879D200", Offset = "0x879BE00", VA = "0x18879D200", Slot = "6")]
		public void CloseMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x879D630", Offset = "0x879C230", VA = "0x18879D630", Slot = "7")]
		public void OpenWatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x879D610", Offset = "0x879C210", VA = "0x18879D610")]
		public void OpenPage(string pageIdentifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x879DA70", Offset = "0x879C670", VA = "0x18879DA70")]
		[IteratorStateMachine(typeof(<WaitForOpenMenu>d__80))]
		private IEnumerator WaitForOpenMenu()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x879DA00", Offset = "0x879C600", VA = "0x18879DA00")]
		[IteratorStateMachine(typeof(<WaitForCloseMenu>d__81))]
		private IEnumerator WaitForCloseMenu()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x879DAE0", Offset = "0x879C6E0", VA = "0x18879DAE0")]
		[IteratorStateMachine(typeof(<WaitToOpenWatch>d__82))]
		private IEnumerator WaitToOpenWatch()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x879D960", Offset = "0x879C560", VA = "0x18879D960")]
		private void SetMenuClosedState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x879D810", Offset = "0x879C410", VA = "0x18879D810")]
		private void SetCanvasSize(Vector2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x879DC00", Offset = "0x879C800", VA = "0x18879DC00")]
		public AppNavMenu()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class AppNavPanel : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class <RegisterAfterOneFrame>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public AppNavPanel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000F8")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F9")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <RegisterAfterOneFrame>d__10(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x87B0F00", Offset = "0x87AFB00", VA = "0x1887B0F00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x87B0FC0", Offset = "0x87AFBC0", VA = "0x1887B0FC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private string panelIdentifierOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private HydrateBase hydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private AppNavPanelSwitcher panelSwitcher;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public string Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public HydrateBase Hydration
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x879F6E0", Offset = "0x879E2E0", VA = "0x18879F6E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x879F4A0", Offset = "0x879E0A0", VA = "0x18879F4A0")]
		[IteratorStateMachine(typeof(<RegisterAfterOneFrame>d__10))]
		private IEnumerator RegisterAfterOneFrame()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x879F510", Offset = "0x879E110", VA = "0x18879F510")]
		public void SetIdentifier(string identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x879F7D0", Offset = "0x879E3D0", VA = "0x18879F7D0")]
		public AppNavPanel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class AppNavPanelSwitcher : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class <CloseTopLevelOnly>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000FB")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FC")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600037A")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <CloseTopLevelOnly>d__27(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x87ADB80", Offset = "0x87AC780", VA = "0x1887ADB80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x87ADC90", Offset = "0x87AC890", VA = "0x1887ADC90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class <OpenTopLevelOnly>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000FD")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600037E")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FE")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <OpenTopLevelOnly>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x87B0DC0", Offset = "0x87AF9C0", VA = "0x1887B0DC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x87B0EC0", Offset = "0x87AFAC0", VA = "0x1887B0EC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class <SwapPanels>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public string targetIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private bool <startedSwapWithValidCurrentPanel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			private AppNavPanel <targetPanel>5__3;

			[Cpp2IlInjected.Token(Token = "0x170000FF")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000384")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000100")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000386")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <SwapPanels>d__24(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x87B1000", Offset = "0x87AFC00", VA = "0x1887B1000", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x87B1580", Offset = "0x87B0180", VA = "0x1887B1580", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class <WaitThenClose>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000101")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600038A")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000102")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <WaitThenClose>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x87B3400", Offset = "0x87B2000", VA = "0x1887B3400", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x87B36A0", Offset = "0x87B22A0", VA = "0x1887B36A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private float initialWaitBeforeCloseTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private float initialOpenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private CanvasScreenSizeRefitter screenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private HydrateBase topLevelHydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private float topLevelHydrationDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private DataResolver currentPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private DataResolver targetPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private Dictionary<string, AppNavPanel> panelLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private string currentPanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private AppNavPanel currentPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private Coroutine panelSwitchCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Coroutine initialOpenCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Vector3 cachedInitialPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public AQWXMNIFQIV AllPanelsClosed;

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public bool SwitchingPanels
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x7885870", Offset = "0x7884470", VA = "0x187885870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x879EA80", Offset = "0x879D680", VA = "0x18879EA80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x879F140", Offset = "0x879DD40", VA = "0x18879F140")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x1A1D630", Offset = "0x1A1C230", VA = "0x181A1D630")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x879EBC0", Offset = "0x879D7C0", VA = "0x18879EBC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x879ED50", Offset = "0x879D950", VA = "0x18879ED50")]
		public void RegisterPanel(AppNavPanel panel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x879F260", Offset = "0x879DE60", VA = "0x18879F260")]
		public void UnregisterPanel(AppNavPanel panel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x879EC70", Offset = "0x879D870", VA = "0x18879EC70")]
		private void OnTargetPanelUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x879EE40", Offset = "0x879DA40", VA = "0x18879EE40")]
		private void RequestTargetPanel(string identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x879F1D0", Offset = "0x879DDD0", VA = "0x18879F1D0")]
		[IteratorStateMachine(typeof(<SwapPanels>d__24))]
		private IEnumerator SwapPanels(string targetIdentifier)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x879F300", Offset = "0x879DF00", VA = "0x18879F300")]
		[IteratorStateMachine(typeof(<WaitThenClose>d__25))]
		private IEnumerator WaitThenClose()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x879ECE0", Offset = "0x879D8E0", VA = "0x18879ECE0")]
		[IteratorStateMachine(typeof(<OpenTopLevelOnly>d__26))]
		private IEnumerator OpenTopLevelOnly()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x879EB50", Offset = "0x879D750", VA = "0x18879EB50")]
		[IteratorStateMachine(typeof(<CloseTopLevelOnly>d__27))]
		private IEnumerator CloseTopLevelOnly()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x879F370", Offset = "0x879DF70", VA = "0x18879F370")]
		public AppNavPanelSwitcher()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class AppNavTutorial : TutorialHighlightTargeter
	{
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public const string ShowAppNavTutorialParameterName = "enable_app_nav_tutorial";

		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private const string tutorialCompletionKey = "AppNavTutorialCompleted";

		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private const string tutorialSoftExitKey = "AppNavTutorialSoftExit";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private UITutorialData tutorialDataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		private AppNavMenu appNavMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		private string idOfOpenAppNavStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[SerializeField]
		private string idOfWidgetStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		private string idOfPortalStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[SerializeField]
		private int allowedSoftExits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private Tutorial tutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private PPDHWZWSJQC preferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private NADKVDSFRLV statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private bool canShowTutorial;

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public static AppNavTutorial Instance
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x87A0CE0", Offset = "0x879F8E0", VA = "0x1887A0CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x87A0D20", Offset = "0x879F920", VA = "0x1887A0D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x879F830", Offset = "0x879E430", VA = "0x18879F830", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x87A08F0", Offset = "0x879F4F0", VA = "0x1887A08F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x87A03D0", Offset = "0x879EFD0", VA = "0x1887A03D0")]
		public void StartTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x87A0930", Offset = "0x879F530", VA = "0x1887A0930")]
		public void StopTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x879FD90", Offset = "0x879E990", VA = "0x18879FD90")]
		private void OnCanUseAppNavChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x879FEF0", Offset = "0x879EAF0", VA = "0x18879FEF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x879FEE0", Offset = "0x879EAE0", VA = "0x18879FEE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x879FE00", Offset = "0x879EA00", VA = "0x18879FE00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x879FD10", Offset = "0x879E910", VA = "0x18879FD10")]
		private void OnAppNavOpened()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x879FCA0", Offset = "0x879E8A0", VA = "0x18879FCA0")]
		private void OnAppNavClosed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x879FF00", Offset = "0x879EB00", VA = "0x18879FF00")]
		private void OnStepChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x879FA90", Offset = "0x879E690", VA = "0x18879FA90")]
		private void ClearTutorialEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x87A0210", Offset = "0x879EE10", VA = "0x1887A0210")]
		private void OnTutorialStarted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x87A00F0", Offset = "0x879ECF0", VA = "0x1887A00F0")]
		private void OnTutorialExited()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x87A0260", Offset = "0x879EE60", VA = "0x1887A0260")]
		[DebugConsoleCommand("appNavResetTutorial", "Reset the App Nav Tutorial", new KeyCode[] { })]
		private static void ResetTutorialCommand()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x87A0C30", Offset = "0x879F830", VA = "0x1887A0C30")]
		public AppNavTutorial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[ViewModel]
	public class AppNavViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct <FetchPanelIds>d__48 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400023F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000240")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public AppNavViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000243")]
			private TaskAwaiter<List<string>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000244")]
			private string <newDefault>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000245")]
			private List<string>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000246")]
			private string <panelId>5__5;

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x87AE3F0", Offset = "0x87ACFF0", VA = "0x1887AE3F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x87AEB70", Offset = "0x87AD770", VA = "0x1887AEB70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private const string UnifiedUISessionIdKey = "unified_ui_session_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[SerializeField]
		private float reopenToLastPanelThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private string activePanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private string nextPanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private DataList<string> widgetPanelIdentifiers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private float availableHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private Guid sessionGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private bool portalPanelAlwaysPresent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private bool portalPanelAlwaysPresentForTouch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private bool portalPanelAlwaysPresentForScreens;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private CNQMJDRALKE analyticsHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private IMenuManager menuManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private string defaultPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private float lastCloseTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private DataItem<string> ActivePanelIdentifierDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private DataItem<string> NextPanelIdentifierDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private DataItem<float> AvailableHeightDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private DataItem<Guid> SessionGuidDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private DataItem<bool> PortalPanelAlwaysPresentDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private DataItem<bool> PortalPanelAlwaysPresentForTouchDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private DataItem<bool> PortalPanelAlwaysPresentForScreensDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private DataItemList WidgetPanelIdentifiersDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private DataItemAction CloseDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ActivePanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x87A2A20", Offset = "0x87A1620", VA = "0x1887A2A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string NextPanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x87A2AD0", Offset = "0x87A16D0", VA = "0x1887A2AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<string> WidgetPanelIdentifiers
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x87A3080", Offset = "0x87A1C80", VA = "0x1887A3080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public float AvailableHeight
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x1371600", Offset = "0x1370200", VA = "0x181371600")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x87A2B40", Offset = "0x87A1740", VA = "0x1887A2B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public Guid SessionGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x87A2BB0", Offset = "0x87A17B0", VA = "0x1887A2BB0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x87A2BC0", Offset = "0x87A17C0", VA = "0x1887A2BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresent
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x226A2E0", Offset = "0x2268EE0", VA = "0x18226A2E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x87A2C40", Offset = "0x87A1840", VA = "0x1887A2C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresentForTouch
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x87A2880", Offset = "0x87A1480", VA = "0x1887A2880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x87A2890", Offset = "0x87A1490", VA = "0x1887A2890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresentForScreens
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x228E280", Offset = "0x228CE80", VA = "0x18228E280")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x87A28F0", Offset = "0x87A14F0", VA = "0x1887A28F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public string PreviousPanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xBD4140", Offset = "0xBD2D40", VA = "0x180BD4140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0xC13B10", Offset = "0xC12710", VA = "0x180C13B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x87A3040", Offset = "0x87A1C40", VA = "0x1887A3040", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x87A0D80", Offset = "0x879F980", VA = "0x1887A0D80", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x87A21E0", Offset = "0x87A0DE0", VA = "0x1887A21E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x87A2230", Offset = "0x87A0E30", VA = "0x1887A2230")]
		public void Open(string panelIdentifier = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x87A1220", Offset = "0x879FE20", VA = "0x1887A1220")]
		[BindableAction(100, null)]
		public void Close()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x87A1490", Offset = "0x87A0090", VA = "0x1887A1490")]
		[AsyncStateMachine(typeof(<FetchPanelIds>d__48))]
		private Task FetchPanelIds()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x87A26B0", Offset = "0x87A12B0", VA = "0x1887A26B0")]
		private void SetAlwaysPortalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x87A19E0", Offset = "0x87A05E0", VA = "0x1887A19E0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x87A1570", Offset = "0x87A0170", VA = "0x1887A1570")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x87A2CA0", Offset = "0x87A18A0", VA = "0x1887A2CA0")]
		public AppNavViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[ViewModel]
	public class DevToolsViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		[SerializeField]
		private Uri debugToolsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		[SerializeField]
		private Uri testCaseManagementUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		[SerializeField]
		private Uri bugReportingUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		[SerializeField]
		private Uri componentLibraryUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private bool canAccessDevTools;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private bool developerToolsActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private bool shouldShowDebugTools;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private DataItem<bool> CanAccessDevToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private DataItem<bool> DeveloperToolsActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private DataItem<bool> ShouldShowDebugToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private DataItemAction OpenDebugToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private DataItemAction OpenTestCaseManagementDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private DataItemAction OpenBugReportingDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private DataItemAction OpenComponentLibraryDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool CanAccessDevTools
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0D0", Offset = "0xB9CCD0", VA = "0x180B9E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x87A3E10", Offset = "0x87A2A10", VA = "0x1887A3E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool DeveloperToolsActive
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xB9E070", Offset = "0xB9CC70", VA = "0x180B9E070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x87A3E70", Offset = "0x87A2A70", VA = "0x1887A3E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool ShouldShowDebugTools
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0E0", Offset = "0xB9CCE0", VA = "0x180B9E0E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x87A3ED0", Offset = "0x87A2AD0", VA = "0x1887A3ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x87A4240", Offset = "0x87A2E40", VA = "0x1887A4240", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x87A30F0", Offset = "0x87A1CF0", VA = "0x1887A30F0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x87A3C30", Offset = "0x87A2830", VA = "0x1887A3C30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x87A3F30", Offset = "0x87A2B30", VA = "0x1887A3F30")]
		private void UpdateBasedOnLocalAccount()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x87A3D50", Offset = "0x87A2950", VA = "0x1887A3D50")]
		[BindableAction(100, null)]
		private void OpenDebugTools()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x87A3DB0", Offset = "0x87A29B0", VA = "0x1887A3DB0")]
		[BindableAction(101, null)]
		private void OpenTestCaseManagement()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x87A3C90", Offset = "0x87A2890", VA = "0x1887A3C90")]
		[BindableAction(102, null)]
		private void OpenBugReporting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x87A3CF0", Offset = "0x87A28F0", VA = "0x1887A3CF0")]
		[BindableAction(103, null)]
		private void OpenComponentLibrary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x87A3700", Offset = "0x87A2300", VA = "0x1887A3700", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x87A3370", Offset = "0x87A1F70", VA = "0x1887A3370")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x87A4090", Offset = "0x87A2C90", VA = "0x1887A4090")]
		public DevToolsViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public interface IAppNavMenu
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[ViewModel]
	public class PortalButtonViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		[SerializeField]
		private UILinkLookup routeLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private PortalButtonConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private LinkInfo linkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private string iconName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private DataItem<string> IconNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private DataItemAction OpenRouteDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x87A9C50", Offset = "0x87A8850", VA = "0x1887A9C50", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x87A9CC0", Offset = "0x87A88C0", VA = "0x1887A9CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string IconName
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x87A9D40", Offset = "0x87A8940", VA = "0x1887A9D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x87A9C10", Offset = "0x87A8810", VA = "0x1887A9C10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x87A9930", Offset = "0x87A8530", VA = "0x1887A9930")]
		[BindableAction(2, null)]
		public void OpenRoute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x87A8E50", Offset = "0x87A7A50", VA = "0x1887A8E50", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x87A9370", Offset = "0x87A7F70", VA = "0x1887A9370")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x87A90C0", Offset = "0x87A7CC0", VA = "0x1887A90C0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x87A8EE0", Offset = "0x87A7AE0", VA = "0x1887A8EE0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x87A9AD0", Offset = "0x87A86D0", VA = "0x1887A9AD0")]
		public PortalButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[ViewModel]
	public class PortalPanelViewModel : RRUIBaseGlobalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct <FetchPortalPanelData>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000274")]
			public PortalPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000275")]
			private TaskAwaiter<PortalPanelConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x87AEBD0", Offset = "0x87AD7D0", VA = "0x1887AEBD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x87AEFA0", Offset = "0x87ADBA0", VA = "0x1887AEFA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct <WaitThenUpdateBackplate>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000276")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			public PortalPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000279")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x87B36E0", Offset = "0x87B22E0", VA = "0x1887B36E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		[SerializeField]
		private List<RectTransform> backplateRects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		[SerializeField]
		private Vector2 verticalBackplatePadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		[SerializeField]
		private RectTransform sectionParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		[SerializeField]
		private RectTransform trayButtonParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private DataList<PortalButtonGroupConfig> sections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private bool hasWidget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private bool portalPanelOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private DataItem<bool> HasWidgetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private DataItem<string> WidgetIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private DataItem<bool> PortalPanelOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private DataItemList SectionsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private DataItemAction TogglePanelStateDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<PortalButtonGroupConfig> Sections
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x87AB1D0", Offset = "0x87A9DD0", VA = "0x1887AB1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool HasWidget
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xCBFFF0", Offset = "0xCBEBF0", VA = "0x180CBFFF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x87AA840", Offset = "0x87A9440", VA = "0x1887AA840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string WidgetId
		{
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x87AB230", Offset = "0x87A9E30", VA = "0x1887AB230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool PortalPanelOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0D0", Offset = "0xB9CCD0", VA = "0x180B9E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x87AA8B0", Offset = "0x87A94B0", VA = "0x1887AA8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x87AB190", Offset = "0x87A9D90", VA = "0x1887AB190", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x87A9DC0", Offset = "0x87A89C0", VA = "0x1887A9DC0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x87AA7C0", Offset = "0x87A93C0", VA = "0x1887AA7C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x87AA790", Offset = "0x87A9390", VA = "0x1887AA790", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x87A9F70", Offset = "0x87A8B70", VA = "0x1887A9F70")]
		[AsyncStateMachine(typeof(<FetchPortalPanelData>d__25))]
		private Task FetchPortalPanelData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x87AAE70", Offset = "0x87A9A70", VA = "0x1887AAE70")]
		[AsyncStateMachine(typeof(<WaitThenUpdateBackplate>d__26))]
		private void WaitThenUpdateBackplate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x87AA9E0", Offset = "0x87A95E0", VA = "0x1887AA9E0")]
		private void UpdateBackplateRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x87AA7D0", Offset = "0x87A93D0", VA = "0x1887AA7D0")]
		[BindableAction(100, null)]
		private void TogglePanelState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x87AA300", Offset = "0x87A8F00", VA = "0x1887AA300", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x87AA040", Offset = "0x87A8C40", VA = "0x1887AA040")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x87AAF20", Offset = "0x87A9B20", VA = "0x1887AAF20")]
		public PortalPanelViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[ViewModel]
	public class PortalSectionViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private PortalButtonGroupConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private string sectionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private string iconName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private DataList<PortalButtonConfig> buttons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private DataItem<string> SectionNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private DataItem<string> IconNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private DataItemList ButtonsDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x87ABE10", Offset = "0x87AAA10", VA = "0x1887ABE10", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string SectionName
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x87ABAC0", Offset = "0x87AA6C0", VA = "0x1887ABAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string IconName
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x87ABB30", Offset = "0x87AA730", VA = "0x1887ABB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<PortalButtonConfig> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x87ABE80", Offset = "0x87AAA80", VA = "0x1887ABE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x87ABDD0", Offset = "0x87AA9D0", VA = "0x1887ABDD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x87AB7A0", Offset = "0x87AA3A0", VA = "0x1887AB7A0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x87AB490", Offset = "0x87AA090", VA = "0x1887AB490", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x87AB2B0", Offset = "0x87A9EB0", VA = "0x1887AB2B0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x87ABC70", Offset = "0x87AA870", VA = "0x1887ABC70")]
		public PortalSectionViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[ViewModel]
	public class WidgetPanelViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct <FetchWidgetData>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000291")]
			public WidgetPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			private int <currentCount>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			private TaskAwaiter<List<string>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x87AF000", Offset = "0x87ADC00", VA = "0x1887AF000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x87AF750", Offset = "0x87AE350", VA = "0x1887AF750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		[SerializeField]
		private float defaultHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		[SerializeField]
		private int maximumWidgetCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		[SerializeField]
		private WidgetPrefabMapping widgetPrefabMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		[SerializeField]
		private AppNavPanel panel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		[SerializeField]
		private DataResolver availableHeightResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private string panelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private float maxHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private float currentHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private List<string> tempList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private DataList<string> widgetIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private DataItemList WidgetIdListDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x87B4550", Offset = "0x87B3150", VA = "0x1887B4550", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<string> WidgetIdList
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xB1B710", Offset = "0xB1A310", VA = "0x180B1B710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x87B45C0", Offset = "0x87B31C0", VA = "0x1887B45C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x87B4510", Offset = "0x87B3110", VA = "0x1887B4510", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x87B3910", Offset = "0x87B2510", VA = "0x1887B3910", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x87B41F0", Offset = "0x87B2DF0", VA = "0x1887B41F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x87B4060", Offset = "0x87B2C60", VA = "0x1887B4060", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x87B3BE0", Offset = "0x87B27E0", VA = "0x1887B3BE0")]
		[AsyncStateMachine(typeof(<FetchWidgetData>d__19))]
		public Task FetchWidgetData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x87B3F60", Offset = "0x87B2B60", VA = "0x1887B3F60")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x87B3B00", Offset = "0x87B2700", VA = "0x1887B3B00")]
		private void CheckIfShouldFetchData(string changedPanelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x87B3B80", Offset = "0x87B2780", VA = "0x1887B3B80")]
		private void DoFetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x87B3F00", Offset = "0x87B2B00", VA = "0x1887B3F00")]
		private void OnAvailableHeightUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x87B3DB0", Offset = "0x87B29B0", VA = "0x1887B3DB0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x87B3CB0", Offset = "0x87B28B0", VA = "0x1887B3CB0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x87B43B0", Offset = "0x87B2FB0", VA = "0x1887B43B0")]
		public WidgetPanelViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class WidgetInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AssetReference WidgetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public float MaxHeight;

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x1563010", Offset = "0x1561C10", VA = "0x181563010")]
		public WidgetInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CreateAssetMenu(fileName = "WidgetPrefabMapping", menuName = "RecRoom/UI/App Nav/Widget Prefab Mapping")]
	public class WidgetPrefabMapping : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public List<WidgetInfo> widgetPrefabs;

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x87B4630", Offset = "0x87B3230", VA = "0x1887B4630")]
		public bool TryGetReference(string widgetId, [Out] AssetReference reference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x87B47C0", Offset = "0x87B33C0", VA = "0x1887B47C0")]
		public bool TryGetWidgetHeight(string widgetId, [Out] float height)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xDB83A0", Offset = "0xDB6FA0", VA = "0x180DB83A0")]
		public WidgetPrefabMapping()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[ViewModel]
	public class WidgetWrapperViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class <MonitorWidgetForSizeChanges>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			public WidgetWrapperViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			private RectTransform <widgetTransform>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700012D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000456")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700012E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000458")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <MonitorWidgetForSizeChanges>d__23(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x87AF7B0", Offset = "0x87AE3B0", VA = "0x1887AF7B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x87AFAB0", Offset = "0x87AE6B0", VA = "0x1887AFAB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private struct <UpdateWidget>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			public string widgetId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public WidgetWrapperViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			private string <typeId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			private AssetReference <reference>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			private AsyncOperationHandle<GameObject> <refHandle>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x87B2520", Offset = "0x87B1120", VA = "0x1887B2520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x87B2DC0", Offset = "0x87B19C0", VA = "0x1887B2DC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public const string WIDGET_ID_PROPERTY = "widget_id";

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public const string WIDGET_TYPE_PROPERTY = "widget_type_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		[SerializeField]
		private WidgetPrefabMapping prefabMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		[SerializeField]
		private DataResolver sessionIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		[SerializeField]
		private bool forceWidgetToFitWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private AssetReference widgetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private GameObject instantiatedWidget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private ImpressionTracker widgetImpressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private Vector2 cachedWidgetSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private Coroutine widgetSizeCheckCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private DataItem<string> WidgetIdDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string WidgetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x87B5290", Offset = "0x87B3E90", VA = "0x1887B5290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x87B5220", Offset = "0x87B3E20", VA = "0x1887B5220", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x87B51E0", Offset = "0x87B3DE0", VA = "0x1887B51E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x87B4940", Offset = "0x87B3540", VA = "0x1887B4940", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x87B4EE0", Offset = "0x87B3AE0", VA = "0x1887B4EE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x87B4E90", Offset = "0x87B3A90", VA = "0x1887B4E90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x87B4CD0", Offset = "0x87B38D0", VA = "0x1887B4CD0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x87B4FE0", Offset = "0x87B3BE0", VA = "0x1887B4FE0")]
		[AsyncStateMachine(typeof(<UpdateWidget>d__22))]
		public Task UpdateWidget(string widgetId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x87B4C60", Offset = "0x87B3860", VA = "0x1887B4C60")]
		[IteratorStateMachine(typeof(<MonitorWidgetForSizeChanges>d__23))]
		private IEnumerator MonitorWidgetForSizeChanges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x87B4F80", Offset = "0x87B3B80", VA = "0x1887B4F80")]
		private void ReleaseWidgetReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x87B4B10", Offset = "0x87B3710", VA = "0x1887B4B10", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x87B4A10", Offset = "0x87B3610", VA = "0x1887B4A10")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x87B50F0", Offset = "0x87B3CF0", VA = "0x1887B50F0")]
		public WidgetWrapperViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[ViewModel]
	public class AccountsWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			public AccountsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			private TaskAwaiter<AccountListQueryData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x87AFD70", Offset = "0x87AE970", VA = "0x1887AFD70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private IAppNavDataManager _appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private IRRUIvNextAccountBridge _vNextAccountBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		[SerializeField]
		private AccountListViewModel accountListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private AccountListQueryData _queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private DataItem<AccountListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public AccountListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x879B320", Offset = "0x8799F20", VA = "0x18879B320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x879B410", Offset = "0x879A010", VA = "0x18879B410", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x879ADA0", Offset = "0x87999A0", VA = "0x18879ADA0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x879B1C0", Offset = "0x8799DC0", VA = "0x18879B1C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x879B270", Offset = "0x8799E70", VA = "0x18879B270")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__10))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x879B070", Offset = "0x8799C70", VA = "0x18879B070", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x879AF70", Offset = "0x8799B70", VA = "0x18879AF70")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x879B390", Offset = "0x8799F90", VA = "0x18879B390")]
		public AccountsWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[ViewModel]
	public class LocalPlayerWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private struct <FetchDataAsync>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			public LocalPlayerWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			private TaskAwaiter<Account> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x87ADCD0", Offset = "0x87AC8D0", VA = "0x1887ADCD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private const int INVALID_TOKEN_BALANCE = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		[SerializeField]
		private AccountViewModel accountViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		[SerializeField]
		private bool manuallySetWidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		[SerializeField]
		private Uri profilePageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[SerializeField]
		private LinkInfo profileLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		[SerializeField]
		private Uri notificationsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		[SerializeField]
		private LinkInfo notificationsLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[SerializeField]
		private Uri settingsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		[SerializeField]
		private LinkInfo settingsLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[SerializeField]
		private Uri rrPlusSubscriptionUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private string profilePictureName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private string userName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private bool hasUnreadNotifications;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private long tokenBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private bool hasRecRoomPlus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private IAccountQueryManager accountManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private IRecRoomPlusDataManager rrPlusDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private int localPlayerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private DataItem<string> ProfilePictureNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private DataItem<string> UserNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private DataItem<bool> HasUnreadNotificationsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private DataItem<long> TokenBalanceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private DataItem<bool> HasRecRoomPlusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private DataItemAction GoToProfilePageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private DataItemAction GoToNotificationsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private DataItemAction GoToSettingsPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private DataItemAction GoToRRPlusPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ProfilePictureName
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xB74D40", Offset = "0xB73940", VA = "0x180B74D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x87A5D40", Offset = "0x87A4940", VA = "0x1887A5D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xF48A30", Offset = "0xF47630", VA = "0x180F48A30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x87A5CB0", Offset = "0x87A48B0", VA = "0x1887A5CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string UserName
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xBD41A0", Offset = "0xBD2DA0", VA = "0x180BD41A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x87A5DC0", Offset = "0x87A49C0", VA = "0x1887A5DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool HasUnreadNotifications
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x1620060", Offset = "0x161EC60", VA = "0x181620060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x87A58B0", Offset = "0x87A44B0", VA = "0x1887A58B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public long TokenBalance
		{
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0xBD4140", Offset = "0xBD2D40", VA = "0x180BD4140")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x87A5910", Offset = "0x87A4510", VA = "0x1887A5910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool HasRecRoomPlus
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xF6B6A0", Offset = "0xF6A2A0", VA = "0x180F6B6A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x87A5820", Offset = "0x87A4420", VA = "0x1887A5820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x87A5C70", Offset = "0x87A4870", VA = "0x1887A5C70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x87A4280", Offset = "0x87A2E80", VA = "0x1887A4280", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x87A56B0", Offset = "0x87A42B0", VA = "0x1887A56B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x87A44E0", Offset = "0x87A30E0", VA = "0x1887A44E0")]
		[AsyncStateMachine(typeof(<FetchDataAsync>d__40))]
		private void FetchDataAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x87A5760", Offset = "0x87A4360", VA = "0x1887A5760")]
		private void RefreshTokenBalance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x87A4B80", Offset = "0x87A3780", VA = "0x1887A4B80")]
		[BindableAction(100, null)]
		private void GoToProfilePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x87A4A70", Offset = "0x87A3670", VA = "0x1887A4A70")]
		[BindableAction(101, null)]
		private void GoToNotifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x87A4DD0", Offset = "0x87A39D0", VA = "0x1887A4DD0")]
		[BindableAction(102, null)]
		private void GoToSettingsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x87A4C90", Offset = "0x87A3890", VA = "0x1887A4C90")]
		[BindableAction(103, null)]
		private void GoToRRPlusPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x87A4EE0", Offset = "0x87A3AE0", VA = "0x1887A4EE0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x87A4590", Offset = "0x87A3190", VA = "0x1887A4590")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x87A5970", Offset = "0x87A4570", VA = "0x1887A5970")]
		public LocalPlayerWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[ViewModel]
	public class MyDormWidgetViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		private Uri thisRoomUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private DataItemAction OpenThisRoomPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private DataItemAction GoToRecCenterDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private DataItemAction EvictAllDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x87A6A20", Offset = "0x87A5620", VA = "0x1887A6A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0x87A6D40", Offset = "0x87A5940", VA = "0x1887A6D40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x87A5E40", Offset = "0x87A4A40", VA = "0x1887A5E40", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x87A6A90", Offset = "0x87A5690", VA = "0x1887A6A90")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x87A6960", Offset = "0x87A5560", VA = "0x1887A6960")]
		[BindableAction(100, null)]
		private void OpenThisRoomPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x87A6440", Offset = "0x87A5040", VA = "0x1887A6440")]
		[BindableAction(101, null)]
		private void GoToRecCenter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x87A60E0", Offset = "0x87A4CE0", VA = "0x1887A60E0")]
		[BindableAction(102, null)]
		private void EvictAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x87A6900", Offset = "0x87A5500", VA = "0x1887A6900")]
		private void OnJoinRoomResponse(JoinRoomResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x87A65F0", Offset = "0x87A51F0", VA = "0x1887A65F0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x87A61F0", Offset = "0x87A4DF0", VA = "0x1887A61F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x87A6C00", Offset = "0x87A5800", VA = "0x1887A6C00")]
		public MyDormWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[ViewModel]
	public class PartyWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private struct <OnPartyChanged>d__39 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public PartyWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x87AFAF0", Offset = "0x87AE6F0", VA = "0x1887AFAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private struct <UpdatePartyData>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public PartyWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x87B17E0", Offset = "0x87B03E0", VA = "0x1887B17E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x87B1F90", Offset = "0x87B0B90", VA = "0x1887B1F90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		private Uri createPartyUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		private Uri managePartyUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		private Uri openPartyChatUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		private float notInPartyHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		private float inPartyHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private bool inParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private bool partyChatAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private bool canGoToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8B")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private bool canAddToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private DataList<int> partyMembers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private int partyMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private bool hasUnreadPartyChatMessages;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private IRRUIvNextSocialBridge socialBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private bool updatePending;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private bool updateQueued;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private DataItem<bool> InPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private DataItem<bool> PartyChatAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private DataItem<bool> CanGoToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private DataItem<bool> CanAddToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private DataItem<int> PartyMemberCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private DataItem<bool> HasUnreadPartyChatMessagesDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private DataItemList PartyMembersDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private DataItemAction CreateOrJoinPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private DataItemAction OpenPartyChatDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private DataItemAction GoToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private DataItemAction AddToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private DataItemAction ManagePartyDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool InParty
		{
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0D0", Offset = "0xB9CCD0", VA = "0x180B9E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x87A87C0", Offset = "0x87A73C0", VA = "0x1887A87C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool PartyChatAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0xB9E070", Offset = "0xB9CC70", VA = "0x180B9E070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x87A8820", Offset = "0x87A7420", VA = "0x1887A8820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool CanGoToParty
		{
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0E0", Offset = "0xB9CCE0", VA = "0x180B9E0E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x87A8880", Offset = "0x87A7480", VA = "0x1887A8880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool CanAddToParty
		{
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0C0", Offset = "0xB9CCC0", VA = "0x180B9E0C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x87A88E0", Offset = "0x87A74E0", VA = "0x1887A88E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public DataList<int> PartyMembers
		{
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x87A8DE0", Offset = "0x87A79E0", VA = "0x1887A8DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public int PartyMemberCount
		{
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x105A8E0", Offset = "0x10594E0", VA = "0x18105A8E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x87A8940", Offset = "0x87A7540", VA = "0x1887A8940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool HasUnreadPartyChatMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x226A2E0", Offset = "0x2268EE0", VA = "0x18226A2E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x87A8690", Offset = "0x87A7290", VA = "0x1887A8690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x87A8DA0", Offset = "0x87A79A0", VA = "0x1887A8DA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x87A6E50", Offset = "0x87A5A50", VA = "0x1887A6E50", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x87A8240", Offset = "0x87A6E40", VA = "0x1887A8240", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x87A8380", Offset = "0x87A6F80", VA = "0x1887A8380")]
		[AsyncStateMachine(typeof(<OnPartyChanged>d__39))]
		private void OnPartyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x87A89A0", Offset = "0x87A75A0", VA = "0x1887A89A0")]
		[AsyncStateMachine(typeof(<UpdatePartyData>d__40))]
		private Task UpdatePartyData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x87A85A0", Offset = "0x87A71A0", VA = "0x1887A85A0")]
		private void SetHeight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x87A8430", Offset = "0x87A7030", VA = "0x1887A8430")]
		private void OnPartyChatUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x87A70F0", Offset = "0x87A5CF0", VA = "0x1887A70F0")]
		[BindableAction(100, null)]
		private void CreateOrJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x87A84D0", Offset = "0x87A70D0", VA = "0x1887A84D0")]
		[BindableAction(101, null)]
		private void OpenPartyChat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x87A7780", Offset = "0x87A6380", VA = "0x1887A7780")]
		[BindableAction(102, null)]
		private void GoToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x87A6D80", Offset = "0x87A5980", VA = "0x1887A6D80")]
		[BindableAction(103, null)]
		private void AddToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x87A8170", Offset = "0x87A6D70", VA = "0x1887A8170")]
		[BindableAction(104, null)]
		private void ManageParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x87A7840", Offset = "0x87A6440", VA = "0x1887A7840", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x87A71C0", Offset = "0x87A5DC0", VA = "0x1887A71C0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x87A8A70", Offset = "0x87A7670", VA = "0x1887A8A70")]
		public PartyWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class RoomCarouselWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			public RoomCarouselWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			private string <widgetId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			private WidgetSourceData <widgetSourceData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x87B0670", Offset = "0x87AF270", VA = "0x1887B0670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[SerializeField]
		private RoomListViewModel roomListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x87ABEF0", Offset = "0x87AAAF0", VA = "0x1887ABEF0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x87AC0C0", Offset = "0x87AACC0", VA = "0x1887AC0C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x87AC170", Offset = "0x87AAD70", VA = "0x1887AC170")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__7))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x87AC220", Offset = "0x87AAE20", VA = "0x1887AC220")]
		public RoomCarouselWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[ViewModel]
	public class RoomCategoryCarouselWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public RoomCategoryCarouselWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			private string <widgetId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			private WidgetSourceData <widgetSourceData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0x87B0100", Offset = "0x87AED00", VA = "0x1887B0100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		[SerializeField]
		private RoomCategoryListViewModel categoryListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x87AC660", Offset = "0x87AB260", VA = "0x1887AC660", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x87AC290", Offset = "0x87AAE90", VA = "0x1887AC290", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x87AC4F0", Offset = "0x87AB0F0", VA = "0x1887AC4F0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x87AC5A0", Offset = "0x87AB1A0", VA = "0x1887AC5A0")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__6))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x87AC4E0", Offset = "0x87AB0E0", VA = "0x1887AC4E0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x87AC460", Offset = "0x87AB060", VA = "0x1887AC460")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x87AC650", Offset = "0x87AB250", VA = "0x1887AC650")]
		public RoomCategoryCarouselWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[ViewModel]
	public class StoreItemsWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct <OnQueryDataLoaded>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x87D14C0", Offset = "0x87D00C0", VA = "0x1887D14C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x87D1670", Offset = "0x87D0270", VA = "0x1887D1670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private struct <TryLoadingFromActiveSourceList>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x87D1F20", Offset = "0x87D0B20", VA = "0x1887D1F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x87D22E0", Offset = "0x87D0EE0", VA = "0x1887D22E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		[SerializeField]
		private int maxItemsInList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private IAppNavDataManager _appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private List<WidgetSourceData> sourceList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private int activeSectionIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private WidgetSourceData widgetSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		[SerializeField]
		private StoreItemListViewModel storeItemListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private StoreItemListQueryData _queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private DataItem<StoreItemListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private DataItemAction GoToStorePageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		private RoomDTO Room
		{
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0x87ADB40", Offset = "0x87AC740", VA = "0x1887ADB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		private bool CanShowRelatedStoreItems
		{
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0x87AD950", Offset = "0x87AC550", VA = "0x1887AD950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public StoreItemListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xF48A30", Offset = "0xF47630", VA = "0x180F48A30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0x87AD810", Offset = "0x87AC410", VA = "0x1887AD810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0x87ADB00", Offset = "0x87AC700", VA = "0x1887ADB00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004ED")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x87ACAD0", Offset = "0x87AB6D0", VA = "0x1887ACAD0")]
		[BindableAction(100, null)]
		private void GoToStorePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x87AC6A0", Offset = "0x87AB2A0", VA = "0x1887AC6A0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x87ACE90", Offset = "0x87ABA90", VA = "0x1887ACE90", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x87AD050", Offset = "0x87ABC50", VA = "0x1887AD050")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__21))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x87AD2F0", Offset = "0x87ABEF0", VA = "0x1887AD2F0")]
		[AsyncStateMachine(typeof(<TryLoadingFromActiveSourceList>d__22))]
		private Task<bool> TryLoadingFromActiveSourceList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x87AD100", Offset = "0x87ABD00", VA = "0x1887AD100")]
		private bool TryLoadSection(SectionDTO section)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x87AD220", Offset = "0x87ABE20", VA = "0x1887AD220")]
		private bool TryLoadSource(string source, string sourceMetadata)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x87AD3E0", Offset = "0x87ABFE0", VA = "0x1887AD3E0")]
		private bool TrySetQueryData(string source, string sourceMetadata)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x87ACFA0", Offset = "0x87ABBA0", VA = "0x1887ACFA0")]
		[AsyncStateMachine(typeof(<OnQueryDataLoaded>d__26))]
		private void OnQueryDataLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x87ACCA0", Offset = "0x87AB8A0", VA = "0x1887ACCA0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x87AC960", Offset = "0x87AB560", VA = "0x1887AC960")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x87AD880", Offset = "0x87AC480", VA = "0x1887AD880")]
		public StoreItemsWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[ViewModel]
	public class ThisRoomWidgetViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		[SerializeField]
		private Uri thisRoomUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private bool canReportRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private DataItem<bool> CanReportRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private DataItemAction OpenThisRoomPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private DataItemAction GoToDormDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private DataItemAction ReportRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private DataItemAction GoToRecCenterDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x87D0400", Offset = "0x87CF000", VA = "0x1887D0400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool CanReportRoom
		{
			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0xCBFFF0", Offset = "0xCBEBF0", VA = "0x180CBFFF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x87D0470", Offset = "0x87CF070", VA = "0x1887D0470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x87D07E0", Offset = "0x87CF3E0", VA = "0x1887D07E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x87CF400", Offset = "0x87CE000", VA = "0x1887CF400", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x87D04D0", Offset = "0x87CF0D0", VA = "0x1887D04D0")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x87D0110", Offset = "0x87CED10", VA = "0x1887D0110")]
		[BindableAction(100, null)]
		private void OpenThisRoomPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x87CF9B0", Offset = "0x87CE5B0", VA = "0x1887CF9B0")]
		[BindableAction(101, null)]
		private void GoToDorm()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x87D01D0", Offset = "0x87CEDD0", VA = "0x1887D01D0")]
		[BindableAction(102, null)]
		private void ReportRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x87CFA60", Offset = "0x87CE660", VA = "0x1887CFA60")]
		[BindableAction(103, null)]
		private void GoToRecCenter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x87D00B0", Offset = "0x87CECB0", VA = "0x1887D00B0")]
		private void OnJoinRoomResponse(JoinRoomResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x87CFC20", Offset = "0x87CE820", VA = "0x1887CFC20", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x87CF690", Offset = "0x87CE290", VA = "0x1887CF690")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x87D0630", Offset = "0x87CF230", VA = "0x1887D0630")]
		public ThisRoomWidgetViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class AssetReferenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public AssetReference Asset;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x1563010", Offset = "0x1561C10", VA = "0x181563010")]
		public AssetReferenceInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CreateAssetMenu(fileName = "AssetReferenceLookup", menuName = "RecRoom/UI/Asset Reference Lookup")]
	public class AssetReferenceLookup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		[SerializeField]
		private List<AssetReferenceInfo> assetReferences;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x87B5310", Offset = "0x87B3F10", VA = "0x1887B5310")]
		public bool TryGetAssetReference(string assetId, [Out] AssetReference assetReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xDB83A0", Offset = "0xDB6FA0", VA = "0x180DB83A0")]
		public AssetReferenceLookup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[ViewModel]
	public class StoreItemListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct <FetchData>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public StoreItemListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<IReadOnlyList<HSUCUPBTDYC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x87D0820", Offset = "0x87CF420", VA = "0x1887D0820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private static readonly List<UnifiedItemId> ImmediateUnifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public AQWXMNIFQIV OnDataFetched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private IRRUIvNextStoreItemBridge _vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private IStoreItemQueryManager _storeItemListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private CancellationTokenSource _cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private bool _waitingForQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private int _minItemsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		[SerializeField]
		private StoreItemListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private DataList<UnifiedItemId> _storeItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private string _displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private bool _isEmptyOrBelowMinimum;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private DataItem<StoreItemListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private DataItem<bool> IsEmptyOrBelowMinimumDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private DataItemList StoreItemIdsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private DataItemAction GoToViewMorePageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int MinItemsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x3085020", Offset = "0x3083C20", VA = "0x183085020")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x87CC6E0", Offset = "0x87CB2E0", VA = "0x1887CC6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		[BindableData(0, "The query data used to retrieve the store item list", DataPermissions.ReadOnly)]
		public StoreItemListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public DataList<UnifiedItemId> StoreItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0xB1B710", Offset = "0xB1A310", VA = "0x180B1B710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x87CC710", Offset = "0x87CB310", VA = "0x1887CC710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		[BindableData(2, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0xB74D40", Offset = "0xB73940", VA = "0x180B74D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x87CC660", Offset = "0x87CB260", VA = "0x1887CC660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool IsEmptyOrBelowMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0xB74A20", Offset = "0xB73620", VA = "0x180B74A20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x87CC200", Offset = "0x87CAE00", VA = "0x1887CC200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x87CC620", Offset = "0x87CB220", VA = "0x1887CC620", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x87CBA40", Offset = "0x87CA640", VA = "0x1887CBA40")]
		public void SetDiscoverySectionId(string sectionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x87CBAF0", Offset = "0x87CA6F0", VA = "0x1887CBAF0")]
		public void SetParentTabName(string parentTabName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x87CB1C0", Offset = "0x87C9DC0", VA = "0x1887CB1C0")]
		[BindableAction(100, null)]
		private void GoToViewMorePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x87CABA0", Offset = "0x87C97A0", VA = "0x1887CABA0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x87CC180", Offset = "0x87CAD80", VA = "0x1887CC180")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x87CB9A0", Offset = "0x87CA5A0", VA = "0x1887CB9A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x87CBC70", Offset = "0x87CA870", VA = "0x1887CBC70")]
		public void SetQueryData(StoreItemListQueryData listQueryData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x87CBBA0", Offset = "0x87CA7A0", VA = "0x1887CBBA0")]
		public void SetPropertiesToDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x87CACB0", Offset = "0x87C98B0", VA = "0x1887CACB0")]
		[AsyncStateMachine(typeof(<FetchData>d__35))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x87CB020", Offset = "0x87C9C20", VA = "0x1887CB020")]
		private string GetDisplayName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x87CBDA0", Offset = "0x87CA9A0", VA = "0x1887CBDA0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x87CB510", Offset = "0x87CA110", VA = "0x1887CB510", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x87CAD60", Offset = "0x87C9960", VA = "0x1887CAD60")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x87CC3C0", Offset = "0x87CAFC0", VA = "0x1887CC3C0")]
		public StoreItemListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[ViewModel]
	public class StoreItemViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private struct <FetchStoreItemData>d__54 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public StoreItemViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<HSUCUPBTDYC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x87D1110", Offset = "0x87CFD10", VA = "0x1887D1110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private static Log Log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private IRRUIvNextStoreItemBridge _vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private Uri itemDetailsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private string _thumbnailImageFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private string costText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private bool isOnSale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private string saleText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private bool isLimitedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private string limitedTimeText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private bool isOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private bool isRecRoomPlusExclusive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private UnifiedItemId storeItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private long price;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private DataItem<string> ThumbnailImageFilenameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private DataItem<string> CostTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private DataItem<bool> IsOnSaleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private DataItem<string> SaleTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private DataItem<bool> IsLimitedTimeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private DataItem<string> LimitedTimeTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private DataItem<bool> IsOwnedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private DataItem<bool> IsRecRoomPlusExclusiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private DataItem<UnifiedItemId> StoreItemIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private DataItem<long> PriceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private DataItemAction GoToDetailsPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x87CEE60", Offset = "0x87CDA60", VA = "0x1887CEE60", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x87CF380", Offset = "0x87CDF80", VA = "0x1887CF380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		[BindableData(1, "The sanitized, friendly name of the store item", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x87CEF50", Offset = "0x87CDB50", VA = "0x1887CEF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		[BindableData(2, "The price of the item (including strikethrough for discounts or 'Owned' if owned)", DataPermissions.ReadOnly)]
		public string CostText
		{
			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0x87CEED0", Offset = "0x87CDAD0", VA = "0x1887CEED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		[BindableData(3, "Whether or not the item is currently on sale (has a discount)", DataPermissions.ReadOnly)]
		public bool IsOnSale
		{
			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D60", Offset = "0xBB2960", VA = "0x180BB3D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0x87CF030", Offset = "0x87CDC30", VA = "0x1887CF030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		[BindableData(4, "Text to show on the sale banner", DataPermissions.ReadOnly)]
		public string SaleText
		{
			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0xB1B710", Offset = "0xB1A310", VA = "0x180B1B710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x87CF1D0", Offset = "0x87CDDD0", VA = "0x1887CF1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		[BindableData(5, "Whether or not to show the 'Limited Time' banner", DataPermissions.ReadOnly)]
		public bool IsLimitedTime
		{
			[Cpp2IlInjected.Token(Token = "0x600053E")]
			[Cpp2IlInjected.Address(RVA = "0x15A3900", Offset = "0x15A2500", VA = "0x1815A3900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0x87CEFD0", Offset = "0x87CDBD0", VA = "0x1887CEFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		[BindableData(6, "Text to show on the 'Limited Time' banner", DataPermissions.ReadOnly)]
		public string LimitedTimeText
		{
			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0xF48A30", Offset = "0xF47630", VA = "0x180F48A30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0x87CF150", Offset = "0x87CDD50", VA = "0x1887CF150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		[BindableData(7, "Whether or not the player owns this item", DataPermissions.ReadOnly)]
		public bool IsOwned
		{
			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0xE78B90", Offset = "0xE77790", VA = "0x180E78B90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x87CF090", Offset = "0x87CDC90", VA = "0x1887CF090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		[BindableData(8, "Whether or not to show the 'Rec Room Plus Exclusive' icon", DataPermissions.ReadOnly)]
		public bool IsRecRoomPlusExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x6000544")]
			[Cpp2IlInjected.Address(RVA = "0xCB1F50", Offset = "0xCB0B50", VA = "0x180CB1F50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000545")]
			[Cpp2IlInjected.Address(RVA = "0x87CF0F0", Offset = "0x87CDCF0", VA = "0x1887CF0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		[BindableData(9, "The ID used to retrieve the IStoreItem from RecNet", DataPermissions.ReadWrite)]
		public UnifiedItemId StoreItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0x87CDEF0", Offset = "0x87CCAF0", VA = "0x1887CDEF0")]
			get
			{
				return default(UnifiedItemId);
			}
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x87CF250", Offset = "0x87CDE50", VA = "0x1887CF250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		[BindableData(10, "The price of the item after any applicable discounts", DataPermissions.ReadWrite)]
		public long Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xBA7EA0", Offset = "0xBA6AA0", VA = "0x180BA7EA0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x87CDF40", Offset = "0x87CCB40", VA = "0x1887CDF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x87CEE20", Offset = "0x87CDA20", VA = "0x1887CEE20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x87CCEC0", Offset = "0x87CBAC0", VA = "0x1887CCEC0")]
		[BindableAction(100, null)]
		private void GoToDetailsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x87CC780", Offset = "0x87CB380", VA = "0x1887CC780", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x87CD990", Offset = "0x87CC590", VA = "0x1887CD990")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x87CC850", Offset = "0x87CB450", VA = "0x1887CC850")]
		[AsyncStateMachine(typeof(<FetchStoreItemData>d__54))]
		private void FetchStoreItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x87CDFB0", Offset = "0x87CCBB0", VA = "0x1887CDFB0")]
		private void UpdateStoreItemData(HSUCUPBTDYC storeItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x87CDC70", Offset = "0x87CC870", VA = "0x1887CDC70")]
		private void ResetStoreItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x87CDAF0", Offset = "0x87CC6F0", VA = "0x1887CDAF0")]
		private void RecordImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x87CD080", Offset = "0x87CBC80", VA = "0x1887CD080", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x87CC900", Offset = "0x87CB500", VA = "0x1887CC900")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x87CEA80", Offset = "0x87CD680", VA = "0x1887CEA80")]
		public StoreItemViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public enum CarouselType
	{
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		Room,
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		Event,
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		Club,
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		Invention,
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		StoreItem,
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		Account
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum HighlightStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		Scale150,
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		Portrait,
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		Scale75,
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		Scale100,
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		FitPerRow4,
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		FitPerRow5,
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		FitPerRow6
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CreateAssetMenu(fileName = "CarouselDisplayConfig", menuName = "RecRoom/UI/CarouselDisplayConfig")]
	public class CarouselDisplayConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public struct HighlightCardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public PlatformMask platformMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public float cardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public float cardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public HighlightStyle HighlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public bool VR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			[ReadOnlyField]
			[TooltipAttribute("Carousel height is driven by the card height. Multi-row room carousels will add one 'Card Height' height per row.")]
			public float carouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public int cardLimit;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public struct CardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			[ReadOnlyField]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public CarouselType CarouselType;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public float carouselTitleHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public float cardMetadataHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			[ReadOnlyField]
			[TooltipAttribute("Carousel height is driven by the card height. Multi-row room carousels will add one 'Default Card Height' height per row.")]
			public float defaultCarouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			public float defaultCardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			public float defaultCardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			public int defaultCardLimitWithScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public int defaultCardLimitWithNoScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public RectOffset singleRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public RectOffset multiRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			[FormerlySerializedAs("rowBottomPadding")]
			[TooltipAttribute("Keep this in sync with the 'item spacing' value in Virtualized Scroll Rect List")]
			public int rowPaddingBottom;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public struct DiscoveryVariantOverrides
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public string variantName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public int cardHeight;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		[SerializeField]
		public List<Uri> Uris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		[SerializeField]
		public bool allowCarouselHighlightingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		[SerializeField]
		public bool allowEnforcingOrderedRenderingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		[SerializeField]
		[TooltipAttribute("Multiplies the number of cards per row by this factor as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		private int dedupingMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		[FormerlySerializedAs("minItemsToFetchPerRow")]
		[SerializeField]
		[TooltipAttribute("Puts a lower bound on number of fetched items as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		private int minItemsToFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		[SerializeField]
		private CardDataObject[] defaultCardList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		[SerializeField]
		private HighlightCardDataObject[] highlightRoomListConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		[SerializeField]
		private DiscoveryVariantOverrides[] discoveryVariantOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		private IRRUIvNextBridge VNextBridge
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x87B6430", Offset = "0x87B5030", VA = "0x1887B6430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x87B62C0", Offset = "0x87B4EC0", VA = "0x1887B62C0")]
		public bool IsAnyConfiguredUriActive(BrowserModel browserModel)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x87B5A70", Offset = "0x87B4670", VA = "0x1887B5A70")]
		public float GetCardWidth(HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x87B5680", Offset = "0x87B4280", VA = "0x1887B5680")]
		public float GetCardHeight(HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x87B5BA0", Offset = "0x87B47A0", VA = "0x1887B5BA0")]
		public float GetCarouselHeight(HighlightStyle highlightStyle, CarouselType carouselType, int numRows = 1, bool addPadding = true)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x87B5DF0", Offset = "0x87B49F0", VA = "0x1887B5DF0")]
		public RectOffset GetCarouselPadding(CarouselType carouselType, int numRows)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x87B5930", Offset = "0x87B4530", VA = "0x1887B5930")]
		public int GetCardLimitPerRow(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x87B6290", Offset = "0x87B4E90", VA = "0x1887B6290")]
		public int GetTotalCardLimit(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType, int maxRows = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x87B61E0", Offset = "0x87B4DE0", VA = "0x1887B61E0")]
		public int GetMinItemsToFetch(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType, int maxRows = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x87B5EE0", Offset = "0x87B4AE0", VA = "0x1887B5EE0")]
		private HighlightCardDataObject GetFilteredDataObject(HighlightStyle highlightStyle)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x87B54A0", Offset = "0x87B40A0", VA = "0x1887B54A0")]
		private HighlightCardDataObject ApplyGameConfigOverrides(HighlightCardDataObject cardDataObject)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x87B6410", Offset = "0x87B5010", VA = "0x1887B6410")]
		public CarouselDisplayConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[ViewModel]
	public class CarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private const int defaultMinItemsToFetch = 20;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private const int defaultCardLimitPerRow = 5;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public const string HighlightStyleDefault = "highlight_default";

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public const string HighlightStyleScale150 = "highlight_scale_150";

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public const string HighlightStylePortrait = "highlight_portrait";

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public const string HighlightStyleScale75 = "highlight_scale_75";

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public const string HighlightStyleScale100 = "highlight_scale_100";

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public const string HighlightStyleFitPerRow4 = "highlight_fitperrow_4";

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public const string HighlightStyleFitPerRow5 = "highlight_fitperrow_5";

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public const string HighlightStyleFitPerRow6 = "highlight_fitperrow_6";

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		[SerializeField]
		private CarouselType carouselType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		[SerializeField]
		private CarouselDisplayConfig displayConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		[SerializeField]
		private DataResolver carouselListResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		[SerializeField]
		private PlatformMask hidePageButtonsOnThesePlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private bool allowHorizontalScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private int rowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private float? heightOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private float? widthOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private HighlightStyle highlightStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private Vector2 cardSizeOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private DiscoveryDisplayMetadata displayMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private string sourceLabelText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private int maxRowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private int maxResultCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private DataItem<bool> AllowHorizontalScrollDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private DataItem<int> RowCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private DataItem<float?> HeightOverrideDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private DataItem<float?> WidthOverrideDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private DataItem<string> BackgroundColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private DataItem<HighlightStyle> HighlightStyleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private DataItem<Vector2> CardSizeOverrideDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool AllowHorizontalScroll
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0xDD2770", Offset = "0xDD1370", VA = "0x180DD2770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x87B7CC0", Offset = "0x87B68C0", VA = "0x1887B7CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		[BindableData(1, "Number of rows in the carousel", DataPermissions.ReadWrite)]
		public int RowCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0xDDA760", Offset = "0xDD9360", VA = "0x180DDA760")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x87B7D20", Offset = "0x87B6920", VA = "0x1887B7D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		[BindableData(2, "The height override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? HeightOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x8608C90", Offset = "0x8607890", VA = "0x188608C90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x87B81F0", Offset = "0x87B6DF0", VA = "0x1887B81F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		[BindableData(3, "The width override value, or null if there isn't one. Typically used for card width.", DataPermissions.ReadWrite)]
		public float? WidthOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x87B7D90", Offset = "0x87B6990", VA = "0x1887B7D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x87B8280", Offset = "0x87B6E80", VA = "0x1887B8280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		[BindableData(4, "Background color of the carousel", DataPermissions.ReadWrite)]
		public string BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x87B80E0", Offset = "0x87B6CE0", VA = "0x1887B80E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		[BindableData(5, "Card Highlight Style", DataPermissions.ReadWrite)]
		public HighlightStyle HighlightStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0xB1F600", Offset = "0xB1E200", VA = "0x180B1F600")]
			get
			{
				return default(HighlightStyle);
			}
			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0x87B7C30", Offset = "0x87B6830", VA = "0x1887B7C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		[BindableData(6, "The card width and height override value, or null if there isn't one. Used when overriding width alone is insufficient.", DataPermissions.ReadWrite)]
		public Vector2 CardSizeOverride
		{
			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x87B7C90", Offset = "0x87B6890", VA = "0x1887B7C90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x87B8160", Offset = "0x87B6D60", VA = "0x1887B8160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		public int NumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0xBB6DA0", Offset = "0xBB59A0", VA = "0x180BB6DA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0xBB6A60", Offset = "0xBB5660", VA = "0x180BB6A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		public int MaxItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xBCC930", Offset = "0xBCB530", VA = "0x180BCC930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x87B80A0", Offset = "0x87B6CA0", VA = "0x1887B80A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x87B64B0", Offset = "0x87B50B0", VA = "0x1887B64B0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x87B7B80", Offset = "0x87B6780", VA = "0x1887B7B80", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x87B6730", Offset = "0x87B5330", VA = "0x1887B6730")]
		public void ConfigureCarousel(DiscoveryDisplayMetadata displayMetadata, string sourceLabelText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x87B6570", Offset = "0x87B5170", VA = "0x1887B6570")]
		private int CalculateNumItemsToFetch()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x87B7300", Offset = "0x87B5F00", VA = "0x1887B7300")]
		private HighlightStyle GetHighlightStyle()
		{
			return default(HighlightStyle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x87B7AF0", Offset = "0x87B66F0", VA = "0x1887B7AF0")]
		private void OnCarouselListUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x87B6930", Offset = "0x87B5530", VA = "0x1887B6930")]
		private void FinishCarouselInit(int totalNumCards)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x87B73F0", Offset = "0x87B5FF0", VA = "0x1887B73F0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x87B6F70", Offset = "0x87B5B70", VA = "0x1887B6F70")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x87B7DC0", Offset = "0x87B69C0", VA = "0x1887B7DC0")]
		public CarouselViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class DiscoveryDisplayMetadata : BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public string DisplayTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public bool supportsDedupe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int numRows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public string sizePerPlatform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public bool horizontalScrollEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public int itemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public string cardStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public int minItemsToShowSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public string textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public string sessionSectionIdOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public string descriptionText;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x87C1280", Offset = "0x87BFE80", VA = "0x1887C1280")]
		public DiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[ViewModel]
	public class ConsumableListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		[SerializeField]
		private IRRUIvNextConsumableBridge.ConsumableCategory listType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		[SerializeField]
		private Route shopRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private IRRUIvNextConsumableBridge consumableBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private DataList<Consumable> consumableList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private DataItemList ConsumableListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private DataItemAction OpenShopDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<Consumable> ConsumableList
		{
			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x87BCF10", Offset = "0x87BBB10", VA = "0x1887BCF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x87BCED0", Offset = "0x87BBAD0", VA = "0x1887BCED0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x87BC910", Offset = "0x87BB510", VA = "0x1887BC910")]
		[BindableAction(1, null)]
		public void OpenShop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x87BC230", Offset = "0x87BAE30", VA = "0x1887BC230", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x87BC800", Offset = "0x87BB400", VA = "0x1887BC800", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x87BC7F0", Offset = "0x87BB3F0", VA = "0x1887BC7F0")]
		private void OnActiveConsumableChanged(Consumable consumable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x87BC7F0", Offset = "0x87BB3F0", VA = "0x1887BC7F0")]
		private void OnPurchasedConsumableChanged(Consumable consumable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x87BCA90", Offset = "0x87BB690", VA = "0x1887BCA90")]
		private void RefreshConsumableList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x87BC600", Offset = "0x87BB200", VA = "0x1887BC600", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x87BC490", Offset = "0x87BB090", VA = "0x1887BC490")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x87BCDC0", Offset = "0x87BB9C0", VA = "0x1887BCDC0")]
		public ConsumableListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[ViewModel]
	public class ConsumableViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private IRRUIvNextConsumableBridge consumableBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private Consumable consumable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private IZQMLBCLOSL mainImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private bool isActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private DataItem<IZQMLBCLOSL> MainImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private DataItem<int> CountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private DataItem<bool> IsActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private DataItemAction UseConsumableDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x87BE2A0", Offset = "0x87BCEA0", VA = "0x1887BE2A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public IZQMLBCLOSL MainImage
		{
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x87BDDD0", Offset = "0x87BC9D0", VA = "0x1887BDDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0xFEF5C0", Offset = "0xFEE1C0", VA = "0x180FEF5C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x87BDE30", Offset = "0x87BCA30", VA = "0x1887BDE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xDD2770", Offset = "0xDD1370", VA = "0x180DD2770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x87BDE90", Offset = "0x87BCA90", VA = "0x1887BDE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x87BE260", Offset = "0x87BCE60", VA = "0x1887BE260", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x87BDEF0", Offset = "0x87BCAF0", VA = "0x1887BDEF0")]
		[BindableAction(0, null)]
		public void UseConsumable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x87BCF80", Offset = "0x87BBB80", VA = "0x1887BCF80", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x87BD830", Offset = "0x87BC430", VA = "0x1887BD830", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x87BD6E0", Offset = "0x87BC2E0", VA = "0x1887BD6E0")]
		private void OnActiveConsumableChanged(Consumable consumable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x87BDD00", Offset = "0x87BC900", VA = "0x1887BDD00", Slot = "14")]
		public override void SetBindingData(int sourceId, int itemId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x87BD8E0", Offset = "0x87BC4E0", VA = "0x1887BD8E0")]
		private void RefreshData(Consumable config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x87BD720", Offset = "0x87BC320", VA = "0x1887BD720")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x87BD310", Offset = "0x87BBF10", VA = "0x1887BD310", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x87BD0C0", Offset = "0x87BBCC0", VA = "0x1887BD0C0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x87BE110", Offset = "0x87BCD10", VA = "0x1887BE110")]
		public ConsumableViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public class GlobalDataViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private int localAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private long localRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private long localRoomEventId;

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int LocalAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0xB31CA0", Offset = "0xB308A0", VA = "0x180B31CA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x87C18D0", Offset = "0x87C04D0", VA = "0x1887C18D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public long LocalRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x87C1980", Offset = "0x87C0580", VA = "0x1887C1980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public long LocalRoomEventId
		{
			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x87C1920", Offset = "0x87C0520", VA = "0x1887C1920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x87C1750", Offset = "0x87C0350", VA = "0x1887C1750")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x87C1290", Offset = "0x87BFE90", VA = "0x1887C1290", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x87C13F0", Offset = "0x87BFFF0", VA = "0x1887C13F0")]
		private void OnLocalAccountUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x87C1550", Offset = "0x87C0150", VA = "0x1887C1550")]
		private void OnLocalRoomChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x87C18B0", Offset = "0x87C04B0", VA = "0x1887C18B0")]
		public GlobalDataViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class LongPressInteractable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		[SerializeField]
		protected float longPressDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AQWXMNIFQIV OnLongClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public AQWXMNIFQIV OnShortClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected float pressStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected bool pointerInside;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xF8CF50", Offset = "0xF8BB50", VA = "0x180F8CF50", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x1D00E30", Offset = "0x1CFFA30", VA = "0x181D00E30", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x87C19E0", Offset = "0x87C05E0", VA = "0x1887C19E0", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x87C1A00", Offset = "0x87C0600", VA = "0x1887C1A00", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x87C1A60", Offset = "0x87C0660", VA = "0x1887C1A60")]
		public LongPressInteractable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[ViewModel]
	public class CategoriesNestedItem : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private IMakerPenHUDBridge hudBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private int absoluteIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private CategoriesNestedListItem item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private bool isExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private Sprite activeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private int depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private DataItem<string> TextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private DataItem<bool> IsExpandedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private DataItem<Sprite> ActiveIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private DataItem<int> DepthDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private DataItemAction SelectItemDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		private CategoriesNestedListConfig config
		{
			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x87B94F0", Offset = "0x87B80F0", VA = "0x1887B94F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x87B9480", Offset = "0x87B8080", VA = "0x1887B9480", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0x87B95F0", Offset = "0x87B81F0", VA = "0x1887B95F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0D0", Offset = "0xB9CCD0", VA = "0x180B9E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x87B91A0", Offset = "0x87B7DA0", VA = "0x1887B91A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public Sprite ActiveIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x87B9540", Offset = "0x87B8140", VA = "0x1887B9540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Depth
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x105A8E0", Offset = "0x10594E0", VA = "0x18105A8E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x87B9210", Offset = "0x87B7E10", VA = "0x1887B9210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x87B9440", Offset = "0x87B8040", VA = "0x1887B9440", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x87B8310", Offset = "0x87B6F10", VA = "0x1887B8310", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x87B8E40", Offset = "0x87B7A40", VA = "0x1887B8E40", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x87B8E70", Offset = "0x87B7A70", VA = "0x1887B8E70")]
		[BindableAction(2, null)]
		public void SelectItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x87B8AD0", Offset = "0x87B76D0", VA = "0x1887B8AD0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x87B8620", Offset = "0x87B7220", VA = "0x1887B8620", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x87B8360", Offset = "0x87B6F60", VA = "0x1887B8360")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x87B9270", Offset = "0x87B7E70", VA = "0x1887B9270")]
		public CategoriesNestedItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[ViewModel]
	public class CategoriesNestedList : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private IMakerPenHUDBridge hudBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private DataList<int> activeIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private DataItemList ActiveIndicesDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		private CategoriesNestedListConfig config
		{
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x87BB5F0", Offset = "0x87BA1F0", VA = "0x1887BB5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> ActiveIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x87BB640", Offset = "0x87BA240", VA = "0x1887BB640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x87BB5C0", Offset = "0x87BA1C0", VA = "0x1887BB5C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x87BAC30", Offset = "0x87B9830", VA = "0x1887BAC30", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x87BB150", Offset = "0x87B9D50", VA = "0x1887BB150", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x87BB350", Offset = "0x87B9F50", VA = "0x1887BB350")]
		private void OnIndexStateChanged(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x87BB000", Offset = "0x87B9C00", VA = "0x1887BB000", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x87BAF00", Offset = "0x87B9B00", VA = "0x1887BAF00")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x87BB4F0", Offset = "0x87BA0F0", VA = "0x1887BB4F0")]
		public CategoriesNestedList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[ViewModel]
	public class ColorPickerCardViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private string colorName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public Enum shapeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private DataItem<int> IndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private DataItem<string> ColorNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private DataItem<Color> ColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private DataItemAction SelectDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		[BindableData(1, "Which slot in the hotbar this represents", DataPermissions.ReadOnly)]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x1338B30", Offset = "0x1337730", VA = "0x181338B30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x87BC180", Offset = "0x87BAD80", VA = "0x1887BC180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		[BindableData(2, "Color Name", DataPermissions.ReadOnly)]
		public string ColorName
		{
			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x87BC050", Offset = "0x87BAC50", VA = "0x1887BC050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		[BindableData(3, "Color", DataPermissions.ReadOnly)]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x310F2C0", Offset = "0x310DEC0", VA = "0x18310F2C0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x87BC0C0", Offset = "0x87BACC0", VA = "0x1887BC0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		[BindableData(5, "IsSelected", DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0xB44430", Offset = "0xB43030", VA = "0x180B44430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x87BC1D0", Offset = "0x87BADD0", VA = "0x1887BC1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x87BC010", Offset = "0x87BAC10", VA = "0x1887BC010", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x87BBE20", Offset = "0x87BAA20", VA = "0x1887BBE20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x87BBD20", Offset = "0x87BA920", VA = "0x1887BBD20", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x87BBD50", Offset = "0x87BA950", VA = "0x1887BBD50")]
		[BindableAction(4, "Selects Color")]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x87BB960", Offset = "0x87BA560", VA = "0x1887BB960", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x87BB6A0", Offset = "0x87BA2A0", VA = "0x1887BB6A0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x87BBE70", Offset = "0x87BAA70", VA = "0x1887BBE70")]
		public ColorPickerCardViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public class CategoriesNestedListItem : ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public string Text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public bool IsExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public Sprite ExpandedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public Sprite CollapsedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public CategoriesFilter Filter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		[Header("All children of the same parent should have both icons set, or none")]
		public List<CategoriesNestedListItem> Children;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x87BA890", Offset = "0x87B9490", VA = "0x1887BA890", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x87BAB90", Offset = "0x87B9790", VA = "0x1887BAB90")]
		public CategoriesNestedListItem()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public struct CategoriesFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CategoriesFilterType filterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		[TooltipAttribute("Metadata for filterType = PaletteSearchFilter")]
		public string paletteSearchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		[TooltipAttribute("Metadata for paletteSortOption = SortOption")]
		public SortOption paletteSortOption;
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public enum CategoriesFilterType
	{
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		PaletteSearchFilter,
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		Favorites,
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		RoomInventions
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CreateAssetMenu(fileName = "CategoriesNestedListConfig", menuName = "RRUI/MakerPenHUD/Nested List/Categories Nested List Config")]
	public class CategoriesNestedListConfig : ScriptableObject, BRMSVVEGLOX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		[SerializeField]
		private List<CategoriesNestedListItem> nestedListItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private List<CategoriesNestedListItem> clonedNestedListItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private List<int> activeIndices;

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public List<CategoriesNestedListItem> ListItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public HWNZTWGRXOC<int> OnIndexExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public HWNZTWGRXOC<int> OnIndexCollapsed
		{
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xB13160", Offset = "0xB11D60", VA = "0x180B13160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public HWNZTWGRXOC<int> OnIndexSelected
		{
			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0xB13190", Offset = "0xB11D90", VA = "0x180B13190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x87B9850", Offset = "0x87B8450", VA = "0x1887B9850", Slot = "6")]
		public List<int> GetActiveIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x87BA250", Offset = "0x87B8E50", VA = "0x1887BA250")]
		private void SetActiveIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x87B98A0", Offset = "0x87B84A0", VA = "0x1887B98A0", Slot = "7")]
		public int GetDepth(int idx)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x87B9BC0", Offset = "0x87B87C0", VA = "0x1887B9BC0", Slot = "8")]
		public bool IsChild(int parentIdx, int childIdx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x87B9C70", Offset = "0x87B8870", VA = "0x1887B9C70", Slot = "9")]
		public bool IsExpanded(int idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x87B9CD0", Offset = "0x87B88D0", VA = "0x1887B9CD0", Slot = "10")]
		public bool IsParent(int childIdx, int parentIdx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x87BA190", Offset = "0x87B8D90", VA = "0x1887BA190")]
		public void Select(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x87B9760", Offset = "0x87B8360", VA = "0x1887B9760")]
		public void Expand(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x87B9670", Offset = "0x87B8270", VA = "0x1887B9670")]
		public void Collapse(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x87B9DD0", Offset = "0x87B89D0", VA = "0x1887B9DD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x87B9990", Offset = "0x87B8590", VA = "0x1887B9990")]
		private bool IconsSetConsistently(List<CategoriesNestedListItem> items)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x87B9D80", Offset = "0x87B8980", VA = "0x1887B9D80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x87BA7A0", Offset = "0x87B93A0", VA = "0x1887BA7A0")]
		public CategoriesNestedListConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[ViewModel]
	public class CreateModeHotbarListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		[SerializeField]
		private InfiniteListViewControllerBase listViewController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private RCUQYCQBFFV manager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private DataList<LJWJYBNIOTO> hotbarEntries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private DataItemList HotbarEntriesDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<LJWJYBNIOTO> HotbarEntries
		{
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x87BF370", Offset = "0x87BDF70", VA = "0x1887BF370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x87BF330", Offset = "0x87BDF30", VA = "0x1887BF330", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x87BE310", Offset = "0x87BCF10", VA = "0x1887BE310", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x87BE800", Offset = "0x87BD400", VA = "0x1887BE800", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x87BEB70", Offset = "0x87BD770", VA = "0x1887BEB70")]
		private void OnHotbarSlotSelected(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x87BEA80", Offset = "0x87BD680", VA = "0x1887BEA80")]
		private void OnHotbarSelectionCleared()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x87BEDF0", Offset = "0x87BD9F0", VA = "0x1887BEDF0")]
		private void OnSlotsChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x87BED70", Offset = "0x87BD970", VA = "0x1887BED70")]
		private void OnPaletteToggled(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x87BEC70", Offset = "0x87BD870", VA = "0x1887BEC70")]
		private void OnObjectCreated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x87BE6B0", Offset = "0x87BD2B0", VA = "0x1887BE6B0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x87BE5B0", Offset = "0x87BD1B0", VA = "0x1887BE5B0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x87BF250", Offset = "0x87BDE50", VA = "0x1887BF250")]
		public CreateModeHotbarListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[ViewModel]
	public class CreateModeHotbarSlotViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private struct <RefreshIcon>d__43 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public LJWJYBNIOTO entry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public CreateModeHotbarSlotViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x87D1C20", Offset = "0x87D0820", VA = "0x1887D1C20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0x87D1EC0", Offset = "0x87D0AC0", VA = "0x1887D1EC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private RCUQYCQBFFV manager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private LJWJYBNIOTO hotbarEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private Texture image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private bool isImageSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x92")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private bool isPaletteOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x93")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private bool? isSelectedAndPaletteNotOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private DataItem<int> IndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private DataItem<Texture> ImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private DataItem<bool> IsImageSetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private DataItem<bool> IsPaletteOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private DataItem<bool> IsSelectedAndPaletteNotOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private DataItem<bool> CanSelectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private DataItemAction SelectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private DataItemAction ClickDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x87C0E20", Offset = "0x87BFA20", VA = "0x1887C0E20", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		[BindableData(1, "Which slot in the hotbar this represents", DataPermissions.ReadOnly)]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0xFEF5C0", Offset = "0xFEE1C0", VA = "0x180FEF5C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x87C1010", Offset = "0x87BFC10", VA = "0x1887C1010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		[BindableData(2, "The image that should be displayed for this hotbar item", DataPermissions.ReadOnly)]
		public Texture Image
		{
			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x87C0F30", Offset = "0x87BFB30", VA = "0x1887C0F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		[BindableData(3, "Whether or not this is selected", DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0xEF9A80", Offset = "0xEF8680", VA = "0x180EF9A80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x87C11A0", Offset = "0x87BFDA0", VA = "0x1887C11A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		[BindableData(5, "Whether or not the Image property is set", DataPermissions.ReadOnly)]
		public bool IsImageSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0xEF9A90", Offset = "0xEF8690", VA = "0x180EF9A90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x87C1070", Offset = "0x87BFC70", VA = "0x1887C1070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		[BindableData(6, "Whether or not the palette is open", DataPermissions.ReadOnly)]
		public bool IsPaletteOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x879DDC0", Offset = "0x879C9C0", VA = "0x18879DDC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0x87C0640", Offset = "0x87BF240", VA = "0x1887C0640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		[BindableData(7, "Whether or not this is selected", DataPermissions.ReadOnly)]
		public bool IsSelectedAndPaletteNotOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0x87C0A70", Offset = "0x87BF670", VA = "0x1887C0A70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0x87C10F0", Offset = "0x87BFCF0", VA = "0x1887C10F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		[BindableData(8, "Whether or not we can select this item", DataPermissions.ReadOnly)]
		public bool CanSelect
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C410", Offset = "0x1E2B010", VA = "0x181E2C410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0x87C0E90", Offset = "0x87BFA90", VA = "0x1887C0E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000666")]
			[Cpp2IlInjected.Address(RVA = "0x87C0DE0", Offset = "0x87BF9E0", VA = "0x1887C0DE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x87C07D0", Offset = "0x87BF3D0", VA = "0x1887C07D0")]
		[BindableAction(4, "Selects this hotbar item")]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x87BF5B0", Offset = "0x87BE1B0", VA = "0x1887BF5B0")]
		[BindableAction(10, "Invoked when the hotbar slot is clicked")]
		public void Click()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x87BF3E0", Offset = "0x87BDFE0", VA = "0x1887BF3E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x87C0450", Offset = "0x87BF050", VA = "0x1887C0450", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x87C0610", Offset = "0x87BF210", VA = "0x1887C0610")]
		private void OnHotbarSlotSelected(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x87C0600", Offset = "0x87BF200", VA = "0x1887C0600")]
		private void OnHotbarSelectionCleared()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x87C0640", Offset = "0x87BF240", VA = "0x1887C0640")]
		private void OnPaletteToggled(bool isOpen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x87C0850", Offset = "0x87BF450", VA = "0x1887C0850")]
		private void SetData(LJWJYBNIOTO entry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x87C06E0", Offset = "0x87BF2E0", VA = "0x1887C06E0")]
		[AsyncStateMachine(typeof(<RefreshIcon>d__43))]
		private Task RefreshIcon(LJWJYBNIOTO entry)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x87C02A0", Offset = "0x87BEEA0", VA = "0x1887C02A0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x87BFB60", Offset = "0x87BE760", VA = "0x1887BFB60", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x87BF680", Offset = "0x87BE280", VA = "0x1887BF680")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x87C0B20", Offset = "0x87BF720", VA = "0x1887C0B20")]
		public CreateModeHotbarSlotViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[ViewModel]
	public class MakerPenHUDConfigureViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TMJIXIOYVGV _configurable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private bool _hasConfigurable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private string _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private string _subtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		[SerializeField]
		private bool isAdvancedMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private bool _isAdvancedMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private DataList<ZAPQAZWXYYV> _dynamicUIElements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private bool _isDynamicUIElementsEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private ToastListModel _toastListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private DialogListModel _dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private IMakerPenHUDBridge _makerPenHUDBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private DataItem<TMJIXIOYVGV> ConfigurableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private DataItem<bool> HasConfigurableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private DataItem<string> TitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private DataItem<string> SubtitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private DataItem<bool> IsAdvancedModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private DataItem<bool> IsDynamicUIElementsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private DataItemList DynamicUIElementsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private DataItemAction ResetConfigurableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private DataItemAction CollapseAllFoldoutsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private DataItemAction ExpandAllFoldoutsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public TMJIXIOYVGV Configurable
		{
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0x87C4180", Offset = "0x87C2D80", VA = "0x1887C4180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		[BindableData(1, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool HasConfigurable
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0xF343C0", Offset = "0xF32FC0", VA = "0x180F343C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x87C3780", Offset = "0x87C2380", VA = "0x1887C3780")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		[BindableData(2, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x87C37E0", Offset = "0x87C23E0", VA = "0x1887C37E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		[BindableData(3, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Subtitle
		{
			[Cpp2IlInjected.Token(Token = "0x600067E")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0x87C42A0", Offset = "0x87C2EA0", VA = "0x1887C42A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool IsAdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0xB9E070", Offset = "0xB9CC70", VA = "0x180B9E070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x87C3860", Offset = "0x87C2460", VA = "0x1887C3860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		[BindableData(5, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public DataList<ZAPQAZWXYYV> DynamicUIElements
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x87C4230", Offset = "0x87C2E30", VA = "0x1887C4230")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		[BindableData(6, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsDynamicUIElementsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0xB44430", Offset = "0xB43030", VA = "0x180B44430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x87C3650", Offset = "0x87C2250", VA = "0x1887C3650")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x87C4140", Offset = "0x87C2D40", VA = "0x1887C4140", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000697")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x87C3400", Offset = "0x87C2000", VA = "0x1887C3400")]
		private void Register(TMJIXIOYVGV configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x87C38D0", Offset = "0x87C24D0", VA = "0x1887C38D0")]
		private void Unregister(TMJIXIOYVGV configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x87C1B10", Offset = "0x87C0710", VA = "0x1887C1B10", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x87C2FE0", Offset = "0x87C1BE0", VA = "0x1887C2FE0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x87C3180", Offset = "0x87C1D80", VA = "0x1887C3180")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x87C3130", Offset = "0x87C1D30", VA = "0x1887C3130")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x87C3250", Offset = "0x87C1E50", VA = "0x1887C3250")]
		private void OnMakerPenConfigMenuDataChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x87C32E0", Offset = "0x87C1EE0", VA = "0x1887C32E0")]
		private void OnRRUIPageContainerEnabledChanged(bool isEnabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x87C32B0", Offset = "0x87C1EB0", VA = "0x1887C32B0")]
		private void OnObjectSettingsToast(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x87C32F0", Offset = "0x87C1EF0", VA = "0x1887C32F0")]
		private void OnShowDialog(DialogType dialogType, PVIOTSLZPKY dialogData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x87C3140", Offset = "0x87C1D40", VA = "0x1887C3140")]
		private void OnDismissAllDialogs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x87C3170", Offset = "0x87C1D70", VA = "0x1887C3170")]
		private void OnDynamicUIElementsChanged(TMJIXIOYVGV configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x87C31E0", Offset = "0x87C1DE0", VA = "0x1887C31E0")]
		private void OnForceRefreshConfigUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x87C3AE0", Offset = "0x87C26E0", VA = "0x1887C3AE0")]
		private void UpdateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x87C1D50", Offset = "0x87C0950", VA = "0x1887C1D50")]
		private void ClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x87C3600", Offset = "0x87C2200", VA = "0x1887C3600")]
		[BindableAction(100, null)]
		public void ResetConfigurable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x87C1E90", Offset = "0x87C0A90", VA = "0x1887C1E90")]
		[BindableAction(101, null)]
		public void CollapseAllFoldouts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x87C20B0", Offset = "0x87C0CB0", VA = "0x1887C20B0")]
		[BindableAction(102, null)]
		public void ExpandAllFoldouts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x87C27B0", Offset = "0x87C13B0", VA = "0x1887C27B0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x87C22D0", Offset = "0x87C0ED0", VA = "0x1887C22D0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x87C3E50", Offset = "0x87C2A50", VA = "0x1887C3E50")]
		public MakerPenHUDConfigureViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[ViewModel]
	public class MakerPenHUDCreateToolbarViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[SerializeField]
		private FocusableUI toolbarFocusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private bool leftModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private bool rightModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private bool rightModifierHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private IRRUIvNextBridge rruiBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private RCUQYCQBFFV manager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private bool hasFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private float holdInputProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private bool showHoldIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private bool paletteButtonSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private bool paletteButtonSelectedAndPaletteClosed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private bool paletteIsOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private string toolDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private DataItem<bool> HasFocusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private DataItem<float> HoldInputProgressDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private DataItem<bool> ShowHoldIndicatorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private DataItem<bool> PaletteButtonSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private DataItem<bool> PaletteButtonSelectedOrPaletteOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private DataItem<bool> PaletteIsOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private DataItem<bool> CreateModeRecolorIsAvailableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private DataItem<string> ToolDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private DataItemAction GoToPaletteModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private DataItemAction ClickPaletteButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private DataItemAction ClickRecolorButtonDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		private bool shouldFocus
		{
			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0x87C69D0", Offset = "0x87C55D0", VA = "0x1887C69D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		[BindableData(200, null, DataPermissions.ReadWrite)]
		public bool HasFocus
		{
			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0xEF9A80", Offset = "0xEF8680", VA = "0x180EF9A80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x87C6310", Offset = "0x87C4F10", VA = "0x1887C6310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		[BindableData(201, null, DataPermissions.ReadWrite)]
		public float HoldInputProgress
		{
			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0x1732AC0", Offset = "0x17316C0", VA = "0x181732AC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0x87C6370", Offset = "0x87C4F70", VA = "0x1887C6370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		[BindableData(202, null, DataPermissions.ReadWrite)]
		public bool ShowHoldIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xB44430", Offset = "0xB43030", VA = "0x180B44430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x87C63E0", Offset = "0x87C4FE0", VA = "0x1887C63E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		[BindableData(203, null, DataPermissions.ReadWrite)]
		public bool PaletteButtonSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0x25244F0", Offset = "0x25230F0", VA = "0x1825244F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0x87C6440", Offset = "0x87C5040", VA = "0x1887C6440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		[BindableData(204, null, DataPermissions.ReadWrite)]
		public bool PaletteButtonSelectedOrPaletteOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x19358F0", Offset = "0x19344F0", VA = "0x1819358F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x87C64F0", Offset = "0x87C50F0", VA = "0x1887C64F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		[BindableData(3, "True if the palette is currently open", DataPermissions.ReadOnly)]
		public bool PaletteIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0x1935900", Offset = "0x1934500", VA = "0x181935900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x87C6A80", Offset = "0x87C5680", VA = "0x1887C6A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		[BindableData(4, "Recolor in create mode is not yet supported", DataPermissions.ReadOnly)]
		public bool CreateModeRecolorIsAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		[BindableData(5, "ToolDescription", DataPermissions.ReadOnly)]
		public string ToolDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x87C6B30", Offset = "0x87C5730", VA = "0x1887C6B30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0x87C6990", Offset = "0x87C5590", VA = "0x1887C6990", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x87C4FA0", Offset = "0x87C3BA0", VA = "0x1887C4FA0")]
		[BindableAction(6, null)]
		public void GoToPaletteMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x87C5D10", Offset = "0x87C4910", VA = "0x1887C5D10")]
		private void OnLeftNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x87C5FA0", Offset = "0x87C4BA0", VA = "0x1887C5FA0")]
		private void OnRightNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x87C65B0", Offset = "0x87C51B0", VA = "0x1887C65B0")]
		private void UpdateInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x87C4320", Offset = "0x87C2F20", VA = "0x1887C4320", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x87C58E0", Offset = "0x87C44E0", VA = "0x1887C58E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x87C49C0", Offset = "0x87C35C0", VA = "0x1887C49C0")]
		[BindableAction(1, "Invoked when the palette button is clicked")]
		public void ClickPaletteButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x87C5F30", Offset = "0x87C4B30", VA = "0x1887C5F30")]
		private void OnPaletteToggled(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x87C5880", Offset = "0x87C4480", VA = "0x1887C5880")]
		private void OnCursorActiveChanged(bool active)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[BindableAction(2, "Invoked when the recolor button is clicked")]
		public void ClickRecolorButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x87C6270", Offset = "0x87C4E70", VA = "0x1887C6270")]
		private void OnStampModeChanged(bool mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x87C6550", Offset = "0x87C5150", VA = "0x1887C6550")]
		private void UpdateCreateModeContextualBarData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x87C5020", Offset = "0x87C3C20", VA = "0x1887C5020", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x87C4A50", Offset = "0x87C3650", VA = "0x1887C4A50")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x87C66D0", Offset = "0x87C52D0", VA = "0x1887C66D0")]
		public MakerPenHUDCreateToolbarViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[ViewModel]
	public class MakerPenHUDPaletteListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		private enum PaletteCategory
		{
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			Favorites,
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			AllObjects,
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			RoomInventions
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		[SerializeField]
		private InfiniteListViewControllerBase listController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private PaletteCategory currentCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private DataList<WSNIPFNOPNH> placableObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private DataItemList PlacableObjectsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		private EYBFYFADWWY paletteDataStore
		{
			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0x87C8190", Offset = "0x87C6D90", VA = "0x1887C8190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<WSNIPFNOPNH> PlacableObjects
		{
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0x87C81E0", Offset = "0x87C6DE0", VA = "0x1887C81E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x87C8150", Offset = "0x87C6D50", VA = "0x1887C8150", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x87C6B90", Offset = "0x87C5790", VA = "0x1887C6B90", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x87C7170", Offset = "0x87C5D70", VA = "0x1887C7170", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x87C7570", Offset = "0x87C6170", VA = "0x1887C7570")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x87C7520", Offset = "0x87C6120", VA = "0x1887C7520")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x87C7A10", Offset = "0x87C6610", VA = "0x1887C7A10")]
		private void RefreshList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x87C76B0", Offset = "0x87C62B0", VA = "0x1887C76B0")]
		private void OnObjectsCategoryRequested(string paletteSearchFilter, SortOption paletteSortOption)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x87C7620", Offset = "0x87C6220", VA = "0x1887C7620")]
		private void OnFavoritesCategoryRequested()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x87C78F0", Offset = "0x87C64F0", VA = "0x1887C78F0")]
		private void OnRoomInventionsCategoryRequested()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x87C78E0", Offset = "0x87C64E0", VA = "0x1887C78E0")]
		private void OnPaletteToggled(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x87C7E40", Offset = "0x87C6A40", VA = "0x1887C7E40")]
		private void SelectFirstGridItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x87C7760", Offset = "0x87C6360", VA = "0x1887C7760")]
		private void OnPaletteSearchToggledToOpen(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x87C7980", Offset = "0x87C6580", VA = "0x1887C7980")]
		private void OnSearchStringChanged(string newSearchString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x87C7020", Offset = "0x87C5C20", VA = "0x1887C7020", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x87C6F20", Offset = "0x87C5B20", VA = "0x1887C6F20")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x87C8070", Offset = "0x87C6C70", VA = "0x1887C8070")]
		public MakerPenHUDPaletteListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[ViewModel]
	public class MakerPenHUDPaletteObjectViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		[CompilerGenerated]
		private struct <RefreshIcon>d__55 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			public WSNIPFNOPNH placableObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004BC")]
			public MakerPenHUDPaletteObjectViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x87ECC00", Offset = "0x87EB800", VA = "0x1887ECC00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x87ECE10", Offset = "0x87EBA10", VA = "0x1887ECE10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[CompilerGenerated]
		private struct <RefreshName>d__56 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public WSNIPFNOPNH placableObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public MakerPenHUDPaletteObjectViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x87ECE70", Offset = "0x87EBA70", VA = "0x1887ECE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x87ED060", Offset = "0x87EBC60", VA = "0x1887ED060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private WSNIPFNOPNH placable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		[FormerlySerializedAs("Index")]
		public int ObjectIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private bool favorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7D")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private bool canBeFavorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7E")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private bool favoriteShortcutAvailable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private Texture iconTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private bool isIconTextureSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private string objectName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private bool selected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private bool showActionButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private string actionButtonText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private bool canShowInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private DataItem<bool> FavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private DataItem<bool> CanBeFavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private DataItem<bool> FavoriteShortcutEnabledDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private DataItem<Texture> IconTextureDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private DataItem<bool> IsIconTextureSetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private DataItem<string> ObjectNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private DataItem<bool> SelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private DataItem<bool> ShowActionButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private DataItem<string> ActionButtonTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private DataItem<bool> CanShowInfoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private DataItemAction ClickObjectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private DataItemAction ClickFavoriteDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private DataItemAction ClickActionButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private DataItemAction ClickInfoButtonDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0x87CA610", Offset = "0x87C9210", VA = "0x1887CA610", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		[BindableData(1, "Whether or not the user has favorited this object", DataPermissions.ReadOnly)]
		public bool Favorited
		{
			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0xFD3720", Offset = "0xFD2320", VA = "0x180FD3720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x87CA7C0", Offset = "0x87C93C0", VA = "0x1887CA7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		[BindableData(8, "Whether or not the user can set this object as a favorite", DataPermissions.ReadOnly)]
		public bool CanBeFavorited
		{
			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x867CF70", Offset = "0x867BB70", VA = "0x18867CF70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x87CA700", Offset = "0x87C9300", VA = "0x1887CA700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool FavoriteShortcutEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x87CA1A0", Offset = "0x87C8DA0", VA = "0x1887CA1A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x87CA1B0", Offset = "0x87C8DB0", VA = "0x1887CA1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		[BindableData(2, "The image to use for the icon for the object", DataPermissions.ReadOnly)]
		public Texture IconTexture
		{
			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0x87CA820", Offset = "0x87C9420", VA = "0x1887CA820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		[BindableData(7, "True if the icon texture is set", DataPermissions.ReadOnly)]
		public bool IsIconTextureSet
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0D0", Offset = "0xB9CCD0", VA = "0x180B9E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x87CAA00", Offset = "0x87C9600", VA = "0x1887CAA00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0x87CA970", Offset = "0x87C9570", VA = "0x1887CA970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		[BindableData(5, "The name of the object to display", DataPermissions.ReadOnly)]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x87CAA60", Offset = "0x87C9660", VA = "0x1887CAA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		[BindableData(6, "Whether or not the object is selected by the user", DataPermissions.ReadOnly)]
		public bool Selected
		{
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D60", Offset = "0xBB2960", VA = "0x180BB3D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x87CAAE0", Offset = "0x87C96E0", VA = "0x1887CAAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		[BindableData(9, "Whether or not to show the action button", DataPermissions.ReadOnly)]
		public bool ShowActionButton
		{
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0620", Offset = "0x1FAF220", VA = "0x181FB0620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006FF")]
			[Cpp2IlInjected.Address(RVA = "0x87CAB40", Offset = "0x87C9740", VA = "0x1887CAB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		[BindableData(10, "Text to populate the action button", DataPermissions.ReadOnly)]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000700")]
			[Cpp2IlInjected.Address(RVA = "0xB1B710", Offset = "0xB1A310", VA = "0x180B1B710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000701")]
			[Cpp2IlInjected.Address(RVA = "0x87CA680", Offset = "0x87C9280", VA = "0x1887CA680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		[BindableData(14, "Whether or not the user can the info button", DataPermissions.ReadOnly)]
		public bool CanShowInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0x15A3900", Offset = "0x15A2500", VA = "0x1815A3900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x87CA760", Offset = "0x87C9360", VA = "0x1887CA760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x87CA5D0", Offset = "0x87C91D0", VA = "0x1887CA5D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x87C83C0", Offset = "0x87C6FC0", VA = "0x1887C83C0")]
		[BindableAction(3, "Call when the object is clicked")]
		public void ClickObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x87C8300", Offset = "0x87C6F00", VA = "0x1887C8300")]
		[BindableAction(4, "Call when the favorite button is clicked")]
		public void ClickFavorite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x87C82A0", Offset = "0x87C6EA0", VA = "0x1887C82A0")]
		[BindableAction(11, "Called when the action button is clicked")]
		public void ClickActionButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x87C8360", Offset = "0x87C6F60", VA = "0x1887C8360")]
		[BindableAction(15, "Called when the info button is clicked")]
		public void ClickInfoButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x87C9730", Offset = "0x87C8330", VA = "0x1887C9730")]
		private void OnPaletteEntryUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x87C9C30", Offset = "0x87C8830", VA = "0x1887C9C30")]
		private void SetData(WSNIPFNOPNH placableObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x87C9A50", Offset = "0x87C8650", VA = "0x1887C9A50")]
		[AsyncStateMachine(typeof(<RefreshIcon>d__55))]
		private Task RefreshIcon(WSNIPFNOPNH placableObject)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x87C9B40", Offset = "0x87C8740", VA = "0x1887C9B40")]
		[AsyncStateMachine(typeof(<RefreshName>d__56))]
		private Task RefreshName(WSNIPFNOPNH placableObject)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x87C95B0", Offset = "0x87C81B0", VA = "0x1887C95B0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x87C8250", Offset = "0x87C6E50", VA = "0x1887C8250", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x87C96E0", Offset = "0x87C82E0", VA = "0x1887C96E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x87C8B20", Offset = "0x87C7720", VA = "0x1887C8B20", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x87C8420", Offset = "0x87C7020", VA = "0x1887C8420")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x87CA220", Offset = "0x87C8E20", VA = "0x1887CA220")]
		public MakerPenHUDPaletteObjectViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[ViewModel]
	public class MakerPenHUDPaletteSearchViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private DataItem<string> PaletteSearchStringDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		[BindableData(1, "The current search string fed to the palette population logic", DataPermissions.ReadWrite)]
		public string PaletteSearchString
		{
			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x87D2670", Offset = "0x87D1270", VA = "0x1887D2670")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x87D26C0", Offset = "0x87D12C0", VA = "0x1887D26C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x87D2800", Offset = "0x87D1400", VA = "0x1887D2800", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x87D23F0", Offset = "0x87D0FF0", VA = "0x1887D23F0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x87BBD20", Offset = "0x87BA920", VA = "0x1887BBD20", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x87D2530", Offset = "0x87D1130", VA = "0x1887D2530", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x87D2440", Offset = "0x87D1040", VA = "0x1887D2440")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x87D2780", Offset = "0x87D1380", VA = "0x1887D2780")]
		public MakerPenHUDPaletteSearchViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[ViewModel]
	public class MakerPenHUDPaletteViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private DataItem<bool> IsPaletteSearchOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private DataItemAction TogglePaletteSearchDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		[BindableData(2, "Is the palette search currently opened or closed", DataPermissions.ReadOnly)]
		public bool IsPaletteSearchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x87D2C00", Offset = "0x87D1800", VA = "0x1887D2C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x87D2D10", Offset = "0x87D1910", VA = "0x1887D2D10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x87D2830", Offset = "0x87D1430", VA = "0x1887D2830", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x87BBD20", Offset = "0x87BA920", VA = "0x1887BBD20", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x87D2B90", Offset = "0x87D1790", VA = "0x1887D2B90")]
		[BindableAction(1, "Toggle Search bar open/closed")]
		public void TogglePaletteSearch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x87D29E0", Offset = "0x87D15E0", VA = "0x1887D29E0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x87D2880", Offset = "0x87D1480", VA = "0x1887D2880")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x87D2C50", Offset = "0x87D1850", VA = "0x1887D2C50")]
		public MakerPenHUDPaletteViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[ViewModel]
	public class MakerPenHUDSelectToolbarViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		[CompilerGenerated]
		private sealed class <UnfocusedNavWaitDelay>d__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			public MakerPenHUDSelectToolbarViewModel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170001ED")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007CC")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001EE")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007CE")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <UnfocusedNavWaitDelay>d__32(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CA")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0x87ED0C0", Offset = "0x87EBCC0", VA = "0x1887ED0C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0x87ED1A0", Offset = "0x87EBDA0", VA = "0x1887ED1A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		[SerializeField]
		private FocusableUI focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		[SerializeField]
		private float unfocusedNavigationSelectDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		[SerializeField]
		private DialogListModel dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private IRRUIvNextBridge rruiBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private bool leftModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private bool rightModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x92")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private bool rightModifierHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private float lastUnfocusedNavEventTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private Coroutine unfocusedNavWaitCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private bool hasFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private float holdInputProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private bool showHoldIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private bool isDeleteAllow;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAA")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private bool onCloneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAB")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private bool toggledMoveWhileFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private bool inTransformModeAndMoveOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private bool toggledRotateWhileFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAE")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private bool inTransformModeAndRotateOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAF")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private bool toggledScaleWhileFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private bool inTransformModeAndScaleOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private bool toggledRecolorWhileFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB2")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private bool isRecolorModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB3")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private bool isPrecisionModifierModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private bool showEditColorPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB5")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private bool isEditColorPanelHiddenWhenRecolorModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB6")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private bool onConfigMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB7")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private bool isRRUIPageContainerEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private string toolDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private bool isAdjustModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private bool showAdjustButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC2")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private bool adjustFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC3")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private bool cloneFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private bool recolorFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private bool configFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private bool exitRecolorFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC7")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private bool deleteFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private bool moveModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private bool rotateModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private bool scaleModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCB")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private bool recolorModeAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private bool configModeAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private DataItem<bool> HasFocusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private DataItem<float> HoldInputProgressDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private DataItem<bool> ShowHoldIndicatorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private DataItem<bool> IsDeleteAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private DataItem<bool> OnCloneModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private DataItem<bool> InTransfromModeAndMoveOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private DataItem<bool> InTransformModeAndRotateOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private DataItem<bool> InTransformModeAndScaleOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private DataItem<bool> IsRecolorModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private DataItem<bool> IsPrecisionModifierModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private DataItem<bool> ShowEditColorPanelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private DataItem<bool> IsEditColorPanelHiddenWhenRecolorModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private DataItem<bool> OnConfigModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private DataItem<bool> IsRRUIPageContainerEnabledDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private DataItem<string> ToolDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private DataItem<bool> IsAdjustModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private DataItem<bool> ShowAdjustButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private DataItem<bool> AdjustFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private DataItem<bool> CloneFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private DataItem<bool> RecolorFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private DataItem<bool> ConfigFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private DataItem<bool> ExitRecolorFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private DataItem<bool> DeleteFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private DataItem<bool> MoveModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private DataItem<bool> RotateModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private DataItem<bool> ScaleModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private DataItem<bool> RecolorModeAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private DataItem<bool> ConfigModeAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private DataItemAction ToggleCloneModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private DataItemAction ToggleMoveModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private DataItemAction ToggleRotateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private DataItemAction ToggleScaleModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private DataItemAction DeleteSelectionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private DataItemAction ToggleRecolorModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private DataItemAction ExitRecolorModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private DataItemAction ToggleConfigModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private DataItemAction HideRRUIPageContainerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private DataItemAction ShowRRUIPageContainerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private DataItemAction RequestAdjustModeDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		private bool shouldFocus
		{
			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x87D9B90", Offset = "0x87D8790", VA = "0x1887D9B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		[BindableData(200, null, DataPermissions.ReadWrite)]
		public bool HasFocus
		{
			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D60", Offset = "0xBB2960", VA = "0x180BB3D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x87D80B0", Offset = "0x87D6CB0", VA = "0x1887D80B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		[BindableData(201, null, DataPermissions.ReadWrite)]
		public float HoldInputProgress
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x179C790", Offset = "0x179B390", VA = "0x18179C790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x87D8370", Offset = "0x87D6F70", VA = "0x1887D8370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		[BindableData(202, null, DataPermissions.ReadWrite)]
		public bool ShowHoldIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0xBD43A0", Offset = "0xBD2FA0", VA = "0x180BD43A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x87D86F0", Offset = "0x87D72F0", VA = "0x1887D86F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		[BindableData(6, "Is Delete Allowed", DataPermissions.ReadWrite)]
		public bool IsDeleteAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0xBD4110", Offset = "0xBD2D10", VA = "0x180BD4110")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x87D8750", Offset = "0x87D7350", VA = "0x1887D8750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		[BindableData(7, "OnCloneMode", DataPermissions.ReadWrite)]
		public bool OnCloneMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000755")]
			[Cpp2IlInjected.Address(RVA = "0x2D53CD0", Offset = "0x2D528D0", VA = "0x182D53CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0x87D87B0", Offset = "0x87D73B0", VA = "0x1887D87B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		[BindableData(8, "In Transfrom Mode And Move On", DataPermissions.ReadWrite)]
		public bool InTransfromModeAndMoveOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0xB1F5E0", Offset = "0xB1E1E0", VA = "0x180B1F5E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x87D7EF0", Offset = "0x87D6AF0", VA = "0x1887D7EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		[BindableData(9, "In Transform Mode And Rotate On", DataPermissions.ReadWrite)]
		public bool InTransformModeAndRotateOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x1034610", Offset = "0x1033210", VA = "0x181034610")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x87D7F60", Offset = "0x87D6B60", VA = "0x1887D7F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		[BindableData(10, "In Transform Mode And Scale On", DataPermissions.ReadWrite)]
		public bool InTransformModeAndScaleOn
		{
			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x15A3900", Offset = "0x15A2500", VA = "0x1815A3900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x87D7FD0", Offset = "0x87D6BD0", VA = "0x1887D7FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		[BindableData(11, "Is Recolor Tool Currently Active", DataPermissions.ReadWrite)]
		public bool IsRecolorModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x228AD10", Offset = "0x2289910", VA = "0x18228AD10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0x87D9DF0", Offset = "0x87D89F0", VA = "0x1887D9DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		[BindableData(12, "Is Transform Tool Active", DataPermissions.ReadWrite)]
		public bool IsPrecisionModifierModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x56975B0", Offset = "0x56961B0", VA = "0x1856975B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0x87D8050", Offset = "0x87D6C50", VA = "0x1887D8050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		[BindableData(14, "Show Edit Color Panel", DataPermissions.ReadOnly)]
		public bool ShowEditColorPanel
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0xE55420", Offset = "0xE54020", VA = "0x180E55420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x87D9F20", Offset = "0x87D8B20", VA = "0x1887D9F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		[BindableData(16, "Is Edit Color Panel Hidden When Recolor Mode is Active", DataPermissions.ReadWrite)]
		public bool IsEditColorPanelHiddenWhenRecolorModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x7EAB7C0", Offset = "0x7EAA3C0", VA = "0x187EAB7C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(RVA = "0x87D8110", Offset = "0x87D6D10", VA = "0x1887D8110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		[BindableData(18, "OnConfigMode", DataPermissions.ReadWrite)]
		public bool OnConfigMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(RVA = "0x87D8170", Offset = "0x87D6D70", VA = "0x1887D8170")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(RVA = "0x87D8180", Offset = "0x87D6D80", VA = "0x1887D8180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		[BindableData(19, "IsRRUIPageContainerEnabled", DataPermissions.ReadWrite)]
		public bool IsRRUIPageContainerEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x7EAB7D0", Offset = "0x7EAA3D0", VA = "0x187EAB7D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x87D81E0", Offset = "0x87D6DE0", VA = "0x1887D81E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		[BindableData(23, "ToolDescription", DataPermissions.ReadOnly)]
		public string ToolDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0xF48A30", Offset = "0xF47630", VA = "0x180F48A30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x87D9F80", Offset = "0x87D8B80", VA = "0x1887D9F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		[BindableData(24, "Is Adjust Mode Active", DataPermissions.ReadWrite)]
		public bool IsAdjustModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0xE78B90", Offset = "0xE77790", VA = "0x180E78B90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x87D8240", Offset = "0x87D6E40", VA = "0x1887D8240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		[BindableData(25, "Show the Adjust button", DataPermissions.ReadWrite)]
		public bool ShowAdjustButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0xCB1F50", Offset = "0xCB0B50", VA = "0x180CB1F50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x87D82A0", Offset = "0x87D6EA0", VA = "0x1887D82A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		[BindableData(26, null, DataPermissions.ReadWrite)]
		public bool AdjustFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x87D8300", Offset = "0x87D6F00", VA = "0x1887D8300")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x87D9C70", Offset = "0x87D8870", VA = "0x1887D9C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		[BindableData(27, null, DataPermissions.ReadWrite)]
		public bool CloneFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x87D8320", Offset = "0x87D6F20", VA = "0x1887D8320")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x87D9CF0", Offset = "0x87D88F0", VA = "0x1887D9CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		[BindableData(28, null, DataPermissions.ReadWrite)]
		public bool RecolorFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x7D386F0", Offset = "0x7D372F0", VA = "0x187D386F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x87D9EA0", Offset = "0x87D8AA0", VA = "0x1887D9EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		[BindableData(29, null, DataPermissions.ReadWrite)]
		public bool ConfigFocused
		{
			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x87D8350", Offset = "0x87D6F50", VA = "0x1887D8350")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x87D9D70", Offset = "0x87D8970", VA = "0x1887D9D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		[BindableData(30, null, DataPermissions.ReadWrite)]
		public bool ExitRecolorFocused
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x87D83E0", Offset = "0x87D6FE0", VA = "0x1887D83E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x87D83F0", Offset = "0x87D6FF0", VA = "0x1887D83F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		[BindableData(31, null, DataPermissions.ReadWrite)]
		public bool DeleteFocused
		{
			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x87D8470", Offset = "0x87D7070", VA = "0x1887D8470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x87D8480", Offset = "0x87D7080", VA = "0x1887D8480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		[BindableData(32, null, DataPermissions.ReadWrite)]
		public bool MoveModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x1620060", Offset = "0x161EC60", VA = "0x181620060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x87D8500", Offset = "0x87D7100", VA = "0x1887D8500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		[BindableData(33, null, DataPermissions.ReadWrite)]
		public bool RotateModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x2533C80", Offset = "0x2532880", VA = "0x182533C80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x87D8560", Offset = "0x87D7160", VA = "0x1887D8560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		[BindableData(34, null, DataPermissions.ReadWrite)]
		public bool ScaleModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x2534010", Offset = "0x2532C10", VA = "0x182534010")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x87D85C0", Offset = "0x87D71C0", VA = "0x1887D85C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		[BindableData(35, null, DataPermissions.ReadWrite)]
		public bool RecolorModeAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x2533BD0", Offset = "0x25327D0", VA = "0x182533BD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x87D8620", Offset = "0x87D7220", VA = "0x1887D8620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		[BindableData(36, null, DataPermissions.ReadWrite)]
		public bool ConfigModeAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x87D8680", Offset = "0x87D7280", VA = "0x1887D8680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x87D8690", Offset = "0x87D7290", VA = "0x1887D8690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x87D9B50", Offset = "0x87D8750", VA = "0x1887D9B50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x87D7140", Offset = "0x87D5D40", VA = "0x1887D7140")]
		private void OnLeftNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x87D7390", Offset = "0x87D5F90", VA = "0x1887D7390")]
		private void OnRightNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x87D8A50", Offset = "0x87D7650", VA = "0x1887D8A50")]
		private void UpdateInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x87D37E0", Offset = "0x87D23E0", VA = "0x1887D37E0")]
		private void CheckForFocusGained()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x87D3950", Offset = "0x87D2550", VA = "0x1887D3950")]
		private void CheckForFocusLost()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x87D6A60", Offset = "0x87D5660", VA = "0x1887D6A60")]
		private void OnCursorActiveChanged(bool active)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x87D33D0", Offset = "0x87D1FD0", VA = "0x1887D33D0")]
		private void ChangeModeToMatchButtonFocusState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x87D7360", Offset = "0x87D5F60", VA = "0x1887D7360")]
		private void OnNavFocusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x87D8810", Offset = "0x87D7410", VA = "0x1887D8810")]
		[IteratorStateMachine(typeof(<UnfocusedNavWaitDelay>d__32))]
		private IEnumerator UnfocusedNavWaitDelay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x87D2D40", Offset = "0x87D1940", VA = "0x1887D2D40", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x87D70F0", Offset = "0x87D5CF0", VA = "0x1887D70F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x87D6AF0", Offset = "0x87D56F0", VA = "0x1887D6AF0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x87D79D0", Offset = "0x87D65D0", VA = "0x1887D79D0")]
		[BindableAction(1, "Press Clone button")]
		public void ToggleCloneMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x87D7AD0", Offset = "0x87D66D0", VA = "0x1887D7AD0")]
		[BindableAction(2, "Press Move button")]
		public void ToggleMoveMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x87D7C70", Offset = "0x87D6870", VA = "0x1887D7C70")]
		[BindableAction(3, "Press Rotate button")]
		public void ToggleRotateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x87D7DB0", Offset = "0x87D69B0", VA = "0x1887D7DB0")]
		[BindableAction(4, "Press Scale button")]
		public void ToggleScaleMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x87D3AC0", Offset = "0x87D26C0", VA = "0x1887D3AC0")]
		[BindableAction(5, "Press Delete button")]
		public void DeleteSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x87D88A0", Offset = "0x87D74A0", VA = "0x1887D88A0")]
		private void UpdateFocusedToMatchActiveMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x87D7C10", Offset = "0x87D6810", VA = "0x1887D7C10")]
		[BindableAction(13, "Press Recolor button")]
		public void ToggleRecolorMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x87D3B60", Offset = "0x87D2760", VA = "0x1887D3B60")]
		[BindableAction(15, "Press Exit Recolor button")]
		public void ExitRecolorMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x87D7A50", Offset = "0x87D6650", VA = "0x1887D7A50")]
		[BindableAction(17, "Press Config button")]
		public void ToggleConfigMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x87D4C80", Offset = "0x87D3880", VA = "0x1887D4C80")]
		[BindableAction(20, "Hide RRUI Page Container")]
		public void HideRRUIPageContainer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x87D7970", Offset = "0x87D6570", VA = "0x1887D7970")]
		[BindableAction(21, "Show RRUI Page Container")]
		public void ShowRRUIPageContainer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x87D78F0", Offset = "0x87D64F0", VA = "0x1887D78F0")]
		[BindableAction(22, "Request Adjust Mode")]
		public void RequestAdjustMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x87D8C40", Offset = "0x87D7840", VA = "0x1887D8C40")]
		private void UpdateSelectModeContextualBarData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x87D8880", Offset = "0x87D7480", VA = "0x1887D8880")]
		private void UpdateColorPickerOpen(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x87D8C30", Offset = "0x87D7830", VA = "0x1887D8C30")]
		private void UpdateRRUIPageContainerEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x87D4CE0", Offset = "0x87D38E0", VA = "0x1887D4CE0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x87D3BD0", Offset = "0x87D27D0", VA = "0x1887D3BD0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x87D9300", Offset = "0x87D7F00", VA = "0x1887D9300")]
		public MakerPenHUDSelectToolbarViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[ViewModel]
	public class MakerPenHUDViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		[SerializeField]
		private FocusableUI focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private IRRUIvNextBridge rruiBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private bool leftModifierHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private bool hasFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private float holdInputProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool showHoldIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private bool undoModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private bool redoModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8B")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private bool selectModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private bool createModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8D")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private bool selectModeAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8E")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private bool createModeAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private DataItem<bool> HasFocusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private DataItem<float> HoldInputProgressDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private DataItem<bool> ShowHoldIndicatorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private DataItem<bool> IsUndoAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private DataItem<bool> IsRedoAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private DataItem<bool> UndoModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private DataItem<bool> RedoModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private DataItem<bool> OnSelectModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private DataItem<bool> OnCreateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private DataItem<bool> SelectModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private DataItem<bool> CreateModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private DataItem<bool> SelectModeAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private DataItem<bool> CreateModeAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private DataItem<bool> IsCursorActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private DataItem<bool> IsInSubMenuDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private DataItemAction TriggerUndoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private DataItemAction TriggerRedoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private DataItemAction GoToSelectModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private DataItemAction GoToCreateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private DataItemAction EndCursorDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		private bool shouldFocus
		{
			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x87DD620", Offset = "0x87DC220", VA = "0x1887DD620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		[BindableData(200, null, DataPermissions.ReadWrite)]
		public bool HasFocus
		{
			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x17329F0", Offset = "0x17315F0", VA = "0x1817329F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x87DCAD0", Offset = "0x87DB6D0", VA = "0x1887DCAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		[BindableData(201, null, DataPermissions.ReadWrite)]
		public float HoldInputProgress
		{
			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x21194E0", Offset = "0x21180E0", VA = "0x1821194E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x87DCC30", Offset = "0x87DB830", VA = "0x1887DCC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		[BindableData(202, null, DataPermissions.ReadWrite)]
		public bool ShowHoldIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0D0", Offset = "0xB9CCD0", VA = "0x180B9E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0x87DCCA0", Offset = "0x87DB8A0", VA = "0x1887DCCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		[BindableData(7, "Is Undo Allowed", DataPermissions.ReadOnly)]
		public bool IsUndoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60007DE")]
			[Cpp2IlInjected.Address(RVA = "0x87DCD00", Offset = "0x87DB900", VA = "0x1887DCD00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		[BindableData(8, "Is Redo Allowed", DataPermissions.ReadOnly)]
		public bool IsRedoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0x87DCD50", Offset = "0x87DB950", VA = "0x1887DCD50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool UndoModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0xB9E070", Offset = "0xB9CC70", VA = "0x180B9E070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x87DCDA0", Offset = "0x87DB9A0", VA = "0x1887DCDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool RedoModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0E0", Offset = "0xB9CCE0", VA = "0x180B9E0E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x87DC8B0", Offset = "0x87DB4B0", VA = "0x1887DC8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		[BindableData(5, "OnSelectMode", DataPermissions.ReadOnly)]
		public bool OnSelectMode
		{
			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x87DC910", Offset = "0x87DB510", VA = "0x1887DC910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		[BindableData(6, "OnCreateMode", DataPermissions.ReadOnly)]
		public bool OnCreateMode
		{
			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x87DC960", Offset = "0x87DB560", VA = "0x1887DC960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool SelectModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0C0", Offset = "0xB9CCC0", VA = "0x180B9E0C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x87DC9B0", Offset = "0x87DB5B0", VA = "0x1887DC9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool CreateModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0xDD9670", Offset = "0xDD8270", VA = "0x180DD9670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007EB")]
			[Cpp2IlInjected.Address(RVA = "0x87DCA10", Offset = "0x87DB610", VA = "0x1887DCA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool SelectModeAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0xDD9680", Offset = "0xDD8280", VA = "0x180DD9680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x87DCA70", Offset = "0x87DB670", VA = "0x1887DCA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool CreateModeAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0x7D75C80", Offset = "0x7D74880", VA = "0x187D75C80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x87DCB30", Offset = "0x87DB730", VA = "0x1887DCB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		[BindableData(9, "Is Cursor Active", DataPermissions.ReadOnly)]
		public bool IsCursorActive
		{
			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x87DCB90", Offset = "0x87DB790", VA = "0x1887DCB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		[BindableData(11, "Is In Sub Menu", DataPermissions.ReadOnly)]
		public bool IsInSubMenu
		{
			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x87DCBE0", Offset = "0x87DB7E0", VA = "0x1887DCBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x87DD5E0", Offset = "0x87DC1E0", VA = "0x1887DD5E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x87DC460", Offset = "0x87DB060", VA = "0x1887DC460")]
		private void OnNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x87DCEF0", Offset = "0x87DBAF0", VA = "0x1887DCEF0")]
		private void UpdateInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x87DA000", Offset = "0x87D8C00", VA = "0x1887DA000", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x87DC010", Offset = "0x87DAC10", VA = "0x1887DC010", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x87DC850", Offset = "0x87DB450", VA = "0x1887DC850")]
		[BindableAction(3, "Press Undo button")]
		public void TriggerUndo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x87DC7F0", Offset = "0x87DB3F0", VA = "0x1887DC7F0")]
		[BindableAction(4, "Press Redo button")]
		public void TriggerRedo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x87DD110", Offset = "0x87DBD10", VA = "0x1887DD110")]
		private void UpdateUndoStackData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x87DA5C0", Offset = "0x87D91C0", VA = "0x1887DA5C0")]
		private void FocusCurrentMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x87DB0A0", Offset = "0x87D9CA0", VA = "0x1887DB0A0")]
		[BindableAction(1, "Press Select button")]
		public void GoToSelectMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x87DB010", Offset = "0x87D9C10", VA = "0x1887DB010")]
		[BindableAction(2, "Press Create button")]
		public void GoToCreateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x87DBFB0", Offset = "0x87DABB0", VA = "0x1887DBFB0")]
		private void OnCurrentModeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x87DCE00", Offset = "0x87DBA00", VA = "0x1887DCE00")]
		private void UpdateCuratedControls()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x87DCEA0", Offset = "0x87DBAA0", VA = "0x1887DCEA0")]
		private void UpdateCursorActive(bool isCursorActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0x87DA570", Offset = "0x87D9170", VA = "0x1887DA570")]
		[BindableAction(10, "Button to request exiting cursor mode")]
		public void EndCursor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x87DD0D0", Offset = "0x87DBCD0", VA = "0x1887DD0D0")]
		private void UpdateSubMenuActive(bool isInSubMenu)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x87DB130", Offset = "0x87D9D30", VA = "0x1887DB130", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0x87DA6E0", Offset = "0x87D92E0", VA = "0x1887DA6E0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0x87DD170", Offset = "0x87DBD70", VA = "0x1887DD170")]
		public MakerPenHUDViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[ViewModel]
	public class NestedItem : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		[SerializeField]
		private NestedListConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private int absoluteIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private NestedListItem item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private bool isExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private Sprite activeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private int depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private DataItem<string> TextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private DataItem<bool> IsExpandedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private DataItem<Sprite> ActiveIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private DataItem<int> DepthDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private DataItemAction ToggleExpandedDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x87DE340", Offset = "0x87DCF40", VA = "0x1887DE340", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000815")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000816")]
			[Cpp2IlInjected.Address(RVA = "0x87DE460", Offset = "0x87DD060", VA = "0x1887DE460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x6000817")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0D0", Offset = "0xB9CCD0", VA = "0x180B9E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0x87DE060", Offset = "0x87DCC60", VA = "0x1887DE060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public Sprite ActiveIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x87DE3B0", Offset = "0x87DCFB0", VA = "0x1887DE3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Depth
		{
			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x105A8E0", Offset = "0x10594E0", VA = "0x18105A8E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x87DE0D0", Offset = "0x87DCCD0", VA = "0x1887DE0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0x87DE300", Offset = "0x87DCF00", VA = "0x1887DE300", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x87DE000", Offset = "0x87DCC00", VA = "0x1887DE000")]
		[BindableAction(2, null)]
		public void ToggleExpanded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x87DDE60", Offset = "0x87DCA60", VA = "0x1887DDE60")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x87DD9B0", Offset = "0x87DC5B0", VA = "0x1887DD9B0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x87DD6F0", Offset = "0x87DC2F0", VA = "0x1887DD6F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x87DE130", Offset = "0x87DCD30", VA = "0x1887DE130")]
		public NestedItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[ViewModel]
	public class NestedList : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		[SerializeField]
		private NestedListConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private DataList<int> activeIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private DataItemList ActiveIndicesDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> ActiveIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0x87DEBB0", Offset = "0x87DD7B0", VA = "0x1887DEBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x87DEB80", Offset = "0x87DD780", VA = "0x1887DEB80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x87DE4E0", Offset = "0x87DD0E0", VA = "0x1887DE4E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x87DE870", Offset = "0x87DD470", VA = "0x1887DE870", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x87DE970", Offset = "0x87DD570", VA = "0x1887DE970")]
		private void OnIndexStateChanged(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x87DE720", Offset = "0x87DD320", VA = "0x1887DE720", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x87DE620", Offset = "0x87DD220", VA = "0x1887DE620")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x87DEAB0", Offset = "0x87DD6B0", VA = "0x1887DEAB0")]
		public NestedList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[ViewModel]
	public class OutfitListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		[CompilerGenerated]
		private struct <FetchOutfitData>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			public OutfitListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			private TaskAwaiter<List<YNFHNIGKEZF>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			private TaskAwaiter<RenderTexture> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			private TaskAwaiter<int> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000853")]
			[Cpp2IlInjected.Address(RVA = "0x87EC0F0", Offset = "0x87EACF0", VA = "0x1887EC0F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000854")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		[SerializeField]
		private int maxOutfitDisplayCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		[SerializeField]
		private bool generateOutfitTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[SerializeField]
		private Route customizationRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[SerializeField]
		private int renderTextureWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[SerializeField]
		private int renderTextureHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[SerializeField]
		private DataResolver currentPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private DataList<YNFHNIGKEZF> savedOutfitList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private bool isEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private DataList<int> saveOutfitSlotList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private RenderTexture outfitTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private string pageIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private DataItem<bool> IsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private DataItem<RenderTexture> OutfitTextureDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private DataItemList SavedOutfitListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private DataItemList SaveOutfitSlotListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private DataItemAction OpenCustomizerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private DataItemAction OpenSavedOutfitsPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<YNFHNIGKEZF> SavedOutfitList
		{
			[Cpp2IlInjected.Token(Token = "0x6000838")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000839")]
			[Cpp2IlInjected.Address(RVA = "0x87E0490", Offset = "0x87DF090", VA = "0x1887E0490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x600083A")]
			[Cpp2IlInjected.Address(RVA = "0xEF9A80", Offset = "0xEF8680", VA = "0x180EF9A80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600083B")]
			[Cpp2IlInjected.Address(RVA = "0x87DFE00", Offset = "0x87DEA00", VA = "0x1887DFE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<int> SaveOutfitSlotList
		{
			[Cpp2IlInjected.Token(Token = "0x600083C")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600083D")]
			[Cpp2IlInjected.Address(RVA = "0x87E0420", Offset = "0x87DF020", VA = "0x1887E0420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public RenderTexture OutfitTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0x87E0300", Offset = "0x87DEF00", VA = "0x1887E0300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(RVA = "0x87E02C0", Offset = "0x87DEEC0", VA = "0x1887E02C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0x87DFBF0", Offset = "0x87DE7F0", VA = "0x1887DFBF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x87DF790", Offset = "0x87DE390", VA = "0x1887DF790", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x87DF500", Offset = "0x87DE100", VA = "0x1887DF500")]
		private void OnActivePanelChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x87DEC10", Offset = "0x87DD810", VA = "0x1887DEC10")]
		[AsyncStateMachine(typeof(<FetchOutfitData>d__28))]
		private void FetchOutfitData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x87DF9A0", Offset = "0x87DE5A0", VA = "0x1887DF9A0")]
		[BindableAction(100, null)]
		private void OpenCustomizer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x87DFAD0", Offset = "0x87DE6D0", VA = "0x1887DFAD0")]
		[BindableAction(101, null)]
		private void OpenSavedOutfitsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x87DEFE0", Offset = "0x87DDBE0", VA = "0x1887DEFE0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x87DECC0", Offset = "0x87DD8C0", VA = "0x1887DECC0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x87E0010", Offset = "0x87DEC10", VA = "0x1887E0010")]
		public OutfitListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[ViewModel]
	public class OutfitViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private string outfitThumbnailName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private bool wearingOutfit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private YNFHNIGKEZF savedOutfitData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private DataItem<string> OutfitThumbnailNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private DataItem<bool> WearingOutfitDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private DataItemAction ChangeOutfitDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string OutfitThumbnailName
		{
			[Cpp2IlInjected.Token(Token = "0x6000855")]
			[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0x87E0F30", Offset = "0x87DFB30", VA = "0x1887E0F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool WearingOutfit
		{
			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xF343C0", Offset = "0xF32FC0", VA = "0x180F343C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0x87E0FA0", Offset = "0x87DFBA0", VA = "0x1887E0FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000859")]
			[Cpp2IlInjected.Address(RVA = "0x87E1170", Offset = "0x87DFD70", VA = "0x1887E1170", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600085D")]
			[Cpp2IlInjected.Address(RVA = "0x87E1130", Offset = "0x87DFD30", VA = "0x1887E1130", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600085E")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x87E0E70", Offset = "0x87DFA70", VA = "0x1887E0E70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x87E0AF0", Offset = "0x87DF6F0", VA = "0x1887E0AF0")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x87E0500", Offset = "0x87DF100", VA = "0x1887E0500")]
		[BindableAction(100, null)]
		private void ChangeOutfit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x87E0810", Offset = "0x87DF410", VA = "0x1887E0810", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x87E0630", Offset = "0x87DF230", VA = "0x1887E0630")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x87E1000", Offset = "0x87DFC00", VA = "0x1887E1000")]
		public OutfitViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[ViewModel]
	public class SaveOutfitButtonViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private int slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private DataItem<int> SlotIndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private DataItemAction SaveOutfitDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x87EB1D0", Offset = "0x87E9DD0", VA = "0x1887EB1D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int SlotIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0x1338B30", Offset = "0x1337730", VA = "0x181338B30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0x87EB090", Offset = "0x87E9C90", VA = "0x1887EB090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0x87EB1A0", Offset = "0x87E9DA0", VA = "0x1887EB1A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x87EAF60", Offset = "0x87E9B60", VA = "0x1887EAF60")]
		[BindableAction(100, null)]
		public void SaveOutfit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x87EAA50", Offset = "0x87E9650", VA = "0x1887EAA50", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x87EAE70", Offset = "0x87E9A70", VA = "0x1887EAE70")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x87EAC80", Offset = "0x87E9880", VA = "0x1887EAC80", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x87EAB20", Offset = "0x87E9720", VA = "0x1887EAB20")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x87EB0E0", Offset = "0x87E9CE0", VA = "0x1887EB0E0")]
		public SaveOutfitButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[ViewModel]
	public class RoomCategoryListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		public enum Sources
		{
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			PageSource,
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			CuratedList
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		[CompilerGenerated]
		private struct <FetchData>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public RoomCategoryListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			private TaskAwaiter<(IReadOnlyList<RUQRXZAMGGP> categories, string displayName)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			private TaskAwaiter<IReadOnlyList<RUQRXZAMGGP>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x87EB240", Offset = "0x87E9E40", VA = "0x1887EB240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		[SerializeField]
		private LoadSceneSources loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		[SerializeField]
		private Sources source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		[SerializeField]
		private string sourceMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private string _discoverySectionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private IRRUIvNextRoomCategoryBridge roomCategoryBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private DataList<RUQRXZAMGGP> roomCategoryList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private DataItemList RoomCategoryListDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		public LoadSceneSources LoadSceneSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0x87E22F0", Offset = "0x87E0EF0", VA = "0x1887E22F0")]
			get
			{
				return default(LoadSceneSources);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public BrowserModel BrowserModel
		{
			[Cpp2IlInjected.Token(Token = "0x6000874")]
			[Cpp2IlInjected.Address(RVA = "0x87E2200", Offset = "0x87E0E00", VA = "0x1887E2200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public string DiscoverySectionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x87E2300", Offset = "0x87E0F00", VA = "0x1887E2300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<RUQRXZAMGGP> RoomCategoryList
		{
			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x87E2430", Offset = "0x87E1030", VA = "0x1887E2430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000879")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600087A")]
			[Cpp2IlInjected.Address(RVA = "0x87E23B0", Offset = "0x87E0FB0", VA = "0x1887E23B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x87E22B0", Offset = "0x87E0EB0", VA = "0x1887E22B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000880")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x87E1C30", Offset = "0x87E0830", VA = "0x1887E1C30", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x87E1CB0", Offset = "0x87E08B0", VA = "0x1887E1CB0")]
		public void SetSourceData(string source, string sourceMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x87E17D0", Offset = "0x87E03D0", VA = "0x1887E17D0")]
		[AsyncStateMachine(typeof(<FetchData>d__25))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x87E1D40", Offset = "0x87E0940", VA = "0x1887E1D40")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x87E19F0", Offset = "0x87E05F0", VA = "0x1887E19F0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x87E1880", Offset = "0x87E0480", VA = "0x1887E1880")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x87E20B0", Offset = "0x87E0CB0", VA = "0x1887E20B0")]
		public RoomCategoryListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[ViewModel]
	public class RoomCategoryViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		[SerializeField]
		private Route searchRoomsroute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		[SerializeField]
		private Route gridViewRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private IRRUIvNextRoomCategoryBridge roomCategoryBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private LoadSceneSources loadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private RUQRXZAMGGP roomCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private DataItemAction SelectRoomCategoryDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000221")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600088A")]
			[Cpp2IlInjected.Address(RVA = "0x87E31D0", Offset = "0x87E1DD0", VA = "0x1887E31D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600088C")]
			[Cpp2IlInjected.Address(RVA = "0x87E3240", Offset = "0x87E1E40", VA = "0x1887E3240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x87E32C0", Offset = "0x87E1EC0", VA = "0x1887E32C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0x87E3190", Offset = "0x87E1D90", VA = "0x1887E3190", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x87E2B60", Offset = "0x87E1760", VA = "0x1887E2B60")]
		[BindableAction(100, null)]
		public void SelectRoomCategory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x87E24A0", Offset = "0x87E10A0", VA = "0x1887E24A0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x87E2A50", Offset = "0x87E1650", VA = "0x1887E2A50")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x87E2D00", Offset = "0x87E1900", VA = "0x1887E2D00")]
		private void Set(RUQRXZAMGGP data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x87E2F40", Offset = "0x87E1B40", VA = "0x1887E2F40")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x87E27A0", Offset = "0x87E13A0", VA = "0x1887E27A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x87E25C0", Offset = "0x87E11C0", VA = "0x1887E25C0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x87E3050", Offset = "0x87E1C50", VA = "0x1887E3050")]
		public RoomCategoryViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public class RoomCardFeatureHelper : BaseBindableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private LoadSceneSourceData loadSceneSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private bool showCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private int pinnedRoomCCUThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private bool showPopularBadge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private int popularRoomCCUThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private bool showNewBadge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private bool showPlayActionButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private bool showMoreLikeThisButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private bool showUpdateToPlayIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private bool showUpdateToPlayText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private string sessionSectionIdOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private Guid? sectionSpawnInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private string parentTabName;

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		public LoadSceneSourceData LoadSceneSourceData
		{
			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x87E1200", Offset = "0x87DFE00", VA = "0x1887E1200")]
			get
			{
				return default(LoadSceneSourceData);
			}
			[Cpp2IlInjected.Token(Token = "0x600089E")]
			[Cpp2IlInjected.Address(RVA = "0x87E1260", Offset = "0x87DFE60", VA = "0x1887E1260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		public bool ShowCCUCounts
		{
			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0xEF9A80", Offset = "0xEF8680", VA = "0x180EF9A80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0x87E1530", Offset = "0x87E0130", VA = "0x1887E1530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		public bool ShowPopularBadge
		{
			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0xB44430", Offset = "0xB43030", VA = "0x180B44430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x87E16B0", Offset = "0x87E02B0", VA = "0x1887E16B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000229")]
		public int PopularRoomCCUThreshold
		{
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x3085020", Offset = "0x3083C20", VA = "0x183085020")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0x87E1370", Offset = "0x87DFF70", VA = "0x1887E1370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		public bool ShowNewBadge
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D60", Offset = "0xBB2960", VA = "0x180BB3D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0x87E1590", Offset = "0x87E0190", VA = "0x1887E1590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		public bool ShowPlayActionButton
		{
			[Cpp2IlInjected.Token(Token = "0x60008A7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0620", Offset = "0x1FAF220", VA = "0x181FB0620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A8")]
			[Cpp2IlInjected.Address(RVA = "0x87E1650", Offset = "0x87E0250", VA = "0x1887E1650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		public bool ShowMoreLikeThisButton
		{
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0x87E1240", Offset = "0x87DFE40", VA = "0x1887E1240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		public bool ShowUpdateToPlayIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0x87E1250", Offset = "0x87DFE50", VA = "0x1887E1250")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0x87E1710", Offset = "0x87E0310", VA = "0x1887E1710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		public bool ShowUpdateToPlayText
		{
			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0x111A880", Offset = "0x1119480", VA = "0x18111A880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0x87E1770", Offset = "0x87E0370", VA = "0x1887E1770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public bool ShowNewThisSessionForSection
		{
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0x1D76A70", Offset = "0x1D75670", VA = "0x181D76A70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0x87E15F0", Offset = "0x87E01F0", VA = "0x1887E15F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public string SessionSectionIdOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60008B0")]
			[Cpp2IlInjected.Address(RVA = "0xB1B710", Offset = "0xB1A310", VA = "0x180B1B710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x87E14B0", Offset = "0x87E00B0", VA = "0x1887E14B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public Guid? SectionSpawnInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0xB1B760", Offset = "0xB1A360", VA = "0x180B1B760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0x87E13D0", Offset = "0x87DFFD0", VA = "0x1887E13D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		public string ParentTabName
		{
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0xBD4160", Offset = "0xBD2D60", VA = "0x180BD4160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B5")]
			[Cpp2IlInjected.Address(RVA = "0x87E12F0", Offset = "0x87DFEF0", VA = "0x1887E12F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x87E11E0", Offset = "0x87DFDE0", VA = "0x1887E11E0")]
		public RoomCardFeatureHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[ViewModel]
	public class RoomListViewModel : RRUIBaseLocalViewModel, IOrderedRenderable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private struct <FetchData>d__52 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005C1")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			public RoomListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			private TaskAwaiter<List<RoomDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60008E4")]
			[Cpp2IlInjected.Address(RVA = "0x87EB830", Offset = "0x87EA430", VA = "0x1887EB830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E5")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		[SerializeField]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		[SerializeField]
		private LoadSceneSources loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private IRoomQueryManager roomListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private bool waitingForQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private List<long> tempIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private int minItemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private bool fetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private DataList<long> roomIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private string listDisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private bool isEmptyOrBelowMinimum;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private RoomCardFeatureHelper featureHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private DataItem<string> ListDisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private DataItem<bool> IsEmptyOrBelowMinimumDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private DataItem<RoomListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private DataItem<RoomCardFeatureHelper> FeatureHelperDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private DataItemList RoomIdListDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<long> RoomIdList
		{
			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0xB1B710", Offset = "0xB1A310", VA = "0x180B1B710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B8")]
			[Cpp2IlInjected.Address(RVA = "0x87E5660", Offset = "0x87E4260", VA = "0x1887E5660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		[BindableData(1, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string ListDisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60008B9")]
			[Cpp2IlInjected.Address(RVA = "0xB74D40", Offset = "0xB73940", VA = "0x180B74D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008BA")]
			[Cpp2IlInjected.Address(RVA = "0x87E55E0", Offset = "0x87E41E0", VA = "0x1887E55E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool IsEmptyOrBelowMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x60008BB")]
			[Cpp2IlInjected.Address(RVA = "0xB74A20", Offset = "0xB73620", VA = "0x180B74A20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008BC")]
			[Cpp2IlInjected.Address(RVA = "0x87E5120", Offset = "0x87E3D20", VA = "0x1887E5120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		[BindableData(3, "The query data used to retrieve the room list", DataPermissions.ReadOnly)]
		public RoomListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public RoomCardFeatureHelper FeatureHelper
		{
			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0xBD41A0", Offset = "0xBD2DA0", VA = "0x180BD41A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008BF")]
			[Cpp2IlInjected.Address(RVA = "0x87E5180", Offset = "0x87E3D80", VA = "0x1887E5180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		public bool RenderInCarouselOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60008C0")]
			[Cpp2IlInjected.Address(RVA = "0x1620060", Offset = "0x161EC60", VA = "0x181620060", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C1")]
			[Cpp2IlInjected.Address(RVA = "0xDC5530", Offset = "0xDC4130", VA = "0x180DC5530", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		public bool AllowRender
		{
			[Cpp2IlInjected.Token(Token = "0x60008C2")]
			[Cpp2IlInjected.Address(RVA = "0x2533C80", Offset = "0x2532880", VA = "0x182533C80", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C3")]
			[Cpp2IlInjected.Address(RVA = "0xDC5540", Offset = "0xDC4140", VA = "0x180DC5540", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		public bool HasRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0x2534010", Offset = "0x2532C10", VA = "0x182534010", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C5")]
			[Cpp2IlInjected.Address(RVA = "0xDC5550", Offset = "0xDC4150", VA = "0x180DC5550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public bool RequiresRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x60008C6")]
			[Cpp2IlInjected.Address(RVA = "0x2533BD0", Offset = "0x25327D0", VA = "0x182533BD0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C7")]
			[Cpp2IlInjected.Address(RVA = "0x2531AD0", Offset = "0x25306D0", VA = "0x182531AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		public bool OverrideLoadSceneSource
		{
			[Cpp2IlInjected.Token(Token = "0x60008C8")]
			[Cpp2IlInjected.Address(RVA = "0xCBFFF0", Offset = "0xCBEBF0", VA = "0x180CBFFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		public LoadSceneSources LoadSceneSourceOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60008C9")]
			[Cpp2IlInjected.Address(RVA = "0xB3B6F0", Offset = "0xB3A2F0", VA = "0x180B3B6F0")]
			get
			{
				return default(LoadSceneSources);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0x87E55A0", Offset = "0x87E41A0", VA = "0x1887E55A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60008D7")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x87E4F80", Offset = "0x87E3B80", VA = "0x1887E4F80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x87E3D30", Offset = "0x87E2930", VA = "0x1887E3D30", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x87E47E0", Offset = "0x87E33E0", VA = "0x1887E47E0")]
		public void SetQueryData(RoomListQueryData listQueryData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x87E46A0", Offset = "0x87E32A0", VA = "0x1887E46A0")]
		public void SetDiscoverySectionId(string sectionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x87E3340", Offset = "0x87E1F40", VA = "0x1887E3340")]
		[AsyncStateMachine(typeof(<FetchData>d__52))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x87E4750", Offset = "0x87E3350", VA = "0x1887E4750")]
		public void SetMaxItems(int maxItemsToFetch, int maxItemsToDisplay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x87E47B0", Offset = "0x87E33B0", VA = "0x1887E47B0")]
		public void SetMinItems(int minItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x87E3EA0", Offset = "0x87E2AA0", VA = "0x1887E3EA0")]
		private void PopulateLoadSceneSourceData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x87E4430", Offset = "0x87E3030", VA = "0x1887E4430")]
		private string ResolveDisplayName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x2533C80", Offset = "0x2532880", VA = "0x182533C80")]
		private bool WaitUntilAllowRender()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x87E48A0", Offset = "0x87E34A0", VA = "0x1887E48A0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x87E3C10", Offset = "0x87E2810", VA = "0x1887E3C10")]
		private void OnChildImpressionTrackerAdded(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x87E36B0", Offset = "0x87E22B0", VA = "0x1887E36B0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x87E33F0", Offset = "0x87E1FF0", VA = "0x1887E33F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x87E52C0", Offset = "0x87E3EC0", VA = "0x1887E52C0")]
		public RoomListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[ViewModel]
	public class RoomViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass128_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400060B")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400060C")]
			public RoomDetailsDTO roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400060D")]
			public SubRoomDTO subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400060E")]
			public bool privateInstance;

			[Cpp2IlInjected.Token(Token = "0x600095B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public <>c__DisplayClass128_0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095C")]
			[Cpp2IlInjected.Address(RVA = "0x87FE8C0", Offset = "0x87FD4C0", VA = "0x1887FE8C0")]
			internal void <PlayAction_TryGoToRoom>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass128_1
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400060F")]
			public SubRoomDataSaveDTO latestValidSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000610")]
			public <>c__DisplayClass128_0 CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600095D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public <>c__DisplayClass128_1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095E")]
			[Cpp2IlInjected.Address(RVA = "0x87FE9B0", Offset = "0x87FD5B0", VA = "0x1887FE9B0")]
			internal void <PlayAction_TryGoToRoom>b__1()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private struct <CreateOrJoinRoomInstance>d__127 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000611")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000612")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000613")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000614")]
			public RoomDetailsDTO roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600095F")]
			[Cpp2IlInjected.Address(RVA = "0x87FC100", Offset = "0x87FAD00", VA = "0x1887FC100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000960")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private struct <DoPlayAction>d__126 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			private RoomDetailsDTO <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			private bool <canChooseSubroom>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400061E")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000961")]
			[Cpp2IlInjected.Address(RVA = "0x87FC670", Offset = "0x87FB270", VA = "0x1887FC670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000962")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private struct <FetchRoomData>d__120 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000622")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			private TaskAwaiter<RoomDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0x87FCE50", Offset = "0x87FBA50", VA = "0x1887FCE50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private struct <PlayAction_TryGoToRoom>d__128 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000625")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000626")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000627")]
			public RoomDetailsDTO roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000628")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000629")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			private <>c__DisplayClass128_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			private <>c__DisplayClass128_1 <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400062D")]
			private TaskAwaiter<SubRoomDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400062E")]
			private IRoomSaveManager <saveManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400062F")]
			private TaskAwaiter<SubRoomDataSaveDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0x87FD630", Offset = "0x87FC230", VA = "0x1887FD630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private const string CCUCountKey = "CCU_COUNT";

		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private const char tokenDelimiter = '.';

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		[SerializeField]
		private DataResolver featureHelperResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private IRoomQueryManager roomQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private IRRUIvNextUIDataBridge vNextDataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private LoadSceneSourceData loadSceneSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private DialogListModel dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private int cheerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private int ccuCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private bool shouldFetchCCUCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private DateTime? lastPublished;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private bool hasSufficientVersionToLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private bool favorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private string cheerCountString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private bool isRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x169")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private bool showCheerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private string ccuCountString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private bool supportsPlayAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x179")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private bool supportsMoreLikeThis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17A")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private bool isPopularRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17B")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private bool isNewlyPublished;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private bool showCCUCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17D")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private bool supportsDataTokens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17E")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private bool showCheerToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17F")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private bool requiresUpdateToPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private bool showUpdateToPlayIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x181")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private bool showUpdateToPlayText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x182")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x183")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private bool showRooms2Badge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private RoomPublishState publishState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private bool showPublishState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private DataItem<long> RoomIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private DataItem<string> DescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private DataItem<bool> FavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private DataItem<string> CheerCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private DataItem<bool> IsRooms2DataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private DataItem<bool> ShowCheerCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private DataItem<string> CCUCountStringDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private DataItem<bool> SupportsPlayActionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private DataItem<bool> SupportsMoreLikeThisDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private DataItem<bool> IsPopularRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private DataItem<bool> IsNewlyPublishedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private DataItem<bool> ShowCCUCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private DataItem<bool> SupportsDataTokensDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private DataItem<bool> ShowCheerTokenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private DataItem<bool> RequiresUpdateToPlayDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private DataItem<bool> ShowUpdateToPlayIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private DataItem<bool> ShowUpdateToPlayTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private DataItem<bool> ShowNewThisSessionForSectionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private DataItem<bool> ShowRooms2BadgeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private DataItem<RoomPublishState> PublishStateDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private DataItem<bool> ShowPublishStateDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private DataItemAction OpenRoomDetailsPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private DataItemAction DoPlayActionDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		[BindableData(0, "The ID used to retrieve the room data from RecNet", DataPermissions.ReadWrite)]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0xC08550", Offset = "0xC07150", VA = "0x180C08550")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0x87EA950", Offset = "0x87E9550", VA = "0x1887EA950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		[BindableData(1, "The sanitized, friendly name of the room", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0xC8F330", Offset = "0xC8DF30", VA = "0x180C8F330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0x87EA840", Offset = "0x87E9440", VA = "0x1887EA840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60008EA")]
			[Cpp2IlInjected.Address(RVA = "0xC8F320", Offset = "0xC8DF20", VA = "0x180C8F320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0x87EA7C0", Offset = "0x87E93C0", VA = "0x1887EA7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60008EC")]
			[Cpp2IlInjected.Address(RVA = "0xC8EDD0", Offset = "0xC8D9D0", VA = "0x180C8EDD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x87EA8C0", Offset = "0x87E94C0", VA = "0x1887EA8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool Favorited
		{
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x17AE780", Offset = "0x17AD380", VA = "0x1817AE780")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x87E9180", Offset = "0x87E7D80", VA = "0x1887E9180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000245")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public string CheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0xC8E030", Offset = "0xC8CC30", VA = "0x180C8E030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x87EA740", Offset = "0x87E9340", VA = "0x1887EA740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000246")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool IsRooms2
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x1A3DA00", Offset = "0x1A3C600", VA = "0x181A3DA00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0x87E8AB0", Offset = "0x87E76B0", VA = "0x1887E8AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool ShowCheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008F4")]
			[Cpp2IlInjected.Address(RVA = "0x228E2A0", Offset = "0x228CEA0", VA = "0x18228E2A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F5")]
			[Cpp2IlInjected.Address(RVA = "0x87E8B10", Offset = "0x87E7710", VA = "0x1887E8B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string CCUCountString
		{
			[Cpp2IlInjected.Token(Token = "0x60008F6")]
			[Cpp2IlInjected.Address(RVA = "0xC8DFF0", Offset = "0xC8CBF0", VA = "0x180C8DFF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008F7")]
			[Cpp2IlInjected.Address(RVA = "0x87EA6C0", Offset = "0x87E92C0", VA = "0x1887EA6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool SupportsPlayAction
		{
			[Cpp2IlInjected.Token(Token = "0x60008F8")]
			[Cpp2IlInjected.Address(RVA = "0xCE46E0", Offset = "0xCE32E0", VA = "0x180CE46E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F9")]
			[Cpp2IlInjected.Address(RVA = "0x87E8B80", Offset = "0x87E7780", VA = "0x1887E8B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024A")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public bool SupportsMoreLikeThis
		{
			[Cpp2IlInjected.Token(Token = "0x60008FA")]
			[Cpp2IlInjected.Address(RVA = "0x87E8BE0", Offset = "0x87E77E0", VA = "0x1887E8BE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008FB")]
			[Cpp2IlInjected.Address(RVA = "0x87E8BF0", Offset = "0x87E77F0", VA = "0x1887E8BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024B")]
		[BindableData(11, null, DataPermissions.ReadWrite)]
		public bool IsPopularRoom
		{
			[Cpp2IlInjected.Token(Token = "0x60008FC")]
			[Cpp2IlInjected.Address(RVA = "0x87E8C60", Offset = "0x87E7860", VA = "0x1887E8C60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008FD")]
			[Cpp2IlInjected.Address(RVA = "0x87E8C70", Offset = "0x87E7870", VA = "0x1887E8C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool IsNewlyPublished
		{
			[Cpp2IlInjected.Token(Token = "0x60008FE")]
			[Cpp2IlInjected.Address(RVA = "0x87E8CD0", Offset = "0x87E78D0", VA = "0x1887E8CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008FF")]
			[Cpp2IlInjected.Address(RVA = "0x87E8CE0", Offset = "0x87E78E0", VA = "0x1887E8CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024D")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool ShowCCUCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000900")]
			[Cpp2IlInjected.Address(RVA = "0x87E8D40", Offset = "0x87E7940", VA = "0x1887E8D40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000901")]
			[Cpp2IlInjected.Address(RVA = "0x87E8D50", Offset = "0x87E7950", VA = "0x1887E8D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024E")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool SupportsDataTokens
		{
			[Cpp2IlInjected.Token(Token = "0x6000902")]
			[Cpp2IlInjected.Address(RVA = "0x87E8DB0", Offset = "0x87E79B0", VA = "0x1887E8DB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000903")]
			[Cpp2IlInjected.Address(RVA = "0x87E8DC0", Offset = "0x87E79C0", VA = "0x1887E8DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool ShowCheerToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000904")]
			[Cpp2IlInjected.Address(RVA = "0x87E8E20", Offset = "0x87E7A20", VA = "0x1887E8E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000905")]
			[Cpp2IlInjected.Address(RVA = "0x87E8E30", Offset = "0x87E7A30", VA = "0x1887E8E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000250")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool RequiresUpdateToPlay
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x87E8E90", Offset = "0x87E7A90", VA = "0x1887E8E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x87E8EA0", Offset = "0x87E7AA0", VA = "0x1887E8EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000251")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool ShowUpdateToPlayIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0xBEA870", Offset = "0xBE9470", VA = "0x180BEA870")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x87E8F00", Offset = "0x87E7B00", VA = "0x1887E8F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000252")]
		[BindableData(18, null, DataPermissions.ReadWrite)]
		public bool ShowUpdateToPlayText
		{
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x87E8F60", Offset = "0x87E7B60", VA = "0x1887E8F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x87E8F70", Offset = "0x87E7B70", VA = "0x1887E8F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		[BindableData(19, null, DataPermissions.ReadWrite)]
		public bool ShowNewThisSessionForSection
		{
			[Cpp2IlInjected.Token(Token = "0x600090C")]
			[Cpp2IlInjected.Address(RVA = "0x87E8FD0", Offset = "0x87E7BD0", VA = "0x1887E8FD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600090D")]
			[Cpp2IlInjected.Address(RVA = "0x87E8FE0", Offset = "0x87E7BE0", VA = "0x1887E8FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		[BindableData(20, null, DataPermissions.ReadWrite)]
		public bool ShowRooms2Badge
		{
			[Cpp2IlInjected.Token(Token = "0x600090E")]
			[Cpp2IlInjected.Address(RVA = "0x87E9040", Offset = "0x87E7C40", VA = "0x1887E9040")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0x87E9050", Offset = "0x87E7C50", VA = "0x1887E9050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		[BindableData(21, null, DataPermissions.ReadWrite)]
		public RoomPublishState PublishState
		{
			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0xBB93C0", Offset = "0xBB7FC0", VA = "0x180BB93C0")]
			get
			{
				return default(RoomPublishState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000911")]
			[Cpp2IlInjected.Address(RVA = "0x87E90B0", Offset = "0x87E7CB0", VA = "0x1887E90B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000256")]
		[BindableData(22, null, DataPermissions.ReadWrite)]
		public bool ShowPublishState
		{
			[Cpp2IlInjected.Token(Token = "0x6000912")]
			[Cpp2IlInjected.Address(RVA = "0xC93E50", Offset = "0xC92A50", VA = "0x180C93E50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000913")]
			[Cpp2IlInjected.Address(RVA = "0x87E9110", Offset = "0x87E7D10", VA = "0x1887E9110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000257")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000914")]
			[Cpp2IlInjected.Address(RVA = "0x87EA590", Offset = "0x87E9190", VA = "0x1887EA590", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000258")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000915")]
			[Cpp2IlInjected.Address(RVA = "0x87EA580", Offset = "0x87E9180", VA = "0x1887EA580", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000916")]
			[Cpp2IlInjected.Address(RVA = "0x87EA940", Offset = "0x87E9540", VA = "0x1887EA940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0x87EA540", Offset = "0x87E9140", VA = "0x1887EA540", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000929")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<ILoadable> Loaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0x87EA480", Offset = "0x87E9080", VA = "0x1887EA480", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000918")]
			[Cpp2IlInjected.Address(RVA = "0x87EA600", Offset = "0x87E9200", VA = "0x1887EA600", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x87E5820", Offset = "0x87E4420", VA = "0x1887E5820", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x87E7CE0", Offset = "0x87E68E0", VA = "0x1887E7CE0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x87E7B00", Offset = "0x87E6700", VA = "0x1887E7B00")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x87E5B20", Offset = "0x87E4720", VA = "0x1887E5B20")]
		[AsyncStateMachine(typeof(<FetchRoomData>d__120))]
		private void FetchRoomData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x87E99F0", Offset = "0x87E85F0", VA = "0x1887E99F0")]
		private void UpdateRoomData(RoomDTO roomDto)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x87E91F0", Offset = "0x87E7DF0", VA = "0x1887E91F0")]
		private void UpdateFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x87E85D0", Offset = "0x87E71D0", VA = "0x1887E85D0")]
		private void ResetRoomData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x87E7D90", Offset = "0x87E6990", VA = "0x1887E7D90")]
		private void OnFeatureHelperUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x87E7DB0", Offset = "0x87E69B0", VA = "0x1887E7DB0")]
		[BindableAction(100, null)]
		private void OpenRoomDetailsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x87E5A70", Offset = "0x87E4670", VA = "0x1887E5A70")]
		[AsyncStateMachine(typeof(<DoPlayAction>d__126))]
		[BindableAction(101, null)]
		private void DoPlayAction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x87E5970", Offset = "0x87E4570", VA = "0x1887E5970")]
		[AsyncStateMachine(typeof(<CreateOrJoinRoomInstance>d__127))]
		private void CreateOrJoinRoomInstance(bool privateInstance, RoomDetailsDTO roomDetails, bool canChooseSubroom = false, bool randomSubroom = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x87E82C0", Offset = "0x87E6EC0", VA = "0x1887E82C0")]
		[AsyncStateMachine(typeof(<PlayAction_TryGoToRoom>d__128))]
		private void PlayAction_TryGoToRoom(RoomDetailsDTO roomDetails, bool privateInstance, bool canChooseSubroom, bool randomSubroom)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x87E83D0", Offset = "0x87E6FD0", VA = "0x1887E83D0")]
		private void RecordImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x87E56D0", Offset = "0x87E42D0", VA = "0x1887E56D0")]
		private void AddDataTokenToImpressionData(string dataToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x87E6720", Offset = "0x87E5320", VA = "0x1887E6720", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x87E5BD0", Offset = "0x87E47D0", VA = "0x1887E5BD0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x87E9E00", Offset = "0x87E8A00", VA = "0x1887E9E00")]
		public RoomViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class RRUIBaseGlobalViewModel : BaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		protected override string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000967")]
			[Cpp2IlInjected.Address(RVA = "0x87F4B70", Offset = "0x87F3770", VA = "0x1887F4B70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x87F4B60", Offset = "0x87F3760", VA = "0x1887F4B60")]
		public RRUIBaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public class RRUIBaseLocalViewModel : BaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		[SerializeField]
		protected ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		protected CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.Token(Token = "0x1700025C")]
		protected override string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000969")]
			[Cpp2IlInjected.Address(RVA = "0x87F4D10", Offset = "0x87F3910", VA = "0x1887F4D10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x87F4CA0", Offset = "0x87F38A0", VA = "0x1887F4CA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x87F4BA0", Offset = "0x87F37A0", VA = "0x1887F4BA0")]
		protected CancellationToken CancelAndRefreshToken()
		{
			return default(CancellationToken);
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x87F4C50", Offset = "0x87F3850", VA = "0x1887F4C50")]
		protected void CancelToken()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x87F4D00", Offset = "0x87F3900", VA = "0x1887F4D00")]
		public RRUIBaseLocalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public class PopoverCornerController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		[SerializeField]
		private GameObject topLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		[SerializeField]
		private GameObject topCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		[SerializeField]
		private GameObject topRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		[SerializeField]
		private GameObject upperLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		[SerializeField]
		private GameObject middleLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		[SerializeField]
		private GameObject lowerLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		[SerializeField]
		private GameObject upperRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		[SerializeField]
		private GameObject middleRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		[SerializeField]
		private GameObject lowerRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		[SerializeField]
		private GameObject bottomLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		[SerializeField]
		private GameObject bottomCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		[SerializeField]
		private GameObject bottomRight;

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		public PopoverAnchor ActiveAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0xFEF5C0", Offset = "0xFEE1C0", VA = "0x180FEF5C0")]
			[CompilerGenerated]
			get
			{
				return default(PopoverAnchor);
			}
			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0x114DF50", Offset = "0x114CB50", VA = "0x18114DF50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x87F49B0", Offset = "0x87F35B0", VA = "0x1887F49B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x87F49D0", Offset = "0x87F35D0", VA = "0x1887F49D0")]
		public void SetActiveAnchor(PopoverAnchor anchor, bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0x87F4B40", Offset = "0x87F3740", VA = "0x1887F4B40")]
		public PopoverCornerController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public class Tutorial
	{
		[Cpp2IlInjected.Token(Token = "0x20000D9")]
		public enum CompletionState
		{
			[Cpp2IlInjected.Token(Token = "0x4000647")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000648")]
			Completed,
			[Cpp2IlInjected.Token(Token = "0x4000649")]
			SoftExit,
			[Cpp2IlInjected.Token(Token = "0x400064A")]
			HardExit
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private List<TutorialStep> steps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private int activeStepIdx;

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000974")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		public TutorialStep ActiveStep
		{
			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0x87FC0A0", Offset = "0x87FACA0", VA = "0x1887FC0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		public IReadOnlyList<TutorialStep> Steps
		{
			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		public AQWXMNIFQIV OnTutorialStarted
		{
			[Cpp2IlInjected.Token(Token = "0x6000977")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		public AQWXMNIFQIV OnTutorialExited
		{
			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000263")]
		public AQWXMNIFQIV OnStepChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000979")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		public CompletionState CompletionStatus
		{
			[Cpp2IlInjected.Token(Token = "0x600097A")]
			[Cpp2IlInjected.Address(RVA = "0xB18830", Offset = "0xB17430", VA = "0x180B18830")]
			[CompilerGenerated]
			get
			{
				return default(CompletionState);
			}
			[Cpp2IlInjected.Token(Token = "0x600097B")]
			[Cpp2IlInjected.Address(RVA = "0xB18820", Offset = "0xB17420", VA = "0x180B18820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x87FBED0", Offset = "0x87FAAD0", VA = "0x1887FBED0")]
		public Tutorial(string id, List<TutorialStep> steps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x87FBE90", Offset = "0x87FAA90", VA = "0x1887FBE90")]
		public void StartTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097E")]
		[Cpp2IlInjected.Address(RVA = "0x87FB820", Offset = "0x87FA420", VA = "0x1887FB820")]
		public void ExitTutorial(bool showAgain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0x87FB9A0", Offset = "0x87FA5A0", VA = "0x1887FB9A0")]
		public void SetActiveStep(string id, bool forceReload = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x87FBAE0", Offset = "0x87FA6E0", VA = "0x1887FBAE0")]
		public void SetActiveStep(int idx, bool forceReload = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x87FB8A0", Offset = "0x87FA4A0", VA = "0x1887FB8A0")]
		private void OnGoBack()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x87FB920", Offset = "0x87FA520", VA = "0x1887FB920")]
		private void OnStepCompleted()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public class TutorialHighlightTargeter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		[SerializeField]
		protected List<TutorialTargetData> tutorialTargets;

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0x87F5670", Offset = "0x87F4270", VA = "0x1887F5670", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x87F57E0", Offset = "0x87F43E0", VA = "0x1887F57E0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x87F5AC0", Offset = "0x87F46C0", VA = "0x1887F5AC0")]
		private void RegisterTargets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(RVA = "0x87F5C60", Offset = "0x87F4860", VA = "0x1887F5C60")]
		public TutorialHighlightTargeter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public class TutorialTargetData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public string TutorialId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public string StepId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public RectTransform Target;

		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0x28397D0", Offset = "0x28383D0", VA = "0x1828397D0")]
		public TutorialTargetData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public enum PopoverAnchor
	{
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		TopLeft,
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		TopCenter,
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		TopRight,
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		UpperLeft,
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		MiddleLeft,
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		LowerLeft,
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		UpperRight,
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		MiddleRight,
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		LowerRight,
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		BottomLeft,
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		BottomCenter,
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		BottomRight,
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		MiddleCenter
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public class TutorialStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private bool isActive;

		[Cpp2IlInjected.Token(Token = "0x17000265")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000988")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000989")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000266")]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x600098A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098B")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000267")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600098C")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000268")]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000269")]
		public string ButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000990")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000991")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026A")]
		public string CountText
		{
			[Cpp2IlInjected.Token(Token = "0x6000992")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026B")]
		public bool HasButtonToGoForward
		{
			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0xFD49C0", Offset = "0xFD35C0", VA = "0x180FD49C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000995")]
			[Cpp2IlInjected.Address(RVA = "0xFD4320", Offset = "0xFD2F20", VA = "0x180FD4320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026C")]
		public bool HasButtonToGoBack
		{
			[Cpp2IlInjected.Token(Token = "0x6000996")]
			[Cpp2IlInjected.Address(RVA = "0x166EB60", Offset = "0x166D760", VA = "0x18166EB60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0x166EB50", Offset = "0x166D750", VA = "0x18166EB50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026D")]
		public bool ShowCountText
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x7EDD690", Offset = "0x7EDC290", VA = "0x187EDD690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x25CB2F0", Offset = "0x25C9EF0", VA = "0x1825CB2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		public bool ShowExitButton
		{
			[Cpp2IlInjected.Token(Token = "0x600099A")]
			[Cpp2IlInjected.Address(RVA = "0x7B00100", Offset = "0x7AFED00", VA = "0x187B00100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0x87F9DE0", Offset = "0x87F89E0", VA = "0x1887F9DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		public bool CanSoftExit
		{
			[Cpp2IlInjected.Token(Token = "0x600099C")]
			[Cpp2IlInjected.Address(RVA = "0xE1C0E0", Offset = "0xE1ACE0", VA = "0x180E1C0E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600099D")]
			[Cpp2IlInjected.Address(RVA = "0xE1C140", Offset = "0xE1AD40", VA = "0x180E1C140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000270")]
		public bool AllowInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x600099E")]
			[Cpp2IlInjected.Address(RVA = "0xE1C100", Offset = "0xE1AD00", VA = "0x180E1C100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600099F")]
			[Cpp2IlInjected.Address(RVA = "0xE1C160", Offset = "0xE1AD60", VA = "0x180E1C160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000271")]
		public bool TargetingHUD
		{
			[Cpp2IlInjected.Token(Token = "0x60009A0")]
			[Cpp2IlInjected.Address(RVA = "0x7D864D0", Offset = "0x7D850D0", VA = "0x187D864D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009A1")]
			[Cpp2IlInjected.Address(RVA = "0x7D864F0", Offset = "0x7D850F0", VA = "0x187D864F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public PopoverAnchor DialogAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60009A2")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D40", Offset = "0xBB2940", VA = "0x180BB3D40")]
			[CompilerGenerated]
			get
			{
				return default(PopoverAnchor);
			}
			[Cpp2IlInjected.Token(Token = "0x60009A3")]
			[Cpp2IlInjected.Address(RVA = "0x104E340", Offset = "0x104CF40", VA = "0x18104E340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public RectTransform TutorialHighlightTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60009A4")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A5")]
			[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public AQWXMNIFQIV OnStepCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60009A6")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		public AQWXMNIFQIV OnStepModified
		{
			[Cpp2IlInjected.Token(Token = "0x60009A7")]
			[Cpp2IlInjected.Address(RVA = "0xB14930", Offset = "0xB13530", VA = "0x180B14930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000276")]
		public AQWXMNIFQIV OnGoBack
		{
			[Cpp2IlInjected.Token(Token = "0x60009A8")]
			[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000277")]
		public bool ShouldShow
		{
			[Cpp2IlInjected.Token(Token = "0x60009A9")]
			[Cpp2IlInjected.Address(RVA = "0xF343C0", Offset = "0xF32FC0", VA = "0x180F343C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009AA")]
			[Cpp2IlInjected.Address(RVA = "0x111EE80", Offset = "0x111DA80", VA = "0x18111EE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000278")]
		public bool CompleteStepOnButtonPress
		{
			[Cpp2IlInjected.Token(Token = "0x60009AB")]
			[Cpp2IlInjected.Address(RVA = "0x139CB80", Offset = "0x139B780", VA = "0x18139CB80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009AC")]
			[Cpp2IlInjected.Address(RVA = "0x16D92B0", Offset = "0x16D7EB0", VA = "0x1816D92B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x87F9C30", Offset = "0x87F8830", VA = "0x1887F9C30")]
		public TutorialStep(string id, string title, string description, Sprite icon, string buttonText, bool showExitButton, bool canSoftExit, bool canGoBack, bool canGoForward, bool showCount, bool allowInteraction, bool targetingHud, PopoverAnchor dialogAnchor, bool shouldShow, bool completeStepOnButtonPress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x87F9A50", Offset = "0x87F8650", VA = "0x1887F9A50")]
		public void SetHighlightTarget(RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x87F9A10", Offset = "0x87F8610", VA = "0x1887F9A10")]
		public void SetCountText(string countText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x87F9710", Offset = "0x87F8310", VA = "0x1887F9710")]
		public void BeginStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x87F98D0", Offset = "0x87F84D0", VA = "0x1887F98D0")]
		private void DeactiveStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x87F98A0", Offset = "0x87F84A0", VA = "0x1887F98A0")]
		public void CompleteStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x87F99E0", Offset = "0x87F85E0", VA = "0x1887F99E0")]
		public void GoBack()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x87F9860", Offset = "0x87F8460", VA = "0x1887F9860")]
		public void ChangeTitle(string newTitle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x87F9820", Offset = "0x87F8420", VA = "0x1887F9820")]
		public void ChangeDescription(string newDescription)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[ViewModel]
	public class TutorialStepViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private sealed class <UpdateVisualsCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000697")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000698")]
			public TutorialStepViewModel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000289")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60009F9")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700028A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60009FB")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60009F6")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <UpdateVisualsCoroutine>d__68(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F8")]
			[Cpp2IlInjected.Address(RVA = "0x87FEAB0", Offset = "0x87FD6B0", VA = "0x1887FEAB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x87FEB70", Offset = "0x87FD770", VA = "0x1887FEB70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		[SerializeField]
		private RectTransform highlightArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		[SerializeField]
		private RectTransform dialogTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		[SerializeField]
		private float maskPadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		[SerializeField]
		private float additionalAnchorOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		[SerializeField]
		private PopoverCornerController popoverCornerController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private TutorialStep step;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private Coroutine updateVisualsCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private Canvas targetCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private string title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private string buttonText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private bool showMainButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private bool canInteractWithHighlightArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private bool showExitButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private bool showNextArrowButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private bool showBackArrowButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private string countText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private bool hasIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private Sprite icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private DataItem<string> TitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private DataItem<string> DescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private DataItem<string> ButtonTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private DataItem<bool> ShowMainButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private DataItem<bool> CanInteractWithHighlightAreaDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private DataItem<bool> ShowExitButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private DataItem<bool> ShowNextArrowButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private DataItem<bool> ShowBackArrowButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private DataItem<string> CountTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private DataItem<bool> HasIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private DataItem<Sprite> IconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private DataItemAction GoToNextStepDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private DataItemAction SkipTutorialDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private DataItemAction SoftExitTutorialDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private DataItemAction GoToPreviousStepDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000279")]
		private Camera screenCamera
		{
			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x87F93A0", Offset = "0x87F7FA0", VA = "0x1887F93A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027A")]
		private Canvas sourceCanvas
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x87F9440", Offset = "0x87F8040", VA = "0x1887F9440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027B")]
		private RectTransform sourceCanvasRect
		{
			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x87F93C0", Offset = "0x87F7FC0", VA = "0x1887F93C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x87F9690", Offset = "0x87F8290", VA = "0x1887F9690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027D")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x87F9560", Offset = "0x87F8160", VA = "0x1887F9560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027E")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string ButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x60009BD")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BE")]
			[Cpp2IlInjected.Address(RVA = "0x87F9460", Offset = "0x87F8060", VA = "0x1887F9460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027F")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool ShowMainButton
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0xB44430", Offset = "0xB43030", VA = "0x180B44430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x87F81B0", Offset = "0x87F6DB0", VA = "0x1887F81B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000280")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool CanInteractWithHighlightArea
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x25244F0", Offset = "0x25230F0", VA = "0x1825244F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0x87F8210", Offset = "0x87F6E10", VA = "0x1887F8210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000281")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool ShowExitButton
		{
			[Cpp2IlInjected.Token(Token = "0x60009C3")]
			[Cpp2IlInjected.Address(RVA = "0x19358F0", Offset = "0x19344F0", VA = "0x1819358F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009C4")]
			[Cpp2IlInjected.Address(RVA = "0x87F7FE0", Offset = "0x87F6BE0", VA = "0x1887F7FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000282")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool ShowNextArrowButton
		{
			[Cpp2IlInjected.Token(Token = "0x60009C5")]
			[Cpp2IlInjected.Address(RVA = "0x1935900", Offset = "0x1934500", VA = "0x181935900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009C6")]
			[Cpp2IlInjected.Address(RVA = "0x87F8040", Offset = "0x87F6C40", VA = "0x1887F8040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000283")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool ShowBackArrowButton
		{
			[Cpp2IlInjected.Token(Token = "0x60009C7")]
			[Cpp2IlInjected.Address(RVA = "0x226A2E0", Offset = "0x2268EE0", VA = "0x18226A2E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009C8")]
			[Cpp2IlInjected.Address(RVA = "0x87F80A0", Offset = "0x87F6CA0", VA = "0x1887F80A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000284")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string CountText
		{
			[Cpp2IlInjected.Token(Token = "0x60009C9")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0x87F94E0", Offset = "0x87F80E0", VA = "0x1887F94E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool HasIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0xBD43A0", Offset = "0xBD2FA0", VA = "0x180BD43A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009CC")]
			[Cpp2IlInjected.Address(RVA = "0x87F8110", Offset = "0x87F6D10", VA = "0x1887F8110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000286")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x60009CD")]
			[Cpp2IlInjected.Address(RVA = "0xB74D40", Offset = "0xB73940", VA = "0x180B74D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0x87F95E0", Offset = "0x87F81E0", VA = "0x1887F95E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000287")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60009DB")]
			[Cpp2IlInjected.Address(RVA = "0x87F9360", Offset = "0x87F7F60", VA = "0x1887F9360", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000288")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60009DC")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x87F6FA0", Offset = "0x87F5BA0", VA = "0x1887F6FA0")]
		[BindableAction(100, null)]
		public void GoToNextStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x87F7E80", Offset = "0x87F6A80", VA = "0x1887F7E80")]
		[BindableAction(101, null)]
		public void SkipTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x87F7F30", Offset = "0x87F6B30", VA = "0x1887F7F30")]
		[BindableAction(102, null)]
		public void SoftExitTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x87F6FF0", Offset = "0x87F5BF0", VA = "0x1887F6FF0")]
		[BindableAction(103, null)]
		public void GoToPreviousStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x87F7D50", Offset = "0x87F6950", VA = "0x1887F7D50")]
		public void Set(TutorialStep step)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x87F7CF0", Offset = "0x87F68F0", VA = "0x1887F7CF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0x87F7CB0", Offset = "0x87F68B0", VA = "0x1887F7CB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x87F7C00", Offset = "0x87F6800", VA = "0x1887F7C00", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x87F8270", Offset = "0x87F6E70", VA = "0x1887F8270")]
		private void UpdateStepData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0x87F8870", Offset = "0x87F7470", VA = "0x1887F8870")]
		[IteratorStateMachine(typeof(<UpdateVisualsCoroutine>d__68))]
		private IEnumerator UpdateVisualsCoroutine()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x87F88E0", Offset = "0x87F74E0", VA = "0x1887F88E0")]
		private void UpdateVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x87F5FA0", Offset = "0x87F4BA0", VA = "0x1887F5FA0")]
		private void AlignEdgeToEdge(RectTransform source, RectTransform target, TextAnchor sourceEdge, TextAnchor targetEdge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DD")]
		[Cpp2IlInjected.Address(RVA = "0x87F7040", Offset = "0x87F5C40", VA = "0x1887F7040", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0x87F68A0", Offset = "0x87F54A0", VA = "0x1887F68A0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x87F8F40", Offset = "0x87F7B40", VA = "0x1887F8F40")]
		public TutorialStepViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public class TutorialUIManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public static AQWXMNIFQIV OnCreated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public AQWXMNIFQIV OnDataUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private Dictionary<string, Dictionary<string, RectTransform>> tutorialTargets;

		[Cpp2IlInjected.Token(Token = "0x1700028B")]
		public static TutorialUIManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60009FC")]
			[Cpp2IlInjected.Address(RVA = "0x87FAD00", Offset = "0x87F9900", VA = "0x1887FAD00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0x87FAD50", Offset = "0x87F9950", VA = "0x1887FAD50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028C")]
		public Tutorial ActiveTutorial
		{
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009FF")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x87F9DF0", Offset = "0x87F89F0", VA = "0x1887F9DF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x87FA0B0", Offset = "0x87F8CB0", VA = "0x1887FA0B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x87F9F30", Offset = "0x87F8B30", VA = "0x1887F9F30")]
		private void ClearActiveTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x87F9F40", Offset = "0x87F8B40", VA = "0x1887F9F40")]
		private void ClearActiveTutorial(bool sendUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x87FA510", Offset = "0x87F9110", VA = "0x1887FA510")]
		public void StartTutorial(Tutorial tutorial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x87FA020", Offset = "0x87F8C20", VA = "0x1887FA020")]
		public void EndTutorial(bool showAgain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x87FA1E0", Offset = "0x87F8DE0", VA = "0x1887FA1E0")]
		public void RegisterTutorialTarget(string tutorialId, string stepId, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x87FA8E0", Offset = "0x87F94E0", VA = "0x1887FA8E0")]
		public void UnregisterTutorialTarget(string tutorialId, string stepId, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x87FAC40", Offset = "0x87F9840", VA = "0x1887FAC40")]
		public TutorialUIManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[ViewModel]
	public class TutorialUIViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		[SerializeField]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		[SerializeField]
		private TutorialStepViewModel tutorialStepViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private Tutorial activeTutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private bool isTutorialActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private DataItem<bool> IsTutorialActiveDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700028D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool IsTutorialActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0A")]
			[Cpp2IlInjected.Address(RVA = "0xB25ED0", Offset = "0xB24AD0", VA = "0x180B25ED0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0B")]
			[Cpp2IlInjected.Address(RVA = "0x87FB710", Offset = "0x87FA310", VA = "0x1887FB710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x87FB7F0", Offset = "0x87FA3F0", VA = "0x1887FB7F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x87FADC0", Offset = "0x87F99C0", VA = "0x1887FADC0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x87FB600", Offset = "0x87FA200", VA = "0x1887FB600")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x87FB100", Offset = "0x87F9D00", VA = "0x1887FB100", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x87FB580", Offset = "0x87FA180", VA = "0x1887FB580")]
		private void OnStepChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x87FB2A0", Offset = "0x87F9EA0", VA = "0x1887FB2A0")]
		private void OnManagerUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x87FAFC0", Offset = "0x87F9BC0", VA = "0x1887FAFC0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x87FAED0", Offset = "0x87F9AD0", VA = "0x1887FAED0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0x87FB770", Offset = "0x87FA370", VA = "0x1887FB770")]
		public TutorialUIViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CreateAssetMenu(fileName = "UITutorialData", menuName = "RecRoom/UI/UI Tutorial Data")]
	public class UITutorialData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		private class TutorialStepData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			public string Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A9")]
			public string Title;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006AA")]
			public string Description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006AB")]
			public Sprite OptionalIcon;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006AC")]
			public string ButtonText;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006AD")]
			public bool ShowButtonToGoForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x40006AE")]
			public bool ShowButtonToGoBack;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x40006AF")]
			public bool ShowCountText;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
			[Cpp2IlInjected.Token(Token = "0x40006B0")]
			public bool ShowExitButton;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40006B1")]
			public bool CanSoftExit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
			[Cpp2IlInjected.Token(Token = "0x40006B2")]
			public bool AllowInteraction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3E")]
			[Cpp2IlInjected.Token(Token = "0x40006B3")]
			public bool TargetingHUD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3F")]
			[Cpp2IlInjected.Token(Token = "0x40006B4")]
			public bool ShouldShow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006B5")]
			public bool CompleteStepOnButtonPress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40006B6")]
			public PopoverAnchor DialogAnchor;

			[Cpp2IlInjected.Token(Token = "0x6000A1A")]
			[Cpp2IlInjected.Address(RVA = "0x87F5CE0", Offset = "0x87F48E0", VA = "0x1887F5CE0")]
			public TutorialStep ToTutorialStep()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A1B")]
			[Cpp2IlInjected.Address(RVA = "0x87F5F00", Offset = "0x87F4B00", VA = "0x1887F5F00")]
			public TutorialStepData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		[SerializeField]
		private string id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		[SerializeField]
		private List<TutorialStepData> steps;

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0x87FF1E0", Offset = "0x87FDDE0", VA = "0x1887FF1E0")]
		public Tutorial GenerateTutorialFromData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x87FF420", Offset = "0x87FE020", VA = "0x1887FF420")]
		public UITutorialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public enum UILinkType
	{
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		Uri,
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		Tab,
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		Legacy
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public enum LegacyUIType
	{
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		Challenges,
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		Outfits
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public class LinkInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public UILinkType LinkType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		[ConditionalField("requiresUri")]
		public Uri LinkUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		[ConditionalField("LinkType", UILinkType.Tab)]
		public WatchTab LinkTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		[ConditionalField("LinkType", UILinkType.Legacy)]
		public LegacyUIType LegacyType;

		[Cpp2IlInjected.Token(Token = "0x17000290")]
		public bool IsLegacyUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x87F47C0", Offset = "0x87F33C0", VA = "0x1887F47C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0x87F4780", Offset = "0x87F3380", VA = "0x1887F4780")]
		public LinkInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CreateAssetMenu(fileName = "RouteLookup", menuName = "RecRoom/UI/Route Lookup")]
	public class UILinkLookup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		[FormerlySerializedAs("routeInfos")]
		[SerializeField]
		private List<LinkInfo> linkInfoList;

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x87FEEB0", Offset = "0x87FDAB0", VA = "0x1887FEEB0")]
		public bool TryGetLinkInfo(string alias, [Out] LinkInfo linkInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x87FF030", Offset = "0x87FDC30", VA = "0x1887FF030")]
		public bool TryGetUri(string routeId, [Out] Uri uri)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x87FEBB0", Offset = "0x87FD7B0", VA = "0x1887FEBB0")]
		public List<Uri> GetAllUri()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x87FED30", Offset = "0x87FD930", VA = "0x1887FED30")]
		public bool TryGetLegacyUIType(string routeId, [Out] LegacyUIType legacyUIType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0xDB83A0", Offset = "0xDB6FA0", VA = "0x180DB83A0")]
		public UILinkLookup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public class WatchViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private const string UnifiedUISessionIdKey = "unified_ui_session_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private IMenuManager _menuManager;

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x87FF4C0", Offset = "0x87FE0C0", VA = "0x1887FF4C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x87FF750", Offset = "0x87FE350", VA = "0x1887FF750", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x87FF820", Offset = "0x87FE420", VA = "0x1887FF820")]
		private void OnWatchMenuUnifiedSessionIdChanged(Guid watchMenuUnifiedSessionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0x87F4B60", Offset = "0x87F3760", VA = "0x1887F4B60")]
		public WatchViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class CanvasScreenSizeRefitter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		[SerializeField]
		private Canvas targetCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		[SerializeField]
		private float minPercentageOfScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		[SerializeField]
		private float maxPercentageOfScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		[SerializeField]
		private float offsetFromNearClipPlane;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		[SerializeField]
		private Camera lookAtCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		[SerializeField]
		private bool updateOnCameraMove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		[SerializeField]
		private bool useScreenSafeArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		[SerializeField]
		private bool forceWidthToFitScreen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private Vector2 cachedDimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private Vector2 cachedSafeAreaDimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private Vector3 cachedCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private Quaternion cachedCameraRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private float cachedFov;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private bool forceUpdate;

		[Cpp2IlInjected.Token(Token = "0x17000291")]
		public Canvas TargetCanvas
		{
			[Cpp2IlInjected.Token(Token = "0x6000A27")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000292")]
		public Camera TargetCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000293")]
		public float OffsetFromCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x87EDEB0", Offset = "0x87ECAB0", VA = "0x1887EDEB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000294")]
		private float cameraFov
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x87EDF40", Offset = "0x87ECB40", VA = "0x1887EDF40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000295")]
		private Vector3 cameraPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x87EDFD0", Offset = "0x87ECBD0", VA = "0x1887EDFD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000296")]
		private Quaternion cameraRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x87EE0B0", Offset = "0x87ECCB0", VA = "0x1887EE0B0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000297")]
		private RectTransform canvasRect
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x87EE180", Offset = "0x87ECD80", VA = "0x1887EE180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
		public void SetLookCamera(Camera lookAt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x87ED250", Offset = "0x87EBE50", VA = "0x1887ED250")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x87ED260", Offset = "0x87EBE60", VA = "0x1887ED260")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0x87ED980", Offset = "0x87EC580", VA = "0x1887ED980")]
		private void UpdateScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x87ED4E0", Offset = "0x87EC0E0", VA = "0x1887ED4E0")]
		public void PinToTopLeftOfScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x87EDD90", Offset = "0x87EC990", VA = "0x1887EDD90")]
		public CanvasScreenSizeRefitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[DisallowMultipleComponent]
	public class FocusableAllowedStateHelper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000EB")]
		public enum StateOverrideSource
		{
			[Cpp2IlInjected.Token(Token = "0x40006E2")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40006E3")]
			Statsig,
			[Cpp2IlInjected.Token(Token = "0x40006E4")]
			GameConfig
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private string defaultStatsigLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private string defaultStatsigParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		[SerializeField]
		private FocusableUI focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		[SerializeField]
		private StateOverrideSource overrideSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		[ConditionalVisibility("overrideSource", ConditionResultType.ShowIfEquals, 1)]
		[SerializeField]
		private string statsigLayerOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		[ConditionalVisibility("overrideSource", ConditionResultType.ShowIfEquals, 1)]
		[SerializeField]
		private string statsigParameterOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		[ConditionalVisibility("overrideSource", ConditionResultType.ShowIfEquals, 2)]
		[SerializeField]
		private string gameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		private EDFELDUZHLG configProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private NADKVDSFRLV statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private bool allowed;

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x87EE5E0", Offset = "0x87ED1E0", VA = "0x1887EE5E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x87EED00", Offset = "0x87ED900", VA = "0x1887EED00")]
		private void UpdateWhenStatsigReady()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x87EEA80", Offset = "0x87ED680", VA = "0x1887EEA80")]
		private void UpdateFromStatsig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0x87EEC50", Offset = "0x87ED850", VA = "0x1887EEC50")]
		private void UpdateWhenConfigReady()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x87EE870", Offset = "0x87ED470", VA = "0x1887EE870")]
		private void UpdateFromGameConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x87EEDB0", Offset = "0x87ED9B0", VA = "0x1887EEDB0")]
		public FocusableAllowedStateHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public class FocusStateHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Selectable focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public UnityEvent<BaseEventData> FocusGained;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public UnityEvent<BaseEventData> FocusLost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public UnityEvent OnEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public UnityEvent OnDisabled;

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x87EE1E0", Offset = "0x87ECDE0", VA = "0x1887EE1E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3B")]
		[Cpp2IlInjected.Address(RVA = "0x87EE320", Offset = "0x87ECF20", VA = "0x1887EE320")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x87EE450", Offset = "0x87ED050", VA = "0x1887EE450")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x87EE430", Offset = "0x87ED030", VA = "0x1887EE430")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x87EE470", Offset = "0x87ED070", VA = "0x1887EE470")]
		private void OnSelect(BaseEventData eventData, Selectable selectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3F")]
		[Cpp2IlInjected.Address(RVA = "0x87EE2C0", Offset = "0x87ECEC0", VA = "0x1887EE2C0")]
		private void OnDeselect(BaseEventData eventData, Selectable selectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x87EE4D0", Offset = "0x87ED0D0", VA = "0x1887EE4D0")]
		public FocusStateHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public class ImpressionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public Dictionary<string, int> IntData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public Dictionary<string, float> FloatData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public Dictionary<string, long> LongData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public Dictionary<string, string> StringData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public Dictionary<string, Guid> GuidData;

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x87EFB10", Offset = "0x87EE710", VA = "0x1887EFB10")]
		public bool TryGetValueAsString(string key, [Out] string valString, string format = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0x87EF8D0", Offset = "0x87EE4D0", VA = "0x1887EF8D0")]
		public NKNMZIGJWYR.SJCYWDVYQIW TryAddProperty(string key, NKNMZIGJWYR.SJCYWDVYQIW eventBuilder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x87EEF60", Offset = "0x87EDB60", VA = "0x1887EEF60")]
		public void ClearData(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x87EEE80", Offset = "0x87EDA80", VA = "0x1887EEE80")]
		public void ClearAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x87EF190", Offset = "0x87EDD90", VA = "0x1887EF190")]
		public void CopyData(ImpressionData copyTo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x87EFCE0", Offset = "0x87EE8E0", VA = "0x1887EFCE0")]
		public ImpressionData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public class ImpressionTracker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public enum PassToChildren
		{
			[Cpp2IlInjected.Token(Token = "0x4000710")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000711")]
			Enabled,
			[Cpp2IlInjected.Token(Token = "0x4000712")]
			EnabledRecursive
		}

		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		[Flags]
		internal enum ImpressionLogEvents
		{
			[Cpp2IlInjected.Token(Token = "0x4000714")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000715")]
			OnClickThrough = 1,
			[Cpp2IlInjected.Token(Token = "0x4000716")]
			OnNavigateToNewPage = 2,
			[Cpp2IlInjected.Token(Token = "0x4000717")]
			OnMenuClosed = 4,
			[Cpp2IlInjected.Token(Token = "0x4000718")]
			OnStopTracking = 8,
			[Cpp2IlInjected.Token(Token = "0x4000719")]
			OnDisable = 0x10
		}

		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		internal enum ImpressionLogConditions
		{
			[Cpp2IlInjected.Token(Token = "0x400071B")]
			NoConditions,
			[Cpp2IlInjected.Token(Token = "0x400071C")]
			OnlyWhenChildrenAreTracked
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[CompilerGenerated]
		private struct <FinishCleanUpAfterLoggingComplete>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400071D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400071E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400071F")]
			public Task logTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000720")]
			public ImpressionTracker <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0x87FD240", Offset = "0x87FBE40", VA = "0x1887FD240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A74")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private static UWDWRYBXQSO<ImpressionData> ImpressionDataPool;

		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private const float minSecondsForImpression = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private const string buttonLocationProperty = "buttonLocation";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		[SerializeField]
		private ImpressionLogEvents logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		[SerializeField]
		private ImpressionLogConditions logConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		[SerializeField]
		private VisibilityChecker visibilityChecker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		private ImpressionData impressionData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		private int idCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		private Dictionary<int, string> idToKeyLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		private Dictionary<string, int> keyToIdLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		private List<int> recordedKeys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private List<int> dataToRecordOnClickThrough;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private List<ImpressionTracker> children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private List<ImpressionTracker> tempChildrenWhileLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private Dictionary<int, PassToChildren> dataToPassToChildren;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private List<int> dataToCollateFromChildrenOnLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		private Dictionary<int, int> collatedDataToRecordUnderDifferentKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private List<int> dataToClearOnChildrenAfterLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private Dictionary<int, string> defaultValueLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private Dictionary<string, string> stringFormatLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private List<ImpressionData> childImpressionsNotYetLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private List<ImpressionData> allChildImpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private Uri pageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private bool pageUriActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private ImpressionTracker parentTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private bool parentTrackerInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private bool trackingActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private StringBuilder stringBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public Action<ImpressionTracker> ChildAdded;

		[Cpp2IlInjected.Token(Token = "0x17000298")]
		public bool AutoTrackWhenVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000A48")]
			[Cpp2IlInjected.Address(RVA = "0xC8A140", Offset = "0xC88D40", VA = "0x180C8A140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0xC88EE0", Offset = "0xC87AE0", VA = "0x180C88EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x87F4180", Offset = "0x87F2D80", VA = "0x1887F4180")]
		private void TryInitializeParentTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(RVA = "0x87EFE70", Offset = "0x87EEA70", VA = "0x1887EFE70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x87F18E0", Offset = "0x87F04E0", VA = "0x1887F18E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0x87F1770", Offset = "0x87F0370", VA = "0x1887F1770")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x87F1FA0", Offset = "0x87F0BA0", VA = "0x1887F1FA0")]
		public void SetDataToCollateFromChildrenOnLog(string key, string defaultValue, bool clearAfterLogging = false, string keyToRecordCollatedData = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x87F2140", Offset = "0x87F0D40", VA = "0x1887F2140")]
		public void SetDataToRecordOnClickThrough(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x87F0AB0", Offset = "0x87EF6B0", VA = "0x1887F0AB0")]
		public void LogImpression(bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x87F0660", Offset = "0x87EF260", VA = "0x1887F0660")]
		[AsyncStateMachine(typeof(<FinishCleanUpAfterLoggingComplete>d__45))]
		private void FinishCleanUpAfterLoggingComplete(Task logTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x87F3870", Offset = "0x87F2470", VA = "0x1887F3870")]
		public void StartTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0x87F3D60", Offset = "0x87F2960", VA = "0x1887F3D60")]
		public void StopTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0x87F3BC0", Offset = "0x87F27C0", VA = "0x1887F3BC0")]
		public void StopTrackingAndClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0x87F1C10", Offset = "0x87F0810", VA = "0x1887F1C10")]
		public void RecordClickThrough([Optional] string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0x87F31B0", Offset = "0x87F1DB0", VA = "0x1887F31B0")]
		public void SetString(string key, string data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x87F31E0", Offset = "0x87F1DE0", VA = "0x1887F31E0")]
		public void SetString(string key, string data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x87F2820", Offset = "0x87F1420", VA = "0x1887F2820")]
		public void SetGuid(string key, Guid data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0x87F2520", Offset = "0x87F1120", VA = "0x1887F2520")]
		public void SetGuid(string key, Guid data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x87F2B70", Offset = "0x87F1770", VA = "0x1887F2B70")]
		public void SetLong(string key, long data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x87F2BA0", Offset = "0x87F17A0", VA = "0x1887F2BA0")]
		public void SetLong(string key, long data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x87F2200", Offset = "0x87F0E00", VA = "0x1887F2200")]
		public void SetFloat(string key, float data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x87F2230", Offset = "0x87F0E30", VA = "0x1887F2230")]
		public void SetFloat(string key, float data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0x87F2E80", Offset = "0x87F1A80", VA = "0x1887F2E80")]
		public void SetObject(string key, object data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x87F2EB0", Offset = "0x87F1AB0", VA = "0x1887F2EB0")]
		public void SetObject(string key, object data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5F")]
		[Cpp2IlInjected.Address(RVA = "0x87F2B40", Offset = "0x87F1740", VA = "0x1887F2B40")]
		public void SetInt(string key, int data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x87F2860", Offset = "0x87F1460", VA = "0x1887F2860")]
		public void SetInt(string key, int data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x87F4100", Offset = "0x87F2D00", VA = "0x1887F4100")]
		public bool TryGetValueAsString(string key, [Out] string valString, string format = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x87F0060", Offset = "0x87EEC60", VA = "0x1887F0060")]
		public void ClearData(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x87F07C0", Offset = "0x87EF3C0", VA = "0x1887F07C0")]
		private int GetOrAddKeyId(string key)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x87F0730", Offset = "0x87EF330", VA = "0x1887F0730")]
		private string GetKey(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x87F1EE0", Offset = "0x87F0AE0", VA = "0x1887F1EE0")]
		private void RecordDuration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A66")]
		[Cpp2IlInjected.Address(RVA = "0x87F35F0", Offset = "0x87F21F0", VA = "0x1887F35F0")]
		private void StartTrackingChild(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x87F3C00", Offset = "0x87F2800", VA = "0x1887F3C00")]
		private void StopTrackingChild(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0x87F0950", Offset = "0x87EF550", VA = "0x1887F0950")]
		private void HandleVisibilityChanged(bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0x87F1640", Offset = "0x87F0240", VA = "0x1887F1640")]
		private void LogImpressionsOnBrowserModelNavigationComplete(PageWrapper destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x87F16E0", Offset = "0x87F02E0", VA = "0x1887F16E0")]
		private void LogImpressionsOnMenuClose(bool isOpen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x87F4270", Offset = "0x87F2E70", VA = "0x1887F4270")]
		private void TryResumeTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x87F1900", Offset = "0x87F0500", VA = "0x1887F1900")]
		private void PassDataToChild(string key, ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x87F0290", Offset = "0x87EEE90", VA = "0x1887F0290")]
		private string CollateDataFromChildren(int keyId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x87F34C0", Offset = "0x87F20C0", VA = "0x1887F34C0")]
		private int SortByElementIndex(ImpressionData lhs, ImpressionData rhs)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x87F0050", Offset = "0x87EEC50", VA = "0x1887F0050")]
		private bool CanLogEvent(ImpressionLogEvents logEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x87F08B0", Offset = "0x87EF4B0", VA = "0x1887F08B0")]
		private void GuaranteeImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x87F43A0", Offset = "0x87F2FA0", VA = "0x1887F43A0")]
		public ImpressionTracker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public class CanvasSizeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public Vector2 CanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public PlatformMask Platforms;

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public CanvasSizeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CreateAssetMenu(fileName = "PlatformDependentCanvasSizeConfig", menuName = "RecRoom/UI/Canvas Size Settings")]
	public class PlatformDependentCanvasSizeConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		[SerializeField]
		private Vector2 fallbackCanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		[SerializeField]
		private List<CanvasSizeData> canvasSizeSettings;

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x87F47D0", Offset = "0x87F33D0", VA = "0x1887F47D0")]
		public Vector2 GetSizeForPlatform(PlatformMask platform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A77")]
		[Cpp2IlInjected.Address(RVA = "0x87F4950", Offset = "0x87F3550", VA = "0x1887F4950")]
		public PlatformDependentCanvasSizeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public class RaycastIgnoreTransformFilter : MonoBehaviour, ICanvasRaycastFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		[SerializeField]
		private List<RectTransform> targetTransforms;

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x87F4D40", Offset = "0x87F3940", VA = "0x1887F4D40", Slot = "4")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public RaycastIgnoreTransformFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public class RectTransformAspectRatioResizer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		public enum ResizeDimension
		{
			[Cpp2IlInjected.Token(Token = "0x400072A")]
			Height,
			[Cpp2IlInjected.Token(Token = "0x400072B")]
			Width
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		[CompilerGenerated]
		private sealed class <FitResizeDimensionToAspectRatioAtEndOfFrame>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400072C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400072D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400072E")]
			public RectTransformAspectRatioResizer <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000299")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A82")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700029A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A84")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <FitResizeDimensionToAspectRatioAtEndOfFrame>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x87FD550", Offset = "0x87FC150", VA = "0x1887FD550", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x87FD5F0", Offset = "0x87FC1F0", VA = "0x1887FD5F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		[SerializeField]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		[SerializeField]
		private ResizeDimension resizeDimension;

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x87F53A0", Offset = "0x87F3FA0", VA = "0x1887F53A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x87F4EB0", Offset = "0x87F3AB0", VA = "0x1887F4EB0")]
		[IteratorStateMachine(typeof(<FitResizeDimensionToAspectRatioAtEndOfFrame>d__4))]
		private IEnumerator FitResizeDimensionToAspectRatioAtEndOfFrame()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x87F4F20", Offset = "0x87F3B20", VA = "0x1887F4F20")]
		private void FitResizeDimensionToAspectRatio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0x87F51E0", Offset = "0x87F3DE0", VA = "0x1887F51E0")]
		private float GetScreenAspectRatio(RectTransform rectTransform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public RectTransformAspectRatioResizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public static class RectTransformUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x87F5520", Offset = "0x87F4120", VA = "0x1887F5520")]
		public static void MatchSourceLossyScale(this Transform source, Transform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x87F5420", Offset = "0x87F4020", VA = "0x1887F5420")]
		public static Vector2 GetPivotFromAnchor(TextAnchor anchor)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class RRUIBinderAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public RRUIBinderAttribute()
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
