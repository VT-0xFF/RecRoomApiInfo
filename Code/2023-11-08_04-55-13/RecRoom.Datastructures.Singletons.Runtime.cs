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
	private static HashSet<GameObject> GGCFMENLJKD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static HashSet<UnityEngine.Object> ADBHJKJJGJD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1A20", Offset = "0x5DC0820", VA = "0x185DC1A20")]
	public static void RegisterDontDestroyOnLoad(GameObject OEBPJKHEKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1AD0", Offset = "0x5DC08D0", VA = "0x185DC1AD0")]
	public static void RegisterHideFlagsDontSaveObject(UnityEngine.Object KANAGAAAGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DC16B0", Offset = "0x5DC04B0", VA = "0x185DC16B0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "6")]
	protected virtual void LLLADHNKADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1C50", Offset = "0x5DC0A50", VA = "0x185DC1C50")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JBHHMBFPCPB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2536370", Offset = "0x2535170", VA = "0x182536370")]
	public static void JJPAJKHELIE<T>(this T FMOHLHFOMNJ) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1C90", Offset = "0x5DC0A90", VA = "0x185DC1C90")]
	public static void JJPAJKHELIE(this GameObject CJHJDJNKIGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3776DC0", Offset = "0x3775BC0", VA = "0x183776DC0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3776F10", Offset = "0x3775D10", VA = "0x183776F10", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3776FD0", Offset = "0x3775DD0", VA = "0x183776FD0")]
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
	public GameObject DCHEMEBLILM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA2420", Offset = "0xAA1220", VA = "0x180AA2420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1D70", Offset = "0x5DC0B70", VA = "0x185DC1D70")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1FB0", Offset = "0x5DC0DB0", VA = "0x185DC1FB0")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76DFF0", VA = "0x18076F1F0")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static T PCALNAMFDCK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T ANGIAPALHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3761410", Offset = "0x3760210", VA = "0x183761410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static bool LNODLGKLEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x40F7BC0", Offset = "0x40F69C0", VA = "0x1840F7BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x40F7840", Offset = "0x40F6640", VA = "0x1840F7840", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x40F7B00", Offset = "0x40F6900", VA = "0x1840F7B00", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76DFF0", VA = "0x18076F1F0")]
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
