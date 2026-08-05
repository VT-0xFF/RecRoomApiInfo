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
using RecNet.AI;
using RecNet.Data;
using RecNet.Discovery;
using RecNet.Rooms;
using RecRoom.AI.RoomieAI;
using RecRoom.AI.RoomieAI.Personality;
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
	private Sprite JDVNPPVZBTD;

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
	private float CAUQFQMIKFT;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static Vector3[] ILBTFTJXFJI;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static Vector3[] EDUQVPBIZRY;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static List<Vector2> QIWVOLIDTSV;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static List<ushort> FVEWUOFOVHM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float GSFDPZFAKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD79AB0", Offset = "0xD788B0", VA = "0x180D79AB0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8322480", Offset = "0x8321280", VA = "0x188322480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool TIAOWZOGLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xF20E00", Offset = "0xF1FC00", VA = "0x180F20E00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8322500", Offset = "0x8321300", VA = "0x188322500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PNZGMHSFXFS
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xADBF60", Offset = "0xADAD60", VA = "0x180ADBF60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8322510", Offset = "0x8321310", VA = "0x188322510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x83221B0", Offset = "0x8320FB0", VA = "0x1883221B0")]
	public void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8322000", Offset = "0x8320E00", VA = "0x188322000")]
	public void ForceRegenerateSprite()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83220E0", Offset = "0x8320EE0", VA = "0x1883220E0")]
	private void GNIVBOVGAMV()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8322120", Offset = "0x8320F20", VA = "0x188322120")]
	private void NFVPRUKXOFY()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8321F90", Offset = "0x8320D90", VA = "0x188321F90")]
	private Vector4 CPCCILXKJMZ(Sprite a)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x83221F0", Offset = "0x8320FF0", VA = "0x1883221F0")]
	private Sprite XOAHRAMYGUN(Sprite a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8321400", Offset = "0x8320200", VA = "0x188321400")]
	private void BLPWQVFGAUH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8316E70", Offset = "0x8315C70", VA = "0x188316E70", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8327A10", Offset = "0x8326810", VA = "0x188327A10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RRUI.Data
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface GTWZHBYHGTX
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
		protected bool BYSMTXGGVND;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool SIIKWASRCMR
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xD79680", Offset = "0xD78480", VA = "0x180D79680", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xC330C0", Offset = "0xC31EC0", VA = "0x180C330C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public virtual float NPPHKQYLYJX
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xB1A860", Offset = "0xB19660", VA = "0x180B1A860", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public virtual float GKNKMXNUFYU
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xB21BD0", Offset = "0xB209D0", VA = "0x180B21BD0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD79670", Offset = "0xD78470", VA = "0x180D79670")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD79670", Offset = "0xD78470", VA = "0x180D79670")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x831C5D0", Offset = "0x831B3D0", VA = "0x18831C5D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x831C590", Offset = "0x831B390", VA = "0x18831C590", Slot = "8")]
		public virtual bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
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
		private List<RRUIGameObjectLayoutElement> UKQAIWBRMXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int SYWKBRHTGQO;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x831D5E0", Offset = "0x831C3E0", VA = "0x18831D5E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x831D4F0", Offset = "0x831C2F0", VA = "0x18831D4F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x831D4F0", Offset = "0x831C2F0", VA = "0x18831D4F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x831D200", Offset = "0x831C000", VA = "0x18831D200")]
		private void OAKDFYPPCSK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x831C8D0", Offset = "0x831B6D0", VA = "0x18831C8D0")]
		private float BRUFRHTCADZ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x831C900", Offset = "0x831B700", VA = "0x18831C900")]
		private bool KZCOORNPDZJ([Out] float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x831DCD0", Offset = "0x831CAD0", VA = "0x18831DCD0")]
		private bool YGRSKNKUEXS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x831D5F0", Offset = "0x831C3F0", VA = "0x18831D5F0")]
		private void XVZNGBGDOWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x831CB10", Offset = "0x831B910", VA = "0x18831CB10")]
		private void LBKBJAFGIAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x831C7C0", Offset = "0x831B5C0", VA = "0x18831C7C0")]
		private void AQRXVHBAIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x831D500", Offset = "0x831C300", VA = "0x18831D500")]
		[ContextMenu("RebuildLayout")]
		public void RebuildLayout()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x831DE00", Offset = "0x831CC00", VA = "0x18831DE00")]
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
		private Sprite THSAAULXHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool UEZFNGBCXGK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool SIIKWASRCMR
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x831DFD0", Offset = "0x831CDD0", VA = "0x18831DFD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override float NPPHKQYLYJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x831E0B0", Offset = "0x831CEB0", VA = "0x18831E0B0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override float GKNKMXNUFYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x831DF10", Offset = "0x831CD10", VA = "0x18831DF10", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x831DE90", Offset = "0x831CC90", VA = "0x18831DE90", Slot = "8")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
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
		private bool UEZFNGBCXGK;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool SIIKWASRCMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x831E250", Offset = "0x831D050", VA = "0x18831E250", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override float NPPHKQYLYJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x831E340", Offset = "0x831D140", VA = "0x18831E340", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override float GKNKMXNUFYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x831E1F0", Offset = "0x831CFF0", VA = "0x18831E1F0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x831E170", Offset = "0x831CF70", VA = "0x18831E170", Slot = "8")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public RRUIGameObjectTextLayoutElement()
		{
		}
	}
}
namespace RecRoom.Maker.MakerPenHUD
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface EQFCHVAQIEZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		IReadOnlyList<NBURWBPKKDU> URZRHQLLZUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action DOSUSMTKRSU;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface NBURWBPKKDU : IEquatable<NBURWBPKKDU>, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		SpawnableID YUHZNPLUTCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool JISIRQYBSTY
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string YUZOTVPXRXF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BXFWOOLOIVK(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<Texture2D> XBNQKHPCDTS();

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<Sprite> OUNQSVEMXJS();
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
	public interface UYBXJKUPTWR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool LRWDRHHDWAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		DQHMEXLDKHB LRPLVWPORKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool ETYNAUVJKMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool YYGOAEGMJGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool APWMWZDBQMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool WADUGIAODSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		OZAYXQWBYWY<bool> SPVEIMNAAWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool HNLLQBBFMMI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool YOIKPDNZHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool PMBXEHIIAAR
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool QOIWUAPQCBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ODUEMJUNKKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "17")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool QQCABMROHCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool JIGZSQTXEWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "23")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool LKXPEVZDXKW
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "25")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool JXUZKXTWDET
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "27")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		OZAYXQWBYWY<bool> PPHAORYUQNB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool YPWIHTUCSIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "30")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		int VAWIYBOOSQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "32")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		Sprite FUYFYWTGHUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		LCORSIUCACL UOTKSWLMSHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "36")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool CRURXSLCZZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool LLVQSMGRQZV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		OZAYXQWBYWY<bool> CLIIIBIDXRW
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "43")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		bool YRPBZHLGVOK
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "44")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		bool CGKZSPSIHDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "48")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		bool LAOEQDHJNOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "49")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		bool RIINTUDWXDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "55")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		OZAYXQWBYWY<bool> NOJDFQHOVEB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "57")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		bool CXRTBYQCRVX
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "59")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		OZAYXQWBYWY<bool> CXZVMMQXYTN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action FXOOMXGDMXR;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<int> HGLELSOBCBI;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action<bool> XLPAURNCHNI;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void GoToSelectMode();

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void GoToCreateMode();

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void OYNALITYTGO();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void FJEJDQVJMLA(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void VRWJRESBGVV(List<SpawnableID> a);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "38")]
		bool JORHGYNZIMW(SpawnableID a);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void ToggleColorPicker(bool open);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void LJLDNFHMNAO(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "50")]
		void BNFTMRXMJTY();

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void KMDOVZBMZGQ();

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "52")]
		void FWRPBZIUXJL();

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void SMBHIYWGCOT();

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void EndCursor();

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void YMXWSXXQSHG(Token a);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void QWEUCQDUJFE(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface LCORSIUCACL : EQFCHVAQIEZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OPDTAEDMERN(NBURWBPKKDU a, [Out] SpawnableID? b);

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PSNHEXCBCXI(int a);

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MOHUVBXOYSW(int a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FUSNYZVMSUG(IReadOnlyList<NBURWBPKKDU> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface UZTLNYWPAHA : IDisposable
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

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		FilterMode CIMCGNNQBZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		IReadOnlyList<JODUULFIMNR> PWKOUVYFGYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action RNHMIDWCECT;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GVBYMUDAOVB();

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YRISXXYVKNN();

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void IRAQYJSAUNU(string a = "", SortOption b = SortOption.None);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SOUGQBYVCTA();

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void HGUKPRANDJE();

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void HGUKPRANDJE(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface WYDKZTNYYNR : IEquatable<WYDKZTNYYNR>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool JISIRQYBSTY
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		bool PIQJQSSXIJH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool YFLHLMGWATI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		string SBBJHJACWTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool FSEUOJTOYKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool MECCYORYHEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action NLLFPICCGNT;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<bool> NTYNHLQJJNT(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool LQIKHTRRFEM(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void ClickActionButton();

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ClickInfoButton();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class JODUULFIMNR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public WYDKZTNYYNR NGAOVGJRGQG
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public SpawnableID ZAUMDXYOJBL
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x10DB500", Offset = "0x10DA300", VA = "0x1810DB500")]
			[CompilerGenerated]
			get
			{
				return default(SpawnableID);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x83169C0", Offset = "0x83157C0", VA = "0x1883169C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public abstract string YUZOTVPXRXF
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract NBURWBPKKDU PGYHHLOCJJJ();

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract Task<string> GCOHIZTKKUK();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract Task<Texture2D> XBNQKHPCDTS();

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void LCAHWSZBUEN();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected JODUULFIMNR()
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

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8321010", Offset = "0x831FE10", VA = "0x188321010")]
		public static SpawnableID CBPLHANEXAR(Guid? a)
		{
			return default(SpawnableID);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8321310", Offset = "0x8320110", VA = "0x188321310")]
		public static SpawnableID YVVREPPDLSA(long? a)
		{
			return default(SpawnableID);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8321330", Offset = "0x8320130", VA = "0x188321330")]
		private SpawnableID(SpawnableType type, Guid? spawnableToolGuid, long? inventionID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8321270", Offset = "0x8320070", VA = "0x188321270")]
		public bool VVOLMSCNGLS([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83211F0", Offset = "0x831FFF0", VA = "0x1883211F0")]
		public bool VPVITYMWMJF([Out] long a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8321030", Offset = "0x831FE30", VA = "0x188321030")]
		public static bool GFBRUTYEXQF(SpawnableID a, SpawnableID b)
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

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x830D170", Offset = "0x830BF70", VA = "0x18830D170", Slot = "20")]
		protected override void OnDataUpdated(AccountBadgeIconType dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x830D210", Offset = "0x830C010", VA = "0x18830D210")]
		public AccountBadgeIconBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RRUIBinder]
	public class AccountLeagueIconBinder : BaseBinder<AccountLeagueIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private AccountLeagueIconView accountLeagueView;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x830D3F0", Offset = "0x830C1F0", VA = "0x18830D3F0", Slot = "20")]
		protected override void OnDataUpdated(AccountLeagueIconType dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x830D490", Offset = "0x830C290", VA = "0x18830D490")]
		public AccountLeagueIconBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AccountRoleIconViewBinder : BaseBinder<AccountRoleIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private AccountRoleView accountRoleView;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x830EA10", Offset = "0x830D810", VA = "0x18830EA10", Slot = "20")]
		protected override void OnDataUpdated(AccountRoleIconType dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x830EAB0", Offset = "0x830D8B0", VA = "0x18830EAB0")]
		public AccountRoleIconViewBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RRUIBinder]
	public class ButtonFocusedActionBinder : BaseBinder<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum FocusedState
		{
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			Focused,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			Unfocused,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			Both
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private FocusedState focusedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool focused;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83132D0", Offset = "0x83120D0", VA = "0x1883132D0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8313560", Offset = "0x8312360", VA = "0x188313560", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "20")]
		protected override void OnDataUpdated(Action dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83133D0", Offset = "0x83121D0", VA = "0x1883133D0")]
		protected void OnButtonStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8313640", Offset = "0x8312440", VA = "0x188313640")]
		public ButtonFocusedActionBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[RRUIBinder]
	public class ButtonFocusedStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum FocusedState
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Focused,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Unfocused,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Both
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private BindDirection bindDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private FocusedState focusedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool focused;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8313680", Offset = "0x8312480", VA = "0x188313680", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8313D00", Offset = "0x8312B00", VA = "0x188313D00", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8313A70", Offset = "0x8312870", VA = "0x188313A70", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x83138D0", Offset = "0x83126D0", VA = "0x1883138D0")]
		protected void OnButtonStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8313A90", Offset = "0x8312890", VA = "0x188313A90")]
		protected void SyncButtonState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8313DE0", Offset = "0x8312BE0", VA = "0x188313DE0")]
		public ButtonFocusedStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[RRUIBinder]
	public class CardHighlightStyleAspectRatioBinder : BaseBinder<HighlightStyle>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public class HighlightStyleAspectRatio
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public HighlightStyle Style;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public float AspectRatio;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x29BA390", Offset = "0x29B9190", VA = "0x1829BA390")]
			public HighlightStyleAspectRatio()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private AspectRatioFitter aspectRatioFitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private RecNetRawImage recNetRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private List<HighlightStyleAspectRatio> aspectRatios;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8313E30", Offset = "0x8312C30", VA = "0x188313E30", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8314130", Offset = "0x8312F30", VA = "0x188314130", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8313F30", Offset = "0x8312D30", VA = "0x188313F30")]
		protected void OnImageLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "20")]
		protected override void OnDataUpdated(HighlightStyle dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8314230", Offset = "0x8313030", VA = "0x188314230")]
		public CardHighlightStyleAspectRatioBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[RRUIBinder]
	public class CarouselHeightBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private List<LayoutElement> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private LayoutElementSizeBinder.LayoutElementSizeTarget targetSize;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8314270", Offset = "0x8313070", VA = "0x188314270", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8314390", Offset = "0x8313190", VA = "0x188314390", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8314680", Offset = "0x8313480", VA = "0x188314680")]
		public CarouselHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RRUIBinder]
	public class CarouselItemSizeBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83146C0", Offset = "0x83134C0", VA = "0x1883146C0", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8314770", Offset = "0x8313570", VA = "0x188314770")]
		public CarouselItemSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[RRUIBinder]
	public class CarouselItemWidthHeightBinder : BaseBinder<Vector2>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x83147B0", Offset = "0x83135B0", VA = "0x1883147B0", Slot = "20")]
		protected override void OnDataUpdated(Vector2 dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8314860", Offset = "0x8313660", VA = "0x188314860")]
		public CarouselItemWidthHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[RRUIBinder]
	public class CarouselRowCountBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x83148A0", Offset = "0x83136A0", VA = "0x1883148A0", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8314940", Offset = "0x8313740", VA = "0x188314940")]
		public CarouselRowCountBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[RRUIBinder]
	public class ConditionalPrefabSpawnBinder : BaseBinder<bool>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <LoadPrefab>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public ConditionalPrefabSpawnBinder <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8325F00", Offset = "0x8324D00", VA = "0x188325F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private MultiPrefabSpawner prefabSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private AssetReference prefabReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private bool prependSpawnedObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private NMFGCGLVGPZ<GameObject> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8314980", Offset = "0x8313780", VA = "0x188314980", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8314BA0", Offset = "0x83139A0", VA = "0x188314BA0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8314D40", Offset = "0x8313B40", VA = "0x188314D40", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8314AF0", Offset = "0x83138F0", VA = "0x188314AF0")]
		[AsyncStateMachine(typeof(<LoadPrefab>d__8))]
		private void LoadPrefab()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		private void OnPopulateInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		private void OnCleanupInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8314EF0", Offset = "0x8313CF0", VA = "0x188314EF0")]
		public ConditionalPrefabSpawnBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[RRUIBinder]
	public class DynamicUIElementsBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private DynamicUIModel dynamicUIModel;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8314F30", Offset = "0x8313D30", VA = "0x188314F30", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8314FD0", Offset = "0x8313DD0", VA = "0x188314FD0")]
		public DynamicUIElementsBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[RRUIBinder]
	public class HideableBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8315010", Offset = "0x8313E10", VA = "0x188315010", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x83150B0", Offset = "0x8313EB0", VA = "0x1883150B0")]
		public HideableBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RRUIBinder]
	public class HtmlColorStringToColorBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private List<Image> targetList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Color htmlColor;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83150F0", Offset = "0x8313EF0", VA = "0x1883150F0", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x83152B0", Offset = "0x83140B0", VA = "0x1883152B0")]
		public HtmlColorStringToColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[RRUIBinder]
	public class HydrationStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private List<HydrateBase> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x83152F0", Offset = "0x83140F0", VA = "0x1883152F0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8315420", Offset = "0x8314220", VA = "0x188315420")]
		public HydrationStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RRUIBinder]
	public class ImageKeyBinder : BaseBinder<string>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct <LoadImage>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public ImageKeyBinder <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AssetReference assetReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private AsyncOperationHandle<Sprite> <handle>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private TaskAwaiter<Sprite> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8325C40", Offset = "0x8324A40", VA = "0x188325C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private Image targetImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private AssetReferenceLookup imageKeyLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private AssetReference currentAsset;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8315540", Offset = "0x8314340", VA = "0x188315540", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x83156F0", Offset = "0x83144F0", VA = "0x1883156F0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x83156A0", Offset = "0x83144A0", VA = "0x1883156A0")]
		private void ReleaseAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8315460", Offset = "0x8314260", VA = "0x188315460")]
		[AsyncStateMachine(typeof(<LoadImage>d__6))]
		private void LoadImage(AssetReference assetReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8315750", Offset = "0x8314550", VA = "0x188315750")]
		public ImageKeyBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[RRUIBinder]
	public class ImposterImageBinder : BaseBinder<RQQQIGIPNON>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private ImposterRawImage imposterImage;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8315790", Offset = "0x8314590", VA = "0x188315790", Slot = "20")]
		protected override void OnDataUpdated(RQQQIGIPNON dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8315820", Offset = "0x8314620", VA = "0x188315820")]
		public ImposterImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[RRUIBinder]
	public class InfiniteListBinder : BaseBinder<DataList>, UQVNBKUYUGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		protected InfiniteListViewControllerBase infiniteList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		protected GameObject defaultPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int listId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private HashSet<int> loadedItems;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xFABA20", Offset = "0xFAA820", VA = "0x180FABA20", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1AC10A0", Offset = "0x1ABFEA0", VA = "0x181AC10A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public OZAYXQWBYWY<int> OnItemAtIndexLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public IReadOnlyCollection<KKIMMECWVZL> VisibleItems
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8316480", Offset = "0x8315280", VA = "0x188316480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83158C0", Offset = "0x83146C0", VA = "0x1883158C0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8315950", Offset = "0x8314750", VA = "0x188315950", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8315E30", Offset = "0x8314C30", VA = "0x188315E30")]
		protected void RefreshActiveItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8315D30", Offset = "0x8314B30", VA = "0x188315D30", Slot = "27")]
		public virtual void OnItemVisible(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8315CA0", Offset = "0x8314AA0", VA = "0x188315CA0", Slot = "28")]
		public virtual void OnItemRefresh(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8315AA0", Offset = "0x83148A0", VA = "0x188315AA0", Slot = "29")]
		public virtual void OnItemHidden(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150", Slot = "30")]
		public virtual GameObject GetPrefabForIndex(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8315860", Offset = "0x8314660", VA = "0x188315860", Slot = "31")]
		public virtual bool IsItemLoaded(InfiniteListDataItem item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8315BB0", Offset = "0x83149B0", VA = "0x188315BB0")]
		protected void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8316390", Offset = "0x8315190", VA = "0x188316390")]
		public InfiniteListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[RRUIBinder]
	public class LimitedCapacityListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		protected List<BaseLocalViewModel> limitedListObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private GameObject overflowIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private TMP_Text overflowText;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x83169E0", Offset = "0x83157E0", VA = "0x1883169E0", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8316E30", Offset = "0x8315C30", VA = "0x188316E30")]
		public LimitedCapacityListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RRUIBinder]
	public class MultiPrefabSpawnerListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private MultiPrefabSpawner multiPrefabSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private GameObject defaultPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int listId;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x83177D0", Offset = "0x83165D0", VA = "0x1883177D0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8317680", Offset = "0x8316480", VA = "0x188317680", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8317A20", Offset = "0x8316820", VA = "0x188317A20", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8317860", Offset = "0x8316660", VA = "0x188317860", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8317910", Offset = "0x8316710", VA = "0x188317910", Slot = "21")]
		protected virtual void OnInstanceCleanupEvent(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8317980", Offset = "0x8316780", VA = "0x188317980", Slot = "22")]
		protected virtual void OnInstanceSpawnedEvent(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8317B50", Offset = "0x8316950", VA = "0x188317B50")]
		public MultiPrefabSpawnerListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RRUIBinder]
	public class NavigationModeSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private List<Selectable> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private Navigation activeNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private Navigation inactiveNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8317D30", Offset = "0x8316B30", VA = "0x188317D30", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8317F30", Offset = "0x8316D30", VA = "0x188317F30")]
		public NavigationModeSwapBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PageNavigationHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private Uri destinationUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private string analyticsButtonName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8318470", Offset = "0x8317270", VA = "0x188318470")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x83186C0", Offset = "0x83174C0", VA = "0x1883186C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8318600", Offset = "0x8317400", VA = "0x188318600")]
		public void NavigateToPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8318920", Offset = "0x8317720", VA = "0x188318920")]
		public void SetUriData(string uriDataKey, int data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8318820", Offset = "0x8317620", VA = "0x188318820")]
		public void SetUriData(string uriDataKey, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x83188A0", Offset = "0x83176A0", VA = "0x1883188A0")]
		public void SetUriData(string uriDataKey, float data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8318790", Offset = "0x8317590", VA = "0x188318790")]
		public void SetUriData(string uriDataKey, Guid data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x83189A0", Offset = "0x83177A0", VA = "0x1883189A0")]
		public PageNavigationHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class PageNavigationHelperUriDataBinder : BaseBinder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private PageNavigationHelper target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private string uriDataKey;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8317F70", Offset = "0x8316D70", VA = "0x188317F70", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8318430", Offset = "0x8317230", VA = "0x188318430")]
		public PageNavigationHelperUriDataBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[RRUIBinder]
	public class PlayerColorSpriteBinder : BaseBinder<IPlayerColor>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private SpriteRenderer target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private IPlayerUIBridge.PlayerColorType _colorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private Color defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		[ConditionalField("_colorType", new object[] { 3, 5 })]
		private Color customColor;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x83189E0", Offset = "0x83177E0", VA = "0x1883189E0", Slot = "20")]
		protected override void OnDataUpdated(IPlayerColor dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8318B80", Offset = "0x8317980", VA = "0x188318B80")]
		public PlayerColorSpriteBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RRUIBinder]
	public class PlayerColorTextBinder : BaseBinder<IPlayerColor>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private TMP_Text target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private IPlayerUIBridge.PlayerColorType _colorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private Color defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		[ConditionalField("_colorType", new object[] { 3, 5 })]
		private Color customTextColor;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8318BD0", Offset = "0x83179D0", VA = "0x188318BD0", Slot = "20")]
		protected override void OnDataUpdated(IPlayerColor dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8318DA0", Offset = "0x8317BA0", VA = "0x188318DA0")]
		public PlayerColorTextBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RRUIBinder]
	public class RecNetRawImageBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private RecNetRawImage target;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x831E3A0", Offset = "0x831D1A0", VA = "0x18831E3A0", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x831E430", Offset = "0x831D230", VA = "0x18831E430")]
		public RecNetRawImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RRUIBinder]
	public class RectTransformHeightSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private List<RectTransform> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private float activeHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private float inactiveHeight;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8320950", Offset = "0x831F750", VA = "0x188320950", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8320AC0", Offset = "0x831F8C0", VA = "0x188320AC0")]
		public RectTransformHeightSwapBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RRUIBinder]
	public class RoomSourceUriLinkButtonBinder : BaseBinder<RoomListQueryData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Uri targetUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private bool useQueryDataInUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[ConditionalField("useQueryDataInUri")]
		[SerializeField]
		private bool overrideQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private RoomListQueryData queryDataOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[ConditionalField("overrideLoadSceneSource")]
		[SerializeField]
		private LoadSceneSources loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8320B00", Offset = "0x831F900", VA = "0x188320B00", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8320EF0", Offset = "0x831FCF0", VA = "0x188320EF0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "20")]
		protected override void OnDataUpdated(RoomListQueryData dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8320C90", Offset = "0x831FA90", VA = "0x188320C90")]
		private void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8320FD0", Offset = "0x831FDD0", VA = "0x188320FD0")]
		public RoomSourceUriLinkButtonBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[RRUIBinder]
	public class StringToWidgetWrapperBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private WidgetWrapperViewModel widgetWrapper;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8322540", Offset = "0x8321340", VA = "0x188322540", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8322600", Offset = "0x8321400", VA = "0x188322600")]
		public StringToWidgetWrapperBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RRUIBinder]
	public class VirtualizedScrollRectListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int listId;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8327110", Offset = "0x8325F10", VA = "0x188327110", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8327370", Offset = "0x8326170", VA = "0x188327370", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8327400", Offset = "0x8326200", VA = "0x188327400", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8327770", Offset = "0x8326570", VA = "0x188327770", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8327670", Offset = "0x8326470", VA = "0x188327670", Slot = "21")]
		protected virtual void OnItemVisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x83275D0", Offset = "0x83263D0", VA = "0x1883275D0", Slot = "22")]
		protected virtual void OnItemRefresh(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x83274B0", Offset = "0x83262B0", VA = "0x1883274B0", Slot = "23")]
		protected virtual void OnItemInvisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8327520", Offset = "0x8326320", VA = "0x188327520")]
		private void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x83279C0", Offset = "0x83267C0", VA = "0x1883279C0")]
		public VirtualizedScrollRectListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface IIconConfig
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface IIconData<T> where T : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetConfig(T enumValue, [Out] IIconConfig config);
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public abstract class EnumIconDataViewBase<T, U> : MonoBehaviour where T : Enum where U : IIconData<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private T defaultIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private U iconData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Header("Image Targets")]
		[SerializeField]
		protected List<Image> backgroundOutlineImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		protected List<Image> backgroundFillImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		protected List<Image> iconOutlineImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		protected List<Image> iconFillImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Header("Sprite Renderer Targets")]
		[SerializeField]
		protected List<SpriteRenderer> backgroundOutlineSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		protected List<SpriteRenderer> backgroundFillSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		protected List<SpriteRenderer> iconOutlineSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		protected List<SpriteRenderer> iconFillSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private T iconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private bool iconTypeSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private List<NMFGCGLVGPZ<Sprite>> resourceHandles;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4A73DA0", Offset = "0x4A72BA0", VA = "0x184A73DA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4A731C0", Offset = "0x4A71FC0", VA = "0x184A731C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4A73390", Offset = "0x4A72190", VA = "0x184A73390")]
		private void ReleaseSpriteHandles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4A734F0", Offset = "0x4A722F0", VA = "0x184A734F0")]
		public void SetIconType(T newIconType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4A73F20", Offset = "0x4A72D20", VA = "0x184A73F20")]
		private void UpdateIcons()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4A72FB0", Offset = "0x4A71DB0", VA = "0x184A72FB0")]
		private void LoadAndSetupSprite(AssetReference spriteReference, List<Image> imageTargets, List<SpriteRenderer> spriteRendererTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4A73620", Offset = "0x4A72420", VA = "0x184A73620")]
		private void SetImageTargetsToIcon(List<Image> targets, Sprite icon)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4A739E0", Offset = "0x4A727E0", VA = "0x184A739E0")]
		private void SetSpriteRendererTargetsToIcon(List<SpriteRenderer> targets, Sprite icon)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4A74660", Offset = "0x4A73460", VA = "0x184A74660")]
		protected EnumIconDataViewBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class MakerPenHUDNavigationInputState
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public class NavInputState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public float MinHoldDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public float HoldDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public float LastHoldDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public bool WasHeldLastFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public OZAYXQWBYWY<NavInputState> NavInputStateChanged;

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public bool IsPressed
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x13E8BC0", Offset = "0x13E79C0", VA = "0x1813E8BC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public bool IsHeld
			{
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x8317D10", Offset = "0x8316B10", VA = "0x188317D10")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public bool WasHeldLastPress
			{
				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x8317D20", Offset = "0x8316B20", VA = "0x188317D20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8317C10", Offset = "0x8316A10", VA = "0x188317C10")]
			public void UpdateHold(float holdDuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8317BA0", Offset = "0x83169A0", VA = "0x188317BA0")]
			public void StopHold()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8317C80", Offset = "0x8316A80", VA = "0x188317C80")]
			public NavInputState()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private Dictionary<MakerPenHUDNavInputType, NavInputState> navInputStates;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8317510", Offset = "0x8316310", VA = "0x188317510")]
		public MakerPenHUDNavigationInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x83173B0", Offset = "0x83161B0", VA = "0x1883173B0")]
		public void Initialize(float minHoldDuration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x83174A0", Offset = "0x83162A0", VA = "0x1883174A0")]
		public bool TryGetNavInputState(MakerPenHUDNavInputType inputType, [Out] NavInputState navInputState)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8317430", Offset = "0x8316230", VA = "0x188317430")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public abstract class BaseBindableObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<string> OnObjectChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8313170", Offset = "0x8311F70", VA = "0x188313170", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8313220", Offset = "0x8312020", VA = "0x188313220", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8313150", Offset = "0x8311F50", VA = "0x188313150")]
		protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected BaseBindableObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface IInterfacesTeamHelper
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool RRUIPerfEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		double RRUIPerfSlowFramesSec
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public enum MakerPenHUDNavInputType
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		LeftModifier,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		RightModifier,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		MAX
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface IMakerPenHUDBridge
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		Guid MakerPenSessionGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		MakerPenHUDNavigationInputState NavigationInputState
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool UseCuratedControls
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		DQHMEXLDKHB UseCuratedControlsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		string InputModeForAnalytics
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool IsUndoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		bool IsRedoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		DQHMEXLDKHB UndoStackEntriesChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		bool OnCreateMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		bool OnSelectMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		string ToolDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool IsRRUIPageContainerEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(Slot = "26")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		OZAYXQWBYWY<bool> RRUIPageContainerEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		bool OnCloneMode
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		bool OnConfigMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool OnDeleteMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		bool InTransformModeAndMoveOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		bool InTransformModeAndRotateOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool InTransformModeAndScaleOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool IsDeleteAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool IsRecolorMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		bool ShowColorPicker
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(Slot = "38")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		OZAYXQWBYWY<bool> ColorPickerToggled
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		bool IsAdjustModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(Slot = "40")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		bool IsPrecisionModifierModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		OZAYXQWBYWY<bool> StampModeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(Slot = "59")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		bool PaletteIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		UZTLNYWPAHA PaletteDataStore
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(Slot = "61")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		bool IsPaletteSearchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(Slot = "78")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		string CurrentPaletteSearchString
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(Slot = "82")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		CategoriesNestedListConfig Config
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "87")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		JODUULFIMNR ToFocusOnReturnToPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "89")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		NGXBIJEPJWX Configurable
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "90")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		DQHMEXLDKHB MakerPenConfigMenuDataChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "91")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		bool IsCursorActive
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "94")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		OZAYXQWBYWY<bool> CursorActiveChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "95")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		bool IsInSubMenu
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(Slot = "97")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		OZAYXQWBYWY<bool> IsInSubMenuChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "98")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		bool ShouldUseButtonNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "99")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		bool ButtonShortcutsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "100")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		DQHMEXLDKHB ButtonShortcutsEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "101")]
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

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void TriggerUndo();

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void TriggerRedo();

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void GoToCreateMode();

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void GoToSelectMode();

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void EnterDeleteMode();

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void RequestAdjustMode();

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void ToggleCloneMode();

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void ToggleMoveMode();

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void ToggleRotateMode();

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void ToggleScaleMode();

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void ToggleConfigMode();

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void PressRecolorButton();

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void ExitRecolorMode();

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void ChangeColor(Enum shapeColor, int index);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void OnConfigButtonPressed();

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "52")]
		bool IsColorSelected(Enum colorId);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void SelectHotbarSlot(int index);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void RemoveHotbarItem(int index);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void TogglePalette();

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "65")]
		void ShowOrHideGlobalToolbarAccordingToPaletteState();

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "68")]
		void PaletteObjectToggleSelected(JODUULFIMNR placable);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "69")]
		void PaletteObjectToggleFavorited(JODUULFIMNR placable);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "70")]
		bool DoesHotbarContainPaletteObject(JODUULFIMNR placable);

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "71")]
		void RequestMakerPenHUDMenuToggleIfNeeded(bool open);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "81")]
		void TogglePaletteSearch();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "85")]
		void SetSearchString(string newSearchString);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "86")]
		void CategoryFilterChanged(CategoriesFilter filter);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "92")]
		void PresentTypedDialog(DialogListModel dialogListModel, DialogType dialogType, WLXQNZZPBQO dialogData);

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "93")]
		IReadOnlyList<OJLHAOSJPLF> GetObjectPropertyDynamicUIData(NGXBIJEPJWX configurable, bool isQuickConfig);

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void EndCursor();
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class MakerPenHUDAnalyticsKeys
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static string SessionKey;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static string InputModeKey;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public static string InputMode_Cursor;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public static string InputMode_ButtonNav;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public static string InputMode_Touch;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public static string GlobalBarName;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static string SelectBarName;

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static string PrevSelectModeKey;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public static string SelectModeKey;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public static string PrecisionMode_Move;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static string PrecisionMode_Rotate;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static string PrecisionMode_Scale;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static string CreateBarName;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static string PaletteMRUSlotType;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static string RemovePaletteMRUSlotType;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public static string PaletteMRUSlotObjectTypeKey;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static string PaletteMRUSlot_Prop;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static string PaletteMRUSlot_Invention;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static string StampModeKey;
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public enum MenuType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		AppNav,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Watch
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public interface IMenuManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		Guid WatchMenuUnifiedSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		OZAYXQWBYWY<Guid> WatchMenuUnifiedSessionIdChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		MenuType LastClosedMenuType
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		float LastClosedMenuTime
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class InterfacesTeamHelper : IInterfacesTeamHelper
	{
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static string RRUI_PERF_EXPERIMENT_NAME;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static string RRUI_PERF_ENABLED_PARAMETER_NAME;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static string RRUI_PERF_SLOW_FRAMES_PARAMETER_NAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private DINTWZBUUTH statSigProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool? rruiPerfEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private double? slowFramesSec;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool RRUIPerfEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x83166A0", Offset = "0x83154A0", VA = "0x1883166A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public double RRUIPerfSlowFramesSec
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8316830", Offset = "0x8315630", VA = "0x188316830", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x83164D0", Offset = "0x83152D0", VA = "0x1883164D0")]
		[FDNTPBIGLET.Root.GameOnly]
		internal static void InitializeOnLoad(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		[UnityEngine.Scripting.Preserve]
		internal InterfacesTeamHelper([Inject(null)][NotNull] DINTWZBUUTH statSigProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public interface IOrderedRenderable
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		bool RenderInCarouselOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		bool AllowRender
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		bool HasRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		bool RequiresRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public interface IRoomieBridge
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task UpdateUserKnowledgeSystemMessage(CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public interface IRoomStoreCategory
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		List<IUnifiedRoomStoreItem> Items
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public interface IRRUIvNextBridge
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		PlatformType CurrentPlatformType
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		bool InVRDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		bool InScreensDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		Guid ScreensMenuUnifiedSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		bool IsDebugBuild
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		long LocalRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		RoomDetailsDTO LocalRoomDetails
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		bool CurrentRoomInstanceIsPrivate
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		bool Discovery_ShouldDefaultPublicInstance
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		bool Discovery_ShouldDefaultPrivateInstance
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		int Discovery_NewDataTokenThresholdDays
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		bool Discovery_ShowPublishStateDataToken
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		string Discovery_StoreItemCardVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		int Discovery_LimitedBadgeThresholdDays
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		bool Discovery_LimitedBadgeQolDetails
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		bool Discovery_LimitedBadgeEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		bool WatchMenuProjector_IsWatchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		bool WatchMenuProject_IsUIOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		bool WatchMenuProjector_IsMenuAnimationVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		bool ToolMenuProjector_IsMenuOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		bool ToolMenuProjector_IsMenuAnimationVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		int UnreadWatchNotificationCount
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		bool HideWatchNavBar
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "24")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		Camera UICamera
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		Camera ScreenModeCamera
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		bool IsUsingTouchInput
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		Action InputMethodChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(Slot = "29")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		DQHMEXLDKHB BrowserModel_RequestAppNavMenu
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(Slot = "52")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Vector2? Discovery_GetHighlightStyleCardOverride(HighlightStyle style);

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "17")]
		string TimeSpanExtensions_GetFormatedTimeString(TimeSpan timeSpan, bool useShortUnits);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "30")]
		T GetConfigValue<T>(string key);

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void OpenWatchMenu();

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void CloseWatchMenu();

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void CloseActiveToolMenu();

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void NavigateToLink(LinkInfo linkInfo, bool isPortalButton = false);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void GuaranteeWatchStateAndGoTo(BrowserModel browserModel, Route route);

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void GuaranteeWatchStateAndGoTo(BrowserModel browserModel, Uri uri);

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void OpenLegacyUI(LegacyUIType legacyUIType);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void NavigateToUriWithRoomSourceData(BrowserModel browserModel, Uri destination, RoomListQueryData queryData, bool useLoadSceneSourceOverride = false, LoadSceneSources sourceOverride = LoadSceneSources.NOT_SET);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "39")]
		string GetFriendlyListNameFromRoomsConfig(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "40")]
		string GetSourceStringForQueryData(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "41")]
		bool PopulateRoomListQueryDataFromSourceInfo(string source, string sourceMetadata, RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "42")]
		HighlightStyle GetHighlightStyleFromDiscoveryTeamHelper(string sourceLabelText, [Optional] string sizePerPlatformFromMetadata);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task LogImpressionEvent(GBKDVYHUEHJ.EGWGLKTRFNS impressionEvent);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "44")]
		bool IsBrowserModelOnRootScreen(BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "45")]
		bool TryGetMenuOpenAction([Out] OZAYXQWBYWY<bool> menuOpenAction);

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void TryTrackLatencyForBrowserRoute(string routeString);

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "47")]
		Task<bool> ShowRoomPlayActionDialog(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task<SubRoomDTO> ShowChooseSubRoomDialog(RoomDetailsDTO roomDetails, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void ForceAcceptRoomWarnings(RoomDTO room);

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "50")]
		Task ShowTwoButtonMessageDialog(DialogListModel dialogListModel, JCVIMRUNLCW dialogData, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void Discovery_HackyTryShowUpdateTheAppDialog(BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "53")]
		Task EvictAllFromDorm();

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void ShowRoomReportDialog(long roomId, string sanitizedFriendlyName);

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void ApplyBrowserModelImpressionData(ImpressionTracker impressionTracker, BrowserModel browserModel, string nullBrowserRouteProperty = "appnav/quickaccess");

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<RenderTexture> GenerateTextureForLocalAvatarAsync(CancellationToken token, int width = -1, int height = -1);

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void AddNotificationRestriction(object token);

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void RemoveNotificationRestriction(object token);

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void OpenManageRRPlusMembershipPage();

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "60")]
		bool CanLocalPlayerChatWith(XTOYSWYWUAV account);

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "61")]
		void GoToChatPage(int accountId, ChatTelemetrySource chatTelemetrySource);

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "62")]
		void ShowEnumPickerDialog<TEnum>(DialogListModel dialogListModel, string title, Func<TEnum, string> nameGetter, Func<TEnum> selectedGetter, Action<TEnum> selectedSetter) where TEnum : Enum;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface IRRUIvNextConsumableBridge
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public enum ConsumableCategory
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			All,
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			Food,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			Other
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<QFRCSVHRAFM> OnActiveConsumableChanged;

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		event Action<QFRCSVHRAFM> OnPurchasedConsumableChanged;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		List<QFRCSVHRAFM> GetLatestPurchasedNonTransferableConsumables(ConsumableCategory category, bool excludeRoomieActivated);

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UseConsumable(QFRCSVHRAFM consumable);

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "6")]
		RQQQIGIPNON GetConsumableImposterRequest(QFRCSVHRAFM consumable);

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IsConsumableSpawned(QFRCSVHRAFM consumable);

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "8")]
		int GetTotalConsumableCount(QFRCSVHRAFM consumable);
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public interface IRRUIvNextRoomCategoryBridge
	{
		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		string DefaultGameConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		bool ShouldHideShowMeAllRooms
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		bool ShouldHideChipBar
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SelectRoomCategory(GTWZHBYHGTX category, Route route, LoadSceneSources loadSceneSource, BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<IReadOnlyList<GTWZHBYHGTX>> GetRoomCategoriesForPageSource(CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<(IReadOnlyList<GTWZHBYHGTX>, string)> GetRoomCategoriesForCuratedList(string sourceMetadata, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<GTWZHBYHGTX> GetRoomCategoriesForConfig(string gameConfigKey);
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public interface IRRUIvNextRoomInventoryBridge
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		const string ROOM_INVENTORY_ITEM_ELEMENT_TYPE = "RoomInventoryItem";

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		event Action OnInventoryItemsChanged;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		List<IUnifiedRoomInventoryItem> GetRoomInventoryItems();
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface IUnifiedRoomInventoryItem
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		Color IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OpenItemDetails([Optional] string source);
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface IRRUIvNextRoomStoreBridge
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		const string UNIFIED_ROOM_STORE_ENTRYPOINT = "UnifiedRoomStore";

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		const string ROOM_STORE_CATEGORY_PROPERTY = "room_store_category";

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		const string ROOM_STORE_CATEGORY_POSITION_PROPERTY = "room_store_category_position";

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		IRoomStoreCategory SelectedCategory
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		event Action OnStoreItemsChanged;

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		event Action OnSelectedCategoryChanged;

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		event Action OnResetSelectedCategory;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		List<IRoomStoreCategory> LoadRoomStoreCategories();

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		List<IUnifiedRoomStoreItem> GetAllRoomStoreItems();

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ResetSelectedCategory();
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface IUnifiedRoomStoreItem
	{
		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		Sprite SecondaryIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		Color SecondaryIconColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		Sprite CurrencyIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		string FormattedPriceText
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		bool CanBuy
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		string ElementType
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		event Action ItemUpdated;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void OpenItemDetails(bool attemptCheckout = false, [Optional] string source);

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void Attach();

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void Detach();
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[ViewModel]
	public class PlayerNametagViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private struct <GetPlayerInfo>d__87 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public IPlayerUIBridge player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			private RoomDetailsDTO <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private Progression <progression>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private TaskAwaiter<Account> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private TaskAwaiter<Progression> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			private TaskAwaiter<bool> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x8324500", Offset = "0x8323300", VA = "0x188324500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private struct <OnAccountUpdated>d__82 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private TaskAwaiter<Account> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x83261C0", Offset = "0x8324FC0", VA = "0x1883261C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private struct <OnReputationUpdated>d__81 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private TaskAwaiter<Reputation> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8326460", Offset = "0x8325260", VA = "0x188326460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private bool canShowNametag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private string playerDisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private string playerCustomEmoji;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private AccountRoleIconType playerRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private AccountBadgeIconType roleBadgeIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private string playerLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool isBroadcasting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private string developerLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool inCallWithLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool muted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private bool blocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private bool inAPartyWithLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private AccountBadgeIconType cheerBadgeIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private IPlayerColor playerColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private AccountLeagueIconType leagueIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private IPlayerUIBridge playerUIBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private CancellationTokenSource tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private string accountLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private bool isInfluencer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private IRoomQueryManager roomQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private CFKTKRDPQSS leagueService;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private Account account;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private DataItem<bool> CanShowNametagDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private DataItem<string> PlayerDisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private DataItem<string> PlayerCustomEmojiDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private DataItem<bool> HasCustomEmojiDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private DataItem<AccountRoleIconType> PlayerRoleTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private DataItem<AccountBadgeIconType> RoleBadgeIconTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private DataItem<string> PlayerLevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private DataItem<bool> IsBroadcastingDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private DataItem<bool> ShowDeveloperLabelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private DataItem<string> DeveloperLabelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private DataItem<bool> InCallWithLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private DataItem<bool> MutedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private DataItem<bool> BlockedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private DataItem<bool> InAPartyWithLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private DataItem<AccountBadgeIconType> CheerBadgeIconTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private DataItem<IPlayerColor> PlayerColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private DataItem<AccountLeagueIconType> LeagueIconTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private DataItemAction OpenPlayerProfileDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public bool CanShowNametag
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xACFCF0", Offset = "0xACEAF0", VA = "0x180ACFCF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x831BFC0", Offset = "0x831ADC0", VA = "0x18831BFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		[BindableData(1, "Display name of the associated player", DataPermissions.ReadOnly)]
		public string PlayerDisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x831C3E0", Offset = "0x831B1E0", VA = "0x18831C3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		[BindableData(2, "Player-set custom emoji", DataPermissions.ReadOnly)]
		public string PlayerCustomEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x831C370", Offset = "0x831B170", VA = "0x18831C370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		[BindableData(3, "Whether a custom emoji is set", DataPermissions.ReadOnly)]
		public bool HasCustomEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x831B870", Offset = "0x831A670", VA = "0x18831B870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[BindableData(5, "The role of this player in the current room", DataPermissions.ReadOnly)]
		public AccountRoleIconType PlayerRoleType
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xFABA20", Offset = "0xFAA820", VA = "0x180FABA20")]
			get
			{
				return default(AccountRoleIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x831C4D0", Offset = "0x831B2D0", VA = "0x18831C4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		[BindableData(6, "The badge the player has selected", DataPermissions.ReadOnly)]
		public AccountBadgeIconType RoleBadgeIconType
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x1003D70", Offset = "0x1002B70", VA = "0x181003D70")]
			get
			{
				return default(AccountBadgeIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x831C530", Offset = "0x831B330", VA = "0x18831C530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		[BindableData(7, "Player level (room level if room has progression)", DataPermissions.ReadOnly)]
		public string PlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x831C450", Offset = "0x831B250", VA = "0x18831C450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		[BindableData(8, "Whether the player is broadcasting", DataPermissions.ReadOnly)]
		public bool IsBroadcasting
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xE9F850", Offset = "0xE9E650", VA = "0x180E9F850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x831C1E0", Offset = "0x831AFE0", VA = "0x18831C1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		[BindableData(9, "Whether the player is a developer", DataPermissions.ReadOnly)]
		public bool ShowDeveloperLabel
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x831B890", Offset = "0x831A690", VA = "0x18831B890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		[BindableData(10, "Player level (room level if room has progression)", DataPermissions.ReadOnly)]
		public string DeveloperLabel
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x831C080", Offset = "0x831AE80", VA = "0x18831C080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		[BindableData(11, "Whether this player is in a call with the local player", DataPermissions.ReadOnly)]
		public bool InCallWithLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xB46000", Offset = "0xB44E00", VA = "0x180B46000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x831C180", Offset = "0x831AF80", VA = "0x18831C180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		[BindableData(12, "Whether this player is muted by the local player", DataPermissions.ReadOnly)]
		public bool Muted
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1C88B00", Offset = "0x1C87900", VA = "0x181C88B00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x831C2A0", Offset = "0x831B0A0", VA = "0x18831C2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		[BindableData(13, "Whether this player has been blocked by local player", DataPermissions.ReadOnly)]
		public bool Blocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x831B850", Offset = "0x831A650", VA = "0x18831B850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x831BF60", Offset = "0x831AD60", VA = "0x18831BF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		[BindableData(14, "Whether this player is in a party", DataPermissions.ReadOnly)]
		public bool InAPartyWithLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x831B860", Offset = "0x831A660", VA = "0x18831B860")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x831C120", Offset = "0x831AF20", VA = "0x18831C120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		[BindableData(15, "The active cheer this player has", DataPermissions.ReadOnly)]
		public AccountBadgeIconType CheerBadgeIconType
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xB18980", Offset = "0xB17780", VA = "0x180B18980")]
			get
			{
				return default(AccountBadgeIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x831C020", Offset = "0x831AE20", VA = "0x18831C020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		[BindableData(16, "Player color defined by legacy scripts", DataPermissions.ReadOnly)]
		public IPlayerColor PlayerColor
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x831C300", Offset = "0x831B100", VA = "0x18831C300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		[BindableData(17, "The league icon this player has", DataPermissions.ReadOnly)]
		public AccountLeagueIconType LeagueIconType
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x1509810", Offset = "0x1508610", VA = "0x181509810")]
			get
			{
				return default(AccountLeagueIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x831C240", Offset = "0x831B040", VA = "0x18831C240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x831BF20", Offset = "0x831AD20", VA = "0x18831BF20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x831B670", Offset = "0x831A470", VA = "0x18831B670")]
		public void Set(IPlayerUIBridge player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8318DF0", Offset = "0x8317BF0", VA = "0x188318DF0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x831AAF0", Offset = "0x83198F0", VA = "0x18831AAF0")]
		private void OnBroadcastingStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x831AC30", Offset = "0x8319A30", VA = "0x18831AC30")]
		private void OnDeveloperDisplayChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x831AB90", Offset = "0x8319990", VA = "0x18831AB90")]
		private void OnCallStatusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x831B040", Offset = "0x8319E40", VA = "0x18831B040")]
		private void OnPartyStatusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x831AFA0", Offset = "0x8319DA0", VA = "0x18831AFA0")]
		private void OnNametagVisibilityChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x831B400", Offset = "0x831A200", VA = "0x18831B400")]
		private void OnRelationshipChanged(int? playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x831B300", Offset = "0x831A100", VA = "0x18831B300")]
		private void OnProgressionUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x831B5B0", Offset = "0x831A3B0", VA = "0x18831B5B0")]
		[AsyncStateMachine(typeof(<OnReputationUpdated>d__81))]
		private void OnReputationUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x831AA30", Offset = "0x8319830", VA = "0x18831AA30")]
		[AsyncStateMachine(typeof(<OnAccountUpdated>d__82))]
		private void OnAccountUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x831AD90", Offset = "0x8319B90", VA = "0x18831AD90")]
		private void OnLeagueUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8319BB0", Offset = "0x83189B0", VA = "0x188319BB0")]
		private static AccountLeagueIconType GetAccountLeagueIconTypeFromLeagueValue(int leagueValue)
		{
			return default(AccountLeagueIconType);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x831B8B0", Offset = "0x831A6B0", VA = "0x18831B8B0")]
		private void UpdateRoleBadge()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x831B220", Offset = "0x831A020", VA = "0x18831B220")]
		private void OnPlayerColorUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8319C20", Offset = "0x8318A20", VA = "0x188319C20")]
		[AsyncStateMachine(typeof(<GetPlayerInfo>d__87))]
		private void GetPlayerInfo(IPlayerUIBridge player, long roomId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		[BindableAction(100, "Opens the player profile page")]
		private void OpenPlayerProfile()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8319D10", Offset = "0x8318B10", VA = "0x188319D10")]
		private static AccountRoleIconType GetRoleIconType(IPlayerUIBridge player, AccountRoleType role)
		{
			return default(AccountRoleIconType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8319DF0", Offset = "0x8318BF0", VA = "0x188319DF0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8319330", Offset = "0x8318130", VA = "0x188319330")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x831BA10", Offset = "0x831A810", VA = "0x18831BA10")]
		public PlayerNametagViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public enum RecRoomPlusOfferType
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		SimpleBenefitList,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		LimitedTimeSignOnItemBonus
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[ViewModel]
	public class RecRoomPlusOfferViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private struct <FetchBenefitData>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public RecRoomPlusOfferViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private TaskAwaiter<List<RecRoomPlusBenefitData>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8322640", Offset = "0x8321440", VA = "0x188322640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private struct <FetchStoreItemOffers>d__50 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public RecRoomPlusOfferViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public WidgetSourceData sourceData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private TaskAwaiter<Commerce.RRPlusSignUpBonusDTO> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private TaskAwaiter<IReadOnlyList<NSVNCQQULFO>> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private IEnumerator<NSVNCQQULFO> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private NSVNCQQULFO <item>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private PurchasableGiftDrop <giftDrop>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private TaskAwaiter<bool> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x8322880", Offset = "0x8321680", VA = "0x188322880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		private RecRoomPlusOfferType offerType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private int maxLimitedTimeOfferItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private Uri offerItemDetailsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		private ImpressionTracker bannerContentsImpressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private bool subscriptionActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private string offerDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private string offerIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private string offerImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private bool useImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private int offerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private int activeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private IRecRoomPlusDataManager rrplusManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private IStoreItemQueryManager storeItemListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private IRRUIvNextStoreItemBridge vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private IRecRoomPlusDataManager rrPlusDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private List<RecRoomPlusBenefitData> benefitData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private StoreItemListQueryData wishlistQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private StoreItemListQueryData configuredQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private List<int> wishlistItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private string nonWishlistSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Dictionary<int, NSVNCQQULFO> storeItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private DataItem<bool> SubscriptionActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private DataItem<string> OfferDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private DataItem<string> OfferIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private DataItem<string> OfferImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private DataItem<bool> UseImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private DataItem<int> OfferIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private DataItemAction RefreshOfferDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private DataItemAction ViewOfferItemDetailsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool SubscriptionActive
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xB41420", Offset = "0xB40220", VA = "0x180B41420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x831FD30", Offset = "0x831EB30", VA = "0x18831FD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string OfferDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x83207D0", Offset = "0x831F5D0", VA = "0x1883207D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string OfferIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8320850", Offset = "0x831F650", VA = "0x188320850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string OfferImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x83208D0", Offset = "0x831F6D0", VA = "0x1883208D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool UseImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xB88090", Offset = "0xB86E90", VA = "0x180B88090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x831FDC0", Offset = "0x831EBC0", VA = "0x18831FDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public int OfferId
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x1684250", Offset = "0x1683050", VA = "0x181684250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x831FCD0", Offset = "0x831EAD0", VA = "0x18831FCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x8320790", Offset = "0x831F590", VA = "0x188320790", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x831F1A0", Offset = "0x831DFA0", VA = "0x18831F1A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x831F910", Offset = "0x831E710", VA = "0x18831F910")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x831F0E0", Offset = "0x831DEE0", VA = "0x18831F0E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x831FE20", Offset = "0x831EC20", VA = "0x18831FE20")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x831E470", Offset = "0x831D270", VA = "0x18831E470")]
		[AsyncStateMachine(typeof(<FetchBenefitData>d__49))]
		private void FetchBenefitData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x831E520", Offset = "0x831D320", VA = "0x18831E520")]
		[AsyncStateMachine(typeof(<FetchStoreItemOffers>d__50))]
		private void FetchStoreItemOffers(WidgetSourceData sourceData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x831F280", Offset = "0x831E080", VA = "0x18831F280")]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x831F320", Offset = "0x831E120", VA = "0x18831F320")]
		[BindableAction(100, null)]
		private void RefreshOffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x831F590", Offset = "0x831E390", VA = "0x18831F590")]
		private void RefreshUIContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x831F760", Offset = "0x831E560", VA = "0x18831F760")]
		private void SetUpImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x83201E0", Offset = "0x831EFE0", VA = "0x1883201E0")]
		[BindableAction(101, null)]
		private void ViewOfferItemDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x831EA30", Offset = "0x831D830", VA = "0x18831EA30", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x831E610", Offset = "0x831D410", VA = "0x18831E610")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8320440", Offset = "0x831F240", VA = "0x188320440")]
		public RecRoomPlusOfferViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum AccountBadgeIconType
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Party,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		RRPlus,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		Influencer,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		Developer,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Cheer_Helpful,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Cheer_General,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		Cheer_Sportsmanship,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Cheer_GreatHost,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Cheer_Creative,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		League
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class AccountBadgeIconConfig : IIconConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AccountBadgeIconType IconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundFillIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundOutlineIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[FormerlySerializedAs("BadgeIcon")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeOutlineIcon;

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AccountBadgeIconConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CreateAssetMenu(fileName = "AccountBadgeIconData", menuName = "Rec Room/App UI/Account/Account Badge Icon Data")]
	public class AccountBadgeIconData : ScriptableObject, IIconData<AccountBadgeIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public List<AccountBadgeIconConfig> Config;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x830D250", Offset = "0x830C050", VA = "0x18830D250", Slot = "4")]
		public bool TryGetConfig(AccountBadgeIconType iconType, [Out] IIconConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public AccountBadgeIconData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class AccountBadgeIconView : EnumIconDataViewBase<AccountBadgeIconType, AccountBadgeIconData>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x830D3B0", Offset = "0x830C1B0", VA = "0x18830D3B0")]
		public AccountBadgeIconView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public enum AccountLeagueIconType
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		TheAmazings,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		ValorSociety,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		LeagueOfDefenders,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		MasterMinds,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		TheUnripened,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		TheRootforged,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		TheVineguard
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class AccountLeagueIconConfig : IIconConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public AccountLeagueIconType IconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundFillIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundOutlineIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[FormerlySerializedAs("BadgeIcon")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeOutlineIcon;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AccountLeagueIconConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CreateAssetMenu(fileName = "AccountLeagueIconData", menuName = "Rec Room/App UI/Account/Account League Icon Data")]
	public class AccountLeagueIconData : ScriptableObject, IIconData<AccountLeagueIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public List<AccountLeagueIconConfig> Config;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x830D4D0", Offset = "0x830C2D0", VA = "0x18830D4D0", Slot = "4")]
		public bool TryGetConfig(AccountLeagueIconType iconType, [Out] IIconConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public AccountLeagueIconData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class AccountLeagueIconView : EnumIconDataViewBase<AccountLeagueIconType, AccountLeagueIconData>
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x830D630", Offset = "0x830C430", VA = "0x18830D630")]
		public AccountLeagueIconView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum AccountRoleIconType
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Banned,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Host,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Moderator,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Contributor,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		CoOwner,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		TemporaryCoOwner,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Creator,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		RoomLevel
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class AccountRoleIconConfig : IIconConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AccountRoleIconType IconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundFillIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundOutlineIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeOutlineIcon;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AccountRoleIconConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CreateAssetMenu(fileName = "AccountRoleIconData", menuName = "RecRoom/App UI/Account Role Icon Data")]
	public class AccountRoleIconData : ScriptableObject, IIconData<AccountRoleIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		private List<AccountRoleIconConfig> iconConfigList;

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x830E8B0", Offset = "0x830D6B0", VA = "0x18830E8B0", Slot = "4")]
		public bool TryGetConfig(AccountRoleIconType iconType, [Out] IIconConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public AccountRoleIconData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class AccountRoleView : EnumIconDataViewBase<AccountRoleIconType, AccountRoleIconData>
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x830EAF0", Offset = "0x830D8F0", VA = "0x18830EAF0")]
		public AccountRoleView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[ViewModel]
	public class AccountListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct <UpdateList>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public AccountListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8326920", Offset = "0x8325720", VA = "0x188326920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private AccountListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		private Uri viewAllFriendsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		private Uri viewHereNowUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private DataList<int> _accountList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private bool _isEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private string _displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private string _emptyText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private IAccountQueryManager _accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private bool _isSubscribed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private DataItem<bool> IsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private DataItem<string> EmptyTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private DataItemList AccountListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private DataItemAction GoToViewAllPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public AccountListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x830E7B0", Offset = "0x830D5B0", VA = "0x18830E7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> AccountList
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x830E640", Offset = "0x830D440", VA = "0x18830E640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xB41420", Offset = "0xB40220", VA = "0x180B41420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x830E200", Offset = "0x830D000", VA = "0x18830E200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		[BindableData(2, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x830E6B0", Offset = "0x830D4B0", VA = "0x18830E6B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		[BindableData(3, "The text to show if the list is empty", DataPermissions.ReadOnly)]
		public string EmptyText
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x830E730", Offset = "0x830D530", VA = "0x18830E730")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x830E600", Offset = "0x830D400", VA = "0x18830E600", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x830DF30", Offset = "0x830CD30", VA = "0x18830DF30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x830DF10", Offset = "0x830CD10", VA = "0x18830DF10", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x830E330", Offset = "0x830D130", VA = "0x18830E330")]
		[AsyncStateMachine(typeof(<UpdateList>d__28))]
		private void UpdateList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x830D940", Offset = "0x830C740", VA = "0x18830D940")]
		[BindableAction(100, null)]
		private void GoToViewAllPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x830E040", Offset = "0x830CE40", VA = "0x18830E040")]
		private bool TrySubscribe()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x830E120", Offset = "0x830CF20", VA = "0x18830E120")]
		private bool TryUnsubscribe()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x830DAD0", Offset = "0x830C8D0", VA = "0x18830DAD0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x830D670", Offset = "0x830C470", VA = "0x18830D670")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x830E3E0", Offset = "0x830D1E0", VA = "0x18830E3E0")]
		public AccountListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[ViewModel]
	public class AccountViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct <FetchAccountData>d__96 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			private CancellationTokenSource <cts>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			private TaskAwaiter<Account> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x8339490", Offset = "0x8338290", VA = "0x188339490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct <UpdateAccountProgression>d__97 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private TaskAwaiter<Progression> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x833D300", Offset = "0x833C100", VA = "0x18833D300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct <UpdatePresence>d__99 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x833DD40", Offset = "0x833CB40", VA = "0x18833DD40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x833E210", Offset = "0x833D010", VA = "0x18833E210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private Uri profilePageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private ChatTelemetrySource chatTelemetrySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private PartyJoinedSource partyJoinedSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private string profileImageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int level;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private float progressInLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private string presence;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private bool _canLocalPlayerGoTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private bool isFriendOfLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAA")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private bool canSendOrAcceptFriendRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAB")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private bool canLocalPlayerInviteToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private bool isLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private bool canLocalPlayerChatWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAE")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private bool canInviteToJoinLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAF")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private bool isInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private bool isFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private bool isFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB2")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private bool isBlocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private XRHBEMYGAXH sessionManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private IRRUIvNextAccountBridge vNextAccountBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private IRRUIvNextSocialBridge vNextSocialBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Account account;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private DataItem<int> AccountIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private DataItem<string> ProfileImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private DataItem<string> UsernameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private DataItem<int> LevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private DataItem<float> ProgressInLevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private DataItem<string> PresenceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private DataItem<bool> CanLocalPlayerGoToDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private DataItem<bool> IsFriendOfLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private DataItem<bool> CanSendOrAcceptFriendRequestDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private DataItem<bool> CanInviteToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private DataItem<bool> IsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private DataItem<bool> CanLocalPlayerChatWithDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private DataItem<bool> CanInviteToJoinLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private DataItem<bool> IsInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private DataItem<bool> IsFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private DataItem<bool> IsFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private DataItem<bool> IsBlockedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private DataItemAction GoToProfilePageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private DataItemAction GoToChatPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private DataItemAction InviteToMyLocationDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private DataItemAction GoToLocationDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private DataItemAction InviteToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private DataItemAction SendFriendRequestDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAE56C0", Offset = "0xAE44C0", VA = "0x180AE56C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8311E60", Offset = "0x8310C60", VA = "0x188311E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x8312F50", Offset = "0x8311D50", VA = "0x188312F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string ProfileImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x8313050", Offset = "0x8311E50", VA = "0x188313050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string Username
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x83130D0", Offset = "0x8311ED0", VA = "0x1883130D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xFFC870", Offset = "0xFFB670", VA = "0x180FFC870")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x8312220", Offset = "0x8311020", VA = "0x188312220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public float ProgressInLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x1CF5490", Offset = "0x1CF4290", VA = "0x181CF5490")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8311CB0", Offset = "0x8310AB0", VA = "0x188311CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[BindableData(6, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Presence
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x8312FD0", Offset = "0x8311DD0", VA = "0x188312FD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		[BindableData(7, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanLocalPlayerGoTo
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xB88090", Offset = "0xB86E90", VA = "0x180B88090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x8311D30", Offset = "0x8310B30", VA = "0x188311D30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		[BindableData(8, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xB88120", Offset = "0xB86F20", VA = "0x180B88120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8311D90", Offset = "0x8310B90", VA = "0x188311D90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		[BindableData(9, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanSendOrAcceptFriendRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x2A67C20", Offset = "0x2A66A20", VA = "0x182A67C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x8311E00", Offset = "0x8310C00", VA = "0x188311E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		[BindableData(10, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanInviteToParty
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2A67970", Offset = "0x2A66770", VA = "0x182A67970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x8311ED0", Offset = "0x8310CD0", VA = "0x188311ED0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		[BindableData(11, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xAC4890", Offset = "0xAC3690", VA = "0x180AC4890")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8311F30", Offset = "0x8310D30", VA = "0x188311F30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		[BindableData(12, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanLocalPlayerChatWith
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2EA08F0", Offset = "0x2E9F6F0", VA = "0x182EA08F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8311F90", Offset = "0x8310D90", VA = "0x188311F90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		[BindableData(13, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanInviteToJoinLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xFD5280", Offset = "0xFD4080", VA = "0x180FD5280")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x8311FF0", Offset = "0x8310DF0", VA = "0x188311FF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		[BindableData(14, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8312050", Offset = "0x8310E50", VA = "0x188312050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8312060", Offset = "0x8310E60", VA = "0x188312060")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		[BindableData(15, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x14DD290", Offset = "0x14DC090", VA = "0x1814DD290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x83120D0", Offset = "0x8310ED0", VA = "0x1883120D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		[BindableData(16, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x1AAEDE0", Offset = "0x1AADBE0", VA = "0x181AAEDE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8312130", Offset = "0x8310F30", VA = "0x188312130")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		[BindableData(17, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsBlocked
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F5EEE0", Offset = "0x1F5DCE0", VA = "0x181F5EEE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x8312190", Offset = "0x8310F90", VA = "0x188312190")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x8312E20", Offset = "0x8311C20", VA = "0x188312E20", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xC38280", Offset = "0xC37080", VA = "0x180C38280", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0xC37250", Offset = "0xC36050", VA = "0x180C37250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x8312DE0", Offset = "0x8311BE0", VA = "0x188312DE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<ILoadable> Loaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x8312D20", Offset = "0x8311B20", VA = "0x188312D20", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x8312E90", Offset = "0x8311C90", VA = "0x188312E90", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x830EB30", Offset = "0x830D930", VA = "0x18830EB30", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x83115A0", Offset = "0x83103A0", VA = "0x1883115A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x83117C0", Offset = "0x83105C0", VA = "0x1883117C0")]
		private void OnRelationshipUpdated(int? accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x83117B0", Offset = "0x83105B0", VA = "0x1883117B0")]
		private void OnPlayerPresenceUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x83117A0", Offset = "0x83105A0", VA = "0x1883117A0")]
		private void OnPartyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x83113D0", Offset = "0x83101D0", VA = "0x1883113D0")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x830EEC0", Offset = "0x830DCC0", VA = "0x18830EEC0")]
		[AsyncStateMachine(typeof(<FetchAccountData>d__96))]
		private void FetchAccountData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8312280", Offset = "0x8311080", VA = "0x188312280")]
		[AsyncStateMachine(typeof(<UpdateAccountProgression>d__97))]
		private void UpdateAccountProgression()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8312570", Offset = "0x8311370", VA = "0x188312570")]
		private void UpdateRelationship()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x83124A0", Offset = "0x83112A0", VA = "0x1883124A0")]
		[AsyncStateMachine(typeof(<UpdatePresence>d__99))]
		private Task UpdatePresence()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8312330", Offset = "0x8311130", VA = "0x188312330")]
		private void UpdateCanInviteToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x83123D0", Offset = "0x83111D0", VA = "0x1883123D0")]
		private void UpdateIsFriendAndInSameRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8311830", Offset = "0x8310630", VA = "0x188311830")]
		private void ResetAccountData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x830FDA0", Offset = "0x830EBA0", VA = "0x18830FDA0")]
		[BindableAction(100, null)]
		private void GoToProfilePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x830FAA0", Offset = "0x830E8A0", VA = "0x18830FAA0")]
		[BindableAction(101, null)]
		private void GoToChatPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8311200", Offset = "0x8310000", VA = "0x188311200")]
		[BindableAction(102, null)]
		private void InviteToMyLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x830FC50", Offset = "0x830EA50", VA = "0x18830FC50")]
		[BindableAction(103, null)]
		private void GoToLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x83112F0", Offset = "0x83100F0", VA = "0x1883112F0")]
		[BindableAction(104, null)]
		private void InviteToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8311C50", Offset = "0x8310A50", VA = "0x188311C50")]
		[BindableAction(105, null)]
		private void SendFriendRequest()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x830FF80", Offset = "0x830ED80", VA = "0x18830FF80", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x830EF70", Offset = "0x830DD70", VA = "0x18830EF70")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8312720", Offset = "0x8311520", VA = "0x188312720")]
		public AccountViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ViewModel]
	public class AppNavButtonViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct <FetchLocalAccountInfo>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public AppNavButtonViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private TaskAwaiter<Account> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x8339EC0", Offset = "0x8338CC0", VA = "0x188339EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		private string buttonIdentifierOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		private DataResolver activeIdentifierResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		private DataResolver targetIdentifierResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private bool buttonPanelActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private string buttonIconId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private bool useProfilePictureAsIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private string profilePictureName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private string buttonIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private IAccountQueryManager accountManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private DataItem<bool> ButtonPanelActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private DataItem<string> ButtonIconIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private DataItem<bool> UseProfilePictureAsIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private DataItem<string> ProfilePictureNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private DataItemAction RequestChangePanelDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public bool ButtonPanelActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xD5E570", Offset = "0xD5D370", VA = "0x180D5E570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x8329620", Offset = "0x8328420", VA = "0x188329620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public string ButtonIconId
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x83295A0", Offset = "0x83283A0", VA = "0x1883295A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public bool UseProfilePictureAsIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xE9F850", Offset = "0xE9E650", VA = "0x180E9F850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x8329700", Offset = "0x8328500", VA = "0x188329700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		[BindableData(3, null, DataPermissions.ReadOnly)]
		public string ProfilePictureName
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x8329680", Offset = "0x8328480", VA = "0x188329680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8329530", Offset = "0x8328330", VA = "0x188329530", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x83294F0", Offset = "0x83282F0", VA = "0x1883294F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x8328270", Offset = "0x8327070", VA = "0x188328270", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x83291B0", Offset = "0x8327FB0", VA = "0x1883291B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8328F70", Offset = "0x8327D70", VA = "0x188328F70", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8328BF0", Offset = "0x83279F0", VA = "0x188328BF0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8328430", Offset = "0x8327230", VA = "0x188328430")]
		[AsyncStateMachine(typeof(<FetchLocalAccountInfo>d__28))]
		private void FetchLocalAccountInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8328B30", Offset = "0x8327930", VA = "0x188328B30")]
		private void OnActiveIdentifierUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8329070", Offset = "0x8327E70", VA = "0x188329070")]
		private void OnTargetIdentifierUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8329130", Offset = "0x8327F30", VA = "0x188329130")]
		[BindableAction(100, null)]
		private void RequestChangePanel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8328380", Offset = "0x8327180", VA = "0x188328380")]
		private void ConfigureImpressions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x83287B0", Offset = "0x83275B0", VA = "0x1883287B0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x83284E0", Offset = "0x83272E0", VA = "0x1883284E0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8329300", Offset = "0x8328100", VA = "0x188329300")]
		public AppNavButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class AppNavMenu : MonoBehaviour, IAppNavMenu
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class <WaitForCloseMenu>d__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700010D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000390")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <WaitForCloseMenu>d__81(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x833EB70", Offset = "0x833D970", VA = "0x18833EB70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x833ECC0", Offset = "0x833DAC0", VA = "0x18833ECC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class <WaitForOpenMenu>d__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private float <watchOpenStart>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700010F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000394")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000110")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <WaitForOpenMenu>d__80(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x833ED00", Offset = "0x833DB00", VA = "0x18833ED00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x833F110", Offset = "0x833DF10", VA = "0x18833F110", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class <WaitToOpenWatch>d__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000111")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600039A")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000112")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600039C")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <WaitToOpenWatch>d__82(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x833F580", Offset = "0x833E380", VA = "0x18833F580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x833F610", Offset = "0x833E410", VA = "0x18833F610", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public const string AppNavLayerName = "interfaces_2025q1_appnav";

		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public const string UseAppNavParameterName = "use_app_nav_forship";

		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public const string UXFlowLayerName = "interfaces_widgetwatch_ux_flow";

		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public const string RetainUIStateParameterName = "enable_retain_ui_state";

		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public const string ShowWatchButtonParameterName = "show_watch_button_in_menus";

		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public const string PortalButtonsAsTabsParameterName = "portal_buttons_act_like_tabs";

		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public const string RetainUIStateDurationParameterName = "retain_ui_state_duration";

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public const string AlwaysPresentPortalParameterName = "portal_always_present";

		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public static readonly DQHMEXLDKHB InitializedEvent;

		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private static AppNavMenu instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Canvas menuCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private HydrateBase appNavHydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private AppNavViewModel appNavViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private AppNavPanelSwitcher panelSwitcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private PlatformDependentCanvasSizeConfig canvasSizeConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private LongPressInteractable backgroundInteractable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private float forceWatchCloseDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private Coroutine transitionCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private DINTWZBUUTH statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private Transform originalParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private bool isGoingBack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private LCYODOXSSEV<object> disableAppNavTokens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public DQHMEXLDKHB BeforeAppNavOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public DQHMEXLDKHB AfterAppNavOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public DQHMEXLDKHB AfterAppNavClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public DQHMEXLDKHB OnShouldUseAppNavChanged;

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		public static bool ShouldRetainUIState
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x832B0C0", Offset = "0x8329EC0", VA = "0x18832B0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		public static bool PortalButtonsActAsTabs
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x832ABB0", Offset = "0x83299B0", VA = "0x18832ABB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public static float RetainUIStateDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x832AD40", Offset = "0x8329B40", VA = "0x18832AD40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public static bool ShouldShowWatchButtonInMenus
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x832B2F0", Offset = "0x832A0F0", VA = "0x18832B2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		private static bool showWatchButtonInMenus
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x832B6B0", Offset = "0x832A4B0", VA = "0x18832B6B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public static bool ShouldRetainUIStateAndResetAfterDuration
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x832B050", Offset = "0x8329E50", VA = "0x18832B050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public static bool UseAlwaysPresentPortalPanel
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x832B520", Offset = "0x832A320", VA = "0x18832B520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public static AppNavMenu Instance
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x832AB50", Offset = "0x8329950", VA = "0x18832AB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public bool ShouldUseAppNav
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x832B4D0", Offset = "0x832A2D0", VA = "0x18832B4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		public bool CanOpenAppNavWhenWatchIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xE9F850", Offset = "0xE9E650", VA = "0x180E9F850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x10E0A40", Offset = "0x10DF840", VA = "0x1810E0A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xE9F860", Offset = "0xE9E660", VA = "0x180E9F860", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xE9E620", Offset = "0xE9D420", VA = "0x180E9E620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public bool IsTransitionActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x832ABA0", Offset = "0x83299A0", VA = "0x18832ABA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x17FED20", Offset = "0x17FDB20", VA = "0x1817FED20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public bool ShouldOpenLastActivePanel
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x1801B60", Offset = "0x1800960", VA = "0x181801B60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x17FED60", Offset = "0x17FDB60", VA = "0x1817FED60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public bool IsToolMenuOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xE23450", Offset = "0xE22250", VA = "0x180E23450")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0xE22BE0", Offset = "0xE219E0", VA = "0x180E22BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public bool WasOpenOnNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xC56160", Offset = "0xC54F60", VA = "0x180C56160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0xC54EB0", Offset = "0xC53CB0", VA = "0x180C54EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x83298C0", Offset = "0x83286C0", VA = "0x1883298C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x832A310", Offset = "0x8329110", VA = "0x18832A310")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x832A0D0", Offset = "0x8328ED0", VA = "0x18832A0D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8329760", Offset = "0x8328560", VA = "0x188329760")]
		public void AddAppNavRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x832A4A0", Offset = "0x83292A0", VA = "0x18832A4A0")]
		public void RemoveAppNavRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x832A350", Offset = "0x8329150", VA = "0x18832A350")]
		public void OpenMenuWithPreviousPanel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x832A360", Offset = "0x8329160", VA = "0x18832A360", Slot = "5")]
		public void OpenMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x832A000", Offset = "0x8328E00", VA = "0x18832A000", Slot = "6")]
		public void CloseMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x832A420", Offset = "0x8329220", VA = "0x18832A420", Slot = "7")]
		public void OpenWatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x832A400", Offset = "0x8329200", VA = "0x18832A400")]
		public void OpenPage(string pageIdentifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x832A860", Offset = "0x8329660", VA = "0x18832A860")]
		[IteratorStateMachine(typeof(<WaitForOpenMenu>d__80))]
		private IEnumerator WaitForOpenMenu()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x832A7F0", Offset = "0x83295F0", VA = "0x18832A7F0")]
		[IteratorStateMachine(typeof(<WaitForCloseMenu>d__81))]
		private IEnumerator WaitForCloseMenu()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x832A8D0", Offset = "0x83296D0", VA = "0x18832A8D0")]
		[IteratorStateMachine(typeof(<WaitToOpenWatch>d__82))]
		private IEnumerator WaitToOpenWatch()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x832A750", Offset = "0x8329550", VA = "0x18832A750")]
		private void SetMenuClosedState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x832A600", Offset = "0x8329400", VA = "0x18832A600")]
		private void SetCanvasSize(Vector2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x832A9E0", Offset = "0x83297E0", VA = "0x18832A9E0")]
		public AppNavMenu()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class AppNavPanel : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class <RegisterAfterOneFrame>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public AppNavPanel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000115")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003A7")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000116")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003A9")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <RegisterAfterOneFrame>d__10(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x833CC40", Offset = "0x833BA40", VA = "0x18833CC40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x833CD00", Offset = "0x833BB00", VA = "0x18833CD00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[SerializeField]
		private string panelIdentifierOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		private HydrateBase hydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private AppNavPanelSwitcher panelSwitcher;

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public string Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public HydrateBase Hydration
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x832C4A0", Offset = "0x832B2A0", VA = "0x18832C4A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x832C260", Offset = "0x832B060", VA = "0x18832C260")]
		[IteratorStateMachine(typeof(<RegisterAfterOneFrame>d__10))]
		private IEnumerator RegisterAfterOneFrame()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x832C2D0", Offset = "0x832B0D0", VA = "0x18832C2D0")]
		public void SetIdentifier(string identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x832C590", Offset = "0x832B390", VA = "0x18832C590")]
		public AppNavPanel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class AppNavPanelSwitcher : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class <CloseTopLevelOnly>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000118")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003BB")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000119")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <CloseTopLevelOnly>d__27(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x8339340", Offset = "0x8338140", VA = "0x188339340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x8339450", Offset = "0x8338250", VA = "0x188339450", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class <OpenTopLevelOnly>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700011A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003C1")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700011B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <OpenTopLevelOnly>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x833CB00", Offset = "0x833B900", VA = "0x18833CB00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x833CC00", Offset = "0x833BA00", VA = "0x18833CC00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class <SwapPanels>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400023B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			public string targetIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			private bool <startedSwapWithValidCurrentPanel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400023F")]
			private AppNavPanel <targetPanel>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700011C")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700011D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003C9")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <SwapPanels>d__24(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x833CD40", Offset = "0x833BB40", VA = "0x18833CD40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x833D2C0", Offset = "0x833C0C0", VA = "0x18833D2C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class <WaitThenClose>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000240")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700011E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700011F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <WaitThenClose>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x833F150", Offset = "0x833DF50", VA = "0x18833F150", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x833F3E0", Offset = "0x833E1E0", VA = "0x18833F3E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[SerializeField]
		private float initialWaitBeforeCloseTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		[SerializeField]
		private float initialOpenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		[SerializeField]
		private CanvasScreenSizeRefitter screenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		[SerializeField]
		private HydrateBase topLevelHydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		[SerializeField]
		private float topLevelHydrationDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		[SerializeField]
		private DataResolver currentPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		[SerializeField]
		private DataResolver targetPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private Dictionary<string, AppNavPanel> panelLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private string currentPanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private AppNavPanel currentPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private Coroutine panelSwitchCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private Coroutine initialOpenCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private Vector3 cachedInitialPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public DQHMEXLDKHB AllPanelsClosed;

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		public bool SwitchingPanels
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7429BD0", Offset = "0x74289D0", VA = "0x187429BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x832B840", Offset = "0x832A640", VA = "0x18832B840")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x832BF00", Offset = "0x832AD00", VA = "0x18832BF00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x1955DD0", Offset = "0x1954BD0", VA = "0x181955DD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x832B980", Offset = "0x832A780", VA = "0x18832B980")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x832BB10", Offset = "0x832A910", VA = "0x18832BB10")]
		public void RegisterPanel(AppNavPanel panel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x832C020", Offset = "0x832AE20", VA = "0x18832C020")]
		public void UnregisterPanel(AppNavPanel panel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x832BA30", Offset = "0x832A830", VA = "0x18832BA30")]
		private void OnTargetPanelUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x832BC00", Offset = "0x832AA00", VA = "0x18832BC00")]
		private void RequestTargetPanel(string identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x832BF90", Offset = "0x832AD90", VA = "0x18832BF90")]
		[IteratorStateMachine(typeof(<SwapPanels>d__24))]
		private IEnumerator SwapPanels(string targetIdentifier)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x832C0C0", Offset = "0x832AEC0", VA = "0x18832C0C0")]
		[IteratorStateMachine(typeof(<WaitThenClose>d__25))]
		private IEnumerator WaitThenClose()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x832BAA0", Offset = "0x832A8A0", VA = "0x18832BAA0")]
		[IteratorStateMachine(typeof(<OpenTopLevelOnly>d__26))]
		private IEnumerator OpenTopLevelOnly()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x832B910", Offset = "0x832A710", VA = "0x18832B910")]
		[IteratorStateMachine(typeof(<CloseTopLevelOnly>d__27))]
		private IEnumerator CloseTopLevelOnly()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x832C130", Offset = "0x832AF30", VA = "0x18832C130")]
		public AppNavPanelSwitcher()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class AppNavTutorial : TutorialHighlightTargeter
	{
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public const string ShowAppNavTutorialParameterName = "enable_app_nav_tutorial";

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private const string tutorialCompletionKey = "AppNavTutorialCompleted";

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private const string tutorialSoftExitKey = "AppNavTutorialSoftExit";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		[SerializeField]
		private UITutorialData tutorialDataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		[SerializeField]
		private AppNavMenu appNavMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		[SerializeField]
		private string idOfOpenAppNavStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		[SerializeField]
		private string idOfWidgetStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		[SerializeField]
		private string idOfPortalStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		[SerializeField]
		private int allowedSoftExits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private Tutorial tutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private AWJSQTHCCJW preferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private DINTWZBUUTH statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private bool canShowTutorial;

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public static AppNavTutorial Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x832D8F0", Offset = "0x832C6F0", VA = "0x18832D8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x832D930", Offset = "0x832C730", VA = "0x18832D930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x832C5E0", Offset = "0x832B3E0", VA = "0x18832C5E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x832D500", Offset = "0x832C300", VA = "0x18832D500")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x832CFF0", Offset = "0x832BDF0", VA = "0x18832CFF0")]
		public void StartTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x832D540", Offset = "0x832C340", VA = "0x18832D540")]
		public void StopTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x832CB30", Offset = "0x832B930", VA = "0x18832CB30")]
		private void OnCanUseAppNavChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x832CC80", Offset = "0x832BA80", VA = "0x18832CC80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x832CC70", Offset = "0x832BA70", VA = "0x18832CC70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x832CBA0", Offset = "0x832B9A0", VA = "0x18832CBA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x832CAB0", Offset = "0x832B8B0", VA = "0x18832CAB0")]
		private void OnAppNavOpened()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x832CA40", Offset = "0x832B840", VA = "0x18832CA40")]
		private void OnAppNavClosed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x832CC90", Offset = "0x832BA90", VA = "0x18832CC90")]
		private void OnStepChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x832C830", Offset = "0x832B630", VA = "0x18832C830")]
		private void ClearTutorialEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x832CFA0", Offset = "0x832BDA0", VA = "0x18832CFA0")]
		private void OnTutorialStarted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x832CE80", Offset = "0x832BC80", VA = "0x18832CE80")]
		private void OnTutorialExited()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x832D840", Offset = "0x832C640", VA = "0x18832D840")]
		public AppNavTutorial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[ViewModel]
	public class AppNavViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private struct <FetchPanelIds>d__48 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			public AppNavViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			private TaskAwaiter<List<string>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			private string <newDefault>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			private List<string>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000274")]
			private string <panelId>5__5;

			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x833A120", Offset = "0x8338F20", VA = "0x18833A120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x833A8A0", Offset = "0x83396A0", VA = "0x18833A8A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private const string UnifiedUISessionIdKey = "unified_ui_session_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		[SerializeField]
		private float reopenToLastPanelThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private string activePanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private string nextPanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private DataList<string> widgetPanelIdentifiers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private float availableHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private Guid sessionGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private bool portalPanelAlwaysPresent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private bool portalPanelAlwaysPresentForTouch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private bool portalPanelAlwaysPresentForScreens;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private KGDITIUSTQK analyticsHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private IMenuManager menuManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private string defaultPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private float lastCloseTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private DataItem<string> ActivePanelIdentifierDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private DataItem<string> NextPanelIdentifierDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private DataItem<float> AvailableHeightDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private DataItem<Guid> SessionGuidDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private DataItem<bool> PortalPanelAlwaysPresentDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private DataItem<bool> PortalPanelAlwaysPresentForTouchDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private DataItem<bool> PortalPanelAlwaysPresentForScreensDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private DataItemList WidgetPanelIdentifiersDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private DataItemAction CloseDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ActivePanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x832F5E0", Offset = "0x832E3E0", VA = "0x18832F5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string NextPanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x832F690", Offset = "0x832E490", VA = "0x18832F690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<string> WidgetPanelIdentifiers
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x832FC20", Offset = "0x832EA20", VA = "0x18832FC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public float AvailableHeight
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x12AA0D0", Offset = "0x12A8ED0", VA = "0x1812AA0D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x832F700", Offset = "0x832E500", VA = "0x18832F700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public Guid SessionGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x4A3C130", Offset = "0x4A3AF30", VA = "0x184A3C130")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x832F770", Offset = "0x832E570", VA = "0x18832F770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresent
		{
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x1F3F130", Offset = "0x1F3DF30", VA = "0x181F3F130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x832F7F0", Offset = "0x832E5F0", VA = "0x18832F7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresentForTouch
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x832F440", Offset = "0x832E240", VA = "0x18832F440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x832F450", Offset = "0x832E250", VA = "0x18832F450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresentForScreens
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x1F65190", Offset = "0x1F63F90", VA = "0x181F65190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x832F4B0", Offset = "0x832E2B0", VA = "0x18832F4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		public string PreviousPanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0xB88140", Offset = "0xB86F40", VA = "0x180B88140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xBBC360", Offset = "0xBBB160", VA = "0x180BBC360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x832FBE0", Offset = "0x832E9E0", VA = "0x18832FBE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x832D980", Offset = "0x832C780", VA = "0x18832D980", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x832EE00", Offset = "0x832DC00", VA = "0x18832EE00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x832EE50", Offset = "0x832DC50", VA = "0x18832EE50")]
		public void Open(string panelIdentifier = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x832DE20", Offset = "0x832CC20", VA = "0x18832DE20")]
		[BindableAction(100, null)]
		public void Close()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x832E090", Offset = "0x832CE90", VA = "0x18832E090")]
		[AsyncStateMachine(typeof(<FetchPanelIds>d__48))]
		private Task FetchPanelIds()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x832F270", Offset = "0x832E070", VA = "0x18832F270")]
		private void SetAlwaysPortalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x832E600", Offset = "0x832D400", VA = "0x18832E600", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x832E170", Offset = "0x832CF70", VA = "0x18832E170")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x832F850", Offset = "0x832E650", VA = "0x18832F850")]
		public AppNavViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[ViewModel]
	public class DevToolsViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		[SerializeField]
		private Uri debugToolsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		[SerializeField]
		private Uri testCaseManagementUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		[SerializeField]
		private Uri bugReportingUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		[SerializeField]
		private Uri componentLibraryUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private bool canAccessDevTools;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private bool developerToolsActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private bool shouldShowDebugTools;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private DataItem<bool> CanAccessDevToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private DataItem<bool> DeveloperToolsActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private DataItem<bool> ShouldShowDebugToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private DataItemAction OpenDebugToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private DataItemAction OpenTestCaseManagementDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private DataItemAction OpenBugReportingDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private DataItemAction OpenComponentLibraryDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool CanAccessDevTools
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xB41420", Offset = "0xB40220", VA = "0x180B41420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x83309D0", Offset = "0x832F7D0", VA = "0x1883309D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool DeveloperToolsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xB413F0", Offset = "0xB401F0", VA = "0x180B413F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x8330A30", Offset = "0x832F830", VA = "0x188330A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool ShouldShowDebugTools
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xB413E0", Offset = "0xB401E0", VA = "0x180B413E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x8330A90", Offset = "0x832F890", VA = "0x188330A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x8330E00", Offset = "0x832FC00", VA = "0x188330E00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x832FC90", Offset = "0x832EA90", VA = "0x18832FC90", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x83307F0", Offset = "0x832F5F0", VA = "0x1883307F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x8330AF0", Offset = "0x832F8F0", VA = "0x188330AF0")]
		private void UpdateBasedOnLocalAccount()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8330910", Offset = "0x832F710", VA = "0x188330910")]
		[BindableAction(100, null)]
		private void OpenDebugTools()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8330970", Offset = "0x832F770", VA = "0x188330970")]
		[BindableAction(101, null)]
		private void OpenTestCaseManagement()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x8330850", Offset = "0x832F650", VA = "0x188330850")]
		[BindableAction(102, null)]
		private void OpenBugReporting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x83308B0", Offset = "0x832F6B0", VA = "0x1883308B0")]
		[BindableAction(103, null)]
		private void OpenComponentLibrary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x83302C0", Offset = "0x832F0C0", VA = "0x1883302C0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x832FF10", Offset = "0x832ED10", VA = "0x18832FF10")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x8330C50", Offset = "0x832FA50", VA = "0x188330C50")]
		public DevToolsViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public interface IAppNavMenu
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[ViewModel]
	public class PortalButtonViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		[SerializeField]
		private UILinkLookup routeLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private PortalButtonConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private LinkInfo linkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private string iconName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private DataItem<string> IconNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private DataItemAction OpenRouteDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x83368D0", Offset = "0x83356D0", VA = "0x1883368D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x8336940", Offset = "0x8335740", VA = "0x188336940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string IconName
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x83369C0", Offset = "0x83357C0", VA = "0x1883369C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x8336890", Offset = "0x8335690", VA = "0x188336890", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x8336540", Offset = "0x8335340", VA = "0x188336540")]
		[BindableAction(2, null)]
		public void OpenRoute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x8335A50", Offset = "0x8334850", VA = "0x188335A50", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x8335F70", Offset = "0x8334D70", VA = "0x188335F70")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x8335CC0", Offset = "0x8334AC0", VA = "0x188335CC0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x8335AE0", Offset = "0x83348E0", VA = "0x188335AE0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x8336760", Offset = "0x8335560", VA = "0x188336760")]
		public PortalButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[ViewModel]
	public class PortalPanelViewModel : RRUIBaseGlobalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private struct <FetchPortalPanelData>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			public PortalPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private TaskAwaiter<PortalPanelConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x833A900", Offset = "0x8339700", VA = "0x18833A900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x833ACD0", Offset = "0x8339AD0", VA = "0x18833ACD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private struct <WaitThenUpdateBackplate>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			public PortalPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x833F420", Offset = "0x833E220", VA = "0x18833F420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		[SerializeField]
		private List<RectTransform> backplateRects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		[SerializeField]
		private Vector2 verticalBackplatePadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		[SerializeField]
		private RectTransform sectionParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		[SerializeField]
		private RectTransform trayButtonParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private DataList<PortalButtonGroupConfig> sections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private bool hasWidget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private bool portalPanelOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private DataItem<bool> HasWidgetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private DataItem<string> WidgetIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private DataItem<bool> PortalPanelOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private DataItemList SectionsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private DataItemAction TogglePanelStateDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<PortalButtonGroupConfig> Sections
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x8337E60", Offset = "0x8336C60", VA = "0x188337E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool HasWidget
		{
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E90", Offset = "0xFBFC90", VA = "0x180FC0E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x83374D0", Offset = "0x83362D0", VA = "0x1883374D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string WidgetId
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x8337EC0", Offset = "0x8336CC0", VA = "0x188337EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool PortalPanelOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xB41420", Offset = "0xB40220", VA = "0x180B41420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x8337540", Offset = "0x8336340", VA = "0x188337540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x8337E20", Offset = "0x8336C20", VA = "0x188337E20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8336A40", Offset = "0x8335840", VA = "0x188336A40", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8337450", Offset = "0x8336250", VA = "0x188337450")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8337420", Offset = "0x8336220", VA = "0x188337420", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x8336BF0", Offset = "0x83359F0", VA = "0x188336BF0")]
		[AsyncStateMachine(typeof(<FetchPortalPanelData>d__25))]
		private Task FetchPortalPanelData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x8337B00", Offset = "0x8336900", VA = "0x188337B00")]
		[AsyncStateMachine(typeof(<WaitThenUpdateBackplate>d__26))]
		private void WaitThenUpdateBackplate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8337670", Offset = "0x8336470", VA = "0x188337670")]
		private void UpdateBackplateRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x8337460", Offset = "0x8336260", VA = "0x188337460")]
		[BindableAction(100, null)]
		private void TogglePanelState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x8336F90", Offset = "0x8335D90", VA = "0x188336F90", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x8336CC0", Offset = "0x8335AC0", VA = "0x188336CC0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x8337BB0", Offset = "0x83369B0", VA = "0x188337BB0")]
		public PortalPanelViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[ViewModel]
	public class PortalSectionViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private PortalButtonGroupConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private string sectionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private string iconName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private DataList<PortalButtonConfig> buttons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private DataItem<string> SectionNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private DataItem<string> IconNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private DataItemList ButtonsDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x8338AB0", Offset = "0x83378B0", VA = "0x188338AB0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string SectionName
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x8338760", Offset = "0x8337560", VA = "0x188338760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string IconName
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x83387D0", Offset = "0x83375D0", VA = "0x1883387D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<PortalButtonConfig> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x8338B20", Offset = "0x8337920", VA = "0x188338B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x8338A70", Offset = "0x8337870", VA = "0x188338A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x8338430", Offset = "0x8337230", VA = "0x188338430")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8338120", Offset = "0x8336F20", VA = "0x188338120", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x8337F40", Offset = "0x8336D40", VA = "0x188337F40")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x8338910", Offset = "0x8337710", VA = "0x188338910")]
		public PortalSectionViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[ViewModel]
	public class WidgetPanelViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private struct <FetchWidgetData>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002BF")]
			public WidgetPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002C0")]
			private int <currentCount>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			private TaskAwaiter<List<string>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x833AD30", Offset = "0x8339B30", VA = "0x18833AD30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x833B480", Offset = "0x833A280", VA = "0x18833B480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		[SerializeField]
		private float defaultHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		[SerializeField]
		private int maximumWidgetCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		[SerializeField]
		private WidgetPrefabMapping widgetPrefabMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		[SerializeField]
		private AppNavPanel panel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		[SerializeField]
		private DataResolver availableHeightResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private string panelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private float maxHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private float currentHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private List<string> tempList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private DataList<string> widgetIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private DataItemList WidgetIdListDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x8340290", Offset = "0x833F090", VA = "0x188340290", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<string> WidgetIdList
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x8340300", Offset = "0x833F100", VA = "0x188340300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x8340250", Offset = "0x833F050", VA = "0x188340250", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x833F650", Offset = "0x833E450", VA = "0x18833F650", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x833FF30", Offset = "0x833ED30", VA = "0x18833FF30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x833FDA0", Offset = "0x833EBA0", VA = "0x18833FDA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x833F920", Offset = "0x833E720", VA = "0x18833F920")]
		[AsyncStateMachine(typeof(<FetchWidgetData>d__19))]
		public Task FetchWidgetData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x833FCA0", Offset = "0x833EAA0", VA = "0x18833FCA0")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x833F840", Offset = "0x833E640", VA = "0x18833F840")]
		private void CheckIfShouldFetchData(string changedPanelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x833F8C0", Offset = "0x833E6C0", VA = "0x18833F8C0")]
		private void DoFetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x833FC40", Offset = "0x833EA40", VA = "0x18833FC40")]
		private void OnAvailableHeightUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x833FAF0", Offset = "0x833E8F0", VA = "0x18833FAF0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x833F9F0", Offset = "0x833E7F0", VA = "0x18833F9F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x83400F0", Offset = "0x833EEF0", VA = "0x1883400F0")]
		public WidgetPanelViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class WidgetInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AssetReference WidgetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public float MaxHeight;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x14914E0", Offset = "0x14902E0", VA = "0x1814914E0")]
		public WidgetInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CreateAssetMenu(fileName = "WidgetPrefabMapping", menuName = "RecRoom/UI/App Nav/Widget Prefab Mapping")]
	public class WidgetPrefabMapping : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public List<WidgetInfo> widgetPrefabs;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x8340370", Offset = "0x833F170", VA = "0x188340370")]
		public bool TryGetReference(string widgetId, [Out] AssetReference reference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x8340500", Offset = "0x833F300", VA = "0x188340500")]
		public bool TryGetWidgetHeight(string widgetId, [Out] float height)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public WidgetPrefabMapping()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[ViewModel]
	public class WidgetWrapperViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class <MonitorWidgetForSizeChanges>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			public WidgetWrapperViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			private RectTransform <widgetTransform>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700014A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700014B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600049A")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <MonitorWidgetForSizeChanges>d__23(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0x833B4E0", Offset = "0x833A2E0", VA = "0x18833B4E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x833B7E0", Offset = "0x833A5E0", VA = "0x18833B7E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private struct <UpdateWidget>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public string widgetId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public WidgetWrapperViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			private string <typeId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			private AssetReference <reference>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			private AsyncOperationHandle<GameObject> <refHandle>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x833E270", Offset = "0x833D070", VA = "0x18833E270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x833EB10", Offset = "0x833D910", VA = "0x18833EB10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public const string WIDGET_ID_PROPERTY = "widget_id";

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public const string WIDGET_TYPE_PROPERTY = "widget_type_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[SerializeField]
		private WidgetPrefabMapping prefabMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		[SerializeField]
		private DataResolver sessionIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		[SerializeField]
		private bool forceWidgetToFitWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private AssetReference widgetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private GameObject instantiatedWidget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private ImpressionTracker widgetImpressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private Vector2 cachedWidgetSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private Coroutine widgetSizeCheckCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private DataItem<string> WidgetIdDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string WidgetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x8340FC0", Offset = "0x833FDC0", VA = "0x188340FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x8340F50", Offset = "0x833FD50", VA = "0x188340F50", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x8340F10", Offset = "0x833FD10", VA = "0x188340F10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x8340680", Offset = "0x833F480", VA = "0x188340680", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x8340C20", Offset = "0x833FA20", VA = "0x188340C20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x8340BD0", Offset = "0x833F9D0", VA = "0x188340BD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x8340A10", Offset = "0x833F810", VA = "0x188340A10")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x8340D20", Offset = "0x833FB20", VA = "0x188340D20")]
		[AsyncStateMachine(typeof(<UpdateWidget>d__22))]
		public Task UpdateWidget(string widgetId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x83409A0", Offset = "0x833F7A0", VA = "0x1883409A0")]
		[IteratorStateMachine(typeof(<MonitorWidgetForSizeChanges>d__23))]
		private IEnumerator MonitorWidgetForSizeChanges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x8340CC0", Offset = "0x833FAC0", VA = "0x188340CC0")]
		private void ReleaseWidgetReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x8340850", Offset = "0x833F650", VA = "0x188340850", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x8340750", Offset = "0x833F550", VA = "0x188340750")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x8340E30", Offset = "0x833FC30", VA = "0x188340E30")]
		public WidgetWrapperViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[ViewModel]
	public class AccountsWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			public AccountsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			private TaskAwaiter<AccountListQueryData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x833BAA0", Offset = "0x833A8A0", VA = "0x18833BAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private IAppNavDataManager _appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private IRRUIvNextAccountBridge _vNextAccountBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		private AccountListViewModel accountListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private AccountListQueryData _queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private DataItem<AccountListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public AccountListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x8328140", Offset = "0x8326F40", VA = "0x188328140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x8328230", Offset = "0x8327030", VA = "0x188328230", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x8327BD0", Offset = "0x83269D0", VA = "0x188327BD0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x8327FE0", Offset = "0x8326DE0", VA = "0x188327FE0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x8328090", Offset = "0x8326E90", VA = "0x188328090")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__10))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x8327E90", Offset = "0x8326C90", VA = "0x188327E90", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x8327D90", Offset = "0x8326B90", VA = "0x188327D90")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x83281B0", Offset = "0x8326FB0", VA = "0x1883281B0")]
		public AccountsWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[ViewModel]
	public class LocalPlayerWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private struct <FetchDataAsync>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public LocalPlayerWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			private TaskAwaiter<Account> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x8339A00", Offset = "0x8338800", VA = "0x188339A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private const int INVALID_TOKEN_BALANCE = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		private AccountViewModel accountViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		private bool manuallySetWidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		private Uri profilePageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[SerializeField]
		private LinkInfo profileLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		[SerializeField]
		private Uri notificationsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[SerializeField]
		private LinkInfo notificationsLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		private Uri settingsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		private LinkInfo settingsLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		private Uri rrPlusSubscriptionUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private string profilePictureName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private string userName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private bool hasUnreadNotifications;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private long tokenBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private bool hasRecRoomPlus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private IAccountQueryManager accountManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private IRecRoomPlusDataManager rrPlusDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private int localPlayerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private DataItem<string> ProfilePictureNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private DataItem<string> UserNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private DataItem<bool> HasUnreadNotificationsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private DataItem<long> TokenBalanceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private DataItem<bool> HasRecRoomPlusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private DataItemAction GoToProfilePageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private DataItemAction GoToNotificationsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private DataItemAction GoToSettingsPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private DataItemAction GoToRRPlusPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ProfilePictureName
		{
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0xB88130", Offset = "0xB86F30", VA = "0x180B88130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x8332910", Offset = "0x8331710", VA = "0x188332910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0xEF42F0", Offset = "0xEF30F0", VA = "0x180EF42F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x8332880", Offset = "0x8331680", VA = "0x188332880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string UserName
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0xB880B0", Offset = "0xB86EB0", VA = "0x180B880B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x8332990", Offset = "0x8331790", VA = "0x188332990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool HasUnreadNotifications
		{
			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x10E2CD0", Offset = "0x10E1AD0", VA = "0x1810E2CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x8332480", Offset = "0x8331280", VA = "0x188332480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public long TokenBalance
		{
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xB88140", Offset = "0xB86F40", VA = "0x180B88140")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x83324E0", Offset = "0x83312E0", VA = "0x1883324E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool HasRecRoomPlus
		{
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xBBC310", Offset = "0xBBB110", VA = "0x180BBC310")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x83323F0", Offset = "0x83311F0", VA = "0x1883323F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x8332840", Offset = "0x8331640", VA = "0x188332840", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x8330E40", Offset = "0x832FC40", VA = "0x188330E40", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x8332280", Offset = "0x8331080", VA = "0x188332280")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x8331090", Offset = "0x832FE90", VA = "0x188331090")]
		[AsyncStateMachine(typeof(<FetchDataAsync>d__40))]
		private void FetchDataAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x8332330", Offset = "0x8331130", VA = "0x188332330")]
		private void RefreshTokenBalance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x8331750", Offset = "0x8330550", VA = "0x188331750")]
		[BindableAction(100, null)]
		private void GoToProfilePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x8331640", Offset = "0x8330440", VA = "0x188331640")]
		[BindableAction(101, null)]
		private void GoToNotifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x83319A0", Offset = "0x83307A0", VA = "0x1883319A0")]
		[BindableAction(102, null)]
		private void GoToSettingsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8331860", Offset = "0x8330660", VA = "0x188331860")]
		[BindableAction(103, null)]
		private void GoToRRPlusPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x8331AB0", Offset = "0x83308B0", VA = "0x188331AB0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x8331140", Offset = "0x832FF40", VA = "0x188331140")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x8332540", Offset = "0x8331340", VA = "0x188332540")]
		public LocalPlayerWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[ViewModel]
	public class MyDormWidgetViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		[SerializeField]
		private Uri thisRoomUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private DataItemAction OpenThisRoomPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private DataItemAction GoToRecCenterDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private DataItemAction EvictAllDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x83335F0", Offset = "0x83323F0", VA = "0x1883335F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x8333920", Offset = "0x8332720", VA = "0x188333920", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x8332A10", Offset = "0x8331810", VA = "0x188332A10", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x8333660", Offset = "0x8332460", VA = "0x188333660")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x8333530", Offset = "0x8332330", VA = "0x188333530")]
		[BindableAction(100, null)]
		private void OpenThisRoomPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x8333010", Offset = "0x8331E10", VA = "0x188333010")]
		[BindableAction(101, null)]
		private void GoToRecCenter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x8332CB0", Offset = "0x8331AB0", VA = "0x188332CB0")]
		[BindableAction(102, null)]
		private void EvictAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x83334D0", Offset = "0x83322D0", VA = "0x1883334D0")]
		private void OnJoinRoomResponse(JoinRoomResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x83331C0", Offset = "0x8331FC0", VA = "0x1883331C0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x8332DC0", Offset = "0x8331BC0", VA = "0x188332DC0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x83337E0", Offset = "0x83325E0", VA = "0x1883337E0")]
		public MyDormWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[ViewModel]
	public class PartyWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private struct <OnPartyChanged>d__39 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public PartyWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0x833B820", Offset = "0x833A620", VA = "0x18833B820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct <UpdatePartyData>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public PartyWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x833D520", Offset = "0x833C320", VA = "0x18833D520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x833DCE0", Offset = "0x833CAE0", VA = "0x18833DCE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[SerializeField]
		private Uri createPartyUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		private Uri managePartyUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[SerializeField]
		private Uri openPartyChatUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		[SerializeField]
		private float notInPartyHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		[SerializeField]
		private float inPartyHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private bool inParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private bool partyChatAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private bool canGoToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8B")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private bool canAddToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private DataList<int> partyMembers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private int partyMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private bool hasUnreadPartyChatMessages;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private IRRUIvNextSocialBridge socialBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private bool updatePending;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private bool updateQueued;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private DataItem<bool> InPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private DataItem<bool> PartyChatAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private DataItem<bool> CanGoToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private DataItem<bool> CanAddToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private DataItem<int> PartyMemberCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private DataItem<bool> HasUnreadPartyChatMessagesDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private DataItemList PartyMembersDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private DataItemAction CreateOrJoinPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private DataItemAction OpenPartyChatDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private DataItemAction GoToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private DataItemAction AddToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private DataItemAction ManagePartyDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool InParty
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xB41420", Offset = "0xB40220", VA = "0x180B41420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0x83353C0", Offset = "0x83341C0", VA = "0x1883353C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool PartyChatAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0xB413F0", Offset = "0xB401F0", VA = "0x180B413F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0x8335420", Offset = "0x8334220", VA = "0x188335420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool CanGoToParty
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xB413E0", Offset = "0xB401E0", VA = "0x180B413E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0x8335480", Offset = "0x8334280", VA = "0x188335480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool CanAddToParty
		{
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0xB41400", Offset = "0xB40200", VA = "0x180B41400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0x83354E0", Offset = "0x83342E0", VA = "0x1883354E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public DataList<int> PartyMembers
		{
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0x83359E0", Offset = "0x83347E0", VA = "0x1883359E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public int PartyMemberCount
		{
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0xFFC870", Offset = "0xFFB670", VA = "0x180FFC870")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0x8335540", Offset = "0x8334340", VA = "0x188335540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool HasUnreadPartyChatMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60004ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F3F130", Offset = "0x1F3DF30", VA = "0x181F3F130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0x8335290", Offset = "0x8334090", VA = "0x188335290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x83359A0", Offset = "0x83347A0", VA = "0x1883359A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x8333A30", Offset = "0x8332830", VA = "0x188333A30", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x8334E40", Offset = "0x8333C40", VA = "0x188334E40", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8334F80", Offset = "0x8333D80", VA = "0x188334F80")]
		[AsyncStateMachine(typeof(<OnPartyChanged>d__39))]
		private void OnPartyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x83355A0", Offset = "0x83343A0", VA = "0x1883355A0")]
		[AsyncStateMachine(typeof(<UpdatePartyData>d__40))]
		private Task UpdatePartyData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x83351A0", Offset = "0x8333FA0", VA = "0x1883351A0")]
		private void SetHeight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x8335030", Offset = "0x8333E30", VA = "0x188335030")]
		private void OnPartyChatUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x8333CD0", Offset = "0x8332AD0", VA = "0x188333CD0")]
		[BindableAction(100, null)]
		private void CreateOrJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x83350D0", Offset = "0x8333ED0", VA = "0x1883350D0")]
		[BindableAction(101, null)]
		private void OpenPartyChat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x8334380", Offset = "0x8333180", VA = "0x188334380")]
		[BindableAction(102, null)]
		private void GoToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x8333960", Offset = "0x8332760", VA = "0x188333960")]
		[BindableAction(103, null)]
		private void AddToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x8334D70", Offset = "0x8333B70", VA = "0x188334D70")]
		[BindableAction(104, null)]
		private void ManageParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x8334440", Offset = "0x8333240", VA = "0x188334440", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x8333DA0", Offset = "0x8332BA0", VA = "0x188333DA0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x8335670", Offset = "0x8334470", VA = "0x188335670")]
		public PartyWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class RoomCarouselWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public RoomCarouselWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			private string <widgetId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			private WidgetSourceData <widgetSourceData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x833C3A0", Offset = "0x833B1A0", VA = "0x18833C3A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[SerializeField]
		private RoomListViewModel roomListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x8338B90", Offset = "0x8337990", VA = "0x188338B90", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8338D60", Offset = "0x8337B60", VA = "0x188338D60", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x8338E10", Offset = "0x8337C10", VA = "0x188338E10")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__7))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8338EC0", Offset = "0x8337CC0", VA = "0x188338EC0")]
		public RoomCarouselWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[ViewModel]
	public class RoomCategoryCarouselWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public RoomCategoryCarouselWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private string <widgetId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			private WidgetSourceData <widgetSourceData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x833BE30", Offset = "0x833AC30", VA = "0x18833BE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		[SerializeField]
		private RoomCategoryListViewModel categoryListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x8339300", Offset = "0x8338100", VA = "0x188339300", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x8338F30", Offset = "0x8337D30", VA = "0x188338F30", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x8339190", Offset = "0x8337F90", VA = "0x188339190", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x8339240", Offset = "0x8338040", VA = "0x188339240")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__6))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x8339180", Offset = "0x8337F80", VA = "0x188339180", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x8339100", Offset = "0x8337F00", VA = "0x188339100")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x83392F0", Offset = "0x83380F0", VA = "0x1883392F0")]
		public RoomCategoryCarouselWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[ViewModel]
	public class StoreItemsWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private struct <OnQueryDataLoaded>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x835D030", Offset = "0x835BE30", VA = "0x18835D030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x835D1E0", Offset = "0x835BFE0", VA = "0x18835D1E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private struct <TryLoadingFromActiveSourceList>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0x835DD50", Offset = "0x835CB50", VA = "0x18835DD50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0x835E110", Offset = "0x835CF10", VA = "0x18835E110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[SerializeField]
		private int maxItemsInList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private IAppNavDataManager _appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private List<WidgetSourceData> sourceList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private int activeSectionIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private WidgetSourceData widgetSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		[SerializeField]
		private StoreItemListViewModel storeItemListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private StoreItemListQueryData _queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private DataItem<StoreItemListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private DataItemAction GoToStorePageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		private RoomDTO Room
		{
			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x835AF20", Offset = "0x8359D20", VA = "0x18835AF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		private bool CanShowRelatedStoreItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x835AD30", Offset = "0x8359B30", VA = "0x18835AD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public StoreItemListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0xEF42F0", Offset = "0xEF30F0", VA = "0x180EF42F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x835ABF0", Offset = "0x83599F0", VA = "0x18835ABF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x835AEE0", Offset = "0x8359CE0", VA = "0x18835AEE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x8359DB0", Offset = "0x8358BB0", VA = "0x188359DB0")]
		[BindableAction(100, null)]
		private void GoToStorePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x8359990", Offset = "0x8358790", VA = "0x188359990", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x835A170", Offset = "0x8358F70", VA = "0x18835A170", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x835A330", Offset = "0x8359130", VA = "0x18835A330")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__21))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x835A5D0", Offset = "0x83593D0", VA = "0x18835A5D0")]
		[AsyncStateMachine(typeof(<TryLoadingFromActiveSourceList>d__22))]
		private Task<bool> TryLoadingFromActiveSourceList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x835A3E0", Offset = "0x83591E0", VA = "0x18835A3E0")]
		private bool TryLoadSection(SectionDTO section)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x835A500", Offset = "0x8359300", VA = "0x18835A500")]
		private bool TryLoadSource(string source, string sourceMetadata)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x835A6C0", Offset = "0x83594C0", VA = "0x18835A6C0")]
		private bool TrySetQueryData(string source, string sourceMetadata)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x835A280", Offset = "0x8359080", VA = "0x18835A280")]
		[AsyncStateMachine(typeof(<OnQueryDataLoaded>d__26))]
		private void OnQueryDataLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x8359F80", Offset = "0x8358D80", VA = "0x188359F80", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x8359C40", Offset = "0x8358A40", VA = "0x188359C40")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x835AC60", Offset = "0x8359A60", VA = "0x18835AC60")]
		public StoreItemsWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[ViewModel]
	public class ThisRoomWidgetViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		[SerializeField]
		private Uri thisRoomUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private bool canReportRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private DataItem<bool> CanReportRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private DataItemAction OpenThisRoomPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private DataItemAction GoToDormDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private DataItemAction ReportRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private DataItemAction GoToRecCenterDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x835BF80", Offset = "0x835AD80", VA = "0x18835BF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool CanReportRoom
		{
			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E90", Offset = "0xFBFC90", VA = "0x180FC0E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600053E")]
			[Cpp2IlInjected.Address(RVA = "0x835BFF0", Offset = "0x835ADF0", VA = "0x18835BFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0x835C360", Offset = "0x835B160", VA = "0x18835C360", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x835AF60", Offset = "0x8359D60", VA = "0x18835AF60", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x835C050", Offset = "0x835AE50", VA = "0x18835C050")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x835BC90", Offset = "0x835AA90", VA = "0x18835BC90")]
		[BindableAction(100, null)]
		private void OpenThisRoomPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x835B530", Offset = "0x835A330", VA = "0x18835B530")]
		[BindableAction(101, null)]
		private void GoToDorm()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x835BD50", Offset = "0x835AB50", VA = "0x18835BD50")]
		[BindableAction(102, null)]
		private void ReportRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x835B5E0", Offset = "0x835A3E0", VA = "0x18835B5E0")]
		[BindableAction(103, null)]
		private void GoToRecCenter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x835BC30", Offset = "0x835AA30", VA = "0x18835BC30")]
		private void OnJoinRoomResponse(JoinRoomResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x835B7A0", Offset = "0x835A5A0", VA = "0x18835B7A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x835B1F0", Offset = "0x8359FF0", VA = "0x18835B1F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x835C1B0", Offset = "0x835AFB0", VA = "0x18835C1B0")]
		public ThisRoomWidgetViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class AssetReferenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public AssetReference Asset;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x14914E0", Offset = "0x14902E0", VA = "0x1814914E0")]
		public AssetReferenceInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CreateAssetMenu(fileName = "AssetReferenceLookup", menuName = "RecRoom/UI/Asset Reference Lookup")]
	public class AssetReferenceLookup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		[SerializeField]
		private List<AssetReferenceInfo> assetReferences;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x8341040", Offset = "0x833FE40", VA = "0x188341040")]
		public bool TryGetAssetReference(string assetId, [Out] AssetReference assetReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public AssetReferenceLookup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[ViewModel]
	public class StoreItemListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private struct <FetchData>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public StoreItemListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			private TaskAwaiter<IReadOnlyList<NSVNCQQULFO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x835C3A0", Offset = "0x835B1A0", VA = "0x18835C3A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private static readonly List<UnifiedItemId> ImmediateUnifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public DQHMEXLDKHB OnDataFetched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private IRRUIvNextStoreItemBridge _vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private IStoreItemQueryManager _storeItemListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private CancellationTokenSource _cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private bool _waitingForQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private int _minItemsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		[SerializeField]
		private StoreItemListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private DataList<UnifiedItemId> _storeItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private string _displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private bool _isEmptyOrBelowMinimum;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private DataItem<StoreItemListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private DataItem<bool> IsEmptyOrBelowMinimumDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private DataItemList StoreItemIdsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private DataItemAction GoToViewMorePageDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		public int MinItemsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x2D95BC0", Offset = "0x2D949C0", VA = "0x182D95BC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x8356C90", Offset = "0x8355A90", VA = "0x188356C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		[BindableData(0, "The query data used to retrieve the store item list", DataPermissions.ReadOnly)]
		public StoreItemListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public DataList<UnifiedItemId> StoreItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x8356CC0", Offset = "0x8355AC0", VA = "0x188356CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		[BindableData(2, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0xB88130", Offset = "0xB86F30", VA = "0x180B88130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x8356C10", Offset = "0x8355A10", VA = "0x188356C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool IsEmptyOrBelowMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0xC56160", Offset = "0xC54F60", VA = "0x180C56160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x83567B0", Offset = "0x83555B0", VA = "0x1883567B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x8356BD0", Offset = "0x83559D0", VA = "0x188356BD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x8355FF0", Offset = "0x8354DF0", VA = "0x188355FF0")]
		public void SetDiscoverySectionId(string sectionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x83560A0", Offset = "0x8354EA0", VA = "0x1883560A0")]
		public void SetParentTabName(string parentTabName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x8355770", Offset = "0x8354570", VA = "0x188355770")]
		[BindableAction(100, null)]
		private void GoToViewMorePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x8355140", Offset = "0x8353F40", VA = "0x188355140", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8356730", Offset = "0x8355530", VA = "0x188356730")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x8355F50", Offset = "0x8354D50", VA = "0x188355F50", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x8356220", Offset = "0x8355020", VA = "0x188356220")]
		public void SetQueryData(StoreItemListQueryData listQueryData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8356150", Offset = "0x8354F50", VA = "0x188356150")]
		public void SetPropertiesToDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x8355250", Offset = "0x8354050", VA = "0x188355250")]
		[AsyncStateMachine(typeof(<FetchData>d__35))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x83555D0", Offset = "0x83543D0", VA = "0x1883555D0")]
		private string GetDisplayName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8356350", Offset = "0x8355150", VA = "0x188356350")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x8355AC0", Offset = "0x83548C0", VA = "0x188355AC0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x8355300", Offset = "0x8354100", VA = "0x188355300")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x8356970", Offset = "0x8355770", VA = "0x188356970")]
		public StoreItemListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[ViewModel]
	public class StoreItemViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private struct <FetchStoreItemData>d__54 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public StoreItemViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			private TaskAwaiter<NSVNCQQULFO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x835CC80", Offset = "0x835BA80", VA = "0x18835CC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private static Log Log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private IRRUIvNextStoreItemBridge _vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private Uri itemDetailsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private string _thumbnailImageFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private string costText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private bool isOnSale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private string saleText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private bool isLimitedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private string limitedTimeText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private bool isOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private bool isRecRoomPlusExclusive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private UnifiedItemId storeItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private long price;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private DataItem<string> ThumbnailImageFilenameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private DataItem<string> CostTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private DataItem<bool> IsOnSaleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private DataItem<string> SaleTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private DataItem<bool> IsLimitedTimeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private DataItem<string> LimitedTimeTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private DataItem<bool> IsOwnedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private DataItem<bool> IsRecRoomPlusExclusiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private DataItem<UnifiedItemId> StoreItemIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private DataItem<long> PriceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private DataItemAction GoToDetailsPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x83593F0", Offset = "0x83581F0", VA = "0x1883593F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0x8359910", Offset = "0x8358710", VA = "0x188359910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		[BindableData(1, "The sanitized, friendly name of the store item", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x83594E0", Offset = "0x83582E0", VA = "0x1883594E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		[BindableData(2, "The price of the item (including strikethrough for discounts or 'Owned' if owned)", DataPermissions.ReadOnly)]
		public string CostText
		{
			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x8359460", Offset = "0x8358260", VA = "0x188359460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		[BindableData(3, "Whether or not the item is currently on sale (has a discount)", DataPermissions.ReadOnly)]
		public bool IsOnSale
		{
			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0xB46000", Offset = "0xB44E00", VA = "0x180B46000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x83595C0", Offset = "0x83583C0", VA = "0x1883595C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		[BindableData(4, "Text to show on the sale banner", DataPermissions.ReadOnly)]
		public string SaleText
		{
			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x8359760", Offset = "0x8358560", VA = "0x188359760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		[BindableData(5, "Whether or not to show the 'Limited Time' banner", DataPermissions.ReadOnly)]
		public bool IsLimitedTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x14DD290", Offset = "0x14DC090", VA = "0x1814DD290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x8359560", Offset = "0x8358360", VA = "0x188359560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		[BindableData(6, "Text to show on the 'Limited Time' banner", DataPermissions.ReadOnly)]
		public string LimitedTimeText
		{
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0xEF42F0", Offset = "0xEF30F0", VA = "0x180EF42F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x83596E0", Offset = "0x83584E0", VA = "0x1883596E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		[BindableData(7, "Whether or not the player owns this item", DataPermissions.ReadOnly)]
		public bool IsOwned
		{
			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0xE1D040", Offset = "0xE1BE40", VA = "0x180E1D040")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x8359620", Offset = "0x8358420", VA = "0x188359620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		[BindableData(8, "Whether or not to show the 'Rec Room Plus Exclusive' icon", DataPermissions.ReadOnly)]
		public bool IsRecRoomPlusExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0xC58720", Offset = "0xC57520", VA = "0x180C58720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x8359680", Offset = "0x8358480", VA = "0x188359680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		[BindableData(9, "The ID used to retrieve the IStoreItem from RecNet", DataPermissions.ReadWrite)]
		public UnifiedItemId StoreItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x83584B0", Offset = "0x83572B0", VA = "0x1883584B0")]
			get
			{
				return default(UnifiedItemId);
			}
			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x83597E0", Offset = "0x83585E0", VA = "0x1883597E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		[BindableData(10, "The price of the item after any applicable discounts", DataPermissions.ReadWrite)]
		public long Price
		{
			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xB4EAC0", Offset = "0xB4D8C0", VA = "0x180B4EAC0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x8358500", Offset = "0x8357300", VA = "0x188358500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x83593B0", Offset = "0x83581B0", VA = "0x1883593B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x8357490", Offset = "0x8356290", VA = "0x188357490")]
		[BindableAction(100, null)]
		private void GoToDetailsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x8356D30", Offset = "0x8355B30", VA = "0x188356D30", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x8357F60", Offset = "0x8356D60", VA = "0x188357F60")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x8356E00", Offset = "0x8355C00", VA = "0x188356E00")]
		[AsyncStateMachine(typeof(<FetchStoreItemData>d__54))]
		private void FetchStoreItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x8358570", Offset = "0x8357370", VA = "0x188358570")]
		private void UpdateStoreItemData(NSVNCQQULFO storeItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x8358240", Offset = "0x8357040", VA = "0x188358240")]
		private void ResetStoreItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x83580C0", Offset = "0x8356EC0", VA = "0x1883580C0")]
		private void RecordImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x8357650", Offset = "0x8356450", VA = "0x188357650", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x8356EB0", Offset = "0x8355CB0", VA = "0x188356EB0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x8359020", Offset = "0x8357E20", VA = "0x188359020")]
		public StoreItemViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public enum CarouselType
	{
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		Room,
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		Event,
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		Club,
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		Invention,
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		StoreItem,
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		Account
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public enum HighlightStyle
	{
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		Scale150,
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		Portrait,
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		Scale75,
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		Scale100,
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		FitPerRow4,
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		FitPerRow5,
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		FitPerRow6
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CreateAssetMenu(fileName = "CarouselDisplayConfig", menuName = "RecRoom/UI/CarouselDisplayConfig")]
	public class CarouselDisplayConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public struct HighlightCardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public PlatformMask platformMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public float cardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public float cardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public HighlightStyle HighlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public bool VR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			[ReadOnlyField]
			[TooltipAttribute("Carousel height is driven by the card height. Multi-row room carousels will add one 'Card Height' height per row.")]
			public float carouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public int cardLimit;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public struct CardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			[ReadOnlyField]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public CarouselType CarouselType;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public float carouselTitleHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public float cardMetadataHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			[ReadOnlyField]
			[TooltipAttribute("Carousel height is driven by the card height. Multi-row room carousels will add one 'Default Card Height' height per row.")]
			public float defaultCarouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public float defaultCardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public float defaultCardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public int defaultCardLimitWithScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public int defaultCardLimitWithNoScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public RectOffset singleRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public RectOffset multiRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			[FormerlySerializedAs("rowBottomPadding")]
			[TooltipAttribute("Keep this in sync with the 'item spacing' value in Virtualized Scroll Rect List")]
			public int rowPaddingBottom;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public struct DiscoveryVariantOverrides
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public string variantName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public int cardHeight;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		[SerializeField]
		public List<Uri> Uris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		[SerializeField]
		public bool allowCarouselHighlightingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		[SerializeField]
		public bool allowEnforcingOrderedRenderingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		[SerializeField]
		[TooltipAttribute("Multiplies the number of cards per row by this factor as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		private int dedupingMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		[FormerlySerializedAs("minItemsToFetchPerRow")]
		[SerializeField]
		[TooltipAttribute("Puts a lower bound on number of fetched items as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		private int minItemsToFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		[SerializeField]
		private CardDataObject[] defaultCardList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		[SerializeField]
		private HighlightCardDataObject[] highlightRoomListConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		[SerializeField]
		private DiscoveryVariantOverrides[] discoveryVariantOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		private IRRUIvNextBridge VNextBridge
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x8342160", Offset = "0x8340F60", VA = "0x188342160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x8341FF0", Offset = "0x8340DF0", VA = "0x188341FF0")]
		public bool IsAnyConfiguredUriActive(BrowserModel browserModel)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x83417A0", Offset = "0x83405A0", VA = "0x1883417A0")]
		public float GetCardWidth(HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x83413B0", Offset = "0x83401B0", VA = "0x1883413B0")]
		public float GetCardHeight(HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x83418D0", Offset = "0x83406D0", VA = "0x1883418D0")]
		public float GetCarouselHeight(HighlightStyle highlightStyle, CarouselType carouselType, int numRows = 1, bool addPadding = true)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x8341B20", Offset = "0x8340920", VA = "0x188341B20")]
		public RectOffset GetCarouselPadding(CarouselType carouselType, int numRows)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x8341660", Offset = "0x8340460", VA = "0x188341660")]
		public int GetCardLimitPerRow(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x8341FC0", Offset = "0x8340DC0", VA = "0x188341FC0")]
		public int GetTotalCardLimit(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType, int maxRows = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x8341F10", Offset = "0x8340D10", VA = "0x188341F10")]
		public int GetMinItemsToFetch(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType, int maxRows = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x8341C10", Offset = "0x8340A10", VA = "0x188341C10")]
		private HighlightCardDataObject GetFilteredDataObject(HighlightStyle highlightStyle)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x83411D0", Offset = "0x833FFD0", VA = "0x1883411D0")]
		private HighlightCardDataObject ApplyGameConfigOverrides(HighlightCardDataObject cardDataObject)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x8342140", Offset = "0x8340F40", VA = "0x188342140")]
		public CarouselDisplayConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[ViewModel]
	public class CarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private const int defaultMinItemsToFetch = 20;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private const int defaultCardLimitPerRow = 5;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public const string HighlightStyleDefault = "highlight_default";

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public const string HighlightStyleScale150 = "highlight_scale_150";

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public const string HighlightStylePortrait = "highlight_portrait";

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public const string HighlightStyleScale75 = "highlight_scale_75";

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public const string HighlightStyleScale100 = "highlight_scale_100";

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public const string HighlightStyleFitPerRow4 = "highlight_fitperrow_4";

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public const string HighlightStyleFitPerRow5 = "highlight_fitperrow_5";

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public const string HighlightStyleFitPerRow6 = "highlight_fitperrow_6";

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		[SerializeField]
		private CarouselType carouselType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		[SerializeField]
		private CarouselDisplayConfig displayConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		[SerializeField]
		private DataResolver carouselListResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		[SerializeField]
		private PlatformMask hidePageButtonsOnThesePlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private bool allowHorizontalScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private int rowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private float? heightOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private float? widthOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private HighlightStyle highlightStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private Vector2 cardSizeOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private DiscoveryDisplayMetadata displayMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private string sourceLabelText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private int maxRowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private int maxResultCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private DataItem<bool> AllowHorizontalScrollDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private DataItem<int> RowCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private DataItem<float?> HeightOverrideDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private DataItem<float?> WidthOverrideDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private DataItem<string> BackgroundColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private DataItem<HighlightStyle> HighlightStyleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private DataItem<Vector2> CardSizeOverrideDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool AllowHorizontalScroll
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xD7C780", Offset = "0xD7B580", VA = "0x180D7C780")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x8343A10", Offset = "0x8342810", VA = "0x188343A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		[BindableData(1, "Number of rows in the carousel", DataPermissions.ReadWrite)]
		public int RowCount
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0xD857B0", Offset = "0xD845B0", VA = "0x180D857B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x8343A70", Offset = "0x8342870", VA = "0x188343A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		[BindableData(2, "The height override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? HeightOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x81910A0", Offset = "0x818FEA0", VA = "0x1881910A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x8343F30", Offset = "0x8342D30", VA = "0x188343F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		[BindableData(3, "The width override value, or null if there isn't one. Typically used for card width.", DataPermissions.ReadWrite)]
		public float? WidthOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x1C96F00", Offset = "0x1C95D00", VA = "0x181C96F00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x8343FC0", Offset = "0x8342DC0", VA = "0x188343FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		[BindableData(4, "Background color of the carousel", DataPermissions.ReadWrite)]
		public string BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x8343E20", Offset = "0x8342C20", VA = "0x188343E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		[BindableData(5, "Card Highlight Style", DataPermissions.ReadWrite)]
		public HighlightStyle HighlightStyle
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0xAC4860", Offset = "0xAC3660", VA = "0x180AC4860")]
			get
			{
				return default(HighlightStyle);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x8343980", Offset = "0x8342780", VA = "0x188343980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		[BindableData(6, "The card width and height override value, or null if there isn't one. Used when overriding width alone is insufficient.", DataPermissions.ReadWrite)]
		public Vector2 CardSizeOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x83439E0", Offset = "0x83427E0", VA = "0x1883439E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x8343EA0", Offset = "0x8342CA0", VA = "0x188343EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public int NumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xB5CDB0", Offset = "0xB5BBB0", VA = "0x180B5CDB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xB5C740", Offset = "0xB5B540", VA = "0x180B5C740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public int MaxItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0xB72C70", Offset = "0xB71A70", VA = "0x180B72C70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x8343DE0", Offset = "0x8342BE0", VA = "0x188343DE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x83421E0", Offset = "0x8340FE0", VA = "0x1883421E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x83438D0", Offset = "0x83426D0", VA = "0x1883438D0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8342460", Offset = "0x8341260", VA = "0x188342460")]
		public void ConfigureCarousel(DiscoveryDisplayMetadata displayMetadata, string sourceLabelText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x83422A0", Offset = "0x83410A0", VA = "0x1883422A0")]
		private int CalculateNumItemsToFetch()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x8343050", Offset = "0x8341E50", VA = "0x188343050")]
		private HighlightStyle GetHighlightStyle()
		{
			return default(HighlightStyle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8343840", Offset = "0x8342640", VA = "0x188343840")]
		private void OnCarouselListUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x8342660", Offset = "0x8341460", VA = "0x188342660")]
		private void FinishCarouselInit(int totalNumCards)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8343140", Offset = "0x8341F40", VA = "0x188343140", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x8342CA0", Offset = "0x8341AA0", VA = "0x188342CA0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x8343B00", Offset = "0x8342900", VA = "0x188343B00")]
		public CarouselViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public class DiscoveryDisplayMetadata : BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public string DisplayTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public bool supportsDedupe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public int numRows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public string sizePerPlatform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public bool horizontalScrollEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public int itemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public string cardStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public int minItemsToShowSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public string textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public string sessionSectionIdOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public string descriptionText;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x834EFF0", Offset = "0x834DDF0", VA = "0x18834EFF0")]
		public DiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[ViewModel]
	public class ConsumableListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		[SerializeField]
		private IRRUIvNextConsumableBridge.ConsumableCategory listType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		[SerializeField]
		private Route shopRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private IRRUIvNextConsumableBridge consumableBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private DataList<QFRCSVHRAFM> consumableList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private DataItemList ConsumableListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private DataItemAction OpenShopDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<QFRCSVHRAFM> ConsumableList
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x8349A00", Offset = "0x8348800", VA = "0x188349A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x83499C0", Offset = "0x83487C0", VA = "0x1883499C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x83493F0", Offset = "0x83481F0", VA = "0x1883493F0")]
		[BindableAction(1, null)]
		public void OpenShop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x8348D10", Offset = "0x8347B10", VA = "0x188348D10", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x83492E0", Offset = "0x83480E0", VA = "0x1883492E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x83492D0", Offset = "0x83480D0", VA = "0x1883492D0")]
		private void OnActiveConsumableChanged(QFRCSVHRAFM _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x83492D0", Offset = "0x83480D0", VA = "0x1883492D0")]
		private void OnPurchasedConsumableChanged(QFRCSVHRAFM _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x8349580", Offset = "0x8348380", VA = "0x188349580")]
		private void RefreshConsumableList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x83490E0", Offset = "0x8347EE0", VA = "0x1883490E0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x8348F70", Offset = "0x8347D70", VA = "0x188348F70")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x83498B0", Offset = "0x83486B0", VA = "0x1883498B0")]
		public ConsumableListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[ViewModel]
	public class ConsumableViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private IRRUIvNextConsumableBridge consumableBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private QFRCSVHRAFM consumable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private RQQQIGIPNON mainImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private bool isActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private DataItem<RQQQIGIPNON> MainImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private DataItem<int> CountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private DataItem<bool> IsActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private DataItemAction UseConsumableDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x834B190", Offset = "0x8349F90", VA = "0x18834B190", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public RQQQIGIPNON MainImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x834ACD0", Offset = "0x8349AD0", VA = "0x18834ACD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0xFABA20", Offset = "0xFAA820", VA = "0x180FABA20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x834AD30", Offset = "0x8349B30", VA = "0x18834AD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xD7C780", Offset = "0xD7B580", VA = "0x180D7C780")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x834AD90", Offset = "0x8349B90", VA = "0x18834AD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x834B150", Offset = "0x8349F50", VA = "0x18834B150", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x834ADF0", Offset = "0x8349BF0", VA = "0x18834ADF0")]
		[BindableAction(0, null)]
		public void UseConsumable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8349A70", Offset = "0x8348870", VA = "0x188349A70", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x834A6C0", Offset = "0x83494C0", VA = "0x18834A6C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x834A1D0", Offset = "0x8348FD0", VA = "0x18834A1D0")]
		private void OnActiveConsumableChanged(QFRCSVHRAFM consumable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x834AC00", Offset = "0x8349A00", VA = "0x18834AC00", Slot = "14")]
		public override void SetBindingData(int sourceId, int itemId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x834A770", Offset = "0x8349570", VA = "0x18834A770")]
		private void RefreshData(QFRCSVHRAFM config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x834A1F0", Offset = "0x8348FF0", VA = "0x18834A1F0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x8349E00", Offset = "0x8348C00", VA = "0x188349E00", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x8349BB0", Offset = "0x83489B0", VA = "0x188349BB0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x834B000", Offset = "0x8349E00", VA = "0x18834B000")]
		public ConsumableViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public class GlobalDataViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private int localAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private long localRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private long localRoomEventId;

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int LocalAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0xADBF60", Offset = "0xADAD60", VA = "0x180ADBF60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x834F620", Offset = "0x834E420", VA = "0x18834F620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public long LocalRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x834F6D0", Offset = "0x834E4D0", VA = "0x18834F6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public long LocalRoomEventId
		{
			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x834F670", Offset = "0x834E470", VA = "0x18834F670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x834F4B0", Offset = "0x834E2B0", VA = "0x18834F4B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x834F000", Offset = "0x834DE00", VA = "0x18834F000", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x834F160", Offset = "0x834DF60", VA = "0x18834F160")]
		private void OnLocalAccountUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x834F2B0", Offset = "0x834E0B0", VA = "0x18834F2B0")]
		private void OnLocalRoomChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x834F600", Offset = "0x834E400", VA = "0x18834F600")]
		public GlobalDataViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public class LongPressInteractable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		[SerializeField]
		protected float longPressDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public DQHMEXLDKHB OnLongClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public DQHMEXLDKHB OnShortClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float pressStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected bool pointerInside;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xF21460", Offset = "0xF20260", VA = "0x180F21460", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x19C7760", Offset = "0x19C6560", VA = "0x1819C7760", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x834F730", Offset = "0x834E530", VA = "0x18834F730", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x834F750", Offset = "0x834E550", VA = "0x18834F750", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x834F7B0", Offset = "0x834E5B0", VA = "0x18834F7B0")]
		public LongPressInteractable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[ViewModel]
	public class CategoriesNestedItem : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private IMakerPenHUDBridge hudBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private int absoluteIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private CategoriesNestedListItem item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private bool isExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private Sprite activeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private int depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private DataItem<string> TextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private DataItem<bool> IsExpandedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private DataItem<Sprite> ActiveIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private DataItem<int> DepthDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private DataItemAction SelectItemDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		private CategoriesNestedListConfig config
		{
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x8345240", Offset = "0x8344040", VA = "0x188345240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x83451D0", Offset = "0x8343FD0", VA = "0x1883451D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0x8345340", Offset = "0x8344140", VA = "0x188345340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0xB41420", Offset = "0xB40220", VA = "0x180B41420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x8344EF0", Offset = "0x8343CF0", VA = "0x188344EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public Sprite ActiveIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x8345290", Offset = "0x8344090", VA = "0x188345290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0xFFC870", Offset = "0xFFB670", VA = "0x180FFC870")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x8344F60", Offset = "0x8343D60", VA = "0x188344F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x8345190", Offset = "0x8343F90", VA = "0x188345190", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x8344050", Offset = "0x8342E50", VA = "0x188344050", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x8344B90", Offset = "0x8343990", VA = "0x188344B90", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x8344BC0", Offset = "0x83439C0", VA = "0x188344BC0")]
		[BindableAction(2, null)]
		public void SelectItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x8344820", Offset = "0x8343620", VA = "0x188344820")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x8344370", Offset = "0x8343170", VA = "0x188344370", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x83440A0", Offset = "0x8342EA0", VA = "0x1883440A0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x8344FC0", Offset = "0x8343DC0", VA = "0x188344FC0")]
		public CategoriesNestedItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[ViewModel]
	public class CategoriesNestedList : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private IMakerPenHUDBridge hudBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private DataList<int> activeIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private DataItemList ActiveIndicesDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		private CategoriesNestedListConfig config
		{
			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x8347340", Offset = "0x8346140", VA = "0x188347340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> ActiveIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x8347390", Offset = "0x8346190", VA = "0x188347390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x8347310", Offset = "0x8346110", VA = "0x188347310", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x8346980", Offset = "0x8345780", VA = "0x188346980", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x8346EA0", Offset = "0x8345CA0", VA = "0x188346EA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x83470A0", Offset = "0x8345EA0", VA = "0x1883470A0")]
		private void OnIndexStateChanged(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x8346D50", Offset = "0x8345B50", VA = "0x188346D50", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8346C50", Offset = "0x8345A50", VA = "0x188346C50")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x8347240", Offset = "0x8346040", VA = "0x188347240")]
		public CategoriesNestedList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[ViewModel]
	public class ColorPickerCardViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private ShapeColorInfo shapeColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private string colorName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private DataItem<int> IndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private DataItem<string> ColorNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private DataItem<Color> ColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private DataItemAction SelectDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x8348310", Offset = "0x8347110", VA = "0x188348310", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		[BindableData(1, "Which slot in the color picker this represents", DataPermissions.ReadOnly)]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xAE56C0", Offset = "0xAE44C0", VA = "0x180AE56C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x83484C0", Offset = "0x83472C0", VA = "0x1883484C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		[BindableData(2, "Color Name", DataPermissions.ReadOnly)]
		public string ColorName
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x8348380", Offset = "0x8347180", VA = "0x188348380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		[BindableData(3, "Color", DataPermissions.ReadOnly)]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0x2121300", Offset = "0x2120100", VA = "0x182121300")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0x8348400", Offset = "0x8347200", VA = "0x188348400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		[BindableData(5, "IsSelected", DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD60", Offset = "0xAECB60", VA = "0x180AEDD60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x8348510", Offset = "0x8347310", VA = "0x188348510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x83482D0", Offset = "0x83470D0", VA = "0x1883482D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x8347DE0", Offset = "0x8346BE0", VA = "0x188347DE0")]
		[BindableAction(4, "Selects Color")]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8347EF0", Offset = "0x8346CF0", VA = "0x188347EF0")]
		private void SetData(ShapeColorInfo colorInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x8347FE0", Offset = "0x8346DE0", VA = "0x188347FE0")]
		private void UpdateSelectionState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x8347B70", Offset = "0x8346970", VA = "0x188347B70")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x83473F0", Offset = "0x83461F0", VA = "0x1883473F0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x8347D10", Offset = "0x8346B10", VA = "0x188347D10", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x8347B60", Offset = "0x8346960", VA = "0x188347B60")]
		private void OnColorPickerCardSelected(int selectedIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x83477A0", Offset = "0x83465A0", VA = "0x1883477A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x83474D0", Offset = "0x83462D0", VA = "0x1883474D0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x8348130", Offset = "0x8346F30", VA = "0x188348130")]
		public ColorPickerCardViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[ViewModel]
	public class ColorPickerListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[CompilerGenerated]
		private sealed class <SelectFirstItem>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public ColorPickerListViewModel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170001B1")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600067A")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001B2")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600067C")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <SelectFirstItem>d__10(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x835DA90", Offset = "0x835C890", VA = "0x18835DA90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x835DD10", Offset = "0x835CB10", VA = "0x18835DD10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[SerializeField]
		private InfiniteListViewControllerBase listController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private List<ShapeColorInfo> allColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private Coroutine selectFirstItemCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private DataList<ShapeColorInfo> colors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private DataItemList ColorsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<ShapeColorInfo> Colors
		{
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x8348CA0", Offset = "0x8347AA0", VA = "0x188348CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x8348C60", Offset = "0x8347A60", VA = "0x188348C60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x8348570", Offset = "0x8347370", VA = "0x188348570", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x83488F0", Offset = "0x83476F0", VA = "0x1883488F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x8348980", Offset = "0x8347780", VA = "0x188348980")]
		private void RefreshList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8348A40", Offset = "0x8347840", VA = "0x188348A40")]
		[IteratorStateMachine(typeof(<SelectFirstItem>d__10))]
		private IEnumerator SelectFirstItem()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x83487A0", Offset = "0x83475A0", VA = "0x1883487A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x83486A0", Offset = "0x83474A0", VA = "0x1883486A0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8348B80", Offset = "0x8347980", VA = "0x188348B80")]
		public ColorPickerListViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class CategoriesNestedListItem : ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public string Text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public bool IsExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public Sprite ExpandedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public Sprite CollapsedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CategoriesFilter Filter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		[Header("All children of the same parent should have both icons set, or none")]
		public List<CategoriesNestedListItem> Children;

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x83465E0", Offset = "0x83453E0", VA = "0x1883465E0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x83468E0", Offset = "0x83456E0", VA = "0x1883468E0")]
		public CategoriesNestedListItem()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public struct CategoriesFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public CategoriesFilterType filterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		[TooltipAttribute("Metadata for filterType = PaletteSearchFilter")]
		public string paletteSearchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		[TooltipAttribute("Metadata for paletteSortOption = SortOption")]
		public SortOption paletteSortOption;
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public enum CategoriesFilterType
	{
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		PaletteSearchFilter,
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		Favorites,
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		RoomInventions
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CreateAssetMenu(fileName = "CategoriesNestedListConfig", menuName = "RRUI/MakerPenHUD/Nested List/Categories Nested List Config")]
	public class CategoriesNestedListConfig : ScriptableObject, XVUGTQIMLRL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		[SerializeField]
		private List<CategoriesNestedListItem> nestedListItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private List<CategoriesNestedListItem> clonedNestedListItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private List<int> activeIndices;

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public List<CategoriesNestedListItem> ListItems
		{
			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public OZAYXQWBYWY<int> OnIndexExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public OZAYXQWBYWY<int> OnIndexCollapsed
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public OZAYXQWBYWY<int> OnIndexSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x83455A0", Offset = "0x83443A0", VA = "0x1883455A0", Slot = "6")]
		public List<int> GetActiveIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x8345FA0", Offset = "0x8344DA0", VA = "0x188345FA0")]
		private void SetActiveIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x83455F0", Offset = "0x83443F0", VA = "0x1883455F0", Slot = "7")]
		public int GetDepth(int idx)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x8345910", Offset = "0x8344710", VA = "0x188345910", Slot = "8")]
		public bool IsChild(int parentIdx, int childIdx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x83459C0", Offset = "0x83447C0", VA = "0x1883459C0", Slot = "9")]
		public bool IsExpanded(int idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x8345A20", Offset = "0x8344820", VA = "0x188345A20", Slot = "10")]
		public bool IsParent(int childIdx, int parentIdx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x8345EE0", Offset = "0x8344CE0", VA = "0x188345EE0")]
		public void Select(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x83454B0", Offset = "0x83442B0", VA = "0x1883454B0")]
		public void Expand(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x83453C0", Offset = "0x83441C0", VA = "0x1883453C0")]
		public void Collapse(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x8345B20", Offset = "0x8344920", VA = "0x188345B20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x83456E0", Offset = "0x83444E0", VA = "0x1883456E0")]
		private bool IconsSetConsistently(List<CategoriesNestedListItem> items)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x8345AD0", Offset = "0x83448D0", VA = "0x188345AD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x83464F0", Offset = "0x83452F0", VA = "0x1883464F0")]
		public CategoriesNestedListConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[ViewModel]
	public class CreateModeHotbarListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		[SerializeField]
		private InfiniteListViewControllerBase listViewController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private UYBXJKUPTWR manager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private DataList<NBURWBPKKDU> hotbarEntries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private DataItemList HotbarEntriesDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<NBURWBPKKDU> HotbarEntries
		{
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000697")]
			[Cpp2IlInjected.Address(RVA = "0x834C4D0", Offset = "0x834B2D0", VA = "0x18834C4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006A0")]
			[Cpp2IlInjected.Address(RVA = "0x834C490", Offset = "0x834B290", VA = "0x18834C490", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x834B200", Offset = "0x834A000", VA = "0x18834B200", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x834B700", Offset = "0x834A500", VA = "0x18834B700", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x834BA70", Offset = "0x834A870", VA = "0x18834BA70")]
		private void OnHotbarSlotSelected(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x834B980", Offset = "0x834A780", VA = "0x18834B980")]
		private void OnHotbarSelectionCleared()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x834BCF0", Offset = "0x834AAF0", VA = "0x18834BCF0")]
		private void OnSlotsChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x834BC70", Offset = "0x834AA70", VA = "0x18834BC70")]
		private void OnPaletteToggled(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x834BB70", Offset = "0x834A970", VA = "0x18834BB70")]
		private void OnObjectCreated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x834C0A0", Offset = "0x834AEA0", VA = "0x18834C0A0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x834B5B0", Offset = "0x834A3B0", VA = "0x18834B5B0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x834B4B0", Offset = "0x834A2B0", VA = "0x18834B4B0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x834C3B0", Offset = "0x834B1B0", VA = "0x18834C3B0")]
		public CreateModeHotbarListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[ViewModel]
	public class CreateModeHotbarSlotViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		[CompilerGenerated]
		private struct <RefreshIcon>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public NBURWBPKKDU entry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public CreateModeHotbarSlotViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0x835D790", Offset = "0x835C590", VA = "0x18835D790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0x835DA30", Offset = "0x835C830", VA = "0x18835DA30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private UYBXJKUPTWR manager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private NBURWBPKKDU hotbarEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private Texture image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private bool isImageSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x92")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private bool isPaletteOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x93")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private bool? isSelectedAndPaletteNotOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private DataItem<int> IndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private DataItem<Texture> ImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private DataItem<bool> IsImageSetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private DataItem<bool> IsPaletteOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private DataItem<bool> IsSelectedAndPaletteNotOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private DataItem<bool> CanSelectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private DataItem<bool> CanShowEmptyPlusIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private DataItem<bool> CanShowRecNetImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private DataItemAction SelectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private DataItemAction ClickDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x834EB30", Offset = "0x834D930", VA = "0x18834EB30", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		[BindableData(1, "Which slot in the hotbar this represents", DataPermissions.ReadOnly)]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0xFABA20", Offset = "0xFAA820", VA = "0x180FABA20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0x834ED40", Offset = "0x834DB40", VA = "0x18834ED40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		[BindableData(2, "The image that should be displayed for this hotbar item", DataPermissions.ReadOnly)]
		public Texture Image
		{
			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x834EC60", Offset = "0x834DA60", VA = "0x18834EC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		[BindableData(3, "Whether or not this is selected", DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0xE9F850", Offset = "0xE9E650", VA = "0x180E9F850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0x834EF10", Offset = "0x834DD10", VA = "0x18834EF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		[BindableData(5, "Whether or not the Image property is set", DataPermissions.ReadOnly)]
		public bool IsImageSet
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xE9F860", Offset = "0xE9E660", VA = "0x180E9F860")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x834EDA0", Offset = "0x834DBA0", VA = "0x18834EDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		[BindableData(6, "Whether or not the palette is open", DataPermissions.ReadOnly)]
		public bool IsPaletteOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0x832ABA0", Offset = "0x83299A0", VA = "0x18832ABA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0x834DBB0", Offset = "0x834C9B0", VA = "0x18834DBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		[BindableData(7, "Whether or not this is selected", DataPermissions.ReadOnly)]
		public bool IsSelectedAndPaletteNotOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x834E370", Offset = "0x834D170", VA = "0x18834E370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x834EE60", Offset = "0x834DC60", VA = "0x18834EE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		[BindableData(8, "Whether or not we can select this item", DataPermissions.ReadOnly)]
		public bool CanSelect
		{
			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0x1B2E7D0", Offset = "0x1B2D5D0", VA = "0x181B2E7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60006B5")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006B6")]
			[Cpp2IlInjected.Address(RVA = "0x834EBA0", Offset = "0x834D9A0", VA = "0x18834EBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		[BindableData(11, "Whether or not we should show the Plus Icon on empty slot", DataPermissions.ReadOnly)]
		public bool CanShowEmptyPlusIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0x834E420", Offset = "0x834D220", VA = "0x18834E420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		[BindableData(12, "Whether or not we should show the recnet Image for invention's icon", DataPermissions.ReadOnly)]
		public bool CanShowRecNetImage
		{
			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0x834E350", Offset = "0x834D150", VA = "0x18834E350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x834EAF0", Offset = "0x834D8F0", VA = "0x18834EAF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x834DD60", Offset = "0x834CB60", VA = "0x18834DD60")]
		[BindableAction(4, "Selects this hotbar item")]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x834C710", Offset = "0x834B510", VA = "0x18834C710")]
		[BindableAction(10, "Invoked when the hotbar slot is clicked")]
		public void Click()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x834C540", Offset = "0x834B340", VA = "0x18834C540", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x834D9D0", Offset = "0x834C7D0", VA = "0x18834D9D0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x834DB90", Offset = "0x834C990", VA = "0x18834DB90")]
		private void OnHotbarSlotSelected(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x834DB80", Offset = "0x834C980", VA = "0x18834DB80")]
		private void OnHotbarSelectionCleared()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x834DBB0", Offset = "0x834C9B0", VA = "0x18834DBB0")]
		private void OnPaletteToggled(bool isOpen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x834DE10", Offset = "0x834CC10", VA = "0x18834DE10")]
		private void SetData(NBURWBPKKDU entry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x834DC70", Offset = "0x834CA70", VA = "0x18834DC70")]
		[AsyncStateMachine(typeof(<RefreshIcon>d__47))]
		private Task RefreshIcon(NBURWBPKKDU entry)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x834D8B0", Offset = "0x834C6B0", VA = "0x18834D8B0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x834E0C0", Offset = "0x834CEC0", VA = "0x18834E0C0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x834E440", Offset = "0x834D240", VA = "0x18834E440")]
		private void UpdateData(NBURWBPKKDU hotbarEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x834D6C0", Offset = "0x834C4C0", VA = "0x18834D6C0")]
		private void LogClick(bool forRemoval = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x834CE30", Offset = "0x834BC30", VA = "0x18834CE30", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x834C850", Offset = "0x834B650", VA = "0x18834C850")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x834E7C0", Offset = "0x834D5C0", VA = "0x18834E7C0")]
		public CreateModeHotbarSlotViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[ViewModel]
	public class MakerPenHUDConfigureViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private NGXBIJEPJWX _configurable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private bool _hasConfigurable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private string _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private string _subtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		[SerializeField]
		private bool isAdvancedMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private bool _isAdvancedMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private DataList<OJLHAOSJPLF> _dynamicUIElements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private bool _isDynamicUIElementsEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private ToastListModel _toastListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private DialogListModel _dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private IMakerPenHUDBridge _makerPenHUDBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private DataItem<NGXBIJEPJWX> ConfigurableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private DataItem<bool> HasConfigurableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private DataItem<string> TitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private DataItem<string> SubtitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private DataItem<bool> IsAdvancedModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private DataItem<bool> IsDynamicUIElementsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private DataItemList DynamicUIElementsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private DataItemAction ResetConfigurableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private DataItemAction CollapseAllFoldoutsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private DataItemAction ExpandAllFoldoutsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public NGXBIJEPJWX Configurable
		{
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0x8351EF0", Offset = "0x8350CF0", VA = "0x188351EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		[BindableData(1, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool HasConfigurable
		{
			[Cpp2IlInjected.Token(Token = "0x60006DC")]
			[Cpp2IlInjected.Address(RVA = "0xC5E3C0", Offset = "0xC5D1C0", VA = "0x180C5E3C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006DD")]
			[Cpp2IlInjected.Address(RVA = "0x83514F0", Offset = "0x83502F0", VA = "0x1883514F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		[BindableData(2, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006DF")]
			[Cpp2IlInjected.Address(RVA = "0x8351550", Offset = "0x8350350", VA = "0x188351550")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		[BindableData(3, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Subtitle
		{
			[Cpp2IlInjected.Token(Token = "0x60006E0")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(RVA = "0x8352010", Offset = "0x8350E10", VA = "0x188352010")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool IsAdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(RVA = "0xB413F0", Offset = "0xB401F0", VA = "0x180B413F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(RVA = "0x83515D0", Offset = "0x83503D0", VA = "0x1883515D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		[BindableData(5, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public DataList<OJLHAOSJPLF> DynamicUIElements
		{
			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x8351FA0", Offset = "0x8350DA0", VA = "0x188351FA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		[BindableData(6, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsDynamicUIElementsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD60", Offset = "0xAECB60", VA = "0x180AEDD60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x83513C0", Offset = "0x83501C0", VA = "0x1883513C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x8351EB0", Offset = "0x8350CB0", VA = "0x188351EB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x8351170", Offset = "0x834FF70", VA = "0x188351170")]
		private void Register(NGXBIJEPJWX configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x8351640", Offset = "0x8350440", VA = "0x188351640")]
		private void Unregister(NGXBIJEPJWX configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x834F860", Offset = "0x834E660", VA = "0x18834F860", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x8350D50", Offset = "0x834FB50", VA = "0x188350D50", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x8350EF0", Offset = "0x834FCF0", VA = "0x188350EF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x8350EA0", Offset = "0x834FCA0", VA = "0x188350EA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x8350FC0", Offset = "0x834FDC0", VA = "0x188350FC0")]
		private void OnMakerPenConfigMenuDataChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x8351050", Offset = "0x834FE50", VA = "0x188351050")]
		private void OnRRUIPageContainerEnabledChanged(bool isEnabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x8351020", Offset = "0x834FE20", VA = "0x188351020")]
		private void OnObjectSettingsToast(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x8351060", Offset = "0x834FE60", VA = "0x188351060")]
		private void OnShowDialog(DialogType dialogType, WLXQNZZPBQO dialogData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x8350EB0", Offset = "0x834FCB0", VA = "0x188350EB0")]
		private void OnDismissAllDialogs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x8350EE0", Offset = "0x834FCE0", VA = "0x188350EE0")]
		private void OnDynamicUIElementsChanged(NGXBIJEPJWX configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x8350F50", Offset = "0x834FD50", VA = "0x188350F50")]
		private void OnForceRefreshConfigUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x8351850", Offset = "0x8350650", VA = "0x188351850")]
		private void UpdateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x834FAA0", Offset = "0x834E8A0", VA = "0x18834FAA0")]
		private void ClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x8351370", Offset = "0x8350170", VA = "0x188351370")]
		[BindableAction(100, null)]
		public void ResetConfigurable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x834FBE0", Offset = "0x834E9E0", VA = "0x18834FBE0")]
		[BindableAction(101, null)]
		public void CollapseAllFoldouts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x834FE00", Offset = "0x834EC00", VA = "0x18834FE00")]
		[BindableAction(102, null)]
		public void ExpandAllFoldouts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x8350520", Offset = "0x834F320", VA = "0x188350520", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x8350020", Offset = "0x834EE20", VA = "0x188350020")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x8351BC0", Offset = "0x83509C0", VA = "0x188351BC0")]
		public MakerPenHUDConfigureViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[ViewModel]
	public class MakerPenHUDCreateToolbarViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		[SerializeField]
		private FocusableUI toolbarFocusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private bool leftModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private bool rightModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private bool rightModifierHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private IRRUIvNextBridge rruiBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private UYBXJKUPTWR manager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private bool hasFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private float holdInputProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private bool showHoldIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private bool paletteButtonSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private bool paletteButtonSelectedOrPaletteOpen;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private const string openPaletteButtonName = "Open Palette";

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private const string closePaletteButtonName = "Close Palette";

		[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private bool paletteIsOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private string toolDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private DataItem<bool> HasFocusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private DataItem<float> HoldInputProgressDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private DataItem<bool> ShowHoldIndicatorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private DataItem<bool> PaletteButtonSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private DataItem<bool> PaletteButtonSelectedOrPaletteOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private DataItem<bool> PaletteButtonSelectedAndPaletteClosedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private DataItem<bool> PaletteIsOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private DataItem<bool> CreateModeRecolorIsAvailableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private DataItem<string> ToolDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private DataItemAction GoToPaletteModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private DataItemAction ClickPaletteButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private DataItemAction ClickRecolorButtonDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		private bool shouldFocus
		{
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x8354F60", Offset = "0x8353D60", VA = "0x188354F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		[BindableData(200, null, DataPermissions.ReadWrite)]
		public bool HasFocus
		{
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0xE9F850", Offset = "0xE9E650", VA = "0x180E9F850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x8354850", Offset = "0x8353650", VA = "0x188354850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		[BindableData(201, null, DataPermissions.ReadWrite)]
		public float HoldInputProgress
		{
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0xF421D0", Offset = "0xF40FD0", VA = "0x180F421D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x83548B0", Offset = "0x83536B0", VA = "0x1883548B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		[BindableData(202, null, DataPermissions.ReadWrite)]
		public bool ShowHoldIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD60", Offset = "0xAECB60", VA = "0x180AEDD60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x8354920", Offset = "0x8353720", VA = "0x188354920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		[BindableData(203, null, DataPermissions.ReadWrite)]
		public bool PaletteButtonSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x2238F50", Offset = "0x2237D50", VA = "0x182238F50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x8354980", Offset = "0x8353780", VA = "0x188354980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		[BindableData(204, null, DataPermissions.ReadWrite)]
		public bool PaletteButtonSelectedOrPaletteOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x1866490", Offset = "0x1865290", VA = "0x181866490")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x8354A50", Offset = "0x8353850", VA = "0x188354A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		[BindableData(205, "True if the palette button is selected and the palette is closed", DataPermissions.ReadOnly)]
		public bool PaletteButtonSelectedAndPaletteClosed
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x8354830", Offset = "0x8353630", VA = "0x188354830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		[BindableData(3, "True if the palette is currently open", DataPermissions.ReadOnly)]
		public bool PaletteIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x18664A0", Offset = "0x18652A0", VA = "0x1818664A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x8355010", Offset = "0x8353E10", VA = "0x188355010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		[BindableData(4, "Recolor in create mode is not yet supported", DataPermissions.ReadOnly)]
		public bool CreateModeRecolorIsAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		[BindableData(5, "ToolDescription", DataPermissions.ReadOnly)]
		public string ToolDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x83550E0", Offset = "0x8353EE0", VA = "0x1883550E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x8354F20", Offset = "0x8353D20", VA = "0x188354F20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x8352EE0", Offset = "0x8351CE0", VA = "0x188352EE0")]
		[BindableAction(6, null)]
		public void GoToPaletteMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x8353E20", Offset = "0x8352C20", VA = "0x188353E20")]
		private void OnLeftNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x8354230", Offset = "0x8353030", VA = "0x188354230")]
		private void OnRightNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x8354B10", Offset = "0x8353910", VA = "0x188354B10")]
		private void UpdateInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x8352090", Offset = "0x8350E90", VA = "0x188352090", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x83539E0", Offset = "0x83527E0", VA = "0x1883539E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x8352740", Offset = "0x8351540", VA = "0x188352740")]
		[BindableAction(1, "Invoked when the palette button is clicked")]
		public void ClickPaletteButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x8354040", Offset = "0x8352E40", VA = "0x188354040")]
		private void OnPaletteToggled(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x8353980", Offset = "0x8352780", VA = "0x188353980")]
		private void OnCursorActiveChanged(bool active)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		[BindableAction(2, "Invoked when the recolor button is clicked")]
		public void ClickRecolorButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x8354500", Offset = "0x8353300", VA = "0x188354500")]
		private void OnStampModeChanged(bool mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x8354AB0", Offset = "0x83538B0", VA = "0x188354AB0")]
		private void UpdateCreateModeContextualBarData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x83545A0", Offset = "0x83533A0", VA = "0x1883545A0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x8353860", Offset = "0x8352660", VA = "0x188353860")]
		private void LogClick(string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x8352F60", Offset = "0x8351D60", VA = "0x188352F60", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x8352900", Offset = "0x8351700", VA = "0x188352900")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x8354C30", Offset = "0x8353A30", VA = "0x188354C30")]
		public MakerPenHUDCreateToolbarViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[ViewModel]
	public class MakerPenHUDPaletteListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		private enum PaletteCategory
		{
			[Cpp2IlInjected.Token(Token = "0x40004D4")]
			Favorites,
			[Cpp2IlInjected.Token(Token = "0x40004D5")]
			AllObjects,
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			RoomInventions
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		[SerializeField]
		private InfiniteListViewControllerBase listController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private PaletteCategory currentCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private DataList<JODUULFIMNR> placableObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private DataItemList PlacableObjectsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		private UZTLNYWPAHA paletteDataStore
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x835F820", Offset = "0x835E620", VA = "0x18835F820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<JODUULFIMNR> PlacableObjects
		{
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x835F870", Offset = "0x835E670", VA = "0x18835F870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x835F7E0", Offset = "0x835E5E0", VA = "0x18835F7E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x835E220", Offset = "0x835D020", VA = "0x18835E220", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x835E800", Offset = "0x835D600", VA = "0x18835E800", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x835EC00", Offset = "0x835DA00", VA = "0x18835EC00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x835EBB0", Offset = "0x835D9B0", VA = "0x18835EBB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x835F0A0", Offset = "0x835DEA0", VA = "0x18835F0A0")]
		private void RefreshList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x835ED40", Offset = "0x835DB40", VA = "0x18835ED40")]
		private void OnObjectsCategoryRequested(string paletteSearchFilter, SortOption paletteSortOption)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x835ECB0", Offset = "0x835DAB0", VA = "0x18835ECB0")]
		private void OnFavoritesCategoryRequested()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x835EF80", Offset = "0x835DD80", VA = "0x18835EF80")]
		private void OnRoomInventionsCategoryRequested()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x835EF70", Offset = "0x835DD70", VA = "0x18835EF70")]
		private void OnPaletteToggled(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x835F4D0", Offset = "0x835E2D0", VA = "0x18835F4D0")]
		private void SelectFirstGridItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x835EDF0", Offset = "0x835DBF0", VA = "0x18835EDF0")]
		private void OnPaletteSearchToggledToOpen(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x835F010", Offset = "0x835DE10", VA = "0x18835F010")]
		private void OnSearchStringChanged(string newSearchString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x835E6B0", Offset = "0x835D4B0", VA = "0x18835E6B0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x835E5B0", Offset = "0x835D3B0", VA = "0x18835E5B0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x835F700", Offset = "0x835E500", VA = "0x18835F700")]
		public MakerPenHUDPaletteListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[ViewModel]
	public class MakerPenHUDPaletteObjectViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		[CompilerGenerated]
		private struct <RefreshIcon>d__65 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			public JODUULFIMNR placableObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			public MakerPenHUDPaletteObjectViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x8378E40", Offset = "0x8377C40", VA = "0x188378E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x8379050", Offset = "0x8377E50", VA = "0x188379050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		[CompilerGenerated]
		private struct <RefreshName>d__66 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			public JODUULFIMNR placableObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000505")]
			public MakerPenHUDPaletteObjectViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000506")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x83790B0", Offset = "0x8377EB0", VA = "0x1883790B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x83792A0", Offset = "0x83780A0", VA = "0x1883792A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private JODUULFIMNR placable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private ContextMenuManager contextMenuManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private List<ContextMenuItemData> contextMenuItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		[SerializeField]
		private ContextMenuItemData favoriteMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		[SerializeField]
		private ContextMenuItemData unfavoriteMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		[SerializeField]
		private ContextMenuItemData infoMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		[FormerlySerializedAs("Index")]
		public int ObjectIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private bool favorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private bool canBeFavorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA6")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private bool contextMenuShortcutAvailable;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private Texture iconTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private bool isIconTextureSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private string objectName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private bool selected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private bool showActionButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private string actionButtonText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private bool canShowInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private bool focused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private DataItem<bool> FavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private DataItem<bool> CanBeFavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private DataItem<bool> ContentMenuShortcutAvailableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private DataItem<Texture> IconTextureDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private DataItem<bool> IsIconTextureSetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private DataItem<string> ObjectNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private DataItem<bool> SelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private DataItem<bool> ShowActionButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private DataItem<string> ActionButtonTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private DataItem<bool> CanShowInfoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private DataItem<bool> FocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private DataItemAction ClickObjectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private DataItemAction ClickFavoriteDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private DataItemAction ClickActionButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private DataItemAction ClickInfoButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private DataItemAction SeeMoreOptionsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x83625F0", Offset = "0x83613F0", VA = "0x1883625F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		[BindableData(1, "Whether or not the user has favorited this object", DataPermissions.ReadOnly)]
		public bool Favorited
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x1037AC0", Offset = "0x10368C0", VA = "0x181037AC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000755")]
			[Cpp2IlInjected.Address(RVA = "0x83627A0", Offset = "0x83615A0", VA = "0x1883627A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		[BindableData(8, "Whether or not the user can set this object as a favorite", DataPermissions.ReadOnly)]
		public bool CanBeFavorited
		{
			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0x1A66910", Offset = "0x1A65710", VA = "0x181A66910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0x83626E0", Offset = "0x83614E0", VA = "0x1883626E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool ContentMenuShortcutAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x8362000", Offset = "0x8360E00", VA = "0x188362000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x8362010", Offset = "0x8360E10", VA = "0x188362010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		[BindableData(2, "The image to use for the icon for the object", DataPermissions.ReadOnly)]
		public Texture IconTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x8362800", Offset = "0x8361600", VA = "0x188362800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		[BindableData(7, "True if the icon texture is set", DataPermissions.ReadOnly)]
		public bool IsIconTextureSet
		{
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x14DD290", Offset = "0x14DC090", VA = "0x1814DD290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x83629E0", Offset = "0x83617E0", VA = "0x1883629E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0xEF42F0", Offset = "0xEF30F0", VA = "0x180EF42F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x8362950", Offset = "0x8361750", VA = "0x188362950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		[BindableData(5, "The name of the object to display", DataPermissions.ReadOnly)]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0xB880B0", Offset = "0xB86EB0", VA = "0x180B880B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x8362A40", Offset = "0x8361840", VA = "0x188362A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		[BindableData(6, "Whether or not the object is selected by the user", DataPermissions.ReadOnly)]
		public bool Selected
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0x10E2CD0", Offset = "0x10E1AD0", VA = "0x1810E2CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x8362AC0", Offset = "0x83618C0", VA = "0x188362AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		[BindableData(9, "Whether or not to show the action button", DataPermissions.ReadOnly)]
		public bool ShowActionButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(RVA = "0x2247120", Offset = "0x2245F20", VA = "0x182247120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x8362B20", Offset = "0x8361920", VA = "0x188362B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		[BindableData(10, "Text to populate the action button", DataPermissions.ReadOnly)]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(RVA = "0xB88140", Offset = "0xB86F40", VA = "0x180B88140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(RVA = "0x8362660", Offset = "0x8361460", VA = "0x188362660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		[BindableData(14, "Whether or not the user can the info button", DataPermissions.ReadOnly)]
		public bool CanShowInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(RVA = "0xBBC310", Offset = "0xBBB110", VA = "0x180BBC310")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(RVA = "0x8362740", Offset = "0x8361540", VA = "0x188362740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool Focused
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x12CEA00", Offset = "0x12CD800", VA = "0x1812CEA00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x8361FA0", Offset = "0x8360DA0", VA = "0x188361FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x83625B0", Offset = "0x83613B0", VA = "0x1883625B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x835FA50", Offset = "0x835E850", VA = "0x18835FA50")]
		[BindableAction(3, "Call when the object is clicked")]
		public void ClickObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x835F990", Offset = "0x835E790", VA = "0x18835F990")]
		[BindableAction(4, "Call when the favorite button is clicked")]
		public void ClickFavorite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x835F930", Offset = "0x835E730", VA = "0x18835F930")]
		[BindableAction(11, "Called when the action button is clicked")]
		public void ClickActionButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x835F9F0", Offset = "0x835E7F0", VA = "0x18835F9F0")]
		[BindableAction(15, "Called when the info button is clicked")]
		public void ClickInfoButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x8361620", Offset = "0x8360420", VA = "0x188361620")]
		[BindableAction(16, null)]
		private void SeeMoreOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x8361110", Offset = "0x835FF10", VA = "0x188361110")]
		private void OnPaletteEntryUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x8361630", Offset = "0x8360430", VA = "0x188361630")]
		private void SetData(JODUULFIMNR placableObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x8361440", Offset = "0x8360240", VA = "0x188361440")]
		[AsyncStateMachine(typeof(<RefreshIcon>d__65))]
		private Task RefreshIcon(JODUULFIMNR placableObject)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x8361530", Offset = "0x8360330", VA = "0x188361530")]
		[AsyncStateMachine(typeof(<RefreshName>d__66))]
		private Task RefreshName(JODUULFIMNR placableObject)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x8360F90", Offset = "0x835FD90", VA = "0x188360F90")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x8361BE0", Offset = "0x83609E0", VA = "0x188361BE0")]
		private void ShowContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x8360EA0", Offset = "0x835FCA0", VA = "0x188360EA0")]
		private void OnContextMenuClosed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x8361EF0", Offset = "0x8360CF0", VA = "0x188361EF0")]
		private void ToggleFavorite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x8362080", Offset = "0x8360E80", VA = "0x188362080")]
		private void ViewInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x835F8E0", Offset = "0x835E6E0", VA = "0x18835F8E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x83610C0", Offset = "0x835FEC0", VA = "0x1883610C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x83602C0", Offset = "0x835F0C0", VA = "0x1883602C0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x835FAB0", Offset = "0x835E8B0", VA = "0x18835FAB0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x8362160", Offset = "0x8360F60", VA = "0x188362160")]
		public MakerPenHUDPaletteObjectViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[ViewModel]
	public class MakerPenHUDPaletteSearchViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private DataItem<string> PaletteSearchStringDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		[BindableData(1, "The current search string fed to the palette population logic", DataPermissions.ReadWrite)]
		public string PaletteSearchString
		{
			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x8362E40", Offset = "0x8361C40", VA = "0x188362E40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x8362E90", Offset = "0x8361C90", VA = "0x188362E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x8362F70", Offset = "0x8361D70", VA = "0x188362F70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x8362B80", Offset = "0x8361980", VA = "0x188362B80", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x8362E10", Offset = "0x8361C10", VA = "0x188362E10", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x8362CD0", Offset = "0x8361AD0", VA = "0x188362CD0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x8362BD0", Offset = "0x83619D0", VA = "0x188362BD0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x8362EF0", Offset = "0x8361CF0", VA = "0x188362EF0")]
		public MakerPenHUDPaletteSearchViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[ViewModel]
	public class MakerPenHUDPaletteViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private DataItem<bool> IsPaletteSearchOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private DataItemAction TogglePaletteSearchDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		[BindableData(2, "Is the palette search currently opened or closed", DataPermissions.ReadOnly)]
		public bool IsPaletteSearchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x8363370", Offset = "0x8362170", VA = "0x188363370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x8363480", Offset = "0x8362280", VA = "0x188363480", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x8362FA0", Offset = "0x8361DA0", VA = "0x188362FA0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x8362E10", Offset = "0x8361C10", VA = "0x188362E10", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x8363300", Offset = "0x8362100", VA = "0x188363300")]
		[BindableAction(1, "Toggle Search bar open/closed")]
		public void TogglePaletteSearch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x8363150", Offset = "0x8361F50", VA = "0x188363150", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x8362FF0", Offset = "0x8361DF0", VA = "0x188362FF0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x83633C0", Offset = "0x83621C0", VA = "0x1883633C0")]
		public MakerPenHUDPaletteViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[ViewModel]
	public class MakerPenHUDSelectToolbarViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class <UnfocusedNavWaitDelay>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000578")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			public MakerPenHUDSelectToolbarViewModel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700021D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000859")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700021E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600085B")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <UnfocusedNavWaitDelay>d__33(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0x8379300", Offset = "0x8378100", VA = "0x188379300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600085A")]
			[Cpp2IlInjected.Address(RVA = "0x83793E0", Offset = "0x83781E0", VA = "0x1883793E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		[SerializeField]
		private FocusableUI focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		[SerializeField]
		private float unfocusedNavigationSelectDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		[SerializeField]
		private DialogListModel dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private IRRUIvNextBridge rruiBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private UYBXJKUPTWR makerPenHUDManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private bool leftModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private bool rightModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private bool rightModifierHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private float lastUnfocusedNavEventTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private Coroutine unfocusedNavWaitCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private bool hasFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private float holdInputProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private bool showHoldIndicator;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private const string cloneButtonName = "Clone Tool Button";

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private const string moveButtonName = "Precision Move Toggle";

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private const string rotateButtonName = "Precision Rotate Toggle";

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private const string scaleButtonName = "Precision Scale Toggle";

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private const string deleteButtonName = "Delete Button";

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private bool isDeleteAllow;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB2")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private bool onCloneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB3")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private bool inTransformModeAndMoveOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private bool inTransformModeAndRotateOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB5")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool inTransformModeAndScaleOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB6")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private bool isRecolorModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB7")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private bool isPrecisionModifierModeActive;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private const string recolorButtonName = "Recolor Tool Button";

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private const string colorPickerButtonName = "Color Picker Menu Toggle";

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private bool showEditColorPanel;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private const string exitRecolorButtonName = "Exit Recolor Button";

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private bool isEditColorPanelHiddenWhenRecolorModeActive;

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private const string configButtonName = "Config Tool Button";

		[Cpp2IlInjected.FieldOffset(Offset = "0xBA")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private bool onConfigMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBB")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private bool isRRUIPageContainerEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private const string adjustButtonName = "Adjust Button";

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private string toolDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private bool isAdjustModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private bool showAdjustButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private bool adjustFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCB")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private bool cloneFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private bool recolorFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCD")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private bool configFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCE")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private bool deleteFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCF")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private bool moveModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private bool rotateModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private bool scaleModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD2")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private bool recolorModeAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD3")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private bool configModeAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private bool isDeleteModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private bool onlyMoveOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private bool onlyRotateOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD7")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private bool onlyScaleOn;

		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private const string selectModeAnalyticsString = "Default Mode";

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private const string precisionSelectModeAnalyticsString = "Precision Mode";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private string currentModeAnalyticsString;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private DataItem<bool> HasFocusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private DataItem<float> HoldInputProgressDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private DataItem<bool> ShowHoldIndicatorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private DataItem<bool> IsDeleteAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private DataItem<bool> OnCloneModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private DataItem<bool> MoveOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private DataItem<bool> RotateOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private DataItem<bool> ScaleOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private DataItem<bool> IsRecolorModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private DataItem<bool> IsPrecisionModifierModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private DataItem<bool> ShowEditColorPanelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private DataItem<bool> IsEditColorPanelHiddenWhenRecolorModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private DataItem<bool> OnConfigModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private DataItem<bool> IsRRUIPageContainerEnabledDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private DataItem<string> ToolDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private DataItem<bool> IsAdjustModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private DataItem<bool> ShowAdjustButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private DataItem<bool> AdjustFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private DataItem<bool> CloneFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private DataItem<bool> RecolorFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private DataItem<bool> ConfigFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private DataItem<bool> DeleteFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private DataItem<bool> MoveModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private DataItem<bool> RotateModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private DataItem<bool> ScaleModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private DataItem<bool> RecolorModeAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private DataItem<bool> ConfigModeAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private DataItem<bool> IsDeleteModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private DataItem<bool> MoveOnAndFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private DataItem<bool> RotateOnAndFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private DataItem<bool> ScaleOnAndFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private DataItem<bool> MoveOffAndFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private DataItem<bool> RotateOffAndFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private DataItem<bool> ScaleOffAndFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private DataItem<bool> OnlyMoveOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private DataItem<bool> OnlyRotateOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private DataItem<bool> OnlyScaleOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private DataItemAction ToggleCloneModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private DataItemAction ToggleMoveModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private DataItemAction ToggleRotateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private DataItemAction ToggleScaleModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private DataItemAction DeleteSelectionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private DataItemAction ToggleRecolorModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private DataItemAction ExitRecolorModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private DataItemAction ToggleConfigModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private DataItemAction HideRRUIPageContainerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private DataItemAction ShowRRUIPageContainerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private DataItemAction RequestAdjustModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private DataItemAction ToggleColorPickerDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		private bool shouldFocus
		{
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x836BC50", Offset = "0x836AA50", VA = "0x18836BC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		[BindableData(200, null, DataPermissions.ReadWrite)]
		public bool HasFocus
		{
			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0xB88090", Offset = "0xB86E90", VA = "0x180B88090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x8369C90", Offset = "0x8368A90", VA = "0x188369C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		[BindableData(201, null, DataPermissions.ReadWrite)]
		public float HoldInputProgress
		{
			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB2240", Offset = "0x1FB1040", VA = "0x181FB2240")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x8369EE0", Offset = "0x8368CE0", VA = "0x188369EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		[BindableData(202, null, DataPermissions.ReadWrite)]
		public bool ShowHoldIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x14DD290", Offset = "0x14DC090", VA = "0x1814DD290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x836A340", Offset = "0x8369140", VA = "0x18836A340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		[BindableData(6, "Is Delete Allowed", DataPermissions.ReadWrite)]
		public bool IsDeleteAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60007C4")]
			[Cpp2IlInjected.Address(RVA = "0x1AAEDE0", Offset = "0x1AADBE0", VA = "0x181AAEDE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C5")]
			[Cpp2IlInjected.Address(RVA = "0x836A3B0", Offset = "0x83691B0", VA = "0x18836A3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		[BindableData(7, "OnCloneMode", DataPermissions.ReadWrite)]
		public bool OnCloneMode
		{
			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0x1F5EEE0", Offset = "0x1F5DCE0", VA = "0x181F5EEE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0x836A410", Offset = "0x8369210", VA = "0x18836A410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		[BindableData(8, "In Transfrom Mode And Move On", DataPermissions.ReadWrite)]
		public bool MoveOn
		{
			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x5A57330", Offset = "0x5A56130", VA = "0x185A57330")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0x836C0B0", Offset = "0x836AEB0", VA = "0x18836C0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		[BindableData(9, "In Transform Mode And Rotate On", DataPermissions.ReadWrite)]
		public bool RotateOn
		{
			[Cpp2IlInjected.Token(Token = "0x60007CA")]
			[Cpp2IlInjected.Address(RVA = "0xDF7B10", Offset = "0xDF6910", VA = "0x180DF7B10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0x836C2F0", Offset = "0x836B0F0", VA = "0x18836C2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		[BindableData(10, "In Transform Mode And Scale On", DataPermissions.ReadWrite)]
		public bool ScaleOn
		{
			[Cpp2IlInjected.Token(Token = "0x60007CC")]
			[Cpp2IlInjected.Address(RVA = "0x7A28D10", Offset = "0x7A27B10", VA = "0x187A28D10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0x836C390", Offset = "0x836B190", VA = "0x18836C390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		[BindableData(11, "Is Recolor Tool Currently Active", DataPermissions.ReadWrite)]
		public bool IsRecolorModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0x8369C10", Offset = "0x8368A10", VA = "0x188369C10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x8369C20", Offset = "0x8368A20", VA = "0x188369C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		[BindableData(12, "Is Transform Tool Active", DataPermissions.ReadWrite)]
		public bool IsPrecisionModifierModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x7A28D20", Offset = "0x7A27B20", VA = "0x187A28D20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x836BEB0", Offset = "0x836ACB0", VA = "0x18836BEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		[BindableData(14, "Show Edit Color Panel", DataPermissions.ReadOnly)]
		public bool ShowEditColorPanel
		{
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0xC56160", Offset = "0xC54F60", VA = "0x180C56160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x836C500", Offset = "0x836B300", VA = "0x18836C500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		[BindableData(16, "Is Edit Color Panel Hidden When Recolor Mode is Active", DataPermissions.ReadWrite)]
		public bool IsEditColorPanelHiddenWhenRecolorModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0xC56170", Offset = "0xC54F70", VA = "0x180C56170")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x8369CF0", Offset = "0x8368AF0", VA = "0x188369CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		[BindableData(18, "OnConfigMode", DataPermissions.ReadWrite)]
		public bool OnConfigMode
		{
			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0xC56190", Offset = "0xC54F90", VA = "0x180C56190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0x8369D50", Offset = "0x8368B50", VA = "0x188369D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		[BindableData(19, "IsRRUIPageContainerEnabled", DataPermissions.ReadWrite)]
		public bool IsRRUIPageContainerEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60007DB")]
			[Cpp2IlInjected.Address(RVA = "0x2348F40", Offset = "0x2347D40", VA = "0x182348F40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007DC")]
			[Cpp2IlInjected.Address(RVA = "0x8369DB0", Offset = "0x8368BB0", VA = "0x188369DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		[BindableData(23, "ToolDescription", DataPermissions.ReadOnly)]
		public string ToolDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0xB880B0", Offset = "0xB86EB0", VA = "0x180B880B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x836C560", Offset = "0x836B360", VA = "0x18836C560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		[BindableData(24, "Is Adjust Mode Active", DataPermissions.ReadWrite)]
		public bool IsAdjustModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x10E2CD0", Offset = "0x10E1AD0", VA = "0x1810E2CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x8369E10", Offset = "0x8368C10", VA = "0x188369E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		[BindableData(25, "Show the Adjust button", DataPermissions.ReadWrite)]
		public bool ShowAdjustButton
		{
			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x2247120", Offset = "0x2245F20", VA = "0x182247120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0x836C430", Offset = "0x836B230", VA = "0x18836C430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		[BindableData(26, null, DataPermissions.ReadWrite)]
		public bool AdjustFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x22474B0", Offset = "0x22462B0", VA = "0x1822474B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x836BD30", Offset = "0x836AB30", VA = "0x18836BD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		[BindableData(27, null, DataPermissions.ReadWrite)]
		public bool CloneFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x2247070", Offset = "0x2245E70", VA = "0x182247070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x836BDB0", Offset = "0x836ABB0", VA = "0x18836BDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		[BindableData(28, null, DataPermissions.ReadWrite)]
		public bool RecolorFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0x8369EA0", Offset = "0x8368CA0", VA = "0x188369EA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007EB")]
			[Cpp2IlInjected.Address(RVA = "0x836C270", Offset = "0x836B070", VA = "0x18836C270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		[BindableData(29, null, DataPermissions.ReadWrite)]
		public bool ConfigFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x8369EC0", Offset = "0x8368CC0", VA = "0x188369EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x836BE30", Offset = "0x836AC30", VA = "0x18836BE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		[BindableData(31, null, DataPermissions.ReadWrite)]
		public bool DeleteFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0x8369F50", Offset = "0x8368D50", VA = "0x188369F50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x8369F60", Offset = "0x8368D60", VA = "0x188369F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		[BindableData(32, null, DataPermissions.ReadWrite)]
		public bool MoveModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x8369FE0", Offset = "0x8368DE0", VA = "0x188369FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x836C010", Offset = "0x836AE10", VA = "0x18836C010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		[BindableData(33, null, DataPermissions.ReadWrite)]
		public bool RotateModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x15E6880", Offset = "0x15E5680", VA = "0x1815E6880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x836A000", Offset = "0x8368E00", VA = "0x18836A000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		[BindableData(34, null, DataPermissions.ReadWrite)]
		public bool ScaleModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x16849E0", Offset = "0x16837E0", VA = "0x1816849E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x836A0A0", Offset = "0x8368EA0", VA = "0x18836A0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		[BindableData(35, null, DataPermissions.ReadWrite)]
		public bool RecolorModeAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x836A140", Offset = "0x8368F40", VA = "0x18836A140")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x836A150", Offset = "0x8368F50", VA = "0x18836A150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		[BindableData(36, null, DataPermissions.ReadWrite)]
		public bool ConfigModeAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x836A1B0", Offset = "0x8368FB0", VA = "0x18836A1B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x836A1C0", Offset = "0x8368FC0", VA = "0x18836A1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		[BindableData(38, "Is Delete Mode Active", DataPermissions.ReadWrite)]
		public bool IsDeleteModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x2A1AC60", Offset = "0x2A19A60", VA = "0x182A1AC60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x836A220", Offset = "0x8369020", VA = "0x18836A220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		[BindableData(39, "Move On And Focused", DataPermissions.ReadOnly)]
		public bool MoveOnAndFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007FD")]
			[Cpp2IlInjected.Address(RVA = "0x836A280", Offset = "0x8369080", VA = "0x18836A280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		[BindableData(40, "Rotate On And Focused", DataPermissions.ReadOnly)]
		public bool RotateOnAndFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007FE")]
			[Cpp2IlInjected.Address(RVA = "0x836A2A0", Offset = "0x83690A0", VA = "0x18836A2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		[BindableData(41, "Scale On And Focused", DataPermissions.ReadOnly)]
		public bool ScaleOnAndFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0x836A2C0", Offset = "0x83690C0", VA = "0x18836A2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		[BindableData(42, "Move Off And Focused", DataPermissions.ReadOnly)]
		public bool MoveOffAndFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x836A2E0", Offset = "0x83690E0", VA = "0x18836A2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		[BindableData(43, "Rotate Off And Focused", DataPermissions.ReadOnly)]
		public bool RotateOffAndFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0x836A300", Offset = "0x8369100", VA = "0x18836A300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		[BindableData(44, "Scale Off And Focused", DataPermissions.ReadOnly)]
		public bool ScaleOffAndFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0x836A320", Offset = "0x8369120", VA = "0x18836A320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		[BindableData(45, "Only Move On", DataPermissions.ReadOnly)]
		public bool OnlyMoveOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0x2A1AC80", Offset = "0x2A19A80", VA = "0x182A1AC80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0x836C150", Offset = "0x836AF50", VA = "0x18836C150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		[BindableData(46, "Only Rotate On", DataPermissions.ReadOnly)]
		public bool OnlyRotateOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x2A1AC70", Offset = "0x2A19A70", VA = "0x182A1AC70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x836C1B0", Offset = "0x836AFB0", VA = "0x18836C1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		[BindableData(47, "Only Scale On", DataPermissions.ReadOnly)]
		public bool OnlyScaleOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000807")]
			[Cpp2IlInjected.Address(RVA = "0x836A3A0", Offset = "0x83691A0", VA = "0x18836A3A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000808")]
			[Cpp2IlInjected.Address(RVA = "0x836C210", Offset = "0x836B010", VA = "0x18836C210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000812")]
			[Cpp2IlInjected.Address(RVA = "0x836BC10", Offset = "0x836AA10", VA = "0x18836BC10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x8368A90", Offset = "0x8367890", VA = "0x188368A90")]
		private void OnLeftNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x8368CB0", Offset = "0x8367AB0", VA = "0x188368CB0")]
		private void OnRightNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x836A6B0", Offset = "0x83694B0", VA = "0x18836A6B0")]
		private void UpdateInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x83643A0", Offset = "0x83631A0", VA = "0x1883643A0")]
		private void CheckForFocusGained()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x83644F0", Offset = "0x83632F0", VA = "0x1883644F0")]
		private void CheckForFocusLost()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x8368390", Offset = "0x8367190", VA = "0x188368390")]
		private void OnCursorActiveChanged(bool active)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x8363B80", Offset = "0x8362980", VA = "0x188363B80")]
		private void ChangeModeToMatchButtonFocusState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x8368C80", Offset = "0x8367A80", VA = "0x188368C80")]
		private void OnNavFocusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x836A470", Offset = "0x8369270", VA = "0x18836A470")]
		[IteratorStateMachine(typeof(<UnfocusedNavWaitDelay>d__33))]
		private IEnumerator UnfocusedNavWaitDelay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x83634B0", Offset = "0x83622B0", VA = "0x1883634B0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x8368A40", Offset = "0x8367840", VA = "0x188368A40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x8368420", Offset = "0x8367220", VA = "0x188368420", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x83695A0", Offset = "0x83683A0", VA = "0x1883695A0")]
		[BindableAction(1, "Press Clone button")]
		public void ToggleCloneMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x8369760", Offset = "0x8368560", VA = "0x188369760")]
		[BindableAction(2, "Press Move button")]
		public void ToggleMoveMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x83699A0", Offset = "0x83687A0", VA = "0x1883699A0")]
		[BindableAction(3, "Press Rotate button")]
		public void ToggleRotateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x8369AC0", Offset = "0x83688C0", VA = "0x188369AC0")]
		[BindableAction(4, "Press Scale button")]
		public void ToggleScaleMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x8364730", Offset = "0x8363530", VA = "0x188364730")]
		[BindableAction(5, "Press Delete button")]
		public void DeleteSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x8364880", Offset = "0x8363680", VA = "0x188364880")]
		public void EnterPrecisionMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x8364820", Offset = "0x8363620", VA = "0x188364820")]
		public void EnterDeleteMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x836A500", Offset = "0x8369300", VA = "0x18836A500")]
		private void UpdateFocusedToMatchActiveMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x8369880", Offset = "0x8368680", VA = "0x188369880")]
		[BindableAction(13, "Press Recolor button")]
		public void ToggleRecolorMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x83649F0", Offset = "0x83637F0", VA = "0x1883649F0")]
		[BindableAction(15, "Press Exit Recolor button")]
		public void ExitRecolorMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x83696C0", Offset = "0x83684C0", VA = "0x1883696C0")]
		[BindableAction(17, "Press Config button")]
		public void ToggleConfigMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x8365CB0", Offset = "0x8364AB0", VA = "0x188365CB0")]
		[BindableAction(20, "Hide RRUI Page Container")]
		public void HideRRUIPageContainer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x8369540", Offset = "0x8368340", VA = "0x188369540")]
		[BindableAction(21, "Show RRUI Page Container")]
		public void ShowRRUIPageContainer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x83691B0", Offset = "0x8367FB0", VA = "0x1883691B0")]
		[BindableAction(22, "Request Adjust Mode")]
		public void RequestAdjustMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0x8369640", Offset = "0x8368440", VA = "0x188369640")]
		[BindableAction(37, "Toggle Color Picker")]
		public void ToggleColorPicker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x836A870", Offset = "0x8369670", VA = "0x18836A870")]
		private void UpdatePrecisionModeToolStatus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x836AB60", Offset = "0x8369960", VA = "0x18836AB60")]
		private void UpdateSelectModeContextualBarData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x836A4E0", Offset = "0x83692E0", VA = "0x18836A4E0")]
		private void UpdateColorPickerOpen(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x836AB50", Offset = "0x8369950", VA = "0x18836AB50")]
		private void UpdateRRUIPageContainerEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x8369250", Offset = "0x8368050", VA = "0x188369250")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x8368200", Offset = "0x8367000", VA = "0x188368200")]
		private void LogImpressionAndChangeMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x836A9C0", Offset = "0x83697C0", VA = "0x18836A9C0")]
		private void UpdatePrecisionModifierAnalytics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x8364640", Offset = "0x8363440", VA = "0x188364640")]
		private void ClearPrecisionModifierAnalytics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x83680E0", Offset = "0x8366EE0", VA = "0x1883680E0")]
		private void LogClick(string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x8365D10", Offset = "0x8364B10", VA = "0x188365D10", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x8364A80", Offset = "0x8363880", VA = "0x188364A80")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x836B1A0", Offset = "0x8369FA0", VA = "0x18836B1A0")]
		public MakerPenHUDSelectToolbarViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[ViewModel]
	public class MakerPenHUDViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		[SerializeField]
		private FocusableUI focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private IRRUIvNextBridge rruiBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private bool leftModifierHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private bool hasFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private float holdInputProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private bool showHoldIndicator;

		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private const string undoButtonName = "Undo Button";

		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private const string redoButtonName = "Redo Button";

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private bool undoModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private bool redoModeFocused;

		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private const string selectButtonName = "Select Mode Button";

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private const string createButtonName = "Create Mode Button";

		[Cpp2IlInjected.FieldOffset(Offset = "0x8B")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private bool selectModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private bool createModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8D")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private bool selectModeAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8E")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private bool createModeAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private DataItem<bool> HasFocusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private DataItem<float> HoldInputProgressDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private DataItem<bool> ShowHoldIndicatorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private DataItem<bool> IsUndoAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private DataItem<bool> IsRedoAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private DataItem<bool> UndoModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private DataItem<bool> RedoModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private DataItem<bool> OnSelectModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private DataItem<bool> OnCreateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private DataItem<bool> SelectModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private DataItem<bool> CreateModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private DataItem<bool> SelectModeAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private DataItem<bool> CreateModeAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private DataItem<bool> IsCursorActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private DataItem<bool> IsInSubMenuDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private DataItemAction TriggerUndoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private DataItemAction TriggerRedoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private DataItemAction GoToSelectModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private DataItemAction GoToCreateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private DataItemAction EndCursorDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		private bool shouldFocus
		{
			[Cpp2IlInjected.Token(Token = "0x600085C")]
			[Cpp2IlInjected.Address(RVA = "0x8370100", Offset = "0x836EF00", VA = "0x188370100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		[BindableData(200, null, DataPermissions.ReadWrite)]
		public bool HasFocus
		{
			[Cpp2IlInjected.Token(Token = "0x600085D")]
			[Cpp2IlInjected.Address(RVA = "0x1666560", Offset = "0x1665360", VA = "0x181666560")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600085E")]
			[Cpp2IlInjected.Address(RVA = "0x836F5B0", Offset = "0x836E3B0", VA = "0x18836F5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000221")]
		[BindableData(201, null, DataPermissions.ReadWrite)]
		public float HoldInputProgress
		{
			[Cpp2IlInjected.Token(Token = "0x600085F")]
			[Cpp2IlInjected.Address(RVA = "0x1DE8900", Offset = "0x1DE7700", VA = "0x181DE8900")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000860")]
			[Cpp2IlInjected.Address(RVA = "0x836F710", Offset = "0x836E510", VA = "0x18836F710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		[BindableData(202, null, DataPermissions.ReadWrite)]
		public bool ShowHoldIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x6000861")]
			[Cpp2IlInjected.Address(RVA = "0xB41420", Offset = "0xB40220", VA = "0x180B41420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000862")]
			[Cpp2IlInjected.Address(RVA = "0x836F780", Offset = "0x836E580", VA = "0x18836F780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		[BindableData(7, "Is Undo Allowed", DataPermissions.ReadOnly)]
		public bool IsUndoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600086B")]
			[Cpp2IlInjected.Address(RVA = "0x836F7E0", Offset = "0x836E5E0", VA = "0x18836F7E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		[BindableData(8, "Is Redo Allowed", DataPermissions.ReadOnly)]
		public bool IsRedoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0x836F830", Offset = "0x836E630", VA = "0x18836F830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool UndoModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0xB413F0", Offset = "0xB401F0", VA = "0x180B413F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600086E")]
			[Cpp2IlInjected.Address(RVA = "0x836F880", Offset = "0x836E680", VA = "0x18836F880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool RedoModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x600086F")]
			[Cpp2IlInjected.Address(RVA = "0xB413E0", Offset = "0xB401E0", VA = "0x180B413E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000870")]
			[Cpp2IlInjected.Address(RVA = "0x836F390", Offset = "0x836E190", VA = "0x18836F390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		[BindableData(5, "OnSelectMode", DataPermissions.ReadOnly)]
		public bool OnSelectMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0x836F3F0", Offset = "0x836E1F0", VA = "0x18836F3F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		[BindableData(6, "OnCreateMode", DataPermissions.ReadOnly)]
		public bool OnCreateMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000874")]
			[Cpp2IlInjected.Address(RVA = "0x836F440", Offset = "0x836E240", VA = "0x18836F440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000229")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool SelectModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0xB41400", Offset = "0xB40200", VA = "0x180B41400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x836F490", Offset = "0x836E290", VA = "0x18836F490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool CreateModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0xD83A40", Offset = "0xD82840", VA = "0x180D83A40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x836F4F0", Offset = "0x836E2F0", VA = "0x18836F4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool SelectModeAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000879")]
			[Cpp2IlInjected.Address(RVA = "0xD83A50", Offset = "0xD82850", VA = "0x180D83A50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600087A")]
			[Cpp2IlInjected.Address(RVA = "0x836F550", Offset = "0x836E350", VA = "0x18836F550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool CreateModeAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600087B")]
			[Cpp2IlInjected.Address(RVA = "0x7903FC0", Offset = "0x7902DC0", VA = "0x187903FC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600087C")]
			[Cpp2IlInjected.Address(RVA = "0x836F610", Offset = "0x836E410", VA = "0x18836F610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		[BindableData(9, "Is Cursor Active", DataPermissions.ReadOnly)]
		public bool IsCursorActive
		{
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x836F670", Offset = "0x836E470", VA = "0x18836F670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		[BindableData(11, "Is In Sub Menu", DataPermissions.ReadOnly)]
		public bool IsInSubMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x836F6C0", Offset = "0x836E4C0", VA = "0x18836F6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0x83700C0", Offset = "0x836EEC0", VA = "0x1883700C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x836EBF0", Offset = "0x836D9F0", VA = "0x18836EBF0")]
		private void OnNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x836F9D0", Offset = "0x836E7D0", VA = "0x18836F9D0")]
		private void UpdateInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0x836C5E0", Offset = "0x836B3E0", VA = "0x18836C5E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0x836E780", Offset = "0x836D580", VA = "0x18836E780", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x836F310", Offset = "0x836E110", VA = "0x18836F310")]
		[BindableAction(3, "Press Undo button")]
		public void TriggerUndo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x836F290", Offset = "0x836E090", VA = "0x18836F290")]
		[BindableAction(4, "Press Redo button")]
		public void TriggerRedo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x836FBF0", Offset = "0x836E9F0", VA = "0x18836FBF0")]
		private void UpdateUndoStackData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x836CBA0", Offset = "0x836B9A0", VA = "0x18836CBA0")]
		private void FocusCurrentMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x836D6D0", Offset = "0x836C4D0", VA = "0x18836D6D0")]
		[BindableAction(1, "Press Select button")]
		public void GoToSelectMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x836D620", Offset = "0x836C420", VA = "0x18836D620")]
		[BindableAction(2, "Press Create button")]
		public void GoToCreateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x836E720", Offset = "0x836D520", VA = "0x18836E720")]
		private void OnCurrentModeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x836F8E0", Offset = "0x836E6E0", VA = "0x18836F8E0")]
		private void UpdateCuratedControls()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x836F980", Offset = "0x836E780", VA = "0x18836F980")]
		private void UpdateCursorActive(bool isCursorActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x836CB50", Offset = "0x836B950", VA = "0x18836CB50")]
		[BindableAction(10, "Button to request exiting cursor mode")]
		public void EndCursor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x836FBB0", Offset = "0x836E9B0", VA = "0x18836FBB0")]
		private void UpdateSubMenuActive(bool isInSubMenu)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x836F000", Offset = "0x836DE00", VA = "0x18836F000")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x836E600", Offset = "0x836D400", VA = "0x18836E600")]
		private void LogClick(string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x836D780", Offset = "0x836C580", VA = "0x18836D780", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x836CCC0", Offset = "0x836BAC0", VA = "0x18836CCC0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x836FC50", Offset = "0x836EA50", VA = "0x18836FC50")]
		public MakerPenHUDViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[ViewModel]
	public class NestedItem : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[SerializeField]
		private NestedListConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private int absoluteIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private NestedListItem item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private bool isExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private Sprite activeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private int depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private DataItem<string> TextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private DataItem<bool> IsExpandedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private DataItem<Sprite> ActiveIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private DataItem<int> DepthDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private DataItemAction ToggleExpandedDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x8370E30", Offset = "0x836FC30", VA = "0x188370E30", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x8370F50", Offset = "0x836FD50", VA = "0x188370F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0xB41420", Offset = "0xB40220", VA = "0x180B41420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A7")]
			[Cpp2IlInjected.Address(RVA = "0x8370B50", Offset = "0x836F950", VA = "0x188370B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public Sprite ActiveIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0x8370EA0", Offset = "0x836FCA0", VA = "0x188370EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Depth
		{
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0xFFC870", Offset = "0xFFB670", VA = "0x180FFC870")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0x8370BC0", Offset = "0x836F9C0", VA = "0x188370BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0x8370DF0", Offset = "0x836FBF0", VA = "0x188370DF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x8370AF0", Offset = "0x836F8F0", VA = "0x188370AF0")]
		[BindableAction(2, null)]
		public void ToggleExpanded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x8370950", Offset = "0x836F750", VA = "0x188370950")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x83704A0", Offset = "0x836F2A0", VA = "0x1883704A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x83701D0", Offset = "0x836EFD0", VA = "0x1883701D0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x8370C20", Offset = "0x836FA20", VA = "0x188370C20")]
		public NestedItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[ViewModel]
	public class NestedList : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		[SerializeField]
		private NestedListConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private DataList<int> activeIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private DataItemList ActiveIndicesDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> ActiveIndices
		{
			[Cpp2IlInjected.Token(Token = "0x60008BB")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008BC")]
			[Cpp2IlInjected.Address(RVA = "0x83716A0", Offset = "0x83704A0", VA = "0x1883716A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60008C0")]
			[Cpp2IlInjected.Address(RVA = "0x8371670", Offset = "0x8370470", VA = "0x188371670", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60008C1")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x8370FD0", Offset = "0x836FDD0", VA = "0x188370FD0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x8371360", Offset = "0x8370160", VA = "0x188371360", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x8371460", Offset = "0x8370260", VA = "0x188371460")]
		private void OnIndexStateChanged(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x8371210", Offset = "0x8370010", VA = "0x188371210", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x8371110", Offset = "0x836FF10", VA = "0x188371110")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x83715A0", Offset = "0x83703A0", VA = "0x1883715A0")]
		public NestedList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[ViewModel]
	public class OutfitListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private struct <FetchOutfitData>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			public OutfitListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			private TaskAwaiter<List<WTXRZVUFAOZ>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			private TaskAwaiter<RenderTexture> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			private TaskAwaiter<int> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60008E2")]
			[Cpp2IlInjected.Address(RVA = "0x8378340", Offset = "0x8377140", VA = "0x188378340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E3")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		[SerializeField]
		private int maxOutfitDisplayCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[SerializeField]
		private bool generateOutfitTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[SerializeField]
		private Route customizationRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[SerializeField]
		private int renderTextureWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[SerializeField]
		private int renderTextureHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[SerializeField]
		private DataResolver currentPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private DataList<WTXRZVUFAOZ> savedOutfitList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private bool isEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private DataList<int> saveOutfitSlotList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private RenderTexture outfitTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private string pageIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private DataItem<bool> IsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private DataItem<RenderTexture> OutfitTextureDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private DataItemList SavedOutfitListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private DataItemList SaveOutfitSlotListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private DataItemAction OpenCustomizerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private DataItemAction OpenSavedOutfitsPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<WTXRZVUFAOZ> SavedOutfitList
		{
			[Cpp2IlInjected.Token(Token = "0x60008C7")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C8")]
			[Cpp2IlInjected.Address(RVA = "0x8372FA0", Offset = "0x8371DA0", VA = "0x188372FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60008C9")]
			[Cpp2IlInjected.Address(RVA = "0xE9F850", Offset = "0xE9E650", VA = "0x180E9F850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x8372910", Offset = "0x8371710", VA = "0x188372910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<int> SaveOutfitSlotList
		{
			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008CC")]
			[Cpp2IlInjected.Address(RVA = "0x8372F30", Offset = "0x8371D30", VA = "0x188372F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public RenderTexture OutfitTexture
		{
			[Cpp2IlInjected.Token(Token = "0x60008CD")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008CE")]
			[Cpp2IlInjected.Address(RVA = "0x8372E10", Offset = "0x8371C10", VA = "0x188372E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60008D5")]
			[Cpp2IlInjected.Address(RVA = "0x8372DD0", Offset = "0x8371BD0", VA = "0x188372DD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x8372700", Offset = "0x8371500", VA = "0x188372700")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x83722A0", Offset = "0x83710A0", VA = "0x1883722A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x8372010", Offset = "0x8370E10", VA = "0x188372010")]
		private void OnActivePanelChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x8371700", Offset = "0x8370500", VA = "0x188371700")]
		[AsyncStateMachine(typeof(<FetchOutfitData>d__28))]
		private void FetchOutfitData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x83724B0", Offset = "0x83712B0", VA = "0x1883724B0")]
		[BindableAction(100, null)]
		private void OpenCustomizer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x83725E0", Offset = "0x83713E0", VA = "0x1883725E0")]
		[BindableAction(101, null)]
		private void OpenSavedOutfitsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x8371AF0", Offset = "0x83708F0", VA = "0x188371AF0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x83717B0", Offset = "0x83705B0", VA = "0x1883717B0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x8372B20", Offset = "0x8371920", VA = "0x188372B20")]
		public OutfitListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[ViewModel]
	public class OutfitViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private string outfitThumbnailName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private bool wearingOutfit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private WTXRZVUFAOZ savedOutfitData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private DataItem<string> OutfitThumbnailNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private DataItem<bool> WearingOutfitDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private DataItemAction ChangeOutfitDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string OutfitThumbnailName
		{
			[Cpp2IlInjected.Token(Token = "0x60008E4")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E5")]
			[Cpp2IlInjected.Address(RVA = "0x8373A40", Offset = "0x8372840", VA = "0x188373A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool WearingOutfit
		{
			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0xC5E3C0", Offset = "0xC5D1C0", VA = "0x180C5E3C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0x8373AB0", Offset = "0x83728B0", VA = "0x188373AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0x8373C70", Offset = "0x8372A70", VA = "0x188373C70", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60008EC")]
			[Cpp2IlInjected.Address(RVA = "0x8373C30", Offset = "0x8372A30", VA = "0x188373C30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000245")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x8373980", Offset = "0x8372780", VA = "0x188373980")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x8373600", Offset = "0x8372400", VA = "0x188373600")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x8373010", Offset = "0x8371E10", VA = "0x188373010")]
		[BindableAction(100, null)]
		private void ChangeOutfit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x8373320", Offset = "0x8372120", VA = "0x188373320", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x8373140", Offset = "0x8371F40", VA = "0x188373140")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x8373B10", Offset = "0x8372910", VA = "0x188373B10")]
		public OutfitViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[ViewModel]
	public class SaveOutfitButtonViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private int slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private DataItem<int> SlotIndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private DataItemAction SaveOutfitDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000246")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60008F5")]
			[Cpp2IlInjected.Address(RVA = "0x83782D0", Offset = "0x83770D0", VA = "0x1883782D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int SlotIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60008F6")]
			[Cpp2IlInjected.Address(RVA = "0x128BCF0", Offset = "0x128AAF0", VA = "0x18128BCF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F7")]
			[Cpp2IlInjected.Address(RVA = "0x8378190", Offset = "0x8376F90", VA = "0x188378190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60008FB")]
			[Cpp2IlInjected.Address(RVA = "0x83782A0", Offset = "0x83770A0", VA = "0x1883782A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60008FC")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x8378060", Offset = "0x8376E60", VA = "0x188378060")]
		[BindableAction(100, null)]
		public void SaveOutfit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x8377B50", Offset = "0x8376950", VA = "0x188377B50", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x8377F70", Offset = "0x8376D70", VA = "0x188377F70")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x8377D80", Offset = "0x8376B80", VA = "0x188377D80", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x8377C10", Offset = "0x8376A10", VA = "0x188377C10")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x83781E0", Offset = "0x8376FE0", VA = "0x1883781E0")]
		public SaveOutfitButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[ViewModel]
	public class RoomiePersonalityQuizAnswerViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private string _answerText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private string _componentValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private RoomiePersonalityQuizQuestionViewModel _roomiePersonalityQuizQuestionViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private QuizAnswer _quizAnswer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private DataItem<string> AnswerTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private DataItem<string> ComponentValueDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private DataItemAction SelectDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700024A")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public string AnswerText
		{
			[Cpp2IlInjected.Token(Token = "0x6000902")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000903")]
			[Cpp2IlInjected.Address(RVA = "0x83749F0", Offset = "0x83737F0", VA = "0x1883749F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024B")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public string ComponentValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000904")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000905")]
			[Cpp2IlInjected.Address(RVA = "0x8374A60", Offset = "0x8373860", VA = "0x188374A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E90", Offset = "0xFBFC90", VA = "0x180FC0E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x8374AD0", Offset = "0x83738D0", VA = "0x188374AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024D")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x8374980", Offset = "0x8373780", VA = "0x188374980", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024E")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600090E")]
			[Cpp2IlInjected.Address(RVA = "0x8374940", Offset = "0x8373740", VA = "0x188374940", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x8374650", Offset = "0x8373450", VA = "0x188374650")]
		[BindableAction(100, null)]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x8373CE0", Offset = "0x8372AE0", VA = "0x188373CE0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x83746B0", Offset = "0x83734B0", VA = "0x1883746B0")]
		private void UpdateDataItem(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x8374370", Offset = "0x8373170", VA = "0x188374370")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x8373D50", Offset = "0x8372B50", VA = "0x188373D50")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x8374080", Offset = "0x8372E80", VA = "0x188374080", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x8373E30", Offset = "0x8372C30", VA = "0x188373E30")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x8374800", Offset = "0x8373600", VA = "0x188374800")]
		public RoomiePersonalityQuizAnswerViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[ViewModel]
	public class RoomiePersonalityQuizQuestionViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private string _questionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private string _componentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private DataList<QuizAnswer> _answers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private RoomiePersonalityQuizViewModel _roomiePersonalityQuizViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private QuizQuestion _quizQuestion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private DataItem<string> QuestionTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private DataItem<string> ComponentNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private DataItemList AnswersDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000250")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public string QuestionText
		{
			[Cpp2IlInjected.Token(Token = "0x6000916")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0x8375830", Offset = "0x8374630", VA = "0x188375830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000251")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public string ComponentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000918")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0x83757C0", Offset = "0x83745C0", VA = "0x1883757C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000252")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public DataList<QuizAnswer> Answers
		{
			[Cpp2IlInjected.Token(Token = "0x600091A")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600091B")]
			[Cpp2IlInjected.Address(RVA = "0x8375760", Offset = "0x8374560", VA = "0x188375760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0x83756F0", Offset = "0x83744F0", VA = "0x1883756F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0x83756B0", Offset = "0x83744B0", VA = "0x1883756B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000924")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x83753D0", Offset = "0x83741D0", VA = "0x1883753D0")]
		public void Select(QuizAnswer quizAnswer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x83750E0", Offset = "0x8373EE0", VA = "0x1883750E0")]
		public bool IsSelected(QuizAnswer quizAnswer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x8374B30", Offset = "0x8373930", VA = "0x188374B30", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x8375410", Offset = "0x8374210", VA = "0x188375410")]
		private void UpdateDataItem(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x83751A0", Offset = "0x8373FA0", VA = "0x1883751A0")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x8374BA0", Offset = "0x83739A0", VA = "0x188374BA0")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x8374E90", Offset = "0x8373C90", VA = "0x188374E90", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x8374CB0", Offset = "0x8373AB0", VA = "0x188374CB0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x8375560", Offset = "0x8374360", VA = "0x188375560")]
		public RoomiePersonalityQuizQuestionViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[ViewModel]
	public class RoomiePersonalityQuizViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private DataList<QuizQuestion> _questions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private bool _hasRespondedToAllQuestions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private string _personalityPrompt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private bool _shouldShowSkipButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private readonly Dictionary<QuizQuestion, QuizAnswer> _answersByQuestion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private IRoomiePersonality _roomiePersonality;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private IRoomieManager _roomieManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private DataItem<bool> HasRespondedToAllQuestionsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private DataItem<string> PersonalityPromptDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private DataItem<bool> ShouldShowSkipButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private DataItemList QuestionsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private DataItemAction DoneDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private DataItemAction CancelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private DataItemAction SavePersonalityPromptDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private DataItemAction SkipDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000256")]
		public bool SuppressQuip
		{
			[Cpp2IlInjected.Token(Token = "0x600092B")]
			[Cpp2IlInjected.Address(RVA = "0xF7B8E0", Offset = "0xF7A6E0", VA = "0x180F7B8E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600092C")]
			[Cpp2IlInjected.Address(RVA = "0xF7B4A0", Offset = "0xF7A2A0", VA = "0x180F7B4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000257")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public DataList<QuizQuestion> Questions
		{
			[Cpp2IlInjected.Token(Token = "0x600092D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x8377A90", Offset = "0x8376890", VA = "0x188377A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000258")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public bool HasRespondedToAllQuestions
		{
			[Cpp2IlInjected.Token(Token = "0x600092F")]
			[Cpp2IlInjected.Address(RVA = "0xB45FE0", Offset = "0xB44DE0", VA = "0x180B45FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0x8377A30", Offset = "0x8376830", VA = "0x188377A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string PersonalityPrompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000931")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0x8377590", Offset = "0x8376390", VA = "0x188377590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		[BindableData(3, null, DataPermissions.ReadOnly)]
		public bool ShouldShowSkipButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000933")]
			[Cpp2IlInjected.Address(RVA = "0xAC50F0", Offset = "0xAC3EF0", VA = "0x180AC50F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0x8377AF0", Offset = "0x83768F0", VA = "0x188377AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public IReadOnlyDictionary<QuizQuestion, QuizAnswer> AnswersByQuestion
		{
			[Cpp2IlInjected.Token(Token = "0x600093B")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025C")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000943")]
			[Cpp2IlInjected.Address(RVA = "0x8377950", Offset = "0x8376750", VA = "0x188377950", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000944")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action CompleteEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0x83778B0", Offset = "0x83766B0", VA = "0x1883778B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600093A")]
			[Cpp2IlInjected.Address(RVA = "0x8377990", Offset = "0x8376790", VA = "0x188377990")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x8375B30", Offset = "0x8374930", VA = "0x188375B30")]
		[BindableAction(100, null)]
		public void Done()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x8375AF0", Offset = "0x83748F0", VA = "0x188375AF0")]
		[BindableAction(101, null)]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x8377020", Offset = "0x8375E20", VA = "0x188377020")]
		[BindableAction(102, null)]
		public void SavePersonalityPrompt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x83773E0", Offset = "0x83761E0", VA = "0x1883773E0")]
		[BindableAction(103, null)]
		public void Skip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x8377080", Offset = "0x8375E80", VA = "0x188377080")]
		public void Select(QuizQuestion quizQuestion, QuizAnswer quizAnswer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x83769A0", Offset = "0x83757A0", VA = "0x1883769A0")]
		public bool IsSelected(QuizQuestion quizQuestion, QuizAnswer quizAnswer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x83758A0", Offset = "0x83746A0", VA = "0x1883758A0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x8376A50", Offset = "0x8375850", VA = "0x188376A50", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x8376B20", Offset = "0x8375920", VA = "0x188376B20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x8376B50", Offset = "0x8375950", VA = "0x188376B50")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x8376B30", Offset = "0x8375930", VA = "0x188376B30")]
		private void OnPersonalityChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x8376410", Offset = "0x8375210", VA = "0x188376410", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x8375FF0", Offset = "0x8374DF0", VA = "0x188375FF0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x8377600", Offset = "0x8376400", VA = "0x188377600")]
		public RoomiePersonalityQuizViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[ViewModel]
	public class RoomieUserFactsViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass49_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			public RoomieUserFactsViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			public UserFactDTO userFact;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			public MessageDialogModel messageDialogModel;

			[Cpp2IlInjected.Token(Token = "0x6000983")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public <>c__DisplayClass49_0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		[CompilerGenerated]
		private struct <Delete>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000626")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000627")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000628")]
			public RoomieUserFactsViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000629")]
			public UserFactDTO userFact;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			private <>c__DisplayClass49_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			private TaskAwaiter<MessageDialogModel> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000988")]
			[Cpp2IlInjected.Address(RVA = "0x838DFD0", Offset = "0x838CDD0", VA = "0x18838DFD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000989")]
			[Cpp2IlInjected.Address(RVA = "0x838E6B0", Offset = "0x838D4B0", VA = "0x18838E6B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		[CompilerGenerated]
		private struct <Refresh>d__52 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400062D")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400062E")]
			public RoomieUserFactsViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400062F")]
			private TaskAwaiter<RoomieUserFactQueryData.IContext> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600098A")]
			[Cpp2IlInjected.Address(RVA = "0x83913D0", Offset = "0x83901D0", VA = "0x1883913D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600098B")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private static readonly string HasLocalPlayerSeenInfoBannerKey;

		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private static readonly string ShouldShowSectionOnSettingsPageKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		[SerializeField]
		private VisibilityChecker visibilityChecker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		[SerializeField]
		private RoomieUserFactQueryData roomieUserFactQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private RoomieUserFactQueryData _roomieUserFactQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private RoomieUserFactQueryData.IContext _roomieUserFactQueryDataContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private ERHONSLNWDT _recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private AWJSQTHCCJW _preferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private YEADHGPVUSS _gameConfigsProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private IRRUIvNextBridge _RRUIvNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private IRoomieBridge _roomieBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private IRoomieQueryManager _roomieQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private DialogListModel _dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private DataList<UserFactDTO> _userFacts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private bool _hasNoUserFacts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private bool _hasNoUnfilteredUserFacts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private bool _shouldShowInfoBanner;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private bool _shouldShowSectionOnSettingsPage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private bool _shouldUpdateUserKnowledge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private DataItem<string> SearchQueryDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private DataItem<bool> HasNoUserFactsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private DataItem<bool> HasNoUnfilteredUserFactsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private DataItem<RoomieUserFactSortType> SortDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private DataItem<bool> ShouldShowInfoBannerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private DataItem<bool> HasSearchQueryDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private DataItem<bool> ShouldShowSectionOnSettingsPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private DataItemList UserFactsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private DataItemAction ClearSearchQueryDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private DataItemAction ShowSortDialogDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private DataItemAction SetHasLocalPlayerSeenBannerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private DataItemAction DismissBannerDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		private RoomieUserFactQueryData RoomieUserFactQueryData
		{
			[Cpp2IlInjected.Token(Token = "0x600094D")]
			[Cpp2IlInjected.Address(RVA = "0x838D820", Offset = "0x838C620", VA = "0x18838D820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		[BindableData(0, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public DataList<UserFactDTO> UserFacts
		{
			[Cpp2IlInjected.Token(Token = "0x600094E")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0x838D9E0", Offset = "0x838C7E0", VA = "0x18838D9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string SearchQuery
		{
			[Cpp2IlInjected.Token(Token = "0x6000950")]
			[Cpp2IlInjected.Address(RVA = "0x838D100", Offset = "0x838BF00", VA = "0x18838D100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0x838D8A0", Offset = "0x838C6A0", VA = "0x18838D8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		[BindableData(2, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool HasNoUserFacts
		{
			[Cpp2IlInjected.Token(Token = "0x6000952")]
			[Cpp2IlInjected.Address(RVA = "0xB46000", Offset = "0xB44E00", VA = "0x180B46000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000953")]
			[Cpp2IlInjected.Address(RVA = "0x838D290", Offset = "0x838C090", VA = "0x18838D290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		[BindableData(3, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool HasNoUnfilteredUserFacts
		{
			[Cpp2IlInjected.Token(Token = "0x6000954")]
			[Cpp2IlInjected.Address(RVA = "0x1C88B00", Offset = "0x1C87900", VA = "0x181C88B00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000955")]
			[Cpp2IlInjected.Address(RVA = "0x838D2F0", Offset = "0x838C0F0", VA = "0x18838D2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000263")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public RoomieUserFactSortType Sort
		{
			[Cpp2IlInjected.Token(Token = "0x6000956")]
			[Cpp2IlInjected.Address(RVA = "0x838D350", Offset = "0x838C150", VA = "0x18838D350")]
			get
			{
				return default(RoomieUserFactSortType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000957")]
			[Cpp2IlInjected.Address(RVA = "0x838D960", Offset = "0x838C760", VA = "0x18838D960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		[BindableData(5, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool ShouldShowInfoBanner
		{
			[Cpp2IlInjected.Token(Token = "0x6000958")]
			[Cpp2IlInjected.Address(RVA = "0x831B850", Offset = "0x831A650", VA = "0x18831B850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000959")]
			[Cpp2IlInjected.Address(RVA = "0x838D380", Offset = "0x838C180", VA = "0x18838D380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000265")]
		[BindableData(6, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool HasSearchQuery
		{
			[Cpp2IlInjected.Token(Token = "0x600095A")]
			[Cpp2IlInjected.Address(RVA = "0x838D120", Offset = "0x838BF20", VA = "0x18838D120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600095B")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000266")]
		[BindableData(7, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool ShouldShowSectionOnSettingsPage
		{
			[Cpp2IlInjected.Token(Token = "0x600095C")]
			[Cpp2IlInjected.Address(RVA = "0x831B860", Offset = "0x831A660", VA = "0x18831B860")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600095D")]
			[Cpp2IlInjected.Address(RVA = "0x838D150", Offset = "0x838BF50", VA = "0x18838D150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000267")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000968")]
			[Cpp2IlInjected.Address(RVA = "0x838D7E0", Offset = "0x838C5E0", VA = "0x18838D7E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000268")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000969")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x838B820", Offset = "0x838A620", VA = "0x18838B820")]
		[BindableAction(100, null)]
		public void ClearSearchQuery()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x838CEB0", Offset = "0x838BCB0", VA = "0x18838CEB0")]
		[BindableAction(101, null)]
		public void ShowSortDialog()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x838CDB0", Offset = "0x838BBB0", VA = "0x18838CDB0")]
		[BindableAction(102, null)]
		public void SetHasLocalPlayerSeenBanner()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x838BA80", Offset = "0x838A880", VA = "0x18838BA80")]
		[BindableAction(103, null)]
		public void DismissBanner()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x838B980", Offset = "0x838A780", VA = "0x18838B980")]
		[AsyncStateMachine(typeof(<Delete>d__49))]
		public Task Delete(UserFactDTO userFact)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x838B560", Offset = "0x838A360", VA = "0x18838B560", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x838CA40", Offset = "0x838B840", VA = "0x18838CA40", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x838CD00", Offset = "0x838BB00", VA = "0x18838CD00")]
		[AsyncStateMachine(typeof(<Refresh>d__52))]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x838B830", Offset = "0x838A630", VA = "0x18838B830")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x838CAF0", Offset = "0x838B8F0", VA = "0x18838CAF0")]
		private void OnVisibilityChanged(bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x838C0C0", Offset = "0x838AEC0", VA = "0x18838C0C0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x838BAE0", Offset = "0x838A8E0", VA = "0x18838BAE0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x838D480", Offset = "0x838C280", VA = "0x18838D480")]
		public RoomieUserFactsViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[ViewModel]
	public class RoomieUserFactViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private static readonly DateTime InvalidDateTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private string _predicate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private string _object;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private string _emotion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private string _createdAt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private string _userFact;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private bool _isCreatedAtValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private RoomieUserFactsViewModel _roomieUserFactsViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private UserFactDTO _userFactDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private DataItem<string> PredicateDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private DataItem<string> ObjectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private DataItem<string> EmotionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private DataItem<string> CreatedAtDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private DataItem<string> UserFactDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private DataItem<bool> IsCreatedAtValidDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private DataItemAction DeleteDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000269")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public string Predicate
		{
			[Cpp2IlInjected.Token(Token = "0x600098C")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x838B470", Offset = "0x838A270", VA = "0x18838B470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026A")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public string Object
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0x838B400", Offset = "0x838A200", VA = "0x18838B400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026B")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string Emotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000990")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000991")]
			[Cpp2IlInjected.Address(RVA = "0x838B330", Offset = "0x838A130", VA = "0x18838B330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026C")]
		[BindableData(3, null, DataPermissions.ReadOnly)]
		public string CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000992")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0x838B2B0", Offset = "0x838A0B0", VA = "0x18838B2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026D")]
		[BindableData(4, null, DataPermissions.ReadOnly)]
		public string UserFact
		{
			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000995")]
			[Cpp2IlInjected.Address(RVA = "0x838B4E0", Offset = "0x838A2E0", VA = "0x18838B4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		[BindableData(5, null, DataPermissions.ReadOnly)]
		public bool IsCreatedAtValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000996")]
			[Cpp2IlInjected.Address(RVA = "0xE9F850", Offset = "0xE9E650", VA = "0x180E9F850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0x838B3A0", Offset = "0x838A1A0", VA = "0x18838B3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x838B240", Offset = "0x838A040", VA = "0x18838B240", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000270")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600099E")]
			[Cpp2IlInjected.Address(RVA = "0x838B200", Offset = "0x838A000", VA = "0x18838B200", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000271")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600099F")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x8389B10", Offset = "0x8388910", VA = "0x188389B10")]
		[BindableAction(100, null)]
		public void Delete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x8389890", Offset = "0x8388690", VA = "0x188389890", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x838A850", Offset = "0x8389650", VA = "0x18838A850")]
		private void UpdateDataItem(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x838A4C0", Offset = "0x83892C0", VA = "0x18838A4C0")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x8389900", Offset = "0x8388700", VA = "0x188389900")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x838A010", Offset = "0x8388E10", VA = "0x18838A010", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x8389C60", Offset = "0x8388A60", VA = "0x188389C60")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x838B020", Offset = "0x8389E20", VA = "0x18838B020")]
		public RoomieUserFactViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[ViewModel]
	public class RoomCategoryListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		public enum Sources
		{
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			PageSource,
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			CuratedList
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct <FetchData>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			public RoomCategoryListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			private TaskAwaiter<(IReadOnlyList<GTWZHBYHGTX> categories, string displayName)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			private TaskAwaiter<IReadOnlyList<GTWZHBYHGTX>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x838EF60", Offset = "0x838DD60", VA = "0x18838EF60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		[SerializeField]
		private LoadSceneSources loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		[SerializeField]
		private Sources source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		[SerializeField]
		private string sourceMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private string _discoverySectionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private IRRUIvNextRoomCategoryBridge roomCategoryBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private DataList<GTWZHBYHGTX> roomCategoryList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private DataItemList RoomCategoryListDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public LoadSceneSources LoadSceneSource
		{
			[Cpp2IlInjected.Token(Token = "0x60009AA")]
			[Cpp2IlInjected.Address(RVA = "0x837A4F0", Offset = "0x83792F0", VA = "0x18837A4F0")]
			get
			{
				return default(LoadSceneSources);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public BrowserModel BrowserModel
		{
			[Cpp2IlInjected.Token(Token = "0x60009AB")]
			[Cpp2IlInjected.Address(RVA = "0x837A400", Offset = "0x8379200", VA = "0x18837A400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public string DiscoverySectionId
		{
			[Cpp2IlInjected.Token(Token = "0x60009AC")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009AD")]
			[Cpp2IlInjected.Address(RVA = "0x837A500", Offset = "0x8379300", VA = "0x18837A500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<GTWZHBYHGTX> RoomCategoryList
		{
			[Cpp2IlInjected.Token(Token = "0x60009AE")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009AF")]
			[Cpp2IlInjected.Address(RVA = "0x837A630", Offset = "0x8379430", VA = "0x18837A630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000276")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60009B0")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x837A5B0", Offset = "0x83793B0", VA = "0x18837A5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000277")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x837A4B0", Offset = "0x83792B0", VA = "0x18837A4B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000278")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x8379E50", Offset = "0x8378C50", VA = "0x188379E50", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x8379ED0", Offset = "0x8378CD0", VA = "0x188379ED0")]
		public void SetSourceData(string source, string sourceMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x83799F0", Offset = "0x83787F0", VA = "0x1883799F0")]
		[AsyncStateMachine(typeof(<FetchData>d__25))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x8379F60", Offset = "0x8378D60", VA = "0x188379F60")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x8379C10", Offset = "0x8378A10", VA = "0x188379C10", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x8379AA0", Offset = "0x83788A0", VA = "0x188379AA0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x837A2C0", Offset = "0x83790C0", VA = "0x18837A2C0")]
		public RoomCategoryListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[ViewModel]
	public class RoomCategoryViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		[SerializeField]
		private Route searchRoomsroute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		[SerializeField]
		private Route gridViewRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private IRRUIvNextRoomCategoryBridge roomCategoryBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private LoadSceneSources loadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private GTWZHBYHGTX roomCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private DataItemAction SelectRoomCategoryDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000279")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x837B340", Offset = "0x837A140", VA = "0x18837B340", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027A")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C3")]
			[Cpp2IlInjected.Address(RVA = "0x837B3B0", Offset = "0x837A1B0", VA = "0x18837B3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027B")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60009C4")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C5")]
			[Cpp2IlInjected.Address(RVA = "0x837B430", Offset = "0x837A230", VA = "0x18837B430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0x837B300", Offset = "0x837A100", VA = "0x18837B300", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027D")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60009CC")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x837ACE0", Offset = "0x8379AE0", VA = "0x18837ACE0")]
		[BindableAction(100, null)]
		public void SelectRoomCategory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x837A6A0", Offset = "0x83794A0", VA = "0x18837A6A0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x837AC50", Offset = "0x8379A50", VA = "0x18837AC50")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x837AE80", Offset = "0x8379C80", VA = "0x18837AE80")]
		private void Set(GTWZHBYHGTX data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x837B0C0", Offset = "0x8379EC0", VA = "0x18837B0C0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x837A9A0", Offset = "0x83797A0", VA = "0x18837A9A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x837A7C0", Offset = "0x83795C0", VA = "0x18837A7C0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x837B1D0", Offset = "0x8379FD0", VA = "0x18837B1D0")]
		public RoomCategoryViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[ViewModel]
	public class RoomInventoryItemViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private IUnifiedRoomInventoryItem item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private string itemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private string itemImageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private bool hasImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private Sprite icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private Color iconColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private DataItem<string> ItemNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private DataItem<string> ItemImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private DataItem<bool> HasImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private DataItem<Sprite> IconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private DataItem<Color> IconColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private DataItemAction OpenItemDetailsDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700027E")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x837C7E0", Offset = "0x837B5E0", VA = "0x18837C7E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027F")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x837BFF0", Offset = "0x837ADF0", VA = "0x18837BFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000280")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string ItemImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60009D7")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x837C060", Offset = "0x837AE60", VA = "0x18837C060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000281")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool HasImage
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0xD5E570", Offset = "0xD5D370", VA = "0x180D5E570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009DB")]
			[Cpp2IlInjected.Address(RVA = "0x837C0D0", Offset = "0x837AED0", VA = "0x18837C0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000282")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x60009DC")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009DD")]
			[Cpp2IlInjected.Address(RVA = "0x837C910", Offset = "0x837B710", VA = "0x18837C910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000283")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public Color IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x60009DE")]
			[Cpp2IlInjected.Address(RVA = "0xFF2690", Offset = "0xFF1490", VA = "0x180FF2690")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60009DF")]
			[Cpp2IlInjected.Address(RVA = "0x837C850", Offset = "0x837B650", VA = "0x18837C850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000284")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60009E4")]
			[Cpp2IlInjected.Address(RVA = "0x837C7A0", Offset = "0x837B5A0", VA = "0x18837C7A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x837BEA0", Offset = "0x837ACA0", VA = "0x18837BEA0")]
		[BindableAction(2, null)]
		public void OpenItemDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0x837C360", Offset = "0x837B160", VA = "0x18837C360")]
		private void UpdateItem(IUnifiedRoomInventoryItem newItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0x837BE00", Offset = "0x837AC00", VA = "0x18837BE00")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x837C160", Offset = "0x837AF60", VA = "0x18837C160")]
		private void UpdateImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x837BD70", Offset = "0x837AB70", VA = "0x18837BD70")]
		private void LogClick(string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x837B7F0", Offset = "0x837A5F0", VA = "0x18837B7F0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x837B4B0", Offset = "0x837A2B0", VA = "0x18837B4B0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x837C580", Offset = "0x837B380", VA = "0x18837C580")]
		public RoomInventoryItemViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public class RoomCardFeatureHelper : BaseBindableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private LoadSceneSourceData loadSceneSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private bool showCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private int pinnedRoomCCUThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private bool showPopularBadge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private int popularRoomCCUThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private bool showNewBadge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private bool showPlayActionButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private bool showMoreLikeThisButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private bool showUpdateToPlayIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private bool showUpdateToPlayText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private string sessionSectionIdOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private Guid? sectionSpawnInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private string parentTabName;

		[Cpp2IlInjected.Token(Token = "0x17000286")]
		public LoadSceneSourceData LoadSceneSourceData
		{
			[Cpp2IlInjected.Token(Token = "0x60009F3")]
			[Cpp2IlInjected.Address(RVA = "0x8379440", Offset = "0x8378240", VA = "0x188379440")]
			get
			{
				return default(LoadSceneSourceData);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F4")]
			[Cpp2IlInjected.Address(RVA = "0x8379480", Offset = "0x8378280", VA = "0x188379480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000287")]
		public bool ShowCCUCounts
		{
			[Cpp2IlInjected.Token(Token = "0x60009F5")]
			[Cpp2IlInjected.Address(RVA = "0xE9F850", Offset = "0xE9E650", VA = "0x180E9F850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F6")]
			[Cpp2IlInjected.Address(RVA = "0x8379750", Offset = "0x8378550", VA = "0x188379750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000288")]
		public bool ShowPopularBadge
		{
			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD60", Offset = "0xAECB60", VA = "0x180AEDD60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F8")]
			[Cpp2IlInjected.Address(RVA = "0x83798D0", Offset = "0x83786D0", VA = "0x1883798D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000289")]
		public int PopularRoomCCUThreshold
		{
			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x2D95BC0", Offset = "0x2D949C0", VA = "0x182D95BC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x8379590", Offset = "0x8378390", VA = "0x188379590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028A")]
		public bool ShowNewBadge
		{
			[Cpp2IlInjected.Token(Token = "0x60009FB")]
			[Cpp2IlInjected.Address(RVA = "0xB46000", Offset = "0xB44E00", VA = "0x180B46000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009FC")]
			[Cpp2IlInjected.Address(RVA = "0x83797B0", Offset = "0x83785B0", VA = "0x1883797B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028B")]
		public bool ShowPlayActionButton
		{
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0x1C88B00", Offset = "0x1C87900", VA = "0x181C88B00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0x8379870", Offset = "0x8378670", VA = "0x188379870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028C")]
		public bool ShowMoreLikeThisButton
		{
			[Cpp2IlInjected.Token(Token = "0x60009FF")]
			[Cpp2IlInjected.Address(RVA = "0x831B850", Offset = "0x831A650", VA = "0x18831B850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028D")]
		public bool ShowUpdateToPlayIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000A00")]
			[Cpp2IlInjected.Address(RVA = "0x831B860", Offset = "0x831A660", VA = "0x18831B860")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A01")]
			[Cpp2IlInjected.Address(RVA = "0x8379930", Offset = "0x8378730", VA = "0x188379930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		public bool ShowUpdateToPlayText
		{
			[Cpp2IlInjected.Token(Token = "0x6000A02")]
			[Cpp2IlInjected.Address(RVA = "0x1037AC0", Offset = "0x10368C0", VA = "0x181037AC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A03")]
			[Cpp2IlInjected.Address(RVA = "0x8379990", Offset = "0x8378790", VA = "0x188379990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		public bool ShowNewThisSessionForSection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A04")]
			[Cpp2IlInjected.Address(RVA = "0x1A66910", Offset = "0x1A65710", VA = "0x181A66910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0x8379810", Offset = "0x8378610", VA = "0x188379810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000290")]
		public string SessionSectionIdOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A07")]
			[Cpp2IlInjected.Address(RVA = "0x83796D0", Offset = "0x83784D0", VA = "0x1883796D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000291")]
		public Guid? SectionSpawnInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A08")]
			[Cpp2IlInjected.Address(RVA = "0xAC4870", Offset = "0xAC3670", VA = "0x180AC4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A09")]
			[Cpp2IlInjected.Address(RVA = "0x83795F0", Offset = "0x83783F0", VA = "0x1883795F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000292")]
		public string ParentTabName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0A")]
			[Cpp2IlInjected.Address(RVA = "0xB880E0", Offset = "0xB86EE0", VA = "0x180B880E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0B")]
			[Cpp2IlInjected.Address(RVA = "0x8379510", Offset = "0x8378310", VA = "0x188379510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x8379420", Offset = "0x8378220", VA = "0x188379420")]
		public RoomCardFeatureHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[ViewModel]
	public class RoomListViewModel : RRUIBaseLocalViewModel, IOrderedRenderable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		[CompilerGenerated]
		private struct <FetchData>d__52 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000697")]
			public RoomListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000698")]
			private TaskAwaiter<List<RoomDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000A3A")]
			[Cpp2IlInjected.Address(RVA = "0x838F560", Offset = "0x838E360", VA = "0x18838F560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		[SerializeField]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		[SerializeField]
		private LoadSceneSources loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private IRoomQueryManager roomListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private bool waitingForQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private List<long> tempIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private int minItemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private bool fetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private DataList<long> roomIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private string listDisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private bool isEmptyOrBelowMinimum;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private RoomCardFeatureHelper featureHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private DataItem<string> ListDisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private DataItem<bool> IsEmptyOrBelowMinimumDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private DataItem<RoomListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private DataItem<RoomCardFeatureHelper> FeatureHelperDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private DataItemList RoomIdListDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000293")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<long> RoomIdList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0D")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0E")]
			[Cpp2IlInjected.Address(RVA = "0x837ECD0", Offset = "0x837DAD0", VA = "0x18837ECD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000294")]
		[BindableData(1, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string ListDisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0xB88130", Offset = "0xB86F30", VA = "0x180B88130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0x837EC50", Offset = "0x837DA50", VA = "0x18837EC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000295")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool IsEmptyOrBelowMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0xC56160", Offset = "0xC54F60", VA = "0x180C56160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x837E7A0", Offset = "0x837D5A0", VA = "0x18837E7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000296")]
		[BindableData(3, "The query data used to retrieve the room list", DataPermissions.ReadOnly)]
		public RoomListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000297")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public RoomCardFeatureHelper FeatureHelper
		{
			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0xB880B0", Offset = "0xB86EB0", VA = "0x180B880B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x837E800", Offset = "0x837D600", VA = "0x18837E800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000298")]
		public bool RenderInCarouselOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x10E2CD0", Offset = "0x10E1AD0", VA = "0x1810E2CD0", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0xD6F7E0", Offset = "0xD6E5E0", VA = "0x180D6F7E0", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public bool AllowRender
		{
			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x2247120", Offset = "0x2245F20", VA = "0x182247120", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A19")]
			[Cpp2IlInjected.Address(RVA = "0xD6F7F0", Offset = "0xD6E5F0", VA = "0x180D6F7F0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		public bool HasRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1A")]
			[Cpp2IlInjected.Address(RVA = "0x22474B0", Offset = "0x22462B0", VA = "0x1822474B0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1B")]
			[Cpp2IlInjected.Address(RVA = "0xD6F800", Offset = "0xD6E600", VA = "0x180D6F800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		public bool RequiresRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x2247070", Offset = "0x2245E70", VA = "0x182247070", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0x2245F30", Offset = "0x2244D30", VA = "0x182245F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029C")]
		public bool OverrideLoadSceneSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E90", Offset = "0xFBFC90", VA = "0x180FC0E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029D")]
		public LoadSceneSources LoadSceneSourceOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xAE5720", Offset = "0xAE4520", VA = "0x180AE5720")]
			get
			{
				return default(LoadSceneSources);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029E")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x837EC10", Offset = "0x837DA10", VA = "0x18837EC10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029F")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x837E600", Offset = "0x837D400", VA = "0x18837E600")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x837D3C0", Offset = "0x837C1C0", VA = "0x18837D3C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x837DE70", Offset = "0x837CC70", VA = "0x18837DE70")]
		public void SetQueryData(RoomListQueryData listQueryData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x837DD30", Offset = "0x837CB30", VA = "0x18837DD30")]
		public void SetDiscoverySectionId(string sectionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x837C9C0", Offset = "0x837B7C0", VA = "0x18837C9C0")]
		[AsyncStateMachine(typeof(<FetchData>d__52))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x837DDE0", Offset = "0x837CBE0", VA = "0x18837DDE0")]
		public void SetMaxItems(int maxItemsToFetch, int maxItemsToDisplay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0x837DE40", Offset = "0x837CC40", VA = "0x18837DE40")]
		public void SetMinItems(int minItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x837D530", Offset = "0x837C330", VA = "0x18837D530")]
		private void PopulateLoadSceneSourceData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x837DAC0", Offset = "0x837C8C0", VA = "0x18837DAC0")]
		private string ResolveDisplayName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x2247120", Offset = "0x2245F20", VA = "0x182247120")]
		private bool WaitUntilAllowRender()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0x837DF30", Offset = "0x837CD30", VA = "0x18837DF30")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x837D2A0", Offset = "0x837C0A0", VA = "0x18837D2A0")]
		private void OnChildImpressionTrackerAdded(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x837CD40", Offset = "0x837BB40", VA = "0x18837CD40", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x837CA70", Offset = "0x837B870", VA = "0x18837CA70")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x837E940", Offset = "0x837D740", VA = "0x18837E940")]
		public RoomListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[ViewModel]
	public class RoomStoreCategoryListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private IRRUIvNextRoomStoreBridge _roomStoreBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private bool _isSubscribed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private IRoomStoreCategory _selectedCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private DataList<IRoomStoreCategory> categoryList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private DataList<IUnifiedRoomStoreItem> _selectedCategoryItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private DataItemList CategoryListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private DataItemList SelectedCategoryItemsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170002A0")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<IRoomStoreCategory> CategoryList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x8380580", Offset = "0x837F380", VA = "0x188380580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A1")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public DataList<IUnifiedRoomStoreItem> SelectedCategoryItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3E")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0x83805F0", Offset = "0x837F3F0", VA = "0x1883805F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A2")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0x8380540", Offset = "0x837F340", VA = "0x188380540", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A3")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x837ED40", Offset = "0x837DB40", VA = "0x18837ED40", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x837FE90", Offset = "0x837EC90", VA = "0x18837FE90")]
		private void SubscribeToStoreChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0x837F440", Offset = "0x837E240", VA = "0x18837F440")]
		private void LoadSelectedCategory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x837FBC0", Offset = "0x837E9C0", VA = "0x18837FBC0")]
		private void OnResetSelectedCategory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x837F2B0", Offset = "0x837E0B0", VA = "0x18837F2B0")]
		private void LoadCategories()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x837FA60", Offset = "0x837E860", VA = "0x18837FA60", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x837FC70", Offset = "0x837EA70", VA = "0x18837FC70")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x837F9D0", Offset = "0x837E7D0", VA = "0x18837F9D0")]
		private void LogImpressionsBeforeCategoryChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x8380230", Offset = "0x837F030", VA = "0x188380230")]
		private void UpdateImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x837F0A0", Offset = "0x837DEA0", VA = "0x18837F0A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0x837EF30", Offset = "0x837DD30", VA = "0x18837EF30")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x83803D0", Offset = "0x837F1D0", VA = "0x1883803D0")]
		public RoomStoreCategoryListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[ViewModel]
	public class RoomStoreCategoryViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private string itemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private Sprite icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private DataList<IUnifiedRoomStoreItem> items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private IRRUIvNextRoomStoreBridge roomStoreBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private IRoomStoreCategory categoryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private DataItem<string> ItemNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private DataItem<Sprite> IconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private DataItemList ItemsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private DataItemAction SelectCategoryDataItem;

		[Cpp2IlInjected.Token(Token = "0x170002A4")]
		[BindableData(0, "The name of the category", DataPermissions.ReadOnly)]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A56")]
			[Cpp2IlInjected.Address(RVA = "0x8381820", Offset = "0x8380620", VA = "0x188381820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A5")]
		[BindableData(1, "The icon for the category", DataPermissions.ReadOnly)]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6000A57")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A58")]
			[Cpp2IlInjected.Address(RVA = "0x8381720", Offset = "0x8380520", VA = "0x188381720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A6")]
		[BindableData(2, "The items in this category", DataPermissions.ReadOnly)]
		public DataList<IUnifiedRoomStoreItem> Items
		{
			[Cpp2IlInjected.Token(Token = "0x6000A59")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5A")]
			[Cpp2IlInjected.Address(RVA = "0x8381890", Offset = "0x8380690", VA = "0x188381890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A7")]
		[BindableData(4, "Whether the category is selected", DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5C")]
			[Cpp2IlInjected.Address(RVA = "0xD5E570", Offset = "0xD5D370", VA = "0x180D5E570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0x83817C0", Offset = "0x83805C0", VA = "0x1883817C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A8")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0x83816B0", Offset = "0x83804B0", VA = "0x1883816B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A9")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A65")]
			[Cpp2IlInjected.Address(RVA = "0x8381670", Offset = "0x8380470", VA = "0x188381670", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AA")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x83812D0", Offset = "0x83800D0", VA = "0x1883812D0")]
		[BindableAction(3, "Selects the category")]
		public void SelectCategory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5F")]
		[Cpp2IlInjected.Address(RVA = "0x8380660", Offset = "0x837F460", VA = "0x188380660", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x8381120", Offset = "0x837FF20", VA = "0x188381120", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x8381330", Offset = "0x8380130", VA = "0x188381330")]
		private void UpdateSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x8380F70", Offset = "0x837FD70", VA = "0x188380F70")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x83811D0", Offset = "0x837FFD0", VA = "0x1883811D0")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x83807C0", Offset = "0x837F5C0", VA = "0x1883807C0")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x8380B90", Offset = "0x837F990", VA = "0x188380B90", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0x83808C0", Offset = "0x837F6C0", VA = "0x1883808C0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0x8381460", Offset = "0x8380260", VA = "0x188381460")]
		public RoomStoreCategoryViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[ViewModel]
	public class RoomStoreItemViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private string itemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private string itemDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private string priceText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private string buyText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private Sprite secondaryIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private Sprite currencyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private bool hasRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private Sprite fallbackImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private bool canBuy;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private Color iconColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private bool hidePrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		[SerializeField]
		private Sprite defaultItemImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private IUnifiedRoomStoreItem storeItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private IRRUIvNextRoomStoreBridge roomStoreBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private DataItem<string> ItemNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private DataItem<string> ItemDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private DataItem<string> PriceTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private DataItem<string> BuyTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private DataItem<Sprite> SecondaryIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private DataItem<Sprite> CurrencyIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private DataItem<bool> HasRawImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private DataItem<Sprite> FallbackImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private DataItem<bool> CanBuyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private DataItem<Color> IconColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private DataItem<bool> HidePriceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		private DataItemAction OpenStorePageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		private DataItemAction BuyItemDataItem;

		[Cpp2IlInjected.Token(Token = "0x170002AB")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6E")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A6F")]
			[Cpp2IlInjected.Address(RVA = "0x8383700", Offset = "0x8382500", VA = "0x188383700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AC")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string ItemDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000A70")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A71")]
			[Cpp2IlInjected.Address(RVA = "0x83837F0", Offset = "0x83825F0", VA = "0x1883837F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AD")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string PriceText
		{
			[Cpp2IlInjected.Token(Token = "0x6000A72")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0x8383860", Offset = "0x8382660", VA = "0x188383860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AE")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string BuyText
		{
			[Cpp2IlInjected.Token(Token = "0x6000A74")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A75")]
			[Cpp2IlInjected.Address(RVA = "0x8384120", Offset = "0x8382F20", VA = "0x188384120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AF")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A76")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A77")]
			[Cpp2IlInjected.Address(RVA = "0x83843C0", Offset = "0x83831C0", VA = "0x1883843C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B0")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public Sprite SecondaryIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000A78")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A79")]
			[Cpp2IlInjected.Address(RVA = "0x8384440", Offset = "0x8383240", VA = "0x188384440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B1")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public Sprite CurrencyIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7B")]
			[Cpp2IlInjected.Address(RVA = "0x83841A0", Offset = "0x8382FA0", VA = "0x1883841A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B2")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool HasRawImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7C")]
			[Cpp2IlInjected.Address(RVA = "0xB46000", Offset = "0xB44E00", VA = "0x180B46000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7D")]
			[Cpp2IlInjected.Address(RVA = "0x8383630", Offset = "0x8382430", VA = "0x188383630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B3")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public Sprite FallbackImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7E")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x8384250", Offset = "0x8383050", VA = "0x188384250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B4")]
		[BindableData(11, null, DataPermissions.ReadWrite)]
		public bool CanBuy
		{
			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x14DD290", Offset = "0x14DC090", VA = "0x1814DD290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x83836A0", Offset = "0x83824A0", VA = "0x1883836A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B5")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public Color IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000A84")]
			[Cpp2IlInjected.Address(RVA = "0x20C5AB0", Offset = "0x20C48B0", VA = "0x1820C5AB0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A85")]
			[Cpp2IlInjected.Address(RVA = "0x8384300", Offset = "0x8383100", VA = "0x188384300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B6")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool HidePrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x78C69F0", Offset = "0x78C57F0", VA = "0x1878C69F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x8383790", Offset = "0x8382590", VA = "0x188383790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B7")]
		public IUnifiedRoomStoreItem StoreItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0xB88140", Offset = "0xB86F40", VA = "0x180B88140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x83844F0", Offset = "0x83832F0", VA = "0x1883844F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B8")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8C")]
			[Cpp2IlInjected.Address(RVA = "0x8384000", Offset = "0x8382E00", VA = "0x188384000", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B9")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x8383FC0", Offset = "0x8382DC0", VA = "0x188383FC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BA")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action OnStoreItemChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8A")]
			[Cpp2IlInjected.Address(RVA = "0x8383F10", Offset = "0x8382D10", VA = "0x188383F10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000A8B")]
			[Cpp2IlInjected.Address(RVA = "0x8384070", Offset = "0x8382E70", VA = "0x188384070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A80")]
		[Cpp2IlInjected.Address(RVA = "0x8383130", Offset = "0x8381F30", VA = "0x188383130")]
		[BindableAction(9, null)]
		public void OpenStorePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A81")]
		[Cpp2IlInjected.Address(RVA = "0x83819C0", Offset = "0x83807C0", VA = "0x1883819C0")]
		[BindableAction(10, null)]
		public void BuyItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x83818F0", Offset = "0x83806F0", VA = "0x1883818F0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x8383050", Offset = "0x8381E50", VA = "0x188383050", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x8382FB0", Offset = "0x8381DB0", VA = "0x188382FB0")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x8381A50", Offset = "0x8380850", VA = "0x188381A50")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x83831C0", Offset = "0x8381FC0", VA = "0x1883831C0")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x8383120", Offset = "0x8381F20", VA = "0x188383120")]
		private void OnUnifiedItemUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x83838F0", Offset = "0x83826F0", VA = "0x1883838F0")]
		private void UpdateImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x8382F20", Offset = "0x8381D20", VA = "0x188382F20")]
		private void LogClick(string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A97")]
		[Cpp2IlInjected.Address(RVA = "0x8382390", Offset = "0x8381190", VA = "0x188382390", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x8381CD0", Offset = "0x8380AD0", VA = "0x188381CD0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x8383B00", Offset = "0x8382900", VA = "0x188383B00")]
		public RoomStoreItemViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[ViewModel]
	public class RoomViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass128_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000716")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000717")]
			public RoomDetailsDTO roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000718")]
			public SubRoomDTO subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000719")]
			public bool privateInstance;

			[Cpp2IlInjected.Token(Token = "0x6000B27")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public <>c__DisplayClass128_0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B28")]
			[Cpp2IlInjected.Address(RVA = "0x8391ED0", Offset = "0x8390CD0", VA = "0x188391ED0")]
			internal void <PlayAction_TryGoToRoom>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EE")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass128_1
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400071A")]
			public SubRoomDataSaveDTO latestValidSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400071B")]
			public <>c__DisplayClass128_0 CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000B29")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public <>c__DisplayClass128_1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B2A")]
			[Cpp2IlInjected.Address(RVA = "0x8391FC0", Offset = "0x8390DC0", VA = "0x188391FC0")]
			internal void <PlayAction_TryGoToRoom>b__1()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private struct <CreateOrJoinRoomInstance>d__127 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400071C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400071D")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400071E")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400071F")]
			public RoomDetailsDTO roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000720")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000722")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000723")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000B2B")]
			[Cpp2IlInjected.Address(RVA = "0x838DA50", Offset = "0x838C850", VA = "0x18838DA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B2C")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		[CompilerGenerated]
		private struct <DoPlayAction>d__126 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000724")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000725")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000727")]
			private RoomDetailsDTO <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000728")]
			private bool <canChooseSubroom>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000729")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400072A")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000B2D")]
			[Cpp2IlInjected.Address(RVA = "0x838E710", Offset = "0x838D510", VA = "0x18838E710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B2E")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		[CompilerGenerated]
		private struct <FetchRoomData>d__120 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400072B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400072C")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400072D")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400072E")]
			private TaskAwaiter<RoomDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000B2F")]
			[Cpp2IlInjected.Address(RVA = "0x838FE20", Offset = "0x838EC20", VA = "0x18838FE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B30")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[CompilerGenerated]
		private struct <PlayAction_TryGoToRoom>d__128 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400072F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000730")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000731")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000732")]
			public RoomDetailsDTO roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000733")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000734")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000735")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000736")]
			private <>c__DisplayClass128_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000737")]
			private <>c__DisplayClass128_1 <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000738")]
			private TaskAwaiter<SubRoomDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000739")]
			private IRoomSaveManager <saveManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400073A")]
			private TaskAwaiter<SubRoomDataSaveDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000B31")]
			[Cpp2IlInjected.Address(RVA = "0x8390180", Offset = "0x838EF80", VA = "0x188390180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B32")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private const string CCUCountKey = "CCU_COUNT";

		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private const char tokenDelimiter = '.';

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		[SerializeField]
		private DataResolver featureHelperResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private IRoomQueryManager roomQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private IRRUIvNextUIDataBridge vNextDataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private LoadSceneSourceData loadSceneSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private DialogListModel dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private int cheerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private int ccuCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private bool shouldFetchCCUCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private DateTime? lastPublished;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private bool hasSufficientVersionToLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		private long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private bool favorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private string cheerCountString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private bool isRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x169")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private bool showCheerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private string ccuCountString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private bool supportsPlayAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x179")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private bool supportsMoreLikeThis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17A")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private bool isPopularRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17B")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private bool isNewlyPublished;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private bool showCCUCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17D")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private bool supportsDataTokens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17E")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private bool showCheerToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17F")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		private bool requiresUpdateToPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private bool showUpdateToPlayIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x181")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private bool showUpdateToPlayText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x182")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x183")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private bool showRooms2Badge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private RoomPublishState publishState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private bool showPublishState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		private DataItem<long> RoomIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private DataItem<string> DescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private DataItem<bool> FavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private DataItem<string> CheerCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private DataItem<bool> IsRooms2DataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		private DataItem<bool> ShowCheerCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private DataItem<string> CCUCountStringDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private DataItem<bool> SupportsPlayActionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private DataItem<bool> SupportsMoreLikeThisDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private DataItem<bool> IsPopularRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private DataItem<bool> IsNewlyPublishedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private DataItem<bool> ShowCCUCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private DataItem<bool> SupportsDataTokensDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private DataItem<bool> ShowCheerTokenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private DataItem<bool> RequiresUpdateToPlayDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private DataItem<bool> ShowUpdateToPlayIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private DataItem<bool> ShowUpdateToPlayTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private DataItem<bool> ShowNewThisSessionForSectionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private DataItem<bool> ShowRooms2BadgeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private DataItem<RoomPublishState> PublishStateDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private DataItem<bool> ShowPublishStateDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private DataItemAction OpenRoomDetailsPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private DataItemAction DoPlayActionDataItem;

		[Cpp2IlInjected.Token(Token = "0x170002BB")]
		[BindableData(0, "The ID used to retrieve the room data from RecNet", DataPermissions.ReadWrite)]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB2")]
			[Cpp2IlInjected.Address(RVA = "0xBAF210", Offset = "0xBAE010", VA = "0x180BAF210")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB3")]
			[Cpp2IlInjected.Address(RVA = "0x8389790", Offset = "0x8388590", VA = "0x188389790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BC")]
		[BindableData(1, "The sanitized, friendly name of the room", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB4")]
			[Cpp2IlInjected.Address(RVA = "0xC3D480", Offset = "0xC3C280", VA = "0x180C3D480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB5")]
			[Cpp2IlInjected.Address(RVA = "0x8389680", Offset = "0x8388480", VA = "0x188389680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BD")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB6")]
			[Cpp2IlInjected.Address(RVA = "0xC3D470", Offset = "0xC3C270", VA = "0x180C3D470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB7")]
			[Cpp2IlInjected.Address(RVA = "0x8389600", Offset = "0x8388400", VA = "0x188389600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BE")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB8")]
			[Cpp2IlInjected.Address(RVA = "0xC3CF20", Offset = "0xC3BD20", VA = "0x180C3CF20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB9")]
			[Cpp2IlInjected.Address(RVA = "0x8389700", Offset = "0x8388500", VA = "0x188389700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BF")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool Favorited
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0x16E5E80", Offset = "0x16E4C80", VA = "0x1816E5E80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x83880D0", Offset = "0x8386ED0", VA = "0x1883880D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C0")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public string CheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0xC3C180", Offset = "0xC3AF80", VA = "0x180C3C180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABD")]
			[Cpp2IlInjected.Address(RVA = "0x8389580", Offset = "0x8388380", VA = "0x188389580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C1")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool IsRooms2
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x1F651C0", Offset = "0x1F63FC0", VA = "0x181F651C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x8387A70", Offset = "0x8386870", VA = "0x188387A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C2")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool ShowCheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x1F651B0", Offset = "0x1F63FB0", VA = "0x181F651B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC1")]
			[Cpp2IlInjected.Address(RVA = "0x8387AD0", Offset = "0x83868D0", VA = "0x188387AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C3")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string CCUCountString
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0xC3C140", Offset = "0xC3AF40", VA = "0x180C3C140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC3")]
			[Cpp2IlInjected.Address(RVA = "0x8389500", Offset = "0x8388300", VA = "0x188389500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C4")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool SupportsPlayAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC4")]
			[Cpp2IlInjected.Address(RVA = "0xC970A0", Offset = "0xC95EA0", VA = "0x180C970A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC5")]
			[Cpp2IlInjected.Address(RVA = "0x8387B40", Offset = "0x8386940", VA = "0x188387B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C5")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public bool SupportsMoreLikeThis
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC6")]
			[Cpp2IlInjected.Address(RVA = "0x8387BA0", Offset = "0x83869A0", VA = "0x188387BA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC7")]
			[Cpp2IlInjected.Address(RVA = "0x8387BB0", Offset = "0x83869B0", VA = "0x188387BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C6")]
		[BindableData(11, null, DataPermissions.ReadWrite)]
		public bool IsPopularRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC8")]
			[Cpp2IlInjected.Address(RVA = "0x8387C20", Offset = "0x8386A20", VA = "0x188387C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC9")]
			[Cpp2IlInjected.Address(RVA = "0x8387C30", Offset = "0x8386A30", VA = "0x188387C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C7")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool IsNewlyPublished
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACA")]
			[Cpp2IlInjected.Address(RVA = "0x8387C90", Offset = "0x8386A90", VA = "0x188387C90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ACB")]
			[Cpp2IlInjected.Address(RVA = "0x8387CA0", Offset = "0x8386AA0", VA = "0x188387CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C8")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool ShowCCUCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACC")]
			[Cpp2IlInjected.Address(RVA = "0x8387D00", Offset = "0x8386B00", VA = "0x188387D00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ACD")]
			[Cpp2IlInjected.Address(RVA = "0x8387D10", Offset = "0x8386B10", VA = "0x188387D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C9")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool SupportsDataTokens
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACE")]
			[Cpp2IlInjected.Address(RVA = "0x8387D70", Offset = "0x8386B70", VA = "0x188387D70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ACF")]
			[Cpp2IlInjected.Address(RVA = "0x8387D80", Offset = "0x8386B80", VA = "0x188387D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CA")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool ShowCheerToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD0")]
			[Cpp2IlInjected.Address(RVA = "0x8387DE0", Offset = "0x8386BE0", VA = "0x188387DE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD1")]
			[Cpp2IlInjected.Address(RVA = "0x8387DF0", Offset = "0x8386BF0", VA = "0x188387DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CB")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool RequiresUpdateToPlay
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD2")]
			[Cpp2IlInjected.Address(RVA = "0x8387E50", Offset = "0x8386C50", VA = "0x188387E50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0x8387E60", Offset = "0x8386C60", VA = "0x188387E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CC")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool ShowUpdateToPlayIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0xB91460", Offset = "0xB90260", VA = "0x180B91460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x8387EC0", Offset = "0x8386CC0", VA = "0x188387EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CD")]
		[BindableData(18, null, DataPermissions.ReadWrite)]
		public bool ShowUpdateToPlayText
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD6")]
			[Cpp2IlInjected.Address(RVA = "0x8387F20", Offset = "0x8386D20", VA = "0x188387F20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD7")]
			[Cpp2IlInjected.Address(RVA = "0x8387F30", Offset = "0x8386D30", VA = "0x188387F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CE")]
		[BindableData(19, null, DataPermissions.ReadWrite)]
		public bool ShowNewThisSessionForSection
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD8")]
			[Cpp2IlInjected.Address(RVA = "0x8387F90", Offset = "0x8386D90", VA = "0x188387F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD9")]
			[Cpp2IlInjected.Address(RVA = "0x8387FA0", Offset = "0x8386DA0", VA = "0x188387FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CF")]
		[BindableData(20, null, DataPermissions.ReadWrite)]
		public bool ShowRooms2Badge
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADA")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ADB")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D0")]
		[BindableData(21, null, DataPermissions.ReadWrite)]
		public RoomPublishState PublishState
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADC")]
			[Cpp2IlInjected.Address(RVA = "0xB5EA20", Offset = "0xB5D820", VA = "0x180B5EA20")]
			get
			{
				return default(RoomPublishState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ADD")]
			[Cpp2IlInjected.Address(RVA = "0x8388000", Offset = "0x8386E00", VA = "0x188388000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D1")]
		[BindableData(22, null, DataPermissions.ReadWrite)]
		public bool ShowPublishState
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADE")]
			[Cpp2IlInjected.Address(RVA = "0xC485E0", Offset = "0xC473E0", VA = "0x180C485E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ADF")]
			[Cpp2IlInjected.Address(RVA = "0x8388060", Offset = "0x8386E60", VA = "0x188388060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D2")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE0")]
			[Cpp2IlInjected.Address(RVA = "0x83893D0", Offset = "0x83881D0", VA = "0x1883893D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D3")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE1")]
			[Cpp2IlInjected.Address(RVA = "0x83893C0", Offset = "0x83881C0", VA = "0x1883893C0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE2")]
			[Cpp2IlInjected.Address(RVA = "0x8389780", Offset = "0x8388580", VA = "0x188389780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D4")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF4")]
			[Cpp2IlInjected.Address(RVA = "0x8389380", Offset = "0x8388180", VA = "0x188389380", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D5")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF5")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<ILoadable> Loaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE3")]
			[Cpp2IlInjected.Address(RVA = "0x83892C0", Offset = "0x83880C0", VA = "0x1883892C0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE4")]
			[Cpp2IlInjected.Address(RVA = "0x8389440", Offset = "0x8388240", VA = "0x188389440", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0x83847C0", Offset = "0x83835C0", VA = "0x1883847C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE6")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x8386CD0", Offset = "0x8385AD0", VA = "0x188386CD0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x8386AF0", Offset = "0x83858F0", VA = "0x188386AF0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x8384AC0", Offset = "0x83838C0", VA = "0x188384AC0")]
		[AsyncStateMachine(typeof(<FetchRoomData>d__120))]
		private void FetchRoomData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x83888A0", Offset = "0x83876A0", VA = "0x1883888A0")]
		private void UpdateRoomData(RoomDTO roomDto)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEB")]
		[Cpp2IlInjected.Address(RVA = "0x8388140", Offset = "0x8386F40", VA = "0x188388140")]
		private void UpdateFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x83875D0", Offset = "0x83863D0", VA = "0x1883875D0")]
		private void ResetRoomData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x8386D80", Offset = "0x8385B80", VA = "0x188386D80")]
		private void OnFeatureHelperUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x8386DA0", Offset = "0x8385BA0", VA = "0x188386DA0")]
		[BindableAction(100, null)]
		private void OpenRoomDetailsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x8384A10", Offset = "0x8383810", VA = "0x188384A10")]
		[AsyncStateMachine(typeof(<DoPlayAction>d__126))]
		[BindableAction(101, null)]
		private void DoPlayAction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x8384910", Offset = "0x8383710", VA = "0x188384910")]
		[AsyncStateMachine(typeof(<CreateOrJoinRoomInstance>d__127))]
		private void CreateOrJoinRoomInstance(bool privateInstance, RoomDetailsDTO roomDetails, bool canChooseSubroom = false, bool randomSubroom = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x83872C0", Offset = "0x83860C0", VA = "0x1883872C0")]
		[AsyncStateMachine(typeof(<PlayAction_TryGoToRoom>d__128))]
		private void PlayAction_TryGoToRoom(RoomDetailsDTO roomDetails, bool privateInstance, bool canChooseSubroom, bool randomSubroom)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x83873D0", Offset = "0x83861D0", VA = "0x1883873D0")]
		private void RecordImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF3")]
		[Cpp2IlInjected.Address(RVA = "0x8384670", Offset = "0x8383470", VA = "0x188384670")]
		private void AddDataTokenToImpressionData(string dataToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF6")]
		[Cpp2IlInjected.Address(RVA = "0x8385710", Offset = "0x8384510", VA = "0x188385710", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF7")]
		[Cpp2IlInjected.Address(RVA = "0x8384B70", Offset = "0x8383970", VA = "0x188384B70")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x8388C50", Offset = "0x8387A50", VA = "0x188388C50")]
		public RoomViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[ViewModel]
	public class WatchHomeRoomStoreCarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private bool shouldShowRoomStore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		private bool shouldShowRoomInventory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		private DataList<IUnifiedRoomStoreItem> roomStoreItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private DataList<IUnifiedRoomInventoryItem> roomInventoryItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		[SerializeField]
		private Uri roomStoreUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		[SerializeField]
		private Uri roomInventoryUriR1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		[SerializeField]
		private Uri roomInventoryUriR2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		[SerializeField]
		private int maxActiveCards;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private IRRUIvNextRoomStoreBridge roomStoreBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private IRRUIvNextRoomInventoryBridge roomInventoryBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		private DataItem<bool> ShouldShowRoomStoreDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private DataItem<bool> ShouldShowRoomInventoryDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private DataItemList RoomStoreItemsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		private DataItemList RoomInventoryItemsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private DataItemAction GoToRoomStoreDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private DataItemAction GoToRoomInventoryDataItem;

		[Cpp2IlInjected.Token(Token = "0x170002D6")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool ShouldShowRoomStore
		{
			[Cpp2IlInjected.Token(Token = "0x6000B35")]
			[Cpp2IlInjected.Address(RVA = "0xACFCF0", Offset = "0xACEAF0", VA = "0x180ACFCF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B36")]
			[Cpp2IlInjected.Address(RVA = "0x8393880", Offset = "0x8392680", VA = "0x188393880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D7")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool ShouldShowRoomInventory
		{
			[Cpp2IlInjected.Token(Token = "0x6000B37")]
			[Cpp2IlInjected.Address(RVA = "0xE16FE0", Offset = "0xE15DE0", VA = "0x180E16FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x83938E0", Offset = "0x83926E0", VA = "0x1883938E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D8")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public DataList<IUnifiedRoomStoreItem> RoomStoreItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x8393DD0", Offset = "0x8392BD0", VA = "0x188393DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D9")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public DataList<IUnifiedRoomInventoryItem> RoomInventoryItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0x8393D70", Offset = "0x8392B70", VA = "0x188393D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DA")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000B42")]
			[Cpp2IlInjected.Address(RVA = "0x8393D30", Offset = "0x8392B30", VA = "0x188393D30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DB")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000B43")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x8392990", Offset = "0x8391790", VA = "0x188392990")]
		[BindableAction(0, null)]
		public void GoToRoomStore()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x8392880", Offset = "0x8391680", VA = "0x188392880")]
		[BindableAction(1, null)]
		public void GoToRoomInventory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x83922D0", Offset = "0x83910D0", VA = "0x1883922D0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x8392F50", Offset = "0x8391D50", VA = "0x188392F50", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x8393340", Offset = "0x8392140", VA = "0x188393340")]
		private void OnStoreItemsChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x8393070", Offset = "0x8391E70", VA = "0x188393070")]
		private void OnInventoryItemsChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x8393650", Offset = "0x8392450", VA = "0x188393650")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x8392A50", Offset = "0x8391850", VA = "0x188392A50", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x8392540", Offset = "0x8391340", VA = "0x188392540")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x8393AE0", Offset = "0x83928E0", VA = "0x188393AE0")]
		public WatchHomeRoomStoreCarouselViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public class RRUIBaseGlobalViewModel : BaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x170002DC")]
		protected override string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x839B800", Offset = "0x839A600", VA = "0x18839B800", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x839B7F0", Offset = "0x839A5F0", VA = "0x18839B7F0")]
		public RRUIBaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public class RRUIBaseLocalViewModel : BaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		[SerializeField]
		protected ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		protected CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.Token(Token = "0x170002DD")]
		protected override string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x839B9A0", Offset = "0x839A7A0", VA = "0x18839B9A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x839B930", Offset = "0x839A730", VA = "0x18839B930", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x839B830", Offset = "0x839A630", VA = "0x18839B830")]
		protected CancellationToken CancelAndRefreshToken()
		{
			return default(CancellationToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x839B8E0", Offset = "0x839A6E0", VA = "0x18839B8E0")]
		protected void CancelToken()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x839B990", Offset = "0x839A790", VA = "0x18839B990")]
		public RRUIBaseLocalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public class PopoverCornerController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		[SerializeField]
		private GameObject topLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		[SerializeField]
		private GameObject topCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		[SerializeField]
		private GameObject topRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		[SerializeField]
		private GameObject upperLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		[SerializeField]
		private GameObject middleLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		[SerializeField]
		private GameObject lowerLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		[SerializeField]
		private GameObject upperRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		[SerializeField]
		private GameObject middleRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		[SerializeField]
		private GameObject lowerRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		[SerializeField]
		private GameObject bottomLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		[SerializeField]
		private GameObject bottomCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		[SerializeField]
		private GameObject bottomRight;

		[Cpp2IlInjected.Token(Token = "0x170002DE")]
		public PopoverAnchor ActiveAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x6000B56")]
			[Cpp2IlInjected.Address(RVA = "0xFABA20", Offset = "0xFAA820", VA = "0x180FABA20")]
			[CompilerGenerated]
			get
			{
				return default(PopoverAnchor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B57")]
			[Cpp2IlInjected.Address(RVA = "0x1AC10A0", Offset = "0x1ABFEA0", VA = "0x181AC10A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x839B640", Offset = "0x839A440", VA = "0x18839B640")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x839B660", Offset = "0x839A460", VA = "0x18839B660")]
		public void SetActiveAnchor(PopoverAnchor anchor, bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x839B7D0", Offset = "0x839A5D0", VA = "0x18839B7D0")]
		public PopoverCornerController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public class Tutorial
	{
		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public enum CompletionState
		{
			[Cpp2IlInjected.Token(Token = "0x4000764")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000765")]
			Completed,
			[Cpp2IlInjected.Token(Token = "0x4000766")]
			SoftExit,
			[Cpp2IlInjected.Token(Token = "0x4000767")]
			HardExit
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private List<TutorialStep> steps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private int activeStepIdx;

		[Cpp2IlInjected.Token(Token = "0x170002DF")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5B")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5C")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E0")]
		public TutorialStep ActiveStep
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5D")]
			[Cpp2IlInjected.Address(RVA = "0x83A2D40", Offset = "0x83A1B40", VA = "0x1883A2D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E1")]
		public IReadOnlyList<TutorialStep> Steps
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E2")]
		public DQHMEXLDKHB OnTutorialStarted
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E3")]
		public DQHMEXLDKHB OnTutorialExited
		{
			[Cpp2IlInjected.Token(Token = "0x6000B60")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E4")]
		public DQHMEXLDKHB OnStepChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000B61")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E5")]
		public CompletionState CompletionStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000B62")]
			[Cpp2IlInjected.Address(RVA = "0xAC6560", Offset = "0xAC5360", VA = "0x180AC6560")]
			[CompilerGenerated]
			get
			{
				return default(CompletionState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0xAC6870", Offset = "0xAC5670", VA = "0x180AC6870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x83A2B70", Offset = "0x83A1970", VA = "0x1883A2B70")]
		public Tutorial(string id, List<TutorialStep> steps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x83A2B30", Offset = "0x83A1930", VA = "0x1883A2B30")]
		public void StartTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0x83A24C0", Offset = "0x83A12C0", VA = "0x1883A24C0")]
		public void ExitTutorial(bool showAgain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B67")]
		[Cpp2IlInjected.Address(RVA = "0x83A2640", Offset = "0x83A1440", VA = "0x1883A2640")]
		public void SetActiveStep(string id, bool forceReload = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B68")]
		[Cpp2IlInjected.Address(RVA = "0x83A2780", Offset = "0x83A1580", VA = "0x1883A2780")]
		public void SetActiveStep(int idx, bool forceReload = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x83A2540", Offset = "0x83A1340", VA = "0x1883A2540")]
		private void OnGoBack()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x83A25C0", Offset = "0x83A13C0", VA = "0x1883A25C0")]
		private void OnStepCompleted()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public class TutorialHighlightTargeter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		[SerializeField]
		protected List<TutorialTargetData> tutorialTargets;

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x839C300", Offset = "0x839B100", VA = "0x18839C300", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x839C460", Offset = "0x839B260", VA = "0x18839C460", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x839C740", Offset = "0x839B540", VA = "0x18839C740")]
		private void RegisterTargets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x839C8D0", Offset = "0x839B6D0", VA = "0x18839C8D0")]
		public TutorialHighlightTargeter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public class TutorialTargetData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public string TutorialId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public string StepId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public RectTransform Target;

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x25337E0", Offset = "0x25325E0", VA = "0x1825337E0")]
		public TutorialTargetData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public enum PopoverAnchor
	{
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		TopLeft,
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		TopCenter,
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		TopRight,
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		UpperLeft,
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		MiddleLeft,
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		LowerLeft,
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		UpperRight,
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		MiddleRight,
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		LowerRight,
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		BottomLeft,
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		BottomCenter,
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		BottomRight,
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		MiddleCenter
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public class TutorialStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		private bool isActive;

		[Cpp2IlInjected.Token(Token = "0x170002E6")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B71")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E7")]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6000B72")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B73")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E8")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000B74")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B75")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E9")]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6000B76")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B77")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EA")]
		public string ButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000B78")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B79")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EB")]
		public string CountText
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B7B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EC")]
		public bool HasButtonToGoForward
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7C")]
			[Cpp2IlInjected.Address(RVA = "0xF7B8E0", Offset = "0xF7A6E0", VA = "0x180F7B8E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B7D")]
			[Cpp2IlInjected.Address(RVA = "0xF7B4A0", Offset = "0xF7A2A0", VA = "0x180F7B4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002ED")]
		public bool HasButtonToGoBack
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7E")]
			[Cpp2IlInjected.Address(RVA = "0x15A35D0", Offset = "0x15A23D0", VA = "0x1815A35D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B7F")]
			[Cpp2IlInjected.Address(RVA = "0x15A2FF0", Offset = "0x15A1DF0", VA = "0x1815A2FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EE")]
		public bool ShowCountText
		{
			[Cpp2IlInjected.Token(Token = "0x6000B80")]
			[Cpp2IlInjected.Address(RVA = "0x7A5AB00", Offset = "0x7A59900", VA = "0x187A5AB00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B81")]
			[Cpp2IlInjected.Address(RVA = "0x22AA560", Offset = "0x22A9360", VA = "0x1822AA560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EF")]
		public bool ShowExitButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x7692050", Offset = "0x7690E50", VA = "0x187692050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x83A0A40", Offset = "0x839F840", VA = "0x1883A0A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F0")]
		public bool CanSoftExit
		{
			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x19B7770", Offset = "0x19B6570", VA = "0x1819B7770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B85")]
			[Cpp2IlInjected.Address(RVA = "0x19B7760", Offset = "0x19B6560", VA = "0x1819B7760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F1")]
		public bool AllowInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x2A1AB00", Offset = "0x2A19900", VA = "0x182A1AB00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B87")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B150", Offset = "0x2A19F50", VA = "0x182A1B150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F2")]
		public bool TargetingHUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x7914D30", Offset = "0x7913B30", VA = "0x187914D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x7914D50", Offset = "0x7913B50", VA = "0x187914D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F3")]
		public PopoverAnchor DialogAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8A")]
			[Cpp2IlInjected.Address(RVA = "0xB45FA0", Offset = "0xB44DA0", VA = "0x180B45FA0")]
			[CompilerGenerated]
			get
			{
				return default(PopoverAnchor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8B")]
			[Cpp2IlInjected.Address(RVA = "0x10073B0", Offset = "0x10061B0", VA = "0x1810073B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F4")]
		public RectTransform TutorialHighlightTarget
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8C")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8D")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F5")]
		public DQHMEXLDKHB OnStepCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8E")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F6")]
		public DQHMEXLDKHB OnStepModified
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0xAC31D0", Offset = "0xAC1FD0", VA = "0x180AC31D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F7")]
		public DQHMEXLDKHB OnGoBack
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F8")]
		public bool ShouldShow
		{
			[Cpp2IlInjected.Token(Token = "0x6000B91")]
			[Cpp2IlInjected.Address(RVA = "0xC5E3C0", Offset = "0xC5D1C0", VA = "0x180C5E3C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B92")]
			[Cpp2IlInjected.Address(RVA = "0x1039590", Offset = "0x1038390", VA = "0x181039590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F9")]
		public bool CompleteStepOnButtonPress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B93")]
			[Cpp2IlInjected.Address(RVA = "0x1323E80", Offset = "0x1322C80", VA = "0x181323E80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B94")]
			[Cpp2IlInjected.Address(RVA = "0x15F58C0", Offset = "0x15F46C0", VA = "0x1815F58C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x83A0890", Offset = "0x839F690", VA = "0x1883A0890")]
		public TutorialStep(string id, string title, string description, Sprite icon, string buttonText, bool showExitButton, bool canSoftExit, bool canGoBack, bool canGoForward, bool showCount, bool allowInteraction, bool targetingHud, PopoverAnchor dialogAnchor, bool shouldShow, bool completeStepOnButtonPress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x83A06B0", Offset = "0x839F4B0", VA = "0x1883A06B0")]
		public void SetHighlightTarget(RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x83A0670", Offset = "0x839F470", VA = "0x1883A0670")]
		public void SetCountText(string countText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x83A0370", Offset = "0x839F170", VA = "0x1883A0370")]
		public void BeginStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x83A0530", Offset = "0x839F330", VA = "0x1883A0530")]
		private void DeactiveStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0x83A0500", Offset = "0x839F300", VA = "0x1883A0500")]
		public void CompleteStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9B")]
		[Cpp2IlInjected.Address(RVA = "0x83A0640", Offset = "0x839F440", VA = "0x1883A0640")]
		public void GoBack()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9C")]
		[Cpp2IlInjected.Address(RVA = "0x83A04C0", Offset = "0x839F2C0", VA = "0x1883A04C0")]
		public void ChangeTitle(string newTitle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9D")]
		[Cpp2IlInjected.Address(RVA = "0x83A0480", Offset = "0x839F280", VA = "0x1883A0480")]
		public void ChangeDescription(string newDescription)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[ViewModel]
	public class TutorialStepViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		[CompilerGenerated]
		private sealed class <UpdateVisualsCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			public TutorialStepViewModel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700030A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000BE1")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700030B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000BE3")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000BDE")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <UpdateVisualsCoroutine>d__68(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BDF")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE0")]
			[Cpp2IlInjected.Address(RVA = "0x83A31E0", Offset = "0x83A1FE0", VA = "0x1883A31E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE2")]
			[Cpp2IlInjected.Address(RVA = "0x83A32A0", Offset = "0x83A20A0", VA = "0x1883A32A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		[SerializeField]
		private RectTransform highlightArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		[SerializeField]
		private RectTransform dialogTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		[SerializeField]
		private float maskPadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		[SerializeField]
		private float additionalAnchorOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		[SerializeField]
		private PopoverCornerController popoverCornerController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		private TutorialStep step;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		private Coroutine updateVisualsCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		private Canvas targetCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		private string title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		private string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		private string buttonText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		private bool showMainButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private bool canInteractWithHighlightArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private bool showExitButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		private bool showNextArrowButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		private bool showBackArrowButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		private string countText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		private bool hasIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		private Sprite icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		private DataItem<string> TitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		private DataItem<string> DescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		private DataItem<string> ButtonTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		private DataItem<bool> ShowMainButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		private DataItem<bool> CanInteractWithHighlightAreaDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		private DataItem<bool> ShowExitButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		private DataItem<bool> ShowNextArrowButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		private DataItem<bool> ShowBackArrowButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		private DataItem<string> CountTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		private DataItem<bool> HasIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		private DataItem<Sprite> IconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		private DataItemAction GoToNextStepDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private DataItemAction SkipTutorialDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		private DataItemAction SoftExitTutorialDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		private DataItemAction GoToPreviousStepDataItem;

		[Cpp2IlInjected.Token(Token = "0x170002FA")]
		private Camera screenCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x83A0000", Offset = "0x839EE00", VA = "0x1883A0000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FB")]
		private Canvas sourceCanvas
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x83A00A0", Offset = "0x839EEA0", VA = "0x1883A00A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FC")]
		private RectTransform sourceCanvasRect
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x83A0020", Offset = "0x839EE20", VA = "0x1883A0020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FD")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA2")]
			[Cpp2IlInjected.Address(RVA = "0x83A02F0", Offset = "0x839F0F0", VA = "0x1883A02F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FE")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA3")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA4")]
			[Cpp2IlInjected.Address(RVA = "0x83A01C0", Offset = "0x839EFC0", VA = "0x1883A01C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FF")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string ButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA6")]
			[Cpp2IlInjected.Address(RVA = "0x83A00C0", Offset = "0x839EEC0", VA = "0x1883A00C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000300")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool ShowMainButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA7")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD60", Offset = "0xAECB60", VA = "0x180AEDD60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x839EE40", Offset = "0x839DC40", VA = "0x18839EE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000301")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool CanInteractWithHighlightArea
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x2238F50", Offset = "0x2237D50", VA = "0x182238F50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAA")]
			[Cpp2IlInjected.Address(RVA = "0x839EEA0", Offset = "0x839DCA0", VA = "0x18839EEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000302")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool ShowExitButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAB")]
			[Cpp2IlInjected.Address(RVA = "0x1866490", Offset = "0x1865290", VA = "0x181866490")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAC")]
			[Cpp2IlInjected.Address(RVA = "0x839EC70", Offset = "0x839DA70", VA = "0x18839EC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000303")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool ShowNextArrowButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAD")]
			[Cpp2IlInjected.Address(RVA = "0x18664A0", Offset = "0x18652A0", VA = "0x1818664A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAE")]
			[Cpp2IlInjected.Address(RVA = "0x839ECD0", Offset = "0x839DAD0", VA = "0x18839ECD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000304")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool ShowBackArrowButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAF")]
			[Cpp2IlInjected.Address(RVA = "0x1F3F130", Offset = "0x1F3DF30", VA = "0x181F3F130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB0")]
			[Cpp2IlInjected.Address(RVA = "0x839ED30", Offset = "0x839DB30", VA = "0x18839ED30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000305")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string CountText
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x83A0140", Offset = "0x839EF40", VA = "0x1883A0140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000306")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool HasIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0xB88090", Offset = "0xB86E90", VA = "0x180B88090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0x839EDA0", Offset = "0x839DBA0", VA = "0x18839EDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000307")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0xB88130", Offset = "0xB86F30", VA = "0x180B88130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x83A0240", Offset = "0x839F040", VA = "0x1883A0240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000308")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC3")]
			[Cpp2IlInjected.Address(RVA = "0x839FFC0", Offset = "0x839EDC0", VA = "0x18839FFC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000309")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC4")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x839DC40", Offset = "0x839CA40", VA = "0x18839DC40")]
		[BindableAction(100, null)]
		public void GoToNextStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x839EB20", Offset = "0x839D920", VA = "0x18839EB20")]
		[BindableAction(101, null)]
		public void SkipTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x839EBC0", Offset = "0x839D9C0", VA = "0x18839EBC0")]
		[BindableAction(102, null)]
		public void SoftExitTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x839DC90", Offset = "0x839CA90", VA = "0x18839DC90")]
		[BindableAction(103, null)]
		public void GoToPreviousStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x839E9F0", Offset = "0x839D7F0", VA = "0x18839E9F0")]
		public void Set(TutorialStep step)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x839E990", Offset = "0x839D790", VA = "0x18839E990")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x839E950", Offset = "0x839D750", VA = "0x18839E950")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x839E8A0", Offset = "0x839D6A0", VA = "0x18839E8A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x839EF00", Offset = "0x839DD00", VA = "0x18839EF00")]
		private void UpdateStepData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x839F4F0", Offset = "0x839E2F0", VA = "0x18839F4F0")]
		[IteratorStateMachine(typeof(<UpdateVisualsCoroutine>d__68))]
		private IEnumerator UpdateVisualsCoroutine()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x839F560", Offset = "0x839E360", VA = "0x18839F560")]
		private void UpdateVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x839CC10", Offset = "0x839BA10", VA = "0x18839CC10")]
		private void AlignEdgeToEdge(RectTransform source, RectTransform target, TextAnchor sourceEdge, TextAnchor targetEdge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x839DCE0", Offset = "0x839CAE0", VA = "0x18839DCE0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x839D510", Offset = "0x839C310", VA = "0x18839D510")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x839FBB0", Offset = "0x839E9B0", VA = "0x18839FBB0")]
		public TutorialStepViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public class TutorialUIManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public static DQHMEXLDKHB OnCreated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public DQHMEXLDKHB OnDataUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		private Dictionary<string, Dictionary<string, RectTransform>> tutorialTargets;

		[Cpp2IlInjected.Token(Token = "0x1700030C")]
		public static TutorialUIManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x83A1990", Offset = "0x83A0790", VA = "0x1883A1990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0x83A19E0", Offset = "0x83A07E0", VA = "0x1883A19E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030D")]
		public Tutorial ActiveTutorial
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE6")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A50", Offset = "0x839F850", VA = "0x1883A0A50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x83A0D50", Offset = "0x839FB50", VA = "0x1883A0D50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEA")]
		[Cpp2IlInjected.Address(RVA = "0x83A0BD0", Offset = "0x839F9D0", VA = "0x1883A0BD0")]
		private void ClearActiveTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEB")]
		[Cpp2IlInjected.Address(RVA = "0x83A0BE0", Offset = "0x839F9E0", VA = "0x1883A0BE0")]
		private void ClearActiveTutorial(bool sendUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x83A11B0", Offset = "0x839FFB0", VA = "0x1883A11B0")]
		public void StartTutorial(Tutorial tutorial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x83A0CC0", Offset = "0x839FAC0", VA = "0x1883A0CC0")]
		public void EndTutorial(bool showAgain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x83A0E80", Offset = "0x839FC80", VA = "0x1883A0E80")]
		public void RegisterTutorialTarget(string tutorialId, string stepId, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x83A1580", Offset = "0x83A0380", VA = "0x1883A1580")]
		public void UnregisterTutorialTarget(string tutorialId, string stepId, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x83A18D0", Offset = "0x83A06D0", VA = "0x1883A18D0")]
		public TutorialUIManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[ViewModel]
	public class TutorialUIViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		[SerializeField]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		[SerializeField]
		private TutorialStepViewModel tutorialStepViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		private Tutorial activeTutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		private bool isTutorialActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		private DataItem<bool> IsTutorialActiveDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700030E")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool IsTutorialActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0xACFCF0", Offset = "0xACEAF0", VA = "0x180ACFCF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x83A23B0", Offset = "0x83A11B0", VA = "0x1883A23B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0x83A2490", Offset = "0x83A1290", VA = "0x1883A2490", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000310")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFA")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x83A1A50", Offset = "0x83A0850", VA = "0x1883A1A50", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x83A22A0", Offset = "0x83A10A0", VA = "0x1883A22A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x83A1DA0", Offset = "0x83A0BA0", VA = "0x1883A1DA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x83A2220", Offset = "0x83A1020", VA = "0x1883A2220")]
		private void OnStepChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0x83A1F40", Offset = "0x83A0D40", VA = "0x1883A1F40")]
		private void OnManagerUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x83A1C60", Offset = "0x83A0A60", VA = "0x1883A1C60", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x83A1B60", Offset = "0x83A0960", VA = "0x1883A1B60")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x83A2410", Offset = "0x83A1210", VA = "0x1883A2410")]
		public TutorialUIViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CreateAssetMenu(fileName = "UITutorialData", menuName = "RecRoom/UI/UI Tutorial Data")]
	public class UITutorialData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		private class TutorialStepData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007C5")]
			public string Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007C6")]
			public string Title;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007C7")]
			public string Description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007C8")]
			public Sprite OptionalIcon;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007C9")]
			public string ButtonText;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007CA")]
			public bool ShowButtonToGoForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x40007CB")]
			public bool ShowButtonToGoBack;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x40007CC")]
			public bool ShowCountText;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
			[Cpp2IlInjected.Token(Token = "0x40007CD")]
			public bool ShowExitButton;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40007CE")]
			public bool CanSoftExit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
			[Cpp2IlInjected.Token(Token = "0x40007CF")]
			public bool AllowInteraction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3E")]
			[Cpp2IlInjected.Token(Token = "0x40007D0")]
			public bool TargetingHUD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3F")]
			[Cpp2IlInjected.Token(Token = "0x40007D1")]
			public bool ShouldShow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007D2")]
			public bool CompleteStepOnButtonPress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			public PopoverAnchor DialogAnchor;

			[Cpp2IlInjected.Token(Token = "0x6000C02")]
			[Cpp2IlInjected.Address(RVA = "0x839C950", Offset = "0x839B750", VA = "0x18839C950")]
			public TutorialStep ToTutorialStep()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C03")]
			[Cpp2IlInjected.Address(RVA = "0x839CB70", Offset = "0x839B970", VA = "0x18839CB70")]
			public TutorialStepData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		[SerializeField]
		private string id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		[SerializeField]
		private List<TutorialStepData> steps;

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x83A3910", Offset = "0x83A2710", VA = "0x1883A3910")]
		public Tutorial GenerateTutorialFromData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x83A3B60", Offset = "0x83A2960", VA = "0x1883A3B60")]
		public UITutorialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public enum UILinkType
	{
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		Uri,
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		Tab,
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		Legacy
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public enum LegacyUIType
	{
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		Challenges,
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		Outfits
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public class LinkInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		public UILinkType LinkType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		[ConditionalField("requiresUri")]
		public Uri LinkUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		[ConditionalField("LinkType", UILinkType.Tab)]
		public WatchTab LinkTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		[ConditionalField("LinkType", UILinkType.Legacy)]
		public LegacyUIType LegacyType;

		[Cpp2IlInjected.Token(Token = "0x17000311")]
		public bool IsLegacyUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C04")]
			[Cpp2IlInjected.Address(RVA = "0x839B450", Offset = "0x839A250", VA = "0x18839B450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x839B410", Offset = "0x839A210", VA = "0x18839B410")]
		public LinkInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CreateAssetMenu(fileName = "RouteLookup", menuName = "RecRoom/UI/Route Lookup")]
	public class UILinkLookup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		[FormerlySerializedAs("routeInfos")]
		[SerializeField]
		private List<LinkInfo> linkInfoList;

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x83A35E0", Offset = "0x83A23E0", VA = "0x1883A35E0")]
		public bool TryGetLinkInfo(string alias, [Out] LinkInfo linkInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x83A3760", Offset = "0x83A2560", VA = "0x1883A3760")]
		public bool TryGetUri(string routeId, [Out] Uri uri)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x83A32E0", Offset = "0x83A20E0", VA = "0x1883A32E0")]
		public List<Uri> GetAllUri()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C09")]
		[Cpp2IlInjected.Address(RVA = "0x83A3460", Offset = "0x83A2260", VA = "0x1883A3460")]
		public bool TryGetLegacyUIType(string routeId, [Out] LegacyUIType legacyUIType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public UILinkLookup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public class WatchViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		private const string UnifiedUISessionIdKey = "unified_ui_session_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private IMenuManager _menuManager;

		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(RVA = "0x83A3C00", Offset = "0x83A2A00", VA = "0x1883A3C00", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0C")]
		[Cpp2IlInjected.Address(RVA = "0x83A3E90", Offset = "0x83A2C90", VA = "0x1883A3E90", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x83A3F60", Offset = "0x83A2D60", VA = "0x1883A3F60")]
		private void OnWatchMenuUnifiedSessionIdChanged(Guid watchMenuUnifiedSessionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x839B7F0", Offset = "0x839A5F0", VA = "0x18839B7F0")]
		public WatchViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public class CanvasScreenSizeRefitter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		[SerializeField]
		private Canvas targetCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		[SerializeField]
		private float minPercentageOfScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		[SerializeField]
		private float maxPercentageOfScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		[SerializeField]
		private float offsetFromNearClipPlane;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		[SerializeField]
		private Camera lookAtCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		[SerializeField]
		private bool updateOnCameraMove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		[SerializeField]
		private bool useScreenSafeArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		[SerializeField]
		private bool forceWidthToFitScreen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		private Vector2 cachedDimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private Vector2 cachedSafeAreaDimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		private Vector3 cachedCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private Quaternion cachedCameraRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private float cachedFov;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		private bool forceUpdate;

		[Cpp2IlInjected.Token(Token = "0x17000312")]
		public Canvas TargetCanvas
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000313")]
		public Camera TargetCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000314")]
		public float OffsetFromCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x8394A70", Offset = "0x8393870", VA = "0x188394A70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000315")]
		private float cameraFov
		{
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x8394B00", Offset = "0x8393900", VA = "0x188394B00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000316")]
		private Vector3 cameraPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x8394B90", Offset = "0x8393990", VA = "0x188394B90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000317")]
		private Quaternion cameraRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000C14")]
			[Cpp2IlInjected.Address(RVA = "0x8394C60", Offset = "0x8393A60", VA = "0x188394C60")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000318")]
		private RectTransform canvasRect
		{
			[Cpp2IlInjected.Token(Token = "0x6000C15")]
			[Cpp2IlInjected.Address(RVA = "0x8394D30", Offset = "0x8393B30", VA = "0x188394D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
		public void SetLookCamera(Camera lookAt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x8393E30", Offset = "0x8392C30", VA = "0x188393E30")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x8393E40", Offset = "0x8392C40", VA = "0x188393E40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x8394550", Offset = "0x8393350", VA = "0x188394550")]
		private void UpdateScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x83940C0", Offset = "0x8392EC0", VA = "0x1883940C0")]
		public void PinToTopLeftOfScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x8394960", Offset = "0x8393760", VA = "0x188394960")]
		public CanvasScreenSizeRefitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[DisallowMultipleComponent]
	public class FocusableAllowedStateHelper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200010A")]
		public enum StateOverrideSource
		{
			[Cpp2IlInjected.Token(Token = "0x40007FF")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			Statsig,
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			GameConfig
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private string defaultStatsigLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		private string defaultStatsigParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		[SerializeField]
		private FocusableUI focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		[SerializeField]
		private StateOverrideSource overrideSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		[ConditionalVisibility("overrideSource", ConditionResultType.ShowIfEquals, 1)]
		[SerializeField]
		private string statsigLayerOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		[ConditionalVisibility("overrideSource", ConditionResultType.ShowIfEquals, 1)]
		[SerializeField]
		private string statsigParameterOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		[ConditionalVisibility("overrideSource", ConditionResultType.ShowIfEquals, 2)]
		[SerializeField]
		private string gameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		private YEADHGPVUSS configProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		private DINTWZBUUTH statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private bool allowed;

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x8395190", Offset = "0x8393F90", VA = "0x188395190")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x83958B0", Offset = "0x83946B0", VA = "0x1883958B0")]
		private void UpdateWhenStatsigReady()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x8395630", Offset = "0x8394430", VA = "0x188395630")]
		private void UpdateFromStatsig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x8395800", Offset = "0x8394600", VA = "0x188395800")]
		private void UpdateWhenConfigReady()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x8395420", Offset = "0x8394220", VA = "0x188395420")]
		private void UpdateFromGameConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x8395960", Offset = "0x8394760", VA = "0x188395960")]
		public FocusableAllowedStateHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public class FocusStateHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Selectable focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		public UnityEvent<BaseEventData> FocusGained;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		public UnityEvent<BaseEventData> FocusLost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		public UnityEvent OnEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		public UnityEvent OnDisabled;

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x8394D90", Offset = "0x8393B90", VA = "0x188394D90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x8394ED0", Offset = "0x8393CD0", VA = "0x188394ED0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x8395000", Offset = "0x8393E00", VA = "0x188395000")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x8394FE0", Offset = "0x8393DE0", VA = "0x188394FE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x8395020", Offset = "0x8393E20", VA = "0x188395020")]
		private void OnSelect(BaseEventData eventData, Selectable selectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x8394E70", Offset = "0x8393C70", VA = "0x188394E70")]
		private void OnDeselect(BaseEventData eventData, Selectable selectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x8395080", Offset = "0x8393E80", VA = "0x188395080")]
		public FocusStateHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public class ImpressionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		public Dictionary<string, int> IntData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		public Dictionary<string, float> FloatData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000809")]
		public Dictionary<string, long> LongData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		public Dictionary<string, string> StringData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400080B")]
		public Dictionary<string, Guid> GuidData;

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x83966C0", Offset = "0x83954C0", VA = "0x1883966C0")]
		public bool TryGetValueAsString(string key, [Out] string valString, string format = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2A")]
		[Cpp2IlInjected.Address(RVA = "0x8396480", Offset = "0x8395280", VA = "0x188396480")]
		public GBKDVYHUEHJ.EGWGLKTRFNS TryAddProperty(string key, GBKDVYHUEHJ.EGWGLKTRFNS eventBuilder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0x8395B10", Offset = "0x8394910", VA = "0x188395B10")]
		public void ClearData(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0x8395A30", Offset = "0x8394830", VA = "0x188395A30")]
		public void ClearAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2D")]
		[Cpp2IlInjected.Address(RVA = "0x8395D40", Offset = "0x8394B40", VA = "0x188395D40")]
		public void CopyData(ImpressionData copyTo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2E")]
		[Cpp2IlInjected.Address(RVA = "0x8396890", Offset = "0x8395690", VA = "0x188396890")]
		public ImpressionData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public class ImpressionTracker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		public enum PassToChildren
		{
			[Cpp2IlInjected.Token(Token = "0x400082D")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x400082E")]
			Enabled,
			[Cpp2IlInjected.Token(Token = "0x400082F")]
			EnabledRecursive
		}

		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[Flags]
		internal enum ImpressionLogEvents
		{
			[Cpp2IlInjected.Token(Token = "0x4000831")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000832")]
			OnClickThrough = 1,
			[Cpp2IlInjected.Token(Token = "0x4000833")]
			OnNavigateToNewPage = 2,
			[Cpp2IlInjected.Token(Token = "0x4000834")]
			OnMenuClosed = 4,
			[Cpp2IlInjected.Token(Token = "0x4000835")]
			OnStopTracking = 8,
			[Cpp2IlInjected.Token(Token = "0x4000836")]
			OnDisable = 0x10
		}

		[Cpp2IlInjected.Token(Token = "0x2000110")]
		internal enum ImpressionLogConditions
		{
			[Cpp2IlInjected.Token(Token = "0x4000838")]
			NoConditions,
			[Cpp2IlInjected.Token(Token = "0x4000839")]
			OnlyWhenChildrenAreTracked
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		[CompilerGenerated]
		private struct <FinishCleanUpAfterLoggingComplete>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400083A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400083B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400083C")]
			public Task logTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400083D")]
			public ImpressionTracker <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400083E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000C5C")]
			[Cpp2IlInjected.Address(RVA = "0x83A2DA0", Offset = "0x83A1BA0", VA = "0x1883A2DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C5D")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400080C")]
		private static ZMYQXPNYBJS<ImpressionData> ImpressionDataPool;

		[Cpp2IlInjected.Token(Token = "0x400080D")]
		private const float minSecondsForImpression = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x400080E")]
		private const string buttonLocationProperty = "buttonLocation";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400080F")]
		[SerializeField]
		private ImpressionLogEvents logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000810")]
		[SerializeField]
		private ImpressionLogConditions logConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		[SerializeField]
		private VisibilityChecker visibilityChecker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private ImpressionData impressionData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		private int idCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		private Dictionary<int, string> idToKeyLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		private Dictionary<string, int> keyToIdLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private List<int> recordedKeys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		private List<int> dataToRecordOnClickThrough;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private List<ImpressionTracker> children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private List<ImpressionTracker> tempChildrenWhileLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private Dictionary<int, PassToChildren> dataToPassToChildren;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		private List<int> dataToCollateFromChildrenOnLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private Dictionary<int, int> collatedDataToRecordUnderDifferentKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		private List<int> dataToClearOnChildrenAfterLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private Dictionary<int, string> defaultValueLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		private Dictionary<string, string> stringFormatLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private List<ImpressionData> childImpressionsNotYetLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		private List<ImpressionData> allChildImpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private Uri pageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		private bool pageUriActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		private ImpressionTracker parentTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		private bool parentTrackerInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		private bool trackingActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		private StringBuilder stringBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		public Action<ImpressionTracker> ChildAdded;

		[Cpp2IlInjected.Token(Token = "0x17000319")]
		public bool AutoTrackWhenVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000C30")]
			[Cpp2IlInjected.Address(RVA = "0xC38280", Offset = "0xC37080", VA = "0x180C38280")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0xC37250", Offset = "0xC36050", VA = "0x180C37250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x839AE10", Offset = "0x8399C10", VA = "0x18839AE10")]
		private void TryInitializeParentTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x8396A20", Offset = "0x8395820", VA = "0x188396A20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x8398490", Offset = "0x8397290", VA = "0x188398490")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x8398330", Offset = "0x8397130", VA = "0x188398330")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x8398CB0", Offset = "0x8397AB0", VA = "0x188398CB0")]
		public void SetDataToCollateFromChildrenOnLog(string key, string defaultValue, bool clearAfterLogging = false, string keyToRecordCollatedData = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x8398E60", Offset = "0x8397C60", VA = "0x188398E60")]
		public void SetDataToRecordOnClickThrough(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x8397640", Offset = "0x8396440", VA = "0x188397640")]
		public void LogImpression(bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x8397200", Offset = "0x8396000", VA = "0x188397200")]
		[AsyncStateMachine(typeof(<FinishCleanUpAfterLoggingComplete>d__45))]
		private void FinishCleanUpAfterLoggingComplete(Task logTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x839A5A0", Offset = "0x83993A0", VA = "0x18839A5A0")]
		public void StartTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x839AA50", Offset = "0x8399850", VA = "0x18839AA50")]
		public void StopTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x839A900", Offset = "0x8399700", VA = "0x18839A900")]
		public void StopTrackingAndClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x83987C0", Offset = "0x83975C0", VA = "0x1883987C0")]
		public void RecordClickThrough([Optional] string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x8399EE0", Offset = "0x8398CE0", VA = "0x188399EE0")]
		public void SetString(string key, string data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x8399F10", Offset = "0x8398D10", VA = "0x188399F10")]
		public void SetString(string key, string data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x8399550", Offset = "0x8398350", VA = "0x188399550")]
		public void SetGuid(string key, Guid data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x8399240", Offset = "0x8398040", VA = "0x188399240")]
		public void SetGuid(string key, Guid data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x83998A0", Offset = "0x83986A0", VA = "0x1883998A0")]
		public void SetLong(string key, long data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x83998D0", Offset = "0x83986D0", VA = "0x1883998D0")]
		public void SetLong(string key, long data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x8398F20", Offset = "0x8397D20", VA = "0x188398F20")]
		public void SetFloat(string key, float data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x8398F50", Offset = "0x8397D50", VA = "0x188398F50")]
		public void SetFloat(string key, float data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x8399BB0", Offset = "0x83989B0", VA = "0x188399BB0")]
		public void SetObject(string key, object data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C46")]
		[Cpp2IlInjected.Address(RVA = "0x8399BE0", Offset = "0x83989E0", VA = "0x188399BE0")]
		public void SetObject(string key, object data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x8399870", Offset = "0x8398670", VA = "0x188399870")]
		public void SetInt(string key, int data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x8399590", Offset = "0x8398390", VA = "0x188399590")]
		public void SetInt(string key, int data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x839AD90", Offset = "0x8399B90", VA = "0x18839AD90")]
		public bool TryGetValueAsString(string key, [Out] string valString, string format = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4A")]
		[Cpp2IlInjected.Address(RVA = "0x8396C10", Offset = "0x8395A10", VA = "0x188396C10")]
		public void ClearData(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x8397360", Offset = "0x8396160", VA = "0x188397360")]
		private int GetOrAddKeyId(string key)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x83972D0", Offset = "0x83960D0", VA = "0x1883972D0")]
		private string GetKey(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x8398A90", Offset = "0x8397890", VA = "0x188398A90")]
		private void RecordDuration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x839A320", Offset = "0x8399120", VA = "0x18839A320")]
		private void StartTrackingChild(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x839A940", Offset = "0x8399740", VA = "0x18839A940")]
		private void StopTrackingChild(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x83974E0", Offset = "0x83962E0", VA = "0x1883974E0")]
		private void HandleVisibilityChanged(bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x83981D0", Offset = "0x8396FD0", VA = "0x1883981D0")]
		private void LogImpressionsOnBrowserModelNavigationComplete(PageWrapper destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x8398280", Offset = "0x8397080", VA = "0x188398280")]
		private void LogImpressionsOnMenuClose(bool isOpen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x8398B50", Offset = "0x8397950", VA = "0x188398B50")]
		private void ResetDurationTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x839AF00", Offset = "0x8399D00", VA = "0x18839AF00")]
		private void TryResumeTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x83984B0", Offset = "0x83972B0", VA = "0x1883984B0")]
		private void PassDataToChild(string key, ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x8396E40", Offset = "0x8395C40", VA = "0x188396E40")]
		private string CollateDataFromChildren(int keyId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x839A1F0", Offset = "0x8398FF0", VA = "0x18839A1F0")]
		private int SortByElementIndex(ImpressionData lhs, ImpressionData rhs)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x8396C00", Offset = "0x8395A00", VA = "0x188396C00")]
		private bool CanLogEvent(ImpressionLogEvents logEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x8397450", Offset = "0x8396250", VA = "0x188397450")]
		private void GuaranteeImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x839B030", Offset = "0x8399E30", VA = "0x18839B030")]
		public ImpressionTracker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	public class CanvasSizeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		public Vector2 CanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000840")]
		public PlatformMask Platforms;

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CanvasSizeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CreateAssetMenu(fileName = "PlatformDependentCanvasSizeConfig", menuName = "RecRoom/UI/Canvas Size Settings")]
	public class PlatformDependentCanvasSizeConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000841")]
		[SerializeField]
		private Vector2 fallbackCanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000842")]
		[SerializeField]
		private List<CanvasSizeData> canvasSizeSettings;

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x839B460", Offset = "0x839A260", VA = "0x18839B460")]
		public Vector2 GetSizeForPlatform(PlatformMask platform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x839B5E0", Offset = "0x839A3E0", VA = "0x18839B5E0")]
		public PlatformDependentCanvasSizeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public class RaycastIgnoreTransformFilter : MonoBehaviour, ICanvasRaycastFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000843")]
		[SerializeField]
		private List<RectTransform> targetTransforms;

		[Cpp2IlInjected.Token(Token = "0x6000C61")]
		[Cpp2IlInjected.Address(RVA = "0x839B9D0", Offset = "0x839A7D0", VA = "0x18839B9D0", Slot = "4")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public RaycastIgnoreTransformFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	public class RectTransformAspectRatioResizer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		public enum ResizeDimension
		{
			[Cpp2IlInjected.Token(Token = "0x4000847")]
			Height,
			[Cpp2IlInjected.Token(Token = "0x4000848")]
			Width
		}

		[Cpp2IlInjected.Token(Token = "0x2000117")]
		[CompilerGenerated]
		private sealed class <FitResizeDimensionToAspectRatioAtEndOfFrame>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000849")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400084A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400084B")]
			public RectTransformAspectRatioResizer <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700031A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C6B")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700031B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C6D")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C68")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public <FitResizeDimensionToAspectRatioAtEndOfFrame>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C69")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C6A")]
			[Cpp2IlInjected.Address(RVA = "0x83A30B0", Offset = "0x83A1EB0", VA = "0x1883A30B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C6C")]
			[Cpp2IlInjected.Address(RVA = "0x83A3150", Offset = "0x83A1F50", VA = "0x1883A3150", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000844")]
		[SerializeField]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000845")]
		[SerializeField]
		private ResizeDimension resizeDimension;

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x839C030", Offset = "0x839AE30", VA = "0x18839C030")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x839BB40", Offset = "0x839A940", VA = "0x18839BB40")]
		[IteratorStateMachine(typeof(<FitResizeDimensionToAspectRatioAtEndOfFrame>d__4))]
		private IEnumerator FitResizeDimensionToAspectRatioAtEndOfFrame()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C65")]
		[Cpp2IlInjected.Address(RVA = "0x839BBB0", Offset = "0x839A9B0", VA = "0x18839BBB0")]
		private void FitResizeDimensionToAspectRatio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x839BE70", Offset = "0x839AC70", VA = "0x18839BE70")]
		private float GetScreenAspectRatio(RectTransform rectTransform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public RectTransformAspectRatioResizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public static class RectTransformUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x839C1B0", Offset = "0x839AFB0", VA = "0x18839C1B0")]
		public static void MatchSourceLossyScale(this Transform source, Transform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x839C0B0", Offset = "0x839AEB0", VA = "0x18839C0B0")]
		public static Vector2 GetPivotFromAnchor(TextAnchor anchor)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class RRUIBinderAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
