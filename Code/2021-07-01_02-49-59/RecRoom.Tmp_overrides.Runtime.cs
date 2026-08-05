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
				[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x3E6190", Offset = "0x3E5190", VA = "0x1803E6190")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public Image IJKBAADKCBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x3E6A40", Offset = "0x3E5A40", VA = "0x1803E6A40")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x3E6720", Offset = "0x3E5720", VA = "0x1803E6720")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RectTransform AIOEKMHLKAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x3E6790", Offset = "0x3E5790", VA = "0x1803E6790")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x3E6D70", Offset = "0x3E5D70", VA = "0x1803E6D70")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Toggle MJDKJADPGIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x3E7830", Offset = "0x3E6830", VA = "0x1803E7830")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x3E6A10", Offset = "0x3E5A10", VA = "0x1803E6A10")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x344BCA0", Offset = "0x344ACA0", VA = "0x18344BCA0", Slot = "6")]
			public virtual void OnPointerEnter(PointerEventData OEKEOCOGKMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x344BC10", Offset = "0x344AC10", VA = "0x18344BC10", Slot = "7")]
			public virtual void OnCancel(BaseEventData OEKEOCOGKMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x40CCD0", Offset = "0x40BCD0", VA = "0x18040CCD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E6220", Offset = "0x3E5220", VA = "0x1803E6220")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x3E6240", Offset = "0x3E5240", VA = "0x1803E6240")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public Sprite image
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x3E6190", Offset = "0x3E5190", VA = "0x1803E6190")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3E5020", Offset = "0x3E4020", VA = "0x1803E5020")]
			public OptionData()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x45A210", Offset = "0x459210", VA = "0x18045A210")]
			public OptionData(string PAANJCAOOAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x52A700", Offset = "0x529700", VA = "0x18052A700")]
			public OptionData(Sprite IJKBAADKCBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x48E100", Offset = "0x48D100", VA = "0x18048E100")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E6220", Offset = "0x3E5220", VA = "0x1803E6220")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x3E6240", Offset = "0x3E5240", VA = "0x1803E6240")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x344C750", Offset = "0x344B750", VA = "0x18344C750")]
			public OptionDataList()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public class DropdownEvent : UnityEvent<int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x344BBD0", Offset = "0x344ABD0", VA = "0x18344BBD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E5020", Offset = "0x3E4020", VA = "0x1803E5020")]
			public DCMBNBJLLKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x344BA50", Offset = "0x344AA50", VA = "0x18344BA50")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x40B080", Offset = "0x40A080", VA = "0x18040B080")]
			[DebuggerHidden]
			public OMHNBHFCIHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x344C610", Offset = "0x344B610", VA = "0x18344C610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x344C6C0", Offset = "0x344B6C0", VA = "0x18344C6C0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x92D6B0", Offset = "0x92C6B0", VA = "0x18092D6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x343D880", Offset = "0x343C880", VA = "0x18343D880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TMP_Text GNPFHIKGONC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5B2A00", Offset = "0x5B1A00", VA = "0x1805B2A00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x343D820", Offset = "0x343C820", VA = "0x18343D820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Image FADBPBIJPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x938740", Offset = "0x937740", VA = "0x180938740")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x343D810", Offset = "0x343C810", VA = "0x18343D810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public TMP_Text IJANOFBIFGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x938750", Offset = "0x937750", VA = "0x180938750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x343D840", Offset = "0x343C840", VA = "0x18343D840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Image CECFEBFHOBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x478CA0", Offset = "0x477CA0", VA = "0x180478CA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x343D830", Offset = "0x343C830", VA = "0x18343D830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public List<OptionData> JJAPBNJPPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x938760", Offset = "0x937760", VA = "0x180938760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x343D850", Offset = "0x343C850", VA = "0x18343D850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public DropdownEvent CCHCBCLCFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x41C1C0", Offset = "0x41B1C0", VA = "0x18041C1C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9387E0", Offset = "0x9377E0", VA = "0x1809387E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int ONGBFDACHHG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x938780", Offset = "0x937780", VA = "0x180938780")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x343D890", Offset = "0x343C890", VA = "0x18343D890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PHOKNNFACHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x343D760", Offset = "0x343C760", VA = "0x18343D760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HACBIOINOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x343D7C0", Offset = "0x343C7C0", VA = "0x18343D7C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x343D630", Offset = "0x343C630", VA = "0x18343D630")]
		protected AG_TMP_Dropdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x343B1C0", Offset = "0x343A1C0", VA = "0x18343B1C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x343C610", Offset = "0x343B610", VA = "0x18343C610")]
		public void RefreshShownValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x343B060", Offset = "0x343A060", VA = "0x18343B060")]
		public void AddOptions(List<OptionData> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x343AF70", Offset = "0x3439F70", VA = "0x18343AF70")]
		public void AddOptions(List<string> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x343B0D0", Offset = "0x343A0D0", VA = "0x18343B0D0")]
		public void AddOptions(List<Sprite> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x343B320", Offset = "0x343A320", VA = "0x18343B320")]
		public void ClearOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x343B380", Offset = "0x343A380", VA = "0x18343B380")]
		private void HKAJJALGMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x277DB30", Offset = "0x277CB30", VA = "0x18277DB30")]
		private static T GLENGLDKGCK<T>(GameObject NNNMGKGMIFG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x343C600", Offset = "0x343B600", VA = "0x18343C600", Slot = "42")]
		public virtual void OnPointerClick(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x343C600", Offset = "0x343B600", VA = "0x18343C600", Slot = "43")]
		public virtual void OnSubmit(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x343C5F0", Offset = "0x343B5F0", VA = "0x18343C5F0", Slot = "44")]
		public virtual void OnCancel(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x343C830", Offset = "0x343B830", VA = "0x18343C830")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x343BF70", Offset = "0x343AF70", VA = "0x18343BF70", Slot = "45")]
		protected virtual GameObject MLONLGOJHEF(Canvas GGEDDFLMJHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x343AD20", Offset = "0x3439D20", VA = "0x18343AD20", Slot = "46")]
		protected virtual void AMGBINMEKLB(GameObject HJPGLBGMCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x343BF10", Offset = "0x343AF10", VA = "0x18343BF10", Slot = "47")]
		protected virtual GameObject MKDGFAJHFPI(GameObject KHKGJGPIIAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x343C470", Offset = "0x343B470", VA = "0x18343C470", Slot = "48")]
		protected virtual void NPDNDADJNJG(GameObject AFFMGNGGCEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x343BEB0", Offset = "0x343AEB0", VA = "0x18343BEB0", Slot = "49")]
		protected virtual DropdownItem JIJOIMHCMAE(DropdownItem FOIOJEEDDCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0", Slot = "50")]
		protected virtual void HOMLPHHMJEL(DropdownItem IOBEPGLJNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x343BC00", Offset = "0x343AC00", VA = "0x18343BC00")]
		private DropdownItem ICFDCCEPJDL(OptionData ABADFLCBFIJ, bool EGJJHJHIPCF, DropdownItem FOIOJEEDDCI, List<DropdownItem> BOOHBJEEGKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x343C220", Offset = "0x343B220", VA = "0x18343C220")]
		private void NOHLFCGKAPE(float BJJEDIGOMGC, float FBPFONBFPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x343C2B0", Offset = "0x343B2B0", VA = "0x18343C2B0")]
		private void NOHLFCGKAPE(float BJJEDIGOMGC, float FKGCMPGAIAP, float KOFMGJJCPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x343C540", Offset = "0x343B540", VA = "0x18343C540")]
		private void OOOAOJDCEHN(float FBPFONBFPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x343BA50", Offset = "0x343AA50", VA = "0x18343BA50")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x343B860", Offset = "0x343A860", VA = "0x18343B860")]
		public void HideImmediately()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x343C4D0", Offset = "0x343B4D0", VA = "0x18343C4D0")]
		[IteratorStateMachine(typeof(OMHNBHFCIHJ))]
		private IEnumerator OENONJDLMPC(float NBOCPMDNOCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x343AD80", Offset = "0x3439D80", VA = "0x18343AD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x344C830", Offset = "0x344B830", VA = "0x18344C830")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x344C710", Offset = "0x344B710", VA = "0x18344C710")]
			public OnChangeEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class SelectionEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x344C7F0", Offset = "0x344B7F0", VA = "0x18344C7F0")]
			public SelectionEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x344C870", Offset = "0x344B870", VA = "0x18344C870")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x40B080", Offset = "0x40A080", VA = "0x18040B080")]
			[DebuggerHidden]
			public ABBELKNBPEB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x343AA20", Offset = "0x3439A20", VA = "0x18343AA20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x343AB40", Offset = "0x3439B40", VA = "0x18343AB40", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x40B080", Offset = "0x40A080", VA = "0x18040B080")]
			[DebuggerHidden]
			public HPAOCFBMJAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x344C340", Offset = "0x344B340", VA = "0x18344C340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x344C5C0", Offset = "0x344B5C0", VA = "0x18344C5C0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x3449F10", Offset = "0x3448F10", VA = "0x183449F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public TouchScreenKeyboard.Status AAMIDBCKMFN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x165D6E0", Offset = "0x165C6E0", VA = "0x18165D6E0")]
			[CompilerGenerated]
			get
			{
				return default(TouchScreenKeyboard.Status);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2BDD720", Offset = "0x2BDC720", VA = "0x182BDD720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TouchScreenKeyboard MFCBKLKENCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5B2A00", Offset = "0x5B1A00", VA = "0x1805B2A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string AJBKBJKLGEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8325F0", Offset = "0x8315F0", VA = "0x1808325F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x344A120", Offset = "0x3449120", VA = "0x18344A120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected Mesh EDLHNCIENFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x343E530", Offset = "0x343D530", VA = "0x18343E530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool AKNGFFLFKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x344A0D0", Offset = "0x34490D0", VA = "0x18344A0D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string PAANJCAOOAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1D92820", Offset = "0x1D91820", VA = "0x181D92820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x344B700", Offset = "0x344A700", VA = "0x18344B700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool LMHGKGKNCDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x344A040", Offset = "0x3449040", VA = "0x18344A040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float HDBOICOPFPG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3449F90", Offset = "0x3448F90", VA = "0x183449F90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x344A1D0", Offset = "0x34491D0", VA = "0x18344A1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int NBLMMLPFCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x344A000", Offset = "0x3449000", VA = "0x18344A000")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x344A400", Offset = "0x3449400", VA = "0x18344A400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RectTransform DAMCEBLMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x938740", Offset = "0x937740", VA = "0x180938740")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x344B6B0", Offset = "0x344A6B0", VA = "0x18344B6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TMP_Text GAOOAKOACIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x938750", Offset = "0x937750", VA = "0x180938750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x344B660", Offset = "0x344A660", VA = "0x18344B660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Graphic NFNFFNAHAPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x41C690", Offset = "0x41B690", VA = "0x18041C690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x344AFE0", Offset = "0x3449FE0", VA = "0x18344AFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Scrollbar DMEHABPKKAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x41C1C0", Offset = "0x41B1C0", VA = "0x18041C1C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x344B820", Offset = "0x344A820", VA = "0x18344B820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float PAKOCGKNBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1EF1450", Offset = "0x1EF0450", VA = "0x181EF1450")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x344B250", Offset = "0x344A250", VA = "0x18344B250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color DLGIEJOLHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3449FA0", Offset = "0x3448FA0", VA = "0x183449FA0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x344A240", Offset = "0x3449240", VA = "0x18344A240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool PHKEONAKJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2393FF0", Offset = "0x2392FF0", VA = "0x182393FF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x344A850", Offset = "0x3449850", VA = "0x18344A850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Color DDOJNMCKCKN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x344A0C0", Offset = "0x34490C0", VA = "0x18344A0C0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x344B380", Offset = "0x344A380", VA = "0x18344B380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public SubmitEvent BGNEEOKFCGC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x41C5B0", Offset = "0x41B5B0", VA = "0x18041C5B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x344ADB0", Offset = "0x3449DB0", VA = "0x18344ADB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public SubmitEvent DKKHDPBJKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x41C5A0", Offset = "0x41B5A0", VA = "0x18041C5A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x344AEA0", Offset = "0x3449EA0", VA = "0x18344AEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public SelectionEvent BCHLJNBPNPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x14901B0", Offset = "0x148F1B0", VA = "0x1814901B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x344AE50", Offset = "0x3449E50", VA = "0x18344AE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public SelectionEvent LJPBJFEFDKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xB6EA10", Offset = "0xB6DA10", VA = "0x180B6EA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x344AD60", Offset = "0x3449D60", VA = "0x18344AD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TextSelectionEvent ENMOLJBNAHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x14607C0", Offset = "0x145F7C0", VA = "0x1814607C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x344AEF0", Offset = "0x3449EF0", VA = "0x18344AEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public TextSelectionEvent HHAPBEDJKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4D3F30", Offset = "0x4D2F30", VA = "0x1804D3F30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x344AE00", Offset = "0x3449E00", VA = "0x18344AE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public OnChangeEvent CCHCBCLCFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x41C640", Offset = "0x41B640", VA = "0x18041C640")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x344AF90", Offset = "0x3449F90", VA = "0x18344AF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public CCNHIOBEBOA KFGGMLKECGK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x21BC0D0", Offset = "0x21BB0D0", VA = "0x1821BC0D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x344AF40", Offset = "0x3449F40", VA = "0x18344AF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int DIDPKDLHNBN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x344A010", Offset = "0x3449010", VA = "0x18344A010")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x344A4A0", Offset = "0x34494A0", VA = "0x18344A4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float EGCPILNPLKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x344A080", Offset = "0x3449080", VA = "0x18344A080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x344B030", Offset = "0x344A030", VA = "0x18344B030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TMP_FontAsset GCFIODLCCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x120D630", Offset = "0x120C630", VA = "0x18120D630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x344A8C0", Offset = "0x34498C0", VA = "0x18344A8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LACLMELLCGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x29C2340", Offset = "0x29C1340", VA = "0x1829C2340")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x29B1D40", Offset = "0x29B0D40", VA = "0x1829B1D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool CEHNEGPAGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x344A090", Offset = "0x3449090", VA = "0x18344A090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x344B1A0", Offset = "0x344A1A0", VA = "0x18344B1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CHEGLKKIPBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x344A0A0", Offset = "0x34490A0", VA = "0x18344A0A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x344B1B0", Offset = "0x344A1B0", VA = "0x18344B1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool KAAIKJLFGFP
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x344A050", Offset = "0x3449050", VA = "0x18344A050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x344AB80", Offset = "0x3449B80", VA = "0x18344AB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PCKCCEOPIGL
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x344A100", Offset = "0x3449100", VA = "0x18344A100")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x344B810", Offset = "0x344A810", VA = "0x18344B810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool NCAFECJAAEC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3449F00", Offset = "0x3448F00", VA = "0x183449F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TMP_InputField.ContentType KCKBKEKAMDF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1465C10", Offset = "0x1464C10", VA = "0x181465C10")]
			get
			{
				return default(TMP_InputField.ContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x344A5A0", Offset = "0x34495A0", VA = "0x18344A5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public TMP_InputField.LineType PLOPNEGDJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x219F690", Offset = "0x219E690", VA = "0x18219F690")]
			get
			{
				return default(TMP_InputField.LineType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x344AC00", Offset = "0x3449C00", VA = "0x18344AC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public TMP_InputField.InputType KJNDMFLHLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x1465F20", Offset = "0x1464F20", VA = "0x181465F20")]
			get
			{
				return default(TMP_InputField.InputType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x344AA50", Offset = "0x3449A50", VA = "0x18344AA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TouchScreenKeyboardType MLFHHNNDOEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x241ED40", Offset = "0x241DD40", VA = "0x18241ED40")]
			get
			{
				return default(TouchScreenKeyboardType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x344AB90", Offset = "0x3449B90", VA = "0x18344AB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TMP_InputField.CharacterValidation HMCHFOILHPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD797F0", Offset = "0xD787F0", VA = "0x180D797F0")]
			get
			{
				return default(TMP_InputField.CharacterValidation);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x344A530", Offset = "0x3449530", VA = "0x18344A530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TMP_InputValidator EPPLBJHBEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x344A030", Offset = "0x3449030", VA = "0x18344A030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x344AAC0", Offset = "0x3449AC0", VA = "0x18344AAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Func<string, bool> GOLGMHKKGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x344A020", Offset = "0x3449020", VA = "0x18344A020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x344AA00", Offset = "0x3449A00", VA = "0x18344AA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool BGNEPFGDKHB
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9FF0B0", Offset = "0x9FE0B0", VA = "0x1809FF0B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x344B190", Offset = "0x344A190", VA = "0x18344B190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool DAAFDDDHEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x344A0B0", Offset = "0x34490B0", VA = "0x18344A0B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x344B1C0", Offset = "0x344A1C0", VA = "0x18344B1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool BBKJPKCMMNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x344A060", Offset = "0x3449060", VA = "0x18344A060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public char EHGCPACOOKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x3449F80", Offset = "0x3448F80", VA = "0x183449F80")]
			get
			{
				return default(char);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x344A170", Offset = "0x3449170", VA = "0x18344A170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool BFMGMGGLHKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x344A110", Offset = "0x3449110", VA = "0x18344A110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected int CHFEODECIBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x3446F40", Offset = "0x3445F40", VA = "0x183446F40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3443740", Offset = "0x3442740", VA = "0x183443740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected int JDLAOAEIGBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x3443710", Offset = "0x3442710", VA = "0x183443710")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x3443000", Offset = "0x3442000", VA = "0x183443000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected int OJEPKIDOLDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x3440370", Offset = "0x343F370", VA = "0x183440370")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x343E360", Offset = "0x343D360", VA = "0x18343E360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected int BJKFMKDBNJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x3441200", Offset = "0x3440200", VA = "0x183441200")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x3442120", Offset = "0x3441120", VA = "0x183442120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool HHBIHFPBPEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x343F470", Offset = "0x343E470", VA = "0x18343F470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int LIMFKKIOJCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3440370", Offset = "0x343F370", VA = "0x183440370")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x344A2F0", Offset = "0x34492F0", VA = "0x18344A2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public int GALHKIEDLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3446F40", Offset = "0x3445F40", VA = "0x183446F40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x344B2F0", Offset = "0x344A2F0", VA = "0x18344B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int JIFIJDPPPFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x3440370", Offset = "0x343F370", VA = "0x183440370")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x344B430", Offset = "0x344A430", VA = "0x18344B430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int HBEHMEFLOII
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3441200", Offset = "0x3440200", VA = "0x183441200")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x344B5A0", Offset = "0x344A5A0", VA = "0x18344B5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int NNHHHMKKBBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x3443710", Offset = "0x3442710", VA = "0x183443710")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x344B4C0", Offset = "0x344A4C0", VA = "0x18344B4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int JAIBIHAADGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x3441200", Offset = "0x3440200", VA = "0x183441200")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x344B530", Offset = "0x344A530", VA = "0x18344B530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private static string MGPNHELOFBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xEFDAB0", Offset = "0xEFCAB0", VA = "0x180EFDAB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xEFE700", Offset = "0xEFD700", VA = "0x180EFE700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3449B90", Offset = "0x3448B90", VA = "0x183449B90")]
		protected AG_TMP_InputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3441BC0", Offset = "0x3440BC0", VA = "0x183441BC0")]
		protected void GNLDFFIHBNL(ref int IFAIDIKJOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3441280", Offset = "0x3440280", VA = "0x183441280")]
		protected void FOHLGFNFBHH(ref int IFAIDIKJOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x34477E0", Offset = "0x34467E0", VA = "0x1834477E0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x34470F0", Offset = "0x34460F0", VA = "0x1834470F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x343F4D0", Offset = "0x343E4D0", VA = "0x18343F4D0")]
		private void CIPAFIJGFPH(UnityEngine.Object NLNHFEEMFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3442040", Offset = "0x3441040", VA = "0x183442040")]
		[IteratorStateMachine(typeof(ABBELKNBPEB))]
		private IEnumerator IFLEEBBKHHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x343E120", Offset = "0x343D120", VA = "0x18343E120")]
		private void AMNPDKKBKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3440EC0", Offset = "0x343FEC0", VA = "0x183440EC0")]
		private void FINJJEAKJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3443990", Offset = "0x3442990", VA = "0x183443990")]
		protected void LKIDFHCFCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x34420A0", Offset = "0x34410A0", VA = "0x1834420A0")]
		protected void ILKEOLFCLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x34453E0", Offset = "0x34443E0", VA = "0x1834453E0")]
		public void MoveTextEnd(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x34455C0", Offset = "0x34445C0", VA = "0x1834455C0")]
		public void MoveTextStart(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3445740", Offset = "0x3444740", VA = "0x183445740")]
		public void MoveToEndOfLine(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3445930", Offset = "0x3444930", VA = "0x183445930")]
		public void MoveToStartOfLine(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3443050", Offset = "0x3442050", VA = "0x183443050")]
		private bool KKILEDOIHJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3444650", Offset = "0x3443650", VA = "0x183444650", Slot = "51")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3444580", Offset = "0x3443580", VA = "0x183444580")]
		private bool LPNBFDALPBB(PointerEventData OEKEOCOGKMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3447050", Offset = "0x3446050", VA = "0x183447050", Slot = "52")]
		public virtual void OnBeginDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3447400", Offset = "0x3446400", VA = "0x183447400", Slot = "53")]
		public virtual void OnDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x34417F0", Offset = "0x34407F0", VA = "0x1834417F0")]
		[IteratorStateMachine(typeof(HPAOCFBMJAC))]
		private IEnumerator GECGBFHNIHP(PointerEventData OEKEOCOGKMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3447E90", Offset = "0x3446E90", VA = "0x183447E90", Slot = "54")]
		public virtual void OnEndDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3447EF0", Offset = "0x3446EF0", VA = "0x183447EF0", Slot = "32")]
		public override void OnPointerDown(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3440470", Offset = "0x343F470", VA = "0x183440470")]
		protected JHEIPDKDOED ELNLABLFKNG(Event PFFGBOMIOHL)
		{
			return default(JHEIPDKDOED);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3442170", Offset = "0x3441170", VA = "0x183442170")]
		private bool JGOAIDFDMAD(char MBEHODBGOJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3449820", Offset = "0x3448820", VA = "0x183449820")]
		public void ProcessEvent(Event CHKKEHOKPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x34487B0", Offset = "0x34477B0", VA = "0x1834487B0", Slot = "55")]
		public virtual void OnUpdateSelected(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3448500", Offset = "0x3447500", VA = "0x183448500", Slot = "56")]
		public virtual void OnScroll(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x343DCE0", Offset = "0x343CCE0", VA = "0x18343DCE0")]
		private string AEAJLKEPNLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3448BE0", Offset = "0x3447BE0", VA = "0x183448BE0")]
		private int PIAEKONDGNG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x343ED80", Offset = "0x343DD80", VA = "0x18343ED80")]
		private void CCJLEGAFGKM(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x34412F0", Offset = "0x34402F0", VA = "0x1834412F0")]
		private int GADBOBOJIDE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3442A00", Offset = "0x3441A00", VA = "0x183442A00")]
		private void JLMEDGAJBEC(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x34408E0", Offset = "0x343F8E0", VA = "0x1834408E0")]
		private int FCKJFAJCNGD(int LBJOEJHPBJK, bool LJFNJIAKLFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x343D990", Offset = "0x343C990", VA = "0x18343D990")]
		private int AACOJNMNOGE(int LBJOEJHPBJK, bool MNNDCGNNAKB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3444D90", Offset = "0x3443D90", VA = "0x183444D90")]
		private int MJKECNILJFD(int LBJOEJHPBJK, bool LJFNJIAKLFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x34425D0", Offset = "0x34415D0", VA = "0x1834425D0")]
		private int JJCPPIAOHIM(int LBJOEJHPBJK, bool MNNDCGNNAKB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x34421C0", Offset = "0x34411C0", VA = "0x1834421C0")]
		private void JHHDGCMNMCN(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x34421D0", Offset = "0x34411D0", VA = "0x1834421D0")]
		private void JHHDGCMNMCN(bool DIHIAEIGDKB, bool MNNDCGNNAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3441BB0", Offset = "0x3440BB0", VA = "0x183441BB0")]
		private void GGFOEKLOLNI(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3441860", Offset = "0x3440860", VA = "0x183441860")]
		private void GGFOEKLOLNI(bool DIHIAEIGDKB, bool LJFNJIAKLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3449810", Offset = "0x3448810", VA = "0x183449810")]
		private void PNNDENFHNDI(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3449290", Offset = "0x3448290", VA = "0x183449290")]
		private void PNNDENFHNDI(bool DIHIAEIGDKB, bool LJFNJIAKLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3443700", Offset = "0x3442700", VA = "0x183443700")]
		private void LCGOPCFKIPP(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3443160", Offset = "0x3442160", VA = "0x183443160")]
		private void LCGOPCFKIPP(bool DIHIAEIGDKB, bool MNNDCGNNAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3448CF0", Offset = "0x3447CF0", VA = "0x183448CF0")]
		private void PKGAHIFGEII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3448910", Offset = "0x3447910", VA = "0x183448910")]
		private void PDHKGPEOBBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3444B10", Offset = "0x3443B10", VA = "0x183444B10")]
		private void MCMONKBJDEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x34451C0", Offset = "0x34441C0", VA = "0x1834451C0", Slot = "57")]
		protected virtual void MJLHLGCPKKA(string DBFBLNILIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3445270", Offset = "0x3444270", VA = "0x183445270", Slot = "58")]
		protected virtual void MJLHLGCPKKA(char DBFBLNILIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3440FC0", Offset = "0x343FFC0", VA = "0x183440FC0")]
		private void FLJBJJLIFHM(char MBEHODBGOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x343E300", Offset = "0x343D300", VA = "0x18343E300")]
		private void BHKGFMKCHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3441230", Offset = "0x3440230", VA = "0x183441230")]
		private void FNCJLCDOPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3448B90", Offset = "0x3447B90", VA = "0x183448B90")]
		protected void PFONIFOBNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3440F70", Offset = "0x343FF70", VA = "0x183440F70")]
		protected void FJLCFFGEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x343E2B0", Offset = "0x343D2B0", VA = "0x18343E2B0")]
		protected void BCDADBPHACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3441FF0", Offset = "0x3440FF0", VA = "0x183441FF0")]
		protected void HPALNDEIFIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x343F3B0", Offset = "0x343E3B0", VA = "0x18343F3B0")]
		protected void CDMKFBBJMDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3446F70", Offset = "0x3445F70", VA = "0x183446F70")]
		protected void ONPEDNNEFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3440C20", Offset = "0x343FC20", VA = "0x183440C20")]
		protected void FDGABBAAGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x34437A0", Offset = "0x34427A0", VA = "0x1834437A0")]
		private void LKFFKIONEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3444AB0", Offset = "0x3443AB0", VA = "0x183444AB0")]
		private void MBEGMCEEJNL(float ONGBFDACHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x343E3C0", Offset = "0x343D3C0", VA = "0x18343E3C0")]
		private void BPOLKAJBDOB(float LKGCBILJGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3442540", Offset = "0x3441540", VA = "0x183442540")]
		private int JIHIOHDMHDH(int FOCIACBBGKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3445B00", Offset = "0x3444B00", VA = "0x183445B00")]
		private int NNAEGEJNCLB(int LIMFKKIOJCM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x34412E0", Offset = "0x34402E0", VA = "0x1834412E0")]
		public void ForceLabelUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3441790", Offset = "0x3440790", VA = "0x183441790")]
		private void GCOEHHCNFIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3449830", Offset = "0x3448830", VA = "0x183449830", Slot = "59")]
		public virtual void Rebuild(CanvasUpdate JFKDDPJDCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0", Slot = "60")]
		public virtual void LayoutComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0", Slot = "61")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x34403A0", Offset = "0x343F3A0", VA = "0x1834403A0")]
		private void EGPBCLJAIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x343E5E0", Offset = "0x343D5E0", VA = "0x18343E5E0")]
		private void CCJJNIFEGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x34413E0", Offset = "0x34403E0", VA = "0x1834413E0")]
		private void GCGNCIIEDJM(Mesh LGFFBNOGPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3443A60", Offset = "0x3442A60", VA = "0x183443A60")]
		private void LKPJIACBDMI(VertexHelper LGFFBNOGPCN, Vector2 HHPJGFCCJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3441E60", Offset = "0x3440E60", VA = "0x183441E60")]
		private void HKNGBDDONBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3445B90", Offset = "0x3444B90", VA = "0x183445B90")]
		private void NPGMCAPEBPB(VertexHelper LGFFBNOGPCN, Vector2 HHPJGFCCJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x343F6A0", Offset = "0x343E6A0", VA = "0x18343F6A0")]
		private void CJDHPCLLGCP(Vector2 FMMMDFONBJG, float CHAKCELLLJD, bool LANOHNACEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3446850", Offset = "0x3445850", VA = "0x183446850")]
		protected char OKAAIIMAHLK(string PAANJCAOOAG, int IFAIDIKJOAC, char OEFNGECBJAP)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x343E160", Offset = "0x343D160", VA = "0x18343E160")]
		public void ActivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x343DDD0", Offset = "0x343CDD0", VA = "0x18343DDD0")]
		private void AGAHHMPPAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x34486C0", Offset = "0x34476C0", VA = "0x1834486C0", Slot = "36")]
		public override void OnSelect(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3447EC0", Offset = "0x3446EC0", VA = "0x183447EC0", Slot = "62")]
		public virtual void OnPointerClick(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0")]
		public void OnControlClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3440010", Offset = "0x343F010", VA = "0x183440010")]
		public void DeactivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3447080", Offset = "0x3446080", VA = "0x183447080", Slot = "37")]
		public override void OnDeselect(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3448720", Offset = "0x3447720", VA = "0x183448720", Slot = "63")]
		public virtual void OnSubmit(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3441C00", Offset = "0x3440C00", VA = "0x183441C00")]
		private void GNNGKJGDDLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x34439B0", Offset = "0x34429B0", VA = "0x1834439B0")]
		private void LKJOKADIOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x343FF80", Offset = "0x343EF80", VA = "0x18343FF80")]
		private void DOFNHJBBMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3448B20", Offset = "0x3447B20", VA = "0x183448B20")]
		private void PELNFKBIIFO(params TMP_InputField.ContentType[] BAEPNOGNECP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3443140", Offset = "0x3442140", VA = "0x183443140")]
		private void LBBBNGGBNBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x34430C0", Offset = "0x34420C0", VA = "0x1834430C0")]
		private void LBBBNGGBNBC(TMP_InputField.CharacterValidation HMCHFOILHPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3440340", Offset = "0x343F340", VA = "0x183440340", Slot = "26")]
		protected override void DoStateTransition(SelectionState GKNIHNHGBKC, bool BKDCBHDFBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x34499F0", Offset = "0x34489F0", VA = "0x1834499F0")]
		public void SetGlobalPointSize(float EGCPILNPLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3449900", Offset = "0x3448900", VA = "0x183449900")]
		public void SetGlobalFontAsset(TMP_FontAsset GCFIODLCCKD)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x470110", Offset = "0x46F110", VA = "0x180470110", Slot = "46")]
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
	[Cpp2IlInjected.Address(RVA = "0x101EF10", Offset = "0x101DF10", VA = "0x18101EF10")]
	public static bool LJAEIJLMDHG(ref Color MMHAEEACNOD, Color BCEFAKDFEMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2DED530", Offset = "0x2DEC530", VA = "0x182DED530")]
	public static bool LBFNDKHKFNH<T>(ref T MMHAEEACNOD, T BCEFAKDFEMM) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2DED710", Offset = "0x2DEC710", VA = "0x182DED710")]
	public static bool AKJLBMDKGMF<T>(ref T MMHAEEACNOD, T BCEFAKDFEMM) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2DED4E0", Offset = "0x2DEC4E0", VA = "0x182DED4E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x344C7B0", Offset = "0x344B7B0", VA = "0x18344C7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x792680", Offset = "0x791680", VA = "0x180792680")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9305F0", Offset = "0x92F5F0", VA = "0x1809305F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Color OADKADHJHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x50D8E0", Offset = "0x50C8E0", VA = "0x18050D8E0")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x50D8D0", Offset = "0x50C8D0", VA = "0x18050D8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public PPPKALBKBCI KNLKEEHCIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5083D0", Offset = "0x5073D0", VA = "0x1805083D0")]
		get
		{
			return default(PPPKALBKBCI);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x508CD0", Offset = "0x507CD0", VA = "0x180508CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public float BJJEDIGOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4539C0", Offset = "0x4529C0", VA = "0x1804539C0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4536F0", Offset = "0x4526F0", VA = "0x1804536F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool LPHAPKJLKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x47FC30", Offset = "0x47EC30", VA = "0x18047FC30", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x45AFE0", Offset = "0x459FE0", VA = "0x18045AFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x343AC30", Offset = "0x3439C30", VA = "0x18343AC30", Slot = "4")]
	public void LHDMGIMPNGF(float OKKKBODNINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x343AB90", Offset = "0x3439B90", VA = "0x18343AB90")]
	public void CJPIEOIKDAO(UnityAction<Color> AFLPGGJMPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x47FC30", Offset = "0x47EC30", VA = "0x18047FC30")]
	public bool EFGINMKOCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4539C0", Offset = "0x4529C0", VA = "0x1804539C0")]
	public float JPCNDKLEFFG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x9305E0", Offset = "0x92F5E0", VA = "0x1809305E0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x344BD20", Offset = "0x344AD20", VA = "0x18344BD20")]
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
		[Cpp2IlInjected.Address(RVA = "0x93BD00", Offset = "0x93AD00", VA = "0x18093BD00")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x93BD20", Offset = "0x93AD20", VA = "0x18093BD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public float NEACGKEPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x93BD10", Offset = "0x93AD10", VA = "0x18093BD10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x93BD30", Offset = "0x93AD30", VA = "0x18093BD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float BJJEDIGOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x451B00", Offset = "0x450B00", VA = "0x180451B00", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x451DB0", Offset = "0x450DB0", VA = "0x180451DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool LPHAPKJLKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5E0", Offset = "0x3EC5E0", VA = "0x1803ED5E0", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5C0", Offset = "0x3EC5C0", VA = "0x1803ED5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x344BB20", Offset = "0x344AB20", VA = "0x18344BB20", Slot = "4")]
	public void LHDMGIMPNGF(float OKKKBODNINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x344BA80", Offset = "0x344AA80", VA = "0x18344BA80")]
	public void CJPIEOIKDAO(UnityAction<float> AFLPGGJMPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5E0", Offset = "0x3EC5E0", VA = "0x1803ED5E0")]
	public bool EFGINMKOCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x451B00", Offset = "0x450B00", VA = "0x180451B00")]
	public float JPCNDKLEFFG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x9305E0", Offset = "0x92F5E0", VA = "0x1809305E0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xAE3D60", Offset = "0xAE2D60", VA = "0x180AE3D60")]
		[DebuggerHidden]
		public HLBKKOEPAKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2CAF070", Offset = "0x2CAE070", VA = "0x182CAF070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2CAF1A0", Offset = "0x2CAE1A0", VA = "0x182CAF1A0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CC0980", Offset = "0x2CBF980", VA = "0x182CC0980")]
	[IteratorStateMachine(typeof(global::OPBIENGHNOL<>.HLBKKOEPAKM))]
	private static IEnumerator HDGEHNGPFDO(T EPGPDBMBPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3E6240", Offset = "0x3E5240", VA = "0x1803E6240")]
	public void CALJLNMMIPN(MonoBehaviour CMIAMAJBJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2CC0820", Offset = "0x2CBF820", VA = "0x182CC0820")]
	public void FPPOJDJCJKI(T DBDDKLHPNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2CC0A70", Offset = "0x2CBFA70", VA = "0x182CC0A70")]
	public void KOAIIMHNKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x61E2F0", Offset = "0x61D2F0", VA = "0x18061E2F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x130C640", Offset = "0x130B640", VA = "0x18130C640")]
	public static List<T> IAHDANBDAAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x131B740", Offset = "0x131A740", VA = "0x18131B740")]
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
		[Cpp2IlInjected.Address(RVA = "0x5083D0", Offset = "0x5073D0", VA = "0x1805083D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x508CD0", Offset = "0x507CD0", VA = "0x180508CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int HHAOOLFNEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1311AA0", Offset = "0x1310AA0", VA = "0x181311AA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int LCPNJDNOAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x67A440", Offset = "0x679440", VA = "0x18067A440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5E60", Offset = "0x2CC4E60", VA = "0x182CC5E60")]
	public DMBLMECIJCJ(UnityAction<T> GOLBLHIPEDI, UnityAction<T> MJNKDEFIDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5C70", Offset = "0x2CC4C70", VA = "0x182CC5C70")]
	public T IAHDANBDAAM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5D60", Offset = "0x2CC4D60", VA = "0x182CC5D60")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E5020", Offset = "0x3E4020", VA = "0x1803E5020")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x344BD60", Offset = "0x344AD60", VA = "0x18344BD60")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x344BE60", Offset = "0x344AE60", VA = "0x18344BE60")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E5020", Offset = "0x3E4020", VA = "0x1803E5020")]
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
