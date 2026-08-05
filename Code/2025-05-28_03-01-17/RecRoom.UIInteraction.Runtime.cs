using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using TMPro;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_UIInteraction_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88DF7C0", Offset = "0x88DE5C0", VA = "0x1888DF7C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HHECDAMDIKH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x88DAD80", Offset = "0x88D9B80", VA = "0x1888DAD80")]
	public static void EHHBIHBNOFK(Component OFNOAHMACNB, bool DLKFMHELCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x88DAF60", Offset = "0x88D9D60", VA = "0x1888DAF60")]
	public static void JGPCPCCLMHN(Text ALKALAAAMFE, string KMIPFFIBFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88DAEE0", Offset = "0x88D9CE0", VA = "0x1888DAEE0")]
	public static void JGPCPCCLMHN(TMP_Text ALKALAAAMFE, string KMIPFFIBFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x88DAE10", Offset = "0x88D9C10", VA = "0x1888DAE10")]
	public static void HPNPJMDEJCC(Image GEEHFPKJDLD, Sprite ANBFKCCECPF, bool EOJMLLDENIC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x88DAC70", Offset = "0x88D9A70", VA = "0x1888DAC70")]
	public static void CEJGDCGMCKP(RawImage GEEHFPKJDLD, Texture2D FBFLLKLGAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x88DACF0", Offset = "0x88D9AF0", VA = "0x1888DACF0")]
	public static void CFFBDJEEALO(Graphic OJBMOHFCGPF, Color DEJLIDMJHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x88DAA70", Offset = "0x88D9870", VA = "0x1888DAA70")]
	public static bool AFMCAMMHELP(GameObject MMMAEDGEACA)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class DragScrollDecorator : MonoBehaviour, IScrollHandler, IEventSystemHandler, IDragHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private bool supportsHorizontalScrolling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool supportsVerticalScrolling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly IMAAKJGDPMH<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly IMAAKJGDPMH<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LGADNKHLGNM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GPPOGHFBCPG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xF9B930", Offset = "0xF9A730", VA = "0x180F9B930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float FNCLIAHBPGL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xC3DD60", Offset = "0xC3CB60", VA = "0x180C3DD60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform KDEKPJBNACE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88D8AE0", Offset = "0x88D78E0", VA = "0x1888D8AE0", Slot = "5")]
		public void OnDrag(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88D8B60", Offset = "0x88D7960", VA = "0x1888D8B60", Slot = "4")]
		public void OnScroll(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88D8A90", Offset = "0x88D7890", VA = "0x1888D8A90")]
		private Vector2 BOILAMJJIDL(Vector2 BNIFDEOHMGD)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88D8BE0", Offset = "0x88D79E0", VA = "0x1888D8BE0")]
		public DragScrollDecorator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu("Event/Fast Graphic Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class FastGraphicRaycaster : BaseRaycaster
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct MGPCLIGNOHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Graphic AIBEHPPEJII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int LOBBDDCGCBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Bounds AKCALJGOOBH;
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker MGDKCLECHGH;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static bool DoOptimizedEarlyOutOfRaycast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly GHDFENKGPPP OHOHIIGFFMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool FFPCDFECKJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected Canvas MPDJDHNNNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected Camera EAOCPGPMIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FastGraphicRaycasterGroup EEHHDMKMLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool IIFGEIBHDCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private AHGDDDFDDJE OILNGEALLKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool? NEDAJBFLECP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<Graphic> GJLMIECOOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int IBFPOBOPHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<MGPCLIGNOHE> FDBNKPJJCPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Vector3[] CIPBPJFMCNB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<MGPCLIGNOHE> LJMAOJJNDEB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool PBHBCIBIHBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x88DA8F0", Offset = "0x88D96F0", VA = "0x1888DA8F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool MAJHCILMOGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x88DA9E0", Offset = "0x88D97E0", VA = "0x1888DA9E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool LGNGAJMLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x88D9D30", Offset = "0x88D8B30", VA = "0x1888D9D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Camera GNNNCHIIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88D8E70", Offset = "0x88D7C70", VA = "0x1888D8E70", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88DA760", Offset = "0x88D9560", VA = "0x1888DA760")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88D9A00", Offset = "0x88D8800", VA = "0x1888D9A00", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88D9AB0", Offset = "0x88D88B0", VA = "0x1888D9AB0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88DA670", Offset = "0x88D9470", VA = "0x1888DA670")]
		public void SetDisabledToken(bool OAIIHELJHLG, DPBIDJALKLM JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x88D9DC0", Offset = "0x88D8BC0", VA = "0x1888D9DC0", Slot = "17")]
		public override void Raycast(PointerEventData FELHJOMEEAD, List<RaycastResult> JDBCGDHCLBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x88D9B20", Offset = "0x88D8920", VA = "0x1888D9B20")]
		protected void PHEFCGOLBNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88D8F30", Offset = "0x88D7D30", VA = "0x1888D8F30")]
		private void ONLKACENELK(Canvas DLBHIGKBIOC, Camera GNNNCHIIBMA, Vector2 PILPFMIJCDC, Ray GFECPFADFNH, List<Graphic> NPDCNNDIODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88D99E0", Offset = "0x88D87E0", VA = "0x1888D99E0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88D8CB0", Offset = "0x88D7AB0", VA = "0x1888D8CB0")]
		public static Bounds GetBounds(Graphic DJNJGENDJMJ, Vector3[] BKCKBKJADLM)
		{
			return default(Bounds);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FastGraphicRaycasterGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool JOMBMMHEOJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6CF0290", Offset = "0x6CEF090", VA = "0x186CF0290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RequireComponent(typeof(Canvas))]
	public class FullScreenModalUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public FullScreenModalUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AHGDDDFDDJE
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray CGNEEDEHLIL, [Out] Graphic MMNDBFPIJKE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable EJNENKNIDAH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LHIMKAAILBN
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera MBOMLAHDEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LLEAAEBCCKF FLIONACCIPP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IMAAKJGDPMH<GameObject> BEMDGELCOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[DisallowMultipleComponent]
	public class UIAnchor : UIBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool JJDEFGKMAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool LMALKCLHIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool DHBDGIAAOOC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool LBDMCKILGEP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x88DEF00", Offset = "0x88DDD00", VA = "0x1888DEF00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool GDLIFDPNCKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x88DF730", Offset = "0x88DE530", VA = "0x1888DF730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x88DEDA0", Offset = "0x88DDBA0", VA = "0x1888DEDA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88DF420", Offset = "0x88DE220", VA = "0x1888DF420", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88DF400", Offset = "0x88DE200", VA = "0x1888DF400", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88DF360", Offset = "0x88DE160", VA = "0x1888DF360", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88DF540", Offset = "0x88DE340", VA = "0x1888DF540", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88DF340", Offset = "0x88DE140", VA = "0x1888DF340", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x88DF660", Offset = "0x88DE460", VA = "0x1888DF660")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88DF460", Offset = "0x88DE260", VA = "0x1888DF460")]
		public void SetFollowerConstraintEnabled(bool MAFNDJNJAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88DF150", Offset = "0x88DDF50", VA = "0x1888DF150")]
		private void HCPMICPEHHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88DF220", Offset = "0x88DE020", VA = "0x1888DF220")]
		private void OGJIGABLPEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88DEF60", Offset = "0x88DDD60", VA = "0x1888DEF60")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88DF6E0", Offset = "0x88DE4E0", VA = "0x1888DF6E0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AADIHPBKDFA
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x88D8220", Offset = "0x88D7020", VA = "0x1888D8220")]
	public static bool POGGAFNCOPM(this Transform OBOFPKCKJOC, Transform BOGJJGPKPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41367D0", Offset = "0x41355D0", VA = "0x1841367D0")]
	public static T JDHOEOIIKKK<T>(this Component GDCDKMJLKDH, bool FMMNKOONKFJ = false) where T : class
	{
		return null;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UIAnchorFollowConstraint : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class PLFFKJDCAFA : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public UIAnchorFollowConstraint <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private Vector3 <initialPosition>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private Vector3 <initialRotationEuler>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private bool <doMove>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private bool <doRotate>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
			[DebuggerHidden]
			public PLFFKJDCAFA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x88DBDF0", Offset = "0x88DABF0", VA = "0x1888DBDF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x88DB100", Offset = "0x88D9F00", VA = "0x1888DB100", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x88DBD60", Offset = "0x88DAB60", VA = "0x1888DBD60")]
			private void PPMJPANAFBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x88DBDA0", Offset = "0x88DABA0", VA = "0x1888DBDA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[Tooltip("Curve that describes the rate of follow motion at different points in the follow (e.g.- ease in and out when starting or stopping the motion).")]
		private AnimationCurve easingCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[Tooltip("How much can the UI anchor move (in meters) before this object starts following it.")]
		private float followPositionThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[Tooltip("How much can the UI anchor rotate (in degrees) before this object starts following it.")]
		private float followRotationThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Tooltip("The maximum speed (in meters/second) that the UI anchor follower move when following the anchor.")]
		private float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[Tooltip("The maximum speed (in degrees/second) that the UI anchor follower rotate when following the anchor.")]
		private float rotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		[Tooltip("The position delta (in meters) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		private float easingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[Tooltip("The rotation delta (in degrees) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		private float rotationEasingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the X-axis.")]
		private bool allowXRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the Y-axis.")]
		private bool allowYRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the Z-axis.")]
		private bool allowZRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private float maxAllowedVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Vector3 MLAEGLPHOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Quaternion GNOJBGBHDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Coroutine GJBBGGLCMBE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float DBNANDFOIBG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xC27A80", Offset = "0xC26880", VA = "0x180C27A80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HJOODMKLMKI
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6BEA6D0", Offset = "0x6BE94D0", VA = "0x186BEA6D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88DC6C0", Offset = "0x88DB4C0", VA = "0x1888DC6C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x168ABB0", Offset = "0x16899B0", VA = "0x18168ABB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88DC810", Offset = "0x88DB610", VA = "0x1888DC810")]
		public void SetTarget(Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88DC360", Offset = "0x88DB160", VA = "0x1888DC360")]
		[IteratorStateMachine(typeof(PLFFKJDCAFA))]
		private IEnumerator KDGGHHAGFIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x88DC030", Offset = "0x88DAE30", VA = "0x1888DC030")]
		private float CPCPKNBCGPC(float PBLGKPFBEFJ, Vector3 OCJMHBGMDBG, Vector3 IGEBPEIAHLG, float NKALBDLCLFI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88DBFA0", Offset = "0x88DADA0", VA = "0x1888DBFA0")]
		private float CPCPKNBCGPC(float PBLGKPFBEFJ, float EBMHBMDHNLG, float GNLFNPOIGCK, float NKALBDLCLFI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x88DC730", Offset = "0x88DB530", VA = "0x1888DC730")]
		private Vector3 PJEIMJBJLJE(Vector3 CDJKDAGCBKN, Vector3 AAKAGDOFPBF, Vector3 MACLBEFOGKL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88DC330", Offset = "0x88DB130", VA = "0x1888DC330")]
		private bool HGILCOHLICG(float DDEBNKFKCJA, float AAKAGDOFPBF, float MACLBEFOGKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x88DC1C0", Offset = "0x88DAFC0", VA = "0x1888DC1C0")]
		private Vector3 DJABFEMDCKI(Quaternion LJIHJJKHDDH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x88DC2A0", Offset = "0x88DB0A0", VA = "0x1888DC2A0")]
		private bool GDKCMOFONIF(Vector3 NPJPCFKLMHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88DC3E0", Offset = "0x88DB1E0", VA = "0x1888DC3E0")]
		private bool ONCEIJGGCIC(Quaternion LJIHJJKHDDH, bool ALFDDOENJBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x88DBEF0", Offset = "0x88DACF0", VA = "0x1888DBEF0")]
		private bool CKEENMLOBMB(Vector3 ALCLKCHJGII, Vector3 GFJPONDOIDH, float MFHMNDJJPGF = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x88DBF40", Offset = "0x88DAD40", VA = "0x1888DBF40")]
		private bool CKEENMLOBMB(Quaternion ALCLKCHJGII, Quaternion GFJPONDOIDH, float MFHMNDJJPGF = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x88DCA30", Offset = "0x88DB830", VA = "0x1888DCA30")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum ALLCMDOPLFG
		{
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			UIRaycast,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			CanvasRender
		}

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static bool UseFaceCameraSyncOptimizations;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static bool DisableUIAnchorFaceCameraForMirrors;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const string JADJDKPBLFM = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const string LFNJBEGHMAK = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static readonly List<UIAnchorFollower> NIONCCCDIEI;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly LLEAAEBCCKF OnUIAnchorsUpdated;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static LHIMKAAILBN HKHHADDNOEN;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int DLOEFMCKFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly LLEAAEBCCKF OnSyncTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		[SerializeField]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private UIAnchorFollowConstraint followConstraint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private GHLDACEJKIG JGPODCDKBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 JDNCEIEDGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Quaternion AHDENHOIGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Vector3 KLGKLGAKAGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool DDDGLGDCPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool BPGFGMNDAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool DMBAILJBCKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Vector3 LLLBBMDIFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly DPBIDJALKLM JLFLGDNCANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private PDGDOIDNPGO PDNJNHDLPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Transform DDLGHMMPBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private UIAnchor DDGDJDDKOBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public bool DoCanvasRenderSync;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static ProfilerMarker NGPNFKENKHG;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool JLFEIPBNLDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x88DD5F0", Offset = "0x88DC3F0", VA = "0x1888DD5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private Transform MAAFBDAKBJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1ECF940", Offset = "0x1ECE740", VA = "0x181ECF940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public UIAnchor IDGKJJKMADM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCFC430", Offset = "0xCFB230", VA = "0x180CFC430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private bool KFKMHMNAMDF
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x88DCF30", Offset = "0x88DBD30", VA = "0x1888DCF30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x88DD460", Offset = "0x88DC260", VA = "0x1888DD460")]
		[EKIJCKMDHHI]
		internal static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x88DD610", Offset = "0x88DC410", VA = "0x1888DD610")]
		[OHEKCAPHOOO(LHBMPOBGEAI.ExitingPlayMode, 0)]
		private static void LEOIPKKBJIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x88DDDD0", Offset = "0x88DCBD0", VA = "0x1888DDDD0")]
		public static void SyncAllFollowers(ALLCMDOPLFG JAPGNGDBBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x88DCF60", Offset = "0x88DBD60", VA = "0x1888DCF60")]
		private static void EKHIAFOOLAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x88DD9F0", Offset = "0x88DC7F0", VA = "0x1888DD9F0")]
		private static void MBKAIGHAJOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x88DCB30", Offset = "0x88DB930", VA = "0x1888DCB30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x88DDA40", Offset = "0x88DC840", VA = "0x1888DDA40", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x88DD540", Offset = "0x88DC340", VA = "0x1888DD540")]
		public void Initialize(UIAnchor DDGDJDDKOBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x88DDC50", Offset = "0x88DCA50", VA = "0x1888DDC50")]
		public void SetAnchorObjectEnabled(bool MAFNDJNJAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x88DDCA0", Offset = "0x88DCAA0", VA = "0x1888DDCA0")]
		public void SetCanvasRenderingEnabled(bool MAFNDJNJAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x88DCFB0", Offset = "0x88DBDB0", VA = "0x1888DCFB0")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88DD1A0", Offset = "0x88DBFA0", VA = "0x1888DD1A0")]
		private void GHENMEGHJDJ(bool MAFNDJNJAOJ, object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x88DD6F0", Offset = "0x88DC4F0", VA = "0x1888DD6F0")]
		private void LIJAGGNLEOO(bool MAFNDJNJAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x88DE140", Offset = "0x88DCF40", VA = "0x1888DE140")]
		public bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x88DDD60", Offset = "0x88DCB60", VA = "0x1888DDD60")]
		public void SetConstraintEnabled(bool MAFNDJNJAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x88DDCF0", Offset = "0x88DCAF0", VA = "0x1888DDCF0")]
		public void SetConstraintAllowed(bool FBFFNDOKIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x88DD320", Offset = "0x88DC120", VA = "0x1888DD320")]
		private bool HGAMCBFHPGD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x88DD7E0", Offset = "0x88DC5E0", VA = "0x1888DD7E0")]
		private void LJKOOCCOMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x88DEC00", Offset = "0x88DDA00", VA = "0x1888DEC00")]
		public UIAnchorFollower()
		{
		}
	}
}
namespace TMPro
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class Clickable : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class MGDACHAEJIE : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private GCOFLMDGPIM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
			[DebuggerHidden]
			public MGDACHAEJIE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x88DAFE0", Offset = "0x88D9DE0", VA = "0x1888DAFE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x88DB0B0", Offset = "0x88D9EB0", VA = "0x1888DB0B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private const float ENHNMNAAOLH = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool DJHOJMJDJPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int LCPMLMKPKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private PointerEventData HOBAMDEHMLD;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IMAAKJGDPMH<PointerEventData> JIJCHJHIICE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IMAAKJGDPMH<PointerEventData> LDPFBIHENBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IMAAKJGDPMH<PointerEventData> FDOJKEOAOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IMAAKJGDPMH<PointerEventData> NGNPPIPJKDE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public IMAAKJGDPMH<PointerEventData> ILCCLLDGLOK
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public IMAAKJGDPMH<PointerEventData> PJNEIHILLOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IMAAKJGDPMH<PointerEventData> MKDEBEOJGKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x88D8500", Offset = "0x88D7300", VA = "0x1888D8500", Slot = "4")]
		public void OnPointerClick(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x88D8830", Offset = "0x88D7630", VA = "0x1888D8830", Slot = "5")]
		public void OnPointerUp(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x88D8560", Offset = "0x88D7360", VA = "0x1888D8560", Slot = "6")]
		public void OnPointerDown(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88D8470", Offset = "0x88D7270", VA = "0x1888D8470")]
		[IteratorStateMachine(typeof(MGDACHAEJIE))]
		private IEnumerator<GCOFLMDGPIM> NKOEHEEAKKP(int LCPMLMKPKLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x88D86D0", Offset = "0x88D74D0", VA = "0x1888D86D0", Slot = "7")]
		public void OnPointerEnter(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x88D8770", Offset = "0x88D7570", VA = "0x1888D8770", Slot = "8")]
		public void OnPointerExit(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x88D8360", Offset = "0x88D7160", VA = "0x1888D8360")]
		private bool KOCFLAMOKIH(GameObject MMMAEDGEACA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x88D88A0", Offset = "0x88D76A0", VA = "0x1888D88A0")]
		public Clickable()
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
