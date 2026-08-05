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
public static class AIJDFNFPCNB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EB83C0", Offset = "0x6EB6FC0", VA = "0x186EB83C0")]
	public static void HDGNJMBCLHG(Component DPLEBJGMEDE, bool JACPCCGHLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7F80", Offset = "0x6EB6B80", VA = "0x186EB7F80")]
	public static void BBNLFALDFFB(Text LHPCJIBJOAD, string IFIAJHGJOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8010", Offset = "0x6EB6C10", VA = "0x186EB8010")]
	public static void BBNLFALDFFB(TMP_Text LHPCJIBJOAD, string IFIAJHGJOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8450", Offset = "0x6EB7050", VA = "0x186EB8450")]
	public static void IOPOEPHBJIO(Image FNKHAELEKFN, Sprite POCNICPLMKL, bool DIKEGAGDOKB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EB80A0", Offset = "0x6EB6CA0", VA = "0x186EB80A0")]
	public static void CJIAHHFOKMI(RawImage FNKHAELEKFN, Texture2D KMIIAOHPJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8320", Offset = "0x6EB6F20", VA = "0x186EB8320")]
	public static void EDFAHIHFEHC(Graphic DOHMHIOBNNH, Color OPOEPBAFNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8120", Offset = "0x6EB6D20", VA = "0x186EB8120")]
	public static bool DANJKDOKPLC(GameObject ALBKEDBKENG)
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
		private sealed class MHKLHMDLALL : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private EDDHBDCNFKM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
			[DebuggerHidden]
			public MHKLHMDLALL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6EBA8E0", Offset = "0x6EB94E0", VA = "0x186EBA8E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6EBA9D0", Offset = "0x6EB95D0", VA = "0x186EBA9D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float FJDOKCIODIJ = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private bool HJNMDMOEPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int FEJGFKBKEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private PointerEventData DLOEGELPHFO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public global::NAOGJOJMPFD<PointerEventData> GAIJLBNIDHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7F0240", Offset = "0x7EEE40", VA = "0x1807F0240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public global::NAOGJOJMPFD<PointerEventData> OEKIDGJPGAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public global::NAOGJOJMPFD<PointerEventData> DIGAPKJBLFP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x83EB00", Offset = "0x83D700", VA = "0x18083EB00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public global::NAOGJOJMPFD<PointerEventData> PEAHILMMGKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x83EB10", Offset = "0x83D710", VA = "0x18083EB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public global::NAOGJOJMPFD<PointerEventData> OLAPBNINGMB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x836090", Offset = "0x834C90", VA = "0x180836090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public global::NAOGJOJMPFD<PointerEventData> OHCIMMJIPHB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x84D7F0", Offset = "0x84C3F0", VA = "0x18084D7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public global::NAOGJOJMPFD<PointerEventData> KGHACOJHFOC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x836080", Offset = "0x834C80", VA = "0x180836080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8650", Offset = "0x6EB7250", VA = "0x186EB8650", Slot = "4")]
		public void OnPointerClick(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8A50", Offset = "0x6EB7650", VA = "0x186EB8A50", Slot = "5")]
		public void OnPointerUp(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6EB86B0", Offset = "0x6EB72B0", VA = "0x186EB86B0", Slot = "6")]
		public void OnPointerDown(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8AC0", Offset = "0x6EB76C0", VA = "0x186EB8AC0")]
		[IteratorStateMachine(typeof(MHKLHMDLALL))]
		private IEnumerator<EDDHBDCNFKM> PNFPKFIIMME(int FEJGFKBKEDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8820", Offset = "0x6EB7420", VA = "0x186EB8820", Slot = "7")]
		public void OnPointerEnter(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8900", Offset = "0x6EB7500", VA = "0x186EB8900", Slot = "8")]
		public void OnPointerExit(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8530", Offset = "0x6EB7130", VA = "0x186EB8530")]
		private bool EOIAAHPOKBB(GameObject ALBKEDBKENG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8B40", Offset = "0x6EB7740", VA = "0x186EB8B40")]
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
		private struct CMHLNLBKEKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Graphic EJHADEGAOID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public int GFMNOBGMKJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public Bounds ECJECEIGILP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool DBOIMKLJPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		protected Canvas BKHEEIDHMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected Camera NIADAJAOHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private FastGraphicRaycasterGroup INMMHDFIFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool EBNCEHJBACA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private AOMHBJOLDGL EGPOHGBOJJK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<Graphic> PEJPDLCFGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int CEKBENGAGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<CMHLNLBKEKJ> CJLGIEDOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Vector3[] DFHFFAGGLHM;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<CMHLNLBKEKJ> KIOOIJPKEPA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LOAGHMJEEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6EBA840", Offset = "0x6EB9440", VA = "0x186EBA840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private bool AJKPFCDMHCK
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6EB8F40", Offset = "0x6EB7B40", VA = "0x186EB8F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override Camera FMBBBEJLGEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x83EB00", Offset = "0x83D700", VA = "0x18083EB00", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6EB9ED0", Offset = "0x6EB8AD0", VA = "0x186EB9ED0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EBA720", Offset = "0x6EB9320", VA = "0x186EBA720")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6EB9FE0", Offset = "0x6EB8BE0", VA = "0x186EB9FE0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6EBA050", Offset = "0x6EB8C50", VA = "0x186EBA050", Slot = "17")]
		public override void Raycast(PointerEventData CBLNAPKAJBM, List<RaycastResult> DOFNILAHIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6EB9A90", Offset = "0x6EB8690", VA = "0x186EB9A90")]
		protected void EOIMGGJACFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8FE0", Offset = "0x6EB7BE0", VA = "0x186EB8FE0")]
		private void DLJICHMMDCK(Canvas EBJMCNBHOLI, Camera FMBBBEJLGEK, Vector2 PGFBCJNOGHI, Ray FJKKIBMNBKO, List<Graphic> JCCJEHKCPKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EB9FC0", Offset = "0x6EB8BC0", VA = "0x186EB9FC0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6EB9CE0", Offset = "0x6EB88E0", VA = "0x186EB9CE0")]
		public static Bounds GetBounds(Graphic MEHDIGLPOEJ, Vector3[] BDHKBJBFPKH)
		{
			return default(Bounds);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NMGILPONEED
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAA10", Offset = "0x6EB9610", VA = "0x186EBAA10")]
	public static bool HBINIPNIHFL(this Transform PIKIEEICNEP, Transform ONIJEEBBCHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8EE0", Offset = "0x2CE7AE0", VA = "0x182CE8EE0")]
	public static T NKIMGGOPBMF<T>(this Component CBHLPGJGAKG, bool NIIBMIPCAIP = false) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HCEPILJOFCG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Camera KKHEIGELFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	KBJOPGEOOCH BLDAEOBMONK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	global::NAOGJOJMPFD<GameObject> CNKOKFOCBKG
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
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EBBFILBJDCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x10876B0", Offset = "0x10862B0", VA = "0x1810876B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x892580", Offset = "0x891180", VA = "0x180892580")]
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
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
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
		public readonly global::NAOGJOJMPFD<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly global::NAOGJOJMPFD<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JKJDAEGDAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x852430", Offset = "0x851030", VA = "0x180852430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool MDGDEKKFLBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x852440", Offset = "0x851040", VA = "0x180852440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float JBMKIEJBKKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1505A60", Offset = "0x1504660", VA = "0x181505A60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public RectTransform LEHJMGJCFAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8D50", Offset = "0x6EB7950", VA = "0x186EB8D50", Slot = "5")]
		public void OnDrag(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8DE0", Offset = "0x6EB79E0", VA = "0x186EB8DE0", Slot = "4")]
		public void OnScroll(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8D00", Offset = "0x6EB7900", VA = "0x186EB8D00")]
		private Vector2 IPKLLOIDBIF(Vector2 OGKFIEHIBCK)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8E70", Offset = "0x6EB7A70", VA = "0x186EB8E70")]
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
		[HHGPBADECGL(MGNIEFNKKLA.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool AGMGGCBIGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private bool HLKFIFDJHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private bool OMMPHHJIFJM;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool IEIOABOLNGN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6EBC290", Offset = "0x6EBAE90", VA = "0x186EBC290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6EBBE80", Offset = "0x6EBAA80", VA = "0x186EBBE80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC510", Offset = "0x6EBB110", VA = "0x186EBC510", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC4F0", Offset = "0x6EBB0F0", VA = "0x186EBC4F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC450", Offset = "0x6EBB050", VA = "0x186EBC450", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC550", Offset = "0x6EBB150", VA = "0x186EBC550", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC430", Offset = "0x6EBB030", VA = "0x186EBC430", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC620", Offset = "0x6EBB220", VA = "0x186EBC620")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC1B0", Offset = "0x6EBADB0", VA = "0x186EBC1B0")]
		private void GMNIFGNIIJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC300", Offset = "0x6EBAF00", VA = "0x186EBC300")]
		private void NIBBGFAFEMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6EBBFC0", Offset = "0x6EBABC0", VA = "0x186EBBFC0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC6B0", Offset = "0x6EBB2B0", VA = "0x186EBC6B0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HPEBJKCFFPE
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const string NLAAALOOFDA = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const string IFOOPJBOEMM = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const string CBMOCAKMOJJ = "\ufffd";
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string BLHPCOLPLHH = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string CBGLBJIKPAP = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const float BGFGFDFFPAG = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly List<UIAnchorFollower> FAEHBKPDCLL;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly KBJOPGEOOCH OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly KBJOPGEOOCH OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static HCEPILJOFCG FMBPMOGBLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private FMDOKKBAPOM APONBDABOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Vector3 LCNGJGBHCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Quaternion NIPNKKBGJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 HKHPEFBAFBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private UIAnchor HEMDNNILLIC;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public UIAnchor GDCBGHOMIKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x84D790", Offset = "0x84C390", VA = "0x18084D790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool KJGJKLIECCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x193C2C0", Offset = "0x193AEC0", VA = "0x18193C2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB3C0", Offset = "0x6EB9FC0", VA = "0x186EBB3C0")]
		[GOLHGLLJIPN(OEMLBLOOECK.Unity_AfterSceneLoad)]
		private static void PBAELFIBGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB670", Offset = "0x6EBA270", VA = "0x186EBB670")]
		[AGOCEKPENPF(ANODGEDDMCH.ExitingPlayMode, 0)]
		private static void PLHEOPIGALA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB7E0", Offset = "0x6EBA3E0", VA = "0x186EBB7E0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6EBABF0", Offset = "0x6EB97F0", VA = "0x186EBABF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB1F0", Offset = "0x6EB9DF0", VA = "0x186EBB1F0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB1B0", Offset = "0x6EB9DB0", VA = "0x186EBB1B0")]
		public void Initialize(UIAnchor HEMDNNILLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB740", Offset = "0x6EBA340", VA = "0x186EBB740")]
		public void SetAnchorObjectEnabled(bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB790", Offset = "0x6EBA390", VA = "0x186EBB790")]
		public void SetCanvasRenderingEnabled(bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EBAFD0", Offset = "0x6EB9BD0", VA = "0x186EBAFD0")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6EBAEC0", Offset = "0x6EB9AC0", VA = "0x186EBAEC0")]
		private void EHNAILOEPMD(bool CNIPDMAOMPP, object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EBAE40", Offset = "0x6EB9A40", VA = "0x186EBAE40")]
		private void CLNBEBMBOFI(bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB950", Offset = "0x6EBA550", VA = "0x186EBB950")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB490", Offset = "0x6EBA090", VA = "0x186EBB490")]
		private void PDHHAMCHNCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6EBBDB0", Offset = "0x6EBA9B0", VA = "0x186EBBDB0")]
		public UIAnchorFollower()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AOMHBJOLDGL
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray AHNOMDFCKNJ, out Graphic BJBIJKJJFNM);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable NFIDIENGJCO);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
