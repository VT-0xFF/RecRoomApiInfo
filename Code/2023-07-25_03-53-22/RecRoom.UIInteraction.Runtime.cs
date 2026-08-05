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
public static class LAJJAPFFEBC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7110B10", Offset = "0x710FB10", VA = "0x187110B10")]
	public static void FAKPJJFLDLK(Component GDOIACLJEDE, bool MHCBMAAPDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7110BA0", Offset = "0x710FBA0", VA = "0x187110BA0")]
	public static void PAGMFNKMDPA(Text NACGBEHOLKJ, string FNFHAMDAPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7110C30", Offset = "0x710FC30", VA = "0x187110C30")]
	public static void PAGMFNKMDPA(TMP_Text NACGBEHOLKJ, string FNFHAMDAPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7110A30", Offset = "0x710FA30", VA = "0x187110A30")]
	public static void DPFLLIMMCJK(Image MMKDNOAGALF, Sprite PMBILBGCDCB, bool JKLAOOADBPG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7110CC0", Offset = "0x710FCC0", VA = "0x187110CC0")]
	public static void PJKLLLMFFJA(RawImage MMKDNOAGALF, Texture2D HCCFKEMJLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7110990", Offset = "0x710F990", VA = "0x187110990")]
	public static void ADFNAHGOIDI(Graphic CLCNCJCLEOG, Color IFAEOGGHLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7110D40", Offset = "0x710FD40", VA = "0x187110D40")]
	public static bool PJLGHLEJCEE(GameObject LAPEIFCGFLM)
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
		private sealed class KHHFPKEKAOK : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private OJAHJFHMFIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
			[DebuggerHidden]
			public KHHFPKEKAOK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7110710", Offset = "0x710F710", VA = "0x187110710", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7110800", Offset = "0x710F800", VA = "0x187110800", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float OFECKDNINMF = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private bool PDDKAJBGIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int BBCJMMAAELO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private PointerEventData MEMFMHLNCFE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public EAFMEKAHDGH<PointerEventData> LOKMJPFMGHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EAFMEKAHDGH<PointerEventData> AAPNOBKBAHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EAFMEKAHDGH<PointerEventData> MNBCEHABJEA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x871190", Offset = "0x870190", VA = "0x180871190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public EAFMEKAHDGH<PointerEventData> ADIDNCPNGIC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x914C50", Offset = "0x913C50", VA = "0x180914C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public EAFMEKAHDGH<PointerEventData> KAEDDLIANNH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x97E5E0", Offset = "0x97D5E0", VA = "0x18097E5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public EAFMEKAHDGH<PointerEventData> PLKDKMEBJEM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x97E580", Offset = "0x97D580", VA = "0x18097E580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public EAFMEKAHDGH<PointerEventData> KNDPHBFAJIB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x97E720", Offset = "0x97D720", VA = "0x18097E720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x710E4B0", Offset = "0x710D4B0", VA = "0x18710E4B0", Slot = "4")]
		public void OnPointerClick(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x710E8F0", Offset = "0x710D8F0", VA = "0x18710E8F0", Slot = "5")]
		public void OnPointerUp(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x710E510", Offset = "0x710D510", VA = "0x18710E510", Slot = "6")]
		public void OnPointerDown(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x710E310", Offset = "0x710D310", VA = "0x18710E310")]
		[IteratorStateMachine(typeof(KHHFPKEKAOK))]
		private IEnumerator<OJAHJFHMFIA> ANNGKGACJHC(int BBCJMMAAELO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x710E670", Offset = "0x710D670", VA = "0x18710E670", Slot = "7")]
		public void OnPointerEnter(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x710E770", Offset = "0x710D770", VA = "0x18710E770", Slot = "8")]
		public void OnPointerExit(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x710E390", Offset = "0x710D390", VA = "0x18710E390")]
		private bool GMPDBKOEKKG(GameObject LAPEIFCGFLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x710E960", Offset = "0x710D960", VA = "0x18710E960")]
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
		private struct PLHCCADILDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Graphic IGGMCFMDADK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public int AJNPMGFOAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public Bounds MFIMHAIPFHC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool NFNKMFCALJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		protected Canvas LDDABJKFILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected Camera POBOHLECFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private FastGraphicRaycasterGroup DNFKJEMPHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool BCIFAACHGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private JGCKAHOODEO AIFGIFANKDH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<Graphic> BCLAKHLGFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int JIGCNCIPJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<PLHCCADILDD> MBIMCMONMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Vector3[] DMPAPGPKABK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<PLHCCADILDD> FEDCBOPDGMM;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IFAIPGHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7110670", Offset = "0x710F670", VA = "0x187110670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private bool HGECOPKDNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x710ED60", Offset = "0x710DD60", VA = "0x18710ED60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override Camera AEIDCNDLMJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x871190", Offset = "0x870190", VA = "0x180871190", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x710EFF0", Offset = "0x710DFF0", VA = "0x18710EFF0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7110550", Offset = "0x710F550", VA = "0x187110550")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x710FB70", Offset = "0x710EB70", VA = "0x18710FB70", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x710FE50", Offset = "0x710EE50", VA = "0x18710FE50", Slot = "17")]
		public override void Raycast(PointerEventData NKPHHCMFEAM, List<RaycastResult> GKPOOEOCECP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x710FBE0", Offset = "0x710EBE0", VA = "0x18710FBE0")]
		protected void PHBEKLBDPLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x710F0E0", Offset = "0x710E0E0", VA = "0x18710F0E0")]
		private void ODBDJACGIND(Canvas GEEKKBCOFDA, Camera AEIDCNDLMJA, Vector2 ABODLGEAHHJ, Ray DLCONAFGHCG, List<Graphic> DIPMGIHIBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x710FB50", Offset = "0x710EB50", VA = "0x18710FB50", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x710EE00", Offset = "0x710DE00", VA = "0x18710EE00")]
		public static Bounds GetBounds(Graphic CIJNNIEBNOP, Vector3[] NCMFCAHDLPN)
		{
			return default(Bounds);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KHLNNGPIBFF
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7110840", Offset = "0x710F840", VA = "0x187110840")]
	public static bool MFCADKGKKJB(this Transform IGJGLIJGINK, Transform DJAGPEDCGHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2123DF0", Offset = "0x2122DF0", VA = "0x182123DF0")]
	public static T KIIOMPFNOGG<T>(this Component FBOMMBLFPCD, bool OGBHNDALLII = false) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GCPOBMMHLGP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Camera MAPGGEKJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	NHBIDAMCDOH EONFAONEFBE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	EAFMEKAHDGH<GameObject> PAEIIJPLGMD
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DFBOGFJEIOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x991F70", Offset = "0x990F70", VA = "0x180991F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
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
		public readonly EAFMEKAHDGH<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly EAFMEKAHDGH<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool BLBCNOPCILB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB87BE0", Offset = "0xB86BE0", VA = "0x180B87BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool ONKPFLKHEBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x14E2BB0", Offset = "0x14E1BB0", VA = "0x1814E2BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float AGFLFACILJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xC92CC0", Offset = "0xC91CC0", VA = "0x180C92CC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public RectTransform JIJOALFEMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x710EB70", Offset = "0x710DB70", VA = "0x18710EB70", Slot = "5")]
		public void OnDrag(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x710EC00", Offset = "0x710DC00", VA = "0x18710EC00", Slot = "4")]
		public void OnScroll(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x710EB20", Offset = "0x710DB20", VA = "0x18710EB20")]
		private Vector2 GJEOODLABLE(Vector2 FEFAFLDDEJN)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x710EC90", Offset = "0x710DC90", VA = "0x18710EC90")]
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool DPJOJMIJFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private bool LJNEIHOEIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private bool EMOMNKIGJIP;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool PKLEJGFHILM
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x71123A0", Offset = "0x71113A0", VA = "0x1871123A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7112270", Offset = "0x7111270", VA = "0x187112270", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x71125F0", Offset = "0x71115F0", VA = "0x1871125F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x71125D0", Offset = "0x71115D0", VA = "0x1871125D0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7112530", Offset = "0x7111530", VA = "0x187112530", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7112760", Offset = "0x7111760", VA = "0x187112760", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7112510", Offset = "0x7111510", VA = "0x187112510", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7112830", Offset = "0x7111830", VA = "0x187112830")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7112410", Offset = "0x7111410", VA = "0x187112410")]
		private void ENFLBLLOBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7112630", Offset = "0x7111630", VA = "0x187112630")]
		private void PNJLFNFLJCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x71124F0", Offset = "0x71114F0", VA = "0x1871124F0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x71128C0", Offset = "0x71118C0", VA = "0x1871128C0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BLHPBKJBDBN
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const string EGFPHAFCEAP = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const string AIACMKEHBOG = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const string BDLDGLDKHDC = "\ufffd";
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string EKJOJEHHAKA = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string DHHIKKNJKNN = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const float NANKDPLIDNM = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly List<UIAnchorFollower> DEBHLJDGDAE;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly NHBIDAMCDOH OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly NHBIDAMCDOH OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static GCPOBMMHLGP OIDBKKMNCPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private FPCHIOCGOJB PDNILCDEBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Vector3 MCMIGAIEJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Quaternion AMFCPNKMOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 NEIBGLOCNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private UIAnchor GHHLEHBFEHI;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public UIAnchor CDFKDJGFCMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9AD4B0", Offset = "0x9AC4B0", VA = "0x1809AD4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool KHFJIKCOKNO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xDD3CF0", Offset = "0xDD2CF0", VA = "0x180DD3CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x71117B0", Offset = "0x71107B0", VA = "0x1871117B0")]
		[PLPLFBFMOJO(DLAFBHIONID.Unity_AfterSceneLoad)]
		private static void LLEBBJIFEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7111880", Offset = "0x7110880", VA = "0x187111880")]
		[JOOLBCFGFFN(LLJHODDJBDJ.ExitingPlayMode, 0)]
		private static void MHFMLBMOKKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7111BC0", Offset = "0x7110BC0", VA = "0x187111BC0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7110FC0", Offset = "0x710FFC0", VA = "0x187110FC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7111950", Offset = "0x7110950", VA = "0x187111950", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7111770", Offset = "0x7110770", VA = "0x187111770")]
		public void Initialize(UIAnchor GHHLEHBFEHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7111B20", Offset = "0x7110B20", VA = "0x187111B20")]
		public void SetAnchorObjectEnabled(bool DDHDBPLDGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7111B70", Offset = "0x7110B70", VA = "0x187111B70")]
		public void SetCanvasRenderingEnabled(bool DDHDBPLDGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7111590", Offset = "0x7110590", VA = "0x187111590")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7111290", Offset = "0x7110290", VA = "0x187111290")]
		private void FDKHNIAIJAP(bool DDHDBPLDGLB, object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7111210", Offset = "0x7110210", VA = "0x187111210")]
		private void DJNELHDPOFJ(bool DDHDBPLDGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7111D30", Offset = "0x7110D30", VA = "0x187111D30")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x71113A0", Offset = "0x71103A0", VA = "0x1871113A0")]
		private void FMBGFDKFFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x71121A0", Offset = "0x71111A0", VA = "0x1871121A0")]
		public UIAnchorFollower()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JGCKAHOODEO
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray JHAKHIHMLOK, out Graphic KIOBFIDCDML);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable PNEMHBEDCAK);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
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
