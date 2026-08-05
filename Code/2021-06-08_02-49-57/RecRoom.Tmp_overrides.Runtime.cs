using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace TMPro
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/TMP Dropdown", 35)]
	public class AG_TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			[SerializeField]
			private TMP_Text m_Text;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			[SerializeField]
			private Image m_Image;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			[SerializeField]
			private RectTransform m_RectTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			[SerializeField]
			private Toggle m_Toggle;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public TMP_Text PAANJCAOOAG
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x3EEBF0", Offset = "0x3ED9F0", VA = "0x1803EEBF0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public Image IJKBAADKCBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x3EEBE0", Offset = "0x3ED9E0", VA = "0x1803EEBE0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x440320", Offset = "0x43F120", VA = "0x180440320")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RectTransform AIOEKMHLKAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x3F00F0", Offset = "0x3EEEF0", VA = "0x1803F00F0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x3EF030", Offset = "0x3EDE30", VA = "0x1803EF030")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Toggle MJDKJADPGIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x3FC030", Offset = "0x3FAE30", VA = "0x1803FC030")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x3EF010", Offset = "0x3EDE10", VA = "0x1803EF010")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2BCC040", Offset = "0x2BCAE40", VA = "0x182BCC040", Slot = "6")]
			public virtual void OnPointerEnter(PointerEventData OEKEOCOGKMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBFB0", Offset = "0x2BCADB0", VA = "0x182BCBFB0", Slot = "7")]
			public virtual void OnCancel(BaseEventData OEKEOCOGKMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8040F0", Offset = "0x802EF0", VA = "0x1808040F0")]
			public DropdownItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public class OptionData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			[SerializeField]
			private string m_Text;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			[SerializeField]
			private Sprite m_Image;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string text
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x3E0000", Offset = "0x3DEE00", VA = "0x1803E0000")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x3EEC00", Offset = "0x3EDA00", VA = "0x1803EEC00")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public Sprite image
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x3EEBF0", Offset = "0x3ED9F0", VA = "0x1803EEBF0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C80", Offset = "0x3E6A80", VA = "0x1803E7C80")]
			public OptionData()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x407DE0", Offset = "0x406BE0", VA = "0x180407DE0")]
			public OptionData(string PAANJCAOOAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x46FF30", Offset = "0x46ED30", VA = "0x18046FF30")]
			public OptionData(Sprite IJKBAADKCBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3FD2E0", Offset = "0x3FC0E0", VA = "0x1803FD2E0")]
			public OptionData(string PAANJCAOOAG, Sprite IJKBAADKCBM)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public class OptionDataList
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			[SerializeField]
			private List<OptionData> m_Options;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public List<OptionData> options
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x3E0000", Offset = "0x3DEE00", VA = "0x1803E0000")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x3EEC00", Offset = "0x3EDA00", VA = "0x1803EEC00")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCAF0", Offset = "0x2BCB8F0", VA = "0x182BCCAF0")]
			public OptionDataList()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public class DropdownEvent : UnityEvent<int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBF70", Offset = "0x2BCAD70", VA = "0x182BCBF70")]
			public DropdownEvent()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class DCMBNBJLLKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public DropdownItem item;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AG_TMP_Dropdown <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C80", Offset = "0x3E6A80", VA = "0x1803E7C80")]
			public DCMBNBJLLKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBDF0", Offset = "0x2BCABF0", VA = "0x182BCBDF0")]
			internal void <Show>b__0(bool x)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OMHNBHFCIHJ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float delay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public AG_TMP_Dropdown <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x439260", Offset = "0x438060", VA = "0x180439260")]
			[DebuggerHidden]
			public OMHNBHFCIHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2BCC9B0", Offset = "0x2BCB7B0", VA = "0x182BCC9B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCA60", Offset = "0x2BCB860", VA = "0x182BCCA60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private RectTransform m_Template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private TMP_Text m_CaptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private Image m_CaptionImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Space]
		[SerializeField]
		private TMP_Text m_ItemText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private Image m_ItemImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		[Space]
		private int m_Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[Space]
		private OptionDataList m_Options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Space]
		[SerializeField]
		private DropdownEvent m_OnValueChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private GameObject AICBIOINOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private GameObject POHHGNBOMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<DropdownItem> GGJCGPEEMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private global::OPBIENGHNOL<DNKDGAHHBCN> CPAFBFMMPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private bool OJEHIKABCEG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static OptionData KCKOBJODBMC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public RectTransform KHKGJGPIIAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x83E070", Offset = "0x83CE70", VA = "0x18083E070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDC20", Offset = "0x2BBCA20", VA = "0x182BBDC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TMP_Text GNPFHIKGONC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6FE240", Offset = "0x6FD040", VA = "0x1806FE240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDBC0", Offset = "0x2BBC9C0", VA = "0x182BBDBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Image FADBPBIJPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x83E220", Offset = "0x83D020", VA = "0x18083E220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDBB0", Offset = "0x2BBC9B0", VA = "0x182BBDBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public TMP_Text IJANOFBIFGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x83E190", Offset = "0x83CF90", VA = "0x18083E190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDBE0", Offset = "0x2BBC9E0", VA = "0x182BBDBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Image CECFEBFHOBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x83CFD0", Offset = "0x83BDD0", VA = "0x18083CFD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDBD0", Offset = "0x2BBC9D0", VA = "0x182BBDBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public List<OptionData> JJAPBNJPPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1622540", Offset = "0x1621340", VA = "0x181622540")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDBF0", Offset = "0x2BBC9F0", VA = "0x182BBDBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public DropdownEvent CCHCBCLCFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x83E080", Offset = "0x83CE80", VA = "0x18083E080")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xBEA5D0", Offset = "0xBE93D0", VA = "0x180BEA5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int ONGBFDACHHG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xC39850", Offset = "0xC38650", VA = "0x180C39850")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDC30", Offset = "0x2BBCA30", VA = "0x182BBDC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PHOKNNFACHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDB00", Offset = "0x2BBC900", VA = "0x182BBDB00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HACBIOINOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2BBDB60", Offset = "0x2BBC960", VA = "0x182BBDB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BBD9D0", Offset = "0x2BBC7D0", VA = "0x182BBD9D0")]
		protected AG_TMP_Dropdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB560", Offset = "0x2BBA360", VA = "0x182BBB560", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC9B0", Offset = "0x2BBB7B0", VA = "0x182BBC9B0")]
		public void RefreshShownValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB400", Offset = "0x2BBA200", VA = "0x182BBB400")]
		public void AddOptions(List<OptionData> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB310", Offset = "0x2BBA110", VA = "0x182BBB310")]
		public void AddOptions(List<string> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB470", Offset = "0x2BBA270", VA = "0x182BBB470")]
		public void AddOptions(List<Sprite> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB6C0", Offset = "0x2BBA4C0", VA = "0x182BBB6C0")]
		public void ClearOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB720", Offset = "0x2BBA520", VA = "0x182BBB720")]
		private void HKAJJALGMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x135F530", Offset = "0x135E330", VA = "0x18135F530")]
		private static T GLENGLDKGCK<T>(GameObject NNNMGKGMIFG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC9A0", Offset = "0x2BBB7A0", VA = "0x182BBC9A0", Slot = "42")]
		public virtual void OnPointerClick(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC9A0", Offset = "0x2BBB7A0", VA = "0x182BBC9A0", Slot = "43")]
		public virtual void OnSubmit(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC990", Offset = "0x2BBB790", VA = "0x182BBC990", Slot = "44")]
		public virtual void OnCancel(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2BBCBD0", Offset = "0x2BBB9D0", VA = "0x182BBCBD0")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC310", Offset = "0x2BBB110", VA = "0x182BBC310", Slot = "45")]
		protected virtual GameObject MLONLGOJHEF(Canvas GGEDDFLMJHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB0C0", Offset = "0x2BB9EC0", VA = "0x182BBB0C0", Slot = "46")]
		protected virtual void AMGBINMEKLB(GameObject HJPGLBGMCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC2B0", Offset = "0x2BBB0B0", VA = "0x182BBC2B0", Slot = "47")]
		protected virtual GameObject MKDGFAJHFPI(GameObject KHKGJGPIIAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC810", Offset = "0x2BBB610", VA = "0x182BBC810", Slot = "48")]
		protected virtual void NPDNDADJNJG(GameObject AFFMGNGGCEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC250", Offset = "0x2BBB050", VA = "0x182BBC250", Slot = "49")]
		protected virtual DropdownItem JIJOIMHCMAE(DropdownItem FOIOJEEDDCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820", Slot = "50")]
		protected virtual void HOMLPHHMJEL(DropdownItem IOBEPGLJNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBFA0", Offset = "0x2BBADA0", VA = "0x182BBBFA0")]
		private DropdownItem ICFDCCEPJDL(OptionData ABADFLCBFIJ, bool EGJJHJHIPCF, DropdownItem FOIOJEEDDCI, List<DropdownItem> BOOHBJEEGKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC5C0", Offset = "0x2BBB3C0", VA = "0x182BBC5C0")]
		private void NOHLFCGKAPE(float BJJEDIGOMGC, float FBPFONBFPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC650", Offset = "0x2BBB450", VA = "0x182BBC650")]
		private void NOHLFCGKAPE(float BJJEDIGOMGC, float FKGCMPGAIAP, float KOFMGJJCPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC8E0", Offset = "0x2BBB6E0", VA = "0x182BBC8E0")]
		private void OOOAOJDCEHN(float FBPFONBFPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBDF0", Offset = "0x2BBABF0", VA = "0x182BBBDF0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBC00", Offset = "0x2BBAA00", VA = "0x182BBBC00")]
		public void HideImmediately()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC870", Offset = "0x2BBB670", VA = "0x182BBC870")]
		[IteratorStateMachine(typeof(OMHNBHFCIHJ))]
		private IEnumerator OENONJDLMPC(float NBOCPMDNOCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB120", Offset = "0x2BB9F20", VA = "0x182BBB120")]
		private void AOPMFOAMJKK(Toggle MJDKJADPGIG)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AddComponentMenu("UI/AG TextMeshPro - Input Field", 105)]
	public class AG_TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, IScrollHandler
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public delegate char CCNHIOBEBOA(string PAANJCAOOAG, int BNDFKNANLDO, char NJOANBJCKDI);

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public class SubmitEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCBD0", Offset = "0x2BCB9D0", VA = "0x182BCCBD0")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCAB0", Offset = "0x2BCB8B0", VA = "0x182BCCAB0")]
			public OnChangeEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class SelectionEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCB90", Offset = "0x2BCB990", VA = "0x182BCCB90")]
			public SelectionEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCC10", Offset = "0x2BCBA10", VA = "0x182BCCC10")]
			public TextSelectionEvent()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		protected enum JHEIPDKDOED
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Continue,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			Finish
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class ABBELKNBPEB : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AG_TMP_InputField <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x439260", Offset = "0x438060", VA = "0x180439260")]
			[DebuggerHidden]
			public ABBELKNBPEB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2BBADC0", Offset = "0x2BB9BC0", VA = "0x182BBADC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x2BBAEE0", Offset = "0x2BB9CE0", VA = "0x182BBAEE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class HPAOCFBMJAC : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AG_TMP_InputField <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public PointerEventData eventData;

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x439260", Offset = "0x438060", VA = "0x180439260")]
			[DebuggerHidden]
			public HPAOCFBMJAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x2BCC6E0", Offset = "0x2BCB4E0", VA = "0x182BCC6E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x2BCC960", Offset = "0x2BCB760", VA = "0x182BCC960", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static global::IILCGFIHJLP<TouchScreenKeyboard, AG_TMP_InputField> UpdateViewForMobileKeyboardEvent;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static bool ForceTouchKeyboardDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		protected TouchScreenKeyboard HJLGGJNDBNI;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly char[] POLJOMDDGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		protected RectTransform m_TextViewport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		protected TMP_Text m_TextComponent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected RectTransform KBDPEAMGNAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		protected bool m_HidePlaceholderOnFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		protected Graphic m_Placeholder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		protected Scrollbar m_VerticalScrollbar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private float CJHFBGKENDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[Range(0f, 1f)]
		protected float m_MinimumScrollbarSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		protected float m_ScrollSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private TMP_InputField.ContentType m_ContentType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private TMP_InputField.InputType m_InputType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private char m_AsteriskChar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private TMP_InputField.LineType m_LineType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private TMP_InputField.CharacterValidation m_CharacterValidation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private string m_RegexValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private float m_GlobalPointSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private int m_CharacterLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private SubmitEvent m_OnEndEdit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private SubmitEvent m_OnSubmit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private SelectionEvent m_OnSelect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private SelectionEvent m_OnDeselect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private TextSelectionEvent m_OnTextSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private TextSelectionEvent m_OnEndTextSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private OnChangeEvent m_OnValueChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private CCNHIOBEBOA m_OnValidateInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Color m_CaretColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private bool m_CustomCaretColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private Color m_SelectionColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[TextArea]
		protected string m_Text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[Range(0f, 4f)]
		private float m_CaretBlinkRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		[Range(1f, 5f)]
		private int m_CaretWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private bool m_ReadOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F1")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private bool m_RichText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected int PAMBCFMBHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected int PJFJGLNDMAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		protected int LKCMLDMBLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected int DMPNOGKIJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RectTransform JOMCONDMIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected UIVertex[] KOGGBMFPGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private CanvasRenderer EGKOKOLPEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Vector2 ANLDAAOKNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Vector2 FKCJKBMBGFM;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected Mesh BOMANFDHOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool DBMMPCJGIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x239")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool FCMLLLNPOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23A")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool PBLIMFCFMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23B")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool ANDDHNDKLGB;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private const float KPOKDMHNIHM = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private const float PENHGJPGMJH = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		protected bool MDGINLMPBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Coroutine KCMIBPLKLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private float BAPMFGMDDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Coroutine AKLHGDAKMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private string LBOIAHBFAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private bool JAOOACGKJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x261")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private bool OPCHNHIAFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x262")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private bool BIBJPJCFOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x263")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private bool EONBLKIPAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool BHJLOEBNHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private float EPIPHKEBKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private float GKOGDBNHCGL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private const string MNCPKKBHHHP = "!#$%&'*+-/=?^_`{|}~";

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		protected TMP_FontAsset m_GlobalFontAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		protected bool m_OnFocusSelectAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected bool OCDPJGGGCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27A")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		protected bool m_ResetOnDeActivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27B")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private bool m_RestoreOriginalTextOnEscape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		protected bool m_isRichTextEditingAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27D")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		protected bool m_updateMobileViewWhenKeyboardOpens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27E")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		protected bool m_ForceDisableScreenSpaceNotification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		protected TMP_InputValidator m_InputValidator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Func<string, bool> GBJBFFBHJOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool AIMPABOMICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x291")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool KIDFDLCBNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x292")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool GCGLLCBEGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private Event LJMHNINAHKD;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool AJIFFAHNDBK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA2B0", Offset = "0x2BC90B0", VA = "0x182BCA2B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public TouchScreenKeyboard.Status AAMIDBCKMFN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x177DFA0", Offset = "0x177CDA0", VA = "0x18177DFA0")]
			[CompilerGenerated]
			get
			{
				return default(TouchScreenKeyboard.Status);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x177E450", Offset = "0x177D250", VA = "0x18177E450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TouchScreenKeyboard MFCBKLKENCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6FE240", Offset = "0x6FD040", VA = "0x1806FE240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string AJBKBJKLGEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x83E000", Offset = "0x83CE00", VA = "0x18083E000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA4C0", Offset = "0x2BC92C0", VA = "0x182BCA4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected Mesh EDLHNCIENFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE8D0", Offset = "0x2BBD6D0", VA = "0x182BBE8D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool AKNGFFLFKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA470", Offset = "0x2BC9270", VA = "0x182BCA470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string PAANJCAOOAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8704F0", Offset = "0x86F2F0", VA = "0x1808704F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBAA0", Offset = "0x2BCA8A0", VA = "0x182BCBAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool LMHGKGKNCDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA3E0", Offset = "0x2BC91E0", VA = "0x182BCA3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float HDBOICOPFPG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA330", Offset = "0x2BC9130", VA = "0x182BCA330")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA570", Offset = "0x2BC9370", VA = "0x182BCA570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int NBLMMLPFCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA3A0", Offset = "0x2BC91A0", VA = "0x182BCA3A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA7A0", Offset = "0x2BC95A0", VA = "0x182BCA7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RectTransform DAMCEBLMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x83E220", Offset = "0x83D020", VA = "0x18083E220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBA50", Offset = "0x2BCA850", VA = "0x182BCBA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TMP_Text GAOOAKOACIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83E190", Offset = "0x83CF90", VA = "0x18083E190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBA00", Offset = "0x2BCA800", VA = "0x182BCBA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Graphic NFNFFNAHAPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x83D140", Offset = "0x83BF40", VA = "0x18083D140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB380", Offset = "0x2BCA180", VA = "0x182BCB380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Scrollbar DMEHABPKKAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x83E080", Offset = "0x83CE80", VA = "0x18083E080")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBBC0", Offset = "0x2BCA9C0", VA = "0x182BCBBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float PAKOCGKNBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xC35EC0", Offset = "0xC34CC0", VA = "0x180C35EC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB5F0", Offset = "0x2BCA3F0", VA = "0x182BCB5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color DLGIEJOLHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA340", Offset = "0x2BC9140", VA = "0x182BCA340")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA5E0", Offset = "0x2BC93E0", VA = "0x182BCA5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool PHKEONAKJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE700A0", Offset = "0xE6EEA0", VA = "0x180E700A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2BCABF0", Offset = "0x2BC99F0", VA = "0x182BCABF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Color DDOJNMCKCKN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA460", Offset = "0x2BC9260", VA = "0x182BCA460")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB720", Offset = "0x2BCA520", VA = "0x182BCB720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public SubmitEvent BGNEEOKFCGC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x83DF50", Offset = "0x83CD50", VA = "0x18083DF50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB150", Offset = "0x2BC9F50", VA = "0x182BCB150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public SubmitEvent DKKHDPBJKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x83E550", Offset = "0x83D350", VA = "0x18083E550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB240", Offset = "0x2BCA040", VA = "0x182BCB240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public SelectionEvent BCHLJNBPNPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xBE91F0", Offset = "0xBE7FF0", VA = "0x180BE91F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB1F0", Offset = "0x2BC9FF0", VA = "0x182BCB1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public SelectionEvent LJPBJFEFDKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6F8B70", Offset = "0x6F7970", VA = "0x1806F8B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB100", Offset = "0x2BC9F00", VA = "0x182BCB100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TextSelectionEvent ENMOLJBNAHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6F88F0", Offset = "0x6F76F0", VA = "0x1806F88F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB290", Offset = "0x2BCA090", VA = "0x182BCB290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public TextSelectionEvent HHAPBEDJKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x83D120", Offset = "0x83BF20", VA = "0x18083D120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB1A0", Offset = "0x2BC9FA0", VA = "0x182BCB1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public OnChangeEvent CCHCBCLCFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x83E430", Offset = "0x83D230", VA = "0x18083E430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB330", Offset = "0x2BCA130", VA = "0x182BCB330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public CCNHIOBEBOA KFGGMLKECGK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xBE8060", Offset = "0xBE6E60", VA = "0x180BE8060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB2E0", Offset = "0x2BCA0E0", VA = "0x182BCB2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int DIDPKDLHNBN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA3B0", Offset = "0x2BC91B0", VA = "0x182BCA3B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA840", Offset = "0x2BC9640", VA = "0x182BCA840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float EGCPILNPLKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA420", Offset = "0x2BC9220", VA = "0x182BCA420")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB3D0", Offset = "0x2BCA1D0", VA = "0x182BCB3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TMP_FontAsset GCFIODLCCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x835520", Offset = "0x834320", VA = "0x180835520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2BCAC60", Offset = "0x2BC9A60", VA = "0x182BCAC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LACLMELLCGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1410E60", Offset = "0x140FC60", VA = "0x181410E60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x14009C0", Offset = "0x13FF7C0", VA = "0x1814009C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool CEHNEGPAGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA430", Offset = "0x2BC9230", VA = "0x182BCA430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB540", Offset = "0x2BCA340", VA = "0x182BCB540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CHEGLKKIPBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA440", Offset = "0x2BC9240", VA = "0x182BCA440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB550", Offset = "0x2BCA350", VA = "0x182BCB550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool KAAIKJLFGFP
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA3F0", Offset = "0x2BC91F0", VA = "0x182BCA3F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2BCAF20", Offset = "0x2BC9D20", VA = "0x182BCAF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PCKCCEOPIGL
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA4A0", Offset = "0x2BC92A0", VA = "0x182BCA4A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBBB0", Offset = "0x2BCA9B0", VA = "0x182BCBBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool NCAFECJAAEC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA2A0", Offset = "0x2BC90A0", VA = "0x182BCA2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TMP_InputField.ContentType KCKBKEKAMDF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6FDD80", Offset = "0x6FCB80", VA = "0x1806FDD80")]
			get
			{
				return default(TMP_InputField.ContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA940", Offset = "0x2BC9740", VA = "0x182BCA940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public TMP_InputField.LineType PLOPNEGDJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xC50E40", Offset = "0xC4FC40", VA = "0x180C50E40")]
			get
			{
				return default(TMP_InputField.LineType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2BCAFA0", Offset = "0x2BC9DA0", VA = "0x182BCAFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public TMP_InputField.InputType KJNDMFLHLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6FE090", Offset = "0x6FCE90", VA = "0x1806FE090")]
			get
			{
				return default(TMP_InputField.InputType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2BCADF0", Offset = "0x2BC9BF0", VA = "0x182BCADF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TouchScreenKeyboardType MLFHHNNDOEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x883770", Offset = "0x882570", VA = "0x180883770")]
			get
			{
				return default(TouchScreenKeyboardType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2BCAF30", Offset = "0x2BC9D30", VA = "0x182BCAF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TMP_InputField.CharacterValidation HMCHFOILHPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x13D01E0", Offset = "0x13CEFE0", VA = "0x1813D01E0")]
			get
			{
				return default(TMP_InputField.CharacterValidation);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA8D0", Offset = "0x2BC96D0", VA = "0x182BCA8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TMP_InputValidator EPPLBJHBEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA3D0", Offset = "0x2BC91D0", VA = "0x182BCA3D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2BCAE60", Offset = "0x2BC9C60", VA = "0x182BCAE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Func<string, bool> GOLGMHKKGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA3C0", Offset = "0x2BC91C0", VA = "0x182BCA3C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2BCADA0", Offset = "0x2BC9BA0", VA = "0x182BCADA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool BGNEPFGDKHB
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x21AA810", Offset = "0x21A9610", VA = "0x1821AA810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB530", Offset = "0x2BCA330", VA = "0x182BCB530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool DAAFDDDHEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA450", Offset = "0x2BC9250", VA = "0x182BCA450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB560", Offset = "0x2BCA360", VA = "0x182BCB560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool BBKJPKCMMNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA400", Offset = "0x2BC9200", VA = "0x182BCA400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public char EHGCPACOOKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA320", Offset = "0x2BC9120", VA = "0x182BCA320")]
			get
			{
				return default(char);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA510", Offset = "0x2BC9310", VA = "0x182BCA510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool BFMGMGGLHKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA4B0", Offset = "0x2BC92B0", VA = "0x182BCA4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected int CHFEODECIBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2BC72E0", Offset = "0x2BC60E0", VA = "0x182BC72E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2BC3AE0", Offset = "0x2BC28E0", VA = "0x182BC3AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected int JDLAOAEIGBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2BC3AB0", Offset = "0x2BC28B0", VA = "0x182BC3AB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2BC33A0", Offset = "0x2BC21A0", VA = "0x182BC33A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected int OJEPKIDOLDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2BC0710", Offset = "0x2BBF510", VA = "0x182BC0710")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE700", Offset = "0x2BBD500", VA = "0x182BBE700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected int BJKFMKDBNJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2BC15A0", Offset = "0x2BC03A0", VA = "0x182BC15A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2BC24C0", Offset = "0x2BC12C0", VA = "0x182BC24C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool HHBIHFPBPEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF810", Offset = "0x2BBE610", VA = "0x182BBF810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int LIMFKKIOJCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2BC0710", Offset = "0x2BBF510", VA = "0x182BC0710")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA690", Offset = "0x2BC9490", VA = "0x182BCA690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public int GALHKIEDLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2BC72E0", Offset = "0x2BC60E0", VA = "0x182BC72E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB690", Offset = "0x2BCA490", VA = "0x182BCB690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int JIFIJDPPPFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x2BC0710", Offset = "0x2BBF510", VA = "0x182BC0710")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB7D0", Offset = "0x2BCA5D0", VA = "0x182BCB7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int HBEHMEFLOII
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x2BC15A0", Offset = "0x2BC03A0", VA = "0x182BC15A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB940", Offset = "0x2BCA740", VA = "0x182BCB940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int NNHHHMKKBBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x2BC3AB0", Offset = "0x2BC28B0", VA = "0x182BC3AB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB860", Offset = "0x2BCA660", VA = "0x182BCB860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int JAIBIHAADGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x2BC15A0", Offset = "0x2BC03A0", VA = "0x182BC15A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB8D0", Offset = "0x2BCA6D0", VA = "0x182BCB8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private static string MGPNHELOFBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1638940", Offset = "0x1637740", VA = "0x181638940")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x16394A0", Offset = "0x16382A0", VA = "0x1816394A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9F30", Offset = "0x2BC8D30", VA = "0x182BC9F30")]
		protected AG_TMP_InputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1F60", Offset = "0x2BC0D60", VA = "0x182BC1F60")]
		protected void GNLDFFIHBNL(ref int IFAIDIKJOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1620", Offset = "0x2BC0420", VA = "0x182BC1620")]
		protected void FOHLGFNFBHH(ref int IFAIDIKJOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7B80", Offset = "0x2BC6980", VA = "0x182BC7B80", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7490", Offset = "0x2BC6290", VA = "0x182BC7490", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF870", Offset = "0x2BBE670", VA = "0x182BBF870")]
		private void CIPAFIJGFPH(UnityEngine.Object NLNHFEEMFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC23E0", Offset = "0x2BC11E0", VA = "0x182BC23E0")]
		[IteratorStateMachine(typeof(ABBELKNBPEB))]
		private IEnumerator IFLEEBBKHHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE4C0", Offset = "0x2BBD2C0", VA = "0x182BBE4C0")]
		private void AMNPDKKBKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1260", Offset = "0x2BC0060", VA = "0x182BC1260")]
		private void FINJJEAKJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3D30", Offset = "0x2BC2B30", VA = "0x182BC3D30")]
		protected void LKIDFHCFCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2440", Offset = "0x2BC1240", VA = "0x182BC2440")]
		protected void ILKEOLFCLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5780", Offset = "0x2BC4580", VA = "0x182BC5780")]
		public void MoveTextEnd(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5960", Offset = "0x2BC4760", VA = "0x182BC5960")]
		public void MoveTextStart(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5AE0", Offset = "0x2BC48E0", VA = "0x182BC5AE0")]
		public void MoveToEndOfLine(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5CD0", Offset = "0x2BC4AD0", VA = "0x182BC5CD0")]
		public void MoveToStartOfLine(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC33F0", Offset = "0x2BC21F0", VA = "0x182BC33F0")]
		private bool KKILEDOIHJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC49F0", Offset = "0x2BC37F0", VA = "0x182BC49F0", Slot = "51")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4920", Offset = "0x2BC3720", VA = "0x182BC4920")]
		private bool LPNBFDALPBB(PointerEventData OEKEOCOGKMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC73F0", Offset = "0x2BC61F0", VA = "0x182BC73F0", Slot = "52")]
		public virtual void OnBeginDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC77A0", Offset = "0x2BC65A0", VA = "0x182BC77A0", Slot = "53")]
		public virtual void OnDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1B90", Offset = "0x2BC0990", VA = "0x182BC1B90")]
		[IteratorStateMachine(typeof(HPAOCFBMJAC))]
		private IEnumerator GECGBFHNIHP(PointerEventData OEKEOCOGKMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8230", Offset = "0x2BC7030", VA = "0x182BC8230", Slot = "54")]
		public virtual void OnEndDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8290", Offset = "0x2BC7090", VA = "0x182BC8290", Slot = "32")]
		public override void OnPointerDown(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0810", Offset = "0x2BBF610", VA = "0x182BC0810")]
		protected JHEIPDKDOED ELNLABLFKNG(Event PFFGBOMIOHL)
		{
			return default(JHEIPDKDOED);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2510", Offset = "0x2BC1310", VA = "0x182BC2510")]
		private bool JGOAIDFDMAD(char MBEHODBGOJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9BC0", Offset = "0x2BC89C0", VA = "0x182BC9BC0")]
		public void ProcessEvent(Event CHKKEHOKPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8B50", Offset = "0x2BC7950", VA = "0x182BC8B50", Slot = "55")]
		public virtual void OnUpdateSelected(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC88A0", Offset = "0x2BC76A0", VA = "0x182BC88A0", Slot = "56")]
		public virtual void OnScroll(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE080", Offset = "0x2BBCE80", VA = "0x182BBE080")]
		private string AEAJLKEPNLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8F80", Offset = "0x2BC7D80", VA = "0x182BC8F80")]
		private int PIAEKONDGNG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF120", Offset = "0x2BBDF20", VA = "0x182BBF120")]
		private void CCJLEGAFGKM(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1690", Offset = "0x2BC0490", VA = "0x182BC1690")]
		private int GADBOBOJIDE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2DA0", Offset = "0x2BC1BA0", VA = "0x182BC2DA0")]
		private void JLMEDGAJBEC(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0C80", Offset = "0x2BBFA80", VA = "0x182BC0C80")]
		private int FCKJFAJCNGD(int LBJOEJHPBJK, bool LJFNJIAKLFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2BBDD30", Offset = "0x2BBCB30", VA = "0x182BBDD30")]
		private int AACOJNMNOGE(int LBJOEJHPBJK, bool MNNDCGNNAKB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5130", Offset = "0x2BC3F30", VA = "0x182BC5130")]
		private int MJKECNILJFD(int LBJOEJHPBJK, bool LJFNJIAKLFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2970", Offset = "0x2BC1770", VA = "0x182BC2970")]
		private int JJCPPIAOHIM(int LBJOEJHPBJK, bool MNNDCGNNAKB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2560", Offset = "0x2BC1360", VA = "0x182BC2560")]
		private void JHHDGCMNMCN(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2570", Offset = "0x2BC1370", VA = "0x182BC2570")]
		private void JHHDGCMNMCN(bool DIHIAEIGDKB, bool MNNDCGNNAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1F50", Offset = "0x2BC0D50", VA = "0x182BC1F50")]
		private void GGFOEKLOLNI(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1C00", Offset = "0x2BC0A00", VA = "0x182BC1C00")]
		private void GGFOEKLOLNI(bool DIHIAEIGDKB, bool LJFNJIAKLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9BB0", Offset = "0x2BC89B0", VA = "0x182BC9BB0")]
		private void PNNDENFHNDI(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9630", Offset = "0x2BC8430", VA = "0x182BC9630")]
		private void PNNDENFHNDI(bool DIHIAEIGDKB, bool LJFNJIAKLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3AA0", Offset = "0x2BC28A0", VA = "0x182BC3AA0")]
		private void LCGOPCFKIPP(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3500", Offset = "0x2BC2300", VA = "0x182BC3500")]
		private void LCGOPCFKIPP(bool DIHIAEIGDKB, bool MNNDCGNNAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9090", Offset = "0x2BC7E90", VA = "0x182BC9090")]
		private void PKGAHIFGEII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8CB0", Offset = "0x2BC7AB0", VA = "0x182BC8CB0")]
		private void PDHKGPEOBBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4EB0", Offset = "0x2BC3CB0", VA = "0x182BC4EB0")]
		private void MCMONKBJDEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5560", Offset = "0x2BC4360", VA = "0x182BC5560", Slot = "57")]
		protected virtual void MJLHLGCPKKA(string DBFBLNILIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5610", Offset = "0x2BC4410", VA = "0x182BC5610", Slot = "58")]
		protected virtual void MJLHLGCPKKA(char DBFBLNILIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1360", Offset = "0x2BC0160", VA = "0x182BC1360")]
		private void FLJBJJLIFHM(char MBEHODBGOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE6A0", Offset = "0x2BBD4A0", VA = "0x182BBE6A0")]
		private void BHKGFMKCHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC15D0", Offset = "0x2BC03D0", VA = "0x182BC15D0")]
		private void FNCJLCDOPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8F30", Offset = "0x2BC7D30", VA = "0x182BC8F30")]
		protected void PFONIFOBNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1310", Offset = "0x2BC0110", VA = "0x182BC1310")]
		protected void FJLCFFGEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE650", Offset = "0x2BBD450", VA = "0x182BBE650")]
		protected void BCDADBPHACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2390", Offset = "0x2BC1190", VA = "0x182BC2390")]
		protected void HPALNDEIFIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF750", Offset = "0x2BBE550", VA = "0x182BBF750")]
		protected void CDMKFBBJMDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7310", Offset = "0x2BC6110", VA = "0x182BC7310")]
		protected void ONPEDNNEFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0FC0", Offset = "0x2BBFDC0", VA = "0x182BC0FC0")]
		protected void FDGABBAAGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3B40", Offset = "0x2BC2940", VA = "0x182BC3B40")]
		private void LKFFKIONEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4E50", Offset = "0x2BC3C50", VA = "0x182BC4E50")]
		private void MBEGMCEEJNL(float ONGBFDACHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE760", Offset = "0x2BBD560", VA = "0x182BBE760")]
		private void BPOLKAJBDOB(float LKGCBILJGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC28E0", Offset = "0x2BC16E0", VA = "0x182BC28E0")]
		private int JIHIOHDMHDH(int FOCIACBBGKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5EA0", Offset = "0x2BC4CA0", VA = "0x182BC5EA0")]
		private int NNAEGEJNCLB(int LIMFKKIOJCM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1680", Offset = "0x2BC0480", VA = "0x182BC1680")]
		public void ForceLabelUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1B30", Offset = "0x2BC0930", VA = "0x182BC1B30")]
		private void GCOEHHCNFIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9BD0", Offset = "0x2BC89D0", VA = "0x182BC9BD0", Slot = "59")]
		public virtual void Rebuild(CanvasUpdate JFKDDPJDCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820", Slot = "60")]
		public virtual void LayoutComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820", Slot = "61")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0740", Offset = "0x2BBF540", VA = "0x182BC0740")]
		private void EGPBCLJAIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE980", Offset = "0x2BBD780", VA = "0x182BBE980")]
		private void CCJJNIFEGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1780", Offset = "0x2BC0580", VA = "0x182BC1780")]
		private void GCGNCIIEDJM(Mesh LGFFBNOGPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3E00", Offset = "0x2BC2C00", VA = "0x182BC3E00")]
		private void LKPJIACBDMI(VertexHelper LGFFBNOGPCN, Vector2 HHPJGFCCJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2200", Offset = "0x2BC1000", VA = "0x182BC2200")]
		private void HKNGBDDONBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5F30", Offset = "0x2BC4D30", VA = "0x182BC5F30")]
		private void NPGMCAPEBPB(VertexHelper LGFFBNOGPCN, Vector2 HHPJGFCCJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFA40", Offset = "0x2BBE840", VA = "0x182BBFA40")]
		private void CJDHPCLLGCP(Vector2 FMMMDFONBJG, float CHAKCELLLJD, bool LANOHNACEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6BF0", Offset = "0x2BC59F0", VA = "0x182BC6BF0")]
		protected char OKAAIIMAHLK(string PAANJCAOOAG, int IFAIDIKJOAC, char OEFNGECBJAP)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE500", Offset = "0x2BBD300", VA = "0x182BBE500")]
		public void ActivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE170", Offset = "0x2BBCF70", VA = "0x182BBE170")]
		private void AGAHHMPPAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8A60", Offset = "0x2BC7860", VA = "0x182BC8A60", Slot = "36")]
		public override void OnSelect(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8260", Offset = "0x2BC7060", VA = "0x182BC8260", Slot = "62")]
		public virtual void OnPointerClick(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820")]
		public void OnControlClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC03B0", Offset = "0x2BBF1B0", VA = "0x182BC03B0")]
		public void DeactivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7420", Offset = "0x2BC6220", VA = "0x182BC7420", Slot = "37")]
		public override void OnDeselect(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8AC0", Offset = "0x2BC78C0", VA = "0x182BC8AC0", Slot = "63")]
		public virtual void OnSubmit(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1FA0", Offset = "0x2BC0DA0", VA = "0x182BC1FA0")]
		private void GNNGKJGDDLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3D50", Offset = "0x2BC2B50", VA = "0x182BC3D50")]
		private void LKJOKADIOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0320", Offset = "0x2BBF120", VA = "0x182BC0320")]
		private void DOFNHJBBMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8EC0", Offset = "0x2BC7CC0", VA = "0x182BC8EC0")]
		private void PELNFKBIIFO(params TMP_InputField.ContentType[] BAEPNOGNECP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2BC34E0", Offset = "0x2BC22E0", VA = "0x182BC34E0")]
		private void LBBBNGGBNBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3460", Offset = "0x2BC2260", VA = "0x182BC3460")]
		private void LBBBNGGBNBC(TMP_InputField.CharacterValidation HMCHFOILHPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2BC06E0", Offset = "0x2BBF4E0", VA = "0x182BC06E0", Slot = "26")]
		protected override void DoStateTransition(SelectionState GKNIHNHGBKC, bool BKDCBHDFBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9D90", Offset = "0x2BC8B90", VA = "0x182BC9D90")]
		public void SetGlobalPointSize(float EGCPILNPLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9CA0", Offset = "0x2BC8AA0", VA = "0x182BC9CA0")]
		public void SetGlobalFontAsset(TMP_FontAsset GCFIODLCCKD)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xE0C040", Offset = "0xE0AE40", VA = "0x180E0C040", Slot = "46")]
		Transform ICanvasElement.get_transform()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal static class LKHGDBFEDLD
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x161A060", Offset = "0x1618E60", VA = "0x18161A060")]
	public static bool LJAEIJLMDHG(ref Color MMHAEEACNOD, Color BCEFAKDFEMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1BF7580", Offset = "0x1BF6380", VA = "0x181BF7580")]
	public static bool LBFNDKHKFNH<T>(ref T MMHAEEACNOD, T BCEFAKDFEMM) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1BF7760", Offset = "0x1BF6560", VA = "0x181BF7760")]
	public static bool AKJLBMDKGMF<T>(ref T MMHAEEACNOD, T BCEFAKDFEMM) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1BF7530", Offset = "0x1BF6330", VA = "0x181BF7530")]
	public static bool OHLMOKLHLKO<T>(ref T MMHAEEACNOD, T BCEFAKDFEMM) where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal interface MPLBKBIMHPH
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool LPHAPKJLKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float BJJEDIGOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHDMGIMPNGF(float OKKKBODNINE);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IMJJDPHPEPI();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal struct AEPGFIGJOGP : MPLBKBIMHPH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum PPPKALBKBCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		All,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		RGB,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Alpha
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class PEEOANMJEHL : UnityEvent<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCB50", Offset = "0x2BCB950", VA = "0x182BCCB50")]
		public PEEOANMJEHL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private PEEOANMJEHL LKJFOFGOPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private Color DKOIJCLJDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private Color JHKDBANGCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private PPPKALBKBCI OLDIEIHFCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private float HMNPMJECDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool BFOGCEFGPHL;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Color CONMNBGNOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1617690", Offset = "0x1616490", VA = "0x181617690")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x800BB0", Offset = "0x7FF9B0", VA = "0x180800BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Color OADKADHJHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4D5A40", Offset = "0x4D4840", VA = "0x1804D5A40")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EF0", Offset = "0x8A8CF0", VA = "0x1808A9EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public PPPKALBKBCI KNLKEEHCIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3FC040", Offset = "0x3FAE40", VA = "0x1803FC040")]
		get
		{
			return default(PPPKALBKBCI);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4465B0", Offset = "0x4453B0", VA = "0x1804465B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public float BJJEDIGOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8A93B0", Offset = "0x8A81B0", VA = "0x1808A93B0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8A93C0", Offset = "0x8A81C0", VA = "0x1808A93C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool LPHAPKJLKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x44E540", Offset = "0x44D340", VA = "0x18044E540", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x47A190", Offset = "0x478F90", VA = "0x18047A190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAFD0", Offset = "0x2BB9DD0", VA = "0x182BBAFD0", Slot = "4")]
	public void LHDMGIMPNGF(float OKKKBODNINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAF30", Offset = "0x2BB9D30", VA = "0x182BBAF30")]
	public void CJPIEOIKDAO(UnityAction<Color> AFLPGGJMPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x44E540", Offset = "0x44D340", VA = "0x18044E540")]
	public bool EFGINMKOCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x8A93B0", Offset = "0x8A81B0", VA = "0x1808A93B0")]
	public float JPCNDKLEFFG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xCED150", Offset = "0xCEBF50", VA = "0x180CED150", Slot = "7")]
	public bool IMJJDPHPEPI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal struct DNKDGAHHBCN : MPLBKBIMHPH
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class FAPMPBFOBJM : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC0C0", Offset = "0x2BCAEC0", VA = "0x182BCC0C0")]
		public FAPMPBFOBJM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private FAPMPBFOBJM LKJFOFGOPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private float EBJIFGIDFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private float KFGIFGMLMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private float HMNPMJECDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool BFOGCEFGPHL;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public float NOCHCJLIIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x1617FC0", Offset = "0x1616DC0", VA = "0x181617FC0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1617FD0", Offset = "0x1616DD0", VA = "0x181617FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public float NEACGKEPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x87A750", Offset = "0x879550", VA = "0x18087A750")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x87A770", Offset = "0x879570", VA = "0x18087A770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float BJJEDIGOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x851630", Offset = "0x850430", VA = "0x180851630", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x851780", Offset = "0x850580", VA = "0x180851780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool LPHAPKJLKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3E3910", Offset = "0x3E2710", VA = "0x1803E3910", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3E3450", Offset = "0x3E2250", VA = "0x1803E3450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBEC0", Offset = "0x2BCACC0", VA = "0x182BCBEC0", Slot = "4")]
	public void LHDMGIMPNGF(float OKKKBODNINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBE20", Offset = "0x2BCAC20", VA = "0x182BCBE20")]
	public void CJPIEOIKDAO(UnityAction<float> AFLPGGJMPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3E3910", Offset = "0x3E2710", VA = "0x1803E3910")]
	public bool EFGINMKOCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x851630", Offset = "0x850430", VA = "0x180851630")]
	public float JPCNDKLEFFG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0xCED150", Offset = "0xCEBF50", VA = "0x180CED150", Slot = "7")]
	public bool IMJJDPHPEPI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal class OPBIENGHNOL<T> where T : struct, MPLBKBIMHPH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HLBKKOEPAKM : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public T tweenInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private float <elapsedTime>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1455000", Offset = "0x1453E00", VA = "0x181455000")]
		[DebuggerHidden]
		public HLBKKOEPAKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x1811810", Offset = "0x1810610", VA = "0x181811810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x1811940", Offset = "0x1810740", VA = "0x181811940", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	protected MonoBehaviour NBPANPPCEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	protected IEnumerator FOIJCAOJGAH;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1823840", Offset = "0x1822640", VA = "0x181823840")]
	[IteratorStateMachine(typeof(global::OPBIENGHNOL<>.HLBKKOEPAKM))]
	private static IEnumerator HDGEHNGPFDO(T EPGPDBMBPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC00", Offset = "0x3EDA00", VA = "0x1803EEC00")]
	public void CALJLNMMIPN(MonoBehaviour CMIAMAJBJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x18236E0", Offset = "0x18224E0", VA = "0x1818236E0")]
	public void FPPOJDJCJKI(T DBDDKLHPNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x1823930", Offset = "0x1822730", VA = "0x181823930")]
	public void KOAIIMHNKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x144BFB0", Offset = "0x144ADB0", VA = "0x18144BFB0")]
	public OPBIENGHNOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal static class ADHOJNKKDIL<T>
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly global::DMBLMECIJCJ<List<T>> EMKNBLJKGGK;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x1D125E0", Offset = "0x1D113E0", VA = "0x181D125E0")]
	public static List<T> IAHDANBDAAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1D12750", Offset = "0x1D11550", VA = "0x181D12750")]
	public static void IOFOFLHIJGM(List<T> IOKKOEMCNPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class DMBLMECIJCJ<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Stack<T> NGMEIKFGLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly UnityAction<T> CJOMIABLMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly UnityAction<T> HAJDHBKMLDE;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int GHNCMKIHPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3FC040", Offset = "0x3FAE40", VA = "0x1803FC040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4465B0", Offset = "0x4453B0", VA = "0x1804465B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int HHAOOLFNEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x18E3920", Offset = "0x18E2720", VA = "0x1818E3920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int LCPNJDNOAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x18E3700", Offset = "0x18E2500", VA = "0x1818E3700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x18E3990", Offset = "0x18E2790", VA = "0x1818E3990")]
	public DMBLMECIJCJ(UnityAction<T> GOLBLHIPEDI, UnityAction<T> MJNKDEFIDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x18E3730", Offset = "0x18E2530", VA = "0x1818E3730")]
	public T IAHDANBDAAM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x18E3820", Offset = "0x18E2620", VA = "0x1818E3820")]
	public void IOFOFLHIJGM(T MJHNEPLAFCL)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FFAFDAOBAHN
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static byte[] OHCLMBBDJLC;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static int NJPHPOMKGAO;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static int NCHLFMFMLBC;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static BigInteger AEEDJIDCNEO;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C80", Offset = "0x3E6A80", VA = "0x1803E7C80")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC100", Offset = "0x2BCAF00", VA = "0x182BCC100")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC200", Offset = "0x2BCB000", VA = "0x182BCC200")]
	public static string PAMIGJPGHHB(byte[] MGPDDEMABPB, bool KOILKPGDKMG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C80", Offset = "0x3E6A80", VA = "0x1803E7C80")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
