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
		[Cpp2IlInjected.Address(RVA = "0x872F540", Offset = "0x872DB40", VA = "0x18872F540", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EJHODDDDEOL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8729AC0", Offset = "0x87280C0", VA = "0x188729AC0")]
	public static void POGILNKCKCJ(Component HABFEKNHDFB, bool CBHHPIGGAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x87298E0", Offset = "0x8727EE0", VA = "0x1887298E0")]
	public static void FKGFLLHJLDC(Text EPPCFIOLOHF, string HKOKFJFBOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8729860", Offset = "0x8727E60", VA = "0x188729860")]
	public static void FKGFLLHJLDC(TMP_Text EPPCFIOLOHF, string HKOKFJFBOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x87299F0", Offset = "0x8727FF0", VA = "0x1887299F0")]
	public static void NFHIJEAKMDF(Image ABELIKGDONF, Sprite FFCGKLIFOBI, bool NDLOLCGMJLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x87295E0", Offset = "0x8727BE0", VA = "0x1887295E0")]
	public static void BOPIFLPGNKC(RawImage ABELIKGDONF, Texture2D BFGBBIJNNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8729960", Offset = "0x8727F60", VA = "0x188729960")]
	public static void KEMOFIOOILF(Graphic KBLAAHMKMKM, Color NGGKCKILBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8729660", Offset = "0x8727C60", VA = "0x188729660")]
	public static bool DNBGMKDMMNP(GameObject CEKGANCAJPA)
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
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
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
		public readonly NPNKPOOAOFG<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly NPNKPOOAOFG<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ACINOEHAOCC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LPFPGGCFDPA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xF59450", Offset = "0xF57A50", VA = "0x180F59450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float AKJDJKAEMHH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xC1B080", Offset = "0xC19680", VA = "0x180C1B080")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform LOEIBILFEHI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8729410", Offset = "0x8727A10", VA = "0x188729410", Slot = "5")]
		public void OnDrag(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8729490", Offset = "0x8727A90", VA = "0x188729490", Slot = "4")]
		public void OnScroll(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87293C0", Offset = "0x87279C0", VA = "0x1887293C0")]
		private Vector2 NPOKDLCABIA(Vector2 KDOOLHFKKFE)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8729510", Offset = "0x8727B10", VA = "0x188729510")]
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
		private struct GPDKIHAIGHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Graphic KEKKFCDMPCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int OKJAOMGGAAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Bounds PNNFGKEEHFB;
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker BMGEFGBKNGD;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static bool DoOptimizedEarlyOutOfRaycast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly JDAIBCKBDGJ LIGGNIKCDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool LDAOLFPBIBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected Canvas IGEJHFINBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected Camera IIPJDNKCFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FastGraphicRaycasterGroup NKDIJBBEMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool JABMMDDHHBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ANHADHEKDKG NOCIAPEGMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool? GNBFOKJHGOO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<Graphic> INKLFIPBBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int HFIGMDFIGIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<GPDKIHAIGHF> IKMMJBEAKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Vector3[] PGBHDMNGGPO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<GPDKIHAIGHF> KLKMKKHJNAD;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CNAOLIGFIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x872B830", Offset = "0x8729E30", VA = "0x18872B830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool OJFCMBKEDEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x872B920", Offset = "0x8729F20", VA = "0x18872B920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool KDAEJEJECFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8729B50", Offset = "0x8728150", VA = "0x188729B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Camera EEDFLFNMIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8729FB0", Offset = "0x87285B0", VA = "0x188729FB0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x872B6A0", Offset = "0x8729CA0", VA = "0x18872B6A0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x872AB40", Offset = "0x8729140", VA = "0x18872AB40", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x872ABF0", Offset = "0x87291F0", VA = "0x18872ABF0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x872B5B0", Offset = "0x8729BB0", VA = "0x18872B5B0")]
		public void SetDisabledToken(bool OHLIHBDBKCE, BDMLCHKFOFH EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x872AC60", Offset = "0x8729260", VA = "0x18872AC60", Slot = "17")]
		public override void Raycast(PointerEventData NKBJHKLGFDP, List<RaycastResult> PINMANGOLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8729BE0", Offset = "0x87281E0", VA = "0x188729BE0")]
		protected void FCGIADKOLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x872A070", Offset = "0x8728670", VA = "0x18872A070")]
		private void OKKELIMCIGO(Canvas JBDHENCGNJB, Camera EEDFLFNMIDJ, Vector2 GEJGGMHKHHB, Ray LEIIOGOBEOH, List<Graphic> NOMCIBPFMGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x872AB20", Offset = "0x8729120", VA = "0x18872AB20", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8729DF0", Offset = "0x87283F0", VA = "0x188729DF0")]
		public static Bounds GetBounds(Graphic NOKCJFMDPME, Vector3[] LGOHFNMIALF)
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
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool DJLLMFIFBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6BA3670", Offset = "0x6BA1C70", VA = "0x186BA3670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RequireComponent(typeof(Canvas))]
	public class FullScreenModalUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public FullScreenModalUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ANHADHEKDKG
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray KHDAOEHDBLC, [Out] Graphic GKMBKNMBGAN);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable FBFBGFCDBIM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NMAMEBHMFHH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera HLJEAOCGCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GCADBNOOJOM NDMALIOLJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NPNKPOOAOFG<GameObject> MJHPOHFHIAM
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
		[ANKANEOPOFH(JINCPHMLLKA.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool MGAKCNPMLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool JDFKAINEFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool LDIJJMAPDAL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool GCOFMDBEOJB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x872EB20", Offset = "0x872D120", VA = "0x18872EB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool ICKJCPJGIAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x872F4B0", Offset = "0x872DAB0", VA = "0x18872F4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x872EB80", Offset = "0x872D180", VA = "0x18872EB80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x872F1A0", Offset = "0x872D7A0", VA = "0x18872F1A0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x872F180", Offset = "0x872D780", VA = "0x18872F180", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x872F0E0", Offset = "0x872D6E0", VA = "0x18872F0E0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x872F2C0", Offset = "0x872D8C0", VA = "0x18872F2C0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x872F0C0", Offset = "0x872D6C0", VA = "0x18872F0C0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x872F3E0", Offset = "0x872D9E0", VA = "0x18872F3E0")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x872F1E0", Offset = "0x872D7E0", VA = "0x18872F1E0")]
		public void SetFollowerConstraintEnabled(bool BFEIIPBAHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x872ECE0", Offset = "0x872D2E0", VA = "0x18872ECE0")]
		private void FAGACFPKBCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x872EFA0", Offset = "0x872D5A0", VA = "0x18872EFA0")]
		private void LDDKHDBOHGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x872EDB0", Offset = "0x872D3B0", VA = "0x18872EDB0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x872F460", Offset = "0x872DA60", VA = "0x18872F460")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OMOPMPCHBNJ
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x872BAD0", Offset = "0x872A0D0", VA = "0x18872BAD0")]
	public static bool BENBEIBNCNG(this Transform HMCFPGIFOED, Transform JHDAOHEONAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x39FE450", Offset = "0x39FCA50", VA = "0x1839FE450")]
	public static T GCMIEMDLMLL<T>(this Component FCPOJLOEIEO, bool PLJFHNDJAFC = false) where T : class
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
		private sealed class BCIEABENFLP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
			[DebuggerHidden]
			public BCIEABENFLP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8728C10", Offset = "0x8727210", VA = "0x188728C10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8727F60", Offset = "0x8726560", VA = "0x188727F60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8727F20", Offset = "0x8726520", VA = "0x188727F20")]
			private void KILKBHNKCHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8728BC0", Offset = "0x87271C0", VA = "0x188728BC0", Slot = "8")]
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
		private Vector3 EHBPFGEJFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Quaternion EDAJKKBNMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Coroutine KILGGIHMEHD;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float GAFPAIKDKBH
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xC073D0", Offset = "0xC059D0", VA = "0x180C073D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool AGJJGPBNNHA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6AA4B00", Offset = "0x6AA3100", VA = "0x186AA4B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x872C480", Offset = "0x872AA80", VA = "0x18872C480")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x162CDD0", Offset = "0x162B3D0", VA = "0x18162CDD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x872C5A0", Offset = "0x872ABA0", VA = "0x18872C5A0")]
		public void SetTarget(Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x872BD90", Offset = "0x872A390", VA = "0x18872BD90")]
		[IteratorStateMachine(typeof(BCIEABENFLP))]
		private IEnumerator HNJJFGEKCIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x872C260", Offset = "0x872A860", VA = "0x18872C260")]
		private float OIKABKICKNA(float HBAJHJKADDP, Vector3 PPBKHENKBIP, Vector3 IKENJJBNCLK, float GNEJMIHLKNH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x872C3F0", Offset = "0x872A9F0", VA = "0x18872C3F0")]
		private float OIKABKICKNA(float HBAJHJKADDP, float FBPDEAGABMI, float BCLDLCLIGPM, float GNEJMIHLKNH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x872BCB0", Offset = "0x872A2B0", VA = "0x18872BCB0")]
		private Vector3 AHMGAFLMCIG(Vector3 JEIANMNIGHN, Vector3 EPEMIKPCAHC, Vector3 IGEMMIGMOOK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x872BC80", Offset = "0x872A280", VA = "0x18872BC80")]
		private bool AAKEGIAEGNO(float HFINKANMECH, float EPEMIKPCAHC, float IGEMMIGMOOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x872BEA0", Offset = "0x872A4A0", VA = "0x18872BEA0")]
		private Vector3 IKGLPAHGDGB(Quaternion OOBEGCNALKF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x872BE10", Offset = "0x872A410", VA = "0x18872BE10")]
		private bool HPKAEDFOOCM(Vector3 EPCLGOKLIPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x872BF80", Offset = "0x872A580", VA = "0x18872BF80")]
		private bool LNLLABEEGMD(Quaternion OOBEGCNALKF, bool EADHPDODBIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x872C550", Offset = "0x872AB50", VA = "0x18872C550")]
		private bool PMPLAFFMBCI(Vector3 OBNCJFFHHLB, Vector3 ODHPFGNCGDP, float PCKBJJFCFKB = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x872C4F0", Offset = "0x872AAF0", VA = "0x18872C4F0")]
		private bool PMPLAFFMBCI(Quaternion OBNCJFFHHLB, Quaternion ODHPFGNCGDP, float PCKBJJFCFKB = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x872C7C0", Offset = "0x872ADC0", VA = "0x18872C7C0")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum GIJOMFPGNPH
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
		private const string PHIIBANKJFK = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const string GFCAENOLCKK = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static readonly List<UIAnchorFollower> NOEEPFNHNIJ;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly GCADBNOOJOM OnUIAnchorsUpdated;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static NMAMEBHMFHH HINNPGNKINP;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int MCNKPIHLJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly GCADBNOOJOM OnSyncTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
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
		private PHIGNGELHED MJCIOHJCKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 NMMFOGDCMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Quaternion KFNHMPEPAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Vector3 DEOKBOACFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool NPGIHAFMBOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool NPKPOFMGJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool NDCCFBODDJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Vector3 NJNIKBIFECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly BDMLCHKFOFH EJJDDFFADPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private AMLNEKCGNJH KBJAAJAOODI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Transform KGPIBDKDEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private UIAnchor JPJCBALAIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public bool DoCanvasRenderSync;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static ProfilerMarker FCBBMCOEICK;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool IFDPJCMMMJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x872D720", Offset = "0x872BD20", VA = "0x18872D720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private Transform KOOMPFGMBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1E602C0", Offset = "0x1E5E8C0", VA = "0x181E602C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public UIAnchor FDGKOOBBJBC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCD6750", Offset = "0xCD4D50", VA = "0x180CD6750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private bool HLFHIHCEOBC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x872D100", Offset = "0x872B700", VA = "0x18872D100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x872C9F0", Offset = "0x872AFF0", VA = "0x18872C9F0")]
		[FHOLJFNIKPC]
		internal static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x872D030", Offset = "0x872B630", VA = "0x18872D030")]
		[FELFDMPPKKE(MGEKOJDDIFB.ExitingPlayMode, 0)]
		private static void DMLDIIKDBJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x872DB10", Offset = "0x872C110", VA = "0x18872DB10")]
		public static void SyncAllFollowers(GIJOMFPGNPH INLEBAAACKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x872D6D0", Offset = "0x872BCD0", VA = "0x18872D6D0")]
		private static void JHAHDFAFGOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x872D940", Offset = "0x872BF40", VA = "0x18872D940")]
		private static void PHPHLPJGLPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x872CAC0", Offset = "0x872B0C0", VA = "0x18872CAC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x872D740", Offset = "0x872BD40", VA = "0x18872D740", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x872D620", Offset = "0x872BC20", VA = "0x18872D620")]
		public void Initialize(UIAnchor JPJCBALAIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x872D990", Offset = "0x872BF90", VA = "0x18872D990")]
		public void SetAnchorObjectEnabled(bool BFEIIPBAHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x872D9E0", Offset = "0x872BFE0", VA = "0x18872D9E0")]
		public void SetCanvasRenderingEnabled(bool BFEIIPBAHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x872D220", Offset = "0x872B820", VA = "0x18872D220")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x872CEB0", Offset = "0x872B4B0", VA = "0x18872CEB0")]
		private void DDFDICHPIPA(bool BFEIIPBAHBE, object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x872D130", Offset = "0x872B730", VA = "0x18872D130")]
		private void FPOCMFDAFCO(bool BFEIIPBAHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x872DE70", Offset = "0x872C470", VA = "0x18872DE70")]
		public bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x872DAA0", Offset = "0x872C0A0", VA = "0x18872DAA0")]
		public void SetConstraintEnabled(bool BFEIIPBAHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x872DA30", Offset = "0x872C030", VA = "0x18872DA30")]
		public void SetConstraintAllowed(bool DFOEHBMLPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x872C8B0", Offset = "0x872AEB0", VA = "0x18872C8B0")]
		private bool AKBELCBKMOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x872D410", Offset = "0x872BA10", VA = "0x18872D410")]
		private void GHBBEEIBJJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x872E980", Offset = "0x872CF80", VA = "0x18872E980")]
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
		private sealed class KNFGAAABGLO : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private NFNODNEANBN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
			[DebuggerHidden]
			public KNFGAAABGLO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x872B9B0", Offset = "0x8729FB0", VA = "0x18872B9B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x872BA80", Offset = "0x872A080", VA = "0x18872BA80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private const float PFJALLOGBFI = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool NHBCIJPKBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int CJEBPINIHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private PointerEventData KANNNHFOOFH;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NPNKPOOAOFG<PointerEventData> OKPHFHPKPEN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NPNKPOOAOFG<PointerEventData> BMHLLKENMCI
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NPNKPOOAOFG<PointerEventData> CNFHLLDIALB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public NPNKPOOAOFG<PointerEventData> PLOBANHKMPB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NPNKPOOAOFG<PointerEventData> HIJBACDMCHN
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public NPNKPOOAOFG<PointerEventData> CMCHCGNIOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public NPNKPOOAOFG<PointerEventData> FCEKKPMKMAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8728E30", Offset = "0x8727430", VA = "0x188728E30", Slot = "4")]
		public void OnPointerClick(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8729160", Offset = "0x8727760", VA = "0x188729160", Slot = "5")]
		public void OnPointerUp(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8728E90", Offset = "0x8727490", VA = "0x188728E90", Slot = "6")]
		public void OnPointerDown(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8728DA0", Offset = "0x87273A0", VA = "0x188728DA0")]
		[IteratorStateMachine(typeof(KNFGAAABGLO))]
		private IEnumerator<NFNODNEANBN> KGGBMOHKBBP(int CJEBPINIHNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8729000", Offset = "0x8727600", VA = "0x188729000", Slot = "7")]
		public void OnPointerEnter(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x87290A0", Offset = "0x87276A0", VA = "0x1887290A0", Slot = "8")]
		public void OnPointerExit(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8728C90", Offset = "0x8727290", VA = "0x188728C90")]
		private bool GODMEAAKIPA(GameObject CEKGANCAJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x87291D0", Offset = "0x87277D0", VA = "0x1887291D0")]
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
