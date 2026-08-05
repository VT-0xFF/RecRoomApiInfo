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
	private static HashSet<GameObject> FBDMMBDONAC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static HashSet<UnityEngine.Object> ABCIHEEODCL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x21DB630", Offset = "0x21DA430", VA = "0x1821DB630")]
	public static void RegisterDontDestroyOnLoad(GameObject OPJJDKDMJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x21DB6F0", Offset = "0x21DA4F0", VA = "0x1821DB6F0")]
	public static void RegisterHideFlagsDontSaveObject(UnityEngine.Object LOPIEGGIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21DB2A0", Offset = "0x21DA0A0", VA = "0x1821DB2A0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "6")]
	protected virtual void ACMIINLKOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21DB850", Offset = "0x21DA650", VA = "0x1821DB850")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NMACHOGDKNA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3677710", Offset = "0x3676510", VA = "0x183677710")]
	public static void PMLJBJPBODI<T>(this T BFKBHAILEEA) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x21DBC50", Offset = "0x21DAA50", VA = "0x1821DBC50")]
	public static void PMLJBJPBODI(this GameObject NGIKODIIBGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37498B0", Offset = "0x37486B0", VA = "0x1837498B0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3749A60", Offset = "0x3748860", VA = "0x183749A60", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3749B10", Offset = "0x3748910", VA = "0x183749B10")]
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
	public GameObject DCLAADPIBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F90", Offset = "0x6F6D90", VA = "0x1806F7F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x21DB8C0", Offset = "0x21DA6C0", VA = "0x1821DB8C0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x21DBB40", Offset = "0x21DA940", VA = "0x1821DBB40")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static T BINMOAHIPCO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T GEHLGJGIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1C0", Offset = "0x6BDFC0", VA = "0x1806BF1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static bool NBPFEPIMLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3C92B50", Offset = "0x3C91950", VA = "0x183C92B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3C925D0", Offset = "0x3C913D0", VA = "0x183C925D0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C92990", Offset = "0x3C91790", VA = "0x183C92990", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2D07CA0", Offset = "0x2D06AA0", VA = "0x182D07CA0")]
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
