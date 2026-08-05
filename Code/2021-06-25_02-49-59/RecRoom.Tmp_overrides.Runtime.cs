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
				[Cpp2IlInjected.Address(RVA = "0x3EFBD0", Offset = "0x3EEDD0", VA = "0x1803EFBD0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x3EFBF0", Offset = "0x3EEDF0", VA = "0x1803EFBF0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public Image IJKBAADKCBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x3EFBE0", Offset = "0x3EEDE0", VA = "0x1803EFBE0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x429AF0", Offset = "0x428CF0", VA = "0x180429AF0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RectTransform AIOEKMHLKAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x3F10F0", Offset = "0x3F02F0", VA = "0x1803F10F0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x3F0030", Offset = "0x3EF230", VA = "0x1803F0030")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Toggle MJDKJADPGIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x3FD030", Offset = "0x3FC230", VA = "0x1803FD030")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x3F0010", Offset = "0x3EF210", VA = "0x1803F0010")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2BF70D0", Offset = "0x2BF62D0", VA = "0x182BF70D0", Slot = "6")]
			public virtual void OnPointerEnter(PointerEventData OEKEOCOGKMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7040", Offset = "0x2BF6240", VA = "0x182BF7040", Slot = "7")]
			public virtual void OnCancel(BaseEventData OEKEOCOGKMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x787D00", Offset = "0x786F00", VA = "0x180787D00")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E1000", Offset = "0x3E0200", VA = "0x1803E1000")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x3EFC00", Offset = "0x3EEE00", VA = "0x1803EFC00")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public Sprite image
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x3EFBD0", Offset = "0x3EEDD0", VA = "0x1803EFBD0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x3EFBF0", Offset = "0x3EEDF0", VA = "0x1803EFBF0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3E8C80", Offset = "0x3E7E80", VA = "0x1803E8C80")]
			public OptionData()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF200", Offset = "0x3FE400", VA = "0x1803FF200")]
			public OptionData(string PAANJCAOOAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x49FDF0", Offset = "0x49EFF0", VA = "0x18049FDF0")]
			public OptionData(Sprite IJKBAADKCBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3FE2E0", Offset = "0x3FD4E0", VA = "0x1803FE2E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E1000", Offset = "0x3E0200", VA = "0x1803E1000")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x3EFC00", Offset = "0x3EEE00", VA = "0x1803EFC00")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7B80", Offset = "0x2BF6D80", VA = "0x182BF7B80")]
			public OptionDataList()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public class DropdownEvent : UnityEvent<int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7000", Offset = "0x2BF6200", VA = "0x182BF7000")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E8C80", Offset = "0x3E7E80", VA = "0x1803E8C80")]
			public DCMBNBJLLKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6E80", Offset = "0x2BF6080", VA = "0x182BF6E80")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EFBD0", Offset = "0x3EEDD0", VA = "0x1803EFBD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EFBD0", Offset = "0x3EEDD0", VA = "0x1803EFBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x422A30", Offset = "0x421C30", VA = "0x180422A30")]
			[DebuggerHidden]
			public OMHNBHFCIHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3E7820", Offset = "0x3E6A20", VA = "0x1803E7820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7A40", Offset = "0x2BF6C40", VA = "0x182BF7A40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7AF0", Offset = "0x2BF6CF0", VA = "0x182BF7AF0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E1CC0", Offset = "0x7E0EC0", VA = "0x1807E1CC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2BE8CB0", Offset = "0x2BE7EB0", VA = "0x182BE8CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TMP_Text GNPFHIKGONC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x67C7A0", Offset = "0x67B9A0", VA = "0x18067C7A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x2BE8C50", Offset = "0x2BE7E50", VA = "0x182BE8C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Image FADBPBIJPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7E1E70", Offset = "0x7E1070", VA = "0x1807E1E70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2BE8C40", Offset = "0x2BE7E40", VA = "0x182BE8C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public TMP_Text IJANOFBIFGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7E1DE0", Offset = "0x7E0FE0", VA = "0x1807E1DE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2BE8C70", Offset = "0x2BE7E70", VA = "0x182BE8C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Image CECFEBFHOBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7E0C20", Offset = "0x7DFE20", VA = "0x1807E0C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2BE8C60", Offset = "0x2BE7E60", VA = "0x182BE8C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public List<OptionData> JJAPBNJPPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x15A9540", Offset = "0x15A8740", VA = "0x1815A9540")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BE8C80", Offset = "0x2BE7E80", VA = "0x182BE8C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public DropdownEvent CCHCBCLCFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7E1CD0", Offset = "0x7E0ED0", VA = "0x1807E1CD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC84D90", Offset = "0xC83F90", VA = "0x180C84D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int ONGBFDACHHG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB13CF0", Offset = "0xB12EF0", VA = "0x180B13CF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2BE8CC0", Offset = "0x2BE7EC0", VA = "0x182BE8CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PHOKNNFACHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2BE8B90", Offset = "0x2BE7D90", VA = "0x182BE8B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HACBIOINOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2BE8BF0", Offset = "0x2BE7DF0", VA = "0x182BE8BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8A60", Offset = "0x2BE7C60", VA = "0x182BE8A60")]
		protected AG_TMP_Dropdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BE65F0", Offset = "0x2BE57F0", VA = "0x182BE65F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7A40", Offset = "0x2BE6C40", VA = "0x182BE7A40")]
		public void RefreshShownValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6490", Offset = "0x2BE5690", VA = "0x182BE6490")]
		public void AddOptions(List<OptionData> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BE63A0", Offset = "0x2BE55A0", VA = "0x182BE63A0")]
		public void AddOptions(List<string> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6500", Offset = "0x2BE5700", VA = "0x182BE6500")]
		public void AddOptions(List<Sprite> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6750", Offset = "0x2BE5950", VA = "0x182BE6750")]
		public void ClearOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE67B0", Offset = "0x2BE59B0", VA = "0x182BE67B0")]
		private void HKAJJALGMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x12C37A0", Offset = "0x12C29A0", VA = "0x1812C37A0")]
		private static T GLENGLDKGCK<T>(GameObject NNNMGKGMIFG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7A30", Offset = "0x2BE6C30", VA = "0x182BE7A30", Slot = "42")]
		public virtual void OnPointerClick(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7A30", Offset = "0x2BE6C30", VA = "0x182BE7A30", Slot = "43")]
		public virtual void OnSubmit(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7A20", Offset = "0x2BE6C20", VA = "0x182BE7A20", Slot = "44")]
		public virtual void OnCancel(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7C60", Offset = "0x2BE6E60", VA = "0x182BE7C60")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2BE73A0", Offset = "0x2BE65A0", VA = "0x182BE73A0", Slot = "45")]
		protected virtual GameObject MLONLGOJHEF(Canvas GGEDDFLMJHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6150", Offset = "0x2BE5350", VA = "0x182BE6150", Slot = "46")]
		protected virtual void AMGBINMEKLB(GameObject HJPGLBGMCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7340", Offset = "0x2BE6540", VA = "0x182BE7340", Slot = "47")]
		protected virtual GameObject MKDGFAJHFPI(GameObject KHKGJGPIIAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BE78A0", Offset = "0x2BE6AA0", VA = "0x182BE78A0", Slot = "48")]
		protected virtual void NPDNDADJNJG(GameObject AFFMGNGGCEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BE72E0", Offset = "0x2BE64E0", VA = "0x182BE72E0", Slot = "49")]
		protected virtual DropdownItem JIJOIMHCMAE(DropdownItem FOIOJEEDDCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E7820", Offset = "0x3E6A20", VA = "0x1803E7820", Slot = "50")]
		protected virtual void HOMLPHHMJEL(DropdownItem IOBEPGLJNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7030", Offset = "0x2BE6230", VA = "0x182BE7030")]
		private DropdownItem ICFDCCEPJDL(OptionData ABADFLCBFIJ, bool EGJJHJHIPCF, DropdownItem FOIOJEEDDCI, List<DropdownItem> BOOHBJEEGKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7650", Offset = "0x2BE6850", VA = "0x182BE7650")]
		private void NOHLFCGKAPE(float BJJEDIGOMGC, float FBPFONBFPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BE76E0", Offset = "0x2BE68E0", VA = "0x182BE76E0")]
		private void NOHLFCGKAPE(float BJJEDIGOMGC, float FKGCMPGAIAP, float KOFMGJJCPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7970", Offset = "0x2BE6B70", VA = "0x182BE7970")]
		private void OOOAOJDCEHN(float FBPFONBFPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6E80", Offset = "0x2BE6080", VA = "0x182BE6E80")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6C90", Offset = "0x2BE5E90", VA = "0x182BE6C90")]
		public void HideImmediately()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7900", Offset = "0x2BE6B00", VA = "0x182BE7900")]
		[IteratorStateMachine(typeof(OMHNBHFCIHJ))]
		private IEnumerator OENONJDLMPC(float NBOCPMDNOCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE61B0", Offset = "0x2BE53B0", VA = "0x182BE61B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BF7C60", Offset = "0x2BF6E60", VA = "0x182BF7C60")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7B40", Offset = "0x2BF6D40", VA = "0x182BF7B40")]
			public OnChangeEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class SelectionEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7C20", Offset = "0x2BF6E20", VA = "0x182BF7C20")]
			public SelectionEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7CA0", Offset = "0x2BF6EA0", VA = "0x182BF7CA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EFBD0", Offset = "0x3EEDD0", VA = "0x1803EFBD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EFBD0", Offset = "0x3EEDD0", VA = "0x1803EFBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x422A30", Offset = "0x421C30", VA = "0x180422A30")]
			[DebuggerHidden]
			public ABBELKNBPEB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3E7820", Offset = "0x3E6A20", VA = "0x1803E7820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2BE5E50", Offset = "0x2BE5050", VA = "0x182BE5E50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x2BE5F70", Offset = "0x2BE5170", VA = "0x182BE5F70", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EFBD0", Offset = "0x3EEDD0", VA = "0x1803EFBD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EFBD0", Offset = "0x3EEDD0", VA = "0x1803EFBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x422A30", Offset = "0x421C30", VA = "0x180422A30")]
			[DebuggerHidden]
			public HPAOCFBMJAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3E7820", Offset = "0x3E6A20", VA = "0x1803E7820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7770", Offset = "0x2BF6970", VA = "0x182BF7770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x2BF79F0", Offset = "0x2BF6BF0", VA = "0x182BF79F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BF5340", Offset = "0x2BF4540", VA = "0x182BF5340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public TouchScreenKeyboard.Status AAMIDBCKMFN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x178DD40", Offset = "0x178CF40", VA = "0x18178DD40")]
			[CompilerGenerated]
			get
			{
				return default(TouchScreenKeyboard.Status);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x178E1F0", Offset = "0x178D3F0", VA = "0x18178E1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TouchScreenKeyboard MFCBKLKENCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x67C7A0", Offset = "0x67B9A0", VA = "0x18067C7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string AJBKBJKLGEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7E1C50", Offset = "0x7E0E50", VA = "0x1807E1C50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5550", Offset = "0x2BF4750", VA = "0x182BF5550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected Mesh EDLHNCIENFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x2BE9960", Offset = "0x2BE8B60", VA = "0x182BE9960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool AKNGFFLFKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5500", Offset = "0x2BF4700", VA = "0x182BF5500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string PAANJCAOOAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x79A130", Offset = "0x799330", VA = "0x18079A130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6B30", Offset = "0x2BF5D30", VA = "0x182BF6B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool LMHGKGKNCDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5470", Offset = "0x2BF4670", VA = "0x182BF5470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float HDBOICOPFPG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2BF53C0", Offset = "0x2BF45C0", VA = "0x182BF53C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5600", Offset = "0x2BF4800", VA = "0x182BF5600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int NBLMMLPFCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5430", Offset = "0x2BF4630", VA = "0x182BF5430")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5830", Offset = "0x2BF4A30", VA = "0x182BF5830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RectTransform DAMCEBLMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7E1E70", Offset = "0x7E1070", VA = "0x1807E1E70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6AE0", Offset = "0x2BF5CE0", VA = "0x182BF6AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TMP_Text GAOOAKOACIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7E1DE0", Offset = "0x7E0FE0", VA = "0x1807E1DE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6A90", Offset = "0x2BF5C90", VA = "0x182BF6A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Graphic NFNFFNAHAPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D90", Offset = "0x7DFF90", VA = "0x1807E0D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6410", Offset = "0x2BF5610", VA = "0x182BF6410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Scrollbar DMEHABPKKAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7E1CD0", Offset = "0x7E0ED0", VA = "0x1807E1CD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6C50", Offset = "0x2BF5E50", VA = "0x182BF6C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float PAKOCGKNBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xB10320", Offset = "0xB0F520", VA = "0x180B10320")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6680", Offset = "0x2BF5880", VA = "0x182BF6680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color DLGIEJOLHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2BF53D0", Offset = "0x2BF45D0", VA = "0x182BF53D0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5670", Offset = "0x2BF4870", VA = "0x182BF5670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool PHKEONAKJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xDE05F0", Offset = "0xDDF7F0", VA = "0x180DE05F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5C80", Offset = "0x2BF4E80", VA = "0x182BF5C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Color DDOJNMCKCKN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2BF54F0", Offset = "0x2BF46F0", VA = "0x182BF54F0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2BF67B0", Offset = "0x2BF59B0", VA = "0x182BF67B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public SubmitEvent BGNEEOKFCGC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7E1BA0", Offset = "0x7E0DA0", VA = "0x1807E1BA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2BF61E0", Offset = "0x2BF53E0", VA = "0x182BF61E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public SubmitEvent DKKHDPBJKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7E21A0", Offset = "0x7E13A0", VA = "0x1807E21A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2BF62D0", Offset = "0x2BF54D0", VA = "0x182BF62D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public SelectionEvent BCHLJNBPNPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xBF5E00", Offset = "0xBF5000", VA = "0x180BF5E00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6280", Offset = "0x2BF5480", VA = "0x182BF6280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public SelectionEvent LJPBJFEFDKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x6762C0", VA = "0x1806770C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6190", Offset = "0x2BF5390", VA = "0x182BF6190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TextSelectionEvent ENMOLJBNAHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x676E40", Offset = "0x676040", VA = "0x180676E40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6320", Offset = "0x2BF5520", VA = "0x182BF6320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public TextSelectionEvent HHAPBEDJKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D70", Offset = "0x7DFF70", VA = "0x1807E0D70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6230", Offset = "0x2BF5430", VA = "0x182BF6230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public OnChangeEvent CCHCBCLCFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7E2080", Offset = "0x7E1280", VA = "0x1807E2080")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2BF63C0", Offset = "0x2BF55C0", VA = "0x182BF63C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public CCNHIOBEBOA KFGGMLKECGK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xC82840", Offset = "0xC81A40", VA = "0x180C82840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6370", Offset = "0x2BF5570", VA = "0x182BF6370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int DIDPKDLHNBN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5440", Offset = "0x2BF4640", VA = "0x182BF5440")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2BF58D0", Offset = "0x2BF4AD0", VA = "0x182BF58D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float EGCPILNPLKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2BF54B0", Offset = "0x2BF46B0", VA = "0x182BF54B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6460", Offset = "0x2BF5660", VA = "0x182BF6460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TMP_FontAsset GCFIODLCCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7D9140", Offset = "0x7D8340", VA = "0x1807D9140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5CF0", Offset = "0x2BF4EF0", VA = "0x182BF5CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LACLMELLCGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x14CE450", Offset = "0x14CD650", VA = "0x1814CE450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x14BDFB0", Offset = "0x14BD1B0", VA = "0x1814BDFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool CEHNEGPAGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x2BF54C0", Offset = "0x2BF46C0", VA = "0x182BF54C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x2BF65D0", Offset = "0x2BF57D0", VA = "0x182BF65D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CHEGLKKIPBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x2BF54D0", Offset = "0x2BF46D0", VA = "0x182BF54D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2BF65E0", Offset = "0x2BF57E0", VA = "0x182BF65E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool KAAIKJLFGFP
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5480", Offset = "0x2BF4680", VA = "0x182BF5480")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5FB0", Offset = "0x2BF51B0", VA = "0x182BF5FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PCKCCEOPIGL
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5530", Offset = "0x2BF4730", VA = "0x182BF5530")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6C40", Offset = "0x2BF5E40", VA = "0x182BF6C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool NCAFECJAAEC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5330", Offset = "0x2BF4530", VA = "0x182BF5330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TMP_InputField.ContentType KCKBKEKAMDF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x67C2D0", Offset = "0x67B4D0", VA = "0x18067C2D0")]
			get
			{
				return default(TMP_InputField.ContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2BF59D0", Offset = "0x2BF4BD0", VA = "0x182BF59D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public TMP_InputField.LineType PLOPNEGDJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xBF5950", Offset = "0xBF4B50", VA = "0x180BF5950")]
			get
			{
				return default(TMP_InputField.LineType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6030", Offset = "0x2BF5230", VA = "0x182BF6030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public TMP_InputField.InputType KJNDMFLHLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x67C5F0", Offset = "0x67B7F0", VA = "0x18067C5F0")]
			get
			{
				return default(TMP_InputField.InputType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5E80", Offset = "0x2BF5080", VA = "0x182BF5E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TouchScreenKeyboardType MLFHHNNDOEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9131F0", Offset = "0x9123F0", VA = "0x1809131F0")]
			get
			{
				return default(TouchScreenKeyboardType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5FC0", Offset = "0x2BF51C0", VA = "0x182BF5FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TMP_InputField.CharacterValidation HMCHFOILHPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x136D4D0", Offset = "0x136C6D0", VA = "0x18136D4D0")]
			get
			{
				return default(TMP_InputField.CharacterValidation);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5960", Offset = "0x2BF4B60", VA = "0x182BF5960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TMP_InputValidator EPPLBJHBEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5460", Offset = "0x2BF4660", VA = "0x182BF5460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5EF0", Offset = "0x2BF50F0", VA = "0x182BF5EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Func<string, bool> GOLGMHKKGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5450", Offset = "0x2BF4650", VA = "0x182BF5450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5E30", Offset = "0x2BF5030", VA = "0x182BF5E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool BGNEPFGDKHB
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x21E79E0", Offset = "0x21E6BE0", VA = "0x1821E79E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2BF65C0", Offset = "0x2BF57C0", VA = "0x182BF65C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool DAAFDDDHEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BF54E0", Offset = "0x2BF46E0", VA = "0x182BF54E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2BF65F0", Offset = "0x2BF57F0", VA = "0x182BF65F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool BBKJPKCMMNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5490", Offset = "0x2BF4690", VA = "0x182BF5490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public char EHGCPACOOKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2BF53B0", Offset = "0x2BF45B0", VA = "0x182BF53B0")]
			get
			{
				return default(char);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2BF55A0", Offset = "0x2BF47A0", VA = "0x182BF55A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool BFMGMGGLHKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5540", Offset = "0x2BF4740", VA = "0x182BF5540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected int CHFEODECIBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2BF2370", Offset = "0x2BF1570", VA = "0x182BF2370")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2BEEB70", Offset = "0x2BEDD70", VA = "0x182BEEB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected int JDLAOAEIGBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2BEEB40", Offset = "0x2BEDD40", VA = "0x182BEEB40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2BEE430", Offset = "0x2BED630", VA = "0x182BEE430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected int OJEPKIDOLDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB7A0", Offset = "0x2BEA9A0", VA = "0x182BEB7A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2BE9790", Offset = "0x2BE8990", VA = "0x182BE9790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected int BJKFMKDBNJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2BEC630", Offset = "0x2BEB830", VA = "0x182BEC630")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2BED550", Offset = "0x2BEC750", VA = "0x182BED550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool HHBIHFPBPEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x2BEA8A0", Offset = "0x2BE9AA0", VA = "0x182BEA8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int LIMFKKIOJCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB7A0", Offset = "0x2BEA9A0", VA = "0x182BEB7A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5720", Offset = "0x2BF4920", VA = "0x182BF5720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public int GALHKIEDLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2BF2370", Offset = "0x2BF1570", VA = "0x182BF2370")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6720", Offset = "0x2BF5920", VA = "0x182BF6720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int JIFIJDPPPFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB7A0", Offset = "0x2BEA9A0", VA = "0x182BEB7A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6860", Offset = "0x2BF5A60", VA = "0x182BF6860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int HBEHMEFLOII
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x2BEC630", Offset = "0x2BEB830", VA = "0x182BEC630")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x2BF69D0", Offset = "0x2BF5BD0", VA = "0x182BF69D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int NNHHHMKKBBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x2BEEB40", Offset = "0x2BEDD40", VA = "0x182BEEB40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2BF68F0", Offset = "0x2BF5AF0", VA = "0x182BF68F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int JAIBIHAADGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x2BEC630", Offset = "0x2BEB830", VA = "0x182BEC630")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6960", Offset = "0x2BF5B60", VA = "0x182BF6960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private static string MGPNHELOFBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x15BF950", Offset = "0x15BEB50", VA = "0x1815BF950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x15C04B0", Offset = "0x15BF6B0", VA = "0x1815C04B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4FC0", Offset = "0x2BF41C0", VA = "0x182BF4FC0")]
		protected AG_TMP_InputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2BECFF0", Offset = "0x2BEC1F0", VA = "0x182BECFF0")]
		protected void GNLDFFIHBNL(ref int IFAIDIKJOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC6B0", Offset = "0x2BEB8B0", VA = "0x182BEC6B0")]
		protected void FOHLGFNFBHH(ref int IFAIDIKJOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2BF2C10", Offset = "0x2BF1E10", VA = "0x182BF2C10", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BF2520", Offset = "0x2BF1720", VA = "0x182BF2520", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2BEA900", Offset = "0x2BE9B00", VA = "0x182BEA900")]
		private void CIPAFIJGFPH(UnityEngine.Object NLNHFEEMFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2BED470", Offset = "0x2BEC670", VA = "0x182BED470")]
		[IteratorStateMachine(typeof(ABBELKNBPEB))]
		private IEnumerator IFLEEBBKHHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9550", Offset = "0x2BE8750", VA = "0x182BE9550")]
		private void AMNPDKKBKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC2F0", Offset = "0x2BEB4F0", VA = "0x182BEC2F0")]
		private void FINJJEAKJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2BEEDC0", Offset = "0x2BEDFC0", VA = "0x182BEEDC0")]
		protected void LKIDFHCFCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2BED4D0", Offset = "0x2BEC6D0", VA = "0x182BED4D0")]
		protected void ILKEOLFCLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0810", Offset = "0x2BEFA10", VA = "0x182BF0810")]
		public void MoveTextEnd(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2BF09F0", Offset = "0x2BEFBF0", VA = "0x182BF09F0")]
		public void MoveTextStart(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0B70", Offset = "0x2BEFD70", VA = "0x182BF0B70")]
		public void MoveToEndOfLine(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0D60", Offset = "0x2BEFF60", VA = "0x182BF0D60")]
		public void MoveToStartOfLine(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BEE480", Offset = "0x2BED680", VA = "0x182BEE480")]
		private bool KKILEDOIHJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BEFA80", Offset = "0x2BEEC80", VA = "0x182BEFA80", Slot = "51")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF9B0", Offset = "0x2BEEBB0", VA = "0x182BEF9B0")]
		private bool LPNBFDALPBB(PointerEventData OEKEOCOGKMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BF2480", Offset = "0x2BF1680", VA = "0x182BF2480", Slot = "52")]
		public virtual void OnBeginDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BF2830", Offset = "0x2BF1A30", VA = "0x182BF2830", Slot = "53")]
		public virtual void OnDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BECC20", Offset = "0x2BEBE20", VA = "0x182BECC20")]
		[IteratorStateMachine(typeof(HPAOCFBMJAC))]
		private IEnumerator GECGBFHNIHP(PointerEventData OEKEOCOGKMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BF32C0", Offset = "0x2BF24C0", VA = "0x182BF32C0", Slot = "54")]
		public virtual void OnEndDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BF3320", Offset = "0x2BF2520", VA = "0x182BF3320", Slot = "32")]
		public override void OnPointerDown(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BEB8A0", Offset = "0x2BEAAA0", VA = "0x182BEB8A0")]
		protected JHEIPDKDOED ELNLABLFKNG(Event PFFGBOMIOHL)
		{
			return default(JHEIPDKDOED);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BED5A0", Offset = "0x2BEC7A0", VA = "0x182BED5A0")]
		private bool JGOAIDFDMAD(char MBEHODBGOJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4C50", Offset = "0x2BF3E50", VA = "0x182BF4C50")]
		public void ProcessEvent(Event CHKKEHOKPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BF3BE0", Offset = "0x2BF2DE0", VA = "0x182BF3BE0", Slot = "55")]
		public virtual void OnUpdateSelected(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BF3930", Offset = "0x2BF2B30", VA = "0x182BF3930", Slot = "56")]
		public virtual void OnScroll(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9110", Offset = "0x2BE8310", VA = "0x182BE9110")]
		private string AEAJLKEPNLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4010", Offset = "0x2BF3210", VA = "0x182BF4010")]
		private int PIAEKONDGNG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BEA1B0", Offset = "0x2BE93B0", VA = "0x182BEA1B0")]
		private void CCJLEGAFGKM(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC720", Offset = "0x2BEB920", VA = "0x182BEC720")]
		private int GADBOBOJIDE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2BEDE30", Offset = "0x2BED030", VA = "0x182BEDE30")]
		private void JLMEDGAJBEC(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BEBD10", Offset = "0x2BEAF10", VA = "0x182BEBD10")]
		private int FCKJFAJCNGD(int LBJOEJHPBJK, bool LJFNJIAKLFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8DC0", Offset = "0x2BE7FC0", VA = "0x182BE8DC0")]
		private int AACOJNMNOGE(int LBJOEJHPBJK, bool MNNDCGNNAKB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2BF01C0", Offset = "0x2BEF3C0", VA = "0x182BF01C0")]
		private int MJKECNILJFD(int LBJOEJHPBJK, bool LJFNJIAKLFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2BEDA00", Offset = "0x2BECC00", VA = "0x182BEDA00")]
		private int JJCPPIAOHIM(int LBJOEJHPBJK, bool MNNDCGNNAKB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BED5F0", Offset = "0x2BEC7F0", VA = "0x182BED5F0")]
		private void JHHDGCMNMCN(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BED600", Offset = "0x2BEC800", VA = "0x182BED600")]
		private void JHHDGCMNMCN(bool DIHIAEIGDKB, bool MNNDCGNNAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BECFE0", Offset = "0x2BEC1E0", VA = "0x182BECFE0")]
		private void GGFOEKLOLNI(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2BECC90", Offset = "0x2BEBE90", VA = "0x182BECC90")]
		private void GGFOEKLOLNI(bool DIHIAEIGDKB, bool LJFNJIAKLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4C40", Offset = "0x2BF3E40", VA = "0x182BF4C40")]
		private void PNNDENFHNDI(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2BF46C0", Offset = "0x2BF38C0", VA = "0x182BF46C0")]
		private void PNNDENFHNDI(bool DIHIAEIGDKB, bool LJFNJIAKLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BEEB30", Offset = "0x2BEDD30", VA = "0x182BEEB30")]
		private void LCGOPCFKIPP(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BEE590", Offset = "0x2BED790", VA = "0x182BEE590")]
		private void LCGOPCFKIPP(bool DIHIAEIGDKB, bool MNNDCGNNAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4120", Offset = "0x2BF3320", VA = "0x182BF4120")]
		private void PKGAHIFGEII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BF3D40", Offset = "0x2BF2F40", VA = "0x182BF3D40")]
		private void PDHKGPEOBBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BEFF40", Offset = "0x2BEF140", VA = "0x182BEFF40")]
		private void MCMONKBJDEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BF05F0", Offset = "0x2BEF7F0", VA = "0x182BF05F0", Slot = "57")]
		protected virtual void MJLHLGCPKKA(string DBFBLNILIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2BF06A0", Offset = "0x2BEF8A0", VA = "0x182BF06A0", Slot = "58")]
		protected virtual void MJLHLGCPKKA(char DBFBLNILIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC3F0", Offset = "0x2BEB5F0", VA = "0x182BEC3F0")]
		private void FLJBJJLIFHM(char MBEHODBGOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9730", Offset = "0x2BE8930", VA = "0x182BE9730")]
		private void BHKGFMKCHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC660", Offset = "0x2BEB860", VA = "0x182BEC660")]
		private void FNCJLCDOPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BF3FC0", Offset = "0x2BF31C0", VA = "0x182BF3FC0")]
		protected void PFONIFOBNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC3A0", Offset = "0x2BEB5A0", VA = "0x182BEC3A0")]
		protected void FJLCFFGEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BE96E0", Offset = "0x2BE88E0", VA = "0x182BE96E0")]
		protected void BCDADBPHACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BED420", Offset = "0x2BEC620", VA = "0x182BED420")]
		protected void HPALNDEIFIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BEA7E0", Offset = "0x2BE99E0", VA = "0x182BEA7E0")]
		protected void CDMKFBBJMDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BF23A0", Offset = "0x2BF15A0", VA = "0x182BF23A0")]
		protected void ONPEDNNEFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC050", Offset = "0x2BEB250", VA = "0x182BEC050")]
		protected void FDGABBAAGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BEEBD0", Offset = "0x2BEDDD0", VA = "0x182BEEBD0")]
		private void LKFFKIONEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BEFEE0", Offset = "0x2BEF0E0", VA = "0x182BEFEE0")]
		private void MBEGMCEEJNL(float ONGBFDACHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BE97F0", Offset = "0x2BE89F0", VA = "0x182BE97F0")]
		private void BPOLKAJBDOB(float LKGCBILJGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2BED970", Offset = "0x2BECB70", VA = "0x182BED970")]
		private int JIHIOHDMHDH(int FOCIACBBGKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0F30", Offset = "0x2BF0130", VA = "0x182BF0F30")]
		private int NNAEGEJNCLB(int LIMFKKIOJCM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC710", Offset = "0x2BEB910", VA = "0x182BEC710")]
		public void ForceLabelUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BECBC0", Offset = "0x2BEBDC0", VA = "0x182BECBC0")]
		private void GCOEHHCNFIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4C60", Offset = "0x2BF3E60", VA = "0x182BF4C60", Slot = "59")]
		public virtual void Rebuild(CanvasUpdate JFKDDPJDCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E7820", Offset = "0x3E6A20", VA = "0x1803E7820", Slot = "60")]
		public virtual void LayoutComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3E7820", Offset = "0x3E6A20", VA = "0x1803E7820", Slot = "61")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BEB7D0", Offset = "0x2BEA9D0", VA = "0x182BEB7D0")]
		private void EGPBCLJAIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9A10", Offset = "0x2BE8C10", VA = "0x182BE9A10")]
		private void CCJJNIFEGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC810", Offset = "0x2BEBA10", VA = "0x182BEC810")]
		private void GCGNCIIEDJM(Mesh LGFFBNOGPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2BEEE90", Offset = "0x2BEE090", VA = "0x182BEEE90")]
		private void LKPJIACBDMI(VertexHelper LGFFBNOGPCN, Vector2 HHPJGFCCJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BED290", Offset = "0x2BEC490", VA = "0x182BED290")]
		private void HKNGBDDONBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0FC0", Offset = "0x2BF01C0", VA = "0x182BF0FC0")]
		private void NPGMCAPEBPB(VertexHelper LGFFBNOGPCN, Vector2 HHPJGFCCJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BEAAD0", Offset = "0x2BE9CD0", VA = "0x182BEAAD0")]
		private void CJDHPCLLGCP(Vector2 FMMMDFONBJG, float CHAKCELLLJD, bool LANOHNACEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BF1C80", Offset = "0x2BF0E80", VA = "0x182BF1C80")]
		protected char OKAAIIMAHLK(string PAANJCAOOAG, int IFAIDIKJOAC, char OEFNGECBJAP)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9590", Offset = "0x2BE8790", VA = "0x182BE9590")]
		public void ActivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9200", Offset = "0x2BE8400", VA = "0x182BE9200")]
		private void AGAHHMPPAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BF3AF0", Offset = "0x2BF2CF0", VA = "0x182BF3AF0", Slot = "36")]
		public override void OnSelect(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BF32F0", Offset = "0x2BF24F0", VA = "0x182BF32F0", Slot = "62")]
		public virtual void OnPointerClick(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7820", Offset = "0x3E6A20", VA = "0x1803E7820")]
		public void OnControlClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BEB440", Offset = "0x2BEA640", VA = "0x182BEB440")]
		public void DeactivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BF24B0", Offset = "0x2BF16B0", VA = "0x182BF24B0", Slot = "37")]
		public override void OnDeselect(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BF3B50", Offset = "0x2BF2D50", VA = "0x182BF3B50", Slot = "63")]
		public virtual void OnSubmit(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BED030", Offset = "0x2BEC230", VA = "0x182BED030")]
		private void GNNGKJGDDLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2BEEDE0", Offset = "0x2BEDFE0", VA = "0x182BEEDE0")]
		private void LKJOKADIOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2BEB3B0", Offset = "0x2BEA5B0", VA = "0x182BEB3B0")]
		private void DOFNHJBBMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2BF3F50", Offset = "0x2BF3150", VA = "0x182BF3F50")]
		private void PELNFKBIIFO(params TMP_InputField.ContentType[] BAEPNOGNECP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2BEE570", Offset = "0x2BED770", VA = "0x182BEE570")]
		private void LBBBNGGBNBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2BEE4F0", Offset = "0x2BED6F0", VA = "0x182BEE4F0")]
		private void LBBBNGGBNBC(TMP_InputField.CharacterValidation HMCHFOILHPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2BEB770", Offset = "0x2BEA970", VA = "0x182BEB770", Slot = "26")]
		protected override void DoStateTransition(SelectionState GKNIHNHGBKC, bool BKDCBHDFBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4E20", Offset = "0x2BF4020", VA = "0x182BF4E20")]
		public void SetGlobalPointSize(float EGCPILNPLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4D30", Offset = "0x2BF3F30", VA = "0x182BF4D30")]
		public void SetGlobalFontAsset(TMP_FontAsset GCFIODLCCKD)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9C6360", Offset = "0x9C5560", VA = "0x1809C6360", Slot = "46")]
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
	[Cpp2IlInjected.Address(RVA = "0x15A1060", Offset = "0x15A0260", VA = "0x1815A1060")]
	public static bool LJAEIJLMDHG(ref Color MMHAEEACNOD, Color BCEFAKDFEMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8170", Offset = "0x1AC7370", VA = "0x181AC8170")]
	public static bool LBFNDKHKFNH<T>(ref T MMHAEEACNOD, T BCEFAKDFEMM) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8350", Offset = "0x1AC7550", VA = "0x181AC8350")]
	public static bool AKJLBMDKGMF<T>(ref T MMHAEEACNOD, T BCEFAKDFEMM) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8120", Offset = "0x1AC7320", VA = "0x181AC8120")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BF7BE0", Offset = "0x2BF6DE0", VA = "0x182BF7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x159E690", Offset = "0x159D890", VA = "0x18159E690")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x786E50", Offset = "0x786050", VA = "0x180786E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Color OADKADHJHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4894A0", Offset = "0x4886A0", VA = "0x1804894A0")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8351A0", Offset = "0x8343A0", VA = "0x1808351A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public PPPKALBKBCI KNLKEEHCIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3FD040", Offset = "0x3FC240", VA = "0x1803FD040")]
		get
		{
			return default(PPPKALBKBCI);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x42FD80", Offset = "0x42EF80", VA = "0x18042FD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public float BJJEDIGOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x813CA0", Offset = "0x812EA0", VA = "0x180813CA0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x813CB0", Offset = "0x812EB0", VA = "0x180813CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool LPHAPKJLKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x437D20", Offset = "0x436F20", VA = "0x180437D20", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x443F20", Offset = "0x443120", VA = "0x180443F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6060", Offset = "0x2BE5260", VA = "0x182BE6060", Slot = "4")]
	public void LHDMGIMPNGF(float OKKKBODNINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5FC0", Offset = "0x2BE51C0", VA = "0x182BE5FC0")]
	public void CJPIEOIKDAO(UnityAction<Color> AFLPGGJMPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x437D20", Offset = "0x436F20", VA = "0x180437D20")]
	public bool EFGINMKOCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x813CA0", Offset = "0x812EA0", VA = "0x180813CA0")]
	public float JPCNDKLEFFG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xDC24D0", Offset = "0xDC16D0", VA = "0x180DC24D0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BF7150", Offset = "0x2BF6350", VA = "0x182BF7150")]
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
		[Cpp2IlInjected.Address(RVA = "0x159EFC0", Offset = "0x159E1C0", VA = "0x18159EFC0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x159EFD0", Offset = "0x159E1D0", VA = "0x18159EFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public float NEACGKEPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x90A270", Offset = "0x909470", VA = "0x18090A270")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x90A280", Offset = "0x909480", VA = "0x18090A280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float BJJEDIGOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C60", Offset = "0x7F3E60", VA = "0x1807F4C60", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DB0", Offset = "0x7F3FB0", VA = "0x1807F4DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool LPHAPKJLKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3E4910", Offset = "0x3E3B10", VA = "0x1803E4910", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3E4450", Offset = "0x3E3650", VA = "0x1803E4450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6F50", Offset = "0x2BF6150", VA = "0x182BF6F50", Slot = "4")]
	public void LHDMGIMPNGF(float OKKKBODNINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6EB0", Offset = "0x2BF60B0", VA = "0x182BF6EB0")]
	public void CJPIEOIKDAO(UnityAction<float> AFLPGGJMPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3E4910", Offset = "0x3E3B10", VA = "0x1803E4910")]
	public bool EFGINMKOCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C60", Offset = "0x7F3E60", VA = "0x1807F4C60")]
	public float JPCNDKLEFFG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0xDC24D0", Offset = "0xDC16D0", VA = "0x180DC24D0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EFBD0", Offset = "0x3EEDD0", VA = "0x1803EFBD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EFBD0", Offset = "0x3EEDD0", VA = "0x1803EFBD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1406870", Offset = "0x1405A70", VA = "0x181406870")]
		[DebuggerHidden]
		public HLBKKOEPAKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3E7820", Offset = "0x3E6A20", VA = "0x1803E7820", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x189F430", Offset = "0x189E630", VA = "0x18189F430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x189F560", Offset = "0x189E760", VA = "0x18189F560", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x18B1070", Offset = "0x18B0270", VA = "0x1818B1070")]
	[IteratorStateMachine(typeof(global::OPBIENGHNOL<>.HLBKKOEPAKM))]
	private static IEnumerator HDGEHNGPFDO(T EPGPDBMBPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3EFC00", Offset = "0x3EEE00", VA = "0x1803EFC00")]
	public void CALJLNMMIPN(MonoBehaviour CMIAMAJBJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x18B0F10", Offset = "0x18B0110", VA = "0x1818B0F10")]
	public void FPPOJDJCJKI(T DBDDKLHPNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x18B1160", Offset = "0x18B0360", VA = "0x1818B1160")]
	public void KOAIIMHNKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x13FE580", Offset = "0x13FD780", VA = "0x1813FE580")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CDB180", Offset = "0x1CDA380", VA = "0x181CDB180")]
	public static List<T> IAHDANBDAAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1CDB2F0", Offset = "0x1CDA4F0", VA = "0x181CDB2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FD040", Offset = "0x3FC240", VA = "0x1803FD040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x42FD80", Offset = "0x42EF80", VA = "0x18042FD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int HHAOOLFNEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1937350", Offset = "0x1936550", VA = "0x181937350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int LCPNJDNOAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1937130", Offset = "0x1936330", VA = "0x181937130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x19373C0", Offset = "0x19365C0", VA = "0x1819373C0")]
	public DMBLMECIJCJ(UnityAction<T> GOLBLHIPEDI, UnityAction<T> MJNKDEFIDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1937160", Offset = "0x1936360", VA = "0x181937160")]
	public T IAHDANBDAAM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1937250", Offset = "0x1936450", VA = "0x181937250")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E8C80", Offset = "0x3E7E80", VA = "0x1803E8C80")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2BF7190", Offset = "0x2BF6390", VA = "0x182BF7190")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2BF7290", Offset = "0x2BF6490", VA = "0x182BF7290")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E8C80", Offset = "0x3E7E80", VA = "0x1803E8C80")]
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
