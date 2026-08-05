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
				[Cpp2IlInjected.Address(RVA = "0x3DF950", Offset = "0x3DEB50", VA = "0x1803DF950")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x3FBF10", Offset = "0x3FB110", VA = "0x1803FBF10")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public Image IJKBAADKCBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x3DF970", Offset = "0x3DEB70", VA = "0x1803DF970")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x4C0C70", Offset = "0x4BFE70", VA = "0x1804C0C70")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RectTransform AIOEKMHLKAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x3DF960", Offset = "0x3DEB60", VA = "0x1803DF960")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x3E2890", Offset = "0x3E1A90", VA = "0x1803E2890")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Toggle MJDKJADPGIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x3DEBA0", Offset = "0x3DDDA0", VA = "0x1803DEBA0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x3DED90", Offset = "0x3DDF90", VA = "0x1803DED90")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x26E6210", Offset = "0x26E5410", VA = "0x1826E6210", Slot = "6")]
			public virtual void OnPointerEnter(PointerEventData OEKEOCOGKMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x26E6180", Offset = "0x26E5380", VA = "0x1826E6180", Slot = "7")]
			public virtual void OnCancel(BaseEventData OEKEOCOGKMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x3F6B60", Offset = "0x3F5D60", VA = "0x1803F6B60")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F0BF0", Offset = "0x3EFDF0", VA = "0x1803F0BF0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x3F8C40", Offset = "0x3F7E40", VA = "0x1803F8C40")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public Sprite image
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x3DF950", Offset = "0x3DEB50", VA = "0x1803DF950")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x3FBF10", Offset = "0x3FB110", VA = "0x1803FBF10")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3E0B10", Offset = "0x3DFD10", VA = "0x1803E0B10")]
			public OptionData()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5B00C0", Offset = "0x5AF2C0", VA = "0x1805B00C0")]
			public OptionData(string text)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5B0090", Offset = "0x5AF290", VA = "0x1805B0090")]
			public OptionData(Sprite image)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3FDBB0", Offset = "0x3FCDB0", VA = "0x1803FDBB0")]
			public OptionData(string text, Sprite image)
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
				[Cpp2IlInjected.Address(RVA = "0x3F0BF0", Offset = "0x3EFDF0", VA = "0x1803F0BF0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x3F8C40", Offset = "0x3F7E40", VA = "0x1803F8C40")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x26E6CC0", Offset = "0x26E5EC0", VA = "0x1826E6CC0")]
			public OptionDataList()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public class DropdownEvent : UnityEvent<int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x26E6140", Offset = "0x26E5340", VA = "0x1826E6140")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E0B10", Offset = "0x3DFD10", VA = "0x1803E0B10")]
			public DCMBNBJLLKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x26E5FC0", Offset = "0x26E51C0", VA = "0x1826E5FC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DF950", Offset = "0x3DEB50", VA = "0x1803DF950", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DF950", Offset = "0x3DEB50", VA = "0x1803DF950", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3F0560", Offset = "0x3EF760", VA = "0x1803F0560")]
			[DebuggerHidden]
			public OMHNBHFCIHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3DA020", Offset = "0x3D9220", VA = "0x1803DA020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x26E6B80", Offset = "0x26E5D80", VA = "0x1826E6B80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x26E6C30", Offset = "0x26E5E30", VA = "0x1826E6C30", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x596A70", Offset = "0x595C70", VA = "0x180596A70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x26D7DE0", Offset = "0x26D6FE0", VA = "0x1826D7DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TMP_Text GNPFHIKGONC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x441980", Offset = "0x440B80", VA = "0x180441980")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x26D7D80", Offset = "0x26D6F80", VA = "0x1826D7D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Image FADBPBIJPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x440E30", Offset = "0x440030", VA = "0x180440E30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x26D7D70", Offset = "0x26D6F70", VA = "0x1826D7D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public TMP_Text IJANOFBIFGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x4411D0", Offset = "0x4403D0", VA = "0x1804411D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x26D7DA0", Offset = "0x26D6FA0", VA = "0x1826D7DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Image CECFEBFHOBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x441740", Offset = "0x440940", VA = "0x180441740")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x26D7D90", Offset = "0x26D6F90", VA = "0x1826D7D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public List<OptionData> JJAPBNJPPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x118EF50", Offset = "0x118E150", VA = "0x18118EF50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x26D7DB0", Offset = "0x26D6FB0", VA = "0x1826D7DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public DropdownEvent CCHCBCLCFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x441530", Offset = "0x440730", VA = "0x180441530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x597A20", Offset = "0x596C20", VA = "0x180597A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int ONGBFDACHHG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x78E110", Offset = "0x78D310", VA = "0x18078E110")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x26D7DF0", Offset = "0x26D6FF0", VA = "0x1826D7DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PHOKNNFACHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x26D7CC0", Offset = "0x26D6EC0", VA = "0x1826D7CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HACBIOINOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x26D7D20", Offset = "0x26D6F20", VA = "0x1826D7D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x26D7B90", Offset = "0x26D6D90", VA = "0x1826D7B90")]
		protected AG_TMP_Dropdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x26D5720", Offset = "0x26D4920", VA = "0x1826D5720", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x26D6B70", Offset = "0x26D5D70", VA = "0x1826D6B70")]
		public void RefreshShownValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x26D55C0", Offset = "0x26D47C0", VA = "0x1826D55C0")]
		public void AddOptions(List<OptionData> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x26D54D0", Offset = "0x26D46D0", VA = "0x1826D54D0")]
		public void AddOptions(List<string> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x26D5630", Offset = "0x26D4830", VA = "0x1826D5630")]
		public void AddOptions(List<Sprite> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x26D5880", Offset = "0x26D4A80", VA = "0x1826D5880")]
		public void ClearOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x26D58E0", Offset = "0x26D4AE0", VA = "0x1826D58E0")]
		private void HKAJJALGMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x13308E0", Offset = "0x132FAE0", VA = "0x1813308E0")]
		private static T GLENGLDKGCK<T>(GameObject NNNMGKGMIFG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x26D6B60", Offset = "0x26D5D60", VA = "0x1826D6B60", Slot = "42")]
		public virtual void OnPointerClick(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x26D6B60", Offset = "0x26D5D60", VA = "0x1826D6B60", Slot = "43")]
		public virtual void OnSubmit(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x26D6B50", Offset = "0x26D5D50", VA = "0x1826D6B50", Slot = "44")]
		public virtual void OnCancel(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x26D6D90", Offset = "0x26D5F90", VA = "0x1826D6D90")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x26D64D0", Offset = "0x26D56D0", VA = "0x1826D64D0", Slot = "45")]
		protected virtual GameObject MLONLGOJHEF(Canvas GGEDDFLMJHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x26D5280", Offset = "0x26D4480", VA = "0x1826D5280", Slot = "46")]
		protected virtual void AMGBINMEKLB(GameObject HJPGLBGMCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x26D6470", Offset = "0x26D5670", VA = "0x1826D6470", Slot = "47")]
		protected virtual GameObject MKDGFAJHFPI(GameObject KHKGJGPIIAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x26D69D0", Offset = "0x26D5BD0", VA = "0x1826D69D0", Slot = "48")]
		protected virtual void NPDNDADJNJG(GameObject AFFMGNGGCEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x26D6410", Offset = "0x26D5610", VA = "0x1826D6410", Slot = "49")]
		protected virtual DropdownItem JIJOIMHCMAE(DropdownItem FOIOJEEDDCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3DA020", Offset = "0x3D9220", VA = "0x1803DA020", Slot = "50")]
		protected virtual void HOMLPHHMJEL(DropdownItem IOBEPGLJNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x26D6160", Offset = "0x26D5360", VA = "0x1826D6160")]
		private DropdownItem ICFDCCEPJDL(OptionData ABADFLCBFIJ, bool EGJJHJHIPCF, DropdownItem FOIOJEEDDCI, List<DropdownItem> BOOHBJEEGKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x26D6780", Offset = "0x26D5980", VA = "0x1826D6780")]
		private void NOHLFCGKAPE(float BJJEDIGOMGC, float FBPFONBFPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x26D6810", Offset = "0x26D5A10", VA = "0x1826D6810")]
		private void NOHLFCGKAPE(float BJJEDIGOMGC, float FKGCMPGAIAP, float KOFMGJJCPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x26D6AA0", Offset = "0x26D5CA0", VA = "0x1826D6AA0")]
		private void OOOAOJDCEHN(float FBPFONBFPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x26D5FB0", Offset = "0x26D51B0", VA = "0x1826D5FB0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x26D5DC0", Offset = "0x26D4FC0", VA = "0x1826D5DC0")]
		public void HideImmediately()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x26D6A30", Offset = "0x26D5C30", VA = "0x1826D6A30")]
		[IteratorStateMachine(typeof(OMHNBHFCIHJ))]
		private IEnumerator OENONJDLMPC(float NBOCPMDNOCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x26D52E0", Offset = "0x26D44E0", VA = "0x1826D52E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x26E6DA0", Offset = "0x26E5FA0", VA = "0x1826E6DA0")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x26E6C80", Offset = "0x26E5E80", VA = "0x1826E6C80")]
			public OnChangeEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class SelectionEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x26E6D60", Offset = "0x26E5F60", VA = "0x1826E6D60")]
			public SelectionEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x26E6DE0", Offset = "0x26E5FE0", VA = "0x1826E6DE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DF950", Offset = "0x3DEB50", VA = "0x1803DF950", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DF950", Offset = "0x3DEB50", VA = "0x1803DF950", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x3F0560", Offset = "0x3EF760", VA = "0x1803F0560")]
			[DebuggerHidden]
			public ABBELKNBPEB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3DA020", Offset = "0x3D9220", VA = "0x1803DA020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x26D4F80", Offset = "0x26D4180", VA = "0x1826D4F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x26D50A0", Offset = "0x26D42A0", VA = "0x1826D50A0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DF950", Offset = "0x3DEB50", VA = "0x1803DF950", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DF950", Offset = "0x3DEB50", VA = "0x1803DF950", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3F0560", Offset = "0x3EF760", VA = "0x1803F0560")]
			[DebuggerHidden]
			public HPAOCFBMJAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3DA020", Offset = "0x3D9220", VA = "0x1803DA020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x26E68B0", Offset = "0x26E5AB0", VA = "0x1826E68B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x26E6B30", Offset = "0x26E5D30", VA = "0x1826E6B30", Slot = "8")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		protected TMP_FontAsset m_GlobalFontAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		protected bool m_OnFocusSelectAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected bool OCDPJGGGCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27A")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		protected bool m_ResetOnDeActivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27B")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private bool m_RestoreOriginalTextOnEscape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		protected bool m_isRichTextEditingAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27D")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		protected bool m_updateMobileViewWhenKeyboardOpens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27E")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		protected bool m_ForceDisableScreenSpaceNotification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		protected TMP_InputValidator m_InputValidator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private Func<string, bool> GBJBFFBHJOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool AIMPABOMICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x291")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool KIDFDLCBNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x292")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool GCGLLCBEGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Event LJMHNINAHKD;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static string MNCPKKBHHHP;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool AJIFFAHNDBK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x26E4480", Offset = "0x26E3680", VA = "0x1826E4480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public TouchScreenKeyboard.Status AAMIDBCKMFN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x136A1F0", Offset = "0x13693F0", VA = "0x18136A1F0")]
			[CompilerGenerated]
			get
			{
				return default(TouchScreenKeyboard.Status);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x136A6C0", Offset = "0x13698C0", VA = "0x18136A6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TouchScreenKeyboard MFCBKLKENCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x441980", Offset = "0x440B80", VA = "0x180441980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string AJBKBJKLGEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x486770", Offset = "0x485970", VA = "0x180486770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x26E4690", Offset = "0x26E3890", VA = "0x1826E4690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected Mesh EDLHNCIENFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x26D8A90", Offset = "0x26D7C90", VA = "0x1826D8A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool AKNGFFLFKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x26E4650", Offset = "0x26E3850", VA = "0x1826E4650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string PAANJCAOOAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x486790", Offset = "0x485990", VA = "0x180486790")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x26E5C70", Offset = "0x26E4E70", VA = "0x1826E5C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool LMHGKGKNCDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x26E45C0", Offset = "0x26E37C0", VA = "0x1826E45C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float HDBOICOPFPG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x26E4500", Offset = "0x26E3700", VA = "0x1826E4500")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x26E4740", Offset = "0x26E3940", VA = "0x1826E4740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int NBLMMLPFCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x26E4570", Offset = "0x26E3770", VA = "0x1826E4570")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x26E4970", Offset = "0x26E3B70", VA = "0x1826E4970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RectTransform DAMCEBLMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x440E30", Offset = "0x440030", VA = "0x180440E30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x26E5C20", Offset = "0x26E4E20", VA = "0x1826E5C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TMP_Text GAOOAKOACIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4411D0", Offset = "0x4403D0", VA = "0x1804411D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x26E5BD0", Offset = "0x26E4DD0", VA = "0x1826E5BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Graphic NFNFFNAHAPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x441910", Offset = "0x440B10", VA = "0x180441910")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x26E5550", Offset = "0x26E4750", VA = "0x1826E5550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Scrollbar DMEHABPKKAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x441530", Offset = "0x440730", VA = "0x180441530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x26E5D90", Offset = "0x26E4F90", VA = "0x1826E5D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float PAKOCGKNBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x441050", Offset = "0x440250", VA = "0x180441050")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x26E57C0", Offset = "0x26E49C0", VA = "0x1826E57C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color DLGIEJOLHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x26E4510", Offset = "0x26E3710", VA = "0x1826E4510")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x26E47B0", Offset = "0x26E39B0", VA = "0x1826E47B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool PHKEONAKJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB3D4E0", Offset = "0xB3C6E0", VA = "0x180B3D4E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x26E4DC0", Offset = "0x26E3FC0", VA = "0x1826E4DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Color DDOJNMCKCKN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x26E4640", Offset = "0x26E3840", VA = "0x1826E4640")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x26E58F0", Offset = "0x26E4AF0", VA = "0x1826E58F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public SubmitEvent BGNEEOKFCGC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x43ECF0", Offset = "0x43DEF0", VA = "0x18043ECF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x26E5320", Offset = "0x26E4520", VA = "0x1826E5320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public SubmitEvent DKKHDPBJKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x486480", Offset = "0x485680", VA = "0x180486480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x26E5410", Offset = "0x26E4610", VA = "0x1826E5410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public SelectionEvent BCHLJNBPNPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x441340", Offset = "0x440540", VA = "0x180441340")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x26E53C0", Offset = "0x26E45C0", VA = "0x1826E53C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public SelectionEvent LJPBJFEFDKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x486470", Offset = "0x485670", VA = "0x180486470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x26E52D0", Offset = "0x26E44D0", VA = "0x1826E52D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TextSelectionEvent ENMOLJBNAHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x486750", Offset = "0x485950", VA = "0x180486750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x26E5460", Offset = "0x26E4660", VA = "0x1826E5460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public TextSelectionEvent HHAPBEDJKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4866D0", Offset = "0x4858D0", VA = "0x1804866D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x26E5370", Offset = "0x26E4570", VA = "0x1826E5370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public OnChangeEvent CCHCBCLCFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x598DA0", Offset = "0x597FA0", VA = "0x180598DA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x26E5500", Offset = "0x26E4700", VA = "0x1826E5500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public CCNHIOBEBOA KFGGMLKECGK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x596A20", Offset = "0x595C20", VA = "0x180596A20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x26E54B0", Offset = "0x26E46B0", VA = "0x1826E54B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int DIDPKDLHNBN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x26E4580", Offset = "0x26E3780", VA = "0x1826E4580")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x26E4A10", Offset = "0x26E3C10", VA = "0x1826E4A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float EGCPILNPLKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x26E4600", Offset = "0x26E3800", VA = "0x1826E4600")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x26E55A0", Offset = "0x26E47A0", VA = "0x1826E55A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TMP_FontAsset GCFIODLCCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5F2F00", Offset = "0x5F2100", VA = "0x1805F2F00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x26E4E30", Offset = "0x26E4030", VA = "0x1826E4E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LACLMELLCGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x486430", Offset = "0x485630", VA = "0x180486430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x476050", Offset = "0x475250", VA = "0x180476050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool CEHNEGPAGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x26E4610", Offset = "0x26E3810", VA = "0x1826E4610")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x26E5710", Offset = "0x26E4910", VA = "0x1826E5710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CHEGLKKIPBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x26E4620", Offset = "0x26E3820", VA = "0x1826E4620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x26E5720", Offset = "0x26E4920", VA = "0x1826E5720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool KAAIKJLFGFP
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x26E45D0", Offset = "0x26E37D0", VA = "0x1826E45D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x26E50F0", Offset = "0x26E42F0", VA = "0x1826E50F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PCKCCEOPIGL
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x26E4680", Offset = "0x26E3880", VA = "0x1826E4680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x26E5D80", Offset = "0x26E4F80", VA = "0x1826E5D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool NCAFECJAAEC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x26E4470", Offset = "0x26E3670", VA = "0x1826E4470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TMP_InputField.ContentType KCKBKEKAMDF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xC77E10", Offset = "0xC77010", VA = "0x180C77E10")]
			get
			{
				return default(TMP_InputField.ContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x26E4B10", Offset = "0x26E3D10", VA = "0x1826E4B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public TMP_InputField.LineType PLOPNEGDJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x440E60", Offset = "0x440060", VA = "0x180440E60")]
			get
			{
				return default(TMP_InputField.LineType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x26E5170", Offset = "0x26E4370", VA = "0x1826E5170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public TMP_InputField.InputType KJNDMFLHLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x26E45A0", Offset = "0x26E37A0", VA = "0x1826E45A0")]
			get
			{
				return default(TMP_InputField.InputType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x26E4FC0", Offset = "0x26E41C0", VA = "0x1826E4FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TouchScreenKeyboardType MLFHHNNDOEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xC77ED0", Offset = "0xC770D0", VA = "0x180C77ED0")]
			get
			{
				return default(TouchScreenKeyboardType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x26E5100", Offset = "0x26E4300", VA = "0x1826E5100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TMP_InputField.CharacterValidation HMCHFOILHPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x101ABA0", Offset = "0x1019DA0", VA = "0x18101ABA0")]
			get
			{
				return default(TMP_InputField.CharacterValidation);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x26E4AA0", Offset = "0x26E3CA0", VA = "0x1826E4AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TMP_InputValidator EPPLBJHBEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x26E45B0", Offset = "0x26E37B0", VA = "0x1826E45B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x26E5030", Offset = "0x26E4230", VA = "0x1826E5030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Func<string, bool> GOLGMHKKGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x26E4590", Offset = "0x26E3790", VA = "0x1826E4590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x26E4F70", Offset = "0x26E4170", VA = "0x1826E4F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool BGNEPFGDKHB
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x1DD1D10", Offset = "0x1DD0F10", VA = "0x181DD1D10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x26E5700", Offset = "0x26E4900", VA = "0x1826E5700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool DAAFDDDHEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x26E4630", Offset = "0x26E3830", VA = "0x1826E4630")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x26E5730", Offset = "0x26E4930", VA = "0x1826E5730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool BBKJPKCMMNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x26E45E0", Offset = "0x26E37E0", VA = "0x1826E45E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public char EHGCPACOOKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x26E44F0", Offset = "0x26E36F0", VA = "0x1826E44F0")]
			get
			{
				return default(char);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x26E46E0", Offset = "0x26E38E0", VA = "0x1826E46E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool BFMGMGGLHKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x776640", Offset = "0x775840", VA = "0x180776640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected int CHFEODECIBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x26E14A0", Offset = "0x26E06A0", VA = "0x1826E14A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x26DDCA0", Offset = "0x26DCEA0", VA = "0x1826DDCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected int JDLAOAEIGBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x26DDC70", Offset = "0x26DCE70", VA = "0x1826DDC70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x26DD560", Offset = "0x26DC760", VA = "0x1826DD560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected int OJEPKIDOLDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x26DA8D0", Offset = "0x26D9AD0", VA = "0x1826DA8D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x26D88C0", Offset = "0x26D7AC0", VA = "0x1826D88C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected int BJKFMKDBNJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x26DB760", Offset = "0x26DA960", VA = "0x1826DB760")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x26DC680", Offset = "0x26DB880", VA = "0x1826DC680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool HHBIHFPBPEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x26D99D0", Offset = "0x26D8BD0", VA = "0x1826D99D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int LIMFKKIOJCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x26DA8D0", Offset = "0x26D9AD0", VA = "0x1826DA8D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x26E4860", Offset = "0x26E3A60", VA = "0x1826E4860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public int GALHKIEDLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x26E14A0", Offset = "0x26E06A0", VA = "0x1826E14A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x26E5860", Offset = "0x26E4A60", VA = "0x1826E5860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int JIFIJDPPPFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x26DA8D0", Offset = "0x26D9AD0", VA = "0x1826DA8D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x26E59A0", Offset = "0x26E4BA0", VA = "0x1826E59A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int HBEHMEFLOII
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x26DB760", Offset = "0x26DA960", VA = "0x1826DB760")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x26E5B10", Offset = "0x26E4D10", VA = "0x1826E5B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int NNHHHMKKBBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x26DDC70", Offset = "0x26DCE70", VA = "0x1826DDC70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x26E5A30", Offset = "0x26E4C30", VA = "0x1826E5A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int JAIBIHAADGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x26DB760", Offset = "0x26DA960", VA = "0x1826DB760")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x26E5AA0", Offset = "0x26E4CA0", VA = "0x1826E5AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private static string MGPNHELOFBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x11A5380", Offset = "0x11A4580", VA = "0x1811A5380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x11A5EC0", Offset = "0x11A50C0", VA = "0x1811A5EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x26E4100", Offset = "0x26E3300", VA = "0x1826E4100")]
		protected AG_TMP_InputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x26DC120", Offset = "0x26DB320", VA = "0x1826DC120")]
		protected void GNLDFFIHBNL(ref int IFAIDIKJOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x26DB7E0", Offset = "0x26DA9E0", VA = "0x1826DB7E0")]
		protected void FOHLGFNFBHH(ref int IFAIDIKJOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x26E1D40", Offset = "0x26E0F40", VA = "0x1826E1D40", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x26E1650", Offset = "0x26E0850", VA = "0x1826E1650", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x26D9A30", Offset = "0x26D8C30", VA = "0x1826D9A30")]
		private void CIPAFIJGFPH(UnityEngine.Object NLNHFEEMFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x26DC5A0", Offset = "0x26DB7A0", VA = "0x1826DC5A0")]
		[IteratorStateMachine(typeof(ABBELKNBPEB))]
		private IEnumerator IFLEEBBKHHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x26D8680", Offset = "0x26D7880", VA = "0x1826D8680")]
		private void AMNPDKKBKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x26DB420", Offset = "0x26DA620", VA = "0x1826DB420")]
		private void FINJJEAKJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x26DDEF0", Offset = "0x26DD0F0", VA = "0x1826DDEF0")]
		protected void LKIDFHCFCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x26DC600", Offset = "0x26DB800", VA = "0x1826DC600")]
		protected void ILKEOLFCLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x26DF940", Offset = "0x26DEB40", VA = "0x1826DF940")]
		public void MoveTextEnd(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x26DFB20", Offset = "0x26DED20", VA = "0x1826DFB20")]
		public void MoveTextStart(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x26DFCA0", Offset = "0x26DEEA0", VA = "0x1826DFCA0")]
		public void MoveToEndOfLine(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x26DFE90", Offset = "0x26DF090", VA = "0x1826DFE90")]
		public void MoveToStartOfLine(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x26DD5B0", Offset = "0x26DC7B0", VA = "0x1826DD5B0")]
		private bool KKILEDOIHJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x26DEBB0", Offset = "0x26DDDB0", VA = "0x1826DEBB0", Slot = "51")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x26DEAE0", Offset = "0x26DDCE0", VA = "0x1826DEAE0")]
		private bool LPNBFDALPBB(PointerEventData OEKEOCOGKMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x26E15B0", Offset = "0x26E07B0", VA = "0x1826E15B0", Slot = "52")]
		public virtual void OnBeginDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x26E1960", Offset = "0x26E0B60", VA = "0x1826E1960", Slot = "53")]
		public virtual void OnDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x26DBD50", Offset = "0x26DAF50", VA = "0x1826DBD50")]
		[IteratorStateMachine(typeof(HPAOCFBMJAC))]
		private IEnumerator GECGBFHNIHP(PointerEventData OEKEOCOGKMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x26E23F0", Offset = "0x26E15F0", VA = "0x1826E23F0", Slot = "54")]
		public virtual void OnEndDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x26E2450", Offset = "0x26E1650", VA = "0x1826E2450", Slot = "32")]
		public override void OnPointerDown(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x26DA9D0", Offset = "0x26D9BD0", VA = "0x1826DA9D0")]
		protected JHEIPDKDOED ELNLABLFKNG(Event PFFGBOMIOHL)
		{
			return default(JHEIPDKDOED);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x26DC6D0", Offset = "0x26DB8D0", VA = "0x1826DC6D0")]
		private bool JGOAIDFDMAD(char MBEHODBGOJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x26E3D80", Offset = "0x26E2F80", VA = "0x1826E3D80")]
		public void ProcessEvent(Event CHKKEHOKPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x26E2D10", Offset = "0x26E1F10", VA = "0x1826E2D10", Slot = "55")]
		public virtual void OnUpdateSelected(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x26E2A60", Offset = "0x26E1C60", VA = "0x1826E2A60", Slot = "56")]
		public virtual void OnScroll(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x26D8240", Offset = "0x26D7440", VA = "0x1826D8240")]
		private string AEAJLKEPNLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x26E3140", Offset = "0x26E2340", VA = "0x1826E3140")]
		private int PIAEKONDGNG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x26D92E0", Offset = "0x26D84E0", VA = "0x1826D92E0")]
		private void CCJLEGAFGKM(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x26DB850", Offset = "0x26DAA50", VA = "0x1826DB850")]
		private int GADBOBOJIDE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x26DCF60", Offset = "0x26DC160", VA = "0x1826DCF60")]
		private void JLMEDGAJBEC(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x26DAE40", Offset = "0x26DA040", VA = "0x1826DAE40")]
		private int FCKJFAJCNGD(int LBJOEJHPBJK, bool LJFNJIAKLFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x26D7EF0", Offset = "0x26D70F0", VA = "0x1826D7EF0")]
		private int AACOJNMNOGE(int LBJOEJHPBJK, bool MNNDCGNNAKB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x26DF2F0", Offset = "0x26DE4F0", VA = "0x1826DF2F0")]
		private int MJKECNILJFD(int LBJOEJHPBJK, bool LJFNJIAKLFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x26DCB30", Offset = "0x26DBD30", VA = "0x1826DCB30")]
		private int JJCPPIAOHIM(int LBJOEJHPBJK, bool MNNDCGNNAKB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x26DC720", Offset = "0x26DB920", VA = "0x1826DC720")]
		private void JHHDGCMNMCN(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x26DC730", Offset = "0x26DB930", VA = "0x1826DC730")]
		private void JHHDGCMNMCN(bool DIHIAEIGDKB, bool MNNDCGNNAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x26DC110", Offset = "0x26DB310", VA = "0x1826DC110")]
		private void GGFOEKLOLNI(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x26DBDC0", Offset = "0x26DAFC0", VA = "0x1826DBDC0")]
		private void GGFOEKLOLNI(bool DIHIAEIGDKB, bool LJFNJIAKLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x26E3D70", Offset = "0x26E2F70", VA = "0x1826E3D70")]
		private void PNNDENFHNDI(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x26E37F0", Offset = "0x26E29F0", VA = "0x1826E37F0")]
		private void PNNDENFHNDI(bool DIHIAEIGDKB, bool LJFNJIAKLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x26DDC60", Offset = "0x26DCE60", VA = "0x1826DDC60")]
		private void LCGOPCFKIPP(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x26DD6C0", Offset = "0x26DC8C0", VA = "0x1826DD6C0")]
		private void LCGOPCFKIPP(bool DIHIAEIGDKB, bool MNNDCGNNAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x26E3250", Offset = "0x26E2450", VA = "0x1826E3250")]
		private void PKGAHIFGEII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x26E2E70", Offset = "0x26E2070", VA = "0x1826E2E70")]
		private void PDHKGPEOBBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x26DF070", Offset = "0x26DE270", VA = "0x1826DF070")]
		private void MCMONKBJDEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x26DF720", Offset = "0x26DE920", VA = "0x1826DF720", Slot = "57")]
		protected virtual void MJLHLGCPKKA(string DBFBLNILIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x26DF7D0", Offset = "0x26DE9D0", VA = "0x1826DF7D0", Slot = "58")]
		protected virtual void MJLHLGCPKKA(char DBFBLNILIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x26DB520", Offset = "0x26DA720", VA = "0x1826DB520")]
		private void FLJBJJLIFHM(char MBEHODBGOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x26D8860", Offset = "0x26D7A60", VA = "0x1826D8860")]
		private void BHKGFMKCHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x26DB790", Offset = "0x26DA990", VA = "0x1826DB790")]
		private void FNCJLCDOPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x26E30F0", Offset = "0x26E22F0", VA = "0x1826E30F0")]
		protected void PFONIFOBNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x26DB4D0", Offset = "0x26DA6D0", VA = "0x1826DB4D0")]
		protected void FJLCFFGEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x26D8810", Offset = "0x26D7A10", VA = "0x1826D8810")]
		protected void BCDADBPHACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x26DC550", Offset = "0x26DB750", VA = "0x1826DC550")]
		protected void HPALNDEIFIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x26D9910", Offset = "0x26D8B10", VA = "0x1826D9910")]
		protected void CDMKFBBJMDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x26E14D0", Offset = "0x26E06D0", VA = "0x1826E14D0")]
		protected void ONPEDNNEFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x26DB180", Offset = "0x26DA380", VA = "0x1826DB180")]
		protected void FDGABBAAGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x26DDD00", Offset = "0x26DCF00", VA = "0x1826DDD00")]
		private void LKFFKIONEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x26DF010", Offset = "0x26DE210", VA = "0x1826DF010")]
		private void MBEGMCEEJNL(float ONGBFDACHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x26D8920", Offset = "0x26D7B20", VA = "0x1826D8920")]
		private void BPOLKAJBDOB(float LKGCBILJGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x26DCAA0", Offset = "0x26DBCA0", VA = "0x1826DCAA0")]
		private int JIHIOHDMHDH(int FOCIACBBGKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x26E0060", Offset = "0x26DF260", VA = "0x1826E0060")]
		private int NNAEGEJNCLB(int LIMFKKIOJCM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x26DB840", Offset = "0x26DAA40", VA = "0x1826DB840")]
		public void ForceLabelUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x26DBCF0", Offset = "0x26DAEF0", VA = "0x1826DBCF0")]
		private void GCOEHHCNFIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x26E3D90", Offset = "0x26E2F90", VA = "0x1826E3D90", Slot = "59")]
		public virtual void Rebuild(CanvasUpdate JFKDDPJDCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3DA020", Offset = "0x3D9220", VA = "0x1803DA020", Slot = "60")]
		public virtual void LayoutComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3DA020", Offset = "0x3D9220", VA = "0x1803DA020", Slot = "61")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x26DA900", Offset = "0x26D9B00", VA = "0x1826DA900")]
		private void EGPBCLJAIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x26D8B40", Offset = "0x26D7D40", VA = "0x1826D8B40")]
		private void CCJJNIFEGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x26DB940", Offset = "0x26DAB40", VA = "0x1826DB940")]
		private void GCGNCIIEDJM(Mesh LGFFBNOGPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x26DDFC0", Offset = "0x26DD1C0", VA = "0x1826DDFC0")]
		private void LKPJIACBDMI(VertexHelper LGFFBNOGPCN, Vector2 HHPJGFCCJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x26DC3C0", Offset = "0x26DB5C0", VA = "0x1826DC3C0")]
		private void HKNGBDDONBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x26E00F0", Offset = "0x26DF2F0", VA = "0x1826E00F0")]
		private void NPGMCAPEBPB(VertexHelper LGFFBNOGPCN, Vector2 HHPJGFCCJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x26D9C00", Offset = "0x26D8E00", VA = "0x1826D9C00")]
		private void CJDHPCLLGCP(Vector2 FMMMDFONBJG, float CHAKCELLLJD, bool LANOHNACEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x26E0DB0", Offset = "0x26DFFB0", VA = "0x1826E0DB0")]
		protected char OKAAIIMAHLK(string PAANJCAOOAG, int IFAIDIKJOAC, char OEFNGECBJAP)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x26D86C0", Offset = "0x26D78C0", VA = "0x1826D86C0")]
		public void ActivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x26D8330", Offset = "0x26D7530", VA = "0x1826D8330")]
		private void AGAHHMPPAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x26E2C20", Offset = "0x26E1E20", VA = "0x1826E2C20", Slot = "36")]
		public override void OnSelect(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x26E2420", Offset = "0x26E1620", VA = "0x1826E2420", Slot = "62")]
		public virtual void OnPointerClick(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3DA020", Offset = "0x3D9220", VA = "0x1803DA020")]
		public void OnControlClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x26DA570", Offset = "0x26D9770", VA = "0x1826DA570")]
		public void DeactivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x26E15E0", Offset = "0x26E07E0", VA = "0x1826E15E0", Slot = "37")]
		public override void OnDeselect(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x26E2C80", Offset = "0x26E1E80", VA = "0x1826E2C80", Slot = "63")]
		public virtual void OnSubmit(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x26DC160", Offset = "0x26DB360", VA = "0x1826DC160")]
		private void GNNGKJGDDLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x26DDF10", Offset = "0x26DD110", VA = "0x1826DDF10")]
		private void LKJOKADIOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x26DA4E0", Offset = "0x26D96E0", VA = "0x1826DA4E0")]
		private void DOFNHJBBMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x26E3080", Offset = "0x26E2280", VA = "0x1826E3080")]
		private void PELNFKBIIFO(params TMP_InputField.ContentType[] BAEPNOGNECP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x26DD6A0", Offset = "0x26DC8A0", VA = "0x1826DD6A0")]
		private void LBBBNGGBNBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x26DD620", Offset = "0x26DC820", VA = "0x1826DD620")]
		private void LBBBNGGBNBC(TMP_InputField.CharacterValidation HMCHFOILHPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x26DA8A0", Offset = "0x26D9AA0", VA = "0x1826DA8A0", Slot = "26")]
		protected override void DoStateTransition(SelectionState GKNIHNHGBKC, bool BKDCBHDFBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x26E3F50", Offset = "0x26E3150", VA = "0x1826E3F50")]
		public void SetGlobalPointSize(float EGCPILNPLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x26E3E60", Offset = "0x26E3060", VA = "0x1826E3E60")]
		public void SetGlobalFontAsset(TMP_FontAsset GCFIODLCCKD)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x694E30", Offset = "0x694030", VA = "0x180694E30", Slot = "46")]
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
	[Cpp2IlInjected.Address(RVA = "0x1186A70", Offset = "0x1185C70", VA = "0x181186A70")]
	public static bool LJAEIJLMDHG(ref Color MMHAEEACNOD, Color BCEFAKDFEMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x16C24A0", Offset = "0x16C16A0", VA = "0x1816C24A0")]
	public static bool LBFNDKHKFNH<T>(ref T MMHAEEACNOD, T BCEFAKDFEMM) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x16C2680", Offset = "0x16C1880", VA = "0x1816C2680")]
	public static bool AKJLBMDKGMF<T>(ref T MMHAEEACNOD, T BCEFAKDFEMM) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x16C2450", Offset = "0x16C1650", VA = "0x1816C2450")]
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
		[Cpp2IlInjected.Address(RVA = "0x26E6D20", Offset = "0x26E5F20", VA = "0x1826E6D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1184090", Offset = "0x1183290", VA = "0x181184090")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x11840A0", Offset = "0x11832A0", VA = "0x1811840A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Color OADKADHJHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4D24C0", Offset = "0x4D16C0", VA = "0x1804D24C0")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4D24D0", Offset = "0x4D16D0", VA = "0x1804D24D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public PPPKALBKBCI KNLKEEHCIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x455FC0", Offset = "0x4551C0", VA = "0x180455FC0")]
		get
		{
			return default(PPPKALBKBCI);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x455FB0", Offset = "0x4551B0", VA = "0x180455FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public float BJJEDIGOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x542160", Offset = "0x541360", VA = "0x180542160", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x542170", Offset = "0x541370", VA = "0x180542170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool LPHAPKJLKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3DF940", Offset = "0x3DEB40", VA = "0x1803DF940", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3DF390", Offset = "0x3DE590", VA = "0x1803DF390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x26D5190", Offset = "0x26D4390", VA = "0x1826D5190", Slot = "4")]
	public void LHDMGIMPNGF(float OKKKBODNINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x26D50F0", Offset = "0x26D42F0", VA = "0x1826D50F0")]
	public void CJPIEOIKDAO(UnityAction<Color> AFLPGGJMPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3DF940", Offset = "0x3DEB40", VA = "0x1803DF940")]
	public bool EFGINMKOCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x542160", Offset = "0x541360", VA = "0x180542160")]
	public float JPCNDKLEFFG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xCC82E0", Offset = "0xCC74E0", VA = "0x180CC82E0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x26E6290", Offset = "0x26E5490", VA = "0x1826E6290")]
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
		[Cpp2IlInjected.Address(RVA = "0x11849D0", Offset = "0x1183BD0", VA = "0x1811849D0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x11849E0", Offset = "0x1183BE0", VA = "0x1811849E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public float NEACGKEPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x51A140", Offset = "0x519340", VA = "0x18051A140")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x51A160", Offset = "0x519360", VA = "0x18051A160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float BJJEDIGOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4542B0", Offset = "0x4534B0", VA = "0x1804542B0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x454400", Offset = "0x453600", VA = "0x180454400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool LPHAPKJLKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5A7130", Offset = "0x5A6330", VA = "0x1805A7130", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5A6B00", Offset = "0x5A5D00", VA = "0x1805A6B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x26E6090", Offset = "0x26E5290", VA = "0x1826E6090", Slot = "4")]
	public void LHDMGIMPNGF(float OKKKBODNINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x26E5FF0", Offset = "0x26E51F0", VA = "0x1826E5FF0")]
	public void CJPIEOIKDAO(UnityAction<float> AFLPGGJMPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5A7130", Offset = "0x5A6330", VA = "0x1805A7130")]
	public bool EFGINMKOCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4542B0", Offset = "0x4534B0", VA = "0x1804542B0")]
	public float JPCNDKLEFFG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0xCC82E0", Offset = "0xCC74E0", VA = "0x180CC82E0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DF950", Offset = "0x3DEB50", VA = "0x1803DF950", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DF950", Offset = "0x3DEB50", VA = "0x1803DF950", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1309F10", Offset = "0x1309110", VA = "0x181309F10")]
		[DebuggerHidden]
		public HLBKKOEPAKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3DA020", Offset = "0x3D9220", VA = "0x1803DA020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x1309D90", Offset = "0x1308F90", VA = "0x181309D90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x1309EC0", Offset = "0x13090C0", VA = "0x181309EC0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x13186C0", Offset = "0x13178C0", VA = "0x1813186C0")]
	[IteratorStateMachine(typeof(global::OPBIENGHNOL<>.HLBKKOEPAKM))]
	private static IEnumerator HDGEHNGPFDO(T EPGPDBMBPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C40", Offset = "0x3F7E40", VA = "0x1803F8C40")]
	public void CALJLNMMIPN(MonoBehaviour CMIAMAJBJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1318560", Offset = "0x1317760", VA = "0x181318560")]
	public void FPPOJDJCJKI(T DBDDKLHPNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x13187B0", Offset = "0x13179B0", VA = "0x1813187B0")]
	public void KOAIIMHNKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xF0DE20", Offset = "0xF0D020", VA = "0x180F0DE20")]
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
	[Cpp2IlInjected.Address(RVA = "0x19496B0", Offset = "0x19488B0", VA = "0x1819496B0")]
	public static List<T> IAHDANBDAAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1949820", Offset = "0x1948A20", VA = "0x181949820")]
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
		[Cpp2IlInjected.Address(RVA = "0x455FC0", Offset = "0x4551C0", VA = "0x180455FC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x455FB0", Offset = "0x4551B0", VA = "0x180455FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int HHAOOLFNEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1824DD0", Offset = "0x1823FD0", VA = "0x181824DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int LCPNJDNOAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x158A8E0", Offset = "0x1589AE0", VA = "0x18158A8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x1824E40", Offset = "0x1824040", VA = "0x181824E40")]
	public DMBLMECIJCJ(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1824BE0", Offset = "0x1823DE0", VA = "0x181824BE0")]
	public T IAHDANBDAAM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1824CD0", Offset = "0x1823ED0", VA = "0x181824CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E0B10", Offset = "0x3DFD10", VA = "0x1803E0B10")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x26E62D0", Offset = "0x26E54D0", VA = "0x1826E62D0")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x26E63D0", Offset = "0x26E55D0", VA = "0x1826E63D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E0B10", Offset = "0x3DFD10", VA = "0x1803E0B10")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class __BB_OBFUSCATOR_VERSION_3_5_3
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
