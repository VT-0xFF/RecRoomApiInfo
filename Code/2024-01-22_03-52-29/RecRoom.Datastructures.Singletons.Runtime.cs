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
	private static HashSet<GameObject> JCOJMDOCAPB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static HashSet<UnityEngine.Object> HAJGDBHFHFL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6910", Offset = "0x5FE5D10", VA = "0x185FE6910")]
	public static void RegisterDontDestroyOnLoad(GameObject HDHABPIEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FE69C0", Offset = "0x5FE5DC0", VA = "0x185FE69C0")]
	public static void RegisterHideFlagsDontSaveObject(UnityEngine.Object DFFBALIDCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FE65A0", Offset = "0x5FE59A0", VA = "0x185FE65A0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "6")]
	protected virtual void FJPMHMJKEKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6B40", Offset = "0x5FE5F40", VA = "0x185FE6B40")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ADMMLOGNFDO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2C53390", Offset = "0x2C52790", VA = "0x182C53390")]
	public static void MEIFGAIOAIA<T>(this T GHPJMKBNPML) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FE64C0", Offset = "0x5FE58C0", VA = "0x185FE64C0")]
	public static void MEIFGAIOAIA(this GameObject IFGJJHCIEPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x39322D0", Offset = "0x39316D0", VA = "0x1839322D0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3932420", Offset = "0x3931820", VA = "0x183932420", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37A2850", Offset = "0x37A1C50", VA = "0x1837A2850")]
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
	public GameObject KEAFFOELAKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB0B540", Offset = "0xB0A940", VA = "0x180B0B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6B80", Offset = "0x5FE5F80", VA = "0x185FE6B80")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6DC0", Offset = "0x5FE61C0", VA = "0x185FE6DC0")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static T JDMDDMDPEKF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T OKALMGBNAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3E53E60", Offset = "0x3E53260", VA = "0x183E53E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static bool KJBEDCLLEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x426E200", Offset = "0x426D600", VA = "0x18426E200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x426DE80", Offset = "0x426D280", VA = "0x18426DE80", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x426E140", Offset = "0x426D540", VA = "0x18426E140", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
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
