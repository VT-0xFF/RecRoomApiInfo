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
		[Cpp2IlInjected.Address(RVA = "0x77CF020", Offset = "0x77CDA20", VA = "0x1877CF020", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LJOGCDNLFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x77CB200", Offset = "0x77C9C00", VA = "0x1877CB200")]
	public static void FLIDPHBAFBL(Component LHCHHCODKCC, bool EHKJPKOFIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x77CB5A0", Offset = "0x77C9FA0", VA = "0x1877CB5A0")]
	public static void PLIBBJHBMLP(Text ILCAHLJPDBJ, string FBNKCILBNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x77CB620", Offset = "0x77CA020", VA = "0x1877CB620")]
	public static void PLIBBJHBMLP(TMP_Text ILCAHLJPDBJ, string FBNKCILBNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x77CB130", Offset = "0x77C9B30", VA = "0x1877CB130")]
	public static void EHBDJJNABOB(Image AJEDMBCAFJK, Sprite IFHBKNHOMCG, bool IJNDAOPMDFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x77CB520", Offset = "0x77C9F20", VA = "0x1877CB520")]
	public static void PIPLDOAJPJF(RawImage AJEDMBCAFJK, Texture2D AGFHPNOIBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x77CB490", Offset = "0x77C9E90", VA = "0x1877CB490")]
	public static void NFNKHCDJMJH(Graphic KMECCEDLENP, Color GNADFIPFMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x77CB290", Offset = "0x77C9C90", VA = "0x1877CB290")]
	public static bool HAAFOBDOJNE(GameObject NJFNKLJIFDE)
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
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
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
		public readonly ABIBNEMCANM<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly ABIBNEMCANM<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool INFEFLPCDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8B0220", Offset = "0x8AEC20", VA = "0x1808B0220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DDPFECADGHH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xDF4670", Offset = "0xDF3070", VA = "0x180DF4670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float NPFGIEDPACO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xBBD460", Offset = "0xBBBE60", VA = "0x180BBD460")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform KCHNGADGLPP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77C8F10", Offset = "0x77C7910", VA = "0x1877C8F10", Slot = "5")]
		public void OnDrag(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77C8F90", Offset = "0x77C7990", VA = "0x1877C8F90", Slot = "4")]
		public void OnScroll(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77C8EC0", Offset = "0x77C78C0", VA = "0x1877C8EC0")]
		private Vector2 GDANDIHAHNM(Vector2 BLFLEPGMCKH)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77C9010", Offset = "0x77C7A10", VA = "0x1877C9010")]
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
		private struct DAPPIJMJBJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Graphic EALEKJFAOAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int BKCLPGPMHAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Bounds HKADBDECCIH;
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker HGAEBNCIONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly OACBODOIEBE PPNADENEKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool IJMLGDOFCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected Canvas PNGGJDPAOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected Camera EJCGCJONALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private FastGraphicRaycasterGroup AJNJNJAJPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private bool OIJICAOHIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private NKFKHOGCHHE BJHNIPJECHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool? JMOHJLFAHNG;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private List<Graphic> LNIOMJOHPJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int OHCBDMADGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<DAPPIJMJBJA> CJPOBKNCKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Vector3[] IIAJFPLGBLJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private List<DAPPIJMJBJA> AFFIHGFKILG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool PBOFEHPHBGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x77CAD50", Offset = "0x77C9750", VA = "0x1877CAD50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool CIONENBNMDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x77CAE40", Offset = "0x77C9840", VA = "0x1877CAE40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool OEDCEKAOPAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x77C90E0", Offset = "0x77C7AE0", VA = "0x1877C90E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Camera PIKOKPCCPHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8B0160", Offset = "0x8AEB60", VA = "0x1808B0160", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x77C9330", Offset = "0x77C7D30", VA = "0x1877C9330", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x77CABC0", Offset = "0x77C95C0", VA = "0x1877CABC0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77CA0D0", Offset = "0x77C8AD0", VA = "0x1877CA0D0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77CA180", Offset = "0x77C8B80", VA = "0x1877CA180", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x77CAAD0", Offset = "0x77C94D0", VA = "0x1877CAAD0")]
		public void SetDisabledToken(bool PKCLPFEIPFH, LLKIGIOJMJI AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x77CA1F0", Offset = "0x77C8BF0", VA = "0x1877CA1F0", Slot = "17")]
		public override void Raycast(PointerEventData JEAABFEJJGG, List<RaycastResult> FBBICJHHECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x77C9EA0", Offset = "0x77C88A0", VA = "0x1877C9EA0")]
		protected void MHHJNADDDLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x77C93F0", Offset = "0x77C7DF0", VA = "0x1877C93F0")]
		private void KHAFNKOHBFN(Canvas AGDLKDLKDGJ, Camera PIKOKPCCPHF, Vector2 LBLLKMDCPCB, Ray FAHPPGENOMB, List<Graphic> BFGLEBJGKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x77CA0B0", Offset = "0x77C8AB0", VA = "0x1877CA0B0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x77C9170", Offset = "0x77C7B70", VA = "0x1877C9170")]
		public static Bounds GetBounds(Graphic ADJABNNJNMI, Vector3[] JJLNNHDOKKD)
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
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HBBOBABEAJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5ED5CC0", Offset = "0x5ED46C0", VA = "0x185ED5CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RequireComponent(typeof(Canvas))]
	public class FullScreenModalUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public FullScreenModalUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NKFKHOGCHHE
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray FJBPPCGIFLC, [Out] Graphic EGIDCFLKDKG);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable NNGMIOAGCBH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LBCNGAPCIDL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera CLJKGAHOOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	APNHDGDPKOI EIJDILJCDME
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	ABIBNEMCANM<GameObject> CDGHPNECBDL
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
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool IMDCMLODHFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool DLEGBDOGGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool HHPALFDFNKP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool ODDLJIKGNOI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x77CE9E0", Offset = "0x77CD3E0", VA = "0x1877CE9E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x77CE690", Offset = "0x77CD090", VA = "0x1877CE690", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x77CED10", Offset = "0x77CD710", VA = "0x1877CED10", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x77CECF0", Offset = "0x77CD6F0", VA = "0x1877CECF0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x77CEC50", Offset = "0x77CD650", VA = "0x1877CEC50", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x77CEE30", Offset = "0x77CD830", VA = "0x1877CEE30", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x77CEC30", Offset = "0x77CD630", VA = "0x1877CEC30", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x77CEF50", Offset = "0x77CD950", VA = "0x1877CEF50")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x77CED50", Offset = "0x77CD750", VA = "0x1877CED50")]
		public void SetFollowerConstraintEnabled(bool FNEAOIOIFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x77CEA40", Offset = "0x77CD440", VA = "0x1877CEA40")]
		private void GFEBIAHIIOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x77CEB10", Offset = "0x77CD510", VA = "0x1877CEB10")]
		private void NHLACJMPBCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x77CE7F0", Offset = "0x77CD1F0", VA = "0x1877CE7F0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x77CEFD0", Offset = "0x77CD9D0", VA = "0x1877CEFD0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IGINOMAHAPI
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x77CAFF0", Offset = "0x77C99F0", VA = "0x1877CAFF0")]
	public static bool LAAOMEGKNGD(this Transform FHMNKMMPPIB, Transform NNFBEGDDJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2F25AF0", Offset = "0x2F244F0", VA = "0x182F25AF0")]
	public static T NPPBHGBHJBB<T>(this Component PCFKCJNPKCO, bool BAIMMGEKILE = false) where T : class
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
		private sealed class CKOILIFIBOD : IEnumerator<object>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
			[DebuggerHidden]
			public CKOILIFIBOD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x77C8710", Offset = "0x77C7110", VA = "0x1877C8710", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x77C7A60", Offset = "0x77C6460", VA = "0x1877C7A60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x77C7A20", Offset = "0x77C6420", VA = "0x1877C7A20")]
			private void BFPHAGOPJMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x77C86C0", Offset = "0x77C70C0", VA = "0x1877C86C0", Slot = "8")]
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
		private Vector3 FIIGDMBKOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Quaternion MIHHICGJLOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Coroutine PIBKDHNLCIA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float ANJBPJLAKPM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAA7010", Offset = "0xAA5A10", VA = "0x180AA7010")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool AABOBOJNLCM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5E3E5A0", Offset = "0x5E3CFA0", VA = "0x185E3E5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x77CBEE0", Offset = "0x77CA8E0", VA = "0x1877CBEE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x10DE340", Offset = "0x10DCD40", VA = "0x1810DE340")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x77CC030", Offset = "0x77CAA30", VA = "0x1877CC030")]
		public void SetTarget(Vector3 PCPIJKGKPCE, Quaternion MHLCHCEFDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x77CBAD0", Offset = "0x77CA4D0", VA = "0x1877CBAD0")]
		[IteratorStateMachine(typeof(CKOILIFIBOD))]
		private IEnumerator FHIIABPPKMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x77CB830", Offset = "0x77CA230", VA = "0x1877CB830")]
		private float AJDBEBONGDJ(float NLOCKBAMCIB, Vector3 GDMLAPNLEGP, Vector3 HJJBHBAFMCC, float LFBGILOKIBK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x77CB7A0", Offset = "0x77CA1A0", VA = "0x1877CB7A0")]
		private float AJDBEBONGDJ(float NLOCKBAMCIB, float AOHAGFLLAOM, float GIIILJKCBAH, float LFBGILOKIBK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x77CB9C0", Offset = "0x77CA3C0", VA = "0x1877CB9C0")]
		private Vector3 DCKAODJIGEB(Vector3 CPCLNAKNFGM, Vector3 JAFIOEMCCKP, Vector3 GPCBHKJPHLL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x77CBAA0", Offset = "0x77CA4A0", VA = "0x1877CBAA0")]
		private bool DHFDJMNNLLC(float EIJJJCDAOFE, float JAFIOEMCCKP, float GPCBHKJPHLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x77CBF50", Offset = "0x77CA950", VA = "0x1877CBF50")]
		private Vector3 PCGINDEBHLP(Quaternion MHLCHCEFDAI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x77CB710", Offset = "0x77CA110", VA = "0x1877CB710")]
		private bool ABCHFGDHMHG(Vector3 PCPIJKGKPCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x77CBB50", Offset = "0x77CA550", VA = "0x1877CBB50")]
		private bool GOPEPDKICCF(Quaternion MHLCHCEFDAI, bool FNBEGNGBNEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x77CBE30", Offset = "0x77CA830", VA = "0x1877CBE30")]
		private bool HOBLEKEBKIE(Vector3 GPBGMCKGICE, Vector3 PGFJAECCPCN, float NJGADAAHKPA = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x77CBE80", Offset = "0x77CA880", VA = "0x1877CBE80")]
		private bool HOBLEKEBKIE(Quaternion GPBGMCKGICE, Quaternion PGFJAECCPCN, float NJGADAAHKPA = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77CC250", Offset = "0x77CAC50", VA = "0x1877CC250")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum BPPNCEGOIIB
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			UIRaycast,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Render
		}

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static bool UseCanvasVisibilityOptimizations;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string AMGKHJOINFP = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string FMKDDNBJPJA = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float KEAGBNBGGOE = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly List<UIAnchorFollower> ICBLJJDIGDC;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly APNHDGDPKOI OnUIAnchorsUpdated;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static LBCNGAPCIDL LILKPINMJFP;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static int MPBKBDBPOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly APNHDGDPKOI OnSyncTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		[SerializeField]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private UIAnchorFollowConstraint followConstraint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private JKLEGNGEMOG AICHLPLJHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Vector3 HANAAALNFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Quaternion PDOKCDCDJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Vector3 NJCBCCGKCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool OBGDGPGHAEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool EFGLAMEJOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool INCOOJLGCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Vector3 JCGGCNLBEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly LLKIGIOJMJI AICEIDIHFDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private AIIJEJIPADL GDFBFAOBLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Transform NJBDGCMJLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private UIAnchor JMCMFOELIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static ProfilerMarker LGFNDOGNHGL;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool GHJKEEGFKNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x77CD2A0", Offset = "0x77CBCA0", VA = "0x1877CD2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private Transform FOBEMKFOBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x177EE90", Offset = "0x177D890", VA = "0x18177EE90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public UIAnchor PLBBMOMNNHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9FF200", Offset = "0x9FDC00", VA = "0x1809FF200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool KJDBNBKBBKO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x77CD270", Offset = "0x77CBC70", VA = "0x1877CD270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x77CCE40", Offset = "0x77CB840", VA = "0x1877CCE40")]
		[DJHNLGFKBFK]
		internal static void GCHKJEOLKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x77CCB80", Offset = "0x77CB580", VA = "0x1877CCB80")]
		[MDNJIPDCAGH(CHEIGNPGAPJ.ExitingPlayMode, 0)]
		private static void FIHNPKLIHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x77CD660", Offset = "0x77CC060", VA = "0x1877CD660")]
		public static void SyncAllFollowers(BPPNCEGOIIB KMDNOIPDFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x77CCF60", Offset = "0x77CB960", VA = "0x1877CCF60")]
		private static void HCOGOJEPKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x77CCF10", Offset = "0x77CB910", VA = "0x1877CCF10")]
		private static void GHECANEPKKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x77CC480", Offset = "0x77CAE80", VA = "0x1877CC480", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x77CD2C0", Offset = "0x77CBCC0", VA = "0x1877CD2C0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x77CD1C0", Offset = "0x77CBBC0", VA = "0x1877CD1C0")]
		public void Initialize(UIAnchor JMCMFOELIIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x77CD4E0", Offset = "0x77CBEE0", VA = "0x1877CD4E0")]
		public void SetAnchorObjectEnabled(bool FNEAOIOIFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x77CD530", Offset = "0x77CBF30", VA = "0x1877CD530")]
		public void SetCanvasRenderingEnabled(bool FNEAOIOIFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x77CCC50", Offset = "0x77CB650", VA = "0x1877CCC50")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x77CC870", Offset = "0x77CB270", VA = "0x1877CC870")]
		private void CHEICOPNKBF(bool FNEAOIOIFKL, object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x77CCA40", Offset = "0x77CB440", VA = "0x1877CCA40")]
		private void EPFBNPDAJBM(bool FNEAOIOIFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x77CD9B0", Offset = "0x77CC3B0", VA = "0x1877CD9B0")]
		public bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x77CD5F0", Offset = "0x77CBFF0", VA = "0x1877CD5F0")]
		public void SetConstraintEnabled(bool FNEAOIOIFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x77CD580", Offset = "0x77CBF80", VA = "0x1877CD580")]
		public void SetConstraintAllowed(bool MIOFELKFGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x77CC340", Offset = "0x77CAD40", VA = "0x1877CC340")]
		private bool AOCJDGDAKAK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x77CCFB0", Offset = "0x77CB9B0", VA = "0x1877CCFB0")]
		private void HOODCACENFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x77CE500", Offset = "0x77CCF00", VA = "0x1877CE500")]
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
		private sealed class HPABJBFKMGO : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private BGFOJNANPKN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
			[DebuggerHidden]
			public HPABJBFKMGO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x77CAED0", Offset = "0x77C98D0", VA = "0x1877CAED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x77CAFA0", Offset = "0x77C99A0", VA = "0x1877CAFA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private const float FGOPKCGHBEI = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool FPMLFHAADBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int HKIOCDJPHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private PointerEventData CLACJFAIJGP;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ABIBNEMCANM<PointerEventData> CHCDBNGPKJI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ABIBNEMCANM<PointerEventData> LDFNKHAIPOA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ABIBNEMCANM<PointerEventData> LMCOKDLBADC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ABIBNEMCANM<PointerEventData> ENFBCMBMBCA
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8AD960", Offset = "0x8AC360", VA = "0x1808AD960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ABIBNEMCANM<PointerEventData> JMFLGIFMCMO
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8B0160", Offset = "0x8AEB60", VA = "0x1808B0160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ABIBNEMCANM<PointerEventData> MFKGEOFMNHF
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1D0", Offset = "0x8A9BD0", VA = "0x1808AB1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ABIBNEMCANM<PointerEventData> PIHGNMNKIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1B0", Offset = "0x8A9BB0", VA = "0x1808AB1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x77C8930", Offset = "0x77C7330", VA = "0x1877C8930", Slot = "4")]
		public void OnPointerClick(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x77C8C60", Offset = "0x77C7660", VA = "0x1877C8C60", Slot = "5")]
		public void OnPointerUp(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x77C8990", Offset = "0x77C7390", VA = "0x1877C8990", Slot = "6")]
		public void OnPointerDown(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x77C8790", Offset = "0x77C7190", VA = "0x1877C8790")]
		[IteratorStateMachine(typeof(HPABJBFKMGO))]
		private IEnumerator<BGFOJNANPKN> BKIAGHCGDFH(int HKIOCDJPHDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x77C8B00", Offset = "0x77C7500", VA = "0x1877C8B00", Slot = "7")]
		public void OnPointerEnter(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x77C8BA0", Offset = "0x77C75A0", VA = "0x1877C8BA0", Slot = "8")]
		public void OnPointerExit(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x77C8820", Offset = "0x77C7220", VA = "0x1877C8820")]
		private bool DDFDBEHLENJ(GameObject NJFNKLJIFDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x77C8CD0", Offset = "0x77C76D0", VA = "0x1877C8CD0")]
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
