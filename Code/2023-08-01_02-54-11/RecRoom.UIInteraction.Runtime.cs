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
public static class OMBCNFMOMBG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x70CA580", Offset = "0x70C9580", VA = "0x1870CA580")]
	public static void AHCOOLAFPLA(Component LMOLNJNIDGC, bool LEOEHJANNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x70CAA10", Offset = "0x70C9A10", VA = "0x1870CAA10")]
	public static void ILHHDBAPLDH(Text NDIGKIFDIMJ, string MHFKHBKFLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x70CA980", Offset = "0x70C9980", VA = "0x1870CA980")]
	public static void ILHHDBAPLDH(TMP_Text NDIGKIFDIMJ, string MHFKHBKFLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x70CA8A0", Offset = "0x70C98A0", VA = "0x1870CA8A0")]
	public static void COKFLJHIIOI(Image OBACHEAFMMB, Sprite KHDIDNLEFOP, bool BGLLLIHGMJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x70CAAA0", Offset = "0x70C9AA0", VA = "0x1870CAAA0")]
	public static void NODJFAKABBO(RawImage OBACHEAFMMB, Texture2D FFACFPCPDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x70CA610", Offset = "0x70C9610", VA = "0x1870CA610")]
	public static void BIIBIJFNNCH(Graphic IDNBECJCFCB, Color OAIMCLIJEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x70CA6B0", Offset = "0x70C96B0", VA = "0x1870CA6B0")]
	public static bool CNAHGCPLKHD(GameObject IHNGPGNCBCG)
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
		private sealed class PCJGACNOONI : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private KNGCLBDEHMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
			[DebuggerHidden]
			public PCJGACNOONI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x70CAB20", Offset = "0x70C9B20", VA = "0x1870CAB20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x70CAC10", Offset = "0x70C9C10", VA = "0x1870CAC10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float JGIJBPGHNCB = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private bool ABBFJMEGNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int KJEKGCHHBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private PointerEventData EPDMDIBBHLN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public OIDLICKKMBF<PointerEventData> DLFFBFILJCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x91FD50", Offset = "0x91ED50", VA = "0x18091FD50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OIDLICKKMBF<PointerEventData> BGNMGJFGLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public OIDLICKKMBF<PointerEventData> OGNHJOIDDGA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x944E10", Offset = "0x943E10", VA = "0x180944E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public OIDLICKKMBF<PointerEventData> NLDCDLMGBIP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x944E20", Offset = "0x943E20", VA = "0x180944E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public OIDLICKKMBF<PointerEventData> CEOENLLLCCE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x94B760", Offset = "0x94A760", VA = "0x18094B760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OIDLICKKMBF<PointerEventData> KGKFONOEGLF
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x947AC0", Offset = "0x946AC0", VA = "0x180947AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OIDLICKKMBF<PointerEventData> EKDMDDHECJG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x92FA50", Offset = "0x92EA50", VA = "0x18092FA50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x70C8320", Offset = "0x70C7320", VA = "0x1870C8320", Slot = "4")]
		public void OnPointerClick(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x70C8760", Offset = "0x70C7760", VA = "0x1870C8760", Slot = "5")]
		public void OnPointerUp(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x70C8380", Offset = "0x70C7380", VA = "0x1870C8380", Slot = "6")]
		public void OnPointerDown(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70C8180", Offset = "0x70C7180", VA = "0x1870C8180")]
		[IteratorStateMachine(typeof(PCJGACNOONI))]
		private IEnumerator<KNGCLBDEHMD> FDBMJKMCADI(int KJEKGCHHBMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x70C84E0", Offset = "0x70C74E0", VA = "0x1870C84E0", Slot = "7")]
		public void OnPointerEnter(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x70C85E0", Offset = "0x70C75E0", VA = "0x1870C85E0", Slot = "8")]
		public void OnPointerExit(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x70C8200", Offset = "0x70C7200", VA = "0x1870C8200")]
		private bool GNFGIAJNJII(GameObject IHNGPGNCBCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x70C87D0", Offset = "0x70C77D0", VA = "0x1870C87D0")]
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
		private struct IGNFILINOHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Graphic KAOFHCDJOAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public int PKLNJIOLPCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public Bounds MPOOHAFAONI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool PKIDMMFINGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		protected Canvas PCINIDBMANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected Camera PBGOFMIPOGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private FastGraphicRaycasterGroup BMMKMJFIEIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool GAMIFCPGHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private JOMGLEBCFMP DMDFPMOGLKF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<Graphic> CJEBPOBDLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int FIIADDKHMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<IGNFILINOHC> MCHCCEOGLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Vector3[] BMFIBPPIDPA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<IGNFILINOHC> FIBGBGCLLMJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FHPLIFDEAHL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x70CA4E0", Offset = "0x70C94E0", VA = "0x1870CA4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private bool ACFLKDMJNMK
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x70C8E40", Offset = "0x70C7E40", VA = "0x1870C8E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override Camera GNOAIFJMIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x944E10", Offset = "0x943E10", VA = "0x180944E10", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x70C90D0", Offset = "0x70C80D0", VA = "0x1870C90D0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70CA3C0", Offset = "0x70C93C0", VA = "0x1870CA3C0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x70C9C50", Offset = "0x70C8C50", VA = "0x1870C9C50", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x70C9CC0", Offset = "0x70C8CC0", VA = "0x1870C9CC0", Slot = "17")]
		public override void Raycast(PointerEventData MLPMPPLPMHH, List<RaycastResult> FECNLAHOKGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x70C8BD0", Offset = "0x70C7BD0", VA = "0x1870C8BD0")]
		protected void BNNNDDNOEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x70C91C0", Offset = "0x70C81C0", VA = "0x1870C91C0")]
		private void NOLNHFIDPAC(Canvas HMOLGENAMNG, Camera GNOAIFJMIFC, Vector2 BLCCHMNLEOF, Ray FFHHDHDGFEJ, List<Graphic> AHAIBOJDPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x70C9C30", Offset = "0x70C8C30", VA = "0x1870C9C30", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x70C8EE0", Offset = "0x70C7EE0", VA = "0x1870C8EE0")]
		public static Bounds GetBounds(Graphic KNJLDAHCICP, Vector3[] BKBGBMPDFPI)
		{
			return default(Bounds);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ADNNALLBMPO
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x70C8030", Offset = "0x70C7030", VA = "0x1870C8030")]
	public static bool NOPLNMDFKFH(this Transform CJCAJMJJJKE, Transform AGFCJPGACCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A21720", Offset = "0x2A20720", VA = "0x182A21720")]
	public static T FNFGHFHHKHK<T>(this Component EEMPMGBFHEC, bool MCLPENLANDF = false) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HPPJLELMILL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Camera DLFDMDMLEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	MONMJFCKPLO AAIKNGNFACH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	OIDLICKKMBF<GameObject> LHMPIKGODMI
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EKIGGAAGMNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x148C650", Offset = "0x148B650", VA = "0x18148C650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
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
		public readonly OIDLICKKMBF<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly OIDLICKKMBF<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EMNNJAPFGJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA4B4B0", Offset = "0xA4A4B0", VA = "0x180A4B4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FJHBLHOMBCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x133CFF0", Offset = "0x133BFF0", VA = "0x18133CFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float LNPMNECAOLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB9E1A0", Offset = "0xB9D1A0", VA = "0x180B9E1A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public RectTransform FGNNMHGBLDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x70C8990", Offset = "0x70C7990", VA = "0x1870C8990", Slot = "5")]
		public void OnDrag(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x70C8A20", Offset = "0x70C7A20", VA = "0x1870C8A20", Slot = "4")]
		public void OnScroll(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x70C8AB0", Offset = "0x70C7AB0", VA = "0x1870C8AB0")]
		private Vector2 PBLDHNHCIHP(Vector2 IPMIODDCEML)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x70C8B00", Offset = "0x70C7B00", VA = "0x1870C8B00")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool KJPCJPHBALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private bool CBLADPCEFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private bool PONDHCAKAAI;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool JMKIPKMCJBH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x70CC210", Offset = "0x70CB210", VA = "0x1870CC210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x70CBF90", Offset = "0x70CAF90", VA = "0x1870CBF90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x70CC440", Offset = "0x70CB440", VA = "0x1870CC440", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x70CC420", Offset = "0x70CB420", VA = "0x1870CC420", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x70CC380", Offset = "0x70CB380", VA = "0x1870CC380", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x70CC480", Offset = "0x70CB480", VA = "0x1870CC480", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x70CC360", Offset = "0x70CB360", VA = "0x1870CC360", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x70CC550", Offset = "0x70CB550", VA = "0x1870CC550")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x70CC280", Offset = "0x70CB280", VA = "0x1870CC280")]
		private void NIJFINKCHGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x70CC0C0", Offset = "0x70CB0C0", VA = "0x1870CC0C0")]
		private void FBBLGNCIDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x70CC1F0", Offset = "0x70CB1F0", VA = "0x1870CC1F0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x70CC5E0", Offset = "0x70CB5E0", VA = "0x1870CC5E0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IGBJGLLJBOI
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const string CBALHDONJIJ = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const string MLPJHDLDJEJ = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const string ODJMBGEBJDF = "\ufffd";
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string FPJPKHLJLAC = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string INCHOJLFKOI = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const float DIABACAHANJ = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly List<UIAnchorFollower> MJAGCDCPEIP;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly MONMJFCKPLO OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly MONMJFCKPLO OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static HPPJLELMILL IBKGAKGABCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private OEMFJNEEEFM CKAOOELNPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Vector3 PFHOHPECFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Quaternion MFCEPMCCOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 FPFGNMCDPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private UIAnchor DNNBALLBDBM;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public UIAnchor CNPBNOHBGNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x94AC50", Offset = "0x949C50", VA = "0x18094AC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool PMIIHBMFKAG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB4BB90", Offset = "0xB4AB90", VA = "0x180B4BB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x70CB520", Offset = "0x70CA520", VA = "0x1870CB520")]
		[HNDDGAICDJM(KJNNMKFJALK.Unity_AfterSceneLoad)]
		private static void JFGMJMMFADK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x70CAF30", Offset = "0x70C9F30", VA = "0x1870CAF30")]
		[PPMJBBHKDPA(BIABBNOAALP.ExitingPlayMode, 0)]
		private static void CODOFJPKFBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x70CB8E0", Offset = "0x70CA8E0", VA = "0x1870CB8E0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x70CACE0", Offset = "0x70C9CE0", VA = "0x1870CACE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70CB670", Offset = "0x70CA670", VA = "0x1870CB670", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x70CB4E0", Offset = "0x70CA4E0", VA = "0x1870CB4E0")]
		public void Initialize(UIAnchor DNNBALLBDBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x70CB840", Offset = "0x70CA840", VA = "0x1870CB840")]
		public void SetAnchorObjectEnabled(bool PINBJOHBLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x70CB890", Offset = "0x70CA890", VA = "0x1870CB890")]
		public void SetCanvasRenderingEnabled(bool PINBJOHBLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x70CB000", Offset = "0x70CA000", VA = "0x1870CB000")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x70CB3D0", Offset = "0x70CA3D0", VA = "0x1870CB3D0")]
		private void HNOMIKFAEBF(bool PINBJOHBLIC, object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x70CB5F0", Offset = "0x70CA5F0", VA = "0x1870CB5F0")]
		private void MKHKJIEHAEP(bool PINBJOHBLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x70CBA50", Offset = "0x70CAA50", VA = "0x1870CBA50")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x70CB1E0", Offset = "0x70CA1E0", VA = "0x1870CB1E0")]
		private void GEOAKACECGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x70CBEC0", Offset = "0x70CAEC0", VA = "0x1870CBEC0")]
		public UIAnchorFollower()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JOMGLEBCFMP
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray BCCLJEDMDFN, out Graphic JFMHKLOPALK);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable FCILEMKNJGB);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
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
