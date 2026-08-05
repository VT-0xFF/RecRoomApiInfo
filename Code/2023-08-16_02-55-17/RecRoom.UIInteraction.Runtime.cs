using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NAICKCPLMPP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D98710", Offset = "0x6D97910", VA = "0x186D98710")]
	public static void CHLIBMAOFCK(Component HPFFEAJFMNI, bool GMKKJGOMPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D988B0", Offset = "0x6D97AB0", VA = "0x186D988B0")]
	public static void GIJNBKIEHJC(Text PDBINFDOFLG, string LOACANDAGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D98820", Offset = "0x6D97A20", VA = "0x186D98820")]
	public static void GIJNBKIEHJC(TMP_Text PDBINFDOFLG, string LOACANDAGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D989E0", Offset = "0x6D97BE0", VA = "0x186D989E0")]
	public static void IECMMHOLEIF(Image LMCLCNLGFDM, Sprite LENPLAKIJHF, bool FOGJIAGMEIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D987A0", Offset = "0x6D979A0", VA = "0x186D987A0")]
	public static void GENODKLEKAC(RawImage LMCLCNLGFDM, Texture2D BNHKLKELIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D98940", Offset = "0x6D97B40", VA = "0x186D98940")]
	public static void HGBOFMPFOBG(Graphic HPLPBKPCGFK, Color GGJPGIMIKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D98AC0", Offset = "0x6D97CC0", VA = "0x186D98AC0")]
	public static bool PFECJOIMBHL(GameObject HAAGKPEGEHP)
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
		private sealed class GPABAFJCHCG : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private MPEFECEHMLJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
			[DebuggerHidden]
			public GPABAFJCHCG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6D98600", Offset = "0x6D97800", VA = "0x186D98600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6D986D0", Offset = "0x6D978D0", VA = "0x186D986D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float HHMDMGKCHDO = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private bool PEOKEELJCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int JCDOFOBJBAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private PointerEventData EKELAHMLEPG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CHBPAJLHAAD<PointerEventData> LKEMCKJJKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CHBPAJLHAAD<PointerEventData> LLMJNPEADLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CHBPAJLHAAD<PointerEventData> AJGMMBNJMDB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public CHBPAJLHAAD<PointerEventData> DECHACFOIPB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8BE190", Offset = "0x8BD390", VA = "0x1808BE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public CHBPAJLHAAD<PointerEventData> PDJBIOHHBIB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public CHBPAJLHAAD<PointerEventData> DAELCGCCFGK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public CHBPAJLHAAD<PointerEventData> LAABADMDMPK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x97BA90", Offset = "0x97AC90", VA = "0x18097BA90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D96250", Offset = "0x6D95450", VA = "0x186D96250", Slot = "4")]
		public void OnPointerClick(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D96690", Offset = "0x6D95890", VA = "0x186D96690", Slot = "5")]
		public void OnPointerUp(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D962B0", Offset = "0x6D954B0", VA = "0x186D962B0", Slot = "6")]
		public void OnPointerDown(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D960B0", Offset = "0x6D952B0", VA = "0x186D960B0")]
		[IteratorStateMachine(typeof(GPABAFJCHCG))]
		private IEnumerator<MPEFECEHMLJ> DOAJDKNEIOF(int JCDOFOBJBAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D96410", Offset = "0x6D95610", VA = "0x186D96410", Slot = "7")]
		public void OnPointerEnter(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D96510", Offset = "0x6D95710", VA = "0x186D96510", Slot = "8")]
		public void OnPointerExit(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D96130", Offset = "0x6D95330", VA = "0x186D96130")]
		private bool HBMDJKLGFHF(GameObject HAAGKPEGEHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D96700", Offset = "0x6D95900", VA = "0x186D96700")]
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
		private struct MILBFIOIHCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Graphic JDMLIEPMLOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public int GAGGAJBAGLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public Bounds IDOBNFEHHNC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool ICMLBDDKIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		protected Canvas AIKGDCEBPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected Camera DACCNIGONJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private FastGraphicRaycasterGroup FAGFHGPLMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool EFPOPENDPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private DNHEKMBPNJH ABBOLJIOKEA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<Graphic> BKFCLAHJGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int GAKLCMMPHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<MILBFIOIHCG> HCKDABIBGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Vector3[] FMFKNMAEOMP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<MILBFIOIHCG> DLPFLNEBEMC;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NGPLCMPIPPC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6D98410", Offset = "0x6D97610", VA = "0x186D98410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private bool AMCLAJCOFOI
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6D96D70", Offset = "0x6D95F70", VA = "0x186D96D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override Camera FGEMIMIBKIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D97A70", Offset = "0x6D96C70", VA = "0x186D97A70", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D982F0", Offset = "0x6D974F0", VA = "0x186D982F0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D97B80", Offset = "0x6D96D80", VA = "0x186D97B80", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D97BF0", Offset = "0x6D96DF0", VA = "0x186D97BF0", Slot = "17")]
		public override void Raycast(PointerEventData BABPGEEPJFH, List<RaycastResult> HBELOJOFICO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6D96B00", Offset = "0x6D95D00", VA = "0x186D96B00")]
		protected void BEJGJDJMHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6D97000", Offset = "0x6D96200", VA = "0x186D97000")]
		private void HIKLJPGBGIK(Canvas BODEMIGIKII, Camera FGEMIMIBKIB, Vector2 BEGAFDBGEDE, Ray NEODNJENDAK, List<Graphic> BCKMMLMPPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D97B60", Offset = "0x6D96D60", VA = "0x186D97B60", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D96E10", Offset = "0x6D96010", VA = "0x186D96E10")]
		public static Bounds GetBounds(Graphic HEMDALANHJP, Vector3[] HHIHJEEKKNH)
		{
			return default(Bounds);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GMLFGOHCKFK
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D984B0", Offset = "0x6D976B0", VA = "0x186D984B0")]
	public static bool EPHANBLDOEF(this Transform PPANDIPJOLP, Transform OJEMCPHOKBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BE50", Offset = "0x1E2B050", VA = "0x181E2BE50")]
	public static T EJPKKMLPGOL<T>(this Component BJPEGONLJEK, bool PBLAGJFIKPG = false) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OOJNDCFDOMN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Camera OKPJNKFOPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	HFMPGNIBJKD JNJNJJEOCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	CHBPAJLHAAD<GameObject> EDDOGKNGPFI
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
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DEKBKAFCAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9B17B0", Offset = "0x9B09B0", VA = "0x1809B17B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
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
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
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
		public readonly CHBPAJLHAAD<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly CHBPAJLHAAD<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool AMPHAKJGLBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x94E3A0", Offset = "0x94D5A0", VA = "0x18094E3A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OIJHADKNFAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD51990", Offset = "0xD50B90", VA = "0x180D51990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float CPFFPKHFBED
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA0D710", Offset = "0xA0C910", VA = "0x180A0D710")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public RectTransform DANICILEFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D96910", Offset = "0x6D95B10", VA = "0x186D96910", Slot = "5")]
		public void OnDrag(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D969A0", Offset = "0x6D95BA0", VA = "0x186D969A0", Slot = "4")]
		public void OnScroll(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D968C0", Offset = "0x6D95AC0", VA = "0x186D968C0")]
		private Vector2 OBNILCCGABC(Vector2 JMPFCEEDONH)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6D96A30", Offset = "0x6D95C30", VA = "0x186D96A30")]
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
		[FLLPKBPMDCP(PFIMANMCDOB.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool EJOMPGOAIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private bool KBHPCDMCNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private bool LODADNOPOPJ;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool NENKFPHCPFF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6D9A350", Offset = "0x6D99550", VA = "0x186D9A350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A120", Offset = "0x6D99320", VA = "0x186D9A120", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A4A0", Offset = "0x6D996A0", VA = "0x186D9A4A0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A480", Offset = "0x6D99680", VA = "0x186D9A480", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A3E0", Offset = "0x6D995E0", VA = "0x186D9A3E0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A4E0", Offset = "0x6D996E0", VA = "0x186D9A4E0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A3C0", Offset = "0x6D995C0", VA = "0x186D9A3C0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A5B0", Offset = "0x6D997B0", VA = "0x186D9A5B0")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A270", Offset = "0x6D99470", VA = "0x186D9A270")]
		private void HIKLLMJIMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D99FF0", Offset = "0x6D991F0", VA = "0x186D99FF0")]
		private void AJNBHBMNJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A250", Offset = "0x6D99450", VA = "0x186D9A250")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A640", Offset = "0x6D99840", VA = "0x186D9A640")]
		public UIAnchor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private const string CBNJFKOFBDP = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private const string LILLJNDLNHH = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const float JHBKOJLMMLM = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly List<UIAnchorFollower> FAHMPCNNFDM;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly HFMPGNIBJKD OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly HFMPGNIBJKD OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static OOJNDCFDOMN FMNKMICAPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private PDJBEHKNNCI DJPOHOAHDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Vector3 CFPNGDHHEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private Quaternion NOLLBBFANGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Vector3 NIPEJCMCNON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private UIAnchor GLLPKEDNKIN;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public UIAnchor JEGKPBHEPEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9CCD40", Offset = "0x9CBF40", VA = "0x1809CCD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool MNMGLCHMPDB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9518B0", Offset = "0x950AB0", VA = "0x1809518B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D99300", Offset = "0x6D98500", VA = "0x186D99300")]
		[MCHKNLLMMBN(LDMPMPAPAMM.Unity_AfterSceneLoad)]
		private static void KCEHONPEIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6D991F0", Offset = "0x6D983F0", VA = "0x186D991F0")]
		[EEIOFBLGGPF(JGEIHADJKJD.ExitingPlayMode, 0)]
		private static void GGOAAOOJIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D99940", Offset = "0x6D98B40", VA = "0x186D99940")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6D98D40", Offset = "0x6D97F40", VA = "0x186D98D40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6D996D0", Offset = "0x6D988D0", VA = "0x186D996D0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6D992C0", Offset = "0x6D984C0", VA = "0x186D992C0")]
		public void Initialize(UIAnchor GLLPKEDNKIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6D998A0", Offset = "0x6D98AA0", VA = "0x186D998A0")]
		public void SetAnchorObjectEnabled(bool EECCCGAOPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6D998F0", Offset = "0x6D98AF0", VA = "0x186D998F0")]
		public void SetCanvasRenderingEnabled(bool EECCCGAOPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6D99010", Offset = "0x6D98210", VA = "0x186D99010")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D995C0", Offset = "0x6D987C0", VA = "0x186D995C0")]
		private void MLFHMLNMFAP(bool EECCCGAOPOH, object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D98F90", Offset = "0x6D98190", VA = "0x186D98F90")]
		private void CDBEMILAKOM(bool EECCCGAOPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D99AB0", Offset = "0x6D98CB0", VA = "0x186D99AB0")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6D993D0", Offset = "0x6D985D0", VA = "0x186D993D0")]
		private void LLBIJKDMHEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6D99F20", Offset = "0x6D99120", VA = "0x186D99F20")]
		public UIAnchorFollower()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DNHEKMBPNJH
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray FCCJKGJFJCE, out Graphic DEANLGMJCAC);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable LNLCAPBHKAL);
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
