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
				[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x3EDBF0", Offset = "0x3ECDF0", VA = "0x1803EDBF0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public Image IJKBAADKCBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x3EDBE0", Offset = "0x3ECDE0", VA = "0x1803EDBE0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x43F320", Offset = "0x43E520", VA = "0x18043F320")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RectTransform AIOEKMHLKAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x3EF0F0", Offset = "0x3EE2F0", VA = "0x1803EF0F0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x3EE030", Offset = "0x3ED230", VA = "0x1803EE030")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Toggle MJDKJADPGIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x3FB030", Offset = "0x3FA230", VA = "0x1803FB030")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x3EE010", Offset = "0x3ED210", VA = "0x1803EE010")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2C14BF0", Offset = "0x2C13DF0", VA = "0x182C14BF0", Slot = "6")]
			public virtual void OnPointerEnter(PointerEventData OEKEOCOGKMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2C14B60", Offset = "0x2C13D60", VA = "0x182C14B60", Slot = "7")]
			public virtual void OnCancel(BaseEventData OEKEOCOGKMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x813120", Offset = "0x812320", VA = "0x180813120")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DF000", Offset = "0x3DE200", VA = "0x1803DF000")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x3EDC00", Offset = "0x3ECE00", VA = "0x1803EDC00")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public Sprite image
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x3EDBF0", Offset = "0x3ECDF0", VA = "0x1803EDBF0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3E6C80", Offset = "0x3E5E80", VA = "0x1803E6C80")]
			public OptionData()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x406DE0", Offset = "0x405FE0", VA = "0x180406DE0")]
			public OptionData(string PAANJCAOOAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x46EF30", Offset = "0x46E130", VA = "0x18046EF30")]
			public OptionData(Sprite IJKBAADKCBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3FC2E0", Offset = "0x3FB4E0", VA = "0x1803FC2E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DF000", Offset = "0x3DE200", VA = "0x1803DF000")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x3EDC00", Offset = "0x3ECE00", VA = "0x1803EDC00")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2C156A0", Offset = "0x2C148A0", VA = "0x182C156A0")]
			public OptionDataList()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public class DropdownEvent : UnityEvent<int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2C14B20", Offset = "0x2C13D20", VA = "0x182C14B20")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E6C80", Offset = "0x3E5E80", VA = "0x1803E6C80")]
			public DCMBNBJLLKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2C149A0", Offset = "0x2C13BA0", VA = "0x182C149A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x438260", Offset = "0x437460", VA = "0x180438260")]
			[DebuggerHidden]
			public OMHNBHFCIHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3E5820", Offset = "0x3E4A20", VA = "0x1803E5820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2C15560", Offset = "0x2C14760", VA = "0x182C15560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x2C15610", Offset = "0x2C14810", VA = "0x182C15610", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x850830", Offset = "0x84FA30", VA = "0x180850830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2C067D0", Offset = "0x2C059D0", VA = "0x182C067D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TMP_Text GNPFHIKGONC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6FD240", Offset = "0x6FC440", VA = "0x1806FD240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x2C06770", Offset = "0x2C05970", VA = "0x182C06770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Image FADBPBIJPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8509E0", Offset = "0x84FBE0", VA = "0x1808509E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2C06760", Offset = "0x2C05960", VA = "0x182C06760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public TMP_Text IJANOFBIFGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x850950", Offset = "0x84FB50", VA = "0x180850950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2C06790", Offset = "0x2C05990", VA = "0x182C06790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Image CECFEBFHOBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x84F790", Offset = "0x84E990", VA = "0x18084F790")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2C06780", Offset = "0x2C05980", VA = "0x182C06780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public List<OptionData> JJAPBNJPPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x162C110", Offset = "0x162B310", VA = "0x18162C110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2C067A0", Offset = "0x2C059A0", VA = "0x182C067A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public DropdownEvent CCHCBCLCFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x850840", Offset = "0x84FA40", VA = "0x180850840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC0D200", Offset = "0xC0C400", VA = "0x180C0D200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int ONGBFDACHHG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB69A60", Offset = "0xB68C60", VA = "0x180B69A60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2C067E0", Offset = "0x2C059E0", VA = "0x182C067E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PHOKNNFACHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2C066B0", Offset = "0x2C058B0", VA = "0x182C066B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HACBIOINOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2C06710", Offset = "0x2C05910", VA = "0x182C06710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2C06580", Offset = "0x2C05780", VA = "0x182C06580")]
		protected AG_TMP_Dropdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2C04110", Offset = "0x2C03310", VA = "0x182C04110", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2C05560", Offset = "0x2C04760", VA = "0x182C05560")]
		public void RefreshShownValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2C03FB0", Offset = "0x2C031B0", VA = "0x182C03FB0")]
		public void AddOptions(List<OptionData> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2C03EC0", Offset = "0x2C030C0", VA = "0x182C03EC0")]
		public void AddOptions(List<string> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2C04020", Offset = "0x2C03220", VA = "0x182C04020")]
		public void AddOptions(List<Sprite> JJAPBNJPPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2C04270", Offset = "0x2C03470", VA = "0x182C04270")]
		public void ClearOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2C042D0", Offset = "0x2C034D0", VA = "0x182C042D0")]
		private void HKAJJALGMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x143E6C0", Offset = "0x143D8C0", VA = "0x18143E6C0")]
		private static T GLENGLDKGCK<T>(GameObject NNNMGKGMIFG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2C05550", Offset = "0x2C04750", VA = "0x182C05550", Slot = "42")]
		public virtual void OnPointerClick(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2C05550", Offset = "0x2C04750", VA = "0x182C05550", Slot = "43")]
		public virtual void OnSubmit(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2C05540", Offset = "0x2C04740", VA = "0x182C05540", Slot = "44")]
		public virtual void OnCancel(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2C05780", Offset = "0x2C04980", VA = "0x182C05780")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2C04EC0", Offset = "0x2C040C0", VA = "0x182C04EC0", Slot = "45")]
		protected virtual GameObject MLONLGOJHEF(Canvas GGEDDFLMJHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2C03C70", Offset = "0x2C02E70", VA = "0x182C03C70", Slot = "46")]
		protected virtual void AMGBINMEKLB(GameObject HJPGLBGMCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2C04E60", Offset = "0x2C04060", VA = "0x182C04E60", Slot = "47")]
		protected virtual GameObject MKDGFAJHFPI(GameObject KHKGJGPIIAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2C053C0", Offset = "0x2C045C0", VA = "0x182C053C0", Slot = "48")]
		protected virtual void NPDNDADJNJG(GameObject AFFMGNGGCEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2C04E00", Offset = "0x2C04000", VA = "0x182C04E00", Slot = "49")]
		protected virtual DropdownItem JIJOIMHCMAE(DropdownItem FOIOJEEDDCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E5820", Offset = "0x3E4A20", VA = "0x1803E5820", Slot = "50")]
		protected virtual void HOMLPHHMJEL(DropdownItem IOBEPGLJNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2C04B50", Offset = "0x2C03D50", VA = "0x182C04B50")]
		private DropdownItem ICFDCCEPJDL(OptionData ABADFLCBFIJ, bool EGJJHJHIPCF, DropdownItem FOIOJEEDDCI, List<DropdownItem> BOOHBJEEGKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2C05170", Offset = "0x2C04370", VA = "0x182C05170")]
		private void NOHLFCGKAPE(float BJJEDIGOMGC, float FBPFONBFPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2C05200", Offset = "0x2C04400", VA = "0x182C05200")]
		private void NOHLFCGKAPE(float BJJEDIGOMGC, float FKGCMPGAIAP, float KOFMGJJCPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2C05490", Offset = "0x2C04690", VA = "0x182C05490")]
		private void OOOAOJDCEHN(float FBPFONBFPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2C049A0", Offset = "0x2C03BA0", VA = "0x182C049A0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2C047B0", Offset = "0x2C039B0", VA = "0x182C047B0")]
		public void HideImmediately()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2C05420", Offset = "0x2C04620", VA = "0x182C05420")]
		[IteratorStateMachine(typeof(OMHNBHFCIHJ))]
		private IEnumerator OENONJDLMPC(float NBOCPMDNOCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2C03CD0", Offset = "0x2C02ED0", VA = "0x182C03CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C15780", Offset = "0x2C14980", VA = "0x182C15780")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2C15660", Offset = "0x2C14860", VA = "0x182C15660")]
			public OnChangeEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class SelectionEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2C15740", Offset = "0x2C14940", VA = "0x182C15740")]
			public SelectionEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2C157C0", Offset = "0x2C149C0", VA = "0x182C157C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x438260", Offset = "0x437460", VA = "0x180438260")]
			[DebuggerHidden]
			public ABBELKNBPEB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3E5820", Offset = "0x3E4A20", VA = "0x1803E5820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2C03970", Offset = "0x2C02B70", VA = "0x182C03970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x2C03A90", Offset = "0x2C02C90", VA = "0x182C03A90", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x438260", Offset = "0x437460", VA = "0x180438260")]
			[DebuggerHidden]
			public HPAOCFBMJAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3E5820", Offset = "0x3E4A20", VA = "0x1803E5820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x2C15290", Offset = "0x2C14490", VA = "0x182C15290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x2C15510", Offset = "0x2C14710", VA = "0x182C15510", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C12E60", Offset = "0x2C12060", VA = "0x182C12E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public TouchScreenKeyboard.Status AAMIDBCKMFN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x181B810", Offset = "0x181AA10", VA = "0x18181B810")]
			[CompilerGenerated]
			get
			{
				return default(TouchScreenKeyboard.Status);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x181BCD0", Offset = "0x181AED0", VA = "0x18181BCD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TouchScreenKeyboard MFCBKLKENCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6FD240", Offset = "0x6FC440", VA = "0x1806FD240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string AJBKBJKLGEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8507C0", Offset = "0x84F9C0", VA = "0x1808507C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x2C13070", Offset = "0x2C12270", VA = "0x182C13070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected Mesh EDLHNCIENFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x2C07480", Offset = "0x2C06680", VA = "0x182C07480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool AKNGFFLFKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2C13020", Offset = "0x2C12220", VA = "0x182C13020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string PAANJCAOOAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x862990", Offset = "0x861B90", VA = "0x180862990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2C14650", Offset = "0x2C13850", VA = "0x182C14650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool LMHGKGKNCDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x2C12F90", Offset = "0x2C12190", VA = "0x182C12F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float HDBOICOPFPG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2C12EE0", Offset = "0x2C120E0", VA = "0x182C12EE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2C13120", Offset = "0x2C12320", VA = "0x182C13120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int NBLMMLPFCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2C12F50", Offset = "0x2C12150", VA = "0x182C12F50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2C13350", Offset = "0x2C12550", VA = "0x182C13350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RectTransform DAMCEBLMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8509E0", Offset = "0x84FBE0", VA = "0x1808509E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2C14600", Offset = "0x2C13800", VA = "0x182C14600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TMP_Text GAOOAKOACIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x850950", Offset = "0x84FB50", VA = "0x180850950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2C145B0", Offset = "0x2C137B0", VA = "0x182C145B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Graphic NFNFFNAHAPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x84F900", Offset = "0x84EB00", VA = "0x18084F900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2C13F30", Offset = "0x2C13130", VA = "0x182C13F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Scrollbar DMEHABPKKAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x850840", Offset = "0x84FA40", VA = "0x180850840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2C14770", Offset = "0x2C13970", VA = "0x182C14770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float PAKOCGKNBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xB66080", Offset = "0xB65280", VA = "0x180B66080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2C141A0", Offset = "0x2C133A0", VA = "0x182C141A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Color DLGIEJOLHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2C12EF0", Offset = "0x2C120F0", VA = "0x182C12EF0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2C13190", Offset = "0x2C12390", VA = "0x182C13190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool PHKEONAKJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE75D30", Offset = "0xE74F30", VA = "0x180E75D30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2C137A0", Offset = "0x2C129A0", VA = "0x182C137A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Color DDOJNMCKCKN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2C13010", Offset = "0x2C12210", VA = "0x182C13010")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2C142D0", Offset = "0x2C134D0", VA = "0x182C142D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public SubmitEvent BGNEEOKFCGC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x850710", Offset = "0x84F910", VA = "0x180850710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2C13D00", Offset = "0x2C12F00", VA = "0x182C13D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public SubmitEvent DKKHDPBJKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x850D10", Offset = "0x84FF10", VA = "0x180850D10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2C13DF0", Offset = "0x2C12FF0", VA = "0x182C13DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public SelectionEvent BCHLJNBPNPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xC0BE20", Offset = "0xC0B020", VA = "0x180C0BE20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2C13DA0", Offset = "0x2C12FA0", VA = "0x182C13DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public SelectionEvent LJPBJFEFDKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B70", Offset = "0x6F6D70", VA = "0x1806F7B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2C13CB0", Offset = "0x2C12EB0", VA = "0x182C13CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TextSelectionEvent ENMOLJBNAHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6F78F0", Offset = "0x6F6AF0", VA = "0x1806F78F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2C13E40", Offset = "0x2C13040", VA = "0x182C13E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public TextSelectionEvent HHAPBEDJKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x84F8E0", Offset = "0x84EAE0", VA = "0x18084F8E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2C13D50", Offset = "0x2C12F50", VA = "0x182C13D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public OnChangeEvent CCHCBCLCFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x850BF0", Offset = "0x84FDF0", VA = "0x180850BF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2C13EE0", Offset = "0x2C130E0", VA = "0x182C13EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public CCNHIOBEBOA KFGGMLKECGK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xC0AC90", Offset = "0xC09E90", VA = "0x180C0AC90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2C13E90", Offset = "0x2C13090", VA = "0x182C13E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int DIDPKDLHNBN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2C12F60", Offset = "0x2C12160", VA = "0x182C12F60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2C133F0", Offset = "0x2C125F0", VA = "0x182C133F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float EGCPILNPLKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2C12FD0", Offset = "0x2C121D0", VA = "0x182C12FD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2C13F80", Offset = "0x2C13180", VA = "0x182C13F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TMP_FontAsset GCFIODLCCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x847CE0", Offset = "0x846EE0", VA = "0x180847CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2C13810", Offset = "0x2C12A10", VA = "0x182C13810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LACLMELLCGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1423380", Offset = "0x1422580", VA = "0x181423380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1412EE0", Offset = "0x14120E0", VA = "0x181412EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool CEHNEGPAGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x2C12FE0", Offset = "0x2C121E0", VA = "0x182C12FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x2C140F0", Offset = "0x2C132F0", VA = "0x182C140F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CHEGLKKIPBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x2C12FF0", Offset = "0x2C121F0", VA = "0x182C12FF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2C14100", Offset = "0x2C13300", VA = "0x182C14100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool KAAIKJLFGFP
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2C12FA0", Offset = "0x2C121A0", VA = "0x182C12FA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2C13AD0", Offset = "0x2C12CD0", VA = "0x182C13AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PCKCCEOPIGL
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2C13050", Offset = "0x2C12250", VA = "0x182C13050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2C14760", Offset = "0x2C13960", VA = "0x182C14760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool NCAFECJAAEC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2C12E50", Offset = "0x2C12050", VA = "0x182C12E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TMP_InputField.ContentType KCKBKEKAMDF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6FCD80", Offset = "0x6FBF80", VA = "0x1806FCD80")]
			get
			{
				return default(TMP_InputField.ContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2C134F0", Offset = "0x2C126F0", VA = "0x182C134F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public TMP_InputField.LineType PLOPNEGDJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xC53F80", Offset = "0xC53180", VA = "0x180C53F80")]
			get
			{
				return default(TMP_InputField.LineType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2C13B50", Offset = "0x2C12D50", VA = "0x182C13B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public TMP_InputField.InputType KJNDMFLHLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6FD090", Offset = "0x6FC290", VA = "0x1806FD090")]
			get
			{
				return default(TMP_InputField.InputType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2C139A0", Offset = "0x2C12BA0", VA = "0x182C139A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TouchScreenKeyboardType MLFHHNNDOEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x998440", Offset = "0x997640", VA = "0x180998440")]
			get
			{
				return default(TouchScreenKeyboardType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2C13AE0", Offset = "0x2C12CE0", VA = "0x182C13AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TMP_InputField.CharacterValidation HMCHFOILHPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x13C4240", Offset = "0x13C3440", VA = "0x1813C4240")]
			get
			{
				return default(TMP_InputField.CharacterValidation);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2C13480", Offset = "0x2C12680", VA = "0x182C13480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TMP_InputValidator EPPLBJHBEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2C12F80", Offset = "0x2C12180", VA = "0x182C12F80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2C13A10", Offset = "0x2C12C10", VA = "0x182C13A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Func<string, bool> GOLGMHKKGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2C12F70", Offset = "0x2C12170", VA = "0x182C12F70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2C13950", Offset = "0x2C12B50", VA = "0x182C13950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool BGNEPFGDKHB
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x223B230", Offset = "0x223A430", VA = "0x18223B230")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2C140E0", Offset = "0x2C132E0", VA = "0x182C140E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool DAAFDDDHEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2C13000", Offset = "0x2C12200", VA = "0x182C13000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2C14110", Offset = "0x2C13310", VA = "0x182C14110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool BBKJPKCMMNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2C12FB0", Offset = "0x2C121B0", VA = "0x182C12FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public char EHGCPACOOKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2C12ED0", Offset = "0x2C120D0", VA = "0x182C12ED0")]
			get
			{
				return default(char);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2C130C0", Offset = "0x2C122C0", VA = "0x182C130C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool BFMGMGGLHKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2C13060", Offset = "0x2C12260", VA = "0x182C13060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected int CHFEODECIBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2C0FE90", Offset = "0x2C0F090", VA = "0x182C0FE90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2C0C690", Offset = "0x2C0B890", VA = "0x182C0C690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected int JDLAOAEIGBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2C0C660", Offset = "0x2C0B860", VA = "0x182C0C660")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2C0BF50", Offset = "0x2C0B150", VA = "0x182C0BF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected int OJEPKIDOLDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2C092C0", Offset = "0x2C084C0", VA = "0x182C092C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2C072B0", Offset = "0x2C064B0", VA = "0x182C072B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected int BJKFMKDBNJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2C0A150", Offset = "0x2C09350", VA = "0x182C0A150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2C0B070", Offset = "0x2C0A270", VA = "0x182C0B070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool HHBIHFPBPEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x2C083C0", Offset = "0x2C075C0", VA = "0x182C083C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int LIMFKKIOJCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2C092C0", Offset = "0x2C084C0", VA = "0x182C092C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2C13240", Offset = "0x2C12440", VA = "0x182C13240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public int GALHKIEDLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2C0FE90", Offset = "0x2C0F090", VA = "0x182C0FE90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2C14240", Offset = "0x2C13440", VA = "0x182C14240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int JIFIJDPPPFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x2C092C0", Offset = "0x2C084C0", VA = "0x182C092C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x2C14380", Offset = "0x2C13580", VA = "0x182C14380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int HBEHMEFLOII
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x2C0A150", Offset = "0x2C09350", VA = "0x182C0A150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x2C144F0", Offset = "0x2C136F0", VA = "0x182C144F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int NNHHHMKKBBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x2C0C660", Offset = "0x2C0B860", VA = "0x182C0C660")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2C14410", Offset = "0x2C13610", VA = "0x182C14410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int JAIBIHAADGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x2C0A150", Offset = "0x2C09350", VA = "0x182C0A150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2C14480", Offset = "0x2C13680", VA = "0x182C14480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private static string MGPNHELOFBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1642510", Offset = "0x1641710", VA = "0x181642510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1643070", Offset = "0x1642270", VA = "0x181643070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2C12AE0", Offset = "0x2C11CE0", VA = "0x182C12AE0")]
		protected AG_TMP_InputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AB10", Offset = "0x2C09D10", VA = "0x182C0AB10")]
		protected void GNLDFFIHBNL(ref int IFAIDIKJOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A1D0", Offset = "0x2C093D0", VA = "0x182C0A1D0")]
		protected void FOHLGFNFBHH(ref int IFAIDIKJOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2C10730", Offset = "0x2C0F930", VA = "0x182C10730", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C10040", Offset = "0x2C0F240", VA = "0x182C10040", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C08420", Offset = "0x2C07620", VA = "0x182C08420")]
		private void CIPAFIJGFPH(UnityEngine.Object NLNHFEEMFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AF90", Offset = "0x2C0A190", VA = "0x182C0AF90")]
		[IteratorStateMachine(typeof(ABBELKNBPEB))]
		private IEnumerator IFLEEBBKHHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C07070", Offset = "0x2C06270", VA = "0x182C07070")]
		private void AMNPDKKBKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C09E10", Offset = "0x2C09010", VA = "0x182C09E10")]
		private void FINJJEAKJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C8E0", Offset = "0x2C0BAE0", VA = "0x182C0C8E0")]
		protected void LKIDFHCFCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AFF0", Offset = "0x2C0A1F0", VA = "0x182C0AFF0")]
		protected void ILKEOLFCLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E330", Offset = "0x2C0D530", VA = "0x182C0E330")]
		public void MoveTextEnd(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E510", Offset = "0x2C0D710", VA = "0x182C0E510")]
		public void MoveTextStart(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E690", Offset = "0x2C0D890", VA = "0x182C0E690")]
		public void MoveToEndOfLine(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E880", Offset = "0x2C0DA80", VA = "0x182C0E880")]
		public void MoveToStartOfLine(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C0BFA0", Offset = "0x2C0B1A0", VA = "0x182C0BFA0")]
		private bool KKILEDOIHJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C0D5A0", Offset = "0x2C0C7A0", VA = "0x182C0D5A0", Slot = "51")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C0D4D0", Offset = "0x2C0C6D0", VA = "0x182C0D4D0")]
		private bool LPNBFDALPBB(PointerEventData OEKEOCOGKMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2C0FFA0", Offset = "0x2C0F1A0", VA = "0x182C0FFA0", Slot = "52")]
		public virtual void OnBeginDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2C10350", Offset = "0x2C0F550", VA = "0x182C10350", Slot = "53")]
		public virtual void OnDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A740", Offset = "0x2C09940", VA = "0x182C0A740")]
		[IteratorStateMachine(typeof(HPAOCFBMJAC))]
		private IEnumerator GECGBFHNIHP(PointerEventData OEKEOCOGKMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C10DE0", Offset = "0x2C0FFE0", VA = "0x182C10DE0", Slot = "54")]
		public virtual void OnEndDrag(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C10E40", Offset = "0x2C10040", VA = "0x182C10E40", Slot = "32")]
		public override void OnPointerDown(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C093C0", Offset = "0x2C085C0", VA = "0x182C093C0")]
		protected JHEIPDKDOED ELNLABLFKNG(Event PFFGBOMIOHL)
		{
			return default(JHEIPDKDOED);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B0C0", Offset = "0x2C0A2C0", VA = "0x182C0B0C0")]
		private bool JGOAIDFDMAD(char MBEHODBGOJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C12770", Offset = "0x2C11970", VA = "0x182C12770")]
		public void ProcessEvent(Event CHKKEHOKPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C11700", Offset = "0x2C10900", VA = "0x182C11700", Slot = "55")]
		public virtual void OnUpdateSelected(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2C11450", Offset = "0x2C10650", VA = "0x182C11450", Slot = "56")]
		public virtual void OnScroll(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2C06C30", Offset = "0x2C05E30", VA = "0x182C06C30")]
		private string AEAJLKEPNLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2C11B30", Offset = "0x2C10D30", VA = "0x182C11B30")]
		private int PIAEKONDGNG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2C07CD0", Offset = "0x2C06ED0", VA = "0x182C07CD0")]
		private void CCJLEGAFGKM(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A240", Offset = "0x2C09440", VA = "0x182C0A240")]
		private int GADBOBOJIDE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B950", Offset = "0x2C0AB50", VA = "0x182C0B950")]
		private void JLMEDGAJBEC(bool DIHIAEIGDKB, bool HOIDLFHCBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2C09830", Offset = "0x2C08A30", VA = "0x182C09830")]
		private int FCKJFAJCNGD(int LBJOEJHPBJK, bool LJFNJIAKLFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2C068E0", Offset = "0x2C05AE0", VA = "0x182C068E0")]
		private int AACOJNMNOGE(int LBJOEJHPBJK, bool MNNDCGNNAKB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2C0DCE0", Offset = "0x2C0CEE0", VA = "0x182C0DCE0")]
		private int MJKECNILJFD(int LBJOEJHPBJK, bool LJFNJIAKLFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B520", Offset = "0x2C0A720", VA = "0x182C0B520")]
		private int JJCPPIAOHIM(int LBJOEJHPBJK, bool MNNDCGNNAKB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B110", Offset = "0x2C0A310", VA = "0x182C0B110")]
		private void JHHDGCMNMCN(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B120", Offset = "0x2C0A320", VA = "0x182C0B120")]
		private void JHHDGCMNMCN(bool DIHIAEIGDKB, bool MNNDCGNNAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AB00", Offset = "0x2C09D00", VA = "0x182C0AB00")]
		private void GGFOEKLOLNI(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A7B0", Offset = "0x2C099B0", VA = "0x182C0A7B0")]
		private void GGFOEKLOLNI(bool DIHIAEIGDKB, bool LJFNJIAKLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2C12760", Offset = "0x2C11960", VA = "0x182C12760")]
		private void PNNDENFHNDI(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2C121E0", Offset = "0x2C113E0", VA = "0x182C121E0")]
		private void PNNDENFHNDI(bool DIHIAEIGDKB, bool LJFNJIAKLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C650", Offset = "0x2C0B850", VA = "0x182C0C650")]
		private void LCGOPCFKIPP(bool DIHIAEIGDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C0B0", Offset = "0x2C0B2B0", VA = "0x182C0C0B0")]
		private void LCGOPCFKIPP(bool DIHIAEIGDKB, bool MNNDCGNNAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C11C40", Offset = "0x2C10E40", VA = "0x182C11C40")]
		private void PKGAHIFGEII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C11860", Offset = "0x2C10A60", VA = "0x182C11860")]
		private void PDHKGPEOBBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C0DA60", Offset = "0x2C0CC60", VA = "0x182C0DA60")]
		private void MCMONKBJDEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E110", Offset = "0x2C0D310", VA = "0x182C0E110", Slot = "57")]
		protected virtual void MJLHLGCPKKA(string DBFBLNILIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E1C0", Offset = "0x2C0D3C0", VA = "0x182C0E1C0", Slot = "58")]
		protected virtual void MJLHLGCPKKA(char DBFBLNILIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C09F10", Offset = "0x2C09110", VA = "0x182C09F10")]
		private void FLJBJJLIFHM(char MBEHODBGOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C07250", Offset = "0x2C06450", VA = "0x182C07250")]
		private void BHKGFMKCHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A180", Offset = "0x2C09380", VA = "0x182C0A180")]
		private void FNCJLCDOPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C11AE0", Offset = "0x2C10CE0", VA = "0x182C11AE0")]
		protected void PFONIFOBNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2C09EC0", Offset = "0x2C090C0", VA = "0x182C09EC0")]
		protected void FJLCFFGEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C07200", Offset = "0x2C06400", VA = "0x182C07200")]
		protected void BCDADBPHACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AF40", Offset = "0x2C0A140", VA = "0x182C0AF40")]
		protected void HPALNDEIFIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C08300", Offset = "0x2C07500", VA = "0x182C08300")]
		protected void CDMKFBBJMDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C0FEC0", Offset = "0x2C0F0C0", VA = "0x182C0FEC0")]
		protected void ONPEDNNEFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2C09B70", Offset = "0x2C08D70", VA = "0x182C09B70")]
		protected void FDGABBAAGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C6F0", Offset = "0x2C0B8F0", VA = "0x182C0C6F0")]
		private void LKFFKIONEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2C0DA00", Offset = "0x2C0CC00", VA = "0x182C0DA00")]
		private void MBEGMCEEJNL(float ONGBFDACHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2C07310", Offset = "0x2C06510", VA = "0x182C07310")]
		private void BPOLKAJBDOB(float LKGCBILJGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B490", Offset = "0x2C0A690", VA = "0x182C0B490")]
		private int JIHIOHDMHDH(int FOCIACBBGKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2C0EA50", Offset = "0x2C0DC50", VA = "0x182C0EA50")]
		private int NNAEGEJNCLB(int LIMFKKIOJCM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A230", Offset = "0x2C09430", VA = "0x182C0A230")]
		public void ForceLabelUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A6E0", Offset = "0x2C098E0", VA = "0x182C0A6E0")]
		private void GCOEHHCNFIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2C12780", Offset = "0x2C11980", VA = "0x182C12780", Slot = "59")]
		public virtual void Rebuild(CanvasUpdate JFKDDPJDCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E5820", Offset = "0x3E4A20", VA = "0x1803E5820", Slot = "60")]
		public virtual void LayoutComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3E5820", Offset = "0x3E4A20", VA = "0x1803E5820", Slot = "61")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2C092F0", Offset = "0x2C084F0", VA = "0x182C092F0")]
		private void EGPBCLJAIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2C07530", Offset = "0x2C06730", VA = "0x182C07530")]
		private void CCJJNIFEGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A330", Offset = "0x2C09530", VA = "0x182C0A330")]
		private void GCGNCIIEDJM(Mesh LGFFBNOGPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C9B0", Offset = "0x2C0BBB0", VA = "0x182C0C9B0")]
		private void LKPJIACBDMI(VertexHelper LGFFBNOGPCN, Vector2 HHPJGFCCJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2C0ADB0", Offset = "0x2C09FB0", VA = "0x182C0ADB0")]
		private void HKNGBDDONBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2C0EAE0", Offset = "0x2C0DCE0", VA = "0x182C0EAE0")]
		private void NPGMCAPEBPB(VertexHelper LGFFBNOGPCN, Vector2 HHPJGFCCJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2C085F0", Offset = "0x2C077F0", VA = "0x182C085F0")]
		private void CJDHPCLLGCP(Vector2 FMMMDFONBJG, float CHAKCELLLJD, bool LANOHNACEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F7A0", Offset = "0x2C0E9A0", VA = "0x182C0F7A0")]
		protected char OKAAIIMAHLK(string PAANJCAOOAG, int IFAIDIKJOAC, char OEFNGECBJAP)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2C070B0", Offset = "0x2C062B0", VA = "0x182C070B0")]
		public void ActivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2C06D20", Offset = "0x2C05F20", VA = "0x182C06D20")]
		private void AGAHHMPPAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2C11610", Offset = "0x2C10810", VA = "0x182C11610", Slot = "36")]
		public override void OnSelect(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2C10E10", Offset = "0x2C10010", VA = "0x182C10E10", Slot = "62")]
		public virtual void OnPointerClick(PointerEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3E5820", Offset = "0x3E4A20", VA = "0x1803E5820")]
		public void OnControlClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2C08F60", Offset = "0x2C08160", VA = "0x182C08F60")]
		public void DeactivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2C0FFD0", Offset = "0x2C0F1D0", VA = "0x182C0FFD0", Slot = "37")]
		public override void OnDeselect(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2C11670", Offset = "0x2C10870", VA = "0x182C11670", Slot = "63")]
		public virtual void OnSubmit(BaseEventData OEKEOCOGKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AB50", Offset = "0x2C09D50", VA = "0x182C0AB50")]
		private void GNNGKJGDDLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C900", Offset = "0x2C0BB00", VA = "0x182C0C900")]
		private void LKJOKADIOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2C08ED0", Offset = "0x2C080D0", VA = "0x182C08ED0")]
		private void DOFNHJBBMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2C11A70", Offset = "0x2C10C70", VA = "0x182C11A70")]
		private void PELNFKBIIFO(params TMP_InputField.ContentType[] BAEPNOGNECP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C090", Offset = "0x2C0B290", VA = "0x182C0C090")]
		private void LBBBNGGBNBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C010", Offset = "0x2C0B210", VA = "0x182C0C010")]
		private void LBBBNGGBNBC(TMP_InputField.CharacterValidation HMCHFOILHPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2C09290", Offset = "0x2C08490", VA = "0x182C09290", Slot = "26")]
		protected override void DoStateTransition(SelectionState GKNIHNHGBKC, bool BKDCBHDFBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2C12940", Offset = "0x2C11B40", VA = "0x182C12940")]
		public void SetGlobalPointSize(float EGCPILNPLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2C12850", Offset = "0x2C11A50", VA = "0x182C12850")]
		public void SetGlobalFontAsset(TMP_FontAsset GCFIODLCCKD)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA52A80", Offset = "0xA51C80", VA = "0x180A52A80", Slot = "46")]
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
	[Cpp2IlInjected.Address(RVA = "0x1623C30", Offset = "0x1622E30", VA = "0x181623C30")]
	public static bool LJAEIJLMDHG(ref Color MMHAEEACNOD, Color BCEFAKDFEMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1A8A9E0", Offset = "0x1A89BE0", VA = "0x181A8A9E0")]
	public static bool LBFNDKHKFNH<T>(ref T MMHAEEACNOD, T BCEFAKDFEMM) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1A8ABC0", Offset = "0x1A89DC0", VA = "0x181A8ABC0")]
	public static bool AKJLBMDKGMF<T>(ref T MMHAEEACNOD, T BCEFAKDFEMM) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1A8A990", Offset = "0x1A89B90", VA = "0x181A8A990")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C15700", Offset = "0x2C14900", VA = "0x182C15700")]
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
		[Cpp2IlInjected.Address(RVA = "0x1621260", Offset = "0x1620460", VA = "0x181621260")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x812270", Offset = "0x811470", VA = "0x180812270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Color OADKADHJHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4D4A40", Offset = "0x4D3C40", VA = "0x1804D4A40")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD30", Offset = "0x8BAF30", VA = "0x1808BBD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public PPPKALBKBCI KNLKEEHCIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3FB040", Offset = "0x3FA240", VA = "0x1803FB040")]
		get
		{
			return default(PPPKALBKBCI);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4455B0", Offset = "0x4447B0", VA = "0x1804455B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public float BJJEDIGOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x89A9B0", Offset = "0x899BB0", VA = "0x18089A9B0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x89A9C0", Offset = "0x899BC0", VA = "0x18089A9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool LPHAPKJLKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x44D540", Offset = "0x44C740", VA = "0x18044D540", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x479190", Offset = "0x478390", VA = "0x180479190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2C03B80", Offset = "0x2C02D80", VA = "0x182C03B80", Slot = "4")]
	public void LHDMGIMPNGF(float OKKKBODNINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2C03AE0", Offset = "0x2C02CE0", VA = "0x182C03AE0")]
	public void CJPIEOIKDAO(UnityAction<Color> AFLPGGJMPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x44D540", Offset = "0x44C740", VA = "0x18044D540")]
	public bool EFGINMKOCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x89A9B0", Offset = "0x899BB0", VA = "0x18089A9B0")]
	public float JPCNDKLEFFG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xE3E450", Offset = "0xE3D650", VA = "0x180E3E450", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C14C70", Offset = "0x2C13E70", VA = "0x182C14C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x1621B90", Offset = "0x1620D90", VA = "0x181621B90")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1621BA0", Offset = "0x1620DA0", VA = "0x181621BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public float NEACGKEPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x98F4A0", Offset = "0x98E6A0", VA = "0x18098F4A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x98F4B0", Offset = "0x98E6B0", VA = "0x18098F4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float BJJEDIGOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x87C8F0", Offset = "0x87BAF0", VA = "0x18087C8F0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x87CA40", Offset = "0x87BC40", VA = "0x18087CA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool LPHAPKJLKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3E2910", Offset = "0x3E1B10", VA = "0x1803E2910", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3E2450", Offset = "0x3E1650", VA = "0x1803E2450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2C14A70", Offset = "0x2C13C70", VA = "0x182C14A70", Slot = "4")]
	public void LHDMGIMPNGF(float OKKKBODNINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2C149D0", Offset = "0x2C13BD0", VA = "0x182C149D0")]
	public void CJPIEOIKDAO(UnityAction<float> AFLPGGJMPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3E2910", Offset = "0x3E1B10", VA = "0x1803E2910")]
	public bool EFGINMKOCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x87C8F0", Offset = "0x87BAF0", VA = "0x18087C8F0")]
	public float JPCNDKLEFFG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0xE3E450", Offset = "0xE3D650", VA = "0x180E3E450", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x16C51F0", Offset = "0x16C43F0", VA = "0x1816C51F0")]
		[DebuggerHidden]
		public HLBKKOEPAKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3E5820", Offset = "0x3E4A20", VA = "0x1803E5820", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2387180", Offset = "0x2386380", VA = "0x182387180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x23872B0", Offset = "0x23864B0", VA = "0x1823872B0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x2394630", Offset = "0x2393830", VA = "0x182394630")]
	[IteratorStateMachine(typeof(global::OPBIENGHNOL<>.HLBKKOEPAKM))]
	private static IEnumerator HDGEHNGPFDO(T EPGPDBMBPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC00", Offset = "0x3ECE00", VA = "0x1803EDC00")]
	public void CALJLNMMIPN(MonoBehaviour CMIAMAJBJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x23944D0", Offset = "0x23936D0", VA = "0x1823944D0")]
	public void FPPOJDJCJKI(T DBDDKLHPNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2394720", Offset = "0x2393920", VA = "0x182394720")]
	public void KOAIIMHNKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x152ABA0", Offset = "0x1529DA0", VA = "0x18152ABA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D0F480", Offset = "0x1D0E680", VA = "0x181D0F480")]
	public static List<T> IAHDANBDAAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F5F0", Offset = "0x1D0E7F0", VA = "0x181D0F5F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FB040", Offset = "0x3FA240", VA = "0x1803FB040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4455B0", Offset = "0x4447B0", VA = "0x1804455B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int HHAOOLFNEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1BDA070", Offset = "0x1BD9270", VA = "0x181BDA070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int LCPNJDNOAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1A27C20", Offset = "0x1A26E20", VA = "0x181A27C20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x1BDA0E0", Offset = "0x1BD92E0", VA = "0x181BDA0E0")]
	public DMBLMECIJCJ(UnityAction<T> GOLBLHIPEDI, UnityAction<T> MJNKDEFIDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1BD9E80", Offset = "0x1BD9080", VA = "0x181BD9E80")]
	public T IAHDANBDAAM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1BD9F70", Offset = "0x1BD9170", VA = "0x181BD9F70")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E6C80", Offset = "0x3E5E80", VA = "0x1803E6C80")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2C14CB0", Offset = "0x2C13EB0", VA = "0x182C14CB0")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2C14DB0", Offset = "0x2C13FB0", VA = "0x182C14DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E6C80", Offset = "0x3E5E80", VA = "0x1803E6C80")]
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
