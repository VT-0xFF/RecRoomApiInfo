using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
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
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x754F9E0", Offset = "0x754E3E0", VA = "0x18754F9E0", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ELIEINGHBHD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75497D0", Offset = "0x75481D0", VA = "0x1875497D0")]
	public static void DHCBGIHCGMC(Component PHMJIJLHMJK, bool LICPECIHEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7549930", Offset = "0x7548330", VA = "0x187549930")]
	public static void FHBPCFAPAMH(Text GONNGOAHHAI, string KGHGMFKOBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75499B0", Offset = "0x75483B0", VA = "0x1875499B0")]
	public static void FHBPCFAPAMH(TMP_Text GONNGOAHHAI, string KGHGMFKOBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7549860", Offset = "0x7548260", VA = "0x187549860")]
	public static void ECPPEHAAMLG(Image GEANLIPDBOD, Sprite DCJCDJHGFMA, bool INEBFBGBJGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75496C0", Offset = "0x75480C0", VA = "0x1875496C0")]
	public static void CPKFLHJFGDO(RawImage GEANLIPDBOD, Texture2D GOIIACIDIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7549740", Offset = "0x7548140", VA = "0x187549740")]
	public static void DGEACPDJOCN(Graphic EKCKDPEFNFH, Color BLBBBKOLGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7549A30", Offset = "0x7548430", VA = "0x187549A30")]
	public static bool NAHGBPPFIDA(GameObject EABKFLBGOGN)
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
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
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
		public readonly HLIGJNPKABP<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly HLIGJNPKABP<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DFAGDBHJJMG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x891450", Offset = "0x88FE50", VA = "0x180891450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DHKDJFNEOEE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xC3FF30", Offset = "0xC3E930", VA = "0x180C3FF30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float FDMOCJKEMFO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA183D0", Offset = "0xA16DD0", VA = "0x180A183D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform JBBPADGJPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75494F0", Offset = "0x7547EF0", VA = "0x1875494F0", Slot = "5")]
		public void OnDrag(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7549570", Offset = "0x7547F70", VA = "0x187549570", Slot = "4")]
		public void OnScroll(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75494A0", Offset = "0x7547EA0", VA = "0x1875494A0")]
		private Vector2 IBGHJLCCJPC(Vector2 MCFGLMBFCMC)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75495F0", Offset = "0x7547FF0", VA = "0x1875495F0")]
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
		private struct IOLCBBAJMFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Graphic DHHLKALGEPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public int DHIANOLNFHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Bounds DMHIKCONKOO;
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker DPILEGKHALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool OJMNGKFGHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Canvas IHDMMJPEIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected Camera BGOFAHBHCMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private FastGraphicRaycasterGroup HAFNMOGDMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool GKFHIPDCION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private AMBMILLLKMK KDBPFNMCPJA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<Graphic> GLPICPPAHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int GNBEAPCNCLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private List<IOLCBBAJMFL> PEJMOMPFNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Vector3[] MGGKNPKOFMA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<IOLCBBAJMFL> CEOADACKJMI;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool HNJMHBJKCBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x754B7B0", Offset = "0x754A1B0", VA = "0x18754B7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool NLNCKCNKLBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7549C30", Offset = "0x7548630", VA = "0x187549C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera PCKAIBIGLEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7549E80", Offset = "0x7548880", VA = "0x187549E80", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x754B670", Offset = "0x754A070", VA = "0x18754B670")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x754AC10", Offset = "0x7549610", VA = "0x18754AC10", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x754ACC0", Offset = "0x75496C0", VA = "0x18754ACC0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x754AD30", Offset = "0x7549730", VA = "0x18754AD30", Slot = "17")]
		public override void Raycast(PointerEventData NIMOEMOGMIA, List<RaycastResult> PDCMPPPNCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x754A9E0", Offset = "0x75493E0", VA = "0x18754A9E0")]
		protected void NEHLLBAJECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7549F40", Offset = "0x7548940", VA = "0x187549F40")]
		private void KCNGDHOHEGO(Canvas OONCAELACPP, Camera PCKAIBIGLEE, Vector2 JLPGHJFNAEA, Ray IFPGENMIFCM, List<Graphic> FKDPICIBJEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x754ABF0", Offset = "0x75495F0", VA = "0x18754ABF0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7549CC0", Offset = "0x75486C0", VA = "0x187549CC0")]
		public static Bounds GetBounds(Graphic MCNAAKGDKOD, Vector3[] BFDOLLPFKHP)
		{
			return default(Bounds);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FastGraphicRaycasterGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LKCOBPNALCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5CCF930", Offset = "0x5CCE330", VA = "0x185CCF930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AMBMILLLKMK
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray ICBFAJIAPFF, [Out] Graphic CFNHFHICLBO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable FEJBLCHPIKF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MMEIEJDLKNC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera FPNEHKDMABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PLAJPLAPENK PAHOLOMCCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HLIGJNPKABP<GameObject> FFEPGJIHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[DisallowMultipleComponent]
	public class UIAnchor : UIBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool JOAABNMIAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool LPKABPCHHID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool BFEFKLJJAAM;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool AOMOILCHIHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x754F590", Offset = "0x754DF90", VA = "0x18754F590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x754F050", Offset = "0x754DA50", VA = "0x18754F050", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x754F6D0", Offset = "0x754E0D0", VA = "0x18754F6D0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x754F6B0", Offset = "0x754E0B0", VA = "0x18754F6B0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x754F610", Offset = "0x754E010", VA = "0x18754F610", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x754F7F0", Offset = "0x754E1F0", VA = "0x18754F7F0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x754F5F0", Offset = "0x754DFF0", VA = "0x18754F5F0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x754F910", Offset = "0x754E310", VA = "0x18754F910")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x754F710", Offset = "0x754E110", VA = "0x18754F710")]
		public void SetFollowerConstraintEnabled(bool CEAFCCPFHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x754F4C0", Offset = "0x754DEC0", VA = "0x18754F4C0")]
		private void LLMDNKMPLLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x754F1B0", Offset = "0x754DBB0", VA = "0x18754F1B0")]
		private void CFBNODKPFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x754F2D0", Offset = "0x754DCD0", VA = "0x18754F2D0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x754F990", Offset = "0x754E390", VA = "0x18754F990")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DIEMHGPOEAE
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7549360", Offset = "0x7547D60", VA = "0x187549360")]
	public static bool LOGAMFLLFGO(this Transform FGMPPONDFPE, Transform DLPGBMPJIIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2AFE180", Offset = "0x2AFCB80", VA = "0x182AFE180")]
	public static T OAMLLDMKNDM<T>(this Component IPOCAIFIKHJ, bool HJMPHOKBEGH = false) where T : class
	{
		return null;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class UIAnchorFollowConstraint : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class KPLEKJLLALO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public UIAnchorFollowConstraint <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Vector3 <initialPosition>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private Vector3 <initialRotationEuler>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private bool <doMove>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool <doRotate>5__5;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
			[DebuggerHidden]
			public KPLEKJLLALO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x754C650", Offset = "0x754B050", VA = "0x18754C650", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x754B9A0", Offset = "0x754A3A0", VA = "0x18754B9A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x754B960", Offset = "0x754A360", VA = "0x18754B960")]
			private void GPKDFCKBEHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x754C600", Offset = "0x754B000", VA = "0x18754C600", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[Tooltip("Curve that describes the rate of follow motion at different points in the follow (e.g.- ease in and out when starting or stopping the motion).")]
		private AnimationCurve easingCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Tooltip("How much can the UI anchor move (in meters) before this object starts following it.")]
		private float followPositionThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		[Tooltip("How much can the UI anchor rotate (in degrees) before this object starts following it.")]
		private float followRotationThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[Tooltip("The maximum speed (in meters/second) that the UI anchor follower move when following the anchor.")]
		private float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[Tooltip("The maximum speed (in degrees/second) that the UI anchor follower rotate when following the anchor.")]
		private float rotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("The position delta (in meters) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		[SerializeField]
		private float easingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Tooltip("The rotation delta (in degrees) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		[SerializeField]
		private float rotationEasingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the X-axis.")]
		private bool allowXRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("Whether this object should match any rotation along the Y-axis.")]
		[SerializeField]
		private bool allowYRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the Z-axis.")]
		private bool allowZRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private float maxAllowedVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Vector3 PHMFBMJCFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Quaternion DEEEKODDHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Coroutine MLFAHPOENGK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float MADJFIOALKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x923010", Offset = "0x921A10", VA = "0x180923010")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x754D000", Offset = "0x754BA00", VA = "0x18754D000")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xF20D80", Offset = "0xF1F780", VA = "0x180F20D80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x754D070", Offset = "0x754BA70", VA = "0x18754D070")]
		public void SetTarget(Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x754C740", Offset = "0x754B140", VA = "0x18754C740")]
		[IteratorStateMachine(typeof(KPLEKJLLALO))]
		private IEnumerator AAKKNNJPOCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x754CBC0", Offset = "0x754B5C0", VA = "0x18754CBC0")]
		private float JCKFGHMILNL(float OOPKGFJAIGI, Vector3 GNCKMPPGLAI, Vector3 CNLJGDEEMMC, float NFDIBOJFEDL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x754CD50", Offset = "0x754B750", VA = "0x18754CD50")]
		private float JCKFGHMILNL(float OOPKGFJAIGI, float AOGOJEMNMHJ, float NJCEBOBNMND, float NFDIBOJFEDL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x754CAE0", Offset = "0x754B4E0", VA = "0x18754CAE0")]
		private Vector3 IKIDEHMCELC(Vector3 OLDGJNKOMLJ, Vector3 KJGHHJDIMGP, Vector3 IMGPFEFAFKM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x754CAB0", Offset = "0x754B4B0", VA = "0x18754CAB0")]
		private bool IFFELAKOIPM(float ABEMALIIAAN, float KJGHHJDIMGP, float IMGPFEFAFKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x754CE90", Offset = "0x754B890", VA = "0x18754CE90")]
		private Vector3 LOOEMPFBABP(Quaternion FJFNLINEAKI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x754CF70", Offset = "0x754B970", VA = "0x18754CF70")]
		private bool MEKOBBIBFMA(Vector3 BJDHDJCINFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x754C7C0", Offset = "0x754B1C0", VA = "0x18754C7C0")]
		private bool EFBMMCPIDOG(Quaternion FJFNLINEAKI, bool HKAJBNGEOON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x754CDE0", Offset = "0x754B7E0", VA = "0x18754CDE0")]
		private bool LKPPMMALPKN(Vector3 CGCFANNHAMA, Vector3 GEGAHIEHOAB, float NMBFIFDIGOK = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x754CE30", Offset = "0x754B830", VA = "0x18754CE30")]
		private bool LKPPMMALPKN(Quaternion CGCFANNHAMA, Quaternion GEGAHIEHOAB, float NMBFIFDIGOK = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x754D290", Offset = "0x754BC90", VA = "0x18754D290")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string OKKGMMBEDEM = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string FBJFLGMDMEE = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const float EFKOEBJBHPO = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly List<UIAnchorFollower> BCFBNCMIILJ;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly PLAJPLAPENK OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly PLAJPLAPENK OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static MMEIEJDLKNC KBDGLINKILO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		[SerializeField]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		[SerializeField]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private UIAnchorFollowConstraint followConstraint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private NMGCDKAGAKF ACGAGEILAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 HLEINELJFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Quaternion KLNDFICKLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Vector3 LIKJJCBKBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool KIIPEBAJKBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool KKDGINEGKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool GLOLIKPIAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Vector3 EOJEBIOODOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Transform LGGLBANNEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private UIAnchor HIOHNAICKJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private bool CKAHFBCJEOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x754DF70", Offset = "0x754C970", VA = "0x18754DF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Transform JKDLLOIHFGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x754DD00", Offset = "0x754C700", VA = "0x18754DD00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public UIAnchor JNHNNAMPMGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x92DDE0", Offset = "0x92C7E0", VA = "0x18092DDE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool BCOGBIAPENP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x754D930", Offset = "0x754C330", VA = "0x18754D930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x754E290", Offset = "0x754CC90", VA = "0x18754E290")]
		[NBPHLMAPGPJ]
		internal static void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x754D960", Offset = "0x754C360", VA = "0x18754D960")]
		[ALOHFLAKNNE(OOMJJAJIPFF.ExitingPlayMode, 0)]
		private static void FFLFLLEPLFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x754E4E0", Offset = "0x754CEE0", VA = "0x18754E4E0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x754D380", Offset = "0x754BD80", VA = "0x18754D380", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x754E0D0", Offset = "0x754CAD0", VA = "0x18754E0D0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x754DD50", Offset = "0x754C750", VA = "0x18754DD50")]
		public void Initialize(UIAnchor HIOHNAICKJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x754E360", Offset = "0x754CD60", VA = "0x18754E360")]
		public void SetAnchorObjectEnabled(bool CEAFCCPFHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x754E3B0", Offset = "0x754CDB0", VA = "0x18754E3B0")]
		public void SetCanvasRenderingEnabled(bool CEAFCCPFHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x754DB10", Offset = "0x754C510", VA = "0x18754DB10")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x754DE00", Offset = "0x754C800", VA = "0x18754DE00")]
		private void JBEBAIKJIBO(bool CEAFCCPFHNA, object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x754DA30", Offset = "0x754C430", VA = "0x18754DA30")]
		private void FLHPDIBGAPJ(bool CEAFCCPFHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x754E640", Offset = "0x754D040", VA = "0x18754E640")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x754E470", Offset = "0x754CE70", VA = "0x18754E470")]
		public void SetConstraintEnabled(bool CEAFCCPFHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x754E400", Offset = "0x754CE00", VA = "0x18754E400")]
		public void SetConstraintAllowed(bool GHLFFKLEFPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x754DF90", Offset = "0x754C990", VA = "0x18754DF90")]
		private bool MKDPBHMLLGB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x754D720", Offset = "0x754C120", VA = "0x18754D720")]
		private void CJJMKEKKPNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x754EF10", Offset = "0x754D910", VA = "0x18754EF10")]
		public UIAnchorFollower()
		{
		}
	}
}
namespace TMPro
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class Clickable : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IHLPLIJFPAM : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private IHLHBLBKNMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
			[DebuggerHidden]
			public IHLPLIJFPAM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x754B840", Offset = "0x754A240", VA = "0x18754B840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x754B910", Offset = "0x754A310", VA = "0x18754B910", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float ICBNHDIMJEB = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool AEJDGPBGNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int IGINGAHFAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private PointerEventData MHLFDKJAMBK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public HLIGJNPKABP<PointerEventData> MBNCCGDJCDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public HLIGJNPKABP<PointerEventData> MGJHOMOHCPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public HLIGJNPKABP<PointerEventData> PGPELBCFNMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HLIGJNPKABP<PointerEventData> HLBJKILPKIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8869B0", Offset = "0x8853B0", VA = "0x1808869B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public HLIGJNPKABP<PointerEventData> KHBJNBDNNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x88C8B0", Offset = "0x88B2B0", VA = "0x18088C8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public HLIGJNPKABP<PointerEventData> GLDKJAOGGBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x885FC0", Offset = "0x8849C0", VA = "0x180885FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public HLIGJNPKABP<PointerEventData> AKHJDDACIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x885FD0", Offset = "0x8849D0", VA = "0x180885FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7548DD0", Offset = "0x75477D0", VA = "0x187548DD0", Slot = "4")]
		public void OnPointerClick(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7549100", Offset = "0x7547B00", VA = "0x187549100", Slot = "5")]
		public void OnPointerUp(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7548E30", Offset = "0x7547830", VA = "0x187548E30", Slot = "6")]
		public void OnPointerDown(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7548D40", Offset = "0x7547740", VA = "0x187548D40")]
		[IteratorStateMachine(typeof(IHLPLIJFPAM))]
		private IEnumerator<IHLHBLBKNMF> CLKCEHGCHFN(int IGINGAHFAGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7548FA0", Offset = "0x75479A0", VA = "0x187548FA0", Slot = "7")]
		public void OnPointerEnter(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7549040", Offset = "0x7547A40", VA = "0x187549040", Slot = "8")]
		public void OnPointerExit(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7548C30", Offset = "0x7547630", VA = "0x187548C30")]
		private bool AGMPMHPBGFO(GameObject EABKFLBGOGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7549170", Offset = "0x7547B70", VA = "0x187549170")]
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
