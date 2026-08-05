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
namespace TMPro
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class FontAssetReference : AssetReferenceT<TMP_FontAsset>, IEquatable<FontAssetReference>, IEqualityComparer<FontAssetReference>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6A41960", Offset = "0x6A3FF60", VA = "0x186A41960", Slot = "23")]
		public bool Equals(FontAssetReference BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A41A50", Offset = "0x6A40050", VA = "0x186A41A50", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A41B60", Offset = "0x6A40160", VA = "0x186A41B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A41A30", Offset = "0x6A40030", VA = "0x186A41A30", Slot = "24")]
		public bool Equals(FontAssetReference OCPDJIJPMCG, FontAssetReference DEKMKLPIHFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5906160", Offset = "0x5904760", VA = "0x185906160", Slot = "25")]
		public int GetHashCode(FontAssetReference NJKKPOFFNNJ)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
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
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<string> EmojiNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F7720", Offset = "0x8F5D20", VA = "0x1808F7720")]
		public LazyEmojiSpriteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LazyFallbackFontAsset : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
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
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0")]
				get
				{
					return default(uint);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public byte AssetReferenceIndex
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x8E74D0", Offset = "0x8E5AD0", VA = "0x1808E74D0")]
				get
				{
					return default(byte);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6A45380", Offset = "0x6A43980", VA = "0x186A45380")]
			public bool LGJHGFMDMBF(uint HEPLJPFPDMC)
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
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6A43110", Offset = "0x6A41710", VA = "0x186A43110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyDictionary<FontAssetReference, AsyncOperationHandle<TMP_FontAsset>> FallbackFontAssetHandles
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6A42D50", Offset = "0x6A41350", VA = "0x186A42D50")]
		public bool OOLBKOFBPDG(uint HEPLJPFPDMC, [Out] TMP_FontAsset BMDHFPIEAOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A42B00", Offset = "0x6A41100", VA = "0x186A42B00")]
		public void OCHHCMHHBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A428D0", Offset = "0x6A40ED0", VA = "0x186A428D0")]
		public bool CDKPCKJFBCB(FontAssetReference DNJEBHBJAJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6A429E0", Offset = "0x6A40FE0", VA = "0x186A429E0")]
		private bool JGNJELOONIG(uint HEPLJPFPDMC, [Out] FontAssetReference DNJEBHBJAJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A43080", Offset = "0x6A41680", VA = "0x186A43080")]
		public LazyFallbackFontAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class SpriteAssetReference : AssetReferenceT<TMP_SpriteAsset>, IEquatable<SpriteAssetReference>, IEqualityComparer<SpriteAssetReference>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6A41960", Offset = "0x6A3FF60", VA = "0x186A41960", Slot = "23")]
		public bool Equals(SpriteAssetReference BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A461C0", Offset = "0x6A447C0", VA = "0x186A461C0", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A41B60", Offset = "0x6A40160", VA = "0x186A41B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A41A30", Offset = "0x6A40030", VA = "0x186A41A30", Slot = "24")]
		public bool Equals(SpriteAssetReference OCPDJIJPMCG, SpriteAssetReference DEKMKLPIHFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5906160", Offset = "0x5904760", VA = "0x185906160", Slot = "25")]
		public int GetHashCode(SpriteAssetReference NJKKPOFFNNJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DFGFKGBGJJI<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x58C3220", Offset = "0x58C1820", VA = "0x1858C3220")]
	public DFGFKGBGJJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AMALJAFHHEG : IEmojiProvider, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LazyEmojiSpriteAsset DEKKPCGPPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AsyncOperationHandle<TMP_SpriteAsset> OGGKBKGFJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private TMP_SpriteAsset LGMIIGAFEHD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<string> GKEGAEJGDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1253450", Offset = "0x1251A50", VA = "0x181253450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public TMP_SpriteAsset MCCBFAIFCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FD70", Offset = "0x6A3E370", VA = "0x186A3FD70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FD20", Offset = "0x6A3E320", VA = "0x186A3FD20")]
	public AMALJAFHHEG(LazyEmojiSpriteAsset DEKKPCGPPDC, bool BHOIAOLEPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FC20", Offset = "0x6A3E220", VA = "0x186A3FC20")]
	private TMP_SpriteAsset HABGNFKMODB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FB90", Offset = "0x6A3E190", VA = "0x186A3FB90", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EFAOPEMHLCD
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DKALIFHMHFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public DKALIFHMHFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FEC0", Offset = "0x6A3E4C0", VA = "0x186A3FEC0")]
		internal bool GPNEMLJMMAN(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A41070", Offset = "0x6A3F670", VA = "0x186A41070")]
	public static List<Locale> MPJNAAPJNAJ(this LocalizationSettings PJGJFAMDILE, bool IBOHPLFGLLA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A40480", Offset = "0x6A3EA80", VA = "0x186A40480")]
	public static void BOBMBLAANHE(Locale PJEFLNNGOFG, string EFDMPGECKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A408D0", Offset = "0x6A3EED0", VA = "0x186A408D0")]
	public static Locale DJPKAMGGPDF(this LocalizationSettings PJGJFAMDILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A412A0", Offset = "0x6A3F8A0", VA = "0x186A412A0")]
	private static void OGDMIPBKOHH(string JJPDOPCNHHH, string JKMLBOIOCFP, string MADFKNCBFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A403D0", Offset = "0x6A3E9D0", VA = "0x186A403D0")]
	public static void BGBBDLEEECB(this LocalizationSettings PJGJFAMDILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A41030", Offset = "0x6A3F630", VA = "0x186A41030")]
	public static Locale LJKCENDLPKE(this LocalizationSettings PJGJFAMDILE, string HKDKKJBPOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A40D60", Offset = "0x6A3F360", VA = "0x186A40D60")]
	public static Locale LJKCENDLPKE(this ILocalesProvider LECMHIHADPE, string HKDKKJBPOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A40B40", Offset = "0x6A3F140", VA = "0x186A40B40")]
	public static string FGMAELCPKGE(this Locale PJEFLNNGOFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A40AC0", Offset = "0x6A3F0C0", VA = "0x186A40AC0")]
	public static string DPKMNBBJBPI(this Locale PJEFLNNGOFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A402D0", Offset = "0x6A3E8D0", VA = "0x186A402D0")]
	public static string BDPHOLBOPED(this CultureInfo HGKHMCNBIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A40780", Offset = "0x6A3ED80", VA = "0x186A40780")]
	public static string CDCNHCCLIGA(this LocalizedString ALGJFPNLHLA, string IBBDLGCDELM, object DMNGPNKHPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A40D10", Offset = "0x6A3F310", VA = "0x186A40D10")]
	public static string LFBPDNLGODP(this LocalizedString ALGJFPNLHLA, string LIABCHEHIDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DNDECKBJODM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct POCMODFIGEN<T> : IAsyncStateMachine where T : Enum
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

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x48026B0", Offset = "0x4800CB0", VA = "0x1848026B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4802D50", Offset = "0x4801350", VA = "0x184802D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LLGOHDIJICI<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T enumValue;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public LLGOHDIJICI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x42E6750", Offset = "0x42E4D50", VA = "0x1842E6750")]
		internal void FDLPKJAJIMB(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly Dictionary<(Type, string), string> BFBAONOEAHI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly Dictionary<Type, string> BIDACDICKCI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x29EE800", Offset = "0x29ECE00", VA = "0x1829EE800")]
	private static string ELBHOMFDAEH<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FF00", Offset = "0x6A3E500", VA = "0x186A3FF00")]
	private static bool FCCBKDGCKDA((Type type, string name) JCCLPPFIKMI, [Out] string MLBJAGPCCKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x29EE0E0", Offset = "0x29EC6E0", VA = "0x1829EE0E0")]
	public static string AOMFCFGFJAN<T>(this T ANPOJJGGDDM, params object[] NKMAJMKBAIK) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x29EEBC0", Offset = "0x29ED1C0", VA = "0x1829EEBC0")]
	[AsyncStateMachine(typeof(POCMODFIGEN<>))]
	public static Task<string> IDOJPKJMFMH<T>(this T ANPOJJGGDDM, params object[] NKMAJMKBAIK) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29EE320", Offset = "0x29EC920", VA = "0x1829EE320")]
	private static bool EIELJJOGGBL<T>([Out] string DMNGPNKHPKF, T ANPOJJGGDDM, params object[] NKMAJMKBAIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x29EEDD0", Offset = "0x29ED3D0", VA = "0x1829EEDD0")]
	private static AsyncOperationHandle<string> NBLJDCFONFI<T>(T ANPOJJGGDDM, params object[] NKMAJMKBAIK) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FFF0", Offset = "0x6A3E5F0", VA = "0x186A3FFF0")]
	static DNDECKBJODM()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class FallbackTableReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private StringTable loadedStringTable;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A418C0", Offset = "0x6A3FEC0", VA = "0x186A418C0")]
		public void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6A415F0", Offset = "0x6A3FBF0", VA = "0x186A415F0")]
		public void IHOPKBJIMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x868270", Offset = "0x866870", VA = "0x180868270")]
		private void INGMJNEOJJM(StringTable OJDKPEIOELJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6A41690", Offset = "0x6A3FC90", VA = "0x186A41690")]
		public string KFKAEJLABHG(string IBBDLGCDELM, string LIABCHEHIDJ = "", bool APPJEAMJBHK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public FallbackTableReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GEMONNJLIMD : IFallbackFontProvider, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MCGNCMDOPNA MOHOHNKJPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LazyFallbackFontAsset PEMAGJMFPOM;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6A42250", Offset = "0x6A40850", VA = "0x186A42250")]
	public GEMONNJLIMD(LazyFallbackFontAsset DEDLKBHHDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A41BD0", Offset = "0x6A401D0", VA = "0x186A41BD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A41C90", Offset = "0x6A40290", VA = "0x186A41C90", Slot = "4")]
	public TMP_Character TryGetCharacter(HashSet<int> EFJEJDCPMHC, uint HEPLJPFPDMC, TMP_FontAsset OIDFJOHCBJD, bool GDHFCJKNDPG, FontStyles BJPOKFMPCAH, FontWeight DAGBNFFPJBJ, [Out] bool EPAMIDOCIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6A41C70", Offset = "0x6A40270", VA = "0x186A41C70")]
	private void LLLBJINPABC(Scene KOGJGCFCINN)
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisplayName("RR Command Line Locale Selector")]
	public class RRCommandLineLocaleSelector : IStartupLocaleSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private string commandLineArgumentPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A44B80", Offset = "0x6A43180", VA = "0x186A44B80", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider EELAIDJDMIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6A45090", Offset = "0x6A43690", VA = "0x186A45090")]
		public RRCommandLineLocaleSelector()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
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
		private AFMGBHDOKHL _preferences;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A450E0", Offset = "0x6A436E0", VA = "0x186A450E0", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider EELAIDJDMIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A45320", Offset = "0x6A43920", VA = "0x186A45320")]
		public RRPlayerPrefLocaleSelector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class LocalizationGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[UnityEngine.Scripting.Preserve]
public class KMDAGLHCMOF : HGKNIFHAGBI
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string BKDJOGJGJMN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A42480", Offset = "0x6A40A80", VA = "0x186A42480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string KHAACEFIKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6A423B0", Offset = "0x6A409B0", VA = "0x186A423B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KJDFABJJGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6A42420", Offset = "0x6A40A20", VA = "0x186A42420", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A42340", Offset = "0x6A40940", VA = "0x186A42340")]
	[ILMJIPMJHLC(LIEKAGJMIGB.Root, IAFNNCJJPGN.None)]
	private static void APAJJDIPHPG(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public KMDAGLHCMOF()
	{
	}
}
namespace RecRoom.Localization
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class LocalizedFontConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
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
		[FormerlySerializedAs("HighEndLocalizedFonts")]
		[Tooltip("All of the actual CJK type fonts should go here")]
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
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public LazyFallbackFontAsset LazyFallbackFontAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LazyEmojiSpriteAsset LazyEmojiSpriteAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8736F0", Offset = "0x871CF0", VA = "0x1808736F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6A43240", Offset = "0x6A41840", VA = "0x186A43240")]
		public static LocalizedFontConfig KANMFDGLBND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6A43160", Offset = "0x6A41760", VA = "0x186A43160")]
		public FontAssetReference IEGIBLHFMDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F7720", Offset = "0x8F5D20", VA = "0x1808F7720")]
		public LocalizedFontConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class LocalizedFontManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class MDNEGLDNJNB : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
			[DebuggerHidden]
			public MDNEGLDNJNB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6A443E0", Offset = "0x6A429E0", VA = "0x186A443E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6A44B30", Offset = "0x6A43130", VA = "0x186A44B30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DNGJMGPDDPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public TMP_FontAsset fontAsset;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public DNGJMGPDDPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6A40200", Offset = "0x6A3E800", VA = "0x186A40200")]
			internal void HFHMPECBDIM(TMP_FontAsset font)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private AsyncOperationHandle<TMP_FontAsset> CEMDDNFNGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private AsyncOperationHandle<TMP_FontAsset> CPHMOEBFOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private AsyncOperationHandle<IList<TMP_FontAsset>> JDIIKLBIJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private LocalizedFontConfig NIHBAMBHFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NMMBPCBEFII ICHJIAGMLMC;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string BGLFBJNPAPN = "RR Tools/Localization/Fonts/";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string EAIKLDIAMGO = "RR Tools/Localization/Fonts/Connect Localized Fonts (Editor Time)";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string MENU_PATH_CLEAR = "RR Tools/Localization/Fonts/Clear Localized Fonts";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const string AAGLFFGKBDH = "interfaces_2024q1_lazy_load_fallback_fonts";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string ECMKFHCEGGH = "should_lazy_load_fallback_fonts";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string MFMDHNCLNIG = "interfaces_2024q1_lazy_load_emojis";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const string EKFHCGAPPDI = "should_lazy_load_emojis";

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6A43DA0", Offset = "0x6A423A0", VA = "0x186A43DA0")]
		[IteratorStateMachine(typeof(MDNEGLDNJNB))]
		public IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A43A70", Offset = "0x6A42070", VA = "0x186A43A70")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6A433B0", Offset = "0x6A419B0", VA = "0x186A433B0")]
		private void DKJEGPNJFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6A43A10", Offset = "0x6A42010", VA = "0x186A43A10")]
		private void KFMKCODKFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6A43520", Offset = "0x6A41B20", VA = "0x186A43520")]
		private void KFMKCODKFEC(TMP_FontAsset BMDHFPIEAOD, IReadOnlyList<AssetReference> EHJCIFGCDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6A43290", Offset = "0x6A41890", VA = "0x186A43290")]
		private void BOGCIAFIHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public LocalizedFontManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	[Description("Exclude this locale from the picker")]
	public class ExcludeFromLanguagePicker : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public ExcludeFromLanguagePicker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Metadata(AllowedTypes = MetadataType.Locale, AllowMultiple = false)]
	public class LocaleDisplayName : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string DisplayName;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public LocaleDisplayName()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class LocalizationConstraint : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		protected LocalizationConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Metadata(AllowedTypes = MetadataType.SharedStringTableEntry, AllowMultiple = false)]
	public class MaximumLengthConstraint : LocalizationConstraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int length;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public MaximumLengthConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	[Description("What locale should we send up to the server for the access token claim")]
	public class RecNetLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public RecNetLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[Description("What locale should we send up to the strings server for localization")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	public class RecNetStringsLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Metadata(AllowedTypes = MetadataType.LocalizationSettings)]
	public class SkippableKnownText : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public List<string> skippableTexts;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public SkippableKnownText()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6A462D0", Offset = "0x6A448D0", VA = "0x186A462D0", Slot = "4")]
		public void Transform(Message ELIMFPDKMPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface EFBIKBOBCPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OJLAJHNHBNB([Optional] CancellationToken FIMAIPEFOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[RecRoom.NoEngine.Common.Preserve]
public class DJGPCOFJGCP : EFBIKBOBCPJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct EHFCGJFMOBN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6A413E0", Offset = "0x6A3F9E0", VA = "0x186A413E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6A41590", Offset = "0x6A3FB90", VA = "0x186A41590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FD80", Offset = "0x6A3E380", VA = "0x186A3FD80")]
	[ILMJIPMJHLC(LIEKAGJMIGB.Root, IAFNNCJJPGN.GameOnly)]
	private static void APAJJDIPHPG(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FDF0", Offset = "0x6A3E3F0", VA = "0x186A3FDF0", Slot = "4")]
	[AsyncStateMachine(typeof(EHFCGJFMOBN))]
	public Task OJLAJHNHBNB([Optional] CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public DJGPCOFJGCP()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RecNetLocalizationTableProcessor : ITablePostprocessor, IReset
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class LGHBNHBIDLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public LGHBNHBIDLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6A424F0", Offset = "0x6A40AF0", VA = "0x186A424F0")]
			internal void IJEAFIBKBIN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private MBLFCGFABOI retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6A45390", Offset = "0x6A43990", VA = "0x186A45390")]
		public static GJFFIMHAENI PNLKNBIHCGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6A455F0", Offset = "0x6A43BF0", VA = "0x186A455F0", Slot = "4")]
		public void PostprocessTable(LocalizationTable CJEIFKCEOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		private void KJFPCCHEFCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A46040", Offset = "0x6A44640", VA = "0x186A46040", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A460C0", Offset = "0x6A446C0", VA = "0x186A460C0")]
		public RecNetLocalizationTableProcessor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
internal class MBLFCGFABOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Dictionary<string, Dictionary<long, string>> EHOCGOGINCF;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x961040", Offset = "0x95F640", VA = "0x180961040")]
	public void DLNFBBLAENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A44030", Offset = "0x6A42630", VA = "0x186A44030")]
	public GJFFIMHAENI OEIICADHOOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public MBLFCGFABOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A43F30", Offset = "0x6A42530", VA = "0x186A43F30")]
	[CompilerGenerated]
	private void MDBKOMNPDMI(Dictionary<string, Dictionary<long, string>> FIMBIGPLPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A43E20", Offset = "0x6A42420", VA = "0x186A43E20")]
	[CompilerGenerated]
	private void DNCPJKBADCK(string KFOCKGMHIBO)
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
