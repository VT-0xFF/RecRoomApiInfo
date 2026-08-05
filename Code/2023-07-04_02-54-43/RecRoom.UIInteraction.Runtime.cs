using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IFGOMPHMILG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x70785A0", Offset = "0x7076BA0", VA = "0x1870785A0")]
	public static void CHDNMABACNC(Component AEKHFLGBLPB, bool FGOINGEANAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7078A20", Offset = "0x7077020", VA = "0x187078A20")]
	public static void PHHPLPPLFDH(Text FGJNOCHIDBK, string EGOBKGDOFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7078AB0", Offset = "0x70770B0", VA = "0x187078AB0")]
	public static void PHHPLPPLFDH(TMP_Text FGJNOCHIDBK, string EGOBKGDOFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7078940", Offset = "0x7076F40", VA = "0x187078940")]
	public static void GNDLIDCODHO(Image FBBCMGIOFJP, Sprite DCCBHABPLCA, bool CDAMGKEJGNF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x70788C0", Offset = "0x7076EC0", VA = "0x1870788C0")]
	public static void EPKFFAGOHAP(RawImage FBBCMGIOFJP, Texture2D HJBKIJHPFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7078820", Offset = "0x7076E20", VA = "0x187078820")]
	public static void EFMFBCAKKGM(Graphic NAMAPMPIJLB, Color OOJLGEBJDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7078630", Offset = "0x7076C30", VA = "0x187078630")]
	public static bool DIBHEDAHPCE(GameObject CGLKMGEDNPH)
	{
		return default(bool);
	}
}
namespace TMPro
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class Clickable : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class OIPEEJBHNNA : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private NGCINEPJDAB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
			[DebuggerHidden]
			public OIPEEJBHNNA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7078B40", Offset = "0x7077140", VA = "0x187078B40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7078C30", Offset = "0x7077230", VA = "0x187078C30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float CHHMIBGOGPO = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private bool KCMCDIJJFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int LHBMKEEGMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private PointerEventData DPHCBFAAJPN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NGNHBGJPOEA<PointerEventData> FGPENHBPMOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x86F230", Offset = "0x86D830", VA = "0x18086F230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public NGNHBGJPOEA<PointerEventData> HPKFMGLPCJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NGNHBGJPOEA<PointerEventData> IKJKGEAIKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x944080", Offset = "0x942680", VA = "0x180944080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NGNHBGJPOEA<PointerEventData> DFGLLLLMMPA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x91DC10", Offset = "0x91C210", VA = "0x18091DC10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public NGNHBGJPOEA<PointerEventData> AMLDDLBLJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x944010", Offset = "0x942610", VA = "0x180944010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NGNHBGJPOEA<PointerEventData> BCPMCGJALAM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x94F4E0", Offset = "0x94DAE0", VA = "0x18094F4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NGNHBGJPOEA<PointerEventData> DKGBFKCLKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x923330", Offset = "0x921930", VA = "0x180923330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7076340", Offset = "0x7074940", VA = "0x187076340", Slot = "4")]
		public void OnPointerClick(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7076780", Offset = "0x7074D80", VA = "0x187076780", Slot = "5")]
		public void OnPointerUp(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x70763A0", Offset = "0x70749A0", VA = "0x1870763A0", Slot = "6")]
		public void OnPointerDown(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70762C0", Offset = "0x70748C0", VA = "0x1870762C0")]
		[IteratorStateMachine(typeof(OIPEEJBHNNA))]
		private IEnumerator<NGCINEPJDAB> IJLEDFLMLLB(int LHBMKEEGMKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7076500", Offset = "0x7074B00", VA = "0x187076500", Slot = "7")]
		public void OnPointerEnter(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7076600", Offset = "0x7074C00", VA = "0x187076600", Slot = "8")]
		public void OnPointerExit(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x70761A0", Offset = "0x70747A0", VA = "0x1870761A0")]
		private bool ABJMHEAPBDC(GameObject CGLKMGEDNPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x70767F0", Offset = "0x7074DF0", VA = "0x1870767F0")]
		public Clickable()
		{
		}
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu("Event/Fast Graphic Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class FastGraphicRaycaster : BaseRaycaster
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct MMLBELAHEPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Graphic NMHKJDCJBIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public int DAEBHNGCKGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public Bounds BKMOBLBAEGA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool BIJDEOJLFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		protected Canvas EAHCKIECIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected Camera CDJFLOBPJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private FastGraphicRaycasterGroup CLGJJLNJLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool CKGHNFIEBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private BBDHHODFDMH LKMOIFLDMFP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<Graphic> PKHPICENIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int FPHMDBHPHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<MMLBELAHEPL> OFBLKACBFOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Vector3[] MHGLEOHMPJI;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<MMLBELAHEPL> PKBKIMMGMPF;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NFIPDKEBOIF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7078500", Offset = "0x7076B00", VA = "0x187078500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private bool NCGHFCLDKGD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7077BB0", Offset = "0x70761B0", VA = "0x187077BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override Camera FBIDGAKDKDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x944080", Offset = "0x942680", VA = "0x180944080", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7077AC0", Offset = "0x70760C0", VA = "0x187077AC0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70783E0", Offset = "0x70769E0", VA = "0x1870783E0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7077C70", Offset = "0x7076270", VA = "0x187077C70", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7077CE0", Offset = "0x70762E0", VA = "0x187077CE0", Slot = "17")]
		public override void Raycast(PointerEventData OHLDPOJHAKH, List<RaycastResult> CEONDNJICLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7077660", Offset = "0x7075C60", VA = "0x187077660")]
		protected void GOAOHOKIKDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7076BF0", Offset = "0x70751F0", VA = "0x187076BF0")]
		private void EEEFHKKIKBI(Canvas HEGADEMEIAP, Camera FBIDGAKDKDG, Vector2 JEPODMELPMF, Ray MMLJPMAFKME, List<Graphic> KEMHJBDKFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7077C50", Offset = "0x7076250", VA = "0x187077C50", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x70778D0", Offset = "0x7075ED0", VA = "0x1870778D0")]
		public static Bounds GetBounds(Graphic CEJDMMFKJDI, Vector3[] DIOFDNFFJBJ)
		{
			return default(Bounds);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OKIFHEJKHJK
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7078C70", Offset = "0x7077270", VA = "0x187078C70")]
	public static bool LGBIHEDFEHE(this Transform AIMPELPKDNP, Transform KHJHJOOPMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1BF1710", Offset = "0x1BEFD10", VA = "0x181BF1710")]
	public static T FBLGNDDNFLH<T>(this Component DPNGJGBLPFN, bool NJMPPCOPNAC = false) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CMJHNMPJOFA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Camera EGHHJIKDDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	BOBAGNNLEHP AJJCMEDGLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NGNHBGJPOEA<GameObject> OEAEGBGDCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class FastGraphicRaycasterGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool AGEMAHLPNDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9256C0", Offset = "0x923CC0", VA = "0x1809256C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x996120", Offset = "0x994720", VA = "0x180996120")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class DragScrollDecorator : MonoBehaviour, IScrollHandler, IEventSystemHandler, IDragHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private bool supportsHorizontalScrolling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private bool supportsVerticalScrolling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly NGNHBGJPOEA<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly NGNHBGJPOEA<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool BAKPBKGANFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x944DD0", Offset = "0x9433D0", VA = "0x180944DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OAHAAOBMPIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA85B90", Offset = "0xA84190", VA = "0x180A85B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float NNMPJEBCBLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x945170", Offset = "0x943770", VA = "0x180945170")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public RectTransform ELJACPKKBCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7076A00", Offset = "0x7075000", VA = "0x187076A00", Slot = "5")]
		public void OnDrag(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7076A90", Offset = "0x7075090", VA = "0x187076A90", Slot = "4")]
		public void OnScroll(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x70769B0", Offset = "0x7074FB0", VA = "0x1870769B0")]
		private Vector2 CCIPCCMPCIN(Vector2 BBCGKGLCFFA)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7076B20", Offset = "0x7075120", VA = "0x187076B20")]
		public DragScrollDecorator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[DisallowMultipleComponent]
	public class UIAnchor : UIBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool IOAHPCGBNBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private bool ONJDCDJIBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private bool HANLIBONCCI;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool KDFFLOCAPNC
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x707A250", Offset = "0x7078850", VA = "0x18707A250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x707A100", Offset = "0x7078700", VA = "0x18707A100", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x707A5B0", Offset = "0x7078BB0", VA = "0x18707A5B0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x707A590", Offset = "0x7078B90", VA = "0x18707A590", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x707A4F0", Offset = "0x7078AF0", VA = "0x18707A4F0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x707A5F0", Offset = "0x7078BF0", VA = "0x18707A5F0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x707A4D0", Offset = "0x7078AD0", VA = "0x18707A4D0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x707A6C0", Offset = "0x7078CC0", VA = "0x18707A6C0")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x707A2C0", Offset = "0x70788C0", VA = "0x18707A2C0")]
		private void HLNFHECLNIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x707A3A0", Offset = "0x70789A0", VA = "0x18707A3A0")]
		private void JEILEHOHEOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x707A230", Offset = "0x7078830", VA = "0x18707A230")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x707A750", Offset = "0x7078D50", VA = "0x18707A750")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FMHJBNPFPPB
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const string FHAFLPEPADH = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const string IKFJOBPCPHJ = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const string BDOEBJKIPPI = "\ufffd";
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string PLCEOMNPENC = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string MPEADENGFDJ = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const float HHKBLFFAHBD = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly List<UIAnchorFollower> JONHPNNPMEA;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly BOBAGNNLEHP OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly BOBAGNNLEHP OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static CMJHNMPJOFA OELBKMNODBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private HMOFDMCMMHE IFMMEGDDBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Vector3 DKBHGGILBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Quaternion FOCNAAEFHDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 NJDIGNFBIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private UIAnchor HLCEAPGMFNF;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public UIAnchor JBFAGEDBPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x940DB0", Offset = "0x93F3B0", VA = "0x180940DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool HBONEEIJFFO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB0AE20", Offset = "0xB09420", VA = "0x180B0AE20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7079640", Offset = "0x7077C40", VA = "0x187079640")]
		[EDLDGBIGMCG(LFDHGOCABCF.Unity_AfterSceneLoad)]
		private static void KGHKJOCLFMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7079710", Offset = "0x7077D10", VA = "0x187079710")]
		[BEIEJGBHBAP(HEKNLLBMOLL.ExitingPlayMode, 0)]
		private static void MINGACPCDED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7079A50", Offset = "0x7078050", VA = "0x187079A50")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7079040", Offset = "0x7077640", VA = "0x187079040", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70797E0", Offset = "0x7077DE0", VA = "0x1870797E0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7079600", Offset = "0x7077C00", VA = "0x187079600")]
		public void Initialize(UIAnchor HLCEAPGMFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x70799B0", Offset = "0x7077FB0", VA = "0x1870799B0")]
		public void SetAnchorObjectEnabled(bool OGJCOIOGMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7079A00", Offset = "0x7078000", VA = "0x187079A00")]
		public void SetCanvasRenderingEnabled(bool OGJCOIOGMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7079420", Offset = "0x7077A20", VA = "0x187079420")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7079310", Offset = "0x7077910", VA = "0x187079310")]
		private void EPAIJOPAHPD(bool OGJCOIOGMOG, object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7079290", Offset = "0x7077890", VA = "0x187079290")]
		private void DJHFJPCICHF(bool OGJCOIOGMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7079BC0", Offset = "0x70781C0", VA = "0x187079BC0")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7078E50", Offset = "0x7077450", VA = "0x187078E50")]
		private void ADIOPPKICAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x707A030", Offset = "0x7078630", VA = "0x18707A030")]
		public UIAnchorFollower()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BBDHHODFDMH
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray BFGNJJOELED, out Graphic CEEIEPOBDOD);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable PPPMMLOJFLE);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
