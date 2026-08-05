using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.Localization.Metadata;
using UnityEngine.Localization.Pseudo;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Localization_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C94520", Offset = "0x6C92F20", VA = "0x186C94520", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace TMPro
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class FontAssetReference : AssetReferenceT<TMP_FontAsset>, IEquatable<FontAssetReference>, IEqualityComparer<FontAssetReference>
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EBB0", Offset = "0x6C8D5B0", VA = "0x186C8EBB0", Slot = "23")]
		public bool Equals(FontAssetReference PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C8ECA0", Offset = "0x6C8D6A0", VA = "0x186C8ECA0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EDB0", Offset = "0x6C8D7B0", VA = "0x186C8EDB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EC80", Offset = "0x6C8D680", VA = "0x186C8EC80", Slot = "24")]
		public bool Equals(FontAssetReference NCPIGLMANIM, FontAssetReference DJBPOPBDKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5B64B00", Offset = "0x5B63500", VA = "0x185B64B00", Slot = "25")]
		public int GetHashCode(FontAssetReference GHMNBJIOGAM)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LazyEmojiSpriteAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private SpriteAssetReference emojiAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private List<string> emojiNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private AsyncOperationHandle<TMP_SpriteAsset> emojiAssetHandle;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public SpriteAssetReference EmojiAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<string> EmojiNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A74A0", Offset = "0x9A5EA0", VA = "0x1809A74A0")]
		public LazyEmojiSpriteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class LazyFallbackFontAsset : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class Range
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			[SerializeField]
			private uint minimum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			[SerializeField]
			private uint maximum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			[SerializeField]
			private byte assetReferenceIndex;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public uint Minimum
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8961A0", Offset = "0x894BA0", VA = "0x1808961A0")]
				get
				{
					return default(uint);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public byte AssetReferenceIndex
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0xAC0390", Offset = "0xABED90", VA = "0x180AC0390")]
				get
				{
					return default(byte);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6C93110", Offset = "0x6C91B10", VA = "0x186C93110")]
			public bool FEAHPDAAGAE(uint CEHLBMNFFHE)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private List<FontAssetReference> fallbackFontAssetReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private List<Range> ranges;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Dictionary<FontAssetReference, AsyncOperationHandle<TMP_FontAsset>> _fallbackFontAssetHandles;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool HasFallbackFontReferences
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6C91150", Offset = "0x6C8FB50", VA = "0x186C91150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyDictionary<FontAssetReference, AsyncOperationHandle<TMP_FontAsset>> FallbackFontAssetHandles
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C90B40", Offset = "0x6C8F540", VA = "0x186C90B40")]
		public bool JIAIJIMEGPN(uint CEHLBMNFFHE, [Out] TMP_FontAsset DHOIIOAJMKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C90E70", Offset = "0x6C8F870", VA = "0x186C90E70")]
		public void LIJBFKFOJOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C90910", Offset = "0x6C8F310", VA = "0x186C90910")]
		public bool CMBAJGMMFPN(FontAssetReference DJMKOFAAMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C90A20", Offset = "0x6C8F420", VA = "0x186C90A20")]
		private bool EBFOKEGABCJ(uint CEHLBMNFFHE, [Out] FontAssetReference DJMKOFAAMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C910C0", Offset = "0x6C8FAC0", VA = "0x186C910C0")]
		public LazyFallbackFontAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class SpriteAssetReference : AssetReferenceT<TMP_SpriteAsset>, IEquatable<SpriteAssetReference>, IEqualityComparer<SpriteAssetReference>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EBB0", Offset = "0x6C8D5B0", VA = "0x186C8EBB0", Slot = "23")]
		public bool Equals(SpriteAssetReference PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C93F30", Offset = "0x6C92930", VA = "0x186C93F30", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EDB0", Offset = "0x6C8D7B0", VA = "0x186C8EDB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EC80", Offset = "0x6C8D680", VA = "0x186C8EC80", Slot = "24")]
		public bool Equals(SpriteAssetReference NCPIGLMANIM, SpriteAssetReference DJBPOPBDKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5B64B00", Offset = "0x5B63500", VA = "0x185B64B00", Slot = "25")]
		public int GetHashCode(SpriteAssetReference GHMNBJIOGAM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CFEDGIGNLEI<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5583370", Offset = "0x5581D70", VA = "0x185583370")]
	public CFEDGIGNLEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FCJICCILHFJ : IEmojiProvider, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LazyEmojiSpriteAsset ELNDFKBECHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AsyncOperationHandle<TMP_SpriteAsset> KPHLNILIIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private TMP_SpriteAsset NBDAAHEFAOG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<string> BGDBDAEPEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x147BB60", Offset = "0x147A560", VA = "0x18147BB60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public TMP_SpriteAsset EPDPKIGKCBF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E830", Offset = "0x6C8D230", VA = "0x186C8E830", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E7E0", Offset = "0x6C8D1E0", VA = "0x186C8E7E0")]
	public FCJICCILHFJ(LazyEmojiSpriteAsset ELNDFKBECHK, bool NMLNNFEEBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E6E0", Offset = "0x6C8D0E0", VA = "0x186C8E6E0")]
	private TMP_SpriteAsset OJOIPBGKGNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E650", Offset = "0x6C8D050", VA = "0x186C8E650", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HPAGHHDJEIB
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BFEHIBHOIAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public BFEHIBHOIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D8A0", Offset = "0x6C8C2A0", VA = "0x186C8D8A0")]
		internal bool GICPMHEKBFA(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F8F0", Offset = "0x6C8E2F0", VA = "0x186C8F8F0")]
	public static List<Locale> EIELFAHGHNI(this LocalizationSettings HDGFLAHCMJL, bool ENAMGCNJDME = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F580", Offset = "0x6C8DF80", VA = "0x186C8F580")]
	public static void CCABCGDGPDA(Locale FKHMDIAJAPB, string HJBMMFEJICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C901F0", Offset = "0x6C8EBF0", VA = "0x186C901F0")]
	public static Locale OEFHFOCKOEF(this LocalizationSettings HDGFLAHCMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C8FBD0", Offset = "0x6C8E5D0", VA = "0x186C8FBD0")]
	private static void LPCFIGOJFGB(string HBLBPFAAKHG, string CGOBPKGFBCG, string MKLJJBDOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C8FB20", Offset = "0x6C8E520", VA = "0x186C8FB20")]
	public static void GALEAKICJMD(this LocalizationSettings HDGFLAHCMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C8FD10", Offset = "0x6C8E710", VA = "0x186C8FD10")]
	public static Locale NINILPBOPKA(this LocalizationSettings HDGFLAHCMJL, string JABKEMAFOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C8FD50", Offset = "0x6C8E750", VA = "0x186C8FD50")]
	public static Locale NINILPBOPKA(this ILocalesProvider PEOCJAHEBJI, string JABKEMAFOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C90020", Offset = "0x6C8EA20", VA = "0x186C90020")]
	public static string NNNPKMJMKLJ(this Locale FKHMDIAJAPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F500", Offset = "0x6C8DF00", VA = "0x186C8F500")]
	public static string CBCBFLCFNKM(this Locale FKHMDIAJAPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F400", Offset = "0x6C8DE00", VA = "0x186C8F400")]
	public static string AAODDDAGPME(this CultureInfo BCDCAAJOPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C90400", Offset = "0x6C8EE00", VA = "0x186C90400")]
	public static string PCKMEMMFPPI(this LocalizedString BLAPDAHCFAP, string LFOBGDLOPID, object KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F8A0", Offset = "0x6C8E2A0", VA = "0x186C8F8A0")]
	public static string DCHCLKLGMEF(this LocalizedString BLAPDAHCFAP, string BAMGCCGAILL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class KJELLADJOGC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct IJCCLALIDJG<T> : IAsyncStateMachine where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public T enumValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x40A8990", Offset = "0x40A7390", VA = "0x1840A8990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x40A90A0", Offset = "0x40A7AA0", VA = "0x1840A90A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class JKDIOHHCFHP<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T enumValue;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public JKDIOHHCFHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x42A1E10", Offset = "0x42A0810", VA = "0x1842A1E10")]
		internal void MAOPDPBEOAO(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly Dictionary<(Type, string), string> OGBKHPBNHNI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly Dictionary<Type, string> MIEPFHJOGOF;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2E494E0", Offset = "0x2E47EE0", VA = "0x182E494E0")]
	private static string IMNAADIDGIK<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C90620", Offset = "0x6C8F020", VA = "0x186C90620")]
	private static bool JFHKNBPBHOK((Type type, string name) KOKGCNKIFHD, [Out] string BNBFBJHKEIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2E48BB0", Offset = "0x2E475B0", VA = "0x182E48BB0")]
	public static string ALBPIICFOMA<T>(this T HBEFBGGFFKD, params object[] GLMADGBENON) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2E492D0", Offset = "0x2E47CD0", VA = "0x182E492D0")]
	[AsyncStateMachine(typeof(IJCCLALIDJG<>))]
	public static Task<string> FALGDBFNOBP<T>(this T HBEFBGGFFKD, params object[] GLMADGBENON) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2E48DF0", Offset = "0x2E477F0", VA = "0x182E48DF0")]
	private static bool CGMBCAHFHNC<T>([Out] string KLABJGGMBGH, T HBEFBGGFFKD, params object[] GLMADGBENON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2E49880", Offset = "0x2E48280", VA = "0x182E49880")]
	private static AsyncOperationHandle<string> NEBHDAPJHOL<T>(T HBEFBGGFFKD, params object[] GLMADGBENON) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C90710", Offset = "0x6C8F110", VA = "0x186C90710")]
	static KJELLADJOGC()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FallbackTableReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private StringTable loadedStringTable;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EB10", Offset = "0x6C8D510", VA = "0x186C8EB10")]
		public void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EA70", Offset = "0x6C8D470", VA = "0x186C8EA70")]
		public void AGDCKPANMGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
		private void PFCFGCANDEL(StringTable PHDKKCCAFIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E840", Offset = "0x6C8D240", VA = "0x186C8E840")]
		public string AFBCKKHKGOG(string LFOBGDLOPID, string BAMGCCGAILL = "", bool FPPDOFKLJHI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public FallbackTableReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PFKDBNFHGFB : IFallbackFontProvider, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DNAGMIOOKGM FLDKOFFFPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LazyFallbackFontAsset KMMCLJOKDED;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C92630", Offset = "0x6C91030", VA = "0x186C92630")]
	public PFKDBNFHGFB(LazyFallbackFontAsset KAPHMNDEJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C91FD0", Offset = "0x6C909D0", VA = "0x186C91FD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C92070", Offset = "0x6C90A70", VA = "0x186C92070", Slot = "4")]
	public TMP_Character TryGetCharacter(HashSet<int> KBEGDHIDHHF, uint CEHLBMNFFHE, TMP_FontAsset POOGPFMJLNP, bool PPFKJNAIDDD, FontStyles KMPFJDKECMN, FontWeight OHFADDDJFBC, [Out] bool FEOKLMMJGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C91FB0", Offset = "0x6C909B0", VA = "0x186C91FB0")]
	private void BLJOMDPFPHC(Scene PAANLKAJOCM)
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[DisplayName("RR Command Line Locale Selector")]
	public class RRCommandLineLocaleSelector : IStartupLocaleSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private string commandLineArgumentPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C928F0", Offset = "0x6C912F0", VA = "0x186C928F0", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider JBCKHHHMCEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6C92E00", Offset = "0x6C91800", VA = "0x186C92E00")]
		public RRCommandLineLocaleSelector()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[DisplayName("RR Player Preferences Locale Selector")]
	public class RRPlayerPrefLocaleSelector : IStartupLocaleSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Tooltip("Should be the default code, but can be the default name as a fallback")]
		public LocaleIdentifier defaultLocaleIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("If no locale can be found, should fallback to the ProjectLocale?")]
		public bool fallbackToProjectLocale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OLBLMMDLAHJ _preferences;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C92E50", Offset = "0x6C91850", VA = "0x186C92E50", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider JBCKHHHMCEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C930B0", Offset = "0x6C91AB0", VA = "0x186C930B0")]
		public RRPlayerPrefLocaleSelector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class LocalizationGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[UnityEngine.Scripting.Preserve]
public class PINDKIPFEKM : JNLBGKCMGIL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string OAGCDGCFJJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C92880", Offset = "0x6C91280", VA = "0x186C92880", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string JIPENAIIAEO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6C92740", Offset = "0x6C91140", VA = "0x186C92740", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FNDFFMLDOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C92820", Offset = "0x6C91220", VA = "0x186C92820", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C927B0", Offset = "0x6C911B0", VA = "0x186C927B0")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void MNJJOBMFJLK(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public PINDKIPFEKM()
	{
	}
}
namespace RecRoom.Localization
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class LocalizedFontConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public class FontAssetReference : AssetReferenceT<TMP_FontAsset>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const string SingletonResourceKey = "LocalizedFontConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Tooltip("JP font")]
		public FontAssetReference FontJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("SC font")]
		public FontAssetReference FontSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Tooltip("KR font")]
		public FontAssetReference FontKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Tooltip("All of the actual CJK type fonts should go here")]
		[FormerlySerializedAs("HighEndLocalizedFonts")]
		[SerializeField]
		private List<FontAssetReference> localizedFonts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private LazyFallbackFontAsset lazyFallbackFontAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private LazyEmojiSpriteAsset lazyEmojiSpriteAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("The font that will contain the fallback chain to CJK")]
		public TMP_FontAsset fallbackFontPlayerBuild;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("An addressable reference to the font that will contain the fallback chains to the CJK fonts")]
		public FontAssetReference fallbackFontAddressable;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IReadOnlyList<FontAssetReference> LocalizedFonts
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public LazyFallbackFontAsset LazyFallbackFontAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LazyEmojiSpriteAsset LazyEmojiSpriteAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x899AA0", Offset = "0x8984A0", VA = "0x180899AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6C91280", Offset = "0x6C8FC80", VA = "0x186C91280")]
		public static LocalizedFontConfig CHOJNGHGONI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6C911A0", Offset = "0x6C8FBA0", VA = "0x186C911A0")]
		public FontAssetReference CFCGHFEGFGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9A74A0", Offset = "0x9A5EA0", VA = "0x1809A74A0")]
		public LocalizedFontConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class LocalizedFontManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CCCPOGOCLHM : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public LocalizedFontManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private AssetReferenceT<TMP_FontAsset> <localeAssetReference>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
			[DebuggerHidden]
			public CCCPOGOCLHM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D8E0", Offset = "0x6C8C2E0", VA = "0x186C8D8E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E040", Offset = "0x6C8CA40", VA = "0x186C8E040", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class JCDMDGDNHHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public TMP_FontAsset fontAsset;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public JCDMDGDNHHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6C90550", Offset = "0x6C8EF50", VA = "0x186C90550")]
			internal void JHMOIHPKKAD(TMP_FontAsset font)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private AsyncOperationHandle<TMP_FontAsset> FJLNHEKLKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private AsyncOperationHandle<TMP_FontAsset> LNPIJGONJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private AsyncOperationHandle<IList<TMP_FontAsset>> CBMEMOKLDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private LocalizedFontConfig JNHFGLCOILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private CDCHCDMFJJO KKMFJEOBINB;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string OACDGDPHPAP = "RR Tools/Localization/Fonts/";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string IOPBCPIHGDO = "RR Tools/Localization/Fonts/Connect Localized Fonts (Editor Time)";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string MENU_PATH_CLEAR = "RR Tools/Localization/Fonts/Clear Localized Fonts";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const string JDDICHNDDBL = "interfaces_2024q1_lazy_load_fallback_fonts";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string OJNGAPMKHFL = "should_lazy_load_fallback_fonts";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string JCACDNDMPEK = "interfaces_2024q1_lazy_load_emojis";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const string NNEAGMEGDDA = "should_lazy_load_emojis";

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C91DF0", Offset = "0x6C907F0", VA = "0x186C91DF0")]
		[IteratorStateMachine(typeof(CCCPOGOCLHM))]
		public IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C91AC0", Offset = "0x6C904C0", VA = "0x186C91AC0")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6C91950", Offset = "0x6C90350", VA = "0x186C91950")]
		private void LIPGNMDNFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C917D0", Offset = "0x6C901D0", VA = "0x186C917D0")]
		private void FOFGEHHCBGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C912D0", Offset = "0x6C8FCD0", VA = "0x186C912D0")]
		private void FOFGEHHCBGB(TMP_FontAsset DHOIIOAJMKC, IReadOnlyList<AssetReference> NJHHAALCHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C91830", Offset = "0x6C90230", VA = "0x186C91830")]
		private void JIOLNMJEOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public LocalizedFontManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Description("Exclude this locale from the picker")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	public class ExcludeFromLanguagePicker : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ExcludeFromLanguagePicker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[Metadata(AllowedTypes = MetadataType.Locale, AllowMultiple = false)]
	public class LocaleDisplayName : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string DisplayName;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LocaleDisplayName()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class LocalizationConstraint : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		protected LocalizationConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[Metadata(AllowedTypes = MetadataType.SharedStringTableEntry, AllowMultiple = false)]
	public class MaximumLengthConstraint : LocalizationConstraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int length;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public MaximumLengthConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[Description("What locale should we send up to the server for the access token claim")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	public class RecNetLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public RecNetLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Description("What locale should we send up to the strings server for localization")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	public class RecNetStringsLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[Metadata(AllowedTypes = MetadataType.LocalizationSettings)]
	public class SkippableKnownText : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public List<string> skippableTexts;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public SkippableKnownText()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C94040", Offset = "0x6C92A40", VA = "0x186C94040", Slot = "4")]
		public void Transform(Message KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OJIKPFMLEIA
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OACPNMOABHH([Optional] CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[RecRoom.NoEngine.Common.Preserve]
public class PEIPCOMAMEH : OJIKPFMLEIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct GCNMFENDPOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EE20", Offset = "0x6C8D820", VA = "0x186C8EE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EFD0", Offset = "0x6C8D9D0", VA = "0x186C8EFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C91E70", Offset = "0x6C90870", VA = "0x186C91E70")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	internal static void MNJJOBMFJLK(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C91EE0", Offset = "0x6C908E0", VA = "0x186C91EE0", Slot = "4")]
	[AsyncStateMachine(typeof(GCNMFENDPOD))]
	public Task OACPNMOABHH([Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public PEIPCOMAMEH()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RecNetLocalizationTableProcessor : ITablePostprocessor, IReset
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class HKHCKEJHHNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public HKHCKEJHHNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6C8F030", Offset = "0x6C8DA30", VA = "0x186C8F030")]
			internal void DJFCKCFDDJE()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private FBEDEGDBDHI retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6C93120", Offset = "0x6C91B20", VA = "0x186C93120")]
		public static EOHNLEPDLDE AIFHKOLJDOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C93380", Offset = "0x6C91D80", VA = "0x186C93380", Slot = "4")]
		public void PostprocessTable(LocalizationTable HEHFECCLFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		private void LBHNEDDJHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6C93DB0", Offset = "0x6C927B0", VA = "0x186C93DB0", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C93E30", Offset = "0x6C92830", VA = "0x186C93E30")]
		public RecNetLocalizationTableProcessor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
internal class FBEDEGDBDHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Dictionary<string, Dictionary<long, string>> BBJJKIBOBAI;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xB8B690", Offset = "0xB8A090", VA = "0x180B8B690")]
	public void HFJFOLKCHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E090", Offset = "0x6C8CA90", VA = "0x186C8E090")]
	public EOHNLEPDLDE AGBPJIGLABF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public FBEDEGDBDHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E440", Offset = "0x6C8CE40", VA = "0x186C8E440")]
	[CompilerGenerated]
	private void CHNLBGBAAFO(Dictionary<string, Dictionary<long, string>> GDLKLCHIEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E540", Offset = "0x6C8CF40", VA = "0x186C8E540")]
	[CompilerGenerated]
	private void EOKOJEHCECA(string KLNAGGGGPDK)
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
