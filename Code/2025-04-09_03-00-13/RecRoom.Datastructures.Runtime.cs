using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x789A540", Offset = "0x7899940", VA = "0x18789A540")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KCOHLBGGNDN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1F4D190", Offset = "0x1F4C590", VA = "0x181F4D190")]
	public KCOHLBGGNDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, LKHFDMEDDEH, ELOKANIMHDL, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A9260", Offset = "0x9A8660", VA = "0x1809A9260", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash FJJIBEAAGGP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xB034E0", Offset = "0xB028E0", VA = "0x180B034E0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x789B710", Offset = "0x789AB10", VA = "0x18789B710")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x789B6D0", Offset = "0x789AAD0", VA = "0x18789B6D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x789B750", Offset = "0x789AB50", VA = "0x18789B750")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x789B900", Offset = "0x789AD00", VA = "0x18789B900")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x789B870", Offset = "0x789AC70", VA = "0x18789B870")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE36A60", Offset = "0xE35E60", VA = "0x180E36A60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xC8B0A0", Offset = "0xC8A4A0", VA = "0x180C8B0A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x789B690", Offset = "0x789AA90", VA = "0x18789B690")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x789B7E0", Offset = "0x789ABE0", VA = "0x18789B7E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x789B130", Offset = "0x789A530", VA = "0x18789B130")]
	public void CopyBounds(SavedExtents KNCKFHOKGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x789B5E0", Offset = "0x789A9E0", VA = "0x18789B5E0")]
	public void SetLocalSpaceBounds(Bounds PDOHOPOOJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x131EF20", Offset = "0x131E320", VA = "0x18131EF20")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x789B5D0", Offset = "0x789A9D0", VA = "0x18789B5D0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x789B220", Offset = "0x789A620", VA = "0x18789B220")]
	private void OJLOLFCDNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x789B3D0", Offset = "0x789A7D0", VA = "0x18789B3D0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x789AAF0", Offset = "0x7899EF0", VA = "0x18789AAF0")]
	public static void CalculateLocalBoundsFor(GameObject GIIGFIAPGGB, [Out] Bounds PDOHOPOOJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x789B160", Offset = "0x789A560", VA = "0x18789B160")]
	private static void EBNIJNOKPBG(Bounds IAJJOLNCJOI, Color NOBKOCLLFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x789B600", Offset = "0x789AA00", VA = "0x18789B600")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9A9250", Offset = "0x9A8650", VA = "0x1809A9250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xE79CD0", Offset = "0xE790D0", VA = "0x180E79CD0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x555C140", Offset = "0x555B540", VA = "0x18555C140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
	public virtual void FDEMLEMBLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[KCOHLBGGNDN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x555BCB0", Offset = "0x555B0B0", VA = "0x18555BCB0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x555A880", Offset = "0x5559C80", VA = "0x18555A880", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x555C060", Offset = "0x555B460", VA = "0x18555C060")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class NFGICKHLCDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NFGICKHLCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x50E2700", Offset = "0x50E1B00", VA = "0x1850E2700")]
		internal int OOFNDENFDCA(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[KCOHLBGGNDN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x430EA30", Offset = "0x430DE30", VA = "0x18430EA30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x430EA90", Offset = "0x430DE90", VA = "0x18430EA90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x430E910", Offset = "0x430DD10", VA = "0x18430E910", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey DJBLFBEBKGO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x430E9D0", Offset = "0x430DDD0", VA = "0x18430E9D0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x430E7C0", Offset = "0x430DBC0", VA = "0x18430E7C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x430E460", Offset = "0x430D860", VA = "0x18430E460", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x430D820", Offset = "0x430CC20", VA = "0x18430D820", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x430D7C0", Offset = "0x430CBC0", VA = "0x18430D7C0", Slot = "14")]
	protected virtual string LPHMDCIGNBF(TKeyVal DPDEDCODDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x430D690", Offset = "0x430CA90", VA = "0x18430D690", Slot = "4")]
	public bool ContainsKey(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x430E640", Offset = "0x430DA40", VA = "0x18430E640", Slot = "5")]
	public bool TryGetValue(TKey DJBLFBEBKGO, [Out] TVal FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x430D6F0", Offset = "0x430CAF0", VA = "0x18430D6F0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x430D6F0", Offset = "0x430CAF0", VA = "0x18430D6F0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x430E6A0", Offset = "0x430DAA0", VA = "0x18430E6A0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	[SerializeReference]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x425AAD0", Offset = "0x4259ED0", VA = "0x18425AAD0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[KCOHLBGGNDN]
	[SerializeField]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x555DB30", Offset = "0x555CF30", VA = "0x18555DB30")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x555D370", Offset = "0x555C770", VA = "0x18555D370", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x555C920", Offset = "0x555BD20", VA = "0x18555C920", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class HBJFAKOLEKH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct JBKJCAGJBMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T HDKOPKMNJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float LHAHEJJDJJP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int HGJKHNPMCNL = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float FLMLCHPGFMG = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly JBKJCAGJBMA[] LLPLHOOOAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int MPFDDBGHHCF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float GMEBDPLAFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB62380", Offset = "0xB61780", VA = "0x180B62380")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xBC5750", Offset = "0xBC4B50", VA = "0x180BC5750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T FHLINHJNANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x48F9FF0", Offset = "0x48F93F0", VA = "0x1848F9FF0")]
	protected HBJFAKOLEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x48FA030", Offset = "0x48F9430", VA = "0x1848FA030")]
	protected HBJFAKOLEKH(int MNDMOIHIBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x48F9EE0", Offset = "0x48F92E0", VA = "0x1848F9EE0")]
	public void JJBKLNLGAIJ(float GLBFMHKMALN, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool NCNJNAKOCKM(float AAHABAEBMKI, float JJDOOOBNCBG, [Out] T FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool JNMGJCLIHOD(float AAHABAEBMKI, float JJDOOOBNCBG, [Out] T FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x48F9D50", Offset = "0x48F9150", VA = "0x1848F9D50")]
	public void CJEMNCEDADJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BKJKMEGFBDN : HBJFAKOLEKH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7896810", Offset = "0x7895C10", VA = "0x187896810", Slot = "4")]
	public override bool NCNJNAKOCKM(float AAHABAEBMKI, float JJDOOOBNCBG, [Out] Vector3 FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x78966D0", Offset = "0x7895AD0", VA = "0x1878966D0", Slot = "5")]
	public override bool JNMGJCLIHOD(float AAHABAEBMKI, float JJDOOOBNCBG, [Out] Vector3 FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7896970", Offset = "0x7895D70", VA = "0x187896970")]
	public BKJKMEGFBDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OCPHFAFGDLD
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3803EB0", Offset = "0x38032B0", VA = "0x183803EB0")]
	public static FFBPAJLKGII<T1, T2> GNHEPACBJCH<T1, T2>(T1 CEPEJICMGPN, T2 PJFDPDEPNKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3803F50", Offset = "0x3803350", VA = "0x183803F50")]
	public static FHPLGJCPPKH<T1, T2, T3> GNHEPACBJCH<T1, T2, T3>(T1 CEPEJICMGPN, T2 PJFDPDEPNKI, T3 MMPFIAOEEJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x50C29F0", Offset = "0x50C1DF0", VA = "0x1850C29F0")]
	internal static int LPMAGMDFHMP(int CAPDDMICJHD, int ENEMLCKKGOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC500", Offset = "0x6AEB900", VA = "0x186AEC500")]
	internal static int LPMAGMDFHMP(int CAPDDMICJHD, int ENEMLCKKGOC, int DJNCHHMNCJM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FFBPAJLKGII<T1, T2> : IComparable<FFBPAJLKGII<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 CMCIHGKDMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 PIGNFBLMIFK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4721C70", Offset = "0x4721070", VA = "0x184721C70")]
	public FFBPAJLKGII(T1 CEPEJICMGPN, T2 PJFDPDEPNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4720370", Offset = "0x471F770", VA = "0x184720370", Slot = "4")]
	public int CompareTo(FFBPAJLKGII<T1, T2> KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4720BF0", Offset = "0x471FFF0", VA = "0x184720BF0", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4720ED0", Offset = "0x47202D0", VA = "0x184720ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x47214B0", Offset = "0x47208B0", VA = "0x1847214B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FHPLGJCPPKH<T1, T2, T3> : IComparable<FHPLGJCPPKH<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 CMCIHGKDMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 PIGNFBLMIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 PIANNFJNJGP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x475AC50", Offset = "0x475A050", VA = "0x18475AC50")]
	public FHPLGJCPPKH(T1 CEPEJICMGPN, T2 PJFDPDEPNKI, T3 MMPFIAOEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x475A440", Offset = "0x4759840", VA = "0x18475A440", Slot = "4")]
	public int CompareTo(FHPLGJCPPKH<T1, T2, T3> KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x475A6B0", Offset = "0x4759AB0", VA = "0x18475A6B0", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x475A8F0", Offset = "0x4759CF0", VA = "0x18475A8F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x475A990", Offset = "0x4759D90", VA = "0x18475A990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve MNCLLABCAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T JMAAAPLCODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x11A9300", Offset = "0x11A8700", VA = "0x1811A9300")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T DLLCDPIEFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB52830", Offset = "0xB51C30", VA = "0x180B52830")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E890", Offset = "0x2A1DC90", VA = "0x182A1E890")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E7E0", Offset = "0x2A1DBE0", VA = "0x182A1E7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float CLFKKIOCMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xB4D100", Offset = "0xB4C500", VA = "0x180B4D100")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x57FF090", Offset = "0x57FE490", VA = "0x1857FF090")]
	public T POKGMNHINPB(float OOLNPDLPIEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x57FEE70", Offset = "0x57FE270", VA = "0x1857FEE70")]
	public T JKGLJIOALDN(float OOLNPDLPIEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LEPHLCNAIOB(T BICHNBDCKLH, T CKCKMBIGMMF, float OOLNPDLPIEB);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7897810", Offset = "0x7896C10", VA = "0x187897810", Slot = "4")]
	protected override float LEPHLCNAIOB(float BICHNBDCKLH, float CKCKMBIGMMF, float OOLNPDLPIEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7897850", Offset = "0x7896C50", VA = "0x187897850")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x15F3B70", Offset = "0x15F2F70", VA = "0x1815F3B70", Slot = "4")]
	protected override Vector3 LEPHLCNAIOB(Vector3 BICHNBDCKLH, Vector3 CKCKMBIGMMF, float OOLNPDLPIEB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x789C6D0", Offset = "0x789BAD0", VA = "0x18789C6D0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7896AB0", Offset = "0x7895EB0", VA = "0x187896AB0", Slot = "4")]
	protected override Color LEPHLCNAIOB(Color BICHNBDCKLH, Color CKCKMBIGMMF, float OOLNPDLPIEB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7896B70", Offset = "0x7895F70", VA = "0x187896B70")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HBEBANAGJFM : PJEGKALNPFE<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7898970", Offset = "0x7897D70", VA = "0x187898970")]
	public HBEBANAGJFM(int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7898900", Offset = "0x7897D00", VA = "0x187898900", Slot = "6")]
	protected override uint NODBEKNMJCK(uint FJJIBEAAGGP, string FFOEEMKIKJO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LGEKACGMFJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable DNEPPKLGBFA;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public LGEKACGMFJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct OBJHIMBOAOB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CLKDLLHEAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int HALBMBHIMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int HFFLKMOEJFN;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x477FA90", Offset = "0x477EE90", VA = "0x18477FA90")]
	private OBJHIMBOAOB(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HAGBHIMNECF, int PEAMCKLLHAK, int KFIDAOBPDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x52094D0", Offset = "0x52088D0", VA = "0x1852094D0")]
	public static OBJHIMBOAOB<T> HBLBJMFGHFK()
	{
		return default(OBJHIMBOAOB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x52095D0", Offset = "0x52089D0", VA = "0x1852095D0")]
	public (int, int, Task<T>) JBEILPHNOEM(int GIBMIJMGIIO, [Optional] CancellationToken LMNHDKIFBOH, double PCFGHPNONAI = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x520B410", Offset = "0x520A810", VA = "0x18520B410")]
	public void MKOCGHEOGGO(int GIBMIJMGIIO, int KFIDAOBPDOI, [In] T HBALBIOOGIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KLOBCFPPNGL
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7899010", Offset = "0x7898410", VA = "0x187899010")]
	public static OBJHIMBOAOB<LPCAMBCOBBH> HBLBJMFGHFK()
	{
		return default(OBJHIMBOAOB<LPCAMBCOBBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7899060", Offset = "0x7898460", VA = "0x187899060")]
	public static void MKOCGHEOGGO([In] this OBJHIMBOAOB<LPCAMBCOBBH> JOCJBPPJMJJ, int GIBMIJMGIIO, int KFIDAOBPDOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class CCEPICLLJMB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> MMAENBAOCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> ILFDPFBIANN;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7C60", Offset = "0x3EA7060", VA = "0x183EA7C60", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HMHCPPJANGM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> JPBJOHHNBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x474E960", Offset = "0x474DD60", VA = "0x18474E960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> BDMOHMNBJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x42FE060", Offset = "0x42FD460", VA = "0x1842FE060", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x62FBD20", Offset = "0x62FB120", VA = "0x1862FBD20", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x62FBDC0", Offset = "0x62FB1C0", VA = "0x1862FBDC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62FB1A0", Offset = "0x62FA5A0", VA = "0x1862FB1A0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x62FB200", Offset = "0x62FA600", VA = "0x1862FB200", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x62FBB00", Offset = "0x62FAF00", VA = "0x1862FBB00", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x62FAFE0", Offset = "0x62FA3E0", VA = "0x1862FAFE0", Slot = "9")]
	public void Add(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x62FAF90", Offset = "0x62FA390", VA = "0x1862FAF90", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x62FB2A0", Offset = "0x62FA6A0", VA = "0x1862FB2A0", Slot = "8")]
	public bool ContainsKey(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62FB330", Offset = "0x62FA730", VA = "0x1862FB330", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x62FBA40", Offset = "0x62FAE40", VA = "0x1862FBA40", Slot = "10")]
	public bool Remove(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x62FBAC0", Offset = "0x62FAEC0", VA = "0x1862FBAC0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x62FBBA0", Offset = "0x62FAFA0", VA = "0x1862FBBA0", Slot = "11")]
	public bool TryGetValue(TKey DJBLFBEBKGO, [Out] TVal FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x62FB3F0", Offset = "0x62FA7F0", VA = "0x1862FB3F0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x62FB370", Offset = "0x62FA770", VA = "0x1862FB370", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LLPLHOOOAEB, int KIMBCLMGPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x62FB0E0", Offset = "0x62FA4E0", VA = "0x1862FB0E0")]
	public bool BGPIDOLLEKE(TVal DJBLFBEBKGO, [Out] TKey FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x62FB490", Offset = "0x62FA890", VA = "0x1862FB490")]
	private void HBAAKKDANCD(TKey DJBLFBEBKGO, TVal PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x62FB720", Offset = "0x62FAB20", VA = "0x1862FB720")]
	private void IEAMEODBOFE(TKey DJBLFBEBKGO, TVal PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x62FB810", Offset = "0x62FAC10", VA = "0x1862FB810")]
	private bool KJOCGPOLNFE(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x62FBC00", Offset = "0x62FB000", VA = "0x1862FBC00")]
	public CCEPICLLJMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class DCBIKFPCNEG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private DCBIKFPCNEG<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x4367430", Offset = "0x4366830", VA = "0x184367430", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4369190", Offset = "0x4368590", VA = "0x184369190", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x436A150", Offset = "0x4369550", VA = "0x18436A150")]
		public Enumerator(DCBIKFPCNEG<T> DAMDACDIHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4367810", Offset = "0x4366C10", VA = "0x184367810", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4368A60", Offset = "0x4367E60", VA = "0x184368A60", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x43676F0", Offset = "0x4366AF0", VA = "0x1843676F0")]
		private void MJFHKHIAHDO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] HHOLFJLOEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int GNPKFMEIDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int HGILLAMPJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int IOFNCNFBMGK;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x66BED60", Offset = "0x66BE160", VA = "0x1866BED60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x66BE990", Offset = "0x66BDD90", VA = "0x1866BE990")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x66BF6D0", Offset = "0x66BEAD0", VA = "0x1866BF6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x66C0AB0", Offset = "0x66BFEB0", VA = "0x1866C0AB0")]
	public DCBIKFPCNEG(int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x66BFF60", Offset = "0x66BF360", VA = "0x1866BFF60")]
	public void JJBKLNLGAIJ(T OOLNPDLPIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x66BEC30", Offset = "0x66BE030", VA = "0x1866BEC30")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x66BF9C0", Offset = "0x66BEDC0", VA = "0x1866BF9C0")]
	public void JCBOCJJKOIJ(int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x66BF080", Offset = "0x66BE480", VA = "0x1866BF080")]
	public void DHDJJANPOHF(T[] LLPLHOOOAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x66BEC50", Offset = "0x66BE050", VA = "0x1866BEC50")]
	public Enumerator DBEEDGEHMMA()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x66C07D0", Offset = "0x66BFBD0", VA = "0x1866C07D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x66C07D0", Offset = "0x66BFBD0", VA = "0x1866C07D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x66C0540", Offset = "0x66BF940", VA = "0x1866C0540")]
	private int LAJNFGCLFAP(int CJFNAFNJJLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x66C07A0", Offset = "0x66BFBA0", VA = "0x1866C07A0")]
	private int OEIOIFOFKPN(int CJFNAFNJJLB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IEPIFCAFPHB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> EDCLFPAMPKP(TRequest ANMDEHLLLBJ, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum BFIEPAHAOLK
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class GEEEPANNAOI
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float EFCEMNBMNEP = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan JOKCGLHLIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int JGJAOPENFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public BFIEPAHAOLK HBKMBEFMMFJ;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly GEEEPANNAOI AMGMCPILGIN;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float IFFCLMFGDFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4849B30", Offset = "0x4848F30", VA = "0x184849B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan FPIIMLNEMLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4849C80", Offset = "0x4849080", VA = "0x184849C80")]
		public GEEEPANNAOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct PCIAOFDDEAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest ANMDEHLLLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken LMNHDKIFBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> LNFGEEIEIAH;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x52FAC00", Offset = "0x52FA000", VA = "0x1852FAC00")]
		public PCIAOFDDEAD(TRequest ANMDEHLLLBJ, TaskCompletionSource<TResult> LNFGEEIEIAH, CancellationToken LMNHDKIFBOH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct AANDKJJGMHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IEPIFCAFPHB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x47F87A0", Offset = "0x47F7BA0", VA = "0x1847F87A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x47F8C00", Offset = "0x47F8000", VA = "0x1847F8C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct JNANGDFDDIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IEPIFCAFPHB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private PCIAOFDDEAD <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4C82D80", Offset = "0x4C82180", VA = "0x184C82D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4C83360", Offset = "0x4C82760", VA = "0x184C83360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource EBBFGPINMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<PCIAOFDDEAD> MNGAJNBHCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GEEEPANNAOI AKKMPCJGDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly EDCLFPAMPKP ADMLHNKOHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task NLKKAPLIOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int BELOHMKLAOG;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4A0D550", Offset = "0x4A0C950", VA = "0x184A0D550")]
	public IEPIFCAFPHB(EDCLFPAMPKP ADMLHNKOHEB, [Optional] GEEEPANNAOI AKKMPCJGDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4A0BFE0", Offset = "0x4A0B3E0", VA = "0x184A0BFE0")]
	public Task<TResult> JJBONKGMIAG(TRequest ANMDEHLLLBJ, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4A0BF10", Offset = "0x4A0B310", VA = "0x184A0BF10")]
	private void HFPJPDLPCLC(PCIAOFDDEAD COPAOJNOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4A0BC90", Offset = "0x4A0B090", VA = "0x184A0BC90")]
	[AsyncStateMachine(typeof(IEPIFCAFPHB<, >.AANDKJJGMHD))]
	private Task EJIHFGDFJGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4A0C990", Offset = "0x4A0BD90", VA = "0x184A0C990")]
	private PCIAOFDDEAD NOAIAJECHLE()
	{
		return default(PCIAOFDDEAD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4A0C7A0", Offset = "0x4A0BBA0", VA = "0x184A0C7A0")]
	[AsyncStateMachine(typeof(IEPIFCAFPHB<, >.JNANGDFDDIK))]
	private Task JOEBCLJNEFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4A0B8B0", Offset = "0x4A0ACB0", VA = "0x184A0B8B0")]
	private void BOBKBEJPCHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4A0BAB0", Offset = "0x4A0AEB0", VA = "0x184A0BAB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class PNPJPACFHAL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> CEFIHBLEFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> LCLDLOCJKKK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7C60", Offset = "0x3EA7060", VA = "0x183EA7C60", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HMHCPPJANGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x38ED830", Offset = "0x38ECC30", VA = "0x1838ED830", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x535AED0", Offset = "0x535A2D0", VA = "0x18535AED0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x47962F0", Offset = "0x47956F0", VA = "0x1847962F0", Slot = "11")]
	public void Add(T MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x535A750", Offset = "0x5359B50", VA = "0x18535A750")]
	public bool KHHMKEEJKGJ(T MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x535ABB0", Offset = "0x5359FB0", VA = "0x18535ABB0", Slot = "15")]
	public bool Remove(T MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5061C90", Offset = "0x5061090", VA = "0x185061C90", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x47C97F0", Offset = "0x47C8BF0", VA = "0x1847C97F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x535A270", Offset = "0x5359670", VA = "0x18535A270", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x535A310", Offset = "0x5359710", VA = "0x18535A310", Slot = "13")]
	public bool Contains(T MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x535A360", Offset = "0x5359760", VA = "0x18535A360", Slot = "14")]
	public void CopyTo(T[] LLPLHOOOAEB, int KIMBCLMGPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4E0A5D0", Offset = "0x4E099D0", VA = "0x184E0A5D0", Slot = "6")]
	public int IndexOf(T MGCEJOCCONP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x535A3C0", Offset = "0x53597C0", VA = "0x18535A3C0", Slot = "7")]
	public void Insert(int CJFNAFNJJLB, T MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x535A850", Offset = "0x5359C50", VA = "0x18535A850", Slot = "8")]
	public void RemoveAt(int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x535AC70", Offset = "0x535A070", VA = "0x18535AC70")]
	public PNPJPACFHAL()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x28A28E0", Offset = "0x28A1CE0", VA = "0x1828A28E0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x23F9CA0", Offset = "0x23F90A0", VA = "0x1823F9CA0")]
		public SerializedGuid([In] Guid KDBHLLEACIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x789BB10", Offset = "0x789AF10", VA = "0x18789BB10")]
		public static SerializedGuid JOIDBKAHEAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x789BAA0", Offset = "0x789AEA0", VA = "0x18789BAA0")]
		public static SerializedGuid JCPJDEJENHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x789BB90", Offset = "0x789AF90", VA = "0x18789BB90")]
		public bool KCBHPIPJOPL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x789BC70", Offset = "0x789B070", VA = "0x18789BC70", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x789BBF0", Offset = "0x789AFF0", VA = "0x18789BBF0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x789B9C0", Offset = "0x789ADC0", VA = "0x18789B9C0", Slot = "7")]
		public bool Equals(SerializedGuid KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x789BA00", Offset = "0x789AE00", VA = "0x18789BA00", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x789BA90", Offset = "0x789AE90", VA = "0x18789BA90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x789B990", Offset = "0x789AD90", VA = "0x18789B990", Slot = "6")]
		public int CompareTo(SerializedGuid KNCKFHOKGJM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NAPJEGFLAEO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type NHHPIACHOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string FOBGOIBFLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool AIHFIMGFLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool LPPCMCBIDHJ;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x789A4D0", Offset = "0x78998D0", VA = "0x18789A4D0")]
	public NAPJEGFLAEO(Type FCENGGJIDNA, string MEHBCEOHLFK, bool FJGPONGLDJF = false, bool FMOKPJDOKBA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BAIOKONMKJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int CABELAFBBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> GFLOCMEJEDF(float GLBFMHKMALN, [Optional] float? AHIKEFMGEKC);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NJEOCINJPPK(float GLBFMHKMALN, T FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJEMNCEDADJ();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class FIEPLLDLKLJ<T> : BAIOKONMKJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class BGFGMGHIBJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float OKGGONCOGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T HDKOPKMNJCH;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BGFGMGHIBJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MCNOPHBJLOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MCNOPHBJLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x504A410", Offset = "0x5049810", VA = "0x18504A410")]
		internal bool JNKILBHFNEN(BGFGMGHIBJB sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float LMJKHCBKNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float BPAHIDGOPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<BGFGMGHIBJB> EJNHCEEFLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private MAEKECGNICD<BGFGMGHIBJB> LEABAFMLNDM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int CABELAFBBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x475D160", Offset = "0x475C560", VA = "0x18475D160", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x475D560", Offset = "0x475C960", VA = "0x18475D560")]
	public FIEPLLDLKLJ(float EDPKCBHJJIM, float JFFGOMGDEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x475D1D0", Offset = "0x475C5D0", VA = "0x18475D1D0", Slot = "6")]
	public bool NJEOCINJPPK(float GLBFMHKMALN, T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x475CBD0", Offset = "0x475BFD0", VA = "0x18475CBD0", Slot = "5")]
	public IEnumerable<T> GFLOCMEJEDF(float GLBFMHKMALN, float? AHIKEFMGEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x475C7B0", Offset = "0x475BBB0", VA = "0x18475C7B0", Slot = "7")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x475CF40", Offset = "0x475C340", VA = "0x18475CF40")]
	private void IKKDDNFEAMI(float GLBFMHKMALN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FOPFBPHAIDO<T> : BAIOKONMKJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct ACEHAEGGKAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T HDKOPKMNJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float OKGGONCOGKK;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x48034D0", Offset = "0x48028D0", VA = "0x1848034D0")]
		public ACEHAEGGKAI(T FFOEEMKIKJO, float GLBFMHKMALN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class FEPKFECIALC : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public FOPFBPHAIDO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
		[DebuggerHidden]
		public FEPKFECIALC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x471F620", Offset = "0x471EA20", VA = "0x18471F620", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x471F910", Offset = "0x471ED10", VA = "0x18471F910", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x471F7F0", Offset = "0x471EBF0", VA = "0x18471F7F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x471F8D0", Offset = "0x471ECD0", VA = "0x18471F8D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float EDPKCBHJJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float JFFGOMGDEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<ACEHAEGGKAI> EJNHCEEFLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int GNPKFMEIDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int DOGDNKHLKAL;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int CABELAFBBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9A9220", Offset = "0x9A8620", VA = "0x1809A9220", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4784620", Offset = "0x4783A20", VA = "0x184784620")]
	public FOPFBPHAIDO(float EDPKCBHJJIM, float JFFGOMGDEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4784130", Offset = "0x4783530", VA = "0x184784130", Slot = "6")]
	public bool NJEOCINJPPK(float GLBFMHKMALN, T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4783E30", Offset = "0x4783230", VA = "0x184783E30", Slot = "8")]
	public int JEMBEAPNKLB(float GLBFMHKMALN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4783940", Offset = "0x4782D40", VA = "0x184783940", Slot = "5")]
	[IteratorStateMachine(typeof(FOPFBPHAIDO<>.FEPKFECIALC))]
	public IEnumerable<T> GFLOCMEJEDF(float GLBFMHKMALN, float? AHIKEFMGEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x47838E0", Offset = "0x4782CE0", VA = "0x1847838E0", Slot = "7")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4783D40", Offset = "0x4783140", VA = "0x184783D40")]
	private void JDKKLNCPHBB(float GLBFMHKMALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4783AC0", Offset = "0x4782EC0", VA = "0x184783AC0")]
	private ACEHAEGGKAI HKABOLJEKDA()
	{
		return default(ACEHAEGGKAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class APGKENHKANG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct LOKNLOBIGNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long HGBCBCFFBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long HNOGAPJKIEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int JIPAJPFKINJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int MBJFKBCPAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool INJOOHFGCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string GFBGIIKFMLP;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EF70", Offset = "0x4E7E370", VA = "0x184E7EF70")]
		public LOKNLOBIGNI(long HGBCBCFFBCK, int JIPAJPFKINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EFE0", Offset = "0x4E7E3E0", VA = "0x184E7EFE0")]
		public LOKNLOBIGNI(long HGBCBCFFBCK, long HNOGAPJKIEF, int JIPAJPFKINJ, int MBJFKBCPAMB, bool INJOOHFGCPP, string GFBGIIKFMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EE00", Offset = "0x4E7E200", VA = "0x184E7EE00")]
		public int DKGPAFNCELB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EE50", Offset = "0x4E7E250", VA = "0x184E7EE50")]
		public int DPMPPJINDMB(int ODCMILIFNPO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EE70", Offset = "0x4E7E270", VA = "0x184E7EE70")]
		public double MJOEDDGOAEB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EED0", Offset = "0x4E7E2D0", VA = "0x184E7EED0")]
		public LOKNLOBIGNI MLDHBAPAGCG(long HNOGAPJKIEF, int MBJFKBCPAMB)
		{
			return default(LOKNLOBIGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class EEEKGBDKLHP : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct IOABIGGCIMC<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public EEEKGBDKLHP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<EEEKGBDKLHP, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private EEEKGBDKLHP <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x4A28E20", Offset = "0x4A28220", VA = "0x184A28E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x48FB5F0", Offset = "0x48FA9F0", VA = "0x1848FB5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey KKGMNHPHOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly APGKENHKANG<TKey> KINEPAABOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly GBHBOJAPDOA DPDKJPMBJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<EEEKGBDKLHP> MGJABHCKIPE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string AHGEGEPEODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x42D46E0", Offset = "0x42D3AE0", VA = "0x1842D46E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<EEEKGBDKLHP> GHOJKGPMAPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x42D46A0", Offset = "0x42D3AA0", VA = "0x1842D46A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public LOKNLOBIGNI DOFCGFPGEEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x42D4730", Offset = "0x42D3B30", VA = "0x1842D4730")]
			[CompilerGenerated]
			get
			{
				return default(LOKNLOBIGNI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x42D4270", Offset = "0x42D3670", VA = "0x1842D4270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x42D4750", Offset = "0x42D3B50", VA = "0x1842D4750")]
		internal EEEKGBDKLHP(APGKENHKANG<TKey> KINEPAABOFB, TKey DJBLFBEBKGO, GBHBOJAPDOA DPDKJPMBJOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x42D44F0", Offset = "0x42D38F0", VA = "0x1842D44F0")]
		public EEEKGBDKLHP IDDABEAKABA(TKey DJBLFBEBKGO, [Optional] GBHBOJAPDOA? MPKBCOMOPAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3B98040", Offset = "0x3B97440", VA = "0x183B98040")]
		[AsyncStateMachine(typeof(IOABIGGCIMC<>))]
		public Task<T> MMBOAJEGAPH<T>(TKey DJBLFBEBKGO, Func<EEEKGBDKLHP, Task<T>> MOIIPMBKBLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x42D42A0", Offset = "0x42D36A0", VA = "0x1842D42A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class BAKIEINEMAA : IEnumerable<(TKey, List<TKey>, LOKNLOBIGNI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LOKNLOBIGNI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, LOKNLOBIGNI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public APGKENHKANG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, LOKNLOBIGNI timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, LOKNLOBIGNI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x28A2E60", Offset = "0x28A2260", VA = "0x1828A2E60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LOKNLOBIGNI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5B26C40", Offset = "0x5B26040", VA = "0x185B26C40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28A2F50", Offset = "0x28A2350", VA = "0x1828A2F50")]
		[DebuggerHidden]
		public BAKIEINEMAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4766820", Offset = "0x4765C20", VA = "0x184766820", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5B26730", Offset = "0x5B25B30", VA = "0x185B26730", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5B26AD0", Offset = "0x5B25ED0", VA = "0x185B26AD0")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5B26BF0", Offset = "0x5B25FF0", VA = "0x185B26BF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5B26B20", Offset = "0x5B25F20", VA = "0x185B26B20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LOKNLOBIGNI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x476E320", Offset = "0x476D720", VA = "0x18476E320", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class AEPOKMJJMCH : IEnumerable<(TKey, List<TKey>, LOKNLOBIGNI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LOKNLOBIGNI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, LOKNLOBIGNI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EEEKGBDKLHP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public EEEKGBDKLHP <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public APGKENHKANG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<EEEKGBDKLHP> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, LOKNLOBIGNI timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, LOKNLOBIGNI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x28A2E60", Offset = "0x28A2260", VA = "0x1828A2E60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LOKNLOBIGNI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x480B840", Offset = "0x480AC40", VA = "0x18480B840", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x28A2F50", Offset = "0x28A2350", VA = "0x1828A2F50")]
		[DebuggerHidden]
		public AEPOKMJJMCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x480B8A0", Offset = "0x480ACA0", VA = "0x18480B8A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x480AE20", Offset = "0x480A220", VA = "0x18480AE20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x480B650", Offset = "0x480AA50", VA = "0x18480B650")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x480B5F0", Offset = "0x480A9F0", VA = "0x18480B5F0")]
		private void NIIFAIKAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x480B7F0", Offset = "0x480ABF0", VA = "0x18480B7F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x480B6B0", Offset = "0x480AAB0", VA = "0x18480B6B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LOKNLOBIGNI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x480B7B0", Offset = "0x480ABB0", VA = "0x18480B7B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, LOKNLOBIGNI, GBHBOJAPDOA> PPPCMOMONEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, LOKNLOBIGNI, GBHBOJAPDOA> HLCLJOECALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<APGKENHKANG<TKey>, GBHBOJAPDOA> NJBPJLLOBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly EEEKGBDKLHP FGCDOGNIMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool ACJJLPFCEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int NKBHHLLPGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch GPLEFDGILMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int JBHEEPLOECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string ILMDEMKACAI;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public EEEKGBDKLHP PEMAJFGNIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string AHGEGEPEODB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A60", Offset = "0x9A8E60", VA = "0x1809A9A60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x49FE390", Offset = "0x49FD790", VA = "0x1849FE390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x49FE3F0", Offset = "0x49FD7F0", VA = "0x1849FE3F0")]
	public APGKENHKANG(TKey FADNPBNCDAH, GBHBOJAPDOA DPDKJPMBJOA, [Optional] int? JIPAJPFKINJ, [Optional][CanBeNull] Stopwatch GPLEFDGILMF, [Optional] Action<TKey, LOKNLOBIGNI, GBHBOJAPDOA> PPPCMOMONEK, [Optional] Action<TKey, LOKNLOBIGNI, GBHBOJAPDOA> HLCLJOECALM, [Optional] Action<APGKENHKANG<TKey>, GBHBOJAPDOA> NJBPJLLOBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x49FE0C0", Offset = "0x49FD4C0", VA = "0x1849FE0C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x49FE270", Offset = "0x49FD670", VA = "0x1849FE270")]
	[IteratorStateMachine(typeof(APGKENHKANG<>.BAKIEINEMAA))]
	public IEnumerable<(TKey, List<TKey>, LOKNLOBIGNI)> GKMHPFGADCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x49FE190", Offset = "0x49FD590", VA = "0x1849FE190")]
	[IteratorStateMachine(typeof(APGKENHKANG<>.AEPOKMJJMCH))]
	private IEnumerable<(TKey, List<TKey>, LOKNLOBIGNI)> GKMHPFGADCI(List<TKey> IOOOOBAIEAN, EEEKGBDKLHP GHLKOGBLJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x49FE310", Offset = "0x49FD710", VA = "0x1849FE310")]
	private (long, int) HEJIEJPJLHD()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class LDGGCOKCCHF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut OEMPKGNJGAC(APGKENHKANG<TKey> KINEPAABOFB);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	protected LDGGCOKCCHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class IEEEACGACAC<TKey> : LDGGCOKCCHF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate string LPBGOLKAGFJ(TKey DJBLFBEBKGO);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4A04DA0", Offset = "0x4A041A0", VA = "0x184A04DA0")]
	private static string FFBGDLPHJBG(TKey DJBLFBEBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4A04F30", Offset = "0x4A04330", VA = "0x184A04F30", Slot = "4")]
	public override string OEMPKGNJGAC(APGKENHKANG<TKey> KINEPAABOFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4A04DE0", Offset = "0x4A041E0", VA = "0x184A04DE0")]
	public string OEMPKGNJGAC(APGKENHKANG<TKey> KINEPAABOFB, [NotNull] LPBGOLKAGFJ LGIBBHPPOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BACDFOLGNCI(APGKENHKANG<TKey> KINEPAABOFB, [NotNull] LPBGOLKAGFJ LGIBBHPPOAC);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4A05010", Offset = "0x4A04410", VA = "0x184A05010")]
	protected IEEEACGACAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KIBMIDFCMIN<TKey> : LDGGCOKCCHF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate string DJNMHLKLKPN(TKey DJBLFBEBKGO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string KFJGGCNEALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double BMIFEHBAEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool DINIKCNDHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int DFGDBBPNANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> FNFKBKNGBGM;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4D909F0", Offset = "0x4D8FDF0", VA = "0x184D909F0")]
	private static string FFBGDLPHJBG(TKey DJBLFBEBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4D915F0", Offset = "0x4D909F0", VA = "0x184D915F0")]
	public KIBMIDFCMIN(string KFJGGCNEALL = "F2", double BMIFEHBAEJG = double.MaxValue, bool DINIKCNDHLA = false, int DFGDBBPNANF = int.MaxValue, [Optional] ISet<string> FNFKBKNGBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4D91140", Offset = "0x4D90540", VA = "0x184D91140", Slot = "4")]
	public override Dictionary<string, string> OEMPKGNJGAC(APGKENHKANG<TKey> KINEPAABOFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4D90A30", Offset = "0x4D8FE30", VA = "0x184D90A30")]
	private bool LEGEAKMNBAN(string HNHKIDAKLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4D90B00", Offset = "0x4D8FF00", VA = "0x184D90B00")]
	public Dictionary<string, string> OEMPKGNJGAC(APGKENHKANG<TKey> KINEPAABOFB, DJNMHLKLKPN LGIBBHPPOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4D91380", Offset = "0x4D90780", VA = "0x184D91380")]
	private string PGPGHHMEOMD(StringBuilder ADAKNFBJHBN, List<TKey> GCOMIIIIMMM, DJNMHLKLKPN LGIBBHPPOAC, bool HNDIHOFCEJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4D91220", Offset = "0x4D90620", VA = "0x184D91220")]
	private static void PGIBILCDDDJ(StringBuilder CONGGHBKFOJ, string AECMHGBNGDN, bool EMGNAJIGBHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class ILLDDAHPMOO<TKey> : IEEEACGACAC<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct BJLGKAGNFPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public LPBGOLKAGFJ keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static ILLDDAHPMOO<TKey> DNEPPKLGBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] AGDCJEAMPDC;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4A23BA0", Offset = "0x4A22FA0", VA = "0x184A23BA0")]
	private ILLDDAHPMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4A22B50", Offset = "0x4A21F50", VA = "0x184A22B50", Slot = "5")]
	protected override string BACDFOLGNCI(APGKENHKANG<TKey> KINEPAABOFB, LPBGOLKAGFJ LGIBBHPPOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4A23960", Offset = "0x4A22D60", VA = "0x184A23960")]
	[CompilerGenerated]
	internal static string PLLBLFPEOHA(string FOALADOIBAE, TKey DJBLFBEBKGO, BJLGKAGNFPD P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class ADJCNDJOHAC : APGKENHKANG<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class AKGIMJNJHIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<ADJCNDJOHAC, GBHBOJAPDOA> callback;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public AKGIMJNJHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7896640", Offset = "0x7895A40", VA = "0x187896640")]
		internal void JGENPHPFIGL(APGKENHKANG<string> timer, GBHBOJAPDOA log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7896140", Offset = "0x7895540", VA = "0x187896140")]
	public ADJCNDJOHAC(GBHBOJAPDOA DPDKJPMBJOA, [Optional] string COMBJFMBCJD, [Optional] int? JIPAJPFKINJ, [Optional] Stopwatch GPLEFDGILMF, [Optional] Action<string, LOKNLOBIGNI, GBHBOJAPDOA> PPPCMOMONEK, [Optional] Action<string, LOKNLOBIGNI, GBHBOJAPDOA> HLCLJOECALM, [Optional] Action<ADJCNDJOHAC, GBHBOJAPDOA> NJBPJLLOBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7896080", Offset = "0x7895480", VA = "0x187896080")]
	private static Action<APGKENHKANG<string>, GBHBOJAPDOA> BHJBFKNGHFK(Action<ADJCNDJOHAC, GBHBOJAPDOA> ADLKPPBLCIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public abstract class FMHENKFEBAH
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class HOCFDIPJHPH : FMHENKFEBAH
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static FMHENKFEBAH DNEPPKLGBFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7898E70", Offset = "0x7898270", VA = "0x187898E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float KFDEODFGGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x10D0A40", Offset = "0x10CFE40", VA = "0x1810D0A40", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7898F60", Offset = "0x7898360", VA = "0x187898F60")]
		public HOCFDIPJHPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static FMHENKFEBAH ANILNGLEINJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static FMHENKFEBAH AMGMCPILGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x78976B0", Offset = "0x7896AB0", VA = "0x1878976B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float KFDEODFGGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	protected FMHENKFEBAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface MFCONHIDCBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool MPMNNGFDLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface HLFDOLJKNKL<T> : MFCONHIDCBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> NMBCJEBMAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	GOBMEFCJDOP<T> GOAEODBEMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FMGKLBADKGB
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x35D7760", Offset = "0x35D6B60", VA = "0x1835D7760")]
	public static HLFDOLJKNKL<TResource> IPPNJGDNINP<TResource, TId>(this NJGLBGPNBMB<TId, TResource> OEEONBHNECC, TId NCJKGMLAKGH, [Optional] Func<TId, CancellationToken, Task<TResource>>? EBOPNJLKNFL) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class FFECFGBFNPG
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class GNDMNCLHJCB<T> : MLJCOMBFFFI<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> NMBCJEBMAFH
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override GOBMEFCJDOP<T?> GOAEODBEMGH
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x48757A0", Offset = "0x4874BA0", VA = "0x1848757A0")]
		public GNDMNCLHJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "10")]
		protected override void PJDDAEBFGNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class ABIADBEIMON<T> : MLJCOMBFFFI<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T NCGFNDEHOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? MNLBIHAIHOF;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> NMBCJEBMAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override GOBMEFCJDOP<T> GOAEODBEMGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9AA330", Offset = "0x9A9730", VA = "0x1809AA330", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x47FD340", Offset = "0x47FC740", VA = "0x1847FD340")]
		public ABIADBEIMON(T MEBMOMPAGGP, Action<T>? JECALFIKEFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x47FD100", Offset = "0x47FC500", VA = "0x1847FD100", Slot = "10")]
		protected override void PJDDAEBFGNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class COMHHJECDBC<T> : MLJCOMBFFFI<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> NMBCJEBMAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override GOBMEFCJDOP<T> GOAEODBEMGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x64884A0", Offset = "0x64878A0", VA = "0x1864884A0")]
		public COMHHJECDBC(Exception DLAPGFGBDMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "10")]
		protected override void PJDDAEBFGNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class MAOAJJJMHFC<T> : MLJCOMBFFFI<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct AMOFIJHGFEM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<HLFDOLJKNKL<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<HLFDOLJKNKL<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x49FB080", Offset = "0x49FA480", VA = "0x1849FB080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x49FBA60", Offset = "0x49FAE60", VA = "0x1849FBA60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct JFCLPANPIPE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<HLFDOLJKNKL<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<HLFDOLJKNKL<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4C04D90", Offset = "0x4C04190", VA = "0x184C04D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4C05020", Offset = "0x4C04420", VA = "0x184C05020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<HLFDOLJKNKL<T>> CHPNEKBOFFL;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> NMBCJEBMAFH
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override GOBMEFCJDOP<T> GOAEODBEMGH
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5042100", Offset = "0x5041500", VA = "0x185042100")]
		public MAOAJJJMHFC(Task<HLFDOLJKNKL<T>> NHNFPALEEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5041FE0", Offset = "0x50413E0", VA = "0x185041FE0", Slot = "10")]
		protected override void PJDDAEBFGNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5041CB0", Offset = "0x50410B0", VA = "0x185041CB0")]
		[AsyncStateMachine(typeof(MAOAJJJMHFC<>.AMOFIJHGFEM))]
		[CompilerGenerated]
		internal static Task<T> HLNLODDOEAJ(Task<HLFDOLJKNKL<T>> NHNFPALEEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5041F00", Offset = "0x5041300", VA = "0x185041F00")]
		[AsyncStateMachine(typeof(MAOAJJJMHFC<>.JFCLPANPIPE))]
		[CompilerGenerated]
		internal static Task OBOAJODIOGK(Task<HLFDOLJKNKL<T>> NHNFPALEEPM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class GJGMLILAKPK<TIn, TOut> : MLJCOMBFFFI<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct HKGHAOFJLCJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x491CCC0", Offset = "0x491C0C0", VA = "0x18491CCC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4856630", Offset = "0x4855A30", VA = "0x184856630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly HLFDOLJKNKL<TIn> COBGPFOHNIN;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> NMBCJEBMAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override GOBMEFCJDOP<TOut> GOAEODBEMGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x485C280", Offset = "0x485B680", VA = "0x18485C280")]
		public GJGMLILAKPK(HLFDOLJKNKL<TIn> AFIBHOKGKBP, Func<TIn, TOut> ICNECFGJGLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x485C1E0", Offset = "0x485B5E0", VA = "0x18485C1E0", Slot = "10")]
		protected override void PJDDAEBFGNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x485BEE0", Offset = "0x485B2E0", VA = "0x18485BEE0")]
		[AsyncStateMachine(typeof(GJGMLILAKPK<, >.HKGHAOFJLCJ))]
		[CompilerGenerated]
		internal static Task<TOut> LNLGBGAEJJK(Task<TIn> JLGCIHFLEAI, Func<TIn, TOut> ICNECFGJGLI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x35D4360", Offset = "0x35D3760", VA = "0x1835D4360")]
	public static HLFDOLJKNKL<T> GBADJOAJCAL<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x35D42B0", Offset = "0x35D36B0", VA = "0x1835D42B0")]
	public static HLFDOLJKNKL<T> CKGJIBIMFON<T>(T HBALBIOOGIJ, [Optional] Action<T>? JECALFIKEFL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3393FF0", Offset = "0x33933F0", VA = "0x183393FF0")]
	public static HLFDOLJKNKL<T> IHGHECCEGBJ<T>(Exception DLAPGFGBDMP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3393FF0", Offset = "0x33933F0", VA = "0x183393FF0")]
	public static HLFDOLJKNKL<T> MKCDEGCPFIA<T>(Task<HLFDOLJKNKL<T>> NHNFPALEEPM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x339B040", Offset = "0x339A440", VA = "0x18339B040")]
	public static HLFDOLJKNKL<TOut> IGBFJKOBHIJ<TOut, TIn>(HLFDOLJKNKL<TIn> GGBKPDHLOJF, Func<TIn, TOut> ICNECFGJGLI) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class MLJCOMBFFFI<T> : HLFDOLJKNKL<T>, MFCONHIDCBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string PNHOBBMPKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly MLHHDOMPAAM KIGNAOJEIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool ACJJLPFCEAB;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool MPMNNGFDLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xBEA340", Offset = "0xBE9740", VA = "0x180BEA340", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> NMBCJEBMAFH
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract GOBMEFCJDOP<T> GOAEODBEMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5085950", Offset = "0x5084D50", VA = "0x185085950")]
	public MLJCOMBFFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x50856C0", Offset = "0x5084AC0", VA = "0x1850856C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void PJDDAEBFGNH();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class KKJEIOEMIAF<TTask, T> : MLJCOMBFFFI<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class BGODFFEFMPC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public BGODFFEFMPC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3E961D0", Offset = "0x3E955D0", VA = "0x183E961D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3E96490", Offset = "0x3E95890", VA = "0x183E96490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public KKJEIOEMIAF<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BGODFFEFMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5F1D610", Offset = "0x5F1CA10", VA = "0x185F1D610")]
		[AsyncStateMachine(typeof(KKJEIOEMIAF<, >.BGODFFEFMPC.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> JOMFDIGPIOJ(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> NHNFPALEEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource MCOIFPENEFF;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> NMBCJEBMAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override GOBMEFCJDOP<T> GOAEODBEMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4DA0310", Offset = "0x4D9F710", VA = "0x184DA0310")]
	protected KKJEIOEMIAF(TTask NHNFPALEEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4DA00C0", Offset = "0x4D9F4C0", VA = "0x184DA00C0", Slot = "10")]
	protected override void PJDDAEBFGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T MFPNANIKEBM(TTask LNJEGKCLOPP);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void DDHGIEAEBOC();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class FFAOIBHIFOE<T> : MLJCOMBFFFI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly OHGHKHJHGOP<Task<T>> KNCAMNOGLIO;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> NMBCJEBMAFH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x471FC70", Offset = "0x471F070", VA = "0x18471FC70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override GOBMEFCJDOP<T> GOAEODBEMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x471FCE0", Offset = "0x471F0E0", VA = "0x18471FCE0")]
	public FFAOIBHIFOE(OHGHKHJHGOP<Task<T>> LIFCDIEMBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x471FCC0", Offset = "0x471F0C0", VA = "0x18471FCC0", Slot = "10")]
	protected override void PJDDAEBFGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class EDFPDAKGIPE
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName MNBDDCKJCBA;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> KFINNJFDOJI;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x78972E0", Offset = "0x78966E0", VA = "0x1878972E0")]
	public static int MKBININHGNE(this LKHFDMEDDEH NIILNBGHOGD, IncrementalHash FJJIBEAAGGP, byte[] DGPJNOICFAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7897280", Offset = "0x7896680", VA = "0x187897280")]
	public static bool DELMBPOOKMM([CanBeNull] this LKHFDMEDDEH NIILNBGHOGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7896C40", Offset = "0x7896040", VA = "0x187896C40")]
	public static bool DELMBPOOKMM([CanBeNull] this LKHFDMEDDEH NIILNBGHOGD, [Out] string AFHGIBDEPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7896F50", Offset = "0x7896350", VA = "0x187896F50")]
	public static bool DELMBPOOKMM([CanBeNull] this LKHFDMEDDEH NIILNBGHOGD, IncrementalHash FJJIBEAAGGP, byte[] DGPJNOICFAE, [Out] string AFHGIBDEPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7896BB0", Offset = "0x7895FB0", VA = "0x187896BB0")]
	private static bool DAKKBDCDKGN(byte[] CBINPPOGPMG, Span<byte> MDIDHDICDLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class AIIAJFHIPDF
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7896290", Offset = "0x7895690", VA = "0x187896290")]
	public static int IKBGHBHMDDP(HashAlgorithmName KIIKIPAHABI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x78963E0", Offset = "0x78957E0", VA = "0x1878963E0")]
	public static int MKBININHGNE(this ELOKANIMHDL EMBJEJOKJKK, byte[] DMBBNCKBGLA, IncrementalHash FJJIBEAAGGP, byte[] EGDECGMODBJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface ELOKANIMHDL
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash FJJIBEAAGGP);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface LKHFDMEDDEH : ELOKANIMHDL
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] GFLBGJDCICK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] IPKFKGPBAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class KOJFMAIPKEH
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool AEPKNNLBGOC;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> OFFKFILGJMJ;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> DIMNPCOBEBJ;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding PGMBLALIFNH;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> GLIAHPGLMIL;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x36ED3C0", Offset = "0x36EC7C0", VA = "0x1836ED3C0")]
	public static void JDPCIEGHHIA<T>(this IncrementalHash KOFJKIPNADB, [CanBeNull] T DMJKAPFLGHP) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x36ED480", Offset = "0x36EC880", VA = "0x1836ED480")]
	public static void PNNLOFBHPHK<T>(this IncrementalHash KOFJKIPNADB, [CanBeNull] T EMBJEJOKJKK) where T : ELOKANIMHDL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x36EC870", Offset = "0x36EBC70", VA = "0x1836EC870")]
	public static void HLKMCLAKBFG<T>(this IncrementalHash KOFJKIPNADB, [CanBeNull] IList<T> HICJLFMOIPD) where T : ELOKANIMHDL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7899380", Offset = "0x7898780", VA = "0x187899380")]
	private static bool ECLNJPNNIEO([CanBeNull] ELOKANIMHDL EMBJEJOKJKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x78996A0", Offset = "0x7898AA0", VA = "0x1878996A0")]
	public static void IJMJHAEHEDP(this IncrementalHash FJJIBEAAGGP, string? GDDJCAFFEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7899470", Offset = "0x7898870", VA = "0x187899470")]
	public static void GOANJCHDMKD(this IncrementalHash FJJIBEAAGGP, long HKCLOHHKEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7899E40", Offset = "0x7899240", VA = "0x187899E40")]
	public static void PHCPLCCGIPL(this IncrementalHash FJJIBEAAGGP, int NKPENDLBPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7899C10", Offset = "0x7899010", VA = "0x187899C10")]
	public static void LKOMBFOHBMM(this IncrementalHash FJJIBEAAGGP, short LKAFGFHHPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7899210", Offset = "0x7898610", VA = "0x187899210")]
	public static void AIDCEMNFMCD(this IncrementalHash FJJIBEAAGGP, byte BKKDMGOKLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7899AA0", Offset = "0x7898EA0", VA = "0x187899AA0")]
	public static void JOFCNOCNIKL(this IncrementalHash FJJIBEAAGGP, bool CNJMAGIHGPL, bool ONCGGDCALGL = false, bool KNNKMCLLFAO = false, bool DDEGIKNOIPK = false, bool OPIJEDPIPLB = false, bool BIDOBGCEFLL = false, bool HHDHJADEJHB = false, bool LOONGLFOANP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x36ECD90", Offset = "0x36EC190", VA = "0x1836ECD90")]
	public static void IMKPAOJDAAC<T>(this IncrementalHash FJJIBEAAGGP, T OEAPKNBFGIB) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7899640", Offset = "0x7898A40", VA = "0x187899640")]
	public static void IBBCNFKHDJD(this IncrementalHash FJJIBEAAGGP, float IPOJAFEDPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7899DE0", Offset = "0x78991E0", VA = "0x187899DE0")]
	public static void NCDLIAGPNGH(this IncrementalHash FJJIBEAAGGP, ulong LJBLMKBHCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7899320", Offset = "0x7898720", VA = "0x187899320")]
	public static void BMILNKIEKDD(this IncrementalHash FJJIBEAAGGP, uint PPHDBPODCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7899410", Offset = "0x7898810", VA = "0x187899410")]
	public static void ECOBIEKEAKD(this IncrementalHash FJJIBEAAGGP, ushort AEADDOCPHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x78990E0", Offset = "0x78984E0", VA = "0x1878990E0")]
	public static void AAJLHHMENBD(this IncrementalHash FJJIBEAAGGP, Vector3 PFJGOOFAJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JBABNFFJPNF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7898FB0", Offset = "0x78983B0", VA = "0x187898FB0")]
	public JBABNFFJPNF(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class PMDPBPHBBFM
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate void MBDCHGLIEPN(ushort EKLOHJMDKGM, ushort NBMJHKFONKH, ushort FENLJLPCNHO, ushort OJBMABLMPGO);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void MIAFLBGLODM(ushort CIKDOLJDJGN, ushort NFCGNAGPPGB);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void DNEOIIDHONC();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort MPIMBGDHPOE = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	protected PMDPBPHBBFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public abstract class BLKDPIONGMN<T> : PMDPBPHBBFM where T : BLKDPIONGMN<T>.IMANFHHDMDP
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public interface IMANFHHDMDP
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		MIAFLBGLODM COJIHNLEBNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		MIAFLBGLODM EIBDNBDMHCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		DNEOIIDHONC CIICAGDOHAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> KGCLPNMOOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private DNEOIIDHONC JOEEIONHMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private DNEOIIDHONC BMBPADNOEJM;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool OCOKAOCMFLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA11750", Offset = "0xA10B50", VA = "0x180A11750")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B3680", Offset = "0x9B2A80", VA = "0x1809B3680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort CBKADNMALJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5F37640", Offset = "0x5F36A40", VA = "0x185F37640")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5F37660", Offset = "0x5F36A60", VA = "0x185F37660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort PDOHAGODAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5F37650", Offset = "0x5F36A50", VA = "0x185F37650")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5F37CA0", Offset = "0x5F370A0", VA = "0x185F37CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort NJPMMPHBJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xD2EAA0", Offset = "0xD2DEA0", VA = "0x180D2EAA0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xD2EBE0", Offset = "0xD2DFE0", VA = "0x180D2EBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort ICGJDIOEPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5F37970", Offset = "0x5F36D70", VA = "0x185F37970")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5F37670", Offset = "0x5F36A70", VA = "0x185F37670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool MEFBFDBMIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x168BC20", Offset = "0x168B020", VA = "0x18168BC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool CFIALOJCFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xDE6F80", Offset = "0xDE6380", VA = "0x180DE6F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MBDCHGLIEPN BLHDJBBMJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5F378D0", Offset = "0x5F36CD0", VA = "0x185F378D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5F37C00", Offset = "0x5F37000", VA = "0x185F37C00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F376F0", Offset = "0x5F36AF0", VA = "0x185F376F0")]
	private T FHGKCJMIFIF(ushort NMCDDILMCNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F377B0", Offset = "0x5F36BB0", VA = "0x185F377B0")]
	private T GBLEGLPCBJM(ushort NMCDDILMCNJ, ushort GDMGCBCMHBP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F37870", Offset = "0x5F36C70", VA = "0x185F37870")]
	protected T GNMPFEBLNMH(uint FCAIMBBLMLM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F38740", Offset = "0x5F37B40", VA = "0x185F38740")]
	protected BLKDPIONGMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F37DC0", Offset = "0x5F371C0", VA = "0x185F37DC0")]
	public void PBMICBBKGKN(ushort IPCNFMBMGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F37E00", Offset = "0x5F37200", VA = "0x185F37E00")]
	public void PBMICBBKGKN(ushort IPCNFMBMGEN, ushort GCAMIHKBBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F37CB0", Offset = "0x5F370B0", VA = "0x185F37CB0", Slot = "4")]
	protected virtual void PBMICBBKGKN(uint ALEPOIEEKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5F37F10", Offset = "0x5F37310", VA = "0x185F37F10")]
	protected void PNHHALOPJNJ(uint ALEPOIEEKFN, uint IMIDEBIHKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5F37E60", Offset = "0x5F37260", VA = "0x185F37E60")]
	protected void PBPANFKGEOA(ushort NMCDDILMCNJ, ushort GDMGCBCMHBP, T DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5F37680", Offset = "0x5F36A80", VA = "0x185F37680")]
	private void EDKJMGADMPP(uint FCAIMBBLMLM, T DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F37990", Offset = "0x5F36D90", VA = "0x185F37990")]
	protected void JPLPCDLPAIH(float JNFHMFBFJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5F37980", Offset = "0x5F36D80", VA = "0x185F37980")]
	protected uint JNPLIIHFLGN(ushort NMCDDILMCNJ, ushort GDMGCBCMHBP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F377A0", Offset = "0x5F36BA0", VA = "0x185F377A0")]
	protected ushort FNPKIDBKMKA(uint CAFEMCHINAO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F376E0", Offset = "0x5F36AE0", VA = "0x185F376E0")]
	protected ushort FBDFFHGLBIL(uint CAFEMCHINAO)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public abstract class EHNKAICOMAE : BLKDPIONGMN<EHNKAICOMAE.PAPDADFBCBM>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class PAPDADFBCBM : IMANFHHDMDP
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public MIAFLBGLODM COJIHNLEBNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public MIAFLBGLODM EIBDNBDMHCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public DNEOIIDHONC CIICAGDOHAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x9A9260", Offset = "0x9A8660", VA = "0x1809A9260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public PAPDADFBCBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x78974F0", Offset = "0x78968F0", VA = "0x1878974F0")]
	public void OOIDMJKAOHG(ushort OHKAEGPBKDI, MIAFLBGLODM BEIFOMBFMKA, MIAFLBGLODM AIPBFIAFNMI, DNEOIIDHONC DABMHPHNEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x78975D0", Offset = "0x78969D0", VA = "0x1878975D0")]
	public void OOIDMJKAOHG(ushort NMCDDILMCNJ, ushort GDMGCBCMHBP, MIAFLBGLODM BEIFOMBFMKA, MIAFLBGLODM AIPBFIAFNMI, DNEOIIDHONC DABMHPHNEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x78974A0", Offset = "0x78968A0", VA = "0x1878974A0")]
	public void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7896A70", Offset = "0x7895E70", VA = "0x187896A70")]
	protected EHNKAICOMAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class CNIKIJHBKDD : EHNKAICOMAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool LNNNHLFANLN;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool LCONPCPHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xB5F800", Offset = "0xB5EC00", VA = "0x180B5F800")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xC51310", Offset = "0xC50710", VA = "0x180C51310")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x78969B0", Offset = "0x7895DB0", VA = "0x1878969B0")]
	public void GDCNGOALEGL(ushort MPCDGJNKAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7896A10", Offset = "0x7895E10", VA = "0x187896A10")]
	public void GDCNGOALEGL(ushort MPCDGJNKAKK, ushort AADPGAALLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7896A70", Offset = "0x7895E70", VA = "0x187896A70")]
	public CNIKIJHBKDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class IADDFIIACED<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal class OFAGCFKONIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode JOCJBPPJMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode KLDFHLFOOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public NOLCDBENBPB EAOBCLAGGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<NOLCDBENBPB> HKPAHCNOJHN;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OFAGCFKONIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal struct NOLCDBENBPB : IComparable<NOLCDBENBPB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int PKKOAIHLPOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant DIMNBLIIFEB;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x154B000", Offset = "0x154A400", VA = "0x18154B000")]
		public NOLCDBENBPB(int PKKOAIHLPOK, TClaimant DIMNBLIIFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x510E110", Offset = "0x510D510", VA = "0x18510E110")]
		public bool HNHELJCGNOA([In] NOLCDBENBPB KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x510E100", Offset = "0x510D500", VA = "0x18510E100")]
		public bool GBDFDLCCGMC([In] NOLCDBENBPB KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x510E0F0", Offset = "0x510D4F0", VA = "0x18510E0F0", Slot = "4")]
		public int CompareTo(NOLCDBENBPB KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x510E170", Offset = "0x510D570", VA = "0x18510E170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public enum LGNPMPEALFL
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DFNOMGIKOJP : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public IADDFIIACED<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
		[DebuggerHidden]
		public DFNOMGIKOJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x66D7240", Offset = "0x66D6640", VA = "0x1866D7240", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x66D7420", Offset = "0x66D6820", VA = "0x1866D7420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x66D7320", Offset = "0x66D6720", VA = "0x1866D7320", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x4767DD0", Offset = "0x47671D0", VA = "0x184767DD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly MAEKECGNICD<OFAGCFKONIE> CBHIBKPDLJC;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly MAEKECGNICD<List<NOLCDBENBPB>> HHKGMFDNLEJ;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int HCHLCNCEOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> EMGNCJKEFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, OFAGCFKONIE> ELNCGMPFJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private LGNPMPEALFL KGLDBFDNHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool EKDCONIHOMM;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode FCPKINCBMMM(TNode BLGGFHHEDNC);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void DGEGGCNKMJN(TNode BLGGFHHEDNC, TClaimant GICEDMPAJKO, TClaimant HDKGNBABBNF);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x49E4D80", Offset = "0x49E4180", VA = "0x1849E4D80")]
	public IADDFIIACED(LGNPMPEALFL KGLDBFDNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x49E37B0", Offset = "0x49E2BB0", VA = "0x1849E37B0")]
	public void FHFNEJPKFMJ(TNode BLGGFHHEDNC, TNode BBFFOKPDHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x49E4A30", Offset = "0x49E3E30", VA = "0x1849E4A30")]
	public void PAHGPGOBLOG(TClaimant DIMNBLIIFEB, TNode NJEDJGLJDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x49E35B0", Offset = "0x49E29B0", VA = "0x1849E35B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x49E4610", Offset = "0x49E3A10", VA = "0x1849E4610")]
	private void NBHIILIKOMJ(TClaimant DIMNBLIIFEB, TNode HLCEBKJKOKD, TNode NJEDJGLJDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x49E4100", Offset = "0x49E3500", VA = "0x1849E4100")]
	private int JKKFAOEONNG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x49E46E0", Offset = "0x49E3AE0", VA = "0x1849E46E0")]
	private void NKLPBHJOHEB(TClaimant DIMNBLIIFEB, TNode MHCJEACPLEG, TNode FKGHPCFGFJE, int MDBOOCNPIBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x49E32A0", Offset = "0x49E26A0", VA = "0x1849E32A0")]
	private void AIJCHCDBAJJ(NOLCDBENBPB FFGBOGCDFGK, OFAGCFKONIE INAPFKLHCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x49E4170", Offset = "0x49E3570", VA = "0x1849E4170")]
	private void KGLIDGIAKHL(TClaimant DIMNBLIIFEB, TNode MHCJEACPLEG, TNode FKGHPCFGFJE, int MDBOOCNPIBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x49E3480", Offset = "0x49E2880", VA = "0x1849E3480")]
	private void DFNNNIFGOBN(NOLCDBENBPB FFGBOGCDFGK, TNode BLGGFHHEDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x49E3870", Offset = "0x49E2C70", VA = "0x1849E3870")]
	private void FHMFIJMMJLI(NOLCDBENBPB FFGBOGCDFGK, OFAGCFKONIE INAPFKLHCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x49E3AC0", Offset = "0x49E2EC0", VA = "0x1849E3AC0")]
	private void HBPPEGAPCCK(OFAGCFKONIE INAPFKLHCFN, bool LMGFPBGEHIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x49E3D90", Offset = "0x49E3190", VA = "0x1849E3D90")]
	private void IENFLAKODGG(OFAGCFKONIE INAPFKLHCFN, TNode BBFFOKPDHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x49E39D0", Offset = "0x49E2DD0", VA = "0x1849E39D0")]
	[IteratorStateMachine(typeof(IADDFIIACED<, >.DFNOMGIKOJP))]
	private IEnumerable<TNode> GKPHKFPABNC(TNode MHCJEACPLEG, TNode FKGHPCFGFJE, bool DMALALHBOOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x49E3370", Offset = "0x49E2770", VA = "0x1849E3370")]
	private OFAGCFKONIE BNGANNPELCE(TNode BLGGFHHEDNC, TNode KLDFHLFOOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x49E3C10", Offset = "0x49E3010", VA = "0x1849E3C10")]
	private OFAGCFKONIE IEKOKIJOAGG(TNode BLGGFHHEDNC, TNode KLDFHLFOOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x49E4450", Offset = "0x49E3850", VA = "0x1849E4450")]
	private void LJGHGBJNDKO(OFAGCFKONIE INAPFKLHCFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PJEGKALNPFE<T> : IEnumerable<PJEGKALNPFE<T>.EOINJMMPHOL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct EOINJMMPHOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T FFOEEMKIKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int CJFNAFNJJLB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class FALODCNPKKL : IEnumerator<EOINJMMPHOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private PJEGKALNPFE<T> IMOLDFICHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int CJFNAFNJJLB;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x430EF90", Offset = "0x430E390", VA = "0x18430EF90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public EOINJMMPHOL JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4704D40", Offset = "0x4704140", VA = "0x184704D40", Slot = "4")]
			get
			{
				return default(EOINJMMPHOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4704C50", Offset = "0x4704050", VA = "0x184704C50")]
		public FALODCNPKKL(PJEGKALNPFE<T> IMOLDFICHHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4704B50", Offset = "0x4703F50", VA = "0x184704B50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x436E1D0", Offset = "0x436D5D0", VA = "0x18436E1D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1047140", Offset = "0x1046540", VA = "0x181047140", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct EJCPBKLMLME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool JFOBOLNIPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T FFOEEMKIKJO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int KMLIDEPMLCN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> OJNLGJKINNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private EJCPBKLMLME[] FLCIPACJAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int LJJOJPHLNKI;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int IHHMIFJCELF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xC6FB60", Offset = "0xC6EF60", VA = "0x180C6FB60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xE4ACB0", Offset = "0xE4A0B0", VA = "0x180E4ACB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7C60", Offset = "0x3EA7060", VA = "0x183EA7C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x531BBB0", Offset = "0x531AFB0", VA = "0x18531BBB0")]
	public PJEGKALNPFE(int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x531B790", Offset = "0x531AB90", VA = "0x18531B790")]
	public PJEGKALNPFE(EOINJMMPHOL[] KEOKEOEPADF, bool DPCDAPKIAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x531B010", Offset = "0x531A410", VA = "0x18531B010")]
	public int EFMAMFAINCJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x531B3F0", Offset = "0x531A7F0", VA = "0x18531B3F0")]
	private int LLMPHCAMOMK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x531B680", Offset = "0x531AA80", VA = "0x18531B680", Slot = "6")]
	protected virtual uint NODBEKNMJCK(uint FJJIBEAAGGP, T FFOEEMKIKJO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x531B0D0", Offset = "0x531A4D0", VA = "0x18531B0D0")]
	public bool KADJIPIGNIG(T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x531AF90", Offset = "0x531A390", VA = "0x18531AF90")]
	public int AMFLNKOGMNI(T FFOEEMKIKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x531B610", Offset = "0x531AA10", VA = "0x18531B610")]
	public T MLACMEICEMO(int CJFNAFNJJLB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x531B130", Offset = "0x531A530", VA = "0x18531B130")]
	public bool KHHMKEEJKGJ(T FFOEEMKIKJO, bool JNLBGJFJKEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x531B190", Offset = "0x531A590", VA = "0x18531B190")]
	public bool KHHMKEEJKGJ(T FFOEEMKIKJO, int CJFNAFNJJLB, bool JNLBGJFJKEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x531B6A0", Offset = "0x531AAA0", VA = "0x18531B6A0")]
	private int OCDDGOEOAFK(int GNPKFMEIDNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x531B6F0", Offset = "0x531AAF0", VA = "0x18531B6F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x531B6F0", Offset = "0x531AAF0", VA = "0x18531B6F0", Slot = "4")]
	private IEnumerator<EOINJMMPHOL> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class MAEKECGNICD<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> LHNFDMCLNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> PIFDACANOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int HJLCKKMBJOD;

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5041700", Offset = "0x5040B00", VA = "0x185041700")]
	public static MAEKECGNICD<T> PKGLILPKCKL(int HDAIOJEADNO = 0, int HJLCKKMBJOD = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x50417F0", Offset = "0x5040BF0", VA = "0x1850417F0")]
	public static MAEKECGNICD<T> PPADHNPKEEP(int HDAIOJEADNO = 0, int HJLCKKMBJOD = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x50418E0", Offset = "0x5040CE0", VA = "0x1850418E0")]
	public MAEKECGNICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5041930", Offset = "0x5040D30", VA = "0x185041930")]
	public MAEKECGNICD(int HDAIOJEADNO, int HJLCKKMBJOD = int.MaxValue, bool MNFGFMNHHAF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x50413F0", Offset = "0x50407F0", VA = "0x1850413F0")]
	public T GKNBKKNIPGM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5041310", Offset = "0x5040710", VA = "0x185041310")]
	public void FEMKONHLAGL(T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5041600", Offset = "0x5040A00", VA = "0x185041600")]
	private void KCIOHMKNAKK(T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x50415C0", Offset = "0x50409C0", VA = "0x1850415C0")]
	private void HHEBOIDCBLJ(T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5041180", Offset = "0x5040580", VA = "0x185041180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5040F90", Offset = "0x5040390", VA = "0x185040F90")]
	private void CFADOGINOMI(IEnumerable<T> JGMAGBDHLIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class BJEDLBDJLJD<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> JLLDPNEPEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T LGHJNJMPFJL;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T HICMJGNAKOC
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5F28470", Offset = "0x5F27870", VA = "0x185F28470")]
	public bool JHAAOHPGICL(T FFOEEMKIKJO, int PKKOAIHLPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4C0D580", Offset = "0x4C0C980", VA = "0x184C0D580")]
	public bool GOGJPLAFFMK(int PKKOAIHLPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5F27F90", Offset = "0x5F27390", VA = "0x185F27F90")]
	public T GFLLIGKNOFJ(int HGOLMEKOOJB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5F27DA0", Offset = "0x5F271A0", VA = "0x185F27DA0")]
	private bool CMPEKILFMCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5F27D40", Offset = "0x5F27140", VA = "0x185F27D40")]
	public bool BGPIDOLLEKE(int PKKOAIHLPOK, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5F28510", Offset = "0x5F27910", VA = "0x185F28510")]
	public BJEDLBDJLJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class JDGCAPCOLKP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	protected struct LOAKKBCIOFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T HDKOPKMNJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int KCOBLCMJBKO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<LOAKKBCIOFD> HHOLFJLOEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T JIKNOOCDKPG;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7C60", Offset = "0x3EA7060", VA = "0x183EA7C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4BFFFA0", Offset = "0x4BFF3A0", VA = "0x184BFFFA0")]
	public bool JOEMDCADNHJ(T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4BFFEF0", Offset = "0x4BFF2F0", VA = "0x184BFFEF0")]
	public void JJBKLNLGAIJ(T FFOEEMKIKJO, int PKKOAIHLPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4BFFC20", Offset = "0x4BFF020", VA = "0x184BFFC20")]
	public bool JEBJOEBLLEI(T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF700", Offset = "0x4BFEB00", VA = "0x184BFF700")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4C00390", Offset = "0x4BFF790", VA = "0x184C00390")]
	public T NBAGDHBBMCG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF920", Offset = "0x4BFED20", VA = "0x184BFF920")]
	protected void GNAEPOOJIPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4C004C0", Offset = "0x4BFF8C0", VA = "0x184C004C0")]
	public JDGCAPCOLKP()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x789A6F0", Offset = "0x7899AF0", VA = "0x18789A6F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x789A9C0", Offset = "0x7899DC0", VA = "0x18789A9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x789A8D0", Offset = "0x7899CD0", VA = "0x18789A8D0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x789A640", Offset = "0x7899A40", VA = "0x18789A640")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x789A910", Offset = "0x7899D10", VA = "0x18789A910")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x789A820", Offset = "0x7899C20", VA = "0x18789A820")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x789A5C0", Offset = "0x78999C0", VA = "0x18789A5C0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5521660", Offset = "0x5520A60", VA = "0x185521660", Slot = "4")]
		public virtual T NOJEAIIHJKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class GIPJKJOHGOJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Dictionary<byte, HLKDFEAAGHL> EPNOLAOCCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly MAEKECGNICD<HLKDFEAAGHL> PMBHIEBEGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool DEGLOHDFKJN;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public HLKDFEAAGHL BJCGPEEMGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 BLEEENGKIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x14B4B70", Offset = "0x14B3F70", VA = "0x1814B4B70")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xBD34D0", Offset = "0xBD28D0", VA = "0x180BD34D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private Vector2 IHJJFDFCDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xC0FC20", Offset = "0xC0F020", VA = "0x180C0FC20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 PCKNMKPEJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7897980", Offset = "0x7896D80", VA = "0x187897980")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA380", Offset = "0x9A9780", VA = "0x1809AA380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int GPMBEGAAOAP
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9B01D0", Offset = "0x9AF5D0", VA = "0x1809B01D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9B01C0", Offset = "0x9AF5C0", VA = "0x1809B01C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7898840", Offset = "0x7897C40", VA = "0x187898840")]
	public GIPJKJOHGOJ(Bounds FCNAOLFGABF, Vector2[] IIENOAADPPM, int JAOKLDDAOCK, byte GNPKFMEIDNL, float FOGNJLJNAAM = 0f, [Optional] MAEKECGNICD<HLKDFEAAGHL> PMBHIEBEGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7897F60", Offset = "0x7897360", VA = "0x187897F60")]
	public void MKDDMOFNGEH(Bounds FCNAOLFGABF, Vector2[] IIENOAADPPM, int JAOKLDDAOCK, byte GNPKFMEIDNL, float FOGNJLJNAAM = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7897F00", Offset = "0x7897300", VA = "0x187897F00")]
	public HLKDFEAAGHL LOACJMMNNIL(byte CJFNAFNJJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x78978B0", Offset = "0x7896CB0", VA = "0x1878978B0")]
	public void BEACFMJMIPM(Vector3 INHMOEHIHAJ, float LMIAKEKJLAE, float CJOHBAOHBNO, List<byte> CBCGNOJNLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7897890", Offset = "0x7896C90", VA = "0x187897890")]
	public void AMLBAKKIAHO(HLKDFEAAGHL.EBNOBKKBKIG MBIOPMNCMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7897E20", Offset = "0x7897220", VA = "0x187897E20")]
	public static int KLOAJNPMLEL(Vector2[] IIENOAADPPM, int JAOKLDDAOCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x78983F0", Offset = "0x78977F0", VA = "0x1878983F0")]
	private HLKDFEAAGHL NLFDIKBALII(byte CJFNAFNJJLB, HLKDFEAAGHL.OAKPGKHPPIJ KIDCBFDJAGE, HLKDFEAAGHL KLDFHLFOOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x78979A0", Offset = "0x7896DA0", VA = "0x1878979A0")]
	private void DONOIJMGDGE(HLKDFEAAGHL KLDFHLFOOFN, Vector2[] IIENOAADPPM, int FNEKGGKBJKD, int KCDCHBKIAOH, int PAAEEECMFDJ, int BEBAIMOENDE, float FOGNJLJNAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7898620", Offset = "0x7897A20", VA = "0x187898620")]
	private void POPKDBMJAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7897D60", Offset = "0x7897160", VA = "0x187897D60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7897DC0", Offset = "0x78971C0", VA = "0x187897DC0", Slot = "1")]
	~GIPJKJOHGOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class HLKDFEAAGHL
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum OAKPGKHPPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum EBNOBKKBKIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte GEEBDAOOGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 MOBLDDDLJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 BFPJLGPCCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 CMCKKLLJEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 ALBCIAIGKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public OAKPGKHPPIJ CFNCDKOFGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public HLKDFEAAGHL HBBFFDLJGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public List<HLKDFEAAGHL> EOKIIEEEJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool BFBEDIFAFLM;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7898E50", Offset = "0x7898250", VA = "0x187898E50")]
	public HLKDFEAAGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7898D10", Offset = "0x7898110", VA = "0x187898D10")]
	public void OEHIFBKDANM(HLKDFEAAGHL MKPPIPAJFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	public void AMLBAKKIAHO(int NCFAMHMJGPN, EBNOBKKBKIG MBIOPMNCMAJ, int DEBJGENBPIA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x78989C0", Offset = "0x7897DC0", VA = "0x1878989C0")]
	public void BEACFMJMIPM(List<byte> CBCGNOJNLCK, Vector3 INHMOEHIHAJ, float LMIAKEKJLAE, float CJOHBAOHBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7898CE0", Offset = "0x78980E0", VA = "0x187898CE0")]
	public bool KKACCBDFIPJ(Vector3 PFALLGAIEAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7898CB0", Offset = "0x78980B0", VA = "0x187898CB0")]
	public bool IJOLKAENOFH(Vector3 PFALLGAIEAE, float GIEPCOMBBEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7898C20", Offset = "0x7898020", VA = "0x187898C20")]
	public void GDCNGOALEGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public interface ININABGLLEO
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	ToolHierarchyCache ABOPFABMBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		public struct DODFNDEIIFO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private readonly List<Component> CEFIHBLEFNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly bool FODLKBCCJDD;

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x16A7E70", Offset = "0x16A7270", VA = "0x1816A7E70")]
			public DODFNDEIIFO(List<Component> CEFIHBLEFNG, bool FODLKBCCJDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x66FC340", Offset = "0x66FB740", VA = "0x1866FC340")]
			public IAMKIHMAPMH<T> DBEEDGEHMMA()
			{
				return default(IAMKIHMAPMH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x66FC3A0", Offset = "0x66FB7A0", VA = "0x1866FC3A0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x66FC3A0", Offset = "0x66FB7A0", VA = "0x1866FC3A0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct IAMKIHMAPMH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly List<Component> CEFIHBLEFNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly bool FODLKBCCJDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private int CJFNAFNJJLB;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T JKNLEFEANEI
			{
				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x49E6090", Offset = "0x49E5490", VA = "0x1849E6090", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x49E6020", Offset = "0x49E5420", VA = "0x1849E6020", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x49E6060", Offset = "0x49E5460", VA = "0x1849E6060")]
			public IAMKIHMAPMH(List<Component> CEFIHBLEFNG, bool FODLKBCCJDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x49E5F60", Offset = "0x49E5360", VA = "0x1849E5F60", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x49E5F70", Offset = "0x49E5370", VA = "0x1849E5F70", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x4360880", Offset = "0x435FC80", VA = "0x184360880", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x789C3B0", Offset = "0x789B7B0", VA = "0x18789C3B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x789BDB0", Offset = "0x789B1B0", VA = "0x18789BDB0")]
		private void GDCNGOALEGL(GameObject PLAPLCBPJGM, bool HLPBIKLHEBD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x789BD20", Offset = "0x789B120", VA = "0x18789BD20")]
		public static void GDCNGOALEGL(GameObject PLAPLCBPJGM, ToolHierarchyCache OEEONBHNECC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x789BF90", Offset = "0x789B390", VA = "0x18789BF90")]
		public void JMFBBFMHGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x39A79A0", Offset = "0x39A6DA0", VA = "0x1839A79A0")]
		public void GHBILAMAGEG<T>(Action<T> IOPCFKOHPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x39A7900", Offset = "0x39A6D00", VA = "0x1839A7900")]
		public T BHCANJCCIFF<T>(bool FODLKBCCJDD = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x39A7BE0", Offset = "0x39A6FE0", VA = "0x1839A7BE0")]
		public DODFNDEIIFO<T> JCJNJCDHNJL<T>(bool FODLKBCCJDD = false) where T : class
		{
			return default(DODFNDEIIFO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x789BFA0", Offset = "0x789B3A0", VA = "0x18789BFA0")]
		public List<Component> OPENLKHMMDK(Type HAFNBBNOLPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x789BCA0", Offset = "0x789B0A0", VA = "0x18789BCA0", Slot = "4")]
		public bool Equals(ToolHierarchyCache MEAMPLHPPKP, ToolHierarchyCache KDELALKKKOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x789BF20", Offset = "0x789B320", VA = "0x18789BF20", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache BLFGIKOAKOL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class CEBDBMIPKGF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int HDAIOJEADNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int GPGGADNCIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private List<T> KLIMJMOCIDN;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x471FC70", Offset = "0x471F070", VA = "0x18471FC70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T HNICEFLLFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x62FC570", Offset = "0x62FB970", VA = "0x1862FC570")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T PECHBGPDAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x62FC460", Offset = "0x62FB860", VA = "0x1862FC460")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T NAECMHEKOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x62FC3C0", Offset = "0x62FB7C0", VA = "0x1862FC3C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x62FCAD0", Offset = "0x62FBED0", VA = "0x1862FCAD0")]
	public CEBDBMIPKGF(int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x62FC870", Offset = "0x62FBC70", VA = "0x1862FC870")]
	public void JJBKLNLGAIJ(T FNMNNKBIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x62FC2F0", Offset = "0x62FB6F0", VA = "0x1862FC2F0")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x62FC200", Offset = "0x62FB600", VA = "0x1862FC200")]
	public void BGGANAPDHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x62FCA70", Offset = "0x62FBE70", VA = "0x1862FCA70")]
	public void MCCJACAAFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x62FC1F0", Offset = "0x62FB5F0", VA = "0x1862FC1F0")]
	public void AHOJIPONMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x62FC9E0", Offset = "0x62FBDE0", VA = "0x1862FC9E0")]
	public List<T> LHLCCBBLLDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class EOEMODHNBOJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct NNNBMCLIIEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int KCOBLCMJBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public T HDKOPKMNJCH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Dictionary<object, NNNBMCLIIEE> JLLDPNEPEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EqualityComparer<T> BDBNFBEJAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T LGHJNJMPFJL;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public virtual T HICMJGNAKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xC76DA0", Offset = "0xC761A0", VA = "0x180C76DA0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x42FED50", Offset = "0x42FE150", VA = "0x1842FED50", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool PKMGEMMGNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x42FE9C0", Offset = "0x42FDDC0", VA = "0x1842FE9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public object DOLHFECNPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9B40A0", Offset = "0x9B34A0", VA = "0x1809B40A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x42FEC60", Offset = "0x42FE060", VA = "0x1842FEC60")]
	public bool JHAAOHPGICL(T FFOEEMKIKJO, object HHGPJKKLNIG, int PKKOAIHLPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x42FEA20", Offset = "0x42FDE20", VA = "0x1842FEA20")]
	public bool GOGJPLAFFMK(object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x42FDF30", Offset = "0x42FD330", VA = "0x1842FDF30")]
	public bool BGPIDOLLEKE(object HHGPJKKLNIG, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x42FE060", Offset = "0x42FD460", VA = "0x1842FE060")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x42FE0B0", Offset = "0x42FD4B0", VA = "0x1842FE0B0")]
	private bool CMPEKILFMCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x42FED90", Offset = "0x42FE190", VA = "0x1842FED90")]
	public EOEMODHNBOJ()
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
