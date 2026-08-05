using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class GameRoot : SingletonMonoBehaviour<GameRoot>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static HashSet<GameObject> CELOJHHBMKI;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static HashSet<UnityEngine.Object> DFIBDDGLJJB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5DE62C0", Offset = "0x5DE56C0", VA = "0x185DE62C0")]
	public static void RegisterDontDestroyOnLoad(GameObject IGCNBCNNLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6370", Offset = "0x5DE5770", VA = "0x185DE6370")]
	public static void RegisterHideFlagsDontSaveObject(UnityEngine.Object ECLCDMJMICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5F50", Offset = "0x5DE5350", VA = "0x185DE5F50", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "6")]
	protected virtual void ABJLKDPJEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DE64F0", Offset = "0x5DE58F0", VA = "0x185DE64F0")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PCGNFOIIHLK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2665A20", Offset = "0x2664E20", VA = "0x182665A20")]
	public static void DDEGNPLHGKL<T>(this T AIKEEEBGAIM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6880", Offset = "0x5DE5C80", VA = "0x185DE6880")]
	public static void DDEGNPLHGKL(this GameObject PLLPJJEOIKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3774FA0", Offset = "0x37743A0", VA = "0x183774FA0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x37750F0", Offset = "0x37744F0", VA = "0x1837750F0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37751B0", Offset = "0x37745B0", VA = "0x1837751B0")]
	public InjectedSingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ManagedSingletonObject : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static Dictionary<string, ManagedSingletonObject> managedObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private string guid;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GameObject JPJEGCALIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAEB1F0", Offset = "0xAEA5F0", VA = "0x180AEB1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6530", Offset = "0x5DE5930", VA = "0x185DE6530")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6770", Offset = "0x5DE5B70", VA = "0x185DE6770")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static T OJEBKBIJNNG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T NMGLFNHIICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3601880", Offset = "0x3600C80", VA = "0x183601880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x410EA40", Offset = "0x410DE40", VA = "0x18410EA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x410E6C0", Offset = "0x410DAC0", VA = "0x18410E6C0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x410E980", Offset = "0x410DD80", VA = "0x18410E980", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
	public SingletonMonoBehaviour()
	{
	}
}
namespace Cpp2IlInjected;

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
