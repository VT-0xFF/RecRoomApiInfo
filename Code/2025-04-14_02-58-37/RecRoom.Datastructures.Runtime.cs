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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D2910", Offset = "0x78D1310", VA = "0x1878D2910")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GOGNGLDBHMN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1F816B0", Offset = "0x1F800B0", VA = "0x181F816B0")]
	public GOGNGLDBHMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, BOEHEEKCPHB, HGFLIKCPNJO, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9B0460", Offset = "0x9AEE60", VA = "0x1809B0460", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash ALFFJDGFOGF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xB404F0", Offset = "0xB3EEF0", VA = "0x180B404F0")]
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
	[SerializeField]
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x78D3CE0", Offset = "0x78D26E0", VA = "0x1878D3CE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78D3CA0", Offset = "0x78D26A0", VA = "0x1878D3CA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78D3D20", Offset = "0x78D2720", VA = "0x1878D3D20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x78D3ED0", Offset = "0x78D28D0", VA = "0x1878D3ED0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x78D3E40", Offset = "0x78D2840", VA = "0x1878D3E40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE5FD30", Offset = "0xE5E730", VA = "0x180E5FD30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCB3DA0", Offset = "0xCB27A0", VA = "0x180CB3DA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x78D3C60", Offset = "0x78D2660", VA = "0x1878D3C60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x78D3DB0", Offset = "0x78D27B0", VA = "0x1878D3DB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x78D3700", Offset = "0x78D2100", VA = "0x1878D3700")]
	public void CopyBounds(SavedExtents OLKLGHOAKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x78D3BB0", Offset = "0x78D25B0", VA = "0x1878D3BB0")]
	public void SetLocalSpaceBounds(Bounds DHNDDMGHDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x134D4B0", Offset = "0x134BEB0", VA = "0x18134D4B0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x78D3BA0", Offset = "0x78D25A0", VA = "0x1878D3BA0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x78D37F0", Offset = "0x78D21F0", VA = "0x1878D37F0")]
	private void MCANEFMEJCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x78D39A0", Offset = "0x78D23A0", VA = "0x1878D39A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x78D30C0", Offset = "0x78D1AC0", VA = "0x1878D30C0")]
	public static void CalculateLocalBoundsFor(GameObject IHDAMAGFMLN, [Out] Bounds DHNDDMGHDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x78D3730", Offset = "0x78D2130", VA = "0x1878D3730")]
	private static void GMKDIKENHFE(Bounds LKKBJAKGIGL, Color LHJMDMLADDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x78D3BD0", Offset = "0x78D25D0", VA = "0x1878D3BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9B9180", Offset = "0x9B7B80", VA = "0x1809B9180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xE906B0", Offset = "0xE8F0B0", VA = "0x180E906B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x55D3A60", Offset = "0x55D2460", VA = "0x1855D3A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
	public virtual void IDEEBCALEGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
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
	[GOGNGLDBHMN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x55D35D0", Offset = "0x55D1FD0", VA = "0x1855D35D0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x55D21A0", Offset = "0x55D0BA0", VA = "0x1855D21A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x55D3980", Offset = "0x55D2380", VA = "0x1855D3980")]
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
	private sealed class LMCANIMJJOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public LMCANIMJJOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4EDC100", Offset = "0x4EDAB00", VA = "0x184EDC100")]
		internal int OFJNNMDMPOK(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[GOGNGLDBHMN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x43A2150", Offset = "0x43A0B50", VA = "0x1843A2150", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x43A21B0", Offset = "0x43A0BB0", VA = "0x1843A21B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x43A2030", Offset = "0x43A0A30", VA = "0x1843A2030", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey NJBPFCDJFGD]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x43A20F0", Offset = "0x43A0AF0", VA = "0x1843A20F0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x43A1EE0", Offset = "0x43A08E0", VA = "0x1843A1EE0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x43A1B80", Offset = "0x43A0580", VA = "0x1843A1B80", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x43A0F40", Offset = "0x439F940", VA = "0x1843A0F40", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x43A0E70", Offset = "0x439F870", VA = "0x1843A0E70", Slot = "14")]
	protected virtual string DDIJKLBCPDP(TKeyVal LDBOMNNPKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x43A0DB0", Offset = "0x439F7B0", VA = "0x1843A0DB0", Slot = "4")]
	public bool ContainsKey(TKey NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x43A1D60", Offset = "0x43A0760", VA = "0x1843A1D60", Slot = "5")]
	public bool TryGetValue(TKey NJBPFCDJFGD, [Out] TVal PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x43A0EA0", Offset = "0x439F8A0", VA = "0x1843A0EA0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x43A0EA0", Offset = "0x439F8A0", VA = "0x1843A0EA0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x43A1DC0", Offset = "0x43A07C0", VA = "0x1843A1DC0")]
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
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x431C530", Offset = "0x431AF30", VA = "0x18431C530")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[GOGNGLDBHMN]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x55D5410", Offset = "0x55D3E10", VA = "0x1855D5410")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x55D4C50", Offset = "0x55D3650", VA = "0x1855D4C50", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x55D4200", Offset = "0x55D2C00", VA = "0x1855D4200", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class CJBNLGBFCCD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct EDEGKLJPMGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T ABKPALEDJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float DIODDCDNNCO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int PFOHIDOEGJF = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float GMGKAJACBEM = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly EDEGKLJPMGB[] NAKGFAINKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int KMOKJOBDIAB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float LKBKPCOAFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB9A7A0", Offset = "0xB991A0", VA = "0x180B9A7A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xBFD880", Offset = "0xBFC280", VA = "0x180BFD880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T CGAFGCMOAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x657AAB0", Offset = "0x65794B0", VA = "0x18657AAB0")]
	protected CJBNLGBFCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x657AAF0", Offset = "0x65794F0", VA = "0x18657AAF0")]
	protected CJBNLGBFCCD(int PICLDLMFMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x657A8D0", Offset = "0x65792D0", VA = "0x18657A8D0")]
	public void HEHCILJMFIP(float KDFJLNMBGOO, T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool FEKFIGMGJNB(float GFMFKDMIOIE, float MGOOJKLLELJ, [Out] T PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool NHCGDCJPLJM(float GFMFKDMIOIE, float MGOOJKLLELJ, [Out] T PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x657AA50", Offset = "0x6579450", VA = "0x18657AA50")]
	public void OPINELCICKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KJMIIEJJEFG : CJBNLGBFCCD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x78D2350", Offset = "0x78D0D50", VA = "0x1878D2350", Slot = "4")]
	public override bool FEKFIGMGJNB(float GFMFKDMIOIE, float MGOOJKLLELJ, [Out] Vector3 PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x78D24B0", Offset = "0x78D0EB0", VA = "0x1878D24B0", Slot = "5")]
	public override bool NHCGDCJPLJM(float GFMFKDMIOIE, float MGOOJKLLELJ, [Out] Vector3 PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x78D25F0", Offset = "0x78D0FF0", VA = "0x1878D25F0")]
	public KJMIIEJJEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JELFNFACAGB
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x36DE590", Offset = "0x36DCF90", VA = "0x1836DE590")]
	public static BJBKJJKBKMJ<T1, T2> IDEDHGEBOCJ<T1, T2>(T1 FECPCCLDLGA, T2 KGGMOAKAKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x36DE630", Offset = "0x36DD030", VA = "0x1836DE630")]
	public static OIEJMDMDOBH<T1, T2, T3> IDEDHGEBOCJ<T1, T2, T3>(T1 FECPCCLDLGA, T2 KGGMOAKAKIF, T3 FNNFLKJDOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5175610", Offset = "0x5174010", VA = "0x185175610")]
	internal static int GBNKFKAEHOF(int ELPIPGLFJFP, int IGMCMPJINDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6B1C140", Offset = "0x6B1AB40", VA = "0x186B1C140")]
	internal static int GBNKFKAEHOF(int ELPIPGLFJFP, int IGMCMPJINDE, int INOGGADFPBE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BJBKJJKBKMJ<T1, T2> : IComparable<BJBKJJKBKMJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 LENLHJNCDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 PJBNNMEIHOF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x647B1A0", Offset = "0x6479BA0", VA = "0x18647B1A0")]
	public BJBKJJKBKMJ(T1 FECPCCLDLGA, T2 KGGMOAKAKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x64797E0", Offset = "0x64781E0", VA = "0x1864797E0", Slot = "4")]
	public int CompareTo(BJBKJJKBKMJ<T1, T2> OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x647A140", Offset = "0x6478B40", VA = "0x18647A140", Slot = "0")]
	public override bool Equals(object OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x647A440", Offset = "0x6478E40", VA = "0x18647A440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x647AF10", Offset = "0x6479910", VA = "0x18647AF10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OIEJMDMDOBH<T1, T2, T3> : IComparable<OIEJMDMDOBH<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 LENLHJNCDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 PJBNNMEIHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 AFBHOEAHIML;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x52DDF20", Offset = "0x52DC920", VA = "0x1852DDF20")]
	public OIEJMDMDOBH(T1 FECPCCLDLGA, T2 KGGMOAKAKIF, T3 FNNFLKJDOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x52DD710", Offset = "0x52DC110", VA = "0x1852DD710", Slot = "4")]
	public int CompareTo(OIEJMDMDOBH<T1, T2, T3> OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x52DD980", Offset = "0x52DC380", VA = "0x1852DD980", Slot = "0")]
	public override bool Equals(object OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x52DDBC0", Offset = "0x52DC5C0", VA = "0x1852DDBC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x52DDC60", Offset = "0x52DC660", VA = "0x1852DDC60", Slot = "3")]
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
	public AnimationCurve DJKLHDCADKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T PJLMJBKIHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x11CB770", Offset = "0x11CA170", VA = "0x1811CB770")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T JAELPHABEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB9B420", Offset = "0xB99E20", VA = "0x180B9B420")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2A40030", Offset = "0x2A3EA30", VA = "0x182A40030")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2A40230", Offset = "0x2A3EC30", VA = "0x182A40230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float OELFLPMOOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xB91A90", Offset = "0xB90490", VA = "0x180B91A90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x587D3A0", Offset = "0x587BDA0", VA = "0x18587D3A0")]
	public T MNGAEKNILLN(float PPOLMDFNGFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x587D630", Offset = "0x587C030", VA = "0x18587D630")]
	public T NAGDPPPCFGC(float PPOLMDFNGFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OBHCEONEMPA(T HIHOACCANFP, T JJEIFHEKJKL, float PPOLMDFNGFC);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x78D0480", Offset = "0x78CEE80", VA = "0x1878D0480", Slot = "4")]
	protected override float OBHCEONEMPA(float HIHOACCANFP, float JJEIFHEKJKL, float PPOLMDFNGFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x78D04C0", Offset = "0x78CEEC0", VA = "0x1878D04C0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x16329B0", Offset = "0x16313B0", VA = "0x1816329B0", Slot = "4")]
	protected override Vector3 OBHCEONEMPA(Vector3 HIHOACCANFP, Vector3 JJEIFHEKJKL, float PPOLMDFNGFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x78D4CA0", Offset = "0x78D36A0", VA = "0x1878D4CA0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x78CE650", Offset = "0x78CD050", VA = "0x1878CE650", Slot = "4")]
	protected override Color OBHCEONEMPA(Color HIHOACCANFP, Color JJEIFHEKJKL, float PPOLMDFNGFC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x78CE710", Offset = "0x78CD110", VA = "0x1878CE710")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JAEHCGKKEAH : JLHAOJOBFEP<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x78D22A0", Offset = "0x78D0CA0", VA = "0x1878D22A0")]
	public JAEHCGKKEAH(int CIIHPLFOGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x78D2230", Offset = "0x78D0C30", VA = "0x1878D2230", Slot = "6")]
	protected override uint CPNJGJCMINP(uint ALFFJDGFOGF, string PPJFMHBDGNA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NCODODENDCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable LALLOKGAEJH;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public NCODODENDCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct PKJFJFKNEOP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KMEANMODPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int OIKLOAPPJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int MABHGHPLMGD;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x51777C0", Offset = "0x51761C0", VA = "0x1851777C0")]
	private PKJFJFKNEOP(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> JHKOKEIDDJD, int INMFHKNBCIC, int HNLDGFGJKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x53DD8C0", Offset = "0x53DC2C0", VA = "0x1853DD8C0")]
	public static PKJFJFKNEOP<T> DDDHPONDPCL()
	{
		return default(PKJFJFKNEOP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x53DBC40", Offset = "0x53DA640", VA = "0x1853DBC40")]
	public (int, int, Task<T>) CPMEHGIFBEE(int DJPDBDCCOEF, [Optional] CancellationToken BJEPDCCBCHJ, double KFGHOINKLDG = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x53DDF50", Offset = "0x53DC950", VA = "0x1853DDF50")]
	public void HBJINDPPBHJ(int DJPDBDCCOEF, int HNLDGFGJKMO, [In] T FFBEKAFHIDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FHNJDCGHGKK
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x78D03B0", Offset = "0x78CEDB0", VA = "0x1878D03B0")]
	public static PKJFJFKNEOP<HGCBNLHKPOI> DDDHPONDPCL()
	{
		return default(PKJFJFKNEOP<HGCBNLHKPOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x78D0400", Offset = "0x78CEE00", VA = "0x1878D0400")]
	public static void HBJINDPPBHJ([In] this PKJFJFKNEOP<HGCBNLHKPOI> IJPDNJELPLO, int DJPDBDCCOEF, int HNLDGFGJKMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class FECHJIEJFFC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> ECOLINBHPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> FIHJNBIJKDI;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3EC87C0", Offset = "0x3EC71C0", VA = "0x183EC87C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KMCAIMHLNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> KAIGPNAKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x47BD1B0", Offset = "0x47BBBB0", VA = "0x1847BD1B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> FIGJBBINHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x47BD200", Offset = "0x47BBC00", VA = "0x1847BD200", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x47BD0F0", Offset = "0x47BBAF0", VA = "0x1847BD0F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x47BD290", Offset = "0x47BBC90", VA = "0x1847BD290", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x47BCA90", Offset = "0x47BB490", VA = "0x1847BCA90")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x47BC840", Offset = "0x47BB240", VA = "0x1847BC840", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x47BCED0", Offset = "0x47BB8D0", VA = "0x1847BCED0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x47BC4E0", Offset = "0x47BAEE0", VA = "0x1847BC4E0", Slot = "9")]
	public void Add(TKey NJBPFCDJFGD, TVal PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x47BC580", Offset = "0x47BAF80", VA = "0x1847BC580", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OIBJKKOCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x47BC8E0", Offset = "0x47BB2E0", VA = "0x1847BC8E0", Slot = "8")]
	public bool ContainsKey(TKey NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x47BC970", Offset = "0x47BB370", VA = "0x1847BC970", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x47BCE50", Offset = "0x47BB850", VA = "0x1847BCE50", Slot = "10")]
	public bool Remove(TKey NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x47BCE10", Offset = "0x47BB810", VA = "0x1847BCE10", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x47BCF70", Offset = "0x47BB970", VA = "0x1847BCF70", Slot = "11")]
	public bool TryGetValue(TKey NJBPFCDJFGD, [Out] TVal PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x47BCAF0", Offset = "0x47BB4F0", VA = "0x1847BCAF0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x47BC9B0", Offset = "0x47BB3B0", VA = "0x1847BC9B0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NAKGFAINKPB, int JMDPMMMKOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x47BCB90", Offset = "0x47BB590", VA = "0x1847BCB90")]
	public bool OCHHJJBEIMP(TVal NJBPFCDJFGD, [Out] TKey PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x47BC320", Offset = "0x47BAD20", VA = "0x1847BC320")]
	private void ABJMKGGONOH(TKey NJBPFCDJFGD, TVal OILNFPPOKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x47BCC50", Offset = "0x47BB650", VA = "0x1847BCC50")]
	private void PNDBKGNDFIL(TKey NJBPFCDJFGD, TVal OILNFPPOKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x47BC610", Offset = "0x47BB010", VA = "0x1847BC610")]
	private bool CEFDPLNCFCL(TKey NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x47BCFD0", Offset = "0x47BB9D0", VA = "0x1847BCFD0")]
	public FECHJIEJFFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class HEGBNNDBLEL<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private HEGBNNDBLEL<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x119D1E0", Offset = "0x119BBE0", VA = "0x18119D1E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4405ED0", Offset = "0x44048D0", VA = "0x184405ED0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4406C50", Offset = "0x4405650", VA = "0x184406C50")]
		public Enumerator(HEGBNNDBLEL<T> KGINKPKLCFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4403640", Offset = "0x4402040", VA = "0x184403640", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x44049C0", Offset = "0x44033C0", VA = "0x1844049C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x44030B0", Offset = "0x4401AB0", VA = "0x1844030B0")]
		private void DBJPPMPBJAG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] GNCABPMOJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int FNEPEEDFAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int JPAAPPADCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int AIBPOENNNGG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4948170", Offset = "0x4946B70", VA = "0x184948170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x49492D0", Offset = "0x4947CD0", VA = "0x1849492D0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4947E80", Offset = "0x4946880", VA = "0x184947E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4949F80", Offset = "0x4948980", VA = "0x184949F80")]
	public HEGBNNDBLEL(int CIIHPLFOGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4949580", Offset = "0x4947F80", VA = "0x184949580")]
	public void HEHCILJMFIP(T PPOLMDFNGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4949C80", Offset = "0x4948680", VA = "0x184949C80")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x49488D0", Offset = "0x49472D0", VA = "0x1849488D0")]
	public void DPEMBMMCNEM(int PGJKBFGEJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x49490D0", Offset = "0x4947AD0", VA = "0x1849490D0")]
	public void ECPAKGCPJJJ(T[] NAKGFAINKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4949BA0", Offset = "0x49485A0", VA = "0x184949BA0")]
	public Enumerator KCFKLFFNEEA()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4949DA0", Offset = "0x49487A0", VA = "0x184949DA0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4949DA0", Offset = "0x49487A0", VA = "0x184949DA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x49481B0", Offset = "0x4946BB0", VA = "0x1849481B0")]
	private int CPPDAGMKCKM(int DOAKEFBOPIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4949240", Offset = "0x4947C40", VA = "0x184949240")]
	private int EPNCNKDGAJJ(int DOAKEFBOPIA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ODMCGKBIDML<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> LGEAJOJCHDB(TRequest EELGNOJLLOB, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum HBGCDJPBBPN
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class NJKPLOCLFJC
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float CFGONDGGFJK = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan HIJBEKGLCNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int LFMBJCNBONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public HBGCDJPBBPN OGPICHDBKBP;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly NJKPLOCLFJC JKECEEFIAPF;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float AMAHMNNBCOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x51B1DC0", Offset = "0x51B07C0", VA = "0x1851B1DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan DHJAFKICLJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x51B1F80", Offset = "0x51B0980", VA = "0x1851B1F80")]
		public NJKPLOCLFJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct GBCNDMDALLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest EELGNOJLLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken BJEPDCCBCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> OPKHIMLOHCF;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x487EEE0", Offset = "0x487D8E0", VA = "0x18487EEE0")]
		public GBCNDMDALLP(TRequest EELGNOJLLOB, TaskCompletionSource<TResult> OPKHIMLOHCF, CancellationToken BJEPDCCBCHJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct MNBGMIEOGFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public ODMCGKBIDML<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x513D230", Offset = "0x513BC30", VA = "0x18513D230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x513DE90", Offset = "0x513C890", VA = "0x18513DE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct LKECIEHDNOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ODMCGKBIDML<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private GBCNDMDALLP <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4ED9520", Offset = "0x4ED7F20", VA = "0x184ED9520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4EDA150", Offset = "0x4ED8B50", VA = "0x184EDA150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource BDGLKFOKLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<GBCNDMDALLP> LAKFGHFMFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NJKPLOCLFJC LMJCOABHJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly LGEAJOJCHDB PMMNHCCLEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task MPOLNBKBIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int LNJECKGPCMA;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x52CE100", Offset = "0x52CCB00", VA = "0x1852CE100")]
	public ODMCGKBIDML(LGEAJOJCHDB PMMNHCCLEDM, [Optional] NJKPLOCLFJC LMJCOABHJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x52CC920", Offset = "0x52CB320", VA = "0x1852CC920")]
	public Task<TResult> GBABLADCKPI(TRequest EELGNOJLLOB, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x52CC510", Offset = "0x52CAF10", VA = "0x1852CC510")]
	private void BDBGGIFFMOI(GBCNDMDALLP GJNHJLLFNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x52CCFF0", Offset = "0x52CB9F0", VA = "0x1852CCFF0")]
	[AsyncStateMachine(typeof(ODMCGKBIDML<, >.MNBGMIEOGFC))]
	private Task LHCIPEPEJMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x52CD560", Offset = "0x52CBF60", VA = "0x1852CD560")]
	private GBCNDMDALLP OEAJFGBIIKJ()
	{
		return default(GBCNDMDALLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x52CDC00", Offset = "0x52CC600", VA = "0x1852CDC00")]
	[AsyncStateMachine(typeof(ODMCGKBIDML<, >.LKECIEHDNOM))]
	private Task POBNMKOIMNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x52CC6E0", Offset = "0x52CB0E0", VA = "0x1852CC6E0")]
	private void BDCFFOBJFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x52CC8E0", Offset = "0x52CB2E0", VA = "0x1852CC8E0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class FGEHMDGMDGP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> FMFEHIEKOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> BEHBGOAGGPF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3EC87C0", Offset = "0x3EC71C0", VA = "0x183EC87C0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KMCAIMHLNNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3905660", Offset = "0x3904060", VA = "0x183905660", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x47C4240", Offset = "0x47C2C40", VA = "0x1847C4240", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x47C3470", Offset = "0x47C1E70", VA = "0x1847C3470", Slot = "11")]
	public void Add(T OIBJKKOCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x47C3980", Offset = "0x47C2380", VA = "0x1847C3980")]
	public bool LKBNKEDGDPB(T OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x47C3E20", Offset = "0x47C2820", VA = "0x1847C3E20", Slot = "15")]
	public bool Remove(T OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x47C3600", Offset = "0x47C2000", VA = "0x1847C3600", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x47C3FA0", Offset = "0x47C29A0", VA = "0x1847C3FA0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x47C34B0", Offset = "0x47C1EB0", VA = "0x1847C34B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x47C3550", Offset = "0x47C1F50", VA = "0x1847C3550", Slot = "13")]
	public bool Contains(T OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x47C35A0", Offset = "0x47C1FA0", VA = "0x1847C35A0", Slot = "14")]
	public void CopyTo(T[] NAKGFAINKPB, int JMDPMMMKOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x47C3690", Offset = "0x47C2090", VA = "0x1847C3690", Slot = "6")]
	public int IndexOf(T OIBJKKOCOBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x47C3840", Offset = "0x47C2240", VA = "0x1847C3840", Slot = "7")]
	public void Insert(int DOAKEFBOPIA, T OIBJKKOCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x47C3B80", Offset = "0x47C2580", VA = "0x1847C3B80", Slot = "8")]
	public void RemoveAt(int DOAKEFBOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x47C3FE0", Offset = "0x47C29E0", VA = "0x1847C3FE0")]
	public FGEHMDGMDGP()
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
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x28C1370", Offset = "0x28BFD70", VA = "0x1828C1370")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x241CA80", Offset = "0x241B480", VA = "0x18241CA80")]
		public SerializedGuid([In] Guid BIGAPECKJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x78D40C0", Offset = "0x78D2AC0", VA = "0x1878D40C0")]
		public static SerializedGuid FJEGBCCJIJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x78D4150", Offset = "0x78D2B50", VA = "0x1878D4150")]
		public static SerializedGuid LPJCKNFDIKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x78D3F90", Offset = "0x78D2990", VA = "0x1878D3F90")]
		public bool DDFCNJDHCLF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x78D4240", Offset = "0x78D2C40", VA = "0x1878D4240", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x78D41C0", Offset = "0x78D2BC0", VA = "0x1878D41C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x78D3FF0", Offset = "0x78D29F0", VA = "0x1878D3FF0", Slot = "7")]
		public bool Equals(SerializedGuid OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x78D4030", Offset = "0x78D2A30", VA = "0x1878D4030", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x78D4140", Offset = "0x78D2B40", VA = "0x1878D4140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x78D3F60", Offset = "0x78D2960", VA = "0x1878D3F60", Slot = "6")]
		public int CompareTo(SerializedGuid OLKLGHOAKNE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class EDGKKBPGCAO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type JAKPNANGGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string GPACBHKBPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool FHGMFNLOANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool MAIAODGAPMP;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x78CF040", Offset = "0x78CDA40", VA = "0x1878CF040")]
	public EDGKKBPGCAO(Type DCJMJFKJAKK, string OACENFNAPGH, bool APJIKHJHCFN = false, bool KEACJGDCNPG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IBBLFKOMBIL<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int IFGCPGOLANO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> PACOGAGIJGL(float KDFJLNMBGOO, [Optional] float? JANDFOFKLEF);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCKCAHAHECM(float KDFJLNMBGOO, T PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPINELCICKH();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class LAIDJADPKND<T> : IBBLFKOMBIL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class DGKBLOLNGJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float DOBIOAAAFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T ABKPALEDJBA;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public DGKBLOLNGJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BPPNIELFMGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public BPPNIELFMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x64C3E50", Offset = "0x64C2850", VA = "0x1864C3E50")]
		internal bool FEPLIFGCFPN(DGKBLOLNGJD sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float BLDBPKEBJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float FIEOGOIGPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<DGKBLOLNGJD> LNKEJEANJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NHNHJDJGPJF<DGKBLOLNGJD> OECBABOIPLK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IFGCPGOLANO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4EA6780", Offset = "0x4EA5180", VA = "0x184EA6780", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6FF0", Offset = "0x4EA59F0", VA = "0x184EA6FF0")]
	public LAIDJADPKND(float MPDIGMEOACC, float FNJBGHAIMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6240", Offset = "0x4EA4C40", VA = "0x184EA6240", Slot = "6")]
	public bool CCKCAHAHECM(float KDFJLNMBGOO, T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6910", Offset = "0x4EA5310", VA = "0x184EA6910", Slot = "5")]
	public IEnumerable<T> PACOGAGIJGL(float KDFJLNMBGOO, float? JANDFOFKLEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6860", Offset = "0x4EA5260", VA = "0x184EA6860", Slot = "7")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4EA65D0", Offset = "0x4EA4FD0", VA = "0x184EA65D0")]
	private void ENHDCFKFABE(float KDFJLNMBGOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class MNALJABKLBP<T> : IBBLFKOMBIL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct NMCOIFKHFPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T ABKPALEDJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float DOBIOAAAFNB;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x48FC900", Offset = "0x48FB300", VA = "0x1848FC900")]
		public NMCOIFKHFPI(T PPJFMHBDGNA, float KDFJLNMBGOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class NPLNGGOCJIJ : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
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
		public MNALJABKLBP<T> <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public NPLNGGOCJIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x51C9670", Offset = "0x51C8070", VA = "0x1851C9670", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x51C9BA0", Offset = "0x51C85A0", VA = "0x1851C9BA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x51C99E0", Offset = "0x51C83E0", VA = "0x1851C99E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4846BB0", Offset = "0x48455B0", VA = "0x184846BB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float MPDIGMEOACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float FNJBGHAIMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<NMCOIFKHFPI> LNKEJEANJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int FNEPEEDFAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int FFGPDCJBNKG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int IFGCPGOLANO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B5540", Offset = "0x9B3F40", VA = "0x1809B5540", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x513D000", Offset = "0x513BA00", VA = "0x18513D000")]
	public MNALJABKLBP(float MPDIGMEOACC, float FNJBGHAIMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x513C5C0", Offset = "0x513AFC0", VA = "0x18513C5C0", Slot = "6")]
	public bool CCKCAHAHECM(float KDFJLNMBGOO, T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x513C2C0", Offset = "0x513ACC0", VA = "0x18513C2C0", Slot = "8")]
	public int ADAEJIBFAKD(float KDFJLNMBGOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x513CC50", Offset = "0x513B650", VA = "0x18513CC50", Slot = "5")]
	[IteratorStateMachine(typeof(MNALJABKLBP<>.NPLNGGOCJIJ))]
	public IEnumerable<T> PACOGAGIJGL(float KDFJLNMBGOO, float? JANDFOFKLEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x513CBF0", Offset = "0x513B5F0", VA = "0x18513CBF0", Slot = "7")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x513C970", Offset = "0x513B370", VA = "0x18513C970")]
	private void CGHILHCOHMD(float KDFJLNMBGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x513CA60", Offset = "0x513B460", VA = "0x18513CA60")]
	private NMCOIFKHFPI EKNPNHAMBPP()
	{
		return default(NMCOIFKHFPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class NCPOPMIDADO<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct HGDIFADGBMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long BCNHOIOCFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long KBAOIFMMMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int HGJDMKJKKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int IMNMEADGJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool BNFALJAHBHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string MANDIAFANLF;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x49529D0", Offset = "0x49513D0", VA = "0x1849529D0")]
		public HGDIFADGBMA(long BCNHOIOCFFA, int HGJDMKJKKIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x49529A0", Offset = "0x49513A0", VA = "0x1849529A0")]
		public HGDIFADGBMA(long BCNHOIOCFFA, long KBAOIFMMMHI, int HGJDMKJKKIE, int IMNMEADGJDE, bool BNFALJAHBHC, string MANDIAFANLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4952930", Offset = "0x4951330", VA = "0x184952930")]
		public int JKKHNEMMBCM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4952980", Offset = "0x4951380", VA = "0x184952980")]
		public int KOFADLMHDCN(int MOGFFJDHGBJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4952830", Offset = "0x4951230", VA = "0x184952830")]
		public double ECHBJJIEHLD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4952890", Offset = "0x4951290", VA = "0x184952890")]
		public HGDIFADGBMA HHPPOEIKGKB(long KBAOIFMMMHI, int IMNMEADGJDE)
		{
			return default(HGDIFADGBMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class CFILPBLEJMI : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct BHELGMBIBED<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public CFILPBLEJMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<CFILPBLEJMI, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private CFILPBLEJMI <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x6464A10", Offset = "0x6463410", VA = "0x186464A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x47DC300", Offset = "0x47DAD00", VA = "0x1847DC300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey BKFIOJPHBFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly NCPOPMIDADO<TKey> NDBGCDOMBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly LMPJBEBLCLM BLAHIKOFFGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<CFILPBLEJMI> FGAIILCCKLK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string HELAKEFOPAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x3F10000", Offset = "0x3F0EA00", VA = "0x183F10000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<CFILPBLEJMI> OOHHONMBFKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x656E210", Offset = "0x656CC10", VA = "0x18656E210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public HGDIFADGBMA KCNAGNICKOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x656E280", Offset = "0x656CC80", VA = "0x18656E280")]
			[CompilerGenerated]
			get
			{
				return default(HGDIFADGBMA);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x656E250", Offset = "0x656CC50", VA = "0x18656E250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x656E450", Offset = "0x656CE50", VA = "0x18656E450")]
		internal CFILPBLEJMI(NCPOPMIDADO<TKey> NDBGCDOMBIN, TKey NJBPFCDJFGD, LMPJBEBLCLM BLAHIKOFFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x656E2A0", Offset = "0x656CCA0", VA = "0x18656E2A0")]
		public CFILPBLEJMI PFIIKEGNDGD(TKey NJBPFCDJFGD, [Optional] LMPJBEBLCLM? CMCFAOEGNKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3651DC0", Offset = "0x36507C0", VA = "0x183651DC0")]
		[AsyncStateMachine(typeof(BHELGMBIBED<>))]
		public Task<T> NFFKAKLNOAF<T>(TKey NJBPFCDJFGD, Func<CFILPBLEJMI, Task<T>> KEEHKILKFBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x656DFC0", Offset = "0x656C9C0", VA = "0x18656DFC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class PNFKENINHGA : IEnumerable<(TKey, List<TKey>, HGDIFADGBMA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HGDIFADGBMA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, HGDIFADGBMA timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public NCPOPMIDADO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, HGDIFADGBMA timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, HGDIFADGBMA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x28B3D60", Offset = "0x28B2760", VA = "0x1828B3D60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HGDIFADGBMA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x53E3D70", Offset = "0x53E2770", VA = "0x1853E3D70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28B3E50", Offset = "0x28B2850", VA = "0x1828B3E50")]
		[DebuggerHidden]
		public PNFKENINHGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x438DBA0", Offset = "0x438C5A0", VA = "0x18438DBA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x53E38B0", Offset = "0x53E22B0", VA = "0x1853E38B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x53E3860", Offset = "0x53E2260", VA = "0x1853E3860")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x53E3D20", Offset = "0x53E2720", VA = "0x1853E3D20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x53E3C50", Offset = "0x53E2650", VA = "0x1853E3C50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HGDIFADGBMA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3F0DFF0", Offset = "0x3F0C9F0", VA = "0x183F0DFF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class EGAOAKHMDHH : IEnumerable<(TKey, List<TKey>, HGDIFADGBMA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HGDIFADGBMA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, HGDIFADGBMA timerEntry) <>2__current;

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
		private CFILPBLEJMI timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CFILPBLEJMI <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public NCPOPMIDADO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<CFILPBLEJMI> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, HGDIFADGBMA timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, HGDIFADGBMA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x28B3D60", Offset = "0x28B2760", VA = "0x1828B3D60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HGDIFADGBMA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x435B030", Offset = "0x4359A30", VA = "0x18435B030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28B3E50", Offset = "0x28B2850", VA = "0x1828B3E50")]
		[DebuggerHidden]
		public EGAOAKHMDHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x435B090", Offset = "0x4359A90", VA = "0x18435B090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x435A6D0", Offset = "0x43590D0", VA = "0x18435A6D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x435A670", Offset = "0x4359070", VA = "0x18435A670")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x435A610", Offset = "0x4359010", VA = "0x18435A610")]
		private void EKCCALBOGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x435AFE0", Offset = "0x43599E0", VA = "0x18435AFE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x435AEA0", Offset = "0x43598A0", VA = "0x18435AEA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HGDIFADGBMA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x435AFA0", Offset = "0x43599A0", VA = "0x18435AFA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, HGDIFADGBMA, LMPJBEBLCLM> FKKAIFOFELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, HGDIFADGBMA, LMPJBEBLCLM> HLJJELOKKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<NCPOPMIDADO<TKey>, LMPJBEBLCLM> MPIJCKMJCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly CFILPBLEJMI MCKLCPFPHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool AGGPBOPKIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int KNDILGBBPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch IONJLKDEBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int JLBNGCHHMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string OBFEGHAECAF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public CFILPBLEJMI CEPDDGGKHPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string HELAKEFOPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4F0", Offset = "0x9AAEF0", VA = "0x1809AC4F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5197190", Offset = "0x5195B90", VA = "0x185197190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5197370", Offset = "0x5195D70", VA = "0x185197370")]
	public NCPOPMIDADO(TKey LHMMKFHJFOJ, LMPJBEBLCLM BLAHIKOFFGK, [Optional] int? HGJDMKJKKIE, [Optional][CanBeNull] Stopwatch IONJLKDEBKB, [Optional] Action<TKey, HGDIFADGBMA, LMPJBEBLCLM> FKKAIFOFELP, [Optional] Action<TKey, HGDIFADGBMA, LMPJBEBLCLM> HLJJELOKKIL, [Optional] Action<NCPOPMIDADO<TKey>, LMPJBEBLCLM> MPIJCKMJCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x51970C0", Offset = "0x5195AC0", VA = "0x1851970C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x51972D0", Offset = "0x5195CD0", VA = "0x1851972D0")]
	[IteratorStateMachine(typeof(NCPOPMIDADO<>.PNFKENINHGA))]
	public IEnumerable<(TKey, List<TKey>, HGDIFADGBMA)> KKHCALGEFEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x51971F0", Offset = "0x5195BF0", VA = "0x1851971F0")]
	[IteratorStateMachine(typeof(NCPOPMIDADO<>.EGAOAKHMDHH))]
	private IEnumerable<(TKey, List<TKey>, HGDIFADGBMA)> KKHCALGEFEP(List<TKey> LMJJJIGEFFK, CFILPBLEJMI LPLNNNILMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5197040", Offset = "0x5195A40", VA = "0x185197040")]
	private (long, int) AOHMKGLINBD()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class JBBOAJIKCCL<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut PHNJJHPBACG(NCPOPMIDADO<TKey> NDBGCDOMBIN);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	protected JBBOAJIKCCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class IEOKLGBDGHC<TKey> : JBBOAJIKCCL<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string CMLFNODMNHL(TKey NJBPFCDJFGD);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4A7AB10", Offset = "0x4A79510", VA = "0x184A7AB10")]
	private static string KAFLNIKELMP(TKey NJBPFCDJFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4A7AB50", Offset = "0x4A79550", VA = "0x184A7AB50", Slot = "4")]
	public override string PHNJJHPBACG(NCPOPMIDADO<TKey> NDBGCDOMBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4A7AC30", Offset = "0x4A79630", VA = "0x184A7AC30")]
	public string PHNJJHPBACG(NCPOPMIDADO<TKey> NDBGCDOMBIN, [NotNull] CMLFNODMNHL HPCPNBIANOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string AIGBOEEEJDM(NCPOPMIDADO<TKey> NDBGCDOMBIN, [NotNull] CMLFNODMNHL HPCPNBIANOH);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3F278D0", Offset = "0x3F262D0", VA = "0x183F278D0")]
	protected IEOKLGBDGHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class HIHFDIIKMCD<TKey> : JBBOAJIKCCL<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string PPBOBFLKDEN(TKey NJBPFCDJFGD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string NCENNDMEFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double AGBCJJEFOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool AMPDNFLNPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int AFFCHJFJAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> PMBOEGLOIGL;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4960810", Offset = "0x495F210", VA = "0x184960810")]
	private static string KAFLNIKELMP(TKey NJBPFCDJFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x49611E0", Offset = "0x495FBE0", VA = "0x1849611E0")]
	public HIHFDIIKMCD(string NCENNDMEFHK = "F2", double AGBCJJEFOOL = double.MaxValue, bool AMPDNFLNPLJ = false, int AFFCHJFJAJE = int.MaxValue, [Optional] ISet<string> PMBOEGLOIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4960AC0", Offset = "0x495F4C0", VA = "0x184960AC0", Slot = "4")]
	public override Dictionary<string, string> PHNJJHPBACG(NCPOPMIDADO<TKey> NDBGCDOMBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4960640", Offset = "0x495F040", VA = "0x184960640")]
	private bool BMBLPAKPDFE(string IANKFDHMOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4960BA0", Offset = "0x495F5A0", VA = "0x184960BA0")]
	public Dictionary<string, string> PHNJJHPBACG(NCPOPMIDADO<TKey> NDBGCDOMBIN, PPBOBFLKDEN HPCPNBIANOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4960850", Offset = "0x495F250", VA = "0x184960850")]
	private string MHMOKHBKKFF(StringBuilder KEJJHJBJACC, List<TKey> MFIENDEPNND, PPBOBFLKDEN HPCPNBIANOH, bool HDBKCHCCEIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x49606B0", Offset = "0x495F0B0", VA = "0x1849606B0")]
	private static void HMBCHCKDMGK(StringBuilder BPCGIPMOLFF, string AIMJEHEJKHL, bool FCJPMNOCIGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KBAEMEFANEN<TKey> : IEOKLGBDGHC<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FGIPCGKOGMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CMLFNODMNHL keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static KBAEMEFANEN<TKey> LALLOKGAEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] APLIKKKAJKE;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE630", Offset = "0x4DDD030", VA = "0x184DDE630")]
	private KBAEMEFANEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD5E0", Offset = "0x4DDBFE0", VA = "0x184DDD5E0", Slot = "5")]
	protected override string AIGBOEEEJDM(NCPOPMIDADO<TKey> NDBGCDOMBIN, CMLFNODMNHL HPCPNBIANOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE3F0", Offset = "0x4DDCDF0", VA = "0x184DDE3F0")]
	[CompilerGenerated]
	internal static string OBECGEKFNJK(string CHJILMDNHCH, TKey NJBPFCDJFGD, FGIPCGKOGMA P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class IAODPMPCBLI : NCPOPMIDADO<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class KLINGALCBDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<IAODPMPCBLI, LMPJBEBLCLM> callback;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KLINGALCBDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x78D2630", Offset = "0x78D1030", VA = "0x1878D2630")]
		internal void OLEDODGOFKN(NCPOPMIDADO<string> timer, LMPJBEBLCLM log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x78D19E0", Offset = "0x78D03E0", VA = "0x1878D19E0")]
	public IAODPMPCBLI(LMPJBEBLCLM BLAHIKOFFGK, [Optional] string OAKJAGGIHEM, [Optional] int? HGJDMKJKKIE, [Optional] Stopwatch IONJLKDEBKB, [Optional] Action<string, HGDIFADGBMA, LMPJBEBLCLM> FKKAIFOFELP, [Optional] Action<string, HGDIFADGBMA, LMPJBEBLCLM> HLJJELOKKIL, [Optional] Action<IAODPMPCBLI, LMPJBEBLCLM> MPIJCKMJCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x78D1920", Offset = "0x78D0320", VA = "0x1878D1920")]
	private static Action<NCPOPMIDADO<string>, LMPJBEBLCLM> DCFHFJIEPNN(Action<IAODPMPCBLI, LMPJBEBLCLM> PCKPGHHEKOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class FHEBDONDPGL
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class PCBPHODAOFC : FHEBDONDPGL
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static FHEBDONDPGL LALLOKGAEJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x78D2A50", Offset = "0x78D1450", VA = "0x1878D2A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float HMFDIECFBNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x10FD190", Offset = "0x10FBB90", VA = "0x1810FD190", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x78D2B40", Offset = "0x78D1540", VA = "0x1878D2B40")]
		public PCBPHODAOFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static FHEBDONDPGL HOCFJJMCKKF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static FHEBDONDPGL JKECEEFIAPF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x78D0250", Offset = "0x78CEC50", VA = "0x1878D0250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float HMFDIECFBNA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	protected FHEBDONDPGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface ICABHIKAJNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool IFMEABDJOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface PHLGPCMBMIF<T> : ICABHIKAJNJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> BBNIIHNELDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	ECHAPNAJEJF<T> OGFOLAGDOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class PBKGHIECKKA
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3834E50", Offset = "0x3833850", VA = "0x183834E50")]
	public static PHLGPCMBMIF<TResource> EABJGAMPDAO<TResource, TId>(this ANMLBAEDBPO<TId, TResource> DKMHABFADGP, TId ICHIIHCEGJD, [Optional] Func<TId, CancellationToken, Task<TResource>>? DFECANMALFC) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class HPNLIGGDMKF
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class ALFNHDCFHPG<T> : NPLKCODGFBP<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> BBNIIHNELDP
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ECHAPNAJEJF<T?> OGFOLAGDOLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x50870C0", Offset = "0x5085AC0", VA = "0x1850870C0")]
		public ALFNHDCFHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "10")]
		protected override void MMDAGHKNPCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class HFBDOBBPOFM<T> : NPLKCODGFBP<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T JLNDJOILDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? DGOJBIDGDHB;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> BBNIIHNELDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override ECHAPNAJEJF<T> OGFOLAGDOLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x9B22C0", Offset = "0x9B0CC0", VA = "0x1809B22C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x494AAB0", Offset = "0x49494B0", VA = "0x18494AAB0")]
		public HFBDOBBPOFM(T CPNFMFAECNK, Action<T>? APIACJCBFLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x494A8C0", Offset = "0x49492C0", VA = "0x18494A8C0", Slot = "10")]
		protected override void MMDAGHKNPCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class HDNANBIGMDF<T> : NPLKCODGFBP<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> BBNIIHNELDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override ECHAPNAJEJF<T> OGFOLAGDOLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x4942890", Offset = "0x4941290", VA = "0x184942890")]
		public HDNANBIGMDF(Exception CHDFBHPMACH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "10")]
		protected override void MMDAGHKNPCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class NBONJPGKICI<T> : NPLKCODGFBP<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct IKFAGMCBHGO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<PHLGPCMBMIF<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<PHLGPCMBMIF<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4A86C90", Offset = "0x4A85690", VA = "0x184A86C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4A87670", Offset = "0x4A86070", VA = "0x184A87670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct BNKANPIOKAK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<PHLGPCMBMIF<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<PHLGPCMBMIF<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x64B5AC0", Offset = "0x64B44C0", VA = "0x1864B5AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x64B5D50", Offset = "0x64B4750", VA = "0x1864B5D50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<PHLGPCMBMIF<T>> ODADOMDAMOI;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> BBNIIHNELDP
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override ECHAPNAJEJF<T> OGFOLAGDOLH
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x518E3E0", Offset = "0x518CDE0", VA = "0x18518E3E0")]
		public NBONJPGKICI(Task<PHLGPCMBMIF<T>> GLCABFFLNII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x518E070", Offset = "0x518CA70", VA = "0x18518E070", Slot = "10")]
		protected override void MMDAGHKNPCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x518E270", Offset = "0x518CC70", VA = "0x18518E270")]
		[AsyncStateMachine(typeof(NBONJPGKICI<>.IKFAGMCBHGO))]
		[CompilerGenerated]
		internal static Task<T> PNNMBNJAOCO(Task<PHLGPCMBMIF<T>> GLCABFFLNII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x518DE20", Offset = "0x518C820", VA = "0x18518DE20")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(NBONJPGKICI<>.BNKANPIOKAK))]
		internal static Task IONMFAFPGNA(Task<PHLGPCMBMIF<T>> GLCABFFLNII)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class PEKFAIMCLFG<TIn, TOut> : NPLKCODGFBP<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct AMPKCJMIJGO : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x508FE70", Offset = "0x508E870", VA = "0x18508FE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x47BEBB0", Offset = "0x47BD5B0", VA = "0x1847BEBB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly PHLGPCMBMIF<TIn> MEMNKOBFLOJ;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> BBNIIHNELDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override ECHAPNAJEJF<TOut> OGFOLAGDOLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x53CE410", Offset = "0x53CCE10", VA = "0x1853CE410")]
		public PEKFAIMCLFG(PHLGPCMBMIF<TIn> OMOJGIGGBNC, Func<TIn, TOut> EONHCDHECFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x53CE0C0", Offset = "0x53CCAC0", VA = "0x1853CE0C0", Slot = "10")]
		protected override void MMDAGHKNPCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x53CE290", Offset = "0x53CCC90", VA = "0x1853CE290")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(PEKFAIMCLFG<, >.AMPKCJMIJGO))]
		internal static Task<TOut> NKJHPLBINKL(Task<TIn> KECPPNPBPGD, Func<TIn, TOut> EONHCDHECFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x36A4580", Offset = "0x36A2F80", VA = "0x1836A4580")]
	public static PHLGPCMBMIF<T> KPJGFDDMHFP<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x36A44D0", Offset = "0x36A2ED0", VA = "0x1836A44D0")]
	public static PHLGPCMBMIF<T> DJGKMABPGCO<T>(T FFBEKAFHIDB, [Optional] Action<T>? APIACJCBFLM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x36A4440", Offset = "0x36A2E40", VA = "0x1836A4440")]
	public static PHLGPCMBMIF<T> DBBHOIENFDG<T>(Exception CHDFBHPMACH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x36A4440", Offset = "0x36A2E40", VA = "0x1836A4440")]
	public static PHLGPCMBMIF<T> OHOOKKAIIOB<T>(Task<PHLGPCMBMIF<T>> GLCABFFLNII) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x33B88C0", Offset = "0x33B72C0", VA = "0x1833B88C0")]
	public static PHLGPCMBMIF<TOut> GKBGOMKDLDP<TOut, TIn>(PHLGPCMBMIF<TIn> ENNBIIMEOCP, Func<TIn, TOut> EONHCDHECFJ) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class NPLKCODGFBP<T> : PHLGPCMBMIF<T>, ICABHIKAJNJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string OIGKKNMCLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly DLHGENCNAGI DJKDIEEHNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool AGGPBOPKIOC;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool IFMEABDJOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xBFFCE0", Offset = "0xBFE6E0", VA = "0x180BFFCE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> BBNIIHNELDP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract ECHAPNAJEJF<T> OGFOLAGDOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x51C95B0", Offset = "0x51C7FB0", VA = "0x1851C95B0")]
	public NPLKCODGFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x51C92A0", Offset = "0x51C7CA0", VA = "0x1851C92A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void MMDAGHKNPCO();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class OPDJODEMNPF<TTask, T> : NPLKCODGFBP<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class HGDJFEFMCLH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
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
			public HGDJFEFMCLH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3EB6AA0", Offset = "0x3EB54A0", VA = "0x183EB6AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3EB6FF0", Offset = "0x3EB59F0", VA = "0x183EB6FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public OPDJODEMNPF<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public HGDJFEFMCLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4952B60", Offset = "0x4951560", VA = "0x184952B60")]
		[AsyncStateMachine(typeof(OPDJODEMNPF<, >.HGDJFEFMCLH.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> HFMGOMMOAAC(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> GLCABFFLNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource DBBALKKKOMJ;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> BBNIIHNELDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override ECHAPNAJEJF<T> OGFOLAGDOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x532D670", Offset = "0x532C070", VA = "0x18532D670")]
	protected OPDJODEMNPF(TTask GLCABFFLNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x532D420", Offset = "0x532BE20", VA = "0x18532D420", Slot = "10")]
	protected override void MMDAGHKNPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T PNGGPEMMAKK(TTask OGGJOOOAAOE);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void INJOKLOEEKC();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EMBLGDDBABF<T> : NPLKCODGFBP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly HDLBIOFLEHA<Task<T>> FJOOMOPICKB;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> BBNIIHNELDP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x438E610", Offset = "0x438D010", VA = "0x18438E610", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override ECHAPNAJEJF<T> OGFOLAGDOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x438E660", Offset = "0x438D060", VA = "0x18438E660")]
	public EMBLGDDBABF(HDLBIOFLEHA<Task<T>> HCHAKAIHHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x438E5F0", Offset = "0x438CFF0", VA = "0x18438E5F0", Slot = "10")]
	protected override void MMDAGHKNPCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class DKINOIJDNNI
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName GGDAKJDJANF;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> EPEBNKHFNJP;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x78CEE80", Offset = "0x78CD880", VA = "0x1878CEE80")]
	public static int KOONKMNPJDB(this BOEHEEKCPHB NKAPLMFMNEL, IncrementalHash ALFFJDGFOGF, byte[] JLCJKMMIINA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x78CEA60", Offset = "0x78CD460", VA = "0x1878CEA60")]
	public static bool FFDKPAHHOFJ([CanBeNull] this BOEHEEKCPHB NKAPLMFMNEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x78CE750", Offset = "0x78CD150", VA = "0x1878CE750")]
	public static bool FFDKPAHHOFJ([CanBeNull] this BOEHEEKCPHB NKAPLMFMNEL, [Out] string LPNLOGECJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x78CEAC0", Offset = "0x78CD4C0", VA = "0x1878CEAC0")]
	public static bool FFDKPAHHOFJ([CanBeNull] this BOEHEEKCPHB NKAPLMFMNEL, IncrementalHash ALFFJDGFOGF, byte[] JLCJKMMIINA, [Out] string LPNLOGECJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x78CEDF0", Offset = "0x78CD7F0", VA = "0x1878CEDF0")]
	private static bool FMJMHCBFHOL(byte[] GJDLFGAFDDF, Span<byte> FEILFEBAKAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class GEMLAKMJCAM
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x78D0760", Offset = "0x78CF160", VA = "0x1878D0760")]
	public static int LOCFFLNDOMN(HashAlgorithmName DHBOPOHKONE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x78D0500", Offset = "0x78CEF00", VA = "0x1878D0500")]
	public static int KOONKMNPJDB(this HGFLIKCPNJO ILFKCAJNMIF, byte[] EFGCIHFLGDC, IncrementalHash ALFFJDGFOGF, byte[] CDPPGIEANFD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HGFLIKCPNJO
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash ALFFJDGFOGF);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BOEHEEKCPHB : HGFLIKCPNJO
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] AGHEHFMAGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] IPJOJMGIIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class EEGOGAGFPIH
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool NCKFNDGILNM;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> COEPGOBJGFK;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> IEODMKFJCBD;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding OKEFNEDLKCG;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> GKOFJPGCDEJ;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x34B6870", Offset = "0x34B5270", VA = "0x1834B6870")]
	public static void MJGOGBBFCKL<T>(this IncrementalHash HGGADFFGMAK, [CanBeNull] T ANAFMCCHAKO) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x34B67E0", Offset = "0x34B51E0", VA = "0x1834B67E0")]
	public static void BJEFOGALEJG<T>(this IncrementalHash HGGADFFGMAK, [CanBeNull] T ILFKCAJNMIF) where T : HGFLIKCPNJO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x34B62C0", Offset = "0x34B4CC0", VA = "0x1834B62C0")]
	public static void AAKCOHOIPLH<T>(this IncrementalHash HGGADFFGMAK, [CanBeNull] IList<T> MPGJPBJBFLL) where T : HGFLIKCPNJO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x78CF640", Offset = "0x78CE040", VA = "0x1878CF640")]
	private static bool GGJDPGHGBDA([CanBeNull] HGFLIKCPNJO ILFKCAJNMIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x78CF900", Offset = "0x78CE300", VA = "0x1878CF900")]
	public static void MNLJNBKONIP(this IncrementalHash ALFFJDGFOGF, string? FFEOABLDJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x78CF6D0", Offset = "0x78CE0D0", VA = "0x1878CF6D0")]
	public static void IGBAKMPBPPN(this IncrementalHash ALFFJDGFOGF, long HHDEGMLEGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x78CFE10", Offset = "0x78CE810", VA = "0x1878CFE10")]
	public static void PFOIAIPLKBJ(this IncrementalHash ALFFJDGFOGF, int KOICMDKJAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x78CF470", Offset = "0x78CDE70", VA = "0x1878CF470")]
	public static void EKLBMHBNOPA(this IncrementalHash ALFFJDGFOGF, short IADKAALIKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x78CFD00", Offset = "0x78CE700", VA = "0x1878CFD00")]
	public static void NMFGHMLGKMM(this IncrementalHash ALFFJDGFOGF, byte MIAOPAPFBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x78CF0B0", Offset = "0x78CDAB0", VA = "0x1878CF0B0")]
	public static void ACGLLLAGEBG(this IncrementalHash ALFFJDGFOGF, bool MMBHMLAIEOG, bool FPHOJAOOBII = false, bool HNEPGOICPHO = false, bool NHGLBHGIOCF = false, bool CFPAKPADNEJ = false, bool MMBFFOELDMK = false, bool MDJCOBLMMIO = false, bool HLOCFHFPOOH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x34B6930", Offset = "0x34B5330", VA = "0x1834B6930")]
	public static void OJOMFMJMFAH<T>(this IncrementalHash ALFFJDGFOGF, T PMMCFCOBIDM) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x78CF410", Offset = "0x78CDE10", VA = "0x1878CF410")]
	public static void DNLJHADOFNH(this IncrementalHash ALFFJDGFOGF, float HAMENNAJFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x78CF220", Offset = "0x78CDC20", VA = "0x1878CF220")]
	public static void AGGGIMHIEMJ(this IncrementalHash ALFFJDGFOGF, ulong IMBIEFNDODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x78CF280", Offset = "0x78CDC80", VA = "0x1878CF280")]
	public static void CANNEGNAJKD(this IncrementalHash ALFFJDGFOGF, uint GIIJHGJOCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x78CF8A0", Offset = "0x78CE2A0", VA = "0x1878CF8A0")]
	public static void JPFLLFMPKFD(this IncrementalHash ALFFJDGFOGF, ushort EDANOAPDNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x78CF2E0", Offset = "0x78CDCE0", VA = "0x1878CF2E0")]
	public static void CHKLEAOPILN(this IncrementalHash ALFFJDGFOGF, Vector3 KBPAOOJIBIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class JOKPELABNOA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x78D22F0", Offset = "0x78D0CF0", VA = "0x1878D22F0")]
	public JOKPELABNOA(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class AJOBOFBDIHB
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void KLNLFIJLOIO(ushort PNAEHLHLOIM, ushort MJAKJBJJJEF, ushort IKEMIIBHOHA, ushort LEEFLNNOPJJ);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void NCLBEHJGDFG(ushort OCIHJPDEMPL, ushort JALLJLEANPG);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void KIFPKMJKFPH();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort CDPNJBDKKPK = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	protected AJOBOFBDIHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class GFFBHOIPGKB<T> : AJOBOFBDIHB where T : GFFBHOIPGKB<T>.OPIELJCFLOK
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface OPIELJCFLOK
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		NCLBEHJGDFG HNDOEMHOLHO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		NCLBEHJGDFG EBNHLLJLAFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		KIFPKMJKFPH FLCBNGHFFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> DCBEFNFIMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private KIFPKMJKFPH OJPFFJEJLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private KIFPKMJKFPH KJNNOPBFFGN;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool FOPMADBCIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA45A60", Offset = "0xA44460", VA = "0x180A45A60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9BABA0", Offset = "0x9B95A0", VA = "0x1809BABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort PPOLDPHCHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x488F840", Offset = "0x488E240", VA = "0x18488F840")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x488EA00", Offset = "0x488D400", VA = "0x18488EA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort DELMEMGCJKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x488E9E0", Offset = "0x488D3E0", VA = "0x18488E9E0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x488EA10", Offset = "0x488D410", VA = "0x18488EA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort FIOMDCMDEML
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xD56620", Offset = "0xD55020", VA = "0x180D56620")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xD56730", Offset = "0xD55130", VA = "0x180D56730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort EFCFBPIJHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x488E9F0", Offset = "0x488D3F0", VA = "0x18488E9F0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x488F790", Offset = "0x488E190", VA = "0x18488F790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool HLHLLNMKMFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x16BB290", Offset = "0x16B9C90", VA = "0x1816BB290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool BOANOENPKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xE115C0", Offset = "0xE0FFC0", VA = "0x180E115C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KLNLFIJLOIO NIEFGPMBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x488F6F0", Offset = "0x488E0F0", VA = "0x18488F6F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x488F7A0", Offset = "0x488E1A0", VA = "0x18488F7A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x488F580", Offset = "0x488DF80", VA = "0x18488F580")]
	private T FHOMHFLAEOO(ushort LJFHNKFBFBH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x488F4C0", Offset = "0x488DEC0", VA = "0x18488F4C0")]
	private T DOFLACFMAKD(ushort LJFHNKFBFBH, ushort JPEKINOHDFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x488F690", Offset = "0x488E090", VA = "0x18488F690")]
	protected T INIAAEPODCI(uint OCKKOFAJEIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x488FAE0", Offset = "0x488E4E0", VA = "0x18488FAE0")]
	protected GFFBHOIPGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x488F9D0", Offset = "0x488E3D0", VA = "0x18488F9D0")]
	public void NNHFPDCAPDD(ushort AMCEBBJJOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x488F970", Offset = "0x488E370", VA = "0x18488F970")]
	public void NNHFPDCAPDD(ushort AMCEBBJJOIK, ushort ICNDIKCJJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x488F860", Offset = "0x488E260", VA = "0x18488F860", Slot = "4")]
	protected virtual void NNHFPDCAPDD(uint ICFHHKLOGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x488EA20", Offset = "0x488D420", VA = "0x18488EA20")]
	protected void CLJMCBOPJPH(uint ICFHHKLOGAJ, uint MGBGBLENIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x488FA10", Offset = "0x488E410", VA = "0x18488FA10")]
	protected void OEHGLAJAJOB(ushort LJFHNKFBFBH, ushort JPEKINOHDFE, T JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x488F630", Offset = "0x488E030", VA = "0x18488F630")]
	private void INHAJCEGGHE(uint OCKKOFAJEIA, T JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x488F250", Offset = "0x488DC50", VA = "0x18488F250")]
	protected void DJNJFDAKGDK(float GFOGDPEAFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x488FAD0", Offset = "0x488E4D0", VA = "0x18488FAD0")]
	protected uint PPGGIPCLKDJ(ushort LJFHNKFBFBH, ushort JPEKINOHDFE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x488F850", Offset = "0x488E250", VA = "0x18488F850")]
	protected ushort MAGPDLNMLHC(uint HCEDLCAIHDI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x488FAC0", Offset = "0x488E4C0", VA = "0x18488FAC0")]
	protected ushort OHNCPEEAIFF(uint HCEDLCAIHDI)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class IMGIFLCKGEF : GFFBHOIPGKB<IMGIFLCKGEF.DOJANEGFNJF>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class DOJANEGFNJF : OPIELJCFLOK
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public NCLBEHJGDFG HNDOEMHOLHO
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public NCLBEHJGDFG EBNHLLJLAFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public KIFPKMJKFPH FLCBNGHFFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x9B0460", Offset = "0x9AEE60", VA = "0x1809B0460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public DOJANEGFNJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x78D1FE0", Offset = "0x78D09E0", VA = "0x1878D1FE0")]
	public void APPCBMHACKN(ushort ANEAPOAAAGG, NCLBEHJGDFG NKHPBBMEIPM, NCLBEHJGDFG BCNKGBADMFM, KIFPKMJKFPH NMDKENMFPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x78D20C0", Offset = "0x78D0AC0", VA = "0x1878D20C0")]
	public void APPCBMHACKN(ushort LJFHNKFBFBH, ushort JPEKINOHDFE, NCLBEHJGDFG NKHPBBMEIPM, NCLBEHJGDFG BCNKGBADMFM, KIFPKMJKFPH NMDKENMFPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x78D21A0", Offset = "0x78D0BA0", VA = "0x1878D21A0")]
	public void IPDLKHCHONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x78D21F0", Offset = "0x78D0BF0", VA = "0x1878D21F0")]
	protected IMGIFLCKGEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class OFKPFFCELOF : IMGIFLCKGEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool ALAMEHOPMFM;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool BHLAOEGENBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xBAD060", Offset = "0xBABA60", VA = "0x180BAD060")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xC78470", Offset = "0xC76E70", VA = "0x180C78470")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x78D2990", Offset = "0x78D1390", VA = "0x1878D2990")]
	public void ELAEPFFNBKM(ushort EANODOJHOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x78D29F0", Offset = "0x78D13F0", VA = "0x1878D29F0")]
	public void ELAEPFFNBKM(ushort EANODOJHOGG, ushort HKBFDNEHDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x78D21F0", Offset = "0x78D0BF0", VA = "0x1878D21F0")]
	public OFKPFFCELOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class HBGOKGCEFLF<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class EALPFFJOKIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode IJPDNJELPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode HGBJMKAPAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CNFIJGMLKJH NMGLJLCLAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<CNFIJGMLKJH> OEBLNEAEIAL;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EALPFFJOKIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct CNFIJGMLKJH : IComparable<CNFIJGMLKJH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int KLEICHAFCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant DIGPGOEMONK;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1581470", Offset = "0x157FE70", VA = "0x181581470")]
		public CNFIJGMLKJH(int KLEICHAFCLM, TClaimant DIGPGOEMONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x65BF750", Offset = "0x65BE150", VA = "0x1865BF750")]
		public bool DLBAABDIEAK([In] CNFIJGMLKJH OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x65BF7B0", Offset = "0x65BE1B0", VA = "0x1865BF7B0")]
		public bool GLKEDHCMJNM([In] CNFIJGMLKJH OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x65BF740", Offset = "0x65BE140", VA = "0x1865BF740", Slot = "4")]
		public int CompareTo(CNFIJGMLKJH OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x65BF7C0", Offset = "0x65BE1C0", VA = "0x1865BF7C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum CBKKENMANHC
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class KBBPGMOFCCG : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public HBGOKGCEFLF<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public KBBPGMOFCCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x4DDE780", Offset = "0x4DDD180", VA = "0x184DDE780", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4DDE960", Offset = "0x4DDD360", VA = "0x184DDE960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x4DDE860", Offset = "0x4DDD260", VA = "0x184DDE860", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x47576C0", Offset = "0x47560C0", VA = "0x1847576C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly NHNHJDJGPJF<EALPFFJOKIC> KAHGHHOHCML;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly NHNHJDJGPJF<List<CNFIJGMLKJH>> MKKNDCDEIDB;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int NDGBBEBMJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> BNANIHPMFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, EALPFFJOKIC> NFHJJNFGMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private CBKKENMANHC NDELDEDNMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool FIMHNIKAAJI;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode KHAFIMLOKOF(TNode ABACLNNLPOO);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void PEAIOEIGLGC(TNode ABACLNNLPOO, TClaimant NFMBAIBKMGL, TClaimant COPCCNAGOGJ);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4934350", Offset = "0x4932D50", VA = "0x184934350")]
	public HBGOKGCEFLF(CBKKENMANHC NDELDEDNMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4933910", Offset = "0x4932310", VA = "0x184933910")]
	public void FNDOOIHIGKA(TNode ABACLNNLPOO, TNode MGKDKKMCMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4932ED0", Offset = "0x49318D0", VA = "0x184932ED0")]
	public void CLLECDIOOIF(TClaimant DIGPGOEMONK, TNode FDEDDBNOMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4933050", Offset = "0x4931A50", VA = "0x184933050", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4932E00", Offset = "0x4931800", VA = "0x184932E00")]
	private void CBCDJFNONKH(TClaimant DIGPGOEMONK, TNode MDLILHLCIHE, TNode FDEDDBNOMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4933E00", Offset = "0x4932800", VA = "0x184933E00")]
	private int IMIEPFGAMFD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4933250", Offset = "0x4931C50", VA = "0x184933250")]
	private void EEHKNLBFJBN(TClaimant DIGPGOEMONK, TNode MNDODOOKJPE, TNode OCMOGBOHIDA, int PDNHJOHNGJH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4933F60", Offset = "0x4932960", VA = "0x184933F60")]
	private void NGFEIEPPHBG(CNFIJGMLKJH LNEJMLIPAFH, EALPFFJOKIC HPKAFPMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4932B20", Offset = "0x4931520", VA = "0x184932B20")]
	private void CBBNHJCDEAB(TClaimant DIGPGOEMONK, TNode MNDODOOKJPE, TNode OCMOGBOHIDA, int PDNHJOHNGJH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x49329F0", Offset = "0x49313F0", VA = "0x1849329F0")]
	private void BENIDPGBCNH(CNFIJGMLKJH LNEJMLIPAFH, TNode ABACLNNLPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4933AE0", Offset = "0x49324E0", VA = "0x184933AE0")]
	private void HMBOMNJMLAB(CNFIJGMLKJH LNEJMLIPAFH, EALPFFJOKIC HPKAFPMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4934030", Offset = "0x4932A30", VA = "0x184934030")]
	private void OFDDMIHABCO(EALPFFJOKIC HPKAFPMNGAI, bool CFPKDEOEMDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x49335A0", Offset = "0x4931FA0", VA = "0x1849335A0")]
	private void FMPGLLLNBPI(EALPFFJOKIC HPKAFPMNGAI, TNode MGKDKKMCMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4933E70", Offset = "0x4932870", VA = "0x184933E70")]
	[IteratorStateMachine(typeof(HBGOKGCEFLF<, >.KBBPGMOFCCG))]
	private IEnumerable<TNode> INNIGKHKLNB(TNode MNDODOOKJPE, TNode OCMOGBOHIDA, bool NBJJHAFDHCP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x49339D0", Offset = "0x49323D0", VA = "0x1849339D0")]
	private EALPFFJOKIC HGIDBJJECFC(TNode ABACLNNLPOO, TNode HGBJMKAPAJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4932870", Offset = "0x4931270", VA = "0x184932870")]
	private EALPFFJOKIC BCHIEABLKLK(TNode ABACLNNLPOO, TNode HGBJMKAPAJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4933C40", Offset = "0x4932640", VA = "0x184933C40")]
	private void IJJEAIGNFKD(EALPFFJOKIC HPKAFPMNGAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JLHAOJOBFEP<T> : IEnumerable<JLHAOJOBFEP<T>.ANGPIDIKIIC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct ANGPIDIKIIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T PPJFMHBDGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int DOAKEFBOPIA;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class AAAIBGNNLDG : IEnumerator<ANGPIDIKIIC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private JLHAOJOBFEP<T> NCNKGDJFDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int DOAKEFBOPIA;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x43A2520", Offset = "0x43A0F20", VA = "0x1843A2520", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public ANGPIDIKIIC GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x483A050", Offset = "0x4838A50", VA = "0x18483A050", Slot = "4")]
			get
			{
				return default(ANGPIDIKIIC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x483A010", Offset = "0x4838A10", VA = "0x18483A010")]
		public AAAIBGNNLDG(JLHAOJOBFEP<T> NCNKGDJFDBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4839F10", Offset = "0x4838910", VA = "0x184839F10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4401550", Offset = "0x43FFF50", VA = "0x184401550", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1073A10", Offset = "0x1072410", VA = "0x181073A10", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct DBLDMAFMEEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool KOHEOJNAMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T PPJFMHBDGNA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int MMJDAKGICKK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> LFKIBHOMNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private DBLDMAFMEEB[] PBEMKJMELPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int NKHPGMELFMD;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int DBGGBCKPDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xC976B0", Offset = "0xC960B0", VA = "0x180C976B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xE7FEF0", Offset = "0xE7E8F0", VA = "0x180E7FEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3EC87C0", Offset = "0x3EC71C0", VA = "0x183EC87C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A9A0", Offset = "0x4D093A0", VA = "0x184D0A9A0")]
	public JLHAOJOBFEP(int CIIHPLFOGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A150", Offset = "0x4D08B50", VA = "0x184D0A150")]
	public JLHAOJOBFEP(ANGPIDIKIIC[] CAMPLKMNOFK, bool AAHMFEMIJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4D09390", Offset = "0x4D07D90", VA = "0x184D09390")]
	public int GEOOEGJIIJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4D09450", Offset = "0x4D07E50", VA = "0x184D09450")]
	private int HJNMNEFOKAO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4D09340", Offset = "0x4D07D40", VA = "0x184D09340", Slot = "6")]
	protected virtual uint CPNJGJCMINP(uint ALFFJDGFOGF, T PPJFMHBDGNA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4D09880", Offset = "0x4D08280", VA = "0x184D09880")]
	public bool IEJEOFPMAAI(T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A030", Offset = "0x4D08A30", VA = "0x184D0A030")]
	public int MPLIDADKEKA(T PPJFMHBDGNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4D09940", Offset = "0x4D08340", VA = "0x184D09940")]
	public T LJEPDBELIAK(int DOAKEFBOPIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4D09A00", Offset = "0x4D08400", VA = "0x184D09A00")]
	public bool LKBNKEDGDPB(T PPJFMHBDGNA, bool KDMFIDBJNMJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4D09D50", Offset = "0x4D08750", VA = "0x184D09D50")]
	public bool LKBNKEDGDPB(T PPJFMHBDGNA, int DOAKEFBOPIA, bool KDMFIDBJNMJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4D092A0", Offset = "0x4D07CA0", VA = "0x184D092A0")]
	private int CJOBPBCMHMC(int FNEPEEDFAPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A0B0", Offset = "0x4D08AB0", VA = "0x184D0A0B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A0B0", Offset = "0x4D08AB0", VA = "0x184D0A0B0", Slot = "4")]
	private IEnumerator<ANGPIDIKIIC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class NHNHJDJGPJF<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> KBEOLPOGFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> GDCPGKDDFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int LPODCBGBMNF;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x51AEF40", Offset = "0x51AD940", VA = "0x1851AEF40")]
	public static NHNHJDJGPJF<T> LJLPIOKOCJE(int CIIHPLFOGKO = 0, int LPODCBGBMNF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x51AE9D0", Offset = "0x51AD3D0", VA = "0x1851AE9D0")]
	public static NHNHJDJGPJF<T> AGBJPJELMLE(int CIIHPLFOGKO = 0, int LPODCBGBMNF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x51AF530", Offset = "0x51ADF30", VA = "0x1851AF530")]
	public NHNHJDJGPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x51AF320", Offset = "0x51ADD20", VA = "0x1851AF320")]
	public NHNHJDJGPJF(int CIIHPLFOGKO, int LPODCBGBMNF = int.MaxValue, bool CEOIMHCFIDJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x51AED70", Offset = "0x51AD770", VA = "0x1851AED70")]
	public T KFLMIKHDEOF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x51AEC90", Offset = "0x51AD690", VA = "0x1851AEC90")]
	public void HPODIEKJDDB(T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x51AF220", Offset = "0x51ADC20", VA = "0x1851AF220")]
	private void MPCNOGNLHGN(T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x51AEC50", Offset = "0x51AD650", VA = "0x1851AEC50")]
	private void GODNFDBLBKG(T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x51AEAC0", Offset = "0x51AD4C0", VA = "0x1851AEAC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x51AF030", Offset = "0x51ADA30", VA = "0x1851AF030")]
	private void LKDCFGODMCI(IEnumerable<T> IOMEFCNHNJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class NBJGEGBJHCB<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> LCGNOGHMHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T LLNOLGFMOLC;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T NKDAIDJELLO
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x518D500", Offset = "0x518BF00", VA = "0x18518D500")]
	public bool EDHPJFLGKJG(T PPJFMHBDGNA, int KLEICHAFCLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x518D640", Offset = "0x518C040", VA = "0x18518D640")]
	public bool EPDPGJBDDAF(int KLEICHAFCLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x518DB00", Offset = "0x518C500", VA = "0x18518DB00")]
	public T JOKBONKAOMO(int NBMNEJLIOMH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x518D6E0", Offset = "0x518C0E0", VA = "0x18518D6E0")]
	private bool JMHDAEPMAIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x518DD10", Offset = "0x518C710", VA = "0x18518DD10")]
	public bool OCHHJJBEIMP(int KLEICHAFCLM, [Out] T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x518DD70", Offset = "0x518C770", VA = "0x18518DD70")]
	public NBJGEGBJHCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class ILPAFKPCPDJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct KHCLIKBPLOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T ABKPALEDJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int JEJIBJPMBDP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<KHCLIKBPLOJ> GNCABPMOJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T ACCLBJFHHNM;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3EC87C0", Offset = "0x3EC71C0", VA = "0x183EC87C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4A99520", Offset = "0x4A97F20", VA = "0x184A99520")]
	public bool EGACGLIMIFH(T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4A99910", Offset = "0x4A98310", VA = "0x184A99910")]
	public void HEHCILJMFIP(T PPJFMHBDGNA, int KLEICHAFCLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4A99200", Offset = "0x4A97C00", VA = "0x184A99200")]
	public bool CBCJJMKDJJC(T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4A99AA0", Offset = "0x4A984A0", VA = "0x184A99AA0")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4A99480", Offset = "0x4A97E80", VA = "0x184A99480")]
	public T CLKPJHDMFPK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4A98F00", Offset = "0x4A97900", VA = "0x184A98F00")]
	protected void AGKJNPLJIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4A99B40", Offset = "0x4A98540", VA = "0x184A99B40")]
	public ILPAFKPCPDJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
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
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x78D2CC0", Offset = "0x78D16C0", VA = "0x1878D2CC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x78D2F90", Offset = "0x78D1990", VA = "0x1878D2F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x78D2EA0", Offset = "0x78D18A0", VA = "0x1878D2EA0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x78D2C10", Offset = "0x78D1610", VA = "0x1878D2C10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x78D2EE0", Offset = "0x78D18E0", VA = "0x1878D2EE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x78D2DF0", Offset = "0x78D17F0", VA = "0x1878D2DF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x78D2B90", Offset = "0x78D1590", VA = "0x1878D2B90")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5598F80", Offset = "0x5597980", VA = "0x185598F80", Slot = "4")]
		public virtual T FEEGENICIPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class HIKJBKCFHEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Dictionary<byte, IJEBAEMCCAF> AHBOAILKCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly NHNHJDJGPJF<IJEBAEMCCAF> CNALBLMCELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool JBIOAPEJAHK;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public IJEBAEMCCAF DEJEKFOPAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 BLDKGKAHLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x14E3FA0", Offset = "0x14E29A0", VA = "0x1814E3FA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xC01020", Offset = "0xBFFA20", VA = "0x180C01020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private Vector2 MIPODGEFJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xC24660", Offset = "0xC23060", VA = "0x180C24660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 HODEHKNFBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x78D0990", Offset = "0x78CF390", VA = "0x1878D0990")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDC0", Offset = "0x9AD7C0", VA = "0x1809AEDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int PANJHCBEMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FC0", Offset = "0x9B59C0", VA = "0x1809B6FC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FE0", Offset = "0x9B59E0", VA = "0x1809B6FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x78D1860", Offset = "0x78D0260", VA = "0x1878D1860")]
	public HIKJBKCFHEH(Bounds OLLBGPBDDIA, Vector2[] LNMCCBPOMNJ, int GNKMHIGODMH, byte FNEPEEDFAPL, float DABGHBKEJKH = 0f, [Optional] NHNHJDJGPJF<IJEBAEMCCAF> CNALBLMCELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x78D0FF0", Offset = "0x78CF9F0", VA = "0x1878D0FF0")]
	public void NCOCBCOPBJE(Bounds OLLBGPBDDIA, Vector2[] LNMCCBPOMNJ, int GNKMHIGODMH, byte FNEPEEDFAPL, float DABGHBKEJKH = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x78D0F90", Offset = "0x78CF990", VA = "0x1878D0F90")]
	public IJEBAEMCCAF LNOOIGBEAOL(byte DOAKEFBOPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x78D0A70", Offset = "0x78CF470", VA = "0x1878D0A70")]
	public void HDOBJEHAGOB(Vector3 KKIJMCHODGC, float ICEJOLEOPJD, float FOFLGMLJCEC, List<byte> GKLGLMOGADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x78D1480", Offset = "0x78CFE80", VA = "0x1878D1480")]
	public void OLHLJFKGJDE(IJEBAEMCCAF.IDIFMOMJENH HBPMLBNNCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x78D08B0", Offset = "0x78CF2B0", VA = "0x1878D08B0")]
	public static int BFONGLAAIHL(Vector2[] LNMCCBPOMNJ, int GNKMHIGODMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x78D0B40", Offset = "0x78CF540", VA = "0x1878D0B40")]
	private IJEBAEMCCAF HKHLGLAOKJM(byte DOAKEFBOPIA, IJEBAEMCCAF.OEPKPFMHOCP GKGKPDAFABN, IJEBAEMCCAF HGBJMKAPAJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x78D14A0", Offset = "0x78CFEA0", VA = "0x1878D14A0")]
	private void PKNKLGKKHPF(IJEBAEMCCAF HGBJMKAPAJA, Vector2[] LNMCCBPOMNJ, int HKKAJBMNPGM, int AMAMOBMPMOC, int GPLFHPCEIDM, int AHOFOJJBGAL, float DABGHBKEJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x78D0D70", Offset = "0x78CF770", VA = "0x1878D0D70")]
	private void LJANLOIECDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x78D09B0", Offset = "0x78CF3B0", VA = "0x1878D09B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x78D0A10", Offset = "0x78CF410", VA = "0x1878D0A10", Slot = "1")]
	~HIKJBKCFHEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class IJEBAEMCCAF
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum OEPKPFMHOCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum IDIFMOMJENH
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
	public byte FIGDAIADJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 AAENOPNGINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 FPLMNCHJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 NBGHNGKCNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 ILCPHMIBLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public OEPKPFMHOCP PFEDDEPFDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public IJEBAEMCCAF LKNIONJKNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public List<IJEBAEMCCAF> PMDOEFADBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool KAIBJCCFFKO;

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x78D1FC0", Offset = "0x78D09C0", VA = "0x1878D1FC0")]
	public IJEBAEMCCAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x78D1E80", Offset = "0x78D0880", VA = "0x1878D1E80")]
	public void JLIGOJPFBFL(IJEBAEMCCAF CGGKEPFNHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	public void OLHLJFKGJDE(int LBBKJKPFDHM, IDIFMOMJENH HBPMLBNNCPF, int GMIJLFKOMMB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x78D1BF0", Offset = "0x78D05F0", VA = "0x1878D1BF0")]
	public void HDOBJEHAGOB(List<byte> GKLGLMOGADC, Vector3 KKIJMCHODGC, float ICEJOLEOPJD, float FOFLGMLJCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x78D1BC0", Offset = "0x78D05C0", VA = "0x1878D1BC0")]
	public bool FBBHEEDAGGG(Vector3 FJGNBGJJOPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x78D1E50", Offset = "0x78D0850", VA = "0x1878D1E50")]
	public bool HOILHLDGMCI(Vector3 FJGNBGJJOPK, float OACFNPENOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x78D1B30", Offset = "0x78D0530", VA = "0x1878D1B30")]
	public void ELAEPFFNBKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface IDHNNCKFICO
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	ToolHierarchyCache MMLDDJAEIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct HHGJPCMKKJA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private readonly List<Component> FMFEHIEKOMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly bool BOOGOKAEFOI;

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x16D9FD0", Offset = "0x16D89D0", VA = "0x1816D9FD0")]
			public HHGJPCMKKJA(List<Component> FMFEHIEKOMI, bool BOOGOKAEFOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x495F210", Offset = "0x495DC10", VA = "0x18495F210")]
			public EJPFOFELGAA<T> KCFKLFFNEEA()
			{
				return default(EJPFOFELGAA<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x495F270", Offset = "0x495DC70", VA = "0x18495F270", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x495F270", Offset = "0x495DC70", VA = "0x18495F270", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		public struct EJPFOFELGAA<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly List<Component> FMFEHIEKOMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly bool BOOGOKAEFOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private int DOAKEFBOPIA;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T GNNLOKFDOIK
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x436C050", Offset = "0x436AA50", VA = "0x18436C050", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x436BFE0", Offset = "0x436A9E0", VA = "0x18436BFE0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x436C020", Offset = "0x436AA20", VA = "0x18436C020")]
			public EJPFOFELGAA(List<Component> FMFEHIEKOMI, bool BOOGOKAEFOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x436BF10", Offset = "0x436A910", VA = "0x18436BF10", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x436BF20", Offset = "0x436A920", VA = "0x18436BF20", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x436BFD0", Offset = "0x436A9D0", VA = "0x18436BFD0", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x78D4980", Offset = "0x78D3380", VA = "0x1878D4980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x78D4680", Offset = "0x78D3080", VA = "0x1878D4680")]
		private void ELAEPFFNBKM(GameObject CLNPCGHJJNG, bool JDEIJIAFEMH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x78D45F0", Offset = "0x78D2FF0", VA = "0x1878D45F0")]
		public static void ELAEPFFNBKM(GameObject CLNPCGHJJNG, ToolHierarchyCache DKMHABFADGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x78D48E0", Offset = "0x78D32E0", VA = "0x1878D48E0")]
		public void PCGIPHNHPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x39C3A00", Offset = "0x39C2400", VA = "0x1839C3A00")]
		public void CEGHJJPHPFH<T>(Action<T> HNDDBOOOBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x39C3D00", Offset = "0x39C2700", VA = "0x1839C3D00")]
		public T NPBNMJDAJIG<T>(bool BOOGOKAEFOI = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x39C3C40", Offset = "0x39C2640", VA = "0x1839C3C40")]
		public HHGJPCMKKJA<T> NJPFGEKCOEO<T>(bool BOOGOKAEFOI = false) where T : class
		{
			return default(HHGJPCMKKJA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x78D4270", Offset = "0x78D2C70", VA = "0x1878D4270")]
		public List<Component> DPCNACAOGGO(Type OHCGINPDMEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x78D47F0", Offset = "0x78D31F0", VA = "0x1878D47F0", Slot = "4")]
		public bool Equals(ToolHierarchyCache CJBFFOKBLHB, ToolHierarchyCache CNBLFOFLDDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x78D4870", Offset = "0x78D3270", VA = "0x1878D4870", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache OIIGDBLKEDN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class IMDJAJIPIPA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int CIIHPLFOGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int KDBEFPKFDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private List<T> NOGFBEHEDEA;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x438E610", Offset = "0x438D010", VA = "0x18438E610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T AJHMAPOACNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4A9A680", Offset = "0x4A99080", VA = "0x184A9A680")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T IDBHEMOCKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x4A9AD70", Offset = "0x4A99770", VA = "0x184A9AD70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T LKCLBGOLDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x4A9A8A0", Offset = "0x4A992A0", VA = "0x184A9A8A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x4A9AE70", Offset = "0x4A99870", VA = "0x184A9AE70")]
	public IMDJAJIPIPA(int CIIHPLFOGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x4A9A9D0", Offset = "0x4A993D0", VA = "0x184A9A9D0")]
	public void HEHCILJMFIP(T LGAOMAAAEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x4A9AE10", Offset = "0x4A99810", VA = "0x184A9AE10")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4A9A590", Offset = "0x4A98F90", VA = "0x184A9A590")]
	public void ANADAMOHGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4A9ACA0", Offset = "0x4A996A0", VA = "0x184A9ACA0")]
	public void OBKMFCBEKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4A9AC90", Offset = "0x4A99690", VA = "0x184A9AC90")]
	public void IEEHGAGKPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4A9A940", Offset = "0x4A99340", VA = "0x184A9A940")]
	public List<T> GPKNGIMKJAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class JCIFFMNMFIG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private struct CMMGDFLBLMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int JEJIBJPMBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public T ABKPALEDJBA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Dictionary<object, CMMGDFLBLMN> LCGNOGHMHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EqualityComparer<T> ONKMALKALDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T LLNOLGFMOLC;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public virtual T NKDAIDJELLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xCA3D80", Offset = "0xCA2780", VA = "0x180CA3D80", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4C8DEC0", Offset = "0x4C8C8C0", VA = "0x184C8DEC0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool OALDOILAGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x4C8ED70", Offset = "0x4C8D770", VA = "0x184C8ED70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public object BLGFNOCGHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9B5530", Offset = "0x9B3F30", VA = "0x1809B5530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E100", Offset = "0x4C8CB00", VA = "0x184C8E100")]
	public bool EDHPJFLGKJG(T PPJFMHBDGNA, object GNAAILLDOKI, int KLEICHAFCLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4C8ECB0", Offset = "0x4C8D6B0", VA = "0x184C8ECB0")]
	public bool EPDPGJBDDAF(object GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4C91D60", Offset = "0x4C90760", VA = "0x184C91D60")]
	public bool OCHHJJBEIMP(object GNAAILLDOKI, [Out] T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x47BD200", Offset = "0x47BBC00", VA = "0x1847BD200")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4C8FA50", Offset = "0x4C8E450", VA = "0x184C8FA50")]
	private bool JMHDAEPMAIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4C92420", Offset = "0x4C90E20", VA = "0x184C92420")]
	public JCIFFMNMFIG()
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
