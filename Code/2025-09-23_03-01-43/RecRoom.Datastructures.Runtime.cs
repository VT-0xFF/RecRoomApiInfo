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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x84BE8D0", Offset = "0x84BCED0", VA = "0x1884BE8D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CBNBOPONCLF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x241B440", Offset = "0x2419A40", VA = "0x18241B440")]
	public CBNBOPONCLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, MBAIGEMKLDH, BNCJPENGCAJ, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash MBMNKPPCEJE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xD5F7D0", Offset = "0xD5DDD0", VA = "0x180D5F7D0")]
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
	[SerializeField]
	[ReadOnlyField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84BFE40", Offset = "0x84BE440", VA = "0x1884BFE40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84BFE00", Offset = "0x84BE400", VA = "0x1884BFE00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84BFE80", Offset = "0x84BE480", VA = "0x1884BFE80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84C0030", Offset = "0x84BE630", VA = "0x1884C0030")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84BFFA0", Offset = "0x84BE5A0", VA = "0x1884BFFA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB02260", Offset = "0xB00860", VA = "0x180B02260")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xB02540", Offset = "0xB00B40", VA = "0x180B02540")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84BFDC0", Offset = "0x84BE3C0", VA = "0x1884BFDC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84BFF10", Offset = "0x84BE510", VA = "0x1884BFF10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84BF860", Offset = "0x84BDE60", VA = "0x1884BF860")]
	public void CopyBounds(SavedExtents AAGCKLPFJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84BFD10", Offset = "0x84BE310", VA = "0x1884BFD10")]
	public void SetLocalSpaceBounds(Bounds HFPGJBKJHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x173FBF0", Offset = "0x173E1F0", VA = "0x18173FBF0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84BFD00", Offset = "0x84BE300", VA = "0x1884BFD00")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84BF890", Offset = "0x84BDE90", VA = "0x1884BF890")]
	private void JHPMMAGKNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84BFB00", Offset = "0x84BE100", VA = "0x1884BFB00")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84BF1F0", Offset = "0x84BD7F0", VA = "0x1884BF1F0")]
	public static void CalculateLocalBoundsFor(GameObject JJEACKINPOJ, [Out] Bounds HFPGJBKJHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84BFA40", Offset = "0x84BE040", VA = "0x1884BFA40")]
	private static void LJJOBHNLDHC(Bounds PDHHCOODKIC, Color KGDLOJHDMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84BFD30", Offset = "0x84BE330", VA = "0x1884BFD30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1C1B900", Offset = "0x1C19F00", VA = "0x181C1B900")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F17530", Offset = "0x5F15B30", VA = "0x185F17530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	public virtual void LABGMPOOMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
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
	[CBNBOPONCLF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F17110", Offset = "0x5F15710", VA = "0x185F17110", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F15E00", Offset = "0x5F14400", VA = "0x185F15E00", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5F17480", Offset = "0x5F15A80", VA = "0x185F17480")]
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
	private sealed class LCCABHBEFEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LCCABHBEFEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x57C3BE0", Offset = "0x57C21E0", VA = "0x1857C3BE0")]
		internal int JELEEFFHDHI(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[CBNBOPONCLF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4B79210", Offset = "0x4B77810", VA = "0x184B79210", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4B79260", Offset = "0x4B77860", VA = "0x184B79260", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4B79110", Offset = "0x4B77710", VA = "0x184B79110", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey HAELBKGFDIJ]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4B791B0", Offset = "0x4B777B0", VA = "0x184B791B0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4B78FF0", Offset = "0x4B775F0", VA = "0x184B78FF0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4B78D00", Offset = "0x4B77300", VA = "0x184B78D00", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4B78140", Offset = "0x4B76740", VA = "0x184B78140", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4B780B0", Offset = "0x4B766B0", VA = "0x184B780B0", Slot = "14")]
	protected virtual string IMIMAEGNBKN(TKeyVal AHEEBNJILJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4B77FC0", Offset = "0x4B765C0", VA = "0x184B77FC0", Slot = "4")]
	public bool ContainsKey(TKey HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4B78EB0", Offset = "0x4B774B0", VA = "0x184B78EB0", Slot = "5")]
	public bool TryGetValue(TKey HAELBKGFDIJ, [Out] TVal KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4B78010", Offset = "0x4B76610", VA = "0x184B78010", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4B78010", Offset = "0x4B76610", VA = "0x184B78010", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4B78F00", Offset = "0x4B77500", VA = "0x184B78F00")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
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
		[Cpp2IlInjected.Address(RVA = "0x4620370", Offset = "0x461E970", VA = "0x184620370")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[CBNBOPONCLF]
	[SerializeField]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5F18D10", Offset = "0x5F17310", VA = "0x185F18D10")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F185D0", Offset = "0x5F16BD0", VA = "0x185F185D0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5F17BC0", Offset = "0x5F161C0", VA = "0x185F17BC0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class CHBJFFKIFPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct CNGPIMHNIAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T CECIKJNPCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float NDAPBLPIOFB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int KDEELOOHEEK = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float DFHPJAAPIDH = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly CNGPIMHNIAL[] GHKPAFFMJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int DJAHBFOFCDB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float GEEJNCFNHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDA16A0", Offset = "0xD9FCA0", VA = "0x180DA16A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE1BC20", Offset = "0xE1A220", VA = "0x180E1BC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T LKMKMCDHPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F89140", Offset = "0x6F87740", VA = "0x186F89140")]
	protected CHBJFFKIFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F89160", Offset = "0x6F87760", VA = "0x186F89160")]
	protected CHBJFFKIFPO(int KCJLCGFEBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F88F80", Offset = "0x6F87580", VA = "0x186F88F80")]
	public void MEFAAGOGBHI(float HBAPMMDKJDM, T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool JEDIOHIOJFD(float FJOIBADLBFH, float HNICEAFIFIL, [Out] T KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool PAAOCGLBLAB(float FJOIBADLBFH, float HNICEAFIFIL, [Out] T KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F88EB0", Offset = "0x6F874B0", VA = "0x186F88EB0")]
	public void ELFNJAKNOMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KGLDGBIDHJI : CHBJFFKIFPO<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84BE3E0", Offset = "0x84BC9E0", VA = "0x1884BE3E0", Slot = "4")]
	public override bool JEDIOHIOJFD(float FJOIBADLBFH, float HNICEAFIFIL, [Out] Vector3 KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84BE540", Offset = "0x84BCB40", VA = "0x1884BE540", Slot = "5")]
	public override bool PAAOCGLBLAB(float FJOIBADLBFH, float HNICEAFIFIL, [Out] Vector3 KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x84BE680", Offset = "0x84BCC80", VA = "0x1884BE680")]
	public KGLDGBIDHJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ANJKKMEKGAO
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x330B4C0", Offset = "0x3309AC0", VA = "0x18330B4C0")]
	public static KHIFPLIFILG<T1, T2> CEAHGFMKGJD<T1, T2>(T1 GKPLGIFPAJC, T2 FBPPJMGDKLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x330B540", Offset = "0x3309B40", VA = "0x18330B540")]
	public static GEIKDDONMKC<T1, T2, T3> CEAHGFMKGJD<T1, T2, T3>(T1 GKPLGIFPAJC, T2 FBPPJMGDKLK, T3 KEKPFBLLNDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5A59ED0", Offset = "0x5A584D0", VA = "0x185A59ED0")]
	internal static int OGCKNANEIIP(int GKPKPCAFGLM, int GLBHMIBDHFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x75FEC10", Offset = "0x75FD210", VA = "0x1875FEC10")]
	internal static int OGCKNANEIIP(int GKPKPCAFGLM, int GLBHMIBDHFC, int JAEINELFIHN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KHIFPLIFILG<T1, T2> : IComparable<KHIFPLIFILG<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 HJIPFDEJMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 ONFKMHLKDFO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5678840", Offset = "0x5676E40", VA = "0x185678840")]
	public KHIFPLIFILG(T1 GKPLGIFPAJC, T2 FBPPJMGDKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x56774E0", Offset = "0x5675AE0", VA = "0x1856774E0", Slot = "4")]
	public int CompareTo(KHIFPLIFILG<T1, T2> AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x56778B0", Offset = "0x5675EB0", VA = "0x1856778B0", Slot = "0")]
	public override bool Equals(object AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5678040", Offset = "0x5676640", VA = "0x185678040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5678440", Offset = "0x5676A40", VA = "0x185678440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GEIKDDONMKC<T1, T2, T3> : IComparable<GEIKDDONMKC<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 HJIPFDEJMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 ONFKMHLKDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 AIFDBPGIFME;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x50EC190", Offset = "0x50EA790", VA = "0x1850EC190")]
	public GEIKDDONMKC(T1 GKPLGIFPAJC, T2 FBPPJMGDKLK, T3 KEKPFBLLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x50EB820", Offset = "0x50E9E20", VA = "0x1850EB820", Slot = "4")]
	public int CompareTo(GEIKDDONMKC<T1, T2, T3> AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x50EBBC0", Offset = "0x50EA1C0", VA = "0x1850EBBC0", Slot = "0")]
	public override bool Equals(object AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x50EBD90", Offset = "0x50EA390", VA = "0x1850EBD90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x50EBFD0", Offset = "0x50EA5D0", VA = "0x1850EBFD0", Slot = "3")]
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
	public AnimationCurve CEGIBOHBGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T FPHLEMKFAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1455470", Offset = "0x1453A70", VA = "0x181455470")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T OOMIACNCOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xBF19C0", Offset = "0xBEFFC0", VA = "0x180BF19C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2FCE140", Offset = "0x2FCC740", VA = "0x182FCE140")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2FCE200", Offset = "0x2FCC800", VA = "0x182FCE200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float DGHPNPEDKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAF8E90", Offset = "0xAF7490", VA = "0x180AF8E90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61FCAF0", Offset = "0x61FB0F0", VA = "0x1861FCAF0")]
	public T FIFODDANBMP(float DHDFDKFCOJK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61FCCC0", Offset = "0x61FB2C0", VA = "0x1861FCCC0")]
	public T NGFBJKBJNPB(float DHDFDKFCOJK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DNMIPJMBGCK(T BNPLNGPMIIG, T DIIGMDFDOAL, float DHDFDKFCOJK);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x84BDE00", Offset = "0x84BC400", VA = "0x1884BDE00", Slot = "4")]
	protected override float DNMIPJMBGCK(float BNPLNGPMIIG, float DIIGMDFDOAL, float DHDFDKFCOJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84BDE40", Offset = "0x84BC440", VA = "0x1884BDE40")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1A52290", Offset = "0x1A50890", VA = "0x181A52290", Slot = "4")]
	protected override Vector3 DNMIPJMBGCK(Vector3 BNPLNGPMIIG, Vector3 DIIGMDFDOAL, float DHDFDKFCOJK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84C0E80", Offset = "0x84BF480", VA = "0x1884C0E80")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84BC960", Offset = "0x84BAF60", VA = "0x1884BC960", Slot = "4")]
	protected override Color DNMIPJMBGCK(Color BNPLNGPMIIG, Color DIIGMDFDOAL, float DHDFDKFCOJK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84BCA20", Offset = "0x84BB020", VA = "0x1884BCA20")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HHBLGDBAAKP : KCPAFICBKNF<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84BE240", Offset = "0x84BC840", VA = "0x1884BE240")]
	public HHBLGDBAAKP(int AHIAOIDMGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84BE1D0", Offset = "0x84BC7D0", VA = "0x1884BE1D0", Slot = "6")]
	protected override uint KEBFALEPGBB(uint MBMNKPPCEJE, string KOPHBHGIACG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OOMNOKEBKFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable EHBCEBDHHPE;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public OOMNOKEBKFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct IKALACCDFFK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> NNJCNAJAAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int EDJDGIIAGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int GPJONBBGPHB;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5180440", Offset = "0x517EA40", VA = "0x185180440")]
	private IKALACCDFFK(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> EMJNAKKOBCE, int LAFCMPHHFML, int PJOPDPNHNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5299570", Offset = "0x5297B70", VA = "0x185299570")]
	public static IKALACCDFFK<T> CPNHECDILPK()
	{
		return default(IKALACCDFFK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x529AAB0", Offset = "0x52990B0", VA = "0x18529AAB0")]
	public (int, int, Task<T>) KAMDGAFLBGF(int MGHFDLLINAI, [Optional] CancellationToken PJCIHHKJKBP, double OEDPOHDPEIB = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x529B4E0", Offset = "0x5299AE0", VA = "0x18529B4E0")]
	public void NNCIHBLNPKF(int MGHFDLLINAI, int PJOPDPNHNGP, [In] T FAKHJBCPGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class PPPPMMBOBDA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x84BEBE0", Offset = "0x84BD1E0", VA = "0x1884BEBE0")]
	public static IKALACCDFFK<IHJGGHCFJKD> CPNHECDILPK()
	{
		return default(IKALACCDFFK<IHJGGHCFJKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84BEC30", Offset = "0x84BD230", VA = "0x1884BEC30")]
	public static void NNCIHBLNPKF([In] this IKALACCDFFK<IHJGGHCFJKD> JNMMMBJNOND, int MGHFDLLINAI, int PJOPDPNHNGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class HGLBBGGAOFG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> PABPNDMECIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> ANLFHGONIML;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x45C9C40", Offset = "0x45C8240", VA = "0x1845C9C40", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BOFAKENAFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> OHEGHCIAIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4665280", Offset = "0x4663880", VA = "0x184665280", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> FFNODFMPDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5162DC0", Offset = "0x51613C0", VA = "0x185162DC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5162CE0", Offset = "0x51612E0", VA = "0x185162CE0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5162E20", Offset = "0x5161420", VA = "0x185162E20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5162600", Offset = "0x5160C00", VA = "0x185162600")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5161D00", Offset = "0x5160300", VA = "0x185161D00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5162A10", Offset = "0x5161010", VA = "0x185162A10", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5161CD0", Offset = "0x51602D0", VA = "0x185161CD0", Slot = "9")]
	public void Add(TKey HAELBKGFDIJ, TVal KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5161CA0", Offset = "0x51602A0", VA = "0x185161CA0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5161DC0", Offset = "0x51603C0", VA = "0x185161DC0", Slot = "8")]
	public bool ContainsKey(TKey HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5161E80", Offset = "0x5160480", VA = "0x185161E80", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> NANHMPOBBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5162930", Offset = "0x5160F30", VA = "0x185162930", Slot = "10")]
	public bool Remove(TKey HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x51629E0", Offset = "0x5160FE0", VA = "0x1851629E0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> NANHMPOBBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5162B00", Offset = "0x5161100", VA = "0x185162B00", Slot = "11")]
	public bool TryGetValue(TKey HAELBKGFDIJ, [Out] TVal KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5161FD0", Offset = "0x51605D0", VA = "0x185161FD0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5161EB0", Offset = "0x51604B0", VA = "0x185161EB0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GHKPAFFMJAO, int MHIOAOJIPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5161F30", Offset = "0x5160530", VA = "0x185161F30")]
	public bool DCJACLLMOIN(TVal HAELBKGFDIJ, [Out] TKey KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5162290", Offset = "0x5160890", VA = "0x185162290")]
	private void MBFDOPGMJIB(TKey HAELBKGFDIJ, TVal IKJAADLGNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5162800", Offset = "0x5160E00", VA = "0x185162800")]
	private void ONFNHNINAEE(TKey HAELBKGFDIJ, TVal IKJAADLGNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5162330", Offset = "0x5160930", VA = "0x185162330")]
	private bool MGAHDLGJJIO(TKey HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5162BA0", Offset = "0x51611A0", VA = "0x185162BA0")]
	public HGLBBGGAOFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class NEKJAKFIEMM<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private NEKJAKFIEMM<T> buffer;

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
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x157A6A0", Offset = "0x1578CA0", VA = "0x18157A6A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x4BE2310", Offset = "0x4BE0910", VA = "0x184BE2310", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4BE3D40", Offset = "0x4BE2340", VA = "0x184BE3D40")]
		public Enumerator(NEKJAKFIEMM<T> DNGAEEFBGGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4BE0770", Offset = "0x4BDED70", VA = "0x184BE0770", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4BE1FF0", Offset = "0x4BE05F0", VA = "0x184BE1FF0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4BE0040", Offset = "0x4BDE640", VA = "0x184BE0040")]
		private void JGHKOPAPFGA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] GFNBOLMANDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int NDMFOILAFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int GNCMIFFAFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int AENIMEGPBEO;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5A7CC90", Offset = "0x5A7B290", VA = "0x185A7CC90", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5A7BDD0", Offset = "0x5A7A3D0", VA = "0x185A7BDD0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5A7B610", Offset = "0x5A79C10", VA = "0x185A7B610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5A7CC10", Offset = "0x5A7B210", VA = "0x185A7CC10")]
	public NEKJAKFIEMM(int AHIAOIDMGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5A7BBD0", Offset = "0x5A7A1D0", VA = "0x185A7BBD0")]
	public void MEFAAGOGBHI(T DHDFDKFCOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5A7A7C0", Offset = "0x5A78DC0", VA = "0x185A7A7C0")]
	public void DMIIHNGPKJN(IEnumerable<T> ICKFEKPLGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5A7AE80", Offset = "0x5A79480", VA = "0x185A7AE80")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5A7B7F0", Offset = "0x5A79DF0", VA = "0x185A7B7F0")]
	public void HIELOLIAHOB(int LMJBLNOIBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5A7C640", Offset = "0x5A7AC40", VA = "0x185A7C640")]
	public void OCEKIKEEKEK(T[] GHKPAFFMJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5A798D0", Offset = "0x5A77ED0", VA = "0x185A798D0")]
	public Enumerator ABGODHCJODA()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5A7CAA0", Offset = "0x5A7B0A0", VA = "0x185A7CAA0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5A7CAA0", Offset = "0x5A7B0A0", VA = "0x185A7CAA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5A7B2E0", Offset = "0x5A798E0", VA = "0x185A7B2E0")]
	private int FHDAHCMDADI(int PMIGBJGNLLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5A79A00", Offset = "0x5A78000", VA = "0x185A79A00")]
	private int CAOCMEPPNNJ(int PMIGBJGNLLP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LMLIHPAPFIM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> KOPGIOODMED(TRequest KOKMGKHMMEE, CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum GIIBGPAKDIE
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class KGEFFGBDEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float MBFOFNAFMNL = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan LDKMAAMAFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int NOCGOEEIAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GIIBGPAKDIE ECEONLNBFIF;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly KGEFFGBDEIJ DKABDBMACEB;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float HPGPFONIKPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x55E8C50", Offset = "0x55E7250", VA = "0x1855E8C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan GDLBDOAPPGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x55E8D30", Offset = "0x55E7330", VA = "0x1855E8D30")]
		public KGEFFGBDEIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct MMHKEBCFGMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest KOKMGKHMMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken PJCIHHKJKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> HCLIHOMOOMM;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5A1CCF0", Offset = "0x5A1B2F0", VA = "0x185A1CCF0")]
		public MMHKEBCFGMM(TRequest KOKMGKHMMEE, TaskCompletionSource<TResult> HCLIHOMOOMM, CancellationToken PJCIHHKJKBP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct ALBAJJBNABJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public LMLIHPAPFIM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x57A5110", Offset = "0x57A3710", VA = "0x1857A5110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x57A5550", Offset = "0x57A3B50", VA = "0x1857A5550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct JJBHBOOFEFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public LMLIHPAPFIM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MMHKEBCFGMM <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x54E6B90", Offset = "0x54E5190", VA = "0x1854E6B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x54E71F0", Offset = "0x54E57F0", VA = "0x1854E71F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource IKGPFLNCIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<MMHKEBCFGMM> IHIPGHKPPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly KGEFFGBDEIJ DBDCDOOGFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KOPGIOODMED KAHPFJEGGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task ONBFCGKIEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int HOAOLIFODMC;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x57D5D40", Offset = "0x57D4340", VA = "0x1857D5D40")]
	public LMLIHPAPFIM(KOPGIOODMED KAHPFJEGGGM, [Optional] KGEFFGBDEIJ DBDCDOOGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x57D5B50", Offset = "0x57D4150", VA = "0x1857D5B50")]
	public Task<TResult> NBHEBECIPJK(TRequest KOKMGKHMMEE, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x57D5240", Offset = "0x57D3840", VA = "0x1857D5240")]
	private void ICMHOPOMGAD(MMHKEBCFGMM JEBLJACCFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x57D4E90", Offset = "0x57D3490", VA = "0x1857D4E90")]
	[AsyncStateMachine(typeof(LMLIHPAPFIM<, >.ALBAJJBNABJ))]
	private Task FPICCOFLPLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x57D44E0", Offset = "0x57D2AE0", VA = "0x1857D44E0")]
	private MMHKEBCFGMM AGPKKPPPKPH()
	{
		return default(MMHKEBCFGMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x57D5150", Offset = "0x57D3750", VA = "0x1857D5150")]
	[AsyncStateMachine(typeof(LMLIHPAPFIM<, >.JJBHBOOFEFK))]
	private Task GOLMBMLFNIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x57D5520", Offset = "0x57D3B20", VA = "0x1857D5520")]
	private void JJMENLAPPJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x57D4CB0", Offset = "0x57D32B0", VA = "0x1857D4CB0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class JJAAPPCMMOE<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> BBBJHCKNPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> BMDCEFMEONE;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x45C9C40", Offset = "0x45C8240", VA = "0x1845C9C40", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool BOFAKENAFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x54E4330", Offset = "0x54E2930", VA = "0x1854E4330", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x54E4450", Offset = "0x54E2A50", VA = "0x1854E4450", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x503EC80", Offset = "0x503D280", VA = "0x18503EC80", Slot = "11")]
	public void Add(T NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x54E3D90", Offset = "0x54E2390", VA = "0x1854E3D90")]
	public bool OCEMEEOJBFJ(T NANHMPOBBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x54E4100", Offset = "0x54E2700", VA = "0x1854E4100", Slot = "15")]
	public bool Remove(T NANHMPOBBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x54E3AF0", Offset = "0x54E20F0", VA = "0x1854E3AF0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x511D210", Offset = "0x511B810", VA = "0x18511D210", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x54E3A20", Offset = "0x54E2020", VA = "0x1854E3A20", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x54E3A80", Offset = "0x54E2080", VA = "0x1854E3A80", Slot = "13")]
	public bool Contains(T NANHMPOBBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x54E3AC0", Offset = "0x54E20C0", VA = "0x1854E3AC0", Slot = "14")]
	public void CopyTo(T[] GHKPAFFMJAO, int MHIOAOJIPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x54E3B80", Offset = "0x54E2180", VA = "0x1854E3B80", Slot = "6")]
	public int IndexOf(T NANHMPOBBLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x54E3CB0", Offset = "0x54E22B0", VA = "0x1854E3CB0", Slot = "7")]
	public void Insert(int PMIGBJGNLLP, T NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x54E3F10", Offset = "0x54E2510", VA = "0x1854E3F10", Slot = "8")]
	public void RemoveAt(int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x54E4240", Offset = "0x54E2840", VA = "0x1854E4240")]
	public JJAAPPCMMOE()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
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
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2DE5FD0", Offset = "0x2DE45D0", VA = "0x182DE5FD0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x84C03D0", Offset = "0x84BE9D0", VA = "0x1884C03D0")]
		public SerializedGuid([In] Guid JJCLDINKIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84C0230", Offset = "0x84BE830", VA = "0x1884C0230")]
		public static SerializedGuid HNPLIFDCICO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84C02B0", Offset = "0x84BE8B0", VA = "0x1884C02B0")]
		public static SerializedGuid NMCDLCHAAAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84C00F0", Offset = "0x84BE6F0", VA = "0x1884C00F0")]
		public bool DEKPKOANCAF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x84C03A0", Offset = "0x84BE9A0", VA = "0x1884C03A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x84C0320", Offset = "0x84BE920", VA = "0x1884C0320", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x84C0150", Offset = "0x84BE750", VA = "0x1884C0150", Slot = "7")]
		public bool Equals(SerializedGuid AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x84C0190", Offset = "0x84BE790", VA = "0x1884C0190", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x84C0220", Offset = "0x84BE820", VA = "0x1884C0220", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84C00C0", Offset = "0x84BE6C0", VA = "0x1884C00C0", Slot = "6")]
		public int CompareTo(SerializedGuid AAGCKLPFJME)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DPKNDGGFDPJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type DEGMGNDHFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string OHDHKDCNNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool FAEJLKACGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool CAGJLKJHGLN;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x84BCA60", Offset = "0x84BB060", VA = "0x1884BCA60")]
	public DPKNDGGFDPJ(Type IOPFBBBHIKL, string OFNDONBHLLE, bool FHHGEAEANLJ = false, bool AGJGNCFDJGC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PEEJNDAHFIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int KDFHHMNMAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> HDAOFPOPHGD(float HBAPMMDKJDM, [Optional] float? POLKEKMDIKL);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CBPEBLIGCIP(float HBAPMMDKJDM, T KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELFNJAKNOMA();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class BECLHMKKDJB<T> : PEEJNDAHFIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct OCFMMBINEFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly T CECIKJNPCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float COHKBGGHDBC;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x54FC850", Offset = "0x54FAE50", VA = "0x1854FC850")]
		public OCFMMBINEFI(T KOPHBHGIACG, float HBAPMMDKJDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class IIFMCACNDIK : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public BECLHMKKDJB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
		[DebuggerHidden]
		public IIFMCACNDIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5287A10", Offset = "0x5286010", VA = "0x185287A10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5287EF0", Offset = "0x52864F0", VA = "0x185287EF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5287D40", Offset = "0x5286340", VA = "0x185287D40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5287EC0", Offset = "0x52864C0", VA = "0x185287EC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly float JKHGPHOOOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly float AGAJFLOKDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly List<OCFMMBINEFI> JDONDHOKKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private int NDMFOILAFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private int NHKHPKKIKNM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KDFHHMNMAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xAA70A0", Offset = "0xAA56A0", VA = "0x180AA70A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A17160", Offset = "0x6A15760", VA = "0x186A17160")]
	public BECLHMKKDJB(float JKHGPHOOOEF, float AGAJFLOKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A165B0", Offset = "0x6A14BB0", VA = "0x186A165B0", Slot = "6")]
	public bool CBPEBLIGCIP(float HBAPMMDKJDM, T KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A16A80", Offset = "0x6A15080", VA = "0x186A16A80", Slot = "8")]
	public int CLHNCECDCGG(float HBAPMMDKJDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A16BA0", Offset = "0x6A151A0", VA = "0x186A16BA0", Slot = "5")]
	[IteratorStateMachine(typeof(BECLHMKKDJB<>.IIFMCACNDIK))]
	public IEnumerable<T> HDAOFPOPHGD(float HBAPMMDKJDM, float? POLKEKMDIKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A16AB0", Offset = "0x6A150B0", VA = "0x186A16AB0", Slot = "7")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A16C50", Offset = "0x6A15250", VA = "0x186A16C50")]
	private void IJMFHIPFEPF(float HBAPMMDKJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A16DF0", Offset = "0x6A153F0", VA = "0x186A16DF0")]
	private OCFMMBINEFI LEILFGLACPI()
	{
		return default(OCFMMBINEFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LLMBEMAOGHJ<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct OKKOECOONGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly long KIKENMDNAPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public readonly long EKNAIIMCJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public readonly int GKJJAABCABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly int BLMAOALPDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly bool EGLNMGCHLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly string CJNCGPAKPCG;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5BBB300", Offset = "0x5BB9900", VA = "0x185BBB300")]
		public OKKOECOONGF(long KIKENMDNAPB, int GKJJAABCABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5BBB370", Offset = "0x5BB9970", VA = "0x185BBB370")]
		public OKKOECOONGF(long KIKENMDNAPB, long EKNAIIMCJKO, int GKJJAABCABJ, int BLMAOALPDFD, bool EGLNMGCHLNJ, string CJNCGPAKPCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5BBB190", Offset = "0x5BB9790", VA = "0x185BBB190")]
		public int BKLCBDNJACO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5BBB1E0", Offset = "0x5BB97E0", VA = "0x185BBB1E0")]
		public int EBFPEGACNPH(int PKNBBBKJGIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5BBB200", Offset = "0x5BB9800", VA = "0x185BBB200")]
		public double LFCEPKPFCNA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5BBB260", Offset = "0x5BB9860", VA = "0x185BBB260")]
		public OKKOECOONGF NJGAPLPAHPC(long EKNAIIMCJKO, int BLMAOALPDFD)
		{
			return default(OKKOECOONGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class LBCCFMIMELL : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private struct KGMFJEFAPBA<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public LBCCFMIMELL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public Func<LBCCFMIMELL, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private LBCCFMIMELL <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x55EA840", Offset = "0x55E8E40", VA = "0x1855EA840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x50F24C0", Offset = "0x50F0AC0", VA = "0x1850F24C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly TKey HPFJLGDHMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly LLMBEMAOGHJ<TKey> PGBOBMDDLFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly IPHNFELODMJ AMCHCCAPJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private List<LBCCFMIMELL> NIDFNELCGFH;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string FKJJGADMJBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x57B9C40", Offset = "0x57B8240", VA = "0x1857B9C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public IEnumerable<LBCCFMIMELL> OOBEGDFAKEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x57B9C00", Offset = "0x57B8200", VA = "0x1857B9C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public OKKOECOONGF AHJIADMJMKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x57B9BE0", Offset = "0x57B81E0", VA = "0x1857B9BE0")]
			[CompilerGenerated]
			get
			{
				return default(OKKOECOONGF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x57B9C70", Offset = "0x57B8270", VA = "0x1857B9C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x57B9CA0", Offset = "0x57B82A0", VA = "0x1857B9CA0")]
		internal LBCCFMIMELL(LLMBEMAOGHJ<TKey> PGBOBMDDLFM, TKey HAELBKGFDIJ, IPHNFELODMJ AMCHCCAPJNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x57B9880", Offset = "0x57B7E80", VA = "0x1857B9880")]
		public LBCCFMIMELL BHDPPBLHMBA(TKey HAELBKGFDIJ, [Optional] IPHNFELODMJ? LNJNJHKBBIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x453B310", Offset = "0x4539910", VA = "0x18453B310")]
		[AsyncStateMachine(typeof(KGMFJEFAPBA<>))]
		public Task<T> IAKBNIMEAOA<T>(TKey HAELBKGFDIJ, Func<LBCCFMIMELL, Task<T>> OFMFDPOLEGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x57B99E0", Offset = "0x57B7FE0", VA = "0x1857B99E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class EIGCDKGFHOJ : IEnumerable<(TKey, List<TKey>, OKKOECOONGF)>, IEnumerable, IEnumerator<(TKey, List<TKey>, OKKOECOONGF)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private (TKey key, List<TKey> path, OKKOECOONGF timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public LLMBEMAOGHJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<(TKey key, List<TKey> path, OKKOECOONGF timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private (TKey, List<TKey>, OKKOECOONGF) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2DF64C0", Offset = "0x2DF4AC0", VA = "0x182DF64C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, OKKOECOONGF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x4B53260", Offset = "0x4B51860", VA = "0x184B53260", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2DF65B0", Offset = "0x2DF4BB0", VA = "0x182DF65B0")]
		[DebuggerHidden]
		public EIGCDKGFHOJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x462E1E0", Offset = "0x462C7E0", VA = "0x18462E1E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4B52DB0", Offset = "0x4B513B0", VA = "0x184B52DB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4B52D60", Offset = "0x4B51360", VA = "0x184B52D60")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4B53210", Offset = "0x4B51810", VA = "0x184B53210", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4B53150", Offset = "0x4B51750", VA = "0x184B53150", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, OKKOECOONGF)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x468EB40", Offset = "0x468D140", VA = "0x18468EB40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class AFGGDLKDOLA : IEnumerable<(TKey, List<TKey>, OKKOECOONGF)>, IEnumerable, IEnumerator<(TKey, List<TKey>, OKKOECOONGF)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (TKey key, List<TKey> path, OKKOECOONGF timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private LBCCFMIMELL timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public LBCCFMIMELL <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public LLMBEMAOGHJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<LBCCFMIMELL> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private IEnumerator<(TKey key, List<TKey> path, OKKOECOONGF timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private (TKey, List<TKey>, OKKOECOONGF) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2DF64C0", Offset = "0x2DF4AC0", VA = "0x182DF64C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, OKKOECOONGF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x540BAD0", Offset = "0x540A0D0", VA = "0x18540BAD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF65B0", Offset = "0x2DF4BB0", VA = "0x182DF65B0")]
		[DebuggerHidden]
		public AFGGDLKDOLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x540BB30", Offset = "0x540A130", VA = "0x18540BB30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x540B1C0", Offset = "0x54097C0", VA = "0x18540B1C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x540B160", Offset = "0x5409760", VA = "0x18540B160")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x540B100", Offset = "0x5409700", VA = "0x18540B100")]
		private void FECGMFJNPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x540BA80", Offset = "0x540A080", VA = "0x18540BA80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x540B970", Offset = "0x5409F70", VA = "0x18540B970", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, OKKOECOONGF)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x540BA50", Offset = "0x540A050", VA = "0x18540BA50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly Action<TKey, OKKOECOONGF, IPHNFELODMJ> HIGOJOADANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Action<TKey, OKKOECOONGF, IPHNFELODMJ> NBEMDIANBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Action<LLMBEMAOGHJ<TKey>, IPHNFELODMJ> EJAEMCNPKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly LBCCFMIMELL OBGPOPFKJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private bool AHFHMNIBLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int JGKEBFCNGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Stopwatch FCNACKIIEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly int DNCHOFPHMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private string LOHDNAHMDCG;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public LBCCFMIMELL LOOFDDLDCIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	[NotNull]
	public string FKJJGADMJBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x57D2EA0", Offset = "0x57D14A0", VA = "0x1857D2EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x57D2F80", Offset = "0x57D1580", VA = "0x1857D2F80")]
	public LLMBEMAOGHJ(TKey OKIOJMFONJD, IPHNFELODMJ AMCHCCAPJNG, [Optional] int? GKJJAABCABJ, [Optional][CanBeNull] Stopwatch FCNACKIIEHD, [Optional] Action<TKey, OKKOECOONGF, IPHNFELODMJ> HIGOJOADANH, [Optional] Action<TKey, OKKOECOONGF, IPHNFELODMJ> NBEMDIANBNP, [Optional] Action<LLMBEMAOGHJ<TKey>, IPHNFELODMJ> EJAEMCNPKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x57D2CB0", Offset = "0x57D12B0", VA = "0x1857D2CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x57D2D40", Offset = "0x57D1340", VA = "0x1857D2D40")]
	[IteratorStateMachine(typeof(LLMBEMAOGHJ<>.EIGCDKGFHOJ))]
	public IEnumerable<(TKey, List<TKey>, OKKOECOONGF)> HCNNINBDEDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x57D2DD0", Offset = "0x57D13D0", VA = "0x1857D2DD0")]
	[IteratorStateMachine(typeof(LLMBEMAOGHJ<>.AFGGDLKDOLA))]
	private IEnumerable<(TKey, List<TKey>, OKKOECOONGF)> HCNNINBDEDE(List<TKey> BFHDBHOMJKM, LBCCFMIMELL KPLKOPIKPBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x57D2F00", Offset = "0x57D1500", VA = "0x1857D2F00")]
	private (long, int) MPKPCHKMFML()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class BKIDPPEKPPC<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut ENMJPKHIOPK(LLMBEMAOGHJ<TKey> PGBOBMDDLFM);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected BKIDPPEKPPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public abstract class PAPFMKNABCD<TKey> : BKIDPPEKPPC<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate string IHLGHJKHKOC(TKey HAELBKGFDIJ);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5CA71C0", Offset = "0x5CA57C0", VA = "0x185CA71C0")]
	private static string DFFIBBADOEC(TKey HAELBKGFDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7200", Offset = "0x5CA5800", VA = "0x185CA7200", Slot = "4")]
	public override string ENMJPKHIOPK(LLMBEMAOGHJ<TKey> PGBOBMDDLFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5CA72C0", Offset = "0x5CA58C0", VA = "0x185CA72C0")]
	public string ENMJPKHIOPK(LLMBEMAOGHJ<TKey> PGBOBMDDLFM, [NotNull] IHLGHJKHKOC LBDHLCOHBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string HKFOIIMACLJ(LLMBEMAOGHJ<TKey> PGBOBMDDLFM, [NotNull] IHLGHJKHKOC LBDHLCOHBMO);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x52AED10", Offset = "0x52AD310", VA = "0x1852AED10")]
	protected PAPFMKNABCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class CEEBBGILAJL<TKey> : BKIDPPEKPPC<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate string LCAGDJEBGOO(TKey HAELBKGFDIJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly string DHMLIHAHCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly double DLIHCHGLPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly bool HAPIKEICEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly int GPMDPKGJLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly ISet<string> MMIFEAFNMBP;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAE90", Offset = "0x6EA9490", VA = "0x186EAAE90")]
	private static string DFFIBBADOEC(TKey HAELBKGFDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB8A0", Offset = "0x6EA9EA0", VA = "0x186EAB8A0")]
	public CEEBBGILAJL(string DHMLIHAHCDH = "F2", double DLIHCHGLPCA = double.MaxValue, bool HAPIKEICEFN = false, int GPMDPKGJLGH = int.MaxValue, [Optional] ISet<string> MMIFEAFNMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAED0", Offset = "0x6EA94D0", VA = "0x186EAAED0", Slot = "4")]
	public override Dictionary<string, string> ENMJPKHIOPK(LLMBEMAOGHJ<TKey> PGBOBMDDLFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB7C0", Offset = "0x6EA9DC0", VA = "0x186EAB7C0")]
	private bool KPAENFLJDGE(string NHBCGIPCGKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAF90", Offset = "0x6EA9590", VA = "0x186EAAF90")]
	public Dictionary<string, string> ENMJPKHIOPK(LLMBEMAOGHJ<TKey> PGBOBMDDLFM, LCAGDJEBGOO LBDHLCOHBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB580", Offset = "0x6EA9B80", VA = "0x186EAB580")]
	private string IIHADJDDFGC(StringBuilder MEKLOKCMCKD, List<TKey> NPLNPFEBBDO, LCAGDJEBGOO LBDHLCOHBMO, bool JOIGJFMIEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAD30", Offset = "0x6EA9330", VA = "0x186EAAD30")]
	private static void CCLIEGIGFDG(StringBuilder CNLHGGLIALG, string MMKPLAJNJPP, bool HIEIHEKNMMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class AIKLBFHPCKC<TKey> : PAPFMKNABCD<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct NBIDHMDAPOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public IHLGHJKHKOC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public static AIKLBFHPCKC<TKey> EHBCEBDHHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly string[] MENJPKLLMPM;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x54C55A0", Offset = "0x54C3BA0", VA = "0x1854C55A0")]
	private AIKLBFHPCKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x54C4590", Offset = "0x54C2B90", VA = "0x1854C4590", Slot = "5")]
	protected override string HKFOIIMACLJ(LLMBEMAOGHJ<TKey> PGBOBMDDLFM, IHLGHJKHKOC LBDHLCOHBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x54C44A0", Offset = "0x54C2AA0", VA = "0x1854C44A0")]
	[CompilerGenerated]
	internal static string HJHMAGKACHI(string OENPKEBKFAG, TKey HAELBKGFDIJ, NBIDHMDAPOL P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class NJMBBKGCDCF : LLMBEMAOGHJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class GLAHIKIPACH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Action<NJMBBKGCDCF, IPHNFELODMJ> callback;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GLAHIKIPACH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x84BDE80", Offset = "0x84BC480", VA = "0x1884BDE80")]
		internal void GBEGEGHEEGC(LLMBEMAOGHJ<string> timer, IPHNFELODMJ log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x84BE780", Offset = "0x84BCD80", VA = "0x1884BE780")]
	public NJMBBKGCDCF(IPHNFELODMJ AMCHCCAPJNG, [Optional] string ECFLIIOCLIB, [Optional] int? GKJJAABCABJ, [Optional] Stopwatch FCNACKIIEHD, [Optional] Action<string, OKKOECOONGF, IPHNFELODMJ> HIGOJOADANH, [Optional] Action<string, OKKOECOONGF, IPHNFELODMJ> NBEMDIANBNP, [Optional] Action<NJMBBKGCDCF, IPHNFELODMJ> EJAEMCNPKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x84BE6C0", Offset = "0x84BCCC0", VA = "0x1884BE6C0")]
	private static Action<LLMBEMAOGHJ<string>, IPHNFELODMJ> HANBIKMKKKC(Action<NJMBBKGCDCF, IPHNFELODMJ> LAOAAOBGDLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class GOMJLOAIGMD
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private class HBFOCMEBLHM : GOMJLOAIGMD
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public static GOMJLOAIGMD EHBCEBDHHPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x84BE080", Offset = "0x84BC680", VA = "0x1884BE080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override float HCOENAFHAGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x13E4070", Offset = "0x13E2670", VA = "0x1813E4070", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x84BE180", Offset = "0x84BC780", VA = "0x1884BE180")]
		public HBFOCMEBLHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static GOMJLOAIGMD AMIALOMEPPB;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static GOMJLOAIGMD DKABDBMACEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x84BDF10", Offset = "0x84BC510", VA = "0x1884BDF10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public abstract float HCOENAFHAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected GOMJLOAIGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface LPJMHNKFBLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool JNKPFBIAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface OFBDOHFHPFI<T> : LPJMHNKFBLM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	[NotNull]
	Task<T> HBKGPJNMBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	EEOEHGFNDGC<T> IIAGELFBMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GDNJJGGGGPB
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3DD94E0", Offset = "0x3DD7AE0", VA = "0x183DD94E0")]
	public static OFBDOHFHPFI<TResource> ENFNHMEOHHF<TResource, TId>(this DCHHBFDIKBJ<TId, TResource> CFAIGLCJBOA, TId NMILEMOAODL, [Optional] Func<TId, CancellationToken, Task<TResource>>? ACOFPNPJDBB) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class AOJHHKAOMBE
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class LILLIOHBDLJ<T> : IMDOKLKPDBF<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override Task<T?> HBKGPJNMBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override EEOEHGFNDGC<T?> IIAGELFBMBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x57CA490", Offset = "0x57C8A90", VA = "0x1857CA490")]
		public LILLIOHBDLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "10")]
		protected override void CDECKPOFFAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class PEMBIOJECPB<T> : IMDOKLKPDBF<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly T OHEELJCBCIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly Action<T>? DJBJNJCFMFI;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override Task<T> HBKGPJNMBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override EEOEHGFNDGC<T> IIAGELFBMBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5CC96E0", Offset = "0x5CC7CE0", VA = "0x185CC96E0")]
		public PEMBIOJECPB(T DKKBNONALEH, Action<T>? JAIKONNCDEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9500", Offset = "0x5CC7B00", VA = "0x185CC9500", Slot = "10")]
		protected override void CDECKPOFFAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class LMPHFNLBPGB<T> : IMDOKLKPDBF<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override Task<T> HBKGPJNMBLG
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override EEOEHGFNDGC<T> IIAGELFBMBB
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x57D6930", Offset = "0x57D4F30", VA = "0x1857D6930")]
		public LMPHFNLBPGB(Exception MFJLILBLNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "10")]
		protected override void CDECKPOFFAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class IOHNEKEFIHB<T> : IMDOKLKPDBF<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct FHDFGCIPFKE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public Task<OFBDOHFHPFI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private TaskAwaiter<OFBDOHFHPFI<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x5011EC0", Offset = "0x50104C0", VA = "0x185011EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x50128C0", Offset = "0x5010EC0", VA = "0x1850128C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct GNJCBJBPDBO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public Task<OFBDOHFHPFI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<OFBDOHFHPFI<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x5102240", Offset = "0x5100840", VA = "0x185102240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5102700", Offset = "0x5100D00", VA = "0x185102700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly Task<OFBDOHFHPFI<T>> BNBCLNHNLOL;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override Task<T> HBKGPJNMBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override EEOEHGFNDGC<T> IIAGELFBMBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x52A7F80", Offset = "0x52A6580", VA = "0x1852A7F80")]
		public IOHNEKEFIHB(Task<OFBDOHFHPFI<T>> DIAHJIAKEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x52A7A50", Offset = "0x52A6050", VA = "0x1852A7A50", Slot = "10")]
		protected override void CDECKPOFFAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x52A7E20", Offset = "0x52A6420", VA = "0x1852A7E20")]
		[AsyncStateMachine(typeof(IOHNEKEFIHB<>.FHDFGCIPFKE))]
		[CompilerGenerated]
		internal static Task<T> LFDOENPOMJE(Task<OFBDOHFHPFI<T>> DIAHJIAKEPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x52A7AE0", Offset = "0x52A60E0", VA = "0x1852A7AE0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(IOHNEKEFIHB<>.GNJCBJBPDBO))]
		internal static Task DBGPMMEBMCN(Task<OFBDOHFHPFI<T>> DIAHJIAKEPB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class EPNNLJGJLND<TIn, TOut> : IMDOKLKPDBF<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct FFPEDOADGPN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x4FFA360", Offset = "0x4FF8960", VA = "0x184FFA360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4FFA6D0", Offset = "0x4FF8CD0", VA = "0x184FFA6D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly OFBDOHFHPFI<TIn> GBAJBEEMDBO;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override Task<TOut> HBKGPJNMBLG
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override EEOEHGFNDGC<TOut> IIAGELFBMBB
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4B74DF0", Offset = "0x4B733F0", VA = "0x184B74DF0")]
		public EPNNLJGJLND(OFBDOHFHPFI<TIn> CMMJFGOLGGK, Func<TIn, TOut> IICJJDEAGKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4B74AA0", Offset = "0x4B730A0", VA = "0x184B74AA0", Slot = "10")]
		protected override void CDECKPOFFAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4B74C70", Offset = "0x4B73270", VA = "0x184B74C70")]
		[AsyncStateMachine(typeof(EPNNLJGJLND<, >.FFPEDOADGPN))]
		[CompilerGenerated]
		internal static Task<TOut> EJEEJGOLPPO(Task<TIn> DODBAIIOMAC, Func<TIn, TOut> IICJJDEAGKK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3310B80", Offset = "0x330F180", VA = "0x183310B80")]
	public static OFBDOHFHPFI<T> HPOBBIFAPGN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3310BE0", Offset = "0x330F1E0", VA = "0x183310BE0")]
	public static OFBDOHFHPFI<T> IKFFNKICLED<T>(T FAKHJBCPGHO, [Optional] Action<T>? JAIKONNCDEB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3310B10", Offset = "0x330F110", VA = "0x183310B10")]
	public static OFBDOHFHPFI<T> FLLFICPNBGB<T>(Exception MFJLILBLNGK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3310B10", Offset = "0x330F110", VA = "0x183310B10")]
	public static OFBDOHFHPFI<T> HIGKGAFCEFK<T>(Task<OFBDOHFHPFI<T>> DIAHJIAKEPB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x330B660", Offset = "0x3309C60", VA = "0x18330B660")]
	public static OFBDOHFHPFI<TOut> JJKHGJPALLJ<TOut, TIn>(OFBDOHFHPFI<TIn> MNHLJANEAIO, Func<TIn, TOut> IICJJDEAGKK) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class IMDOKLKPDBF<T> : OFBDOHFHPFI<T>, LPJMHNKFBLM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly string DFOAFHEBKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly BIMENMEPEPN LMGCJPBBELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool AHFHMNIBLBI;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool JNKPFBIAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xB82BB0", Offset = "0xB811B0", VA = "0x180B82BB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract Task<T> HBKGPJNMBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract EEOEHGFNDGC<T> IIAGELFBMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x529F200", Offset = "0x529D800", VA = "0x18529F200")]
	public IMDOKLKPDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x529EEC0", Offset = "0x529D4C0", VA = "0x18529EEC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void CDECKPOFFAE();
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class FBGJMBJJPEA<TTask, T> : IMDOKLKPDBF<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class LLIMFNANIML
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public LLIMFNANIML <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x45B27A0", Offset = "0x45B0DA0", VA = "0x1845B27A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x45B2A70", Offset = "0x45B1070", VA = "0x1845B2A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public FBGJMBJJPEA<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LLIMFNANIML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x57D26F0", Offset = "0x57D0CF0", VA = "0x1857D26F0")]
		[AsyncStateMachine(typeof(FBGJMBJJPEA<, >.LLIMFNANIML.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> HMLENOCNHDO(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly Task<T> DIAHJIAKEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	protected readonly CancellationTokenSource JOPLMKCEELD;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public override Task<T> HBKGPJNMBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override EEOEHGFNDGC<T> IIAGELFBMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4FEB6D0", Offset = "0x4FE9CD0", VA = "0x184FEB6D0")]
	protected FBGJMBJJPEA(TTask DIAHJIAKEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4FEB4B0", Offset = "0x4FE9AB0", VA = "0x184FEB4B0", Slot = "10")]
	protected override void CDECKPOFFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T HBBFAMFHPNI(TTask FHOJKIEPBJI);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void ACDKHOBEFKK();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class EHNCHGNACOG<T> : IMDOKLKPDBF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly GCAHIIHOLJP<Task<T>> PJKOCAHBFGD;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override Task<T> HBKGPJNMBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4B47D20", Offset = "0x4B46320", VA = "0x184B47D20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override EEOEHGFNDGC<T> IIAGELFBMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4B47D60", Offset = "0x4B46360", VA = "0x184B47D60")]
	public EHNCHGNACOG(GCAHIIHOLJP<Task<T>> LPEIEKGCBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4B47D00", Offset = "0x4B46300", VA = "0x184B47D00", Slot = "10")]
	protected override void CDECKPOFFAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class CAMLCGMGCPB
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly HashAlgorithmName ABMFMMEIBPO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly ThreadLocal<IncrementalHash> MCIFAKOPBKN;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x84BC690", Offset = "0x84BAC90", VA = "0x1884BC690")]
	public static int JLNKGAOLILO(this MBAIGEMKLDH OOPAEOMAKFD, IncrementalHash MBMNKPPCEJE, byte[] MKJMNACEAHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x84BC290", Offset = "0x84BA890", VA = "0x1884BC290")]
	public static bool BJJECIFMHOO([CanBeNull] this MBAIGEMKLDH OOPAEOMAKFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x84BC2F0", Offset = "0x84BA8F0", VA = "0x1884BC2F0")]
	public static bool BJJECIFMHOO([CanBeNull] this MBAIGEMKLDH OOPAEOMAKFD, [Out] string DAANGKEHOHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x84BBF50", Offset = "0x84BA550", VA = "0x1884BBF50")]
	public static bool BJJECIFMHOO([CanBeNull] this MBAIGEMKLDH OOPAEOMAKFD, IncrementalHash MBMNKPPCEJE, byte[] MKJMNACEAHB, [Out] string DAANGKEHOHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x84BC600", Offset = "0x84BAC00", VA = "0x1884BC600")]
	private static bool HACOFNFMFPJ(byte[] DIFECCIPOHN, Span<byte> HNIOEABHBDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class FGAANCLGMNO
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x84BCAD0", Offset = "0x84BB0D0", VA = "0x1884BCAD0")]
	public static int EIABODFBDNF(HashAlgorithmName APKNEGHFBCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBFA0", Offset = "0x3DBA5A0", VA = "0x183DBBFA0")]
	public static int JLNKGAOLILO<T>(this T AFPHEBKHILO, byte[] OBOMGBJMBOA, IncrementalHash MBMNKPPCEJE, byte[] MCDJJDPOJAL) where T : BNCJPENGCAJ
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface BNCJPENGCAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash MBMNKPPCEJE);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface MBAIGEMKLDH : BNCJPENGCAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	[CanBeNull]
	byte[] NHEKAHAMPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] FHCJFNNFJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class FGAHPIAIKBA
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static bool LMPDFAMHKEF;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly ArrayPool<byte> EHEMJLHEIPA;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly ArrayPool<char> NFCBJFCOIOE;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly Encoding HDFDBFIOCII;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly ThreadLocal<Encoder> CFJJAMIIBJI;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3DBCEF0", Offset = "0x3DBB4F0", VA = "0x183DBCEF0")]
	public static void IHOMLPBNBDJ<T>(this IncrementalHash BEGDHAFOKJM, [CanBeNull] T IDFKPPKNONO) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3DBCE60", Offset = "0x3DBB460", VA = "0x183DBCE60")]
	public static void GCLPJACGDNF<T>(this IncrementalHash BEGDHAFOKJM, [CanBeNull] T AFPHEBKHILO) where T : BNCJPENGCAJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3DBCFB0", Offset = "0x3DBB5B0", VA = "0x183DBCFB0")]
	public static void OGPKOKNMBND<T>(this IncrementalHash BEGDHAFOKJM, [CanBeNull] IList<T> JGOFHHMMDFC) where T : BNCJPENGCAJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x84BD320", Offset = "0x84BB920", VA = "0x1884BD320")]
	private static bool HCODIGOEAIN([CanBeNull] BNCJPENGCAJ AFPHEBKHILO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x84BD750", Offset = "0x84BBD50", VA = "0x1884BD750")]
	public static void OIEMLJMPBIA(this IncrementalHash MBMNKPPCEJE, string? HGADPEBPIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x84BCDF0", Offset = "0x84BB3F0", VA = "0x1884BCDF0")]
	public static void AOKOMDHADMO(this IncrementalHash MBMNKPPCEJE, long JABOKABGHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x84BCC20", Offset = "0x84BB220", VA = "0x1884BCC20")]
	public static void AMLGOALLALP(this IncrementalHash MBMNKPPCEJE, int JDJEJNLJGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x84BD150", Offset = "0x84BB750", VA = "0x1884BD150")]
	public static void HCEIODIBELB(this IncrementalHash MBMNKPPCEJE, short PDOMABGIIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x84BD640", Offset = "0x84BBC40", VA = "0x1884BD640")]
	public static void NLEJMCCJCDN(this IncrementalHash MBMNKPPCEJE, byte DBNAIDOODAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x84BD4D0", Offset = "0x84BBAD0", VA = "0x1884BD4D0")]
	public static void NEEECFDLBHC(this IncrementalHash MBMNKPPCEJE, bool OAGDNPHHPLG, bool DMGGJBJCJML = false, bool BKEGDHJFLDE = false, bool FCIHONDOIII = false, bool MJDEAHCIBKP = false, bool CAIMCPFJEEH = false, bool OLMDADJKEEE = false, bool OKHKMKDNFEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3DBC200", Offset = "0x3DBA800", VA = "0x183DBC200")]
	public static void CDPEIJJEOEG<T>(this IncrementalHash MBMNKPPCEJE, T KCKCBGONOJI) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x84BCFC0", Offset = "0x84BB5C0", VA = "0x1884BCFC0")]
	public static void DMIJELGFEGJ(this IncrementalHash MBMNKPPCEJE, float IINHICHIBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x84BD3B0", Offset = "0x84BB9B0", VA = "0x1884BD3B0")]
	public static void IEDEFCALPOP(this IncrementalHash MBMNKPPCEJE, ulong BFMKIGOEBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x84BD410", Offset = "0x84BBA10", VA = "0x1884BD410")]
	public static void IFFBIAPLNNO(this IncrementalHash MBMNKPPCEJE, uint FLJCBBIGCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x84BD470", Offset = "0x84BBA70", VA = "0x1884BD470")]
	public static void LOADCAPBKFP(this IncrementalHash MBMNKPPCEJE, ushort ADKNIAKKOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x84BD020", Offset = "0x84BB620", VA = "0x1884BD020")]
	public static void ECPCIGGGLOF(this IncrementalHash MBMNKPPCEJE, Vector3 HLJBCKEOABC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class HNOGPKCBJEM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x84BE290", Offset = "0x84BC890", VA = "0x1884BE290")]
	public HNOGPKCBJEM(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public abstract class JBJOCNPIONI
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void JIIOCIJJGPF(ushort MBNFNOGFMAA, ushort GMFOLKLCAEK, ushort FNLBHLHIMAG, ushort MHGDEJAECNO);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public delegate void CEBABAFLPEA(ushort FPEHMGMOKPP, ushort NOFCHMBBGJO);

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate void EOEMDNDDEOB();

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const ushort KOFAAMFEEGO = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected JBJOCNPIONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class BAKOEENNOIN<T> : JBJOCNPIONI where T : BAKOEENNOIN<T>.GAKCPNFDOJI
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public interface GAKCPNFDOJI
	{
		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		CEBABAFLPEA HJPEAEPPJEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		CEBABAFLPEA ICPPAKGPNIB
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		EOEMDNDDEOB IAHAPLOAKPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<uint, T> DFLDBPLIIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private EOEMDNDDEOB HBDNEBBEEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private EOEMDNDDEOB CAGEBKPFMEN;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool DODGNMFNHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xB268D0", Offset = "0xB24ED0", VA = "0x180B268D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xAB4E30", Offset = "0xAB3430", VA = "0x180AB4E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public ushort GBFFOCNOBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x129E3D0", Offset = "0x129C9D0", VA = "0x18129E3D0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x129E510", Offset = "0x129CB10", VA = "0x18129E510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort BKPFBMLKFII
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A04410", Offset = "0x6A02A10", VA = "0x186A04410")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6A043D0", Offset = "0x6A029D0", VA = "0x186A043D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort PIBEGOFKDID
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xF85D00", Offset = "0xF84300", VA = "0x180F85D00")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xF85DC0", Offset = "0xF843C0", VA = "0x180F85DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort FBOMIIONLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A037E0", Offset = "0x6A01DE0", VA = "0x186A037E0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A043F0", Offset = "0x6A029F0", VA = "0x186A043F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	protected bool KPAOHNJPNJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x129E8A0", Offset = "0x129CEA0", VA = "0x18129E8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool LAMDILHJOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x234D280", Offset = "0x234B880", VA = "0x18234D280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event JIIOCIJJGPF AIDMOHHILGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A037F0", Offset = "0x6A01DF0", VA = "0x186A037F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A03560", Offset = "0x6A01B60", VA = "0x186A03560")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A03890", Offset = "0x6A01E90", VA = "0x186A03890")]
	private T JHOOFCCKIPO(ushort NFGHMGDLGMN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A040A0", Offset = "0x6A026A0", VA = "0x186A040A0")]
	private T LMJLOPDACFE(ushort NFGHMGDLGMN, ushort FLEOIFIHKNM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A04380", Offset = "0x6A02980", VA = "0x186A04380")]
	protected T MPIIOKPMMBD(uint EJADLEKJOEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A04430", Offset = "0x6A02A30", VA = "0x186A04430")]
	protected BAKOEENNOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A036A0", Offset = "0x6A01CA0", VA = "0x186A036A0")]
	public void GLEPALPMNGF(ushort NIHDBEPFMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A03790", Offset = "0x6A01D90", VA = "0x186A03790")]
	public void GLEPALPMNGF(ushort NIHDBEPFMDL, ushort OOFCBALLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A036C0", Offset = "0x6A01CC0", VA = "0x186A036C0", Slot = "4")]
	protected virtual void GLEPALPMNGF(uint KIBNELKPKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A03920", Offset = "0x6A01F20", VA = "0x186A03920")]
	protected void JNJOMLBFDGO(uint KIBNELKPKBA, uint DBBNPCBIOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A03630", Offset = "0x6A01C30", VA = "0x186A03630")]
	protected void GAGPNPHBLAN(ushort NFGHMGDLGMN, ushort FLEOIFIHKNM, T HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A03600", Offset = "0x6A01C00", VA = "0x186A03600")]
	private void DNCGNHJHNEG(uint EJADLEKJOEL, T HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A04130", Offset = "0x6A02730", VA = "0x186A04130")]
	protected void LOCBIJCECEJ(float KJDBPOBDAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A04400", Offset = "0x6A02A00", VA = "0x186A04400")]
	protected uint OGCEIBPJLKD(ushort NFGHMGDLGMN, ushort FLEOIFIHKNM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A04420", Offset = "0x6A02A20", VA = "0x186A04420")]
	protected ushort PPPENNOPJBL(uint LIBLEAKGDEM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A043E0", Offset = "0x6A029E0", VA = "0x186A043E0")]
	protected ushort NNBCCNIMELJ(uint LIBLEAKGDEM)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public abstract class PGKANOHFFNH : BAKOEENNOIN<PGKANOHFFNH.IMIOGFDPJIO>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class IMIOGFDPJIO : GAKCPNFDOJI
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public CEBABAFLPEA HJPEAEPPJEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public CEBABAFLPEA ICPPAKGPNIB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public EOEMDNDDEOB IAHAPLOAKPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public IMIOGFDPJIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x84BEB00", Offset = "0x84BD100", VA = "0x1884BEB00")]
	public void KKAHNNMEBDG(ushort DBJANFHDBDH, CEBABAFLPEA HKPJKGPOOOL, CEBABAFLPEA JDJPJFPEGLH, EOEMDNDDEOB JMNPGKDDAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x84BEA20", Offset = "0x84BD020", VA = "0x1884BEA20")]
	public void KKAHNNMEBDG(ushort NFGHMGDLGMN, ushort FLEOIFIHKNM, CEBABAFLPEA HKPJKGPOOOL, CEBABAFLPEA JDJPJFPEGLH, EOEMDNDDEOB JMNPGKDDAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x84BE9D0", Offset = "0x84BCFD0", VA = "0x1884BE9D0")]
	public void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x84BBF10", Offset = "0x84BA510", VA = "0x1884BBF10")]
	protected PGKANOHFFNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class AIMIDGCLOIF : PGKANOHFFNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool AFOOKDMEFGC;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool NMKMFLCMAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xDB20D0", Offset = "0xDB06D0", VA = "0x180DB20D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xE9F2B0", Offset = "0xE9D8B0", VA = "0x180E9F2B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x84BBE50", Offset = "0x84BA450", VA = "0x1884BBE50")]
	public void BDBKJLHAGCA(ushort HLEJALCOCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x84BBEB0", Offset = "0x84BA4B0", VA = "0x1884BBEB0")]
	public void BDBKJLHAGCA(ushort HLEJALCOCEL, ushort GBOFNCGKAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x84BBF10", Offset = "0x84BA510", VA = "0x1884BBF10")]
	public AIMIDGCLOIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public abstract class IDIPDFIKANH<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal class MKHBBPCNOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public TNode JNMMMBJNOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public TNode BEBONNCPGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public IKBJIBGAHJA PCLFJGMAHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public List<IKBJIBGAHJA> KFONOLLAAEC;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MKHBBPCNOGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal struct IKBJIBGAHJA : IComparable<IKBJIBGAHJA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int EOENKBEJCMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public TClaimant HGEPMFAINOH;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x1998FA0", Offset = "0x19975A0", VA = "0x181998FA0")]
		public IKBJIBGAHJA(int EOENKBEJCMN, TClaimant HGEPMFAINOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x529B880", Offset = "0x5299E80", VA = "0x18529B880")]
		public bool IKJAPMOJBHL([In] IKBJIBGAHJA AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x529B860", Offset = "0x5299E60", VA = "0x18529B860")]
		public bool CMMIFJENHJJ([In] IKBJIBGAHJA AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x529B870", Offset = "0x5299E70", VA = "0x18529B870", Slot = "4")]
		public int CompareTo(IKBJIBGAHJA AAGCKLPFJME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x529B8E0", Offset = "0x5299EE0", VA = "0x18529B8E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public enum OEBFAJBPOKF
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class MALOFEHCIHM : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public IDIPDFIKANH<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
		[DebuggerHidden]
		public MALOFEHCIHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x59F0A00", Offset = "0x59EF000", VA = "0x1859F0A00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x59F0BC0", Offset = "0x59EF1C0", VA = "0x1859F0BC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x59F0AE0", Offset = "0x59EF0E0", VA = "0x1859F0AE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5075420", Offset = "0x5073A20", VA = "0x185075420", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly GJIKIJCNGAN<MKHBBPCNOGG> FJMINCONFGK;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly GJIKIJCNGAN<List<IKBJIBGAHJA>> LAFJJHDFCOB;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static int BCEJCBDEINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	internal readonly Dictionary<TClaimant, TNode> HMAOACMNKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	internal readonly Dictionary<TNode, MKHBBPCNOGG> NFOAKALIDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private OEBFAJBPOKF IBLGEJEKAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool AJNGKKLNKMJ;

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode AFGPLCNMJDO(TNode EMOGDLPNEGA);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void KJNGEGBALDO(TNode EMOGDLPNEGA, TClaimant LGHFAMCJLIA, TClaimant HKAAHJDINLD);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x525D0D0", Offset = "0x525B6D0", VA = "0x18525D0D0")]
	public IDIPDFIKANH(OEBFAJBPOKF IBLGEJEKAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x525CE80", Offset = "0x525B480", VA = "0x18525CE80")]
	public void OCDGEALAPIC(TNode EMOGDLPNEGA, TNode JBFCMKMBEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x525CC80", Offset = "0x525B280", VA = "0x18525CC80")]
	public void MHMLKDHBKHK(TClaimant HGEPMFAINOH, TNode FFPFKLLEBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x525BA30", Offset = "0x525A030", VA = "0x18525BA30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x525C330", Offset = "0x525A930", VA = "0x18525C330")]
	private void IFOGPKDMDIL(TClaimant HGEPMFAINOH, TNode OKPMGGGCFIG, TNode FFPFKLLEBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x525C670", Offset = "0x525AC70", VA = "0x18525C670")]
	private int KIIKBJHCHJJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x525C7D0", Offset = "0x525ADD0", VA = "0x18525C7D0")]
	private void LLPNFKINLFJ(TClaimant HGEPMFAINOH, TNode GCONFEIBHNM, TNode DOEFIPICAFB, int ACMCJHIPPDK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x525B890", Offset = "0x5259E90", VA = "0x18525B890")]
	private void ABMLKBPMMPI(IKBJIBGAHJA LLMKJADDFHO, MKHBBPCNOGG PFIDGGFALEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x525BCF0", Offset = "0x525A2F0", VA = "0x18525BCF0")]
	private void ICKCNIFDPIO(TClaimant HGEPMFAINOH, TNode GCONFEIBHNM, TNode DOEFIPICAFB, int ACMCJHIPPDK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x525B920", Offset = "0x5259F20", VA = "0x18525B920")]
	private void BNGMFOIOJHD(IKBJIBGAHJA LLMKJADDFHO, TNode EMOGDLPNEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x525C6E0", Offset = "0x525ACE0", VA = "0x18525C6E0")]
	private void LFIDNLEKKHO(IKBJIBGAHJA LLMKJADDFHO, MKHBBPCNOGG PFIDGGFALEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x525C3D0", Offset = "0x525A9D0", VA = "0x18525C3D0")]
	private void IPLFBHHKPHC(MKHBBPCNOGG PFIDGGFALEN, bool LCOGJOMAEEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x525BFD0", Offset = "0x525A5D0", VA = "0x18525BFD0")]
	private void IDCECMFMFLH(MKHBBPCNOGG PFIDGGFALEN, TNode JBFCMKMBEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x525CDA0", Offset = "0x525B3A0", VA = "0x18525CDA0")]
	[IteratorStateMachine(typeof(IDIPDFIKANH<, >.MALOFEHCIHM))]
	private IEnumerable<TNode> NLBKIHJLBJD(TNode GCONFEIBHNM, TNode DOEFIPICAFB, bool DIJECHFIOLP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x525BC00", Offset = "0x525A200", VA = "0x18525BC00")]
	private MKHBBPCNOGG HJPNBKONBPJ(TNode EMOGDLPNEGA, TNode BEBONNCPGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x525CB10", Offset = "0x525B110", VA = "0x18525CB10")]
	private MKHBBPCNOGG MDLFFMCMIGI(TNode EMOGDLPNEGA, TNode BEBONNCPGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x525C500", Offset = "0x525AB00", VA = "0x18525C500")]
	private void JFHBPBPNAKF(MKHBBPCNOGG PFIDGGFALEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class KCPAFICBKNF<T> : IEnumerable<KCPAFICBKNF<T>.KGFKEHDGCAL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct KGFKEHDGCAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T KOPHBHGIACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int PMIGBJGNLLP;
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class IIPEGFLFKMF : IEnumerator<KGFKEHDGCAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private KCPAFICBKNF<T> PLDHKFPNKBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int PMIGBJGNLLP;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x4B79840", Offset = "0x4B77E40", VA = "0x184B79840", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public KGFKEHDGCAL MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x528E9B0", Offset = "0x528CFB0", VA = "0x18528E9B0", Slot = "4")]
			get
			{
				return default(KGFKEHDGCAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x528E970", Offset = "0x528CF70", VA = "0x18528E970")]
		public IIPEGFLFKMF(KCPAFICBKNF<T> PLDHKFPNKBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x528E870", Offset = "0x528CE70", VA = "0x18528E870", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x4BEBDA0", Offset = "0x4BEA3A0", VA = "0x184BEBDA0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x135CED0", Offset = "0x135B4D0", VA = "0x18135CED0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private struct FIPNMBMFCAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public bool PFFMBBJBOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public T KOPHBHGIACG;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private const int JBJBDCMKBGO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly Dictionary<T, int> CFKOINEOGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private FIPNMBMFCAN[] NJOHILHNIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int FGNINCGLPMC;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int AGGHDJEFDGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xC582A0", Offset = "0xC568A0", VA = "0x180C582A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x10B1C80", Offset = "0x10B0280", VA = "0x1810B1C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x45C9C40", Offset = "0x45C8240", VA = "0x1845C9C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x55E2E10", Offset = "0x55E1410", VA = "0x1855E2E10")]
	public KCPAFICBKNF(int AHIAOIDMGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x55E2EF0", Offset = "0x55E14F0", VA = "0x1855E2EF0")]
	public KCPAFICBKNF(KGFKEHDGCAL[] JOMDDCFFGNJ, bool LFBOIDLDLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x55E22B0", Offset = "0x55E08B0", VA = "0x1855E22B0")]
	public int KGOBFPFGEBM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x55E1D80", Offset = "0x55E0380", VA = "0x1855E1D80")]
	private int IAHMACOBIII()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x55E2280", Offset = "0x55E0880", VA = "0x1855E2280", Slot = "6")]
	protected virtual uint KEBFALEPGBB(uint MBMNKPPCEJE, T KOPHBHGIACG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x55E2340", Offset = "0x55E0940", VA = "0x1855E2340")]
	public bool LPDOPEOMNNF(T KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x55E2950", Offset = "0x55E0F50", VA = "0x1855E2950")]
	public int PPHEAHPKLIP(T KOPHBHGIACG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x55E21E0", Offset = "0x55E07E0", VA = "0x1855E21E0")]
	public T JCJJAHBLGNJ(int PMIGBJGNLLP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x55E2850", Offset = "0x55E0E50", VA = "0x1855E2850")]
	public bool OCEMEEOJBFJ(T KOPHBHGIACG, bool HPLEBEAGDEF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x55E2640", Offset = "0x55E0C40", VA = "0x1855E2640")]
	public bool OCEMEEOJBFJ(T KOPHBHGIACG, int PMIGBJGNLLP, bool HPLEBEAGDEF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x55E1D30", Offset = "0x55E0330", VA = "0x1855E1D30")]
	private int GPFMPGJJJPA(int NDMFOILAFKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x55E29C0", Offset = "0x55E0FC0", VA = "0x1855E29C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x55E29C0", Offset = "0x55E0FC0", VA = "0x1855E29C0", Slot = "4")]
	private IEnumerator<KGFKEHDGCAL> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class GJIKIJCNGAN<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly Stack<T> BHPJDAFOMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly List<T> AMJCHPMBPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly int GFGHLMJIEJH;

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x50F8670", Offset = "0x50F6C70", VA = "0x1850F8670")]
	public static GJIKIJCNGAN<T> FLGONNACOEN(int AHIAOIDMGDN = 0, int GFGHLMJIEJH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x50F8B10", Offset = "0x50F7110", VA = "0x1850F8B10")]
	public GJIKIJCNGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x50F8B40", Offset = "0x50F7140", VA = "0x1850F8B40")]
	public GJIKIJCNGAN(int AHIAOIDMGDN, int GFGHLMJIEJH = int.MaxValue, bool NEHBOEBFCFF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x50F8970", Offset = "0x50F6F70", VA = "0x1850F8970")]
	public T NPAODEBCNPN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x50F8360", Offset = "0x50F6960", VA = "0x1850F8360")]
	public void AMPHLDINMDF(T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x50F8440", Offset = "0x50F6A40", VA = "0x1850F8440")]
	private void CHLPLJGJHDG(T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x50F8950", Offset = "0x50F6F50", VA = "0x1850F8950")]
	private void JFPCDJFDILA(T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x50F8520", Offset = "0x50F6B20", VA = "0x1850F8520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x50F8750", Offset = "0x50F6D50", VA = "0x1850F8750")]
	private void HDLKJKCOBDE(IEnumerable<T> LGMBOCEBOMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class BJLLBPKIDBJ<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private Dictionary<int, T> LLNAAJAADDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private T BCGCPFFPHME;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public virtual T BNLADJKDIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8480", Offset = "0x6AF6A80", VA = "0x186AF8480")]
	public bool KIHHIABHMFG(T KOPHBHGIACG, int EOENKBEJCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4FFCBC0", Offset = "0x4FFB1C0", VA = "0x184FFCBC0")]
	public bool DNAKNINADLD(int EOENKBEJCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8280", Offset = "0x6AF6880", VA = "0x186AF8280")]
	public T DHJOEDDKEOI(int EIFDPLMMGEF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7EE0", Offset = "0x6AF64E0", VA = "0x186AF7EE0")]
	private bool BDHCAOCAAMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8020", Offset = "0x6AF6620", VA = "0x186AF8020")]
	public bool DCJACLLMOIN(int EOENKBEJCMN, [Out] T KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD4B0", Offset = "0x4FFBAB0", VA = "0x184FFD4B0")]
	public BJLLBPKIDBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class NJONLOEALLH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	protected struct CPANEOIDFBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public T CECIKJNPCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int KEBNPPLDLHH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	protected readonly List<CPANEOIDFBG> GFNBOLMANDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private T GHOBKIEABHD;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x45C9C40", Offset = "0x45C8240", VA = "0x1845C9C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5A89630", Offset = "0x5A87C30", VA = "0x185A89630")]
	public bool AOFBHNFGAFG(T KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5A8A1B0", Offset = "0x5A887B0", VA = "0x185A8A1B0")]
	public void MEFAAGOGBHI(T KOPHBHGIACG, int EOENKBEJCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5A89B60", Offset = "0x5A88160", VA = "0x185A89B60")]
	public bool CBELOMAGFLH(T KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5A89E40", Offset = "0x5A88440", VA = "0x185A89E40")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5A89D20", Offset = "0x5A88320", VA = "0x185A89D20")]
	public T EBENGCKKLDM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5A89EA0", Offset = "0x5A884A0", VA = "0x185A89EA0")]
	protected void LIOGLNIMODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5A8A2D0", Offset = "0x5A888D0", VA = "0x185A8A2D0")]
	public NJONLOEALLH()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x84BEDF0", Offset = "0x84BD3F0", VA = "0x1884BEDF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x84BF0C0", Offset = "0x84BD6C0", VA = "0x1884BF0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x84BEFD0", Offset = "0x84BD5D0", VA = "0x1884BEFD0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x84BED40", Offset = "0x84BD340", VA = "0x1884BED40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x84BF010", Offset = "0x84BD610", VA = "0x1884BF010")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x84BEF20", Offset = "0x84BD520", VA = "0x1884BEF20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x84BECB0", Offset = "0x84BD2B0", VA = "0x1884BECB0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCFB0", Offset = "0x5EDB5B0", VA = "0x185EDCFB0", Slot = "4")]
		public virtual T LKPAPHGILMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface DMAJKPCIKCL
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	ToolHierarchyCache PLMPHGEALKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public struct HFGEFPCNKOE<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private readonly List<Component> BBBJHCKNPGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly bool CAGLIHNAINL;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1B0CD90", Offset = "0x1B0B390", VA = "0x181B0CD90")]
			public HFGEFPCNKOE(List<Component> BBBJHCKNPGO, bool CAGLIHNAINL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x51604E0", Offset = "0x515EAE0", VA = "0x1851604E0")]
			public IGNBLFMNABJ<T> ABGODHCJODA()
			{
				return default(IGNBLFMNABJ<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x5160550", Offset = "0x515EB50", VA = "0x185160550", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x5160550", Offset = "0x515EB50", VA = "0x185160550", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public struct IGNBLFMNABJ<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly List<Component> BBBJHCKNPGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly bool CAGLIHNAINL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private int PMIGBJGNLLP;

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public T MIECLPJBKEF
			{
				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x52835C0", Offset = "0x5281BC0", VA = "0x1852835C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x5283550", Offset = "0x5281B50", VA = "0x185283550", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x5283590", Offset = "0x5281B90", VA = "0x185283590")]
			public IGNBLFMNABJ(List<Component> BBBJHCKNPGO, bool CAGLIHNAINL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x5283490", Offset = "0x5281A90", VA = "0x185283490", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x52834A0", Offset = "0x5281AA0", VA = "0x1852834A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x4BCD480", Offset = "0x4BCBA80", VA = "0x184BCD480", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x84C0B20", Offset = "0x84BF120", VA = "0x1884C0B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x84C0400", Offset = "0x84BEA00", VA = "0x1884C0400")]
		private void BDBKJLHAGCA(GameObject BHDNOHGBIBI, bool AKKFOJDOENB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x84C0570", Offset = "0x84BEB70", VA = "0x1884C0570")]
		public static void BDBKJLHAGCA(GameObject BHDNOHGBIBI, ToolHierarchyCache CFAIGLCJBOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x84C0A80", Offset = "0x84BF080", VA = "0x1884C0A80")]
		public void JKKIBKHAPAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x4152D40", Offset = "0x4151340", VA = "0x184152D40")]
		public void OICOKOAIPNF<T>(Action<T> PMBBLAOPHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4152CD0", Offset = "0x41512D0", VA = "0x184152CD0")]
		public T GPOGFAOFLNI<T>(bool CAGLIHNAINL = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4152C10", Offset = "0x4151210", VA = "0x184152C10")]
		public HFGEFPCNKOE<T> CMPAIFKCDDG<T>(bool CAGLIHNAINL = false) where T : class
		{
			return default(HFGEFPCNKOE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x84C06F0", Offset = "0x84BECF0", VA = "0x1884C06F0")]
		public List<Component> IFOEGEDALHI(Type GPEIAHGICNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x84C0600", Offset = "0x84BEC00", VA = "0x1884C0600", Slot = "4")]
		public bool Equals(ToolHierarchyCache GBNAKFLHCOE, ToolHierarchyCache ODEKEFJCIIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x84C0680", Offset = "0x84BEC80", VA = "0x1884C0680", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache MPIDDJPOOMJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class GHHGBEKJMKM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int AHIAOIDMGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int MAJOACCCIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private List<T> FLDLNFIMHJE;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x4B47D20", Offset = "0x4B46320", VA = "0x184B47D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public T ELAEOJCGHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x50F4850", Offset = "0x50F2E50", VA = "0x1850F4850")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T IGFBBBEHFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x50F4AF0", Offset = "0x50F30F0", VA = "0x1850F4AF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T KONHPLPNBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x50F4A60", Offset = "0x50F3060", VA = "0x1850F4A60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x50F4EB0", Offset = "0x50F34B0", VA = "0x1850F4EB0")]
	public GHHGBEKJMKM(int AHIAOIDMGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x50F4CD0", Offset = "0x50F32D0", VA = "0x1850F4CD0")]
	public void MEFAAGOGBHI(T AGLJGNHNENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x50F4930", Offset = "0x50F2F30", VA = "0x1850F4930")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x50F4DE0", Offset = "0x50F33E0", VA = "0x1850F4DE0")]
	public void MGHHDMPHOCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x50F4740", Offset = "0x50F2D40", VA = "0x1850F4740")]
	public void DCCKBIKGFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x50F49F0", Offset = "0x50F2FF0", VA = "0x1850F49F0")]
	public void IADLCFEPBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x50F4970", Offset = "0x50F2F70", VA = "0x1850F4970")]
	public List<T> HGLMMFFMGNF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class JKOPAHCCABD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private struct HPMLJHBJPJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int KEBNPPLDLHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public T CECIKJNPCJO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly Dictionary<object, HPMLJHBJPJL> LLNAAJAADDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly EqualityComparer<T> LMGMKJNOHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T BCGCPFFPHME;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public virtual T BNLADJKDIDO
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xEC0AD0", Offset = "0xEBF0D0", VA = "0x180EC0AD0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x54ECEC0", Offset = "0x54EB4C0", VA = "0x1854ECEC0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public bool OOFNGFGCBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x54ED380", Offset = "0x54EB980", VA = "0x1854ED380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public object IBJCPJBECLL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x54ED0B0", Offset = "0x54EB6B0", VA = "0x1854ED0B0")]
	public bool KIHHIABHMFG(T KOPHBHGIACG, object INEEADCBMPK, int EOENKBEJCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x54ECDF0", Offset = "0x54EB3F0", VA = "0x1854ECDF0")]
	public bool DNAKNINADLD(object INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x54ECA70", Offset = "0x54EB070", VA = "0x1854ECA70")]
	public bool DCJACLLMOIN(object INEEADCBMPK, [Out] T KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x54ECE80", Offset = "0x54EB480", VA = "0x1854ECE80")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x54EBE20", Offset = "0x54EA420", VA = "0x1854EBE20")]
	private bool BDHCAOCAAMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x54ED3D0", Offset = "0x54EB9D0", VA = "0x1854ED3D0")]
	public JKOPAHCCABD()
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
