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
		[Cpp2IlInjected.Address(RVA = "0x87A7BA0", Offset = "0x87A6DA0", VA = "0x1887A7BA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JMCNJLNBPJP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x87A31B0", Offset = "0x87A23B0", VA = "0x1887A31B0")]
	public static void KAFKOFIHGLA(Component CBNJHLDNKAL, bool GHGDMNBCOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x87A3340", Offset = "0x87A2540", VA = "0x1887A3340")]
	public static void PBCLMGEJFHK(Text NNGGNHFCEGE, string PGAPAABCDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x87A32C0", Offset = "0x87A24C0", VA = "0x1887A32C0")]
	public static void PBCLMGEJFHK(TMP_Text NNGGNHFCEGE, string PGAPAABCDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x87A30E0", Offset = "0x87A22E0", VA = "0x1887A30E0")]
	public static void GIIGDABFEEI(Image PGJEFOFMCAC, Sprite KOKDCBLJHCB, bool JFFDBNEPACH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x87A3240", Offset = "0x87A2440", VA = "0x1887A3240")]
	public static void NJDCHEIFOGH(RawImage PGJEFOFMCAC, Texture2D BEFHHDCIDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x87A2E50", Offset = "0x87A2050", VA = "0x1887A2E50")]
	public static void EJFMGDCDDGO(Graphic GAHMKJLMGEE, Color EKKMKLFENBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x87A2EE0", Offset = "0x87A20E0", VA = "0x1887A2EE0")]
	public static bool GFNCCLEHOAK(GameObject GNOLFLMODHC)
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
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
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
		public readonly NDCOIAMFCNJ<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly NDCOIAMFCNJ<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HEMBJPJEJLL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ELHCBHJMDCL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xF6BC00", Offset = "0xF6AE00", VA = "0x180F6BC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float ICENPDJBFMN
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xC23640", Offset = "0xC22840", VA = "0x180C23640")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform BNBEKNKENIA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87A0D00", Offset = "0x879FF00", VA = "0x1887A0D00", Slot = "5")]
		public void OnDrag(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x87A0D80", Offset = "0x879FF80", VA = "0x1887A0D80", Slot = "4")]
		public void OnScroll(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87A0CB0", Offset = "0x879FEB0", VA = "0x1887A0CB0")]
		private Vector2 HLCJGBFHAPP(Vector2 MDGEGMGLAKJ)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x87A0E00", Offset = "0x87A0000", VA = "0x1887A0E00")]
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
		private struct KEKKHLDBLGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Graphic HIMBMEGDKJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int IJBNGDCDKFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Bounds IJKNBBIEKIH;
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker HCBPGOBGPPP;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static bool DoOptimizedEarlyOutOfRaycast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly NEBOPKIABGF KLMIPGJNLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool ACNLBMJLDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected Canvas ELEAKCAOMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected Camera DEOBIFOAMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FastGraphicRaycasterGroup LIDKHOLBLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool ALNMJJFFDAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EBMOEHDONDJ EFMAHPFBNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool? PPMDIAPPKCG;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<Graphic> CFLOBNMNLBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int APBGBKKCHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<KEKKHLDBLGJ> DBJOKCHEJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Vector3[] IMOGLFCMFKJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<KEKKHLDBLGJ> LDICLGODCJG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DLMFLNHPJHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x87A2BB0", Offset = "0x87A1DB0", VA = "0x1887A2BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool KALIFBJIHMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x87A2CA0", Offset = "0x87A1EA0", VA = "0x1887A2CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool NOEKDBAPPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x87A1E10", Offset = "0x87A1010", VA = "0x1887A1E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Camera NEJKOMHGHED
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x87A1D50", Offset = "0x87A0F50", VA = "0x1887A1D50", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x87A2A20", Offset = "0x87A1C20", VA = "0x1887A2A20")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x87A1EC0", Offset = "0x87A10C0", VA = "0x1887A1EC0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x87A1F70", Offset = "0x87A1170", VA = "0x1887A1F70", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87A2930", Offset = "0x87A1B30", VA = "0x1887A2930")]
		public void SetDisabledToken(bool MLCDCHNOCFI, AAILLPLJANG PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x87A1FE0", Offset = "0x87A11E0", VA = "0x1887A1FE0", Slot = "17")]
		public override void Raycast(PointerEventData ELJMGFIBFCP, List<RaycastResult> LJPBHMPMGAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x87A1980", Offset = "0x87A0B80", VA = "0x1887A1980")]
		protected void FDOPOPAIPBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x87A0ED0", Offset = "0x87A00D0", VA = "0x1887A0ED0")]
		private void BOBCDBIDKKL(Canvas FFDFPHFGIOG, Camera NEJKOMHGHED, Vector2 OKFHDFPFANB, Ray JACKJCAGPFJ, List<Graphic> HEBIEBIPLCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x87A1EA0", Offset = "0x87A10A0", VA = "0x1887A1EA0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87A1B90", Offset = "0x87A0D90", VA = "0x1887A1B90")]
		public static Bounds GetBounds(Graphic CPICBKAHABD, Vector3[] KJOPDAKDNFM)
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
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool BFDEOBNNJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6C04310", Offset = "0x6C03510", VA = "0x186C04310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RequireComponent(typeof(Canvas))]
	public class FullScreenModalUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public FullScreenModalUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EBMOEHDONDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray DKPLIJKCGNF, [Out] Graphic LJNBDJGMPKO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable MOENGLABINI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EDNFCKJMNOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera MDLBLBDCKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JGNOJICCDHE IEGPBDBGAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NDCOIAMFCNJ<GameObject> LHEPAKOGACG
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
		[GABLABEDCEL(HJNEPGJJFOF.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool JOKKPMLBPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool FCPFIPJJOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool CALOLKHHNOJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool IAHPGDBPAKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x87A75F0", Offset = "0x87A67F0", VA = "0x1887A75F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool KAFFBFLNIFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x87A7B10", Offset = "0x87A6D10", VA = "0x1887A7B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x87A7180", Offset = "0x87A6380", VA = "0x1887A7180", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x87A7800", Offset = "0x87A6A00", VA = "0x1887A7800", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x87A77E0", Offset = "0x87A69E0", VA = "0x1887A77E0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x87A7740", Offset = "0x87A6940", VA = "0x1887A7740", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x87A7920", Offset = "0x87A6B20", VA = "0x1887A7920", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x87A7720", Offset = "0x87A6920", VA = "0x1887A7720", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x87A7A40", Offset = "0x87A6C40", VA = "0x1887A7A40")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x87A7840", Offset = "0x87A6A40", VA = "0x1887A7840")]
		public void SetFollowerConstraintEnabled(bool PGGLOGHIPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x87A7650", Offset = "0x87A6850", VA = "0x1887A7650")]
		private void LMAHEDDOPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x87A72E0", Offset = "0x87A64E0", VA = "0x1887A72E0")]
		private void FKPHOIFKPBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x87A7400", Offset = "0x87A6600", VA = "0x1887A7400")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x87A7AC0", Offset = "0x87A6CC0", VA = "0x1887A7AC0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JNPKMMGBBIE
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x87A33C0", Offset = "0x87A25C0", VA = "0x1887A33C0")]
	public static bool NFFPJKCOLEJ(this Transform NCMJKLKGNMA, Transform NJHDJGHEICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x386E3A0", Offset = "0x386D5A0", VA = "0x18386E3A0")]
	public static T BPOOLPDDNDG<T>(this Component PJNHLGGHCLG, bool AHIEFMDCCLG = false) where T : class
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
		private sealed class NEOHDKOICFO : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
			[DebuggerHidden]
			public NEOHDKOICFO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x87A41F0", Offset = "0x87A33F0", VA = "0x1887A41F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x87A3540", Offset = "0x87A2740", VA = "0x1887A3540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x87A3500", Offset = "0x87A2700", VA = "0x1887A3500")]
			private void CKKMGPGLJAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x87A41A0", Offset = "0x87A33A0", VA = "0x1887A41A0", Slot = "8")]
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
		private Vector3 BNLADNJCIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Quaternion BMGOOJLNKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Coroutine GLKBGAGHCHP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float HDPDFFKOOOP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xC07D60", Offset = "0xC06F60", VA = "0x180C07D60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EDEJGEKFGIA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6B057A0", Offset = "0x6B049A0", VA = "0x186B057A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87A4B90", Offset = "0x87A3D90", VA = "0x1887A4B90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1647020", Offset = "0x1646220", VA = "0x181647020")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87A4C00", Offset = "0x87A3E00", VA = "0x1887A4C00")]
		public void SetTarget(Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87A4480", Offset = "0x87A3680", VA = "0x1887A4480")]
		[IteratorStateMachine(typeof(NEOHDKOICFO))]
		private IEnumerator DILFPKHLEKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x87A45B0", Offset = "0x87A37B0", VA = "0x1887A45B0")]
		private float JIEJNIAEJBD(float COGBPEEADFF, Vector3 KJLDHFDFJEA, Vector3 BBMDPPKEFIF, float GJFLNFCKGAL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x87A4740", Offset = "0x87A3940", VA = "0x1887A4740")]
		private float JIEJNIAEJBD(float COGBPEEADFF, float ONKGCPHDDLJ, float OOHFPDDJAHO, float GJFLNFCKGAL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x87A43A0", Offset = "0x87A35A0", VA = "0x1887A43A0")]
		private Vector3 DFNEKDNLKGL(Vector3 PIFBACAKANG, Vector3 MFPGJPKAOFM, Vector3 ACBMNMFGAEN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x87A42E0", Offset = "0x87A34E0", VA = "0x1887A42E0")]
		private bool ACAKNPHKBDL(float BMBDPNPBBFI, float MFPGJPKAOFM, float ACBMNMFGAEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x87A47D0", Offset = "0x87A39D0", VA = "0x1887A47D0")]
		private Vector3 LHBKLOMJPME(Quaternion PANMBKPFLFA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x87A4310", Offset = "0x87A3510", VA = "0x1887A4310")]
		private bool BJHGHCHLOIP(Vector3 BJHAAAPCKLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x87A48B0", Offset = "0x87A3AB0", VA = "0x1887A48B0")]
		private bool OGHLCHONNND(Quaternion PANMBKPFLFA, bool BIPEBEGNGNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x87A4500", Offset = "0x87A3700", VA = "0x1887A4500")]
		private bool GFJOACIAGHA(Vector3 OGNDHFPFEOJ, Vector3 ABBPAGLDFGP, float FKLIDADBAFK = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x87A4550", Offset = "0x87A3750", VA = "0x1887A4550")]
		private bool GFJOACIAGHA(Quaternion OGNDHFPFEOJ, Quaternion ABBPAGLDFGP, float FKLIDADBAFK = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x87A4E20", Offset = "0x87A4020", VA = "0x1887A4E20")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum AFLKCHEKKGI
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
		private const string JPFJNJEOOOJ = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const string EPELDCOLEBB = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static readonly List<UIAnchorFollower> EEKGMHEFEJD;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly JGNOJICCDHE OnUIAnchorsUpdated;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static EDNFCKJMNOJ GMPPJKGMGLE;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int MPMDJHCBECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly JGNOJICCDHE OnSyncTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
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
		private IHHCNLCAMGC DGKGBDGJEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 GPKGFKBMPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Quaternion HPNKCJIILEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Vector3 KCMDJKMDLAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool LMLCMPBPAJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool FPBDOPIDAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool LHCGPCAMNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Vector3 CLBKKCGODON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly AAILLPLJANG PPOILDCNBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private DJKCEHNOJIC PDEEOHOAJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Transform BOIECFFPLJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private UIAnchor JDHDLIJADBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public bool DoCanvasRenderSync;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static ProfilerMarker PPBOHPBDMDG;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool AMBKLKLONKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x87A5440", Offset = "0x87A4640", VA = "0x1887A5440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private Transform PMPOHKBNMIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1E80400", Offset = "0x1E7F600", VA = "0x181E80400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public UIAnchor COCCDOIBFGI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCDF180", Offset = "0xCDE380", VA = "0x180CDF180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private bool NHHHOFMFPBN
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x87A5FC0", Offset = "0x87A51C0", VA = "0x1887A5FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x87A5650", Offset = "0x87A4850", VA = "0x1887A5650")]
		[CBBBKCBCELM]
		internal static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x87A5C00", Offset = "0x87A4E00", VA = "0x1887A5C00")]
		[MPFAIPJMBCK(GGMCIMEHBME.ExitingPlayMode, 0)]
		private static void NHHAABJGCOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x87A6170", Offset = "0x87A5370", VA = "0x1887A6170")]
		public static void SyncAllFollowers(AFLKCHEKKGI OPJOIGJBJKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x87A57D0", Offset = "0x87A49D0", VA = "0x1887A57D0")]
		private static void MEIOBFDAMOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x87A5820", Offset = "0x87A4A20", VA = "0x1887A5820")]
		private static void MHPLJHJHIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x87A5050", Offset = "0x87A4250", VA = "0x1887A5050", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x87A5DC0", Offset = "0x87A4FC0", VA = "0x1887A5DC0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x87A5720", Offset = "0x87A4920", VA = "0x1887A5720")]
		public void Initialize(UIAnchor JDHDLIJADBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x87A5FF0", Offset = "0x87A51F0", VA = "0x1887A5FF0")]
		public void SetAnchorObjectEnabled(bool PGGLOGHIPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x87A6040", Offset = "0x87A5240", VA = "0x1887A6040")]
		public void SetCanvasRenderingEnabled(bool PGGLOGHIPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x87A5460", Offset = "0x87A4660", VA = "0x1887A5460")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x87A5870", Offset = "0x87A4A70", VA = "0x1887A5870")]
		private void MJGNBDDFJJC(bool PGGLOGHIPPK, object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x87A5CD0", Offset = "0x87A4ED0", VA = "0x1887A5CD0")]
		private void OBNPJNBBHNO(bool PGGLOGHIPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x87A64D0", Offset = "0x87A56D0", VA = "0x1887A64D0")]
		public bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x87A6100", Offset = "0x87A5300", VA = "0x1887A6100")]
		public void SetConstraintEnabled(bool PGGLOGHIPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x87A6090", Offset = "0x87A5290", VA = "0x1887A6090")]
		public void SetConstraintAllowed(bool DCCJJEHMIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x87A4F10", Offset = "0x87A4110", VA = "0x1887A4F10")]
		private bool AHFKFPBLHFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x87A59F0", Offset = "0x87A4BF0", VA = "0x1887A59F0")]
		private void MKJJLJLBOOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x87A6FE0", Offset = "0x87A61E0", VA = "0x1887A6FE0")]
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
		private sealed class GDHHIJGOPPD : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private EAALCCOKLJL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
			[DebuggerHidden]
			public GDHHIJGOPPD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x87A2D30", Offset = "0x87A1F30", VA = "0x1887A2D30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x87A2E00", Offset = "0x87A2000", VA = "0x1887A2E00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private const float GPDMJEGLLKL = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool DOPJAMAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int IFHAMGIGELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private PointerEventData IBFEOEJMAFL;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NDCOIAMFCNJ<PointerEventData> JKAMHLDOGAG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NDCOIAMFCNJ<PointerEventData> DGHJFMAGJBB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NDCOIAMFCNJ<PointerEventData> BOGFLNIKIDD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public NDCOIAMFCNJ<PointerEventData> NGFDCFAILBL
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NDCOIAMFCNJ<PointerEventData> FDNEGGKEHCP
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public NDCOIAMFCNJ<PointerEventData> OCBFIBBHFJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public NDCOIAMFCNJ<PointerEventData> FIFKFCPDNKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x87A0720", Offset = "0x879F920", VA = "0x1887A0720", Slot = "4")]
		public void OnPointerClick(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x87A0A50", Offset = "0x879FC50", VA = "0x1887A0A50", Slot = "5")]
		public void OnPointerUp(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x87A0780", Offset = "0x879F980", VA = "0x1887A0780", Slot = "6")]
		public void OnPointerDown(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x87A0580", Offset = "0x879F780", VA = "0x1887A0580")]
		[IteratorStateMachine(typeof(GDHHIJGOPPD))]
		private IEnumerator<EAALCCOKLJL> BGLLHHGDKDB(int IFHAMGIGELA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x87A08F0", Offset = "0x879FAF0", VA = "0x1887A08F0", Slot = "7")]
		public void OnPointerEnter(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x87A0990", Offset = "0x879FB90", VA = "0x1887A0990", Slot = "8")]
		public void OnPointerExit(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x87A0610", Offset = "0x879F810", VA = "0x1887A0610")]
		private bool OBNCPAFHGCD(GameObject GNOLFLMODHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x87A0AC0", Offset = "0x879FCC0", VA = "0x1887A0AC0")]
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
