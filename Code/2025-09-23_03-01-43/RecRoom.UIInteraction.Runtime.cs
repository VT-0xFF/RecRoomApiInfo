using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.UI;
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
		[Cpp2IlInjected.Address(RVA = "0x90B4F50", Offset = "0x90B3550", VA = "0x1890B4F50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KFOCMBLMGOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x90B0B10", Offset = "0x90AF110", VA = "0x1890B0B10")]
	public static void GIEMOOCJHIL(Component IDFKPPKNONO, bool KAHLPNCEPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x90B0DA0", Offset = "0x90AF3A0", VA = "0x1890B0DA0")]
	public static void LEBFIFAGOHA(Text OBLACOLBGNN, string MEJLBKIDBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x90B0E20", Offset = "0x90AF420", VA = "0x1890B0E20")]
	public static void LEBFIFAGOHA(TMP_Text OBLACOLBGNN, string MEJLBKIDBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x90B0A40", Offset = "0x90AF040", VA = "0x1890B0A40")]
	public static void EOJDJBFOAHO(Image FHMCLBFBJBJ, Sprite BGDPMEMGGAC, bool HJKBOJMOMNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x90B0EA0", Offset = "0x90AF4A0", VA = "0x1890B0EA0")]
	public static void PFBGNHAFIIO(RawImage FHMCLBFBJBJ, Texture2D BDFJHOHMCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x90B09B0", Offset = "0x90AEFB0", VA = "0x1890B09B0")]
	public static void DNAHJEMINPI(Graphic AAHHHDCLDPL, Color FPHNLEHIJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x90B0BA0", Offset = "0x90AF1A0", VA = "0x1890B0BA0")]
	public static bool HNDJGPLOEKK(GameObject JJEACKINPOJ)
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
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
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
		public readonly PKBDHHCMFJK<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly PKBDHHCMFJK<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool KBIGHFKNPPE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5700", Offset = "0xAA3D00", VA = "0x180AA5700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NGOIACKIHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x15ECAD0", Offset = "0x15EB0D0", VA = "0x1815ECAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float JFHMJOGJMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xC58280", Offset = "0xC56880", VA = "0x180C58280")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform MDNPLPFJFAM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x90ADEE0", Offset = "0x90AC4E0", VA = "0x1890ADEE0", Slot = "5")]
		public void OnDrag(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x90ADF60", Offset = "0x90AC560", VA = "0x1890ADF60", Slot = "4")]
		public void OnScroll(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x90ADE90", Offset = "0x90AC490", VA = "0x1890ADE90")]
		private Vector2 AANKOKNPENK(Vector2 EADGKLNFFKF)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x90ADFE0", Offset = "0x90AC5E0", VA = "0x1890ADFE0")]
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
		private struct CAJGHABFPAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Graphic AHBLKKNEAHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int BJANODOBLMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Bounds PCFMJKHDECG;
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker KMCBHJGEJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly BGICKGNAFMP IJDIEPKONFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool IBJAKAJINAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected Canvas ICFDDOBNBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected Camera DLGNDLLHBIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private FastGraphicRaycasterGroup JEMOHEDIEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private bool OIJPENJFFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ODODLLNDBII IADANJCGAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool? IHNBOKGHGGE;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private List<Graphic> APPBJPKBFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int IODGFDHDOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<CAJGHABFPAF> LANAANDONBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Vector3[] ABDCMOKKEPF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private List<CAJGHABFPAF> EGJGNABHEBH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FLOGPNNGDAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x90B07E0", Offset = "0x90AEDE0", VA = "0x1890B07E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool AKKNHJFCOOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x90B08D0", Offset = "0x90AEED0", VA = "0x1890B08D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool AOGPNONGNLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x90AFB00", Offset = "0x90AE100", VA = "0x1890AFB00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Camera MOLLGGCIBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x90AFA40", Offset = "0x90AE040", VA = "0x1890AFA40", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x90B0650", Offset = "0x90AEC50", VA = "0x1890B0650")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x90AFBB0", Offset = "0x90AE1B0", VA = "0x1890AFBB0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x90AFC60", Offset = "0x90AE260", VA = "0x1890AFC60", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x90B0560", Offset = "0x90AEB60", VA = "0x1890B0560")]
		public void SetDisabledToken(bool KOPHBHGIACG, NBKBJBPEAPN INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x90AFCD0", Offset = "0x90AE2D0", VA = "0x1890AFCD0", Slot = "17")]
		public override void Raycast(PointerEventData CBIMJBOHKKP, List<RaycastResult> NKPJFLOIDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x90AF670", Offset = "0x90ADC70", VA = "0x1890AF670")]
		protected void EJFPPFHDPFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x90AEBC0", Offset = "0x90AD1C0", VA = "0x1890AEBC0")]
		private void DOCCPAJAFAO(Canvas OOOOLEJMLHO, Camera MOLLGGCIBGI, Vector2 JALJNLJLDOO, Ray JHLEHGGOPFA, List<Graphic> NDPLDEAJBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x90AFB90", Offset = "0x90AE190", VA = "0x1890AFB90", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x90AF880", Offset = "0x90ADE80", VA = "0x1890AF880")]
		public static Bounds GetBounds(Graphic HEKJGPKFKAD, Vector3[] HCNOFBNKEFN)
		{
			return default(Bounds);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FastGraphicRaycasterGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool DIBGFNJPLKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x72DF5C0", Offset = "0x72DDBC0", VA = "0x1872DF5C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RequireComponent(typeof(Canvas))]
	public class FullScreenModalUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public FullScreenModalUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ODODLLNDBII
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray GMJMIPAALKC, [Out] Graphic FCCAEBCAEEP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable PICHAOGNHPH);
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class IUIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public abstract bool IAOHCAHHGHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract HLLOFHFLNHG EOJANIPKGMB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract bool SyncTransform();

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		public abstract void SetConstraintEnabled(bool KOPHBHGIACG);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract void SetAnchorObjectEnabled(bool KOPHBHGIACG);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		public abstract void Initialize(UIAnchor CBEKJHOJHDO);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "24")]
		public abstract void ForceSyncScale();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "25")]
		public abstract void SetCanvasRenderingEnabled(bool KOPHBHGIACG);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x90B0960", Offset = "0x90AEF60", VA = "0x1890B0960")]
		protected IUIAnchorFollower()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BBNHJGEFOEF
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Camera PFPDFEJHIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HLLOFHFLNHG CMDNAENKCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	PKBDHHCMFJK<GameObject> CKEBPNLPMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleComponent]
	public class UIAnchor : UIBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Children, false, false, false)]
		private IUIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool KBKCOOIGHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool LNKOEDFGGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool LHDBFFLEDJP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private bool KPBOHMKPEAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x90B4910", Offset = "0x90B2F10", VA = "0x1890B4910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NIEEMMIBPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x90B4EC0", Offset = "0x90B34C0", VA = "0x1890B4EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x90B4780", Offset = "0x90B2D80", VA = "0x1890B4780", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x90B4C00", Offset = "0x90B3200", VA = "0x1890B4C00", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x90B4BE0", Offset = "0x90B31E0", VA = "0x1890B4BE0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x90B4B40", Offset = "0x90B3140", VA = "0x1890B4B40", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x90B4D30", Offset = "0x90B3330", VA = "0x1890B4D30", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x90B4C40", Offset = "0x90B3240", VA = "0x1890B4C40")]
		public void OverrideFollower(IUIAnchorFollower KNIEHBLGOLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x90B4B20", Offset = "0x90B3120", VA = "0x1890B4B20", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x90B4DE0", Offset = "0x90B33E0", VA = "0x1890B4DE0")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x90B4C90", Offset = "0x90B3290", VA = "0x1890B4C90")]
		public void SetFollowerConstraintEnabled(bool KBMMNNBFAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x90B4A70", Offset = "0x90B3070", VA = "0x1890B4A70")]
		private void JIFGBPJEDLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x90B4970", Offset = "0x90B2F70", VA = "0x1890B4970")]
		private void IKAIHKDCHOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x90B48E0", Offset = "0x90B2EE0", VA = "0x1890B48E0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x90B4E70", Offset = "0x90B3470", VA = "0x1890B4E70")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FGOLMJGJOBE
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x90AEA80", Offset = "0x90AD080", VA = "0x1890AEA80")]
	public static bool PBEJHGGLGKM(this Transform PEKDBPKONMC, Transform BEBONNCPGLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DBDFB0", Offset = "0x3DBC5B0", VA = "0x183DBDFB0")]
	public static T OHNFGKJIJMP<T>(this Component AMMKGILEHBG, bool CAGLIHNAINL = false) where T : class
	{
		return null;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class UIAnchorFollowConstraint : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class NHLPIGCBGDJ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public UIAnchorFollowConstraint <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private Vector3 <initialPosition>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private Vector3 <initialRotationEuler>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private bool <doMove>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private bool <doRotate>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public NHLPIGCBGDJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x90B1D30", Offset = "0x90B0330", VA = "0x1890B1D30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x90B1080", Offset = "0x90AF680", VA = "0x1890B1080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x90B1040", Offset = "0x90AF640", VA = "0x1890B1040")]
			private void MPMIGDGBFBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x90B1CE0", Offset = "0x90B02E0", VA = "0x1890B1CE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		[Tooltip("Curve that describes the rate of follow motion at different points in the follow (e.g.- ease in and out when starting or stopping the motion).")]
		private AnimationCurve easingCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[Tooltip("How much can the UI anchor move (in meters) before this object starts following it.")]
		private float followPositionThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[Tooltip("How much can the UI anchor rotate (in degrees) before this object starts following it.")]
		private float followRotationThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[Tooltip("The maximum speed (in meters/second) that the UI anchor follower move when following the anchor.")]
		private float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Tooltip("The maximum speed (in degrees/second) that the UI anchor follower rotate when following the anchor.")]
		private float rotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[Tooltip("The position delta (in meters) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		private float easingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		[Tooltip("The rotation delta (in degrees) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		private float rotationEasingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the X-axis.")]
		private bool allowXRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the Y-axis.")]
		private bool allowYRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the Z-axis.")]
		private bool allowZRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private float maxAllowedVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Vector3 JBLICLEPIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Quaternion AFBGPKKHDJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Coroutine FEMKPJPOHAF;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float IGKNLKBDDDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E80", Offset = "0xAF7480", VA = "0x180AF8E80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FNFHCLPCPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7280F90", Offset = "0x727F590", VA = "0x187280F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x90B26E0", Offset = "0x90B0CE0", VA = "0x1890B26E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x197E270", Offset = "0x197C870", VA = "0x18197E270")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x90B2750", Offset = "0x90B0D50", VA = "0x1890B2750")]
		public void SetTarget(Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x90B1EF0", Offset = "0x90B04F0", VA = "0x1890B1EF0")]
		[IteratorStateMachine(typeof(NHLPIGCBGDJ))]
		private IEnumerator FMCFMOONOND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x90B20E0", Offset = "0x90B06E0", VA = "0x1890B20E0")]
		private float HMJHKAAHCAA(float COHIDKMANHI, Vector3 JOLOOHCKHOK, Vector3 KJEDEIAOBCJ, float MEGNCMNIANH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x90B2050", Offset = "0x90B0650", VA = "0x1890B2050")]
		private float HMJHKAAHCAA(float COHIDKMANHI, float CHGBFOCJAOL, float CIMMNOLCCPL, float MEGNCMNIANH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x90B2320", Offset = "0x90B0920", VA = "0x1890B2320")]
		private Vector3 MOJGCNPIKBL(Vector3 BGDKDMHJNMI, Vector3 LGFPKFJKGLG, Vector3 JPDMHOCEDGB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x90B1EC0", Offset = "0x90B04C0", VA = "0x1890B1EC0")]
		private bool FBABMIEPNFA(float AHHPNEGFFDH, float LGFPKFJKGLG, float JPDMHOCEDGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x90B1F70", Offset = "0x90B0570", VA = "0x1890B1F70")]
		private Vector3 GBNDAFBIHGO(Quaternion LDAEEKEKDJC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x90B1E30", Offset = "0x90B0430", VA = "0x1890B1E30")]
		private bool CMEPDEGFOMO(Vector3 APHHGJIDDCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x90B2400", Offset = "0x90B0A00", VA = "0x1890B2400")]
		private bool OLLKOBCDNMI(Quaternion LDAEEKEKDJC, bool IDAPLBLJDFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x90B2270", Offset = "0x90B0870", VA = "0x1890B2270")]
		private bool MJFDPHCGGIA(Vector3 BNPLNGPMIIG, Vector3 DIIGMDFDOAL, float OPNDIIKICNH = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x90B22C0", Offset = "0x90B08C0", VA = "0x1890B22C0")]
		private bool MJFDPHCGGIA(Quaternion BNPLNGPMIIG, Quaternion DIIGMDFDOAL, float OPNDIIKICNH = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x90B2970", Offset = "0x90B0F70", VA = "0x1890B2970")]
		public UIAnchorFollowConstraint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EPGENBJBICL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum NNFFJMEIPEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		UIRaycast,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		CanvasRender
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly List<IUIAnchorFollower> BIGHEKOFEJC;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly HLLOFHFLNHG GPCALBLFLKE;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static BBNHJGEFOEF FDGELDCEGDC;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int ABJEDOLDBND;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x90AE0B0", Offset = "0x90AC6B0", VA = "0x1890AE0B0")]
	[DIEFPEDLFME]
	internal static void BDBKJLHAGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x90AE470", Offset = "0x90ACA70", VA = "0x1890AE470")]
	[FEIBEOENFMF(CMFDNLPEHHP.ExitingPlayMode, 0)]
	internal static void HBPFENEFPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x90AE220", Offset = "0x90AC820", VA = "0x1890AE220")]
	public static void EDPFHJNLEOD(NNFFJMEIPEI JIFPJFGEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x90AE760", Offset = "0x90ACD60", VA = "0x1890AE760")]
	private static void JICJPNNPAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x90AE1D0", Offset = "0x90AC7D0", VA = "0x1890AE1D0")]
	private static void DOGOHHMHMHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x90AE590", Offset = "0x90ACB90", VA = "0x1890AE590")]
	public static void HCGKMMJAOEA(IUIAnchorFollower BKOOPMIKOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x90AE7B0", Offset = "0x90ACDB0", VA = "0x1890AE7B0")]
	public static void JJLMNHJOKOC(IUIAnchorFollower BKOOPMIKOCD)
	{
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : IUIAnchorFollower
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string IKMLMNHEJDJ = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string BOJINONJOJO = "AnchorObjectDisabled";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private UIAnchorFollowConstraint followConstraint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private PBCNGJENIAB PFMNJIPKMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 FGMHENAMABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Quaternion MLAKIFPODON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Vector3 HPKPEALGOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool JBNBLNBNBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool IAFBCCDFGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool JGGLOMPIFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Vector3 LOIBEMBJEDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly NBKBJBPEAPN INEEADCBMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Transform GKMKOPPOHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private UIAnchor CBEKJHOJHDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static ProfilerMarker GLFIGNJKNGF;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override HLLOFHFLNHG EOJANIPKGMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private bool AIFMFIIJOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x90B3470", Offset = "0x90B1A70", VA = "0x1890B3470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Transform CCHLCEHOKAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x90B3420", Offset = "0x90B1A20", VA = "0x1890B3420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public UIAnchor OFNFFJEHMPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAB0450", Offset = "0xAAEA50", VA = "0x180AB0450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool GHPJDHBOLCO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x90B2B50", Offset = "0x90B1150", VA = "0x1890B2B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool IAOHCAHHGHI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB2DC30", Offset = "0xB2C230", VA = "0x180B2DC30", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xB2DCB0", Offset = "0xB2C2B0", VA = "0x180B2DCB0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x90B2B80", Offset = "0x90B1180", VA = "0x1890B2B80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x90B36A0", Offset = "0x90B1CA0", VA = "0x1890B36A0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x90B3370", Offset = "0x90B1970", VA = "0x1890B3370", Slot = "23")]
		public override void Initialize(UIAnchor CBEKJHOJHDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x90B3A70", Offset = "0x90B2070", VA = "0x1890B3A70", Slot = "22")]
		public override void SetAnchorObjectEnabled(bool KBMMNNBFAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x90B3AC0", Offset = "0x90B20C0", VA = "0x1890B3AC0", Slot = "25")]
		public override void SetCanvasRenderingEnabled(bool KBMMNNBFAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x90B3090", Offset = "0x90B1690", VA = "0x1890B3090", Slot = "24")]
		public override void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x90B38F0", Offset = "0x90B1EF0", VA = "0x1890B38F0")]
		private void PGIEJBIMOAJ(bool KBMMNNBFAAB, object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x90B3280", Offset = "0x90B1880", VA = "0x1890B3280")]
		private void INKCLDBMDLL(bool KBMMNNBFAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x90B3BF0", Offset = "0x90B21F0", VA = "0x1890B3BF0", Slot = "20")]
		public override bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x90B3B80", Offset = "0x90B2180", VA = "0x1890B3B80", Slot = "21")]
		public override void SetConstraintEnabled(bool KBMMNNBFAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x90B3B10", Offset = "0x90B2110", VA = "0x1890B3B10")]
		public void SetConstraintAllowed(bool OPDPBKIJOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x90B2F50", Offset = "0x90B1550", VA = "0x1890B2F50")]
		private bool BGPMMGPKFHC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x90B3490", Offset = "0x90B1A90", VA = "0x1890B3490")]
		private void OJIDHACIKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x90B45D0", Offset = "0x90B2BD0", VA = "0x1890B45D0")]
		public UIAnchorFollower()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class UIAnchorFollowerSimple : IUIAnchorFollower
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool IAOHCAHHGHI
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5700", Offset = "0xAA3D00", VA = "0x180AA5700", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAA54D0", Offset = "0xAA3AD0", VA = "0x180AA54D0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override HLLOFHFLNHG EOJANIPKGMB
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x90B2A70", Offset = "0x90B1070", VA = "0x1890B2A70", Slot = "20")]
		public override bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "21")]
		public override void SetConstraintEnabled(bool KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "22")]
		public override void SetAnchorObjectEnabled(bool KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "23")]
		public override void Initialize(UIAnchor CBEKJHOJHDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "24")]
		public override void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "25")]
		public override void SetCanvasRenderingEnabled(bool KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x90B2AA0", Offset = "0x90B10A0", VA = "0x1890B2AA0")]
		public UIAnchorFollowerSimple()
		{
		}
	}
}
namespace TMPro
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class Clickable : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class LHPAGJNIOEO : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private KAIBAKBEOHB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public LHPAGJNIOEO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x90B0F20", Offset = "0x90AF520", VA = "0x1890B0F20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x90B0FF0", Offset = "0x90AF5F0", VA = "0x1890B0FF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private const float EEFFIAHGAHI = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool NEPPKCFILGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int DMBKONNKFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private PointerEventData KPKJJEDFBIG;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public PKBDHHCMFJK<PointerEventData> OLCCEDALPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public PKBDHHCMFJK<PointerEventData> ODOAGMIEOLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public PKBDHHCMFJK<PointerEventData> MBGFDGDHMHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public PKBDHHCMFJK<PointerEventData> LKBNPJLCKCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public PKBDHHCMFJK<PointerEventData> FMOCMIIHDBD
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public PKBDHHCMFJK<PointerEventData> HGIJHNIDBAO
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public PKBDHHCMFJK<PointerEventData> KDDGJEHGEHB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAA54C0", Offset = "0xAA3AC0", VA = "0x180AA54C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x90AD900", Offset = "0x90ABF00", VA = "0x1890AD900", Slot = "4")]
		public void OnPointerClick(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x90ADC30", Offset = "0x90AC230", VA = "0x1890ADC30", Slot = "5")]
		public void OnPointerUp(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x90AD960", Offset = "0x90ABF60", VA = "0x1890AD960", Slot = "6")]
		public void OnPointerDown(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x90AD760", Offset = "0x90ABD60", VA = "0x1890AD760")]
		[IteratorStateMachine(typeof(LHPAGJNIOEO))]
		private IEnumerator<KAIBAKBEOHB> KLDOPIJHEKE(int DMBKONNKFNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x90ADAD0", Offset = "0x90AC0D0", VA = "0x1890ADAD0", Slot = "7")]
		public void OnPointerEnter(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x90ADB70", Offset = "0x90AC170", VA = "0x1890ADB70", Slot = "8")]
		public void OnPointerExit(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x90AD7F0", Offset = "0x90ABDF0", VA = "0x1890AD7F0")]
		private bool LCKBDPGCIHI(GameObject JJEACKINPOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x90ADCA0", Offset = "0x90AC2A0", VA = "0x1890ADCA0")]
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
