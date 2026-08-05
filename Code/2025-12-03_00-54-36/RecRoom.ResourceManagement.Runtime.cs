using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Async;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.ResourceManagement
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AYZGCBWEQDT
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[CompilerGenerated]
		private sealed class SYNNFXFDNKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public AYZGCBWEQDT BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string ISLTQSUTSNY;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SYNNFXFDNKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x89AEF10", Offset = "0x89ADB10", VA = "0x1889AEF10")]
			internal void LBQXUSERXRF(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x89AEE70", Offset = "0x89ADA70", VA = "0x1889AEE70")]
			internal void LBLQXLKUOFW(GameObject a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly AYZGCBWEQDT IZOEBKDYPHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private Dictionary<string, GameObject> RUJLBTJLRCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<string, GameObject> XWXINWQXGVZ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89AE980", Offset = "0x89AD580", VA = "0x1889AE980")]
		public AYZGCBWEQDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x89AE460", Offset = "0x89AD060", VA = "0x1889AE460", Slot = "1")]
		~AYZGCBWEQDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89AE580", Offset = "0x89AD180", VA = "0x1889AE580")]
		private void HMPBXZLOHLU(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x89AE6A0", Offset = "0x89AD2A0", VA = "0x1889AE6A0")]
		public GameObject UPGUCUWARFK(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89AE680", Offset = "0x89AD280", VA = "0x1889AE680")]
		public PYAXBIZPKFO<GameObject> QAJMPQRZPDS(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89AE6E0", Offset = "0x89AD2E0", VA = "0x1889AE6E0")]
		private GameObject XAWBVEMWUDB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89ADFB0", Offset = "0x89ACBB0", VA = "0x1889ADFB0")]
		public void FKKDFIUOEIF(string a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89AE7B0", Offset = "0x89AD3B0", VA = "0x1889AE7B0")]
		public void YCMNDALDAWS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89AE080", Offset = "0x89ACC80", VA = "0x1889AE080")]
		public PYAXBIZPKFO<GameObject> FKKDFIUOEIF(string a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89AE600", Offset = "0x89AD200", VA = "0x1889AE600")]
		public bool NJTXIVHBYCB(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class COHXJFHZTHW
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3460C20", Offset = "0x345F820", VA = "0x183460C20")]
		public static a BCPRDVDYSGG<a>(string a) where a : UnityEngine.Object
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ResourcesManager : SingletonMonoBehaviour<ResourcesManager>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class ZIIHDKAUKOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string PGKNCCWCZLY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public DMRSXSBMYHB<GameObject> NJJRGFITQLO;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x89AF000", Offset = "0x89ADC00", VA = "0x1889AF000")]
			public ZIIHDKAUKOK(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class XVCGTKCCKDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<ZIIHDKAUKOK> UWBKAXKRSLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> HUVVFXMGSVM;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XVCGTKCCKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x89AEFB0", Offset = "0x89ADBB0", VA = "0x1889AEFB0")]
			internal bool UZZZDRPCQCV()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class AOKYGLRFUJD : IEnumerator<YRPRUNTVYNF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private YRPRUNTVYNF VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<ZIIHDKAUKOK> UWBKAXKRSLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private XVCGTKCCKDJ UFRIJIAVQKY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private ZIIHDKAUKOK WZOONWDZWJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest WZUDOXJPEEC;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private YRPRUNTVYNF AYWYUYDOKDY
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public AOKYGLRFUJD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x89ADC10", Offset = "0x89AC810", VA = "0x1889ADC10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x89ADF70", Offset = "0x89ACB70", VA = "0x1889ADF70", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int XAIXRLTNDQI = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<ZIIHDKAUKOK> QASDTQIYONM;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x89AEC20", Offset = "0x89AD820", VA = "0x1889AEC20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3A2C740", Offset = "0x3A2B340", VA = "0x183A2C740")]
		public PYAXBIZPKFO<T> LoadResourceAsync<T>(string assetName) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x89AEB00", Offset = "0x89AD700", VA = "0x1889AEB00")]
		public PYAXBIZPKFO<GameObject> LoadResourceAsync(string assetName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89AEA90", Offset = "0x89AD690", VA = "0x1889AEA90")]
		[IteratorStateMachine(typeof(AOKYGLRFUJD))]
		private IEnumerator<YRPRUNTVYNF> IETUGRSGVLZ(Queue<ZIIHDKAUKOK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x89AEE30", Offset = "0x89ADA30", VA = "0x1889AEE30")]
		public ResourcesManager()
		{
		}
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
